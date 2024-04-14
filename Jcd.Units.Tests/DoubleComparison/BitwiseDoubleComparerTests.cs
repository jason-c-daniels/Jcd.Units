#region

using Jcd.Units.DoubleComparison;

#endregion

namespace Jcd.Units.Tests.DoubleComparison;

public class BitwiseDoubleComparerTests
{
   [Theory]
   [InlineData(1.10,         1.55,         -1)]
   [InlineData(1.23,         1.23,         0)]
   [InlineData(1.55,         1.22,         1)]
   [InlineData(1.101,        1.555,        -1)]
   [InlineData(1.123,        1.123,        0)]
   [InlineData(1.555,        1.501,        1)]
   [InlineData(1001.1001,    1001.5055,    -1)]
   [InlineData(1001.1023,    1001.1023,    0)]
   [InlineData(1001.5055,    1001.5001,    1)]
   [InlineData(1001.1000001, 1001.5000055, -1)]
   [InlineData(1001.1000023, 1001.1000023, 0)]
   [InlineData(1001.5000055, 1001.5000001, 1)]
   public void Compare_Returns_Expected_Result(double x, double y, int expectedResult)
   {
      var sut = BitwiseDoubleComparer.Instance;
      Assert.Equal(expectedResult, sut.Compare(x, y));
   }
   
   [Theory]
   [InlineData(1.10,         1.55,         false)]
   [InlineData(1.23,         1.23,         true)]
   [InlineData(1.55,         1.22,         false)]
   [InlineData(1.101,        1.555,        false)]
   [InlineData(1.123,        1.123,        true)]
   [InlineData(1.555,        1.501,        false)]
   [InlineData(1001.1001,    1001.5055,    false)]
   [InlineData(1001.1023,    1001.1023,    true)]
   [InlineData(1001.5055,    1001.5001,    false)]
   [InlineData(1001.1000001, 1001.5000055, false)]
   [InlineData(1001.1000023, 1001.1000023, true)]
   [InlineData(1001.5000055, 1001.5000001, false)]
   public void Equals_Returns_Expected_Result(double x, double y, bool expectedResult)
   {
      var sut = BitwiseDoubleComparer.Instance;
      Assert.Equal(expectedResult, sut.Equals(x, y));
   }
   
   [Theory]
   [InlineData(1.23,         1.23)]
   [InlineData(1.123,        1.123)]
   [InlineData(1001.1023,    1001.1023)]
   [InlineData(1001.1000023, 1001.1000023)]
   public void GetHashCode_Returns_Equal_Values(double x, double y)
   {
      var sut = BitwiseDoubleComparer.Instance;
      var hx = sut.GetHashCode(x);
      var hy = sut.GetHashCode(y);
      Assert.Equal(hx, hy);
   }
}