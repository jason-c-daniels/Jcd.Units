// ReSharper disable UnusedMember.Global

#region

using Jcd.Units.UnitsOfMeasure;
using Jcd.Units.UnitTypes;

#endregion

namespace Jcd.Units;

/// <summary>
/// Some extension methods to make creating quantities using units of measures,
/// and converting among units of measure easier.
/// </summary>
public static class QuantityFactoryExtensions
{
   /// <summary>
   /// Converts a <see cref="double" /> into a quantity using the specified unit of measure.
   /// </summary>
   /// <param name="rawValue">The <see cref="double" /> to convert.</param>
   /// <param name="unitOfMeasure">The unit of measure to use.</param>
   /// <typeparam name="TUnit">The type of the unit of measure.</typeparam>
   /// <returns>A new <see cref="Quantity{TUnit}" /> instance.</returns>
   public static Quantity<TUnit> As<TUnit>(this double rawValue, TUnit unitOfMeasure)
            where TUnit : UnitOfMeasure<TUnit>
      => new (rawValue, unitOfMeasure);

   /// <summary>
   /// Converts a <see cref="float" /> into a quantity using the specified unit of measure.
   /// </summary>
   /// <param name="rawValue">The <see cref="float" /> to convert.</param>
   /// <param name="unitOfMeasure">The unit of measure to use.</param>
   /// <typeparam name="TUnit">The type of the unit of measure.</typeparam>
   /// <returns>A new <see cref="Quantity{TUnit}" /> instance.</returns>
   public static Quantity<TUnit> As<TUnit>(this float rawValue, TUnit unitOfMeasure)
            where TUnit : UnitOfMeasure<TUnit>
      => new (rawValue, unitOfMeasure);

   /// <summary>
   /// Converts an <see cref="long" /> into a quantity using the specified unit of measure.
   /// </summary>
   /// <param name="rawValue">The <see cref="long" /> to convert.</param>
   /// <param name="unitOfMeasure">The unit of measure to use.</param>
   /// <typeparam name="TUnit">The type of the unit of measure.</typeparam>
   /// <returns>A new <see cref="Quantity{TUnit}" /> instance.</returns>
   public static Quantity<TUnit> As<TUnit>(this long rawValue, TUnit unitOfMeasure)
            where TUnit : UnitOfMeasure<TUnit>
      => new (rawValue, unitOfMeasure);

   /// <summary>
   /// Converts a <see cref="ulong" /> into a quantity using the specified unit of measure.
   /// </summary>
   /// <param name="rawValue">The <see cref="ulong" /> to convert.</param>
   /// <param name="unitOfMeasure">The unit of measure to use.</param>
   /// <typeparam name="TUnit">The type of the unit of measure.</typeparam>
   /// <returns>A new <see cref="Quantity{TUnit}" /> instance.</returns>
   public static Quantity<TUnit> As<TUnit>(this ulong rawValue, TUnit unitOfMeasure)
            where TUnit : UnitOfMeasure<TUnit>
      => new (rawValue, unitOfMeasure);

   /// <summary>
   /// Converts an <see cref="int" /> into a quantity using the specified unit of measure.
   /// </summary>
   /// <param name="rawValue">The <see cref="int" /> to convert.</param>
   /// <param name="unitOfMeasure">The unit of measure to use.</param>
   /// <typeparam name="TUnit">The type of the unit of measure.</typeparam>
   /// <returns>A new <see cref="Quantity{TUnit}" /> instance.</returns>
   public static Quantity<TUnit> As<TUnit>(this int rawValue, TUnit unitOfMeasure)
            where TUnit : UnitOfMeasure<TUnit>
      => new (rawValue, unitOfMeasure);

   /// <summary>
   /// Converts a <see cref="uint" /> into a quantity using the specified unit of measure.
   /// </summary>
   /// <param name="rawValue">The <see cref="uint" /> to convert.</param>
   /// <param name="unitOfMeasure">The unit of measure to use.</param>
   /// <typeparam name="TUnit">The type of the unit of measure.</typeparam>
   /// <returns>A new <see cref="Quantity{TUnit}" /> instance.</returns>
   public static Quantity<TUnit> As<TUnit>(this uint rawValue, TUnit unitOfMeasure)
            where TUnit : UnitOfMeasure<TUnit>
      => new (rawValue, unitOfMeasure);

   /// <summary>
   /// Converts a <see cref="short" /> into a quantity using the specified unit of measure.
   /// </summary>
   /// <param name="rawValue">The <see cref="short" /> to convert.</param>
   /// <param name="unitOfMeasure">The unit of measure to use.</param>
   /// <typeparam name="TUnit">The type of the unit of measure.</typeparam>
   /// <returns>A new <see cref="Quantity{TUnit}" /> instance.</returns>
   public static Quantity<TUnit> As<TUnit>(this short rawValue, TUnit unitOfMeasure)
            where TUnit : UnitOfMeasure<TUnit>
      => new (rawValue, unitOfMeasure);

   /// <summary>
   /// Converts a <see cref="ushort" /> into a quantity using the specified unit of measure.
   /// </summary>
   /// <param name="rawValue">The <see cref="ushort" /> to convert.</param>
   /// <param name="unitOfMeasure">The unit of measure to use.</param>
   /// <typeparam name="TUnit">The type of the unit of measure.</typeparam>
   /// <returns>A new <see cref="Quantity{TUnit}" /> instance.</returns>
   public static Quantity<TUnit> As<TUnit>(this ushort rawValue, TUnit unitOfMeasure)
            where TUnit : UnitOfMeasure<TUnit>
      => new (rawValue, unitOfMeasure);

   /// <summary>
   /// Converts an <see cref="sbyte" /> into a quantity using the specified unit of measure.
   /// </summary>
   /// <param name="rawValue">The <see cref="sbyte" /> to convert.</param>
   /// <param name="unitOfMeasure">The unit of measure to use.</param>
   /// <typeparam name="TUnit">The type of the unit of measure.</typeparam>
   /// <returns>A new <see cref="Quantity{TUnit}" /> instance.</returns>
   public static Quantity<TUnit> As<TUnit>(this sbyte rawValue, TUnit unitOfMeasure)
            where TUnit : UnitOfMeasure<TUnit>
      => new (rawValue, unitOfMeasure);

   /// <summary>
   /// Converts a <see cref="byte" /> into a quantity using the specified unit of measure.
   /// </summary>
   /// <param name="rawValue">The <see cref="byte" /> to convert.</param>
   /// <param name="unitOfMeasure">The unit of measure to use.</param>
   /// <typeparam name="TUnit">The type of the unit of measure.</typeparam>
   /// <returns>A new <see cref="Quantity{TUnit}" /> instance.</returns>
   public static Quantity<TUnit> As<TUnit>(this byte rawValue, TUnit unitOfMeasure)
            where TUnit : UnitOfMeasure<TUnit>
      => new (rawValue, unitOfMeasure);

   /// <summary>
   /// Converts an existing <see cref="Quantity{TUnit}" /> into a new quantity replacing the existing units of measure with
   /// the the specified unit of measure, WITHOUT CONVERSION.
   /// </summary>
   /// <param name="quantity">The <see cref="Quantity{TUnit}" /> to convert.</param>
   /// <param name="unitOfMeasure">The new unit of measure to use.</param>
   /// <typeparam name="TUnit">The type of unit of measure for the source quantity.</typeparam>
   /// <typeparam name="TNewUnit">The type of the new unit of measure for the new quantity.</typeparam>
   /// <returns>A new <see cref="Quantity{TUnit}" /> instance.</returns>
   public static Quantity<TNewUnit> As<TUnit, TNewUnit>(this Quantity<TUnit> quantity, TNewUnit unitOfMeasure)
            where TUnit : UnitOfMeasure<TUnit>
            where TNewUnit : UnitOfMeasure<TNewUnit>
      => quantity.RawValue.As(unitOfMeasure);

   /// <summary>
   /// Converts a <see cref="TimeSpan" /> to a <see cref="Duration" /> represented as the specified unit of time.
   /// </summary>
   /// <param name="timeSpan">The <see cref="TimeSpan" /> to convert.</param>
   /// <param name="timeUnit">The <see cref="Duration" /> unit of measure to convert to.</param>
   /// <returns></returns>
   public static Quantity<Duration> As(this TimeSpan timeSpan, Duration timeUnit)
      => timeSpan.TotalMilliseconds.As(Durations.Millisecond)
                 .To(timeUnit);

   /// <summary>
   /// Converts a <see cref="Duration" /> to a <see cref="TimeSpan" />
   /// </summary>
   /// <param name="duration">The <see cref="Duration" /> to convert.</param>
   /// <returns>The <see cref="TimeSpan" /> representation of the <see cref="Duration" /> </returns>
   public static TimeSpan ToTimeSpan(this Quantity<Duration> duration)
   {
      var ticksDur = duration.To(Durations.Tick);
      var ticks    = Convert.ToInt64(Math.Round(ticksDur.RawValue, 0));

      return new TimeSpan(ticks);
   }
}
