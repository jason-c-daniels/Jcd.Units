namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the amount of work energy needed to move a unit of an electric charge from a reference point to a specific point.
/// </summary>
public record ElectricalPotential : UnitOfMeasure<ElectricalPotential>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="ElectricalPotential" /> using another <see cref="ElectricalPotential" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="ElectricalPotential" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="system">The optional system the unit of measure belongs to.</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public ElectricalPotential
            (
            string name
          , string symbol
          , ElectricalPotential? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
          , string system = ""
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer, system) { }
}
