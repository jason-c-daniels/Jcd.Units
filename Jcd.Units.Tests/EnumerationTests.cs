using Jcd.Units.Tests.TestHarnesses;

namespace Jcd.Units.Tests;

public class EnumerationTests
{
    [Fact]
    public void GetAll_Returns_Expected_Values()
    {
        var units = UnitOfMeasure1Units.GetAll().ToList();
        var expectedCount = 3;
        Assert.Equal(expectedCount,units.Count);
        Assert.Contains(UnitOfMeasure1Units.BaseUnit, units);
        Assert.Contains(UnitOfMeasure1Units.DerivedUnit1, units);
        Assert.Contains(UnitOfMeasure1Units.DerivedUnit2, units);
    }
}