using System;
using System.Diagnostics;

namespace Jcd.Units;

public record Duration(string Name, string Abbreviation, double Coefficient=1, double Offset=0) 
    : IUnitOfMeasure<Duration>
{
    public Duration(string Name, string Abbreviation, Duration baseUnit, double Coefficient, double Offset = 0) 
        : this(Name,Abbreviation,baseUnit.Coefficient*Coefficient,baseUnit.Coefficient*baseUnit.Offset+Offset)
    {
        Debug.WriteLine($"{this}");
    }
    
    #region Equality members

    public virtual bool Equals(Duration? other)
    {
        return Coefficient.Equals(other.Coefficient) && Offset.Equals(other.Offset);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Coefficient, Offset, typeof(Duration));
    }
    
    #endregion

    #region Relational members

    public int CompareTo(Duration other)
    {
        var factorComparison = Coefficient.CompareTo(other.Coefficient);
        return factorComparison != 0 ? factorComparison : Offset.CompareTo(other.Offset);
    }

    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is Duration other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Duration)}");
    }

    public static bool operator <(Duration left, Duration right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator >(Duration left, Duration right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator <=(Duration left, Duration right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >=(Duration left, Duration right)
    {
        return left.CompareTo(right) >= 0;
    }

    #endregion
    
    #region Predefined Durations
    
    public static Duration Second = new ("second", "s",1,0);
    public static Duration Decisecond = new ("decisecond", "ds",Second,1.0/10.0);
    public static Duration Centisecond = new ("centisecond", "cs",Decisecond,1.0/10.0);
    public static Duration Millisecond = new ("millisecond", "ms",Centisecond,1.0/10.0);
    public static Duration Microsecond = new ("microsecond", "μs",Millisecond,1.0/1000.0);
    public static Duration Nanosecond = new ("nanosecond", "ns",Microsecond,1.0/1000.0);
    public static Duration Picosecond = new ("picosecond", "ps",Nanosecond,1.0/1000.0);
    public static Duration Femtosecond = new ("femtosecond", "fs",Picosecond,1.0/1000.0);
    public static Duration Attosecond = new ("attosecond", "as",Femtosecond,1.0/1000.0);
    public static Duration Zeptosecond = new ("zeposecond", "zs",Attosecond,1.0/1000.0);
    public static Duration Yoctosecond = new ("yoctosecond", "ys",Zeptosecond,1.0/1000.0);
    public static Duration PlanckTime = new ("planck-time", "tP", Yoctosecond, 5.39121E-20);
    public static Duration Minute = new ("minute(s)", "min",Second,60);
    public static Duration Hour = new ("hour(s)", "hr",Minute,60);
    public static Duration Day = new ("day(s)", "dy",Hour,24);
    public static Duration Week = new ("week(s)", "wk",Day,7);
    public static Duration Year = new ("year(s)", "yr",Day,365.2525);
    public static Duration Decade = new ("decade(s)", "dec.",Year,10);
    public static Duration Century = new ("century", "cent.",Decade,10);
    public static Duration Millennium = new ("millennium", "ky",Century,10);
    public static Duration MillionYears = new ("million years", "Myr",Millennium,1000);
    public static Duration BillionYears = new ("billion years", "Gyr",MillionYears,1000);
    public static Duration TrillionYears = new ("trillion years", "Tyr",BillionYears,1000);
    public static Duration QuadrillionYears = new ("quadrillion years", "Pyr",TrillionYears,1000);
    public static Duration SextillionYears = new ("sextillion years", "Zyr",QuadrillionYears,1000);
    public static Duration SeptillionYears = new ("septillion years", "Yyr",SextillionYears,1000);    

    #endregion
}