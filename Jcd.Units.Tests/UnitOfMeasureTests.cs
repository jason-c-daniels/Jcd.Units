using Jcd.Units.Tests.TestHarnesses;
// ReSharper disable EqualExpressionComparison

namespace Jcd.Units.Tests;

public class UnitOfMeasureTests
{
    
    const string BaseUnitName = "buName";
    const string BaseUnitSymbol = "bu";
    UnitOfMeasure1 BaseUnit = new UnitOfMeasure1(BaseUnitName, BaseUnitSymbol);
    
    [Theory]
    [InlineData("Derived Unit 1","du1",2d,2d)]
    [InlineData("Derived Unit 2","du2",3.2d,1.5d)]
    public void UnitOfMeasure_Constructor_Sets_Properties_To_Expected_Values(string name, string symbol, double coefficient, double offset)
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
    public void UnitOfMeasure_Equals_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset,bool expectedResult)
    {
        var du = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
        Assert.Equal(expectedResult,du == BaseUnit);
        Assert.Equal(expectedResult,BaseUnit == du);
    }
    
    [Theory]
    [InlineData("Derived Alternate Base","dab",1d,0d)]
    [InlineData("Derived Unit 1","du1",2d,2d)]
    [InlineData("Derived Unit 2","du2",3.2d,1.5d)] 
    public void UnitOfMeasure_Equals_Operator_Returns_False_When_One_Side_Is_Null(string name, string symbol, double coefficient, double offset)
    {
        var du = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
        Assert.False(du == null);
        Assert.False(null == du);
    }
    
    [Fact]
    public void UnitOfMeasure_Equals_Operator_Returns_True_When_One_Both_Sides_Are_Null()
    {
        Assert.True(((UnitOfMeasure1)null) == null);
    }

    [Theory]
    [InlineData("Derived Unit","da",-1d,-2d,true)]
    [InlineData("Derived Alternate Base","dab",1d,0d,false)]
    [InlineData("Derived Unit 1","du1",2d,2d,false)]
    public void UnitOfMeasure_LessThan_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset,bool expectedResult)
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
    public void UnitOfMeasure_LessThan_Or_Equals_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset,bool expectedResult)
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
    public void UnitOfMeasure_GreaterThan_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset,bool expectedResult)
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
    public void UnitOfMeasure_GreaterThan_Or_Equals_Operator_Returns_Expected_Value(string name, string symbol, double coefficient, double offset,bool expectedResult)
    {
        var du = new UnitOfMeasure1(name, symbol, BaseUnit, coefficient, offset);
        Assert.Equal(expectedResult,du >= BaseUnit);
        Assert.False(((UnitOfMeasure1)null) >= null);
        Assert.True(du >= du);
        Assert.False(null >= du);
        Assert.False(du >= null);
    }
}