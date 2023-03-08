namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measure of the wavelength-weighted power emitted by a light source in a particular direction per unit solid angle.
/// </summary>
public record LuminousIntensity : UnitOfMeasure<LuminousIntensity>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="LuminousIntensity" /> using another <see cref="LuminousIntensity" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="LuminousIntensity" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public LuminousIntensity
            (
            string name
          , string symbol
          , LuminousIntensity? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer) { }
}
