#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure;

/// <summary>
/// Uncategorized Units for measuring Duration.
/// </summary>
public class Durations : Enumeration<Durations, Duration>
{
   /// <summary>
   /// A(n) second.
   /// </summary>
   public static readonly Duration Second = new ("second", "s");

   /// <summary>
   /// A(n) decisecond. Defined in terms of a(n) second.
   /// </summary>
   public static readonly Duration Decisecond = new ("decisecond", "ds", Second, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centisecond. Defined in terms of a(n) decisecond.
   /// </summary>
   public static readonly Duration Centisecond = new ("centisecond", "cs", Decisecond, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millisecond. Defined in terms of a(n) centisecond.
   /// </summary>
   public static readonly Duration Millisecond = new ("millisecond", "ms", Centisecond, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microsecond. Defined in terms of a(n) millisecond.
   /// </summary>
   public static readonly Duration Microsecond = new ("microsecond", "μs", Millisecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanosecond. Defined in terms of a(n) microsecond.
   /// </summary>
   public static readonly Duration Nanosecond = new ("nanosecond", "ns", Microsecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picosecond. Defined in terms of a(n) nanosecond.
   /// </summary>
   public static readonly Duration Picosecond = new ("picosecond", "ps", Nanosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtosecond. Defined in terms of a(n) picosecond.
   /// </summary>
   public static readonly Duration Femtosecond = new ("femtosecond", "fs", Picosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attosecond. Defined in terms of a(n) femtosecond.
   /// </summary>
   public static readonly Duration Attosecond = new ("attosecond", "as", Femtosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptosecond. Defined in terms of a(n) attosecond.
   /// </summary>
   public static readonly Duration Zeptosecond = new ("zeptosecond", "zs", Attosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctosecond. Defined in terms of a(n) zeptosecond.
   /// </summary>
   public static readonly Duration Yoctosecond = new ("yoctosecond", "ys", Zeptosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontosecond. Defined in terms of a(n) yoctosecond.
   /// </summary>
   public static readonly Duration Rontosecond = new ("rontosecond", "rs", Yoctosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectosecond. Defined in terms of a(n) rontosecond.
   /// </summary>
   public static readonly Duration Quectosecond = new ("quectosecond", "qs", Rontosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) minute. Defined in terms of a(n) second.
   /// </summary>
   public static readonly Duration Minute = new ("minute", "min", Second, 60.0, 0);

   /// <summary>
   /// A(n) hour. Defined in terms of a(n) minute.
   /// </summary>
   public static readonly Duration Hour = new ("hour", "hr", Minute, 60.0, 0);

   /// <summary>
   /// A(n) day. Defined in terms of a(n) hour.
   /// </summary>
   public static readonly Duration Day = new ("day", "dy", Hour, 24.0, 0);

   /// <summary>
   /// A(n) week. Defined in terms of a(n) day.
   /// </summary>
   public static readonly Duration Week = new ("week", "wk", Day, 7.0, 0);

   /// <summary>
   /// A(n) year. Defined in terms of a(n) day.
   /// </summary>
   public static readonly Duration Year = new ("year", "yr", Day, 365.2525, 0);

   /// <summary>
   /// A(n) decade. Defined in terms of a(n) year.
   /// </summary>
   public static readonly Duration Decade = new ("decade", "dec.", Year, 10.0, 0);

   /// <summary>
   /// A(n) century. Defined in terms of a(n) decade.
   /// </summary>
   public static readonly Duration Century = new ("century", "cent.", Decade, 10.0, 0);

   /// <summary>
   /// A(n) millennium. Defined in terms of a(n) century.
   /// </summary>
   public static readonly Duration Millennium = new ("millennium", "kyr", Century, 10.0, 0);

   /// <summary>
   /// A(n) million years. Defined in terms of a(n) millennium.
   /// </summary>
   public static readonly Duration MillionYears = new ("million years", "Myr", Millennium, 1000.0, 0);

   /// <summary>
   /// A(n) billion years. Defined in terms of a(n) million years.
   /// </summary>
   public static readonly Duration BillionYears = new ("billion years", "Gyr", MillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) trillion years. Defined in terms of a(n) billion years.
   /// </summary>
   public static readonly Duration TrillionYears = new ("trillion years", "Tyr", BillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) quadrillion years. Defined in terms of a(n) trillion years.
   /// </summary>
   public static readonly Duration QuadrillionYears = new ("quadrillion years", "Pyr", TrillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) quintillion years. Defined in terms of a(n) quadrillion years.
   /// </summary>
   public static readonly Duration QuintillionYears = new ("quintillion years", "Eyr", QuadrillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) sextillion years. Defined in terms of a(n) quintillion years.
   /// </summary>
   public static readonly Duration SextillionYears = new ("sextillion years", "Zyr", QuintillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) septillion years. Defined in terms of a(n) sextillion years.
   /// </summary>
   public static readonly Duration SeptillionYears = new ("septillion years", "Yyr", SextillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) octillion years. Defined in terms of a(n) septillion years.
   /// </summary>
   public static readonly Duration OctillionYears = new ("octillion years", "Ryr", SeptillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) nonillion years. Defined in terms of a(n) octillion years.
   /// </summary>
   public static readonly Duration NonillionYears = new ("nonillion years", "Qyr", OctillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) decillion years. Defined in terms of a(n) nonillion years.
   /// </summary>
   public static readonly Duration DecillionYears = new ("decillion years", "decillion yr", NonillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) planck-time. Defined in terms of a(n) microsecond.
   /// </summary>
   public static readonly Duration PlanckTime = new ("planck-time", "t(P)", Microsecond, 5.391247E-38, 0);

   /// <summary>
   /// A(n) tick. Defined in terms of a(n) nanosecond.
   /// </summary>
   public static readonly Duration Tick = new ("tick", "tick", Nanosecond, 100.0, 0);
}
