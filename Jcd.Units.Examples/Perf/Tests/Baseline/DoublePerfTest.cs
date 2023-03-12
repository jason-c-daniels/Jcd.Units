namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal abstract record DoublePerfTest(string Description) : PerfTestBase(Description)
{
   protected double d1 { get; set; }
   protected double d2 { get; set; }
   protected double d3 { get; set; }
   protected double d4 { get; set; }
}
