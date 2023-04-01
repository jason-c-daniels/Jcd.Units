namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the total space taken up by a surface. This may be a planar two-dimensional measurement, the surface of a three-dimensional object...etc.
/// </summary>
public record Area : UnitOfMeasure<Area>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="Area" /> using another <see cref="Area" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="Area" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="system">The optional system the unit of measure belongs to.</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public Area
            (
            string name
          , string symbol
          , Area? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
          , string system = ""
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer, system) { }
}
