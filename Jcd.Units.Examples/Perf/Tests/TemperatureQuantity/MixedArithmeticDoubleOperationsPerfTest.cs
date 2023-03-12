namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record MixedArithmeticDoubleOperationsPerfTest() : TemperaturePerfTest(
                                                                                "Quantity<T> [on degrees F] with mixed arithmetic double operations (with .As per iteration)"
                                                                               )
{
   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         q1 =  i.As(F);
         q2 =  3d * q1;
         q2 -= 7d;
         q3 =  q2 / 4.0;
         q3 += 13d;
      }

      return 4 * iterations;
   }
}
