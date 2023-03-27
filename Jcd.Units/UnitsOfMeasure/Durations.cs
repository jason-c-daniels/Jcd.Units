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
public class Durations : UnitOfMeasureEnumeration<Durations, Duration>
{
   /// <summary>
   /// A(n) second.
   /// </summary>
   public static readonly Duration Second = new ("second", "s");

   /// <summary>
   /// A(n) decisecond. Defined as: (1.0/10.0) × second + (0).
   /// </summary>
   public static readonly Duration Decisecond = new ("decisecond", "ds", Second, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centisecond. Defined as: (1.0/10.0) × decisecond + (0).
   /// </summary>
   public static readonly Duration Centisecond = new ("centisecond", "cs", Decisecond, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millisecond. Defined as: (1.0/10.0) × centisecond + (0).
   /// </summary>
   public static readonly Duration Millisecond = new ("millisecond", "ms", Centisecond, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microsecond. Defined as: (1.0/1000.0) × millisecond + (0).
   /// </summary>
   public static readonly Duration Microsecond = new ("microsecond", "μs", Millisecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanosecond. Defined as: (1.0/1000.0) × microsecond + (0).
   /// </summary>
   public static readonly Duration Nanosecond = new ("nanosecond", "ns", Microsecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picosecond. Defined as: (1.0/1000.0) × nanosecond + (0).
   /// </summary>
   public static readonly Duration Picosecond = new ("picosecond", "ps", Nanosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtosecond. Defined as: (1.0/1000.0) × picosecond + (0).
   /// </summary>
   public static readonly Duration Femtosecond = new ("femtosecond", "fs", Picosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attosecond. Defined as: (1.0/1000.0) × femtosecond + (0).
   /// </summary>
   public static readonly Duration Attosecond = new ("attosecond", "as", Femtosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptosecond. Defined as: (1.0/1000.0) × attosecond + (0).
   /// </summary>
   public static readonly Duration Zeptosecond = new ("zeptosecond", "zs", Attosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctosecond. Defined as: (1.0/1000.0) × zeptosecond + (0).
   /// </summary>
   public static readonly Duration Yoctosecond = new ("yoctosecond", "ys", Zeptosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontosecond. Defined as: (1.0/1000.0) × yoctosecond + (0).
   /// </summary>
   public static readonly Duration Rontosecond = new ("rontosecond", "rs", Yoctosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectosecond. Defined as: (1.0/1000.0) × rontosecond + (0).
   /// </summary>
   public static readonly Duration Quectosecond = new ("quectosecond", "qs", Rontosecond, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) minute. Defined as: (60.0) × second + (0).
   /// </summary>
   public static readonly Duration Minute = new ("minute", "min", Second, 60.0, 0);

   /// <summary>
   /// A(n) hour. Defined as: (60.0) × minute + (0).
   /// </summary>
   public static readonly Duration Hour = new ("hour", "hr", Minute, 60.0, 0);

   /// <summary>
   /// A(n) day. Defined as: (24.0) × hour + (0).
   /// </summary>
   public static readonly Duration Day = new ("day", "dy", Hour, 24.0, 0);

   /// <summary>
   /// A(n) week. Defined as: (7.0) × day + (0).
   /// </summary>
   public static readonly Duration Week = new ("week", "wk", Day, 7.0, 0);

   /// <summary>
   /// A(n) year. Defined as: (365.2525) × day + (0).
   /// </summary>
   public static readonly Duration Year = new ("year", "yr", Day, 365.2525, 0);

   /// <summary>
   /// A(n) decade. Defined as: (10.0) × year + (0).
   /// </summary>
   public static readonly Duration Decade = new ("decade", "dec.", Year, 10.0, 0);

   /// <summary>
   /// A(n) century. Defined as: (10.0) × decade + (0).
   /// </summary>
   public static readonly Duration Century = new ("century", "cent.", Decade, 10.0, 0);

   /// <summary>
   /// A(n) millennium. Defined as: (10.0) × century + (0).
   /// </summary>
   public static readonly Duration Millennium = new ("millennium", "kyr", Century, 10.0, 0);

   /// <summary>
   /// A(n) million years. Defined as: (1000.0) × millennium + (0).
   /// </summary>
   public static readonly Duration MillionYears = new ("million years", "Myr", Millennium, 1000.0, 0);

   /// <summary>
   /// A(n) billion years. Defined as: (1000.0) × million years + (0).
   /// </summary>
   public static readonly Duration BillionYears = new ("billion years", "Gyr", MillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) trillion years. Defined as: (1000.0) × billion years + (0).
   /// </summary>
   public static readonly Duration TrillionYears = new ("trillion years", "Tyr", BillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) quadrillion years. Defined as: (1000.0) × trillion years + (0).
   /// </summary>
   public static readonly Duration QuadrillionYears = new ("quadrillion years", "Pyr", TrillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) quintillion years. Defined as: (1000.0) × quadrillion years + (0).
   /// </summary>
   public static readonly Duration QuintillionYears = new ("quintillion years", "Eyr", QuadrillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) sextillion years. Defined as: (1000.0) × quintillion years + (0).
   /// </summary>
   public static readonly Duration SextillionYears = new ("sextillion years", "Zyr", QuintillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) septillion years. Defined as: (1000.0) × sextillion years + (0).
   /// </summary>
   public static readonly Duration SeptillionYears = new ("septillion years", "Yyr", SextillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) octillion years. Defined as: (1000.0) × septillion years + (0).
   /// </summary>
   public static readonly Duration OctillionYears = new ("octillion years", "Ryr", SeptillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) nonillion years. Defined as: (1000.0) × octillion years + (0).
   /// </summary>
   public static readonly Duration NonillionYears = new ("nonillion years", "Qyr", OctillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) decillion years. Defined as: (1000.0) × nonillion years + (0).
   /// </summary>
   public static readonly Duration DecillionYears = new ("decillion years", "decillion yr", NonillionYears, 1000.0, 0);

   /// <summary>
   /// A(n) planck-time. Defined as: (5.391247E-38) × microsecond + (0).
   /// </summary>
   public static readonly Duration PlanckTime = new ("planck-time", "tₚ", Microsecond, 5.391247E-38, 0);

   /// <summary>
   /// A(n) tick. Defined as: (100.0) × nanosecond + (0).
   /// </summary>
   public static readonly Duration Tick = new ("tick", "tick", Nanosecond, 100.0, 0);
}
