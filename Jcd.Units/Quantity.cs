#region

using System.Globalization;

using Jcd.Units.DoubleComparison;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable StaticMemberInGenericType

#endregion

namespace Jcd.Units;

/// <summary>
/// Represents a quantity with an associated unit of measure.
/// </summary>
/// <param name="RawValue">The numeric portion, without associated unit of measure</param>
/// <param name="Unit">The unit of measure.</param>
/// <typeparam name="TUnit">
/// The data type of the unit of measure. It must derive from <see cref="UnitOfMeasure{TUnit}" />
/// </typeparam>
public readonly record struct Quantity<TUnit>(double RawValue, TUnit Unit) :
         IComparable<Quantity<TUnit>>
       , IFormattable
       , IComparable
         where TUnit : UnitOfMeasure<TUnit>
{
   private static IUnitSelectionStrategy? _comparisonUnitSelector = null;
   private static IUnitSelectionStrategy? _arithmeticUnitSelector = null;
   private readonly IValueComparer<double>? _comparer = null;

   /// <summary>
   /// Represents a quantity with an associated unit of measure.
   /// </summary>
   /// <param name="rawValue">The numeric portion, without associated unit of measure</param>
   /// <param name="unit">The unit of measure.</param>
   /// <param name="baseUnitComparer">Compares two doubles represented as doubles in the base unit of measure.</param>
   public Quantity
            (
            double rawValue
          , TUnit unit
          , IValueComparer<double>? baseUnitComparer = null
            ) :
            this(rawValue, unit)
   {
      _comparer = baseUnitComparer;
   }

   /// <summary>
   /// Sets the default <see cref="IValueComparer{Double}" /> used by quantities for the particular unit of
   /// measure type. (e.g. lengths.)
   /// </summary>
   public static IValueComparer<double>? DefaultDoubleComparer { get; set; }

   /// <summary>
   /// The <see cref="IUnitSelectionStrategy" /> used by quantities of the particular unit of
   /// measure type (e.g. lengths) to select which unit of measure will be used to perform comparisons.
   /// </summary>
   public static IUnitSelectionStrategy? ComparisonUnitSelector
   {
      get => _comparisonUnitSelector ?? GlobalUnitSelectionStrategy.ForComparison;
      set => _comparisonUnitSelector = value;
   }

   /// <summary>
   /// The <see cref="IUnitSelectionStrategy" /> used by quantities of the particular unit of
   /// measure type (e.g. lengths) to select which unit of measure will be returned from arithmetic operations.
   /// </summary>
   public static IUnitSelectionStrategy? ArithmeticUnitSelector
   {
      get => _arithmeticUnitSelector ?? GlobalUnitSelectionStrategy.ForArithmetic;
      set => _arithmeticUnitSelector = value;
   }

   /// <summary>
   /// The <see cref="IValueComparer{T}" /> used for comparisons: where <c>T</c> is a <see cref="double" />.
   /// </summary>
   /// <remarks>
   /// If not assigned during initialization, this returns <see cref="UnitOfMeasure{TUnit}" />
   /// type specific comparison (e.g. Temperatures) or and the globally configured comparer.
   /// </remarks>
   public IValueComparer<double>? Comparer => _comparer
                                           ?? DefaultDoubleComparer
                                           ?? GlobalDoubleComparisonStrategy.UnitOfMeasure;

   /// <summary>
   /// Converts the quantity from its current unit of measure to the target unit of measure.
   /// </summary>
   /// <param name="targetUnit">The target unit of measure</param>
   /// <returns>The new quantity represented as the new unit of measure.</returns>
   public Quantity<TUnit> To(TUnit targetUnit)
   {
      if (ReferenceEquals(Unit, targetUnit)) return this;

      var nv  = Unit.ToFundamentalUnitValue(RawValue);
      var dnv = targetUnit.FromFundamentalUnitValue(nv);

      return new Quantity<TUnit>(dnv, targetUnit, _comparer);
   }

   #region Explicit conversions

   /// <summary>
   /// Explicit cast conversion to double.
   /// </summary>
   /// <param name="q">The quantity to convert.</param>
   /// <returns>The raw double representation without any unit of measure.</returns>
   public static explicit operator double(Quantity<TUnit> q) => q.RawValue;

   #endregion

   #region Overrides of ValueType

   /// <summary>
   /// Formats a string with the quantity value followed by the symbol.
   /// </summary>
   /// <returns>The formatted string.</returns>
   public override string ToString() =>
            ToString("n", CultureInfo.CurrentCulture);

   /// <summary>
   /// Outputs the number formatted according to the <paramref name="format" />
   /// with unit symbol.
   /// </summary>
   /// <param name="format">The format to apply to the number portion</param>
   /// <returns>The formatted value.</returns>
   public string ToString(string format)
      => ToString(format, CultureInfo.CurrentCulture);

   /// <summary>
   /// Formats the value of the current instance using the specified format.
   /// </summary>
   /// <param name="format">The format to use. Null or empty string uses the default.</param>
   /// <param name="provider">The provider to use to format the value. Null uses the current locale.</param>
   /// <returns></returns>
   public string ToString(string? format, IFormatProvider? provider)
   {
      if (string.IsNullOrEmpty(format)) format = "n";
      provider ??= CultureInfo.CurrentCulture;

      var sb = new StringBuilder();
      sb.Append(RawValue.ToString(format, provider));
      sb.Append($" {Unit.Symbol}");

      return sb.ToString();
   }

   #endregion

   #region Quantity to Quantity and unary Quantity arithmetic operators.

   /// <summary>
   /// Performs a standard unary "+" operation.
   /// </summary>
   /// <param name="q">The <see cref="Quantity{TUnit}" /> to operate on.</param>
   /// <returns>The <see cref="Quantity{TUnit}" /></returns>
   public static Quantity<TUnit> operator +(Quantity<TUnit> q)
      => q;

   /// <summary>
   /// Performs unary negation on the <see cref="RawValue" /> component and
   /// returns a new <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="q">The quantity to perform the negation on.</param>
   /// <returns>The negated form of the <see cref="Quantity{TUnit}" /></returns>
   public static Quantity<TUnit> operator -(Quantity<TUnit> q)
      => q with { RawValue = -q.RawValue };

   /// <summary>
   /// Performs a unary increment operation.
   /// </summary>
   /// <param name="q">The <see cref="Quantity{TUnit}" /> to operate on.</param>
   /// <returns>The <see cref="Quantity{TUnit}" /></returns>
   public static Quantity<TUnit> operator ++(Quantity<TUnit> q)
      => q with { RawValue = q.RawValue + 1 };

   /// <summary>
   /// Performs a unary decrement operation.
   /// </summary>
   /// <param name="q">The <see cref="Quantity{TUnit}" /> to operate on.</param>
   /// <returns>The <see cref="Quantity{TUnit}" /></returns>
   public static Quantity<TUnit> operator --(Quantity<TUnit> q)
      => q with { RawValue = q.RawValue - 1 };

   /// <summary>
   /// Adds two quantities, selecting the larger unit of measure as the common representation.
   /// </summary>
   /// <param name="x">The left hand operand</param>
   /// <param name="y">The right hand operand</param>
   /// <returns>The sum of the two quantities in the common unit of measure.</returns>
   public static Quantity<TUnit> operator +(Quantity<TUnit> x, Quantity<TUnit> y)
   {
      var targetUnit = ArithmeticUnitSelector!.SelectUnit(x.Unit, y.Unit);

      return x.To(targetUnit)
              .RawValue
           + y.To(targetUnit);
   }

   /// <summary>
   /// Performs subtraction on two quantities, converting to the larger of the two units of measure.
   /// </summary>
   /// <param name="x">The left hand operand</param>
   /// <param name="y">The right hand operand.</param>
   /// <returns>The result of the subtraction.</returns>
   public static Quantity<TUnit> operator -(Quantity<TUnit> x, Quantity<TUnit> y)
   {
      var targetUnit = ArithmeticUnitSelector!.SelectUnit(x.Unit, y.Unit);

      return x.To(targetUnit)
              .RawValue
           - y.To(targetUnit);
   }

   /// <summary>
   /// Performs multiplication on two quantities, converting to the larger of the two units of measure.
   /// </summary>
   /// <param name="x">The left hand operand</param>
   /// <param name="y">The right hand operand.</param>
   /// <returns>The product of the two operands.</returns>
   public static Quantity<TUnit> operator *(Quantity<TUnit> x, Quantity<TUnit> y)
   {
      var targetUnit = ArithmeticUnitSelector!.SelectUnit(x.Unit, y.Unit);

      return x.To(targetUnit)
              .RawValue
           * y.To(targetUnit);
   }

   /// <summary>
   /// Performs division on two quantities, converting to the larger of the two units of measure.
   /// </summary>
   /// <param name="x">The left hand operand</param>
   /// <param name="y">The right hand operand.</param>
   /// <returns>The result of the division.</returns>
   /// <exception cref="DivideByZeroException">When <paramref name="y" /> is zero.</exception>
   public static Quantity<TUnit> operator /(Quantity<TUnit> x, Quantity<TUnit> y)
   {
      var targetUnit = ArithmeticUnitSelector!.SelectUnit(x.Unit, y.Unit);

      return x.To(targetUnit)
              .RawValue
           / y.To(targetUnit);
   }

   #endregion

   #region Quantity to double artithmetic operators.

   /// <summary>
   /// Performs addition on a double and a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="x">The <see cref="Quantity{TUnit}" /> operand.</param>
   /// <param name="y">The double operand.</param>
   /// <returns>a <see cref="Quantity{TUnit}" /> of the results of the operation in the original unit of measure.</returns>
   public static Quantity<TUnit> operator +(Quantity<TUnit> x, double y)
      => x with { RawValue = x.RawValue + y };

   /// <summary>
   /// Performs subtraction on a double and a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="x">The <see cref="Quantity{TUnit}" /> operand.</param>
   /// <param name="y">The double operand.</param>
   /// <returns>a <see cref="Quantity{TUnit}" /> of the results of the operation in the original unit of measure.</returns>
   public static Quantity<TUnit> operator -(Quantity<TUnit> x, double y)
      => x with { RawValue = x.RawValue - y };

   /// <summary>
   /// Performs multiplication on a double and a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="x">The <see cref="Quantity{TUnit}" /> operand.</param>
   /// <param name="y">The double operand.</param>
   /// <returns>a <see cref="Quantity{TUnit}" /> of the results of the operation in the original unit of measure.</returns>
   public static Quantity<TUnit> operator *(Quantity<TUnit> x, double y)
      => x with { RawValue = x.RawValue * y };

   /// <summary>
   /// Performs division on a double and a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="x">The <see cref="Quantity{TUnit}" /> operand.</param>
   /// <param name="y">The double operand.</param>
   /// <returns>a <see cref="Quantity{TUnit}" /> of the results of the operation in the original unit of measure.</returns>
   /// <exception cref="DivideByZeroException">When <paramref name="y" /> is zero.</exception>
   public static Quantity<TUnit> operator /(Quantity<TUnit> x, double y)
      => x with { RawValue = x.RawValue / y };

   #endregion

   #region double to Quantity arithmetic operators.

   /// <summary>
   /// Performs addition on a double and a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="x">The double operand</param>
   /// <param name="y">The <see cref="Quantity{TUnit}" /> operand.</param>
   /// <returns>a <see cref="Quantity{TUnit}" /> of the results of the operation in the original unit of measure.</returns>
   public static Quantity<TUnit> operator +(double x, Quantity<TUnit> y)
      => y with { RawValue = x + y.RawValue };

   /// <summary>
   /// Performs subtraction on a double and a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="x">The double operand</param>
   /// <param name="y">The <see cref="Quantity{TUnit}" /> operand.</param>
   /// <returns>a <see cref="Quantity{TUnit}" /> of the results of the operation in the original unit of measure.</returns>
   public static Quantity<TUnit> operator -(double x, Quantity<TUnit> y)
      => y with { RawValue = x - y.RawValue };

   /// <summary>
   /// Performs multiplication on a double and a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="x">The double operand</param>
   /// <param name="y">The <see cref="Quantity{TUnit}" /> operand.</param>
   /// <returns>a <see cref="Quantity{TUnit}" /> of the results of the operation in the original unit of measure.</returns>
   public static Quantity<TUnit> operator *(double x, Quantity<TUnit> y)
      => y with { RawValue = x * y.RawValue };

   /// <summary>
   /// Performs division on a double and a <see cref="Quantity{TUnit}" />.
   /// </summary>
   /// <param name="x">The double operand</param>
   /// <param name="y">The <see cref="Quantity{TUnit}" /> operand.</param>
   /// <returns>a <see cref="Quantity{TUnit}" /> of the results of the operation in the original unit of measure.</returns>
   /// <exception cref="DivideByZeroException">When <paramref name="y" /> is zero.</exception>
   public static Quantity<TUnit> operator /(double x, Quantity<TUnit> y)
      => y with { RawValue = x / y.RawValue };

   #endregion

   #region Equality members

   /// <summary>
   /// Compares this instance to another <see cref="Quantity{TUnit}" /> instance for equality.
   /// </summary>
   /// <remarks>
   /// The quantity with the smaller unit of measure is converted to the double representation of
   /// the larger unit of measure before comparison.
   /// </remarks>
   /// <param name="other">The other instance to compare against.</param>
   /// <returns>True if equivalent. False otherwise.</returns>
   public bool Equals(Quantity<TUnit> other)
      => CompareTo(other) == 0;

   /// <summary>
   /// Computes a hashcode for the quantity, so that numeric equivalence is maintained
   /// regardless of precise unit of measure is used, the hashcode is calculated on
   /// the fundamental unit representation. TUnit is included in the hashcode to ensure
   /// that differing units do not hash the same.
   /// </summary>
   /// <returns>The calculated hashcode.</returns>
   public override int GetHashCode()
   {
      var dbl = To(Unit.FundamentalUnit)
              .RawValue;

      var hc1 = Comparer!.GetHashCode(dbl);
      var hc2 = HashCode.Combine(typeof(Quantity<TUnit>));

      return hc1 ^ hc2;
   }

   #endregion

   #region Relational members

   /// <summary>
   /// Compares this instance to another <see cref="Quantity{TUnit}" /> instance for relative value.
   /// </summary>
   /// <remarks>
   /// The quantity with the smaller unit of measure is converted to the larger unit of measure
   /// before comparison.
   /// </remarks>
   /// <param name="other">The other instance to compare against.</param>
   /// <returns>-1 if this instance is less than the other; 1 if this instance is greater than the other; 0 if equivalent.</returns>
   public int CompareTo(Quantity<TUnit> other)
   {
      var comparer   = Comparer!;
      var targetUnit = ComparisonUnitSelector!.SelectUnit(Unit, other.Unit);

      return comparer.Compare(
                              To(targetUnit)
                                      .RawValue
                            , other.To(targetUnit)
                                   .RawValue
                             );
   }

   /// <summary>
   /// Compares this instance to another <see cref="Quantity{TUnit}" /> instance for relative value.
   /// </summary>
   /// <param name="obj">The other instance to compare against.</param>
   /// <returns>-1 if this instance is less than the other; 1 if this instance is greater than the other; 0 if equivalent.</returns>
   public int CompareTo(object? obj)
   {
      if (obj is null) return 1;

      return obj is Quantity<TUnit> other
               ? CompareTo(other)
               : throw new ArgumentException($"Object must be of type {nameof(Quantity<TUnit>)}");
   }

   /// <summary>
   /// Performs a less than comparison between two <see cref="Quantity{TUnit}" /> instances.
   /// </summary>
   /// <param name="left">the left hand operand</param>
   /// <param name="right">the right hand operand</param>
   /// <returns>true if <paramref name="left" /> is strictly less than <paramref name="right" />; false otherwise.</returns>
   public static bool operator <(Quantity<TUnit> left, Quantity<TUnit> right)
      => left.CompareTo(right) < 0;

   /// <summary>
   /// Performs a greater than comparison between two <see cref="Quantity{TUnit}" /> instances.
   /// </summary>
   /// <param name="left">the left hand operand</param>
   /// <param name="right">the right hand operand</param>
   /// <returns>true if <paramref name="left" /> is strictly greater than <paramref name="right" />; false otherwise.</returns>
   public static bool operator >(Quantity<TUnit> left, Quantity<TUnit> right)
      => left.CompareTo(right) > 0;

   /// <summary>
   /// Performs a less than or equals comparison between two <see cref="Quantity{TUnit}" /> instances.
   /// </summary>
   /// <param name="left">the left hand operand</param>
   /// <param name="right">the right hand operand</param>
   /// <returns>true if <paramref name="left" /> is less than or equal to <paramref name="right" />; false otherwise.</returns>
   public static bool operator <=(Quantity<TUnit> left, Quantity<TUnit> right)
      => left.CompareTo(right) <= 0;

   /// <summary>
   /// Performs a greater than or equals comparison between two <see cref="Quantity{TUnit}" /> instances.
   /// </summary>
   /// <param name="left">the left hand operand</param>
   /// <param name="right">the right hand operand</param>
   /// <returns>true if <paramref name="left" /> is greater than or equal to <paramref name="right" />; false otherwise.</returns>
   public static bool operator >=(Quantity<TUnit> left, Quantity<TUnit> right)
      => left.CompareTo(right) >= 0;

   #endregion
}
