#region

using System.Collections.Generic;
using System.Linq;

using Jcd.RichEnumerations.Classes;

// ReSharper disable MemberCanBeProtected.Global

#endregion

namespace Jcd.Units;

/// <summary>
/// The base of all unit of measure enumerations in this library.
/// </summary>
/// <typeparam name="TEnumeration">The enumeration type.</typeparam>
/// <typeparam name="TEnumerated">The type of the enumerated members.</typeparam>
public abstract class UnitOfMeasureEnumeration<TEnumeration, TEnumerated> : RichEnumBase<TEnumeration, TEnumerated>
         where TEnumerated : IEquatable<TEnumerated>
       , IUnitOfMeasure<TEnumerated>
{
   static UnitOfMeasureEnumeration()
   {
      ByName   = All.ToDictionary(u => u.Name);
      BySymbol = All.ToDictionary(u => u.Symbol);
   }

   /// <summary>
   /// Looks up an enumerated unit of measure by name.
   /// </summary>
   public static IReadOnlyDictionary<string, TEnumerated> ByName { get; }

   /// <summary>
   /// Looks up an enumerated unit of measure by symbol.
   /// </summary>
   public static IReadOnlyDictionary<string, TEnumerated> BySymbol { get; }
}
