namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record SquaredPerfTest() : TemperaturePerfTest("Quantity<T> squared (with .As per iteration)")
{
   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         Quantity1 = i.As(Ra);
         Quantity2 = Quantity1 * Quantity1;
         Quantity3 = Quantity2 * Quantity2;
      }

      return 2 * iterations;
   }
}
