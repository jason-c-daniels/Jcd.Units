#region

using Jcd.Units.UnitSelection;

#endregion

#pragma warning disable CS8625

namespace Jcd.Units.Tests.UnitSelection;

public class GlobalUnitSelectionStrategyTests : TestBase
{
   [Fact]
   public void ForArithmetic_Get_SelectLargerUnit_Instance_When_Not_Set()
   {
      var expectedValue = SelectLargerUnit.Instance;
      Assert.Equal(expectedValue, GlobalUnitSelectionStrategy.ForArithmetic);
   }

   [Fact]
   public void ForComparison_Get_SelectLargerUnit_Instance_When_Not_Set()
   {
      var expectedValue = SelectLargerUnit.Instance;
      Assert.Equal(expectedValue, GlobalUnitSelectionStrategy.ForComparison);
   }

   [Fact]
   public void ForArithmetic_Get_Returns_Expected_Result_When_Set()
   {
      var mockSelector  = new Mock<IUnitSelectionStrategy>();
      var expectedValue = mockSelector.Object;
      GlobalUnitSelectionStrategy.ForArithmetic = expectedValue;
      Assert.Equal(expectedValue, GlobalUnitSelectionStrategy.ForArithmetic);
   }

   [Fact]
   public void ForComparison_Get_Returns_Expected_Result_When_Set()
   {
      var mockSelector  = new Mock<IUnitSelectionStrategy>();
      var expectedValue = mockSelector.Object;
      GlobalUnitSelectionStrategy.ForComparison = expectedValue;
      Assert.Equal(expectedValue, GlobalUnitSelectionStrategy.ForComparison);
   }

   [Fact]
   public void ForArithmetic_Set_Throws_When_Given_Null()
   {
      Assert.Throws<ArgumentNullException>(() => GlobalUnitSelectionStrategy.ForArithmetic = null);
   }

   [Fact]
   public void ForComparison_Set_Throws_When_Given_Null()
   {
      Assert.Throws<ArgumentNullException>(() => GlobalUnitSelectionStrategy.ForComparison = null);
   }
}
