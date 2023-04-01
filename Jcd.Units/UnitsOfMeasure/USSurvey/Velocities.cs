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
   /// league per century, defined as: SI meter per decade × (4828.032)/(10.0)
   /// </summary>
   public static readonly Velocity LeaguePerCentury = new (
                                                           "league per century"
                                                         , "lea/century"
                                                         , SI.Velocities.MeterPerDecade
                                                         , 4828.032 / 10.0
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// chain per sextillion years, defined as: SI meter per quintillion years × (20.1168)/(1000.0)
   /// </summary>
   public static readonly Velocity ChainPerSextillionYears = new (
                                                                  "chain per sextillion years"
                                                                , "ch/Zyr"
                                                                , SI.Velocities.MeterPerQuintillionYears
                                                                , 20.1168 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// chain per year, defined as: SI meter per day × (20.1168)/(365.2525)
   /// </summary>
   public static readonly Velocity ChainPerYear = new (
                                                       "chain per year"
                                                     , "ch/yr"
                                                     , SI.Velocities.MeterPerDay
                                                     , 20.1168 / 365.2525
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// rod per billion years, defined as: SI meter per million years × (5.0292)/(1000.0)
   /// </summary>
   public static readonly Velocity RodPerBillionYears = new (
                                                             "rod per billion years"
                                                           , "rd/Gyr"
                                                           , SI.Velocities.MeterPerMillionYears
                                                           , 5.0292 / 1000.0
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// rod per trillion years, defined as: SI meter per billion years × (5.0292)/(1000.0)
   /// </summary>
   public static readonly Velocity RodPerTrillionYears = new (
                                                              "rod per trillion years"
                                                            , "rd/Tyr"
                                                            , SI.Velocities.MeterPerBillionYears
                                                            , 5.0292 / 1000.0
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per quadrillion years, defined as: SI meter per trillion years × (4828.032)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerQuadrillionYears = new (
                                                                    "league per quadrillion years"
                                                                  , "lea/Pyr"
                                                                  , SI.Velocities.MeterPerTrillionYears
                                                                  , 4828.032 / 1000.0
                                                                  , system: "US Survey"
                                                                   );

   /// <summary>
   /// furlong per octillion years, defined as: SI meter per septillion years × (201.168)/(1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerOctillionYears = new (
                                                                   "furlong per octillion years"
                                                                 , "fur/Ryr"
                                                                 , SI.Velocities.MeterPerSeptillionYears
                                                                 , 201.168 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// furlong per billion years, defined as: SI meter per million years × (201.168)/(1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerBillionYears = new (
                                                                 "furlong per billion years"
                                                               , "fur/Gyr"
                                                               , SI.Velocities.MeterPerMillionYears
                                                               , 201.168 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// chain per septillion years, defined as: SI meter per sextillion years × (20.1168)/(1000.0)
   /// </summary>
   public static readonly Velocity ChainPerSeptillionYears = new (
                                                                  "chain per septillion years"
                                                                , "ch/Yyr"
                                                                , SI.Velocities.MeterPerSextillionYears
                                                                , 20.1168 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// furlong per week, defined as: SI meter per day × (201.168)/(7.0)
   /// </summary>
   public static readonly Velocity FurlongPerWeek = new (
                                                         "furlong per week"
                                                       , "fur/wk"
                                                       , SI.Velocities.MeterPerDay
                                                       , 201.168 / 7.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// league per day, defined as: SI meter per hour × (4828.032)/(24.0)
   /// </summary>
   public static readonly Velocity LeaguePerDay = new (
                                                       "league per day"
                                                     , "lea/dy"
                                                     , SI.Velocities.MeterPerHour
                                                     , 4828.032 / 24.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// chain per decade, defined as: SI meter per year × (20.1168)/(10.0)
   /// </summary>
   public static readonly Velocity ChainPerDecade = new (
                                                         "chain per decade"
                                                       , "ch/decade"
                                                       , SI.Velocities.MeterPerYear
                                                       , 20.1168 / 10.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// rod per quadrillion years, defined as: SI meter per trillion years × (5.0292)/(1000.0)
   /// </summary>
   public static readonly Velocity RodPerQuadrillionYears = new (
                                                                 "rod per quadrillion years"
                                                               , "rd/Pyr"
                                                               , SI.Velocities.MeterPerTrillionYears
                                                               , 5.0292 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// league per nonillion years, defined as: SI meter per octillion years × (4828.032)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerNonillionYears = new (
                                                                  "league per nonillion years"
                                                                , "lea/Qyr"
                                                                , SI.Velocities.MeterPerOctillionYears
                                                                , 4828.032 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// rod per quintillion years, defined as: SI meter per quadrillion years × (5.0292)/(1000.0)
   /// </summary>
   public static readonly Velocity RodPerQuintillionYears = new (
                                                                 "rod per quintillion years"
                                                               , "rd/Eyr"
                                                               , SI.Velocities.MeterPerQuadrillionYears
                                                               , 5.0292 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// league per millennium, defined as: SI meter per century × (4828.032)/(10.0)
   /// </summary>
   public static readonly Velocity LeaguePerMillennium = new (
                                                              "league per millennium"
                                                            , "lea/kyr"
                                                            , SI.Velocities.MeterPerCentury
                                                            , 4828.032 / 10.0
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per octillion years, defined as: SI meter per septillion years × (20.1168)/(1000.0)
   /// </summary>
   public static readonly Velocity ChainPerOctillionYears = new (
                                                                 "chain per octillion years"
                                                               , "ch/Ryr"
                                                               , SI.Velocities.MeterPerSeptillionYears
                                                               , 20.1168 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// chain per century, defined as: SI meter per decade × (20.1168)/(10.0)
   /// </summary>
   public static readonly Velocity ChainPerCentury = new (
                                                          "chain per century"
                                                        , "ch/century"
                                                        , SI.Velocities.MeterPerDecade
                                                        , 20.1168 / 10.0
                                                        , system: "US Survey"
                                                         );

   /// <summary>
   /// rod per sextillion years, defined as: SI meter per quintillion years × (5.0292)/(1000.0)
   /// </summary>
   public static readonly Velocity RodPerSextillionYears = new (
                                                                "rod per sextillion years"
                                                              , "rd/Zyr"
                                                              , SI.Velocities.MeterPerQuintillionYears
                                                              , 5.0292 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per nonillion years, defined as: SI meter per octillion years × (201.168)/(1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerNonillionYears = new (
                                                                   "furlong per nonillion years"
                                                                 , "fur/Qyr"
                                                                 , SI.Velocities.MeterPerOctillionYears
                                                                 , 201.168 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// furlong per trillion years, defined as: SI meter per billion years × (201.168)/(1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerTrillionYears = new (
                                                                  "furlong per trillion years"
                                                                , "fur/Tyr"
                                                                , SI.Velocities.MeterPerBillionYears
                                                                , 201.168 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// furlong per year, defined as: SI meter per day × (201.168)/(365.2525)
   /// </summary>
   public static readonly Velocity FurlongPerYear = new (
                                                         "furlong per year"
                                                       , "fur/yr"
                                                       , SI.Velocities.MeterPerDay
                                                       , 201.168 / 365.2525
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// rod per septillion years, defined as: SI meter per sextillion years × (5.0292)/(1000.0)
   /// </summary>
   public static readonly Velocity RodPerSeptillionYears = new (
                                                                "rod per septillion years"
                                                              , "rd/Yyr"
                                                              , SI.Velocities.MeterPerSextillionYears
                                                              , 5.0292 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// league per quintillion years, defined as: SI meter per quadrillion years × (4828.032)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerQuintillionYears = new (
                                                                    "league per quintillion years"
                                                                  , "lea/Eyr"
                                                                  , SI.Velocities.MeterPerQuadrillionYears
                                                                  , 4828.032 / 1000.0
                                                                  , system: "US Survey"
                                                                   );

   /// <summary>
   /// chain per nonillion years, defined as: SI meter per octillion years × (20.1168)/(1000.0)
   /// </summary>
   public static readonly Velocity ChainPerNonillionYears = new (
                                                                 "chain per nonillion years"
                                                               , "ch/Qyr"
                                                               , SI.Velocities.MeterPerOctillionYears
                                                               , 20.1168 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// league per week, defined as: SI meter per day × (4828.032)/(7.0)
   /// </summary>
   public static readonly Velocity LeaguePerWeek = new (
                                                        "league per week"
                                                      , "lea/wk"
                                                      , SI.Velocities.MeterPerDay
                                                      , 4828.032 / 7.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// chain per millennium, defined as: SI meter per century × (20.1168)/(10.0)
   /// </summary>
   public static readonly Velocity ChainPerMillennium = new (
                                                             "chain per millennium"
                                                           , "ch/kyr"
                                                           , SI.Velocities.MeterPerCentury
                                                           , 20.1168 / 10.0
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// rod per octillion years, defined as: SI meter per septillion years × (5.0292)/(1000.0)
   /// </summary>
   public static readonly Velocity RodPerOctillionYears = new (
                                                               "rod per octillion years"
                                                             , "rd/Ryr"
                                                             , SI.Velocities.MeterPerSeptillionYears
                                                             , 5.0292 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per decillion years, defined as: SI meter per nonillion years × (4828.032)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerDecillionYears = new (
                                                                  "league per decillion years"
                                                                , "lea/decillion yr"
                                                                , SI.Velocities.MeterPerNonillionYears
                                                                , 4828.032 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// rod per nonillion years, defined as: SI meter per octillion years × (5.0292)/(1000.0)
   /// </summary>
   public static readonly Velocity RodPerNonillionYears = new (
                                                               "rod per nonillion years"
                                                             , "rd/Qyr"
                                                             , SI.Velocities.MeterPerOctillionYears
                                                             , 5.0292 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per decillion years, defined as: SI meter per nonillion years × (201.168)/(1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerDecillionYears = new (
                                                                   "furlong per decillion years"
                                                                 , "fur/decillion yr"
                                                                 , SI.Velocities.MeterPerNonillionYears
                                                                 , 201.168 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// league per million years, defined as: SI meter per millennium × (4828.032)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerMillionYears = new (
                                                                "league per million years"
                                                              , "lea/Myr"
                                                              , SI.Velocities.MeterPerMillennium
                                                              , 4828.032 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per quadrillion years, defined as: SI meter per trillion years × (201.168)/(1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerQuadrillionYears = new (
                                                                     "furlong per quadrillion years"
                                                                   , "fur/Pyr"
                                                                   , SI.Velocities.MeterPerTrillionYears
                                                                   , 201.168 / 1000.0
                                                                   , system: "US Survey"
                                                                    );

   /// <summary>
   /// chain per decillion years, defined as: SI meter per nonillion years × (20.1168)/(1000.0)
   /// </summary>
   public static readonly Velocity ChainPerDecillionYears = new (
                                                                 "chain per decillion years"
                                                               , "ch/decillion yr"
                                                               , SI.Velocities.MeterPerNonillionYears
                                                               , 20.1168 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// furlong per decade, defined as: SI meter per year × (201.168)/(10.0)
   /// </summary>
   public static readonly Velocity FurlongPerDecade = new (
                                                           "furlong per decade"
                                                         , "fur/decade"
                                                         , SI.Velocities.MeterPerYear
                                                         , 201.168 / 10.0
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// chain per million years, defined as: SI meter per millennium × (20.1168)/(1000.0)
   /// </summary>
   public static readonly Velocity ChainPerMillionYears = new (
                                                               "chain per million years"
                                                             , "ch/Myr"
                                                             , SI.Velocities.MeterPerMillennium
                                                             , 20.1168 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// rod per decillion years, defined as: SI meter per nonillion years × (5.0292)/(1000.0)
   /// </summary>
   public static readonly Velocity RodPerDecillionYears = new (
                                                               "rod per decillion years"
                                                             , "rd/decillion yr"
                                                             , SI.Velocities.MeterPerNonillionYears
                                                             , 5.0292 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// link per second, defined as: SI meter per second × (0.20116)/(1.0)
   /// </summary>
   public static readonly Velocity LinkPerSecond = new (
                                                        "link per second"
                                                      , "li/s"
                                                      , SI.Velocities.MeterPerSecond
                                                      , 0.20116 / 1.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// link per planck-time, defined as: SI meter per microsecond × (0.20116)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity LinkPerPlanckTime = new (
                                                            "link per planck-time"
                                                          , "li/tₚ"
                                                          , SI.Velocities.MeterPerMicrosecond
                                                          , 0.20116 / 5.391247E-38
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per decisecond, defined as: SI meter per second × (0.20116)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity LinkPerDecisecond = new (
                                                            "link per decisecond"
                                                          , "li/ds"
                                                          , SI.Velocities.MeterPerSecond
                                                          , 0.20116 / (1.0 / 10.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per centisecond, defined as: SI meter per decisecond × (0.20116)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity LinkPerCentisecond = new (
                                                             "link per centisecond"
                                                           , "li/cs"
                                                           , SI.Velocities.MeterPerDecisecond
                                                           , 0.20116 / (1.0 / 10.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per millisecond, defined as: SI meter per centisecond × (0.20116)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity LinkPerMillisecond = new (
                                                             "link per millisecond"
                                                           , "li/ms"
                                                           , SI.Velocities.MeterPerCentisecond
                                                           , 0.20116 / (1.0 / 10.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per microsecond, defined as: SI meter per millisecond × (0.20116)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LinkPerMicrosecond = new (
                                                             "link per microsecond"
                                                           , "li/μs"
                                                           , SI.Velocities.MeterPerMillisecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per nanosecond, defined as: SI meter per microsecond × (0.20116)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LinkPerNanosecond = new (
                                                            "link per nanosecond"
                                                          , "li/ns"
                                                          , SI.Velocities.MeterPerMicrosecond
                                                          , 0.20116 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per picosecond, defined as: SI meter per nanosecond × (0.20116)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LinkPerPicosecond = new (
                                                            "link per picosecond"
                                                          , "li/ps"
                                                          , SI.Velocities.MeterPerNanosecond
                                                          , 0.20116 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per femtosecond, defined as: SI meter per picosecond × (0.20116)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LinkPerFemtosecond = new (
                                                             "link per femtosecond"
                                                           , "li/fs"
                                                           , SI.Velocities.MeterPerPicosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per attosecond, defined as: SI meter per femtosecond × (0.20116)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LinkPerAttosecond = new (
                                                            "link per attosecond"
                                                          , "li/as"
                                                          , SI.Velocities.MeterPerFemtosecond
                                                          , 0.20116 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per zeptosecond, defined as: SI meter per attosecond × (0.20116)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LinkPerZeptosecond = new (
                                                             "link per zeptosecond"
                                                           , "li/zs"
                                                           , SI.Velocities.MeterPerAttosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per yoctosecond, defined as: SI meter per zeptosecond × (0.20116)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LinkPerYoctosecond = new (
                                                             "link per yoctosecond"
                                                           , "li/ys"
                                                           , SI.Velocities.MeterPerZeptosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per rontosecond, defined as: SI meter per yoctosecond × (0.20116)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LinkPerRontosecond = new (
                                                             "link per rontosecond"
                                                           , "li/rs"
                                                           , SI.Velocities.MeterPerYoctosecond
                                                           , 0.20116 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per quectosecond, defined as: SI meter per rontosecond × (0.20116)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LinkPerQuectosecond = new (
                                                              "link per quectosecond"
                                                            , "li/qs"
                                                            , SI.Velocities.MeterPerRontosecond
                                                            , 0.20116 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// link per minute, defined as: SI meter per second × (0.20116)/(60.0)
   /// </summary>
   public static readonly Velocity LinkPerMinute = new (
                                                        "link per minute"
                                                      , "li/min"
                                                      , SI.Velocities.MeterPerSecond
                                                      , 0.20116 / 60.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// rod per second, defined as: SI meter per second × (5.0292)/(1.0)
   /// </summary>
   public static readonly Velocity RodPerSecond = new (
                                                       "rod per second"
                                                     , "rd/s"
                                                     , SI.Velocities.MeterPerSecond
                                                     , 5.0292 / 1.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// rod per planck-time, defined as: SI meter per microsecond × (5.0292)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity RodPerPlanckTime = new (
                                                           "rod per planck-time"
                                                         , "rd/tₚ"
                                                         , SI.Velocities.MeterPerMicrosecond
                                                         , 5.0292 / 5.391247E-38
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// rod per decisecond, defined as: SI meter per second × (5.0292)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity RodPerDecisecond = new (
                                                           "rod per decisecond"
                                                         , "rd/ds"
                                                         , SI.Velocities.MeterPerSecond
                                                         , 5.0292 / (1.0 / 10.0)
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// rod per centisecond, defined as: SI meter per decisecond × (5.0292)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity RodPerCentisecond = new (
                                                            "rod per centisecond"
                                                          , "rd/cs"
                                                          , SI.Velocities.MeterPerDecisecond
                                                          , 5.0292 / (1.0 / 10.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per millisecond, defined as: SI meter per centisecond × (5.0292)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity RodPerMillisecond = new (
                                                            "rod per millisecond"
                                                          , "rd/ms"
                                                          , SI.Velocities.MeterPerCentisecond
                                                          , 5.0292 / (1.0 / 10.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per microsecond, defined as: SI meter per millisecond × (5.0292)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RodPerMicrosecond = new (
                                                            "rod per microsecond"
                                                          , "rd/μs"
                                                          , SI.Velocities.MeterPerMillisecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per nanosecond, defined as: SI meter per microsecond × (5.0292)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RodPerNanosecond = new (
                                                           "rod per nanosecond"
                                                         , "rd/ns"
                                                         , SI.Velocities.MeterPerMicrosecond
                                                         , 5.0292 / (1.0 / 1000.0)
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// rod per picosecond, defined as: SI meter per nanosecond × (5.0292)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RodPerPicosecond = new (
                                                           "rod per picosecond"
                                                         , "rd/ps"
                                                         , SI.Velocities.MeterPerNanosecond
                                                         , 5.0292 / (1.0 / 1000.0)
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// rod per femtosecond, defined as: SI meter per picosecond × (5.0292)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RodPerFemtosecond = new (
                                                            "rod per femtosecond"
                                                          , "rd/fs"
                                                          , SI.Velocities.MeterPerPicosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per attosecond, defined as: SI meter per femtosecond × (5.0292)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RodPerAttosecond = new (
                                                           "rod per attosecond"
                                                         , "rd/as"
                                                         , SI.Velocities.MeterPerFemtosecond
                                                         , 5.0292 / (1.0 / 1000.0)
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// rod per zeptosecond, defined as: SI meter per attosecond × (5.0292)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RodPerZeptosecond = new (
                                                            "rod per zeptosecond"
                                                          , "rd/zs"
                                                          , SI.Velocities.MeterPerAttosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per yoctosecond, defined as: SI meter per zeptosecond × (5.0292)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RodPerYoctosecond = new (
                                                            "rod per yoctosecond"
                                                          , "rd/ys"
                                                          , SI.Velocities.MeterPerZeptosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per rontosecond, defined as: SI meter per yoctosecond × (5.0292)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RodPerRontosecond = new (
                                                            "rod per rontosecond"
                                                          , "rd/rs"
                                                          , SI.Velocities.MeterPerYoctosecond
                                                          , 5.0292 / (1.0 / 1000.0)
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per quectosecond, defined as: SI meter per rontosecond × (5.0292)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RodPerQuectosecond = new (
                                                             "rod per quectosecond"
                                                           , "rd/qs"
                                                           , SI.Velocities.MeterPerRontosecond
                                                           , 5.0292 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// link per hour, defined as: SI meter per minute × (0.20116)/(60.0)
   /// </summary>
   public static readonly Velocity LinkPerHour = new (
                                                      "link per hour"
                                                    , "li/hr"
                                                    , SI.Velocities.MeterPerMinute
                                                    , 0.20116 / 60.0
                                                    , system: "US Survey"
                                                     );

   /// <summary>
   /// chain per second, defined as: SI meter per second × (20.1168)/(1.0)
   /// </summary>
   public static readonly Velocity ChainPerSecond = new (
                                                         "chain per second"
                                                       , "ch/s"
                                                       , SI.Velocities.MeterPerSecond
                                                       , 20.1168 / 1.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// chain per planck-time, defined as: SI meter per microsecond × (20.1168)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity ChainPerPlanckTime = new (
                                                             "chain per planck-time"
                                                           , "ch/tₚ"
                                                           , SI.Velocities.MeterPerMicrosecond
                                                           , 20.1168 / 5.391247E-38
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// chain per decisecond, defined as: SI meter per second × (20.1168)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ChainPerDecisecond = new (
                                                             "chain per decisecond"
                                                           , "ch/ds"
                                                           , SI.Velocities.MeterPerSecond
                                                           , 20.1168 / (1.0 / 10.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// chain per centisecond, defined as: SI meter per decisecond × (20.1168)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ChainPerCentisecond = new (
                                                              "chain per centisecond"
                                                            , "ch/cs"
                                                            , SI.Velocities.MeterPerDecisecond
                                                            , 20.1168 / (1.0 / 10.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per millisecond, defined as: SI meter per centisecond × (20.1168)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ChainPerMillisecond = new (
                                                              "chain per millisecond"
                                                            , "ch/ms"
                                                            , SI.Velocities.MeterPerCentisecond
                                                            , 20.1168 / (1.0 / 10.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per microsecond, defined as: SI meter per millisecond × (20.1168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ChainPerMicrosecond = new (
                                                              "chain per microsecond"
                                                            , "ch/μs"
                                                            , SI.Velocities.MeterPerMillisecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per nanosecond, defined as: SI meter per microsecond × (20.1168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ChainPerNanosecond = new (
                                                             "chain per nanosecond"
                                                           , "ch/ns"
                                                           , SI.Velocities.MeterPerMicrosecond
                                                           , 20.1168 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// chain per picosecond, defined as: SI meter per nanosecond × (20.1168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ChainPerPicosecond = new (
                                                             "chain per picosecond"
                                                           , "ch/ps"
                                                           , SI.Velocities.MeterPerNanosecond
                                                           , 20.1168 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// chain per femtosecond, defined as: SI meter per picosecond × (20.1168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ChainPerFemtosecond = new (
                                                              "chain per femtosecond"
                                                            , "ch/fs"
                                                            , SI.Velocities.MeterPerPicosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per attosecond, defined as: SI meter per femtosecond × (20.1168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ChainPerAttosecond = new (
                                                             "chain per attosecond"
                                                           , "ch/as"
                                                           , SI.Velocities.MeterPerFemtosecond
                                                           , 20.1168 / (1.0 / 1000.0)
                                                           , system: "US Survey"
                                                            );

   /// <summary>
   /// chain per zeptosecond, defined as: SI meter per attosecond × (20.1168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ChainPerZeptosecond = new (
                                                              "chain per zeptosecond"
                                                            , "ch/zs"
                                                            , SI.Velocities.MeterPerAttosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per yoctosecond, defined as: SI meter per zeptosecond × (20.1168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ChainPerYoctosecond = new (
                                                              "chain per yoctosecond"
                                                            , "ch/ys"
                                                            , SI.Velocities.MeterPerZeptosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per rontosecond, defined as: SI meter per yoctosecond × (20.1168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ChainPerRontosecond = new (
                                                              "chain per rontosecond"
                                                            , "ch/rs"
                                                            , SI.Velocities.MeterPerYoctosecond
                                                            , 20.1168 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// chain per quectosecond, defined as: SI meter per rontosecond × (20.1168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ChainPerQuectosecond = new (
                                                               "chain per quectosecond"
                                                             , "ch/qs"
                                                             , SI.Velocities.MeterPerRontosecond
                                                             , 20.1168 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// link per day, defined as: SI meter per hour × (0.20116)/(24.0)
   /// </summary>
   public static readonly Velocity LinkPerDay = new (
                                                     "link per day"
                                                   , "li/dy"
                                                   , SI.Velocities.MeterPerHour
                                                   , 0.20116 / 24.0
                                                   , system: "US Survey"
                                                    );

   /// <summary>
   /// furlong per second, defined as: SI meter per second × (201.168)/(1.0)
   /// </summary>
   public static readonly Velocity FurlongPerSecond = new (
                                                           "furlong per second"
                                                         , "fur/s"
                                                         , SI.Velocities.MeterPerSecond
                                                         , 201.168 / 1.0
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// furlong per planck-time, defined as: SI meter per microsecond × (201.168)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity FurlongPerPlanckTime = new (
                                                               "furlong per planck-time"
                                                             , "fur/tₚ"
                                                             , SI.Velocities.MeterPerMicrosecond
                                                             , 201.168 / 5.391247E-38
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per decisecond, defined as: SI meter per second × (201.168)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FurlongPerDecisecond = new (
                                                               "furlong per decisecond"
                                                             , "fur/ds"
                                                             , SI.Velocities.MeterPerSecond
                                                             , 201.168 / (1.0 / 10.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per centisecond, defined as: SI meter per decisecond × (201.168)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FurlongPerCentisecond = new (
                                                                "furlong per centisecond"
                                                              , "fur/cs"
                                                              , SI.Velocities.MeterPerDecisecond
                                                              , 201.168 / (1.0 / 10.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per millisecond, defined as: SI meter per centisecond × (201.168)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FurlongPerMillisecond = new (
                                                                "furlong per millisecond"
                                                              , "fur/ms"
                                                              , SI.Velocities.MeterPerCentisecond
                                                              , 201.168 / (1.0 / 10.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per microsecond, defined as: SI meter per millisecond × (201.168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerMicrosecond = new (
                                                                "furlong per microsecond"
                                                              , "fur/μs"
                                                              , SI.Velocities.MeterPerMillisecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per nanosecond, defined as: SI meter per microsecond × (201.168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerNanosecond = new (
                                                               "furlong per nanosecond"
                                                             , "fur/ns"
                                                             , SI.Velocities.MeterPerMicrosecond
                                                             , 201.168 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per picosecond, defined as: SI meter per nanosecond × (201.168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerPicosecond = new (
                                                               "furlong per picosecond"
                                                             , "fur/ps"
                                                             , SI.Velocities.MeterPerNanosecond
                                                             , 201.168 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per femtosecond, defined as: SI meter per picosecond × (201.168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerFemtosecond = new (
                                                                "furlong per femtosecond"
                                                              , "fur/fs"
                                                              , SI.Velocities.MeterPerPicosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per attosecond, defined as: SI meter per femtosecond × (201.168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerAttosecond = new (
                                                               "furlong per attosecond"
                                                             , "fur/as"
                                                             , SI.Velocities.MeterPerFemtosecond
                                                             , 201.168 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// furlong per zeptosecond, defined as: SI meter per attosecond × (201.168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerZeptosecond = new (
                                                                "furlong per zeptosecond"
                                                              , "fur/zs"
                                                              , SI.Velocities.MeterPerAttosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per yoctosecond, defined as: SI meter per zeptosecond × (201.168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerYoctosecond = new (
                                                                "furlong per yoctosecond"
                                                              , "fur/ys"
                                                              , SI.Velocities.MeterPerZeptosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per rontosecond, defined as: SI meter per yoctosecond × (201.168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerRontosecond = new (
                                                                "furlong per rontosecond"
                                                              , "fur/rs"
                                                              , SI.Velocities.MeterPerYoctosecond
                                                              , 201.168 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// furlong per quectosecond, defined as: SI meter per rontosecond × (201.168)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerQuectosecond = new (
                                                                 "furlong per quectosecond"
                                                               , "fur/qs"
                                                               , SI.Velocities.MeterPerRontosecond
                                                               , 201.168 / (1.0 / 1000.0)
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// link per week, defined as: SI meter per day × (0.20116)/(7.0)
   /// </summary>
   public static readonly Velocity LinkPerWeek = new (
                                                      "link per week"
                                                    , "li/wk"
                                                    , SI.Velocities.MeterPerDay
                                                    , 0.20116 / 7.0
                                                    , system: "US Survey"
                                                     );

   /// <summary>
   /// league per second, defined as: SI meter per second × (4828.032)/(1.0)
   /// </summary>
   public static readonly Velocity LeaguePerSecond = new (
                                                          "league per second"
                                                        , "lea/s"
                                                        , SI.Velocities.MeterPerSecond
                                                        , 4828.032 / 1.0
                                                        , system: "US Survey"
                                                         );

   /// <summary>
   /// league per planck-time, defined as: SI meter per microsecond × (4828.032)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity LeaguePerPlanckTime = new (
                                                              "league per planck-time"
                                                            , "lea/tₚ"
                                                            , SI.Velocities.MeterPerMicrosecond
                                                            , 4828.032 / 5.391247E-38
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per decisecond, defined as: SI meter per second × (4828.032)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity LeaguePerDecisecond = new (
                                                              "league per decisecond"
                                                            , "lea/ds"
                                                            , SI.Velocities.MeterPerSecond
                                                            , 4828.032 / (1.0 / 10.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per centisecond, defined as: SI meter per decisecond × (4828.032)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity LeaguePerCentisecond = new (
                                                               "league per centisecond"
                                                             , "lea/cs"
                                                             , SI.Velocities.MeterPerDecisecond
                                                             , 4828.032 / (1.0 / 10.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per millisecond, defined as: SI meter per centisecond × (4828.032)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity LeaguePerMillisecond = new (
                                                               "league per millisecond"
                                                             , "lea/ms"
                                                             , SI.Velocities.MeterPerCentisecond
                                                             , 4828.032 / (1.0 / 10.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per microsecond, defined as: SI meter per millisecond × (4828.032)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerMicrosecond = new (
                                                               "league per microsecond"
                                                             , "lea/μs"
                                                             , SI.Velocities.MeterPerMillisecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per nanosecond, defined as: SI meter per microsecond × (4828.032)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerNanosecond = new (
                                                              "league per nanosecond"
                                                            , "lea/ns"
                                                            , SI.Velocities.MeterPerMicrosecond
                                                            , 4828.032 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per picosecond, defined as: SI meter per nanosecond × (4828.032)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerPicosecond = new (
                                                              "league per picosecond"
                                                            , "lea/ps"
                                                            , SI.Velocities.MeterPerNanosecond
                                                            , 4828.032 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per femtosecond, defined as: SI meter per picosecond × (4828.032)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerFemtosecond = new (
                                                               "league per femtosecond"
                                                             , "lea/fs"
                                                             , SI.Velocities.MeterPerPicosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per attosecond, defined as: SI meter per femtosecond × (4828.032)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerAttosecond = new (
                                                              "league per attosecond"
                                                            , "lea/as"
                                                            , SI.Velocities.MeterPerFemtosecond
                                                            , 4828.032 / (1.0 / 1000.0)
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// league per zeptosecond, defined as: SI meter per attosecond × (4828.032)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerZeptosecond = new (
                                                               "league per zeptosecond"
                                                             , "lea/zs"
                                                             , SI.Velocities.MeterPerAttosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per yoctosecond, defined as: SI meter per zeptosecond × (4828.032)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerYoctosecond = new (
                                                               "league per yoctosecond"
                                                             , "lea/ys"
                                                             , SI.Velocities.MeterPerZeptosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per rontosecond, defined as: SI meter per yoctosecond × (4828.032)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerRontosecond = new (
                                                               "league per rontosecond"
                                                             , "lea/rs"
                                                             , SI.Velocities.MeterPerYoctosecond
                                                             , 4828.032 / (1.0 / 1000.0)
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// league per quectosecond, defined as: SI meter per rontosecond × (4828.032)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerQuectosecond = new (
                                                                "league per quectosecond"
                                                              , "lea/qs"
                                                              , SI.Velocities.MeterPerRontosecond
                                                              , 4828.032 / (1.0 / 1000.0)
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// link per year, defined as: SI meter per day × (0.20116)/(365.2525)
   /// </summary>
   public static readonly Velocity LinkPerYear = new (
                                                      "link per year"
                                                    , "li/yr"
                                                    , SI.Velocities.MeterPerDay
                                                    , 0.20116 / 365.2525
                                                    , system: "US Survey"
                                                     );

   /// <summary>
   /// link per decade, defined as: SI meter per year × (0.20116)/(10.0)
   /// </summary>
   public static readonly Velocity LinkPerDecade = new (
                                                        "link per decade"
                                                      , "li/decade"
                                                      , SI.Velocities.MeterPerYear
                                                      , 0.20116 / 10.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// link per century, defined as: SI meter per decade × (0.20116)/(10.0)
   /// </summary>
   public static readonly Velocity LinkPerCentury = new (
                                                         "link per century"
                                                       , "li/century"
                                                       , SI.Velocities.MeterPerDecade
                                                       , 0.20116 / 10.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// link per millennium, defined as: SI meter per century × (0.20116)/(10.0)
   /// </summary>
   public static readonly Velocity LinkPerMillennium = new (
                                                            "link per millennium"
                                                          , "li/kyr"
                                                          , SI.Velocities.MeterPerCentury
                                                          , 0.20116 / 10.0
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// link per million years, defined as: SI meter per millennium × (0.20116)/(1000.0)
   /// </summary>
   public static readonly Velocity LinkPerMillionYears = new (
                                                              "link per million years"
                                                            , "li/Myr"
                                                            , SI.Velocities.MeterPerMillennium
                                                            , 0.20116 / 1000.0
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// link per billion years, defined as: SI meter per million years × (0.20116)/(1000.0)
   /// </summary>
   public static readonly Velocity LinkPerBillionYears = new (
                                                              "link per billion years"
                                                            , "li/Gyr"
                                                            , SI.Velocities.MeterPerMillionYears
                                                            , 0.20116 / 1000.0
                                                            , system: "US Survey"
                                                             );

   /// <summary>
   /// link per trillion years, defined as: SI meter per billion years × (0.20116)/(1000.0)
   /// </summary>
   public static readonly Velocity LinkPerTrillionYears = new (
                                                               "link per trillion years"
                                                             , "li/Tyr"
                                                             , SI.Velocities.MeterPerBillionYears
                                                             , 0.20116 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// link per quadrillion years, defined as: SI meter per trillion years × (0.20116)/(1000.0)
   /// </summary>
   public static readonly Velocity LinkPerQuadrillionYears = new (
                                                                  "link per quadrillion years"
                                                                , "li/Pyr"
                                                                , SI.Velocities.MeterPerTrillionYears
                                                                , 0.20116 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// link per quintillion years, defined as: SI meter per quadrillion years × (0.20116)/(1000.0)
   /// </summary>
   public static readonly Velocity LinkPerQuintillionYears = new (
                                                                  "link per quintillion years"
                                                                , "li/Eyr"
                                                                , SI.Velocities.MeterPerQuadrillionYears
                                                                , 0.20116 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// link per sextillion years, defined as: SI meter per quintillion years × (0.20116)/(1000.0)
   /// </summary>
   public static readonly Velocity LinkPerSextillionYears = new (
                                                                 "link per sextillion years"
                                                               , "li/Zyr"
                                                               , SI.Velocities.MeterPerQuintillionYears
                                                               , 0.20116 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// link per septillion years, defined as: SI meter per sextillion years × (0.20116)/(1000.0)
   /// </summary>
   public static readonly Velocity LinkPerSeptillionYears = new (
                                                                 "link per septillion years"
                                                               , "li/Yyr"
                                                               , SI.Velocities.MeterPerSextillionYears
                                                               , 0.20116 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// link per octillion years, defined as: SI meter per septillion years × (0.20116)/(1000.0)
   /// </summary>
   public static readonly Velocity LinkPerOctillionYears = new (
                                                                "link per octillion years"
                                                              , "li/Ryr"
                                                              , SI.Velocities.MeterPerSeptillionYears
                                                              , 0.20116 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// link per nonillion years, defined as: SI meter per octillion years × (0.20116)/(1000.0)
   /// </summary>
   public static readonly Velocity LinkPerNonillionYears = new (
                                                                "link per nonillion years"
                                                              , "li/Qyr"
                                                              , SI.Velocities.MeterPerOctillionYears
                                                              , 0.20116 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// link per decillion years, defined as: SI meter per nonillion years × (0.20116)/(1000.0)
   /// </summary>
   public static readonly Velocity LinkPerDecillionYears = new (
                                                                "link per decillion years"
                                                              , "li/decillion yr"
                                                              , SI.Velocities.MeterPerNonillionYears
                                                              , 0.20116 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// link per tick, defined as: SI meter per nanosecond × (0.20116)/(100.0)
   /// </summary>
   public static readonly Velocity LinkPerTick = new (
                                                      "link per tick"
                                                    , "li/tick"
                                                    , SI.Velocities.MeterPerNanosecond
                                                    , 0.20116 / 100.0
                                                    , system: "US Survey"
                                                     );

   /// <summary>
   /// league per sextillion years, defined as: SI meter per quintillion years × (4828.032)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerSextillionYears = new (
                                                                   "league per sextillion years"
                                                                 , "lea/Zyr"
                                                                 , SI.Velocities.MeterPerQuintillionYears
                                                                 , 4828.032 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// rod per minute, defined as: SI meter per second × (5.0292)/(60.0)
   /// </summary>
   public static readonly Velocity RodPerMinute = new (
                                                       "rod per minute"
                                                     , "rd/min"
                                                     , SI.Velocities.MeterPerSecond
                                                     , 5.0292 / 60.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// league per year, defined as: SI meter per day × (4828.032)/(365.2525)
   /// </summary>
   public static readonly Velocity LeaguePerYear = new (
                                                        "league per year"
                                                      , "lea/yr"
                                                      , SI.Velocities.MeterPerDay
                                                      , 4828.032 / 365.2525
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// chain per billion years, defined as: SI meter per million years × (20.1168)/(1000.0)
   /// </summary>
   public static readonly Velocity ChainPerBillionYears = new (
                                                               "chain per billion years"
                                                             , "ch/Gyr"
                                                             , SI.Velocities.MeterPerMillionYears
                                                             , 20.1168 / 1000.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// rod per tick, defined as: SI meter per nanosecond × (5.0292)/(100.0)
   /// </summary>
   public static readonly Velocity RodPerTick = new (
                                                     "rod per tick"
                                                   , "rd/tick"
                                                   , SI.Velocities.MeterPerNanosecond
                                                   , 5.0292 / 100.0
                                                   , system: "US Survey"
                                                    );

   /// <summary>
   /// rod per hour, defined as: SI meter per minute × (5.0292)/(60.0)
   /// </summary>
   public static readonly Velocity RodPerHour = new (
                                                     "rod per hour"
                                                   , "rd/hr"
                                                   , SI.Velocities.MeterPerMinute
                                                   , 5.0292 / 60.0
                                                   , system: "US Survey"
                                                    );

   /// <summary>
   /// chain per minute, defined as: SI meter per second × (20.1168)/(60.0)
   /// </summary>
   public static readonly Velocity ChainPerMinute = new (
                                                         "chain per minute"
                                                       , "ch/min"
                                                       , SI.Velocities.MeterPerSecond
                                                       , 20.1168 / 60.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// furlong per quintillion years, defined as: SI meter per quadrillion years × (201.168)/(1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerQuintillionYears = new (
                                                                     "furlong per quintillion years"
                                                                   , "fur/Eyr"
                                                                   , SI.Velocities.MeterPerQuadrillionYears
                                                                   , 201.168 / 1000.0
                                                                   , system: "US Survey"
                                                                    );

   /// <summary>
   /// furlong per century, defined as: SI meter per decade × (201.168)/(10.0)
   /// </summary>
   public static readonly Velocity FurlongPerCentury = new (
                                                            "furlong per century"
                                                          , "fur/century"
                                                          , SI.Velocities.MeterPerDecade
                                                          , 201.168 / 10.0
                                                          , system: "US Survey"
                                                           );

   /// <summary>
   /// rod per day, defined as: SI meter per hour × (5.0292)/(24.0)
   /// </summary>
   public static readonly Velocity RodPerDay = new (
                                                    "rod per day"
                                                  , "rd/dy"
                                                  , SI.Velocities.MeterPerHour
                                                  , 5.0292 / 24.0
                                                  , system: "US Survey"
                                                   );

   /// <summary>
   /// furlong per minute, defined as: SI meter per second × (201.168)/(60.0)
   /// </summary>
   public static readonly Velocity FurlongPerMinute = new (
                                                           "furlong per minute"
                                                         , "fur/min"
                                                         , SI.Velocities.MeterPerSecond
                                                         , 201.168 / 60.0
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// league per billion years, defined as: SI meter per million years × (4828.032)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerBillionYears = new (
                                                                "league per billion years"
                                                              , "lea/Gyr"
                                                              , SI.Velocities.MeterPerMillionYears
                                                              , 4828.032 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// chain per tick, defined as: SI meter per nanosecond × (20.1168)/(100.0)
   /// </summary>
   public static readonly Velocity ChainPerTick = new (
                                                       "chain per tick"
                                                     , "ch/tick"
                                                     , SI.Velocities.MeterPerNanosecond
                                                     , 20.1168 / 100.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// chain per trillion years, defined as: SI meter per billion years × (20.1168)/(1000.0)
   /// </summary>
   public static readonly Velocity ChainPerTrillionYears = new (
                                                                "chain per trillion years"
                                                              , "ch/Tyr"
                                                              , SI.Velocities.MeterPerBillionYears
                                                              , 20.1168 / 1000.0
                                                              , system: "US Survey"
                                                               );

   /// <summary>
   /// chain per hour, defined as: SI meter per minute × (20.1168)/(60.0)
   /// </summary>
   public static readonly Velocity ChainPerHour = new (
                                                       "chain per hour"
                                                     , "ch/hr"
                                                     , SI.Velocities.MeterPerMinute
                                                     , 20.1168 / 60.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// rod per week, defined as: SI meter per day × (5.0292)/(7.0)
   /// </summary>
   public static readonly Velocity RodPerWeek = new (
                                                     "rod per week"
                                                   , "rd/wk"
                                                   , SI.Velocities.MeterPerDay
                                                   , 5.0292 / 7.0
                                                   , system: "US Survey"
                                                    );

   /// <summary>
   /// league per minute, defined as: SI meter per second × (4828.032)/(60.0)
   /// </summary>
   public static readonly Velocity LeaguePerMinute = new (
                                                          "league per minute"
                                                        , "lea/min"
                                                        , SI.Velocities.MeterPerSecond
                                                        , 4828.032 / 60.0
                                                        , system: "US Survey"
                                                         );

   /// <summary>
   /// league per septillion years, defined as: SI meter per sextillion years × (4828.032)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerSeptillionYears = new (
                                                                   "league per septillion years"
                                                                 , "lea/Yyr"
                                                                 , SI.Velocities.MeterPerSextillionYears
                                                                 , 4828.032 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// furlong per tick, defined as: SI meter per nanosecond × (201.168)/(100.0)
   /// </summary>
   public static readonly Velocity FurlongPerTick = new (
                                                         "furlong per tick"
                                                       , "fur/tick"
                                                       , SI.Velocities.MeterPerNanosecond
                                                       , 201.168 / 100.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// rod per year, defined as: SI meter per day × (5.0292)/(365.2525)
   /// </summary>
   public static readonly Velocity RodPerYear = new (
                                                     "rod per year"
                                                   , "rd/yr"
                                                   , SI.Velocities.MeterPerDay
                                                   , 5.0292 / 365.2525
                                                   , system: "US Survey"
                                                    );

   /// <summary>
   /// furlong per sextillion years, defined as: SI meter per quintillion years × (201.168)/(1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerSextillionYears = new (
                                                                    "furlong per sextillion years"
                                                                  , "fur/Zyr"
                                                                  , SI.Velocities.MeterPerQuintillionYears
                                                                  , 201.168 / 1000.0
                                                                  , system: "US Survey"
                                                                   );

   /// <summary>
   /// league per decade, defined as: SI meter per year × (4828.032)/(10.0)
   /// </summary>
   public static readonly Velocity LeaguePerDecade = new (
                                                          "league per decade"
                                                        , "lea/decade"
                                                        , SI.Velocities.MeterPerYear
                                                        , 4828.032 / 10.0
                                                        , system: "US Survey"
                                                         );

   /// <summary>
   /// furlong per millennium, defined as: SI meter per century × (201.168)/(10.0)
   /// </summary>
   public static readonly Velocity FurlongPerMillennium = new (
                                                               "furlong per millennium"
                                                             , "fur/kyr"
                                                             , SI.Velocities.MeterPerCentury
                                                             , 201.168 / 10.0
                                                             , system: "US Survey"
                                                              );

   /// <summary>
   /// chain per quadrillion years, defined as: SI meter per trillion years × (20.1168)/(1000.0)
   /// </summary>
   public static readonly Velocity ChainPerQuadrillionYears = new (
                                                                   "chain per quadrillion years"
                                                                 , "ch/Pyr"
                                                                 , SI.Velocities.MeterPerTrillionYears
                                                                 , 20.1168 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// chain per day, defined as: SI meter per hour × (20.1168)/(24.0)
   /// </summary>
   public static readonly Velocity ChainPerDay = new (
                                                      "chain per day"
                                                    , "ch/dy"
                                                    , SI.Velocities.MeterPerHour
                                                    , 20.1168 / 24.0
                                                    , system: "US Survey"
                                                     );

   /// <summary>
   /// furlong per hour, defined as: SI meter per minute × (201.168)/(60.0)
   /// </summary>
   public static readonly Velocity FurlongPerHour = new (
                                                         "furlong per hour"
                                                       , "fur/hr"
                                                       , SI.Velocities.MeterPerMinute
                                                       , 201.168 / 60.0
                                                       , system: "US Survey"
                                                        );

   /// <summary>
   /// rod per decade, defined as: SI meter per year × (5.0292)/(10.0)
   /// </summary>
   public static readonly Velocity RodPerDecade = new (
                                                       "rod per decade"
                                                     , "rd/decade"
                                                     , SI.Velocities.MeterPerYear
                                                     , 5.0292 / 10.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// league per tick, defined as: SI meter per nanosecond × (4828.032)/(100.0)
   /// </summary>
   public static readonly Velocity LeaguePerTick = new (
                                                        "league per tick"
                                                      , "lea/tick"
                                                      , SI.Velocities.MeterPerNanosecond
                                                      , 4828.032 / 100.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// rod per century, defined as: SI meter per decade × (5.0292)/(10.0)
   /// </summary>
   public static readonly Velocity RodPerCentury = new (
                                                        "rod per century"
                                                      , "rd/century"
                                                      , SI.Velocities.MeterPerDecade
                                                      , 5.0292 / 10.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// league per trillion years, defined as: SI meter per billion years × (4828.032)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerTrillionYears = new (
                                                                 "league per trillion years"
                                                               , "lea/Tyr"
                                                               , SI.Velocities.MeterPerBillionYears
                                                               , 4828.032 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// chain per quintillion years, defined as: SI meter per quadrillion years × (20.1168)/(1000.0)
   /// </summary>
   public static readonly Velocity ChainPerQuintillionYears = new (
                                                                   "chain per quintillion years"
                                                                 , "ch/Eyr"
                                                                 , SI.Velocities.MeterPerQuadrillionYears
                                                                 , 20.1168 / 1000.0
                                                                 , system: "US Survey"
                                                                  );

   /// <summary>
   /// chain per week, defined as: SI meter per day × (20.1168)/(7.0)
   /// </summary>
   public static readonly Velocity ChainPerWeek = new (
                                                       "chain per week"
                                                     , "ch/wk"
                                                     , SI.Velocities.MeterPerDay
                                                     , 20.1168 / 7.0
                                                     , system: "US Survey"
                                                      );

   /// <summary>
   /// league per hour, defined as: SI meter per minute × (4828.032)/(60.0)
   /// </summary>
   public static readonly Velocity LeaguePerHour = new (
                                                        "league per hour"
                                                      , "lea/hr"
                                                      , SI.Velocities.MeterPerMinute
                                                      , 4828.032 / 60.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// rod per millennium, defined as: SI meter per century × (5.0292)/(10.0)
   /// </summary>
   public static readonly Velocity RodPerMillennium = new (
                                                           "rod per millennium"
                                                         , "rd/kyr"
                                                         , SI.Velocities.MeterPerCentury
                                                         , 5.0292 / 10.0
                                                         , system: "US Survey"
                                                          );

   /// <summary>
   /// furlong per septillion years, defined as: SI meter per sextillion years × (201.168)/(1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerSeptillionYears = new (
                                                                    "furlong per septillion years"
                                                                  , "fur/Yyr"
                                                                  , SI.Velocities.MeterPerSextillionYears
                                                                  , 201.168 / 1000.0
                                                                  , system: "US Survey"
                                                                   );

   /// <summary>
   /// furlong per million years, defined as: SI meter per millennium × (201.168)/(1000.0)
   /// </summary>
   public static readonly Velocity FurlongPerMillionYears = new (
                                                                 "furlong per million years"
                                                               , "fur/Myr"
                                                               , SI.Velocities.MeterPerMillennium
                                                               , 201.168 / 1000.0
                                                               , system: "US Survey"
                                                                );

   /// <summary>
   /// league per octillion years, defined as: SI meter per septillion years × (4828.032)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerOctillionYears = new (
                                                                  "league per octillion years"
                                                                , "lea/Ryr"
                                                                , SI.Velocities.MeterPerSeptillionYears
                                                                , 4828.032 / 1000.0
                                                                , system: "US Survey"
                                                                 );

   /// <summary>
   /// furlong per day, defined as: SI meter per hour × (201.168)/(24.0)
   /// </summary>
   public static readonly Velocity FurlongPerDay = new (
                                                        "furlong per day"
                                                      , "fur/dy"
                                                      , SI.Velocities.MeterPerHour
                                                      , 201.168 / 24.0
                                                      , system: "US Survey"
                                                       );

   /// <summary>
   /// rod per million years, defined as: SI meter per millennium × (5.0292)/(1000.0)
   /// </summary>
   public static readonly Velocity RodPerMillionYears = new (
                                                             "rod per million years"
                                                           , "rd/Myr"
                                                           , SI.Velocities.MeterPerMillennium
                                                           , 5.0292 / 1000.0
                                                           , system: "US Survey"
                                                            );
}
