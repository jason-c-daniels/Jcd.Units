namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the ability of a system to store an electric charge.
/// </summary>
public record Capacitance : UnitOfMeasure<Capacitance>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="Capacitance" /> using another <see cref="Capacitance" /> as a
   /// reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="Capacitance" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="system">The optional system the unit of measure belongs to.</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit" /></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit" />.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}" /> used for comparisons.</param>
   public Capacitance(
      string name, string symbol, Capacitance? baseUnit = null, double coefficient = 1.0, double offset = 0, IValueComparer<double>? comparer = null
    , string system = ""
   )
      : base(name, symbol, baseUnit, coefficient, offset, comparer, system)
   {
   }
}