namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record SquaredPerfTest() : TemperaturePerfTest("Quantity<T> squared (with .As per iteration)")
{
   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         q1 = i.As(Ra);
         q2 = q1 * q1;
         q3 = q2 * q2;
      }

      return 2 * iterations;
   }
}
