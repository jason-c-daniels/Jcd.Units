﻿using System.Collections.Generic;

namespace Jcd.Units;

/// <summary>
/// Defines the interface needed to perform value comparisons within a quantity or UnitOfMeasure type.
/// </summary>
/// <typeparam name="T">The datatype being compared</typeparam>
/// <remarks>
/// This type is used to provide stable hash codes (i.e. hash codes that are identical for values
/// that the implementation compares as equivalent.) and comparison implementations to provide
/// application defined comparison operations. It's most useful for <see cref="float"/>, <see cref="double"/> and custom data types.
/// </remarks>
public interface IValueComparer<in T> : 
    IComparer<T>, 
    IEqualityComparer<T>
{
    
}