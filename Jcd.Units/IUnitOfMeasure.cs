using System;
// ReSharper disable UnusedMember.Global

namespace Jcd.Units;

/// <summary>
/// The interface defining what every unit of measure must support.
/// </summary>
/// <typeparam name="TUnits">The type deriving from <see cref="IUnitOfMeasure{TUnits}"/></typeparam>
/// <remarks>
/// By ensuring that all units of measure provide their own type to the interface
/// we guarantee compile time detection of certain classes of errors.
/// </remarks>
public interface IUnitOfMeasure<in TUnits>
    : IComparable<TUnits>,
      IComparable
{
    /// <summary>
    /// The friendly name of the unit of measure. (e.g. millisecond)
    /// </summary>
    string Name { get; }
    
    /// <summary>
    /// The symbolic short representation.
    /// NOTE: THIS SHOULD BE ONLY LETTERS AND SYMBOLS, NOT AN EQUATION.
    /// </summary>
    string Symbol { get; }
    
    /// <summary>
    /// The Coefficient relative to the fundamental unit for derived units.
    /// This is 1.0 for fundamental units. This should never be 0.
    /// (divide by zero errors will occur.)
    /// </summary>
    double Coefficient { get; }
    
    /// <summary>
    /// This is the offset from the fundamental unit.
    /// </summary>
    double Offset { get; }
}