#region

using System.Diagnostics.CodeAnalysis;
using System.Text;

using UnitGen.Models;
using UnitGen.Repositories;
using UnitGen.Resources;

using FSS = UnitGen.Services.FileSystemService;

// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace UnitGen.Services;

[SuppressMessage("Usage", "CA2208:Instantiate argument exceptions correctly")]
public class SourceCodeGenerator
{
   private const string DefaultBaseNamespace = "Jcd.Units.UnitTypes";
   private const string DefaultUnitOfMeasureNamespace = "Jcd.Units.UnitsOfMeasure";
   private readonly string? _baseUnitTemplate;
   private readonly string? _derivedUnitNoCoefficientTemplate;
   private readonly string? _derivedUnitSynonymTemplate;
   private readonly string? _derivedUnitTemplate;
   private readonly string? _derivedUnitWithOffsetTemplate;
   private readonly string? _enumerationTemplate;
   private readonly string? _namespaceDocTemplate;
   private readonly Dictionary<string, Models.System> _systemLookup;
   
   private readonly UnitDefinitionRepository _unitDefRepo;
   private readonly string _unitsOfMeasureDir;
   private readonly string _unitTypesDir;
   private readonly string? _unitTypeTemplate;
   
   public SourceCodeGenerator(UnitDefinitionRepository unitDefRepo, string jcdUnitsDir)
   {
      _unitDefRepo = unitDefRepo;
      _unitTypesDir = Path.Combine(jcdUnitsDir,      "UnitTypes");
      _unitsOfMeasureDir = Path.Combine(jcdUnitsDir, "UnitsOfMeasure");
      
      // ReSharper disable NotResolvedInText
      _unitTypeTemplate = EmbeddedResource.ReadString("UnitType.template") ?? throw new ArgumentNullException("UnitType.template");
      
      _baseUnitTemplate = EmbeddedResource.ReadString("BaseUnit.template") ?? throw new ArgumentNullException("BaseUnit.template");
      
      _derivedUnitTemplate = EmbeddedResource.ReadString("DerivedUnit.template") ?? throw new ArgumentNullException("DerivedUnit.template");
      
      _derivedUnitWithOffsetTemplate = EmbeddedResource.ReadString("DerivedUnitWithOffset.template")
                                    ?? throw new ArgumentNullException("DerivedUnitWithOffset.template");
      
      _derivedUnitNoCoefficientTemplate = EmbeddedResource.ReadString("DerivedUnitNoCoefficient.template")
                                       ?? throw new ArgumentNullException("DerivedUnitNoCoefficient.template");
      
      _derivedUnitSynonymTemplate = EmbeddedResource.ReadString("DerivedUnitSynonym.template") ?? throw new ArgumentNullException("DerivedUnitSynonym.template");
      
      _enumerationTemplate = EmbeddedResource.ReadString("Enumeration.template") ?? throw new ArgumentNullException("Enumeration.template");
      
      _namespaceDocTemplate = EmbeddedResource.ReadString("UnitOfMeasure.NamespaceDoc.template")
                           ?? throw new ArgumentNullException("UnitOfMeasure.NamespaceDoc.template");
      
      // ReSharper restore NotResolvedInText
      
      _systemLookup = unitDefRepo.SystemRepo.GetAll().ToDictionary(x => x.Name);
   }
   
   private string GenerateUnitType(UnitType unitType, string baseNamespace = DefaultBaseNamespace)
   {
      return _unitTypeTemplate!.Replace("$BaseNamespace$", baseNamespace)
                               .Replace("$Description$",  unitType.Description)
                               .Replace("$UnitTypeName$", unitType.UnitTypeName);
   }
   
   private string GenerateUnit(UnitDefinition unitDef, string baseNamespace = DefaultBaseNamespace)
   {
      var hasOffset = !double.TryParse(unitDef.Offset, out var offset) || offset != 0.0;
      
      // ReSharper disable once CompareOfFloatsByEqualityOperator
      var hasCoefficient = !double.TryParse(unitDef.Coefficient, out var coefficient) || coefficient != 1.0;
      var template = _baseUnitTemplate;
      
      if (!unitDef.IsBaseUnit)
      {
         if (!hasCoefficient && !hasOffset)
         {
            template = _derivedUnitSynonymTemplate;
         }
         else if (!hasCoefficient && hasOffset)
         {
            template = _derivedUnitNoCoefficientTemplate;
         }
         else if (hasCoefficient && hasOffset)
         {
            template = _derivedUnitWithOffsetTemplate;
         }
         else if (hasCoefficient && !hasOffset)
         {
            template = _derivedUnitTemplate;
         }
      }
      
      var baseSystem = _systemLookup[unitDef.Unit.BaseUnitSystem];
      
      var baseSystemName = string.IsNullOrWhiteSpace(unitDef.BaseUnitNamespacePrefix)
                              ? string.Empty
                              : $"{baseSystem.Name} ";
      
      return template!.Replace("$System.Name$", unitDef.System.Name)
                      .Replace("$BaseNamespace$",           baseNamespace)
                      .Replace("$UnitType.TypeName$",       unitDef.UnitType.UnitTypeName)
                      .Replace("$Unit.Unit$",               unitDef.UnitVarName)
                      .Replace("$Unit.Name$",               unitDef.UnitName)
                      .Replace("$BaseUnitNamespacePrefix$", unitDef.BaseUnitNamespacePrefix)
                      .Replace("$BaseUnit.Name$",           unitDef.BaseUnitName)
                      .Replace("$BaseUnit.System$",         baseSystemName)
                      .Replace("$BaseUnit$",                unitDef.BaseUnitName.MakeSymbolName())
                      .Replace("$Symbol$",                  unitDef.Symbol)
                      .Replace("$Coefficient$",             unitDef.Coefficient)
                      .Replace("$Offset$",                  unitDef.Offset);
   }
   
   private string GenerateEnumeration(UnitDefinition unitDef, string units, string baseNamespace = DefaultUnitOfMeasureNamespace)
   {
      return _enumerationTemplate!.Replace("$BaseNamespace$", baseNamespace)
                                  .Replace("$System.Description$", unitDef.System.Description)
                                  .Replace("$Enumeration$",        unitDef.UnitType.EnumerationName)
                                  .Replace("$UnitType.Name$",      unitDef.UnitType.Name)
                                  .Replace("$UnitType.TypeName$",  unitDef.UnitType.UnitTypeName)
                                  .Replace("$Subnamespace$",       unitDef.Subnamespace)
                                  .Replace("$Units$",              units.TrimEnd());
   }
   
   private string GenerateUnitOfMeasureNamespaceDoc(string systemName, string subnamespaceName, string baseNamespace = DefaultUnitOfMeasureNamespace)
   {
      systemName = string.IsNullOrWhiteSpace(systemName)
                      ? systemName
                      : $"{systemName} ";
      
      return _namespaceDocTemplate!.Replace("$BaseNamespace$", baseNamespace).Replace("$Subnamespace$", subnamespaceName).Replace("$System.Name$", systemName);
   }
   
   public void CreateUnitTypeFiles()
   {
      var unitDefs = _unitDefRepo.GetUsedUnitTypes().ToList();
      
      FSS.CreateDirectoryIfNeeded(_unitTypesDir);
      
      // generate the individual unit type files in UnitTypes (in the output directory)
      foreach (var ut in unitDefs)
      {
         var unitTypeFileName = $"{ut.UnitTypeName}.cs";
         var unitTypeFilePath = Path.Combine(_unitTypesDir, unitTypeFileName);
         var fileContent = GenerateUnitType(ut);
         FSS.WriteFileContent(unitTypeFilePath, fileContent);
      }
   }
   
   public void CreateUnitOfMeasureFiles()
   {
      var systemGroupings = _unitDefRepo.GetSystemToUnitTypeToUnitDefinitionGroupings().ToList();
      
      FSS.CreateDirectoryIfNeeded(_unitsOfMeasureDir);
      
      foreach (var systemGrouping in systemGroupings)
      {
         var namespaceName = systemGrouping.Key.MakeSymbolName();
         var systemUnitsFolder = Path.Combine(_unitsOfMeasureDir, namespaceName);
         
         if (namespaceName.Trim().Length > 0)
         {
            FSS.CreateDirectoryIfNeeded(systemUnitsFolder);
         }
         
         var subnamespaceName = string.IsNullOrWhiteSpace(namespaceName)
                                   ? string.Empty
                                   : $".{namespaceName}";
         
         var namespaceDocFileContent = GenerateUnitOfMeasureNamespaceDoc(systemGrouping.Key, subnamespaceName);
         
         var namespaceDocPath = Path.Combine(systemUnitsFolder, "NamespaceDoc.cs");
         
         FSS.WriteFileContent(namespaceDocPath, namespaceDocFileContent);
         
         var uomWithNamespaceDir = string.IsNullOrWhiteSpace(namespaceName)
                                      ? _unitsOfMeasureDir
                                      : Path.Combine(_unitsOfMeasureDir, namespaceName);
         
         FSS.CreateDirectoryIfNeeded(uomWithNamespaceDir);
         var unitTypeGroupings = systemGrouping.ToList();
         
         foreach (var unitTypeGrouping in unitTypeGroupings)
         {
            GenerateUnitTypeGrouping(unitTypeGrouping, uomWithNamespaceDir);
         }
      }
   }
   
   private void GenerateUnitTypeGrouping(IGrouping<string, UnitDefinition> unitTypeGrouping, string uomWithNamespaceDir)
   {
      var ut = unitTypeGrouping.First().UnitType;
      
      var enumerationName = ut.EnumerationName;
      var enumerationFileName = $"{enumerationName}.cs";
      var enumerationsFilePath = Path.Combine(uomWithNamespaceDir, enumerationFileName);
      
      Console.WriteLine();
      Console.WriteLine("--------------------------------------------------------");
      
      var sortedGrouping = unitTypeGrouping.OrderBy(u => u.System.Name)
                                           .ThenBy(u => u.UnitType.Name)
                                           .ThenByDescending(u => u.IsBaseUnit)
                                           .ThenBy(u => u.Unit.SortIndex)
                                           .ThenBy(u => u.Prefix.SortIndex)
                                           .ToList();
      
      var sbUnits = new StringBuilder();
      
      var units = new Queue<UnitDefinition>(sortedGrouping);
      var generated = new HashSet<string>();
      
      while (units.Count > 0)
      {
         var unitDefinition = units.Dequeue();
         
         if (unitDefinition.IsBaseUnit || !unitDefinition.IsSameSystem || generated.Contains(unitDefinition.BaseUnitName))
         {
            Console.WriteLine($"Generating: {unitDefinition.Prefix.Name}{unitDefinition.Unit.UnitName}");
            sbUnits.AppendLine(GenerateUnit(unitDefinition));
            generated.Add(unitDefinition.UnitName);
         }
         else
         {
            units.Enqueue(unitDefinition);
         }
      }
      
      var enumerationFileContent = GenerateEnumeration(sortedGrouping[0], sbUnits.ToString());
      FSS.WriteFileContent(enumerationsFilePath, enumerationFileContent);
   }
}