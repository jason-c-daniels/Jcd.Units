#region

using Jcd.Units.Tests._Fakes;

#endregion

namespace Jcd.Units.Tests;

public class EnumerationTests : TestBase
{
   [Fact]
   public void GetAll_Returns_Expected_Values()
   {
      var units = UnitOfMeasure1Units.GetAll().ToList();
      
      const int expectedCount = 3;
      Assert.Equal(expectedCount, units.Count);
      Assert.Contains(UnitOfMeasure1Units.BaseUnit,     units);
      Assert.Contains(UnitOfMeasure1Units.DerivedUnit1, units);
      Assert.Contains(UnitOfMeasure1Units.DerivedUnit2, units);
      
      var otherUnits = UnitOfMeasure1Units2.GetAll().ToList();
      
      const int otherExpectedCount = 2;
      Assert.Equal(otherExpectedCount, otherUnits.Count);
      Assert.Contains(UnitOfMeasure1Units2.DerivedUnit3, otherUnits);
      Assert.Contains(UnitOfMeasure1Units2.DerivedUnit4, otherUnits);
   }
   
   [Fact]
   public void ByName_Contains_Expected_Values()
   {
      var expectedUnit = UnitOfMeasure1Units.DerivedUnit1;
      Assert.Equal(expectedUnit, UnitOfMeasure1Units.ByName[expectedUnit.Name]);
      expectedUnit = UnitOfMeasure1Units.DerivedUnit2;
      Assert.Equal(expectedUnit, UnitOfMeasure1Units.ByName[expectedUnit.Name]);
   }
   
   [Fact]
   public void BySymbol_Contains_Expected_Values()
   {
      var expectedUnit = UnitOfMeasure1Units.DerivedUnit1;
      Assert.Equal(expectedUnit, UnitOfMeasure1Units.BySymbol[expectedUnit.Symbol]);
      expectedUnit = UnitOfMeasure1Units.DerivedUnit2;
      Assert.Equal(expectedUnit, UnitOfMeasure1Units.BySymbol[expectedUnit.Symbol]);
   }
}