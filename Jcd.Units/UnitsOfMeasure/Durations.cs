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
   public static readonly Duration Second = new ("second", "s", system: "");

   /// <summary>
   /// decisecond, defined as: second × 1.0/10.0
   /// </summary>
   public static readonly Duration Decisecond = new ("decisecond", "ds", Second, 1.0 / 10.0, system: "");

   /// <summary>
   /// centisecond, defined as: decisecond × 1.0/10.0
   /// </summary>
   public static readonly Duration Centisecond = new ("centisecond", "cs", Decisecond, 1.0 / 10.0, system: "");

   /// <summary>
   /// millisecond, defined as: centisecond × 1.0/10.0
   /// </summary>
   public static readonly Duration Millisecond = new ("millisecond", "ms", Centisecond, 1.0 / 10.0, system: "");

   /// <summary>
   /// microsecond, defined as: millisecond × 1.0/1000.0
   /// </summary>
   public static readonly Duration Microsecond = new ("microsecond", "μs", Millisecond, 1.0 / 1000.0, system: "");

   /// <summary>
   /// nanosecond, defined as: microsecond × 1.0/1000.0
   /// </summary>
   public static readonly Duration Nanosecond = new ("nanosecond", "ns", Microsecond, 1.0 / 1000.0, system: "");

   /// <summary>
   /// picosecond, defined as: nanosecond × 1.0/1000.0
   /// </summary>
   public static readonly Duration Picosecond = new ("picosecond", "ps", Nanosecond, 1.0 / 1000.0, system: "");

   /// <summary>
   /// femtosecond, defined as: picosecond × 1.0/1000.0
   /// </summary>
   public static readonly Duration Femtosecond = new ("femtosecond", "fs", Picosecond, 1.0 / 1000.0, system: "");

   /// <summary>
   /// attosecond, defined as: femtosecond × 1.0/1000.0
   /// </summary>
   public static readonly Duration Attosecond = new ("attosecond", "as", Femtosecond, 1.0 / 1000.0, system: "");

   /// <summary>
   /// zeptosecond, defined as: attosecond × 1.0/1000.0
   /// </summary>
   public static readonly Duration Zeptosecond = new ("zeptosecond", "zs", Attosecond, 1.0 / 1000.0, system: "");

   /// <summary>
   /// yoctosecond, defined as: zeptosecond × 1.0/1000.0
   /// </summary>
   public static readonly Duration Yoctosecond = new ("yoctosecond", "ys", Zeptosecond, 1.0 / 1000.0, system: "");

   /// <summary>
   /// rontosecond, defined as: yoctosecond × 1.0/1000.0
   /// </summary>
   public static readonly Duration Rontosecond = new ("rontosecond", "rs", Yoctosecond, 1.0 / 1000.0, system: "");

   /// <summary>
   /// quectosecond, defined as: rontosecond × 1.0/1000.0
   /// </summary>
   public static readonly Duration Quectosecond = new ("quectosecond", "qs", Rontosecond, 1.0 / 1000.0, system: "");

   /// <summary>
   /// minute, defined as: second × 60.0
   /// </summary>
   public static readonly Duration Minute = new ("minute", "min", Second, 60.0, system: "");

   /// <summary>
   /// hour, defined as: minute × 60.0
   /// </summary>
   public static readonly Duration Hour = new ("hour", "hr", Minute, 60.0, system: "");

   /// <summary>
   /// day, defined as: hour × 24.0
   /// </summary>
   public static readonly Duration Day = new ("day", "dy", Hour, 24.0, system: "");

   /// <summary>
   /// week, defined as: day × 7.0
   /// </summary>
   public static readonly Duration Week = new ("week", "wk", Day, 7.0, system: "");

   /// <summary>
   /// year, defined as: day × 365.2525
   /// </summary>
   public static readonly Duration Year = new ("year", "yr", Day, 365.2525, system: "");

   /// <summary>
   /// decade, defined as: year × 10.0
   /// </summary>
   public static readonly Duration Decade = new ("decade", "decade", Year, 10.0, system: "");

   /// <summary>
   /// century, defined as: decade × 10.0
   /// </summary>
   public static readonly Duration Century = new ("century", "century", Decade, 10.0, system: "");

   /// <summary>
   /// millennium, defined as: century × 10.0
   /// </summary>
   public static readonly Duration Millennium = new ("millennium", "kyr", Century, 10.0, system: "");

   /// <summary>
   /// million years, defined as: millennium × 1000.0
   /// </summary>
   public static readonly Duration MillionYears = new ("million years", "Myr", Millennium, 1000.0, system: "");

   /// <summary>
   /// billion years, defined as: million years × 1000.0
   /// </summary>
   public static readonly Duration BillionYears = new ("billion years", "Gyr", MillionYears, 1000.0, system: "");

   /// <summary>
   /// trillion years, defined as: billion years × 1000.0
   /// </summary>
   public static readonly Duration TrillionYears = new ("trillion years", "Tyr", BillionYears, 1000.0, system: "");

   /// <summary>
   /// quadrillion years, defined as: trillion years × 1000.0
   /// </summary>
   public static readonly Duration QuadrillionYears = new (
                                                           "quadrillion years"
                                                         , "Pyr"
                                                         , TrillionYears
                                                         , 1000.0
                                                         , system: ""
                                                          );

   /// <summary>
   /// quintillion years, defined as: quadrillion years × 1000.0
   /// </summary>
   public static readonly Duration QuintillionYears = new (
                                                           "quintillion years"
                                                         , "Eyr"
                                                         , QuadrillionYears
                                                         , 1000.0
                                                         , system: ""
                                                          );

   /// <summary>
   /// sextillion years, defined as: quintillion years × 1000.0
   /// </summary>
   public static readonly Duration SextillionYears = new (
                                                          "sextillion years"
                                                        , "Zyr"
                                                        , QuintillionYears
                                                        , 1000.0
                                                        , system: ""
                                                         );

   /// <summary>
   /// septillion years, defined as: sextillion years × 1000.0
   /// </summary>
   public static readonly Duration SeptillionYears = new (
                                                          "septillion years"
                                                        , "Yyr"
                                                        , SextillionYears
                                                        , 1000.0
                                                        , system: ""
                                                         );

   /// <summary>
   /// octillion years, defined as: septillion years × 1000.0
   /// </summary>
   public static readonly Duration OctillionYears = new ("octillion years", "Ryr", SeptillionYears, 1000.0, system: "");

   /// <summary>
   /// nonillion years, defined as: octillion years × 1000.0
   /// </summary>
   public static readonly Duration NonillionYears = new ("nonillion years", "Qyr", OctillionYears, 1000.0, system: "");

   /// <summary>
   /// decillion years, defined as: nonillion years × 1000.0
   /// </summary>
   public static readonly Duration DecillionYears = new (
                                                         "decillion years"
                                                       , "decillion yr"
                                                       , NonillionYears
                                                       , 1000.0
                                                       , system: ""
                                                        );

   /// <summary>
   /// tick, defined as: nanosecond × 100.0
   /// </summary>
   public static readonly Duration Tick = new ("tick", "tick", Nanosecond, 100.0, system: "");
}
