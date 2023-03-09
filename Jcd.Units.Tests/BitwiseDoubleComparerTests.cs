#region

using Jcd.Units.DoubleComparison;

#endregion

namespace Jcd.Units.Tests;

public class BitwiseDoubleComparerTests
{
   [Theory]
   [InlineData(0.0, 0.1, -1)]
   [InlineData(0.0, 0.0, 0)]
   [InlineData(0.1, 0.0, 1)]
   public void Compare_Returns_Expected_Value(double x, double y, int expected)
   {
      var cmp = BitwiseDoubleComparer.Default;
      Assert.Equal(expected, cmp.Compare(x, y));
   }

   [Theory]
   [InlineData(0.0, 0.1, false)]
   [InlineData(0.0, 0.0, true)]
   [InlineData(0.1, 0.0, false)]
   public void Equals_Returns_Expected_Value(double x, double y, bool expected)
   {
      var cmp = BitwiseDoubleComparer.Default;
      Assert.Equal(expected, cmp.Equals(x, y));
   }

   [Theory]
   [InlineData(-0.1)]
   [InlineData(0.0)]
   [InlineData(0.1)]
   public void GetHashCode_Returns_Expected_Value(double x)
   {
      var cmp = BitwiseDoubleComparer.Default;
      Assert.Equal(x.GetHashCode(), cmp.GetHashCode(x));
   }
}
