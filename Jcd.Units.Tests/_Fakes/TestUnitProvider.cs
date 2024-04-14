// ReSharper disable ClassNeverInstantiated.Global

namespace Jcd.Units.Tests._Fakes;

/// <summary>
/// A collection of fake units of measure along with a dictionary to allow lookup by symbol.
/// </summary>
internal class TestUnitProvider : UnitOfMeasureEnumeration<TestUnitProvider, UnitOfMeasure1>
{
   public static readonly UnitOfMeasure1 DerivedUnitX10 = new("DerivedUnitX10", "du x 10", UnitOfMeasure1Units.BaseUnit, 10);
   
   public static readonly UnitOfMeasure1 DerivedUnitX100 = new("DerivedUnitX100", "du x 100", UnitOfMeasure1Units.BaseUnit, 100);
   
   public static readonly Int64ConversionComparer SixDecimalPlacesComparer = Int64ConversionComparer.SixDecimalPlaces;
   
   public static UnitOfMeasure1 GetUnit(string nameOrSymbol)
   {
      return UnitOfMeasure1Units.ByName.ContainsKey(nameOrSymbol)
                ? UnitOfMeasure1Units.ByName[nameOrSymbol]
                : UnitOfMeasure1Units2.ByName.ContainsKey(nameOrSymbol)
                   ? UnitOfMeasure1Units2.ByName[nameOrSymbol]
                   : ByName[nameOrSymbol];
   }
}