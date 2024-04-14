#region

using Jcd.Units.DoubleComparison;

// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable NotAccessedField.Local

#endregion

namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal record BitwiseComparerPerfTest() : DoublePerfTest("Bitwise comparer comparisons")
{
   private readonly IValueComparer<double> _comparer = BitwiseDoubleComparer.Instance;
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
         _r1 = _comparer.Equals(Value1, Value2);
         _r2 = _comparer.Equals(Value2, Value1);
      }

      return 2 * iterations;
   }
}