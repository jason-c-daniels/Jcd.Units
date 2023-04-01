#region

using JetBrains.Annotations;

using UnitGen.Services;

// ReSharper disable MemberCanBePrivate.Global

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
   public bool IsBaseUnit => Prefix.IsBasePrefix && IsSameSystem && IsSameName;

   public bool IsSameSystem => Unit.System == Unit.BaseUnitSystem;

   public bool IsSameName => Unit.UnitName == Unit.BaseUnit;

   public string UnitVarName => $"{UnitName}".MakeSymbolName();

   public string BaseUnitNamespacePrefix =>
            Unit.HasBaseUnitSubnamespace && Prefix.IsBasePrefix && !IsSameSystem
                     ? string.IsNullOrWhiteSpace(Unit.BaseUnitSubnamespace)
                              ? $"UnitsOfMeasure.{UnitType.EnumerationName}."
                              : $"{Unit.BaseUnitSubnamespace}.{UnitType.EnumerationName}."
                     : "";

   public string Coefficient => Prefix.IsBasePrefix ? Unit.Coefficient : Prefix.Coefficient;
   public string Offset => Unit.Offset;

   public string PrefixSeparator => Prefix is { SpaceAfterPrefix: true, IsBasePrefix: false } ? " " : "";
   public string UnitName => $"{Prefix.Name}{PrefixSeparator}{Unit.UnitName}";

   public string BaseUnitName => IsBaseUnit
            ? UnitName
            : (!IsBaseUnit && !Unit.UsesPrefixes) || Prefix.IsBasePrefix
                     ? Unit.BaseUnit
                     : $"{Prefix.BasePrefix}{PrefixSeparator}{Unit.UnitName}";

   public string Symbol => $"{Prefix.EffectiveSymbol}{Unit.UnitSymbol}";

   public string Subnamespace => System.HasSubnamespace
            ? $".{System.Subnamespace}"
            : "";
}
