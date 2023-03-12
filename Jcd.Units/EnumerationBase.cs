﻿#region

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;

#endregion

namespace Jcd.Units;

/// <summary>
/// The base of all unit of measure enumerations in this library.
/// </summary>
/// <typeparam name="TEnumeration">The enumeration type.</typeparam>
/// <typeparam name="T">The type of the enumerated members.</typeparam>
public class EnumerationBase<TEnumeration, T>
         where T : IEquatable<T>
{
   /// <summary>
   /// All enumerated elements. Populated in static constructor.
   /// </summary>
   protected static readonly ImmutableArray<T> All;

   static EnumerationBase()
   {
      var t = typeof(T);

      var fields = typeof(TEnumeration).GetFields(
                                                  BindingFlags.Public
                                                | BindingFlags.Static
                                                | BindingFlags.DeclaredOnly
                                                 );

      All = fields
           .Where(f => f.FieldType == typeof(T))
           .Select(f => f.GetValue(null))
           .Cast<T>()
           .ToImmutableArray()
               ;
   }

   /// <summary>
   /// Retrieves all public static properties of type <typeparamref name="T" />
   /// on the derived enumeration <typeparamref name="TEnumeration" />
   /// </summary>
   /// <returns>An <see cref="IEnumerable{T}" /> for all detected members.</returns>
   public static IEnumerable<T> GetAll() => All;
}