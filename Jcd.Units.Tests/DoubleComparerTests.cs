// ReSharper disable HeapView.BoxingAllocation

#region

using Jcd.Units.DoubleComparisons;

#endregion

namespace Jcd.Units.Tests;

public class DoubleComparerTests
{
   public DoubleComparerTests()
   {
      GlobalDoubleComparisonStrategy.Quantity      = BitwiseDoubleComparer.Default;
      GlobalDoubleComparisonStrategy.UnitOfMeasure = BitwiseDoubleComparer.Default;
   }

   [Fact]
   public void Quantity_Get_Returns_BitwiseDoubleComparer_When_Not_Set()
   {
      Assert.Equal(GlobalDoubleComparisonStrategy.Quantity, BitwiseDoubleComparer.Default);
   }

   [Fact]
   public void UnitOfMeasure_Get_Returns_BitwiseDoubleComparer_When_Not_Set()
   {
      Assert.Equal(GlobalDoubleComparisonStrategy.UnitOfMeasure, BitwiseDoubleComparer.Default);
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
