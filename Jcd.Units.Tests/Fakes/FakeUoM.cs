namespace Jcd.Units.Tests.Fakes;

/// <summary>
/// A collection of fake units of measure along with a dictionary to allow lookup by symbol.
/// </summary>
internal static class FakeUoM
{
   public static readonly IReadOnlyDictionary<string, UnitOfMeasure1> LookupUoM1ByName =
            UnitOfMeasure1Units
                    .GetAll()
                    .ToDictionary(x => x.Name);

   public static readonly IReadOnlyDictionary<string, UnitOfMeasure1> LookupUoM2ByName =
            UnitOfMeasure1Units2
                    .GetAll()
                    .ToDictionary(x => x.Name);

   public static readonly UnitOfMeasure1 Dux10 = new ("DerivedUnit x10", "Dux10", UnitOfMeasure1Units.BaseUnit, 10);

   public static readonly UnitOfMeasure1 Dux100 = new (
                                                       "DerivedUnit x100"
                                                     , "Dux100"
                                                     , UnitOfMeasure1Units.BaseUnit
                                                     , 100
                                                      );

   public static readonly IReadOnlyDictionary<string, UnitOfMeasure1> LookupDuxBySymbol =
            new[] { Dux10, Dux100 }.ToDictionary(x => x.Symbol);

   public static readonly Int64ConversionComparer SixDecimalPlacesComparer = Int64ConversionComparer.SixDecimalPlaces;

   public static UnitOfMeasure1 GetUnit(string nameOrSymbol)
      => LookupUoM1ByName.ContainsKey(nameOrSymbol)
               ? LookupUoM1ByName[nameOrSymbol]
               : LookupUoM2ByName.ContainsKey(nameOrSymbol)
                        ? LookupUoM2ByName[nameOrSymbol]
                        : LookupDuxBySymbol[nameOrSymbol];
}
