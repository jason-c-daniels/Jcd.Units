// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Jcd.Units.DoubleComparison;

/// <summary>
/// Rounds two values then compares them using the builtin Round method of <see cref="System.Math"/>
/// </summary>
public readonly struct BuiltInRoundingComparer : IValueComparer<double>
{
   #region Convenience properties.

   /// <summary>
   /// A Rounds to a whole number using <see cref="MidpointRounding.ToEven"/> as the midpoint rounding method.
   /// </summary>
   public static readonly BuiltInRoundingComparer WholeNumber = new (0);

   /// <summary>
   /// A 1 decimal place rounding comparer, using <see cref="MidpointRounding.ToEven"/> as the midpoint rounding method.
   /// </summary>
   public static readonly BuiltInRoundingComparer OneDecimalPlace = new (1);

   /// <summary>
   /// A 2 decimal place rounding comparer, using <see cref="MidpointRounding.ToEven"/> as the midpoint rounding method.
   /// </summary>
   public static readonly BuiltInRoundingComparer TwoDecimalPlaces = new (2);

   /// <summary>
   /// A 3 decimal place rounding comparer, using <see cref="MidpointRounding.ToEven"/> as the midpoint rounding method.
   /// </summary>
   public static readonly BuiltInRoundingComparer ThreeDecimalPlaces = new (3);

   /// <summary>
   /// A 4 decimal place rounding comparer, using <see cref="MidpointRounding.ToEven"/> as the midpoint rounding method.
   /// </summary>
   public static readonly BuiltInRoundingComparer FourDecimalPlaces = new (4);

   /// <summary>
   /// A 5 decimal place rounding comparer, using <see cref="MidpointRounding.ToEven"/> as the midpoint rounding method.
   /// </summary>
   public static readonly BuiltInRoundingComparer FiveDecimalPlaces = new (5);

   /// <summary>
   /// A 6 decimal place rounding comparer, using <see cref="MidpointRounding.ToEven"/> as the midpoint rounding method.
   /// </summary>
   public static readonly BuiltInRoundingComparer SixDecimalPlaces = new (6);

   /// <summary>
   /// A 9 decimal place rounding comparer, using <see cref="MidpointRounding.ToEven"/> as the midpoint rounding method.
   /// </summary>
   public static readonly BuiltInRoundingComparer NineDecimalPlaces = new (9);

   /// <summary>
   /// A 10 decimal place rounding comparer, using <see cref="MidpointRounding.ToEven"/> as the midpoint rounding method.
   /// </summary>
   public static readonly BuiltInRoundingComparer TenDecimalPlaces = new (10);

   /// <summary>
   /// A 15 decimal place rounding comparer, using <see cref="MidpointRounding.ToEven"/> as the midpoint rounding method.
   /// This is the maximum number of valid .
   /// </summary>
   public static readonly BuiltInRoundingComparer FifteenDecimalPlaces = new (15);

   /// <summary>
   /// An alias for <see cref="FifteenDecimalPlaces"/>
   /// </summary>
   public static readonly BuiltInRoundingComparer Default = FifteenDecimalPlaces;

   #endregion

   /// <summary>
   /// The number of decimal places to round to.
   /// </summary>
   public int DecimalPlaces { get; }

   /// <summary>
   /// The rounding method to employ.
   /// </summary>
   public MidpointRounding RoundingMethod { get; }

   /// <summary>
   /// Constructs an instance of <see cref="BuiltInRoundingComparer"/> from number of decimal places and a rounding method.
   /// </summary>
   /// <param name="decimalPlaces">The number of decimal places to round to.</param>
   /// <param name="roundingMethod">The rounding method to use.</param>
   public BuiltInRoundingComparer(int decimalPlaces, MidpointRounding roundingMethod = MidpointRounding.ToEven)
   {
      DecimalPlaces  = decimalPlaces;
      RoundingMethod = roundingMethod;
   }

   private double Round(double value) => Math.Round(value, DecimalPlaces, RoundingMethod);

   /// <inheritdoc />
   public int Compare(double x, double y)
   {
      var rx = Round(x);
      var ry = Round(y);

      return rx.CompareTo(ry);
   }

   /// <inheritdoc />
   public bool Equals(double x, double y)
      => Compare(x, y) == 0;

   /// <inheritdoc />
   public int GetHashCode(double obj)
      => Round(obj)
              .GetHashCode();
}
