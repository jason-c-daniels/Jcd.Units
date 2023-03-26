namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal record DoubleDivisionPerfTest() : DoublePerfTest("Divide two doubles")
{
   public override void Setup()
   {
      Value1 = 1d / 3d;
   }

   public override int Execute(int iterations = 1)
   {
      for (var i = 1; i <= iterations; i++)
      {
         Value2 = i      / Value1;
         Value3 = Value2 / 7.3d;
      }

      return 2 * iterations;
   }
}
