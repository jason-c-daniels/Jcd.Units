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
   /// second, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Duration Second = new("second", "s", system: "");
   
   /// <summary>
   /// decisecond defined such that: second = ds × 1.0/10.0.
   /// </summary>
   public static readonly Duration Decisecond = new("decisecond", "ds", Second, 1.0 / 10.0, system: "");
   
   /// <summary>
   /// centisecond defined such that: decisecond = cs × 1.0/10.0.
   /// </summary>
   public static readonly Duration Centisecond = new("centisecond", "cs", Decisecond, 1.0 / 10.0, system: "");
   
   /// <summary>
   /// millisecond defined such that: centisecond = ms × 1.0/10.0.
   /// </summary>
   public static readonly Duration Millisecond = new("millisecond", "ms", Centisecond, 1.0 / 10.0, system: "");
   
   /// <summary>
   /// microsecond defined such that: millisecond = μs × 1.0/1000.0.
   /// </summary>
   public static readonly Duration Microsecond = new("microsecond", "μs", Millisecond, 1.0 / 1000.0, system: "");
   
   /// <summary>
   /// nanosecond defined such that: microsecond = ns × 1.0/1000.0.
   /// </summary>
   public static readonly Duration Nanosecond = new("nanosecond", "ns", Microsecond, 1.0 / 1000.0, system: "");
   
   /// <summary>
   /// picosecond defined such that: nanosecond = ps × 1.0/1000.0.
   /// </summary>
   public static readonly Duration Picosecond = new("picosecond", "ps", Nanosecond, 1.0 / 1000.0, system: "");
   
   /// <summary>
   /// femtosecond defined such that: picosecond = fs × 1.0/1000.0.
   /// </summary>
   public static readonly Duration Femtosecond = new("femtosecond", "fs", Picosecond, 1.0 / 1000.0, system: "");
   
   /// <summary>
   /// attosecond defined such that: femtosecond = as × 1.0/1000.0.
   /// </summary>
   public static readonly Duration Attosecond = new("attosecond", "as", Femtosecond, 1.0 / 1000.0, system: "");
   
   /// <summary>
   /// zeptosecond defined such that: attosecond = zs × 1.0/1000.0.
   /// </summary>
   public static readonly Duration Zeptosecond = new("zeptosecond", "zs", Attosecond, 1.0 / 1000.0, system: "");
   
   /// <summary>
   /// yoctosecond defined such that: zeptosecond = ys × 1.0/1000.0.
   /// </summary>
   public static readonly Duration Yoctosecond = new("yoctosecond", "ys", Zeptosecond, 1.0 / 1000.0, system: "");
   
   /// <summary>
   /// rontosecond defined such that: yoctosecond = rs × 1.0/1000.0.
   /// </summary>
   public static readonly Duration Rontosecond = new("rontosecond", "rs", Yoctosecond, 1.0 / 1000.0, system: "");
   
   /// <summary>
   /// quectosecond defined such that: rontosecond = qs × 1.0/1000.0.
   /// </summary>
   public static readonly Duration Quectosecond = new("quectosecond", "qs", Rontosecond, 1.0 / 1000.0, system: "");
   
   /// <summary>
   /// minute defined such that: second = min × 60.0.
   /// </summary>
   public static readonly Duration Minute = new("minute", "min", Second, 60.0, system: "");
   
   /// <summary>
   /// hour defined such that: minute = hr × 60.0.
   /// </summary>
   public static readonly Duration Hour = new("hour", "hr", Minute, 60.0, system: "");
   
   /// <summary>
   /// day defined such that: hour = dy × 24.0.
   /// </summary>
   public static readonly Duration Day = new("day", "dy", Hour, 24.0, system: "");
   
   /// <summary>
   /// week defined such that: day = wk × 7.0.
   /// </summary>
   public static readonly Duration Week = new("week", "wk", Day, 7.0, system: "");
   
   /// <summary>
   /// year defined such that: day = yr × 365.2525.
   /// </summary>
   public static readonly Duration Year = new("year", "yr", Day, 365.2525, system: "");
   
   /// <summary>
   /// decade defined such that: year = decade × 10.0.
   /// </summary>
   public static readonly Duration Decade = new("decade", "decade", Year, 10.0, system: "");
   
   /// <summary>
   /// century defined such that: decade = century × 10.0.
   /// </summary>
   public static readonly Duration Century = new("century", "century", Decade, 10.0, system: "");
   
   /// <summary>
   /// millennium defined such that: century = kyr × 10.0.
   /// </summary>
   public static readonly Duration Millennium = new("millennium", "kyr", Century, 10.0, system: "");
   
   /// <summary>
   /// million years defined such that: millennium = Myr × 1000.0.
   /// </summary>
   public static readonly Duration MillionYears = new("million years", "Myr", Millennium, 1000.0, system: "");
   
   /// <summary>
   /// billion years defined such that: million years = Gyr × 1000.0.
   /// </summary>
   public static readonly Duration BillionYears = new("billion years", "Gyr", MillionYears, 1000.0, system: "");
   
   /// <summary>
   /// trillion years defined such that: billion years = Tyr × 1000.0.
   /// </summary>
   public static readonly Duration TrillionYears = new("trillion years", "Tyr", BillionYears, 1000.0, system: "");
   
   /// <summary>
   /// quadrillion years defined such that: trillion years = Pyr × 1000.0.
   /// </summary>
   public static readonly Duration QuadrillionYears = new("quadrillion years", "Pyr", TrillionYears, 1000.0, system: "");
   
   /// <summary>
   /// quintillion years defined such that: quadrillion years = Eyr × 1000.0.
   /// </summary>
   public static readonly Duration QuintillionYears = new("quintillion years", "Eyr", QuadrillionYears, 1000.0, system: "");
   
   /// <summary>
   /// sextillion years defined such that: quintillion years = Zyr × 1000.0.
   /// </summary>
   public static readonly Duration SextillionYears = new("sextillion years", "Zyr", QuintillionYears, 1000.0, system: "");
   
   /// <summary>
   /// septillion years defined such that: sextillion years = Yyr × 1000.0.
   /// </summary>
   public static readonly Duration SeptillionYears = new("septillion years", "Yyr", SextillionYears, 1000.0, system: "");
   
   /// <summary>
   /// octillion years defined such that: septillion years = Ryr × 1000.0.
   /// </summary>
   public static readonly Duration OctillionYears = new("octillion years", "Ryr", SeptillionYears, 1000.0, system: "");
   
   /// <summary>
   /// nonillion years defined such that: octillion years = Qyr × 1000.0.
   /// </summary>
   public static readonly Duration NonillionYears = new("nonillion years", "Qyr", OctillionYears, 1000.0, system: "");
   
   /// <summary>
   /// decillion years defined such that: nonillion years = decillion yr × 1000.0.
   /// </summary>
   public static readonly Duration DecillionYears = new("decillion years", "decillion yr", NonillionYears, 1000.0, system: "");
   
   /// <summary>
   /// tick defined such that: nanosecond = tick × 100.0.
   /// </summary>
   public static readonly Duration Tick = new("tick", "tick", Nanosecond, 100.0, system: "");
}