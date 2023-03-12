namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record ComparisonOfSameUnitsPerfTest() : TemperaturePerfTest("Quantity<T> Comparison Of Same Units")
{
   private bool _r1;
   private bool _r2;

   public override void Setup()
   {
      q1  = 100.As(C);
      q2  = q1 + 7;
      q3  = q2 - 1d / 3d * 100d;
      _r1 = false;
      _r2 = false;
   }

   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         _r1 = q1 == q2;
         _r2 = q2 == q3;
      }

      return 2 * iterations;
   }
}
