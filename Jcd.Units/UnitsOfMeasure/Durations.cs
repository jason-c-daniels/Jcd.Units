using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure;

/// <summary>
/// Uncategorized Units for measuring Duration.
/// </summary>
public class Durations : Enumeration<Durations,Duration>
{
    public static readonly Duration Second = new ("second", "s");
    public static readonly Duration Decisecond = new ("decisecond", "ds", Second, 1.0/10.0,0);
    public static readonly Duration Centisecond = new ("centisecond", "cs", Decisecond, 1.0/10.0,0);
    public static readonly Duration Millisecond = new ("millisecond", "ms", Centisecond, 1.0/10.0,0);
    public static readonly Duration Microsecond = new ("microsecond", "μs", Millisecond, 1.0/1000.0,0);
    public static readonly Duration Nanosecond = new ("nanosecond", "ns", Microsecond, 1.0/1000.0,0);
    public static readonly Duration Picosecond = new ("picosecond", "ps", Nanosecond, 1.0/1000.0,0);
    public static readonly Duration Femtosecond = new ("femtosecond", "fs", Picosecond, 1.0/1000.0,0);
    public static readonly Duration Attosecond = new ("attosecond", "as", Femtosecond, 1.0/1000.0,0);
    public static readonly Duration Zeptosecond = new ("zeptosecond", "zs", Attosecond, 1.0/1000.0,0);
    public static readonly Duration Yoctosecond = new ("yoctosecond", "ys", Zeptosecond, 1.0/1000.0,0);
    public static readonly Duration Rontosecond = new ("rontosecond", "rs", Yoctosecond, 1.0/1000.0,0);
    public static readonly Duration Quectosecond = new ("quectosecond", "qs", Rontosecond, 1.0/1000.0,0);
    public static readonly Duration Dekasecond = new ("dekasecond", "das", Second, 10,0);
    public static readonly Duration Hectosecond = new ("hectosecond", "hs", Dekasecond, 10,0);
    public static readonly Duration Kilosecond = new ("kilosecond", "ks", Hectosecond, 10,0);
    public static readonly Duration Megasecond = new ("megasecond", "Ms", Kilosecond, 1000,0);
    public static readonly Duration Gigasecond = new ("gigasecond", "Gs", Megasecond, 1000,0);
    public static readonly Duration Terasecond = new ("terasecond", "Ts", Gigasecond, 1000,0);
    public static readonly Duration Petasecond = new ("petasecond", "Ps", Terasecond, 1000,0);
    public static readonly Duration Exasecond = new ("exasecond", "Es", Petasecond, 1000,0);
    public static readonly Duration Zettasecond = new ("zettasecond", "Zs", Exasecond, 1000,0);
    public static readonly Duration Yottasecond = new ("yottasecond", "Ys", Zettasecond, 1000,0);
    public static readonly Duration Ronnasecond = new ("ronnasecond", "Rs", Yottasecond, 1000,0);
    public static readonly Duration Quettasecond = new ("quettasecond", "Qs", Ronnasecond, 1000,0);
    public static readonly Duration Minute = new ("minute", "min", Second, 60,0);
    public static readonly Duration Hour = new ("hour", "hr", Minute, 60,0);
    public static readonly Duration Day = new ("day", "dy", Hour, 24,0);
    public static readonly Duration Week = new ("week", "wk", Day, 7,0);
    public static readonly Duration Year = new ("year", "yr", Day, 365.2525,0);
    public static readonly Duration Decade = new ("decade", "dec.", Year, 10,0);
    public static readonly Duration Century = new ("century", "cent.", Decade, 10,0);
    public static readonly Duration Millennium = new ("millennium", "kyr", Century, 10,0);
    public static readonly Duration MillionYears = new ("million years", "Myr", Millennium, 1000,0);
    public static readonly Duration BillionYears = new ("billion years", "Gyr", MillionYears, 1000,0);
    public static readonly Duration TrillionYears = new ("trillion years", "Tyr", BillionYears, 1000,0);
    public static readonly Duration QuadrillionYears = new ("quadrillion years", "Pyr", TrillionYears, 1000,0);
    public static readonly Duration SextillionYears = new ("sextillion years", "Zyr", QuadrillionYears, 1000,0);
    public static readonly Duration SeptillionYears = new ("septillion years", "Yyr", SextillionYears, 1000,0);
    public static readonly Duration PlanckTime = new ("planck-time", "tP", Yoctosecond, 5.39121E-20,0);
}