namespace Jcd.Units.UnitTypes;

/// <summary>
/// A measurement of the amount of work energy needed to move a unit of an electric charge from a reference point to a specific point.
/// </summary>
/// <param name="Name">The name of this unit of measure.</param>
/// <param name="Symbol">The symbol or abbreviation to represent the <see cref="ElectricalPotential" /></param>
/// <param name="Coefficient">The unit's coefficient relative to the ultimate base unit's representation.</param>
/// <param name="Offset">The offset used when computing values going to and from the base unit's representation.</param>
public record ElectricalPotential(string Name, string Symbol, double Coefficient=1, double Offset=0) 
    : UnitOfMeasure<ElectricalPotential>(Name,Symbol,Coefficient,Offset)
{
    /// <summary>
    /// Constructs a unit measuring a specified <see cref="ElectricalPotential" /> using another <see cref="ElectricalPotential" /> as a reference.
    /// </summary>
    /// <param name="name">The name of this unit</param>
    /// <param name="symbol">The symbol or abbreviation to represent the <see cref="ElectricalPotential" /></param>
    /// <param name="baseUnit">The unit to use as a base</param>
    /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
    /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
    public ElectricalPotential(string name, string symbol, ElectricalPotential baseUnit, double coefficient, double offset = 0) 
        : this(name,symbol,baseUnit.ComputeFundamentalCoefficient(coefficient),baseUnit.ComputeFundamentalOffset(offset))
    {
    }
}