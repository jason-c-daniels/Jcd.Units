namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the amount of magnetic flux through a unit area taken perpendicular to the direction of the magnetic flux.
/// </summary>
public record MagneticFluxDensity : UnitOfMeasure<MagneticFluxDensity>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="MagneticFluxDensity" /> using another <see cref="MagneticFluxDensity" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="MagneticFluxDensity" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="system">The optional system the unit of measure belongs to.</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public MagneticFluxDensity
            (
            string name
          , string symbol
          , MagneticFluxDensity? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
          , string system = ""
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer, system) { }
}
