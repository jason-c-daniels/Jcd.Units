using UnitGen.CodeGenerators;

namespace UnitGen.Data;

public record Unit
(
    string System,
    string UnitType,
    string UnitName,
    string UnitSymbol,
    bool UsesPrefixes,
    string BaseUnitSystem,
    string BaseUnit,
    string Coefficient,
    string Offset,
    int SortIndex
)
{
    public bool IsBaseUnit => string.Compare(UnitName, BaseUnit, StringComparison.InvariantCultureIgnoreCase) == 0;
    public bool IsDerivedUnit => !IsBaseUnit;
    public bool HasBaseUnitSubnamespace => System != BaseUnitSystem && IsDerivedUnit;
    public string BaseUnitSubnamespace => HasBaseUnitSubnamespace ? $"{BaseUnitSystem.MakeSymbolName()}" : "";
}