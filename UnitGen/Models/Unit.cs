#region

using JetBrains.Annotations;

using UnitGen.Services;

#endregion

namespace UnitGen.Models;

[UsedImplicitly]
public record Unit
         (
         string System
       , string UnitType
       , string UnitName
       , string UnitSymbol
       , bool UsesPrefixes
       , string PrefixScale
       , string PrefixExponentsToInclude
       , string BaseUnitSystem
       , string BaseUnit
       , string Coefficient
       , string Offset
       , int SortIndex
         )
{
   public bool IsBaseUnit => string.Compare(UnitName, BaseUnit, StringComparison.InvariantCultureIgnoreCase) == 0;

   // ReSharper disable once MemberCanBePrivate.Global
   public bool IsDerivedUnit => !IsBaseUnit;
   public bool HasBaseUnitSubnamespace => System != BaseUnitSystem && IsDerivedUnit;
   public string BaseUnitSubnamespace => HasBaseUnitSubnamespace ? $"{BaseUnitSystem.MakeSymbolName()}" : "";
}
