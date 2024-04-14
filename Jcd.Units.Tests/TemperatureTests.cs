#region

using Jcd.Units.DoubleComparison;
using Jcd.Units.UnitsOfMeasure.SI;
using Jcd.Units.UnitTypes;

using US = Jcd.Units.UnitsOfMeasure.USCustomary;

#endregion

namespace Jcd.Units.Tests;

public class TemperatureTests
{
   private static readonly Temperature DegreesKiloKelvin = new("kilokelvin", "°kK", Temperatures.DegreesKelvin, 1000.0);
   
   private static readonly IReadOnlyList<Temperature> AllTemps = new[]
                                                                 {
                                                                    US.Temperatures.DegreesFahrenheit
                                                                  , Temperatures.DegreesCelsius
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
   [InlineData(-1000d,              "°K",  -1d,                 "°kK")]
   [InlineData(-2000d,              "°K",  -2d,                 "°kK")]
   [InlineData(0d,                  "°K",  0d,                  "°kK")]
   [InlineData(1000d,               "°K",  1d,                  "°kK")]
   [InlineData(2000d,               "°K",  2d,                  "°kK")]
   [InlineData(-273.15,             "°C",  0d,                  "°K")]
   [InlineData(0d,                  "°C",  273.15d,             "°K")]
   [InlineData(1000d,               "°C",  1273.15,             "°K")]
   [InlineData(2000d,               "°C",  2273.15,             "°K")]
   [InlineData(1d,                  "°kK", 726.85,              "°C")]
   [InlineData(1000d,               "°K",  726.85,              "°C")]
   [InlineData(0d,                  "°R",  0,                   "°K")]
   [InlineData(1.8d,                "°R",  1d,                  "°K")]
   [InlineData(1d,                  "°C",  493.47,              "°R")]
   [InlineData(1d,                  "°N",  497.1245454545454,   "°R")]
   [InlineData(7d,                  "°N",  529.85181818181818,  "°R")]
   [InlineData(-7d,                 "°N",  453.488181818181818, "°R")]
   [InlineData(1d,                  "°N",  2.424242424242424,   "°Ré")]
   [InlineData(7d,                  "°N",  16.96969696969696,   "°Ré")]
   [InlineData(-4.125,              "°N",  -10,                 "°Ré")]
   [InlineData(-1.5714285714285714, "°N",  5d,                  "°Rø")]
   [InlineData(-25.66645714285714,  "°N",  -33.333,             "°Rø")]
   [InlineData(16.237885714285714,  "°N",  33.333,              "°Rø")]
   [InlineData(-300,                "°De", 300d,                "°C")]
   [InlineData(300,                 "°De", -100,                "°C")]
   [InlineData(10000,               "°De", -6566.66666666666,   "°C")]
   public void Value_Converts_As_Expected(double source, string sourceSymbol, double target, string targetSymbol)
   {
      var comparer = BuiltInRoundingComparer.TenDecimalPlaces;
      var su = TemperatureBySymbol[sourceSymbol];
      var tu = TemperatureBySymbol[targetSymbol];
      
      var sq1 = source.As(su);
      var tq = sq1.To(tu);
      
      Assert.Equal(target, (double) tq, comparer);
      
      var tq1 = target.As(tu);
      var sq = tq1.To(su);
      
      Assert.Equal(source, (double) sq, comparer);
   }
}