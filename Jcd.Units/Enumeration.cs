#region

using System.Collections.Generic;
using System.Linq;

// ReSharper disable MemberCanBeProtected.Global

#endregion

namespace Jcd.Units;

/// <summary>
/// The base of all unit of measure enumerations in this library.
/// </summary>
/// <typeparam name="TEnumeration">The enumeration type.</typeparam>
/// <typeparam name="T">The type of the enumerated members.</typeparam>
public class Enumeration<TEnumeration, T> : EnumerationBase<TEnumeration, T>
         where T : IEquatable<T>
       , IUnitOfMeasure<T>
{
   static Enumeration()
   {
      ByName   = All.ToDictionary(u => u.Name);
      BySymbol = All.ToDictionary(u => u.Symbol);
   }

   /// <summary>
   /// Looks up an enumerated unit of measure by name.
   /// </summary>
   public static IReadOnlyDictionary<string, T> ByName { get; }

   /// <summary>
   /// Looks up an enumerated unit of measure by symbol.
   /// </summary>
   public static IReadOnlyDictionary<string, T> BySymbol { get; }
}
