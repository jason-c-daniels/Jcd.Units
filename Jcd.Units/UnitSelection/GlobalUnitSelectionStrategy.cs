#region

using Jcd.Units.DoubleComparison;

#endregion

namespace Jcd.Units.UnitSelection;

/// <summary>
/// Globally registered 
/// </summary>
public static class GlobalUnitSelectionStrategy
{
   /// <summary>
   /// The default strategy used in selecting a unit of measure for comparison and/or arithmetic operations.
   /// </summary>
   public static readonly IUnitSelectionStrategy Default = SelectLargerUnit.Instance;

   private static IUnitSelectionStrategy _forArithmetic = Default;
   private static IUnitSelectionStrategy _forComparison = Default;

   /// <summary>
   /// The globally registered Unit of Measure selection strategy used for arithmetic operators.
   /// Results will be returned in the unit of measure selected by this unit selection strategy.
   /// By default this is the <see cref="SelectLargerUnit"/> implementation.
   /// </summary>
   /// <remarks>
   /// This is not a thread safe property. Synchronize your code around setting/getting this if you plan on setting it outside of your application's startup code.
   /// </remarks>
   public static IUnitSelectionStrategy ForArithmetic
   {
      get => _forArithmetic;
      set => _forArithmetic = value ?? throw new ArgumentNullException(nameof(value));
   }

   /// <summary>
   /// The globally registered Unit of Measure selection strategy used for comparison operators.
   /// Operands will be compared in the units selected by this unit selection strategy.
   /// By default this is the <see cref="SelectLargerUnit"/> implementation.
   /// </summary>
   /// <remarks>
   /// NOTES:
   /// 1. Before changing this consider if this will impact the DoubleComparers you have registered (either in <see cref="GlobalDoubleComparisonStrategy"/>'s <c>Quantity</c> property, or instance level registrations.
   /// (i.e. if the operands are converted to a unit with greater or fewer digits after the decimal point, your comparisons may not return the expected results. Always do trial runs first to ensure the expected behavior.)
   /// 
   /// 2. This is not a thread safe property. Synchronize your code around setting/getting this if you plan on setting it outside of your application's startup code.
   /// </remarks>
   public static IUnitSelectionStrategy ForComparison
   {
      get => _forComparison;
      set => _forComparison = value ?? throw new ArgumentNullException(nameof(value));
   }
}
