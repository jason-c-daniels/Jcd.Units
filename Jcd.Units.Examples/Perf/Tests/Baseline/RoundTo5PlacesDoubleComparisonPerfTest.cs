#region

using Jcd.Units.DoubleComparison;

#endregion

namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal record RoundTo5PlacesDoubleComparisonPerfTest() : DoublePerfTest("Round to 5 decimal places double comparison")
{
   private readonly IValueComparer<double> _comparer = BuiltInRoundingComparer.FiveDecimalPlaces;
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
}
