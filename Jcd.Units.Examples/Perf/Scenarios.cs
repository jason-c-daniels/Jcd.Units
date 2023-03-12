#region

using Jcd.Units.DoubleComparison;
using Jcd.Units.UnitSelection;
using Jcd.Units.UnitTypes;

#endregion

namespace Jcd.Units.Examples.Perf;

public class Scenarios : EnumerationBase<Scenarios, Scenario>
{
   public static readonly Scenario DefaultSettings = new (
                                                          "Using all default settings"
                                                        , ConfigureDefaultSelectorsAndComparers
                                                        , ConfigureDefaultSelectorsAndComparers
                                                         );

   public static readonly Scenario DefaultComparersAndSelectLeftUnit = new (
                                                                            "Using default global unit of measure and quantity comparers. Selecting left unit of measure."
                                                                          , ConfigureRoundTo15DecimalPlacesForAllComparers
                                                                          , ConfigureDefaultSelectorsAndComparers
                                                                           );

   public static readonly Scenario ComparersRoundTo15DecimalPlaces = new (
                                                                          "Using global unit of measure and quantity comparers that round to 15 decimal places"
                                                                        , ConfigureRoundTo15DecimalPlacesForAllComparers
                                                                        , ConfigureDefaultSelectorsAndComparers
                                                                         );

   public static readonly Scenario ComparersRoundTo5DecimalPlaces = new (
                                                                         "Using global unit of measure and quantity comparers that round to 5 decimal places"
                                                                       , ConfigureRoundTo5DecimalPlacesForAllComparers
                                                                       , ConfigureDefaultSelectorsAndComparers
                                                                        );

   public static readonly Scenario SelectLeftUnitAndComparersRoundTo15DecimalPlaces = new (
       "Using arithmetic and comparison unit selection of Left unit. global unit of measure and quantity comparers round to 15 decimal places"
     , ConfigureSelectLeftUnitAndRoundTo15DecimalPlacesForAllComparers
     , ConfigureDefaultSelectorsAndComparers
      );

   public static readonly Scenario SelectLeftUnitAndComparersRoundTo5DecimalPlaces = new (
       "Using arithmetic and comparison unit selection of Left unit. global unit of measure and quantity comparers round to 5 decimal places"
     , ConfigureSelectLeftUnitAndRoundTo5DecimalPlacesForAllComparers
     , ConfigureDefaultSelectorsAndComparers
      );

   private static void ConfigureDefaultSelectorsAndComparers() => ConfigureSettings();

   private static void ConfigureRoundTo15DecimalPlacesForAllComparers()
      => ConfigureSettings(BuiltInRoundingComparer.FifteenDecimalPlaces, BuiltInRoundingComparer.FifteenDecimalPlaces);

   private static void ConfigureRoundTo5DecimalPlacesForAllComparers()
      => ConfigureSettings(BuiltInRoundingComparer.FiveDecimalPlaces, BuiltInRoundingComparer.FiveDecimalPlaces);

   private static void ConfigureSelectLeftUnitAndUseDefaultComparers() => ConfigureSettings(
       null
     , null
     , SelectLeftUnit.Instance
     , SelectLeftUnit.Instance
      );

   private static void ConfigureSelectLeftUnitAndRoundTo5DecimalPlacesForAllComparers() => ConfigureSettings(
       BuiltInRoundingComparer.FiveDecimalPlaces
     , BuiltInRoundingComparer.FiveDecimalPlaces
     , SelectLeftUnit.Instance
     , SelectLeftUnit.Instance
      );

   private static void ConfigureSelectLeftUnitAndRoundTo15DecimalPlacesForAllComparers() => ConfigureSettings(
       BuiltInRoundingComparer.FifteenDecimalPlaces
     , BuiltInRoundingComparer.FifteenDecimalPlaces
     , SelectLeftUnit.Instance
     , SelectLeftUnit.Instance
      );

   private static void ConfigureSettings
            (
            IValueComparer<double>? globalUnitOfMeasureComparer = null
          , IValueComparer<double>? globalQuantityComparer = null
          , IUnitSelectionStrategy? globalMathUnitSelectionStrategy = null
          , IUnitSelectionStrategy? globalComparisonUnitSelectionStrategy = null
          , IValueComparer<double>? quantityDoubleComparer = null
          , IUnitSelectionStrategy? quantityMathUnitSelector = null
          , IUnitSelectionStrategy? quantityComparisonUnitSelector = null
            )
   {
      GlobalDoubleComparisonStrategy.UnitOfMeasure =
               globalUnitOfMeasureComparer ?? GlobalDoubleComparisonStrategy.Default;

      GlobalDoubleComparisonStrategy.Quantity = globalQuantityComparer ?? GlobalDoubleComparisonStrategy.Default;

      GlobalUnitSelectionStrategy.ForArithmetic =
               globalMathUnitSelectionStrategy ?? GlobalUnitSelectionStrategy.Default;

      GlobalUnitSelectionStrategy.ForComparison =
               globalComparisonUnitSelectionStrategy ?? GlobalUnitSelectionStrategy.Default;

      Quantity<Temperature>.DefaultDoubleComparer  = quantityDoubleComparer;
      Quantity<Temperature>.ArithmeticUnitSelector = quantityMathUnitSelector;
      Quantity<Temperature>.ComparisonUnitSelector = quantityComparisonUnitSelector;
   }
}
