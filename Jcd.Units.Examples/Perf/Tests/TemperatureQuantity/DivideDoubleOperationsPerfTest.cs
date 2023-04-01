namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record DivideDoubleOperationsPerfTest() : TemperaturePerfTest(
                                                                       "Quantity<T> division with double (with .As per iteration)"
                                                                      )
{
   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         Quantity1 = i.As(Ra);
         Quantity2 = 3         - Quantity1;
         Quantity3 = Quantity2 - 7;
      }

      return 2 * iterations;
   }
}
