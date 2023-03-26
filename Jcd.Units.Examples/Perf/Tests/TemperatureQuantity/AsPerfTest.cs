namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record AsPerfTest() : TemperaturePerfTest("<type>.As(T)")
{
   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         Quantity1 = i.As(C);
         Quantity2 = ((double)i).As(F);
         Quantity3 = ((float)i).As(F);
      }

      return 3 * iterations;
   }
}
