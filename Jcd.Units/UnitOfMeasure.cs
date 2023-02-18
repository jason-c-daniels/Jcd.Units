using System;

namespace Jcd.Units;

/// <summary>
/// Base type to simplify creating a unit of measure. This type provides relational and equivalence operations.
/// </summary>
/// <param name="Name">The name of this unit</param>
/// <param name="Symbol">The symbol or abbreviation to represent the <see cref="UnitOfMeasure{TUnits}"/></param>
/// <param name="Coefficient">The unit's coefficient relative to the ultimate base unit's representation.</param>
/// <param name="Offset">The offset used when computing values going to and from the base unit's representation.</param>
public abstract record UnitOfMeasure<TUnits>(string Name, string Symbol, double Coefficient=1, double Offset=0) 
    : IUnitOfMeasure<UnitOfMeasure<TUnits>>
{
    #region Equality members

    /// <summary>
    /// Compares this <see cref="UnitOfMeasure{TUnits}"/> to another one for equality.
    /// </summary>
    /// <param name="other">The other <see cref="UnitOfMeasure{TUnits}"/> to compare against.</param>
    /// <returns>true if equivalent, false otherwise.</returns>
    public virtual bool Equals(UnitOfMeasure<TUnits>? other)
    {
        if (other is null) return false;
        return Coefficient.Equals(other.Coefficient) && Offset.Equals(other.Offset);
    }

    /// <summary>
    /// Computes the hash code for this <see cref="UnitOfMeasure{TUnits}"/>
    /// </summary>
    /// <returns>The computed hashcode.</returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(Coefficient, Offset, typeof(UnitOfMeasure<TUnits>));
    }
    
    #endregion

    #region Relational members

    /// <summary>
    /// Performs a relative comparison between this <see cref="UnitOfMeasure{TUnits}"/> and another one.
    /// </summary>
    /// <param name="other">The <see cref="UnitOfMeasure{TUnits}"/> to compare against.</param>
    /// <returns>-1 if less than; 1 if greater than; 0 if equals.</returns>
    public int CompareTo(UnitOfMeasure<TUnits>? other)
    {
        if (other is null) return 1; // sort nulls first.
        var factorComparison = Coefficient.CompareTo(other.Coefficient);
        return factorComparison != 0 ? factorComparison : Offset.CompareTo(other.Offset);
    }

    /// <summary>
    /// Performs a relative comparison between this <see cref="UnitOfMeasure{TUnits}"/> and another one.
    /// </summary>
    /// <param name="obj">The <see cref="UnitOfMeasure{TUnits}"/> to compare against.</param>
    /// <returns>-1 if less than; 1 if greater than; 0 if equals.</returns>
    /// <exception cref="ArgumentException">When the passed in object is not a <see cref="UnitOfMeasure{TUnits}"/></exception>
    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1; // sort nulls first.
        return obj is UnitOfMeasure<TUnits> other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(UnitOfMeasure<TUnits>)}");
    }

    /// <summary>
    /// Compares two <see cref="UnitOfMeasure{TUnits}"/> instances to determine if the left one is less than the right one. 
    /// </summary>
    /// <param name="left">The left <see cref="UnitOfMeasure{TUnits}"/></param>
    /// <param name="right">The right <see cref="UnitOfMeasure{TUnits}"/></param>
    /// <returns>true if left is &lt; right; false otherwise.</returns>
    public static bool operator <(UnitOfMeasure<TUnits>? left, UnitOfMeasure<TUnits>? right)
    {
        if (ReferenceEquals(left, right)) return false; // if they're the same instance or both are null.
        if (ReferenceEquals(null, right)) return false; // relationally, nulls do not compare, return false.
        if (ReferenceEquals(null, left)) return false; // relationally, nulls do not compare, return false.
        return left.CompareTo(right) < 0;
    }

    /// <summary>
    /// Compares two <see cref="UnitOfMeasure{TUnits}"/> instances to determine if the left one is greater than the right one. 
    /// </summary>
    /// <param name="left">The left <see cref="UnitOfMeasure{TUnits}"/></param>
    /// <param name="right">The right <see cref="UnitOfMeasure{TUnits}"/></param>
    /// <returns>true if left is &gt; right; false otherwise.</returns>
    public static bool operator >(UnitOfMeasure<TUnits>? left, UnitOfMeasure<TUnits>? right)
    {
        if (ReferenceEquals(left, right)) return false; // if they're the same instance or both are null.
        if (ReferenceEquals(null, right)) return false; // relationally, nulls do not compare, return false.
        if (ReferenceEquals(null, left)) return false; // relationally, nulls do not compare, return false.
        return left.CompareTo(right) > 0;
    }

    /// <summary>
    /// Compares two <see cref="UnitOfMeasure{TUnits}"/> instances to determine if the left one is less than or equal to the right one. 
    /// </summary>
    /// <param name="left">The left <see cref="UnitOfMeasure{TUnits}"/></param>
    /// <param name="right">The right <see cref="UnitOfMeasure{TUnits}"/></param>
    /// <returns>true if left is &lt;= right; false otherwise.</returns>
    public static bool operator <=(UnitOfMeasure<TUnits>? left, UnitOfMeasure<TUnits>? right)
    {
        if (left is null && right is null) return false; // relationally, nulls do not compare, return false. 
        if (ReferenceEquals(left, right)) return true; // if they're the same instance.
        if (ReferenceEquals(null, right)) return false; // relationally, nulls do not compare, return false.
        if (ReferenceEquals(null, left)) return false; // relationally, nulls do not compare, return false.
        return left.CompareTo(right) <= 0;
    }

    /// <summary>
    /// Compares two <see cref="UnitOfMeasure{TUnits}"/> instances to determine if the left one is greater than or equal to the right one. 
    /// </summary>
    /// <param name="left">The left <see cref="UnitOfMeasure{TUnits}"/></param>
    /// <param name="right">The right <see cref="UnitOfMeasure{TUnits}"/></param>
    /// <returns>true if left is &gt;= right; false otherwise.</returns>
    public static bool operator >=(UnitOfMeasure<TUnits>? left, UnitOfMeasure<TUnits>? right)
    {
        if (left is null && right is null) return false; // relationally, nulls do not compare, return false. 
        if (ReferenceEquals(left, right)) return false; // if they're the same instance.
        if (ReferenceEquals(null, right)) return false; // relationally, nulls do not compare, return false.
        if (ReferenceEquals(null, left)) return false; // relationally, nulls do not compare, return false.
        return left.CompareTo(right) >= 0;
    }

    #endregion
}