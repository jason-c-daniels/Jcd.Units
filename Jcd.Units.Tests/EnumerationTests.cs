#region

using Jcd.Units.Tests.TestHarnesses;

#endregion

namespace Jcd.Units.Tests;

public class EnumerationTests
{
   [Fact]
   public void GetAll_Returns_Expected_Values()
   {
      var units = UnitOfMeasure1Units
                 .GetAll()
                 .ToList();

      const int expectedCount = 3;
      Assert.Equal(expectedCount, units.Count);
      Assert.Contains(UnitOfMeasure1Units.BaseUnit, units);
      Assert.Contains(UnitOfMeasure1Units.DerivedUnit1, units);
      Assert.Contains(UnitOfMeasure1Units.DerivedUnit2, units);

      var otherUnits = UnitOfMeasure1Units2
                      .GetAll()
                      .ToList();

      const int otherExpectedCount = 2;
      Assert.Equal(otherExpectedCount, otherUnits.Count);
      Assert.Contains(UnitOfMeasure1Units2.DerivedUnit3, otherUnits);
      Assert.Contains(UnitOfMeasure1Units2.DerivedUnit4, otherUnits);
   }
}
