namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal record DoubleAdditionPerfTest() : DoublePerfTest("Add two Doubles")
{
   public override void Setup()
   {
      d1 = 1d / 3d;
   }

   public override int Execute(int iterations = 1)
   {
      for (var i = 1; i <= iterations; i++)
      {
         d2 = d1 + i;
         d3 = d2 + 7.5d;
      }

      return 2 * iterations;
   }
}
