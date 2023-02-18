using System;

namespace Jcd.Units.UnitTypes;



/// <summary>
/// A measure of the perceived power of light.
/// </summary>
/// <param name="Name">The name of this unit of measure.</param>
/// <param name="Symbol">The symbol or abbreviation to represent the <see cref="LuminousFlux"/></param>
/// <param name="Coefficient">The unit's coefficient relative to the ultimate base unit's representation.</param>
/// <param name="Offset">The offset used when computing values going to and from the base unit's representation.</param>
public record LuminousFlux(string Name, string Symbol, double Coefficient=1, double Offset=0) 
    : UnitOfMeasure<LuminousFlux>(Name,Symbol,Coefficient,Offset)
{
    /// <summary>
    /// Constructs a unit measuring a specified <see cref="LuminousFlux"/> using another <see cref="LuminousFlux"/> as a reference.
    /// </summary>
    /// <param name="name">The name of this unit</param>
    /// <param name="symbol">The symbol or abbreviation to represent the <see cref="LuminousFlux"/></param>
    /// <param name="baseUnit">The unit to use as a base</param>
    /// <param name="coefficient">The coefficient relative to the <c>baseUnit</c></param>
    /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
    public LuminousFlux(string name, string symbol, LuminousFlux baseUnit, double coefficient, double offset = 0) 
        : this(name,symbol,baseUnit.ComputeFundamentalCoefficient(coefficient),baseUnit.ComputeFundamentalOffset(offset))
    {
        
    }
}