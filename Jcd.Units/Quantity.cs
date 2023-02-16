using System;

namespace Jcd.Units;

/// <summary>
///     Represents a quantity with an associated unit of measure.
/// </summary>
/// <param name="RawValue">The numeric portion, without associated unit of measure</param>
/// <param name="Units">The unit of measure.</param>
/// <typeparam name="TUnits">The data type of the unit of measure.</typeparam>
public readonly record struct Quantity<TUnits>(double RawValue, TUnits Units) :
    IComparable<Quantity<TUnits>>,
    IComparable where TUnits : IUnitOfMeasure<TUnits>
{
    /// <summary>
    ///     Converts the quantity from its current unit of measure to the target unit of measure.
    /// </summary>
    /// <param name="targetUnit">The target unit of measure</param>
    /// <returns>The new quantity represented as the new unit of measure.</returns>
    public Quantity<TUnits> To(TUnits targetUnit)
    {
        var nv = Units.ToBaseUnitValue(RawValue);
        var dnv = targetUnit.FromBaseUnitValue(nv);
        return new Quantity<TUnits>(dnv, targetUnit);
    }

    #region Overrides of ValueType

    public override string ToString()
    {
        return $"{RawValue:n} {Units.Symbol}";
    }

    #endregion

    #region Quantity to Quantity arithmetic operators.

    /// <summary>
    ///     Performs a standard unary "+" operation.
    /// </summary>
    /// <param name="q">The <c>Quantity</c> to operate on.</param>
    /// <returns>The <c>Quantity</c></returns>
    public static Quantity<TUnits> operator +(Quantity<TUnits> q)
    {
        return q;
    }

    /// <summary>
    ///     Performs standard unary negation on the <c>RawValue</c> component and returns a new <c>Quantity</c>.
    /// </summary>
    /// <param name="q">The quantity to perform the operation on.</param>
    /// <returns>The negated form of the <c>Quantity</c></returns>
    public static Quantity<TUnits> operator -(Quantity<TUnits> q)
    {
        return q with { RawValue = -q.RawValue };
    }

    /// <summary>
    /// Adds two quantities, selecting the larger unit of measure as the common representation.
    /// </summary>
    /// <param name="x">The left hand operand</param>
    /// <param name="y">The right hand operand</param>
    /// <returns>The sum of the two quantities in the common unit of measure.</returns>
    public static Quantity<TUnits> operator +(Quantity<TUnits> x, Quantity<TUnits> y)
    {
        if (x.Units.CompareTo(y.Units) == 0) return x + y.RawValue;
        var targetUnit = x.Units.CompareTo(y.Units) > 0 ? x.Units : y.Units;
        if (x.Units.CompareTo(targetUnit) == 0) return x + y.To(targetUnit).RawValue;
        return x.To(targetUnit).RawValue + y;
    }

    /// <summary>
    /// Performs subtraction on two quantities, converting to the larger of the two units of measure.
    /// </summary>
    /// <param name="x">The left hand operand</param>
    /// <param name="y">The right hand operand.</param>
    /// <returns>The result of the subtraction.</returns>
    public static Quantity<TUnits> operator -(Quantity<TUnits> x, Quantity<TUnits> y)
    {
        if (x.Units.CompareTo(y.Units) == 0) return x - y.RawValue;
        var targetUnit = x.Units.CompareTo(y.Units) > 0 ? x.Units : y.Units;
        if (x.Units.CompareTo(targetUnit) == 0) return x - y.To(targetUnit).RawValue;
        return x.To(targetUnit).RawValue - y;
    }

    /// <summary>
    /// Performs multiplication on two quantities, converting to the larger of the two units of measure.
    /// </summary>
    /// <param name="x">The left hand operand</param>
    /// <param name="y">The right hand operand.</param>
    /// <returns>The product of the two operands.</returns>
    public static Quantity<TUnits> operator *(Quantity<TUnits> x, Quantity<TUnits> y)
    {
        if (x.Units.CompareTo(y.Units) == 0) return x * y.RawValue;
        var targetUnit = x.Units.CompareTo(y.Units) > 0 ? x.Units : y.Units;
        if (x.Units.CompareTo(targetUnit) == 0) return x * y.To(targetUnit).RawValue;
        return x.To(targetUnit).RawValue * y;
    }

    /// <summary>
    /// Performs division on two quantities, converting to the larger of the two units of measure.
    /// </summary>
    /// <param name="x">The left hand operand</param>
    /// <param name="y">The right hand operand.</param>
    /// <returns>The result of the division.</returns>
    /// <exception cref="DivideByZeroException">When <c>y</c> is zero.</exception>
    public static Quantity<TUnits> operator /(Quantity<TUnits> x, Quantity<TUnits> y)
    {
        if (y.RawValue == 0) throw new DivideByZeroException();
        if (x.Units.CompareTo(y.Units) == 0) return x / y.RawValue;
        var targetUnit = x.Units.CompareTo(y.Units) > 0 ? x.Units : y.Units;
        if (x.Units.CompareTo(targetUnit) == 0) return x / y.To(targetUnit).RawValue;
        return x.To(targetUnit).RawValue / y;
    }

    #endregion

    #region Quantity to double artithmetic operators.

    /// <summary>
    /// Performs addition on a <c>Quantity</c> (left-hand operand) and a double.
    /// </summary>
    /// <param name="x">The left hand operand</param>
    /// <param name="y">The right hand, <c>double</c>, operand.</param>
    /// <returns>The result of the addition.</returns>
    public static Quantity<TUnits> operator +(Quantity<TUnits> x, double y)
    {
        return x with { RawValue = x.RawValue + y };
    }

    /// <summary>
    /// Performs subtraction on a <c>Quantity</c> (left-hand operand) and a double.
    /// </summary>
    /// <param name="x">The left hand operand</param>
    /// <param name="y">The right hand, <c>double</c>, operand.</param>
    /// <returns>The result of the subtraction.</returns>
    public static Quantity<TUnits> operator -(Quantity<TUnits> x, double y)
    {
        return x with { RawValue = x.RawValue - y };
    }

    public static Quantity<TUnits> operator *(Quantity<TUnits> x, double y)
    {
        return x with { RawValue = x.RawValue * y };
    }

    public static Quantity<TUnits> operator /(Quantity<TUnits> x, double y)
    {
        if (y == 0) throw new DivideByZeroException();
        return x with { RawValue = x.RawValue / y };
    }

    #endregion

    #region double to Quantity arithmetic operators.

    public static Quantity<TUnits> operator +(double x, Quantity<TUnits> y)
    {
        return y with { RawValue = x + y.RawValue };
    }

    public static Quantity<TUnits> operator -(double x, Quantity<TUnits> y)
    {
        return y with { RawValue = x - y.RawValue };
    }

    public static Quantity<TUnits> operator *(double x, Quantity<TUnits> y)
    {
        return y with { RawValue = x * y.RawValue };
    }

    public static Quantity<TUnits> operator /(double x, Quantity<TUnits> y)
    {
        if (y.RawValue == 0) throw new DivideByZeroException();
        return y with { RawValue = x / y.RawValue };
    }

    #endregion

    #region Equality members

    public bool Equals(Quantity<TUnits> other)
    {
        return Units.ToBaseUnitValue(RawValue) == other.Units.ToBaseUnitValue(other.RawValue);
    }

    public override int GetHashCode()
    {
        return Units.ToBaseUnitValue(RawValue).GetHashCode();
    }

    #endregion

    #region Relational members

    public int CompareTo(Quantity<TUnits> other)
    {
        return Units.ToBaseUnitValue(RawValue).CompareTo(other.Units.ToBaseUnitValue(other.RawValue));
    }

    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is Quantity<TUnits> other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Quantity<TUnits>)}");
    }

    public static bool operator <(Quantity<TUnits> left, Quantity<TUnits> right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator >(Quantity<TUnits> left, Quantity<TUnits> right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator <=(Quantity<TUnits> left, Quantity<TUnits> right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >=(Quantity<TUnits> left, Quantity<TUnits> right)
    {
        return left.CompareTo(right) >= 0;
    }

    #endregion
}