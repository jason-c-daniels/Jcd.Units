#region

using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// ReSharper disable MemberCanBeProtected.Global

#endregion

namespace Jcd.Units;

/// <summary>
/// The base of all unit of measure enumerations in this library.
/// </summary>
/// <typeparam name="TEnumeration">The enumeration type.</typeparam>
/// <typeparam name="T">The type of the enumerated members.</typeparam>
public class Enumeration<TEnumeration, T>
         where T : IEquatable<T>
       , IUnitOfMeasure<T>
{
   private static readonly T[] All;

   static Enumeration()
   {
      All = typeof(TEnumeration).GetFields(
                                           BindingFlags.Public
                                         | BindingFlags.Static
                                         | BindingFlags.DeclaredOnly
                                          )
                                .Select(f => f.GetValue(null))
                                .Where(x => x?.GetType() == typeof(T))
                                .Cast<T>()
                                .ToArray();

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

   /// <summary>
   /// Retrieves all public static properties of type <typeparamref name="T"/>
   /// on the derived enumeration <typeparamref name="TEnumeration"/>
   /// </summary>
   /// <returns>An <see cref="IEnumerable{T}"/> for all detected members.</returns>
   public static IEnumerable<T> GetAll() => All;
}
