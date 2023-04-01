namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the rate of change of momentum.
/// </summary>
public record Force : UnitOfMeasure<Force>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="Force" /> using another <see cref="Force" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="Force" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="system">The optional system the unit of measure belongs to.</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public Force
            (
            string name
          , string symbol
          , Force? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
          , string system = ""
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer, system) { }
}
