namespace UnitGen.Data;

public record UnitDefinition
(
    System System,
    UnitType UnitType,
    Prefix Prefix,
    Unit Unit
)
{
    public bool IsBaseUnit =>
        string.Compare(Unit.UnitName, Unit.BaseUnit, StringComparison.InvariantCultureIgnoreCase) == 0;
}