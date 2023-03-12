#region

using Jcd.Units.DoubleComparison;

#endregion

namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal record NoOpComparerPerfTest() : DoublePerfTest("No-op comparer calls")
{
   private readonly IValueComparer<double> _comparer = BitwiseDoubleComparer.Instance;

   private bool _r1;
   private bool _r2;

   public override void Setup()
   {
      d1 = 1d        / 3d;
      d2 = 1.000015d / 3d;
   }

   public override int Execute(int iterations = 1)
   {
      for (var i = 0; i < iterations; i++)
      {
         _r1 = _comparer.Equals(d1, d2);
         _r2 = _comparer.Equals(d2, d1);
      }

      return 2 * iterations;
   }

   private class NoOpComparer : IValueComparer<double>
   {
      public int Compare(double x, double y) => 1;

      public bool Equals(double x, double y) => true;

      public int GetHashCode(double obj) => -1d.GetHashCode();
   }
}
