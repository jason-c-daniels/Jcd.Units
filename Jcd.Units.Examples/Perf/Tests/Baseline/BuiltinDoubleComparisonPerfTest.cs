namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal record BuiltinDoubleComparisonPerfTest() : DoublePerfTest("Builtin Double Comparison")
{
   private bool _r1;
   private bool _r2;

   public override void Setup()
   {
      d1 = 1d        / 3d;
      d2 = 1.000015d / 3d;
   }

   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         _r1 = d1 == d2;
         _r2 = d2 == d1;
      }

      return 2 * iterations;
   }
}
