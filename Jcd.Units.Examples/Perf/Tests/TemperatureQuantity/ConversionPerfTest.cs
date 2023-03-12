namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record ConversionPerfTest() : TemperaturePerfTest("Quantity<T> Unit Conversion (with .As per iteration)")
{
   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         q1 = i.As(C);
         q2 = q1.To(F);
         q3 = q2.To(Ra);
      }

      return 2 * iterations;
   }
}
