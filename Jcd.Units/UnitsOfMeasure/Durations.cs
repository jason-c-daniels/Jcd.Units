using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure;

/// <summary>
/// Uncategorized Units for measuring Duration.
/// </summary>
public class Durations : Enumeration<Durations,Duration>
{

    /// <summary>
    /// Units of a second.
    /// </summary>
    public static readonly Duration Second = new ("second", "s");
    /// <summary>
    /// Units of a decisecond. It's defined in terms of a(n)  second.
    /// </summary>
    public static readonly Duration Decisecond = new ("decisecond", "ds", Second, 1.0/10.0,0);
    /// <summary>
    /// Units of a centisecond. It's defined in terms of a(n)  decisecond.
    /// </summary>
    public static readonly Duration Centisecond = new ("centisecond", "cs", Decisecond, 1.0/10.0,0);
    /// <summary>
    /// Units of a millisecond. It's defined in terms of a(n)  centisecond.
    /// </summary>
    public static readonly Duration Millisecond = new ("millisecond", "ms", Centisecond, 1.0/10.0,0);
    /// <summary>
    /// Units of a microsecond. It's defined in terms of a(n)  millisecond.
    /// </summary>
    public static readonly Duration Microsecond = new ("microsecond", "μs", Millisecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanosecond. It's defined in terms of a(n)  microsecond.
    /// </summary>
    public static readonly Duration Nanosecond = new ("nanosecond", "ns", Microsecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picosecond. It's defined in terms of a(n)  nanosecond.
    /// </summary>
    public static readonly Duration Picosecond = new ("picosecond", "ps", Nanosecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtosecond. It's defined in terms of a(n)  picosecond.
    /// </summary>
    public static readonly Duration Femtosecond = new ("femtosecond", "fs", Picosecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attosecond. It's defined in terms of a(n)  femtosecond.
    /// </summary>
    public static readonly Duration Attosecond = new ("attosecond", "as", Femtosecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptosecond. It's defined in terms of a(n)  attosecond.
    /// </summary>
    public static readonly Duration Zeptosecond = new ("zeptosecond", "zs", Attosecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctosecond. It's defined in terms of a(n)  zeptosecond.
    /// </summary>
    public static readonly Duration Yoctosecond = new ("yoctosecond", "ys", Zeptosecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontosecond. It's defined in terms of a(n)  yoctosecond.
    /// </summary>
    public static readonly Duration Rontosecond = new ("rontosecond", "rs", Yoctosecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectosecond. It's defined in terms of a(n)  rontosecond.
    /// </summary>
    public static readonly Duration Quectosecond = new ("quectosecond", "qs", Rontosecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekasecond. It's defined in terms of a(n)  second.
    /// </summary>
    public static readonly Duration Dekasecond = new ("dekasecond", "das", Second, 10,0);
    /// <summary>
    /// Units of a hectosecond. It's defined in terms of a(n)  dekasecond.
    /// </summary>
    public static readonly Duration Hectosecond = new ("hectosecond", "hs", Dekasecond, 10,0);
    /// <summary>
    /// Units of a kilosecond. It's defined in terms of a(n)  hectosecond.
    /// </summary>
    public static readonly Duration Kilosecond = new ("kilosecond", "ks", Hectosecond, 10,0);
    /// <summary>
    /// Units of a megasecond. It's defined in terms of a(n)  kilosecond.
    /// </summary>
    public static readonly Duration Megasecond = new ("megasecond", "Ms", Kilosecond, 1000,0);
    /// <summary>
    /// Units of a gigasecond. It's defined in terms of a(n)  megasecond.
    /// </summary>
    public static readonly Duration Gigasecond = new ("gigasecond", "Gs", Megasecond, 1000,0);
    /// <summary>
    /// Units of a terasecond. It's defined in terms of a(n)  gigasecond.
    /// </summary>
    public static readonly Duration Terasecond = new ("terasecond", "Ts", Gigasecond, 1000,0);
    /// <summary>
    /// Units of a petasecond. It's defined in terms of a(n)  terasecond.
    /// </summary>
    public static readonly Duration Petasecond = new ("petasecond", "Ps", Terasecond, 1000,0);
    /// <summary>
    /// Units of a exasecond. It's defined in terms of a(n)  petasecond.
    /// </summary>
    public static readonly Duration Exasecond = new ("exasecond", "Es", Petasecond, 1000,0);
    /// <summary>
    /// Units of a zettasecond. It's defined in terms of a(n)  exasecond.
    /// </summary>
    public static readonly Duration Zettasecond = new ("zettasecond", "Zs", Exasecond, 1000,0);
    /// <summary>
    /// Units of a yottasecond. It's defined in terms of a(n)  zettasecond.
    /// </summary>
    public static readonly Duration Yottasecond = new ("yottasecond", "Ys", Zettasecond, 1000,0);
    /// <summary>
    /// Units of a ronnasecond. It's defined in terms of a(n)  yottasecond.
    /// </summary>
    public static readonly Duration Ronnasecond = new ("ronnasecond", "Rs", Yottasecond, 1000,0);
    /// <summary>
    /// Units of a quettasecond. It's defined in terms of a(n)  ronnasecond.
    /// </summary>
    public static readonly Duration Quettasecond = new ("quettasecond", "Qs", Ronnasecond, 1000,0);
    /// <summary>
    /// Units of a minute. It's defined in terms of a(n)  second.
    /// </summary>
    public static readonly Duration Minute = new ("minute", "min", Second, 60,0);
    /// <summary>
    /// Units of a hour. It's defined in terms of a(n)  minute.
    /// </summary>
    public static readonly Duration Hour = new ("hour", "hr", Minute, 60,0);
    /// <summary>
    /// Units of a day. It's defined in terms of a(n)  hour.
    /// </summary>
    public static readonly Duration Day = new ("day", "dy", Hour, 24,0);
    /// <summary>
    /// Units of a week. It's defined in terms of a(n)  day.
    /// </summary>
    public static readonly Duration Week = new ("week", "wk", Day, 7,0);
    /// <summary>
    /// Units of a year. It's defined in terms of a(n)  day.
    /// </summary>
    public static readonly Duration Year = new ("year", "yr", Day, 365.2525,0);
    /// <summary>
    /// Units of a decade. It's defined in terms of a(n)  year.
    /// </summary>
    public static readonly Duration Decade = new ("decade", "dec.", Year, 10,0);
    /// <summary>
    /// Units of a century. It's defined in terms of a(n)  decade.
    /// </summary>
    public static readonly Duration Century = new ("century", "cent.", Decade, 10,0);
    /// <summary>
    /// Units of a millennium. It's defined in terms of a(n)  century.
    /// </summary>
    public static readonly Duration Millennium = new ("millennium", "kyr", Century, 10,0);
    /// <summary>
    /// Units of a million years. It's defined in terms of a(n)  millennium.
    /// </summary>
    public static readonly Duration MillionYears = new ("million years", "Myr", Millennium, 1000,0);
    /// <summary>
    /// Units of a billion years. It's defined in terms of a(n)  million years.
    /// </summary>
    public static readonly Duration BillionYears = new ("billion years", "Gyr", MillionYears, 1000,0);
    /// <summary>
    /// Units of a trillion years. It's defined in terms of a(n)  billion years.
    /// </summary>
    public static readonly Duration TrillionYears = new ("trillion years", "Tyr", BillionYears, 1000,0);
    /// <summary>
    /// Units of a quadrillion years. It's defined in terms of a(n)  trillion years.
    /// </summary>
    public static readonly Duration QuadrillionYears = new ("quadrillion years", "Pyr", TrillionYears, 1000,0);
    /// <summary>
    /// Units of a sextillion years. It's defined in terms of a(n)  quadrillion years.
    /// </summary>
    public static readonly Duration SextillionYears = new ("sextillion years", "Zyr", QuadrillionYears, 1000,0);
    /// <summary>
    /// Units of a septillion years. It's defined in terms of a(n)  sextillion years.
    /// </summary>
    public static readonly Duration SeptillionYears = new ("septillion years", "Yyr", SextillionYears, 1000,0);
    /// <summary>
    /// Units of a planck-time. It's defined in terms of a(n)  yoctosecond.
    /// </summary>
    public static readonly Duration PlanckTime = new ("planck-time", "tP", Yoctosecond, 5.39121E-20,0);

}