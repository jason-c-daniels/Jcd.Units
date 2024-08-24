#region

using Jcd.Units.UnitsOfMeasure.USCustomary;
using Jcd.Units.UnitTypes;

// ReSharper disable UnusedMember.Global

#endregion

namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal abstract record TemperaturePerfTest(string Description) : PerfTestBase(Description)
{
   protected static readonly Temperature F = Temperatures
           .DegreesFahrenheit;

   protected static readonly Temperature C = UnitsOfMeasure.SI.Temperatures
                                                           .DegreesCelcius;

   protected static readonly Temperature Ra = UnitsOfMeasure.Temperatures
                                                            .DegreesRankine;

   protected static readonly Temperature Ré = UnitsOfMeasure.Temperatures
                                                            .DegreesRéaumur;

   protected static readonly Temperature Rø = UnitsOfMeasure.Temperatures
                                                            .DegreesRømer;

   private static Quantity<Temperature> DefaultTemp = 0.As(C);

   protected Quantity<Temperature> Quantity1 { get; set; } = DefaultTemp;
   protected Quantity<Temperature> Quantity2 { get; set; } = DefaultTemp;
   protected Quantity<Temperature> Quantity3 { get; set; } = DefaultTemp;
   protected Quantity<Temperature> Quantity4 { get; set; } = DefaultTemp;
}
