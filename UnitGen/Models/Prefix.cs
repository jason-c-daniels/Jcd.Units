#region

using JetBrains.Annotations;

#endregion

namespace UnitGen.Models;

[UsedImplicitly]
public record Prefix
         (
         string Name
       , string Symbol
       , string BasePrefix
       , string Coefficient
       , int SortIndex
         )
{
   public bool IsBasePrefix => string.IsNullOrWhiteSpace(Name);
}
