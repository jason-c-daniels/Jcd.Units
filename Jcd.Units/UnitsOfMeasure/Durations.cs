using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure;

public class Durations : Enumeration<Durations,Duration>
{
    public static Duration Second = new ("second", "s");
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
}