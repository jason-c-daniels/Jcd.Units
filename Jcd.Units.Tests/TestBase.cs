#region

using Jcd.Units.DoubleComparison;
using Jcd.Units.Tests._Fakes;
using Jcd.Units.UnitSelection;
using Jcd.Units.UnitTypes;

#endregion

namespace Jcd.Units.Tests;

/// <summary>
/// The base of all tests. This types constructor is where you set globals that
/// need to have their state predictable for each test. And of course derive tests from it.
/// </summary>
public abstract class TestBase
{
   protected TestBase()
   {
      GlobalDoubleComparisonStrategy.Quantity      = GlobalDoubleComparisonStrategy.Default;
      GlobalDoubleComparisonStrategy.UnitOfMeasure = GlobalDoubleComparisonStrategy.Default;

      Quantity<UnitOfMeasure1>.DefaultDoubleComparer  = null;
      Quantity<UnitOfMeasure1>.ComparisonUnitSelector = null;
      Quantity<UnitOfMeasure1>.ArithmeticUnitSelector = null;

      Quantity<Length>.DefaultDoubleComparer  = null;
      Quantity<Length>.ComparisonUnitSelector = null;
      Quantity<Length>.ArithmeticUnitSelector = null;

      GlobalUnitSelectionStrategy.ForArithmetic = GlobalUnitSelectionStrategy.Default;
      GlobalUnitSelectionStrategy.ForComparison = GlobalUnitSelectionStrategy.Default;
   }
}
