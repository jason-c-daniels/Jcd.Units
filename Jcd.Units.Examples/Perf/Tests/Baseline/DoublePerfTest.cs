// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global

namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal abstract record DoublePerfTest(string Description) : PerfTestBase(Description)
{
   protected double Value1 { get; set; }
   protected double Value2 { get; set; }
   protected double Value3 { get; set; }

   protected double Value4 { get; set; }
}