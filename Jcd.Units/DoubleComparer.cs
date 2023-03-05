#region

using System;

#endregion

namespace Jcd.Units;

/// <summary>
/// Provides both default and registrable ways of comparing doubles used within this subsystem.
/// </summary>
public static class DoubleComparer
{
   private static IValueComparer<double> _quantity = BitwiseDoubleComparer.Default;
   private static IValueComparer<double> _unitOfMeasure = BitwiseDoubleComparer.Default;

   /// <summary>
   /// The registered double comparer used by Quantities, by default. 
   /// </summary>
   public static IValueComparer<double>? Quantity
   {
      get => _quantity;
      set => _quantity = value ?? throw new ArgumentNullException(nameof(value));
   }

   /// <summary>
   /// The registered double comparer used by UnitOfMeasure instances, by default.
   /// </summary>
   public static IValueComparer<double>? UnitOfMeasure
   {
      get => _unitOfMeasure;
      set => _unitOfMeasure = value ?? throw new ArgumentNullException(nameof(value));
   }
}
