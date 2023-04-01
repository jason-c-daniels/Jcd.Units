#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.TheoreticalPhysics;

/// <summary>
/// Units used in theoretical physics for measuring Velocity.
/// </summary>
public class Velocities : UnitOfMeasureEnumeration<Velocities, Velocity>
{
   /// <summary>
   /// speed of light, defined as: SI meter per second × 299_792_458
   /// </summary>
   public static readonly Velocity SpeedOfLight = new (
                                                       "speed of light"
                                                     , "c"
                                                     , SI.Velocities.MeterPerSecond
                                                     , 299_792_458
                                                      );

   /// <summary>
   /// planck-length per second, defined as: SI meter per second × (1.616255E-35)/(1.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerSecond = new (
                                                                "planck-length per second"
                                                              , "ℓₚ/s"
                                                              , SI.Velocities.MeterPerSecond
                                                              , 1.616255E-35 / 1.0
                                                               );

   /// <summary>
   /// planck-length per planck-time, defined as: SI meter per microsecond × (1.616255E-35)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity PlanckLengthPerPlanckTime = new (
                                                                    "planck-length per planck-time"
                                                                  , "ℓₚ/tₚ"
                                                                  , SI.Velocities.MeterPerMicrosecond
                                                                  , 1.616255E-35 / 5.391247E-38
                                                                   );

   /// <summary>
   /// planck-length per decisecond, defined as: SI meter per second × (1.616255E-35)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerDecisecond = new (
                                                                    "planck-length per decisecond"
                                                                  , "ℓₚ/ds"
                                                                  , SI.Velocities.MeterPerSecond
                                                                  , 1.616255E-35 / (1.0 / 10.0)
                                                                   );

   /// <summary>
   /// planck-length per centisecond, defined as: SI meter per decisecond × (1.616255E-35)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerCentisecond = new (
                                                                     "planck-length per centisecond"
                                                                   , "ℓₚ/cs"
                                                                   , SI.Velocities.MeterPerDecisecond
                                                                   , 1.616255E-35 / (1.0 / 10.0)
                                                                    );

   /// <summary>
   /// planck-length per millisecond, defined as: SI meter per centisecond × (1.616255E-35)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerMillisecond = new (
                                                                     "planck-length per millisecond"
                                                                   , "ℓₚ/ms"
                                                                   , SI.Velocities.MeterPerCentisecond
                                                                   , 1.616255E-35 / (1.0 / 10.0)
                                                                    );

   /// <summary>
   /// planck-length per microsecond, defined as: SI meter per millisecond × (1.616255E-35)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerMicrosecond = new (
                                                                     "planck-length per microsecond"
                                                                   , "ℓₚ/μs"
                                                                   , SI.Velocities.MeterPerMillisecond
                                                                   , 1.616255E-35 / (1.0 / 1000.0)
                                                                    );

   /// <summary>
   /// planck-length per nanosecond, defined as: SI meter per microsecond × (1.616255E-35)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerNanosecond = new (
                                                                    "planck-length per nanosecond"
                                                                  , "ℓₚ/ns"
                                                                  , SI.Velocities.MeterPerMicrosecond
                                                                  , 1.616255E-35 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// planck-length per picosecond, defined as: SI meter per nanosecond × (1.616255E-35)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerPicosecond = new (
                                                                    "planck-length per picosecond"
                                                                  , "ℓₚ/ps"
                                                                  , SI.Velocities.MeterPerNanosecond
                                                                  , 1.616255E-35 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// planck-length per femtosecond, defined as: SI meter per picosecond × (1.616255E-35)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerFemtosecond = new (
                                                                     "planck-length per femtosecond"
                                                                   , "ℓₚ/fs"
                                                                   , SI.Velocities.MeterPerPicosecond
                                                                   , 1.616255E-35 / (1.0 / 1000.0)
                                                                    );

   /// <summary>
   /// planck-length per attosecond, defined as: SI meter per femtosecond × (1.616255E-35)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerAttosecond = new (
                                                                    "planck-length per attosecond"
                                                                  , "ℓₚ/as"
                                                                  , SI.Velocities.MeterPerFemtosecond
                                                                  , 1.616255E-35 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// planck-length per zeptosecond, defined as: SI meter per attosecond × (1.616255E-35)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerZeptosecond = new (
                                                                     "planck-length per zeptosecond"
                                                                   , "ℓₚ/zs"
                                                                   , SI.Velocities.MeterPerAttosecond
                                                                   , 1.616255E-35 / (1.0 / 1000.0)
                                                                    );

   /// <summary>
   /// planck-length per yoctosecond, defined as: SI meter per zeptosecond × (1.616255E-35)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerYoctosecond = new (
                                                                     "planck-length per yoctosecond"
                                                                   , "ℓₚ/ys"
                                                                   , SI.Velocities.MeterPerZeptosecond
                                                                   , 1.616255E-35 / (1.0 / 1000.0)
                                                                    );

   /// <summary>
   /// planck-length per rontosecond, defined as: SI meter per yoctosecond × (1.616255E-35)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerRontosecond = new (
                                                                     "planck-length per rontosecond"
                                                                   , "ℓₚ/rs"
                                                                   , SI.Velocities.MeterPerYoctosecond
                                                                   , 1.616255E-35 / (1.0 / 1000.0)
                                                                    );

   /// <summary>
   /// planck-length per quectosecond, defined as: SI meter per rontosecond × (1.616255E-35)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerQuectosecond = new (
                                                                      "planck-length per quectosecond"
                                                                    , "ℓₚ/qs"
                                                                    , SI.Velocities.MeterPerRontosecond
                                                                    , 1.616255E-35 / (1.0 / 1000.0)
                                                                     );

   /// <summary>
   /// planck-length per minute, defined as: SI meter per second × (1.616255E-35)/(60.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerMinute = new (
                                                                "planck-length per minute"
                                                              , "ℓₚ/min"
                                                              , SI.Velocities.MeterPerSecond
                                                              , 1.616255E-35 / 60.0
                                                               );

   /// <summary>
   /// planck-length per hour, defined as: SI meter per minute × (1.616255E-35)/(60.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerHour = new (
                                                              "planck-length per hour"
                                                            , "ℓₚ/hr"
                                                            , SI.Velocities.MeterPerMinute
                                                            , 1.616255E-35 / 60.0
                                                             );

   /// <summary>
   /// planck-length per day, defined as: SI meter per hour × (1.616255E-35)/(24.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerDay = new (
                                                             "planck-length per day"
                                                           , "ℓₚ/dy"
                                                           , SI.Velocities.MeterPerHour
                                                           , 1.616255E-35 / 24.0
                                                            );

   /// <summary>
   /// planck-length per week, defined as: SI meter per day × (1.616255E-35)/(7.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerWeek = new (
                                                              "planck-length per week"
                                                            , "ℓₚ/wk"
                                                            , SI.Velocities.MeterPerDay
                                                            , 1.616255E-35 / 7.0
                                                             );

   /// <summary>
   /// planck-length per year, defined as: SI meter per day × (1.616255E-35)/(365.2525)
   /// </summary>
   public static readonly Velocity PlanckLengthPerYear = new (
                                                              "planck-length per year"
                                                            , "ℓₚ/yr"
                                                            , SI.Velocities.MeterPerDay
                                                            , 1.616255E-35 / 365.2525
                                                             );

   /// <summary>
   /// planck-length per decade, defined as: SI meter per year × (1.616255E-35)/(10.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerDecade = new (
                                                                "planck-length per decade"
                                                              , "ℓₚ/decade"
                                                              , SI.Velocities.MeterPerYear
                                                              , 1.616255E-35 / 10.0
                                                               );

   /// <summary>
   /// planck-length per century, defined as: SI meter per decade × (1.616255E-35)/(10.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerCentury = new (
                                                                 "planck-length per century"
                                                               , "ℓₚ/century"
                                                               , SI.Velocities.MeterPerDecade
                                                               , 1.616255E-35 / 10.0
                                                                );

   /// <summary>
   /// planck-length per millennium, defined as: SI meter per century × (1.616255E-35)/(10.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerMillennium = new (
                                                                    "planck-length per millennium"
                                                                  , "ℓₚ/kyr"
                                                                  , SI.Velocities.MeterPerCentury
                                                                  , 1.616255E-35 / 10.0
                                                                   );

   /// <summary>
   /// planck-length per million years, defined as: SI meter per millennium × (1.616255E-35)/(1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerMillionYears = new (
                                                                      "planck-length per million years"
                                                                    , "ℓₚ/Myr"
                                                                    , SI.Velocities.MeterPerMillennium
                                                                    , 1.616255E-35 / 1000.0
                                                                     );

   /// <summary>
   /// planck-length per billion years, defined as: SI meter per million years × (1.616255E-35)/(1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerBillionYears = new (
                                                                      "planck-length per billion years"
                                                                    , "ℓₚ/Gyr"
                                                                    , SI.Velocities.MeterPerMillionYears
                                                                    , 1.616255E-35 / 1000.0
                                                                     );

   /// <summary>
   /// planck-length per trillion years, defined as: SI meter per billion years × (1.616255E-35)/(1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerTrillionYears = new (
                                                                       "planck-length per trillion years"
                                                                     , "ℓₚ/Tyr"
                                                                     , SI.Velocities.MeterPerBillionYears
                                                                     , 1.616255E-35 / 1000.0
                                                                      );

   /// <summary>
   /// planck-length per quadrillion years, defined as: SI meter per trillion years × (1.616255E-35)/(1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerQuadrillionYears = new (
                                                                          "planck-length per quadrillion years"
                                                                        , "ℓₚ/Pyr"
                                                                        , SI.Velocities.MeterPerTrillionYears
                                                                        , 1.616255E-35 / 1000.0
                                                                         );

   /// <summary>
   /// planck-length per quintillion years, defined as: SI meter per quadrillion years × (1.616255E-35)/(1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerQuintillionYears = new (
                                                                          "planck-length per quintillion years"
                                                                        , "ℓₚ/Eyr"
                                                                        , SI.Velocities.MeterPerQuadrillionYears
                                                                        , 1.616255E-35 / 1000.0
                                                                         );

   /// <summary>
   /// planck-length per sextillion years, defined as: SI meter per quintillion years × (1.616255E-35)/(1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerSextillionYears = new (
                                                                         "planck-length per sextillion years"
                                                                       , "ℓₚ/Zyr"
                                                                       , SI.Velocities.MeterPerQuintillionYears
                                                                       , 1.616255E-35 / 1000.0
                                                                        );

   /// <summary>
   /// planck-length per septillion years, defined as: SI meter per sextillion years × (1.616255E-35)/(1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerSeptillionYears = new (
                                                                         "planck-length per septillion years"
                                                                       , "ℓₚ/Yyr"
                                                                       , SI.Velocities.MeterPerSextillionYears
                                                                       , 1.616255E-35 / 1000.0
                                                                        );

   /// <summary>
   /// planck-length per octillion years, defined as: SI meter per septillion years × (1.616255E-35)/(1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerOctillionYears = new (
                                                                        "planck-length per octillion years"
                                                                      , "ℓₚ/Ryr"
                                                                      , SI.Velocities.MeterPerSeptillionYears
                                                                      , 1.616255E-35 / 1000.0
                                                                       );

   /// <summary>
   /// planck-length per nonillion years, defined as: SI meter per octillion years × (1.616255E-35)/(1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerNonillionYears = new (
                                                                        "planck-length per nonillion years"
                                                                      , "ℓₚ/Qyr"
                                                                      , SI.Velocities.MeterPerOctillionYears
                                                                      , 1.616255E-35 / 1000.0
                                                                       );

   /// <summary>
   /// planck-length per decillion years, defined as: SI meter per nonillion years × (1.616255E-35)/(1000.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerDecillionYears = new (
                                                                        "planck-length per decillion years"
                                                                      , "ℓₚ/decillion yr"
                                                                      , SI.Velocities.MeterPerNonillionYears
                                                                      , 1.616255E-35 / 1000.0
                                                                       );

   /// <summary>
   /// planck-length per tick, defined as: SI meter per nanosecond × (1.616255E-35)/(100.0)
   /// </summary>
   public static readonly Velocity PlanckLengthPerTick = new (
                                                              "planck-length per tick"
                                                            , "ℓₚ/tick"
                                                            , SI.Velocities.MeterPerNanosecond
                                                            , 1.616255E-35 / 100.0
                                                             );
}
