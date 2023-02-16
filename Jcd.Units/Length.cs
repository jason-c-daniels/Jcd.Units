using System;
using System.Diagnostics;

namespace Jcd.Units;

public record struct Length(string Name, string Symbol, double Coefficient=1.0, double Offset=0) 
    : IUnitOfMeasure<Length>
{
    public Length(string Name, string Symbol, Length baseUnit, double Coefficient=1.0, double Offset = 0) 
        : this(Name,Symbol,baseUnit.Coefficient*Coefficient,baseUnit.Coefficient*baseUnit.Offset+Offset)
    {
        Debug.WriteLine($"{this}");
    }
    
    #region Equality members

    public bool Equals(Length other)
    {
        return Coefficient.Equals(other.Coefficient) && Offset.Equals(other.Offset);
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Coefficient, Offset);
    }
    
    #endregion

    #region Relational members

    public int CompareTo(Length other)
    {
        var factorComparison = Coefficient.CompareTo(other.Coefficient);
        return factorComparison != 0 ? factorComparison : Offset.CompareTo(other.Offset);
    }

    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is Length other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Length)}");
    }

    public static bool operator <(Length left, Length right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator >(Length left, Length right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator <=(Length left, Length right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >=(Length left, Length right)
    {
        return left.CompareTo(right) >= 0;
    }

    #endregion
}