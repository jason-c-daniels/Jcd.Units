// ReSharper disable CompareOfFloatsByEqualityOperator
// ReSharper disable NotAccessedField.Local

namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal record BuiltinDoubleComparisonPerfTest() : DoublePerfTest("Builtin Double Comparison")
{
   private bool _r1;
   private bool _r2;

   public override void Setup()
   {
      Value1 = 1d        / 3d;
      Value2 = 1.000015d / 3d;
   }

   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         _r1 = Value1 == Value2;
         _r2 = Value2 == Value1;
      }

      return 2 * iterations;
   }
}
