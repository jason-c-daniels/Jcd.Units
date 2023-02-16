using System.Diagnostics.SymbolStore;

namespace UnitGen;

public record BaseUnitDefinition
(
    string System,
    string UnitType,
    string UnitName,
    string UnitSymbol,
    bool UsesPrefixes,
    string BaseUnit,
    string Coefficient,
    string Offset,
    int SortIndex
)
{
    public bool IsBaseUnit => string.Compare(UnitName, BaseUnit, StringComparison.InvariantCultureIgnoreCase) == 0;
}