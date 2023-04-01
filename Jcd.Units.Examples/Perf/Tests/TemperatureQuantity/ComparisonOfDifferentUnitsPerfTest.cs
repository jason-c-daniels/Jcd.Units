// ReSharper disable NotAccessedField.Local

namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record ComparisonOfDifferentUnitsPerfTest() : TemperaturePerfTest("Quantity<T> Comparison Of Different Units")
{
   private bool _r1;
   private bool _r2;

   public override void Setup()
   {
      Quantity1 = 100.As(C);
      Quantity2 = Quantity1.To(F);
      Quantity3 = Quantity2.To(Ra) + 1;
      _r1       = false;
      _r2       = false;
   }

   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         _r1 = Quantity1 == Quantity2;
         _r2 = Quantity2 == Quantity3;
      }

      return 2 * iterations;
   }
}
