#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.Imperial;

/// <summary>
/// British Imperial Units for measuring Velocity.
/// </summary>
public class Velocities : UnitOfMeasureEnumeration<Velocities, Velocity>
{
   /// <summary>
   /// inch per second defined such that: SI centimeter per second = in/s × (2.54)/(1.0).
   /// </summary>
   public static readonly Velocity InchPerSecond = new (
                                                        "inch per second"
                                                      , "in/s"
                                                      , SI.Velocities.CentimeterPerSecond
                                                      , 2.54 / 1.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// inch per planck-time defined such that: SI centimeter per microsecond = in/tₚ × (2.54)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity InchPerPlanckTime = new (
                                                            "inch per planck-time"
                                                          , "in/tₚ"
                                                          , SI.Velocities.CentimeterPerMicrosecond
                                                          , 2.54 / 5.391247E-38
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// inch per decisecond defined such that: SI centimeter per second = in/ds × (2.54)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity InchPerDecisecond = new (
                                                            "inch per decisecond"
                                                          , "in/ds"
                                                          , SI.Velocities.CentimeterPerSecond
                                                          , 2.54 / (1.0 / 10.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// inch per centisecond defined such that: SI centimeter per decisecond = in/cs × (2.54)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity InchPerCentisecond = new (
                                                             "inch per centisecond"
                                                           , "in/cs"
                                                           , SI.Velocities.CentimeterPerDecisecond
                                                           , 2.54 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// inch per millisecond defined such that: SI centimeter per centisecond = in/ms × (2.54)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity InchPerMillisecond = new (
                                                             "inch per millisecond"
                                                           , "in/ms"
                                                           , SI.Velocities.CentimeterPerCentisecond
                                                           , 2.54 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// inch per microsecond defined such that: SI centimeter per millisecond = in/μs × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerMicrosecond = new (
                                                             "inch per microsecond"
                                                           , "in/μs"
                                                           , SI.Velocities.CentimeterPerMillisecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// inch per nanosecond defined such that: SI centimeter per microsecond = in/ns × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerNanosecond = new (
                                                            "inch per nanosecond"
                                                          , "in/ns"
                                                          , SI.Velocities.CentimeterPerMicrosecond
                                                          , 2.54 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// inch per picosecond defined such that: SI centimeter per nanosecond = in/ps × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerPicosecond = new (
                                                            "inch per picosecond"
                                                          , "in/ps"
                                                          , SI.Velocities.CentimeterPerNanosecond
                                                          , 2.54 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// inch per femtosecond defined such that: SI centimeter per picosecond = in/fs × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerFemtosecond = new (
                                                             "inch per femtosecond"
                                                           , "in/fs"
                                                           , SI.Velocities.CentimeterPerPicosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// inch per attosecond defined such that: SI centimeter per femtosecond = in/as × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerAttosecond = new (
                                                            "inch per attosecond"
                                                          , "in/as"
                                                          , SI.Velocities.CentimeterPerFemtosecond
                                                          , 2.54 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// inch per zeptosecond defined such that: SI centimeter per attosecond = in/zs × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerZeptosecond = new (
                                                             "inch per zeptosecond"
                                                           , "in/zs"
                                                           , SI.Velocities.CentimeterPerAttosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// inch per yoctosecond defined such that: SI centimeter per zeptosecond = in/ys × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerYoctosecond = new (
                                                             "inch per yoctosecond"
                                                           , "in/ys"
                                                           , SI.Velocities.CentimeterPerZeptosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// inch per rontosecond defined such that: SI centimeter per yoctosecond = in/rs × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerRontosecond = new (
                                                             "inch per rontosecond"
                                                           , "in/rs"
                                                           , SI.Velocities.CentimeterPerYoctosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// inch per quectosecond defined such that: SI centimeter per rontosecond = in/qs × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerQuectosecond = new (
                                                              "inch per quectosecond"
                                                            , "in/qs"
                                                            , SI.Velocities.CentimeterPerRontosecond
                                                            , 2.54 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// inch per minute defined such that: SI centimeter per second = in/min × (2.54)/(60.0).
   /// </summary>
   public static readonly Velocity InchPerMinute = new (
                                                        "inch per minute"
                                                      , "in/min"
                                                      , SI.Velocities.CentimeterPerSecond
                                                      , 2.54 / 60.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// foot per second defined such that: inch per second = ft/s × (12)/(1.0).
   /// </summary>
   public static readonly Velocity FootPerSecond = new (
                                                        "foot per second"
                                                      , "ft/s"
                                                      , InchPerSecond
                                                      , 12 / 1.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// foot per planck-time defined such that: inch per microsecond = ft/tₚ × (12)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity FootPerPlanckTime = new (
                                                            "foot per planck-time"
                                                          , "ft/tₚ"
                                                          , InchPerMicrosecond
                                                          , 12 / 5.391247E-38
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// foot per decisecond defined such that: inch per second = ft/ds × (12)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FootPerDecisecond = new (
                                                            "foot per decisecond"
                                                          , "ft/ds"
                                                          , InchPerSecond
                                                          , 12 / (1.0 / 10.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// foot per centisecond defined such that: inch per decisecond = ft/cs × (12)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FootPerCentisecond = new (
                                                             "foot per centisecond"
                                                           , "ft/cs"
                                                           , InchPerDecisecond
                                                           , 12 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// foot per millisecond defined such that: inch per centisecond = ft/ms × (12)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FootPerMillisecond = new (
                                                             "foot per millisecond"
                                                           , "ft/ms"
                                                           , InchPerCentisecond
                                                           , 12 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// foot per microsecond defined such that: inch per millisecond = ft/μs × (12)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerMicrosecond = new (
                                                             "foot per microsecond"
                                                           , "ft/μs"
                                                           , InchPerMillisecond
                                                           , 12 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// foot per nanosecond defined such that: inch per microsecond = ft/ns × (12)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerNanosecond = new (
                                                            "foot per nanosecond"
                                                          , "ft/ns"
                                                          , InchPerMicrosecond
                                                          , 12 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// foot per picosecond defined such that: inch per nanosecond = ft/ps × (12)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerPicosecond = new (
                                                            "foot per picosecond"
                                                          , "ft/ps"
                                                          , InchPerNanosecond
                                                          , 12 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// foot per femtosecond defined such that: inch per picosecond = ft/fs × (12)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerFemtosecond = new (
                                                             "foot per femtosecond"
                                                           , "ft/fs"
                                                           , InchPerPicosecond
                                                           , 12 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// foot per attosecond defined such that: inch per femtosecond = ft/as × (12)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerAttosecond = new (
                                                            "foot per attosecond"
                                                          , "ft/as"
                                                          , InchPerFemtosecond
                                                          , 12 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// foot per zeptosecond defined such that: inch per attosecond = ft/zs × (12)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerZeptosecond = new (
                                                             "foot per zeptosecond"
                                                           , "ft/zs"
                                                           , InchPerAttosecond
                                                           , 12 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// foot per yoctosecond defined such that: inch per zeptosecond = ft/ys × (12)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerYoctosecond = new (
                                                             "foot per yoctosecond"
                                                           , "ft/ys"
                                                           , InchPerZeptosecond
                                                           , 12 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// foot per rontosecond defined such that: inch per yoctosecond = ft/rs × (12)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerRontosecond = new (
                                                             "foot per rontosecond"
                                                           , "ft/rs"
                                                           , InchPerYoctosecond
                                                           , 12 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// foot per quectosecond defined such that: inch per rontosecond = ft/qs × (12)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerQuectosecond = new (
                                                              "foot per quectosecond"
                                                            , "ft/qs"
                                                            , InchPerRontosecond
                                                            , 12 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// inch per hour defined such that: SI centimeter per minute = in/hr × (2.54)/(60.0).
   /// </summary>
   public static readonly Velocity InchPerHour = new (
                                                      "inch per hour"
                                                    , "in/hr"
                                                    , SI.Velocities.CentimeterPerMinute
                                                    , 2.54 / 60.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// twip per second defined such that: foot per second = twip/s × (1.0/17280.0)/(1.0).
   /// </summary>
   public static readonly Velocity TwipPerSecond = new (
                                                        "twip per second"
                                                      , "twip/s"
                                                      , FootPerSecond
                                                      , 1.0 / 17280.0 / 1.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// twip per planck-time defined such that: foot per microsecond = twip/tₚ × (1.0/17280.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity TwipPerPlanckTime = new (
                                                            "twip per planck-time"
                                                          , "twip/tₚ"
                                                          , FootPerMicrosecond
                                                          , 1.0 / 17280.0 / 5.391247E-38
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// twip per decisecond defined such that: foot per second = twip/ds × (1.0/17280.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity TwipPerDecisecond = new (
                                                            "twip per decisecond"
                                                          , "twip/ds"
                                                          , FootPerSecond
                                                          , 1.0 / 17280.0 / (1.0 / 10.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// twip per centisecond defined such that: foot per decisecond = twip/cs × (1.0/17280.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity TwipPerCentisecond = new (
                                                             "twip per centisecond"
                                                           , "twip/cs"
                                                           , FootPerDecisecond
                                                           , 1.0 / 17280.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// twip per millisecond defined such that: foot per centisecond = twip/ms × (1.0/17280.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity TwipPerMillisecond = new (
                                                             "twip per millisecond"
                                                           , "twip/ms"
                                                           , FootPerCentisecond
                                                           , 1.0 / 17280.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// twip per microsecond defined such that: foot per millisecond = twip/μs × (1.0/17280.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerMicrosecond = new (
                                                             "twip per microsecond"
                                                           , "twip/μs"
                                                           , FootPerMillisecond
                                                           , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// twip per nanosecond defined such that: foot per microsecond = twip/ns × (1.0/17280.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerNanosecond = new (
                                                            "twip per nanosecond"
                                                          , "twip/ns"
                                                          , FootPerMicrosecond
                                                          , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// twip per picosecond defined such that: foot per nanosecond = twip/ps × (1.0/17280.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerPicosecond = new (
                                                            "twip per picosecond"
                                                          , "twip/ps"
                                                          , FootPerNanosecond
                                                          , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// twip per femtosecond defined such that: foot per picosecond = twip/fs × (1.0/17280.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerFemtosecond = new (
                                                             "twip per femtosecond"
                                                           , "twip/fs"
                                                           , FootPerPicosecond
                                                           , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// twip per attosecond defined such that: foot per femtosecond = twip/as × (1.0/17280.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerAttosecond = new (
                                                            "twip per attosecond"
                                                          , "twip/as"
                                                          , FootPerFemtosecond
                                                          , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// twip per zeptosecond defined such that: foot per attosecond = twip/zs × (1.0/17280.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerZeptosecond = new (
                                                             "twip per zeptosecond"
                                                           , "twip/zs"
                                                           , FootPerAttosecond
                                                           , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// twip per yoctosecond defined such that: foot per zeptosecond = twip/ys × (1.0/17280.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerYoctosecond = new (
                                                             "twip per yoctosecond"
                                                           , "twip/ys"
                                                           , FootPerZeptosecond
                                                           , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// twip per rontosecond defined such that: foot per yoctosecond = twip/rs × (1.0/17280.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerRontosecond = new (
                                                             "twip per rontosecond"
                                                           , "twip/rs"
                                                           , FootPerYoctosecond
                                                           , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// twip per quectosecond defined such that: foot per rontosecond = twip/qs × (1.0/17280.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerQuectosecond = new (
                                                              "twip per quectosecond"
                                                            , "twip/qs"
                                                            , FootPerRontosecond
                                                            , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// inch per day defined such that: SI centimeter per hour = in/dy × (2.54)/(24.0).
   /// </summary>
   public static readonly Velocity InchPerDay = new (
                                                     "inch per day"
                                                   , "in/dy"
                                                   , SI.Velocities.CentimeterPerHour
                                                   , 2.54 / 24.0
                                                   , system: "Imperial"
                                                    );

   /// <summary>
   /// thou per second defined such that: foot per second = th/s × (1.0/12000.0)/(1.0).
   /// </summary>
   public static readonly Velocity ThouPerSecond = new (
                                                        "thou per second"
                                                      , "th/s"
                                                      , FootPerSecond
                                                      , 1.0 / 12000.0 / 1.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// thou per planck-time defined such that: foot per microsecond = th/tₚ × (1.0/12000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity ThouPerPlanckTime = new (
                                                            "thou per planck-time"
                                                          , "th/tₚ"
                                                          , FootPerMicrosecond
                                                          , 1.0 / 12000.0 / 5.391247E-38
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// thou per decisecond defined such that: foot per second = th/ds × (1.0/12000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ThouPerDecisecond = new (
                                                            "thou per decisecond"
                                                          , "th/ds"
                                                          , FootPerSecond
                                                          , 1.0 / 12000.0 / (1.0 / 10.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// thou per centisecond defined such that: foot per decisecond = th/cs × (1.0/12000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ThouPerCentisecond = new (
                                                             "thou per centisecond"
                                                           , "th/cs"
                                                           , FootPerDecisecond
                                                           , 1.0 / 12000.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// thou per millisecond defined such that: foot per centisecond = th/ms × (1.0/12000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ThouPerMillisecond = new (
                                                             "thou per millisecond"
                                                           , "th/ms"
                                                           , FootPerCentisecond
                                                           , 1.0 / 12000.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// thou per microsecond defined such that: foot per millisecond = th/μs × (1.0/12000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ThouPerMicrosecond = new (
                                                             "thou per microsecond"
                                                           , "th/μs"
                                                           , FootPerMillisecond
                                                           , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// thou per nanosecond defined such that: foot per microsecond = th/ns × (1.0/12000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ThouPerNanosecond = new (
                                                            "thou per nanosecond"
                                                          , "th/ns"
                                                          , FootPerMicrosecond
                                                          , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// thou per picosecond defined such that: foot per nanosecond = th/ps × (1.0/12000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ThouPerPicosecond = new (
                                                            "thou per picosecond"
                                                          , "th/ps"
                                                          , FootPerNanosecond
                                                          , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// thou per femtosecond defined such that: foot per picosecond = th/fs × (1.0/12000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ThouPerFemtosecond = new (
                                                             "thou per femtosecond"
                                                           , "th/fs"
                                                           , FootPerPicosecond
                                                           , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// thou per attosecond defined such that: foot per femtosecond = th/as × (1.0/12000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ThouPerAttosecond = new (
                                                            "thou per attosecond"
                                                          , "th/as"
                                                          , FootPerFemtosecond
                                                          , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// thou per zeptosecond defined such that: foot per attosecond = th/zs × (1.0/12000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ThouPerZeptosecond = new (
                                                             "thou per zeptosecond"
                                                           , "th/zs"
                                                           , FootPerAttosecond
                                                           , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// thou per yoctosecond defined such that: foot per zeptosecond = th/ys × (1.0/12000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ThouPerYoctosecond = new (
                                                             "thou per yoctosecond"
                                                           , "th/ys"
                                                           , FootPerZeptosecond
                                                           , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// thou per rontosecond defined such that: foot per yoctosecond = th/rs × (1.0/12000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ThouPerRontosecond = new (
                                                             "thou per rontosecond"
                                                           , "th/rs"
                                                           , FootPerYoctosecond
                                                           , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// thou per quectosecond defined such that: foot per rontosecond = th/qs × (1.0/12000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ThouPerQuectosecond = new (
                                                              "thou per quectosecond"
                                                            , "th/qs"
                                                            , FootPerRontosecond
                                                            , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// inch per week defined such that: SI centimeter per day = in/wk × (2.54)/(7.0).
   /// </summary>
   public static readonly Velocity InchPerWeek = new (
                                                      "inch per week"
                                                    , "in/wk"
                                                    , SI.Velocities.CentimeterPerDay
                                                    , 2.54 / 7.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// barleycorn per second defined such that: foot per second = barleycorn/s × (1.0/36.0)/(1.0).
   /// </summary>
   public static readonly Velocity BarleycornPerSecond = new (
                                                              "barleycorn per second"
                                                            , "barleycorn/s"
                                                            , FootPerSecond
                                                            , 1.0 / 36.0 / 1.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// barleycorn per planck-time defined such that: foot per microsecond = barleycorn/tₚ × (1.0/36.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity BarleycornPerPlanckTime = new (
                                                                  "barleycorn per planck-time"
                                                                , "barleycorn/tₚ"
                                                                , FootPerMicrosecond
                                                                , 1.0 / 36.0 / 5.391247E-38
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// barleycorn per decisecond defined such that: foot per second = barleycorn/ds × (1.0/36.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity BarleycornPerDecisecond = new (
                                                                  "barleycorn per decisecond"
                                                                , "barleycorn/ds"
                                                                , FootPerSecond
                                                                , 1.0 / 36.0 / (1.0 / 10.0)
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// barleycorn per centisecond defined such that: foot per decisecond = barleycorn/cs × (1.0/36.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity BarleycornPerCentisecond = new (
                                                                   "barleycorn per centisecond"
                                                                 , "barleycorn/cs"
                                                                 , FootPerDecisecond
                                                                 , 1.0 / 36.0 / (1.0 / 10.0)
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// barleycorn per millisecond defined such that: foot per centisecond = barleycorn/ms × (1.0/36.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity BarleycornPerMillisecond = new (
                                                                   "barleycorn per millisecond"
                                                                 , "barleycorn/ms"
                                                                 , FootPerCentisecond
                                                                 , 1.0 / 36.0 / (1.0 / 10.0)
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// barleycorn per microsecond defined such that: foot per millisecond = barleycorn/μs × (1.0/36.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerMicrosecond = new (
                                                                   "barleycorn per microsecond"
                                                                 , "barleycorn/μs"
                                                                 , FootPerMillisecond
                                                                 , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// barleycorn per nanosecond defined such that: foot per microsecond = barleycorn/ns × (1.0/36.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerNanosecond = new (
                                                                  "barleycorn per nanosecond"
                                                                , "barleycorn/ns"
                                                                , FootPerMicrosecond
                                                                , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// barleycorn per picosecond defined such that: foot per nanosecond = barleycorn/ps × (1.0/36.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerPicosecond = new (
                                                                  "barleycorn per picosecond"
                                                                , "barleycorn/ps"
                                                                , FootPerNanosecond
                                                                , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// barleycorn per femtosecond defined such that: foot per picosecond = barleycorn/fs × (1.0/36.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerFemtosecond = new (
                                                                   "barleycorn per femtosecond"
                                                                 , "barleycorn/fs"
                                                                 , FootPerPicosecond
                                                                 , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// barleycorn per attosecond defined such that: foot per femtosecond = barleycorn/as × (1.0/36.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerAttosecond = new (
                                                                  "barleycorn per attosecond"
                                                                , "barleycorn/as"
                                                                , FootPerFemtosecond
                                                                , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// barleycorn per zeptosecond defined such that: foot per attosecond = barleycorn/zs × (1.0/36.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerZeptosecond = new (
                                                                   "barleycorn per zeptosecond"
                                                                 , "barleycorn/zs"
                                                                 , FootPerAttosecond
                                                                 , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// barleycorn per yoctosecond defined such that: foot per zeptosecond = barleycorn/ys × (1.0/36.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerYoctosecond = new (
                                                                   "barleycorn per yoctosecond"
                                                                 , "barleycorn/ys"
                                                                 , FootPerZeptosecond
                                                                 , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// barleycorn per rontosecond defined such that: foot per yoctosecond = barleycorn/rs × (1.0/36.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerRontosecond = new (
                                                                   "barleycorn per rontosecond"
                                                                 , "barleycorn/rs"
                                                                 , FootPerYoctosecond
                                                                 , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// barleycorn per quectosecond defined such that: foot per rontosecond = barleycorn/qs × (1.0/36.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerQuectosecond = new (
                                                                    "barleycorn per quectosecond"
                                                                  , "barleycorn/qs"
                                                                  , FootPerRontosecond
                                                                  , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// inch per year defined such that: SI centimeter per day = in/yr × (2.54)/(365.2525).
   /// </summary>
   public static readonly Velocity InchPerYear = new (
                                                      "inch per year"
                                                    , "in/yr"
                                                    , SI.Velocities.CentimeterPerDay
                                                    , 2.54 / 365.2525
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// hand per second defined such that: inch per second = hh/s × (4.0)/(1.0).
   /// </summary>
   public static readonly Velocity HandPerSecond = new (
                                                        "hand per second"
                                                      , "hh/s"
                                                      , InchPerSecond
                                                      , 4.0 / 1.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// hand per planck-time defined such that: inch per microsecond = hh/tₚ × (4.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity HandPerPlanckTime = new (
                                                            "hand per planck-time"
                                                          , "hh/tₚ"
                                                          , InchPerMicrosecond
                                                          , 4.0 / 5.391247E-38
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// hand per decisecond defined such that: inch per second = hh/ds × (4.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity HandPerDecisecond = new (
                                                            "hand per decisecond"
                                                          , "hh/ds"
                                                          , InchPerSecond
                                                          , 4.0 / (1.0 / 10.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// hand per centisecond defined such that: inch per decisecond = hh/cs × (4.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity HandPerCentisecond = new (
                                                             "hand per centisecond"
                                                           , "hh/cs"
                                                           , InchPerDecisecond
                                                           , 4.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// hand per millisecond defined such that: inch per centisecond = hh/ms × (4.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity HandPerMillisecond = new (
                                                             "hand per millisecond"
                                                           , "hh/ms"
                                                           , InchPerCentisecond
                                                           , 4.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// hand per microsecond defined such that: inch per millisecond = hh/μs × (4.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HandPerMicrosecond = new (
                                                             "hand per microsecond"
                                                           , "hh/μs"
                                                           , InchPerMillisecond
                                                           , 4.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// hand per nanosecond defined such that: inch per microsecond = hh/ns × (4.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HandPerNanosecond = new (
                                                            "hand per nanosecond"
                                                          , "hh/ns"
                                                          , InchPerMicrosecond
                                                          , 4.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// hand per picosecond defined such that: inch per nanosecond = hh/ps × (4.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HandPerPicosecond = new (
                                                            "hand per picosecond"
                                                          , "hh/ps"
                                                          , InchPerNanosecond
                                                          , 4.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// hand per femtosecond defined such that: inch per picosecond = hh/fs × (4.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HandPerFemtosecond = new (
                                                             "hand per femtosecond"
                                                           , "hh/fs"
                                                           , InchPerPicosecond
                                                           , 4.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// hand per attosecond defined such that: inch per femtosecond = hh/as × (4.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HandPerAttosecond = new (
                                                            "hand per attosecond"
                                                          , "hh/as"
                                                          , InchPerFemtosecond
                                                          , 4.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// hand per zeptosecond defined such that: inch per attosecond = hh/zs × (4.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HandPerZeptosecond = new (
                                                             "hand per zeptosecond"
                                                           , "hh/zs"
                                                           , InchPerAttosecond
                                                           , 4.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// hand per yoctosecond defined such that: inch per zeptosecond = hh/ys × (4.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HandPerYoctosecond = new (
                                                             "hand per yoctosecond"
                                                           , "hh/ys"
                                                           , InchPerZeptosecond
                                                           , 4.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// hand per rontosecond defined such that: inch per yoctosecond = hh/rs × (4.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HandPerRontosecond = new (
                                                             "hand per rontosecond"
                                                           , "hh/rs"
                                                           , InchPerYoctosecond
                                                           , 4.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// hand per quectosecond defined such that: inch per rontosecond = hh/qs × (4.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HandPerQuectosecond = new (
                                                              "hand per quectosecond"
                                                            , "hh/qs"
                                                            , InchPerRontosecond
                                                            , 4.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// inch per decade defined such that: SI centimeter per year = in/decade × (2.54)/(10.0).
   /// </summary>
   public static readonly Velocity InchPerDecade = new (
                                                        "inch per decade"
                                                      , "in/decade"
                                                      , SI.Velocities.CentimeterPerYear
                                                      , 2.54 / 10.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// yard per second defined such that: foot per second = yd/s × (3.0)/(1.0).
   /// </summary>
   public static readonly Velocity YardPerSecond = new (
                                                        "yard per second"
                                                      , "yd/s"
                                                      , FootPerSecond
                                                      , 3.0 / 1.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// yard per planck-time defined such that: foot per microsecond = yd/tₚ × (3.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity YardPerPlanckTime = new (
                                                            "yard per planck-time"
                                                          , "yd/tₚ"
                                                          , FootPerMicrosecond
                                                          , 3.0 / 5.391247E-38
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// yard per decisecond defined such that: foot per second = yd/ds × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YardPerDecisecond = new (
                                                            "yard per decisecond"
                                                          , "yd/ds"
                                                          , FootPerSecond
                                                          , 3.0 / (1.0 / 10.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// yard per centisecond defined such that: foot per decisecond = yd/cs × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YardPerCentisecond = new (
                                                             "yard per centisecond"
                                                           , "yd/cs"
                                                           , FootPerDecisecond
                                                           , 3.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// yard per millisecond defined such that: foot per centisecond = yd/ms × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YardPerMillisecond = new (
                                                             "yard per millisecond"
                                                           , "yd/ms"
                                                           , FootPerCentisecond
                                                           , 3.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// yard per microsecond defined such that: foot per millisecond = yd/μs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerMicrosecond = new (
                                                             "yard per microsecond"
                                                           , "yd/μs"
                                                           , FootPerMillisecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// yard per nanosecond defined such that: foot per microsecond = yd/ns × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerNanosecond = new (
                                                            "yard per nanosecond"
                                                          , "yd/ns"
                                                          , FootPerMicrosecond
                                                          , 3.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// yard per picosecond defined such that: foot per nanosecond = yd/ps × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerPicosecond = new (
                                                            "yard per picosecond"
                                                          , "yd/ps"
                                                          , FootPerNanosecond
                                                          , 3.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// yard per femtosecond defined such that: foot per picosecond = yd/fs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerFemtosecond = new (
                                                             "yard per femtosecond"
                                                           , "yd/fs"
                                                           , FootPerPicosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// yard per attosecond defined such that: foot per femtosecond = yd/as × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerAttosecond = new (
                                                            "yard per attosecond"
                                                          , "yd/as"
                                                          , FootPerFemtosecond
                                                          , 3.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// yard per zeptosecond defined such that: foot per attosecond = yd/zs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerZeptosecond = new (
                                                             "yard per zeptosecond"
                                                           , "yd/zs"
                                                           , FootPerAttosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// yard per yoctosecond defined such that: foot per zeptosecond = yd/ys × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerYoctosecond = new (
                                                             "yard per yoctosecond"
                                                           , "yd/ys"
                                                           , FootPerZeptosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// yard per rontosecond defined such that: foot per yoctosecond = yd/rs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerRontosecond = new (
                                                             "yard per rontosecond"
                                                           , "yd/rs"
                                                           , FootPerYoctosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// yard per quectosecond defined such that: foot per rontosecond = yd/qs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerQuectosecond = new (
                                                              "yard per quectosecond"
                                                            , "yd/qs"
                                                            , FootPerRontosecond
                                                            , 3.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// inch per century defined such that: SI centimeter per decade = in/century × (2.54)/(10.0).
   /// </summary>
   public static readonly Velocity InchPerCentury = new (
                                                         "inch per century"
                                                       , "in/century"
                                                       , SI.Velocities.CentimeterPerDecade
                                                       , 2.54 / 10.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// chain per second defined such that: yard per second = ch/s × (22.0)/(1.0).
   /// </summary>
   public static readonly Velocity ChainPerSecond = new (
                                                         "chain per second"
                                                       , "ch/s"
                                                       , YardPerSecond
                                                       , 22.0 / 1.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// chain per planck-time defined such that: yard per microsecond = ch/tₚ × (22.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity ChainPerPlanckTime = new (
                                                             "chain per planck-time"
                                                           , "ch/tₚ"
                                                           , YardPerMicrosecond
                                                           , 22.0 / 5.391247E-38
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// chain per decisecond defined such that: yard per second = ch/ds × (22.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ChainPerDecisecond = new (
                                                             "chain per decisecond"
                                                           , "ch/ds"
                                                           , YardPerSecond
                                                           , 22.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// chain per centisecond defined such that: yard per decisecond = ch/cs × (22.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ChainPerCentisecond = new (
                                                              "chain per centisecond"
                                                            , "ch/cs"
                                                            , YardPerDecisecond
                                                            , 22.0 / (1.0 / 10.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// chain per millisecond defined such that: yard per centisecond = ch/ms × (22.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ChainPerMillisecond = new (
                                                              "chain per millisecond"
                                                            , "ch/ms"
                                                            , YardPerCentisecond
                                                            , 22.0 / (1.0 / 10.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// chain per microsecond defined such that: yard per millisecond = ch/μs × (22.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerMicrosecond = new (
                                                              "chain per microsecond"
                                                            , "ch/μs"
                                                            , YardPerMillisecond
                                                            , 22.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// chain per nanosecond defined such that: yard per microsecond = ch/ns × (22.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerNanosecond = new (
                                                             "chain per nanosecond"
                                                           , "ch/ns"
                                                           , YardPerMicrosecond
                                                           , 22.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// chain per picosecond defined such that: yard per nanosecond = ch/ps × (22.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerPicosecond = new (
                                                             "chain per picosecond"
                                                           , "ch/ps"
                                                           , YardPerNanosecond
                                                           , 22.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// chain per femtosecond defined such that: yard per picosecond = ch/fs × (22.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerFemtosecond = new (
                                                              "chain per femtosecond"
                                                            , "ch/fs"
                                                            , YardPerPicosecond
                                                            , 22.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// chain per attosecond defined such that: yard per femtosecond = ch/as × (22.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerAttosecond = new (
                                                             "chain per attosecond"
                                                           , "ch/as"
                                                           , YardPerFemtosecond
                                                           , 22.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// chain per zeptosecond defined such that: yard per attosecond = ch/zs × (22.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerZeptosecond = new (
                                                              "chain per zeptosecond"
                                                            , "ch/zs"
                                                            , YardPerAttosecond
                                                            , 22.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// chain per yoctosecond defined such that: yard per zeptosecond = ch/ys × (22.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerYoctosecond = new (
                                                              "chain per yoctosecond"
                                                            , "ch/ys"
                                                            , YardPerZeptosecond
                                                            , 22.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// chain per rontosecond defined such that: yard per yoctosecond = ch/rs × (22.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerRontosecond = new (
                                                              "chain per rontosecond"
                                                            , "ch/rs"
                                                            , YardPerYoctosecond
                                                            , 22.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// chain per quectosecond defined such that: yard per rontosecond = ch/qs × (22.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ChainPerQuectosecond = new (
                                                               "chain per quectosecond"
                                                             , "ch/qs"
                                                             , YardPerRontosecond
                                                             , 22.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// inch per millennium defined such that: SI centimeter per century = in/kyr × (2.54)/(10.0).
   /// </summary>
   public static readonly Velocity InchPerMillennium = new (
                                                            "inch per millennium"
                                                          , "in/kyr"
                                                          , SI.Velocities.CentimeterPerCentury
                                                          , 2.54 / 10.0
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// furlong per second defined such that: chain per second = fur/s × (10.0)/(1.0).
   /// </summary>
   public static readonly Velocity FurlongPerSecond = new (
                                                           "furlong per second"
                                                         , "fur/s"
                                                         , ChainPerSecond
                                                         , 10.0 / 1.0
                                                         , system: "Imperial"
                                                          );

   /// <summary>
   /// furlong per planck-time defined such that: chain per microsecond = fur/tₚ × (10.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity FurlongPerPlanckTime = new (
                                                               "furlong per planck-time"
                                                             , "fur/tₚ"
                                                             , ChainPerMicrosecond
                                                             , 10.0 / 5.391247E-38
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// furlong per decisecond defined such that: chain per second = fur/ds × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FurlongPerDecisecond = new (
                                                               "furlong per decisecond"
                                                             , "fur/ds"
                                                             , ChainPerSecond
                                                             , 10.0 / (1.0 / 10.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// furlong per centisecond defined such that: chain per decisecond = fur/cs × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FurlongPerCentisecond = new (
                                                                "furlong per centisecond"
                                                              , "fur/cs"
                                                              , ChainPerDecisecond
                                                              , 10.0 / (1.0 / 10.0)
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// furlong per millisecond defined such that: chain per centisecond = fur/ms × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FurlongPerMillisecond = new (
                                                                "furlong per millisecond"
                                                              , "fur/ms"
                                                              , ChainPerCentisecond
                                                              , 10.0 / (1.0 / 10.0)
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// furlong per microsecond defined such that: chain per millisecond = fur/μs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerMicrosecond = new (
                                                                "furlong per microsecond"
                                                              , "fur/μs"
                                                              , ChainPerMillisecond
                                                              , 10.0 / (1.0 / 1000.0)
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// furlong per nanosecond defined such that: chain per microsecond = fur/ns × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerNanosecond = new (
                                                               "furlong per nanosecond"
                                                             , "fur/ns"
                                                             , ChainPerMicrosecond
                                                             , 10.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// furlong per picosecond defined such that: chain per nanosecond = fur/ps × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerPicosecond = new (
                                                               "furlong per picosecond"
                                                             , "fur/ps"
                                                             , ChainPerNanosecond
                                                             , 10.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// furlong per femtosecond defined such that: chain per picosecond = fur/fs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerFemtosecond = new (
                                                                "furlong per femtosecond"
                                                              , "fur/fs"
                                                              , ChainPerPicosecond
                                                              , 10.0 / (1.0 / 1000.0)
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// furlong per attosecond defined such that: chain per femtosecond = fur/as × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerAttosecond = new (
                                                               "furlong per attosecond"
                                                             , "fur/as"
                                                             , ChainPerFemtosecond
                                                             , 10.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// furlong per zeptosecond defined such that: chain per attosecond = fur/zs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerZeptosecond = new (
                                                                "furlong per zeptosecond"
                                                              , "fur/zs"
                                                              , ChainPerAttosecond
                                                              , 10.0 / (1.0 / 1000.0)
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// furlong per yoctosecond defined such that: chain per zeptosecond = fur/ys × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerYoctosecond = new (
                                                                "furlong per yoctosecond"
                                                              , "fur/ys"
                                                              , ChainPerZeptosecond
                                                              , 10.0 / (1.0 / 1000.0)
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// furlong per rontosecond defined such that: chain per yoctosecond = fur/rs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerRontosecond = new (
                                                                "furlong per rontosecond"
                                                              , "fur/rs"
                                                              , ChainPerYoctosecond
                                                              , 10.0 / (1.0 / 1000.0)
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// furlong per quectosecond defined such that: chain per rontosecond = fur/qs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerQuectosecond = new (
                                                                 "furlong per quectosecond"
                                                               , "fur/qs"
                                                               , ChainPerRontosecond
                                                               , 10.0 / (1.0 / 1000.0)
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// inch per million years defined such that: SI centimeter per millennium = in/Myr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerMillionYears = new (
                                                              "inch per million years"
                                                            , "in/Myr"
                                                            , SI.Velocities.CentimeterPerMillennium
                                                            , 2.54 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// mile per second defined such that: furlong per second = mi/s × (8.0)/(1.0).
   /// </summary>
   public static readonly Velocity MilePerSecond = new (
                                                        "mile per second"
                                                      , "mi/s"
                                                      , FurlongPerSecond
                                                      , 8.0 / 1.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// mile per planck-time defined such that: furlong per microsecond = mi/tₚ × (8.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity MilePerPlanckTime = new (
                                                            "mile per planck-time"
                                                          , "mi/tₚ"
                                                          , FurlongPerMicrosecond
                                                          , 8.0 / 5.391247E-38
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// mile per decisecond defined such that: furlong per second = mi/ds × (8.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MilePerDecisecond = new (
                                                            "mile per decisecond"
                                                          , "mi/ds"
                                                          , FurlongPerSecond
                                                          , 8.0 / (1.0 / 10.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// mile per centisecond defined such that: furlong per decisecond = mi/cs × (8.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MilePerCentisecond = new (
                                                             "mile per centisecond"
                                                           , "mi/cs"
                                                           , FurlongPerDecisecond
                                                           , 8.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// mile per millisecond defined such that: furlong per centisecond = mi/ms × (8.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MilePerMillisecond = new (
                                                             "mile per millisecond"
                                                           , "mi/ms"
                                                           , FurlongPerCentisecond
                                                           , 8.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// mile per microsecond defined such that: furlong per millisecond = mi/μs × (8.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerMicrosecond = new (
                                                             "mile per microsecond"
                                                           , "mi/μs"
                                                           , FurlongPerMillisecond
                                                           , 8.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// mile per nanosecond defined such that: furlong per microsecond = mi/ns × (8.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerNanosecond = new (
                                                            "mile per nanosecond"
                                                          , "mi/ns"
                                                          , FurlongPerMicrosecond
                                                          , 8.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// mile per picosecond defined such that: furlong per nanosecond = mi/ps × (8.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerPicosecond = new (
                                                            "mile per picosecond"
                                                          , "mi/ps"
                                                          , FurlongPerNanosecond
                                                          , 8.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// mile per femtosecond defined such that: furlong per picosecond = mi/fs × (8.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerFemtosecond = new (
                                                             "mile per femtosecond"
                                                           , "mi/fs"
                                                           , FurlongPerPicosecond
                                                           , 8.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// mile per attosecond defined such that: furlong per femtosecond = mi/as × (8.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerAttosecond = new (
                                                            "mile per attosecond"
                                                          , "mi/as"
                                                          , FurlongPerFemtosecond
                                                          , 8.0 / (1.0 / 1000.0)
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// mile per zeptosecond defined such that: furlong per attosecond = mi/zs × (8.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerZeptosecond = new (
                                                             "mile per zeptosecond"
                                                           , "mi/zs"
                                                           , FurlongPerAttosecond
                                                           , 8.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// mile per yoctosecond defined such that: furlong per zeptosecond = mi/ys × (8.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerYoctosecond = new (
                                                             "mile per yoctosecond"
                                                           , "mi/ys"
                                                           , FurlongPerZeptosecond
                                                           , 8.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// mile per rontosecond defined such that: furlong per yoctosecond = mi/rs × (8.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerRontosecond = new (
                                                             "mile per rontosecond"
                                                           , "mi/rs"
                                                           , FurlongPerYoctosecond
                                                           , 8.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// mile per quectosecond defined such that: furlong per rontosecond = mi/qs × (8.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerQuectosecond = new (
                                                              "mile per quectosecond"
                                                            , "mi/qs"
                                                            , FurlongPerRontosecond
                                                            , 8.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// inch per billion years defined such that: SI centimeter per million years = in/Gyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerBillionYears = new (
                                                              "inch per billion years"
                                                            , "in/Gyr"
                                                            , SI.Velocities.CentimeterPerMillionYears
                                                            , 2.54 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// league per second defined such that: mile per second = lea/s × (3.0)/(1.0).
   /// </summary>
   public static readonly Velocity LeaguePerSecond = new (
                                                          "league per second"
                                                        , "lea/s"
                                                        , MilePerSecond
                                                        , 3.0 / 1.0
                                                        , system: "Imperial"
                                                         );

   /// <summary>
   /// league per planck-time defined such that: mile per microsecond = lea/tₚ × (3.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity LeaguePerPlanckTime = new (
                                                              "league per planck-time"
                                                            , "lea/tₚ"
                                                            , MilePerMicrosecond
                                                            , 3.0 / 5.391247E-38
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// league per decisecond defined such that: mile per second = lea/ds × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LeaguePerDecisecond = new (
                                                              "league per decisecond"
                                                            , "lea/ds"
                                                            , MilePerSecond
                                                            , 3.0 / (1.0 / 10.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// league per centisecond defined such that: mile per decisecond = lea/cs × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LeaguePerCentisecond = new (
                                                               "league per centisecond"
                                                             , "lea/cs"
                                                             , MilePerDecisecond
                                                             , 3.0 / (1.0 / 10.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// league per millisecond defined such that: mile per centisecond = lea/ms × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LeaguePerMillisecond = new (
                                                               "league per millisecond"
                                                             , "lea/ms"
                                                             , MilePerCentisecond
                                                             , 3.0 / (1.0 / 10.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// league per microsecond defined such that: mile per millisecond = lea/μs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerMicrosecond = new (
                                                               "league per microsecond"
                                                             , "lea/μs"
                                                             , MilePerMillisecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// league per nanosecond defined such that: mile per microsecond = lea/ns × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerNanosecond = new (
                                                              "league per nanosecond"
                                                            , "lea/ns"
                                                            , MilePerMicrosecond
                                                            , 3.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// league per picosecond defined such that: mile per nanosecond = lea/ps × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerPicosecond = new (
                                                              "league per picosecond"
                                                            , "lea/ps"
                                                            , MilePerNanosecond
                                                            , 3.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// league per femtosecond defined such that: mile per picosecond = lea/fs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerFemtosecond = new (
                                                               "league per femtosecond"
                                                             , "lea/fs"
                                                             , MilePerPicosecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// league per attosecond defined such that: mile per femtosecond = lea/as × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerAttosecond = new (
                                                              "league per attosecond"
                                                            , "lea/as"
                                                            , MilePerFemtosecond
                                                            , 3.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// league per zeptosecond defined such that: mile per attosecond = lea/zs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerZeptosecond = new (
                                                               "league per zeptosecond"
                                                             , "lea/zs"
                                                             , MilePerAttosecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// league per yoctosecond defined such that: mile per zeptosecond = lea/ys × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerYoctosecond = new (
                                                               "league per yoctosecond"
                                                             , "lea/ys"
                                                             , MilePerZeptosecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// league per rontosecond defined such that: mile per yoctosecond = lea/rs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerRontosecond = new (
                                                               "league per rontosecond"
                                                             , "lea/rs"
                                                             , MilePerYoctosecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// league per quectosecond defined such that: mile per rontosecond = lea/qs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerQuectosecond = new (
                                                                "league per quectosecond"
                                                              , "lea/qs"
                                                              , MilePerRontosecond
                                                              , 3.0 / (1.0 / 1000.0)
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// inch per trillion years defined such that: SI centimeter per billion years = in/Tyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerTrillionYears = new (
                                                               "inch per trillion years"
                                                             , "in/Tyr"
                                                             , SI.Velocities.CentimeterPerBillionYears
                                                             , 2.54 / 1000.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per second defined such that: foot per second = ftm/s × (6.0)/(1.0).
   /// </summary>
   public static readonly Velocity FathomPerSecond = new (
                                                          "fathom per second"
                                                        , "ftm/s"
                                                        , FootPerSecond
                                                        , 6.0 / 1.0
                                                        , system: "Imperial"
                                                         );

   /// <summary>
   /// fathom per planck-time defined such that: foot per microsecond = ftm/tₚ × (6.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity FathomPerPlanckTime = new (
                                                              "fathom per planck-time"
                                                            , "ftm/tₚ"
                                                            , FootPerMicrosecond
                                                            , 6.0 / 5.391247E-38
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// fathom per decisecond defined such that: foot per second = ftm/ds × (6.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FathomPerDecisecond = new (
                                                              "fathom per decisecond"
                                                            , "ftm/ds"
                                                            , FootPerSecond
                                                            , 6.0 / (1.0 / 10.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// fathom per centisecond defined such that: foot per decisecond = ftm/cs × (6.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FathomPerCentisecond = new (
                                                               "fathom per centisecond"
                                                             , "ftm/cs"
                                                             , FootPerDecisecond
                                                             , 6.0 / (1.0 / 10.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per millisecond defined such that: foot per centisecond = ftm/ms × (6.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FathomPerMillisecond = new (
                                                               "fathom per millisecond"
                                                             , "ftm/ms"
                                                             , FootPerCentisecond
                                                             , 6.0 / (1.0 / 10.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per microsecond defined such that: foot per millisecond = ftm/μs × (6.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerMicrosecond = new (
                                                               "fathom per microsecond"
                                                             , "ftm/μs"
                                                             , FootPerMillisecond
                                                             , 6.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per nanosecond defined such that: foot per microsecond = ftm/ns × (6.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerNanosecond = new (
                                                              "fathom per nanosecond"
                                                            , "ftm/ns"
                                                            , FootPerMicrosecond
                                                            , 6.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// fathom per picosecond defined such that: foot per nanosecond = ftm/ps × (6.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerPicosecond = new (
                                                              "fathom per picosecond"
                                                            , "ftm/ps"
                                                            , FootPerNanosecond
                                                            , 6.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// fathom per femtosecond defined such that: foot per picosecond = ftm/fs × (6.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerFemtosecond = new (
                                                               "fathom per femtosecond"
                                                             , "ftm/fs"
                                                             , FootPerPicosecond
                                                             , 6.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per attosecond defined such that: foot per femtosecond = ftm/as × (6.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerAttosecond = new (
                                                              "fathom per attosecond"
                                                            , "ftm/as"
                                                            , FootPerFemtosecond
                                                            , 6.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// fathom per zeptosecond defined such that: foot per attosecond = ftm/zs × (6.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerZeptosecond = new (
                                                               "fathom per zeptosecond"
                                                             , "ftm/zs"
                                                             , FootPerAttosecond
                                                             , 6.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per yoctosecond defined such that: foot per zeptosecond = ftm/ys × (6.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerYoctosecond = new (
                                                               "fathom per yoctosecond"
                                                             , "ftm/ys"
                                                             , FootPerZeptosecond
                                                             , 6.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per rontosecond defined such that: foot per yoctosecond = ftm/rs × (6.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerRontosecond = new (
                                                               "fathom per rontosecond"
                                                             , "ftm/rs"
                                                             , FootPerYoctosecond
                                                             , 6.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per quectosecond defined such that: foot per rontosecond = ftm/qs × (6.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerQuectosecond = new (
                                                                "fathom per quectosecond"
                                                              , "ftm/qs"
                                                              , FootPerRontosecond
                                                              , 6.0 / (1.0 / 1000.0)
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// inch per quadrillion years defined such that: SI centimeter per trillion years = in/Pyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerQuadrillionYears = new (
                                                                  "inch per quadrillion years"
                                                                , "in/Pyr"
                                                                , SI.Velocities.CentimeterPerTrillionYears
                                                                , 2.54 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// cable per second defined such that: fathom per second = cable/s × (100.0)/(1.0).
   /// </summary>
   public static readonly Velocity CablePerSecond = new (
                                                         "cable per second"
                                                       , "cable/s"
                                                       , FathomPerSecond
                                                       , 100.0 / 1.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// cable per planck-time defined such that: fathom per microsecond = cable/tₚ × (100.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity CablePerPlanckTime = new (
                                                             "cable per planck-time"
                                                           , "cable/tₚ"
                                                           , FathomPerMicrosecond
                                                           , 100.0 / 5.391247E-38
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// cable per decisecond defined such that: fathom per second = cable/ds × (100.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity CablePerDecisecond = new (
                                                             "cable per decisecond"
                                                           , "cable/ds"
                                                           , FathomPerSecond
                                                           , 100.0 / (1.0 / 10.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// cable per centisecond defined such that: fathom per decisecond = cable/cs × (100.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity CablePerCentisecond = new (
                                                              "cable per centisecond"
                                                            , "cable/cs"
                                                            , FathomPerDecisecond
                                                            , 100.0 / (1.0 / 10.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// cable per millisecond defined such that: fathom per centisecond = cable/ms × (100.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity CablePerMillisecond = new (
                                                              "cable per millisecond"
                                                            , "cable/ms"
                                                            , FathomPerCentisecond
                                                            , 100.0 / (1.0 / 10.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// cable per microsecond defined such that: fathom per millisecond = cable/μs × (100.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerMicrosecond = new (
                                                              "cable per microsecond"
                                                            , "cable/μs"
                                                            , FathomPerMillisecond
                                                            , 100.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// cable per nanosecond defined such that: fathom per microsecond = cable/ns × (100.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerNanosecond = new (
                                                             "cable per nanosecond"
                                                           , "cable/ns"
                                                           , FathomPerMicrosecond
                                                           , 100.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// cable per picosecond defined such that: fathom per nanosecond = cable/ps × (100.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerPicosecond = new (
                                                             "cable per picosecond"
                                                           , "cable/ps"
                                                           , FathomPerNanosecond
                                                           , 100.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// cable per femtosecond defined such that: fathom per picosecond = cable/fs × (100.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerFemtosecond = new (
                                                              "cable per femtosecond"
                                                            , "cable/fs"
                                                            , FathomPerPicosecond
                                                            , 100.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// cable per attosecond defined such that: fathom per femtosecond = cable/as × (100.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerAttosecond = new (
                                                             "cable per attosecond"
                                                           , "cable/as"
                                                           , FathomPerFemtosecond
                                                           , 100.0 / (1.0 / 1000.0)
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// cable per zeptosecond defined such that: fathom per attosecond = cable/zs × (100.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerZeptosecond = new (
                                                              "cable per zeptosecond"
                                                            , "cable/zs"
                                                            , FathomPerAttosecond
                                                            , 100.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// cable per yoctosecond defined such that: fathom per zeptosecond = cable/ys × (100.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerYoctosecond = new (
                                                              "cable per yoctosecond"
                                                            , "cable/ys"
                                                            , FathomPerZeptosecond
                                                            , 100.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// cable per rontosecond defined such that: fathom per yoctosecond = cable/rs × (100.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerRontosecond = new (
                                                              "cable per rontosecond"
                                                            , "cable/rs"
                                                            , FathomPerYoctosecond
                                                            , 100.0 / (1.0 / 1000.0)
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// cable per quectosecond defined such that: fathom per rontosecond = cable/qs × (100.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerQuectosecond = new (
                                                               "cable per quectosecond"
                                                             , "cable/qs"
                                                             , FathomPerRontosecond
                                                             , 100.0 / (1.0 / 1000.0)
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// inch per quintillion years defined such that: SI centimeter per quadrillion years = in/Eyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerQuintillionYears = new (
                                                                  "inch per quintillion years"
                                                                , "in/Eyr"
                                                                , SI.Velocities.CentimeterPerQuadrillionYears
                                                                , 2.54 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// nautical mile per second defined such that: cable per second = nmi/s × (10.0)/(1.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSecond = new (
                                                                "nautical mile per second"
                                                              , "nmi/s"
                                                              , CablePerSecond
                                                              , 10.0 / 1.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// nautical mile per planck-time defined such that: cable per microsecond = nmi/tₚ × (10.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity NauticalMilePerPlanckTime = new (
                                                                    "nautical mile per planck-time"
                                                                  , "nmi/tₚ"
                                                                  , CablePerMicrosecond
                                                                  , 10.0 / 5.391247E-38
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// nautical mile per decisecond defined such that: cable per second = nmi/ds × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecisecond = new (
                                                                    "nautical mile per decisecond"
                                                                  , "nmi/ds"
                                                                  , CablePerSecond
                                                                  , 10.0 / (1.0 / 10.0)
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// nautical mile per centisecond defined such that: cable per decisecond = nmi/cs × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerCentisecond = new (
                                                                     "nautical mile per centisecond"
                                                                   , "nmi/cs"
                                                                   , CablePerDecisecond
                                                                   , 10.0 / (1.0 / 10.0)
                                                                   , system: "Imperial"
                                                                    );

   /// <summary>
   /// nautical mile per millisecond defined such that: cable per centisecond = nmi/ms × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillisecond = new (
                                                                     "nautical mile per millisecond"
                                                                   , "nmi/ms"
                                                                   , CablePerCentisecond
                                                                   , 10.0 / (1.0 / 10.0)
                                                                   , system: "Imperial"
                                                                    );

   /// <summary>
   /// nautical mile per microsecond defined such that: cable per millisecond = nmi/μs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMicrosecond = new (
                                                                     "nautical mile per microsecond"
                                                                   , "nmi/μs"
                                                                   , CablePerMillisecond
                                                                   , 10.0 / (1.0 / 1000.0)
                                                                   , system: "Imperial"
                                                                    );

   /// <summary>
   /// nautical mile per nanosecond defined such that: cable per microsecond = nmi/ns × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerNanosecond = new (
                                                                    "nautical mile per nanosecond"
                                                                  , "nmi/ns"
                                                                  , CablePerMicrosecond
                                                                  , 10.0 / (1.0 / 1000.0)
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// nautical mile per picosecond defined such that: cable per nanosecond = nmi/ps × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerPicosecond = new (
                                                                    "nautical mile per picosecond"
                                                                  , "nmi/ps"
                                                                  , CablePerNanosecond
                                                                  , 10.0 / (1.0 / 1000.0)
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// nautical mile per femtosecond defined such that: cable per picosecond = nmi/fs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerFemtosecond = new (
                                                                     "nautical mile per femtosecond"
                                                                   , "nmi/fs"
                                                                   , CablePerPicosecond
                                                                   , 10.0 / (1.0 / 1000.0)
                                                                   , system: "Imperial"
                                                                    );

   /// <summary>
   /// nautical mile per attosecond defined such that: cable per femtosecond = nmi/as × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerAttosecond = new (
                                                                    "nautical mile per attosecond"
                                                                  , "nmi/as"
                                                                  , CablePerFemtosecond
                                                                  , 10.0 / (1.0 / 1000.0)
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// nautical mile per zeptosecond defined such that: cable per attosecond = nmi/zs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerZeptosecond = new (
                                                                     "nautical mile per zeptosecond"
                                                                   , "nmi/zs"
                                                                   , CablePerAttosecond
                                                                   , 10.0 / (1.0 / 1000.0)
                                                                   , system: "Imperial"
                                                                    );

   /// <summary>
   /// nautical mile per yoctosecond defined such that: cable per zeptosecond = nmi/ys × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerYoctosecond = new (
                                                                     "nautical mile per yoctosecond"
                                                                   , "nmi/ys"
                                                                   , CablePerZeptosecond
                                                                   , 10.0 / (1.0 / 1000.0)
                                                                   , system: "Imperial"
                                                                    );

   /// <summary>
   /// nautical mile per rontosecond defined such that: cable per yoctosecond = nmi/rs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerRontosecond = new (
                                                                     "nautical mile per rontosecond"
                                                                   , "nmi/rs"
                                                                   , CablePerYoctosecond
                                                                   , 10.0 / (1.0 / 1000.0)
                                                                   , system: "Imperial"
                                                                    );

   /// <summary>
   /// nautical mile per quectosecond defined such that: cable per rontosecond = nmi/qs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuectosecond = new (
                                                                      "nautical mile per quectosecond"
                                                                    , "nmi/qs"
                                                                    , CablePerRontosecond
                                                                    , 10.0 / (1.0 / 1000.0)
                                                                    , system: "Imperial"
                                                                     );

   /// <summary>
   /// inch per sextillion years defined such that: SI centimeter per quintillion years = in/Zyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerSextillionYears = new (
                                                                 "inch per sextillion years"
                                                               , "in/Zyr"
                                                               , SI.Velocities.CentimeterPerQuintillionYears
                                                               , 2.54 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// inch per septillion years defined such that: SI centimeter per sextillion years = in/Yyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerSeptillionYears = new (
                                                                 "inch per septillion years"
                                                               , "in/Yyr"
                                                               , SI.Velocities.CentimeterPerSextillionYears
                                                               , 2.54 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// inch per octillion years defined such that: SI centimeter per septillion years = in/Ryr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerOctillionYears = new (
                                                                "inch per octillion years"
                                                              , "in/Ryr"
                                                              , SI.Velocities.CentimeterPerSeptillionYears
                                                              , 2.54 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// inch per nonillion years defined such that: SI centimeter per octillion years = in/Qyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerNonillionYears = new (
                                                                "inch per nonillion years"
                                                              , "in/Qyr"
                                                              , SI.Velocities.CentimeterPerOctillionYears
                                                              , 2.54 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// inch per decillion years defined such that: SI centimeter per nonillion years = in/decillion yr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerDecillionYears = new (
                                                                "inch per decillion years"
                                                              , "in/decillion yr"
                                                              , SI.Velocities.CentimeterPerNonillionYears
                                                              , 2.54 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// inch per tick defined such that: SI centimeter per nanosecond = in/tick × (2.54)/(100.0).
   /// </summary>
   public static readonly Velocity InchPerTick = new (
                                                      "inch per tick"
                                                    , "in/tick"
                                                    , SI.Velocities.CentimeterPerNanosecond
                                                    , 2.54 / 100.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// cable per tick defined such that: fathom per nanosecond = cable/tick × (100.0)/(100.0).
   /// </summary>
   public static readonly Velocity CablePerTick = new (
                                                       "cable per tick"
                                                     , "cable/tick"
                                                     , FathomPerNanosecond
                                                     , 100.0 / 100.0
                                                     , system: "Imperial"
                                                      );

   /// <summary>
   /// foot per minute defined such that: inch per second = ft/min × (12)/(60.0).
   /// </summary>
   public static readonly Velocity FootPerMinute = new (
                                                        "foot per minute"
                                                      , "ft/min"
                                                      , InchPerSecond
                                                      , 12 / 60.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// hand per septillion years defined such that: inch per sextillion years = hh/Yyr × (4.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HandPerSeptillionYears = new (
                                                                 "hand per septillion years"
                                                               , "hh/Yyr"
                                                               , InchPerSextillionYears
                                                               , 4.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// hand per week defined such that: inch per day = hh/wk × (4.0)/(7.0).
   /// </summary>
   public static readonly Velocity HandPerWeek = new (
                                                      "hand per week"
                                                    , "hh/wk"
                                                    , InchPerDay
                                                    , 4.0 / 7.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// foot per tick defined such that: inch per nanosecond = ft/tick × (12)/(100.0).
   /// </summary>
   public static readonly Velocity FootPerTick = new (
                                                      "foot per tick"
                                                    , "ft/tick"
                                                    , InchPerNanosecond
                                                    , 12 / 100.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// nautical mile per tick defined such that: cable per nanosecond = nmi/tick × (10.0)/(100.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerTick = new (
                                                              "nautical mile per tick"
                                                            , "nmi/tick"
                                                            , CablePerNanosecond
                                                            , 10.0 / 100.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// foot per hour defined such that: inch per minute = ft/hr × (12)/(60.0).
   /// </summary>
   public static readonly Velocity FootPerHour = new (
                                                      "foot per hour"
                                                    , "ft/hr"
                                                    , InchPerMinute
                                                    , 12 / 60.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// twip per minute defined such that: foot per second = twip/min × (1.0/17280.0)/(60.0).
   /// </summary>
   public static readonly Velocity TwipPerMinute = new (
                                                        "twip per minute"
                                                      , "twip/min"
                                                      , FootPerSecond
                                                      , 1.0 / 17280.0 / 60.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// foot per day defined such that: inch per hour = ft/dy × (12)/(24.0).
   /// </summary>
   public static readonly Velocity FootPerDay = new (
                                                     "foot per day"
                                                   , "ft/dy"
                                                   , InchPerHour
                                                   , 12 / 24.0
                                                   , system: "Imperial"
                                                    );

   /// <summary>
   /// thou per minute defined such that: foot per second = th/min × (1.0/12000.0)/(60.0).
   /// </summary>
   public static readonly Velocity ThouPerMinute = new (
                                                        "thou per minute"
                                                      , "th/min"
                                                      , FootPerSecond
                                                      , 1.0 / 12000.0 / 60.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// hand per millennium defined such that: inch per century = hh/kyr × (4.0)/(10.0).
   /// </summary>
   public static readonly Velocity HandPerMillennium = new (
                                                            "hand per millennium"
                                                          , "hh/kyr"
                                                          , InchPerCentury
                                                          , 4.0 / 10.0
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// twip per tick defined such that: foot per nanosecond = twip/tick × (1.0/17280.0)/(100.0).
   /// </summary>
   public static readonly Velocity TwipPerTick = new (
                                                      "twip per tick"
                                                    , "twip/tick"
                                                    , FootPerNanosecond
                                                    , 1.0 / 17280.0 / 100.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// fathom per hour defined such that: foot per minute = ftm/hr × (6.0)/(60.0).
   /// </summary>
   public static readonly Velocity FathomPerHour = new (
                                                        "fathom per hour"
                                                      , "ftm/hr"
                                                      , FootPerMinute
                                                      , 6.0 / 60.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// twip per hour defined such that: foot per minute = twip/hr × (1.0/17280.0)/(60.0).
   /// </summary>
   public static readonly Velocity TwipPerHour = new (
                                                      "twip per hour"
                                                    , "twip/hr"
                                                    , FootPerMinute
                                                    , 1.0 / 17280.0 / 60.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// foot per week defined such that: inch per day = ft/wk × (12)/(7.0).
   /// </summary>
   public static readonly Velocity FootPerWeek = new (
                                                      "foot per week"
                                                    , "ft/wk"
                                                    , InchPerDay
                                                    , 12 / 7.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// barleycorn per minute defined such that: foot per second = barleycorn/min × (1.0/36.0)/(60.0).
   /// </summary>
   public static readonly Velocity BarleycornPerMinute = new (
                                                              "barleycorn per minute"
                                                            , "barleycorn/min"
                                                            , FootPerSecond
                                                            , 1.0 / 36.0 / 60.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// hand per quadrillion years defined such that: inch per trillion years = hh/Pyr × (4.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HandPerQuadrillionYears = new (
                                                                  "hand per quadrillion years"
                                                                , "hh/Pyr"
                                                                , InchPerTrillionYears
                                                                , 4.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// thou per tick defined such that: foot per nanosecond = th/tick × (1.0/12000.0)/(100.0).
   /// </summary>
   public static readonly Velocity ThouPerTick = new (
                                                      "thou per tick"
                                                    , "th/tick"
                                                    , FootPerNanosecond
                                                    , 1.0 / 12000.0 / 100.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// foot per year defined such that: inch per day = ft/yr × (12)/(365.2525).
   /// </summary>
   public static readonly Velocity FootPerYear = new (
                                                      "foot per year"
                                                    , "ft/yr"
                                                    , InchPerDay
                                                    , 12 / 365.2525
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// hand per minute defined such that: inch per second = hh/min × (4.0)/(60.0).
   /// </summary>
   public static readonly Velocity HandPerMinute = new (
                                                        "hand per minute"
                                                      , "hh/min"
                                                      , InchPerSecond
                                                      , 4.0 / 60.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// barleycorn per decade defined such that: foot per year = barleycorn/decade × (1.0/36.0)/(10.0).
   /// </summary>
   public static readonly Velocity BarleycornPerDecade = new (
                                                              "barleycorn per decade"
                                                            , "barleycorn/decade"
                                                            , FootPerYear
                                                            , 1.0 / 36.0 / 10.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// yard per week defined such that: foot per day = yd/wk × (3.0)/(7.0).
   /// </summary>
   public static readonly Velocity YardPerWeek = new (
                                                      "yard per week"
                                                    , "yd/wk"
                                                    , FootPerDay
                                                    , 3.0 / 7.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// twip per day defined such that: foot per hour = twip/dy × (1.0/17280.0)/(24.0).
   /// </summary>
   public static readonly Velocity TwipPerDay = new (
                                                     "twip per day"
                                                   , "twip/dy"
                                                   , FootPerHour
                                                   , 1.0 / 17280.0 / 24.0
                                                   , system: "Imperial"
                                                    );

   /// <summary>
   /// thou per hour defined such that: foot per minute = th/hr × (1.0/12000.0)/(60.0).
   /// </summary>
   public static readonly Velocity ThouPerHour = new (
                                                      "thou per hour"
                                                    , "th/hr"
                                                    , FootPerMinute
                                                    , 1.0 / 12000.0 / 60.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// foot per decade defined such that: inch per year = ft/decade × (12)/(10.0).
   /// </summary>
   public static readonly Velocity FootPerDecade = new (
                                                        "foot per decade"
                                                      , "ft/decade"
                                                      , InchPerYear
                                                      , 12 / 10.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// yard per minute defined such that: foot per second = yd/min × (3.0)/(60.0).
   /// </summary>
   public static readonly Velocity YardPerMinute = new (
                                                        "yard per minute"
                                                      , "yd/min"
                                                      , FootPerSecond
                                                      , 3.0 / 60.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// hand per octillion years defined such that: inch per septillion years = hh/Ryr × (4.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HandPerOctillionYears = new (
                                                                "hand per octillion years"
                                                              , "hh/Ryr"
                                                              , InchPerSeptillionYears
                                                              , 4.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// barleycorn per tick defined such that: foot per nanosecond = barleycorn/tick × (1.0/36.0)/(100.0).
   /// </summary>
   public static readonly Velocity BarleycornPerTick = new (
                                                            "barleycorn per tick"
                                                          , "barleycorn/tick"
                                                          , FootPerNanosecond
                                                          , 1.0 / 36.0 / 100.0
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// hand per year defined such that: inch per day = hh/yr × (4.0)/(365.2525).
   /// </summary>
   public static readonly Velocity HandPerYear = new (
                                                      "hand per year"
                                                    , "hh/yr"
                                                    , InchPerDay
                                                    , 4.0 / 365.2525
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// foot per century defined such that: inch per decade = ft/century × (12)/(10.0).
   /// </summary>
   public static readonly Velocity FootPerCentury = new (
                                                         "foot per century"
                                                       , "ft/century"
                                                       , InchPerDecade
                                                       , 12 / 10.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// chain per minute defined such that: yard per second = ch/min × (22.0)/(60.0).
   /// </summary>
   public static readonly Velocity ChainPerMinute = new (
                                                         "chain per minute"
                                                       , "ch/min"
                                                       , YardPerSecond
                                                       , 22.0 / 60.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// fathom per week defined such that: foot per day = ftm/wk × (6.0)/(7.0).
   /// </summary>
   public static readonly Velocity FathomPerWeek = new (
                                                        "fathom per week"
                                                      , "ftm/wk"
                                                      , FootPerDay
                                                      , 6.0 / 7.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// hand per tick defined such that: inch per nanosecond = hh/tick × (4.0)/(100.0).
   /// </summary>
   public static readonly Velocity HandPerTick = new (
                                                      "hand per tick"
                                                    , "hh/tick"
                                                    , InchPerNanosecond
                                                    , 4.0 / 100.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// twip per week defined such that: foot per day = twip/wk × (1.0/17280.0)/(7.0).
   /// </summary>
   public static readonly Velocity TwipPerWeek = new (
                                                      "twip per week"
                                                    , "twip/wk"
                                                    , FootPerDay
                                                    , 1.0 / 17280.0 / 7.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// barleycorn per hour defined such that: foot per minute = barleycorn/hr × (1.0/36.0)/(60.0).
   /// </summary>
   public static readonly Velocity BarleycornPerHour = new (
                                                            "barleycorn per hour"
                                                          , "barleycorn/hr"
                                                          , FootPerMinute
                                                          , 1.0 / 36.0 / 60.0
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// foot per millennium defined such that: inch per century = ft/kyr × (12)/(10.0).
   /// </summary>
   public static readonly Velocity FootPerMillennium = new (
                                                            "foot per millennium"
                                                          , "ft/kyr"
                                                          , InchPerCentury
                                                          , 12 / 10.0
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// furlong per minute defined such that: chain per second = fur/min × (10.0)/(60.0).
   /// </summary>
   public static readonly Velocity FurlongPerMinute = new (
                                                           "furlong per minute"
                                                         , "fur/min"
                                                         , ChainPerSecond
                                                         , 10.0 / 60.0
                                                         , system: "Imperial"
                                                          );

   /// <summary>
   /// hand per million years defined such that: inch per millennium = hh/Myr × (4.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HandPerMillionYears = new (
                                                              "hand per million years"
                                                            , "hh/Myr"
                                                            , InchPerMillennium
                                                            , 4.0 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// thou per million years defined such that: foot per millennium = th/Myr × (1.0/12000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ThouPerMillionYears = new (
                                                              "thou per million years"
                                                            , "th/Myr"
                                                            , FootPerMillennium
                                                            , 1.0 / 12000.0 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// thou per day defined such that: foot per hour = th/dy × (1.0/12000.0)/(24.0).
   /// </summary>
   public static readonly Velocity ThouPerDay = new (
                                                     "thou per day"
                                                   , "th/dy"
                                                   , FootPerHour
                                                   , 1.0 / 12000.0 / 24.0
                                                   , system: "Imperial"
                                                    );

   /// <summary>
   /// foot per million years defined such that: inch per millennium = ft/Myr × (12)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerMillionYears = new (
                                                              "foot per million years"
                                                            , "ft/Myr"
                                                            , InchPerMillennium
                                                            , 12 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// mile per minute defined such that: furlong per second = mi/min × (8.0)/(60.0).
   /// </summary>
   public static readonly Velocity MilePerMinute = new (
                                                        "mile per minute"
                                                      , "mi/min"
                                                      , FurlongPerSecond
                                                      , 8.0 / 60.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// yard per tick defined such that: foot per nanosecond = yd/tick × (3.0)/(100.0).
   /// </summary>
   public static readonly Velocity YardPerTick = new (
                                                      "yard per tick"
                                                    , "yd/tick"
                                                    , FootPerNanosecond
                                                    , 3.0 / 100.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// barleycorn per century defined such that: foot per decade = barleycorn/century × (1.0/36.0)/(10.0).
   /// </summary>
   public static readonly Velocity BarleycornPerCentury = new (
                                                               "barleycorn per century"
                                                             , "barleycorn/century"
                                                             , FootPerDecade
                                                             , 1.0 / 36.0 / 10.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// hand per quintillion years defined such that: inch per quadrillion years = hh/Eyr × (4.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HandPerQuintillionYears = new (
                                                                  "hand per quintillion years"
                                                                , "hh/Eyr"
                                                                , InchPerQuadrillionYears
                                                                , 4.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// twip per year defined such that: foot per day = twip/yr × (1.0/17280.0)/(365.2525).
   /// </summary>
   public static readonly Velocity TwipPerYear = new (
                                                      "twip per year"
                                                    , "twip/yr"
                                                    , FootPerDay
                                                    , 1.0 / 17280.0 / 365.2525
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// hand per hour defined such that: inch per minute = hh/hr × (4.0)/(60.0).
   /// </summary>
   public static readonly Velocity HandPerHour = new (
                                                      "hand per hour"
                                                    , "hh/hr"
                                                    , InchPerMinute
                                                    , 4.0 / 60.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// foot per billion years defined such that: inch per million years = ft/Gyr × (12)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerBillionYears = new (
                                                              "foot per billion years"
                                                            , "ft/Gyr"
                                                            , InchPerMillionYears
                                                            , 12 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// league per minute defined such that: mile per second = lea/min × (3.0)/(60.0).
   /// </summary>
   public static readonly Velocity LeaguePerMinute = new (
                                                          "league per minute"
                                                        , "lea/min"
                                                        , MilePerSecond
                                                        , 3.0 / 60.0
                                                        , system: "Imperial"
                                                         );

   /// <summary>
   /// fathom per trillion years defined such that: foot per billion years = ftm/Tyr × (6.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerTrillionYears = new (
                                                                 "fathom per trillion years"
                                                               , "ftm/Tyr"
                                                               , FootPerBillionYears
                                                               , 6.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// yard per trillion years defined such that: foot per billion years = yd/Tyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerTrillionYears = new (
                                                               "yard per trillion years"
                                                             , "yd/Tyr"
                                                             , FootPerBillionYears
                                                             , 3.0 / 1000.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per decade defined such that: foot per year = ftm/decade × (6.0)/(10.0).
   /// </summary>
   public static readonly Velocity FathomPerDecade = new (
                                                          "fathom per decade"
                                                        , "ftm/decade"
                                                        , FootPerYear
                                                        , 6.0 / 10.0
                                                        , system: "Imperial"
                                                         );

   /// <summary>
   /// chain per tick defined such that: yard per nanosecond = ch/tick × (22.0)/(100.0).
   /// </summary>
   public static readonly Velocity ChainPerTick = new (
                                                       "chain per tick"
                                                     , "ch/tick"
                                                     , YardPerNanosecond
                                                     , 22.0 / 100.0
                                                     , system: "Imperial"
                                                      );

   /// <summary>
   /// foot per trillion years defined such that: inch per billion years = ft/Tyr × (12)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerTrillionYears = new (
                                                               "foot per trillion years"
                                                             , "ft/Tyr"
                                                             , InchPerBillionYears
                                                             , 12 / 1000.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per minute defined such that: foot per second = ftm/min × (6.0)/(60.0).
   /// </summary>
   public static readonly Velocity FathomPerMinute = new (
                                                          "fathom per minute"
                                                        , "ftm/min"
                                                        , FootPerSecond
                                                        , 6.0 / 60.0
                                                        , system: "Imperial"
                                                         );

   /// <summary>
   /// yard per millennium defined such that: foot per century = yd/kyr × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity YardPerMillennium = new (
                                                            "yard per millennium"
                                                          , "yd/kyr"
                                                          , FootPerCentury
                                                          , 3.0 / 10.0
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// barleycorn per quadrillion years defined such that: foot per trillion years = barleycorn/Pyr × (1.0/36.0)/(1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerQuadrillionYears = new (
                                                                        "barleycorn per quadrillion years"
                                                                      , "barleycorn/Pyr"
                                                                      , FootPerTrillionYears
                                                                      , 1.0 / 36.0 / 1000.0
                                                                      , system: "Imperial"
                                                                       );

   /// <summary>
   /// hand per nonillion years defined such that: inch per octillion years = hh/Qyr × (4.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HandPerNonillionYears = new (
                                                                "hand per nonillion years"
                                                              , "hh/Qyr"
                                                              , InchPerOctillionYears
                                                              , 4.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// hand per decade defined such that: inch per year = hh/decade × (4.0)/(10.0).
   /// </summary>
   public static readonly Velocity HandPerDecade = new (
                                                        "hand per decade"
                                                      , "hh/decade"
                                                      , InchPerYear
                                                      , 4.0 / 10.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// yard per year defined such that: foot per day = yd/yr × (3.0)/(365.2525).
   /// </summary>
   public static readonly Velocity YardPerYear = new (
                                                      "yard per year"
                                                    , "yd/yr"
                                                    , FootPerDay
                                                    , 3.0 / 365.2525
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// thou per billion years defined such that: foot per million years = th/Gyr × (1.0/12000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ThouPerBillionYears = new (
                                                              "thou per billion years"
                                                            , "th/Gyr"
                                                            , FootPerMillionYears
                                                            , 1.0 / 12000.0 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// thou per week defined such that: foot per day = th/wk × (1.0/12000.0)/(7.0).
   /// </summary>
   public static readonly Velocity ThouPerWeek = new (
                                                      "thou per week"
                                                    , "th/wk"
                                                    , FootPerDay
                                                    , 1.0 / 12000.0 / 7.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// barleycorn per day defined such that: foot per hour = barleycorn/dy × (1.0/36.0)/(24.0).
   /// </summary>
   public static readonly Velocity BarleycornPerDay = new (
                                                           "barleycorn per day"
                                                         , "barleycorn/dy"
                                                         , FootPerHour
                                                         , 1.0 / 36.0 / 24.0
                                                         , system: "Imperial"
                                                          );

   /// <summary>
   /// twip per decade defined such that: foot per year = twip/decade × (1.0/17280.0)/(10.0).
   /// </summary>
   public static readonly Velocity TwipPerDecade = new (
                                                        "twip per decade"
                                                      , "twip/decade"
                                                      , FootPerYear
                                                      , 1.0 / 17280.0 / 10.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// yard per hour defined such that: foot per minute = yd/hr × (3.0)/(60.0).
   /// </summary>
   public static readonly Velocity YardPerHour = new (
                                                      "yard per hour"
                                                    , "yd/hr"
                                                    , FootPerMinute
                                                    , 3.0 / 60.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// foot per quadrillion years defined such that: inch per trillion years = ft/Pyr × (12)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerQuadrillionYears = new (
                                                                  "foot per quadrillion years"
                                                                , "ft/Pyr"
                                                                , InchPerTrillionYears
                                                                , 12 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// cable per minute defined such that: fathom per second = cable/min × (100.0)/(60.0).
   /// </summary>
   public static readonly Velocity CablePerMinute = new (
                                                         "cable per minute"
                                                       , "cable/min"
                                                       , FathomPerSecond
                                                       , 100.0 / 60.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// furlong per tick defined such that: chain per nanosecond = fur/tick × (10.0)/(100.0).
   /// </summary>
   public static readonly Velocity FurlongPerTick = new (
                                                         "furlong per tick"
                                                       , "fur/tick"
                                                       , ChainPerNanosecond
                                                       , 10.0 / 100.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// foot per quintillion years defined such that: inch per quadrillion years = ft/Eyr × (12)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerQuintillionYears = new (
                                                                  "foot per quintillion years"
                                                                , "ft/Eyr"
                                                                , InchPerQuadrillionYears
                                                                , 12 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// nautical mile per minute defined such that: cable per second = nmi/min × (10.0)/(60.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMinute = new (
                                                                "nautical mile per minute"
                                                              , "nmi/min"
                                                              , CablePerSecond
                                                              , 10.0 / 60.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// hand per billion years defined such that: inch per million years = hh/Gyr × (4.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HandPerBillionYears = new (
                                                              "hand per billion years"
                                                            , "hh/Gyr"
                                                            , InchPerMillionYears
                                                            , 4.0 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// barleycorn per millennium defined such that: foot per century = barleycorn/kyr × (1.0/36.0)/(10.0).
   /// </summary>
   public static readonly Velocity BarleycornPerMillennium = new (
                                                                  "barleycorn per millennium"
                                                                , "barleycorn/kyr"
                                                                , FootPerCentury
                                                                , 1.0 / 36.0 / 10.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// fathom per quintillion years defined such that: foot per quadrillion years = ftm/Eyr × (6.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerQuintillionYears = new (
                                                                    "fathom per quintillion years"
                                                                  , "ftm/Eyr"
                                                                  , FootPerQuadrillionYears
                                                                  , 6.0 / 1000.0
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// mile per tick defined such that: furlong per nanosecond = mi/tick × (8.0)/(100.0).
   /// </summary>
   public static readonly Velocity MilePerTick = new (
                                                      "mile per tick"
                                                    , "mi/tick"
                                                    , FurlongPerNanosecond
                                                    , 8.0 / 100.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// twip per century defined such that: foot per decade = twip/century × (1.0/17280.0)/(10.0).
   /// </summary>
   public static readonly Velocity TwipPerCentury = new (
                                                         "twip per century"
                                                       , "twip/century"
                                                       , FootPerDecade
                                                       , 1.0 / 17280.0 / 10.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// chain per hour defined such that: yard per minute = ch/hr × (22.0)/(60.0).
   /// </summary>
   public static readonly Velocity ChainPerHour = new (
                                                       "chain per hour"
                                                     , "ch/hr"
                                                     , YardPerMinute
                                                     , 22.0 / 60.0
                                                     , system: "Imperial"
                                                      );

   /// <summary>
   /// foot per sextillion years defined such that: inch per quintillion years = ft/Zyr × (12)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerSextillionYears = new (
                                                                 "foot per sextillion years"
                                                               , "ft/Zyr"
                                                               , InchPerQuintillionYears
                                                               , 12 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// fathom per millennium defined such that: foot per century = ftm/kyr × (6.0)/(10.0).
   /// </summary>
   public static readonly Velocity FathomPerMillennium = new (
                                                              "fathom per millennium"
                                                            , "ftm/kyr"
                                                            , FootPerCentury
                                                            , 6.0 / 10.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// thou per trillion years defined such that: foot per billion years = th/Tyr × (1.0/12000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ThouPerTrillionYears = new (
                                                               "thou per trillion years"
                                                             , "th/Tyr"
                                                             , FootPerBillionYears
                                                             , 1.0 / 12000.0 / 1000.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per day defined such that: foot per hour = ftm/dy × (6.0)/(24.0).
   /// </summary>
   public static readonly Velocity FathomPerDay = new (
                                                       "fathom per day"
                                                     , "ftm/dy"
                                                     , FootPerHour
                                                     , 6.0 / 24.0
                                                     , system: "Imperial"
                                                      );

   /// <summary>
   /// hand per sextillion years defined such that: inch per quintillion years = hh/Zyr × (4.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HandPerSextillionYears = new (
                                                                 "hand per sextillion years"
                                                               , "hh/Zyr"
                                                               , InchPerQuintillionYears
                                                               , 4.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// cable per quadrillion years defined such that: fathom per trillion years = cable/Pyr × (100.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerQuadrillionYears = new (
                                                                   "cable per quadrillion years"
                                                                 , "cable/Pyr"
                                                                 , FathomPerTrillionYears
                                                                 , 100.0 / 1000.0
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// thou per year defined such that: foot per day = th/yr × (1.0/12000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity ThouPerYear = new (
                                                      "thou per year"
                                                    , "th/yr"
                                                    , FootPerDay
                                                    , 1.0 / 12000.0 / 365.2525
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// hand per day defined such that: inch per hour = hh/dy × (4.0)/(24.0).
   /// </summary>
   public static readonly Velocity HandPerDay = new (
                                                     "hand per day"
                                                   , "hh/dy"
                                                   , InchPerHour
                                                   , 4.0 / 24.0
                                                   , system: "Imperial"
                                                    );

   /// <summary>
   /// foot per septillion years defined such that: inch per sextillion years = ft/Yyr × (12)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerSeptillionYears = new (
                                                                 "foot per septillion years"
                                                               , "ft/Yyr"
                                                               , InchPerSextillionYears
                                                               , 12 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// barleycorn per quintillion years defined such that: foot per quadrillion years = barleycorn/Eyr × (1.0/36.0)/(1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerQuintillionYears = new (
                                                                        "barleycorn per quintillion years"
                                                                      , "barleycorn/Eyr"
                                                                      , FootPerQuadrillionYears
                                                                      , 1.0 / 36.0 / 1000.0
                                                                      , system: "Imperial"
                                                                       );

   /// <summary>
   /// league per tick defined such that: mile per nanosecond = lea/tick × (3.0)/(100.0).
   /// </summary>
   public static readonly Velocity LeaguePerTick = new (
                                                        "league per tick"
                                                      , "lea/tick"
                                                      , MilePerNanosecond
                                                      , 3.0 / 100.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// cable per million years defined such that: fathom per millennium = cable/Myr × (100.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerMillionYears = new (
                                                               "cable per million years"
                                                             , "cable/Myr"
                                                             , FathomPerMillennium
                                                             , 100.0 / 1000.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// barleycorn per week defined such that: foot per day = barleycorn/wk × (1.0/36.0)/(7.0).
   /// </summary>
   public static readonly Velocity BarleycornPerWeek = new (
                                                            "barleycorn per week"
                                                          , "barleycorn/wk"
                                                          , FootPerDay
                                                          , 1.0 / 36.0 / 7.0
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// twip per millennium defined such that: foot per century = twip/kyr × (1.0/17280.0)/(10.0).
   /// </summary>
   public static readonly Velocity TwipPerMillennium = new (
                                                            "twip per millennium"
                                                          , "twip/kyr"
                                                          , FootPerCentury
                                                          , 1.0 / 17280.0 / 10.0
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// furlong per hour defined such that: chain per minute = fur/hr × (10.0)/(60.0).
   /// </summary>
   public static readonly Velocity FurlongPerHour = new (
                                                         "furlong per hour"
                                                       , "fur/hr"
                                                       , ChainPerMinute
                                                       , 10.0 / 60.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// foot per octillion years defined such that: inch per septillion years = ft/Ryr × (12)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerOctillionYears = new (
                                                                "foot per octillion years"
                                                              , "ft/Ryr"
                                                              , InchPerSeptillionYears
                                                              , 12 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// yard per septillion years defined such that: foot per sextillion years = yd/Yyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerSeptillionYears = new (
                                                                 "yard per septillion years"
                                                               , "yd/Yyr"
                                                               , FootPerSextillionYears
                                                               , 3.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// hand per decillion years defined such that: inch per nonillion years = hh/decillion yr × (4.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HandPerDecillionYears = new (
                                                                "hand per decillion years"
                                                              , "hh/decillion yr"
                                                              , InchPerNonillionYears
                                                              , 4.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// hand per century defined such that: inch per decade = hh/century × (4.0)/(10.0).
   /// </summary>
   public static readonly Velocity HandPerCentury = new (
                                                         "hand per century"
                                                       , "hh/century"
                                                       , InchPerDecade
                                                       , 4.0 / 10.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// yard per quadrillion years defined such that: foot per trillion years = yd/Pyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerQuadrillionYears = new (
                                                                  "yard per quadrillion years"
                                                                , "yd/Pyr"
                                                                , FootPerTrillionYears
                                                                , 3.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// foot per nonillion years defined such that: inch per octillion years = ft/Qyr × (12)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerNonillionYears = new (
                                                                "foot per nonillion years"
                                                              , "ft/Qyr"
                                                              , InchPerOctillionYears
                                                              , 12 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// fathom per tick defined such that: foot per nanosecond = ftm/tick × (6.0)/(100.0).
   /// </summary>
   public static readonly Velocity FathomPerTick = new (
                                                        "fathom per tick"
                                                      , "ftm/tick"
                                                      , FootPerNanosecond
                                                      , 6.0 / 100.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// yard per million years defined such that: foot per millennium = yd/Myr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerMillionYears = new (
                                                              "yard per million years"
                                                            , "yd/Myr"
                                                            , FootPerMillennium
                                                            , 3.0 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// thou per decillion years defined such that: foot per nonillion years = th/decillion yr × (1.0/12000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ThouPerDecillionYears = new (
                                                                "thou per decillion years"
                                                              , "th/decillion yr"
                                                              , FootPerNonillionYears
                                                              , 1.0 / 12000.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// chain per quintillion years defined such that: yard per quadrillion years = ch/Eyr × (22.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerQuintillionYears = new (
                                                                   "chain per quintillion years"
                                                                 , "ch/Eyr"
                                                                 , YardPerQuadrillionYears
                                                                 , 22.0 / 1000.0
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// fathom per septillion years defined such that: foot per sextillion years = ftm/Yyr × (6.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerSeptillionYears = new (
                                                                   "fathom per septillion years"
                                                                 , "ftm/Yyr"
                                                                 , FootPerSextillionYears
                                                                 , 6.0 / 1000.0
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// yard per decade defined such that: foot per year = yd/decade × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity YardPerDecade = new (
                                                        "yard per decade"
                                                      , "yd/decade"
                                                      , FootPerYear
                                                      , 3.0 / 10.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// barleycorn per million years defined such that: foot per millennium = barleycorn/Myr × (1.0/36.0)/(1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerMillionYears = new (
                                                                    "barleycorn per million years"
                                                                  , "barleycorn/Myr"
                                                                  , FootPerMillennium
                                                                  , 1.0 / 36.0 / 1000.0
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// thou per quadrillion years defined such that: foot per trillion years = th/Pyr × (1.0/12000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ThouPerQuadrillionYears = new (
                                                                  "thou per quadrillion years"
                                                                , "th/Pyr"
                                                                , FootPerTrillionYears
                                                                , 1.0 / 12000.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// cable per day defined such that: fathom per hour = cable/dy × (100.0)/(24.0).
   /// </summary>
   public static readonly Velocity CablePerDay = new (
                                                      "cable per day"
                                                    , "cable/dy"
                                                    , FathomPerHour
                                                    , 100.0 / 24.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// twip per decillion years defined such that: foot per nonillion years = twip/decillion yr × (1.0/17280.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerDecillionYears = new (
                                                                "twip per decillion years"
                                                              , "twip/decillion yr"
                                                              , FootPerNonillionYears
                                                              , 1.0 / 17280.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// fathom per billion years defined such that: foot per million years = ftm/Gyr × (6.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerBillionYears = new (
                                                                "fathom per billion years"
                                                              , "ftm/Gyr"
                                                              , FootPerMillionYears
                                                              , 6.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// thou per decade defined such that: foot per year = th/decade × (1.0/12000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ThouPerDecade = new (
                                                        "thou per decade"
                                                      , "th/decade"
                                                      , FootPerYear
                                                      , 1.0 / 12000.0 / 10.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// yard per day defined such that: foot per hour = yd/dy × (3.0)/(24.0).
   /// </summary>
   public static readonly Velocity YardPerDay = new (
                                                     "yard per day"
                                                   , "yd/dy"
                                                   , FootPerHour
                                                   , 3.0 / 24.0
                                                   , system: "Imperial"
                                                    );

   /// <summary>
   /// twip per million years defined such that: foot per millennium = twip/Myr × (1.0/17280.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerMillionYears = new (
                                                              "twip per million years"
                                                            , "twip/Myr"
                                                            , FootPerMillennium
                                                            , 1.0 / 17280.0 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// mile per hour defined such that: furlong per minute = mi/hr × (8.0)/(60.0).
   /// </summary>
   public static readonly Velocity MilePerHour = new (
                                                      "mile per hour"
                                                    , "mi/hr"
                                                    , FurlongPerMinute
                                                    , 8.0 / 60.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// foot per decillion years defined such that: inch per nonillion years = ft/decillion yr × (12)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerDecillionYears = new (
                                                                "foot per decillion years"
                                                              , "ft/decillion yr"
                                                              , InchPerNonillionYears
                                                              , 12 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// hand per trillion years defined such that: inch per billion years = hh/Tyr × (4.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HandPerTrillionYears = new (
                                                               "hand per trillion years"
                                                             , "hh/Tyr"
                                                             , InchPerBillionYears
                                                             , 4.0 / 1000.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// fathom per year defined such that: foot per day = ftm/yr × (6.0)/(365.2525).
   /// </summary>
   public static readonly Velocity FathomPerYear = new (
                                                        "fathom per year"
                                                      , "ftm/yr"
                                                      , FootPerDay
                                                      , 6.0 / 365.2525
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// barleycorn per sextillion years defined such that: foot per quintillion years = barleycorn/Zyr × (1.0/36.0)/(1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerSextillionYears = new (
                                                                       "barleycorn per sextillion years"
                                                                     , "barleycorn/Zyr"
                                                                     , FootPerQuintillionYears
                                                                     , 1.0 / 36.0 / 1000.0
                                                                     , system: "Imperial"
                                                                      );

   /// <summary>
   /// nautical mile per billion years defined such that: cable per million years = nmi/Gyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerBillionYears = new (
                                                                      "nautical mile per billion years"
                                                                    , "nmi/Gyr"
                                                                    , CablePerMillionYears
                                                                    , 10.0 / 1000.0
                                                                    , system: "Imperial"
                                                                     );

   /// <summary>
   /// furlong per sextillion years defined such that: chain per quintillion years = fur/Zyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerSextillionYears = new (
                                                                    "furlong per sextillion years"
                                                                  , "fur/Zyr"
                                                                  , ChainPerQuintillionYears
                                                                  , 10.0 / 1000.0
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// chain per octillion years defined such that: yard per septillion years = ch/Ryr × (22.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerOctillionYears = new (
                                                                 "chain per octillion years"
                                                               , "ch/Ryr"
                                                               , YardPerSeptillionYears
                                                               , 22.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// barleycorn per year defined such that: foot per day = barleycorn/yr × (1.0/36.0)/(365.2525).
   /// </summary>
   public static readonly Velocity BarleycornPerYear = new (
                                                            "barleycorn per year"
                                                          , "barleycorn/yr"
                                                          , FootPerDay
                                                          , 1.0 / 36.0 / 365.2525
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// twip per billion years defined such that: foot per million years = twip/Gyr × (1.0/17280.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerBillionYears = new (
                                                              "twip per billion years"
                                                            , "twip/Gyr"
                                                            , FootPerMillionYears
                                                            , 1.0 / 17280.0 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// league per hour defined such that: mile per minute = lea/hr × (3.0)/(60.0).
   /// </summary>
   public static readonly Velocity LeaguePerHour = new (
                                                        "league per hour"
                                                      , "lea/hr"
                                                      , MilePerMinute
                                                      , 3.0 / 60.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// cable per sextillion years defined such that: fathom per quintillion years = cable/Zyr × (100.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerSextillionYears = new (
                                                                  "cable per sextillion years"
                                                                , "cable/Zyr"
                                                                , FathomPerQuintillionYears
                                                                , 100.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// thou per quintillion years defined such that: foot per quadrillion years = th/Eyr × (1.0/12000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ThouPerQuintillionYears = new (
                                                                  "thou per quintillion years"
                                                                , "th/Eyr"
                                                                , FootPerQuadrillionYears
                                                                , 1.0 / 12000.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// fathom per nonillion years defined such that: foot per octillion years = ftm/Qyr × (6.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerNonillionYears = new (
                                                                  "fathom per nonillion years"
                                                                , "ftm/Qyr"
                                                                , FootPerOctillionYears
                                                                , 6.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// thou per century defined such that: foot per decade = th/century × (1.0/12000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ThouPerCentury = new (
                                                         "thou per century"
                                                       , "th/century"
                                                       , FootPerDecade
                                                       , 1.0 / 12000.0 / 10.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// chain per day defined such that: yard per hour = ch/dy × (22.0)/(24.0).
   /// </summary>
   public static readonly Velocity ChainPerDay = new (
                                                      "chain per day"
                                                    , "ch/dy"
                                                    , YardPerHour
                                                    , 22.0 / 24.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// fathom per quadrillion years defined such that: foot per trillion years = ftm/Pyr × (6.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerQuadrillionYears = new (
                                                                    "fathom per quadrillion years"
                                                                  , "ftm/Pyr"
                                                                  , FootPerTrillionYears
                                                                  , 6.0 / 1000.0
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// cable per trillion years defined such that: fathom per billion years = cable/Tyr × (100.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerTrillionYears = new (
                                                                "cable per trillion years"
                                                              , "cable/Tyr"
                                                              , FathomPerBillionYears
                                                              , 100.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// nautical mile per quintillion years defined such that: cable per quadrillion years = nmi/Eyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuintillionYears = new (
                                                                          "nautical mile per quintillion years"
                                                                        , "nmi/Eyr"
                                                                        , CablePerQuadrillionYears
                                                                        , 10.0 / 1000.0
                                                                        , system: "Imperial"
                                                                         );

   /// <summary>
   /// furlong per year defined such that: chain per day = fur/yr × (10.0)/(365.2525).
   /// </summary>
   public static readonly Velocity FurlongPerYear = new (
                                                         "furlong per year"
                                                       , "fur/yr"
                                                       , ChainPerDay
                                                       , 10.0 / 365.2525
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// barleycorn per billion years defined such that: foot per million years = barleycorn/Gyr × (1.0/36.0)/(1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerBillionYears = new (
                                                                    "barleycorn per billion years"
                                                                  , "barleycorn/Gyr"
                                                                  , FootPerMillionYears
                                                                  , 1.0 / 36.0 / 1000.0
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// fathom per century defined such that: foot per decade = ftm/century × (6.0)/(10.0).
   /// </summary>
   public static readonly Velocity FathomPerCentury = new (
                                                           "fathom per century"
                                                         , "ftm/century"
                                                         , FootPerDecade
                                                         , 6.0 / 10.0
                                                         , system: "Imperial"
                                                          );

   /// <summary>
   /// twip per trillion years defined such that: foot per billion years = twip/Tyr × (1.0/17280.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerTrillionYears = new (
                                                               "twip per trillion years"
                                                             , "twip/Tyr"
                                                             , FootPerBillionYears
                                                             , 1.0 / 17280.0 / 1000.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// cable per millennium defined such that: fathom per century = cable/kyr × (100.0)/(10.0).
   /// </summary>
   public static readonly Velocity CablePerMillennium = new (
                                                             "cable per millennium"
                                                           , "cable/kyr"
                                                           , FathomPerCentury
                                                           , 100.0 / 10.0
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// yard per octillion years defined such that: foot per septillion years = yd/Ryr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerOctillionYears = new (
                                                                "yard per octillion years"
                                                              , "yd/Ryr"
                                                              , FootPerSeptillionYears
                                                              , 3.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// yard per quintillion years defined such that: foot per quadrillion years = yd/Eyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerQuintillionYears = new (
                                                                  "yard per quintillion years"
                                                                , "yd/Eyr"
                                                                , FootPerQuadrillionYears
                                                                , 3.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// yard per billion years defined such that: foot per million years = yd/Gyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerBillionYears = new (
                                                              "yard per billion years"
                                                            , "yd/Gyr"
                                                            , FootPerMillionYears
                                                            , 3.0 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// cable per year defined such that: fathom per day = cable/yr × (100.0)/(365.2525).
   /// </summary>
   public static readonly Velocity CablePerYear = new (
                                                       "cable per year"
                                                     , "cable/yr"
                                                     , FathomPerDay
                                                     , 100.0 / 365.2525
                                                     , system: "Imperial"
                                                      );

   /// <summary>
   /// barleycorn per septillion years defined such that: foot per sextillion years = barleycorn/Yyr × (1.0/36.0)/(1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerSeptillionYears = new (
                                                                       "barleycorn per septillion years"
                                                                     , "barleycorn/Yyr"
                                                                     , FootPerSextillionYears
                                                                     , 1.0 / 36.0 / 1000.0
                                                                     , system: "Imperial"
                                                                      );

   /// <summary>
   /// yard per century defined such that: foot per decade = yd/century × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity YardPerCentury = new (
                                                         "yard per century"
                                                       , "yd/century"
                                                       , FootPerDecade
                                                       , 3.0 / 10.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// chain per decade defined such that: yard per year = ch/decade × (22.0)/(10.0).
   /// </summary>
   public static readonly Velocity ChainPerDecade = new (
                                                         "chain per decade"
                                                       , "ch/decade"
                                                       , YardPerYear
                                                       , 22.0 / 10.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// thou per sextillion years defined such that: foot per quintillion years = th/Zyr × (1.0/12000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ThouPerSextillionYears = new (
                                                                 "thou per sextillion years"
                                                               , "th/Zyr"
                                                               , FootPerQuintillionYears
                                                               , 1.0 / 12000.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// thou per millennium defined such that: foot per century = th/kyr × (1.0/12000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ThouPerMillennium = new (
                                                            "thou per millennium"
                                                          , "th/kyr"
                                                          , FootPerCentury
                                                          , 1.0 / 12000.0 / 10.0
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// furlong per day defined such that: chain per hour = fur/dy × (10.0)/(24.0).
   /// </summary>
   public static readonly Velocity FurlongPerDay = new (
                                                        "furlong per day"
                                                      , "fur/dy"
                                                      , ChainPerHour
                                                      , 10.0 / 24.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// twip per quadrillion years defined such that: foot per trillion years = twip/Pyr × (1.0/17280.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerQuadrillionYears = new (
                                                                  "twip per quadrillion years"
                                                                , "twip/Pyr"
                                                                , FootPerTrillionYears
                                                                , 1.0 / 17280.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// cable per hour defined such that: fathom per minute = cable/hr × (100.0)/(60.0).
   /// </summary>
   public static readonly Velocity CablePerHour = new (
                                                       "cable per hour"
                                                     , "cable/hr"
                                                     , FathomPerMinute
                                                     , 100.0 / 60.0
                                                     , system: "Imperial"
                                                      );

   /// <summary>
   /// chain per sextillion years defined such that: yard per quintillion years = ch/Zyr × (22.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerSextillionYears = new (
                                                                  "chain per sextillion years"
                                                                , "ch/Zyr"
                                                                , YardPerQuintillionYears
                                                                , 22.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// mile per septillion years defined such that: furlong per sextillion years = mi/Yyr × (8.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerSeptillionYears = new (
                                                                 "mile per septillion years"
                                                               , "mi/Yyr"
                                                               , FurlongPerSextillionYears
                                                               , 8.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// nautical mile per million years defined such that: cable per millennium = nmi/Myr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillionYears = new (
                                                                      "nautical mile per million years"
                                                                    , "nmi/Myr"
                                                                    , CablePerMillennium
                                                                    , 10.0 / 1000.0
                                                                    , system: "Imperial"
                                                                     );

   /// <summary>
   /// fathom per sextillion years defined such that: foot per quintillion years = ftm/Zyr × (6.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerSextillionYears = new (
                                                                   "fathom per sextillion years"
                                                                 , "ftm/Zyr"
                                                                 , FootPerQuintillionYears
                                                                 , 6.0 / 1000.0
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// fathom per million years defined such that: foot per millennium = ftm/Myr × (6.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerMillionYears = new (
                                                                "fathom per million years"
                                                              , "ftm/Myr"
                                                              , FootPerMillennium
                                                              , 6.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// furlong per nonillion years defined such that: chain per octillion years = fur/Qyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerNonillionYears = new (
                                                                   "furlong per nonillion years"
                                                                 , "fur/Qyr"
                                                                 , ChainPerOctillionYears
                                                                 , 10.0 / 1000.0
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// barleycorn per trillion years defined such that: foot per billion years = barleycorn/Tyr × (1.0/36.0)/(1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerTrillionYears = new (
                                                                     "barleycorn per trillion years"
                                                                   , "barleycorn/Tyr"
                                                                   , FootPerBillionYears
                                                                   , 1.0 / 36.0 / 1000.0
                                                                   , system: "Imperial"
                                                                    );

   /// <summary>
   /// cable per octillion years defined such that: fathom per septillion years = cable/Ryr × (100.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerOctillionYears = new (
                                                                 "cable per octillion years"
                                                               , "cable/Ryr"
                                                               , FathomPerSeptillionYears
                                                               , 100.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// twip per quintillion years defined such that: foot per quadrillion years = twip/Eyr × (1.0/17280.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerQuintillionYears = new (
                                                                  "twip per quintillion years"
                                                                , "twip/Eyr"
                                                                , FootPerQuadrillionYears
                                                                , 1.0 / 17280.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// nautical mile per hour defined such that: cable per minute = nmi/hr × (10.0)/(60.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerHour = new (
                                                              "nautical mile per hour"
                                                            , "nmi/hr"
                                                            , CablePerMinute
                                                            , 10.0 / 60.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// chain per million years defined such that: yard per millennium = ch/Myr × (22.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerMillionYears = new (
                                                               "chain per million years"
                                                             , "ch/Myr"
                                                             , YardPerMillennium
                                                             , 22.0 / 1000.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// mile per year defined such that: furlong per day = mi/yr × (8.0)/(365.2525).
   /// </summary>
   public static readonly Velocity MilePerYear = new (
                                                      "mile per year"
                                                    , "mi/yr"
                                                    , FurlongPerDay
                                                    , 8.0 / 365.2525
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// thou per septillion years defined such that: foot per sextillion years = th/Yyr × (1.0/12000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ThouPerSeptillionYears = new (
                                                                 "thou per septillion years"
                                                               , "th/Yyr"
                                                               , FootPerSextillionYears
                                                               , 1.0 / 12000.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// chain per nonillion years defined such that: yard per octillion years = ch/Qyr × (22.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerNonillionYears = new (
                                                                 "chain per nonillion years"
                                                               , "ch/Qyr"
                                                               , YardPerOctillionYears
                                                               , 22.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// cable per quintillion years defined such that: fathom per quadrillion years = cable/Eyr × (100.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerQuintillionYears = new (
                                                                   "cable per quintillion years"
                                                                 , "cable/Eyr"
                                                                 , FathomPerQuadrillionYears
                                                                 , 100.0 / 1000.0
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// nautical mile per quadrillion years defined such that: cable per trillion years = nmi/Pyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuadrillionYears = new (
                                                                          "nautical mile per quadrillion years"
                                                                        , "nmi/Pyr"
                                                                        , CablePerTrillionYears
                                                                        , 10.0 / 1000.0
                                                                        , system: "Imperial"
                                                                         );

   /// <summary>
   /// mile per day defined such that: furlong per hour = mi/dy × (8.0)/(24.0).
   /// </summary>
   public static readonly Velocity MilePerDay = new (
                                                     "mile per day"
                                                   , "mi/dy"
                                                   , FurlongPerHour
                                                   , 8.0 / 24.0
                                                   , system: "Imperial"
                                                    );

   /// <summary>
   /// barleycorn per octillion years defined such that: foot per septillion years = barleycorn/Ryr × (1.0/36.0)/(1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerOctillionYears = new (
                                                                      "barleycorn per octillion years"
                                                                    , "barleycorn/Ryr"
                                                                    , FootPerSeptillionYears
                                                                    , 1.0 / 36.0 / 1000.0
                                                                    , system: "Imperial"
                                                                     );

   /// <summary>
   /// cable per billion years defined such that: fathom per million years = cable/Gyr × (100.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerBillionYears = new (
                                                               "cable per billion years"
                                                             , "cable/Gyr"
                                                             , FathomPerMillionYears
                                                             , 100.0 / 1000.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// furlong per septillion years defined such that: chain per sextillion years = fur/Yyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerSeptillionYears = new (
                                                                    "furlong per septillion years"
                                                                  , "fur/Yyr"
                                                                  , ChainPerSextillionYears
                                                                  , 10.0 / 1000.0
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// chain per week defined such that: yard per day = ch/wk × (22.0)/(7.0).
   /// </summary>
   public static readonly Velocity ChainPerWeek = new (
                                                       "chain per week"
                                                     , "ch/wk"
                                                     , YardPerDay
                                                     , 22.0 / 7.0
                                                     , system: "Imperial"
                                                      );

   /// <summary>
   /// twip per sextillion years defined such that: foot per quintillion years = twip/Zyr × (1.0/17280.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerSextillionYears = new (
                                                                 "twip per sextillion years"
                                                               , "twip/Zyr"
                                                               , FootPerQuintillionYears
                                                               , 1.0 / 17280.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// nautical mile per year defined such that: cable per day = nmi/yr × (10.0)/(365.2525).
   /// </summary>
   public static readonly Velocity NauticalMilePerYear = new (
                                                              "nautical mile per year"
                                                            , "nmi/yr"
                                                            , CablePerDay
                                                            , 10.0 / 365.2525
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// yard per nonillion years defined such that: foot per octillion years = yd/Qyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerNonillionYears = new (
                                                                "yard per nonillion years"
                                                              , "yd/Qyr"
                                                              , FootPerOctillionYears
                                                              , 3.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// fathom per octillion years defined such that: foot per septillion years = ftm/Ryr × (6.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerOctillionYears = new (
                                                                  "fathom per octillion years"
                                                                , "ftm/Ryr"
                                                                , FootPerSeptillionYears
                                                                , 6.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// chain per quadrillion years defined such that: yard per trillion years = ch/Pyr × (22.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerQuadrillionYears = new (
                                                                   "chain per quadrillion years"
                                                                 , "ch/Pyr"
                                                                 , YardPerTrillionYears
                                                                 , 22.0 / 1000.0
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// cable per century defined such that: fathom per decade = cable/century × (100.0)/(10.0).
   /// </summary>
   public static readonly Velocity CablePerCentury = new (
                                                          "cable per century"
                                                        , "cable/century"
                                                        , FathomPerDecade
                                                        , 100.0 / 10.0
                                                        , system: "Imperial"
                                                         );

   /// <summary>
   /// yard per sextillion years defined such that: foot per quintillion years = yd/Zyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerSextillionYears = new (
                                                                 "yard per sextillion years"
                                                               , "yd/Zyr"
                                                               , FootPerQuintillionYears
                                                               , 3.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// nautical mile per septillion years defined such that: cable per sextillion years = nmi/Yyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSeptillionYears = new (
                                                                         "nautical mile per septillion years"
                                                                       , "nmi/Yyr"
                                                                       , CablePerSextillionYears
                                                                       , 10.0 / 1000.0
                                                                       , system: "Imperial"
                                                                        );

   /// <summary>
   /// cable per week defined such that: fathom per day = cable/wk × (100.0)/(7.0).
   /// </summary>
   public static readonly Velocity CablePerWeek = new (
                                                       "cable per week"
                                                     , "cable/wk"
                                                     , FathomPerDay
                                                     , 100.0 / 7.0
                                                     , system: "Imperial"
                                                      );

   /// <summary>
   /// thou per octillion years defined such that: foot per septillion years = th/Ryr × (1.0/12000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ThouPerOctillionYears = new (
                                                                "thou per octillion years"
                                                              , "th/Ryr"
                                                              , FootPerSeptillionYears
                                                              , 1.0 / 12000.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// league per day defined such that: mile per hour = lea/dy × (3.0)/(24.0).
   /// </summary>
   public static readonly Velocity LeaguePerDay = new (
                                                       "league per day"
                                                     , "lea/dy"
                                                     , MilePerHour
                                                     , 3.0 / 24.0
                                                     , system: "Imperial"
                                                      );

   /// <summary>
   /// twip per septillion years defined such that: foot per sextillion years = twip/Yyr × (1.0/17280.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerSeptillionYears = new (
                                                                 "twip per septillion years"
                                                               , "twip/Yyr"
                                                               , FootPerSextillionYears
                                                               , 1.0 / 17280.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// furlong per quintillion years defined such that: chain per quadrillion years = fur/Eyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerQuintillionYears = new (
                                                                     "furlong per quintillion years"
                                                                   , "fur/Eyr"
                                                                   , ChainPerQuadrillionYears
                                                                   , 10.0 / 1000.0
                                                                   , system: "Imperial"
                                                                    );

   /// <summary>
   /// nautical mile per millennium defined such that: cable per century = nmi/kyr × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillennium = new (
                                                                    "nautical mile per millennium"
                                                                  , "nmi/kyr"
                                                                  , CablePerCentury
                                                                  , 10.0 / 10.0
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// chain per century defined such that: yard per decade = ch/century × (22.0)/(10.0).
   /// </summary>
   public static readonly Velocity ChainPerCentury = new (
                                                          "chain per century"
                                                        , "ch/century"
                                                        , YardPerDecade
                                                        , 22.0 / 10.0
                                                        , system: "Imperial"
                                                         );

   /// <summary>
   /// league per octillion years defined such that: mile per septillion years = lea/Ryr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerOctillionYears = new (
                                                                  "league per octillion years"
                                                                , "lea/Ryr"
                                                                , MilePerSeptillionYears
                                                                , 3.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// barleycorn per nonillion years defined such that: foot per octillion years = barleycorn/Qyr × (1.0/36.0)/(1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerNonillionYears = new (
                                                                      "barleycorn per nonillion years"
                                                                    , "barleycorn/Qyr"
                                                                    , FootPerOctillionYears
                                                                    , 1.0 / 36.0 / 1000.0
                                                                    , system: "Imperial"
                                                                     );

   /// <summary>
   /// chain per septillion years defined such that: yard per sextillion years = ch/Yyr × (22.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerSeptillionYears = new (
                                                                  "chain per septillion years"
                                                                , "ch/Yyr"
                                                                , YardPerSextillionYears
                                                                , 22.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// cable per decillion years defined such that: fathom per nonillion years = cable/decillion yr × (100.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerDecillionYears = new (
                                                                 "cable per decillion years"
                                                               , "cable/decillion yr"
                                                               , FathomPerNonillionYears
                                                               , 100.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// league per year defined such that: mile per day = lea/yr × (3.0)/(365.2525).
   /// </summary>
   public static readonly Velocity LeaguePerYear = new (
                                                        "league per year"
                                                      , "lea/yr"
                                                      , MilePerDay
                                                      , 3.0 / 365.2525
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// fathom per decillion years defined such that: foot per nonillion years = ftm/decillion yr × (6.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerDecillionYears = new (
                                                                  "fathom per decillion years"
                                                                , "ftm/decillion yr"
                                                                , FootPerNonillionYears
                                                                , 6.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// furlong per week defined such that: chain per day = fur/wk × (10.0)/(7.0).
   /// </summary>
   public static readonly Velocity FurlongPerWeek = new (
                                                         "furlong per week"
                                                       , "fur/wk"
                                                       , ChainPerDay
                                                       , 10.0 / 7.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// twip per octillion years defined such that: foot per septillion years = twip/Ryr × (1.0/17280.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerOctillionYears = new (
                                                                "twip per octillion years"
                                                              , "twip/Ryr"
                                                              , FootPerSeptillionYears
                                                              , 1.0 / 17280.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// nautical mile per trillion years defined such that: cable per billion years = nmi/Tyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerTrillionYears = new (
                                                                       "nautical mile per trillion years"
                                                                     , "nmi/Tyr"
                                                                     , CablePerBillionYears
                                                                     , 10.0 / 1000.0
                                                                     , system: "Imperial"
                                                                      );

   /// <summary>
   /// cable per septillion years defined such that: fathom per sextillion years = cable/Yyr × (100.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerSeptillionYears = new (
                                                                  "cable per septillion years"
                                                                , "cable/Yyr"
                                                                , FathomPerSextillionYears
                                                                , 100.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// thou per nonillion years defined such that: foot per octillion years = th/Qyr × (1.0/12000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ThouPerNonillionYears = new (
                                                                "thou per nonillion years"
                                                              , "th/Qyr"
                                                              , FootPerOctillionYears
                                                              , 1.0 / 12000.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// mile per decillion years defined such that: furlong per nonillion years = mi/decillion yr × (8.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerDecillionYears = new (
                                                                "mile per decillion years"
                                                              , "mi/decillion yr"
                                                              , FurlongPerNonillionYears
                                                              , 8.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// chain per billion years defined such that: yard per million years = ch/Gyr × (22.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerBillionYears = new (
                                                               "chain per billion years"
                                                             , "ch/Gyr"
                                                             , YardPerMillionYears
                                                             , 22.0 / 1000.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// mile per octillion years defined such that: furlong per septillion years = mi/Ryr × (8.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerOctillionYears = new (
                                                                "mile per octillion years"
                                                              , "mi/Ryr"
                                                              , FurlongPerSeptillionYears
                                                              , 8.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// furlong per decillion years defined such that: chain per nonillion years = fur/decillion yr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerDecillionYears = new (
                                                                   "furlong per decillion years"
                                                                 , "fur/decillion yr"
                                                                 , ChainPerNonillionYears
                                                                 , 10.0 / 1000.0
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// nautical mile per week defined such that: cable per day = nmi/wk × (10.0)/(7.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerWeek = new (
                                                              "nautical mile per week"
                                                            , "nmi/wk"
                                                            , CablePerDay
                                                            , 10.0 / 7.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// mile per sextillion years defined such that: furlong per quintillion years = mi/Zyr × (8.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerSextillionYears = new (
                                                                 "mile per sextillion years"
                                                               , "mi/Zyr"
                                                               , FurlongPerQuintillionYears
                                                               , 8.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// chain per decillion years defined such that: yard per nonillion years = ch/decillion yr × (22.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerDecillionYears = new (
                                                                 "chain per decillion years"
                                                               , "ch/decillion yr"
                                                               , YardPerNonillionYears
                                                               , 22.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// twip per nonillion years defined such that: foot per octillion years = twip/Qyr × (1.0/17280.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerNonillionYears = new (
                                                                "twip per nonillion years"
                                                              , "twip/Qyr"
                                                              , FootPerOctillionYears
                                                              , 1.0 / 17280.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// yard per decillion years defined such that: foot per nonillion years = yd/decillion yr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerDecillionYears = new (
                                                                "yard per decillion years"
                                                              , "yd/decillion yr"
                                                              , FootPerNonillionYears
                                                              , 3.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// nautical mile per sextillion years defined such that: cable per quintillion years = nmi/Zyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSextillionYears = new (
                                                                         "nautical mile per sextillion years"
                                                                       , "nmi/Zyr"
                                                                       , CablePerQuintillionYears
                                                                       , 10.0 / 1000.0
                                                                       , system: "Imperial"
                                                                        );

   /// <summary>
   /// chain per year defined such that: yard per day = ch/yr × (22.0)/(365.2525).
   /// </summary>
   public static readonly Velocity ChainPerYear = new (
                                                       "chain per year"
                                                     , "ch/yr"
                                                     , YardPerDay
                                                     , 22.0 / 365.2525
                                                     , system: "Imperial"
                                                      );

   /// <summary>
   /// cable per decade defined such that: fathom per year = cable/decade × (100.0)/(10.0).
   /// </summary>
   public static readonly Velocity CablePerDecade = new (
                                                         "cable per decade"
                                                       , "cable/decade"
                                                       , FathomPerYear
                                                       , 100.0 / 10.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// barleycorn per decillion years defined such that: foot per nonillion years = barleycorn/decillion yr × (1.0/36.0)/(1000.0).
   /// </summary>
   public static readonly Velocity BarleycornPerDecillionYears = new (
                                                                      "barleycorn per decillion years"
                                                                    , "barleycorn/decillion yr"
                                                                    , FootPerNonillionYears
                                                                    , 1.0 / 36.0 / 1000.0
                                                                    , system: "Imperial"
                                                                     );

   /// <summary>
   /// mile per decade defined such that: furlong per year = mi/decade × (8.0)/(10.0).
   /// </summary>
   public static readonly Velocity MilePerDecade = new (
                                                        "mile per decade"
                                                      , "mi/decade"
                                                      , FurlongPerYear
                                                      , 8.0 / 10.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// nautical mile per century defined such that: cable per decade = nmi/century × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerCentury = new (
                                                                 "nautical mile per century"
                                                               , "nmi/century"
                                                               , CablePerDecade
                                                               , 10.0 / 10.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// furlong per octillion years defined such that: chain per septillion years = fur/Ryr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerOctillionYears = new (
                                                                   "furlong per octillion years"
                                                                 , "fur/Ryr"
                                                                 , ChainPerSeptillionYears
                                                                 , 10.0 / 1000.0
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// mile per week defined such that: furlong per day = mi/wk × (8.0)/(7.0).
   /// </summary>
   public static readonly Velocity MilePerWeek = new (
                                                      "mile per week"
                                                    , "mi/wk"
                                                    , FurlongPerDay
                                                    , 8.0 / 7.0
                                                    , system: "Imperial"
                                                     );

   /// <summary>
   /// nautical mile per nonillion years defined such that: cable per octillion years = nmi/Qyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerNonillionYears = new (
                                                                        "nautical mile per nonillion years"
                                                                      , "nmi/Qyr"
                                                                      , CablePerOctillionYears
                                                                      , 10.0 / 1000.0
                                                                      , system: "Imperial"
                                                                       );

   /// <summary>
   /// chain per millennium defined such that: yard per century = ch/kyr × (22.0)/(10.0).
   /// </summary>
   public static readonly Velocity ChainPerMillennium = new (
                                                             "chain per millennium"
                                                           , "ch/kyr"
                                                           , YardPerCentury
                                                           , 22.0 / 10.0
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// furlong per century defined such that: chain per decade = fur/century × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity FurlongPerCentury = new (
                                                            "furlong per century"
                                                          , "fur/century"
                                                          , ChainPerDecade
                                                          , 10.0 / 10.0
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// cable per nonillion years defined such that: fathom per octillion years = cable/Qyr × (100.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerNonillionYears = new (
                                                                 "cable per nonillion years"
                                                               , "cable/Qyr"
                                                               , FathomPerOctillionYears
                                                               , 100.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// nautical mile per day defined such that: cable per hour = nmi/dy × (10.0)/(24.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDay = new (
                                                             "nautical mile per day"
                                                           , "nmi/dy"
                                                           , CablePerHour
                                                           , 10.0 / 24.0
                                                           , system: "Imperial"
                                                            );

   /// <summary>
   /// league per septillion years defined such that: mile per sextillion years = lea/Yyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerSeptillionYears = new (
                                                                   "league per septillion years"
                                                                 , "lea/Yyr"
                                                                 , MilePerSextillionYears
                                                                 , 3.0 / 1000.0
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// league per week defined such that: mile per day = lea/wk × (3.0)/(7.0).
   /// </summary>
   public static readonly Velocity LeaguePerWeek = new (
                                                        "league per week"
                                                      , "lea/wk"
                                                      , MilePerDay
                                                      , 3.0 / 7.0
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// chain per trillion years defined such that: yard per billion years = ch/Tyr × (22.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ChainPerTrillionYears = new (
                                                                "chain per trillion years"
                                                              , "ch/Tyr"
                                                              , YardPerBillionYears
                                                              , 22.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// furlong per quadrillion years defined such that: chain per trillion years = fur/Pyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerQuadrillionYears = new (
                                                                     "furlong per quadrillion years"
                                                                   , "fur/Pyr"
                                                                   , ChainPerTrillionYears
                                                                   , 10.0 / 1000.0
                                                                   , system: "Imperial"
                                                                    );

   /// <summary>
   /// league per nonillion years defined such that: mile per octillion years = lea/Qyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerNonillionYears = new (
                                                                  "league per nonillion years"
                                                                , "lea/Qyr"
                                                                , MilePerOctillionYears
                                                                , 3.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// nautical mile per decade defined such that: cable per year = nmi/decade × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecade = new (
                                                                "nautical mile per decade"
                                                              , "nmi/decade"
                                                              , CablePerYear
                                                              , 10.0 / 10.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// league per decade defined such that: mile per year = lea/decade × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity LeaguePerDecade = new (
                                                          "league per decade"
                                                        , "lea/decade"
                                                        , MilePerYear
                                                        , 3.0 / 10.0
                                                        , system: "Imperial"
                                                         );

   /// <summary>
   /// nautical mile per octillion years defined such that: cable per septillion years = nmi/Ryr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerOctillionYears = new (
                                                                        "nautical mile per octillion years"
                                                                      , "nmi/Ryr"
                                                                      , CablePerSeptillionYears
                                                                      , 10.0 / 1000.0
                                                                      , system: "Imperial"
                                                                       );

   /// <summary>
   /// mile per nonillion years defined such that: furlong per octillion years = mi/Qyr × (8.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerNonillionYears = new (
                                                                "mile per nonillion years"
                                                              , "mi/Qyr"
                                                              , FurlongPerOctillionYears
                                                              , 8.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// furlong per billion years defined such that: chain per million years = fur/Gyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerBillionYears = new (
                                                                 "furlong per billion years"
                                                               , "fur/Gyr"
                                                               , ChainPerMillionYears
                                                               , 10.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// mile per quintillion years defined such that: furlong per quadrillion years = mi/Eyr × (8.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerQuintillionYears = new (
                                                                  "mile per quintillion years"
                                                                , "mi/Eyr"
                                                                , FurlongPerQuadrillionYears
                                                                , 8.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// mile per trillion years defined such that: furlong per billion years = mi/Tyr × (8.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerTrillionYears = new (
                                                               "mile per trillion years"
                                                             , "mi/Tyr"
                                                             , FurlongPerBillionYears
                                                             , 8.0 / 1000.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// furlong per millennium defined such that: chain per century = fur/kyr × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity FurlongPerMillennium = new (
                                                               "furlong per millennium"
                                                             , "fur/kyr"
                                                             , ChainPerCentury
                                                             , 10.0 / 10.0
                                                             , system: "Imperial"
                                                              );

   /// <summary>
   /// league per quadrillion years defined such that: mile per trillion years = lea/Pyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerQuadrillionYears = new (
                                                                    "league per quadrillion years"
                                                                  , "lea/Pyr"
                                                                  , MilePerTrillionYears
                                                                  , 3.0 / 1000.0
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// league per sextillion years defined such that: mile per quintillion years = lea/Zyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerSextillionYears = new (
                                                                   "league per sextillion years"
                                                                 , "lea/Zyr"
                                                                 , MilePerQuintillionYears
                                                                 , 3.0 / 1000.0
                                                                 , system: "Imperial"
                                                                  );

   /// <summary>
   /// furlong per decade defined such that: chain per year = fur/decade × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity FurlongPerDecade = new (
                                                           "furlong per decade"
                                                         , "fur/decade"
                                                         , ChainPerYear
                                                         , 10.0 / 10.0
                                                         , system: "Imperial"
                                                          );

   /// <summary>
   /// nautical mile per decillion years defined such that: cable per nonillion years = nmi/decillion yr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecillionYears = new (
                                                                        "nautical mile per decillion years"
                                                                      , "nmi/decillion yr"
                                                                      , CablePerNonillionYears
                                                                      , 10.0 / 1000.0
                                                                      , system: "Imperial"
                                                                       );

   /// <summary>
   /// league per decillion years defined such that: mile per nonillion years = lea/decillion yr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerDecillionYears = new (
                                                                  "league per decillion years"
                                                                , "lea/decillion yr"
                                                                , MilePerNonillionYears
                                                                , 3.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// furlong per trillion years defined such that: chain per billion years = fur/Tyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerTrillionYears = new (
                                                                  "furlong per trillion years"
                                                                , "fur/Tyr"
                                                                , ChainPerBillionYears
                                                                , 10.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// league per century defined such that: mile per decade = lea/century × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity LeaguePerCentury = new (
                                                           "league per century"
                                                         , "lea/century"
                                                         , MilePerDecade
                                                         , 3.0 / 10.0
                                                         , system: "Imperial"
                                                          );

   /// <summary>
   /// mile per quadrillion years defined such that: furlong per trillion years = mi/Pyr × (8.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerQuadrillionYears = new (
                                                                  "mile per quadrillion years"
                                                                , "mi/Pyr"
                                                                , FurlongPerTrillionYears
                                                                , 8.0 / 1000.0
                                                                , system: "Imperial"
                                                                 );

   /// <summary>
   /// furlong per million years defined such that: chain per millennium = fur/Myr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FurlongPerMillionYears = new (
                                                                 "furlong per million years"
                                                               , "fur/Myr"
                                                               , ChainPerMillennium
                                                               , 10.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// mile per millennium defined such that: furlong per century = mi/kyr × (8.0)/(10.0).
   /// </summary>
   public static readonly Velocity MilePerMillennium = new (
                                                            "mile per millennium"
                                                          , "mi/kyr"
                                                          , FurlongPerCentury
                                                          , 8.0 / 10.0
                                                          , system: "Imperial"
                                                           );

   /// <summary>
   /// league per quintillion years defined such that: mile per quadrillion years = lea/Eyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerQuintillionYears = new (
                                                                    "league per quintillion years"
                                                                  , "lea/Eyr"
                                                                  , MilePerQuadrillionYears
                                                                  , 3.0 / 1000.0
                                                                  , system: "Imperial"
                                                                   );

   /// <summary>
   /// mile per million years defined such that: furlong per millennium = mi/Myr × (8.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerMillionYears = new (
                                                              "mile per million years"
                                                            , "mi/Myr"
                                                            , FurlongPerMillennium
                                                            , 8.0 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// mile per century defined such that: furlong per decade = mi/century × (8.0)/(10.0).
   /// </summary>
   public static readonly Velocity MilePerCentury = new (
                                                         "mile per century"
                                                       , "mi/century"
                                                       , FurlongPerDecade
                                                       , 8.0 / 10.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// league per billion years defined such that: mile per million years = lea/Gyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerBillionYears = new (
                                                                "league per billion years"
                                                              , "lea/Gyr"
                                                              , MilePerMillionYears
                                                              , 3.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// mile per billion years defined such that: furlong per million years = mi/Gyr × (8.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerBillionYears = new (
                                                              "mile per billion years"
                                                            , "mi/Gyr"
                                                            , FurlongPerMillionYears
                                                            , 8.0 / 1000.0
                                                            , system: "Imperial"
                                                             );

   /// <summary>
   /// league per million years defined such that: mile per millennium = lea/Myr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerMillionYears = new (
                                                                "league per million years"
                                                              , "lea/Myr"
                                                              , MilePerMillennium
                                                              , 3.0 / 1000.0
                                                              , system: "Imperial"
                                                               );

   /// <summary>
   /// league per trillion years defined such that: mile per billion years = lea/Tyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerTrillionYears = new (
                                                                 "league per trillion years"
                                                               , "lea/Tyr"
                                                               , MilePerBillionYears
                                                               , 3.0 / 1000.0
                                                               , system: "Imperial"
                                                                );

   /// <summary>
   /// league per millennium defined such that: mile per century = lea/kyr × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity LeaguePerMillennium = new (
                                                              "league per millennium"
                                                            , "lea/kyr"
                                                            , MilePerCentury
                                                            , 3.0 / 10.0
                                                            , system: "Imperial"
                                                             );
}
