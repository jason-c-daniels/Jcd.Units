namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the number of atomic nuclei that decay per unit time.
/// </summary>
public record RadioactiveDecay : UnitOfMeasure<RadioactiveDecay>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="RadioactiveDecay" /> using another <see cref="RadioactiveDecay" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="RadioactiveDecay" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public RadioactiveDecay
            (
            string name
          , string symbol
          , RadioactiveDecay? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer) { }
}
