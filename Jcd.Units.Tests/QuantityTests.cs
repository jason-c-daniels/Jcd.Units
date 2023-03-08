#region

using Jcd.Units.Tests.TestHarnesses;

#endregion

namespace Jcd.Units.Tests;

public class QuantityTests
{
   #region Constructor Tests

   [Theory]
   [InlineData(2.3141d, nameof(UnitOfMeasure1Units.BaseUnit))]
   [InlineData(-2.3141d, nameof(UnitOfMeasure1Units.BaseUnit))]
   [InlineData(0d, nameof(UnitOfMeasure1Units.DerivedUnit1))]
   [InlineData(7.3141d, nameof(UnitOfMeasure1Units.DerivedUnit1))]
   [InlineData(32.1d, nameof(UnitOfMeasure1Units.DerivedUnit2))]
   [InlineData(0.3141d, nameof(UnitOfMeasure1Units.DerivedUnit2))]
   public void Constructor_Sets_Properties_To_Expected_Values(double value, string unitName)
   {
      var unit         = UnitOfMeasure1UnitsDictionary[unitName];
      var mockComparer = new Mock<IValueComparer<double>>();

      var sut1 = new Quantity<UnitOfMeasure1>(value, unit);

      Assert.Equal(unit, sut1.Unit);
      Assert.Equal(value, sut1.RawValue, SixDecimalPlacesComparer);

      var sut2 = new Quantity<UnitOfMeasure1>(value, unit, mockComparer.Object);

      Assert.Equal(unit, sut2.Unit);
      Assert.Equal(value, sut2.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   #endregion

   #region Statics Used In Tests

   private static readonly IReadOnlyDictionary<string, UnitOfMeasure1> UnitOfMeasure1UnitsDictionary =
            UnitOfMeasure1Units
                    .GetAll()
                    .ToDictionary(x => x.Name);

   private static readonly UnitOfMeasure1 Dux10 = new ("DerivedUnit x10", "Dux10", UnitOfMeasure1Units.BaseUnit, 10);

   private static readonly UnitOfMeasure1 Dux100 = new (
                                                        "DerivedUnit x100"
                                                      , "Dux100"
                                                      , UnitOfMeasure1Units.BaseUnit
                                                      , 100
                                                       );

   private static readonly IReadOnlyDictionary<string, UnitOfMeasure1> MyUnitsOfMeasureDictionary =
            new[] { Dux10, Dux100 }.ToDictionary(x => x.Symbol);

   private static readonly Int64ConversionComparer SixDecimalPlacesComparer = Int64ConversionComparer.SixDecimalPlaces;

   #endregion

   #region Unary operator tests

   [Theory]
   [InlineData(2.3141d, nameof(UnitOfMeasure1Units.BaseUnit))]
   [InlineData(-2.3141d, nameof(UnitOfMeasure1Units.BaseUnit))]
   [InlineData(0d, nameof(UnitOfMeasure1Units.DerivedUnit1))]
   [InlineData(7.3141d, nameof(UnitOfMeasure1Units.DerivedUnit1))]
   [InlineData(32.1d, nameof(UnitOfMeasure1Units.DerivedUnit2))]
   [InlineData(0.3141d, nameof(UnitOfMeasure1Units.DerivedUnit2))]
   public void op_UnaryPlus_Returns_Same_Quantity(double value, string unitName)
   {
      var unit         = UnitOfMeasure1UnitsDictionary[unitName];
      var mockComparer = new Mock<IValueComparer<double>>();

      var sut = new Quantity<UnitOfMeasure1>(value, unit, mockComparer.Object);

      var res = +sut;

      Assert.Equal(unit, res.Unit);
      Assert.Equal(value, res.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, res.Comparer);
   }

   [Theory]
   [InlineData(2.3141d, nameof(UnitOfMeasure1Units.BaseUnit))]
   [InlineData(-2.3141d, nameof(UnitOfMeasure1Units.BaseUnit))]
   [InlineData(0d, nameof(UnitOfMeasure1Units.DerivedUnit1))]
   [InlineData(7.3141d, nameof(UnitOfMeasure1Units.DerivedUnit1))]
   [InlineData(32.1d, nameof(UnitOfMeasure1Units.DerivedUnit2))]
   [InlineData(0.3141d, nameof(UnitOfMeasure1Units.DerivedUnit2))]
   public void op_UnaryNegation_Returns_New_Quantity_With_RawValue_Negated(double value, string unitName)
   {
      var expectedValue = -value;
      var unit          = UnitOfMeasure1UnitsDictionary[unitName];
      var mockComparer  = new Mock<IValueComparer<double>>();

      var sut = new Quantity<UnitOfMeasure1>(value, unit, mockComparer.Object);

      var res = -sut;

      Assert.Equal(unit, res.Unit);
      Assert.Equal(expectedValue, res.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, res.Comparer);
   }

   [Theory]
   [InlineData(2.3141d, nameof(UnitOfMeasure1Units.BaseUnit))]
   [InlineData(-2.3141d, nameof(UnitOfMeasure1Units.BaseUnit))]
   [InlineData(0d, nameof(UnitOfMeasure1Units.DerivedUnit1))]
   [InlineData(7.3141d, nameof(UnitOfMeasure1Units.DerivedUnit1))]
   [InlineData(32.1d, nameof(UnitOfMeasure1Units.DerivedUnit2))]
   [InlineData(0.3141d, nameof(UnitOfMeasure1Units.DerivedUnit2))]
   public void op_Increment_Updates_Existing_Quantity_With_RawValue_Incremented_By_One(double value, string unitName)
   {
      var expectedValue = value + 1;
      var unit          = UnitOfMeasure1UnitsDictionary[unitName];
      var mockComparer  = new Mock<IValueComparer<double>>();

      var sut = new Quantity<UnitOfMeasure1>(value, unit, mockComparer.Object);

      sut++;
      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);

      ++sut;
      expectedValue++;
      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);
   }

   [Theory]
   [InlineData(2.3141d, nameof(UnitOfMeasure1Units.BaseUnit))]
   [InlineData(-2.3141d, nameof(UnitOfMeasure1Units.BaseUnit))]
   [InlineData(0d, nameof(UnitOfMeasure1Units.DerivedUnit1))]
   [InlineData(7.3141d, nameof(UnitOfMeasure1Units.DerivedUnit1))]
   [InlineData(32.1d, nameof(UnitOfMeasure1Units.DerivedUnit2))]
   [InlineData(0.3141d, nameof(UnitOfMeasure1Units.DerivedUnit2))]
   public void op_Decrements_Updates_Existing_Quantity_With_RawValue_Decremented_By_One(double value, string unitName)
   {
      var expectedValue = value - 1;
      var unit          = UnitOfMeasure1UnitsDictionary[unitName];
      var mockComparer  = new Mock<IValueComparer<double>>();

      var sut = new Quantity<UnitOfMeasure1>(value, unit, mockComparer.Object);

      sut--;
      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);

      --sut;
      expectedValue--;
      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);
   }

   #endregion

   #region op_Addition Tests

   [Theory]
   [InlineData(nameof(UnitOfMeasure1Units.BaseUnit), 1, 0)]
   [InlineData(nameof(UnitOfMeasure1Units.DerivedUnit1), 2.1, 3.3)]
   public void op_Addition_When_Both_X_And_Y_Are_Same_Unit_Returns_The_Expected_Value
            (string unitName, double xValue, double yValue)
   {
      var expectedValue = xValue + yValue;
      var mockComparer  = new Mock<IValueComparer<double>>();
      var unit          = UnitOfMeasure1UnitsDictionary[unitName];

      var x = new Quantity<UnitOfMeasure1>(xValue, unit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, unit, mockComparer.Object);

      var sut = x + y;

      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Addition_When_Both_X_And_Y_Are_Different_Unit_Returns_The_Expected_Value_In_The_Larger_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = Dux100;

      var xUnit1         = Dux10;
      var yUnit1         = Dux100;
      var expectedValue1 = xValue / 10 + yValue;

      var x1 = new Quantity<UnitOfMeasure1>(xValue, xUnit1, mockComparer.Object);
      var y1 = new Quantity<UnitOfMeasure1>(yValue, yUnit1, mockComparer.Object);

      var sut1 = x1 + y1;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue1, sut1.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var xUnit2         = Dux100;
      var yUnit2         = Dux10;
      var expectedValue2 = xValue + yValue / 10;

      var x2 = new Quantity<UnitOfMeasure1>(xValue, xUnit2, mockComparer.Object);
      var y2 = new Quantity<UnitOfMeasure1>(yValue, yUnit2, mockComparer.Object);

      var sut2 = x2 + y2;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue2, sut2.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Addition_When_Either_X_Or_Y_Are_A_Double_Returns_The_Expected_Value_In_The_Source_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = Dux100;

      var expectedValue = xValue + yValue;

      var x = new Quantity<UnitOfMeasure1>(xValue, expectedUnit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, expectedUnit, mockComparer.Object);

      var sut1 = x + yValue;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue, sut1.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var sut2 = xValue + y;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue, sut2.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   #endregion

   #region op_Subtraction Tests

   [Theory]
   [InlineData(nameof(UnitOfMeasure1Units.BaseUnit), 1, 0)]
   [InlineData(nameof(UnitOfMeasure1Units.DerivedUnit1), 2.1, 3.3)]
   public void op_Subtraction_When_Both_X_And_Y_Are_Same_Unit_Returns_The_Expected_Value
            (string unitName, double xValue, double yValue)
   {
      var expectedValue = xValue - yValue;
      var mockComparer  = new Mock<IValueComparer<double>>();
      var unit          = UnitOfMeasure1UnitsDictionary[unitName];

      var x = new Quantity<UnitOfMeasure1>(xValue, unit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, unit, mockComparer.Object);

      var sut = x - y;

      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Subtraction_When_Both_X_And_Y_Are_Different_Unit_Returns_The_Expected_Value_In_The_Larger_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = Dux100;

      var xUnit1         = Dux10;
      var yUnit1         = Dux100;
      var expectedValue1 = xValue / 10 - yValue;

      var x1 = new Quantity<UnitOfMeasure1>(xValue, xUnit1, mockComparer.Object);
      var y1 = new Quantity<UnitOfMeasure1>(yValue, yUnit1, mockComparer.Object);

      var sut1 = x1 - y1;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue1, sut1.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var xUnit2         = Dux100;
      var yUnit2         = Dux10;
      var expectedValue2 = xValue - yValue / 10;

      var x2 = new Quantity<UnitOfMeasure1>(xValue, xUnit2, mockComparer.Object);
      var y2 = new Quantity<UnitOfMeasure1>(yValue, yUnit2, mockComparer.Object);

      var sut2 = x2 - y2;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue2, sut2.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Subtraction_When_Either_X_Or_Y_Are_Raw_Double_Returns_The_Expected_Value_In_The_Source_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = Dux100;

      var expectedValue = xValue - yValue;

      var x = new Quantity<UnitOfMeasure1>(xValue, expectedUnit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, expectedUnit, mockComparer.Object);

      var sut1 = x - yValue;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue, sut1.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var sut2 = xValue - y;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue, sut2.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   #endregion

   #region op_Multiply Tests

   [Theory]
   [InlineData(nameof(UnitOfMeasure1Units.BaseUnit), 1, 0)]
   [InlineData(nameof(UnitOfMeasure1Units.DerivedUnit1), 2.1, 3.3)]
   public void op_Multiply_When_Both_X_And_Y_Are_Same_Unit_Returns_The_Expected_Value
            (string unitName, double xValue, double yValue)
   {
      var expectedValue = xValue * yValue;
      var mockComparer  = new Mock<IValueComparer<double>>();
      var unit          = UnitOfMeasure1UnitsDictionary[unitName];

      var x = new Quantity<UnitOfMeasure1>(xValue, unit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, unit, mockComparer.Object);

      var sut = x * y;

      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Multiply_When_Both_X_And_Y_Are_Different_Unit_Returns_The_Expected_Value_In_The_Larger_Unit
            (double xValue, double yValue)
   {
      var expectedUnit = Dux100;

      var xUnit1         = Dux10;
      var yUnit1         = Dux100;
      var expectedValue1 = xValue / 10 * yValue;

      var x1 = new Quantity<UnitOfMeasure1>(xValue, xUnit1, SixDecimalPlacesComparer);
      var y1 = new Quantity<UnitOfMeasure1>(yValue, yUnit1, SixDecimalPlacesComparer);

      var sut1 = x1 * y1;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue1, sut1.RawValue, SixDecimalPlacesComparer);
      Assert.Same(SixDecimalPlacesComparer, sut1.Comparer);

      var xUnit2         = Dux100;
      var yUnit2         = Dux10;
      var expectedValue2 = xValue * (yValue / 10);

      var x2 = new Quantity<UnitOfMeasure1>(xValue, xUnit2, SixDecimalPlacesComparer);
      var y2 = new Quantity<UnitOfMeasure1>(yValue, yUnit2, SixDecimalPlacesComparer);

      var sut2 = x2 * y2;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue2, sut2.RawValue, SixDecimalPlacesComparer);
      Assert.Same(SixDecimalPlacesComparer, sut2.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Multiply_When_Either_X_Or_Y_Are_Raw_Double_Returns_The_Expected_Value_In_The_Source_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = Dux100;

      var expectedValue = xValue * yValue;

      var x = new Quantity<UnitOfMeasure1>(xValue, expectedUnit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, expectedUnit, mockComparer.Object);

      var sut1 = x * yValue;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue, sut1.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var sut2 = xValue * y;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue, sut2.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   #endregion

   #region op_Division Tests

   [Theory]
   [InlineData(nameof(UnitOfMeasure1Units.BaseUnit), 3, 7)]
   [InlineData(nameof(UnitOfMeasure1Units.DerivedUnit1), 2.1, 3.3)]
   public void op_Division_When_Both_X_And_Y_Are_Same_Unit_Returns_The_Expected_Value
            (string unitName, double xValue, double yValue)
   {
      var expectedValue = xValue / yValue;
      var mockComparer  = new Mock<IValueComparer<double>>();
      var unit          = UnitOfMeasure1UnitsDictionary[unitName];

      var x = new Quantity<UnitOfMeasure1>(xValue, unit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, unit, mockComparer.Object);

      var sut = x / y;

      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);
   }

   [Theory]
   [InlineData(3, 7)]
   [InlineData(2.1, 3.3)]
   public void op_Division_When_Both_X_And_Y_Are_Different_Unit_Returns_The_Expected_Value_In_The_Larger_Unit
            (double xValue, double yValue)
   {
      var expectedUnit = Dux100;

      var xUnit1         = Dux10;
      var yUnit1         = Dux100;
      var expectedValue1 = xValue / 10 / yValue;

      var x1 = new Quantity<UnitOfMeasure1>(xValue, xUnit1, SixDecimalPlacesComparer);
      var y1 = new Quantity<UnitOfMeasure1>(yValue, yUnit1, SixDecimalPlacesComparer);

      var sut1 = x1 / y1;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue1, sut1.RawValue, SixDecimalPlacesComparer);
      Assert.Same(SixDecimalPlacesComparer, sut1.Comparer);

      var xUnit2         = Dux100;
      var yUnit2         = Dux10;
      var expectedValue2 = xValue / (yValue / 10);

      var x2 = new Quantity<UnitOfMeasure1>(xValue, xUnit2, SixDecimalPlacesComparer);
      var y2 = new Quantity<UnitOfMeasure1>(yValue, yUnit2, SixDecimalPlacesComparer);

      var sut2 = x2 / y2;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue2, sut2.RawValue, SixDecimalPlacesComparer);
      Assert.Same(SixDecimalPlacesComparer, sut2.Comparer);
   }

   [Theory]
   [InlineData(3, 7)]
   [InlineData(2.1, 3.3)]
   public void op_Division_When_Either_X_Or_Y_Are_Raw_Double_Returns_The_Expected_Value_In_The_Source_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = Dux100;

      var expectedValue = xValue / yValue;

      var x = new Quantity<UnitOfMeasure1>(xValue, expectedUnit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, expectedUnit, mockComparer.Object);

      var sut1 = x / yValue;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue, sut1.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var sut2 = xValue / y;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue, sut2.RawValue, SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   #endregion

   #region Equality Member Tests

   [Theory]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1, true)]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1.1, false)]
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 10, true)]
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 11, false)]
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d, true)]
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d + 0.01d, false)]
   public void Equals_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, bool expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      UnitOfMeasure1.DefaultDoubleComparer = SixDecimalPlacesComparer;
      var xUnitOfMeasure = MyUnitsOfMeasureDictionary[xUnit];
      var yUnitOfMeasure = MyUnitsOfMeasureDictionary[yUnit];
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectedValue, x.Equals(y));
      Assert.Equal(expectedValue, y.Equals(x));
      Assert.Equal(expectedValue, x == y);
      Assert.Equal(expectedValue, y == x);
   }

   [Theory]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1, true)]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1.1, false)]
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 10, true)]
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 11, false)]
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d, true)]
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d + 0.01d, false)]
   public void GetHashCode_Returns_Expected_Value
            (string xUnit, double xValue, string yUnit, double yValue, bool expectEqualHashCodes)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      UnitOfMeasure1.DefaultDoubleComparer = SixDecimalPlacesComparer;
      var xUnitOfMeasure = MyUnitsOfMeasureDictionary[xUnit];
      var yUnitOfMeasure = MyUnitsOfMeasureDictionary[yUnit];
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectEqualHashCodes, x.GetHashCode() == y.GetHashCode());
   }

   #endregion

   #region Relational Operator/Member Tests

   [Theory]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1, 0)]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1.1, -1)]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 0.9, 1)]
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 10, 0)]
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 9, 1)]
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 11, -1)]
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d, 0)]
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d + 0.01d, -1)]
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d - 0.01d, 1)]
   public void CompareTo_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, int expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      //UnitOfMeasure1.DefaultDoubleComparer           = SixDecimalPlacesComparer;
      Quantity<UnitOfMeasure1>.DefaultDoubleComparer = SixDecimalPlacesComparer;
      var xUnitOfMeasure = MyUnitsOfMeasureDictionary[xUnit];
      var yUnitOfMeasure = MyUnitsOfMeasureDictionary[yUnit];
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectedValue, x.CompareTo(y));
      Assert.Equal(-1 * expectedValue, y.CompareTo(x));

      // ReSharper disable HeapView.BoxingAllocation
      Assert.Equal(expectedValue, x.CompareTo((object)y));
      Assert.Equal(-1 * expectedValue, y.CompareTo((object)x));

      // ReSharper restore HeapView.BoxingAllocation
   }

   [Theory]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1)]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1.1)]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 0.9)]
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 10)]
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 9)]
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 11)]
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d)]
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d + 0.01d)]
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d - 0.01d)]
   public void CompareTo_When_Given_Null_Returns_NonZero_Result
            (string xUnit, double xValue, string yUnit, double yValue)
   {
      var xUnitOfMeasure = MyUnitsOfMeasureDictionary[xUnit];
      var yUnitOfMeasure = MyUnitsOfMeasureDictionary[yUnit];
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.False(x.CompareTo(null) == 0);
      Assert.False(y.CompareTo(null) == 0);
   }

   [Theory]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1, false)]                          // equal
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1.1, true)]                         // less than
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 0.9, false)]                        // greater than
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 10, false)]                          // equal
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 9, false)]                           // greater than
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 11, true)]                           // less than
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d, false)]         // equal
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d + 0.01d, true)]  // less than
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d - 0.01d, false)] // greater than
   public void op_LessThan_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, bool expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      //UnitOfMeasure1.DefaultDoubleComparer           = SixDecimalPlacesComparer;
      Quantity<UnitOfMeasure1>.DefaultDoubleComparer = SixDecimalPlacesComparer;
      var xUnitOfMeasure = MyUnitsOfMeasureDictionary[xUnit];
      var yUnitOfMeasure = MyUnitsOfMeasureDictionary[yUnit];
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectedValue, x < y);
   }

   [Theory]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1, true)]                           // equal
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1.1, true)]                         // less than
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 0.9, false)]                        // greater than
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 10, true)]                           // equal
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 9, false)]                           // greater than
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 11, true)]                           // less than
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d, true)]          // equal
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d + 0.01d, true)]  // less than
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d - 0.01d, false)] // greater than
   public void op_LessThanOrEqual_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, bool expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      //UnitOfMeasure1.DefaultDoubleComparer           = SixDecimalPlacesComparer;
      Quantity<UnitOfMeasure1>.DefaultDoubleComparer = SixDecimalPlacesComparer;
      var xUnitOfMeasure = MyUnitsOfMeasureDictionary[xUnit];
      var yUnitOfMeasure = MyUnitsOfMeasureDictionary[yUnit];
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectedValue, x <= y);
   }

   [Theory]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1, false)]                          // equal
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1.1, false)]                        // less than
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 0.9, true)]                         // greater than
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 10, false)]                          // equal
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 9, true)]                            // greater than
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 11, false)]                          // less than
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d, false)]         // equal
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d + 0.01d, false)] // less than
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d - 0.01d, true)]  // greater than
   public void op_GreaterThan_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, bool expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      //UnitOfMeasure1.DefaultDoubleComparer           = SixDecimalPlacesComparer;
      Quantity<UnitOfMeasure1>.DefaultDoubleComparer = SixDecimalPlacesComparer;
      var xUnitOfMeasure = MyUnitsOfMeasureDictionary[xUnit];
      var yUnitOfMeasure = MyUnitsOfMeasureDictionary[yUnit];
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectedValue, x > y);
   }

   [Theory]
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1, true)]                           // equal
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 1.1, false)]                        // less than
   [InlineData(nameof(Dux10), 10, nameof(Dux100), 0.9, true)]                         // greater than
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 10, true)]                           // equal
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 9, true)]                            // greater than
   [InlineData(nameof(Dux10), 10, nameof(Dux10), 11, false)]                          // less than
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d, true)]          // equal
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d + 0.01d, false)] // less than
   [InlineData(nameof(Dux10), 1d / 3d, nameof(Dux100), 1d / 3d / 10d - 0.01d, true)]  // greater than
   public void op_GreaterThanOrEqual_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, bool expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      //UnitOfMeasure1.DefaultDoubleComparer           = SixDecimalPlacesComparer;
      Quantity<UnitOfMeasure1>.DefaultDoubleComparer = SixDecimalPlacesComparer;
      var xUnitOfMeasure = MyUnitsOfMeasureDictionary[xUnit];
      var yUnitOfMeasure = MyUnitsOfMeasureDictionary[yUnit];
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectedValue, x >= y);
   }

   #endregion

   #region ToString Tests

   [Theory]
   [InlineData(nameof(Dux100), 1, "1.00 Dux100")]
   [InlineData(nameof(Dux100), 1.1, "1.10 Dux100")]
   [InlineData(nameof(Dux100), 0.9, "0.90 Dux100")]
   [InlineData(nameof(Dux10), 10, "10.00 Dux10")]
   [InlineData(nameof(Dux10), 9, "9.00 Dux10")]
   [InlineData(nameof(Dux10), 11, "11.00 Dux10")]
   [InlineData(nameof(Dux100), 1d / 3d / 10d, "0.03 Dux100")]
   [InlineData(nameof(Dux10), 1d  / 3d / 10d + 0.01d, "0.04 Dux10")]
   [InlineData(nameof(Dux100), 1d / 3d / 10d - 0.01d, "0.02 Dux100")]
   public void Default_ToString_Returns_Expected_Value(string unit, double value, string expectedString)
   {
      var uom = MyUnitsOfMeasureDictionary[unit];
      var x   = value.As(uom);
      Assert.Equal(expectedString, x.ToString());
   }

   [Theory]
   [InlineData(nameof(Dux100), 1, "n2", "1.00 Dux100")]
   [InlineData(nameof(Dux100), 1.1, "n3", "1.100 Dux100")]
   [InlineData(nameof(Dux100), 0.9, "n1", "0.9 Dux100")]
   [InlineData(nameof(Dux10), 10, "e2", "1.00e+001 Dux10")]
   [InlineData(nameof(Dux10), 10, "", "10.00 Dux10")]
   public void ToString_With_FormatString_Returns_Expected_Value
            (string unit, double value, string format, string expectedString)
   {
      var uom = MyUnitsOfMeasureDictionary[unit];
      var x   = value.As(uom);
      Assert.Equal(expectedString, x.ToString(format));
   }

   #endregion
}
