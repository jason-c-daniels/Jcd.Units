#region

using JetBrains.Annotations;

#endregion

namespace UnitGen.Models;

[UsedImplicitly]
public record Prefix
         (
         string Scale
       , string Name
       , bool SpaceAfterPrefix
       , string Symbol
       , string BasePrefix
       , string Coefficient
       , int RelativeExponent
       , int SortIndex
         )
{
   public bool IsBasePrefix => string.IsNullOrWhiteSpace(Name);
   public bool IsPositiveExponent => RelativeExponent >= 0;
   public bool IsNegativeExponent => RelativeExponent < 0;

   public string EffectiveSymbol => string.IsNullOrWhiteSpace(Symbol)
            ? SpaceAfterPrefix ? $"{Name} " : Name
            : Symbol;
}
