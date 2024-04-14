#region

using Jcd.Units.DoubleComparison;
using Jcd.Units.UnitsOfMeasure;
using Jcd.Units.UnitTypes;

using Amounts = Jcd.Units.UnitsOfMeasure.USCustomary.Amounts;

#endregion

namespace Jcd.Units.Tests;

public class MathQTests
{
   #region Abs, Ceiling, Floor, Min, Max and similar

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Abs_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Abs(q);
      Assert.Equal(unit,             r.Unit);
      Assert.Equal(Math.Abs(number), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Ceiling_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Ceiling(q);
      Assert.Equal(unit,                 r.Unit);
      Assert.Equal(Math.Ceiling(number), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Floor_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Floor(q);
      Assert.Equal(unit,               r.Unit);
      Assert.Equal(Math.Floor(number), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Truncate_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Truncate(q);
      Assert.Equal(unit,                  r.Unit);
      Assert.Equal(Math.Truncate(number), (double) r);
   }

   [Theory]
   [MemberData(nameof(RoundingParams))]
   public void Round_Returns_Expected_Value_In_Expected_Units(double number, Amount unit, int digits, MidpointRounding method)
   {
      var q = number.As(unit);
      var r = MathQ.Round(q, digits, method);
      Assert.Equal(unit,                               r.Unit);
      Assert.Equal(Math.Round(number, digits, method), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumberAndUnitPairs))]
   public void Min_Returns_Expected_Quantity(double x, double y, Amount unit1, Amount unit2)
   {
      var qx = x.As(unit1);
      var qy = y.As(unit2);
      var r = MathQ.Min(qx, qy);
      Assert.Equal(qx <= qy
                      ? qx
                      : qy
                 , r
                  );
   }

   [Theory]
   [MemberData(nameof(NumberAndUnitPairs))]
   public void Max_Returns_Expected_Quantity(double x, double y, Amount unit1, Amount unit2)
   {
      var qx = x.As(unit1);
      var qy = y.As(unit2);
      var r = MathQ.Max(qx, qy);
      Assert.Equal(qx >= qy
                      ? qx
                      : qy
                 , r
                  );
   }

   [Theory]
   [MemberData(nameof(NumberAndUnitTrios))]
   public void Clamp_Returns_Expected_Value_In_Expected_Units(double x, double y, double z, Amount unitX, Amount unitY, Amount unitZ)
   {
      // ReSharper disable IdentifierTypo
      var qx = x.As(unitX);
      var qy = y.As(unitY);
      var qz = z.As(unitZ);

      var qy1 = qy;
      var qz1 = qz;
      var qmin = MathQ.Min(qy1, qz1);
      var qmax = MathQ.Max(qy1, qz1);

      // ReSharper restore IdentifierTypo

      var min = (double) qmin.To(qx.Unit);
      var max = (double) qmax.To(qx.Unit);

      var r = MathQ.Clamp(qx, qmin, qmax);

      Assert.Equal(unitX,                   r.Unit);
      Assert.Equal(Math.Clamp(x, min, max), (double) r);
   }

   #endregion

   #region Exponents, Logarithms, Powers, Sign, and Roots

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Exp_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Exp(q);
      Assert.Equal(unit,             r.Unit);
      Assert.Equal(Math.Exp(number), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Log_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Log(q);
      Assert.Equal(unit,             r.Unit);
      Assert.Equal(Math.Log(number), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumbersCountUnitsAndBases))]
   public void Log_With_Base_Returns_Expected_Value_In_Expected_Units(double number, Amount unit, double @base)
   {
      var q = number.As(unit);
      var r = MathQ.Log(q, @base);
      Assert.Equal(unit,                    r.Unit);
      Assert.Equal(Math.Log(number, @base), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Log10_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Log10(q);
      Assert.Equal(unit,               r.Unit);
      Assert.Equal(Math.Log10(number), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Log2_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Log2(q);
      Assert.Equal(unit,              r.Unit);
      Assert.Equal(Math.Log2(number), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Cbrt_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Cbrt(q);
      Assert.Equal(unit,              r.Unit);
      Assert.Equal(Math.Cbrt(number), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumbersCountUnitsAndBases))]
   public void Pow_Returns_Expected_Value_In_Expected_Units(double number, Amount unit, double pow)
   {
      var q = number.As(unit);
      var r = MathQ.Pow(q, pow);
      Assert.Equal(unit,                  r.Unit);
      Assert.Equal(Math.Pow(number, pow), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Sqrt_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Sqrt(q);
      Assert.Equal(unit,              r.Unit);
      Assert.Equal(Math.Sqrt(number), (double) r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Sign_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Sign(q);
      Assert.Equal(Math.Sign(number), r);
   }

   #endregion

   #region Trigonometry Functions

   [Theory]
   [InlineData(0d)]
   [InlineData(359d)]
   [InlineData(360d)]
   [InlineData(180d)]
   [InlineData(45d)]
   [InlineData(275d)]
   public void Cos_Returns_Expected_Value(double angleInDegrees)
   {
      var degree = angleInDegrees.As(Angles.Degree);
      var arcsecond = degree.To(Angles.ArcSecond);
      var arcminute = degree.To(Angles.Degree);
      var radian = degree.To(Angles.Radian);
      var angleInRadian = (double) radian;
      Assert.Equal(Math.Cos(angleInRadian), MathQ.Cos(radian));
      Assert.Equal(Math.Cos(angleInRadian), MathQ.Cos(degree));
      Assert.Equal(Math.Cos(angleInRadian), MathQ.Cos(arcsecond));
      Assert.Equal(Math.Cos(angleInRadian), MathQ.Cos(arcminute));
   }

   [Theory]
   [InlineData(0d)]
   [InlineData(359d)]
   [InlineData(360d)]
   [InlineData(180d)]
   [InlineData(45d)]
   [InlineData(275d)]
   public void Sin_Returns_Expected_Value(double angleInDegrees)
   {
      var degree = angleInDegrees.As(Angles.Degree);
      var arcsecond = degree.To(Angles.ArcSecond);
      var arcminute = degree.To(Angles.Degree);
      var radian = degree.To(Angles.Radian);
      var angleInRadian = (double) radian;
      Assert.Equal(Math.Sin(angleInRadian), MathQ.Sin(radian));
      Assert.Equal(Math.Sin(angleInRadian), MathQ.Sin(degree));
      Assert.Equal(Math.Sin(angleInRadian), MathQ.Sin(arcsecond));
      Assert.Equal(Math.Sin(angleInRadian), MathQ.Sin(arcminute));
   }

   [Theory]
   [InlineData(0d)]
   [InlineData(359d)]
   [InlineData(360d)]
   [InlineData(180d)]
   [InlineData(45d)]
   [InlineData(275d)]
   public void Tan_Returns_Expected_Value(double angleInDegrees)
   {
      var degree = angleInDegrees.As(Angles.Degree);
      var arcsecond = degree.To(Angles.ArcSecond);
      var arcminute = degree.To(Angles.Degree);
      var radian = degree.To(Angles.Radian);
      var angleInRadian = (double) radian;
      Assert.Equal(Math.Tan(angleInRadian), MathQ.Tan(radian));
      Assert.Equal(Math.Tan(angleInRadian), MathQ.Tan(degree));
      Assert.Equal(Math.Tan(angleInRadian), MathQ.Tan(arcsecond));
      Assert.Equal(Math.Tan(angleInRadian), MathQ.Tan(arcminute));
   }

   [Theory]
   [InlineData(0d)]
   [InlineData(359d)]
   [InlineData(360d)]
   [InlineData(180d)]
   [InlineData(45d)]
   [InlineData(275d)]
   public void Cosh_Returns_Expected_Value(double angleInDegrees)
   {
      var degree = angleInDegrees.As(Angles.Degree);
      var arcsecond = degree.To(Angles.ArcSecond);
      var arcminute = degree.To(Angles.Degree);
      var radian = degree.To(Angles.Radian);
      var angleInRadian = (double) radian;
      Assert.Equal(Math.Cosh(angleInRadian), MathQ.Cosh(radian));
      Assert.Equal(Math.Cosh(angleInRadian), MathQ.Cosh(degree));
      Assert.Equal(Math.Cosh(angleInRadian), MathQ.Cosh(arcsecond));
      Assert.Equal(Math.Cosh(angleInRadian), MathQ.Cosh(arcminute));
   }

   [Theory]
   [InlineData(0d)]
   [InlineData(359d)]
   [InlineData(360d)]
   [InlineData(180d)]
   [InlineData(45d)]
   [InlineData(275d)]
   public void Sinh_Returns_Expected_Value(double angleInDegrees)
   {
      var degree = angleInDegrees.As(Angles.Degree);
      var arcsecond = degree.To(Angles.ArcSecond);
      var arcminute = degree.To(Angles.Degree);
      var radian = degree.To(Angles.Radian);
      var angleInRadian = (double) radian;
      Assert.Equal(Math.Sinh(angleInRadian), MathQ.Sinh(radian));
      Assert.Equal(Math.Sinh(angleInRadian), MathQ.Sinh(degree));
      Assert.Equal(Math.Sinh(angleInRadian), MathQ.Sinh(arcsecond));
      Assert.Equal(Math.Sinh(angleInRadian), MathQ.Sinh(arcminute));
   }

   [Theory]
   [InlineData(0d)]
   [InlineData(359d)]
   [InlineData(360d)]
   [InlineData(180d)]
   [InlineData(45d)]
   [InlineData(275d)]
   public void Tanh_Returns_Expected_Value(double angleInDegrees)
   {
      var degree = angleInDegrees.As(Angles.Degree);
      var arcsecond = degree.To(Angles.ArcSecond);
      var arcminute = degree.To(Angles.Degree);
      var radian = degree.To(Angles.Radian);
      var angleInRadian = (double) radian;
      Assert.Equal(Math.Tanh(angleInRadian), MathQ.Tanh(radian));
      Assert.Equal(Math.Tanh(angleInRadian), MathQ.Tanh(degree));
      Assert.Equal(Math.Tanh(angleInRadian), MathQ.Tanh(arcsecond));
      Assert.Equal(Math.Tanh(angleInRadian), MathQ.Tanh(arcminute));
   }

   [Theory]
   [InlineData(0d)]
   [InlineData(359d)]
   [InlineData(360d)]
   [InlineData(180d)]
   [InlineData(45d)]
   [InlineData(275d)]
   public void SinCos_Returns_Expected_Value(double angleInDegrees)
   {
      var degree = angleInDegrees.As(Angles.Degree);
      var arcsecond = degree.To(Angles.ArcSecond);
      var arcminute = degree.To(Angles.Degree);
      var radian = degree.To(Angles.Radian);
      var angleInRadian = (double) radian;
      Assert.Equal(Math.SinCos(angleInRadian), MathQ.SinCos(radian));
      Assert.Equal(Math.SinCos(angleInRadian), MathQ.SinCos(degree));
      Assert.Equal(Math.SinCos(angleInRadian), MathQ.SinCos(arcsecond));
      Assert.Equal(Math.SinCos(angleInRadian), MathQ.SinCos(arcminute));
   }

   [Theory]
   [InlineData(1.0d)]
   [InlineData(0.5d)]
   [InlineData(0.3d)]
   [InlineData(-0.3d)]
   [InlineData(-0.5d)]
   [InlineData(-1.0d)]
   public void Acos_Returns_Expected_Value(double cos)
   {
      var comparer = BuiltInRoundingComparer.TenDecimalPlaces;
      Assert.Equal(Math.Acos(cos), (double) MathQ.Acos(cos),                comparer);
      Assert.Equal(Math.Acos(cos), (double) MathQ.Acos(cos, Angles.Radian), comparer);

      Assert.Equal(Math.Acos(cos), (double) MathQ.Acos(cos, Angles.Degree).To(Angles.Radian), comparer);

      Assert.Equal(Math.Acos(cos), (double) MathQ.Acos(cos, Angles.ArcSecond).To(Angles.Radian), comparer);

      Assert.Equal(Math.Acos(cos), (double) MathQ.Acos(cos, Angles.ArcMinute).To(Angles.Radian), comparer);

      Assert.Equal(Math.Acos(cos), (double) MathQ.Acos(cos, Angles.Gradian).To(Angles.Radian), comparer);
   }

   [Theory]
   [InlineData(1.0d)]
   [InlineData(0.5d)]
   [InlineData(0.3d)]
   [InlineData(-0.3d)]
   [InlineData(-0.5d)]
   [InlineData(-1.0d)]
   public void Asin_Returns_Expected_Value(double sin)
   {
      var comparer = BuiltInRoundingComparer.TenDecimalPlaces;
      Assert.Equal(Math.Asin(sin), (double) MathQ.Asin(sin),                comparer);
      Assert.Equal(Math.Asin(sin), (double) MathQ.Asin(sin, Angles.Radian), comparer);

      Assert.Equal(Math.Asin(sin), (double) MathQ.Asin(sin, Angles.Degree).To(Angles.Radian), comparer);

      Assert.Equal(Math.Asin(sin), (double) MathQ.Asin(sin, Angles.ArcSecond).To(Angles.Radian), comparer);

      Assert.Equal(Math.Asin(sin), (double) MathQ.Asin(sin, Angles.ArcMinute).To(Angles.Radian), comparer);

      Assert.Equal(Math.Asin(sin), (double) MathQ.Asin(sin, Angles.Gradian).To(Angles.Radian), comparer);
   }

   [Theory]
   [InlineData(1.0d)]
   [InlineData(0.5d)]
   [InlineData(0.3d)]
   [InlineData(-0.3d)]
   [InlineData(-0.5d)]
   [InlineData(-1.0d)]
   public void Atan_Returns_Expected_Value(double tan)
   {
      var comparer = BuiltInRoundingComparer.FifteenDecimalPlaces;
      Assert.Equal(Math.Atan(tan), (double) MathQ.Atan(tan),                comparer);
      Assert.Equal(Math.Atan(tan), (double) MathQ.Atan(tan, Angles.Radian), comparer);

      Assert.Equal(Math.Atan(tan), (double) MathQ.Atan(tan, Angles.Degree).To(Angles.Radian), comparer);

      Assert.Equal(Math.Atan(tan), (double) MathQ.Atan(tan, Angles.ArcSecond).To(Angles.Radian), comparer);

      Assert.Equal(Math.Atan(tan), (double) MathQ.Atan(tan, Angles.ArcMinute).To(Angles.Radian), comparer);

      Assert.Equal(Math.Atan(tan), (double) MathQ.Atan(tan, Angles.Gradian).To(Angles.Radian), comparer);
   }

   [Theory]
   [InlineData(1.0d,   1.5d)]
   [InlineData(0.5d,   200d)]
   [InlineData(0.3d,   -3.5d)]
   [InlineData(-25.3d, 75d)]
   [InlineData(-13.5d, 32d)]
   [InlineData(-1.0d,  13d)]
   public void Atan2_Returns_Expected_Value(double x, double y)
   {
      var comparer = BuiltInRoundingComparer.TenDecimalPlaces;
      Assert.Equal(Math.Atan2(x, y), (double) MathQ.Atan2(x, y),                comparer);
      Assert.Equal(Math.Atan2(x, y), (double) MathQ.Atan2(x, y, Angles.Radian), comparer);

      Assert.Equal(Math.Atan2(x, y), (double) MathQ.Atan2(x, y, Angles.Degree).To(Angles.Radian), comparer);

      Assert.Equal(Math.Atan2(x, y), (double) MathQ.Atan2(x, y, Angles.ArcSecond).To(Angles.Radian), comparer);

      Assert.Equal(Math.Atan2(x, y), (double) MathQ.Atan2(x, y, Angles.ArcMinute).To(Angles.Radian), comparer);

      Assert.Equal(Math.Atan2(x, y), (double) MathQ.Atan2(x, y, Angles.Gradian).To(Angles.Radian), comparer);
   }

   [Theory]
   [InlineData(1.1d)]
   [InlineData(11111110.5d)]
   [InlineData(111111110.3d)]
   [InlineData(110.3d)]
   [InlineData(110.5d)]
   [InlineData(111.0d)]
   public void Acosh_Returns_Expected_Value(double tan)
   {
      var comparer = BuiltInRoundingComparer.TenDecimalPlaces;
      Assert.Equal(Math.Acosh(tan), (double) MathQ.Acosh(tan),                comparer);
      Assert.Equal(Math.Acosh(tan), (double) MathQ.Acosh(tan, Angles.Radian), comparer);

      Assert.Equal(Math.Acosh(tan), (double) MathQ.Acosh(tan, Angles.Degree).To(Angles.Radian), comparer);

      Assert.Equal(Math.Acosh(tan), (double) MathQ.Acosh(tan, Angles.ArcSecond).To(Angles.Radian), comparer);

      Assert.Equal(Math.Acosh(tan), (double) MathQ.Acosh(tan, Angles.ArcMinute).To(Angles.Radian), comparer);

      Assert.Equal(Math.Acosh(tan), (double) MathQ.Acosh(tan, Angles.Gradian).To(Angles.Radian), comparer);
   }

   [Theory]
   [InlineData(1.1d)]
   [InlineData(11111110.5d)]
   [InlineData(111111110.3d)]
   [InlineData(110.3d)]
   [InlineData(110.5d)]
   [InlineData(111.0d)]
   public void Asinh_Returns_Expected_Value(double tan)
   {
      var comparer = BuiltInRoundingComparer.TenDecimalPlaces;
      Assert.Equal(Math.Asinh(tan), (double) MathQ.Asinh(tan),                comparer);
      Assert.Equal(Math.Asinh(tan), (double) MathQ.Asinh(tan, Angles.Radian), comparer);

      Assert.Equal(Math.Asinh(tan), (double) MathQ.Asinh(tan, Angles.Degree).To(Angles.Radian), comparer);

      Assert.Equal(Math.Asinh(tan), (double) MathQ.Asinh(tan, Angles.ArcSecond).To(Angles.Radian), comparer);

      Assert.Equal(Math.Asinh(tan), (double) MathQ.Asinh(tan, Angles.ArcMinute).To(Angles.Radian), comparer);

      Assert.Equal(Math.Asinh(tan), (double) MathQ.Asinh(tan, Angles.Gradian).To(Angles.Radian), comparer);
   }

   [Theory]
   [InlineData(1.0d)]
   [InlineData(0.5d)]
   [InlineData(0.3d)]
   [InlineData(-0.3d)]
   [InlineData(-0.5d)]
   [InlineData(-1.0d)]
   public void Atanh_Returns_Expected_Value(double tan)
   {
      var comparer = BuiltInRoundingComparer.FifteenDecimalPlaces;
      Assert.Equal(Math.Atanh(tan), (double) MathQ.Atanh(tan),                comparer);
      Assert.Equal(Math.Atanh(tan), (double) MathQ.Atanh(tan, Angles.Radian), comparer);

      Assert.Equal(Math.Atanh(tan), (double) MathQ.Atanh(tan, Angles.Degree).To(Angles.Radian), comparer);

      Assert.Equal(Math.Atanh(tan), (double) MathQ.Atanh(tan, Angles.ArcSecond).To(Angles.Radian), comparer);

      Assert.Equal(Math.Atanh(tan), (double) MathQ.Atanh(tan, Angles.ArcMinute).To(Angles.Radian), comparer);

      Assert.Equal(Math.Atanh(tan), (double) MathQ.Atanh(tan, Angles.Gradian).To(Angles.Radian), comparer);
   }

   #endregion

   #region MemberData providers

   /// <summary>
   /// returns a set of Amount units and number pairs
   /// </summary>
   public static IEnumerable<object[]> NumbersAndCountUnits
   {
      get
      {
         var units = new[] { Amounts.Count, Amounts.TenCount, Amounts.HundredCount };
         var numbers = new[] { 10.0, -10.0, 31.6, -31.6 };

         return from number in numbers from unit in units select new object[] { number, unit };
      }
   }

   /// <summary>
   /// returns a set of Amount units and number pairs
   /// </summary>
   public static IEnumerable<object[]> NumbersCountUnitsAndBases
   {
      get
      {
         var units = new[] { Amounts.Count, Amounts.TenCount, Amounts.HundredCount };
         var numbers = new[] { 10.0, -10.0, 31.6, -31.6 };
         var bases = new[] { 2d, 4d, 8d, 10d, 16d };

         return from number in numbers from unit in units from @base in bases select new object[] { number, unit, @base };
      }
   }

   /// <summary>
   /// returns a set of Amount units and number pairs (number1, number2, unit1, unit 2)
   /// </summary>
   public static IEnumerable<object[]> NumberAndUnitPairs
   {
      get
      {
         var units = new[] { Amounts.Count, Amounts.TenCount, Amounts.HundredCount };
         var numbers = new[] { 1.2, 3.5, 3.7, 10.0, -10.0, 31.6, -31.6, -3.7, -3.5 };

         return from number1 in numbers from number2 in numbers from unit1 in units from unit2 in units select new object[] { number1, number2, unit1, unit2 };
      }
   }

   /// <summary>
   /// returns a set of Amount units and number trios (number1, number2, number3, unit1, unit2, unit3)
   /// </summary>
   public static IEnumerable<object[]> NumberAndUnitTrios
   {
      get
      {
         var units = new[] { Amounts.Count, Amounts.TenCount };
         var numbers = new[] { 1.2, 31.6, -3.7, -3.5 };

         return
            from number1 in numbers
            from number2 in numbers
            from number3 in numbers
            from unit1 in units
            from unit2 in units
            from unit3 in units
            select new object[] { number1, number2, number3, unit1, unit2, unit3 };
      }
   }

   /// <summary>
   /// returns a set of value, Amounts units, number of digits to round to, and rounding method.
   /// </summary>
   public static IEnumerable<object[]> RoundingParams
   {
      get
      {
         var units = new[] { Amounts.Count, Amounts.TenCount, Amounts.HundredCount };
         var numbers = new[] { 10.0 + 1d / 3d, -10.11 + 2d / 3d, 31.12 + 1d / 3d, -31.6 + 1d / 3d };
         var places = new[] { 0, 1, 3, 6, 12, 15 };

         var methods = new[]
                       {
                          MidpointRounding.ToEven
                        , MidpointRounding.ToZero
                        , MidpointRounding.AwayFromZero
                        , MidpointRounding.ToNegativeInfinity
                        , MidpointRounding.ToPositiveInfinity
                       };

         return from number in numbers from unit in units from digits in places from method in methods select new object[] { number, unit, digits, method };
      }
   }

   #endregion
}