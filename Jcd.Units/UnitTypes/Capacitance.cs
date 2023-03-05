namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the ability of a system to store an electric charge.
/// </summary>
/// <param name="Name">The name of this unit of measure.</param>
/// <param name="Symbol">The symbol or abbreviation to represent the <see cref="Capacitance" /></param>
/// <param name="Coefficient">The unit's coefficient relative to the ultimate base unit's representation.</param>
/// <param name="Offset">The offset used when computing values going to and from the base unit's representation.</param>
public record Capacitance(string Name, string Symbol, double Coefficient = 1, double Offset = 0)
         : UnitOfMeasure<Capacitance>(Name, Symbol, Coefficient, Offset)
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="Capacitance" /> using another <see cref="Capacitance" /> as a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="Capacitance" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
   public Capacitance(string name, string symbol, Capacitance baseUnit, double coefficient, double offset = 0)
            : this(name, symbol, coefficient, offset)
   {
      BaseUnit        = baseUnit;
      FundamentalUnit = baseUnit.FundamentalUnit;
      Coefficient     = baseUnit.ComputeFundamentalCoefficient(coefficient);
      Offset          = baseUnit.ComputeFundamentalOffset(Coefficient, offset);
   }
}
