#region

using Jcd.Units.DoubleComparison;

#endregion

namespace Jcd.Units.Tests.DoubleComparison;

public class BuiltInRoundingComparerTests
{
   [Theory]
   [InlineData(1.10,         1.55,         1, -1)]
   [InlineData(1.23,         1.24,         1, 0)]
   [InlineData(1.55,         1.22,         1, 1)]
   [InlineData(1.101,        1.555,        2, -1)]
   [InlineData(1.123,        1.124,        2, 0)]
   [InlineData(1.555,        1.501,        2, 1)]
   [InlineData(1001.1001,    1001.5055,    3, -1)]
   [InlineData(1001.1023,    1001.1024,    3, 0)]
   [InlineData(1001.5055,    1001.5001,    3, 1)]
   [InlineData(1001.1000001, 1001.5000055, 6, -1)]
   [InlineData(1001.1000023, 1001.1000024, 6, 0)]
   [InlineData(1001.5000055, 1001.5000001, 6, 1)]
   public void Compare_Returns_Expected_Result(double x, double y, int precision, int expectedResult)
   {
      var sut = new BuiltInRoundingComparer(precision);
      Assert.Equal(expectedResult, sut.Compare(x, y));
   }

   [Theory]
   [InlineData(1.10,         1.55,         1, false)]
   [InlineData(1.23,         1.24,         1, true)]
   [InlineData(1.55,         1.22,         1, false)]
   [InlineData(1.101,        1.555,        2, false)]
   [InlineData(1.123,        1.124,        2, true)]
   [InlineData(1.555,        1.501,        2, false)]
   [InlineData(1001.1001,    1001.5055,    3, false)]
   [InlineData(1001.1023,    1001.1024,    3, true)]
   [InlineData(1001.5055,    1001.5001,    3, false)]
   [InlineData(1001.1000001, 1001.5000055, 6, false)]
   [InlineData(1001.1000023, 1001.1000024, 6, true)]
   [InlineData(1001.5000055, 1001.5000001, 6, false)]
   public void Equals_Returns_Expected_Result(double x, double y, int precision, bool expectedResult)
   {
      var sut = new BuiltInRoundingComparer(precision);
      Assert.Equal(expectedResult, sut.Equals(x, y));
   }

   [Theory]
   [InlineData(1.23,         1.24,         1)]
   [InlineData(1.123,        1.124,        2)]
   [InlineData(1001.1023,    1001.1024,    3)]
   [InlineData(1001.1000023, 1001.1000024, 6)]
   public void GetHashCode_Returns_Equal_Values(double x, double y, int precision)
   {
      var sut = new BuiltInRoundingComparer(precision);
      var hx = sut.GetHashCode(x);
      var hy = sut.GetHashCode(y);
      Assert.Equal(hx, hy);
   }

   [Fact]
   public void Static_Properties_Have_Correct_Values()
   {
      Verify(0,  BuiltInRoundingComparer.WholeNumber);
      Verify(1,  BuiltInRoundingComparer.OneDecimalPlace);
      Verify(2,  BuiltInRoundingComparer.TwoDecimalPlaces);
      Verify(3,  BuiltInRoundingComparer.ThreeDecimalPlaces);
      Verify(4,  BuiltInRoundingComparer.FourDecimalPlaces);
      Verify(5,  BuiltInRoundingComparer.FiveDecimalPlaces);
      Verify(6,  BuiltInRoundingComparer.SixDecimalPlaces);
      Verify(9,  BuiltInRoundingComparer.NineDecimalPlaces);
      Verify(10, BuiltInRoundingComparer.TenDecimalPlaces);
      Verify(15, BuiltInRoundingComparer.FifteenDecimalPlaces);
      Verify(15, BuiltInRoundingComparer.Default);

      void Verify(int expectedDecimalPlaces, BuiltInRoundingComparer item)
      {
         Assert.Equal(expectedDecimalPlaces,   item.DecimalPlaces);
         Assert.Equal(MidpointRounding.ToEven, item.RoundingMethod);
      }
   }
}