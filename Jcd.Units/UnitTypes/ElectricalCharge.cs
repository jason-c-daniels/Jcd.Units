namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the amount of electricity that a current carries for a given unit of time.
/// </summary>
public record ElectricalCharge : UnitOfMeasure<ElectricalCharge>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="ElectricalCharge" /> using another <see cref="ElectricalCharge" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="ElectricalCharge" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public ElectricalCharge
            (
            string name
          , string symbol
          , ElectricalCharge? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer) { }
}
