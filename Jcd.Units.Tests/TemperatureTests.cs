#region

using Jcd.Units.DoubleComparison;
using Jcd.Units.UnitsOfMeasure.SI;
using Jcd.Units.UnitTypes;

using US = Jcd.Units.UnitsOfMeasure.USCustomary;

#endregion

namespace Jcd.Units.Tests;

public class TemperatureTests
{
   private static readonly Temperature DegreesKiloKelvin =
            new ("kilokelvin", "°kK", Temperatures.DegreesKelvin, 1000.0);

   private static readonly IReadOnlyList<Temperature> AllTemps = new[]
                                                                 {
                                                                          US.Temperatures.DegreesFahrenheit
                                                                        , Temperatures.DegreesCelcius
                                                                        , Temperatures.DegreesKelvin
                                                                        , UnitsOfMeasure.Temperatures.DegreesDelisle
                                                                        , UnitsOfMeasure.Temperatures.DegreesNewton
                                                                        , UnitsOfMeasure.Temperatures.DegreesRankine
                                                                        , UnitsOfMeasure.Temperatures.DegreesRéaumur
                                                                        , UnitsOfMeasure.Temperatures.DegreesRømer
                                                                        , DegreesKiloKelvin
                                                                 };

   private static readonly Dictionary<string, Temperature> TemperatureBySymbol = AllTemps.ToDictionary(x => x.Symbol);

   [Theory]

   // [InlineData(-1000d,"°K",-1d,"°kK")]
   // [InlineData(-2000d,"°K",-2d,"°kK")]
   // [InlineData(0d,"°K",0d,"°kK")]
   // [InlineData(1000d,"°K",1d,"°kK")]
   // [InlineData(2000d,"°K",2d,"°kK")]
   [InlineData(-273.15, "°C", 0d, "°K")]

   // [InlineData(0d,"°C",273.15d,"°K")]
   [InlineData(1000d, "°C", 726.85, "°K")]
   [InlineData(2000d, "°C", 1726.85, "°K")]
   public void Value_Converts_As_Expected(double source, string sourceSymbol, double target, string targetSymbol)
   {
      var comparer = BuiltInRoundingComparer.TenDecimalPlaces;
      var su       = TemperatureBySymbol[sourceSymbol];
      var tu       = TemperatureBySymbol[targetSymbol];

      var tq = source.As(su)
                     .To(tu);

      Assert.Equal(target, (double)tq, comparer);

      var sq = target.As(tu)
                     .To(su);

      Assert.Equal(source, (double)sq, comparer);
   }
}
