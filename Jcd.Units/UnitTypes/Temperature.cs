namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the energy contained in the motion and vibration of an object's molecules.
/// </summary>
/// <param name="Name">The name of this unit of measure.</param>
/// <param name="Symbol">The symbol or abbreviation to represent the <see cref="Temperature" /></param>
/// <param name="Coefficient">The unit's coefficient relative to the ultimate base unit's representation.</param>
/// <param name="Offset">The offset used when computing values going to and from the base unit's representation.</param>
public record Temperature(string Name, string Symbol, double Coefficient=1, double Offset=0) 
    : UnitOfMeasure<Temperature>(Name,Symbol,Coefficient,Offset)
{
    /// <summary>
    /// Constructs a unit measuring a specified <see cref="Temperature" /> using another <see cref="Temperature" /> as a reference.
    /// </summary>
    /// <param name="name">The name of this unit</param>
    /// <param name="symbol">The symbol or abbreviation to represent the <see cref="Temperature" /></param>
    /// <param name="baseUnit">The unit to use as a base</param>
    /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
    /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
    public Temperature(string name, string symbol, Temperature baseUnit, double coefficient, double offset = 0) 
        : this(name,symbol,coefficient,offset)
    {
	    Coefficient = baseUnit.ComputeFundamentalCoefficient(coefficient);
        Offset = baseUnit.ComputeFundamentalOffset(Coefficient, offset);
    }
}