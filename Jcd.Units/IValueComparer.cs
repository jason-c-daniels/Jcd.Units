using System.Collections.Generic;

namespace Jcd.Units;

/// <summary>
/// Defines the interface needed to perform value comparisons within a quantity or UnitOfMeasure type. 
/// </summary>
/// <typeparam name="T">The datatype being compared</typeparam>
public interface IValueComparer<in T> : 
    IComparer<T>, 
    IEqualityComparer<T>
{
    
}