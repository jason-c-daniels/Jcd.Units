using UnitGen.Resources;
namespace UnitGen.CodeGenerators;

public class UnitTypeGenerator
{
    private string unitTypeTemplate;

    public UnitTypeGenerator()
    {
        unitTypeTemplate = ResourceHelper.ReadStringResource("UnitType.template");
    }
    public string Generate(string unitTypeName, string baseNamespace="Jcd.Units")
    {
        return unitTypeTemplate
            .Replace("$BaseNamespace$", baseNamespace)
            .Replace("$UnitTypeName$",unitTypeName);
    }
}