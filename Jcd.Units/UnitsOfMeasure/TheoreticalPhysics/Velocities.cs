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
   /// speed of light defined such that: SI meter per second = c × 299_792_458.
   /// </summary>
   public static readonly Velocity SpeedOfLight = new (
                                                       "speed of light"
                                                     , "c"
                                                     , SI.Velocities.MeterPerSecond
                                                     , 299_792_458
                                                     , system: "Theoretical Physics"
                                                      );

   /// <summary>
   /// planck-length per second defined such that: SI meter per second = ℓₚ/s × (1.616255E-35)/(1.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerSecond = new (
                                                                "planck-length per second"
                                                              , "ℓₚ/s"
                                                              , SI.Velocities.MeterPerSecond
                                                              , 1.616255E-35 / 1.0
                                                              , system: "Theoretical Physics"
                                                               );

   /// <summary>
   /// planck-length per planck-time defined such that: SI meter per microsecond = ℓₚ/tₚ × (1.616255E-35)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity PlanckLengthPerPlanckTime = new (
                                                                    "planck-length per planck-time"
                                                                  , "ℓₚ/tₚ"
                                                                  , SI.Velocities.MeterPerMicrosecond
                                                                  , 1.616255E-35 / 5.391247E-38
                                                                  , system: "Theoretical Physics"
                                                                   );

   /// <summary>
   /// planck-length per decisecond defined such that: SI meter per second = ℓₚ/ds × (1.616255E-35)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerDecisecond = new (
                                                                    "planck-length per decisecond"
                                                                  , "ℓₚ/ds"
                                                                  , SI.Velocities.MeterPerSecond
                                                                  , 1.616255E-35 / (1.0 / 10.0)
                                                                  , system: "Theoretical Physics"
                                                                   );

   /// <summary>
   /// planck-length per centisecond defined such that: SI meter per decisecond = ℓₚ/cs × (1.616255E-35)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerCentisecond = new (
                                                                     "planck-length per centisecond"
                                                                   , "ℓₚ/cs"
                                                                   , SI.Velocities.MeterPerDecisecond
                                                                   , 1.616255E-35 / (1.0 / 10.0)
                                                                   , system: "Theoretical Physics"
                                                                    );

   /// <summary>
   /// planck-length per millisecond defined such that: SI meter per centisecond = ℓₚ/ms × (1.616255E-35)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerMillisecond = new (
                                                                     "planck-length per millisecond"
                                                                   , "ℓₚ/ms"
                                                                   , SI.Velocities.MeterPerCentisecond
                                                                   , 1.616255E-35 / (1.0 / 10.0)
                                                                   , system: "Theoretical Physics"
                                                                    );

   /// <summary>
   /// planck-length per microsecond defined such that: SI meter per millisecond = ℓₚ/μs × (1.616255E-35)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerMicrosecond = new (
                                                                     "planck-length per microsecond"
                                                                   , "ℓₚ/μs"
                                                                   , SI.Velocities.MeterPerMillisecond
                                                                   , 1.616255E-35 / (1.0 / 1000.0)
                                                                   , system: "Theoretical Physics"
                                                                    );

   /// <summary>
   /// planck-length per nanosecond defined such that: SI meter per microsecond = ℓₚ/ns × (1.616255E-35)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerNanosecond = new (
                                                                    "planck-length per nanosecond"
                                                                  , "ℓₚ/ns"
                                                                  , SI.Velocities.MeterPerMicrosecond
                                                                  , 1.616255E-35 / (1.0 / 1000.0)
                                                                  , system: "Theoretical Physics"
                                                                   );

   /// <summary>
   /// planck-length per picosecond defined such that: SI meter per nanosecond = ℓₚ/ps × (1.616255E-35)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerPicosecond = new (
                                                                    "planck-length per picosecond"
                                                                  , "ℓₚ/ps"
                                                                  , SI.Velocities.MeterPerNanosecond
                                                                  , 1.616255E-35 / (1.0 / 1000.0)
                                                                  , system: "Theoretical Physics"
                                                                   );

   /// <summary>
   /// planck-length per femtosecond defined such that: SI meter per picosecond = ℓₚ/fs × (1.616255E-35)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerFemtosecond = new (
                                                                     "planck-length per femtosecond"
                                                                   , "ℓₚ/fs"
                                                                   , SI.Velocities.MeterPerPicosecond
                                                                   , 1.616255E-35 / (1.0 / 1000.0)
                                                                   , system: "Theoretical Physics"
                                                                    );

   /// <summary>
   /// planck-length per attosecond defined such that: SI meter per femtosecond = ℓₚ/as × (1.616255E-35)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerAttosecond = new (
                                                                    "planck-length per attosecond"
                                                                  , "ℓₚ/as"
                                                                  , SI.Velocities.MeterPerFemtosecond
                                                                  , 1.616255E-35 / (1.0 / 1000.0)
                                                                  , system: "Theoretical Physics"
                                                                   );

   /// <summary>
   /// planck-length per zeptosecond defined such that: SI meter per attosecond = ℓₚ/zs × (1.616255E-35)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerZeptosecond = new (
                                                                     "planck-length per zeptosecond"
                                                                   , "ℓₚ/zs"
                                                                   , SI.Velocities.MeterPerAttosecond
                                                                   , 1.616255E-35 / (1.0 / 1000.0)
                                                                   , system: "Theoretical Physics"
                                                                    );

   /// <summary>
   /// planck-length per yoctosecond defined such that: SI meter per zeptosecond = ℓₚ/ys × (1.616255E-35)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerYoctosecond = new (
                                                                     "planck-length per yoctosecond"
                                                                   , "ℓₚ/ys"
                                                                   , SI.Velocities.MeterPerZeptosecond
                                                                   , 1.616255E-35 / (1.0 / 1000.0)
                                                                   , system: "Theoretical Physics"
                                                                    );

   /// <summary>
   /// planck-length per rontosecond defined such that: SI meter per yoctosecond = ℓₚ/rs × (1.616255E-35)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerRontosecond = new (
                                                                     "planck-length per rontosecond"
                                                                   , "ℓₚ/rs"
                                                                   , SI.Velocities.MeterPerYoctosecond
                                                                   , 1.616255E-35 / (1.0 / 1000.0)
                                                                   , system: "Theoretical Physics"
                                                                    );

   /// <summary>
   /// planck-length per quectosecond defined such that: SI meter per rontosecond = ℓₚ/qs × (1.616255E-35)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerQuectosecond = new (
                                                                      "planck-length per quectosecond"
                                                                    , "ℓₚ/qs"
                                                                    , SI.Velocities.MeterPerRontosecond
                                                                    , 1.616255E-35 / (1.0 / 1000.0)
                                                                    , system: "Theoretical Physics"
                                                                     );

   /// <summary>
   /// planck-length per minute defined such that: SI meter per second = ℓₚ/min × (1.616255E-35)/(60.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerMinute = new (
                                                                "planck-length per minute"
                                                              , "ℓₚ/min"
                                                              , SI.Velocities.MeterPerSecond
                                                              , 1.616255E-35 / 60.0
                                                              , system: "Theoretical Physics"
                                                               );

   /// <summary>
   /// planck-length per hour defined such that: SI meter per minute = ℓₚ/hr × (1.616255E-35)/(60.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerHour = new (
                                                              "planck-length per hour"
                                                            , "ℓₚ/hr"
                                                            , SI.Velocities.MeterPerMinute
                                                            , 1.616255E-35 / 60.0
                                                            , system: "Theoretical Physics"
                                                             );

   /// <summary>
   /// planck-length per day defined such that: SI meter per hour = ℓₚ/dy × (1.616255E-35)/(24.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerDay = new (
                                                             "planck-length per day"
                                                           , "ℓₚ/dy"
                                                           , SI.Velocities.MeterPerHour
                                                           , 1.616255E-35 / 24.0
                                                           , system: "Theoretical Physics"
                                                            );

   /// <summary>
   /// planck-length per week defined such that: SI meter per day = ℓₚ/wk × (1.616255E-35)/(7.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerWeek = new (
                                                              "planck-length per week"
                                                            , "ℓₚ/wk"
                                                            , SI.Velocities.MeterPerDay
                                                            , 1.616255E-35 / 7.0
                                                            , system: "Theoretical Physics"
                                                             );

   /// <summary>
   /// planck-length per year defined such that: SI meter per day = ℓₚ/yr × (1.616255E-35)/(365.2525).
   /// </summary>
   public static readonly Velocity PlanckLengthPerYear = new (
                                                              "planck-length per year"
                                                            , "ℓₚ/yr"
                                                            , SI.Velocities.MeterPerDay
                                                            , 1.616255E-35 / 365.2525
                                                            , system: "Theoretical Physics"
                                                             );

   /// <summary>
   /// planck-length per decade defined such that: SI meter per year = ℓₚ/decade × (1.616255E-35)/(10.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerDecade = new (
                                                                "planck-length per decade"
                                                              , "ℓₚ/decade"
                                                              , SI.Velocities.MeterPerYear
                                                              , 1.616255E-35 / 10.0
                                                              , system: "Theoretical Physics"
                                                               );

   /// <summary>
   /// planck-length per century defined such that: SI meter per decade = ℓₚ/century × (1.616255E-35)/(10.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerCentury = new (
                                                                 "planck-length per century"
                                                               , "ℓₚ/century"
                                                               , SI.Velocities.MeterPerDecade
                                                               , 1.616255E-35 / 10.0
                                                               , system: "Theoretical Physics"
                                                                );

   /// <summary>
   /// planck-length per millennium defined such that: SI meter per century = ℓₚ/kyr × (1.616255E-35)/(10.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerMillennium = new (
                                                                    "planck-length per millennium"
                                                                  , "ℓₚ/kyr"
                                                                  , SI.Velocities.MeterPerCentury
                                                                  , 1.616255E-35 / 10.0
                                                                  , system: "Theoretical Physics"
                                                                   );

   /// <summary>
   /// planck-length per million years defined such that: SI meter per millennium = ℓₚ/Myr × (1.616255E-35)/(1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerMillionYears = new (
                                                                      "planck-length per million years"
                                                                    , "ℓₚ/Myr"
                                                                    , SI.Velocities.MeterPerMillennium
                                                                    , 1.616255E-35 / 1000.0
                                                                    , system: "Theoretical Physics"
                                                                     );

   /// <summary>
   /// planck-length per billion years defined such that: SI meter per million years = ℓₚ/Gyr × (1.616255E-35)/(1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerBillionYears = new (
                                                                      "planck-length per billion years"
                                                                    , "ℓₚ/Gyr"
                                                                    , SI.Velocities.MeterPerMillionYears
                                                                    , 1.616255E-35 / 1000.0
                                                                    , system: "Theoretical Physics"
                                                                     );

   /// <summary>
   /// planck-length per trillion years defined such that: SI meter per billion years = ℓₚ/Tyr × (1.616255E-35)/(1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerTrillionYears = new (
                                                                       "planck-length per trillion years"
                                                                     , "ℓₚ/Tyr"
                                                                     , SI.Velocities.MeterPerBillionYears
                                                                     , 1.616255E-35 / 1000.0
                                                                     , system: "Theoretical Physics"
                                                                      );

   /// <summary>
   /// planck-length per quadrillion years defined such that: SI meter per trillion years = ℓₚ/Pyr × (1.616255E-35)/(1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerQuadrillionYears = new (
                                                                          "planck-length per quadrillion years"
                                                                        , "ℓₚ/Pyr"
                                                                        , SI.Velocities.MeterPerTrillionYears
                                                                        , 1.616255E-35 / 1000.0
                                                                        , system: "Theoretical Physics"
                                                                         );

   /// <summary>
   /// planck-length per quintillion years defined such that: SI meter per quadrillion years = ℓₚ/Eyr × (1.616255E-35)/(1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerQuintillionYears = new (
                                                                          "planck-length per quintillion years"
                                                                        , "ℓₚ/Eyr"
                                                                        , SI.Velocities.MeterPerQuadrillionYears
                                                                        , 1.616255E-35 / 1000.0
                                                                        , system: "Theoretical Physics"
                                                                         );

   /// <summary>
   /// planck-length per sextillion years defined such that: SI meter per quintillion years = ℓₚ/Zyr × (1.616255E-35)/(1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerSextillionYears = new (
                                                                         "planck-length per sextillion years"
                                                                       , "ℓₚ/Zyr"
                                                                       , SI.Velocities.MeterPerQuintillionYears
                                                                       , 1.616255E-35 / 1000.0
                                                                       , system: "Theoretical Physics"
                                                                        );

   /// <summary>
   /// planck-length per septillion years defined such that: SI meter per sextillion years = ℓₚ/Yyr × (1.616255E-35)/(1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerSeptillionYears = new (
                                                                         "planck-length per septillion years"
                                                                       , "ℓₚ/Yyr"
                                                                       , SI.Velocities.MeterPerSextillionYears
                                                                       , 1.616255E-35 / 1000.0
                                                                       , system: "Theoretical Physics"
                                                                        );

   /// <summary>
   /// planck-length per octillion years defined such that: SI meter per septillion years = ℓₚ/Ryr × (1.616255E-35)/(1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerOctillionYears = new (
                                                                        "planck-length per octillion years"
                                                                      , "ℓₚ/Ryr"
                                                                      , SI.Velocities.MeterPerSeptillionYears
                                                                      , 1.616255E-35 / 1000.0
                                                                      , system: "Theoretical Physics"
                                                                       );

   /// <summary>
   /// planck-length per nonillion years defined such that: SI meter per octillion years = ℓₚ/Qyr × (1.616255E-35)/(1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerNonillionYears = new (
                                                                        "planck-length per nonillion years"
                                                                      , "ℓₚ/Qyr"
                                                                      , SI.Velocities.MeterPerOctillionYears
                                                                      , 1.616255E-35 / 1000.0
                                                                      , system: "Theoretical Physics"
                                                                       );

   /// <summary>
   /// planck-length per decillion years defined such that: SI meter per nonillion years = ℓₚ/decillion yr × (1.616255E-35)/(1000.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerDecillionYears = new (
                                                                        "planck-length per decillion years"
                                                                      , "ℓₚ/decillion yr"
                                                                      , SI.Velocities.MeterPerNonillionYears
                                                                      , 1.616255E-35 / 1000.0
                                                                      , system: "Theoretical Physics"
                                                                       );

   /// <summary>
   /// planck-length per tick defined such that: SI meter per nanosecond = ℓₚ/tick × (1.616255E-35)/(100.0).
   /// </summary>
   public static readonly Velocity PlanckLengthPerTick = new (
                                                              "planck-length per tick"
                                                            , "ℓₚ/tick"
                                                            , SI.Velocities.MeterPerNanosecond
                                                            , 1.616255E-35 / 100.0
                                                            , system: "Theoretical Physics"
                                                             );
}
