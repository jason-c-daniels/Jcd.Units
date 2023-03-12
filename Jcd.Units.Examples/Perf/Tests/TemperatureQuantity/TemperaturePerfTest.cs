#region

using Jcd.Units.UnitsOfMeasure.USCustomary;
using Jcd.Units.UnitTypes;

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

   protected Quantity<Temperature> q1 { get; set; }
   protected Quantity<Temperature> q2 { get; set; }
   protected Quantity<Temperature> q3 { get; set; }
   protected Quantity<Temperature> q4 { get; set; }
}
