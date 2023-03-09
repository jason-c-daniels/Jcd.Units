#region

using Jcd.Units.Tests.Fakes;
using Jcd.Units.UnitSelection;

#endregion

namespace Jcd.Units.Tests.UnitSelection;

public class SelectLeftUnitTests
{
   [Theory]
   [InlineData(nameof(FakeUoM.Dux10), nameof(FakeUoM.Dux100), nameof(FakeUoM.Dux10))]
   [InlineData(nameof(FakeUoM.Dux100), nameof(FakeUoM.Dux10), nameof(FakeUoM.Dux100))]
   [InlineData(nameof(UnitOfMeasure1Units.BaseUnit), nameof(FakeUoM.Dux100), nameof(UnitOfMeasure1Units.BaseUnit))]
   [InlineData(nameof(FakeUoM.Dux10), nameof(UnitOfMeasure1Units.BaseUnit), nameof(FakeUoM.Dux10))]
   [InlineData(
                 nameof(UnitOfMeasure1Units2.DerivedUnit3)
               , nameof(UnitOfMeasure1Units2.DerivedUnit4)
               , nameof(UnitOfMeasure1Units2.DerivedUnit3)
              )]
   public void SelectUnit_Returns_Expected_Value(string unit1, string unit2, string expectedUnit)
   {
      var expected = FakeUoM.GetUnit(expectedUnit);
      var u1       = FakeUoM.GetUnit(unit1);
      var u2       = FakeUoM.GetUnit(unit2);
      Assert.Equal(expected, SelectLeftUnit.Instance.SelectUnit(u1, u2));
   }
}
