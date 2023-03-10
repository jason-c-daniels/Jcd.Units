#region

using Jcd.Units.Tests._Fakes;
using Jcd.Units.UnitSelection;
using Jcd.Units.UnitsOfMeasure.SI;
using Jcd.Units.UnitTypes;

#endregion

namespace Jcd.Units.Tests;

public class QuantityTests : TestBase
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
      var unit         = TestUnitProvider.GetUnit(unitName);
      var mockComparer = new Mock<IValueComparer<double>>();

      var sut1 = new Quantity<UnitOfMeasure1>(value, unit);

      Assert.Equal(unit, sut1.Unit);
      Assert.Equal(value, sut1.RawValue, TestUnitProvider.SixDecimalPlacesComparer);

      var sut2 = new Quantity<UnitOfMeasure1>(value, unit, mockComparer.Object);

      Assert.Equal(unit, sut2.Unit);
      Assert.Equal(value, sut2.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

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
      var unit         = TestUnitProvider.GetUnit(unitName);
      var mockComparer = new Mock<IValueComparer<double>>();

      var sut = new Quantity<UnitOfMeasure1>(value, unit, mockComparer.Object);

      var res = +sut;

      Assert.Equal(unit, res.Unit);
      Assert.Equal(value, res.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
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
      var unit          = TestUnitProvider.GetUnit(unitName);
      var mockComparer  = new Mock<IValueComparer<double>>();

      var sut = new Quantity<UnitOfMeasure1>(value, unit, mockComparer.Object);

      var res = -sut;

      Assert.Equal(unit, res.Unit);
      Assert.Equal(expectedValue, res.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
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
      var unit          = TestUnitProvider.GetUnit(unitName);
      var mockComparer  = new Mock<IValueComparer<double>>();

      var sut = new Quantity<UnitOfMeasure1>(value, unit, mockComparer.Object);

      sut++;
      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);

      ++sut;
      expectedValue++;
      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
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
      var unit          = TestUnitProvider.GetUnit(unitName);
      var mockComparer  = new Mock<IValueComparer<double>>();

      var sut = new Quantity<UnitOfMeasure1>(value, unit, mockComparer.Object);

      sut--;
      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);

      --sut;
      expectedValue--;
      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
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
      var unit          = TestUnitProvider.GetUnit(unitName);

      var x = new Quantity<UnitOfMeasure1>(xValue, unit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, unit, mockComparer.Object);

      var sut = x + y;

      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Addition_When_Both_X_And_Y_Are_Different_Unit_Returns_The_Expected_Value_In_The_Larger_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = TestUnitProvider.DerivedUnitX100;

      var xUnit1         = TestUnitProvider.DerivedUnitX10;
      var yUnit1         = TestUnitProvider.DerivedUnitX100;
      var expectedValue1 = xValue / 10 + yValue;

      var x1 = new Quantity<UnitOfMeasure1>(xValue, xUnit1, mockComparer.Object);
      var y1 = new Quantity<UnitOfMeasure1>(yValue, yUnit1, mockComparer.Object);

      var sut1 = x1 + y1;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue1, sut1.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var xUnit2         = TestUnitProvider.DerivedUnitX100;
      var yUnit2         = TestUnitProvider.DerivedUnitX10;
      var expectedValue2 = xValue + yValue / 10;

      var x2 = new Quantity<UnitOfMeasure1>(xValue, xUnit2, mockComparer.Object);
      var y2 = new Quantity<UnitOfMeasure1>(yValue, yUnit2, mockComparer.Object);

      var sut2 = x2 + y2;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue2, sut2.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Addition_When_Either_X_Or_Y_Are_A_Double_Returns_The_Expected_Value_In_The_Source_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = TestUnitProvider.DerivedUnitX100;

      var expectedValue = xValue + yValue;

      var x = new Quantity<UnitOfMeasure1>(xValue, expectedUnit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, expectedUnit, mockComparer.Object);

      var sut1 = x + yValue;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue, sut1.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var sut2 = xValue + y;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue, sut2.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   [Fact]
   public void op_Addition_When_Global_ForArithmetic_Is_Set_Returns_Expected_Unit()
   {
      GlobalUnitSelectionStrategy.ForArithmetic = SelectLeftUnit.Instance;
      var q1 = 1.As(Lengths.Kilometer);
      var q2 = 2.As(Lengths.Meter);
      var r1 = q1 + q2;
      Assert.Equal(q1.Unit, r1.Unit);
      var r2 = q2 + r1;
      Assert.Equal(q2.Unit, r2.Unit);
   }

   [Fact]
   public void op_Addition_When_Quantity_ArithmeticUnitSelector_Is_Set_Returns_Expected_Unit()
   {
      Quantity<Length>.ArithmeticUnitSelector = SelectLeftUnit.Instance;
      var q1 = 1.As(Lengths.Kilometer);
      var q2 = 2.As(Lengths.Meter);
      var r1 = q1 + q2;
      Assert.Equal(q1.Unit, r1.Unit);
      var r2 = q2 + r1;
      Assert.Equal(q2.Unit, r2.Unit);
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
      var unit          = TestUnitProvider.GetUnit(unitName);

      var x = new Quantity<UnitOfMeasure1>(xValue, unit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, unit, mockComparer.Object);

      var sut = x - y;

      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Subtraction_When_Both_X_And_Y_Are_Different_Unit_Returns_The_Expected_Value_In_The_Larger_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = TestUnitProvider.DerivedUnitX100;

      var xUnit1         = TestUnitProvider.DerivedUnitX10;
      var yUnit1         = TestUnitProvider.DerivedUnitX100;
      var expectedValue1 = xValue / 10 - yValue;

      var x1 = new Quantity<UnitOfMeasure1>(xValue, xUnit1, mockComparer.Object);
      var y1 = new Quantity<UnitOfMeasure1>(yValue, yUnit1, mockComparer.Object);

      var sut1 = x1 - y1;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue1, sut1.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var xUnit2         = TestUnitProvider.DerivedUnitX100;
      var yUnit2         = TestUnitProvider.DerivedUnitX10;
      var expectedValue2 = xValue - yValue / 10;

      var x2 = new Quantity<UnitOfMeasure1>(xValue, xUnit2, mockComparer.Object);
      var y2 = new Quantity<UnitOfMeasure1>(yValue, yUnit2, mockComparer.Object);

      var sut2 = x2 - y2;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue2, sut2.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Subtraction_When_Either_X_Or_Y_Are_Raw_Double_Returns_The_Expected_Value_In_The_Source_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = TestUnitProvider.DerivedUnitX100;

      var expectedValue = xValue - yValue;

      var x = new Quantity<UnitOfMeasure1>(xValue, expectedUnit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, expectedUnit, mockComparer.Object);

      var sut1 = x - yValue;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue, sut1.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var sut2 = xValue - y;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue, sut2.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   [Fact]
   public void op_Subtraction_When_Global_ForArithmetic_Is_Set_Returns_Expected_Unit()
   {
      GlobalUnitSelectionStrategy.ForArithmetic = SelectLeftUnit.Instance;
      var q1 = 1.As(Lengths.Kilometer);
      var q2 = 2.As(Lengths.Meter);
      var r1 = q1 - q2;
      Assert.Equal(q1.Unit, r1.Unit);
      var r2 = q2 - r1;
      Assert.Equal(q2.Unit, r2.Unit);
   }

   [Fact]
   public void op_Subtraction_When_Quantity_ArithmeticUnitSelector_Is_Set_Returns_Expected_Unit()
   {
      Quantity<Length>.ArithmeticUnitSelector = SelectLeftUnit.Instance;
      var q1 = 1.As(Lengths.Kilometer);
      var q2 = 2.As(Lengths.Meter);
      var r1 = q1 - q2;
      Assert.Equal(q1.Unit, r1.Unit);
      var r2 = q2 - r1;
      Assert.Equal(q2.Unit, r2.Unit);
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
      var unit          = TestUnitProvider.GetUnit(unitName);

      var x = new Quantity<UnitOfMeasure1>(xValue, unit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, unit, mockComparer.Object);

      var sut = x * y;

      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Multiply_When_Both_X_And_Y_Are_Different_Unit_Returns_The_Expected_Value_In_The_Larger_Unit
            (double xValue, double yValue)
   {
      var expectedUnit = TestUnitProvider.DerivedUnitX100;

      var xUnit1         = TestUnitProvider.DerivedUnitX10;
      var yUnit1         = TestUnitProvider.DerivedUnitX100;
      var expectedValue1 = xValue / 10 * yValue;

      var x1 = new Quantity<UnitOfMeasure1>(xValue, xUnit1, TestUnitProvider.SixDecimalPlacesComparer);
      var y1 = new Quantity<UnitOfMeasure1>(yValue, yUnit1, TestUnitProvider.SixDecimalPlacesComparer);

      var sut1 = x1 * y1;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue1, sut1.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(TestUnitProvider.SixDecimalPlacesComparer, sut1.Comparer);

      var xUnit2         = TestUnitProvider.DerivedUnitX100;
      var yUnit2         = TestUnitProvider.DerivedUnitX10;
      var expectedValue2 = xValue * (yValue / 10);

      var x2 = new Quantity<UnitOfMeasure1>(xValue, xUnit2, TestUnitProvider.SixDecimalPlacesComparer);
      var y2 = new Quantity<UnitOfMeasure1>(yValue, yUnit2, TestUnitProvider.SixDecimalPlacesComparer);

      var sut2 = x2 * y2;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue2, sut2.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(TestUnitProvider.SixDecimalPlacesComparer, sut2.Comparer);
   }

   [Theory]
   [InlineData(1, 0)]
   [InlineData(2.1, 3.3)]
   public void op_Multiply_When_Either_X_Or_Y_Are_Raw_Double_Returns_The_Expected_Value_In_The_Source_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = TestUnitProvider.DerivedUnitX100;

      var expectedValue = xValue * yValue;

      var x = new Quantity<UnitOfMeasure1>(xValue, expectedUnit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, expectedUnit, mockComparer.Object);

      var sut1 = x * yValue;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue, sut1.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var sut2 = xValue * y;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue, sut2.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   [Fact]
   public void op_Multiply_When_Global_ForArithmetic_Is_Set_Returns_Expected_Unit()
   {
      GlobalUnitSelectionStrategy.ForArithmetic = SelectLeftUnit.Instance;
      var q1 = 1.As(Lengths.Kilometer);
      var q2 = 2.As(Lengths.Meter);
      var r1 = q1 * q2;
      Assert.Equal(q1.Unit, r1.Unit);
      var r2 = q2 * r1;
      Assert.Equal(q2.Unit, r2.Unit);
   }

   [Fact]
   public void op_Multiply_When_Quantity_ArithmeticUnitSelector_Is_Set_Returns_Expected_Unit()
   {
      Quantity<Length>.ArithmeticUnitSelector = SelectLeftUnit.Instance;
      var q1 = 1.As(Lengths.Kilometer);
      var q2 = 2.As(Lengths.Meter);
      var r1 = q1 * q2;
      Assert.Equal(q1.Unit, r1.Unit);
      var r2 = q2 * r1;
      Assert.Equal(q2.Unit, r2.Unit);
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
      var unit          = TestUnitProvider.GetUnit(unitName);

      var x = new Quantity<UnitOfMeasure1>(xValue, unit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, unit, mockComparer.Object);

      var sut = x / y;

      Assert.Equal(unit, sut.Unit);
      Assert.Equal(expectedValue, sut.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut.Comparer);
   }

   [Theory]
   [InlineData(3, 7)]
   [InlineData(2.1, 3.3)]
   public void op_Division_When_Both_X_And_Y_Are_Different_Unit_Returns_The_Expected_Value_In_The_Larger_Unit
            (double xValue, double yValue)
   {
      var expectedUnit = TestUnitProvider.DerivedUnitX100;

      var xUnit1         = TestUnitProvider.DerivedUnitX10;
      var yUnit1         = TestUnitProvider.DerivedUnitX100;
      var expectedValue1 = xValue / 10 / yValue;

      var x1 = new Quantity<UnitOfMeasure1>(xValue, xUnit1, TestUnitProvider.SixDecimalPlacesComparer);
      var y1 = new Quantity<UnitOfMeasure1>(yValue, yUnit1, TestUnitProvider.SixDecimalPlacesComparer);

      var sut1 = x1 / y1;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue1, sut1.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(TestUnitProvider.SixDecimalPlacesComparer, sut1.Comparer);

      var xUnit2         = TestUnitProvider.DerivedUnitX100;
      var yUnit2         = TestUnitProvider.DerivedUnitX10;
      var expectedValue2 = xValue / (yValue / 10);

      var x2 = new Quantity<UnitOfMeasure1>(xValue, xUnit2, TestUnitProvider.SixDecimalPlacesComparer);
      var y2 = new Quantity<UnitOfMeasure1>(yValue, yUnit2, TestUnitProvider.SixDecimalPlacesComparer);

      var sut2 = x2 / y2;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue2, sut2.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(TestUnitProvider.SixDecimalPlacesComparer, sut2.Comparer);
   }

   [Theory]
   [InlineData(3, 7)]
   [InlineData(2.1, 3.3)]
   public void op_Division_When_Either_X_Or_Y_Are_Raw_Double_Returns_The_Expected_Value_In_The_Source_Unit
            (double xValue, double yValue)
   {
      var mockComparer = new Mock<IValueComparer<double>>();
      var expectedUnit = TestUnitProvider.DerivedUnitX100;

      var expectedValue = xValue / yValue;

      var x = new Quantity<UnitOfMeasure1>(xValue, expectedUnit, mockComparer.Object);
      var y = new Quantity<UnitOfMeasure1>(yValue, expectedUnit, mockComparer.Object);

      var sut1 = x / yValue;

      Assert.Equal(expectedUnit, sut1.Unit);
      Assert.Equal(expectedValue, sut1.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut1.Comparer);

      var sut2 = xValue / y;

      Assert.Equal(expectedUnit, sut2.Unit);
      Assert.Equal(expectedValue, sut2.RawValue, TestUnitProvider.SixDecimalPlacesComparer);
      Assert.Same(mockComparer.Object, sut2.Comparer);
   }

   [Fact]
   public void op_Division_When_Global_ForArithmetic_Is_Set_Returns_Expected_Unit()
   {
      GlobalUnitSelectionStrategy.ForArithmetic = SelectLeftUnit.Instance;
      var q1 = 1.As(Lengths.Kilometer);
      var q2 = 2.As(Lengths.Meter);
      var r1 = q1 / q2;
      Assert.Equal(q1.Unit, r1.Unit);
      var r2 = q2 / r1;
      Assert.Equal(q2.Unit, r2.Unit);
   }

   [Fact]
   public void op_Division_When_Quantity_ArithmeticUnitSelector_Is_Set_Returns_Expected_Unit()
   {
      Quantity<Length>.ArithmeticUnitSelector = SelectLeftUnit.Instance;
      var q1 = 1.As(Lengths.Kilometer);
      var q2 = 2.As(Lengths.Meter);
      var r1 = q1 / q2;
      Assert.Equal(q1.Unit, r1.Unit);
      var r2 = q2 / r1;
      Assert.Equal(q2.Unit, r2.Unit);
   }

   #endregion

   #region Equality Member Tests

   [Theory]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 1, true)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 1.1, false)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 10, true)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 11, false)]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d
               , true
              )]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d + 0.01d
               , false
              )]
   public void Equals_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, bool expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      UnitOfMeasure1.DefaultDoubleComparer = TestUnitProvider.SixDecimalPlacesComparer;
      var xUnitOfMeasure = TestUnitProvider.GetUnit(xUnit);
      var yUnitOfMeasure = TestUnitProvider.GetUnit(yUnit);
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectedValue, x.Equals(y));
      Assert.Equal(expectedValue, y.Equals(x));
      Assert.Equal(expectedValue, x == y);
      Assert.Equal(expectedValue, y == x);
   }

   [Theory]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 1, true)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 1.1, false)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 10, true)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 11, false)]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d
               , true
              )]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d + 0.01d
               , false
              )]
   public void GetHashCode_Returns_Expected_Value
            (string xUnit, double xValue, string yUnit, double yValue, bool expectEqualHashCodes)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      Quantity<UnitOfMeasure1>.DefaultDoubleComparer = TestUnitProvider.SixDecimalPlacesComparer;
      var xUnitOfMeasure = TestUnitProvider.GetUnit(xUnit);
      var yUnitOfMeasure = TestUnitProvider.GetUnit(yUnit);
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      var hc1 = x.GetHashCode();
      var hc2 = y.GetHashCode();
      Assert.Equal(expectEqualHashCodes, hc1 == hc2);
   }

   #endregion

   #region Relational Operator/Member Tests

   [Theory]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 1, 0)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 1.1, -1)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 0.9, 1)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 10, 0)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 9, 1)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 11, -1)]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d
               , 0
              )]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d + 0.01d
               , -1
              )]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d - 0.01d
               , 1
              )]
   public void CompareTo_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, int expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      //UnitOfMeasure1.DefaultDoubleComparer           = SixDecimalPlacesComparer;
      Quantity<UnitOfMeasure1>.DefaultDoubleComparer = TestUnitProvider.SixDecimalPlacesComparer;
      var xUnitOfMeasure = TestUnitProvider.GetUnit(xUnit);
      var yUnitOfMeasure = TestUnitProvider.GetUnit(yUnit);
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
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 1)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 1.1)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 0.9)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 10)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 9)]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 11)]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d
              )]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d + 0.01d
              )]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d - 0.01d
              )]
   public void CompareTo_When_Given_Null_Returns_NonZero_Result
            (string xUnit, double xValue, string yUnit, double yValue)
   {
      var xUnitOfMeasure = TestUnitProvider.GetUnit(xUnit);
      var yUnitOfMeasure = TestUnitProvider.GetUnit(yUnit);
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.False(x.CompareTo(null) == 0);
      Assert.False(y.CompareTo(null) == 0);
   }

   [Theory]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1
               , false
              )] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1.1
               , true
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 0.9
               , false
              )] // greater than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , false
              )] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX10)
               , 9
               , false
              )] // greater than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX10)
               , 11
               , true
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d
               , false
              )] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d + 0.01d
               , true
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d - 0.01d
               , false
              )] // greater than
   public void op_LessThan_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, bool expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      //UnitOfMeasure1.DefaultDoubleComparer           = SixDecimalPlacesComparer;
      Quantity<UnitOfMeasure1>.DefaultDoubleComparer = TestUnitProvider.SixDecimalPlacesComparer;
      var xUnitOfMeasure = TestUnitProvider.GetUnit(xUnit);
      var yUnitOfMeasure = TestUnitProvider.GetUnit(yUnit);
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectedValue, x < y);
   }

   [Theory]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 1, true)] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1.1
               , true
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 0.9
               , false
              )] // greater than
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 10, true)] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX10)
               , 9
               , false
              )] // greater than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX10)
               , 11
               , true
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d
               , true
              )] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d + 0.01d
               , true
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d - 0.01d
               , false
              )] // greater than
   public void op_LessThanOrEqual_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, bool expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      //UnitOfMeasure1.DefaultDoubleComparer           = SixDecimalPlacesComparer;
      Quantity<UnitOfMeasure1>.DefaultDoubleComparer = TestUnitProvider.SixDecimalPlacesComparer;
      var xUnitOfMeasure = TestUnitProvider.GetUnit(xUnit);
      var yUnitOfMeasure = TestUnitProvider.GetUnit(yUnit);
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectedValue, x <= y);
   }

   [Theory]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1
               , false
              )] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1.1
               , false
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 0.9
               , true
              )] // greater than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , false
              )] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX10)
               , 9
               , true
              )] // greater than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX10)
               , 11
               , false
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d
               , false
              )] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d + 0.01d
               , false
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d - 0.01d
               , true
              )] // greater than
   public void op_GreaterThan_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, bool expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      //UnitOfMeasure1.DefaultDoubleComparer           = SixDecimalPlacesComparer;
      Quantity<UnitOfMeasure1>.DefaultDoubleComparer = TestUnitProvider.SixDecimalPlacesComparer;
      var xUnitOfMeasure = TestUnitProvider.GetUnit(xUnit);
      var yUnitOfMeasure = TestUnitProvider.GetUnit(yUnit);
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectedValue, x > y);
   }

   [Theory]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX100), 1, true)] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1.1
               , false
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 0.9
               , true
              )] // greater than
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, nameof(TestUnitProvider.DerivedUnitX10), 10, true)] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX10)
               , 9
               , true
              )] // greater than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 10
               , nameof(TestUnitProvider.DerivedUnitX10)
               , 11
               , false
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d
               , true
              )] // equal
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d + 0.01d
               , false
              )] // less than
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , 1d / 3d
               , nameof(TestUnitProvider.DerivedUnitX100)
               , 1d / 3d / 10d - 0.01d
               , true
              )] // greater than
   public void op_GreaterThanOrEqual_Returns_Expected_Result
            (string xUnit, double xValue, string yUnit, double yValue, bool expectedValue)
   {
      // NOTE: the comparer used compares up to 6 decimal places by first multiplying by 1,000,000 then converting to an Int64.
      // keep the InlineData in a range that's actually convertible.
      //UnitOfMeasure1.DefaultDoubleComparer           = SixDecimalPlacesComparer;
      Quantity<UnitOfMeasure1>.DefaultDoubleComparer = TestUnitProvider.SixDecimalPlacesComparer;
      var xUnitOfMeasure = TestUnitProvider.GetUnit(xUnit);
      var yUnitOfMeasure = TestUnitProvider.GetUnit(yUnit);
      var x              = xValue.As(xUnitOfMeasure);
      var y              = yValue.As(yUnitOfMeasure);

      Assert.Equal(expectedValue, x >= y);
   }

   #endregion

   #region ToString Tests

   [Theory]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX100), 1, "1.00 du x 100")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX100), 1.1, "1.10 du x 100")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX100), 0.9, "0.90 du x 100")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, "10.00 du x 10")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 9, "9.00 du x 10")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 11, "11.00 du x 10")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX100), 1d / 3d / 10d, "0.03 du x 100")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 1d  / 3d / 10d + 0.01d, "0.04 du x 10")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX100), 1d / 3d / 10d - 0.01d, "0.02 du x 100")]
   public void Default_ToString_Returns_Expected_Value(string unit, double value, string expectedString)
   {
      var uom = TestUnitProvider.GetUnit(unit);
      var x   = value.As(uom);
      Assert.Equal(expectedString, x.ToString());
   }

   [Theory]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX100), 1, "n2", "1.00 du x 100")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX100), 1.1, "n3", "1.100 du x 100")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX100), 0.9, "n1", "0.9 du x 100")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, "e2", "1.00e+001 du x 10")]
   [InlineData(nameof(TestUnitProvider.DerivedUnitX10), 10, "", "10.00 du x 10")]
   public void ToString_With_FormatString_Returns_Expected_Value
            (string unit, double value, string format, string expectedString)
   {
      var uom = TestUnitProvider.GetUnit(unit);
      var x   = value.As(uom);
      Assert.Equal(expectedString, x.ToString(format));
   }

   #endregion
}
