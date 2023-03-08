#region

using Jcd.Units.Tests.TestHarnesses;
using Jcd.Units.UnitsOfMeasure;

#endregion

namespace Jcd.Units.Tests;

public class QuantityFactoryExtensionsTests
{
   [Theory]
   [InlineData(0d)]
   [InlineData(-1d         / 3d)]
   [InlineData(1d          / 3d)]
   [InlineData(-100d       / 3d)]
   [InlineData(100d        / 3d)]
   [InlineData(-100000d    / 3d)]
   [InlineData(100000d     / 3d)]
   [InlineData(-100000000d / 3d)]
   [InlineData(100000000d  / 3d)]
   public void Double_As_Unit_Creates_A_Quantity_For_The_Unit_With_The_Specified_Value_For_RawValue
            (double value)
   {
      var u = UnitOfMeasure1Units.DerivedUnit1;
      var q = value.As(u);
      Assert.Equal(u, q.Unit);
      Assert.Equal(value, q.RawValue);
   }

   [Theory]
   [InlineData(0f)]
   [InlineData(-1f         / 3f)]
   [InlineData(1f          / 3f)]
   [InlineData(-100f       / 3f)]
   [InlineData(100f        / 3f)]
   [InlineData(-100000f    / 3f)]
   [InlineData(100000f     / 3f)]
   [InlineData(-100000000f / 3f)]
   [InlineData(100000000f  / 3f)]
   public void Float_As_Unit_Creates_A_Quantity_For_The_Unit_With_The_Specified_Value_For_RawValue
            (float value)
   {
      var u = UnitOfMeasure1Units.DerivedUnit1;
      var q = value.As(u);
      Assert.Equal(u, q.Unit);
      Assert.Equal(value, q.RawValue);
   }

   [Theory]
   [InlineData(0L)]
   [InlineData(-1L)]
   [InlineData(1L)]
   [InlineData(-100L)]
   [InlineData(100L)]
   [InlineData(-100000L)]
   [InlineData(100000L)]
   [InlineData(-100000000L)]
   [InlineData(100000000L)]
   public void Int64_As_Unit_Creates_A_Quantity_For_The_Unit_With_The_Specified_Value_For_RawValue
            (long value)
   {
      var u = UnitOfMeasure1Units.DerivedUnit1;
      var q = value.As(u);
      Assert.Equal(u, q.Unit);
      Assert.Equal(value, q.RawValue);
   }

   [Theory]
   [InlineData(0UL)]
   [InlineData(2UL)]
   [InlineData(1UL)]
   [InlineData(200UL)]
   [InlineData(100UL)]
   [InlineData(200000UL)]
   [InlineData(100000UL)]
   [InlineData(200000000UL)]
   [InlineData(100000000UL)]
   public void UInt64_As_Unit_Creates_A_Quantity_For_The_Unit_With_The_Specified_Value_For_RawValue
            (ulong value)
   {
      var u = UnitOfMeasure1Units.DerivedUnit1;
      var q = value.As(u);
      Assert.Equal(u, q.Unit);
      Assert.Equal(value, q.RawValue);
   }

   [Theory]
   [InlineData(0)]
   [InlineData(-1)]
   [InlineData(1)]
   [InlineData(-100)]
   [InlineData(100)]
   [InlineData(-100000)]
   [InlineData(100000)]
   [InlineData(-100000000)]
   [InlineData(100000000)]
   public void Int32_As_Unit_Creates_A_Quantity_For_The_Unit_With_The_Specified_Value_For_RawValue
            (int value)
   {
      var u = UnitOfMeasure1Units.DerivedUnit1;
      var q = value.As(u);
      Assert.Equal(u, q.Unit);
      Assert.Equal(value, q.RawValue);
   }

   [Theory]
   [InlineData(0)]
   [InlineData(2)]
   [InlineData(1)]
   [InlineData(200)]
   [InlineData(100)]
   [InlineData(200000)]
   [InlineData(100000)]
   [InlineData(200000000)]
   [InlineData(100000000)]
   public void UInt32_As_Unit_Creates_A_Quantity_For_The_Unit_With_The_Specified_Value_For_RawValue
            (uint value)
   {
      var u = UnitOfMeasure1Units.DerivedUnit1;
      var q = value.As(u);
      Assert.Equal(u, q.Unit);
      Assert.Equal(value, q.RawValue);
   }

   [Theory]
   [InlineData(0)]
   [InlineData(-1)]
   [InlineData(1)]
   [InlineData(-100)]
   [InlineData(100)]
   [InlineData(-10000)]
   [InlineData(10000)]
   [InlineData(-30000)]
   [InlineData(30000)]
   public void Int16_As_Unit_Creates_A_Quantity_For_The_Unit_With_The_Specified_Value_For_RawValue
            (short value)
   {
      var u = UnitOfMeasure1Units.DerivedUnit1;
      var q = value.As(u);
      Assert.Equal(u, q.Unit);
      Assert.Equal(value, q.RawValue);
   }

   [Theory]
   [InlineData(0)]
   [InlineData(2)]
   [InlineData(1)]
   [InlineData(200)]
   [InlineData(100)]
   [InlineData(20000)]
   [InlineData(10000)]
   [InlineData(40000)]
   [InlineData(0xFFFF)]
   public void UInt16_As_Unit_Creates_A_Quantity_For_The_Unit_With_The_Specified_Value_For_RawValue
            (ushort value)
   {
      var u = UnitOfMeasure1Units.DerivedUnit1;
      var q = value.As(u);
      Assert.Equal(u, q.Unit);
      Assert.Equal(value, q.RawValue);
   }

   [Theory]
   [InlineData(0)]
   [InlineData(-1)]
   [InlineData(1)]
   [InlineData(-100)]
   [InlineData(100)]
   [InlineData(-110)]
   [InlineData(110)]
   [InlineData(-120)]
   [InlineData(120)]
   public void SByte_As_Unit_Creates_A_Quantity_For_The_Unit_With_The_Specified_Value_For_RawValue
            (sbyte value)
   {
      var u = UnitOfMeasure1Units.DerivedUnit1;
      var q = value.As(u);
      Assert.Equal(u, q.Unit);
      Assert.Equal(value, q.RawValue);
   }

   [Theory]
   [InlineData(0)]
   [InlineData(2)]
   [InlineData(1)]
   [InlineData(75)]
   [InlineData(150)]
   [InlineData(175)]
   [InlineData(200)]
   [InlineData(225)]
   [InlineData(255)]
   public void Byte_As_Unit_Creates_A_Quantity_For_The_Unit_With_The_Specified_Value_For_RawValue
            (byte value)
   {
      var u = UnitOfMeasure1Units.DerivedUnit1;
      var q = value.As(u);
      Assert.Equal(u, q.Unit);
      Assert.Equal(value, q.RawValue);
   }

   [Theory]
   [InlineData(1000d)]
   public void TimeSpan_As_Duration_Returns_Expected_Value(double expectedTotalMilliseconds)
   {
      var ts = new TimeSpan((long)expectedTotalMilliseconds * 10000);
      var q  = ts.As(Durations.Millisecond);

      Assert.Equal(ts.TotalMilliseconds, q.RawValue);
   }
}
