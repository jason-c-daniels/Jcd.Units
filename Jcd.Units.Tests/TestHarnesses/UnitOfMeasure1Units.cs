namespace Jcd.Units.Tests.TestHarnesses;

public class UnitOfMeasure1Units : Enumeration<UnitOfMeasure1Units,UnitOfMeasure1>
{
    public static UnitOfMeasure1 BaseUnit = new("BaseUnit","bu");
    public static UnitOfMeasure1 DerivedUnit1 = new("DerivedUnit1","du1",BaseUnit,2.0,2);
    public static UnitOfMeasure1 DerivedUnit2 = new("DerivedUnit2","du2",DerivedUnit1,2.0,2);
}

public class UnitOfMeasure1Units2 : Enumeration<UnitOfMeasure1Units2,UnitOfMeasure1>
{
    public static UnitOfMeasure1 DerivedUnit3 = new("DerivedUnit1","du1",UnitOfMeasure1Units.DerivedUnit2,2.0,2);
    public static UnitOfMeasure1 DerivedUnit4 = new("DerivedUnit2","du2",DerivedUnit3,2.0,2);
}