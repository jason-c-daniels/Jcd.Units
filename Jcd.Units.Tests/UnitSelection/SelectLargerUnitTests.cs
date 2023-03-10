#region

using Jcd.Units.Tests._Fakes;
using Jcd.Units.UnitSelection;

#endregion

namespace Jcd.Units.Tests.UnitSelection;

public class SelectLargerUnitTests : TestBase
{
   [Theory]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , nameof(TestUnitProvider.DerivedUnitX100)
               , nameof(TestUnitProvider.DerivedUnitX100)
              )]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX100)
               , nameof(TestUnitProvider.DerivedUnitX10)
               , nameof(TestUnitProvider.DerivedUnitX100)
              )]
   [InlineData(
                 nameof(UnitOfMeasure1Units.BaseUnit)
               , nameof(TestUnitProvider.DerivedUnitX100)
               , nameof(TestUnitProvider.DerivedUnitX100)
              )]
   [InlineData(
                 nameof(TestUnitProvider.DerivedUnitX10)
               , nameof(UnitOfMeasure1Units.BaseUnit)
               , nameof(TestUnitProvider.DerivedUnitX10)
              )]
   [InlineData(
                 nameof(UnitOfMeasure1Units2.DerivedUnit3)
               , nameof(UnitOfMeasure1Units2.DerivedUnit4)
               , nameof(UnitOfMeasure1Units2.DerivedUnit4)
              )]
   public void SelectUnit_Returns_Expected_Value(string unit1, string unit2, string expectedUnit)
   {
      var expected = TestUnitProvider.GetUnit(expectedUnit);
      var u1       = TestUnitProvider.GetUnit(unit1);
      var u2       = TestUnitProvider.GetUnit(unit2);
      Assert.Equal(expected, SelectLargerUnit.Instance.SelectUnit(u1, u2));
   }
}
