namespace Jcd.Units.Tests.TestHarnesses;

// ReSharper disable once ClassNeverInstantiated.Global
public class UnitOfMeasure1Units2 : Enumeration<UnitOfMeasure1Units2, UnitOfMeasure1>
{
   public static readonly UnitOfMeasure1 DerivedUnit3 = new ("DerivedUnit1", "du1", UnitOfMeasure1Units.DerivedUnit2, 2.0, 2);
   public static readonly UnitOfMeasure1 DerivedUnit4 = new ("DerivedUnit2", "du2", DerivedUnit3, 2.0, 2);
}
