namespace Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;

internal class PerfTests : EnumerationBase<PerfTests, IPerfTest>
{
   public static readonly IPerfTest As = new AsPerfTest();
   public static readonly IPerfTest Conversion = new ConversionPerfTest();
   public static readonly IPerfTest QuantityMath1 = new MixedArithmeticDoubleOperationsPerfTest();
   public static readonly IPerfTest QuantityMath2 = new MultiplyByDoubleOperationsPerfTest();
   public static readonly IPerfTest QuantityMath3 = new SquaredPerfTest();
   public static readonly IPerfTest QuantityMath4 = new AddDoubleOperationsPerfTest();
   public static readonly IPerfTest QuantityMath5 = new AddToSelfOperationsPerfTest();
   public static readonly IPerfTest QuantityMath6 = new MinusDoubleOperationsPerfTest();
   public static readonly IPerfTest QuantityMath7 = new MinusWithOtherOperationsPerfTest();
   public static readonly IPerfTest QuantityMath8 = new DivideDoubleOperationsPerfTest();
   public static readonly IPerfTest QuantityMath9 = new DivideByOtherOperationsPerfTest();
   public static readonly IPerfTest ComparisonOfDifferentUnits = new ComparisonOfDifferentUnitsPerfTest();
   public static readonly IPerfTest ComparisonOfSameUnits = new ComparisonOfSameUnitsPerfTest();
}
