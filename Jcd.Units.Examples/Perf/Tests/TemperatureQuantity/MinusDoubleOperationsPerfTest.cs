namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record MinusDoubleOperationsPerfTest() : TemperaturePerfTest(
                                                                      "Quantity<T> subtraction with double (with .As per iteration)"
                                                                     )
{
   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         q1 = i.As(Ra);
         q2 = 3  - q1;
         q3 = q2 - 7;
      }

      return 2 * iterations;
   }
}
