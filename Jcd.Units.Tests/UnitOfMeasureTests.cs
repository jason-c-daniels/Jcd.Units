using Jcd.Units.Tests.TestHarnesses;
// ReSharper disable EqualExpressionComparison

namespace Jcd.Units.Tests;

public class UnitOfMeasureTests
{
    
    const string BaseUnitName = "buName";
    const string BaseUnitSymbol = "bu";
    static UnitOfMeasure1 BaseUnit = new UnitOfMeasure1(BaseUnitName, BaseUnitSymbol);

    const string DerivedUnit1Name = "duName1";
    const string DerivedUnit1Symbol = "du1";
    private const double Du1C = 2.0;
    private const double Du1O = 3.0;
    static UnitOfMeasure1 DerivedUnit1 = new UnitOfMeasure1(DerivedUnit1Name, DerivedUnit1Symbol,BaseUnit,Du1C,Du1O);
    
    const string DerivedUnit2Name = "duName2";
    const string DerivedUnit2Symbol = "du2";
    static UnitOfMeasure1 DerivedUnit2 = new UnitOfMeasure1(DerivedUnit2Name, DerivedUnit2Symbol,BaseUnit,-2,0);

    [Theory]
    [InlineData("Derived Unit 1","du1",2d,2d)]
    [InlineData("Derived Unit 2","du2",3.2d,1.5d)]
    public void Constructor_Sets_Properties_To_Expected_Values(string name, string symbol, double coefficient, double offset)
    {
        const string buName = "buName";
        const string buSymbol = "bu";
        var bu = new UnitOfMeasure1(buName, buSymbol);
        Assert.Equal(buName,bu.Name);
        Assert.Equal(buSymbol,bu.Symbol);
        Assert.Equal(1.0,bu.Coefficient);
        Assert.Equal(0.0,bu.Offset);

        var du = new UnitOfMeasure1(name, symbol, bu, coefficient, offset);
        Assert.Equal(name,du.Name);
        Assert.Equal(symbol,du.Symbol);
        Assert.Equal(coefficient,du.Coefficient);
        Assert.Equal(offset,du.Offset);
    }
    
    [Theory]
    [InlineData("Derived Alternate Base","dab",1d,0d,true)]
    [InlineData("Derived Unit 1","du1",2d,2d,false)]
    [InlineData("Derived Unit 2","du2",3.2d,1.5d,false)] 
    public void Equals_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset,bool expectedResult)
    {
        var du = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
        Assert.Equal(expectedResult,du == BaseUnit);
        Assert.Equal(expectedResult,BaseUnit == du);
    }
    
    [Theory]
    [InlineData("Derived Alternate Base","dab",1d,0d)]
    [InlineData("Derived Unit 1","du1",2d,2d)]
    [InlineData("Derived Unit 2","du2",3.2d,1.5d)] 
    public void Equals_Operator_Returns_False_When_One_Side_Is_Null(string name, string symbol, double coefficient, double offset)
    {
        var du = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
        Assert.False(du == null);
        Assert.False(null == du);
    }
    
    [Fact]
    public void CompareTo_NonObject_Throws()
    {
        Assert.ThrowsAny<ArgumentException>(()=>BaseUnit.CompareTo(new object()));
    }

    [Fact]
    public void CompareTo_Null_Object_Returns_Nonzero_Value()
    {
        Assert.NotEqual(0,BaseUnit.CompareTo((object)null));
    }

    [Fact]
    public void CompareTo_Null_Returns_Nonzero_Value()
    {
        Assert.NotEqual(0,BaseUnit.CompareTo((UnitOfMeasure1)null));
    }

    [Fact]
    public void Equals_Operator_Returns_True_When_One_Both_Sides_Are_Null()
    {
        Assert.True(((UnitOfMeasure1)null) == null);
    }

    [Theory]
    [InlineData("Derived Unit","da",-1d,-2d,true)]
    [InlineData("Derived Alternate Base","dab",1d,0d,false)]
    [InlineData("Derived Unit 1","du1",2d,2d,false)]
    public void LessThan_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset,bool expectedResult)
    {
        var du = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
        Assert.Equal(expectedResult,du < BaseUnit);
        Assert.False(((UnitOfMeasure1)null) < null);
        Assert.False(du < du);
        Assert.False(null < du);
        Assert.False(du < null);
    }
    
    [Theory]
    [InlineData("Derived Unit","da",-1d,-2d,true)]
    [InlineData("Derived Alternate Base","dab",1d,0d,true)]
    [InlineData("Derived Unit 1","du1",2d,2d,false)]
    public void LessThan_Or_Equals_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset,bool expectedResult)
    {
        var du = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
        Assert.Equal(expectedResult,du <= BaseUnit);
        Assert.False(((UnitOfMeasure1)null) <= null);
        Assert.True(du <= du);
        Assert.False(null <= du);
        Assert.False(du <= null);
    }
    
    [Theory]
    [InlineData("Derived Unit","da",-1d,-2d,false)]
    [InlineData("Derived Alternate Base","dab",1d,0d,false)]
    [InlineData("Derived Unit 1","du1",2d,2d,true)]
    public void GreaterThan_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset,bool expectedResult)
    {
        var du = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
        Assert.Equal(expectedResult,du > BaseUnit);
        Assert.False(((UnitOfMeasure1)null) > null);
        Assert.False(du > du);
        Assert.False(null > du);
        Assert.False(du > null);
    }
    
    [Theory]
    [InlineData("Derived Unit","da",-1d,-2d,false)]
    [InlineData("Derived Alternate Base","dab",1d,0d,true)]
    [InlineData("Derived Unit 1","du1",2d,2d,true)]
    public void GreaterThan_Or_Equals_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset,bool expectedResult)
    {
        var du = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
        Assert.Equal(expectedResult,du >= BaseUnit);
        Assert.False(((UnitOfMeasure1)null) >= null);
        Assert.True(du >= du);
        Assert.False(null >= du);
        Assert.False(du >= null);
    }

    [Fact]
    public void ToString_BaseUnit_Returns_Expected_Result()
    {
        Assert.Equal($"{BaseUnit.Name} ({BaseUnit.Symbol})",BaseUnit.ToString());
    }
    
    [Fact]
    public void ToString_DerivedUnit1_Returns_Expected_Result()
    {
        var s = DerivedUnit1.ToString();
        Assert.Equal($"{DerivedUnit1.Name} ({DerivedUnit1.Symbol}) [= bu × {(1.0 / DerivedUnit1.Coefficient):n3} - {Math.Abs(DerivedUnit1.Offset):n3}]",s);
    }

    [Fact]
    public void TwoUnits_With_Same_Coefficient_And_Offest_Hash_To_The_Same_Value()
    {
        var hc1 = new UnitOfMeasure1("new1", "n1", DerivedUnit1.BaseUnit, Du1C, Du1O).GetHashCode();
        var hc2 = DerivedUnit1.GetHashCode();
        Assert.Equal(hc2,hc1);
    }
    
}