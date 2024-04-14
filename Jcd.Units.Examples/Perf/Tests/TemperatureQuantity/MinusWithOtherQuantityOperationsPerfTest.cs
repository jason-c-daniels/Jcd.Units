namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal record MinusWithOtherOperationsPerfTest() : TemperaturePerfTest("Quantity<T> subtraction with other instance (with .As per iteration)")
{
   public override void Setup()
   {
      Quantity4 = 31.As(Rø);
   }
   
   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         Quantity1 = i.As(Rø);
         Quantity2 = Quantity4 - Quantity1;
         Quantity3 = Quantity2 - Quantity4;
      }
      
      return 2 * iterations;
   }
}