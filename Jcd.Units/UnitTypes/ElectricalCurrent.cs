using System;

namespace Jcd.Units.UnitTypes;



/// <summary>
/// Constructs a unit measuring a specified <see cref="ElectricalCurrent"/>
/// </summary>
/// <param name="Name">The name of this unit</param>
/// <param name="Symbol">The symbol or abbreviation to represent the <see cref="ElectricalCurrent"/></param>
/// <param name="Coefficient">The unit's coefficient relative to the ultimate base unit's representation.</param>
/// <param name="Offset">The offset used when computing values going to and from the base unit's representation.</param>
public record ElectricalCurrent(string Name, string Symbol, double Coefficient=1, double Offset=0) 
    : UnitOfMeasure<ElectricalCurrent>(Name,Symbol,Coefficient,Offset)
{
    /// <summary>
    /// Constructs a unit measuring a specified <see cref="ElectricalCurrent"/> using another ElectricalCurrent as a reference.
    /// </summary>
    /// <param name="name">The name of this unit</param>
    /// <param name="symbol">The symbol or abbreviation to represent the <see cref="ElectricalCurrent"/></param>
    /// <param name="baseUnit">The unit to use as a base</param>
    /// <param name="coefficient">The coefficient relative to the <c>baseUnit</c></param>
    /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
    public ElectricalCurrent(string name, string symbol, ElectricalCurrent baseUnit, double coefficient, double offset = 0) 
        : this(name,symbol,baseUnit.ComputeFundamentalCoefficient(coefficient),baseUnit.ComputeFundamentalOffset(offset))
    {
        
    }
}