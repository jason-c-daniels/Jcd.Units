using System;
using System.Diagnostics;

namespace Jcd.Units;

public record struct Temperature(string Name, string Symbol, double Coefficient=1, double Offset=0) 
    : IUnitOfMeasure<Temperature>
{
    public Temperature(string Name, string Symbol, Temperature baseUnit, double Coefficient, double Offset = 0) 
        : this(Name,Symbol,baseUnit.Coefficient*Coefficient,baseUnit.Coefficient*baseUnit.Offset+Offset)
    {
        Debug.WriteLine($"{this}");
    }
    
    #region Equality members

    public bool Equals(Temperature other)
    {
        return Coefficient.Equals(other.Coefficient) && Offset.Equals(other.Offset);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Coefficient, Offset);
    }
    
    #endregion

    #region Relational members

    public int CompareTo(Temperature other)
    {
        var factorComparison = Coefficient.CompareTo(other.Coefficient);
        return factorComparison != 0 ? factorComparison : Offset.CompareTo(other.Offset);
    }

    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is Temperature other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Temperature)}");
    }

    public static bool operator <(Temperature left, Temperature right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator >(Temperature left, Temperature right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator <=(Temperature left, Temperature right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >=(Temperature left, Temperature right)
    {
        return left.CompareTo(right) >= 0;
    }

    #endregion
}