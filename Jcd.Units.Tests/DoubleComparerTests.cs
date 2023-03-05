namespace Jcd.Units.Tests;

public class DoubleComparerTests
{
    public DoubleComparerTests()
    {
        DoubleComparer.Quantity=BitwiseDoubleComparer.Default;
        DoubleComparer.UnitOfMeasure=BitwiseDoubleComparer.Default;
    }

    [Fact]
    public void Quantity_Get_Returns_BitwiseDoubleComparer_When_Not_Set()
    {
        Assert.Equal(DoubleComparer.Quantity,BitwiseDoubleComparer.Default);
    }
    
    [Fact]
    public void UnitOfMeasure_Get_Returns_BitwiseDoubleComparer_When_Not_Set()
    {
        Assert.Equal(DoubleComparer.UnitOfMeasure,BitwiseDoubleComparer.Default);
    }
    
    [Fact]
    public void Quantity_Set_Throws_When_Given_Null()
    {
        Assert.Throws<ArgumentNullException>(()=>DoubleComparer.Quantity=null);
    }
    
    [Fact]
    public void UnitOfMeasure_Set_Throws_When_Given_Null()
    {
        Assert.Throws<ArgumentNullException>(()=>DoubleComparer.UnitOfMeasure=null);
    }
}