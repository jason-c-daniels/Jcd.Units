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
   /// league per century defined such that: SI meter per decade = lea/century × (4828.032)/(10.0).
   /// </summary>
   public static readonly Velocity LeaguePerCentury = new (
                                                           "league per century"
                                                         , "lea/century"
                                                         , SI.Velocities.MeterPerDecade
                                                         , 4828.032 / 10.0
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// chain per sextillion years defined such that: SI meter per quintillion years = ch/Zyr × (20.1168)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerSextillionYears = new (
                                                                  "chain per sextillion years"
                                                                , "ch/Zyr"
                                                                , SI.Velocities.MeterPerQuintillionYears
                                                                , 20.1168 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// chain per year defined such that: SI meter per day = ch/yr × (20.1168)/(365.2525).
   /// </summary>
   public static readonly Velocity ChainPerYear = new (
                                                       "chain per year"
                                                     , "ch/yr"
                                                     , SI.Velocities.MeterPerDay
                                                     , 20.1168 / 365.2525
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// rod per billion years defined such that: SI meter per million years = rd/Gyr × (5.0292)/(1000.0).
   /// </summary>
   public static readonly Velocity RodPerBillionYears = new (
                                                             "rod per billion years"
                                                           , "rd/Gyr"
                                                           , SI.Velocities.MeterPerMillionYears
                                                           , 5.0292 / 1000.0
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// rod per trillion years defined such that: SI meter per billion years = rd/Tyr × (5.0292)/(1000.0).
   /// </summary>
   public static readonly Velocity RodPerTrillionYears = new (
                                                              "rod per trillion years"
                                                            , "rd/Tyr"
                                                            , SI.Velocities.MeterPerBillionYears
                                                            , 5.0292 / 1000.0
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per quadrillion years defined such that: SI meter per trillion years = lea/Pyr × (4828.032)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerQuadrillionYears = new (
                                                                    "league per quadrillion years"
                                                                  , "lea/Pyr"
                                                                  , SI.Velocities.MeterPerTrillionYears
                                                                  , 4828.032 / 1000.0
                                                                  , system: "US Survey"
                                                                   );

   /// <summary>
   /// furlong per octillion years defined such that: SI meter per septillion years = fur/Ryr × (201.168)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerOctillionYears = new (
                                                                   "furlong per octillion years"
                                                                 , "fur/Ryr"
                                                                 , SI.Velocities.MeterPerSeptillionYears
                                                                 , 201.168 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// furlong per billion years defined such that: SI meter per million years = fur/Gyr × (201.168)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerBillionYears = new (
                                                                 "furlong per billion years"
                                                               , "fur/Gyr"
                                                               , SI.Velocities.MeterPerMillionYears
                                                               , 201.168 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// chain per septillion years defined such that: SI meter per sextillion years = ch/Yyr × (20.1168)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerSeptillionYears = new (
                                                                  "chain per septillion years"
                                                                , "ch/Yyr"
                                                                , SI.Velocities.MeterPerSextillionYears
                                                                , 20.1168 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// furlong per week defined such that: SI meter per day = fur/wk × (201.168)/(7.0).
   /// </summary>
   public static readonly Velocity FurlongPerWeek = new (
                                                         "furlong per week"
                                                       , "fur/wk"
                                                       , SI.Velocities.MeterPerDay
                                                       , 201.168 / 7.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// league per day defined such that: SI meter per hour = lea/dy × (4828.032)/(24.0).
   /// </summary>
   public static readonly Velocity LeaguePerDay = new (
                                                       "league per day"
                                                     , "lea/dy"
                                                     , SI.Velocities.MeterPerHour
                                                     , 4828.032 / 24.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// chain per decade defined such that: SI meter per year = ch/decade × (20.1168)/(10.0).
   /// </summary>
   public static readonly Velocity ChainPerDecade = new (
                                                         "chain per decade"
                                                       , "ch/decade"
                                                       , SI.Velocities.MeterPerYear
                                                       , 20.1168 / 10.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// rod per quadrillion years defined such that: SI meter per trillion years = rd/Pyr × (5.0292)/(1000.0).
   /// </summary>
   public static readonly Velocity RodPerQuadrillionYears = new (
                                                                 "rod per quadrillion years"
                                                               , "rd/Pyr"
                                                               , SI.Velocities.MeterPerTrillionYears
                                                               , 5.0292 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// league per nonillion years defined such that: SI meter per octillion years = lea/Qyr × (4828.032)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerNonillionYears = new (
                                                                  "league per nonillion years"
                                                                , "lea/Qyr"
                                                                , SI.Velocities.MeterPerOctillionYears
                                                                , 4828.032 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// rod per quintillion years defined such that: SI meter per quadrillion years = rd/Eyr × (5.0292)/(1000.0).
   /// </summary>
   public static readonly Velocity RodPerQuintillionYears = new (
                                                                 "rod per quintillion years"
                                                               , "rd/Eyr"
                                                               , SI.Velocities.MeterPerQuadrillionYears
                                                               , 5.0292 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// league per millennium defined such that: SI meter per century = lea/kyr × (4828.032)/(10.0).
   /// </summary>
   public static readonly Velocity LeaguePerMillennium = new (
                                                              "league per millennium"
                                                            , "lea/kyr"
                                                            , SI.Velocities.MeterPerCentury
                                                            , 4828.032 / 10.0
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per octillion years defined such that: SI meter per septillion years = ch/Ryr × (20.1168)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerOctillionYears = new (
                                                                 "chain per octillion years"
                                                               , "ch/Ryr"
                                                               , SI.Velocities.MeterPerSeptillionYears
                                                               , 20.1168 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// chain per century defined such that: SI meter per decade = ch/century × (20.1168)/(10.0).
   /// </summary>
   public static readonly Velocity ChainPerCentury = new (
                                                          "chain per century"
                                                        , "ch/century"
                                                        , SI.Velocities.MeterPerDecade
                                                        , 20.1168 / 10.0
                                                        , system: "US Survey"
                                                         );

   /// <summary>
   /// rod per sextillion years defined such that: SI meter per quintillion years = rd/Zyr × (5.0292)/(1000.0).
   /// </summary>
   public static readonly Velocity RodPerSextillionYears = new (
                                                                "rod per sextillion years"
                                                              , "rd/Zyr"
                                                              , SI.Velocities.MeterPerQuintillionYears
                                                              , 5.0292 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per nonillion years defined such that: SI meter per octillion years = fur/Qyr × (201.168)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerNonillionYears = new (
                                                                   "furlong per nonillion years"
                                                                 , "fur/Qyr"
                                                                 , SI.Velocities.MeterPerOctillionYears
                                                                 , 201.168 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// furlong per trillion years defined such that: SI meter per billion years = fur/Tyr × (201.168)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerTrillionYears = new (
                                                                  "furlong per trillion years"
                                                                , "fur/Tyr"
                                                                , SI.Velocities.MeterPerBillionYears
                                                                , 201.168 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// furlong per year defined such that: SI meter per day = fur/yr × (201.168)/(365.2525).
   /// </summary>
   public static readonly Velocity FurlongPerYear = new (
                                                         "furlong per year"
                                                       , "fur/yr"
                                                       , SI.Velocities.MeterPerDay
                                                       , 201.168 / 365.2525
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// rod per septillion years defined such that: SI meter per sextillion years = rd/Yyr × (5.0292)/(1000.0).
   /// </summary>
   public static readonly Velocity RodPerSeptillionYears = new (
                                                                "rod per septillion years"
                                                              , "rd/Yyr"
                                                              , SI.Velocities.MeterPerSextillionYears
                                                              , 5.0292 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// league per quintillion years defined such that: SI meter per quadrillion years = lea/Eyr × (4828.032)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerQuintillionYears = new (
                                                                    "league per quintillion years"
                                                                  , "lea/Eyr"
                                                                  , SI.Velocities.MeterPerQuadrillionYears
                                                                  , 4828.032 / 1000.0
                                                                  , system: "US Survey"
                                                                   );

   /// <summary>
   /// chain per nonillion years defined such that: SI meter per octillion years = ch/Qyr × (20.1168)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerNonillionYears = new (
                                                                 "chain per nonillion years"
                                                               , "ch/Qyr"
                                                               , SI.Velocities.MeterPerOctillionYears
                                                               , 20.1168 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// league per week defined such that: SI meter per day = lea/wk × (4828.032)/(7.0).
   /// </summary>
   public static readonly Velocity LeaguePerWeek = new (
                                                        "league per week"
                                                      , "lea/wk"
                                                      , SI.Velocities.MeterPerDay
                                                      , 4828.032 / 7.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// chain per millennium defined such that: SI meter per century = ch/kyr × (20.1168)/(10.0).
   /// </summary>
   public static readonly Velocity ChainPerMillennium = new (
                                                             "chain per millennium"
                                                           , "ch/kyr"
                                                           , SI.Velocities.MeterPerCentury
                                                           , 20.1168 / 10.0
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// rod per octillion years defined such that: SI meter per septillion years = rd/Ryr × (5.0292)/(1000.0).
   /// </summary>
   public static readonly Velocity RodPerOctillionYears = new (
                                                               "rod per octillion years"
                                                             , "rd/Ryr"
                                                             , SI.Velocities.MeterPerSeptillionYears
                                                             , 5.0292 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per decillion years defined such that: SI meter per nonillion years = lea/decillion yr × (4828.032)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerDecillionYears = new (
                                                                  "league per decillion years"
                                                                , "lea/decillion yr"
                                                                , SI.Velocities.MeterPerNonillionYears
                                                                , 4828.032 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// rod per nonillion years defined such that: SI meter per octillion years = rd/Qyr × (5.0292)/(1000.0).
   /// </summary>
   public static readonly Velocity RodPerNonillionYears = new (
                                                               "rod per nonillion years"
                                                             , "rd/Qyr"
                                                             , SI.Velocities.MeterPerOctillionYears
                                                             , 5.0292 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per decillion years defined such that: SI meter per nonillion years = fur/decillion yr × (201.168)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerDecillionYears = new (
                                                                   "furlong per decillion years"
                                                                 , "fur/decillion yr"
                                                                 , SI.Velocities.MeterPerNonillionYears
                                                                 , 201.168 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// league per million years defined such that: SI meter per millennium = lea/Myr × (4828.032)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerMillionYears = new (
                                                                "league per million years"
                                                              , "lea/Myr"
                                                              , SI.Velocities.MeterPerMillennium
                                                              , 4828.032 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per quadrillion years defined such that: SI meter per trillion years = fur/Pyr × (201.168)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerQuadrillionYears = new (
                                                                     "furlong per quadrillion years"
                                                                   , "fur/Pyr"
                                                                   , SI.Velocities.MeterPerTrillionYears
                                                                   , 201.168 / 1000.0
                                                                   , system: "US Survey"
                                                                    );

   /// <summary>
   /// chain per decillion years defined such that: SI meter per nonillion years = ch/decillion yr × (20.1168)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerDecillionYears = new (
                                                                 "chain per decillion years"
                                                               , "ch/decillion yr"
                                                               , SI.Velocities.MeterPerNonillionYears
                                                               , 20.1168 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// furlong per decade defined such that: SI meter per year = fur/decade × (201.168)/(10.0).
   /// </summary>
   public static readonly Velocity FurlongPerDecade = new (
                                                           "furlong per decade"
                                                         , "fur/decade"
                                                         , SI.Velocities.MeterPerYear
                                                         , 201.168 / 10.0
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// chain per million years defined such that: SI meter per millennium = ch/Myr × (20.1168)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerMillionYears = new (
                                                               "chain per million years"
                                                             , "ch/Myr"
                                                             , SI.Velocities.MeterPerMillennium
                                                             , 20.1168 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// rod per decillion years defined such that: SI meter per nonillion years = rd/decillion yr × (5.0292)/(1000.0).
   /// </summary>
   public static readonly Velocity RodPerDecillionYears = new (
                                                               "rod per decillion years"
                                                             , "rd/decillion yr"
                                                             , SI.Velocities.MeterPerNonillionYears
                                                             , 5.0292 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// link per second defined such that: SI meter per second = li/s × (0.20116)/(1.0).
   /// </summary>
   public static readonly Velocity LinkPerSecond = new (
                                                        "link per second"
                                                      , "li/s"
                                                      , SI.Velocities.MeterPerSecond
                                                      , 0.20116 / 1.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// link per planck-time defined such that: SI meter per microsecond = li/tₚ × (0.20116)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity LinkPerPlanckTime = new (
                                                            "link per planck-time"
                                                          , "li/tₚ"
                                                          , SI.Velocities.MeterPerMicrosecond
                                                          , 0.20116 / 5.391247E-38
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per decisecond defined such that: SI meter per second = li/ds × (0.20116)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LinkPerDecisecond = new (
                                                            "link per decisecond"
                                                          , "li/ds"
                                                          , SI.Velocities.MeterPerSecond
                                                          , 0.20116 / (1.0 / 10.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per centisecond defined such that: SI meter per decisecond = li/cs × (0.20116)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LinkPerCentisecond = new (
                                                             "link per centisecond"
                                                           , "li/cs"
                                                           , SI.Velocities.MeterPerDecisecond
                                                           , 0.20116 / (1.0 / 10.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per millisecond defined such that: SI meter per centisecond = li/ms × (0.20116)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LinkPerMillisecond = new (
                                                             "link per millisecond"
                                                           , "li/ms"
                                                           , SI.Velocities.MeterPerCentisecond
                                                           , 0.20116 / (1.0 / 10.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per microsecond defined such that: SI meter per millisecond = li/μs × (0.20116)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LinkPerMicrosecond = new (
                                                             "link per microsecond"
                                                           , "li/μs"
                                                           , SI.Velocities.MeterPerMillisecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per nanosecond defined such that: SI meter per microsecond = li/ns × (0.20116)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LinkPerNanosecond = new (
                                                            "link per nanosecond"
                                                          , "li/ns"
                                                          , SI.Velocities.MeterPerMicrosecond
                                                          , 0.20116 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per picosecond defined such that: SI meter per nanosecond = li/ps × (0.20116)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LinkPerPicosecond = new (
                                                            "link per picosecond"
                                                          , "li/ps"
                                                          , SI.Velocities.MeterPerNanosecond
                                                          , 0.20116 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per femtosecond defined such that: SI meter per picosecond = li/fs × (0.20116)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LinkPerFemtosecond = new (
                                                             "link per femtosecond"
                                                           , "li/fs"
                                                           , SI.Velocities.MeterPerPicosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per attosecond defined such that: SI meter per femtosecond = li/as × (0.20116)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LinkPerAttosecond = new (
                                                            "link per attosecond"
                                                          , "li/as"
                                                          , SI.Velocities.MeterPerFemtosecond
                                                          , 0.20116 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per zeptosecond defined such that: SI meter per attosecond = li/zs × (0.20116)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LinkPerZeptosecond = new (
                                                             "link per zeptosecond"
                                                           , "li/zs"
                                                           , SI.Velocities.MeterPerAttosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per yoctosecond defined such that: SI meter per zeptosecond = li/ys × (0.20116)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LinkPerYoctosecond = new (
                                                             "link per yoctosecond"
                                                           , "li/ys"
                                                           , SI.Velocities.MeterPerZeptosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per rontosecond defined such that: SI meter per yoctosecond = li/rs × (0.20116)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LinkPerRontosecond = new (
                                                             "link per rontosecond"
                                                           , "li/rs"
                                                           , SI.Velocities.MeterPerYoctosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per quectosecond defined such that: SI meter per rontosecond = li/qs × (0.20116)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LinkPerQuectosecond = new (
                                                              "link per quectosecond"
                                                            , "li/qs"
                                                            , SI.Velocities.MeterPerRontosecond
                                                            , 0.20116 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// link per minute defined such that: SI meter per second = li/min × (0.20116)/(60.0).
   /// </summary>
   public static readonly Velocity LinkPerMinute = new (
                                                        "link per minute"
                                                      , "li/min"
                                                      , SI.Velocities.MeterPerSecond
                                                      , 0.20116 / 60.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// rod per second defined such that: SI meter per second = rd/s × (5.0292)/(1.0).
   /// </summary>
   public static readonly Velocity RodPerSecond = new (
                                                       "rod per second"
                                                     , "rd/s"
                                                     , SI.Velocities.MeterPerSecond
                                                     , 5.0292 / 1.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// rod per planck-time defined such that: SI meter per microsecond = rd/tₚ × (5.0292)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity RodPerPlanckTime = new (
                                                           "rod per planck-time"
                                                         , "rd/tₚ"
                                                         , SI.Velocities.MeterPerMicrosecond
                                                         , 5.0292 / 5.391247E-38
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// rod per decisecond defined such that: SI meter per second = rd/ds × (5.0292)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity RodPerDecisecond = new (
                                                           "rod per decisecond"
                                                         , "rd/ds"
                                                         , SI.Velocities.MeterPerSecond
                                                         , 5.0292 / (1.0 / 10.0)
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// rod per centisecond defined such that: SI meter per decisecond = rd/cs × (5.0292)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity RodPerCentisecond = new (
                                                            "rod per centisecond"
                                                          , "rd/cs"
                                                          , SI.Velocities.MeterPerDecisecond
                                                          , 5.0292 / (1.0 / 10.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per millisecond defined such that: SI meter per centisecond = rd/ms × (5.0292)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity RodPerMillisecond = new (
                                                            "rod per millisecond"
                                                          , "rd/ms"
                                                          , SI.Velocities.MeterPerCentisecond
                                                          , 5.0292 / (1.0 / 10.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per microsecond defined such that: SI meter per millisecond = rd/μs × (5.0292)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RodPerMicrosecond = new (
                                                            "rod per microsecond"
                                                          , "rd/μs"
                                                          , SI.Velocities.MeterPerMillisecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per nanosecond defined such that: SI meter per microsecond = rd/ns × (5.0292)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RodPerNanosecond = new (
                                                           "rod per nanosecond"
                                                         , "rd/ns"
                                                         , SI.Velocities.MeterPerMicrosecond
                                                         , 5.0292 / (1.0 / 1000.0)
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// rod per picosecond defined such that: SI meter per nanosecond = rd/ps × (5.0292)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RodPerPicosecond = new (
                                                           "rod per picosecond"
                                                         , "rd/ps"
                                                         , SI.Velocities.MeterPerNanosecond
                                                         , 5.0292 / (1.0 / 1000.0)
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// rod per femtosecond defined such that: SI meter per picosecond = rd/fs × (5.0292)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RodPerFemtosecond = new (
                                                            "rod per femtosecond"
                                                          , "rd/fs"
                                                          , SI.Velocities.MeterPerPicosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per attosecond defined such that: SI meter per femtosecond = rd/as × (5.0292)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RodPerAttosecond = new (
                                                           "rod per attosecond"
                                                         , "rd/as"
                                                         , SI.Velocities.MeterPerFemtosecond
                                                         , 5.0292 / (1.0 / 1000.0)
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// rod per zeptosecond defined such that: SI meter per attosecond = rd/zs × (5.0292)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RodPerZeptosecond = new (
                                                            "rod per zeptosecond"
                                                          , "rd/zs"
                                                          , SI.Velocities.MeterPerAttosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per yoctosecond defined such that: SI meter per zeptosecond = rd/ys × (5.0292)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RodPerYoctosecond = new (
                                                            "rod per yoctosecond"
                                                          , "rd/ys"
                                                          , SI.Velocities.MeterPerZeptosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per rontosecond defined such that: SI meter per yoctosecond = rd/rs × (5.0292)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RodPerRontosecond = new (
                                                            "rod per rontosecond"
                                                          , "rd/rs"
                                                          , SI.Velocities.MeterPerYoctosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per quectosecond defined such that: SI meter per rontosecond = rd/qs × (5.0292)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RodPerQuectosecond = new (
                                                             "rod per quectosecond"
                                                           , "rd/qs"
                                                           , SI.Velocities.MeterPerRontosecond
                                                           , 5.0292 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per hour defined such that: SI meter per minute = li/hr × (0.20116)/(60.0).
   /// </summary>
   public static readonly Velocity LinkPerHour = new (
                                                      "link per hour"
                                                    , "li/hr"
                                                    , SI.Velocities.MeterPerMinute
                                                    , 0.20116 / 60.0
                                                    , system: "US Survey"
                                                     );

   /// <summary>
   /// chain per second defined such that: SI meter per second = ch/s × (20.1168)/(1.0).
   /// </summary>
   public static readonly Velocity ChainPerSecond = new (
                                                         "chain per second"
                                                       , "ch/s"
                                                       , SI.Velocities.MeterPerSecond
                                                       , 20.1168 / 1.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// chain per planck-time defined such that: SI meter per microsecond = ch/tₚ × (20.1168)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity ChainPerPlanckTime = new (
                                                             "chain per planck-time"
                                                           , "ch/tₚ"
                                                           , SI.Velocities.MeterPerMicrosecond
                                                           , 20.1168 / 5.391247E-38
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// chain per decisecond defined such that: SI meter per second = ch/ds × (20.1168)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ChainPerDecisecond = new (
                                                             "chain per decisecond"
                                                           , "ch/ds"
                                                           , SI.Velocities.MeterPerSecond
                                                           , 20.1168 / (1.0 / 10.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// chain per centisecond defined such that: SI meter per decisecond = ch/cs × (20.1168)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ChainPerCentisecond = new (
                                                              "chain per centisecond"
                                                            , "ch/cs"
                                                            , SI.Velocities.MeterPerDecisecond
                                                            , 20.1168 / (1.0 / 10.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per millisecond defined such that: SI meter per centisecond = ch/ms × (20.1168)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ChainPerMillisecond = new (
                                                              "chain per millisecond"
                                                            , "ch/ms"
                                                            , SI.Velocities.MeterPerCentisecond
                                                            , 20.1168 / (1.0 / 10.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per microsecond defined such that: SI meter per millisecond = ch/μs × (20.1168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerMicrosecond = new (
                                                              "chain per microsecond"
                                                            , "ch/μs"
                                                            , SI.Velocities.MeterPerMillisecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per nanosecond defined such that: SI meter per microsecond = ch/ns × (20.1168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerNanosecond = new (
                                                             "chain per nanosecond"
                                                           , "ch/ns"
                                                           , SI.Velocities.MeterPerMicrosecond
                                                           , 20.1168 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// chain per picosecond defined such that: SI meter per nanosecond = ch/ps × (20.1168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerPicosecond = new (
                                                             "chain per picosecond"
                                                           , "ch/ps"
                                                           , SI.Velocities.MeterPerNanosecond
                                                           , 20.1168 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// chain per femtosecond defined such that: SI meter per picosecond = ch/fs × (20.1168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerFemtosecond = new (
                                                              "chain per femtosecond"
                                                            , "ch/fs"
                                                            , SI.Velocities.MeterPerPicosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per attosecond defined such that: SI meter per femtosecond = ch/as × (20.1168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerAttosecond = new (
                                                             "chain per attosecond"
                                                           , "ch/as"
                                                           , SI.Velocities.MeterPerFemtosecond
                                                           , 20.1168 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// chain per zeptosecond defined such that: SI meter per attosecond = ch/zs × (20.1168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerZeptosecond = new (
                                                              "chain per zeptosecond"
                                                            , "ch/zs"
                                                            , SI.Velocities.MeterPerAttosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per yoctosecond defined such that: SI meter per zeptosecond = ch/ys × (20.1168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerYoctosecond = new (
                                                              "chain per yoctosecond"
                                                            , "ch/ys"
                                                            , SI.Velocities.MeterPerZeptosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per rontosecond defined such that: SI meter per yoctosecond = ch/rs × (20.1168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerRontosecond = new (
                                                              "chain per rontosecond"
                                                            , "ch/rs"
                                                            , SI.Velocities.MeterPerYoctosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per quectosecond defined such that: SI meter per rontosecond = ch/qs × (20.1168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerQuectosecond = new (
                                                               "chain per quectosecond"
                                                             , "ch/qs"
                                                             , SI.Velocities.MeterPerRontosecond
                                                             , 20.1168 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// link per day defined such that: SI meter per hour = li/dy × (0.20116)/(24.0).
   /// </summary>
   public static readonly Velocity LinkPerDay = new (
                                                     "link per day"
                                                   , "li/dy"
                                                   , SI.Velocities.MeterPerHour
                                                   , 0.20116 / 24.0
                                                   , system: "US Survey"
                                                    );

   /// <summary>
   /// furlong per second defined such that: SI meter per second = fur/s × (201.168)/(1.0).
   /// </summary>
   public static readonly Velocity FurlongPerSecond = new (
                                                           "furlong per second"
                                                         , "fur/s"
                                                         , SI.Velocities.MeterPerSecond
                                                         , 201.168 / 1.0
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// furlong per planck-time defined such that: SI meter per microsecond = fur/tₚ × (201.168)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity FurlongPerPlanckTime = new (
                                                               "furlong per planck-time"
                                                             , "fur/tₚ"
                                                             , SI.Velocities.MeterPerMicrosecond
                                                             , 201.168 / 5.391247E-38
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per decisecond defined such that: SI meter per second = fur/ds × (201.168)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FurlongPerDecisecond = new (
                                                               "furlong per decisecond"
                                                             , "fur/ds"
                                                             , SI.Velocities.MeterPerSecond
                                                             , 201.168 / (1.0 / 10.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per centisecond defined such that: SI meter per decisecond = fur/cs × (201.168)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FurlongPerCentisecond = new (
                                                                "furlong per centisecond"
                                                              , "fur/cs"
                                                              , SI.Velocities.MeterPerDecisecond
                                                              , 201.168 / (1.0 / 10.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per millisecond defined such that: SI meter per centisecond = fur/ms × (201.168)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FurlongPerMillisecond = new (
                                                                "furlong per millisecond"
                                                              , "fur/ms"
                                                              , SI.Velocities.MeterPerCentisecond
                                                              , 201.168 / (1.0 / 10.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per microsecond defined such that: SI meter per millisecond = fur/μs × (201.168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerMicrosecond = new (
                                                                "furlong per microsecond"
                                                              , "fur/μs"
                                                              , SI.Velocities.MeterPerMillisecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per nanosecond defined such that: SI meter per microsecond = fur/ns × (201.168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerNanosecond = new (
                                                               "furlong per nanosecond"
                                                             , "fur/ns"
                                                             , SI.Velocities.MeterPerMicrosecond
                                                             , 201.168 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per picosecond defined such that: SI meter per nanosecond = fur/ps × (201.168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerPicosecond = new (
                                                               "furlong per picosecond"
                                                             , "fur/ps"
                                                             , SI.Velocities.MeterPerNanosecond
                                                             , 201.168 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per femtosecond defined such that: SI meter per picosecond = fur/fs × (201.168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerFemtosecond = new (
                                                                "furlong per femtosecond"
                                                              , "fur/fs"
                                                              , SI.Velocities.MeterPerPicosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per attosecond defined such that: SI meter per femtosecond = fur/as × (201.168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerAttosecond = new (
                                                               "furlong per attosecond"
                                                             , "fur/as"
                                                             , SI.Velocities.MeterPerFemtosecond
                                                             , 201.168 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per zeptosecond defined such that: SI meter per attosecond = fur/zs × (201.168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerZeptosecond = new (
                                                                "furlong per zeptosecond"
                                                              , "fur/zs"
                                                              , SI.Velocities.MeterPerAttosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per yoctosecond defined such that: SI meter per zeptosecond = fur/ys × (201.168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerYoctosecond = new (
                                                                "furlong per yoctosecond"
                                                              , "fur/ys"
                                                              , SI.Velocities.MeterPerZeptosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per rontosecond defined such that: SI meter per yoctosecond = fur/rs × (201.168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerRontosecond = new (
                                                                "furlong per rontosecond"
                                                              , "fur/rs"
                                                              , SI.Velocities.MeterPerYoctosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per quectosecond defined such that: SI meter per rontosecond = fur/qs × (201.168)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerQuectosecond = new (
                                                                 "furlong per quectosecond"
                                                               , "fur/qs"
                                                               , SI.Velocities.MeterPerRontosecond
                                                               , 201.168 / (1.0 / 1000.0)
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// link per week defined such that: SI meter per day = li/wk × (0.20116)/(7.0).
   /// </summary>
   public static readonly Velocity LinkPerWeek = new (
                                                      "link per week"
                                                    , "li/wk"
                                                    , SI.Velocities.MeterPerDay
                                                    , 0.20116 / 7.0
                                                    , system: "US Survey"
                                                     );

   /// <summary>
   /// league per second defined such that: SI meter per second = lea/s × (4828.032)/(1.0).
   /// </summary>
   public static readonly Velocity LeaguePerSecond = new (
                                                          "league per second"
                                                        , "lea/s"
                                                        , SI.Velocities.MeterPerSecond
                                                        , 4828.032 / 1.0
                                                        , system: "US Survey"
                                                         );

   /// <summary>
   /// league per planck-time defined such that: SI meter per microsecond = lea/tₚ × (4828.032)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity LeaguePerPlanckTime = new (
                                                              "league per planck-time"
                                                            , "lea/tₚ"
                                                            , SI.Velocities.MeterPerMicrosecond
                                                            , 4828.032 / 5.391247E-38
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per decisecond defined such that: SI meter per second = lea/ds × (4828.032)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LeaguePerDecisecond = new (
                                                              "league per decisecond"
                                                            , "lea/ds"
                                                            , SI.Velocities.MeterPerSecond
                                                            , 4828.032 / (1.0 / 10.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per centisecond defined such that: SI meter per decisecond = lea/cs × (4828.032)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LeaguePerCentisecond = new (
                                                               "league per centisecond"
                                                             , "lea/cs"
                                                             , SI.Velocities.MeterPerDecisecond
                                                             , 4828.032 / (1.0 / 10.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per millisecond defined such that: SI meter per centisecond = lea/ms × (4828.032)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LeaguePerMillisecond = new (
                                                               "league per millisecond"
                                                             , "lea/ms"
                                                             , SI.Velocities.MeterPerCentisecond
                                                             , 4828.032 / (1.0 / 10.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per microsecond defined such that: SI meter per millisecond = lea/μs × (4828.032)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerMicrosecond = new (
                                                               "league per microsecond"
                                                             , "lea/μs"
                                                             , SI.Velocities.MeterPerMillisecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per nanosecond defined such that: SI meter per microsecond = lea/ns × (4828.032)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerNanosecond = new (
                                                              "league per nanosecond"
                                                            , "lea/ns"
                                                            , SI.Velocities.MeterPerMicrosecond
                                                            , 4828.032 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per picosecond defined such that: SI meter per nanosecond = lea/ps × (4828.032)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerPicosecond = new (
                                                              "league per picosecond"
                                                            , "lea/ps"
                                                            , SI.Velocities.MeterPerNanosecond
                                                            , 4828.032 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per femtosecond defined such that: SI meter per picosecond = lea/fs × (4828.032)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerFemtosecond = new (
                                                               "league per femtosecond"
                                                             , "lea/fs"
                                                             , SI.Velocities.MeterPerPicosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per attosecond defined such that: SI meter per femtosecond = lea/as × (4828.032)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerAttosecond = new (
                                                              "league per attosecond"
                                                            , "lea/as"
                                                            , SI.Velocities.MeterPerFemtosecond
                                                            , 4828.032 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per zeptosecond defined such that: SI meter per attosecond = lea/zs × (4828.032)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerZeptosecond = new (
                                                               "league per zeptosecond"
                                                             , "lea/zs"
                                                             , SI.Velocities.MeterPerAttosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per yoctosecond defined such that: SI meter per zeptosecond = lea/ys × (4828.032)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerYoctosecond = new (
                                                               "league per yoctosecond"
                                                             , "lea/ys"
                                                             , SI.Velocities.MeterPerZeptosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per rontosecond defined such that: SI meter per yoctosecond = lea/rs × (4828.032)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerRontosecond = new (
                                                               "league per rontosecond"
                                                             , "lea/rs"
                                                             , SI.Velocities.MeterPerYoctosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per quectosecond defined such that: SI meter per rontosecond = lea/qs × (4828.032)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerQuectosecond = new (
                                                                "league per quectosecond"
                                                              , "lea/qs"
                                                              , SI.Velocities.MeterPerRontosecond
                                                              , 4828.032 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// link per year defined such that: SI meter per day = li/yr × (0.20116)/(365.2525).
   /// </summary>
   public static readonly Velocity LinkPerYear = new (
                                                      "link per year"
                                                    , "li/yr"
                                                    , SI.Velocities.MeterPerDay
                                                    , 0.20116 / 365.2525
                                                    , system: "US Survey"
                                                     );

   /// <summary>
   /// link per decade defined such that: SI meter per year = li/decade × (0.20116)/(10.0).
   /// </summary>
   public static readonly Velocity LinkPerDecade = new (
                                                        "link per decade"
                                                      , "li/decade"
                                                      , SI.Velocities.MeterPerYear
                                                      , 0.20116 / 10.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// link per century defined such that: SI meter per decade = li/century × (0.20116)/(10.0).
   /// </summary>
   public static readonly Velocity LinkPerCentury = new (
                                                         "link per century"
                                                       , "li/century"
                                                       , SI.Velocities.MeterPerDecade
                                                       , 0.20116 / 10.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// link per millennium defined such that: SI meter per century = li/kyr × (0.20116)/(10.0).
   /// </summary>
   public static readonly Velocity LinkPerMillennium = new (
                                                            "link per millennium"
                                                          , "li/kyr"
                                                          , SI.Velocities.MeterPerCentury
                                                          , 0.20116 / 10.0
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per million years defined such that: SI meter per millennium = li/Myr × (0.20116)/(1000.0).
   /// </summary>
   public static readonly Velocity LinkPerMillionYears = new (
                                                              "link per million years"
                                                            , "li/Myr"
                                                            , SI.Velocities.MeterPerMillennium
                                                            , 0.20116 / 1000.0
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// link per billion years defined such that: SI meter per million years = li/Gyr × (0.20116)/(1000.0).
   /// </summary>
   public static readonly Velocity LinkPerBillionYears = new (
                                                              "link per billion years"
                                                            , "li/Gyr"
                                                            , SI.Velocities.MeterPerMillionYears
                                                            , 0.20116 / 1000.0
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// link per trillion years defined such that: SI meter per billion years = li/Tyr × (0.20116)/(1000.0).
   /// </summary>
   public static readonly Velocity LinkPerTrillionYears = new (
                                                               "link per trillion years"
                                                             , "li/Tyr"
                                                             , SI.Velocities.MeterPerBillionYears
                                                             , 0.20116 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// link per quadrillion years defined such that: SI meter per trillion years = li/Pyr × (0.20116)/(1000.0).
   /// </summary>
   public static readonly Velocity LinkPerQuadrillionYears = new (
                                                                  "link per quadrillion years"
                                                                , "li/Pyr"
                                                                , SI.Velocities.MeterPerTrillionYears
                                                                , 0.20116 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// link per quintillion years defined such that: SI meter per quadrillion years = li/Eyr × (0.20116)/(1000.0).
   /// </summary>
   public static readonly Velocity LinkPerQuintillionYears = new (
                                                                  "link per quintillion years"
                                                                , "li/Eyr"
                                                                , SI.Velocities.MeterPerQuadrillionYears
                                                                , 0.20116 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// link per sextillion years defined such that: SI meter per quintillion years = li/Zyr × (0.20116)/(1000.0).
   /// </summary>
   public static readonly Velocity LinkPerSextillionYears = new (
                                                                 "link per sextillion years"
                                                               , "li/Zyr"
                                                               , SI.Velocities.MeterPerQuintillionYears
                                                               , 0.20116 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// link per septillion years defined such that: SI meter per sextillion years = li/Yyr × (0.20116)/(1000.0).
   /// </summary>
   public static readonly Velocity LinkPerSeptillionYears = new (
                                                                 "link per septillion years"
                                                               , "li/Yyr"
                                                               , SI.Velocities.MeterPerSextillionYears
                                                               , 0.20116 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// link per octillion years defined such that: SI meter per septillion years = li/Ryr × (0.20116)/(1000.0).
   /// </summary>
   public static readonly Velocity LinkPerOctillionYears = new (
                                                                "link per octillion years"
                                                              , "li/Ryr"
                                                              , SI.Velocities.MeterPerSeptillionYears
                                                              , 0.20116 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// link per nonillion years defined such that: SI meter per octillion years = li/Qyr × (0.20116)/(1000.0).
   /// </summary>
   public static readonly Velocity LinkPerNonillionYears = new (
                                                                "link per nonillion years"
                                                              , "li/Qyr"
                                                              , SI.Velocities.MeterPerOctillionYears
                                                              , 0.20116 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// link per decillion years defined such that: SI meter per nonillion years = li/decillion yr × (0.20116)/(1000.0).
   /// </summary>
   public static readonly Velocity LinkPerDecillionYears = new (
                                                                "link per decillion years"
                                                              , "li/decillion yr"
                                                              , SI.Velocities.MeterPerNonillionYears
                                                              , 0.20116 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// link per tick defined such that: SI meter per nanosecond = li/tick × (0.20116)/(100.0).
   /// </summary>
   public static readonly Velocity LinkPerTick = new (
                                                      "link per tick"
                                                    , "li/tick"
                                                    , SI.Velocities.MeterPerNanosecond
                                                    , 0.20116 / 100.0
                                                    , system: "US Survey"
                                                     );

   /// <summary>
   /// league per sextillion years defined such that: SI meter per quintillion years = lea/Zyr × (4828.032)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerSextillionYears = new (
                                                                   "league per sextillion years"
                                                                 , "lea/Zyr"
                                                                 , SI.Velocities.MeterPerQuintillionYears
                                                                 , 4828.032 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// rod per minute defined such that: SI meter per second = rd/min × (5.0292)/(60.0).
   /// </summary>
   public static readonly Velocity RodPerMinute = new (
                                                       "rod per minute"
                                                     , "rd/min"
                                                     , SI.Velocities.MeterPerSecond
                                                     , 5.0292 / 60.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// league per year defined such that: SI meter per day = lea/yr × (4828.032)/(365.2525).
   /// </summary>
   public static readonly Velocity LeaguePerYear = new (
                                                        "league per year"
                                                      , "lea/yr"
                                                      , SI.Velocities.MeterPerDay
                                                      , 4828.032 / 365.2525
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// chain per billion years defined such that: SI meter per million years = ch/Gyr × (20.1168)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerBillionYears = new (
                                                               "chain per billion years"
                                                             , "ch/Gyr"
                                                             , SI.Velocities.MeterPerMillionYears
                                                             , 20.1168 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// rod per tick defined such that: SI meter per nanosecond = rd/tick × (5.0292)/(100.0).
   /// </summary>
   public static readonly Velocity RodPerTick = new (
                                                     "rod per tick"
                                                   , "rd/tick"
                                                   , SI.Velocities.MeterPerNanosecond
                                                   , 5.0292 / 100.0
                                                   , system: "US Survey"
                                                    );

   /// <summary>
   /// rod per hour defined such that: SI meter per minute = rd/hr × (5.0292)/(60.0).
   /// </summary>
   public static readonly Velocity RodPerHour = new (
                                                     "rod per hour"
                                                   , "rd/hr"
                                                   , SI.Velocities.MeterPerMinute
                                                   , 5.0292 / 60.0
                                                   , system: "US Survey"
                                                    );

   /// <summary>
   /// chain per minute defined such that: SI meter per second = ch/min × (20.1168)/(60.0).
   /// </summary>
   public static readonly Velocity ChainPerMinute = new (
                                                         "chain per minute"
                                                       , "ch/min"
                                                       , SI.Velocities.MeterPerSecond
                                                       , 20.1168 / 60.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// furlong per quintillion years defined such that: SI meter per quadrillion years = fur/Eyr × (201.168)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerQuintillionYears = new (
                                                                     "furlong per quintillion years"
                                                                   , "fur/Eyr"
                                                                   , SI.Velocities.MeterPerQuadrillionYears
                                                                   , 201.168 / 1000.0
                                                                   , system: "US Survey"
                                                                    );

   /// <summary>
   /// furlong per century defined such that: SI meter per decade = fur/century × (201.168)/(10.0).
   /// </summary>
   public static readonly Velocity FurlongPerCentury = new (
                                                            "furlong per century"
                                                          , "fur/century"
                                                          , SI.Velocities.MeterPerDecade
                                                          , 201.168 / 10.0
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per day defined such that: SI meter per hour = rd/dy × (5.0292)/(24.0).
   /// </summary>
   public static readonly Velocity RodPerDay = new (
                                                    "rod per day"
                                                  , "rd/dy"
                                                  , SI.Velocities.MeterPerHour
                                                  , 5.0292 / 24.0
                                                  , system: "US Survey"
                                                   );

   /// <summary>
   /// furlong per minute defined such that: SI meter per second = fur/min × (201.168)/(60.0).
   /// </summary>
   public static readonly Velocity FurlongPerMinute = new (
                                                           "furlong per minute"
                                                         , "fur/min"
                                                         , SI.Velocities.MeterPerSecond
                                                         , 201.168 / 60.0
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// league per billion years defined such that: SI meter per million years = lea/Gyr × (4828.032)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerBillionYears = new (
                                                                "league per billion years"
                                                              , "lea/Gyr"
                                                              , SI.Velocities.MeterPerMillionYears
                                                              , 4828.032 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// chain per tick defined such that: SI meter per nanosecond = ch/tick × (20.1168)/(100.0).
   /// </summary>
   public static readonly Velocity ChainPerTick = new (
                                                       "chain per tick"
                                                     , "ch/tick"
                                                     , SI.Velocities.MeterPerNanosecond
                                                     , 20.1168 / 100.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// chain per trillion years defined such that: SI meter per billion years = ch/Tyr × (20.1168)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerTrillionYears = new (
                                                                "chain per trillion years"
                                                              , "ch/Tyr"
                                                              , SI.Velocities.MeterPerBillionYears
                                                              , 20.1168 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// chain per hour defined such that: SI meter per minute = ch/hr × (20.1168)/(60.0).
   /// </summary>
   public static readonly Velocity ChainPerHour = new (
                                                       "chain per hour"
                                                     , "ch/hr"
                                                     , SI.Velocities.MeterPerMinute
                                                     , 20.1168 / 60.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// rod per week defined such that: SI meter per day = rd/wk × (5.0292)/(7.0).
   /// </summary>
   public static readonly Velocity RodPerWeek = new (
                                                     "rod per week"
                                                   , "rd/wk"
                                                   , SI.Velocities.MeterPerDay
                                                   , 5.0292 / 7.0
                                                   , system: "US Survey"
                                                    );

   /// <summary>
   /// league per minute defined such that: SI meter per second = lea/min × (4828.032)/(60.0).
   /// </summary>
   public static readonly Velocity LeaguePerMinute = new (
                                                          "league per minute"
                                                        , "lea/min"
                                                        , SI.Velocities.MeterPerSecond
                                                        , 4828.032 / 60.0
                                                        , system: "US Survey"
                                                         );

   /// <summary>
   /// league per septillion years defined such that: SI meter per sextillion years = lea/Yyr × (4828.032)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerSeptillionYears = new (
                                                                   "league per septillion years"
                                                                 , "lea/Yyr"
                                                                 , SI.Velocities.MeterPerSextillionYears
                                                                 , 4828.032 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// furlong per tick defined such that: SI meter per nanosecond = fur/tick × (201.168)/(100.0).
   /// </summary>
   public static readonly Velocity FurlongPerTick = new (
                                                         "furlong per tick"
                                                       , "fur/tick"
                                                       , SI.Velocities.MeterPerNanosecond
                                                       , 201.168 / 100.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// rod per year defined such that: SI meter per day = rd/yr × (5.0292)/(365.2525).
   /// </summary>
   public static readonly Velocity RodPerYear = new (
                                                     "rod per year"
                                                   , "rd/yr"
                                                   , SI.Velocities.MeterPerDay
                                                   , 5.0292 / 365.2525
                                                   , system: "US Survey"
                                                    );

   /// <summary>
   /// furlong per sextillion years defined such that: SI meter per quintillion years = fur/Zyr × (201.168)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerSextillionYears = new (
                                                                    "furlong per sextillion years"
                                                                  , "fur/Zyr"
                                                                  , SI.Velocities.MeterPerQuintillionYears
                                                                  , 201.168 / 1000.0
                                                                  , system: "US Survey"
                                                                   );

   /// <summary>
   /// league per decade defined such that: SI meter per year = lea/decade × (4828.032)/(10.0).
   /// </summary>
   public static readonly Velocity LeaguePerDecade = new (
                                                          "league per decade"
                                                        , "lea/decade"
                                                        , SI.Velocities.MeterPerYear
                                                        , 4828.032 / 10.0
                                                        , system: "US Survey"
                                                         );

   /// <summary>
   /// furlong per millennium defined such that: SI meter per century = fur/kyr × (201.168)/(10.0).
   /// </summary>
   public static readonly Velocity FurlongPerMillennium = new (
                                                               "furlong per millennium"
                                                             , "fur/kyr"
                                                             , SI.Velocities.MeterPerCentury
                                                             , 201.168 / 10.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// chain per quadrillion years defined such that: SI meter per trillion years = ch/Pyr × (20.1168)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerQuadrillionYears = new (
                                                                   "chain per quadrillion years"
                                                                 , "ch/Pyr"
                                                                 , SI.Velocities.MeterPerTrillionYears
                                                                 , 20.1168 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// chain per day defined such that: SI meter per hour = ch/dy × (20.1168)/(24.0).
   /// </summary>
   public static readonly Velocity ChainPerDay = new (
                                                      "chain per day"
                                                    , "ch/dy"
                                                    , SI.Velocities.MeterPerHour
                                                    , 20.1168 / 24.0
                                                    , system: "US Survey"
                                                     );

   /// <summary>
   /// furlong per hour defined such that: SI meter per minute = fur/hr × (201.168)/(60.0).
   /// </summary>
   public static readonly Velocity FurlongPerHour = new (
                                                         "furlong per hour"
                                                       , "fur/hr"
                                                       , SI.Velocities.MeterPerMinute
                                                       , 201.168 / 60.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// rod per decade defined such that: SI meter per year = rd/decade × (5.0292)/(10.0).
   /// </summary>
   public static readonly Velocity RodPerDecade = new (
                                                       "rod per decade"
                                                     , "rd/decade"
                                                     , SI.Velocities.MeterPerYear
                                                     , 5.0292 / 10.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// league per tick defined such that: SI meter per nanosecond = lea/tick × (4828.032)/(100.0).
   /// </summary>
   public static readonly Velocity LeaguePerTick = new (
                                                        "league per tick"
                                                      , "lea/tick"
                                                      , SI.Velocities.MeterPerNanosecond
                                                      , 4828.032 / 100.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// rod per century defined such that: SI meter per decade = rd/century × (5.0292)/(10.0).
   /// </summary>
   public static readonly Velocity RodPerCentury = new (
                                                        "rod per century"
                                                      , "rd/century"
                                                      , SI.Velocities.MeterPerDecade
                                                      , 5.0292 / 10.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// league per trillion years defined such that: SI meter per billion years = lea/Tyr × (4828.032)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerTrillionYears = new (
                                                                 "league per trillion years"
                                                               , "lea/Tyr"
                                                               , SI.Velocities.MeterPerBillionYears
                                                               , 4828.032 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// chain per quintillion years defined such that: SI meter per quadrillion years = ch/Eyr × (20.1168)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerQuintillionYears = new (
                                                                   "chain per quintillion years"
                                                                 , "ch/Eyr"
                                                                 , SI.Velocities.MeterPerQuadrillionYears
                                                                 , 20.1168 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// chain per week defined such that: SI meter per day = ch/wk × (20.1168)/(7.0).
   /// </summary>
   public static readonly Velocity ChainPerWeek = new (
                                                       "chain per week"
                                                     , "ch/wk"
                                                     , SI.Velocities.MeterPerDay
                                                     , 20.1168 / 7.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// league per hour defined such that: SI meter per minute = lea/hr × (4828.032)/(60.0).
   /// </summary>
   public static readonly Velocity LeaguePerHour = new (
                                                        "league per hour"
                                                      , "lea/hr"
                                                      , SI.Velocities.MeterPerMinute
                                                      , 4828.032 / 60.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// rod per millennium defined such that: SI meter per century = rd/kyr × (5.0292)/(10.0).
   /// </summary>
   public static readonly Velocity RodPerMillennium = new (
                                                           "rod per millennium"
                                                         , "rd/kyr"
                                                         , SI.Velocities.MeterPerCentury
                                                         , 5.0292 / 10.0
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// furlong per septillion years defined such that: SI meter per sextillion years = fur/Yyr × (201.168)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerSeptillionYears = new (
                                                                    "furlong per septillion years"
                                                                  , "fur/Yyr"
                                                                  , SI.Velocities.MeterPerSextillionYears
                                                                  , 201.168 / 1000.0
                                                                  , system: "US Survey"
                                                                   );

   /// <summary>
   /// furlong per million years defined such that: SI meter per millennium = fur/Myr × (201.168)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerMillionYears = new (
                                                                 "furlong per million years"
                                                               , "fur/Myr"
                                                               , SI.Velocities.MeterPerMillennium
                                                               , 201.168 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// league per octillion years defined such that: SI meter per septillion years = lea/Ryr × (4828.032)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerOctillionYears = new (
                                                                  "league per octillion years"
                                                                , "lea/Ryr"
                                                                , SI.Velocities.MeterPerSeptillionYears
                                                                , 4828.032 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// furlong per day defined such that: SI meter per hour = fur/dy × (201.168)/(24.0).
   /// </summary>
   public static readonly Velocity FurlongPerDay = new (
                                                        "furlong per day"
                                                      , "fur/dy"
                                                      , SI.Velocities.MeterPerHour
                                                      , 201.168 / 24.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// rod per million years defined such that: SI meter per millennium = rd/Myr × (5.0292)/(1000.0).
   /// </summary>
   public static readonly Velocity RodPerMillionYears = new (
                                                             "rod per million years"
                                                           , "rd/Myr"
                                                           , SI.Velocities.MeterPerMillennium
                                                           , 5.0292 / 1000.0
                                                           , system: "US Survey"
                                                            );
}
