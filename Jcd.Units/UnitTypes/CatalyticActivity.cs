namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the increase in the rate of a chemical reaction caused by the presence of a catalyst.
/// </summary>
public record CatalyticActivity : UnitOfMeasure<CatalyticActivity>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="CatalyticActivity" /> using another <see cref="CatalyticActivity" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="CatalyticActivity" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="system">The optional system the unit of measure belongs to.</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public CatalyticActivity
            (
            string name
          , string symbol
          , CatalyticActivity? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
          , string system = ""
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer, system) { }
}
