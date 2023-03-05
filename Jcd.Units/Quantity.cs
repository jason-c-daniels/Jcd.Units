using System;

namespace Jcd.Units;

/// <summary>
/// Represents a quantity with an associated unit of measure.
/// </summary>
/// <param name="RawValue">The numeric portion, without associated unit of measure</param>
/// <param name="Unit">The unit of measure.</param>
/// <typeparam name="TUnit">The data type of the unit of measure. It must derive from <see cref="UnitOfMeasure{TUnit}"/></typeparam>
public readonly record struct Quantity<TUnit>(double RawValue, TUnit Unit) :
    IComparable<Quantity<TUnit>>,
    IComparable where TUnit : UnitOfMeasure<TUnit>
{
    /// <summary>
    /// Sets the <see cref="IValueComparer{Double}"/> used by quantities for the particular unit of
    /// measure type. (e.g. lengths.) 
    /// </summary>
    // ReSharper disable once StaticMemberInGenericType
    public static IValueComparer<double>? DefaultDoubleComparer { get; set; }

    private readonly IValueComparer<double>? _comparer=null;
    
    /// <summary>
    /// Represents a quantity with an associated unit of measure.
    /// </summary>
    /// <param name="rawValue">The numeric portion, without associated unit of measure</param>
    /// <param name="unit">The unit of measure.</param>
    /// <param name="baseUnitComparer">Compares two doubles represented as doubles in the base unit of measure.</param>
    public Quantity(double rawValue, TUnit unit, IValueComparer<double>? baseUnitComparer = null) :
        this(rawValue,unit)
    {
        _comparer = baseUnitComparer;
    }

    /// <summary>
    /// Converts the quantity from its current unit of measure to the target unit of measure.
    /// </summary>
    /// <param name="targetUnit">The target unit of measure</param>
    /// <returns>The new quantity represented as the new unit of measure.</returns>
    public Quantity<TUnit> To(TUnit targetUnit)
    {
        var nv = Unit.ToBaseUnitValue(RawValue);
        var dnv = targetUnit.FromBaseUnitValue(nv);
        return new Quantity<TUnit>(dnv, targetUnit);
    }

    #region Overrides of ValueType

    /// <summary>
    /// Formats a string with the quantity value followed by the symbol.
    /// </summary>
    /// <returns>The formatted string.</returns>
    public override string ToString() => $"{RawValue:n} {Unit.Symbol}";

    #endregion

    #region Quantity to Quantity and unary Quantity arithmetic operators.

    /// <summary>
    /// Performs a standard unary "+" operation.
    /// </summary>
    /// <param name="q">The <see cref="Quantity{TUnit}"/> to operate on.</param>
    /// <returns>The <see cref="Quantity{TUnit}"/></returns>
    public static Quantity<TUnit> operator +(Quantity<TUnit> q) 
        => q;

    /// <summary>
    /// Performs unary negation on the <see cref="RawValue"/> component and
    /// returns a new <see cref="Quantity{TUnit}"/>.
    /// </summary>
    /// <param name="q">The quantity to perform the negation on.</param>
    /// <returns>The negated form of the <see cref="Quantity{TUnit}"/></returns>
    public static Quantity<TUnit> operator -(Quantity<TUnit> q) 
        => q with { RawValue = -q.RawValue };

    /// <summary>
    /// Performs a unary increment operation.
    /// </summary>
    /// <param name="q">The <see cref="Quantity{TUnit}"/> to operate on.</param>
    /// <returns>The <see cref="Quantity{TUnit}"/></returns>
    public static Quantity<TUnit> operator ++(Quantity<TUnit> q) 
        => q with { RawValue = q.RawValue + 1 };

    /// <summary>
    /// Performs a unary decrement operation.
    /// </summary>
    /// <param name="q">The <see cref="Quantity{TUnit}"/> to operate on.</param>
    /// <returns>The <see cref="Quantity{TUnit}"/></returns>
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
        if (x.Unit.CompareTo(y.Unit) == 0) return x + y.RawValue;
        var targetUnit = x.Unit.CompareTo(y.Unit) > 0 ? x.Unit : y.Unit;
        if (x.Unit.CompareTo(targetUnit) == 0) return x + y.To(targetUnit).RawValue;
        return x.To(targetUnit).RawValue + y;
    }

    /// <summary>
    /// Performs subtraction on two quantities, converting to the larger of the two units of measure.
    /// </summary>
    /// <param name="x">The left hand operand</param>
    /// <param name="y">The right hand operand.</param>
    /// <returns>The result of the subtraction.</returns>
    public static Quantity<TUnit> operator -(Quantity<TUnit> x, Quantity<TUnit> y)
    {
        if (x.Unit.CompareTo(y.Unit) == 0) return x - y.RawValue;
        var targetUnit = x.Unit.CompareTo(y.Unit) > 0 ? x.Unit : y.Unit;
        if (x.Unit.CompareTo(targetUnit) == 0) return x - y.To(targetUnit).RawValue;
        return x.To(targetUnit).RawValue - y;
    }

    /// <summary>
    /// Performs multiplication on two quantities, converting to the larger of the two units of measure.
    /// </summary>
    /// <param name="x">The left hand operand</param>
    /// <param name="y">The right hand operand.</param>
    /// <returns>The product of the two operands.</returns>
    public static Quantity<TUnit> operator *(Quantity<TUnit> x, Quantity<TUnit> y)
    {
        if (x.Unit.CompareTo(y.Unit) == 0) return x * y.RawValue;
        var targetUnit = x.Unit.CompareTo(y.Unit) > 0 ? x.Unit : y.Unit;
        if (x.Unit.CompareTo(targetUnit) == 0) return x * y.To(targetUnit).RawValue;
        return x.To(targetUnit).RawValue * y;
    }

    /// <summary>
    /// Performs division on two quantities, converting to the larger of the two units of measure.
    /// </summary>
    /// <param name="x">The left hand operand</param>
    /// <param name="y">The right hand operand.</param>
    /// <returns>The result of the division.</returns>
    /// <exception cref="DivideByZeroException">When <paramref name="y"/> is zero.</exception>
    public static Quantity<TUnit> operator /(Quantity<TUnit> x, Quantity<TUnit> y)
    {
        if (x.Unit.CompareTo(y.Unit) == 0) return x / y.RawValue;
        var targetUnit = x.Unit.CompareTo(y.Unit) > 0 ? x.Unit : y.Unit;
        if (x.Unit.CompareTo(targetUnit) == 0) return x / y.To(targetUnit).RawValue;
        return x.To(targetUnit).RawValue / y;
    }

    #endregion

    #region Quantity to double artithmetic operators.

    /// <summary>
    /// Performs addition on a double and a <see cref="Quantity{TUnit}"/>.
    /// </summary>
    /// <param name="x">The <see cref="Quantity{TUnit}"/> operand.</param>
    /// <param name="y">The double operand.</param>
    /// <returns>a <see cref="Quantity{TUnit}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnit> operator +(Quantity<TUnit> x, double y) 
        => x with { RawValue = x.RawValue + y };

    /// <summary>
    /// Performs subtraction on a double and a <see cref="Quantity{TUnit}"/>.
    /// </summary>
    /// <param name="x">The <see cref="Quantity{TUnit}"/> operand.</param>
    /// <param name="y">The double operand.</param>
    /// <returns>a <see cref="Quantity{TUnit}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnit> operator -(Quantity<TUnit> x, double y) 
        => x with { RawValue = x.RawValue - y };

    /// <summary>
    /// Performs multiplication on a double and a <see cref="Quantity{TUnit}"/>.
    /// </summary>
    /// <param name="x">The <see cref="Quantity{TUnit}"/> operand.</param>
    /// <param name="y">The double operand.</param>
    /// <returns>a <see cref="Quantity{TUnit}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnit> operator *(Quantity<TUnit> x, double y) 
        => x with { RawValue = x.RawValue * y };

    /// <summary>
    /// Performs division on a double and a <see cref="Quantity{TUnit}"/>.
    /// </summary>
    /// <param name="x">The <see cref="Quantity{TUnit}"/> operand.</param>
    /// <param name="y">The double operand.</param>
    /// <returns>a <see cref="Quantity{TUnit}"/> of the results of the operation in the original unit of measure.</returns>
    /// <exception cref="DivideByZeroException">When <paramref name="y"/> is zero.</exception>
    public static Quantity<TUnit> operator /(Quantity<TUnit> x, double y) 
        => x with { RawValue = x.RawValue / y };

    #endregion

    #region double to Quantity arithmetic operators.

    /// <summary>
    /// Performs addition on a double and a <see cref="Quantity{TUnit}"/>.
    /// </summary>
    /// <param name="x">The double operand</param>
    /// <param name="y">The <see cref="Quantity{TUnit}"/> operand.</param>
    /// <returns>a <see cref="Quantity{TUnit}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnit> operator +(double x, Quantity<TUnit> y) 
        => y with { RawValue = x + y.RawValue };

    /// <summary>
    /// Performs subtraction on a double and a <see cref="Quantity{TUnit}"/>.
    /// </summary>
    /// <param name="x">The double operand</param>
    /// <param name="y">The <see cref="Quantity{TUnit}"/> operand.</param>
    /// <returns>a <see cref="Quantity{TUnit}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnit> operator -(double x, Quantity<TUnit> y) 
        => y with { RawValue = x - y.RawValue };

    /// <summary>
    /// Performs multiplication on a double and a <see cref="Quantity{TUnit}"/>.
    /// </summary>
    /// <param name="x">The double operand</param>
    /// <param name="y">The <see cref="Quantity{TUnit}"/> operand.</param>
    /// <returns>a <see cref="Quantity{TUnit}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnit> operator *(double x, Quantity<TUnit> y) 
        => y with { RawValue = x * y.RawValue };

    /// <summary>
    /// Performs division on a double and a <see cref="Quantity{TUnit}"/>.
    /// </summary>
    /// <param name="x">The double operand</param>
    /// <param name="y">The <see cref="Quantity{TUnit}"/> operand.</param>
    /// <returns>a <see cref="Quantity{TUnit}"/> of the results of the operation in the original unit of measure.</returns>
    /// <exception cref="DivideByZeroException">When <paramref name="y"/> is zero.</exception>
    public static Quantity<TUnit> operator /(double x, Quantity<TUnit> y) 
        => y with { RawValue = x / y.RawValue };

    #endregion

    #region Equality members

    /// <summary>
    /// Compares this instance to another <see cref="Quantity{TUnit}"/> instance for equality.
    /// </summary>
    /// <remarks>
    /// The quantity with the smaller unit of measure is converted to the double representation of
    /// the larger unit of measure before comparison.
    /// </remarks>
    /// <param name="other">The other instance to compare against.</param>
    /// <returns>True if equivalent. False otherwise.</returns>
    public bool Equals(Quantity<TUnit> other)
    {
        var comparer = GetComparer();
        var targetUnit = Unit >= other.Unit ? Unit : other.Unit;
        var ownValue = Unit == targetUnit ? RawValue : To(targetUnit).RawValue;
        var otherValue = other.Unit == targetUnit ? other.RawValue : other.To(targetUnit).RawValue;
        return comparer.Equals(ownValue,otherValue);
    }

    /// <summary>
    /// Computes a hashcode for the quantity. So that numeric equivalence is maintained
    /// regardless of precise unit of measure is used, the hashcode is calculated on
    /// the base unit representation. TUnit is included in the hashcode to ensure
    /// that differing units do not compare the same.
    /// </summary>
    /// <returns>The calculated hashcode.</returns>
    public override int GetHashCode()
    {
        var comparer = GetComparer();
        return HashCode.Combine(comparer.GetHashCode(Unit.ToBaseUnitValue(RawValue)), typeof(Quantity<TUnit>));
    }

    #endregion

    #region Relational members
    
    /// <summary>
    /// Compares this instance to another <see cref="Quantity{TUnit}"/> instance for relative value.
    /// </summary>
    /// <remarks>
    /// The quantity with the smaller unit of measure is converted to the double representation of
    /// the larger unit of measure before comparison.
    /// </remarks>
    /// <param name="other">The other instance to compare against.</param>
    /// <returns>-1 if this instance is less than the other; 1 if this instance is greater than the other; 0 if equivalent.</returns>
    public int CompareTo(Quantity<TUnit> other)
    {
        var comparer = GetComparer();
        var targetUnit = Unit >= other.Unit ? Unit : other.Unit;
        var ownValue = Unit == targetUnit ? RawValue : To(targetUnit).RawValue;
        var otherValue = other.Unit == targetUnit ? other.RawValue : other.To(targetUnit).RawValue;
        return comparer.Compare(ownValue,otherValue);
    }
    
    /// <summary>
    /// Compares this instance to another <see cref="Quantity{TUnit}"/> instance for relative value.
    /// </summary>
    /// <param name="obj">The other instance to compare against.</param>
    /// <returns>-1 if this instance is less than the other; 1 if this instance is greater than the other; 0 if equivalent.</returns>
    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is Quantity<TUnit> other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Quantity<TUnit>)}");
    }

    /// <summary>
    /// Performs a less than comparison between two <see cref="Quantity{TUnit}"/> instances.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if <paramref name="left"/> is strictly less than <paramref name="right"/>; false otherwise.</returns>
    public static bool operator <(Quantity<TUnit> left, Quantity<TUnit> right)
    {
        return left.CompareTo(right) < 0;
    }

    /// <summary>
    /// Performs a greater than comparison between two <see cref="Quantity{TUnit}"/> instances.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if <paramref name="left"/> is strictly greater than <paramref name="right"/>; false otherwise.</returns>
    public static bool operator >(Quantity<TUnit> left, Quantity<TUnit> right)
    {
        return left.CompareTo(right) > 0;
    }

    /// <summary>
    /// Performs a less than or equals comparison between two <see cref="Quantity{TUnit}"/> instances.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if <paramref name="left"/> is less than or equal to <paramref name="right"/>; false otherwise.</returns>
    public static bool operator <=(Quantity<TUnit> left, Quantity<TUnit> right)
    {
        return left.CompareTo(right) <= 0;
    }

    /// <summary>
    /// Performs a greater than or equals comparison between two <see cref="Quantity{TUnit}"/> instances.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; false otherwise.</returns>
    public static bool operator >=(Quantity<TUnit> left, Quantity<TUnit> right)
    {
        return left.CompareTo(right) >= 0;
    }

    #endregion
    
    private IValueComparer<double> GetComparer() 
        => _comparer ?? DefaultDoubleComparer ?? DoubleComparer.Quantity;

}