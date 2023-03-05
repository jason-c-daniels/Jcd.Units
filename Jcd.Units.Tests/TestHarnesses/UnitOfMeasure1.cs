namespace Jcd.Units.Tests.TestHarnesses
{
    /// <summary>
    /// A test harness for validating 
    /// </summary>
    /// <param name="Name">The name of this unit of measure.</param>
    /// <param name="Symbol">The symbol or abbreviation to represent the <see cref="UnitOfMeasure1" /></param>
    /// <param name="Coefficient">The unit's coefficient relative to the ultimate base unit's representation.</param>
    /// <param name="Offset">The offset used when computing values going to and from the base unit's representation.</param>
    public record UnitOfMeasure1(string Name, string Symbol, double Coefficient=1, double Offset=0) 
        : UnitOfMeasure<UnitOfMeasure1>(Name,Symbol,Coefficient,Offset)
    {
        /// <summary>
        /// Constructs a unit measuring a specified <see cref="UnitOfMeasure1" /> using another <see cref="UnitOfMeasure1" /> as a reference.
        /// </summary>
        /// <param name="name">The name of this unit</param>
        /// <param name="symbol">The symbol or abbreviation to represent the <see cref="UnitOfMeasure1" /></param>
        /// <param name="baseUnit">The unit to use as a base</param>
        /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
        /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
        public UnitOfMeasure1(string name, string symbol, UnitOfMeasure1 baseUnit, double coefficient, double offset = 0) 
            : this(name,symbol,coefficient,offset)
        {
            BaseUnit = baseUnit;
            FundamentalUnit = baseUnit.FundamentalUnit;
            Coefficient = baseUnit.ComputeFundamentalCoefficient(coefficient);
            Offset = baseUnit.ComputeFundamentalOffset(Coefficient, offset);
        }
    }
}