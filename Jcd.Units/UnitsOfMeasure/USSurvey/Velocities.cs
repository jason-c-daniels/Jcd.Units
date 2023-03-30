#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.USSurvey;

/// <summary>
/// United States Survey Units for measuring Velocity.
/// </summary>
public class Velocities : UnitOfMeasureEnumeration<Velocities, Velocity>
{
   /// <summary>
   /// A(n) league per century. Defined as: (4828.032)/(10.0) × SI meter per decade.
   /// </summary>
   public static readonly Velocity LeaguePerCentury = new (
                                                           "league per century"
                                                         , "lea/century"
                                                         , SI.Velocities.MeterPerDecade
                                                         , 4828.032 / 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) chain per sextillion years. Defined as: (20.1168)/(1000.0) × SI meter per quintillion years.
   /// </summary>
   public static readonly Velocity ChainPerSextillionYears = new (
                                                                  "chain per sextillion years"
                                                                , "ch/Zyr"
                                                                , SI.Velocities.MeterPerQuintillionYears
                                                                , 20.1168 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) chain per year. Defined as: (20.1168)/(365.2525) × SI meter per day.
   /// </summary>
   public static readonly Velocity ChainPerYear = new (
                                                       "chain per year"
                                                     , "ch/yr"
                                                     , SI.Velocities.MeterPerDay
                                                     , 20.1168 / 365.2525
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) rod per billion years. Defined as: (5.0292)/(1000.0) × SI meter per million years.
   /// </summary>
   public static readonly Velocity RodPerBillionYears = new (
                                                             "rod per billion years"
                                                           , "rd/Gyr"
                                                           , SI.Velocities.MeterPerMillionYears
                                                           , 5.0292 / 1000.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) rod per trillion years. Defined as: (5.0292)/(1000.0) × SI meter per billion years.
   /// </summary>
   public static readonly Velocity RodPerTrillionYears = new (
                                                              "rod per trillion years"
                                                            , "rd/Tyr"
                                                            , SI.Velocities.MeterPerBillionYears
                                                            , 5.0292 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) league per quadrillion years. Defined as: (4828.032)/(1000.0) × SI meter per trillion years.
   /// </summary>
   public static readonly Velocity LeaguePerQuadrillionYears = new (
                                                                    "league per quadrillion years"
                                                                  , "lea/Pyr"
                                                                  , SI.Velocities.MeterPerTrillionYears
                                                                  , 4828.032 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) furlong per octillion years. Defined as: (201.168)/(1000.0) × SI meter per septillion years.
   /// </summary>
   public static readonly Velocity FurlongPerOctillionYears = new (
                                                                   "furlong per octillion years"
                                                                 , "fur/Ryr"
                                                                 , SI.Velocities.MeterPerSeptillionYears
                                                                 , 201.168 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) furlong per billion years. Defined as: (201.168)/(1000.0) × SI meter per million years.
   /// </summary>
   public static readonly Velocity FurlongPerBillionYears = new (
                                                                 "furlong per billion years"
                                                               , "fur/Gyr"
                                                               , SI.Velocities.MeterPerMillionYears
                                                               , 201.168 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) chain per septillion years. Defined as: (20.1168)/(1000.0) × SI meter per sextillion years.
   /// </summary>
   public static readonly Velocity ChainPerSeptillionYears = new (
                                                                  "chain per septillion years"
                                                                , "ch/Yyr"
                                                                , SI.Velocities.MeterPerSextillionYears
                                                                , 20.1168 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) furlong per week. Defined as: (201.168)/(7.0) × SI meter per day.
   /// </summary>
   public static readonly Velocity FurlongPerWeek = new (
                                                         "furlong per week"
                                                       , "fur/wk"
                                                       , SI.Velocities.MeterPerDay
                                                       , 201.168 / 7.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) league per day. Defined as: (4828.032)/(24.0) × SI meter per hour.
   /// </summary>
   public static readonly Velocity LeaguePerDay = new (
                                                       "league per day"
                                                     , "lea/dy"
                                                     , SI.Velocities.MeterPerHour
                                                     , 4828.032 / 24.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) chain per decade. Defined as: (20.1168)/(10.0) × SI meter per year.
   /// </summary>
   public static readonly Velocity ChainPerDecade = new (
                                                         "chain per decade"
                                                       , "ch/decade"
                                                       , SI.Velocities.MeterPerYear
                                                       , 20.1168 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) rod per quadrillion years. Defined as: (5.0292)/(1000.0) × SI meter per trillion years.
   /// </summary>
   public static readonly Velocity RodPerQuadrillionYears = new (
                                                                 "rod per quadrillion years"
                                                               , "rd/Pyr"
                                                               , SI.Velocities.MeterPerTrillionYears
                                                               , 5.0292 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) league per nonillion years. Defined as: (4828.032)/(1000.0) × SI meter per octillion years.
   /// </summary>
   public static readonly Velocity LeaguePerNonillionYears = new (
                                                                  "league per nonillion years"
                                                                , "lea/Qyr"
                                                                , SI.Velocities.MeterPerOctillionYears
                                                                , 4828.032 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) rod per quintillion years. Defined as: (5.0292)/(1000.0) × SI meter per quadrillion years.
   /// </summary>
   public static readonly Velocity RodPerQuintillionYears = new (
                                                                 "rod per quintillion years"
                                                               , "rd/Eyr"
                                                               , SI.Velocities.MeterPerQuadrillionYears
                                                               , 5.0292 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) chain per tick. Defined as: (20.1168)/(100.0) × SI meter per nanosecond.
   /// </summary>
   public static readonly Velocity ChainPerTick = new (
                                                       "chain per tick"
                                                     , "ch/tick"
                                                     , SI.Velocities.MeterPerNanosecond
                                                     , 20.1168 / 100.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) league per millennium. Defined as: (4828.032)/(10.0) × SI meter per century.
   /// </summary>
   public static readonly Velocity LeaguePerMillennium = new (
                                                              "league per millennium"
                                                            , "lea/kyr"
                                                            , SI.Velocities.MeterPerCentury
                                                            , 4828.032 / 10.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per octillion years. Defined as: (20.1168)/(1000.0) × SI meter per septillion years.
   /// </summary>
   public static readonly Velocity ChainPerOctillionYears = new (
                                                                 "chain per octillion years"
                                                               , "ch/Ryr"
                                                               , SI.Velocities.MeterPerSeptillionYears
                                                               , 20.1168 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) chain per century. Defined as: (20.1168)/(10.0) × SI meter per decade.
   /// </summary>
   public static readonly Velocity ChainPerCentury = new (
                                                          "chain per century"
                                                        , "ch/century"
                                                        , SI.Velocities.MeterPerDecade
                                                        , 20.1168 / 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) rod per sextillion years. Defined as: (5.0292)/(1000.0) × SI meter per quintillion years.
   /// </summary>
   public static readonly Velocity RodPerSextillionYears = new (
                                                                "rod per sextillion years"
                                                              , "rd/Zyr"
                                                              , SI.Velocities.MeterPerQuintillionYears
                                                              , 5.0292 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per nonillion years. Defined as: (201.168)/(1000.0) × SI meter per octillion years.
   /// </summary>
   public static readonly Velocity FurlongPerNonillionYears = new (
                                                                   "furlong per nonillion years"
                                                                 , "fur/Qyr"
                                                                 , SI.Velocities.MeterPerOctillionYears
                                                                 , 201.168 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) furlong per trillion years. Defined as: (201.168)/(1000.0) × SI meter per billion years.
   /// </summary>
   public static readonly Velocity FurlongPerTrillionYears = new (
                                                                  "furlong per trillion years"
                                                                , "fur/Tyr"
                                                                , SI.Velocities.MeterPerBillionYears
                                                                , 201.168 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) furlong per year. Defined as: (201.168)/(365.2525) × SI meter per day.
   /// </summary>
   public static readonly Velocity FurlongPerYear = new (
                                                         "furlong per year"
                                                       , "fur/yr"
                                                       , SI.Velocities.MeterPerDay
                                                       , 201.168 / 365.2525
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) rod per septillion years. Defined as: (5.0292)/(1000.0) × SI meter per sextillion years.
   /// </summary>
   public static readonly Velocity RodPerSeptillionYears = new (
                                                                "rod per septillion years"
                                                              , "rd/Yyr"
                                                              , SI.Velocities.MeterPerSextillionYears
                                                              , 5.0292 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) league per quintillion years. Defined as: (4828.032)/(1000.0) × SI meter per quadrillion years.
   /// </summary>
   public static readonly Velocity LeaguePerQuintillionYears = new (
                                                                    "league per quintillion years"
                                                                  , "lea/Eyr"
                                                                  , SI.Velocities.MeterPerQuadrillionYears
                                                                  , 4828.032 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) chain per nonillion years. Defined as: (20.1168)/(1000.0) × SI meter per octillion years.
   /// </summary>
   public static readonly Velocity ChainPerNonillionYears = new (
                                                                 "chain per nonillion years"
                                                               , "ch/Qyr"
                                                               , SI.Velocities.MeterPerOctillionYears
                                                               , 20.1168 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) league per week. Defined as: (4828.032)/(7.0) × SI meter per day.
   /// </summary>
   public static readonly Velocity LeaguePerWeek = new (
                                                        "league per week"
                                                      , "lea/wk"
                                                      , SI.Velocities.MeterPerDay
                                                      , 4828.032 / 7.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) chain per millennium. Defined as: (20.1168)/(10.0) × SI meter per century.
   /// </summary>
   public static readonly Velocity ChainPerMillennium = new (
                                                             "chain per millennium"
                                                           , "ch/kyr"
                                                           , SI.Velocities.MeterPerCentury
                                                           , 20.1168 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) rod per octillion years. Defined as: (5.0292)/(1000.0) × SI meter per septillion years.
   /// </summary>
   public static readonly Velocity RodPerOctillionYears = new (
                                                               "rod per octillion years"
                                                             , "rd/Ryr"
                                                             , SI.Velocities.MeterPerSeptillionYears
                                                             , 5.0292 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per decillion years. Defined as: (4828.032)/(1000.0) × SI meter per nonillion years.
   /// </summary>
   public static readonly Velocity LeaguePerDecillionYears = new (
                                                                  "league per decillion years"
                                                                , "lea/decillion yr"
                                                                , SI.Velocities.MeterPerNonillionYears
                                                                , 4828.032 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) rod per nonillion years. Defined as: (5.0292)/(1000.0) × SI meter per octillion years.
   /// </summary>
   public static readonly Velocity RodPerNonillionYears = new (
                                                               "rod per nonillion years"
                                                             , "rd/Qyr"
                                                             , SI.Velocities.MeterPerOctillionYears
                                                             , 5.0292 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per decillion years. Defined as: (201.168)/(1000.0) × SI meter per nonillion years.
   /// </summary>
   public static readonly Velocity FurlongPerDecillionYears = new (
                                                                   "furlong per decillion years"
                                                                 , "fur/decillion yr"
                                                                 , SI.Velocities.MeterPerNonillionYears
                                                                 , 201.168 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) league per million years. Defined as: (4828.032)/(1000.0) × SI meter per millennium.
   /// </summary>
   public static readonly Velocity LeaguePerMillionYears = new (
                                                                "league per million years"
                                                              , "lea/Myr"
                                                              , SI.Velocities.MeterPerMillennium
                                                              , 4828.032 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per quadrillion years. Defined as: (201.168)/(1000.0) × SI meter per trillion years.
   /// </summary>
   public static readonly Velocity FurlongPerQuadrillionYears = new (
                                                                     "furlong per quadrillion years"
                                                                   , "fur/Pyr"
                                                                   , SI.Velocities.MeterPerTrillionYears
                                                                   , 201.168 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) chain per decillion years. Defined as: (20.1168)/(1000.0) × SI meter per nonillion years.
   /// </summary>
   public static readonly Velocity ChainPerDecillionYears = new (
                                                                 "chain per decillion years"
                                                               , "ch/decillion yr"
                                                               , SI.Velocities.MeterPerNonillionYears
                                                               , 20.1168 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) furlong per decade. Defined as: (201.168)/(10.0) × SI meter per year.
   /// </summary>
   public static readonly Velocity FurlongPerDecade = new (
                                                           "furlong per decade"
                                                         , "fur/decade"
                                                         , SI.Velocities.MeterPerYear
                                                         , 201.168 / 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) chain per million years. Defined as: (20.1168)/(1000.0) × SI meter per millennium.
   /// </summary>
   public static readonly Velocity ChainPerMillionYears = new (
                                                               "chain per million years"
                                                             , "ch/Myr"
                                                             , SI.Velocities.MeterPerMillennium
                                                             , 20.1168 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) rod per decillion years. Defined as: (5.0292)/(1000.0) × SI meter per nonillion years.
   /// </summary>
   public static readonly Velocity RodPerDecillionYears = new (
                                                               "rod per decillion years"
                                                             , "rd/decillion yr"
                                                             , SI.Velocities.MeterPerNonillionYears
                                                             , 5.0292 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) link per second. Defined as: (0.20116)/(1.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity LinkPerSecond = new (
                                                        "link per second"
                                                      , "li/s"
                                                      , SI.Velocities.MeterPerSecond
                                                      , 0.20116 / 1.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) link per decisecond. Defined as: (0.20116)/(1.0/10.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity LinkPerDecisecond = new (
                                                            "link per decisecond"
                                                          , "li/ds"
                                                          , SI.Velocities.MeterPerSecond
                                                          , 0.20116 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) link per centisecond. Defined as: (0.20116)/(1.0/10.0) × SI meter per decisecond.
   /// </summary>
   public static readonly Velocity LinkPerCentisecond = new (
                                                             "link per centisecond"
                                                           , "li/cs"
                                                           , SI.Velocities.MeterPerDecisecond
                                                           , 0.20116 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) link per millisecond. Defined as: (0.20116)/(1.0/10.0) × SI meter per centisecond.
   /// </summary>
   public static readonly Velocity LinkPerMillisecond = new (
                                                             "link per millisecond"
                                                           , "li/ms"
                                                           , SI.Velocities.MeterPerCentisecond
                                                           , 0.20116 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) link per microsecond. Defined as: (0.20116)/(1.0/1000.0) × SI meter per millisecond.
   /// </summary>
   public static readonly Velocity LinkPerMicrosecond = new (
                                                             "link per microsecond"
                                                           , "li/μs"
                                                           , SI.Velocities.MeterPerMillisecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) link per nanosecond. Defined as: (0.20116)/(1.0/1000.0) × SI meter per microsecond.
   /// </summary>
   public static readonly Velocity LinkPerNanosecond = new (
                                                            "link per nanosecond"
                                                          , "li/ns"
                                                          , SI.Velocities.MeterPerMicrosecond
                                                          , 0.20116 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) link per picosecond. Defined as: (0.20116)/(1.0/1000.0) × SI meter per nanosecond.
   /// </summary>
   public static readonly Velocity LinkPerPicosecond = new (
                                                            "link per picosecond"
                                                          , "li/ps"
                                                          , SI.Velocities.MeterPerNanosecond
                                                          , 0.20116 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) link per femtosecond. Defined as: (0.20116)/(1.0/1000.0) × SI meter per picosecond.
   /// </summary>
   public static readonly Velocity LinkPerFemtosecond = new (
                                                             "link per femtosecond"
                                                           , "li/fs"
                                                           , SI.Velocities.MeterPerPicosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) link per attosecond. Defined as: (0.20116)/(1.0/1000.0) × SI meter per femtosecond.
   /// </summary>
   public static readonly Velocity LinkPerAttosecond = new (
                                                            "link per attosecond"
                                                          , "li/as"
                                                          , SI.Velocities.MeterPerFemtosecond
                                                          , 0.20116 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) link per zeptosecond. Defined as: (0.20116)/(1.0/1000.0) × SI meter per attosecond.
   /// </summary>
   public static readonly Velocity LinkPerZeptosecond = new (
                                                             "link per zeptosecond"
                                                           , "li/zs"
                                                           , SI.Velocities.MeterPerAttosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) link per yoctosecond. Defined as: (0.20116)/(1.0/1000.0) × SI meter per zeptosecond.
   /// </summary>
   public static readonly Velocity LinkPerYoctosecond = new (
                                                             "link per yoctosecond"
                                                           , "li/ys"
                                                           , SI.Velocities.MeterPerZeptosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) link per rontosecond. Defined as: (0.20116)/(1.0/1000.0) × SI meter per yoctosecond.
   /// </summary>
   public static readonly Velocity LinkPerRontosecond = new (
                                                             "link per rontosecond"
                                                           , "li/rs"
                                                           , SI.Velocities.MeterPerYoctosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) link per quectosecond. Defined as: (0.20116)/(1.0/1000.0) × SI meter per rontosecond.
   /// </summary>
   public static readonly Velocity LinkPerQuectosecond = new (
                                                              "link per quectosecond"
                                                            , "li/qs"
                                                            , SI.Velocities.MeterPerRontosecond
                                                            , 0.20116 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) link per minute. Defined as: (0.20116)/(60.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity LinkPerMinute = new (
                                                        "link per minute"
                                                      , "li/min"
                                                      , SI.Velocities.MeterPerSecond
                                                      , 0.20116 / 60.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) rod per second. Defined as: (5.0292)/(1.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity RodPerSecond = new (
                                                       "rod per second"
                                                     , "rd/s"
                                                     , SI.Velocities.MeterPerSecond
                                                     , 5.0292 / 1.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) rod per decisecond. Defined as: (5.0292)/(1.0/10.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity RodPerDecisecond = new (
                                                           "rod per decisecond"
                                                         , "rd/ds"
                                                         , SI.Velocities.MeterPerSecond
                                                         , 5.0292 / (1.0 / 10.0)
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) rod per centisecond. Defined as: (5.0292)/(1.0/10.0) × SI meter per decisecond.
   /// </summary>
   public static readonly Velocity RodPerCentisecond = new (
                                                            "rod per centisecond"
                                                          , "rd/cs"
                                                          , SI.Velocities.MeterPerDecisecond
                                                          , 5.0292 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) rod per millisecond. Defined as: (5.0292)/(1.0/10.0) × SI meter per centisecond.
   /// </summary>
   public static readonly Velocity RodPerMillisecond = new (
                                                            "rod per millisecond"
                                                          , "rd/ms"
                                                          , SI.Velocities.MeterPerCentisecond
                                                          , 5.0292 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) rod per microsecond. Defined as: (5.0292)/(1.0/1000.0) × SI meter per millisecond.
   /// </summary>
   public static readonly Velocity RodPerMicrosecond = new (
                                                            "rod per microsecond"
                                                          , "rd/μs"
                                                          , SI.Velocities.MeterPerMillisecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) rod per nanosecond. Defined as: (5.0292)/(1.0/1000.0) × SI meter per microsecond.
   /// </summary>
   public static readonly Velocity RodPerNanosecond = new (
                                                           "rod per nanosecond"
                                                         , "rd/ns"
                                                         , SI.Velocities.MeterPerMicrosecond
                                                         , 5.0292 / (1.0 / 1000.0)
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) rod per picosecond. Defined as: (5.0292)/(1.0/1000.0) × SI meter per nanosecond.
   /// </summary>
   public static readonly Velocity RodPerPicosecond = new (
                                                           "rod per picosecond"
                                                         , "rd/ps"
                                                         , SI.Velocities.MeterPerNanosecond
                                                         , 5.0292 / (1.0 / 1000.0)
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) rod per femtosecond. Defined as: (5.0292)/(1.0/1000.0) × SI meter per picosecond.
   /// </summary>
   public static readonly Velocity RodPerFemtosecond = new (
                                                            "rod per femtosecond"
                                                          , "rd/fs"
                                                          , SI.Velocities.MeterPerPicosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) rod per attosecond. Defined as: (5.0292)/(1.0/1000.0) × SI meter per femtosecond.
   /// </summary>
   public static readonly Velocity RodPerAttosecond = new (
                                                           "rod per attosecond"
                                                         , "rd/as"
                                                         , SI.Velocities.MeterPerFemtosecond
                                                         , 5.0292 / (1.0 / 1000.0)
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) rod per zeptosecond. Defined as: (5.0292)/(1.0/1000.0) × SI meter per attosecond.
   /// </summary>
   public static readonly Velocity RodPerZeptosecond = new (
                                                            "rod per zeptosecond"
                                                          , "rd/zs"
                                                          , SI.Velocities.MeterPerAttosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) rod per yoctosecond. Defined as: (5.0292)/(1.0/1000.0) × SI meter per zeptosecond.
   /// </summary>
   public static readonly Velocity RodPerYoctosecond = new (
                                                            "rod per yoctosecond"
                                                          , "rd/ys"
                                                          , SI.Velocities.MeterPerZeptosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) rod per rontosecond. Defined as: (5.0292)/(1.0/1000.0) × SI meter per yoctosecond.
   /// </summary>
   public static readonly Velocity RodPerRontosecond = new (
                                                            "rod per rontosecond"
                                                          , "rd/rs"
                                                          , SI.Velocities.MeterPerYoctosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) rod per quectosecond. Defined as: (5.0292)/(1.0/1000.0) × SI meter per rontosecond.
   /// </summary>
   public static readonly Velocity RodPerQuectosecond = new (
                                                             "rod per quectosecond"
                                                           , "rd/qs"
                                                           , SI.Velocities.MeterPerRontosecond
                                                           , 5.0292 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) link per hour. Defined as: (0.20116)/(60.0) × SI meter per minute.
   /// </summary>
   public static readonly Velocity LinkPerHour = new (
                                                      "link per hour"
                                                    , "li/hr"
                                                    , SI.Velocities.MeterPerMinute
                                                    , 0.20116 / 60.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) chain per second. Defined as: (20.1168)/(1.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity ChainPerSecond = new (
                                                         "chain per second"
                                                       , "ch/s"
                                                       , SI.Velocities.MeterPerSecond
                                                       , 20.1168 / 1.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) chain per decisecond. Defined as: (20.1168)/(1.0/10.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity ChainPerDecisecond = new (
                                                             "chain per decisecond"
                                                           , "ch/ds"
                                                           , SI.Velocities.MeterPerSecond
                                                           , 20.1168 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) chain per centisecond. Defined as: (20.1168)/(1.0/10.0) × SI meter per decisecond.
   /// </summary>
   public static readonly Velocity ChainPerCentisecond = new (
                                                              "chain per centisecond"
                                                            , "ch/cs"
                                                            , SI.Velocities.MeterPerDecisecond
                                                            , 20.1168 / (1.0 / 10.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per millisecond. Defined as: (20.1168)/(1.0/10.0) × SI meter per centisecond.
   /// </summary>
   public static readonly Velocity ChainPerMillisecond = new (
                                                              "chain per millisecond"
                                                            , "ch/ms"
                                                            , SI.Velocities.MeterPerCentisecond
                                                            , 20.1168 / (1.0 / 10.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per microsecond. Defined as: (20.1168)/(1.0/1000.0) × SI meter per millisecond.
   /// </summary>
   public static readonly Velocity ChainPerMicrosecond = new (
                                                              "chain per microsecond"
                                                            , "ch/μs"
                                                            , SI.Velocities.MeterPerMillisecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per nanosecond. Defined as: (20.1168)/(1.0/1000.0) × SI meter per microsecond.
   /// </summary>
   public static readonly Velocity ChainPerNanosecond = new (
                                                             "chain per nanosecond"
                                                           , "ch/ns"
                                                           , SI.Velocities.MeterPerMicrosecond
                                                           , 20.1168 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) chain per picosecond. Defined as: (20.1168)/(1.0/1000.0) × SI meter per nanosecond.
   /// </summary>
   public static readonly Velocity ChainPerPicosecond = new (
                                                             "chain per picosecond"
                                                           , "ch/ps"
                                                           , SI.Velocities.MeterPerNanosecond
                                                           , 20.1168 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) chain per femtosecond. Defined as: (20.1168)/(1.0/1000.0) × SI meter per picosecond.
   /// </summary>
   public static readonly Velocity ChainPerFemtosecond = new (
                                                              "chain per femtosecond"
                                                            , "ch/fs"
                                                            , SI.Velocities.MeterPerPicosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per attosecond. Defined as: (20.1168)/(1.0/1000.0) × SI meter per femtosecond.
   /// </summary>
   public static readonly Velocity ChainPerAttosecond = new (
                                                             "chain per attosecond"
                                                           , "ch/as"
                                                           , SI.Velocities.MeterPerFemtosecond
                                                           , 20.1168 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) chain per zeptosecond. Defined as: (20.1168)/(1.0/1000.0) × SI meter per attosecond.
   /// </summary>
   public static readonly Velocity ChainPerZeptosecond = new (
                                                              "chain per zeptosecond"
                                                            , "ch/zs"
                                                            , SI.Velocities.MeterPerAttosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per yoctosecond. Defined as: (20.1168)/(1.0/1000.0) × SI meter per zeptosecond.
   /// </summary>
   public static readonly Velocity ChainPerYoctosecond = new (
                                                              "chain per yoctosecond"
                                                            , "ch/ys"
                                                            , SI.Velocities.MeterPerZeptosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per rontosecond. Defined as: (20.1168)/(1.0/1000.0) × SI meter per yoctosecond.
   /// </summary>
   public static readonly Velocity ChainPerRontosecond = new (
                                                              "chain per rontosecond"
                                                            , "ch/rs"
                                                            , SI.Velocities.MeterPerYoctosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per quectosecond. Defined as: (20.1168)/(1.0/1000.0) × SI meter per rontosecond.
   /// </summary>
   public static readonly Velocity ChainPerQuectosecond = new (
                                                               "chain per quectosecond"
                                                             , "ch/qs"
                                                             , SI.Velocities.MeterPerRontosecond
                                                             , 20.1168 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) link per day. Defined as: (0.20116)/(24.0) × SI meter per hour.
   /// </summary>
   public static readonly Velocity LinkPerDay = new (
                                                     "link per day"
                                                   , "li/dy"
                                                   , SI.Velocities.MeterPerHour
                                                   , 0.20116 / 24.0
                                                   , 0
                                                    );

   /// <summary>
   /// A(n) furlong per second. Defined as: (201.168)/(1.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity FurlongPerSecond = new (
                                                           "furlong per second"
                                                         , "fur/s"
                                                         , SI.Velocities.MeterPerSecond
                                                         , 201.168 / 1.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) furlong per decisecond. Defined as: (201.168)/(1.0/10.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity FurlongPerDecisecond = new (
                                                               "furlong per decisecond"
                                                             , "fur/ds"
                                                             , SI.Velocities.MeterPerSecond
                                                             , 201.168 / (1.0 / 10.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per centisecond. Defined as: (201.168)/(1.0/10.0) × SI meter per decisecond.
   /// </summary>
   public static readonly Velocity FurlongPerCentisecond = new (
                                                                "furlong per centisecond"
                                                              , "fur/cs"
                                                              , SI.Velocities.MeterPerDecisecond
                                                              , 201.168 / (1.0 / 10.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per millisecond. Defined as: (201.168)/(1.0/10.0) × SI meter per centisecond.
   /// </summary>
   public static readonly Velocity FurlongPerMillisecond = new (
                                                                "furlong per millisecond"
                                                              , "fur/ms"
                                                              , SI.Velocities.MeterPerCentisecond
                                                              , 201.168 / (1.0 / 10.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per microsecond. Defined as: (201.168)/(1.0/1000.0) × SI meter per millisecond.
   /// </summary>
   public static readonly Velocity FurlongPerMicrosecond = new (
                                                                "furlong per microsecond"
                                                              , "fur/μs"
                                                              , SI.Velocities.MeterPerMillisecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per nanosecond. Defined as: (201.168)/(1.0/1000.0) × SI meter per microsecond.
   /// </summary>
   public static readonly Velocity FurlongPerNanosecond = new (
                                                               "furlong per nanosecond"
                                                             , "fur/ns"
                                                             , SI.Velocities.MeterPerMicrosecond
                                                             , 201.168 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per picosecond. Defined as: (201.168)/(1.0/1000.0) × SI meter per nanosecond.
   /// </summary>
   public static readonly Velocity FurlongPerPicosecond = new (
                                                               "furlong per picosecond"
                                                             , "fur/ps"
                                                             , SI.Velocities.MeterPerNanosecond
                                                             , 201.168 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per femtosecond. Defined as: (201.168)/(1.0/1000.0) × SI meter per picosecond.
   /// </summary>
   public static readonly Velocity FurlongPerFemtosecond = new (
                                                                "furlong per femtosecond"
                                                              , "fur/fs"
                                                              , SI.Velocities.MeterPerPicosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per attosecond. Defined as: (201.168)/(1.0/1000.0) × SI meter per femtosecond.
   /// </summary>
   public static readonly Velocity FurlongPerAttosecond = new (
                                                               "furlong per attosecond"
                                                             , "fur/as"
                                                             , SI.Velocities.MeterPerFemtosecond
                                                             , 201.168 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per zeptosecond. Defined as: (201.168)/(1.0/1000.0) × SI meter per attosecond.
   /// </summary>
   public static readonly Velocity FurlongPerZeptosecond = new (
                                                                "furlong per zeptosecond"
                                                              , "fur/zs"
                                                              , SI.Velocities.MeterPerAttosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per yoctosecond. Defined as: (201.168)/(1.0/1000.0) × SI meter per zeptosecond.
   /// </summary>
   public static readonly Velocity FurlongPerYoctosecond = new (
                                                                "furlong per yoctosecond"
                                                              , "fur/ys"
                                                              , SI.Velocities.MeterPerZeptosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per rontosecond. Defined as: (201.168)/(1.0/1000.0) × SI meter per yoctosecond.
   /// </summary>
   public static readonly Velocity FurlongPerRontosecond = new (
                                                                "furlong per rontosecond"
                                                              , "fur/rs"
                                                              , SI.Velocities.MeterPerYoctosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per quectosecond. Defined as: (201.168)/(1.0/1000.0) × SI meter per rontosecond.
   /// </summary>
   public static readonly Velocity FurlongPerQuectosecond = new (
                                                                 "furlong per quectosecond"
                                                               , "fur/qs"
                                                               , SI.Velocities.MeterPerRontosecond
                                                               , 201.168 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) link per week. Defined as: (0.20116)/(7.0) × SI meter per day.
   /// </summary>
   public static readonly Velocity LinkPerWeek = new (
                                                      "link per week"
                                                    , "li/wk"
                                                    , SI.Velocities.MeterPerDay
                                                    , 0.20116 / 7.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) league per second. Defined as: (4828.032)/(1.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity LeaguePerSecond = new (
                                                          "league per second"
                                                        , "lea/s"
                                                        , SI.Velocities.MeterPerSecond
                                                        , 4828.032 / 1.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) league per decisecond. Defined as: (4828.032)/(1.0/10.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity LeaguePerDecisecond = new (
                                                              "league per decisecond"
                                                            , "lea/ds"
                                                            , SI.Velocities.MeterPerSecond
                                                            , 4828.032 / (1.0 / 10.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) league per centisecond. Defined as: (4828.032)/(1.0/10.0) × SI meter per decisecond.
   /// </summary>
   public static readonly Velocity LeaguePerCentisecond = new (
                                                               "league per centisecond"
                                                             , "lea/cs"
                                                             , SI.Velocities.MeterPerDecisecond
                                                             , 4828.032 / (1.0 / 10.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per millisecond. Defined as: (4828.032)/(1.0/10.0) × SI meter per centisecond.
   /// </summary>
   public static readonly Velocity LeaguePerMillisecond = new (
                                                               "league per millisecond"
                                                             , "lea/ms"
                                                             , SI.Velocities.MeterPerCentisecond
                                                             , 4828.032 / (1.0 / 10.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per microsecond. Defined as: (4828.032)/(1.0/1000.0) × SI meter per millisecond.
   /// </summary>
   public static readonly Velocity LeaguePerMicrosecond = new (
                                                               "league per microsecond"
                                                             , "lea/μs"
                                                             , SI.Velocities.MeterPerMillisecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per nanosecond. Defined as: (4828.032)/(1.0/1000.0) × SI meter per microsecond.
   /// </summary>
   public static readonly Velocity LeaguePerNanosecond = new (
                                                              "league per nanosecond"
                                                            , "lea/ns"
                                                            , SI.Velocities.MeterPerMicrosecond
                                                            , 4828.032 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) league per picosecond. Defined as: (4828.032)/(1.0/1000.0) × SI meter per nanosecond.
   /// </summary>
   public static readonly Velocity LeaguePerPicosecond = new (
                                                              "league per picosecond"
                                                            , "lea/ps"
                                                            , SI.Velocities.MeterPerNanosecond
                                                            , 4828.032 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) league per femtosecond. Defined as: (4828.032)/(1.0/1000.0) × SI meter per picosecond.
   /// </summary>
   public static readonly Velocity LeaguePerFemtosecond = new (
                                                               "league per femtosecond"
                                                             , "lea/fs"
                                                             , SI.Velocities.MeterPerPicosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per attosecond. Defined as: (4828.032)/(1.0/1000.0) × SI meter per femtosecond.
   /// </summary>
   public static readonly Velocity LeaguePerAttosecond = new (
                                                              "league per attosecond"
                                                            , "lea/as"
                                                            , SI.Velocities.MeterPerFemtosecond
                                                            , 4828.032 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) league per zeptosecond. Defined as: (4828.032)/(1.0/1000.0) × SI meter per attosecond.
   /// </summary>
   public static readonly Velocity LeaguePerZeptosecond = new (
                                                               "league per zeptosecond"
                                                             , "lea/zs"
                                                             , SI.Velocities.MeterPerAttosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per yoctosecond. Defined as: (4828.032)/(1.0/1000.0) × SI meter per zeptosecond.
   /// </summary>
   public static readonly Velocity LeaguePerYoctosecond = new (
                                                               "league per yoctosecond"
                                                             , "lea/ys"
                                                             , SI.Velocities.MeterPerZeptosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per rontosecond. Defined as: (4828.032)/(1.0/1000.0) × SI meter per yoctosecond.
   /// </summary>
   public static readonly Velocity LeaguePerRontosecond = new (
                                                               "league per rontosecond"
                                                             , "lea/rs"
                                                             , SI.Velocities.MeterPerYoctosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per quectosecond. Defined as: (4828.032)/(1.0/1000.0) × SI meter per rontosecond.
   /// </summary>
   public static readonly Velocity LeaguePerQuectosecond = new (
                                                                "league per quectosecond"
                                                              , "lea/qs"
                                                              , SI.Velocities.MeterPerRontosecond
                                                              , 4828.032 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) link per year. Defined as: (0.20116)/(365.2525) × SI meter per day.
   /// </summary>
   public static readonly Velocity LinkPerYear = new (
                                                      "link per year"
                                                    , "li/yr"
                                                    , SI.Velocities.MeterPerDay
                                                    , 0.20116 / 365.2525
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) link per decade. Defined as: (0.20116)/(10.0) × SI meter per year.
   /// </summary>
   public static readonly Velocity LinkPerDecade = new (
                                                        "link per decade"
                                                      , "li/decade"
                                                      , SI.Velocities.MeterPerYear
                                                      , 0.20116 / 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) link per century. Defined as: (0.20116)/(10.0) × SI meter per decade.
   /// </summary>
   public static readonly Velocity LinkPerCentury = new (
                                                         "link per century"
                                                       , "li/century"
                                                       , SI.Velocities.MeterPerDecade
                                                       , 0.20116 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) link per millennium. Defined as: (0.20116)/(10.0) × SI meter per century.
   /// </summary>
   public static readonly Velocity LinkPerMillennium = new (
                                                            "link per millennium"
                                                          , "li/kyr"
                                                          , SI.Velocities.MeterPerCentury
                                                          , 0.20116 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) link per million years. Defined as: (0.20116)/(1000.0) × SI meter per millennium.
   /// </summary>
   public static readonly Velocity LinkPerMillionYears = new (
                                                              "link per million years"
                                                            , "li/Myr"
                                                            , SI.Velocities.MeterPerMillennium
                                                            , 0.20116 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) link per billion years. Defined as: (0.20116)/(1000.0) × SI meter per million years.
   /// </summary>
   public static readonly Velocity LinkPerBillionYears = new (
                                                              "link per billion years"
                                                            , "li/Gyr"
                                                            , SI.Velocities.MeterPerMillionYears
                                                            , 0.20116 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) link per trillion years. Defined as: (0.20116)/(1000.0) × SI meter per billion years.
   /// </summary>
   public static readonly Velocity LinkPerTrillionYears = new (
                                                               "link per trillion years"
                                                             , "li/Tyr"
                                                             , SI.Velocities.MeterPerBillionYears
                                                             , 0.20116 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) link per quadrillion years. Defined as: (0.20116)/(1000.0) × SI meter per trillion years.
   /// </summary>
   public static readonly Velocity LinkPerQuadrillionYears = new (
                                                                  "link per quadrillion years"
                                                                , "li/Pyr"
                                                                , SI.Velocities.MeterPerTrillionYears
                                                                , 0.20116 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) link per quintillion years. Defined as: (0.20116)/(1000.0) × SI meter per quadrillion years.
   /// </summary>
   public static readonly Velocity LinkPerQuintillionYears = new (
                                                                  "link per quintillion years"
                                                                , "li/Eyr"
                                                                , SI.Velocities.MeterPerQuadrillionYears
                                                                , 0.20116 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) link per sextillion years. Defined as: (0.20116)/(1000.0) × SI meter per quintillion years.
   /// </summary>
   public static readonly Velocity LinkPerSextillionYears = new (
                                                                 "link per sextillion years"
                                                               , "li/Zyr"
                                                               , SI.Velocities.MeterPerQuintillionYears
                                                               , 0.20116 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) link per septillion years. Defined as: (0.20116)/(1000.0) × SI meter per sextillion years.
   /// </summary>
   public static readonly Velocity LinkPerSeptillionYears = new (
                                                                 "link per septillion years"
                                                               , "li/Yyr"
                                                               , SI.Velocities.MeterPerSextillionYears
                                                               , 0.20116 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) link per octillion years. Defined as: (0.20116)/(1000.0) × SI meter per septillion years.
   /// </summary>
   public static readonly Velocity LinkPerOctillionYears = new (
                                                                "link per octillion years"
                                                              , "li/Ryr"
                                                              , SI.Velocities.MeterPerSeptillionYears
                                                              , 0.20116 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) link per nonillion years. Defined as: (0.20116)/(1000.0) × SI meter per octillion years.
   /// </summary>
   public static readonly Velocity LinkPerNonillionYears = new (
                                                                "link per nonillion years"
                                                              , "li/Qyr"
                                                              , SI.Velocities.MeterPerOctillionYears
                                                              , 0.20116 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) link per decillion years. Defined as: (0.20116)/(1000.0) × SI meter per nonillion years.
   /// </summary>
   public static readonly Velocity LinkPerDecillionYears = new (
                                                                "link per decillion years"
                                                              , "li/decillion yr"
                                                              , SI.Velocities.MeterPerNonillionYears
                                                              , 0.20116 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) link per planck-time. Defined as: (0.20116)/(5.391247E-38) × SI meter per microsecond.
   /// </summary>
   public static readonly Velocity LinkPerPlanckTime = new (
                                                            "link per planck-time"
                                                          , "li/tₚ"
                                                          , SI.Velocities.MeterPerMicrosecond
                                                          , 0.20116 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) link per tick. Defined as: (0.20116)/(100.0) × SI meter per nanosecond.
   /// </summary>
   public static readonly Velocity LinkPerTick = new (
                                                      "link per tick"
                                                    , "li/tick"
                                                    , SI.Velocities.MeterPerNanosecond
                                                    , 0.20116 / 100.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) rod per planck-time. Defined as: (5.0292)/(5.391247E-38) × SI meter per microsecond.
   /// </summary>
   public static readonly Velocity RodPerPlanckTime = new (
                                                           "rod per planck-time"
                                                         , "rd/tₚ"
                                                         , SI.Velocities.MeterPerMicrosecond
                                                         , 5.0292 / 5.391247E-38
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) league per sextillion years. Defined as: (4828.032)/(1000.0) × SI meter per quintillion years.
   /// </summary>
   public static readonly Velocity LeaguePerSextillionYears = new (
                                                                   "league per sextillion years"
                                                                 , "lea/Zyr"
                                                                 , SI.Velocities.MeterPerQuintillionYears
                                                                 , 4828.032 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rod per minute. Defined as: (5.0292)/(60.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity RodPerMinute = new (
                                                       "rod per minute"
                                                     , "rd/min"
                                                     , SI.Velocities.MeterPerSecond
                                                     , 5.0292 / 60.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) chain per planck-time. Defined as: (20.1168)/(5.391247E-38) × SI meter per microsecond.
   /// </summary>
   public static readonly Velocity ChainPerPlanckTime = new (
                                                             "chain per planck-time"
                                                           , "ch/tₚ"
                                                           , SI.Velocities.MeterPerMicrosecond
                                                           , 20.1168 / 5.391247E-38
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) furlong per tick. Defined as: (201.168)/(100.0) × SI meter per nanosecond.
   /// </summary>
   public static readonly Velocity FurlongPerTick = new (
                                                         "furlong per tick"
                                                       , "fur/tick"
                                                       , SI.Velocities.MeterPerNanosecond
                                                       , 201.168 / 100.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) league per year. Defined as: (4828.032)/(365.2525) × SI meter per day.
   /// </summary>
   public static readonly Velocity LeaguePerYear = new (
                                                        "league per year"
                                                      , "lea/yr"
                                                      , SI.Velocities.MeterPerDay
                                                      , 4828.032 / 365.2525
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) chain per billion years. Defined as: (20.1168)/(1000.0) × SI meter per million years.
   /// </summary>
   public static readonly Velocity ChainPerBillionYears = new (
                                                               "chain per billion years"
                                                             , "ch/Gyr"
                                                             , SI.Velocities.MeterPerMillionYears
                                                             , 20.1168 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per planck-time. Defined as: (201.168)/(5.391247E-38) × SI meter per microsecond.
   /// </summary>
   public static readonly Velocity FurlongPerPlanckTime = new (
                                                               "furlong per planck-time"
                                                             , "fur/tₚ"
                                                             , SI.Velocities.MeterPerMicrosecond
                                                             , 201.168 / 5.391247E-38
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) rod per hour. Defined as: (5.0292)/(60.0) × SI meter per minute.
   /// </summary>
   public static readonly Velocity RodPerHour = new (
                                                     "rod per hour"
                                                   , "rd/hr"
                                                   , SI.Velocities.MeterPerMinute
                                                   , 5.0292 / 60.0
                                                   , 0
                                                    );

   /// <summary>
   /// A(n) chain per minute. Defined as: (20.1168)/(60.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity ChainPerMinute = new (
                                                         "chain per minute"
                                                       , "ch/min"
                                                       , SI.Velocities.MeterPerSecond
                                                       , 20.1168 / 60.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) furlong per quintillion years. Defined as: (201.168)/(1000.0) × SI meter per quadrillion years.
   /// </summary>
   public static readonly Velocity FurlongPerQuintillionYears = new (
                                                                     "furlong per quintillion years"
                                                                   , "fur/Eyr"
                                                                   , SI.Velocities.MeterPerQuadrillionYears
                                                                   , 201.168 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) league per planck-time. Defined as: (4828.032)/(5.391247E-38) × SI meter per microsecond.
   /// </summary>
   public static readonly Velocity LeaguePerPlanckTime = new (
                                                              "league per planck-time"
                                                            , "lea/tₚ"
                                                            , SI.Velocities.MeterPerMicrosecond
                                                            , 4828.032 / 5.391247E-38
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) furlong per century. Defined as: (201.168)/(10.0) × SI meter per decade.
   /// </summary>
   public static readonly Velocity FurlongPerCentury = new (
                                                            "furlong per century"
                                                          , "fur/century"
                                                          , SI.Velocities.MeterPerDecade
                                                          , 201.168 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) rod per day. Defined as: (5.0292)/(24.0) × SI meter per hour.
   /// </summary>
   public static readonly Velocity RodPerDay = new (
                                                    "rod per day"
                                                  , "rd/dy"
                                                  , SI.Velocities.MeterPerHour
                                                  , 5.0292 / 24.0
                                                  , 0
                                                   );

   /// <summary>
   /// A(n) furlong per minute. Defined as: (201.168)/(60.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity FurlongPerMinute = new (
                                                           "furlong per minute"
                                                         , "fur/min"
                                                         , SI.Velocities.MeterPerSecond
                                                         , 201.168 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) league per billion years. Defined as: (4828.032)/(1000.0) × SI meter per million years.
   /// </summary>
   public static readonly Velocity LeaguePerBillionYears = new (
                                                                "league per billion years"
                                                              , "lea/Gyr"
                                                              , SI.Velocities.MeterPerMillionYears
                                                              , 4828.032 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) chain per trillion years. Defined as: (20.1168)/(1000.0) × SI meter per billion years.
   /// </summary>
   public static readonly Velocity ChainPerTrillionYears = new (
                                                                "chain per trillion years"
                                                              , "ch/Tyr"
                                                              , SI.Velocities.MeterPerBillionYears
                                                              , 20.1168 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) chain per hour. Defined as: (20.1168)/(60.0) × SI meter per minute.
   /// </summary>
   public static readonly Velocity ChainPerHour = new (
                                                       "chain per hour"
                                                     , "ch/hr"
                                                     , SI.Velocities.MeterPerMinute
                                                     , 20.1168 / 60.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) rod per week. Defined as: (5.0292)/(7.0) × SI meter per day.
   /// </summary>
   public static readonly Velocity RodPerWeek = new (
                                                     "rod per week"
                                                   , "rd/wk"
                                                   , SI.Velocities.MeterPerDay
                                                   , 5.0292 / 7.0
                                                   , 0
                                                    );

   /// <summary>
   /// A(n) league per minute. Defined as: (4828.032)/(60.0) × SI meter per second.
   /// </summary>
   public static readonly Velocity LeaguePerMinute = new (
                                                          "league per minute"
                                                        , "lea/min"
                                                        , SI.Velocities.MeterPerSecond
                                                        , 4828.032 / 60.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) league per septillion years. Defined as: (4828.032)/(1000.0) × SI meter per sextillion years.
   /// </summary>
   public static readonly Velocity LeaguePerSeptillionYears = new (
                                                                   "league per septillion years"
                                                                 , "lea/Yyr"
                                                                 , SI.Velocities.MeterPerSextillionYears
                                                                 , 4828.032 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rod per year. Defined as: (5.0292)/(365.2525) × SI meter per day.
   /// </summary>
   public static readonly Velocity RodPerYear = new (
                                                     "rod per year"
                                                   , "rd/yr"
                                                   , SI.Velocities.MeterPerDay
                                                   , 5.0292 / 365.2525
                                                   , 0
                                                    );

   /// <summary>
   /// A(n) furlong per sextillion years. Defined as: (201.168)/(1000.0) × SI meter per quintillion years.
   /// </summary>
   public static readonly Velocity FurlongPerSextillionYears = new (
                                                                    "furlong per sextillion years"
                                                                  , "fur/Zyr"
                                                                  , SI.Velocities.MeterPerQuintillionYears
                                                                  , 201.168 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) league per decade. Defined as: (4828.032)/(10.0) × SI meter per year.
   /// </summary>
   public static readonly Velocity LeaguePerDecade = new (
                                                          "league per decade"
                                                        , "lea/decade"
                                                        , SI.Velocities.MeterPerYear
                                                        , 4828.032 / 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) furlong per millennium. Defined as: (201.168)/(10.0) × SI meter per century.
   /// </summary>
   public static readonly Velocity FurlongPerMillennium = new (
                                                               "furlong per millennium"
                                                             , "fur/kyr"
                                                             , SI.Velocities.MeterPerCentury
                                                             , 201.168 / 10.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) chain per quadrillion years. Defined as: (20.1168)/(1000.0) × SI meter per trillion years.
   /// </summary>
   public static readonly Velocity ChainPerQuadrillionYears = new (
                                                                   "chain per quadrillion years"
                                                                 , "ch/Pyr"
                                                                 , SI.Velocities.MeterPerTrillionYears
                                                                 , 20.1168 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) chain per day. Defined as: (20.1168)/(24.0) × SI meter per hour.
   /// </summary>
   public static readonly Velocity ChainPerDay = new (
                                                      "chain per day"
                                                    , "ch/dy"
                                                    , SI.Velocities.MeterPerHour
                                                    , 20.1168 / 24.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) furlong per hour. Defined as: (201.168)/(60.0) × SI meter per minute.
   /// </summary>
   public static readonly Velocity FurlongPerHour = new (
                                                         "furlong per hour"
                                                       , "fur/hr"
                                                       , SI.Velocities.MeterPerMinute
                                                       , 201.168 / 60.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) rod per decade. Defined as: (5.0292)/(10.0) × SI meter per year.
   /// </summary>
   public static readonly Velocity RodPerDecade = new (
                                                       "rod per decade"
                                                     , "rd/decade"
                                                     , SI.Velocities.MeterPerYear
                                                     , 5.0292 / 10.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) rod per tick. Defined as: (5.0292)/(100.0) × SI meter per nanosecond.
   /// </summary>
   public static readonly Velocity RodPerTick = new (
                                                     "rod per tick"
                                                   , "rd/tick"
                                                   , SI.Velocities.MeterPerNanosecond
                                                   , 5.0292 / 100.0
                                                   , 0
                                                    );

   /// <summary>
   /// A(n) rod per century. Defined as: (5.0292)/(10.0) × SI meter per decade.
   /// </summary>
   public static readonly Velocity RodPerCentury = new (
                                                        "rod per century"
                                                      , "rd/century"
                                                      , SI.Velocities.MeterPerDecade
                                                      , 5.0292 / 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) league per trillion years. Defined as: (4828.032)/(1000.0) × SI meter per billion years.
   /// </summary>
   public static readonly Velocity LeaguePerTrillionYears = new (
                                                                 "league per trillion years"
                                                               , "lea/Tyr"
                                                               , SI.Velocities.MeterPerBillionYears
                                                               , 4828.032 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) chain per quintillion years. Defined as: (20.1168)/(1000.0) × SI meter per quadrillion years.
   /// </summary>
   public static readonly Velocity ChainPerQuintillionYears = new (
                                                                   "chain per quintillion years"
                                                                 , "ch/Eyr"
                                                                 , SI.Velocities.MeterPerQuadrillionYears
                                                                 , 20.1168 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) league per tick. Defined as: (4828.032)/(100.0) × SI meter per nanosecond.
   /// </summary>
   public static readonly Velocity LeaguePerTick = new (
                                                        "league per tick"
                                                      , "lea/tick"
                                                      , SI.Velocities.MeterPerNanosecond
                                                      , 4828.032 / 100.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) chain per week. Defined as: (20.1168)/(7.0) × SI meter per day.
   /// </summary>
   public static readonly Velocity ChainPerWeek = new (
                                                       "chain per week"
                                                     , "ch/wk"
                                                     , SI.Velocities.MeterPerDay
                                                     , 20.1168 / 7.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) league per hour. Defined as: (4828.032)/(60.0) × SI meter per minute.
   /// </summary>
   public static readonly Velocity LeaguePerHour = new (
                                                        "league per hour"
                                                      , "lea/hr"
                                                      , SI.Velocities.MeterPerMinute
                                                      , 4828.032 / 60.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) rod per millennium. Defined as: (5.0292)/(10.0) × SI meter per century.
   /// </summary>
   public static readonly Velocity RodPerMillennium = new (
                                                           "rod per millennium"
                                                         , "rd/kyr"
                                                         , SI.Velocities.MeterPerCentury
                                                         , 5.0292 / 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) furlong per septillion years. Defined as: (201.168)/(1000.0) × SI meter per sextillion years.
   /// </summary>
   public static readonly Velocity FurlongPerSeptillionYears = new (
                                                                    "furlong per septillion years"
                                                                  , "fur/Yyr"
                                                                  , SI.Velocities.MeterPerSextillionYears
                                                                  , 201.168 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) furlong per million years. Defined as: (201.168)/(1000.0) × SI meter per millennium.
   /// </summary>
   public static readonly Velocity FurlongPerMillionYears = new (
                                                                 "furlong per million years"
                                                               , "fur/Myr"
                                                               , SI.Velocities.MeterPerMillennium
                                                               , 201.168 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) league per octillion years. Defined as: (4828.032)/(1000.0) × SI meter per septillion years.
   /// </summary>
   public static readonly Velocity LeaguePerOctillionYears = new (
                                                                  "league per octillion years"
                                                                , "lea/Ryr"
                                                                , SI.Velocities.MeterPerSeptillionYears
                                                                , 4828.032 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) furlong per day. Defined as: (201.168)/(24.0) × SI meter per hour.
   /// </summary>
   public static readonly Velocity FurlongPerDay = new (
                                                        "furlong per day"
                                                      , "fur/dy"
                                                      , SI.Velocities.MeterPerHour
                                                      , 201.168 / 24.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) rod per million years. Defined as: (5.0292)/(1000.0) × SI meter per millennium.
   /// </summary>
   public static readonly Velocity RodPerMillionYears = new (
                                                             "rod per million years"
                                                           , "rd/Myr"
                                                           , SI.Velocities.MeterPerMillennium
                                                           , 5.0292 / 1000.0
                                                           , 0
                                                            );
}
