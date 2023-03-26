namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record ConversionPerfTest() : TemperaturePerfTest("Quantity<T> Unit Conversion (with .As per iteration)")
{
   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         Quantity1 = i.As(C);
         Quantity2 = Quantity1.To(F);
         Quantity3 = Quantity2.To(Ra);
      }

      return 2 * iterations;
   }
}
