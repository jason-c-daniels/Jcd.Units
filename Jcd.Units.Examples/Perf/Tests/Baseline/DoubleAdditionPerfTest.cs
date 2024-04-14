namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal record DoubleAdditionPerfTest() : DoublePerfTest("Add two Doubles")
{
   public override void Setup()
   {
      Value1 = 1d / 3d;
   }
   
   public override int Execute(int iterations = 1)
   {
      for (var i = 1; i <= iterations; i++)
      {
         Value2 = Value1 + i;
         Value3 = Value2 + 7.5d;
      }
      
      return 2 * iterations;
   }
}