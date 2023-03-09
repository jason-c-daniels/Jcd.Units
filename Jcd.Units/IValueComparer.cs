#region

using System.Collections.Generic;

#endregion

namespace Jcd.Units;

/// <summary>
/// Defines a marker interface used to enforce providing both relational (CompareTo) and equality comparisons on a given type.
/// </summary>
/// <typeparam name="T">The datatype being compared</typeparam>
/// <remarks>
/// This type is used to provide stable hash codes (i.e. hash codes that are identical for values
/// that the implementation compares as equivalent.) and comparison implementations to provide
/// application defined comparison operations. It's most useful for <see cref="float"/>, <see cref="double"/> and custom data types.
/// </remarks> 
public interface IValueComparer<in T> :
         IComparer<T>
       , IEqualityComparer<T> { }
