#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

/// <summary>
/// United States Customary Units for measuring Velocity.
/// </summary>
public class Velocities : UnitOfMeasureEnumeration<Velocities, Velocity>
{
   /// <summary>
   /// nautical mile per octillion years, defined as: SI meter per septillion years × (1852.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerOctillionYears = new (
                                                                        "nautical mile per octillion years"
                                                                      , "nmi/Ryr"
                                                                      , SI.Velocities.MeterPerSeptillionYears
                                                                      , 1852.0 / 1000.0
                                                                      , system: "US Customary"
                                                                       );

   /// <summary>
   /// nautical mile per trillion years, defined as: SI meter per billion years × (1852.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerTrillionYears = new (
                                                                       "nautical mile per trillion years"
                                                                     , "nmi/Tyr"
                                                                     , SI.Velocities.MeterPerBillionYears
                                                                     , 1852.0 / 1000.0
                                                                     , system: "US Customary"
                                                                      );

   /// <summary>
   /// nautical mile per decade, defined as: SI meter per year × (1852.0)/(10.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerDecade = new (
                                                                "nautical mile per decade"
                                                              , "nmi/decade"
                                                              , SI.Velocities.MeterPerYear
                                                              , 1852.0 / 10.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// nautical mile per minute, defined as: SI meter per second × (1852.0)/(60.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerMinute = new (
                                                                "nautical mile per minute"
                                                              , "nmi/min"
                                                              , SI.Velocities.MeterPerSecond
                                                              , 1852.0 / 60.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// nautical mile per decillion years, defined as: SI meter per nonillion years × (1852.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerDecillionYears = new (
                                                                        "nautical mile per decillion years"
                                                                      , "nmi/decillion yr"
                                                                      , SI.Velocities.MeterPerNonillionYears
                                                                      , 1852.0 / 1000.0
                                                                      , system: "US Customary"
                                                                       );

   /// <summary>
   /// nautical mile per quintillion years, defined as: SI meter per quadrillion years × (1852.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerQuintillionYears = new (
                                                                          "nautical mile per quintillion years"
                                                                        , "nmi/Eyr"
                                                                        , SI.Velocities.MeterPerQuadrillionYears
                                                                        , 1852.0 / 1000.0
                                                                        , system: "US Customary"
                                                                         );

   /// <summary>
   /// nautical mile per millennium, defined as: SI meter per century × (1852.0)/(10.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerMillennium = new (
                                                                    "nautical mile per millennium"
                                                                  , "nmi/kyr"
                                                                  , SI.Velocities.MeterPerCentury
                                                                  , 1852.0 / 10.0
                                                                  , system: "US Customary"
                                                                   );

   /// <summary>
   /// nautical mile per day, defined as: SI meter per hour × (1852.0)/(24.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerDay = new (
                                                             "nautical mile per day"
                                                           , "nmi/dy"
                                                           , SI.Velocities.MeterPerHour
                                                           , 1852.0 / 24.0
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// nautical mile per tick, defined as: SI meter per nanosecond × (1852.0)/(100.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerTick = new (
                                                              "nautical mile per tick"
                                                            , "nmi/tick"
                                                            , SI.Velocities.MeterPerNanosecond
                                                            , 1852.0 / 100.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// nautical mile per septillion years, defined as: SI meter per sextillion years × (1852.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerSeptillionYears = new (
                                                                         "nautical mile per septillion years"
                                                                       , "nmi/Yyr"
                                                                       , SI.Velocities.MeterPerSextillionYears
                                                                       , 1852.0 / 1000.0
                                                                       , system: "US Customary"
                                                                        );

   /// <summary>
   /// nautical mile per billion years, defined as: SI meter per million years × (1852.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerBillionYears = new (
                                                                      "nautical mile per billion years"
                                                                    , "nmi/Gyr"
                                                                    , SI.Velocities.MeterPerMillionYears
                                                                    , 1852.0 / 1000.0
                                                                    , system: "US Customary"
                                                                     );

   /// <summary>
   /// nautical mile per year, defined as: SI meter per day × (1852.0)/(365.2525)
   /// </summary>
   public static readonly Velocity NauticalMilePerYear = new (
                                                              "nautical mile per year"
                                                            , "nmi/yr"
                                                            , SI.Velocities.MeterPerDay
                                                            , 1852.0 / 365.2525
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// inch per second, defined as: SI centimeter per second × (2.54)/(1.0)
   /// </summary>
   public static readonly Velocity InchPerSecond = new (
                                                        "inch per second"
                                                      , "in/s"
                                                      , SI.Velocities.CentimeterPerSecond
                                                      , 2.54 / 1.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// inch per planck-time, defined as: SI centimeter per microsecond × (2.54)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity InchPerPlanckTime = new (
                                                            "inch per planck-time"
                                                          , "in/tₚ"
                                                          , SI.Velocities.CentimeterPerMicrosecond
                                                          , 2.54 / 5.391247E-38
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// inch per decisecond, defined as: SI centimeter per second × (2.54)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity InchPerDecisecond = new (
                                                            "inch per decisecond"
                                                          , "in/ds"
                                                          , SI.Velocities.CentimeterPerSecond
                                                          , 2.54 / (1.0 / 10.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// inch per centisecond, defined as: SI centimeter per decisecond × (2.54)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity InchPerCentisecond = new (
                                                             "inch per centisecond"
                                                           , "in/cs"
                                                           , SI.Velocities.CentimeterPerDecisecond
                                                           , 2.54 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// inch per millisecond, defined as: SI centimeter per centisecond × (2.54)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity InchPerMillisecond = new (
                                                             "inch per millisecond"
                                                           , "in/ms"
                                                           , SI.Velocities.CentimeterPerCentisecond
                                                           , 2.54 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// inch per microsecond, defined as: SI centimeter per millisecond × (2.54)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity InchPerMicrosecond = new (
                                                             "inch per microsecond"
                                                           , "in/μs"
                                                           , SI.Velocities.CentimeterPerMillisecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// inch per nanosecond, defined as: SI centimeter per microsecond × (2.54)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity InchPerNanosecond = new (
                                                            "inch per nanosecond"
                                                          , "in/ns"
                                                          , SI.Velocities.CentimeterPerMicrosecond
                                                          , 2.54 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// inch per picosecond, defined as: SI centimeter per nanosecond × (2.54)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity InchPerPicosecond = new (
                                                            "inch per picosecond"
                                                          , "in/ps"
                                                          , SI.Velocities.CentimeterPerNanosecond
                                                          , 2.54 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// inch per femtosecond, defined as: SI centimeter per picosecond × (2.54)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity InchPerFemtosecond = new (
                                                             "inch per femtosecond"
                                                           , "in/fs"
                                                           , SI.Velocities.CentimeterPerPicosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// inch per attosecond, defined as: SI centimeter per femtosecond × (2.54)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity InchPerAttosecond = new (
                                                            "inch per attosecond"
                                                          , "in/as"
                                                          , SI.Velocities.CentimeterPerFemtosecond
                                                          , 2.54 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// inch per zeptosecond, defined as: SI centimeter per attosecond × (2.54)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity InchPerZeptosecond = new (
                                                             "inch per zeptosecond"
                                                           , "in/zs"
                                                           , SI.Velocities.CentimeterPerAttosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// inch per yoctosecond, defined as: SI centimeter per zeptosecond × (2.54)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity InchPerYoctosecond = new (
                                                             "inch per yoctosecond"
                                                           , "in/ys"
                                                           , SI.Velocities.CentimeterPerZeptosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// inch per rontosecond, defined as: SI centimeter per yoctosecond × (2.54)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity InchPerRontosecond = new (
                                                             "inch per rontosecond"
                                                           , "in/rs"
                                                           , SI.Velocities.CentimeterPerYoctosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// inch per quectosecond, defined as: SI centimeter per rontosecond × (2.54)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity InchPerQuectosecond = new (
                                                              "inch per quectosecond"
                                                            , "in/qs"
                                                            , SI.Velocities.CentimeterPerRontosecond
                                                            , 2.54 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// inch per minute, defined as: SI centimeter per second × (2.54)/(60.0)
   /// </summary>
   public static readonly Velocity InchPerMinute = new (
                                                        "inch per minute"
                                                      , "in/min"
                                                      , SI.Velocities.CentimeterPerSecond
                                                      , 2.54 / 60.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// mil per second, defined as: inch per second × (1.0/1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity MilPerSecond = new (
                                                       "mil per second"
                                                     , "mil/s"
                                                     , InchPerSecond
                                                     , 1.0 / 1000.0 / 1.0
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// mil per planck-time, defined as: inch per microsecond × (1.0/1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity MilPerPlanckTime = new (
                                                           "mil per planck-time"
                                                         , "mil/tₚ"
                                                         , InchPerMicrosecond
                                                         , 1.0 / 1000.0 / 5.391247E-38
                                                         , system: "US Customary"
                                                          );

   /// <summary>
   /// mil per decisecond, defined as: inch per second × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MilPerDecisecond = new (
                                                           "mil per decisecond"
                                                         , "mil/ds"
                                                         , InchPerSecond
                                                         , 1.0 / 1000.0 / (1.0 / 10.0)
                                                         , system: "US Customary"
                                                          );

   /// <summary>
   /// mil per centisecond, defined as: inch per decisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MilPerCentisecond = new (
                                                            "mil per centisecond"
                                                          , "mil/cs"
                                                          , InchPerDecisecond
                                                          , 1.0 / 1000.0 / (1.0 / 10.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mil per millisecond, defined as: inch per centisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MilPerMillisecond = new (
                                                            "mil per millisecond"
                                                          , "mil/ms"
                                                          , InchPerCentisecond
                                                          , 1.0 / 1000.0 / (1.0 / 10.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mil per microsecond, defined as: inch per millisecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilPerMicrosecond = new (
                                                            "mil per microsecond"
                                                          , "mil/μs"
                                                          , InchPerMillisecond
                                                          , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mil per nanosecond, defined as: inch per microsecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilPerNanosecond = new (
                                                           "mil per nanosecond"
                                                         , "mil/ns"
                                                         , InchPerMicrosecond
                                                         , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                         , system: "US Customary"
                                                          );

   /// <summary>
   /// mil per picosecond, defined as: inch per nanosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilPerPicosecond = new (
                                                           "mil per picosecond"
                                                         , "mil/ps"
                                                         , InchPerNanosecond
                                                         , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                         , system: "US Customary"
                                                          );

   /// <summary>
   /// mil per femtosecond, defined as: inch per picosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilPerFemtosecond = new (
                                                            "mil per femtosecond"
                                                          , "mil/fs"
                                                          , InchPerPicosecond
                                                          , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mil per attosecond, defined as: inch per femtosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilPerAttosecond = new (
                                                           "mil per attosecond"
                                                         , "mil/as"
                                                         , InchPerFemtosecond
                                                         , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                         , system: "US Customary"
                                                          );

   /// <summary>
   /// mil per zeptosecond, defined as: inch per attosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilPerZeptosecond = new (
                                                            "mil per zeptosecond"
                                                          , "mil/zs"
                                                          , InchPerAttosecond
                                                          , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mil per yoctosecond, defined as: inch per zeptosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilPerYoctosecond = new (
                                                            "mil per yoctosecond"
                                                          , "mil/ys"
                                                          , InchPerZeptosecond
                                                          , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mil per rontosecond, defined as: inch per yoctosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilPerRontosecond = new (
                                                            "mil per rontosecond"
                                                          , "mil/rs"
                                                          , InchPerYoctosecond
                                                          , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mil per quectosecond, defined as: inch per rontosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilPerQuectosecond = new (
                                                             "mil per quectosecond"
                                                           , "mil/qs"
                                                           , InchPerRontosecond
                                                           , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// inch per hour, defined as: SI centimeter per minute × (2.54)/(60.0)
   /// </summary>
   public static readonly Velocity InchPerHour = new (
                                                      "inch per hour"
                                                    , "in/hr"
                                                    , SI.Velocities.CentimeterPerMinute
                                                    , 2.54 / 60.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// point per second, defined as: inch per second × (1.0/72.0)/(1.0)
   /// </summary>
   public static readonly Velocity PointPerSecond = new (
                                                         "point per second"
                                                       , "p/s"
                                                       , InchPerSecond
                                                       , 1.0 / 72.0 / 1.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// point per planck-time, defined as: inch per microsecond × (1.0/72.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity PointPerPlanckTime = new (
                                                             "point per planck-time"
                                                           , "p/tₚ"
                                                           , InchPerMicrosecond
                                                           , 1.0 / 72.0 / 5.391247E-38
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// point per decisecond, defined as: inch per second × (1.0/72.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PointPerDecisecond = new (
                                                             "point per decisecond"
                                                           , "p/ds"
                                                           , InchPerSecond
                                                           , 1.0 / 72.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// point per centisecond, defined as: inch per decisecond × (1.0/72.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PointPerCentisecond = new (
                                                              "point per centisecond"
                                                            , "p/cs"
                                                            , InchPerDecisecond
                                                            , 1.0 / 72.0 / (1.0 / 10.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// point per millisecond, defined as: inch per centisecond × (1.0/72.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PointPerMillisecond = new (
                                                              "point per millisecond"
                                                            , "p/ms"
                                                            , InchPerCentisecond
                                                            , 1.0 / 72.0 / (1.0 / 10.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// point per microsecond, defined as: inch per millisecond × (1.0/72.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PointPerMicrosecond = new (
                                                              "point per microsecond"
                                                            , "p/μs"
                                                            , InchPerMillisecond
                                                            , 1.0 / 72.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// point per nanosecond, defined as: inch per microsecond × (1.0/72.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PointPerNanosecond = new (
                                                             "point per nanosecond"
                                                           , "p/ns"
                                                           , InchPerMicrosecond
                                                           , 1.0 / 72.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// point per picosecond, defined as: inch per nanosecond × (1.0/72.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PointPerPicosecond = new (
                                                             "point per picosecond"
                                                           , "p/ps"
                                                           , InchPerNanosecond
                                                           , 1.0 / 72.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// point per femtosecond, defined as: inch per picosecond × (1.0/72.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PointPerFemtosecond = new (
                                                              "point per femtosecond"
                                                            , "p/fs"
                                                            , InchPerPicosecond
                                                            , 1.0 / 72.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// point per attosecond, defined as: inch per femtosecond × (1.0/72.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PointPerAttosecond = new (
                                                             "point per attosecond"
                                                           , "p/as"
                                                           , InchPerFemtosecond
                                                           , 1.0 / 72.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// point per zeptosecond, defined as: inch per attosecond × (1.0/72.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PointPerZeptosecond = new (
                                                              "point per zeptosecond"
                                                            , "p/zs"
                                                            , InchPerAttosecond
                                                            , 1.0 / 72.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// point per yoctosecond, defined as: inch per zeptosecond × (1.0/72.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PointPerYoctosecond = new (
                                                              "point per yoctosecond"
                                                            , "p/ys"
                                                            , InchPerZeptosecond
                                                            , 1.0 / 72.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// point per rontosecond, defined as: inch per yoctosecond × (1.0/72.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PointPerRontosecond = new (
                                                              "point per rontosecond"
                                                            , "p/rs"
                                                            , InchPerYoctosecond
                                                            , 1.0 / 72.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// point per quectosecond, defined as: inch per rontosecond × (1.0/72.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PointPerQuectosecond = new (
                                                               "point per quectosecond"
                                                             , "p/qs"
                                                             , InchPerRontosecond
                                                             , 1.0 / 72.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// inch per day, defined as: SI centimeter per hour × (2.54)/(24.0)
   /// </summary>
   public static readonly Velocity InchPerDay = new (
                                                     "inch per day"
                                                   , "in/dy"
                                                   , SI.Velocities.CentimeterPerHour
                                                   , 2.54 / 24.0
                                                   , system: "US Customary"
                                                    );

   /// <summary>
   /// twip per second, defined as: point per second × (1.0/20.0)/(1.0)
   /// </summary>
   public static readonly Velocity TwipPerSecond = new (
                                                        "twip per second"
                                                      , "twip/s"
                                                      , PointPerSecond
                                                      , 1.0 / 20.0 / 1.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// twip per planck-time, defined as: point per microsecond × (1.0/20.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity TwipPerPlanckTime = new (
                                                            "twip per planck-time"
                                                          , "twip/tₚ"
                                                          , PointPerMicrosecond
                                                          , 1.0 / 20.0 / 5.391247E-38
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// twip per decisecond, defined as: point per second × (1.0/20.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity TwipPerDecisecond = new (
                                                            "twip per decisecond"
                                                          , "twip/ds"
                                                          , PointPerSecond
                                                          , 1.0 / 20.0 / (1.0 / 10.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// twip per centisecond, defined as: point per decisecond × (1.0/20.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity TwipPerCentisecond = new (
                                                             "twip per centisecond"
                                                           , "twip/cs"
                                                           , PointPerDecisecond
                                                           , 1.0 / 20.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// twip per millisecond, defined as: point per centisecond × (1.0/20.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity TwipPerMillisecond = new (
                                                             "twip per millisecond"
                                                           , "twip/ms"
                                                           , PointPerCentisecond
                                                           , 1.0 / 20.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// twip per microsecond, defined as: point per millisecond × (1.0/20.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TwipPerMicrosecond = new (
                                                             "twip per microsecond"
                                                           , "twip/μs"
                                                           , PointPerMillisecond
                                                           , 1.0 / 20.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// twip per nanosecond, defined as: point per microsecond × (1.0/20.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TwipPerNanosecond = new (
                                                            "twip per nanosecond"
                                                          , "twip/ns"
                                                          , PointPerMicrosecond
                                                          , 1.0 / 20.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// twip per picosecond, defined as: point per nanosecond × (1.0/20.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TwipPerPicosecond = new (
                                                            "twip per picosecond"
                                                          , "twip/ps"
                                                          , PointPerNanosecond
                                                          , 1.0 / 20.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// twip per femtosecond, defined as: point per picosecond × (1.0/20.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TwipPerFemtosecond = new (
                                                             "twip per femtosecond"
                                                           , "twip/fs"
                                                           , PointPerPicosecond
                                                           , 1.0 / 20.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// twip per attosecond, defined as: point per femtosecond × (1.0/20.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TwipPerAttosecond = new (
                                                            "twip per attosecond"
                                                          , "twip/as"
                                                          , PointPerFemtosecond
                                                          , 1.0 / 20.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// twip per zeptosecond, defined as: point per attosecond × (1.0/20.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TwipPerZeptosecond = new (
                                                             "twip per zeptosecond"
                                                           , "twip/zs"
                                                           , PointPerAttosecond
                                                           , 1.0 / 20.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// twip per yoctosecond, defined as: point per zeptosecond × (1.0/20.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TwipPerYoctosecond = new (
                                                             "twip per yoctosecond"
                                                           , "twip/ys"
                                                           , PointPerZeptosecond
                                                           , 1.0 / 20.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// twip per rontosecond, defined as: point per yoctosecond × (1.0/20.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TwipPerRontosecond = new (
                                                             "twip per rontosecond"
                                                           , "twip/rs"
                                                           , PointPerYoctosecond
                                                           , 1.0 / 20.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// twip per quectosecond, defined as: point per rontosecond × (1.0/20.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TwipPerQuectosecond = new (
                                                              "twip per quectosecond"
                                                            , "twip/qs"
                                                            , PointPerRontosecond
                                                            , 1.0 / 20.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// inch per week, defined as: SI centimeter per day × (2.54)/(7.0)
   /// </summary>
   public static readonly Velocity InchPerWeek = new (
                                                      "inch per week"
                                                    , "in/wk"
                                                    , SI.Velocities.CentimeterPerDay
                                                    , 2.54 / 7.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// pica per second, defined as: point per second × (12.0)/(1.0)
   /// </summary>
   public static readonly Velocity PicaPerSecond = new (
                                                        "pica per second"
                                                      , "P/s"
                                                      , PointPerSecond
                                                      , 12.0 / 1.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// pica per planck-time, defined as: point per microsecond × (12.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity PicaPerPlanckTime = new (
                                                            "pica per planck-time"
                                                          , "P/tₚ"
                                                          , PointPerMicrosecond
                                                          , 12.0 / 5.391247E-38
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// pica per decisecond, defined as: point per second × (12.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PicaPerDecisecond = new (
                                                            "pica per decisecond"
                                                          , "P/ds"
                                                          , PointPerSecond
                                                          , 12.0 / (1.0 / 10.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// pica per centisecond, defined as: point per decisecond × (12.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PicaPerCentisecond = new (
                                                             "pica per centisecond"
                                                           , "P/cs"
                                                           , PointPerDecisecond
                                                           , 12.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// pica per millisecond, defined as: point per centisecond × (12.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PicaPerMillisecond = new (
                                                             "pica per millisecond"
                                                           , "P/ms"
                                                           , PointPerCentisecond
                                                           , 12.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// pica per microsecond, defined as: point per millisecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicaPerMicrosecond = new (
                                                             "pica per microsecond"
                                                           , "P/μs"
                                                           , PointPerMillisecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// pica per nanosecond, defined as: point per microsecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicaPerNanosecond = new (
                                                            "pica per nanosecond"
                                                          , "P/ns"
                                                          , PointPerMicrosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// pica per picosecond, defined as: point per nanosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicaPerPicosecond = new (
                                                            "pica per picosecond"
                                                          , "P/ps"
                                                          , PointPerNanosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// pica per femtosecond, defined as: point per picosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicaPerFemtosecond = new (
                                                             "pica per femtosecond"
                                                           , "P/fs"
                                                           , PointPerPicosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// pica per attosecond, defined as: point per femtosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicaPerAttosecond = new (
                                                            "pica per attosecond"
                                                          , "P/as"
                                                          , PointPerFemtosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// pica per zeptosecond, defined as: point per attosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicaPerZeptosecond = new (
                                                             "pica per zeptosecond"
                                                           , "P/zs"
                                                           , PointPerAttosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// pica per yoctosecond, defined as: point per zeptosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicaPerYoctosecond = new (
                                                             "pica per yoctosecond"
                                                           , "P/ys"
                                                           , PointPerZeptosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// pica per rontosecond, defined as: point per yoctosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicaPerRontosecond = new (
                                                             "pica per rontosecond"
                                                           , "P/rs"
                                                           , PointPerYoctosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// pica per quectosecond, defined as: point per rontosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicaPerQuectosecond = new (
                                                              "pica per quectosecond"
                                                            , "P/qs"
                                                            , PointPerRontosecond
                                                            , 12.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// inch per year, defined as: SI centimeter per day × (2.54)/(365.2525)
   /// </summary>
   public static readonly Velocity InchPerYear = new (
                                                      "inch per year"
                                                    , "in/yr"
                                                    , SI.Velocities.CentimeterPerDay
                                                    , 2.54 / 365.2525
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// foot per second, defined as: inch per second × (12.0)/(1.0)
   /// </summary>
   public static readonly Velocity FootPerSecond = new (
                                                        "foot per second"
                                                      , "ft/s"
                                                      , InchPerSecond
                                                      , 12.0 / 1.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// foot per planck-time, defined as: inch per microsecond × (12.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity FootPerPlanckTime = new (
                                                            "foot per planck-time"
                                                          , "ft/tₚ"
                                                          , InchPerMicrosecond
                                                          , 12.0 / 5.391247E-38
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// foot per decisecond, defined as: inch per second × (12.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FootPerDecisecond = new (
                                                            "foot per decisecond"
                                                          , "ft/ds"
                                                          , InchPerSecond
                                                          , 12.0 / (1.0 / 10.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// foot per centisecond, defined as: inch per decisecond × (12.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FootPerCentisecond = new (
                                                             "foot per centisecond"
                                                           , "ft/cs"
                                                           , InchPerDecisecond
                                                           , 12.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// foot per millisecond, defined as: inch per centisecond × (12.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FootPerMillisecond = new (
                                                             "foot per millisecond"
                                                           , "ft/ms"
                                                           , InchPerCentisecond
                                                           , 12.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// foot per microsecond, defined as: inch per millisecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FootPerMicrosecond = new (
                                                             "foot per microsecond"
                                                           , "ft/μs"
                                                           , InchPerMillisecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// foot per nanosecond, defined as: inch per microsecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FootPerNanosecond = new (
                                                            "foot per nanosecond"
                                                          , "ft/ns"
                                                          , InchPerMicrosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// foot per picosecond, defined as: inch per nanosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FootPerPicosecond = new (
                                                            "foot per picosecond"
                                                          , "ft/ps"
                                                          , InchPerNanosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// foot per femtosecond, defined as: inch per picosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FootPerFemtosecond = new (
                                                             "foot per femtosecond"
                                                           , "ft/fs"
                                                           , InchPerPicosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// foot per attosecond, defined as: inch per femtosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FootPerAttosecond = new (
                                                            "foot per attosecond"
                                                          , "ft/as"
                                                          , InchPerFemtosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// foot per zeptosecond, defined as: inch per attosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FootPerZeptosecond = new (
                                                             "foot per zeptosecond"
                                                           , "ft/zs"
                                                           , InchPerAttosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// foot per yoctosecond, defined as: inch per zeptosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FootPerYoctosecond = new (
                                                             "foot per yoctosecond"
                                                           , "ft/ys"
                                                           , InchPerZeptosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// foot per rontosecond, defined as: inch per yoctosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FootPerRontosecond = new (
                                                             "foot per rontosecond"
                                                           , "ft/rs"
                                                           , InchPerYoctosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// foot per quectosecond, defined as: inch per rontosecond × (12.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FootPerQuectosecond = new (
                                                              "foot per quectosecond"
                                                            , "ft/qs"
                                                            , InchPerRontosecond
                                                            , 12.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// inch per decade, defined as: SI centimeter per year × (2.54)/(10.0)
   /// </summary>
   public static readonly Velocity InchPerDecade = new (
                                                        "inch per decade"
                                                      , "in/decade"
                                                      , SI.Velocities.CentimeterPerYear
                                                      , 2.54 / 10.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// yard per second, defined as: foot per second × (3.0)/(1.0)
   /// </summary>
   public static readonly Velocity YardPerSecond = new (
                                                        "yard per second"
                                                      , "yd/s"
                                                      , FootPerSecond
                                                      , 3.0 / 1.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// yard per planck-time, defined as: foot per microsecond × (3.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity YardPerPlanckTime = new (
                                                            "yard per planck-time"
                                                          , "yd/tₚ"
                                                          , FootPerMicrosecond
                                                          , 3.0 / 5.391247E-38
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// yard per decisecond, defined as: foot per second × (3.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity YardPerDecisecond = new (
                                                            "yard per decisecond"
                                                          , "yd/ds"
                                                          , FootPerSecond
                                                          , 3.0 / (1.0 / 10.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// yard per centisecond, defined as: foot per decisecond × (3.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity YardPerCentisecond = new (
                                                             "yard per centisecond"
                                                           , "yd/cs"
                                                           , FootPerDecisecond
                                                           , 3.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// yard per millisecond, defined as: foot per centisecond × (3.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity YardPerMillisecond = new (
                                                             "yard per millisecond"
                                                           , "yd/ms"
                                                           , FootPerCentisecond
                                                           , 3.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// yard per microsecond, defined as: foot per millisecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YardPerMicrosecond = new (
                                                             "yard per microsecond"
                                                           , "yd/μs"
                                                           , FootPerMillisecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// yard per nanosecond, defined as: foot per microsecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YardPerNanosecond = new (
                                                            "yard per nanosecond"
                                                          , "yd/ns"
                                                          , FootPerMicrosecond
                                                          , 3.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// yard per picosecond, defined as: foot per nanosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YardPerPicosecond = new (
                                                            "yard per picosecond"
                                                          , "yd/ps"
                                                          , FootPerNanosecond
                                                          , 3.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// yard per femtosecond, defined as: foot per picosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YardPerFemtosecond = new (
                                                             "yard per femtosecond"
                                                           , "yd/fs"
                                                           , FootPerPicosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// yard per attosecond, defined as: foot per femtosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YardPerAttosecond = new (
                                                            "yard per attosecond"
                                                          , "yd/as"
                                                          , FootPerFemtosecond
                                                          , 3.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// yard per zeptosecond, defined as: foot per attosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YardPerZeptosecond = new (
                                                             "yard per zeptosecond"
                                                           , "yd/zs"
                                                           , FootPerAttosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// yard per yoctosecond, defined as: foot per zeptosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YardPerYoctosecond = new (
                                                             "yard per yoctosecond"
                                                           , "yd/ys"
                                                           , FootPerZeptosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// yard per rontosecond, defined as: foot per yoctosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YardPerRontosecond = new (
                                                             "yard per rontosecond"
                                                           , "yd/rs"
                                                           , FootPerYoctosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// yard per quectosecond, defined as: foot per rontosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YardPerQuectosecond = new (
                                                              "yard per quectosecond"
                                                            , "yd/qs"
                                                            , FootPerRontosecond
                                                            , 3.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// inch per century, defined as: SI centimeter per decade × (2.54)/(10.0)
   /// </summary>
   public static readonly Velocity InchPerCentury = new (
                                                         "inch per century"
                                                       , "in/century"
                                                       , SI.Velocities.CentimeterPerDecade
                                                       , 2.54 / 10.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// mile per second, defined as: yard per second × (1760.0)/(1.0)
   /// </summary>
   public static readonly Velocity MilePerSecond = new (
                                                        "mile per second"
                                                      , "mi/s"
                                                      , YardPerSecond
                                                      , 1760.0 / 1.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// mile per planck-time, defined as: yard per microsecond × (1760.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity MilePerPlanckTime = new (
                                                            "mile per planck-time"
                                                          , "mi/tₚ"
                                                          , YardPerMicrosecond
                                                          , 1760.0 / 5.391247E-38
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mile per decisecond, defined as: yard per second × (1760.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MilePerDecisecond = new (
                                                            "mile per decisecond"
                                                          , "mi/ds"
                                                          , YardPerSecond
                                                          , 1760.0 / (1.0 / 10.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mile per centisecond, defined as: yard per decisecond × (1760.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MilePerCentisecond = new (
                                                             "mile per centisecond"
                                                           , "mi/cs"
                                                           , YardPerDecisecond
                                                           , 1760.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// mile per millisecond, defined as: yard per centisecond × (1760.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MilePerMillisecond = new (
                                                             "mile per millisecond"
                                                           , "mi/ms"
                                                           , YardPerCentisecond
                                                           , 1760.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// mile per microsecond, defined as: yard per millisecond × (1760.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilePerMicrosecond = new (
                                                             "mile per microsecond"
                                                           , "mi/μs"
                                                           , YardPerMillisecond
                                                           , 1760.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// mile per nanosecond, defined as: yard per microsecond × (1760.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilePerNanosecond = new (
                                                            "mile per nanosecond"
                                                          , "mi/ns"
                                                          , YardPerMicrosecond
                                                          , 1760.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mile per picosecond, defined as: yard per nanosecond × (1760.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilePerPicosecond = new (
                                                            "mile per picosecond"
                                                          , "mi/ps"
                                                          , YardPerNanosecond
                                                          , 1760.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mile per femtosecond, defined as: yard per picosecond × (1760.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilePerFemtosecond = new (
                                                             "mile per femtosecond"
                                                           , "mi/fs"
                                                           , YardPerPicosecond
                                                           , 1760.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// mile per attosecond, defined as: yard per femtosecond × (1760.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilePerAttosecond = new (
                                                            "mile per attosecond"
                                                          , "mi/as"
                                                          , YardPerFemtosecond
                                                          , 1760.0 / (1.0 / 1000.0)
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// mile per zeptosecond, defined as: yard per attosecond × (1760.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilePerZeptosecond = new (
                                                             "mile per zeptosecond"
                                                           , "mi/zs"
                                                           , YardPerAttosecond
                                                           , 1760.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// mile per yoctosecond, defined as: yard per zeptosecond × (1760.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilePerYoctosecond = new (
                                                             "mile per yoctosecond"
                                                           , "mi/ys"
                                                           , YardPerZeptosecond
                                                           , 1760.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// mile per rontosecond, defined as: yard per yoctosecond × (1760.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilePerRontosecond = new (
                                                             "mile per rontosecond"
                                                           , "mi/rs"
                                                           , YardPerYoctosecond
                                                           , 1760.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// mile per quectosecond, defined as: yard per rontosecond × (1760.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MilePerQuectosecond = new (
                                                              "mile per quectosecond"
                                                            , "mi/qs"
                                                            , YardPerRontosecond
                                                            , 1760.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// inch per millennium, defined as: SI centimeter per century × (2.54)/(10.0)
   /// </summary>
   public static readonly Velocity InchPerMillennium = new (
                                                            "inch per millennium"
                                                          , "in/kyr"
                                                          , SI.Velocities.CentimeterPerCentury
                                                          , 2.54 / 10.0
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// league per second, defined as: mile per second × (3.0)/(1.0)
   /// </summary>
   public static readonly Velocity LeaguePerSecond = new (
                                                          "league per second"
                                                        , "le/s"
                                                        , MilePerSecond
                                                        , 3.0 / 1.0
                                                        , system: "US Customary"
                                                         );

   /// <summary>
   /// league per planck-time, defined as: mile per microsecond × (3.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity LeaguePerPlanckTime = new (
                                                              "league per planck-time"
                                                            , "le/tₚ"
                                                            , MilePerMicrosecond
                                                            , 3.0 / 5.391247E-38
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// league per decisecond, defined as: mile per second × (3.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity LeaguePerDecisecond = new (
                                                              "league per decisecond"
                                                            , "le/ds"
                                                            , MilePerSecond
                                                            , 3.0 / (1.0 / 10.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// league per centisecond, defined as: mile per decisecond × (3.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity LeaguePerCentisecond = new (
                                                               "league per centisecond"
                                                             , "le/cs"
                                                             , MilePerDecisecond
                                                             , 3.0 / (1.0 / 10.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// league per millisecond, defined as: mile per centisecond × (3.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity LeaguePerMillisecond = new (
                                                               "league per millisecond"
                                                             , "le/ms"
                                                             , MilePerCentisecond
                                                             , 3.0 / (1.0 / 10.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// league per microsecond, defined as: mile per millisecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerMicrosecond = new (
                                                               "league per microsecond"
                                                             , "le/μs"
                                                             , MilePerMillisecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// league per nanosecond, defined as: mile per microsecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerNanosecond = new (
                                                              "league per nanosecond"
                                                            , "le/ns"
                                                            , MilePerMicrosecond
                                                            , 3.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// league per picosecond, defined as: mile per nanosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerPicosecond = new (
                                                              "league per picosecond"
                                                            , "le/ps"
                                                            , MilePerNanosecond
                                                            , 3.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// league per femtosecond, defined as: mile per picosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerFemtosecond = new (
                                                               "league per femtosecond"
                                                             , "le/fs"
                                                             , MilePerPicosecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// league per attosecond, defined as: mile per femtosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerAttosecond = new (
                                                              "league per attosecond"
                                                            , "le/as"
                                                            , MilePerFemtosecond
                                                            , 3.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// league per zeptosecond, defined as: mile per attosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerZeptosecond = new (
                                                               "league per zeptosecond"
                                                             , "le/zs"
                                                             , MilePerAttosecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// league per yoctosecond, defined as: mile per zeptosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerYoctosecond = new (
                                                               "league per yoctosecond"
                                                             , "le/ys"
                                                             , MilePerZeptosecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// league per rontosecond, defined as: mile per yoctosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerRontosecond = new (
                                                               "league per rontosecond"
                                                             , "le/rs"
                                                             , MilePerYoctosecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// league per quectosecond, defined as: mile per rontosecond × (3.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerQuectosecond = new (
                                                                "league per quectosecond"
                                                              , "le/qs"
                                                              , MilePerRontosecond
                                                              , 3.0 / (1.0 / 1000.0)
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// inch per million years, defined as: SI centimeter per millennium × (2.54)/(1000.0)
   /// </summary>
   public static readonly Velocity InchPerMillionYears = new (
                                                              "inch per million years"
                                                            , "in/Myr"
                                                            , SI.Velocities.CentimeterPerMillennium
                                                            , 2.54 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// fathom per second, defined as: yard per second × (2.0)/(1.0)
   /// </summary>
   public static readonly Velocity FathomPerSecond = new (
                                                          "fathom per second"
                                                        , "ftm/s"
                                                        , YardPerSecond
                                                        , 2.0 / 1.0
                                                        , system: "US Customary"
                                                         );

   /// <summary>
   /// fathom per planck-time, defined as: yard per microsecond × (2.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity FathomPerPlanckTime = new (
                                                              "fathom per planck-time"
                                                            , "ftm/tₚ"
                                                            , YardPerMicrosecond
                                                            , 2.0 / 5.391247E-38
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// fathom per decisecond, defined as: yard per second × (2.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FathomPerDecisecond = new (
                                                              "fathom per decisecond"
                                                            , "ftm/ds"
                                                            , YardPerSecond
                                                            , 2.0 / (1.0 / 10.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// fathom per centisecond, defined as: yard per decisecond × (2.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FathomPerCentisecond = new (
                                                               "fathom per centisecond"
                                                             , "ftm/cs"
                                                             , YardPerDecisecond
                                                             , 2.0 / (1.0 / 10.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// fathom per millisecond, defined as: yard per centisecond × (2.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FathomPerMillisecond = new (
                                                               "fathom per millisecond"
                                                             , "ftm/ms"
                                                             , YardPerCentisecond
                                                             , 2.0 / (1.0 / 10.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// fathom per microsecond, defined as: yard per millisecond × (2.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FathomPerMicrosecond = new (
                                                               "fathom per microsecond"
                                                             , "ftm/μs"
                                                             , YardPerMillisecond
                                                             , 2.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// fathom per nanosecond, defined as: yard per microsecond × (2.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FathomPerNanosecond = new (
                                                              "fathom per nanosecond"
                                                            , "ftm/ns"
                                                            , YardPerMicrosecond
                                                            , 2.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// fathom per picosecond, defined as: yard per nanosecond × (2.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FathomPerPicosecond = new (
                                                              "fathom per picosecond"
                                                            , "ftm/ps"
                                                            , YardPerNanosecond
                                                            , 2.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// fathom per femtosecond, defined as: yard per picosecond × (2.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FathomPerFemtosecond = new (
                                                               "fathom per femtosecond"
                                                             , "ftm/fs"
                                                             , YardPerPicosecond
                                                             , 2.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// fathom per attosecond, defined as: yard per femtosecond × (2.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FathomPerAttosecond = new (
                                                              "fathom per attosecond"
                                                            , "ftm/as"
                                                            , YardPerFemtosecond
                                                            , 2.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// fathom per zeptosecond, defined as: yard per attosecond × (2.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FathomPerZeptosecond = new (
                                                               "fathom per zeptosecond"
                                                             , "ftm/zs"
                                                             , YardPerAttosecond
                                                             , 2.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// fathom per yoctosecond, defined as: yard per zeptosecond × (2.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FathomPerYoctosecond = new (
                                                               "fathom per yoctosecond"
                                                             , "ftm/ys"
                                                             , YardPerZeptosecond
                                                             , 2.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// fathom per rontosecond, defined as: yard per yoctosecond × (2.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FathomPerRontosecond = new (
                                                               "fathom per rontosecond"
                                                             , "ftm/rs"
                                                             , YardPerYoctosecond
                                                             , 2.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// fathom per quectosecond, defined as: yard per rontosecond × (2.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FathomPerQuectosecond = new (
                                                                "fathom per quectosecond"
                                                              , "ftm/qs"
                                                              , YardPerRontosecond
                                                              , 2.0 / (1.0 / 1000.0)
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// inch per billion years, defined as: SI centimeter per million years × (2.54)/(1000.0)
   /// </summary>
   public static readonly Velocity InchPerBillionYears = new (
                                                              "inch per billion years"
                                                            , "in/Gyr"
                                                            , SI.Velocities.CentimeterPerMillionYears
                                                            , 2.54 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// cable per second, defined as: fathom per second × (120.0)/(1.0)
   /// </summary>
   public static readonly Velocity CablePerSecond = new (
                                                         "cable per second"
                                                       , "cb/s"
                                                       , FathomPerSecond
                                                       , 120.0 / 1.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// cable per planck-time, defined as: fathom per microsecond × (120.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity CablePerPlanckTime = new (
                                                             "cable per planck-time"
                                                           , "cb/tₚ"
                                                           , FathomPerMicrosecond
                                                           , 120.0 / 5.391247E-38
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// cable per decisecond, defined as: fathom per second × (120.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity CablePerDecisecond = new (
                                                             "cable per decisecond"
                                                           , "cb/ds"
                                                           , FathomPerSecond
                                                           , 120.0 / (1.0 / 10.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// cable per centisecond, defined as: fathom per decisecond × (120.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity CablePerCentisecond = new (
                                                              "cable per centisecond"
                                                            , "cb/cs"
                                                            , FathomPerDecisecond
                                                            , 120.0 / (1.0 / 10.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// cable per millisecond, defined as: fathom per centisecond × (120.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity CablePerMillisecond = new (
                                                              "cable per millisecond"
                                                            , "cb/ms"
                                                            , FathomPerCentisecond
                                                            , 120.0 / (1.0 / 10.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// cable per microsecond, defined as: fathom per millisecond × (120.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CablePerMicrosecond = new (
                                                              "cable per microsecond"
                                                            , "cb/μs"
                                                            , FathomPerMillisecond
                                                            , 120.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// cable per nanosecond, defined as: fathom per microsecond × (120.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CablePerNanosecond = new (
                                                             "cable per nanosecond"
                                                           , "cb/ns"
                                                           , FathomPerMicrosecond
                                                           , 120.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// cable per picosecond, defined as: fathom per nanosecond × (120.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CablePerPicosecond = new (
                                                             "cable per picosecond"
                                                           , "cb/ps"
                                                           , FathomPerNanosecond
                                                           , 120.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// cable per femtosecond, defined as: fathom per picosecond × (120.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CablePerFemtosecond = new (
                                                              "cable per femtosecond"
                                                            , "cb/fs"
                                                            , FathomPerPicosecond
                                                            , 120.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// cable per attosecond, defined as: fathom per femtosecond × (120.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CablePerAttosecond = new (
                                                             "cable per attosecond"
                                                           , "cb/as"
                                                           , FathomPerFemtosecond
                                                           , 120.0 / (1.0 / 1000.0)
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// cable per zeptosecond, defined as: fathom per attosecond × (120.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CablePerZeptosecond = new (
                                                              "cable per zeptosecond"
                                                            , "cb/zs"
                                                            , FathomPerAttosecond
                                                            , 120.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// cable per yoctosecond, defined as: fathom per zeptosecond × (120.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CablePerYoctosecond = new (
                                                              "cable per yoctosecond"
                                                            , "cb/ys"
                                                            , FathomPerZeptosecond
                                                            , 120.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// cable per rontosecond, defined as: fathom per yoctosecond × (120.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CablePerRontosecond = new (
                                                              "cable per rontosecond"
                                                            , "cb/rs"
                                                            , FathomPerYoctosecond
                                                            , 120.0 / (1.0 / 1000.0)
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// cable per quectosecond, defined as: fathom per rontosecond × (120.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CablePerQuectosecond = new (
                                                               "cable per quectosecond"
                                                             , "cb/qs"
                                                             , FathomPerRontosecond
                                                             , 120.0 / (1.0 / 1000.0)
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// inch per trillion years, defined as: SI centimeter per billion years × (2.54)/(1000.0)
   /// </summary>
   public static readonly Velocity InchPerTrillionYears = new (
                                                               "inch per trillion years"
                                                             , "in/Tyr"
                                                             , SI.Velocities.CentimeterPerBillionYears
                                                             , 2.54 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// nautical mile per second, defined as: SI meter per second × (1852.0)/(1.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerSecond = new (
                                                                "nautical mile per second"
                                                              , "nmi/s"
                                                              , SI.Velocities.MeterPerSecond
                                                              , 1852.0 / 1.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// nautical mile per planck-time, defined as: SI meter per microsecond × (1852.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity NauticalMilePerPlanckTime = new (
                                                                    "nautical mile per planck-time"
                                                                  , "nmi/tₚ"
                                                                  , SI.Velocities.MeterPerMicrosecond
                                                                  , 1852.0 / 5.391247E-38
                                                                  , system: "US Customary"
                                                                   );

   /// <summary>
   /// nautical mile per decisecond, defined as: SI meter per second × (1852.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerDecisecond = new (
                                                                    "nautical mile per decisecond"
                                                                  , "nmi/ds"
                                                                  , SI.Velocities.MeterPerSecond
                                                                  , 1852.0 / (1.0 / 10.0)
                                                                  , system: "US Customary"
                                                                   );

   /// <summary>
   /// nautical mile per centisecond, defined as: SI meter per decisecond × (1852.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerCentisecond = new (
                                                                     "nautical mile per centisecond"
                                                                   , "nmi/cs"
                                                                   , SI.Velocities.MeterPerDecisecond
                                                                   , 1852.0 / (1.0 / 10.0)
                                                                   , system: "US Customary"
                                                                    );

   /// <summary>
   /// nautical mile per millisecond, defined as: SI meter per centisecond × (1852.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerMillisecond = new (
                                                                     "nautical mile per millisecond"
                                                                   , "nmi/ms"
                                                                   , SI.Velocities.MeterPerCentisecond
                                                                   , 1852.0 / (1.0 / 10.0)
                                                                   , system: "US Customary"
                                                                    );

   /// <summary>
   /// nautical mile per microsecond, defined as: SI meter per millisecond × (1852.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerMicrosecond = new (
                                                                     "nautical mile per microsecond"
                                                                   , "nmi/μs"
                                                                   , SI.Velocities.MeterPerMillisecond
                                                                   , 1852.0 / (1.0 / 1000.0)
                                                                   , system: "US Customary"
                                                                    );

   /// <summary>
   /// nautical mile per nanosecond, defined as: SI meter per microsecond × (1852.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerNanosecond = new (
                                                                    "nautical mile per nanosecond"
                                                                  , "nmi/ns"
                                                                  , SI.Velocities.MeterPerMicrosecond
                                                                  , 1852.0 / (1.0 / 1000.0)
                                                                  , system: "US Customary"
                                                                   );

   /// <summary>
   /// nautical mile per picosecond, defined as: SI meter per nanosecond × (1852.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerPicosecond = new (
                                                                    "nautical mile per picosecond"
                                                                  , "nmi/ps"
                                                                  , SI.Velocities.MeterPerNanosecond
                                                                  , 1852.0 / (1.0 / 1000.0)
                                                                  , system: "US Customary"
                                                                   );

   /// <summary>
   /// nautical mile per femtosecond, defined as: SI meter per picosecond × (1852.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerFemtosecond = new (
                                                                     "nautical mile per femtosecond"
                                                                   , "nmi/fs"
                                                                   , SI.Velocities.MeterPerPicosecond
                                                                   , 1852.0 / (1.0 / 1000.0)
                                                                   , system: "US Customary"
                                                                    );

   /// <summary>
   /// nautical mile per attosecond, defined as: SI meter per femtosecond × (1852.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerAttosecond = new (
                                                                    "nautical mile per attosecond"
                                                                  , "nmi/as"
                                                                  , SI.Velocities.MeterPerFemtosecond
                                                                  , 1852.0 / (1.0 / 1000.0)
                                                                  , system: "US Customary"
                                                                   );

   /// <summary>
   /// nautical mile per zeptosecond, defined as: SI meter per attosecond × (1852.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerZeptosecond = new (
                                                                     "nautical mile per zeptosecond"
                                                                   , "nmi/zs"
                                                                   , SI.Velocities.MeterPerAttosecond
                                                                   , 1852.0 / (1.0 / 1000.0)
                                                                   , system: "US Customary"
                                                                    );

   /// <summary>
   /// nautical mile per yoctosecond, defined as: SI meter per zeptosecond × (1852.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerYoctosecond = new (
                                                                     "nautical mile per yoctosecond"
                                                                   , "nmi/ys"
                                                                   , SI.Velocities.MeterPerZeptosecond
                                                                   , 1852.0 / (1.0 / 1000.0)
                                                                   , system: "US Customary"
                                                                    );

   /// <summary>
   /// nautical mile per rontosecond, defined as: SI meter per yoctosecond × (1852.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerRontosecond = new (
                                                                     "nautical mile per rontosecond"
                                                                   , "nmi/rs"
                                                                   , SI.Velocities.MeterPerYoctosecond
                                                                   , 1852.0 / (1.0 / 1000.0)
                                                                   , system: "US Customary"
                                                                    );

   /// <summary>
   /// nautical mile per quectosecond, defined as: SI meter per rontosecond × (1852.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerQuectosecond = new (
                                                                      "nautical mile per quectosecond"
                                                                    , "nmi/qs"
                                                                    , SI.Velocities.MeterPerRontosecond
                                                                    , 1852.0 / (1.0 / 1000.0)
                                                                    , system: "US Customary"
                                                                     );

   /// <summary>
   /// inch per quadrillion years, defined as: SI centimeter per trillion years × (2.54)/(1000.0)
   /// </summary>
   public static readonly Velocity InchPerQuadrillionYears = new (
                                                                  "inch per quadrillion years"
                                                                , "in/Pyr"
                                                                , SI.Velocities.CentimeterPerTrillionYears
                                                                , 2.54 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// inch per quintillion years, defined as: SI centimeter per quadrillion years × (2.54)/(1000.0)
   /// </summary>
   public static readonly Velocity InchPerQuintillionYears = new (
                                                                  "inch per quintillion years"
                                                                , "in/Eyr"
                                                                , SI.Velocities.CentimeterPerQuadrillionYears
                                                                , 2.54 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// inch per sextillion years, defined as: SI centimeter per quintillion years × (2.54)/(1000.0)
   /// </summary>
   public static readonly Velocity InchPerSextillionYears = new (
                                                                 "inch per sextillion years"
                                                               , "in/Zyr"
                                                               , SI.Velocities.CentimeterPerQuintillionYears
                                                               , 2.54 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// inch per septillion years, defined as: SI centimeter per sextillion years × (2.54)/(1000.0)
   /// </summary>
   public static readonly Velocity InchPerSeptillionYears = new (
                                                                 "inch per septillion years"
                                                               , "in/Yyr"
                                                               , SI.Velocities.CentimeterPerSextillionYears
                                                               , 2.54 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// inch per octillion years, defined as: SI centimeter per septillion years × (2.54)/(1000.0)
   /// </summary>
   public static readonly Velocity InchPerOctillionYears = new (
                                                                "inch per octillion years"
                                                              , "in/Ryr"
                                                              , SI.Velocities.CentimeterPerSeptillionYears
                                                              , 2.54 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// inch per nonillion years, defined as: SI centimeter per octillion years × (2.54)/(1000.0)
   /// </summary>
   public static readonly Velocity InchPerNonillionYears = new (
                                                                "inch per nonillion years"
                                                              , "in/Qyr"
                                                              , SI.Velocities.CentimeterPerOctillionYears
                                                              , 2.54 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// inch per decillion years, defined as: SI centimeter per nonillion years × (2.54)/(1000.0)
   /// </summary>
   public static readonly Velocity InchPerDecillionYears = new (
                                                                "inch per decillion years"
                                                              , "in/decillion yr"
                                                              , SI.Velocities.CentimeterPerNonillionYears
                                                              , 2.54 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// inch per tick, defined as: SI centimeter per nanosecond × (2.54)/(100.0)
   /// </summary>
   public static readonly Velocity InchPerTick = new (
                                                      "inch per tick"
                                                    , "in/tick"
                                                    , SI.Velocities.CentimeterPerNanosecond
                                                    , 2.54 / 100.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// mil per minute, defined as: inch per second × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity MilPerMinute = new (
                                                       "mil per minute"
                                                     , "mil/min"
                                                     , InchPerSecond
                                                     , 1.0 / 1000.0 / 60.0
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// foot per septillion years, defined as: inch per sextillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FootPerSeptillionYears = new (
                                                                 "foot per septillion years"
                                                               , "ft/Yyr"
                                                               , InchPerSextillionYears
                                                               , 12.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// foot per week, defined as: inch per day × (12.0)/(7.0)
   /// </summary>
   public static readonly Velocity FootPerWeek = new (
                                                      "foot per week"
                                                    , "ft/wk"
                                                    , InchPerDay
                                                    , 12.0 / 7.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// point per billion years, defined as: inch per million years × (1.0/72.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PointPerBillionYears = new (
                                                               "point per billion years"
                                                             , "p/Gyr"
                                                             , InchPerMillionYears
                                                             , 1.0 / 72.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// mil per tick, defined as: inch per nanosecond × (1.0/1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity MilPerTick = new (
                                                     "mil per tick"
                                                   , "mil/tick"
                                                   , InchPerNanosecond
                                                   , 1.0 / 1000.0 / 100.0
                                                   , system: "US Customary"
                                                    );

   /// <summary>
   /// mil per hour, defined as: inch per minute × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity MilPerHour = new (
                                                     "mil per hour"
                                                   , "mil/hr"
                                                   , InchPerMinute
                                                   , 1.0 / 1000.0 / 60.0
                                                   , system: "US Customary"
                                                    );

   /// <summary>
   /// point per minute, defined as: inch per second × (1.0/72.0)/(60.0)
   /// </summary>
   public static readonly Velocity PointPerMinute = new (
                                                         "point per minute"
                                                       , "p/min"
                                                       , InchPerSecond
                                                       , 1.0 / 72.0 / 60.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// nautical mile per nonillion years, defined as: SI meter per octillion years × (1852.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerNonillionYears = new (
                                                                        "nautical mile per nonillion years"
                                                                      , "nmi/Qyr"
                                                                      , SI.Velocities.MeterPerOctillionYears
                                                                      , 1852.0 / 1000.0
                                                                      , system: "US Customary"
                                                                       );

   /// <summary>
   /// nautical mile per quadrillion years, defined as: SI meter per trillion years × (1852.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerQuadrillionYears = new (
                                                                          "nautical mile per quadrillion years"
                                                                        , "nmi/Pyr"
                                                                        , SI.Velocities.MeterPerTrillionYears
                                                                        , 1852.0 / 1000.0
                                                                        , system: "US Customary"
                                                                         );

   /// <summary>
   /// mil per day, defined as: inch per hour × (1.0/1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity MilPerDay = new (
                                                    "mil per day"
                                                  , "mil/dy"
                                                  , InchPerHour
                                                  , 1.0 / 1000.0 / 24.0
                                                  , system: "US Customary"
                                                   );

   /// <summary>
   /// twip per minute, defined as: point per second × (1.0/20.0)/(60.0)
   /// </summary>
   public static readonly Velocity TwipPerMinute = new (
                                                        "twip per minute"
                                                      , "twip/min"
                                                      , PointPerSecond
                                                      , 1.0 / 20.0 / 60.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// foot per millennium, defined as: inch per century × (12.0)/(10.0)
   /// </summary>
   public static readonly Velocity FootPerMillennium = new (
                                                            "foot per millennium"
                                                          , "ft/kyr"
                                                          , InchPerCentury
                                                          , 12.0 / 10.0
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// point per tick, defined as: inch per nanosecond × (1.0/72.0)/(100.0)
   /// </summary>
   public static readonly Velocity PointPerTick = new (
                                                       "point per tick"
                                                     , "p/tick"
                                                     , InchPerNanosecond
                                                     , 1.0 / 72.0 / 100.0
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// nautical mile per century, defined as: SI meter per decade × (1852.0)/(10.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerCentury = new (
                                                                 "nautical mile per century"
                                                               , "nmi/century"
                                                               , SI.Velocities.MeterPerDecade
                                                               , 1852.0 / 10.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// point per trillion years, defined as: inch per billion years × (1.0/72.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PointPerTrillionYears = new (
                                                                "point per trillion years"
                                                              , "p/Tyr"
                                                              , InchPerBillionYears
                                                              , 1.0 / 72.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// nautical mile per hour, defined as: SI meter per minute × (1852.0)/(60.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerHour = new (
                                                              "nautical mile per hour"
                                                            , "nmi/hr"
                                                            , SI.Velocities.MeterPerMinute
                                                            , 1852.0 / 60.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// yard per octillion years, defined as: foot per septillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YardPerOctillionYears = new (
                                                                "yard per octillion years"
                                                              , "yd/Ryr"
                                                              , FootPerSeptillionYears
                                                              , 3.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// point per hour, defined as: inch per minute × (1.0/72.0)/(60.0)
   /// </summary>
   public static readonly Velocity PointPerHour = new (
                                                       "point per hour"
                                                     , "p/hr"
                                                     , InchPerMinute
                                                     , 1.0 / 72.0 / 60.0
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// mil per week, defined as: inch per day × (1.0/1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity MilPerWeek = new (
                                                     "mil per week"
                                                   , "mil/wk"
                                                   , InchPerDay
                                                   , 1.0 / 1000.0 / 7.0
                                                   , system: "US Customary"
                                                    );

   /// <summary>
   /// pica per minute, defined as: point per second × (12.0)/(60.0)
   /// </summary>
   public static readonly Velocity PicaPerMinute = new (
                                                        "pica per minute"
                                                      , "P/min"
                                                      , PointPerSecond
                                                      , 12.0 / 60.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// foot per quadrillion years, defined as: inch per trillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FootPerQuadrillionYears = new (
                                                                  "foot per quadrillion years"
                                                                , "ft/Pyr"
                                                                , InchPerTrillionYears
                                                                , 12.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// twip per tick, defined as: point per nanosecond × (1.0/20.0)/(100.0)
   /// </summary>
   public static readonly Velocity TwipPerTick = new (
                                                      "twip per tick"
                                                    , "twip/tick"
                                                    , PointPerNanosecond
                                                    , 1.0 / 20.0 / 100.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// mil per year, defined as: inch per day × (1.0/1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity MilPerYear = new (
                                                     "mil per year"
                                                   , "mil/yr"
                                                   , InchPerDay
                                                   , 1.0 / 1000.0 / 365.2525
                                                   , system: "US Customary"
                                                    );

   /// <summary>
   /// foot per minute, defined as: inch per second × (12.0)/(60.0)
   /// </summary>
   public static readonly Velocity FootPerMinute = new (
                                                        "foot per minute"
                                                      , "ft/min"
                                                      , InchPerSecond
                                                      , 12.0 / 60.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// fathom per nonillion years, defined as: yard per octillion years × (2.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FathomPerNonillionYears = new (
                                                                  "fathom per nonillion years"
                                                                , "ftm/Qyr"
                                                                , YardPerOctillionYears
                                                                , 2.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// point per quadrillion years, defined as: inch per trillion years × (1.0/72.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PointPerQuadrillionYears = new (
                                                                   "point per quadrillion years"
                                                                 , "p/Pyr"
                                                                 , InchPerTrillionYears
                                                                 , 1.0 / 72.0 / 1000.0
                                                                 , system: "US Customary"
                                                                  );

   /// <summary>
   /// point per day, defined as: inch per hour × (1.0/72.0)/(24.0)
   /// </summary>
   public static readonly Velocity PointPerDay = new (
                                                      "point per day"
                                                    , "p/dy"
                                                    , InchPerHour
                                                    , 1.0 / 72.0 / 24.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// twip per hour, defined as: point per minute × (1.0/20.0)/(60.0)
   /// </summary>
   public static readonly Velocity TwipPerHour = new (
                                                      "twip per hour"
                                                    , "twip/hr"
                                                    , PointPerMinute
                                                    , 1.0 / 20.0 / 60.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// mil per decade, defined as: inch per year × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity MilPerDecade = new (
                                                       "mil per decade"
                                                     , "mil/decade"
                                                     , InchPerYear
                                                     , 1.0 / 1000.0 / 10.0
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// yard per minute, defined as: foot per second × (3.0)/(60.0)
   /// </summary>
   public static readonly Velocity YardPerMinute = new (
                                                        "yard per minute"
                                                      , "yd/min"
                                                      , FootPerSecond
                                                      , 3.0 / 60.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// foot per octillion years, defined as: inch per septillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FootPerOctillionYears = new (
                                                                "foot per octillion years"
                                                              , "ft/Ryr"
                                                              , InchPerSeptillionYears
                                                              , 12.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// pica per tick, defined as: point per nanosecond × (12.0)/(100.0)
   /// </summary>
   public static readonly Velocity PicaPerTick = new (
                                                      "pica per tick"
                                                    , "P/tick"
                                                    , PointPerNanosecond
                                                    , 12.0 / 100.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// nautical mile per sextillion years, defined as: SI meter per quintillion years × (1852.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerSextillionYears = new (
                                                                         "nautical mile per sextillion years"
                                                                       , "nmi/Zyr"
                                                                       , SI.Velocities.MeterPerQuintillionYears
                                                                       , 1852.0 / 1000.0
                                                                       , system: "US Customary"
                                                                        );

   /// <summary>
   /// foot per year, defined as: inch per day × (12.0)/(365.2525)
   /// </summary>
   public static readonly Velocity FootPerYear = new (
                                                      "foot per year"
                                                    , "ft/yr"
                                                    , InchPerDay
                                                    , 12.0 / 365.2525
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// nautical mile per million years, defined as: SI meter per millennium × (1852.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerMillionYears = new (
                                                                      "nautical mile per million years"
                                                                    , "nmi/Myr"
                                                                    , SI.Velocities.MeterPerMillennium
                                                                    , 1852.0 / 1000.0
                                                                    , system: "US Customary"
                                                                     );

   /// <summary>
   /// mil per century, defined as: inch per decade × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity MilPerCentury = new (
                                                        "mil per century"
                                                      , "mil/century"
                                                      , InchPerDecade
                                                      , 1.0 / 1000.0 / 10.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// mile per minute, defined as: yard per second × (1760.0)/(60.0)
   /// </summary>
   public static readonly Velocity MilePerMinute = new (
                                                        "mile per minute"
                                                      , "mi/min"
                                                      , YardPerSecond
                                                      , 1760.0 / 60.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// pica per trillion years, defined as: point per billion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicaPerTrillionYears = new (
                                                               "pica per trillion years"
                                                             , "P/Tyr"
                                                             , PointPerBillionYears
                                                             , 12.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// nautical mile per week, defined as: SI meter per day × (1852.0)/(7.0)
   /// </summary>
   public static readonly Velocity NauticalMilePerWeek = new (
                                                              "nautical mile per week"
                                                            , "nmi/wk"
                                                            , SI.Velocities.MeterPerDay
                                                            , 1852.0 / 7.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// point per quintillion years, defined as: inch per quadrillion years × (1.0/72.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PointPerQuintillionYears = new (
                                                                   "point per quintillion years"
                                                                 , "p/Eyr"
                                                                 , InchPerQuadrillionYears
                                                                 , 1.0 / 72.0 / 1000.0
                                                                 , system: "US Customary"
                                                                  );

   /// <summary>
   /// foot per tick, defined as: inch per nanosecond × (12.0)/(100.0)
   /// </summary>
   public static readonly Velocity FootPerTick = new (
                                                      "foot per tick"
                                                    , "ft/tick"
                                                    , InchPerNanosecond
                                                    , 12.0 / 100.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// point per week, defined as: inch per day × (1.0/72.0)/(7.0)
   /// </summary>
   public static readonly Velocity PointPerWeek = new (
                                                       "point per week"
                                                     , "p/wk"
                                                     , InchPerDay
                                                     , 1.0 / 72.0 / 7.0
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// pica per hour, defined as: point per minute × (12.0)/(60.0)
   /// </summary>
   public static readonly Velocity PicaPerHour = new (
                                                      "pica per hour"
                                                    , "P/hr"
                                                    , PointPerMinute
                                                    , 12.0 / 60.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// mil per millennium, defined as: inch per century × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity MilPerMillennium = new (
                                                           "mil per millennium"
                                                         , "mil/kyr"
                                                         , InchPerCentury
                                                         , 1.0 / 1000.0 / 10.0
                                                         , system: "US Customary"
                                                          );

   /// <summary>
   /// league per minute, defined as: mile per second × (3.0)/(60.0)
   /// </summary>
   public static readonly Velocity LeaguePerMinute = new (
                                                          "league per minute"
                                                        , "le/min"
                                                        , MilePerSecond
                                                        , 3.0 / 60.0
                                                        , system: "US Customary"
                                                         );

   /// <summary>
   /// foot per million years, defined as: inch per millennium × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FootPerMillionYears = new (
                                                              "foot per million years"
                                                            , "ft/Myr"
                                                            , InchPerMillennium
                                                            , 12.0 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// mile per nonillion years, defined as: yard per octillion years × (1760.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilePerNonillionYears = new (
                                                                "mile per nonillion years"
                                                              , "mi/Qyr"
                                                              , YardPerOctillionYears
                                                              , 1760.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// twip per day, defined as: point per hour × (1.0/20.0)/(24.0)
   /// </summary>
   public static readonly Velocity TwipPerDay = new (
                                                     "twip per day"
                                                   , "twip/dy"
                                                   , PointPerHour
                                                   , 1.0 / 20.0 / 24.0
                                                   , system: "US Customary"
                                                    );

   /// <summary>
   /// mil per million years, defined as: inch per millennium × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilPerMillionYears = new (
                                                             "mil per million years"
                                                           , "mil/Myr"
                                                           , InchPerMillennium
                                                           , 1.0 / 1000.0 / 1000.0
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// fathom per minute, defined as: yard per second × (2.0)/(60.0)
   /// </summary>
   public static readonly Velocity FathomPerMinute = new (
                                                          "fathom per minute"
                                                        , "ftm/min"
                                                        , YardPerSecond
                                                        , 2.0 / 60.0
                                                        , system: "US Customary"
                                                         );

   /// <summary>
   /// yard per tick, defined as: foot per nanosecond × (3.0)/(100.0)
   /// </summary>
   public static readonly Velocity YardPerTick = new (
                                                      "yard per tick"
                                                    , "yd/tick"
                                                    , FootPerNanosecond
                                                    , 3.0 / 100.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// point per sextillion years, defined as: inch per quintillion years × (1.0/72.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PointPerSextillionYears = new (
                                                                  "point per sextillion years"
                                                                , "p/Zyr"
                                                                , InchPerQuintillionYears
                                                                , 1.0 / 72.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// foot per quintillion years, defined as: inch per quadrillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FootPerQuintillionYears = new (
                                                                  "foot per quintillion years"
                                                                , "ft/Eyr"
                                                                , InchPerQuadrillionYears
                                                                , 12.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// yard per nonillion years, defined as: foot per octillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YardPerNonillionYears = new (
                                                                "yard per nonillion years"
                                                              , "yd/Qyr"
                                                              , FootPerOctillionYears
                                                              , 3.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// point per year, defined as: inch per day × (1.0/72.0)/(365.2525)
   /// </summary>
   public static readonly Velocity PointPerYear = new (
                                                       "point per year"
                                                     , "p/yr"
                                                     , InchPerDay
                                                     , 1.0 / 72.0 / 365.2525
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// foot per hour, defined as: inch per minute × (12.0)/(60.0)
   /// </summary>
   public static readonly Velocity FootPerHour = new (
                                                      "foot per hour"
                                                    , "ft/hr"
                                                    , InchPerMinute
                                                    , 12.0 / 60.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// mil per billion years, defined as: inch per million years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilPerBillionYears = new (
                                                             "mil per billion years"
                                                           , "mil/Gyr"
                                                           , InchPerMillionYears
                                                           , 1.0 / 1000.0 / 1000.0
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// cable per minute, defined as: fathom per second × (120.0)/(60.0)
   /// </summary>
   public static readonly Velocity CablePerMinute = new (
                                                         "cable per minute"
                                                       , "cb/min"
                                                       , FathomPerSecond
                                                       , 120.0 / 60.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// yard per sextillion years, defined as: foot per quintillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YardPerSextillionYears = new (
                                                                 "yard per sextillion years"
                                                               , "yd/Zyr"
                                                               , FootPerQuintillionYears
                                                               , 3.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// mile per tick, defined as: yard per nanosecond × (1760.0)/(100.0)
   /// </summary>
   public static readonly Velocity MilePerTick = new (
                                                      "mile per tick"
                                                    , "mi/tick"
                                                    , YardPerNanosecond
                                                    , 1760.0 / 100.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// mil per trillion years, defined as: inch per billion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilPerTrillionYears = new (
                                                              "mil per trillion years"
                                                            , "mil/Tyr"
                                                            , InchPerBillionYears
                                                            , 1.0 / 1000.0 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// pica per quadrillion years, defined as: point per trillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicaPerQuadrillionYears = new (
                                                                  "pica per quadrillion years"
                                                                , "P/Pyr"
                                                                , PointPerTrillionYears
                                                                , 12.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// foot per nonillion years, defined as: inch per octillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FootPerNonillionYears = new (
                                                                "foot per nonillion years"
                                                              , "ft/Qyr"
                                                              , InchPerOctillionYears
                                                              , 12.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// foot per decade, defined as: inch per year × (12.0)/(10.0)
   /// </summary>
   public static readonly Velocity FootPerDecade = new (
                                                        "foot per decade"
                                                      , "ft/decade"
                                                      , InchPerYear
                                                      , 12.0 / 10.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// point per septillion years, defined as: inch per sextillion years × (1.0/72.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PointPerSeptillionYears = new (
                                                                  "point per septillion years"
                                                                , "p/Yyr"
                                                                , InchPerSextillionYears
                                                                , 1.0 / 72.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// twip per week, defined as: point per day × (1.0/20.0)/(7.0)
   /// </summary>
   public static readonly Velocity TwipPerWeek = new (
                                                      "twip per week"
                                                    , "twip/wk"
                                                    , PointPerDay
                                                    , 1.0 / 20.0 / 7.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// pica per day, defined as: point per hour × (12.0)/(24.0)
   /// </summary>
   public static readonly Velocity PicaPerDay = new (
                                                     "pica per day"
                                                   , "P/dy"
                                                   , PointPerHour
                                                   , 12.0 / 24.0
                                                   , system: "US Customary"
                                                    );

   /// <summary>
   /// point per decade, defined as: inch per year × (1.0/72.0)/(10.0)
   /// </summary>
   public static readonly Velocity PointPerDecade = new (
                                                         "point per decade"
                                                       , "p/decade"
                                                       , InchPerYear
                                                       , 1.0 / 72.0 / 10.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// yard per hour, defined as: foot per minute × (3.0)/(60.0)
   /// </summary>
   public static readonly Velocity YardPerHour = new (
                                                      "yard per hour"
                                                    , "yd/hr"
                                                    , FootPerMinute
                                                    , 3.0 / 60.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// mil per quadrillion years, defined as: inch per trillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilPerQuadrillionYears = new (
                                                                 "mil per quadrillion years"
                                                               , "mil/Pyr"
                                                               , InchPerTrillionYears
                                                               , 1.0 / 1000.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// league per tick, defined as: mile per nanosecond × (3.0)/(100.0)
   /// </summary>
   public static readonly Velocity LeaguePerTick = new (
                                                        "league per tick"
                                                      , "le/tick"
                                                      , MilePerNanosecond
                                                      , 3.0 / 100.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// mile per septillion years, defined as: yard per sextillion years × (1760.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilePerSeptillionYears = new (
                                                                 "mile per septillion years"
                                                               , "mi/Yyr"
                                                               , YardPerSextillionYears
                                                               , 1760.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// mil per quintillion years, defined as: inch per quadrillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilPerQuintillionYears = new (
                                                                 "mil per quintillion years"
                                                               , "mil/Eyr"
                                                               , InchPerQuadrillionYears
                                                               , 1.0 / 1000.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// foot per billion years, defined as: inch per million years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FootPerBillionYears = new (
                                                              "foot per billion years"
                                                            , "ft/Gyr"
                                                            , InchPerMillionYears
                                                            , 12.0 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// point per octillion years, defined as: inch per septillion years × (1.0/72.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PointPerOctillionYears = new (
                                                                 "point per octillion years"
                                                               , "p/Ryr"
                                                               , InchPerSeptillionYears
                                                               , 1.0 / 72.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// cable per decillion years, defined as: fathom per nonillion years × (120.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CablePerDecillionYears = new (
                                                                 "cable per decillion years"
                                                               , "cb/decillion yr"
                                                               , FathomPerNonillionYears
                                                               , 120.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// fathom per tick, defined as: yard per nanosecond × (2.0)/(100.0)
   /// </summary>
   public static readonly Velocity FathomPerTick = new (
                                                        "fathom per tick"
                                                      , "ftm/tick"
                                                      , YardPerNanosecond
                                                      , 2.0 / 100.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// point per century, defined as: inch per decade × (1.0/72.0)/(10.0)
   /// </summary>
   public static readonly Velocity PointPerCentury = new (
                                                          "point per century"
                                                        , "p/century"
                                                        , InchPerDecade
                                                        , 1.0 / 72.0 / 10.0
                                                        , system: "US Customary"
                                                         );

   /// <summary>
   /// mile per hour, defined as: yard per minute × (1760.0)/(60.0)
   /// </summary>
   public static readonly Velocity MilePerHour = new (
                                                      "mile per hour"
                                                    , "mi/hr"
                                                    , YardPerMinute
                                                    , 1760.0 / 60.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// mil per sextillion years, defined as: inch per quintillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilPerSextillionYears = new (
                                                                "mil per sextillion years"
                                                              , "mil/Zyr"
                                                              , InchPerQuintillionYears
                                                              , 1.0 / 1000.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// twip per nonillion years, defined as: point per octillion years × (1.0/20.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TwipPerNonillionYears = new (
                                                                "twip per nonillion years"
                                                              , "twip/Qyr"
                                                              , PointPerOctillionYears
                                                              , 1.0 / 20.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// fathom per decillion years, defined as: yard per nonillion years × (2.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FathomPerDecillionYears = new (
                                                                  "fathom per decillion years"
                                                                , "ftm/decillion yr"
                                                                , YardPerNonillionYears
                                                                , 2.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// twip per trillion years, defined as: point per billion years × (1.0/20.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TwipPerTrillionYears = new (
                                                               "twip per trillion years"
                                                             , "twip/Tyr"
                                                             , PointPerBillionYears
                                                             , 1.0 / 20.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// foot per sextillion years, defined as: inch per quintillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FootPerSextillionYears = new (
                                                                 "foot per sextillion years"
                                                               , "ft/Zyr"
                                                               , InchPerQuintillionYears
                                                               , 12.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// league per decillion years, defined as: mile per nonillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerDecillionYears = new (
                                                                  "league per decillion years"
                                                                , "le/decillion yr"
                                                                , MilePerNonillionYears
                                                                , 3.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// twip per year, defined as: point per day × (1.0/20.0)/(365.2525)
   /// </summary>
   public static readonly Velocity TwipPerYear = new (
                                                      "twip per year"
                                                    , "twip/yr"
                                                    , PointPerDay
                                                    , 1.0 / 20.0 / 365.2525
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// foot per day, defined as: inch per hour × (12.0)/(24.0)
   /// </summary>
   public static readonly Velocity FootPerDay = new (
                                                     "foot per day"
                                                   , "ft/dy"
                                                   , InchPerHour
                                                   , 12.0 / 24.0
                                                   , system: "US Customary"
                                                    );

   /// <summary>
   /// mil per septillion years, defined as: inch per sextillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilPerSeptillionYears = new (
                                                                "mil per septillion years"
                                                              , "mil/Yyr"
                                                              , InchPerSextillionYears
                                                              , 1.0 / 1000.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// pica per quintillion years, defined as: point per quadrillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicaPerQuintillionYears = new (
                                                                  "pica per quintillion years"
                                                                , "P/Eyr"
                                                                , PointPerQuadrillionYears
                                                                , 12.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// mile per decillion years, defined as: yard per nonillion years × (1760.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilePerDecillionYears = new (
                                                                "mile per decillion years"
                                                              , "mi/decillion yr"
                                                              , YardPerNonillionYears
                                                              , 1760.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// cable per tick, defined as: fathom per nanosecond × (120.0)/(100.0)
   /// </summary>
   public static readonly Velocity CablePerTick = new (
                                                       "cable per tick"
                                                     , "cb/tick"
                                                     , FathomPerNanosecond
                                                     , 120.0 / 100.0
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// point per nonillion years, defined as: inch per octillion years × (1.0/72.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PointPerNonillionYears = new (
                                                                 "point per nonillion years"
                                                               , "p/Qyr"
                                                               , InchPerOctillionYears
                                                               , 1.0 / 72.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// yard per decillion years, defined as: foot per nonillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YardPerDecillionYears = new (
                                                                "yard per decillion years"
                                                              , "yd/decillion yr"
                                                              , FootPerNonillionYears
                                                              , 3.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// pica per week, defined as: point per day × (12.0)/(7.0)
   /// </summary>
   public static readonly Velocity PicaPerWeek = new (
                                                      "pica per week"
                                                    , "P/wk"
                                                    , PointPerDay
                                                    , 12.0 / 7.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// point per millennium, defined as: inch per century × (1.0/72.0)/(10.0)
   /// </summary>
   public static readonly Velocity PointPerMillennium = new (
                                                             "point per millennium"
                                                           , "p/kyr"
                                                           , InchPerCentury
                                                           , 1.0 / 72.0 / 10.0
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// league per hour, defined as: mile per minute × (3.0)/(60.0)
   /// </summary>
   public static readonly Velocity LeaguePerHour = new (
                                                        "league per hour"
                                                      , "le/hr"
                                                      , MilePerMinute
                                                      , 3.0 / 60.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// mil per octillion years, defined as: inch per septillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilPerOctillionYears = new (
                                                               "mil per octillion years"
                                                             , "mil/Ryr"
                                                             , InchPerSeptillionYears
                                                             , 1.0 / 1000.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// yard per septillion years, defined as: foot per sextillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YardPerSeptillionYears = new (
                                                                 "yard per septillion years"
                                                               , "yd/Yyr"
                                                               , FootPerSextillionYears
                                                               , 3.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// foot per decillion years, defined as: inch per nonillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FootPerDecillionYears = new (
                                                                "foot per decillion years"
                                                              , "ft/decillion yr"
                                                              , InchPerNonillionYears
                                                              , 12.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// foot per century, defined as: inch per decade × (12.0)/(10.0)
   /// </summary>
   public static readonly Velocity FootPerCentury = new (
                                                         "foot per century"
                                                       , "ft/century"
                                                       , InchPerDecade
                                                       , 12.0 / 10.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// pica per decillion years, defined as: point per nonillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicaPerDecillionYears = new (
                                                                "pica per decillion years"
                                                              , "P/decillion yr"
                                                              , PointPerNonillionYears
                                                              , 12.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// mil per nonillion years, defined as: inch per octillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilPerNonillionYears = new (
                                                               "mil per nonillion years"
                                                             , "mil/Qyr"
                                                             , InchPerOctillionYears
                                                             , 1.0 / 1000.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// yard per million years, defined as: foot per millennium × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YardPerMillionYears = new (
                                                              "yard per million years"
                                                            , "yd/Myr"
                                                            , FootPerMillennium
                                                            , 3.0 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// twip per decillion years, defined as: point per nonillion years × (1.0/20.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TwipPerDecillionYears = new (
                                                                "twip per decillion years"
                                                              , "twip/decillion yr"
                                                              , PointPerNonillionYears
                                                              , 1.0 / 20.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// league per octillion years, defined as: mile per septillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerOctillionYears = new (
                                                                  "league per octillion years"
                                                                , "le/Ryr"
                                                                , MilePerSeptillionYears
                                                                , 3.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// yard per decade, defined as: foot per year × (3.0)/(10.0)
   /// </summary>
   public static readonly Velocity YardPerDecade = new (
                                                        "yard per decade"
                                                      , "yd/decade"
                                                      , FootPerYear
                                                      , 3.0 / 10.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// pica per million years, defined as: point per millennium × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicaPerMillionYears = new (
                                                              "pica per million years"
                                                            , "P/Myr"
                                                            , PointPerMillennium
                                                            , 12.0 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// twip per quadrillion years, defined as: point per trillion years × (1.0/20.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TwipPerQuadrillionYears = new (
                                                                  "twip per quadrillion years"
                                                                , "twip/Pyr"
                                                                , PointPerTrillionYears
                                                                , 1.0 / 20.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// point per decillion years, defined as: inch per nonillion years × (1.0/72.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PointPerDecillionYears = new (
                                                                 "point per decillion years"
                                                               , "p/decillion yr"
                                                               , InchPerNonillionYears
                                                               , 1.0 / 72.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// twip per decade, defined as: point per year × (1.0/20.0)/(10.0)
   /// </summary>
   public static readonly Velocity TwipPerDecade = new (
                                                        "twip per decade"
                                                      , "twip/decade"
                                                      , PointPerYear
                                                      , 1.0 / 20.0 / 10.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// yard per day, defined as: foot per hour × (3.0)/(24.0)
   /// </summary>
   public static readonly Velocity YardPerDay = new (
                                                     "yard per day"
                                                   , "yd/dy"
                                                   , FootPerHour
                                                   , 3.0 / 24.0
                                                   , system: "US Customary"
                                                    );

   /// <summary>
   /// point per million years, defined as: inch per millennium × (1.0/72.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PointPerMillionYears = new (
                                                               "point per million years"
                                                             , "p/Myr"
                                                             , InchPerMillennium
                                                             , 1.0 / 72.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// fathom per hour, defined as: yard per minute × (2.0)/(60.0)
   /// </summary>
   public static readonly Velocity FathomPerHour = new (
                                                        "fathom per hour"
                                                      , "ftm/hr"
                                                      , YardPerMinute
                                                      , 2.0 / 60.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// mil per decillion years, defined as: inch per nonillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilPerDecillionYears = new (
                                                               "mil per decillion years"
                                                             , "mil/decillion yr"
                                                             , InchPerNonillionYears
                                                             , 1.0 / 1000.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// foot per trillion years, defined as: inch per billion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FootPerTrillionYears = new (
                                                               "foot per trillion years"
                                                             , "ft/Tyr"
                                                             , InchPerBillionYears
                                                             , 12.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// pica per sextillion years, defined as: point per quintillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicaPerSextillionYears = new (
                                                                 "pica per sextillion years"
                                                               , "P/Zyr"
                                                               , PointPerQuintillionYears
                                                               , 12.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// mile per octillion years, defined as: yard per septillion years × (1760.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilePerOctillionYears = new (
                                                                "mile per octillion years"
                                                              , "mi/Ryr"
                                                              , YardPerSeptillionYears
                                                              , 1760.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// pica per year, defined as: point per day × (12.0)/(365.2525)
   /// </summary>
   public static readonly Velocity PicaPerYear = new (
                                                      "pica per year"
                                                    , "P/yr"
                                                    , PointPerDay
                                                    , 12.0 / 365.2525
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// cable per hour, defined as: fathom per minute × (120.0)/(60.0)
   /// </summary>
   public static readonly Velocity CablePerHour = new (
                                                       "cable per hour"
                                                     , "cb/hr"
                                                     , FathomPerMinute
                                                     , 120.0 / 60.0
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// twip per quintillion years, defined as: point per quadrillion years × (1.0/20.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TwipPerQuintillionYears = new (
                                                                  "twip per quintillion years"
                                                                , "twip/Eyr"
                                                                , PointPerQuadrillionYears
                                                                , 1.0 / 20.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// twip per century, defined as: point per decade × (1.0/20.0)/(10.0)
   /// </summary>
   public static readonly Velocity TwipPerCentury = new (
                                                         "twip per century"
                                                       , "twip/century"
                                                       , PointPerDecade
                                                       , 1.0 / 20.0 / 10.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// mile per day, defined as: yard per hour × (1760.0)/(24.0)
   /// </summary>
   public static readonly Velocity MilePerDay = new (
                                                     "mile per day"
                                                   , "mi/dy"
                                                   , YardPerHour
                                                   , 1760.0 / 24.0
                                                   , system: "US Customary"
                                                    );

   /// <summary>
   /// league per year, defined as: mile per day × (3.0)/(365.2525)
   /// </summary>
   public static readonly Velocity LeaguePerYear = new (
                                                        "league per year"
                                                      , "le/yr"
                                                      , MilePerDay
                                                      , 3.0 / 365.2525
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// pica per billion years, defined as: point per million years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicaPerBillionYears = new (
                                                              "pica per billion years"
                                                            , "P/Gyr"
                                                            , PointPerMillionYears
                                                            , 12.0 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// yard per quintillion years, defined as: foot per quadrillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YardPerQuintillionYears = new (
                                                                  "yard per quintillion years"
                                                                , "yd/Eyr"
                                                                , FootPerQuadrillionYears
                                                                , 3.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// yard per billion years, defined as: foot per million years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YardPerBillionYears = new (
                                                              "yard per billion years"
                                                            , "yd/Gyr"
                                                            , FootPerMillionYears
                                                            , 3.0 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// pica per septillion years, defined as: point per sextillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicaPerSeptillionYears = new (
                                                                 "pica per septillion years"
                                                               , "P/Yyr"
                                                               , PointPerSextillionYears
                                                               , 12.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// yard per century, defined as: foot per decade × (3.0)/(10.0)
   /// </summary>
   public static readonly Velocity YardPerCentury = new (
                                                         "yard per century"
                                                       , "yd/century"
                                                       , FootPerDecade
                                                       , 3.0 / 10.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// twip per sextillion years, defined as: point per quintillion years × (1.0/20.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TwipPerSextillionYears = new (
                                                                 "twip per sextillion years"
                                                               , "twip/Zyr"
                                                               , PointPerQuintillionYears
                                                               , 1.0 / 20.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// pica per decade, defined as: point per year × (12.0)/(10.0)
   /// </summary>
   public static readonly Velocity PicaPerDecade = new (
                                                        "pica per decade"
                                                      , "P/decade"
                                                      , PointPerYear
                                                      , 12.0 / 10.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// yard per week, defined as: foot per day × (3.0)/(7.0)
   /// </summary>
   public static readonly Velocity YardPerWeek = new (
                                                      "yard per week"
                                                    , "yd/wk"
                                                    , FootPerDay
                                                    , 3.0 / 7.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// twip per millennium, defined as: point per century × (1.0/20.0)/(10.0)
   /// </summary>
   public static readonly Velocity TwipPerMillennium = new (
                                                            "twip per millennium"
                                                          , "twip/kyr"
                                                          , PointPerCentury
                                                          , 1.0 / 20.0 / 10.0
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// league per day, defined as: mile per hour × (3.0)/(24.0)
   /// </summary>
   public static readonly Velocity LeaguePerDay = new (
                                                       "league per day"
                                                     , "le/dy"
                                                     , MilePerHour
                                                     , 3.0 / 24.0
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// mile per sextillion years, defined as: yard per quintillion years × (1760.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilePerSextillionYears = new (
                                                                 "mile per sextillion years"
                                                               , "mi/Zyr"
                                                               , YardPerQuintillionYears
                                                               , 1760.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// fathom per septillion years, defined as: yard per sextillion years × (2.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FathomPerSeptillionYears = new (
                                                                   "fathom per septillion years"
                                                                 , "ftm/Yyr"
                                                                 , YardPerSextillionYears
                                                                 , 2.0 / 1000.0
                                                                 , system: "US Customary"
                                                                  );

   /// <summary>
   /// fathom per trillion years, defined as: yard per billion years × (2.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FathomPerTrillionYears = new (
                                                                 "fathom per trillion years"
                                                               , "ftm/Tyr"
                                                               , YardPerBillionYears
                                                               , 2.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// league per nonillion years, defined as: mile per octillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerNonillionYears = new (
                                                                  "league per nonillion years"
                                                                , "le/Qyr"
                                                                , MilePerOctillionYears
                                                                , 3.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// fathom per century, defined as: yard per decade × (2.0)/(10.0)
   /// </summary>
   public static readonly Velocity FathomPerCentury = new (
                                                           "fathom per century"
                                                         , "ftm/century"
                                                         , YardPerDecade
                                                         , 2.0 / 10.0
                                                         , system: "US Customary"
                                                          );

   /// <summary>
   /// fathom per year, defined as: yard per day × (2.0)/(365.2525)
   /// </summary>
   public static readonly Velocity FathomPerYear = new (
                                                        "fathom per year"
                                                      , "ftm/yr"
                                                      , YardPerDay
                                                      , 2.0 / 365.2525
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// twip per septillion years, defined as: point per sextillion years × (1.0/20.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TwipPerSeptillionYears = new (
                                                                 "twip per septillion years"
                                                               , "twip/Yyr"
                                                               , PointPerSextillionYears
                                                               , 1.0 / 20.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// twip per million years, defined as: point per millennium × (1.0/20.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TwipPerMillionYears = new (
                                                              "twip per million years"
                                                            , "twip/Myr"
                                                            , PointPerMillennium
                                                            , 1.0 / 20.0 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// fathom per day, defined as: yard per hour × (2.0)/(24.0)
   /// </summary>
   public static readonly Velocity FathomPerDay = new (
                                                       "fathom per day"
                                                     , "ftm/dy"
                                                     , YardPerHour
                                                     , 2.0 / 24.0
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// pica per octillion years, defined as: point per septillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicaPerOctillionYears = new (
                                                                "pica per octillion years"
                                                              , "P/Ryr"
                                                              , PointPerSeptillionYears
                                                              , 12.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// cable per quadrillion years, defined as: fathom per trillion years × (120.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CablePerQuadrillionYears = new (
                                                                   "cable per quadrillion years"
                                                                 , "cb/Pyr"
                                                                 , FathomPerTrillionYears
                                                                 , 120.0 / 1000.0
                                                                 , system: "US Customary"
                                                                  );

   /// <summary>
   /// league per septillion years, defined as: mile per sextillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerSeptillionYears = new (
                                                                   "league per septillion years"
                                                                 , "le/Yyr"
                                                                 , MilePerSextillionYears
                                                                 , 3.0 / 1000.0
                                                                 , system: "US Customary"
                                                                  );

   /// <summary>
   /// pica per century, defined as: point per decade × (12.0)/(10.0)
   /// </summary>
   public static readonly Velocity PicaPerCentury = new (
                                                         "pica per century"
                                                       , "P/century"
                                                       , PointPerDecade
                                                       , 12.0 / 10.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// mile per week, defined as: yard per day × (1760.0)/(7.0)
   /// </summary>
   public static readonly Velocity MilePerWeek = new (
                                                      "mile per week"
                                                    , "mi/wk"
                                                    , YardPerDay
                                                    , 1760.0 / 7.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// yard per trillion years, defined as: foot per billion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YardPerTrillionYears = new (
                                                               "yard per trillion years"
                                                             , "yd/Tyr"
                                                             , FootPerBillionYears
                                                             , 3.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// yard per millennium, defined as: foot per century × (3.0)/(10.0)
   /// </summary>
   public static readonly Velocity YardPerMillennium = new (
                                                            "yard per millennium"
                                                          , "yd/kyr"
                                                          , FootPerCentury
                                                          , 3.0 / 10.0
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// twip per octillion years, defined as: point per septillion years × (1.0/20.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TwipPerOctillionYears = new (
                                                                "twip per octillion years"
                                                              , "twip/Ryr"
                                                              , PointPerSeptillionYears
                                                              , 1.0 / 20.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// yard per year, defined as: foot per day × (3.0)/(365.2525)
   /// </summary>
   public static readonly Velocity YardPerYear = new (
                                                      "yard per year"
                                                    , "yd/yr"
                                                    , FootPerDay
                                                    , 3.0 / 365.2525
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// twip per billion years, defined as: point per million years × (1.0/20.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TwipPerBillionYears = new (
                                                              "twip per billion years"
                                                            , "twip/Gyr"
                                                            , PointPerMillionYears
                                                            , 1.0 / 20.0 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// cable per day, defined as: fathom per hour × (120.0)/(24.0)
   /// </summary>
   public static readonly Velocity CablePerDay = new (
                                                      "cable per day"
                                                    , "cb/dy"
                                                    , FathomPerHour
                                                    , 120.0 / 24.0
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// mile per century, defined as: yard per decade × (1760.0)/(10.0)
   /// </summary>
   public static readonly Velocity MilePerCentury = new (
                                                         "mile per century"
                                                       , "mi/century"
                                                       , YardPerDecade
                                                       , 1760.0 / 10.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// cable per octillion years, defined as: fathom per septillion years × (120.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CablePerOctillionYears = new (
                                                                 "cable per octillion years"
                                                               , "cb/Ryr"
                                                               , FathomPerSeptillionYears
                                                               , 120.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// pica per nonillion years, defined as: point per octillion years × (12.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicaPerNonillionYears = new (
                                                                "pica per nonillion years"
                                                              , "P/Qyr"
                                                              , PointPerOctillionYears
                                                              , 12.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// cable per year, defined as: fathom per day × (120.0)/(365.2525)
   /// </summary>
   public static readonly Velocity CablePerYear = new (
                                                       "cable per year"
                                                     , "cb/yr"
                                                     , FathomPerDay
                                                     , 120.0 / 365.2525
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// pica per millennium, defined as: point per century × (12.0)/(10.0)
   /// </summary>
   public static readonly Velocity PicaPerMillennium = new (
                                                            "pica per millennium"
                                                          , "P/kyr"
                                                          , PointPerCentury
                                                          , 12.0 / 10.0
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// league per week, defined as: mile per day × (3.0)/(7.0)
   /// </summary>
   public static readonly Velocity LeaguePerWeek = new (
                                                        "league per week"
                                                      , "le/wk"
                                                      , MilePerDay
                                                      , 3.0 / 7.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// mile per billion years, defined as: yard per million years × (1760.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilePerBillionYears = new (
                                                              "mile per billion years"
                                                            , "mi/Gyr"
                                                            , YardPerMillionYears
                                                            , 1760.0 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// fathom per octillion years, defined as: yard per septillion years × (2.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FathomPerOctillionYears = new (
                                                                  "fathom per octillion years"
                                                                , "ftm/Ryr"
                                                                , YardPerSeptillionYears
                                                                , 2.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// fathom per sextillion years, defined as: yard per quintillion years × (2.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FathomPerSextillionYears = new (
                                                                   "fathom per sextillion years"
                                                                 , "ftm/Zyr"
                                                                 , YardPerQuintillionYears
                                                                 , 2.0 / 1000.0
                                                                 , system: "US Customary"
                                                                  );

   /// <summary>
   /// fathom per quadrillion years, defined as: yard per trillion years × (2.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FathomPerQuadrillionYears = new (
                                                                    "fathom per quadrillion years"
                                                                  , "ftm/Pyr"
                                                                  , YardPerTrillionYears
                                                                  , 2.0 / 1000.0
                                                                  , system: "US Customary"
                                                                   );

   /// <summary>
   /// fathom per billion years, defined as: yard per million years × (2.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FathomPerBillionYears = new (
                                                                "fathom per billion years"
                                                              , "ftm/Gyr"
                                                              , YardPerMillionYears
                                                              , 2.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// mile per year, defined as: yard per day × (1760.0)/(365.2525)
   /// </summary>
   public static readonly Velocity MilePerYear = new (
                                                      "mile per year"
                                                    , "mi/yr"
                                                    , YardPerDay
                                                    , 1760.0 / 365.2525
                                                    , system: "US Customary"
                                                     );

   /// <summary>
   /// fathom per millennium, defined as: yard per century × (2.0)/(10.0)
   /// </summary>
   public static readonly Velocity FathomPerMillennium = new (
                                                              "fathom per millennium"
                                                            , "ftm/kyr"
                                                            , YardPerCentury
                                                            , 2.0 / 10.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// yard per quadrillion years, defined as: foot per trillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YardPerQuadrillionYears = new (
                                                                  "yard per quadrillion years"
                                                                , "yd/Pyr"
                                                                , FootPerTrillionYears
                                                                , 3.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// fathom per decade, defined as: yard per year × (2.0)/(10.0)
   /// </summary>
   public static readonly Velocity FathomPerDecade = new (
                                                          "fathom per decade"
                                                        , "ftm/decade"
                                                        , YardPerYear
                                                        , 2.0 / 10.0
                                                        , system: "US Customary"
                                                         );

   /// <summary>
   /// mile per quintillion years, defined as: yard per quadrillion years × (1760.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilePerQuintillionYears = new (
                                                                  "mile per quintillion years"
                                                                , "mi/Eyr"
                                                                , YardPerQuadrillionYears
                                                                , 1760.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// fathom per week, defined as: yard per day × (2.0)/(7.0)
   /// </summary>
   public static readonly Velocity FathomPerWeek = new (
                                                        "fathom per week"
                                                      , "ftm/wk"
                                                      , YardPerDay
                                                      , 2.0 / 7.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// cable per trillion years, defined as: fathom per billion years × (120.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CablePerTrillionYears = new (
                                                                "cable per trillion years"
                                                              , "cb/Tyr"
                                                              , FathomPerBillionYears
                                                              , 120.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// mile per millennium, defined as: yard per century × (1760.0)/(10.0)
   /// </summary>
   public static readonly Velocity MilePerMillennium = new (
                                                            "mile per millennium"
                                                          , "mi/kyr"
                                                          , YardPerCentury
                                                          , 1760.0 / 10.0
                                                          , system: "US Customary"
                                                           );

   /// <summary>
   /// cable per quintillion years, defined as: fathom per quadrillion years × (120.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CablePerQuintillionYears = new (
                                                                   "cable per quintillion years"
                                                                 , "cb/Eyr"
                                                                 , FathomPerQuadrillionYears
                                                                 , 120.0 / 1000.0
                                                                 , system: "US Customary"
                                                                  );

   /// <summary>
   /// league per sextillion years, defined as: mile per quintillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerSextillionYears = new (
                                                                   "league per sextillion years"
                                                                 , "le/Zyr"
                                                                 , MilePerQuintillionYears
                                                                 , 3.0 / 1000.0
                                                                 , system: "US Customary"
                                                                  );

   /// <summary>
   /// cable per septillion years, defined as: fathom per sextillion years × (120.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CablePerSeptillionYears = new (
                                                                  "cable per septillion years"
                                                                , "cb/Yyr"
                                                                , FathomPerSextillionYears
                                                                , 120.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// cable per week, defined as: fathom per day × (120.0)/(7.0)
   /// </summary>
   public static readonly Velocity CablePerWeek = new (
                                                       "cable per week"
                                                     , "cb/wk"
                                                     , FathomPerDay
                                                     , 120.0 / 7.0
                                                     , system: "US Customary"
                                                      );

   /// <summary>
   /// mile per trillion years, defined as: yard per billion years × (1760.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilePerTrillionYears = new (
                                                               "mile per trillion years"
                                                             , "mi/Tyr"
                                                             , YardPerBillionYears
                                                             , 1760.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// league per quadrillion years, defined as: mile per trillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerQuadrillionYears = new (
                                                                    "league per quadrillion years"
                                                                  , "le/Pyr"
                                                                  , MilePerTrillionYears
                                                                  , 3.0 / 1000.0
                                                                  , system: "US Customary"
                                                                   );

   /// <summary>
   /// cable per nonillion years, defined as: fathom per octillion years × (120.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CablePerNonillionYears = new (
                                                                 "cable per nonillion years"
                                                               , "cb/Qyr"
                                                               , FathomPerOctillionYears
                                                               , 120.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// cable per decade, defined as: fathom per year × (120.0)/(10.0)
   /// </summary>
   public static readonly Velocity CablePerDecade = new (
                                                         "cable per decade"
                                                       , "cb/decade"
                                                       , FathomPerYear
                                                       , 120.0 / 10.0
                                                       , system: "US Customary"
                                                        );

   /// <summary>
   /// mile per decade, defined as: yard per year × (1760.0)/(10.0)
   /// </summary>
   public static readonly Velocity MilePerDecade = new (
                                                        "mile per decade"
                                                      , "mi/decade"
                                                      , YardPerYear
                                                      , 1760.0 / 10.0
                                                      , system: "US Customary"
                                                       );

   /// <summary>
   /// cable per millennium, defined as: fathom per century × (120.0)/(10.0)
   /// </summary>
   public static readonly Velocity CablePerMillennium = new (
                                                             "cable per millennium"
                                                           , "cb/kyr"
                                                           , FathomPerCentury
                                                           , 120.0 / 10.0
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// fathom per quintillion years, defined as: yard per quadrillion years × (2.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FathomPerQuintillionYears = new (
                                                                    "fathom per quintillion years"
                                                                  , "ftm/Eyr"
                                                                  , YardPerQuadrillionYears
                                                                  , 2.0 / 1000.0
                                                                  , system: "US Customary"
                                                                   );

   /// <summary>
   /// fathom per million years, defined as: yard per millennium × (2.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FathomPerMillionYears = new (
                                                                "fathom per million years"
                                                              , "ftm/Myr"
                                                              , YardPerMillennium
                                                              , 2.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// mile per million years, defined as: yard per millennium × (1760.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilePerMillionYears = new (
                                                              "mile per million years"
                                                            , "mi/Myr"
                                                            , YardPerMillennium
                                                            , 1760.0 / 1000.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// cable per billion years, defined as: fathom per million years × (120.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CablePerBillionYears = new (
                                                               "cable per billion years"
                                                             , "cb/Gyr"
                                                             , FathomPerMillionYears
                                                             , 120.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// league per millennium, defined as: mile per century × (3.0)/(10.0)
   /// </summary>
   public static readonly Velocity LeaguePerMillennium = new (
                                                              "league per millennium"
                                                            , "le/kyr"
                                                            , MilePerCentury
                                                            , 3.0 / 10.0
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// mile per quadrillion years, defined as: yard per trillion years × (1760.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MilePerQuadrillionYears = new (
                                                                  "mile per quadrillion years"
                                                                , "mi/Pyr"
                                                                , YardPerTrillionYears
                                                                , 1760.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// cable per sextillion years, defined as: fathom per quintillion years × (120.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CablePerSextillionYears = new (
                                                                  "cable per sextillion years"
                                                                , "cb/Zyr"
                                                                , FathomPerQuintillionYears
                                                                , 120.0 / 1000.0
                                                                , system: "US Customary"
                                                                 );

   /// <summary>
   /// league per decade, defined as: mile per year × (3.0)/(10.0)
   /// </summary>
   public static readonly Velocity LeaguePerDecade = new (
                                                          "league per decade"
                                                        , "le/decade"
                                                        , MilePerYear
                                                        , 3.0 / 10.0
                                                        , system: "US Customary"
                                                         );

   /// <summary>
   /// league per quintillion years, defined as: mile per quadrillion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerQuintillionYears = new (
                                                                    "league per quintillion years"
                                                                  , "le/Eyr"
                                                                  , MilePerQuadrillionYears
                                                                  , 3.0 / 1000.0
                                                                  , system: "US Customary"
                                                                   );

   /// <summary>
   /// league per trillion years, defined as: mile per billion years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerTrillionYears = new (
                                                                 "league per trillion years"
                                                               , "le/Tyr"
                                                               , MilePerBillionYears
                                                               , 3.0 / 1000.0
                                                               , system: "US Customary"
                                                                );

   /// <summary>
   /// cable per century, defined as: fathom per decade × (120.0)/(10.0)
   /// </summary>
   public static readonly Velocity CablePerCentury = new (
                                                          "cable per century"
                                                        , "cb/century"
                                                        , FathomPerDecade
                                                        , 120.0 / 10.0
                                                        , system: "US Customary"
                                                         );

   /// <summary>
   /// cable per million years, defined as: fathom per millennium × (120.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CablePerMillionYears = new (
                                                               "cable per million years"
                                                             , "cb/Myr"
                                                             , FathomPerMillennium
                                                             , 120.0 / 1000.0
                                                             , system: "US Customary"
                                                              );

   /// <summary>
   /// league per million years, defined as: mile per millennium × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerMillionYears = new (
                                                                "league per million years"
                                                              , "le/Myr"
                                                              , MilePerMillennium
                                                              , 3.0 / 1000.0
                                                              , system: "US Customary"
                                                               );

   /// <summary>
   /// league per century, defined as: mile per decade × (3.0)/(10.0)
   /// </summary>
   public static readonly Velocity LeaguePerCentury = new (
                                                           "league per century"
                                                         , "le/century"
                                                         , MilePerDecade
                                                         , 3.0 / 10.0
                                                         , system: "US Customary"
                                                          );

   /// <summary>
   /// league per billion years, defined as: mile per million years × (3.0)/(1000.0)
   /// </summary>
   public static readonly Velocity LeaguePerBillionYears = new (
                                                                "league per billion years"
                                                              , "le/Gyr"
                                                              , MilePerMillionYears
                                                              , 3.0 / 1000.0
                                                              , system: "US Customary"
                                                               );
}
