namespace Jcd.Units.Tests.Fakes;

// ReSharper disable once ClassNeverInstantiated.Global
public class UnitOfMeasure1Units2 : Enumeration<UnitOfMeasure1Units2, UnitOfMeasure1>
{
   public static readonly UnitOfMeasure1 DerivedUnit3 = new (
                                                             "DerivedUnit3"
                                                           , "du3"
                                                           , UnitOfMeasure1Units.DerivedUnit2
                                                           , 3.0
                                                           , 2
                                                            );

   public static readonly UnitOfMeasure1 DerivedUnit4 = new ("DerivedUnit4", "du4", DerivedUnit3, 4.0, 2);
}
