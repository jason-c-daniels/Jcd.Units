﻿namespace Jcd.Units.Tests.TestHarnesses
{
    /// <summary>
    /// A test harness for validating 
    /// </summary>
    /// <param name="Name">The name of this unit of measure.</param>
    /// <param name="Symbol">The symbol or abbreviation to represent the <see cref="UnitOfMeasure2" /></param>
    /// <param name="Coefficient">The unit's coefficient relative to the ultimate base unit's representation.</param>
    /// <param name="Offset">The offset used when computing values going to and from the base unit's representation.</param>
    public record UnitOfMeasure2(string Name, string Symbol, double Coefficient=1, double Offset=0) 
        : UnitOfMeasure<UnitOfMeasure2>(Name,Symbol,Coefficient,Offset)
    {
        /// <summary>
        /// Constructs a unit measuring a specified <see cref="UnitOfMeasure2" /> using another <see cref="UnitOfMeasure2" /> as a reference.
        /// </summary>
        /// <param name="name">The name of this unit</param>
        /// <param name="symbol">The symbol or abbreviation to represent the <see cref="UnitOfMeasure2" /></param>
        /// <param name="baseUnit">The unit to use as a base</param>
        /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit"/></param>
        /// <param name="offset">The offset from the <paramref name="baseUnit"/>.</param>
        /// <param name="comparer">The instance specific <see cref="IValueComparer{T}"/> used for comparisons.</param>
        public UnitOfMeasure2(string name, string symbol, UnitOfMeasure2 baseUnit, double coefficient, double offset = 0, IValueComparer<double>? comparer=null) 
            : this(name,symbol,coefficient,offset)
        {
            BaseUnit = baseUnit;
            FundamentalUnit = baseUnit.FundamentalUnit;
            Coefficient = baseUnit.ComputeFundamentalCoefficient(coefficient);
            Offset = baseUnit.ComputeFundamentalOffset(Coefficient, offset);
            Comparer = comparer;
        }
    }
}