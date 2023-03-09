namespace Jcd.Units.Tests.Fakes;

// ReSharper disable once ClassNeverInstantiated.Global
public class UnitOfMeasure1Units : Enumeration<UnitOfMeasure1Units, UnitOfMeasure1>
{
   public static readonly UnitOfMeasure1 BaseUnit = new ("BaseUnit", "bu");
   public static readonly UnitOfMeasure1 DerivedUnit1 = new ("DerivedUnit1", "du1", BaseUnit, 2.0, 2);
   public static readonly UnitOfMeasure1 DerivedUnit2 = new ("DerivedUnit2", "du2", DerivedUnit1, 2.0, 2);
}
