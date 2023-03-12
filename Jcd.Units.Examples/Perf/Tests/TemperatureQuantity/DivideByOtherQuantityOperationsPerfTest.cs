namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record DivideByOtherOperationsPerfTest() : TemperaturePerfTest(
                                                                        "Quantity<T> divide by other instance (with .As per iteration)"
                                                                       )
{
   public override void Setup()
   {
      q4 = 37.As(Rø);
   }

   public override int Execute(int iterations = 1)
   {
      for (var i = 1; i <= iterations; i++)
      {
         q1 = i.As(Rø);
         q2 = q4 / q1;
         q3 = q2 / q4;
      }

      return 2 * iterations;
   }
}
