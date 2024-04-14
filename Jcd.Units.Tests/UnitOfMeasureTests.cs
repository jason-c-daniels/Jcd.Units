#region

using Jcd.Units.DoubleComparison;
using Jcd.Units.Tests._Fakes;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable UnusedVariable
// ReSharper disable HeapView.BoxingAllocation
#pragma warning disable CS8600
#pragma warning disable CS1718

#endregion

// ReSharper disable EqualExpressionComparison

namespace Jcd.Units.Tests;

public class UnitOfMeasureTests : TestBase
{
   private const string BaseUnitName = "buName";
   private const string BaseUnitSymbol = "bu";
   
   private const string DerivedUnit1Name = "duName1";
   private const string DerivedUnit1Symbol = "du1";
   private const double Du1C = 2.0;
   private const double Du1O = 3.0;
   
   private const string DerivedUnit2Name = "duName2";
   private const string DerivedUnit2Symbol = "du2";
   private static readonly object SyncRoot = new();
   private static readonly UnitOfMeasure1 BaseUnit = new(BaseUnitName, BaseUnitSymbol);
   
   private static readonly UnitOfMeasure1 DerivedUnit1 = new(DerivedUnit1Name, DerivedUnit1Symbol, BaseUnit, Du1C, Du1O);
   
   private static readonly UnitOfMeasure1 DerivedUnit2 = new(DerivedUnit2Name, DerivedUnit2Symbol, BaseUnit, -2);
   
   [Theory]
   [InlineData("Derived Alternate Base", "dab", 1d,   0d,   true)]
   [InlineData("Derived Unit 1",         "du1", 2d,   2d,   false)]
   [InlineData("Derived Unit 2",         "du2", 3.2d, 1.5d, false)]
   public void Equals_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset, bool expectedResult)
   {
      var du = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
      Assert.Equal(expectedResult, du       == BaseUnit);
      Assert.Equal(expectedResult, BaseUnit == du);
   }
   
   [Theory]
   [InlineData("Derived Alternate Base", "dab", 1d,   0d)]
   [InlineData("Derived Unit 1",         "du1", 2d,   2d)]
   [InlineData("Derived Unit 2",         "du2", 3.2d, 1.5d)]
   public void Equals_Operator_Returns_False_When_One_Side_Is_Null(string name, string symbol, double coefficient, double offset)
   {
      var du = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
      Assert.False(du   == null);
      Assert.False(null == du);
   }
   
   [Fact]
   public void CompareTo_NonObject_Throws()
   {
      Assert.ThrowsAny<ArgumentException>(() => BaseUnit.CompareTo(new object()));
   }
   
   [Fact]
   public void CompareTo_Null_Object_Returns_Nonzero_Value()
   {
      Assert.NotEqual(0, BaseUnit.CompareTo((object) null));
   }
   
   [Fact]
   public void CompareTo_Null_Returns_Nonzero_Value()
   {
      Assert.NotEqual(0, BaseUnit.CompareTo(null));
   }
   
   [Fact]
   public void Equals_Operator_Returns_True_When_One_Both_Sides_Are_Null()
   {
      Assert.True((UnitOfMeasure1) null == null);
   }
   
   [Theory]
   [InlineData("Derived Unit",           "da",  -1d, -2d, true)]
   [InlineData("Derived Alternate Base", "dab", 1d,  0d,  false)]
   [InlineData("Derived Unit 1",         "du1", 2d,  2d,  false)]
   public void LessThan_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset, bool expectedResult)
   {
      var du = new UnitOfMeasure1(name,  symbol, BaseUnit, coefficient, offset);
      var du1 = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
      Assert.Equal(expectedResult, du    < BaseUnit);
      Assert.False((UnitOfMeasure1) null < null);
      Assert.False(du                    < du1);
      Assert.False(null                  < du);
      Assert.False(du                    < du);
      Assert.False(du                    < null);
   }
   
   [Theory]
   [InlineData("Derived Unit",           "da",  -1d, -2d, true)]
   [InlineData("Derived Alternate Base", "dab", 1d,  0d,  true)]
   [InlineData("Derived Unit 1",         "du1", 2d,  2d,  false)]
   public void LessThan_Or_Equals_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset, bool expectedResult)
   {
      var du = new UnitOfMeasure1(name,  symbol, BaseUnit, coefficient, offset);
      var du1 = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
      Assert.Equal(expectedResult, du    <= BaseUnit);
      Assert.False((UnitOfMeasure1) null <= null);
      
      // prevent compiler from griping about comparing to self. This is intentional
      Assert.True(du    <= du);
      Assert.False(null <= du);
      Assert.False(du   <= null);
   }
   
   [Theory]
   [InlineData("Derived Unit",           "da",  -1d, -2d, false)]
   [InlineData("Derived Alternate Base", "dab", 1d,  0d,  false)]
   [InlineData("Derived Unit 1",         "du1", 2d,  2d,  true)]
   public void GreaterThan_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset, bool expectedResult)
   {
      var du = new UnitOfMeasure1(name,  symbol, BaseUnit, coefficient, offset);
      var du1 = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
      Assert.Equal(expectedResult, du    > BaseUnit);
      Assert.False((UnitOfMeasure1) null > null);
      Assert.False(du                    > du1);
      Assert.False(du                    > du);
      Assert.False(null                  > du);
      Assert.False(du                    > null);
   }
   
   [Theory]
   [InlineData("Derived Unit",           "da",  -1d, -2d, false)]
   [InlineData("Derived Alternate Base", "dab", 1d,  0d,  true)]
   [InlineData("Derived Unit 1",         "du1", 2d,  2d,  true)]
   public void GreaterThan_Or_Equals_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset, bool expectedResult)
   {
      var du = new UnitOfMeasure1(name,  symbol, BaseUnit, coefficient, offset);
      var du1 = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
      Assert.Equal(expectedResult, du    >= BaseUnit);
      Assert.False((UnitOfMeasure1) null >= null);
      
      // prevent compiler from griping about comparing to self. This is intentional
      Assert.True(du    >= du);
      Assert.False(null >= du);
      Assert.False(du   >= null);
   }
   
   [Fact]
   public void ToString_BaseUnit_Returns_Expected_Result()
   {
      Assert.Equal($"{BaseUnit.Name} ({BaseUnit.Symbol})", BaseUnit.ToString());
   }
   
   [Fact]
   public void ToString_DerivedUnit1_Returns_Expected_Result()
   {
      var s = DerivedUnit1.ToString();
      
      Assert.Equal($"{DerivedUnit1.Name} ({DerivedUnit1.Symbol})", s);
   }
   
   [Fact]
   public void TwoUnits_With_Same_Coefficient_And_Offset_Hash_To_The_Same_Value()
   {
      var hc1 = new UnitOfMeasure1("new1", "n1", DerivedUnit1.BaseUnit, Du1C, Du1O).GetHashCode();
      var hc2 = DerivedUnit1.GetHashCode();
      Assert.Equal(hc2, hc1);
   }
   
   [Theory]
   [InlineData(-1000000d)]
   [InlineData(-1000d)]
   [InlineData(-100d)]
   [InlineData(-10d)]
   [InlineData(-1d)]
   [InlineData(-1d / 10d)]
   [InlineData(-1d / 100d)]
   [InlineData(-1d / 1000d)]
   [InlineData(-1d / 1000000d)]
   [InlineData(0d)]
   [InlineData(1d / 1000000d)]
   [InlineData(1d / 1000d)]
   [InlineData(1d / 100d)]
   [InlineData(1d / 10d)]
   [InlineData(1d)]
   [InlineData(10d)]
   [InlineData(100d)]
   [InlineData(1000d)]
   [InlineData(1000000d)]
   public void FromBaseUnitValue_Returns_The_Expected_Value(double normalizedValue)
   {
      var expectedValue = normalizedValue / DerivedUnit1.Coefficient - DerivedUnit1.Offset;
      Assert.Equal(expectedValue, DerivedUnit1.FromFundamentalUnitValue(normalizedValue));
   }
   
   [Theory]
   [InlineData(-1000000d)]
   [InlineData(-1000d)]
   [InlineData(-100d)]
   [InlineData(-10d)]
   [InlineData(-1d)]
   [InlineData(-1d / 10d)]
   [InlineData(-1d / 100d)]
   [InlineData(-1d / 1000d)]
   [InlineData(-1d / 1000000d)]
   [InlineData(0d)]
   [InlineData(1d / 1000000d)]
   [InlineData(1d / 1000d)]
   [InlineData(1d / 100d)]
   [InlineData(1d / 10d)]
   [InlineData(1d)]
   [InlineData(10d)]
   [InlineData(100d)]
   [InlineData(1000d)]
   [InlineData(1000000d)]
   public void ToBaseUnitValue_Returns_The_Expected_Value(double denormalizedValue)
   {
      var expectedValue = (denormalizedValue + DerivedUnit1.Offset) * DerivedUnit1.Coefficient;
      Assert.Equal(expectedValue, DerivedUnit1.ToFundamentalUnitValue(denormalizedValue));
   }
   
   [Fact]
   public void Custom_Global_DoubleComparer_Used_For_Comparisons()
   {
      lock (SyncRoot) // this is to prevent multiple threads from stepping on each other.
      {
         // Setup
         var mockUomComparer = new Mock<IValueComparer<double>>();
         
         mockUomComparer.Setup(m => m.Compare(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y));
         
         mockUomComparer.Setup(m => m.Equals(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y) == 0);
         
         var mockQuantityComparer = new Mock<IValueComparer<double>>();
         
         mockQuantityComparer.Setup(m => m.Compare(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y));
         
         mockQuantityComparer.Setup(m => m.Equals(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y) == 0);
         
         UnitOfMeasure1.DefaultDoubleComparer = null; // ensure the global is being used.
         GlobalDoubleComparisonStrategy.UnitOfMeasure = mockUomComparer.Object;
         GlobalDoubleComparisonStrategy.Quantity = mockQuantityComparer.Object;
         
         // act
         var comparison = DerivedUnit2.CompareTo(DerivedUnit1);
         var equals = DerivedUnit1.Equals(DerivedUnit2);
         
         // verify
         mockUomComparer.Verify(m => m.Compare(It.IsAny<double>(), It.IsAny<double>()), Times.AtLeastOnce);
         mockUomComparer.Verify(m => m.Equals(It.IsAny<double>(), It.IsAny<double>()),  Times.AtLeastOnce);
         mockQuantityComparer.Verify(m => m.Compare(It.IsAny<double>(), It.IsAny<double>()), Times.Never);
         mockQuantityComparer.Verify(m => m.Equals(It.IsAny<double>(), It.IsAny<double>()),  Times.Never);
      }
   }
   
   [Fact]
   public void Custom_TypeSpecific_DoubleComparer_Used_For_Comparisons()
   {
      lock (SyncRoot) // this is to prevent multiple threads from stepping on each other.
      {
         // Setup
         var mockUomComparer1 = new Mock<IValueComparer<double>>();
         
         mockUomComparer1.Setup(m => m.Compare(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y));
         
         mockUomComparer1.Setup(m => m.Equals(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y) == 0);
         
         var mockUomComparer2 = new Mock<IValueComparer<double>>();
         
         mockUomComparer2.Setup(m => m.Compare(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y));
         
         mockUomComparer2.Setup(m => m.Equals(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y) == 0);
         
         UnitOfMeasure1.DefaultDoubleComparer = mockUomComparer1.Object;
         GlobalDoubleComparisonStrategy.UnitOfMeasure = mockUomComparer2.Object;
         GlobalDoubleComparisonStrategy.Quantity = BitwiseDoubleComparer.Instance;
         
         // act
         var comparison = DerivedUnit2.CompareTo(DerivedUnit1);
         var equals = DerivedUnit1.Equals(DerivedUnit2);
         
         // verify
         mockUomComparer1.Verify(m => m.Compare(It.IsAny<double>(), It.IsAny<double>()), Times.AtLeastOnce);
         mockUomComparer1.Verify(m => m.Equals(It.IsAny<double>(), It.IsAny<double>()),  Times.AtLeastOnce);
         mockUomComparer2.Verify(m => m.Compare(It.IsAny<double>(), It.IsAny<double>()), Times.Never);
         mockUomComparer2.Verify(m => m.Equals(It.IsAny<double>(), It.IsAny<double>()),  Times.Never);
      }
   }
   
   [Fact]
   public void Custom_Instance_Specific_DoubleComparer_Used_For_Comparisons()
   {
      lock (SyncRoot) // this is to prevent multiple threads from stepping on each other.
      {
         // Setup
         var mockUomComparer1 = new Mock<IValueComparer<double>>();
         
         mockUomComparer1.Setup(m => m.Compare(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y));
         
         mockUomComparer1.Setup(m => m.Equals(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y) == 0);
         
         var mockUomComparer2 = new Mock<IValueComparer<double>>();
         
         mockUomComparer2.Setup(m => m.Compare(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y));
         
         mockUomComparer2.Setup(m => m.Equals(It.IsAny<double>(), It.IsAny<double>())).Returns<double, double>((x, y) => x.CompareTo(y) == 0);
         
         UnitOfMeasure1.DefaultDoubleComparer = mockUomComparer2.Object;
         GlobalDoubleComparisonStrategy.UnitOfMeasure = mockUomComparer2.Object;
         GlobalDoubleComparisonStrategy.Quantity = mockUomComparer2.Object;
         var myUnit = new UnitOfMeasure1("M1", "m1", BaseUnit, 10, -1, mockUomComparer1.Object);
         
         // act
         var comparison = myUnit.CompareTo(DerivedUnit1);
         var equals = myUnit.Equals(DerivedUnit2);
         
         // verify
         mockUomComparer1.Verify(m => m.Compare(It.IsAny<double>(), It.IsAny<double>()), Times.AtLeastOnce);
         mockUomComparer1.Verify(m => m.Equals(It.IsAny<double>(), It.IsAny<double>()),  Times.AtLeastOnce);
         mockUomComparer2.Verify(m => m.Compare(It.IsAny<double>(), It.IsAny<double>()), Times.Never);
         mockUomComparer2.Verify(m => m.Equals(It.IsAny<double>(), It.IsAny<double>()),  Times.Never);
      }
   }
   
   #region Constructor Tests
   
   [Theory]
   [InlineData("Derived Unit 1", "du1", 2d,   2d)]
   [InlineData("Derived Unit 2", "du2", 3.2d, 1.5d)]
   public void Default_Constructor_Sets_Properties_To_Expected_Values(string name, string symbol, double coefficient, double offset)
   {
      const string buName = "buName";
      const string buSymbol = "bu";
      var bu = new UnitOfMeasure1(buName, buSymbol);
      Assert.Equal(buName,   bu.Name);
      Assert.Equal(buSymbol, bu.Symbol);
      Assert.Equal(1.0,      bu.Coefficient);
      Assert.Equal(0.0,      bu.Offset);
      
      var du = new UnitOfMeasure1(name, symbol, bu, coefficient, offset);
      Assert.Equal(name,        du.Name);
      Assert.Equal(symbol,      du.Symbol);
      Assert.Equal(coefficient, du.Coefficient);
      Assert.Equal(offset,      du.Offset);
   }
   
   [Theory]
   [InlineData("Derived Unit 1", "du1", 2d,   2d)]
   [InlineData("Derived Unit 2", "du2", 3.2d, 1.5d)]
   public void Comparer_Constructor_Sets_Properties_To_Expected_Values(string name, string symbol, double coefficient, double offset)
   {
      const string buName = "buName";
      const string buSymbol = "bu";
      var bu = new UnitOfMeasure1(buName, buSymbol, null, 1, 0, Int64ConversionComparer.SixDecimalPlaces);
      Assert.Equal(buName,   bu.Name);
      Assert.Equal(buSymbol, bu.Symbol);
      Assert.Equal(1.0,      bu.Coefficient);
      Assert.Equal(0.0,      bu.Offset);
      
      var du = new UnitOfMeasure1(name, symbol, bu, coefficient, offset, Int64ConversionComparer.SixDecimalPlaces);
      Assert.Equal(name,                                     du.Name);
      Assert.Equal(symbol,                                   du.Symbol);
      Assert.Equal(coefficient,                              du.Coefficient);
      Assert.Equal(offset,                                   du.Offset);
      Assert.Equal(Int64ConversionComparer.SixDecimalPlaces, du.Comparer);
   }
   
   #endregion
}