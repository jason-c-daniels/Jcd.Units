using System;
using System.Text;

namespace Jcd.Units;

/// <summary>
/// Base type to simplify creating a unit of measure. This type provides relational and equivalence operations.
/// </summary>
/// <param name="Name">The name of this unit</param>
/// <param name="Symbol">The symbol or abbreviation to represent the <see cref="UnitOfMeasure{TUnit}"/></param>
/// <param name="Coefficient">The unit's coefficient relative to the ultimate base unit's representation.</param>
/// <param name="Offset">The offset used when computing values going to and from the base unit's representation.</param>
public abstract record UnitOfMeasure<TUnit>(
        string Name,
        string Symbol,
        double Coefficient=1,
        double Offset=0
        ) 
    : IUnitOfMeasure<TUnit>
where TUnit : UnitOfMeasure<TUnit>
{
    private IValueComparer<double>? _comparer;
    private readonly TUnit? _fundamentalUnit;
    private readonly TUnit? _baseUnit;

    /// <summary>
    /// Sets the <see cref="IValueComparer{Double}"/> used by units of measure for this particular unit of
    /// measure type. (e.g. lengths.) 
    /// </summary>
    // ReSharper disable once StaticMemberInGenericType
    public static IValueComparer<double>? DefaultDoubleComparer { get; set; }
    
    /// <summary>
    /// The unit of measure all others are represented in terms of.
    /// </summary>
    public TUnit FundamentalUnit
    {
        get => _fundamentalUnit ?? (TUnit)this;
        protected init => _fundamentalUnit = value;
    }

    /// <summary>
    /// The unit of measure this one was defined in terms of.
    /// </summary>
    public TUnit BaseUnit
    {
        get => _baseUnit ?? (TUnit)this;
        protected init => _baseUnit = value;
    }

    /// <summary>
    /// Indicates if this unit of measure is the fundamental unit. (i.e. Coefficient 1, Offset 0)
    /// </summary>
    public bool IsFundamentalUnit => _baseUnit is null;

    /// <summary>
    /// The <see cref="IValueComparer{T}"/> used for comparisons: where <c>T</c> is a <see cref="Double"/>.
    /// </summary>
    /// <remarks>
    /// If not assigned during initialization, this returns <see cref="UnitOfMeasure{TUnit}"/>
    /// type specific comparison (e.g. Temperatures) or and the globally configured comparer.  
    /// </remarks>
    public IValueComparer<double>? Comparer
    {
        get => _comparer ?? DefaultDoubleComparer ?? DoubleComparer.UnitOfMeasure;
        set => _comparer = value;
    }

    #region Equality members

    /// <summary>
    /// Compares this <see cref="UnitOfMeasure{TUnit}"/> to another one for equality.
    /// </summary>
    /// <param name="other">The other <see cref="UnitOfMeasure{TUnit}"/> to compare against.</param>
    /// <returns>true if equivalent, false otherwise.</returns>
    public virtual bool Equals(UnitOfMeasure<TUnit>? other)
    {
        if (other is null) return false;
        var comparer = Comparer;
        return comparer.Equals(Coefficient,other.Coefficient) && comparer.Equals(Offset,other.Offset);
    }
    
    /// <summary>
    /// Computes the hash code for this <see cref="UnitOfMeasure{TUnit}"/>
    /// </summary>
    /// <returns>The computed hashcode.</returns>
    public override int GetHashCode()
    {
        // ReSharper disable once NonReadonlyMemberInGetHashCode
        var comparer = Comparer;
        return HashCode.Combine(comparer.GetHashCode(Coefficient), comparer.GetHashCode(Offset), typeof(TUnit));
    }

    /// <inheritdoc />
    public sealed override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{Name} ({Symbol})");
        if (!ReferenceEquals(this, FundamentalUnit))
        {
            sb.Append($" [= {FundamentalUnit.Symbol}");
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (Coefficient != 1.0 || Offset == 0.0) sb.Append($" × {(1.0 / Coefficient):n3}");
            if (Offset != 0.0)
            {
                var sign = Offset <= 0 ? '+' : '-';
                sb.Append($" {sign} {Math.Abs(Offset):n3}");
            }

            sb.Append(']');
        }
        
        return sb.ToString();
    }

    #endregion

    #region Relational members

    /// <summary>
    /// Performs a relative comparison between this <see cref="UnitOfMeasure{TUnit}"/> and another one.
    /// </summary>
    /// <param name="other">The <see cref="UnitOfMeasure{TUnit}"/> to compare against.</param>
    /// <returns>-1 if less than; 1 if greater than; 0 if equals.</returns>
    public int CompareTo(TUnit? other)
    {
        if (other is null) return 1; // sort nulls first.
        var comparer = Comparer;
        var factorComparison = comparer.Compare(Coefficient,other.Coefficient);
        var result= factorComparison != 0 ? factorComparison : comparer.Compare(Offset,other.Offset);
        return result;
    }

    /// <summary>
    /// Performs a relative comparison between this <see cref="UnitOfMeasure{TUnit}"/> and another one.
    /// </summary>
    /// <param name="obj">The <see cref="UnitOfMeasure{TUnit}"/> to compare against.</param>
    /// <returns>-1 if less than; 1 if greater than; 0 if equals.</returns>
    /// <exception cref="ArgumentException">When the passed in object is not a <see cref="UnitOfMeasure{TUnit}"/></exception>
    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1; // sort nulls first.
        return obj is TUnit other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(UnitOfMeasure<TUnit>)}");
    }

    /// <summary>
    /// Compares two <see cref="UnitOfMeasure{TUnit}"/> instances to determine if the left one is less than the right one. 
    /// </summary>
    /// <param name="left">The left <see cref="UnitOfMeasure{TUnit}"/></param>
    /// <param name="right">The right <see cref="UnitOfMeasure{TUnit}"/></param>
    /// <returns>true if left is &lt; right; false otherwise.</returns>
    public static bool operator <(UnitOfMeasure<TUnit>? left, UnitOfMeasure<TUnit>? right)
    {
        if (ReferenceEquals(left, right)) return false; // if they're the same instance or both are null.
        if (ReferenceEquals(null, right)) return false; // relationally, nulls do not compare, return false.
        if (ReferenceEquals(null, left)) return false; // relationally, nulls do not compare, return false.
        return left.CompareTo(right) < 0;
    }

    /// <summary>
    /// Compares two <see cref="UnitOfMeasure{TUnit}"/> instances to determine if the left one is greater than the right one. 
    /// </summary>
    /// <param name="left">The left <see cref="UnitOfMeasure{TUnit}"/></param>
    /// <param name="right">The right <see cref="UnitOfMeasure{TUnit}"/></param>
    /// <returns>true if left is &gt; right; false otherwise.</returns>
    public static bool operator >(UnitOfMeasure<TUnit>? left, UnitOfMeasure<TUnit>? right)
    {
        if (ReferenceEquals(left, right)) return false; // if they're the same instance or both are null.
        if (ReferenceEquals(null, right)) return false; // relationally, nulls do not compare, return false.
        if (ReferenceEquals(null, left)) return false; // relationally, nulls do not compare, return false.
        return left.CompareTo(right) > 0;
    }

    /// <summary>
    /// Compares two <see cref="UnitOfMeasure{TUnit}"/> instances to determine if the left one is less than or equal to the right one. 
    /// </summary>
    /// <param name="left">The left <see cref="UnitOfMeasure{TUnit}"/></param>
    /// <param name="right">The right <see cref="UnitOfMeasure{TUnit}"/></param>
    /// <returns>true if left is &lt;= right; false otherwise.</returns>
    public static bool operator <=(UnitOfMeasure<TUnit>? left, UnitOfMeasure<TUnit>? right)
    {
        if (left is null && right is null) return false; // relationally, nulls do not compare, return false. 
        if (ReferenceEquals(left, right)) return true; // if they're the same instance.
        if (ReferenceEquals(null, right)) return false; // relationally, nulls do not compare, return false.
        if (ReferenceEquals(null, left)) return false; // relationally, nulls do not compare, return false.
        return left.CompareTo(right) <= 0;
    }

    /// <summary>
    /// Compares two <see cref="UnitOfMeasure{TUnit}"/> instances to determine if the left one is greater than or equal to the right one. 
    /// </summary>
    /// <param name="left">The left <see cref="UnitOfMeasure{TUnit}"/></param>
    /// <param name="right">The right <see cref="UnitOfMeasure{TUnit}"/></param>
    /// <returns>true if left is &gt;= right; false otherwise.</returns>
    public static bool operator >=(UnitOfMeasure<TUnit>? left, UnitOfMeasure<TUnit>? right)
    {
        if (left is null && right is null) return false; // relationally, nulls do not compare, return false. 
        if (ReferenceEquals(left, right)) return true; // if they're the same instance.
        if (ReferenceEquals(null, right)) return false; // relationally, nulls do not compare, return false.
        if (ReferenceEquals(null, left)) return false; // relationally, nulls do not compare, return false.
        return left.CompareTo(right) >= 0;
    }

    #endregion
    
    #region Conversion Methods
    
    /// <inheritdoc cref="IUnitOfMeasure{TUnit}"/> 
    public double FromBaseUnitValue(double normalizedValue) 
        => (normalizedValue / Coefficient)  - Offset;

    /// <inheritdoc cref="IUnitOfMeasure{TUnit}"/> 
    public double ToBaseUnitValue( double denormalizedValue) 
        => (denormalizedValue + Offset) * Coefficient;
    
    /// <inheritdoc cref="IUnitOfMeasure{TUnit}"/> 
    public double ComputeFundamentalCoefficient(double coefficient) 
        => Coefficient * coefficient;

    /// <inheritdoc cref="IUnitOfMeasure{TUnit}"/> 
    public double ComputeFundamentalOffset(double fundamentalCoefficient, double offset) 
        => IsFundamentalUnit ? offset : ToBaseUnitValue(offset)/fundamentalCoefficient;

    #endregion
    
}