namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of rate at which velocity changes with time, in terms of both speed and direction.
/// </summary>
public record Acceleration : UnitOfMeasure<Acceleration>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="Acceleration" /> using another <see cref="Acceleration" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="Acceleration" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public Acceleration
            (
            string name
          , string symbol
          , Acceleration? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer) { }
}
