#region

using System.Runtime.CompilerServices;

using Jcd.Units.UnitsOfMeasure;
using Jcd.Units.UnitTypes;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

#endregion

namespace Jcd.Units;

/// <summary>
/// Provides common logarithmic, mathematical and trigonometric functions <see cref="Quantity{TUnit}" /> instances.
/// This parallels and uses many of the <see cref="System.Math" /> implementations.
/// </summary>
public static class MathQ
{
   #region Abs, Ceiling, Floor, Min, Max and similar
   
   /// <summary>
   /// Returns the absolute value of a <see cref="Quantity{TUnit}" /> as a new Quantity with the source unit of measure.
   /// </summary>
   /// <param name="quantity">The quantity</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>the absolute value of a <see cref="Quantity{TUnit}" /> as a new Quantity with the source unit of measure.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Abs<TUnit>(Quantity<TUnit> quantity)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Abs(quantity.RawValue).As(quantity.Unit);
   }
   
   /// <summary>
   /// Returns the smallest integral value greater than or equal to the numeric component of the
   /// <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="quantity">The quantity</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>the ceiling of the <see cref="Quantity{TUnit}" /> expressed in the same unit of measure.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Ceiling<TUnit>(Quantity<TUnit> quantity)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Ceiling(quantity.RawValue).As(quantity.Unit);
   }
   
   /// <summary>
   /// Returns the smallest value that is greater than or equal to the numeric component of a
   /// <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="value">The quantity to clamp</param>
   /// <param name="min">The minimum value.</param>
   /// <param name="max">The maximum value.</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>the ceiling for the <see cref="Quantity{TUnit}" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Clamp<TUnit>(Quantity<TUnit> value, Quantity<TUnit> min, Quantity<TUnit> max)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Clamp((double) value, (double) min.To(value.Unit), (double) max.To(value.Unit)).As(value.Unit);
   }
   
   /// <summary>
   /// Returns the largest integral value less than or equal to the numeric component of the <see cref="Quantity{TUnit}" />
   /// .
   /// </summary>
   /// <param name="quantity">The quantity</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>the floor of the <see cref="Quantity{TUnit}" /> expressed in the same unit of measure.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Floor<TUnit>(Quantity<TUnit> quantity)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Floor(quantity.RawValue).As(quantity.Unit);
   }
   
   /// <summary>
   /// Returns the larger of two <see cref="Quantity{TUnit}" /> instances.
   /// </summary>
   /// <param name="value1">The first value to compare.</param>
   /// <param name="value2">The second value to compare.</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>The larger of two specified <see cref="Quantity{TUnit}" /> instances.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Max<TUnit>(Quantity<TUnit> value1, Quantity<TUnit> value2)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return value1 >= value2
                ? value1
                : value2;
   }
   
   /// <summary>
   /// Returns the smaller of two <see cref="Quantity{TUnit}" /> instances.
   /// </summary>
   /// <param name="value1">The first value to compare.</param>
   /// <param name="value2">The second value to compare.</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>The smaller of two specified <see cref="Quantity{TUnit}" /> instances.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Min<TUnit>(Quantity<TUnit> value1, Quantity<TUnit> value2)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return value1 <= value2
                ? value1
                : value2;
   }
   
   /// <summary>
   /// Rounds a quantity's numeric component to a specified number of digits using the specified rounding mode.
   /// </summary>
   /// <param name="quantity">The quantity</param>
   /// <param name="digits">The number of decimal places to round to. (Default is zero.)</param>
   /// <param name="mode">The rounding mode to use (default is ToEven)</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>The <see cref="Quantity{TUnit}" /> rounded to the specified number of digits.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Round<TUnit>(Quantity<TUnit> quantity, int digits = 0, MidpointRounding mode = MidpointRounding.ToEven)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Round(quantity.RawValue, digits, mode).As(quantity.Unit);
   }
   
   /// <summary>
   /// Calculates the integral part of a quantity's numeric component.
   /// </summary>
   /// <param name="quantity">The quantity</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>The <see cref="Quantity{TUnit}" /> rounded to the specified number of digits.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Truncate<TUnit>(Quantity<TUnit> quantity)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Truncate(quantity.RawValue).As(quantity.Unit);
   }
   
   #endregion
   
   #region Exponents, Logarithms, Powers, Sign, and Roots
   
   /// <summary>
   /// Returns the cube root of a <see cref="Quantity{TUnit}" /> as a new Quantity with the source unit of measure.
   /// </summary>
   /// <param name="quantity">The quantity</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>the cube root of a <see cref="Quantity{TUnit}" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Cbrt<TUnit>(Quantity<TUnit> quantity)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Cbrt(quantity.RawValue).As(quantity.Unit);
   }
   
   /// <summary>
   /// Returns <c>e</c> raised to the specified power as a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="quantity">The power for <c>e</c></param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns><c>e</c> raised to the specified power a <see cref="Quantity{TUnit}" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Exp<TUnit>(Quantity<TUnit> quantity)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Exp(quantity.RawValue).As(quantity.Unit);
   }
   
   /// <summary>
   /// Returns the natural (base e) logarithm of the numeric component of a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="quantity">The number whose logarithm is to be found</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>The natural (base e) logarithm of a the numeric component of a <see cref="Quantity{TUnit}" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Log<TUnit>(Quantity<TUnit> quantity)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Log(quantity.RawValue).As(quantity.Unit);
   }
   
   /// <summary>
   /// Returns the logarithm of a the numeric component of a <see cref="Quantity{TUnit}" /> in a specified base.
   /// </summary>
   /// <param name="quantity">The number whose logarithm is to be found</param>
   /// <param name="base">The numeric base of the logarithm.</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>The logarithm of a the numeric component of a <see cref="Quantity{TUnit}" /> in a specified base.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Log<TUnit>(Quantity<TUnit> quantity, double @base)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Log(quantity.RawValue, @base).As(quantity.Unit);
   }
   
   /// <summary>
   /// Returns the base 10 logarithm of a the numeric component of a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="quantity">The number whose logarithm is to be found</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>The base 10 logarithm of a the numeric component of a <see cref="Quantity{TUnit}" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Log10<TUnit>(Quantity<TUnit> quantity)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Log10(quantity.RawValue).As(quantity.Unit);
   }
   
   /// <summary>
   /// Returns the base 2 logarithm of a the numeric component of a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="quantity">The number whose logarithm is to be found</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>The base 2 logarithm of a the numeric component of a <see cref="Quantity{TUnit}" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Log2<TUnit>(Quantity<TUnit> quantity)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Log2(quantity.RawValue).As(quantity.Unit);
   }
   
   /// <summary>
   /// Returns the <see cref="Quantity{TUnit}" /> raised to the specified power.
   /// </summary>
   /// <param name="quantity">The value to raise to the power specified by <paramref name="exponent" /></param>
   /// <param name="exponent">A number specifying the power.</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>The <see cref="Quantity{TUnit}" /> raised to the specified power.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Pow<TUnit>(Quantity<TUnit> quantity, double exponent)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Pow(quantity.RawValue, exponent).As(quantity.Unit);
   }
   
   /// <summary>
   /// Returns an integer indicating the sign of the numeric component of the quantity.
   /// </summary>
   /// <param name="quantity">The number whose sign is to be returned.</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>
   /// 0 if the numeric component is zero; -1 if the numeric component is less than zero; 1 if the numeric component
   /// is greater than 0.
   /// </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int Sign<TUnit>(Quantity<TUnit> quantity)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Sign(quantity.RawValue);
   }
   
   /// <summary>
   /// Returns the square root of the numeric component of the quantity.
   /// </summary>
   /// <param name="quantity">The number whose sign is to be returned.</param>
   /// <typeparam name="TUnit">The type of unit of measure. (e.g. temperature)</typeparam>
   /// <returns>The square root of the numeric component of the quantity.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<TUnit> Sqrt<TUnit>(Quantity<TUnit> quantity)
      where TUnit : UnitOfMeasure<TUnit>
   {
      return Math.Sqrt(quantity.RawValue).As(quantity.Unit);
   }
   
   #endregion
   
   #region Trigonometry Functions
   
   /// <summary>
   /// Returns the angle whose cosine is the specified number.
   /// </summary>
   /// <param name="value">the number to perform the inverse cosine function on.</param>
   /// <param name="outputUnitOfMeasure">The optional, requested output unit of measure.</param>
   /// <returns>The angle whose cosine is the specified number.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<Angle> Acos(double value, Angle? outputUnitOfMeasure = null)
   {
      var degreesRadians = Math.Acos(value).As(Angles.Radian);
      
      return outputUnitOfMeasure is null
                ? degreesRadians
                : degreesRadians.To(outputUnitOfMeasure);
   }
   
   /// <summary>
   /// Returns the angle whose hyperbolic cosine is the specified number.
   /// </summary>
   /// <param name="value">A number representing a hyperbolic cosine.</param>
   /// <param name="outputUnitOfMeasure">The optional, requested output unit of measure.</param>
   /// <returns>The angle whose hyperbolic cosine is the specified number.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<Angle> Acosh(double value, Angle? outputUnitOfMeasure = null)
   {
      var degreesRadians = Math.Acosh(value).As(Angles.Radian);
      
      return outputUnitOfMeasure is null
                ? degreesRadians
                : degreesRadians.To(outputUnitOfMeasure);
   }
   
   /// <summary>
   /// Returns the angle whose sine is the specified number.
   /// </summary>
   /// <param name="value">the number to perform the inverse sine function on.</param>
   /// <param name="outputUnitOfMeasure">The optional, requested output unit of measure.</param>
   /// <returns>The angle whose sine is the specified number.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<Angle> Asin(double value, Angle? outputUnitOfMeasure = null)
   {
      var degreesRadians = Math.Asin(value).As(Angles.Radian);
      
      return outputUnitOfMeasure is null
                ? degreesRadians
                : degreesRadians.To(outputUnitOfMeasure);
   }
   
   /// <summary>
   /// Returns the angle whose hyperbolic sine is the specified number.
   /// </summary>
   /// <param name="value">the number to perform the inverse hyperbolic sine function on.</param>
   /// <param name="outputUnitOfMeasure">The optional, requested output unit of measure.</param>
   /// <returns>The angle whose hyperbolic sine is the specified number.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<Angle> Asinh(double value, Angle? outputUnitOfMeasure = null)
   {
      var degreesRadians = Math.Asinh(value).As(Angles.Radian);
      
      return outputUnitOfMeasure is null
                ? degreesRadians
                : degreesRadians.To(outputUnitOfMeasure);
   }
   
   /// <summary>
   /// Returns the angle whose tangent is the specified number.
   /// </summary>
   /// <param name="value">the number to perform the inverse tangent function on.</param>
   /// <param name="outputUnitOfMeasure">The optional, requested output unit of measure.</param>
   /// <returns>The angle whose inverse tangent is the specified number.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<Angle> Atan(double value, Angle? outputUnitOfMeasure = null)
   {
      var degreesRadians = Math.Atan(value).As(Angles.Radian);
      
      return outputUnitOfMeasure is null
                ? degreesRadians
                : degreesRadians.To(outputUnitOfMeasure);
   }
   
   /// <summary>
   /// Returns the angle whose tangent is the specified number.
   /// </summary>
   /// <param name="y">the y coordinate of a point.</param>
   /// <param name="x">the x coordinate of a point.</param>
   /// <param name="outputUnitOfMeasure">The optional, requested output unit of measure.</param>
   /// <returns>The angle whose inverse tangent is the specified number.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<Angle> Atan2(double y, double x, Angle? outputUnitOfMeasure = null)
   {
      var degreesRadians = Math.Atan2(y, x).As(Angles.Radian);
      
      return outputUnitOfMeasure is null
                ? degreesRadians
                : degreesRadians.To(outputUnitOfMeasure);
   }
   
   /// <summary>
   /// Returns the angle whose hyperbolic tangent is the specified number.
   /// </summary>
   /// <param name="value">the number to perform the inverse hyperbolic sine function on.</param>
   /// <param name="outputUnitOfMeasure">The optional, requested output unit of measure.</param>
   /// <returns>The angle whose hyperbolic tangent is the specified number.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static Quantity<Angle> Atanh(double value, Angle? outputUnitOfMeasure = null)
   {
      var degreesRadians = Math.Atanh(value).As(Angles.Radian);
      
      return outputUnitOfMeasure is null
                ? degreesRadians
                : degreesRadians.To(outputUnitOfMeasure);
   }
   
   /// <summary>
   /// Returns the cosine of the specified angle.
   /// </summary>
   /// <param name="angle">The angle, in any unit of measure for <see cref="Angles" />.</param>
   /// <returns>The cosine of the specified angle.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double Cos(Quantity<Angle> angle)
   {
      var rv = (double) (angle.Unit == Angles.Radian
                            ? angle
                            : angle.To(Angles.Radian));
      
      return Math.Cos(rv);
   }
   
   /// <summary>
   /// Returns the hyperbolic cosine of the specified angle.
   /// </summary>
   /// <param name="angle">The angle, in any unit of measure for <see cref="Angles" />.</param>
   /// <returns>The hyperbolic cosine of the specified angle.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double Cosh(Quantity<Angle> angle)
   {
      var rv = (double) (angle.Unit == Angles.Radian
                            ? angle
                            : angle.To(Angles.Radian));
      
      return Math.Cosh(rv);
   }
   
   /// <summary>
   /// Returns the sine of the specified angle.
   /// </summary>
   /// <param name="angle">The angle, in any unit of measure for <see cref="Angles" />.</param>
   /// <returns>The sine of the specified angle.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double Sin(Quantity<Angle> angle)
   {
      var rv = (double) (angle.Unit == Angles.Radian
                            ? angle
                            : angle.To(Angles.Radian));
      
      return Math.Sin(rv);
   }
   
   /// <summary>
   /// Returns the hyperbolic sine of the specified angle.
   /// </summary>
   /// <param name="angle">The angle, in any unit of measure for <see cref="Angles" />.</param>
   /// <returns>The hyperbolic sine of the specified angle.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double Sinh(Quantity<Angle> angle)
   {
      var rv = (double) (angle.Unit == Angles.Radian
                            ? angle
                            : angle.To(Angles.Radian));
      
      return Math.Sinh(rv);
   }
   
   /// <summary>
   /// Returns the hyperbolic sine of the specified angle.
   /// </summary>
   /// <param name="angle">The angle, in any unit of measure for <see cref="Angles" />.</param>
   /// <returns>The hyperbolic sine of the specified angle.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static (double Sin, double Cos) SinCos(Quantity<Angle> angle)
   {
      var rv = (double) (angle.Unit == Angles.Radian
                            ? angle
                            : angle.To(Angles.Radian));
      
      return Math.SinCos(rv);
   }
   
   /// <summary>
   /// Returns the tangent of the specified angle.
   /// </summary>
   /// <param name="angle">The angle, in any unit of measure for <see cref="Angles" />.</param>
   /// <returns>The tangent of the specified angle.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double Tan(Quantity<Angle> angle)
   {
      var rv = (double) (angle.Unit == Angles.Radian
                            ? angle
                            : angle.To(Angles.Radian));
      
      return Math.Tan(rv);
   }
   
   /// <summary>
   /// Returns the hyperbolic tangent of the specified angle.
   /// </summary>
   /// <param name="angle">The angle, in any unit of measure for <see cref="Angles" />.</param>
   /// <returns>The hyperbolic tangent of the specified angle.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double Tanh(Quantity<Angle> angle)
   {
      var rv = (double) (angle.Unit == Angles.Radian
                            ? angle
                            : angle.To(Angles.Radian));
      
      return Math.Tanh(rv);
   }
   
   #endregion
}