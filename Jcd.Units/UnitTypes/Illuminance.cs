namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the amount of luminous flux per unit area.
/// </summary>
public record Illuminance : UnitOfMeasure<Illuminance>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="Illuminance" /> using another <see cref="Illuminance" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="Illuminance" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public Illuminance
            (
            string name
          , string symbol
          , Illuminance? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer) { }
}
