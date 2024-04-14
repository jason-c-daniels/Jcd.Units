// ReSharper disable HeapView.BoxingAllocation

#region

using Jcd.Units.DoubleComparison;

#endregion

namespace Jcd.Units.Tests.DoubleComparison;

public class GlobalDoubleComparisonStrategyTests : TestBase
{
   [Fact]
   public void Quantity_Get_Returns_BitwiseDoubleComparer_When_Not_Set()
   {
      Assert.Equal(GlobalDoubleComparisonStrategy.Quantity, BitwiseDoubleComparer.Instance);
   }
   
   [Fact]
   public void UnitOfMeasure_Get_Returns_BitwiseDoubleComparer_When_Not_Set()
   {
      Assert.Equal(GlobalDoubleComparisonStrategy.UnitOfMeasure, BitwiseDoubleComparer.Instance);
   }
   
   [Fact]
   public void Quantity_Get_Returns_Expected_Result_When_Set()
   {
      var mockSelector = new Mock<IValueComparer<double>>();
      var expectedValue = mockSelector.Object;
      GlobalDoubleComparisonStrategy.Quantity = expectedValue;
      Assert.Equal(expectedValue, GlobalDoubleComparisonStrategy.Quantity);
   }
   
   [Fact]
   public void ForComparison_Get_Returns_Expected_Result_When_Set()
   {
      var mockSelector = new Mock<IValueComparer<double>>();
      var expectedValue = mockSelector.Object;
      GlobalDoubleComparisonStrategy.UnitOfMeasure = expectedValue;
      Assert.Equal(expectedValue, GlobalDoubleComparisonStrategy.UnitOfMeasure);
   }
   
   [Fact]
   public void Quantity_Set_Throws_When_Given_Null()
   {
      Assert.Throws<ArgumentNullException>(() => GlobalDoubleComparisonStrategy.Quantity = null);
   }
   
   [Fact]
   public void UnitOfMeasure_Set_Throws_When_Given_Null()
   {
      Assert.Throws<ArgumentNullException>(() => GlobalDoubleComparisonStrategy.UnitOfMeasure = null);
   }
}