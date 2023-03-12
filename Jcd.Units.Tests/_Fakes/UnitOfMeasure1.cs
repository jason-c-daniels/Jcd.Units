namespace Jcd.Units.Tests._Fakes;
#pragma warning disable CA1067

/// <summary>
/// A test harness for validating
/// </summary>
public record UnitOfMeasure1
         : UnitOfMeasure<UnitOfMeasure1> //(Name, Symbol, Coefficient, Offset)
{
   /// <summary>
   /// Constructs a unit measuring a specified <see cref="UnitOfMeasure1" /> using another <see cref="UnitOfMeasure1" /> as
   /// a reference.
   /// </summary>
   /// <param name="name">The name of this unit</param>
   /// <param name="symbol">The symbol or abbreviation to represent the <see cref="UnitOfMeasure1" /></param>
   /// <param name="baseUnit">The unit to use as a base</param>
   /// <param name="coefficient">The coefficient relative to the <paramref name="baseUnit" /></param>
   /// <param name="offset">The offset from the <paramref name="baseUnit" />.</param>
   /// <param name="comparer">The instance specific <see cref="IValueComparer{T}" /> used for comparisons.</param>
   public UnitOfMeasure1
            (
            string name
          , string symbol
          , UnitOfMeasure1? baseUnit = null
          , double coefficient = 1.0
          , double offset = 0
          , IValueComparer<double>? comparer = null
            )
            : base(name, symbol, baseUnit, coefficient, offset, comparer) { }
}

#pragma warning restore CA1067
