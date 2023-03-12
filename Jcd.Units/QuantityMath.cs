namespace Jcd.Units;

/// <summary>
/// Provides static common mathematical functions performed on instances of <see cref="Quantity{TUnit}" />.
/// This parallels and uses many of the <see cref="System.Math" /> implementations.
/// </summary>
public static class QMath
{
   /// <summary>
   /// Returns the absolute value of a <see cref="Quantity{TUnit}" /> as a new Quantity with the source unit of measure.
   /// </summary>
   /// <param name="quantity">The quantity</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>the absolute value of a <see cref="Quantity{TUnit}" /> as a new Quantity with the source unit of measure.</returns>
   public static Quantity<TUnit> Abs<TUnit>(Quantity<TUnit> quantity)
            where TUnit : UnitOfMeasure<TUnit>
      => Math.Abs(quantity.RawValue)
             .As(quantity.Unit);
}
