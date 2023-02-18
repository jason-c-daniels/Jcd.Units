using UnitGen.Data;
using UnitGen.Resources;
namespace UnitGen.CodeGenerators;

public class SourceCodeGenerator
{
    private const string DefaultBaseNamespace = "Jcd.Units.UnitTypes";
    private const string DefaultUnitOfMeasureNamespace = "Jcd.Units.UnitsOfMeasure";
    private string unitTypeTemplate;
    private string baseUnitTemplate;
    private string derivedUnitTemplate;
    private string enumerationTemplate;
    private Dictionary<string, Data.System> systemLookup;

    public SourceCodeGenerator(IEnumerable<Data.System> systems)
    {
        unitTypeTemplate = EmbeddedResource.ReadString("UnitType.template");
        baseUnitTemplate = EmbeddedResource.ReadString("BaseUnit.template");
        derivedUnitTemplate = EmbeddedResource.ReadString("DerivedUnit.template");
        enumerationTemplate = EmbeddedResource.ReadString("Enumeration.template");
        systemLookup = systems.ToDictionary(x => x.Name);
    }

    public string GenerateUnitType(UnitType unitType, string baseNamespace=DefaultBaseNamespace)
    {
        return unitTypeTemplate
            .Replace("$BaseNamespace$", baseNamespace)
            .Replace("$UnitTypeName$",unitType.UnitTypeName);
    }

    public string GenerateUnit(UnitDefinition unitDef, string baseNamespace = DefaultBaseNamespace)
    {
        var template = unitDef.IsBaseUnit ? baseUnitTemplate : derivedUnitTemplate;
        return template
            .Replace("$BaseNamespace$", baseNamespace)
            .Replace("$UnitType.TypeName$",unitDef.UnitType.UnitTypeName)
            .Replace("$Unit.Unit$",unitDef.UnitVarName)
            .Replace("$Unit.Name$",unitDef.UnitName)
            .Replace("$BaseUnitNamespacePrefix$", unitDef.BaseUnitNamespacePrefix)
            .Replace("$BaseUnit$",unitDef.BaseUnitName.MakeSymbolName())
            .Replace("$Symbol$",unitDef.Symbol)
            .Replace("$Coefficient$",unitDef.Coefficient)
            .Replace("$Offset$",unitDef.Offset)
            ;
    }
    
    public string GenerateEnumeration(UnitDefinition unitDef, string units, string baseNamespace=DefaultUnitOfMeasureNamespace)
    {
        return enumerationTemplate
            .Replace("$BaseNamespace$", baseNamespace)
            .Replace("$Enumeration$",unitDef.UnitType.EnumerationName)
            .Replace("$UnitType$",unitDef.UnitType.UnitTypeName)
            .Replace("$Subnamespace$",unitDef.Subnamespace)
            .Replace("$Units$",units.TrimEnd())
            ;
    }
}