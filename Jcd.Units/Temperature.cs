using System;
using System.Diagnostics;

namespace Jcd.Units;

public record Temperature(string Name, string Abbreviation, double Coefficient=1, double Offset=0) 
    : IUnitOfMeasure<Temperature>
{
    public Temperature(string Name, string Abbreviation, Temperature baseUnit, double Coefficient, double Offset = 0) 
        : this(Name,Abbreviation,baseUnit.Coefficient*Coefficient,baseUnit.Coefficient*baseUnit.Offset+Offset)
    {
        Debug.WriteLine($"{this}");
    }
    
    #region Equality members

    public virtual bool Equals(Temperature? other)
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
    
    #region Predefined Temperatures
    
    public static Temperature Celcius = new ("Celcius", "°C",1,0);
    public static Temperature Kelvin = new ("Kelvin", "°K", Celcius,1,-273.15);
    public static Temperature Fahrenheit = new ("Fahrenheit", "°F",5.0/9.0,-32.0);
    public static Temperature Rankine = new ("Rankine", "°R",Celcius,5.0/9.0, -491.67);
    public static Temperature Delisle = new ("Delisle", "°De",Celcius,1.5,100.0);
    public static Temperature Newton = new ("Newton", "°N",Celcius,33.0/100.0);
    public static Temperature Réaumur = new ("Réaumur", "°Ré",Celcius,4.0/5.0);
    public static Temperature Rømer = new ("Rømer", "°Rø",Celcius,0.52500,-7.5);
    
    #endregion
}