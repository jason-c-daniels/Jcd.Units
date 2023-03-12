namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record AsPerfTest() : TemperaturePerfTest("<type>.As(T)")
{
   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         q1 = i.As(C);
         q2 = ((double)i).As(F);
         q3 = ((float)i).As(F);
      }

      return 3 * iterations;
   }
}
