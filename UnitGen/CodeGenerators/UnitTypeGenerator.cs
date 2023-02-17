using UnitGen.Data;
using UnitGen.Resources;
namespace UnitGen.CodeGenerators;

public class UnitTypeGenerator
{
    private const string DefaultBaseNamespace = "Jcd.Units.UnitTypes";
    private string unitTypeTemplate;

    public UnitTypeGenerator()
    {
        unitTypeTemplate = EmbeddedResource.ReadString("UnitType.template");
    }
    
    public string Generate(string unitTypeName, string baseNamespace=DefaultBaseNamespace)
    {
        return unitTypeTemplate
            .Replace("$BaseNamespace$", baseNamespace)
            .Replace("$UnitTypeName$",unitTypeName);
    }

    public string Generate(UnitType unitType, string baseNamespace=DefaultBaseNamespace)
    {
        return unitTypeTemplate
            .Replace("$BaseNamespace$", baseNamespace)
            .Replace("$UnitTypeName$",unitType.UnitTypeName);
    }
}