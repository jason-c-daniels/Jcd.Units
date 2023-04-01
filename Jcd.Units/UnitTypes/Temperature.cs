namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the energy contained in the motion and vibration of an object's molecules.
/// </summary>
public record Temperature : UnitOfMeasure<Temperature>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="Temperature" /> using another <see cref="Temperature" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="Temperature" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="system">The optional system the unit of measure belongs to.</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public Temperature
            (
            string name
          , string symbol
          , Temperature? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
          , string system = ""
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer, system) { }
}
