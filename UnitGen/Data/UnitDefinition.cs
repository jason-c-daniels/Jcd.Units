using UnitGen.CodeGenerators;

namespace UnitGen.Data;

public record UnitDefinition
(
    System System,
    UnitType UnitType,
    Prefix Prefix,
    Unit Unit
)
{
    public bool IsBaseUnit => Unit.IsBaseUnit && Prefix.IsBasePrefix;
    public string UnitVarName => $"{UnitName}".MakeSymbolName();

    public string BaseUnitNamespacePrefix => 
        Unit.HasBaseUnitSubnamespace
            ? string.IsNullOrWhiteSpace(Unit.BaseUnitSubnamespace)
                ? $"{UnitType.EnumerationName}."
                : $"{Unit.BaseUnitSubnamespace}.{UnitType.EnumerationName}."
            : "";
    public string Coefficient => Prefix.IsBasePrefix ? Unit.Coefficient : Prefix.Coefficient;
    public string Offset => Unit.Offset;

    public string UnitName => IsBaseUnit ? Unit.UnitName : $"{Prefix.Name}{Unit.UnitName}";
    
    public string BaseUnitName => Prefix.IsBasePrefix 
        ? Unit.BaseUnit
        : $"{Prefix.BasePrefix}{Unit.UnitName}"
    ;
    public string Symbol => IsBaseUnit ? Unit.UnitSymbol : $"{Prefix.Symbol}{Unit.UnitSymbol}";
    public string Subnamespace => System.HasSubnamespace ? $".{System.Subnamespace}" : "";
}