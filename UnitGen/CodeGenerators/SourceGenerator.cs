using UnitGen.Data;
using UnitGen.Resources;
namespace UnitGen.CodeGenerators;

public class SourceCodeGenerator
{
    private const string DefaultBaseNamespace = "Jcd.Units.UnitTypes";
    private const string DefaultUnitOfMeasureNamespace = "Jcd.Units.UnitsOfMeasure";
    private readonly string? _unitTypeTemplate;
    private readonly string? _baseUnitTemplate;
    private readonly string? _derivedUnitTemplate;
    private readonly string? _enumerationTemplate;
    private Dictionary<string, Data.System> _systemLookup;

    public SourceCodeGenerator(IEnumerable<Data.System> systems)
    {
        _unitTypeTemplate = EmbeddedResource.ReadString("UnitType.template");
        _baseUnitTemplate = EmbeddedResource.ReadString("BaseUnit.template");
        _derivedUnitTemplate = EmbeddedResource.ReadString("DerivedUnit.template");
        _enumerationTemplate = EmbeddedResource.ReadString("Enumeration.template");
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
        return template
            .Replace("$BaseNamespace$", baseNamespace)
            .Replace("$UnitType.TypeName$",unitDef.UnitType.UnitTypeName)
            .Replace("$Unit.Unit$",unitDef.UnitVarName)
            .Replace("$Unit.Name$",unitDef.UnitName)
            .Replace("$BaseUnitNamespacePrefix$", unitDef.BaseUnitNamespacePrefix)
            .Replace("$BaseUnit.Name$",unitDef.BaseUnitName)
            .Replace("$BaseUnit.System$",unitDef.Unit.BaseUnitSystem)
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
}