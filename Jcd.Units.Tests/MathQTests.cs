#region

using Jcd.Units.UnitsOfMeasure.USCustomary;
using Jcd.Units.UnitTypes;

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
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Abs(number), (double)r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Ceiling_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Ceiling(q);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Ceiling(number), (double)r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Floor_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Floor(q);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Floor(number), (double)r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Truncate_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Truncate(q);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Truncate(number), (double)r);
   }

   [Theory]
   [MemberData(nameof(RoundingParams))]
   public void Round_Returns_Expected_Value_In_Expected_Units
            (double number, Amount unit, int digits, MidpointRounding method)
   {
      var q = number.As(unit);
      var r = MathQ.Round(q, digits, method);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Round(number, digits, method), (double)r);
   }

   [Theory]
   [MemberData(nameof(NumberPairsAndUnitPairs))]
   public void Min_Returns_Expected_Value_In_Expected_Units(double x, double y, Amount unit1, Amount unit2)
   {
      var qx = x.As(unit1);
      var qy = y.As(unit2);
      var r  = MathQ.Min(qx, qy);
      Assert.Equal(qx <= qy ? qx : qy, r);
   }

   [Theory]
   [MemberData(nameof(NumberPairsAndUnitPairs))]
   public void Max_Returns_Expected_Value_In_Expected_Units(double x, double y, Amount unit1, Amount unit2)
   {
      var qx = x.As(unit1);
      var qy = y.As(unit2);
      var r  = MathQ.Max(qx, qy);
      Assert.Equal(qx >= qy ? qx : qy, r);
   }

   #endregion

   #region Exponents, Logarithms, Powers, Sign, and Roots

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Exp_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Exp(q);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Exp(number), (double)r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Log_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Log(q);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Log(number), (double)r);
   }

   [Theory]
   [MemberData(nameof(NumbersCountUnitsAndBases))]
   public void Log_With_Base_Returns_Expected_Value_In_Expected_Units(double number, Amount unit, double @base)
   {
      var q = number.As(unit);
      var r = MathQ.Log(q, @base);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Log(number, @base), (double)r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Log10_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Log10(q);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Log10(number), (double)r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Log2_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Log2(q);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Log2(number), (double)r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Cbrt_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Cbrt(q);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Cbrt(number), (double)r);
   }

   [Theory]
   [MemberData(nameof(NumbersCountUnitsAndBases))]
   public void Pow_Returns_Expected_Value_In_Expected_Units(double number, Amount unit, double pow)
   {
      var q = number.As(unit);
      var r = MathQ.Pow(q, pow);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Pow(number, pow), (double)r);
   }

   [Theory]
   [MemberData(nameof(NumbersAndCountUnits))]
   public void Sqrt_Returns_Expected_Value_In_Expected_Units(double number, Amount unit)
   {
      var q = number.As(unit);
      var r = MathQ.Sqrt(q);
      Assert.Equal(unit, r.Unit);
      Assert.Equal(Math.Sqrt(number), (double)r);
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

   #region MemberData providers

   /// <summary>
   /// returns a set of Amount units and number pairs
   /// </summary>
   public static IEnumerable<object[]> NumbersAndCountUnits
   {
      get
      {
         var units   = new[] { Amounts.Count, Amounts.TenCount, Amounts.HundredCount };
         var numbers = new[] { 10.0, -10.0, 31.6, -31.6 };

         return
                  from number in numbers
                  from unit in units
                  select new object[] { number, unit };
      }
   }

   /// <summary>
   /// returns a set of Amount units and number pairs
   /// </summary>
   public static IEnumerable<object[]> NumbersCountUnitsAndBases
   {
      get
      {
         var units   = new[] { Amounts.Count, Amounts.TenCount, Amounts.HundredCount };
         var numbers = new[] { 10.0, -10.0, 31.6, -31.6 };
         var bases   = new[] { 2d, 4d, 8d, 10d, 16d };

         return
                  from number in numbers
                  from unit in units
                  from @base in bases
                  select new object[] { number, unit, @base };
      }
   }

   /// <summary>
   /// returns a set of Amount units and number pairs
   /// </summary>
   public static IEnumerable<object[]> NumberPairsAndUnitPairs
   {
      get
      {
         var units   = new[] { Amounts.Count, Amounts.TenCount, Amounts.HundredCount };
         var numbers = new[] { 1.2, 3.5, 3.7, 10.0, -10.0, 31.6, -31.6, -3.7, -3.5 };

         return
                  from number1 in numbers
                  from number2 in numbers
                  from unit1 in units
                  from unit2 in units
                  select new object[] { number1, number2, unit1, unit2 };
      }
   }

   /// <summary>
   /// returns a set of Amount units and number pairs
   /// </summary>
   public static IEnumerable<object[]> RoundingParams
   {
      get
      {
         var units   = new[] { Amounts.Count, Amounts.TenCount, Amounts.HundredCount };
         var numbers = new[] { 10.0 + 1d / 3d, -10.11 + 2d / 3d, 31.12 + 1d / 3d, -31.6 + 1d / 3d };
         var places  = new[] { 0, 1, 3, 6, 12, 15 };

         var methods = new[]
                       {
                                MidpointRounding.ToEven, MidpointRounding.ToZero, MidpointRounding.AwayFromZero
                              , MidpointRounding.ToNegativeInfinity, MidpointRounding.ToPositiveInfinity
                       };

         return
                  from number in numbers
                  from unit in units
                  from digits in places
                  from method in methods
                  select new object[] { number, unit, digits, method };
      }
   }

   #endregion
}
