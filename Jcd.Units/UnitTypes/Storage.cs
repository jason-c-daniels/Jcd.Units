namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of data storage.
/// </summary>
public record Storage : UnitOfMeasure<Storage>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="Storage" /> using another <see cref="Storage" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="Storage" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="system">The optional system the unit of measure belongs to.</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit" /></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit" />.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}" /> used for comparisons.</param>
   public Storage(
      string name, string symbol, Storage? baseUnit = null, double coefficient = 1.0, double offset = 0, IValueComparer<double>? comparer = null, string system = ""
   )
      : base(name, symbol, baseUnit, coefficient, offset, comparer, system)
   {
   }
}