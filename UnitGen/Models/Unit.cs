#region

using JetBrains.Annotations;

using UnitGen.Services;

// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace UnitGen.Models;

[UsedImplicitly]
public record Unit
(
   string System
 , string UnitType
 , string UnitName
 , string UnitSymbol
 , string PrefixScale
 , string PrefixExponentsToInclude
 , string BaseUnitSystem
 , string BaseUnit
 , string Coefficient
 , string Offset
 , long SortIndex
)
{
   public bool IsBaseUnit
      => string.Compare(System,   BaseUnitSystem, StringComparison.InvariantCultureIgnoreCase) == 0
      && string.Compare(UnitName, BaseUnit,       StringComparison.InvariantCultureIgnoreCase) == 0;

   public bool UsesPrefixes => !string.IsNullOrWhiteSpace(PrefixScale);

   // ReSharper disable once MemberCanBePrivate.Global
   public bool IsDerivedUnit => !IsBaseUnit;
   public bool HasBaseUnitSubnamespace => System != BaseUnitSystem && IsDerivedUnit;

   public string BaseUnitSubnamespace
      => HasBaseUnitSubnamespace
            ? $"{BaseUnitSystem.MakeSymbolName()}"
            : "";
}