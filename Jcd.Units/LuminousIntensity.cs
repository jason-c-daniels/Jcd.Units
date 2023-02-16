using System;

namespace Jcd.Units;

/// <summary>
/// Constructs a unit measuring a specified <c>LuminousIntensity</c>
/// </summary>
/// <param name="Name">The name of this unit</param>
/// <param name="Symbol">The symbol or abbreviation to represent the <c>LuminousIntensity</c></param>
/// <param name="Coefficient">The unit's coefficient relative to the ultimate base unit's representation.</param>
/// <param name="Offset">The offset used when computing values going to and from the base unit's representation.</param>
public record struct LuminousIntensity(string Name, string Symbol, double Coefficient=1, double Offset=0)
    : IUnitOfMeasure<LuminousIntensity>
{
    /// <summary>
    /// Constructs a unit measuring a specified <c>LuminousIntensity</c> using another LuminousIntensity as a reference.
    /// </summary>
    /// <param name="name">The name of this unit</param>
    /// <param name="symbol">The symbol or abbreviation to represent the <c>LuminousIntensity</c></param>
    /// <param name="baseUnit">The unit to use as a base</param>
    /// <param name="coefficient">The coefficient relative to the <c>baseUnit</c></param>
    /// <param name="offset">The offset from the <c>baseUnit</c>.</param>
    public LuminousIntensity(string name, string symbol, LuminousIntensity baseUnit, double coefficient, double offset = 0)
        : this(name,symbol,baseUnit.Coefficient*coefficient,baseUnit.Coefficient*baseUnit.Offset+offset)
    {

    }

    #region Equality members

    /// <summary>
    /// Compares this <c>LuminousIntensity</c> to another one for equality.
    /// </summary>
    /// <param name="other">The other <c>LuminousIntensity</c> to compare against.</param>
    /// <returns>true if equivalent, false otherwise.</returns>
    public bool Equals(LuminousIntensity other)
    {
        return Coefficient.Equals(other.Coefficient) && Offset.Equals(other.Offset);
    }

    /// <summary>
    /// Computes the hash code for this <c>LuminousIntensity</c>
    /// </summary>
    /// <returns>The computed hashcode.</returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(Coefficient, Offset, typeof(LuminousIntensity));
    }

    #endregion

    #region Relational members

    /// <summary>
    /// Performs a relative comparison between this <c>LuminousIntensity</c> and another one.
    /// </summary>
    /// <param name="other">The <c>LuminousIntensity</c> to compare against.</param>
    /// <returns>-1 if less than; 1 if greater than; 0 if equals.</returns>
    public int CompareTo(LuminousIntensity other)
    {
        var factorComparison = Coefficient.CompareTo(other.Coefficient);
        return factorComparison != 0 ? factorComparison : Offset.CompareTo(other.Offset);
    }

    /// <summary>
    /// Performs a relative comparison between this <c>LuminousIntensity</c> and another one.
    /// </summary>
    /// <param name="obj">The <c>LuminousIntensity</c> to compare against.</param>
    /// <returns>-1 if less than; 1 if greater than; 0 if equals.</returns>
    /// <exception cref="ArgumentException">When the passed in object is not a <c>LuminousIntensity</c></exception>
    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is LuminousIntensity other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(LuminousIntensity)}");
    }

    /// <summary>
    /// Compares two <c>LuminousIntensity</c> instances to determine if the left one is less than the right one.
    /// </summary>
    /// <param name="left">The left <c>LuminousIntensity</c></param>
    /// <param name="right">The right <c>LuminousIntensity</c></param>
    /// <returns>true if left is &lt; right; false otherwise.</returns>
    public static bool operator <(LuminousIntensity left, LuminousIntensity right)
    {
        return left.CompareTo(right) < 0;
    }

    /// <summary>
    /// Compares two <c>LuminousIntensity</c> instances to determine if the left one is greater than the right one.
    /// </summary>
    /// <param name="left">The left <c>LuminousIntensity</c></param>
    /// <param name="right">The right <c>LuminousIntensity</c></param>
    /// <returns>true if left is &gt; right; false otherwise.</returns>
    public static bool operator >(LuminousIntensity left, LuminousIntensity right)
    {
        return left.CompareTo(right) > 0;
    }

    /// <summary>
    /// Compares two <c>LuminousIntensity</c> instances to determine if the left one is less than or equal to the right one.
    /// </summary>
    /// <param name="left">The left <c>LuminousIntensity</c></param>
    /// <param name="right">The right <c>LuminousIntensity</c></param>
    /// <returns>true if left is &lt;= right; false otherwise.</returns>
    public static bool operator <=(LuminousIntensity left, LuminousIntensity right)
    {
        return left.CompareTo(right) <= 0;
    }

    /// <summary>
    /// Compares two <c>LuminousIntensity</c> instances to determine if the left one is greater than or equal to the right one.
    /// </summary>
    /// <param name="left">The left <c>LuminousIntensity</c></param>
    /// <param name="right">The right <c>LuminousIntensity</c></param>
    /// <returns>true if left is &gt;= right; false otherwise.</returns>
    public static bool operator >=(LuminousIntensity left, LuminousIntensity right)
    {
        return left.CompareTo(right) >= 0;
    }

    #endregion
}