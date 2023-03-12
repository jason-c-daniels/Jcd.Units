namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal record DoubleSubtractionPerfTest() : DoublePerfTest("Subtract two doubles")
{
   public override void Setup()
   {
      d1 = 1d / 3d;
   }

   public override int Execute(int iterations = 1)
   {
      for (var i = 1; i <= iterations; i++)
      {
         d2 = i  - d1;
         d3 = d2 - 7.3d;
      }

      return 2 * iterations;
   }
}
