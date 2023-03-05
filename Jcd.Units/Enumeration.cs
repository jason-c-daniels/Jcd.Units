#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

#endregion

namespace Jcd.Units;

/// <summary>
/// The base of all DDD-style enumerations in this library.
/// </summary>
/// <typeparam name="TEnumeration">The enumeration type.</typeparam>
/// <typeparam name="T">The type of the enumerated members.</typeparam>
public class Enumeration<TEnumeration, T>
         where T : IEquatable<T>
{
   /// <summary>
   /// Retrieves all public static properties of type <typeparamref name="T"/>
   /// on the derived enumeration <typeparamref name="TEnumeration"/>
   /// </summary>
   /// <returns>An <see cref="IEnumerable{T}"/> for all detected members.</returns>
   public static IEnumerable<T> GetAll() =>
            typeof(TEnumeration).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                                .Select(f => f.GetValue(null))
                                .Cast<T>();
}
