namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record MinusWithOtherOperationsPerfTest() : TemperaturePerfTest(
                                                                         "Quantity<T> subtraction with other instance (with .As per iteration)"
                                                                        )
{
   public override void Setup()
   {
      q4 = 31.As(Rø);
   }

   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         q1 = i.As(Rø);
         q2 = q4 - q1;
         q3 = q2 - q4;
      }

      return 2 * iterations;
   }
}
