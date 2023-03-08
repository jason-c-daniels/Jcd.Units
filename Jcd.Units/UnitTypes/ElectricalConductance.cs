﻿namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the ease with which an electric current passes through matter. It's the reciprocal of electrical resistance.
/// </summary>
public record ElectricalConductance : UnitOfMeasure<ElectricalConductance>
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="ElectricalConductance" /> using another <see cref="ElectricalConductance" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="ElectricalConductance" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
   public ElectricalConductance
            (
            string name
          , string symbol
          , ElectricalConductance? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer) { }
}
