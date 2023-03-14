#region

using JetBrains.Annotations;

using UnitGen.Services;

#endregion

namespace UnitGen.Models;

[UsedImplicitly]
public record UnitDefinition
         (
         System System
       , UnitType UnitType
       , Prefix Prefix
       , Unit Unit
         )
{
   public bool IsBaseUnit => Unit.IsBaseUnit && Prefix.IsBasePrefix;
   public string UnitVarName => $"{UnitName}".MakeSymbolName();

   public string BaseUnitNamespacePrefix =>
            Unit.HasBaseUnitSubnamespace && Prefix.IsBasePrefix
                     ? string.IsNullOrWhiteSpace(Unit.BaseUnitSubnamespace)
                              ? $"UnitsOfMeasure.{UnitType.EnumerationName}."
                              : $"{Unit.BaseUnitSubnamespace}.{UnitType.EnumerationName}."
                     : "";

   public string Coefficient => Prefix.IsBasePrefix ? Unit.Coefficient : Prefix.Coefficient;
   public string Offset => Unit.Offset;

   public string PrefixSeparator => Prefix.SpaceAfterPrefix && !Prefix.IsBasePrefix ? " " : "";
   public string UnitName => IsBaseUnit ? Unit.UnitName : $"{Prefix.Name}{PrefixSeparator}{Unit.UnitName}";

   public string BaseUnitName => Prefix.IsBasePrefix
            ? Unit.BaseUnit
            : $"{Prefix.BasePrefix}{PrefixSeparator}{Unit.UnitName}";

   public string Symbol => IsBaseUnit ? Unit.UnitSymbol : $"{Prefix.EffectiveSymbol}{Unit.UnitSymbol}";

   public string Subnamespace => System.HasSubnamespace
            ? $".{System.Subnamespace}"
            : "";
}
