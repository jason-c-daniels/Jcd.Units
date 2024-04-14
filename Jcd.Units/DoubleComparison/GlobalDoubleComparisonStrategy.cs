// ReSharper disable HeapView.BoxingAllocation

namespace Jcd.Units.DoubleComparison;

/// <summary>
/// Provides global fallback double comparison strategies used by <see cref="Quantity" /> and
/// <see cref="UnitOfMeasure" />.
/// </summary>
/// <remarks>
/// For performance reasons the properties within are not thread safe.
/// As well it's a bad practice to set these frequently in separate threads.
/// Your comparison results may be very unstable, even with proper thread synchronization.
/// </remarks>
public static class GlobalDoubleComparisonStrategy
{
   /// <summary>
   /// The default (bitwise) double comparer. You really should use something else.
   /// </summary>
   public static readonly IValueComparer<double> Default = BitwiseDoubleComparer.Instance;
   
   private static IValueComparer<double> _quantity = Default;
   
   private static IValueComparer<double> _unitOfMeasure = Default;
   
   /// <summary>
   /// The registered double comparer used by Quantities, by default.
   /// </summary>
   /// <remarks>
   /// This is not a thread safe property. Synchronize your code around setting/getting this if you plan on setting it
   /// outside of your application's startup code.
   /// </remarks>
   public static IValueComparer<double>? Quantity
   {
      get => _quantity;
      set => _quantity = value ?? throw new ArgumentNullException(nameof(value));
   }
   
   /// <summary>
   /// The globally registered double comparer used for comparing <see cref="UnitOfMeasure" /> instances. It's unlikely
   /// that you will actually need to set this to anything other than the default (bitwise comparison)
   /// </summary>
   /// <remarks>
   /// This is not a thread safe property. Synchronize your code around setting/getting this if you plan on setting it
   /// outside of your application's startup code.
   /// </remarks>
   public static IValueComparer<double>? UnitOfMeasure
   {
      get => _unitOfMeasure;
      set => _unitOfMeasure = value ?? throw new ArgumentNullException(nameof(value));
   }
}