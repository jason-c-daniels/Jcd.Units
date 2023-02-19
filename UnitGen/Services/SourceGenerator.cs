using System.Text;
using UnitGen.Models;
using UnitGen.Resources;
using FSS=UnitGen.Services.FileSystemService;

namespace UnitGen.Services;

public class SourceCodeGenerator
{
    private const string DefaultBaseNamespace = "Jcd.Units.UnitTypes";
    private const string DefaultUnitOfMeasureNamespace = "Jcd.Units.UnitsOfMeasure";
    private readonly string? _unitTypeTemplate;
    private readonly string? _baseUnitTemplate;
    private readonly string? _derivedUnitTemplate;
    private readonly string? _enumerationTemplate;
    private readonly string? _namespaceDocTemplate;
    
    private Dictionary<string, Models.System> _systemLookup;

    public SourceCodeGenerator(IEnumerable<Models.System> systems)
    {
        _unitTypeTemplate = EmbeddedResource.ReadString("UnitType.template") ?? throw new ArgumentNullException("UnitType.template");
        _baseUnitTemplate = EmbeddedResource.ReadString("BaseUnit.template") ?? throw new ArgumentNullException("BaseUnit.template");
        _derivedUnitTemplate = EmbeddedResource.ReadString("DerivedUnit.template") ?? throw new ArgumentNullException("DerivedUnit.template");
        _enumerationTemplate = EmbeddedResource.ReadString("Enumeration.template") ?? throw new ArgumentNullException("Enumeration.template");
        _namespaceDocTemplate = EmbeddedResource.ReadString("UnitOfMeasure.NamespaceDoc.template") ?? throw new ArgumentNullException("UnitOfMeasure.NamespaceDoc.template");
        
        _systemLookup = systems.ToDictionary(x => x.Name);
    }

    public string GenerateUnitType(UnitType unitType, string baseNamespace = DefaultBaseNamespace)
    {
        return _unitTypeTemplate
            .Replace("$BaseNamespace$", baseNamespace)
            .Replace("$Description$",unitType.Description)
            .Replace("$UnitTypeName$",unitType.UnitTypeName);
    }

    public string GenerateUnit(UnitDefinition unitDef, string baseNamespace = DefaultBaseNamespace)
    {
        var template = unitDef.IsBaseUnit ? _baseUnitTemplate : _derivedUnitTemplate;

        var baseSystem = _systemLookup[unitDef.Unit.BaseUnitSystem];
        var baseSystemName = string.IsNullOrWhiteSpace(unitDef.BaseUnitNamespacePrefix)
            ? string.Empty
            : $"{baseSystem.Name} ";
        return template
            .Replace("$BaseNamespace$", baseNamespace)
            .Replace("$UnitType.TypeName$",unitDef.UnitType.UnitTypeName)
            .Replace("$Unit.Unit$",unitDef.UnitVarName)
            .Replace("$Unit.Name$",unitDef.UnitName)
            .Replace("$BaseUnitNamespacePrefix$", unitDef.BaseUnitNamespacePrefix)
            .Replace("$BaseUnit.Name$",unitDef.BaseUnitName)
            .Replace("$BaseUnit.System$",baseSystemName)
            .Replace("$BaseUnit$",unitDef.BaseUnitName.MakeSymbolName())
            .Replace("$Symbol$",unitDef.Symbol)
            .Replace("$Coefficient$",unitDef.Coefficient)
            .Replace("$Offset$",unitDef.Offset)
            ;
    }
    
    public string GenerateEnumeration(UnitDefinition unitDef, string units, string baseNamespace=DefaultUnitOfMeasureNamespace)
    {
        return _enumerationTemplate
            .Replace("$BaseNamespace$", baseNamespace)
            .Replace("$System.Description$", unitDef.System.Description)
            .Replace("$Enumeration$",unitDef.UnitType.EnumerationName)
            .Replace("$UnitType.Name$",unitDef.UnitType.Name)
            .Replace("$UnitType.TypeName$",unitDef.UnitType.UnitTypeName)
            .Replace("$Subnamespace$",unitDef.Subnamespace)
            .Replace("$Units$",units.TrimEnd())
            ;
    }

    public string GenerateUnitOfMeasureNamespaceDoc(string systemName, string subnamespaceName, string baseNamespace = DefaultUnitOfMeasureNamespace)
    {
        systemName = string.IsNullOrWhiteSpace(systemName) ? systemName : $"{systemName} ";
        return _namespaceDocTemplate
                .Replace("$BaseNamespace$", baseNamespace)
                .Replace("$Subnamespace$",subnamespaceName)
                .Replace("$System.Name$", systemName)
            ;
    }
    
    public void CreateUnitTypeFiles(string unitTypesDirPath, IEnumerable<UnitType> enumerable)
    {
        FSS.CreateDirectoryIfNeeded(unitTypesDirPath);

        // generate the individual unit type files in UnitTypes (in the output directory)
        foreach (var ut in enumerable)
        {
            var unitTypeFileName = $"{ut.UnitTypeName}.cs";
            var unitTypeFilePath = Path.Combine(unitTypesDirPath, unitTypeFileName);
            var fileContent = GenerateUnitType(ut);
            FSS.WriteFileContent(unitTypeFilePath, fileContent);
        }
    }

    public void CreateUnitOfMeasureFiles(string unitsOfMeasurePath, IEnumerable<IGrouping<string, IGrouping<string, UnitDefinition>>> groupings1)
    {
        FSS.CreateDirectoryIfNeeded(unitsOfMeasurePath);
        foreach (var systemGrouping in groupings1)
        {
            var namespaceName = systemGrouping.Key.MakeSymbolName();
            var systemUnitsFolder = Path.Combine(unitsOfMeasurePath, namespaceName);
            if (namespaceName.Trim().Length > 0)
            {
                FSS.CreateDirectoryIfNeeded(systemUnitsFolder);
            }

            var subnamespaceName = string.IsNullOrWhiteSpace(namespaceName) ? string.Empty : $".{namespaceName}";
            var namespaceDocFileContent =
                GenerateUnitOfMeasureNamespaceDoc(systemGrouping.Key, subnamespaceName);
            var namespaceDocPath = Path.Combine(systemUnitsFolder, "NamespaceDoc.cs");

            FSS.WriteFileContent(namespaceDocPath, namespaceDocFileContent);

            var uomWithNamespaceDir = string.IsNullOrWhiteSpace(namespaceName)
                ? unitsOfMeasurePath
                : Path.Combine(unitsOfMeasurePath, namespaceName);

            FSS.CreateDirectoryIfNeeded(uomWithNamespaceDir);

            foreach (var unitTypeGrouping in systemGrouping)
            {
                var ut = unitTypeGrouping.First().UnitType;
                var enumerationName = ut.EnumerationName;
                var enumerationFileName = $"{enumerationName}.cs";
                var enumerationsFilePath = Path.Combine(uomWithNamespaceDir, enumerationFileName);

                Console.WriteLine();
                Console.WriteLine($"--------------------------------------------------------");

                var sortedGrouping = unitTypeGrouping
                        .OrderBy(u => u.System.Name)
                        .ThenBy(u => u.UnitType.Name)
                        .ThenByDescending(u => u.IsBaseUnit)
                        .ThenBy(u => u.Unit.SortIndex)
                        .ThenBy(u => u.Prefix.SortIndex)
                        .ToList()
                    ;
                var sbUnits = new StringBuilder();
                foreach (var unitDefinition in sortedGrouping)
                {
                    Console.WriteLine($"Generating: {unitDefinition.Prefix.Name}{unitDefinition.Unit.UnitName}");
                    sbUnits.AppendLine(GenerateUnit(unitDefinition));
                }

                var enumerationFileContent = GenerateEnumeration(sortedGrouping[0], sbUnits.ToString());
                FSS.WriteFileContent(enumerationsFilePath, enumerationFileContent);
            }
        }
    }
    
}