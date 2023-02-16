namespace UnitGen;

public record UnitDefinition
(
    string System, 
    string UnitType, 
    string Name,
    string Symbol, 
    string BaseUnit,
    string UnitCoefficient,
    string Offset,
    int UnitSortIndex,
    int PrefixSortIndex
)
{
    public bool IsBaseUnit => string.Compare(Name, BaseUnit, StringComparison.InvariantCultureIgnoreCase) == 0;
}