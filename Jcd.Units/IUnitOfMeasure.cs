// ReSharper disable UnusedMember.Global

namespace Jcd.Units;

/// <summary>
/// The interface defining what every unit of measure must support.
/// </summary>
/// <typeparam name="TUnit">The type deriving from <see cref="IUnitOfMeasure{TUnit}"/></typeparam>
/// <remarks>
/// By ensuring that all units of measure provide their own type to the interface
/// we guarantee compile time detection of certain classes of errors.
/// </remarks>
public interface IUnitOfMeasure<TUnit>
         : IComparable<TUnit>
         , IComparable
         where TUnit : IUnitOfMeasure<TUnit>
{
   /// <summary>
   /// The friendly name of the unit of measure. (e.g. millisecond)
   /// </summary>
   string Name { get; }

   /// <summary>
   /// The symbolic short representation.
   /// </summary>
   string Symbol { get; }

   /// <summary>
   /// The Coefficient relative to the fundamental unit for derived units.
   /// This is 1.0 for fundamental units. This should never be 0.
   /// (divide by zero errors will occur.)
   /// </summary>
   double Coefficient { get; }

   /// <summary>
   /// This is the offset from the fundamental unit.
   /// </summary>
   double Offset { get; }

   /// <summary>
   /// The unit of measure all others are represented in terms of.
   /// </summary>
   TUnit FundamentalUnit { get; }

   /// <summary>
   /// The unit of measure this one was defined in terms of.
   /// </summary>
   TUnit BaseUnit { get; }

   /// <summary>
   /// Indicates if this unit of measure is the fundamental unit. (i.e. Coefficient 1, Offset 0)
   /// </summary>
   bool IsFundamentalUnit { get; }

   /// <summary>
   /// Given a raw value, convert FROM the fundamental (normalized) base unit representation
   /// TO the non-base value. (e.g. 0.1  becomes 100mm as meters are the base
   /// unit and 0.1m is 100mm )
   /// </summary>
   /// <param name="normalizedValue">the normalized value.</param>
   /// <returns>The denormalized value</returns>
   double FromBaseUnitValue(double normalizedValue);

   /// <summary>
   /// Given a raw value, convert TO the fundamental base unit representation
   /// FROM the non-base unit representation of  the value. (e.g. 100mm becomes
   /// 0.1 as meters are the base unit)
   /// </summary>
   /// <param name="denormalizedValue">the denormalized value.</param>
   double ToBaseUnitValue(double denormalizedValue);

   /// <summary>
   /// Given a coefficient, calculate the equivalent coefficient for the
   /// fundamental unit of measure. (i.e. the one with Coeff. = 1 and Offset = 0) 
   /// </summary>
   /// <param name="coefficient">The coefficient to normalize.</param>
   /// <returns>The coefficient for the fundamental unit of measure.</returns>
   double ComputeFundamentalCoefficient(double coefficient);

   /// <summary>
   /// Given an offset and the coefficient for converting to the fundamental unit
   /// of measure, calculate the equivalent offset for the fundamental unit of measure.
   /// (i.e. the one with Coeff = 1 and Offset = 0) 
   /// </summary>
   /// <param name="offset">The offset to normalize.</param>
   /// <param name="fundamentalCoefficient">The coefficient for converting to the fundamental unit of measure.</param>
   /// <returns>The offset for the fundamental unit of measure.</returns>
   public double ComputeFundamentalOffset(double fundamentalCoefficient, double offset);
}
