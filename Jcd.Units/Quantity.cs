using System;

namespace Jcd.Units;

/// <summary>
/// Represents a quantity with an associated unit of measure.
/// </summary>
/// <param name="RawValue">The numeric portion, without associated unit of measure</param>
/// <param name="Units">The unit of measure.</param>
/// <typeparam name="TUnits">The data type of the unit of measure.</typeparam>
public readonly record struct Quantity<TUnits>(double RawValue, TUnits Units) :
    IComparable<Quantity<TUnits>>,
    IComparable where TUnits : IUnitOfMeasure<TUnits>
{

    /// <summary>
    /// Converts the quantity from its current unit of measure to the target unit of measure.
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

    /// <summary>
    /// Formats a string with the quantity value followed by the symbol.
    /// </summary>
    /// <returns>The formatted string.</returns>
    public override string ToString()
    {
        return $"{RawValue:n} {Units.Symbol}";
    }

    #endregion

    #region Quantity to Quantity and unary Quantity arithmetic operators.

    /// <summary>
    /// Performs a standard unary "+" operation.
    /// </summary>
    /// <param name="q">The <see cref="Quantity{TUnits}"/> to operate on.</param>
    /// <returns>The <see cref="Quantity{TUnits}"/></returns>
    public static Quantity<TUnits> operator +(Quantity<TUnits> q)
    {
        return q;
    }
    
    /// <summary>
    /// Performs unary negation on the <see cref="RawValue"/> component and
    /// returns a new <see cref="Quantity{TUnits}"/>.
    /// </summary>
    /// <param name="q">The quantity to perform the negation on.</param>
    /// <returns>The negated form of the <see cref="Quantity{TUnits}"/></returns>
    public static Quantity<TUnits> operator -(Quantity<TUnits> q)
    {
        return q with { RawValue = -q.RawValue };
    }
    
    /// <summary>
    /// Performs a unary increment operation.
    /// </summary>
    /// <param name="q">The <see cref="Quantity{TUnits}"/> to operate on.</param>
    /// <returns>The <see cref="Quantity{TUnits}"/></returns>
    public static Quantity<TUnits> operator ++(Quantity<TUnits> q)
    {
        return q with { RawValue = q.RawValue + 1 };
    }

    /// <summary>
    /// Performs a unary decrement operation.
    /// </summary>
    /// <param name="q">The <see cref="Quantity{TUnits}"/> to operate on.</param>
    /// <returns>The <see cref="Quantity{TUnits}"/></returns>
    public static Quantity<TUnits> operator --(Quantity<TUnits> q)
    {
        return q with { RawValue = q.RawValue - 1 };
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
    /// <exception cref="DivideByZeroException">When <paramref name="y"/> is zero.</exception>
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
    /// Performs addition on a double and a <see cref="Quantity{TUnits}"/>.
    /// </summary>
    /// <param name="x">The <see cref="Quantity{TUnits}"/> operand.</param>
    /// <param name="y">The double operand.</param>
    /// <returns>a <see cref="Quantity{TUnits}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnits> operator +(Quantity<TUnits> x, double y)
    {
        return x with { RawValue = x.RawValue + y };
    }

    /// <summary>
    /// Performs subtraction on a double and a <see cref="Quantity{TUnits}"/>.
    /// </summary>
    /// <param name="x">The <see cref="Quantity{TUnits}"/> operand.</param>
    /// <param name="y">The double operand.</param>
    /// <returns>a <see cref="Quantity{TUnits}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnits> operator -(Quantity<TUnits> x, double y)
    {
        return x with { RawValue = x.RawValue - y };
    }

    /// <summary>
    /// Performs multiplication on a double and a <see cref="Quantity{TUnits}"/>.
    /// </summary>
    /// <param name="x">The <see cref="Quantity{TUnits}"/> operand.</param>
    /// <param name="y">The double operand.</param>
    /// <returns>a <see cref="Quantity{TUnits}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnits> operator *(Quantity<TUnits> x, double y)
    {
        return x with { RawValue = x.RawValue * y };
    }

    /// <summary>
    /// Performs division on a double and a <see cref="Quantity{TUnits}"/>.
    /// </summary>
    /// <param name="x">The <see cref="Quantity{TUnits}"/> operand.</param>
    /// <param name="y">The double operand.</param>
    /// <returns>a <see cref="Quantity{TUnits}"/> of the results of the operation in the original unit of measure.</returns>
    /// <exception cref="DivideByZeroException">When <paramref name="y"/> is zero.</exception>
    public static Quantity<TUnits> operator /(Quantity<TUnits> x, double y)
    {
        if (y == 0) throw new DivideByZeroException();
        return x with { RawValue = x.RawValue / y };
    }

    #endregion

    #region double to Quantity arithmetic operators.

    /// <summary>
    /// Performs addition on a double and a <see cref="Quantity{TUnits}"/>.
    /// </summary>
    /// <param name="x">The double operand</param>
    /// <param name="y">The <see cref="Quantity{TUnits}"/> operand.</param>
    /// <returns>a <see cref="Quantity{TUnits}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnits> operator +(double x, Quantity<TUnits> y)
    {
        return y with { RawValue = x + y.RawValue };
    }

    /// <summary>
    /// Performs subtraction on a double and a <see cref="Quantity{TUnits}"/>.
    /// </summary>
    /// <param name="x">The double operand</param>
    /// <param name="y">The <see cref="Quantity{TUnits}"/> operand.</param>
    /// <returns>a <see cref="Quantity{TUnits}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnits> operator -(double x, Quantity<TUnits> y)
    {
        return y with { RawValue = x - y.RawValue };
    }

    /// <summary>
    /// Performs multiplication on a double and a <see cref="Quantity{TUnits}"/>.
    /// </summary>
    /// <param name="x">The double operand</param>
    /// <param name="y">The <see cref="Quantity{TUnits}"/> operand.</param>
    /// <returns>a <see cref="Quantity{TUnits}"/> of the results of the operation in the original unit of measure.</returns>
    public static Quantity<TUnits> operator *(double x, Quantity<TUnits> y)
    {
        return y with { RawValue = x * y.RawValue };
    }

    /// <summary>
    /// Performs division on a double and a <see cref="Quantity{TUnits}"/>.
    /// </summary>
    /// <param name="x">The double operand</param>
    /// <param name="y">The <see cref="Quantity{TUnits}"/> operand.</param>
    /// <returns>a <see cref="Quantity{TUnits}"/> of the results of the operation in the original unit of measure.</returns>
    /// <exception cref="DivideByZeroException">When <paramref name="y"/> is zero.</exception>
    public static Quantity<TUnits> operator /(double x, Quantity<TUnits> y)
    {
        if (y.RawValue == 0) throw new DivideByZeroException();
        return y with { RawValue = x / y.RawValue };
    }

    #endregion

    #region Equality members

    /// <summary>
    /// Compares this instance to another <see cref="Quantity{TUnits}"/> instance for equality.
    /// </summary>
    /// <param name="other">The other instance to compare against.</param>
    /// <returns>True if equivalent. False otherwise.</returns>
    public bool Equals(Quantity<TUnits> other)
    {
        return Units.ToBaseUnitValue(RawValue) == other.Units.ToBaseUnitValue(other.RawValue);
    }

    /// <summary>
    /// Computes a hashcode for the quantity. So that numeric equivalence is maintained
    /// regardless of precise unit of measure is used, the hashcode is calculated on
    /// the base unit representation. TUnits is included in the hashcode to ensure
    /// that differing units do not compare the same.
    /// </summary>
    /// <returns>The calculated hashcode.</returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(Units.ToBaseUnitValue(RawValue), typeof(Quantity<TUnits>));
    }

    #endregion

    #region Relational members
    
    /// <summary>
    /// Compares this instance to another <see cref="Quantity{TUnits}"/> instance for relative value.
    /// </summary>
    /// <param name="other">The other instance to compare against.</param>
    /// <returns>-1 if this instance is less than the other; 1 if this instance is greater than the other; 0 if equivalent.</returns>

    public int CompareTo(Quantity<TUnits> other)
    {
        return Units.ToBaseUnitValue(RawValue).CompareTo(other.Units.ToBaseUnitValue(other.RawValue));
    }
    /// <summary>
    /// Compares this instance to another <see cref="Quantity{TUnits}"/> instance for relative value.
    /// </summary>
    /// <param name="obj">The other instance to compare against.</param>
    /// <returns>-1 if this instance is less than the other; 1 if this instance is greater than the other; 0 if equivalent.</returns>

    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is Quantity<TUnits> other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Quantity<TUnits>)}");
    }

    /// <summary>
    /// Performs a less than comparison between two <see cref="Quantity{TUnits}"/> instances.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if <paramref name="left"/> is strictly less than <paramref name="right"/>; false otherwise.</returns>
    public static bool operator <(Quantity<TUnits> left, Quantity<TUnits> right)
    {
        return left.CompareTo(right) < 0;
    }

    /// <summary>
    /// Performs a greater than comparison between two <see cref="Quantity{TUnits}"/> instances.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if <paramref name="left"/> is strictly greater than <paramref name="right"/>; false otherwise.</returns>
    public static bool operator >(Quantity<TUnits> left, Quantity<TUnits> right)
    {
        return left.CompareTo(right) > 0;
    }

    /// <summary>
    /// Performs a less than or equals comparison between two <see cref="Quantity{TUnits}"/> instances.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if <paramref name="left"/> is less than or equal to <paramref name="right"/>; false otherwise.</returns>
    public static bool operator <=(Quantity<TUnits> left, Quantity<TUnits> right)
    {
        return left.CompareTo(right) <= 0;
    }

    /// <summary>
    /// Performs a greater than or equals comparison between two <see cref="Quantity{TUnits}"/> instances.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; false otherwise.</returns>
    public static bool operator >=(Quantity<TUnits> left, Quantity<TUnits> right)
    {
        return left.CompareTo(right) >= 0;
    }

    #endregion
}