// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global

using Jcd.RichEnumerations.Classes;

namespace Jcd.Units.Examples.Perf.Tests.Baseline;

internal class BaselinePerfTests : RichEnumBase<BaselinePerfTests, IPerfTest>
{
   public static readonly IPerfTest DoubleAdditionPerfTest = new DoubleAdditionPerfTest();
   public static readonly IPerfTest DoubleSubtractionPerfTest = new DoubleSubtractionPerfTest();
   public static readonly IPerfTest DoubleMultiplicationPerfTest = new DoubleMultiplicationPerfTest();
   public static readonly IPerfTest DoubleDivisionPerfTest = new DoubleDivisionPerfTest();
   public static readonly IPerfTest BuiltInComparison = new BuiltinDoubleComparisonPerfTest();
   public static readonly IPerfTest NoOpComparer = new NoOpComparerPerfTest();
   public static readonly IPerfTest BitwiseComparer = new BitwiseComparerPerfTest();
   public static readonly IPerfTest RoundingComparison = new RoundTo5PlacesDoubleComparisonPerfTest();
}
