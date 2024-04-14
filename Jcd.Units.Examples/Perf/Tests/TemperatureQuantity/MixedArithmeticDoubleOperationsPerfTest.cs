namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record MixedArithmeticDoubleOperationsPerfTest()
   : TemperaturePerfTest("Quantity<T> [on degrees F] with mixed arithmetic double operations (with .As per iteration)")
{
   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         Quantity1 = i.As(F);
         Quantity2 = 3d * Quantity1;
         Quantity2 -= 7d;
         Quantity3 = Quantity2 / 4.0;
         Quantity3 += 13d;
      }
      
      return 4 * iterations;
   }
}