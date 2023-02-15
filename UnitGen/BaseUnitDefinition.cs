using System.Diagnostics.SymbolStore;

namespace UnitGen;

public record BaseUnitDefinition
(
    string QuantityName, 
    string UnitName, 
    string UnitSymbol, 
    bool UsesPrefixes, 
    string BaseUnit, 
    string Coefficient, 
    string Offset,
    int SortIndex
);


public record UnitDefinition
(
    string System, 
    string QuantityName, 
    string Name, 
    string Symbol, 
    string BaseUnit,
    string Coefficient, 
    string Offset,
    int SortIndex
)
{
    public bool IsBaseUnit => string.Compare(Name, BaseUnit, StringComparison.InvariantCultureIgnoreCase) == 0;
}
