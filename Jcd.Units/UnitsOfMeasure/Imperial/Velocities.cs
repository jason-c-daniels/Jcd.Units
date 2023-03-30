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
   /// A(n) inch per second. Defined as: ((2.54)/(1.0)) × SI centimeter per second + (0).
   /// </summary>
   public static readonly Velocity InchPerSecond = new (
                                                        "inch per second"
                                                      , "in/s"
                                                      , SI.Velocities.CentimeterPerSecond
                                                      , 2.54 / 1.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) inch per decisecond. Defined as: ((2.54)/(1.0/10.0)) × SI centimeter per second + (0).
   /// </summary>
   public static readonly Velocity InchPerDecisecond = new (
                                                            "inch per decisecond"
                                                          , "in/ds"
                                                          , SI.Velocities.CentimeterPerSecond
                                                          , 2.54 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) inch per centisecond. Defined as: ((2.54)/(1.0/10.0)) × SI centimeter per decisecond + (0).
   /// </summary>
   public static readonly Velocity InchPerCentisecond = new (
                                                             "inch per centisecond"
                                                           , "in/cs"
                                                           , SI.Velocities.CentimeterPerDecisecond
                                                           , 2.54 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) inch per millisecond. Defined as: ((2.54)/(1.0/10.0)) × SI centimeter per centisecond + (0).
   /// </summary>
   public static readonly Velocity InchPerMillisecond = new (
                                                             "inch per millisecond"
                                                           , "in/ms"
                                                           , SI.Velocities.CentimeterPerCentisecond
                                                           , 2.54 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) inch per microsecond. Defined as: ((2.54)/(1.0/1000.0)) × SI centimeter per millisecond + (0).
   /// </summary>
   public static readonly Velocity InchPerMicrosecond = new (
                                                             "inch per microsecond"
                                                           , "in/μs"
                                                           , SI.Velocities.CentimeterPerMillisecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) inch per nanosecond. Defined as: ((2.54)/(1.0/1000.0)) × SI centimeter per microsecond + (0).
   /// </summary>
   public static readonly Velocity InchPerNanosecond = new (
                                                            "inch per nanosecond"
                                                          , "in/ns"
                                                          , SI.Velocities.CentimeterPerMicrosecond
                                                          , 2.54 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) inch per picosecond. Defined as: ((2.54)/(1.0/1000.0)) × SI centimeter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity InchPerPicosecond = new (
                                                            "inch per picosecond"
                                                          , "in/ps"
                                                          , SI.Velocities.CentimeterPerNanosecond
                                                          , 2.54 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) inch per femtosecond. Defined as: ((2.54)/(1.0/1000.0)) × SI centimeter per picosecond + (0).
   /// </summary>
   public static readonly Velocity InchPerFemtosecond = new (
                                                             "inch per femtosecond"
                                                           , "in/fs"
                                                           , SI.Velocities.CentimeterPerPicosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) inch per attosecond. Defined as: ((2.54)/(1.0/1000.0)) × SI centimeter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity InchPerAttosecond = new (
                                                            "inch per attosecond"
                                                          , "in/as"
                                                          , SI.Velocities.CentimeterPerFemtosecond
                                                          , 2.54 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) inch per zeptosecond. Defined as: ((2.54)/(1.0/1000.0)) × SI centimeter per attosecond + (0).
   /// </summary>
   public static readonly Velocity InchPerZeptosecond = new (
                                                             "inch per zeptosecond"
                                                           , "in/zs"
                                                           , SI.Velocities.CentimeterPerAttosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) inch per yoctosecond. Defined as: ((2.54)/(1.0/1000.0)) × SI centimeter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity InchPerYoctosecond = new (
                                                             "inch per yoctosecond"
                                                           , "in/ys"
                                                           , SI.Velocities.CentimeterPerZeptosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) inch per rontosecond. Defined as: ((2.54)/(1.0/1000.0)) × SI centimeter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity InchPerRontosecond = new (
                                                             "inch per rontosecond"
                                                           , "in/rs"
                                                           , SI.Velocities.CentimeterPerYoctosecond
                                                           , 2.54 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) inch per quectosecond. Defined as: ((2.54)/(1.0/1000.0)) × SI centimeter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity InchPerQuectosecond = new (
                                                              "inch per quectosecond"
                                                            , "in/qs"
                                                            , SI.Velocities.CentimeterPerRontosecond
                                                            , 2.54 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) inch per minute. Defined as: ((2.54)/(60.0)) × SI centimeter per second + (0).
   /// </summary>
   public static readonly Velocity InchPerMinute = new (
                                                        "inch per minute"
                                                      , "in/min"
                                                      , SI.Velocities.CentimeterPerSecond
                                                      , 2.54 / 60.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) foot per second. Defined as: ((12)/(1.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity FootPerSecond = new ("foot per second", "ft/s", InchPerSecond, 12 / 1.0, 0);

   /// <summary>
   /// A(n) foot per decisecond. Defined as: ((12)/(1.0/10.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity FootPerDecisecond = new (
                                                            "foot per decisecond"
                                                          , "ft/ds"
                                                          , InchPerSecond
                                                          , 12 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per centisecond. Defined as: ((12)/(1.0/10.0)) × inch per decisecond + (0).
   /// </summary>
   public static readonly Velocity FootPerCentisecond = new (
                                                             "foot per centisecond"
                                                           , "ft/cs"
                                                           , InchPerDecisecond
                                                           , 12 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per millisecond. Defined as: ((12)/(1.0/10.0)) × inch per centisecond + (0).
   /// </summary>
   public static readonly Velocity FootPerMillisecond = new (
                                                             "foot per millisecond"
                                                           , "ft/ms"
                                                           , InchPerCentisecond
                                                           , 12 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per microsecond. Defined as: ((12)/(1.0/1000.0)) × inch per millisecond + (0).
   /// </summary>
   public static readonly Velocity FootPerMicrosecond = new (
                                                             "foot per microsecond"
                                                           , "ft/μs"
                                                           , InchPerMillisecond
                                                           , 12 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per nanosecond. Defined as: ((12)/(1.0/1000.0)) × inch per microsecond + (0).
   /// </summary>
   public static readonly Velocity FootPerNanosecond = new (
                                                            "foot per nanosecond"
                                                          , "ft/ns"
                                                          , InchPerMicrosecond
                                                          , 12 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per picosecond. Defined as: ((12)/(1.0/1000.0)) × inch per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerPicosecond = new (
                                                            "foot per picosecond"
                                                          , "ft/ps"
                                                          , InchPerNanosecond
                                                          , 12 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per femtosecond. Defined as: ((12)/(1.0/1000.0)) × inch per picosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerFemtosecond = new (
                                                             "foot per femtosecond"
                                                           , "ft/fs"
                                                           , InchPerPicosecond
                                                           , 12 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per attosecond. Defined as: ((12)/(1.0/1000.0)) × inch per femtosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerAttosecond = new (
                                                            "foot per attosecond"
                                                          , "ft/as"
                                                          , InchPerFemtosecond
                                                          , 12 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per zeptosecond. Defined as: ((12)/(1.0/1000.0)) × inch per attosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerZeptosecond = new (
                                                             "foot per zeptosecond"
                                                           , "ft/zs"
                                                           , InchPerAttosecond
                                                           , 12 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per yoctosecond. Defined as: ((12)/(1.0/1000.0)) × inch per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerYoctosecond = new (
                                                             "foot per yoctosecond"
                                                           , "ft/ys"
                                                           , InchPerZeptosecond
                                                           , 12 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per rontosecond. Defined as: ((12)/(1.0/1000.0)) × inch per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerRontosecond = new (
                                                             "foot per rontosecond"
                                                           , "ft/rs"
                                                           , InchPerYoctosecond
                                                           , 12 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per quectosecond. Defined as: ((12)/(1.0/1000.0)) × inch per rontosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerQuectosecond =
            new ("foot per quectosecond", "ft/qs", InchPerRontosecond, 12 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) inch per hour. Defined as: ((2.54)/(60.0)) × SI centimeter per minute + (0).
   /// </summary>
   public static readonly Velocity InchPerHour = new (
                                                      "inch per hour"
                                                    , "in/hr"
                                                    , SI.Velocities.CentimeterPerMinute
                                                    , 2.54 / 60.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) twip per second. Defined as: ((1.0/17280.0)/(1.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity TwipPerSecond = new (
                                                        "twip per second"
                                                      , "twip/s"
                                                      , FootPerSecond
                                                      , 1.0 / 17280.0 / 1.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) twip per decisecond. Defined as: ((1.0/17280.0)/(1.0/10.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity TwipPerDecisecond = new (
                                                            "twip per decisecond"
                                                          , "twip/ds"
                                                          , FootPerSecond
                                                          , 1.0 / 17280.0 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) twip per centisecond. Defined as: ((1.0/17280.0)/(1.0/10.0)) × foot per decisecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerCentisecond = new (
                                                             "twip per centisecond"
                                                           , "twip/cs"
                                                           , FootPerDecisecond
                                                           , 1.0 / 17280.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per millisecond. Defined as: ((1.0/17280.0)/(1.0/10.0)) × foot per centisecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerMillisecond = new (
                                                             "twip per millisecond"
                                                           , "twip/ms"
                                                           , FootPerCentisecond
                                                           , 1.0 / 17280.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per microsecond. Defined as: ((1.0/17280.0)/(1.0/1000.0)) × foot per millisecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerMicrosecond = new (
                                                             "twip per microsecond"
                                                           , "twip/μs"
                                                           , FootPerMillisecond
                                                           , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per nanosecond. Defined as: ((1.0/17280.0)/(1.0/1000.0)) × foot per microsecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerNanosecond = new (
                                                            "twip per nanosecond"
                                                          , "twip/ns"
                                                          , FootPerMicrosecond
                                                          , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) twip per picosecond. Defined as: ((1.0/17280.0)/(1.0/1000.0)) × foot per nanosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerPicosecond = new (
                                                            "twip per picosecond"
                                                          , "twip/ps"
                                                          , FootPerNanosecond
                                                          , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) twip per femtosecond. Defined as: ((1.0/17280.0)/(1.0/1000.0)) × foot per picosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerFemtosecond = new (
                                                             "twip per femtosecond"
                                                           , "twip/fs"
                                                           , FootPerPicosecond
                                                           , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per attosecond. Defined as: ((1.0/17280.0)/(1.0/1000.0)) × foot per femtosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerAttosecond = new (
                                                            "twip per attosecond"
                                                          , "twip/as"
                                                          , FootPerFemtosecond
                                                          , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) twip per zeptosecond. Defined as: ((1.0/17280.0)/(1.0/1000.0)) × foot per attosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerZeptosecond = new (
                                                             "twip per zeptosecond"
                                                           , "twip/zs"
                                                           , FootPerAttosecond
                                                           , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per yoctosecond. Defined as: ((1.0/17280.0)/(1.0/1000.0)) × foot per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerYoctosecond = new (
                                                             "twip per yoctosecond"
                                                           , "twip/ys"
                                                           , FootPerZeptosecond
                                                           , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per rontosecond. Defined as: ((1.0/17280.0)/(1.0/1000.0)) × foot per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerRontosecond = new (
                                                             "twip per rontosecond"
                                                           , "twip/rs"
                                                           , FootPerYoctosecond
                                                           , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per quectosecond. Defined as: ((1.0/17280.0)/(1.0/1000.0)) × foot per rontosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerQuectosecond = new (
                                                              "twip per quectosecond"
                                                            , "twip/qs"
                                                            , FootPerRontosecond
                                                            , 1.0 / 17280.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) inch per day. Defined as: ((2.54)/(24.0)) × SI centimeter per hour + (0).
   /// </summary>
   public static readonly Velocity InchPerDay = new (
                                                     "inch per day"
                                                   , "in/dy"
                                                   , SI.Velocities.CentimeterPerHour
                                                   , 2.54 / 24.0
                                                   , 0
                                                    );

   /// <summary>
   /// A(n) thou per second. Defined as: ((1.0/12000.0)/(1.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity ThouPerSecond = new (
                                                        "thou per second"
                                                      , "th/s"
                                                      , FootPerSecond
                                                      , 1.0 / 12000.0 / 1.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) thou per decisecond. Defined as: ((1.0/12000.0)/(1.0/10.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity ThouPerDecisecond = new (
                                                            "thou per decisecond"
                                                          , "th/ds"
                                                          , FootPerSecond
                                                          , 1.0 / 12000.0 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) thou per centisecond. Defined as: ((1.0/12000.0)/(1.0/10.0)) × foot per decisecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerCentisecond = new (
                                                             "thou per centisecond"
                                                           , "th/cs"
                                                           , FootPerDecisecond
                                                           , 1.0 / 12000.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) thou per millisecond. Defined as: ((1.0/12000.0)/(1.0/10.0)) × foot per centisecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerMillisecond = new (
                                                             "thou per millisecond"
                                                           , "th/ms"
                                                           , FootPerCentisecond
                                                           , 1.0 / 12000.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) thou per microsecond. Defined as: ((1.0/12000.0)/(1.0/1000.0)) × foot per millisecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerMicrosecond = new (
                                                             "thou per microsecond"
                                                           , "th/μs"
                                                           , FootPerMillisecond
                                                           , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) thou per nanosecond. Defined as: ((1.0/12000.0)/(1.0/1000.0)) × foot per microsecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerNanosecond = new (
                                                            "thou per nanosecond"
                                                          , "th/ns"
                                                          , FootPerMicrosecond
                                                          , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) thou per picosecond. Defined as: ((1.0/12000.0)/(1.0/1000.0)) × foot per nanosecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerPicosecond = new (
                                                            "thou per picosecond"
                                                          , "th/ps"
                                                          , FootPerNanosecond
                                                          , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) thou per femtosecond. Defined as: ((1.0/12000.0)/(1.0/1000.0)) × foot per picosecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerFemtosecond = new (
                                                             "thou per femtosecond"
                                                           , "th/fs"
                                                           , FootPerPicosecond
                                                           , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) thou per attosecond. Defined as: ((1.0/12000.0)/(1.0/1000.0)) × foot per femtosecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerAttosecond = new (
                                                            "thou per attosecond"
                                                          , "th/as"
                                                          , FootPerFemtosecond
                                                          , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) thou per zeptosecond. Defined as: ((1.0/12000.0)/(1.0/1000.0)) × foot per attosecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerZeptosecond = new (
                                                             "thou per zeptosecond"
                                                           , "th/zs"
                                                           , FootPerAttosecond
                                                           , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) thou per yoctosecond. Defined as: ((1.0/12000.0)/(1.0/1000.0)) × foot per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerYoctosecond = new (
                                                             "thou per yoctosecond"
                                                           , "th/ys"
                                                           , FootPerZeptosecond
                                                           , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) thou per rontosecond. Defined as: ((1.0/12000.0)/(1.0/1000.0)) × foot per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerRontosecond = new (
                                                             "thou per rontosecond"
                                                           , "th/rs"
                                                           , FootPerYoctosecond
                                                           , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) thou per quectosecond. Defined as: ((1.0/12000.0)/(1.0/1000.0)) × foot per rontosecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerQuectosecond = new (
                                                              "thou per quectosecond"
                                                            , "th/qs"
                                                            , FootPerRontosecond
                                                            , 1.0 / 12000.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) inch per week. Defined as: ((2.54)/(7.0)) × SI centimeter per day + (0).
   /// </summary>
   public static readonly Velocity InchPerWeek = new (
                                                      "inch per week"
                                                    , "in/wk"
                                                    , SI.Velocities.CentimeterPerDay
                                                    , 2.54 / 7.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) barleycorn per second. Defined as: ((1.0/36.0)/(1.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerSecond =
            new ("barleycorn per second", "barleycorn/s", FootPerSecond, 1.0 / 36.0 / 1.0, 0);

   /// <summary>
   /// A(n) barleycorn per decisecond. Defined as: ((1.0/36.0)/(1.0/10.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerDecisecond = new (
                                                                  "barleycorn per decisecond"
                                                                , "barleycorn/ds"
                                                                , FootPerSecond
                                                                , 1.0 / 36.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) barleycorn per centisecond. Defined as: ((1.0/36.0)/(1.0/10.0)) × foot per decisecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerCentisecond = new (
                                                                   "barleycorn per centisecond"
                                                                 , "barleycorn/cs"
                                                                 , FootPerDecisecond
                                                                 , 1.0 / 36.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) barleycorn per millisecond. Defined as: ((1.0/36.0)/(1.0/10.0)) × foot per centisecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerMillisecond = new (
                                                                   "barleycorn per millisecond"
                                                                 , "barleycorn/ms"
                                                                 , FootPerCentisecond
                                                                 , 1.0 / 36.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) barleycorn per microsecond. Defined as: ((1.0/36.0)/(1.0/1000.0)) × foot per millisecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerMicrosecond = new (
                                                                   "barleycorn per microsecond"
                                                                 , "barleycorn/μs"
                                                                 , FootPerMillisecond
                                                                 , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) barleycorn per nanosecond. Defined as: ((1.0/36.0)/(1.0/1000.0)) × foot per microsecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerNanosecond = new (
                                                                  "barleycorn per nanosecond"
                                                                , "barleycorn/ns"
                                                                , FootPerMicrosecond
                                                                , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) barleycorn per picosecond. Defined as: ((1.0/36.0)/(1.0/1000.0)) × foot per nanosecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerPicosecond = new (
                                                                  "barleycorn per picosecond"
                                                                , "barleycorn/ps"
                                                                , FootPerNanosecond
                                                                , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) barleycorn per femtosecond. Defined as: ((1.0/36.0)/(1.0/1000.0)) × foot per picosecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerFemtosecond = new (
                                                                   "barleycorn per femtosecond"
                                                                 , "barleycorn/fs"
                                                                 , FootPerPicosecond
                                                                 , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) barleycorn per attosecond. Defined as: ((1.0/36.0)/(1.0/1000.0)) × foot per femtosecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerAttosecond = new (
                                                                  "barleycorn per attosecond"
                                                                , "barleycorn/as"
                                                                , FootPerFemtosecond
                                                                , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) barleycorn per zeptosecond. Defined as: ((1.0/36.0)/(1.0/1000.0)) × foot per attosecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerZeptosecond = new (
                                                                   "barleycorn per zeptosecond"
                                                                 , "barleycorn/zs"
                                                                 , FootPerAttosecond
                                                                 , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) barleycorn per yoctosecond. Defined as: ((1.0/36.0)/(1.0/1000.0)) × foot per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerYoctosecond = new (
                                                                   "barleycorn per yoctosecond"
                                                                 , "barleycorn/ys"
                                                                 , FootPerZeptosecond
                                                                 , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) barleycorn per rontosecond. Defined as: ((1.0/36.0)/(1.0/1000.0)) × foot per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerRontosecond = new (
                                                                   "barleycorn per rontosecond"
                                                                 , "barleycorn/rs"
                                                                 , FootPerYoctosecond
                                                                 , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) barleycorn per quectosecond. Defined as: ((1.0/36.0)/(1.0/1000.0)) × foot per rontosecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerQuectosecond = new (
                                                                    "barleycorn per quectosecond"
                                                                  , "barleycorn/qs"
                                                                  , FootPerRontosecond
                                                                  , 1.0 / 36.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) inch per year. Defined as: ((2.54)/(365.2525)) × SI centimeter per day + (0).
   /// </summary>
   public static readonly Velocity InchPerYear = new (
                                                      "inch per year"
                                                    , "in/yr"
                                                    , SI.Velocities.CentimeterPerDay
                                                    , 2.54 / 365.2525
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) hand per second. Defined as: ((4.0)/(1.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity HandPerSecond = new ("hand per second", "hh/s", InchPerSecond, 4.0 / 1.0, 0);

   /// <summary>
   /// A(n) hand per decisecond. Defined as: ((4.0)/(1.0/10.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity HandPerDecisecond = new (
                                                            "hand per decisecond"
                                                          , "hh/ds"
                                                          , InchPerSecond
                                                          , 4.0 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) hand per centisecond. Defined as: ((4.0)/(1.0/10.0)) × inch per decisecond + (0).
   /// </summary>
   public static readonly Velocity HandPerCentisecond = new (
                                                             "hand per centisecond"
                                                           , "hh/cs"
                                                           , InchPerDecisecond
                                                           , 4.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) hand per millisecond. Defined as: ((4.0)/(1.0/10.0)) × inch per centisecond + (0).
   /// </summary>
   public static readonly Velocity HandPerMillisecond = new (
                                                             "hand per millisecond"
                                                           , "hh/ms"
                                                           , InchPerCentisecond
                                                           , 4.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) hand per microsecond. Defined as: ((4.0)/(1.0/1000.0)) × inch per millisecond + (0).
   /// </summary>
   public static readonly Velocity HandPerMicrosecond = new (
                                                             "hand per microsecond"
                                                           , "hh/μs"
                                                           , InchPerMillisecond
                                                           , 4.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) hand per nanosecond. Defined as: ((4.0)/(1.0/1000.0)) × inch per microsecond + (0).
   /// </summary>
   public static readonly Velocity HandPerNanosecond = new (
                                                            "hand per nanosecond"
                                                          , "hh/ns"
                                                          , InchPerMicrosecond
                                                          , 4.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) hand per picosecond. Defined as: ((4.0)/(1.0/1000.0)) × inch per nanosecond + (0).
   /// </summary>
   public static readonly Velocity HandPerPicosecond = new (
                                                            "hand per picosecond"
                                                          , "hh/ps"
                                                          , InchPerNanosecond
                                                          , 4.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) hand per femtosecond. Defined as: ((4.0)/(1.0/1000.0)) × inch per picosecond + (0).
   /// </summary>
   public static readonly Velocity HandPerFemtosecond = new (
                                                             "hand per femtosecond"
                                                           , "hh/fs"
                                                           , InchPerPicosecond
                                                           , 4.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) hand per attosecond. Defined as: ((4.0)/(1.0/1000.0)) × inch per femtosecond + (0).
   /// </summary>
   public static readonly Velocity HandPerAttosecond = new (
                                                            "hand per attosecond"
                                                          , "hh/as"
                                                          , InchPerFemtosecond
                                                          , 4.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) hand per zeptosecond. Defined as: ((4.0)/(1.0/1000.0)) × inch per attosecond + (0).
   /// </summary>
   public static readonly Velocity HandPerZeptosecond = new (
                                                             "hand per zeptosecond"
                                                           , "hh/zs"
                                                           , InchPerAttosecond
                                                           , 4.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) hand per yoctosecond. Defined as: ((4.0)/(1.0/1000.0)) × inch per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity HandPerYoctosecond = new (
                                                             "hand per yoctosecond"
                                                           , "hh/ys"
                                                           , InchPerZeptosecond
                                                           , 4.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) hand per rontosecond. Defined as: ((4.0)/(1.0/1000.0)) × inch per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity HandPerRontosecond = new (
                                                             "hand per rontosecond"
                                                           , "hh/rs"
                                                           , InchPerYoctosecond
                                                           , 4.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) hand per quectosecond. Defined as: ((4.0)/(1.0/1000.0)) × inch per rontosecond + (0).
   /// </summary>
   public static readonly Velocity HandPerQuectosecond =
            new ("hand per quectosecond", "hh/qs", InchPerRontosecond, 4.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) inch per decade. Defined as: ((2.54)/(10.0)) × SI centimeter per year + (0).
   /// </summary>
   public static readonly Velocity InchPerDecade = new (
                                                        "inch per decade"
                                                      , "in/decade"
                                                      , SI.Velocities.CentimeterPerYear
                                                      , 2.54 / 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) yard per second. Defined as: ((3.0)/(1.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity YardPerSecond = new ("yard per second", "yd/s", FootPerSecond, 3.0 / 1.0, 0);

   /// <summary>
   /// A(n) yard per decisecond. Defined as: ((3.0)/(1.0/10.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity YardPerDecisecond = new (
                                                            "yard per decisecond"
                                                          , "yd/ds"
                                                          , FootPerSecond
                                                          , 3.0 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) yard per centisecond. Defined as: ((3.0)/(1.0/10.0)) × foot per decisecond + (0).
   /// </summary>
   public static readonly Velocity YardPerCentisecond = new (
                                                             "yard per centisecond"
                                                           , "yd/cs"
                                                           , FootPerDecisecond
                                                           , 3.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) yard per millisecond. Defined as: ((3.0)/(1.0/10.0)) × foot per centisecond + (0).
   /// </summary>
   public static readonly Velocity YardPerMillisecond = new (
                                                             "yard per millisecond"
                                                           , "yd/ms"
                                                           , FootPerCentisecond
                                                           , 3.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) yard per microsecond. Defined as: ((3.0)/(1.0/1000.0)) × foot per millisecond + (0).
   /// </summary>
   public static readonly Velocity YardPerMicrosecond = new (
                                                             "yard per microsecond"
                                                           , "yd/μs"
                                                           , FootPerMillisecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) yard per nanosecond. Defined as: ((3.0)/(1.0/1000.0)) × foot per microsecond + (0).
   /// </summary>
   public static readonly Velocity YardPerNanosecond = new (
                                                            "yard per nanosecond"
                                                          , "yd/ns"
                                                          , FootPerMicrosecond
                                                          , 3.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) yard per picosecond. Defined as: ((3.0)/(1.0/1000.0)) × foot per nanosecond + (0).
   /// </summary>
   public static readonly Velocity YardPerPicosecond = new (
                                                            "yard per picosecond"
                                                          , "yd/ps"
                                                          , FootPerNanosecond
                                                          , 3.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) yard per femtosecond. Defined as: ((3.0)/(1.0/1000.0)) × foot per picosecond + (0).
   /// </summary>
   public static readonly Velocity YardPerFemtosecond = new (
                                                             "yard per femtosecond"
                                                           , "yd/fs"
                                                           , FootPerPicosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) yard per attosecond. Defined as: ((3.0)/(1.0/1000.0)) × foot per femtosecond + (0).
   /// </summary>
   public static readonly Velocity YardPerAttosecond = new (
                                                            "yard per attosecond"
                                                          , "yd/as"
                                                          , FootPerFemtosecond
                                                          , 3.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) yard per zeptosecond. Defined as: ((3.0)/(1.0/1000.0)) × foot per attosecond + (0).
   /// </summary>
   public static readonly Velocity YardPerZeptosecond = new (
                                                             "yard per zeptosecond"
                                                           , "yd/zs"
                                                           , FootPerAttosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) yard per yoctosecond. Defined as: ((3.0)/(1.0/1000.0)) × foot per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity YardPerYoctosecond = new (
                                                             "yard per yoctosecond"
                                                           , "yd/ys"
                                                           , FootPerZeptosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) yard per rontosecond. Defined as: ((3.0)/(1.0/1000.0)) × foot per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity YardPerRontosecond = new (
                                                             "yard per rontosecond"
                                                           , "yd/rs"
                                                           , FootPerYoctosecond
                                                           , 3.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) yard per quectosecond. Defined as: ((3.0)/(1.0/1000.0)) × foot per rontosecond + (0).
   /// </summary>
   public static readonly Velocity YardPerQuectosecond =
            new ("yard per quectosecond", "yd/qs", FootPerRontosecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) inch per century. Defined as: ((2.54)/(10.0)) × SI centimeter per decade + (0).
   /// </summary>
   public static readonly Velocity InchPerCentury = new (
                                                         "inch per century"
                                                       , "in/century"
                                                       , SI.Velocities.CentimeterPerDecade
                                                       , 2.54 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) chain per second. Defined as: ((22.0)/(1.0)) × yard per second + (0).
   /// </summary>
   public static readonly Velocity ChainPerSecond = new ("chain per second", "ch/s", YardPerSecond, 22.0 / 1.0, 0);

   /// <summary>
   /// A(n) chain per decisecond. Defined as: ((22.0)/(1.0/10.0)) × yard per second + (0).
   /// </summary>
   public static readonly Velocity ChainPerDecisecond = new (
                                                             "chain per decisecond"
                                                           , "ch/ds"
                                                           , YardPerSecond
                                                           , 22.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) chain per centisecond. Defined as: ((22.0)/(1.0/10.0)) × yard per decisecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerCentisecond =
            new ("chain per centisecond", "ch/cs", YardPerDecisecond, 22.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) chain per millisecond. Defined as: ((22.0)/(1.0/10.0)) × yard per centisecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerMillisecond =
            new ("chain per millisecond", "ch/ms", YardPerCentisecond, 22.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) chain per microsecond. Defined as: ((22.0)/(1.0/1000.0)) × yard per millisecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerMicrosecond = new (
                                                              "chain per microsecond"
                                                            , "ch/μs"
                                                            , YardPerMillisecond
                                                            , 22.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per nanosecond. Defined as: ((22.0)/(1.0/1000.0)) × yard per microsecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerNanosecond = new (
                                                             "chain per nanosecond"
                                                           , "ch/ns"
                                                           , YardPerMicrosecond
                                                           , 22.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) chain per picosecond. Defined as: ((22.0)/(1.0/1000.0)) × yard per nanosecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerPicosecond = new (
                                                             "chain per picosecond"
                                                           , "ch/ps"
                                                           , YardPerNanosecond
                                                           , 22.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) chain per femtosecond. Defined as: ((22.0)/(1.0/1000.0)) × yard per picosecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerFemtosecond =
            new ("chain per femtosecond", "ch/fs", YardPerPicosecond, 22.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) chain per attosecond. Defined as: ((22.0)/(1.0/1000.0)) × yard per femtosecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerAttosecond = new (
                                                             "chain per attosecond"
                                                           , "ch/as"
                                                           , YardPerFemtosecond
                                                           , 22.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) chain per zeptosecond. Defined as: ((22.0)/(1.0/1000.0)) × yard per attosecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerZeptosecond =
            new ("chain per zeptosecond", "ch/zs", YardPerAttosecond, 22.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) chain per yoctosecond. Defined as: ((22.0)/(1.0/1000.0)) × yard per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerYoctosecond = new (
                                                              "chain per yoctosecond"
                                                            , "ch/ys"
                                                            , YardPerZeptosecond
                                                            , 22.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per rontosecond. Defined as: ((22.0)/(1.0/1000.0)) × yard per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerRontosecond = new (
                                                              "chain per rontosecond"
                                                            , "ch/rs"
                                                            , YardPerYoctosecond
                                                            , 22.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per quectosecond. Defined as: ((22.0)/(1.0/1000.0)) × yard per rontosecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerQuectosecond = new (
                                                               "chain per quectosecond"
                                                             , "ch/qs"
                                                             , YardPerRontosecond
                                                             , 22.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) inch per millennium. Defined as: ((2.54)/(10.0)) × SI centimeter per century + (0).
   /// </summary>
   public static readonly Velocity InchPerMillennium = new (
                                                            "inch per millennium"
                                                          , "in/kyr"
                                                          , SI.Velocities.CentimeterPerCentury
                                                          , 2.54 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) furlong per second. Defined as: ((10.0)/(1.0)) × chain per second + (0).
   /// </summary>
   public static readonly Velocity FurlongPerSecond = new (
                                                           "furlong per second"
                                                         , "fur/s"
                                                         , ChainPerSecond
                                                         , 10.0 / 1.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) furlong per decisecond. Defined as: ((10.0)/(1.0/10.0)) × chain per second + (0).
   /// </summary>
   public static readonly Velocity FurlongPerDecisecond =
            new ("furlong per decisecond", "fur/ds", ChainPerSecond, 10.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) furlong per centisecond. Defined as: ((10.0)/(1.0/10.0)) × chain per decisecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerCentisecond =
            new ("furlong per centisecond", "fur/cs", ChainPerDecisecond, 10.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) furlong per millisecond. Defined as: ((10.0)/(1.0/10.0)) × chain per centisecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerMillisecond = new (
                                                                "furlong per millisecond"
                                                              , "fur/ms"
                                                              , ChainPerCentisecond
                                                              , 10.0 / (1.0 / 10.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per microsecond. Defined as: ((10.0)/(1.0/1000.0)) × chain per millisecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerMicrosecond = new (
                                                                "furlong per microsecond"
                                                              , "fur/μs"
                                                              , ChainPerMillisecond
                                                              , 10.0 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per nanosecond. Defined as: ((10.0)/(1.0/1000.0)) × chain per microsecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerNanosecond = new (
                                                               "furlong per nanosecond"
                                                             , "fur/ns"
                                                             , ChainPerMicrosecond
                                                             , 10.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per picosecond. Defined as: ((10.0)/(1.0/1000.0)) × chain per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerPicosecond = new (
                                                               "furlong per picosecond"
                                                             , "fur/ps"
                                                             , ChainPerNanosecond
                                                             , 10.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per femtosecond. Defined as: ((10.0)/(1.0/1000.0)) × chain per picosecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerFemtosecond = new (
                                                                "furlong per femtosecond"
                                                              , "fur/fs"
                                                              , ChainPerPicosecond
                                                              , 10.0 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per attosecond. Defined as: ((10.0)/(1.0/1000.0)) × chain per femtosecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerAttosecond = new (
                                                               "furlong per attosecond"
                                                             , "fur/as"
                                                             , ChainPerFemtosecond
                                                             , 10.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per zeptosecond. Defined as: ((10.0)/(1.0/1000.0)) × chain per attosecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerZeptosecond = new (
                                                                "furlong per zeptosecond"
                                                              , "fur/zs"
                                                              , ChainPerAttosecond
                                                              , 10.0 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per yoctosecond. Defined as: ((10.0)/(1.0/1000.0)) × chain per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerYoctosecond = new (
                                                                "furlong per yoctosecond"
                                                              , "fur/ys"
                                                              , ChainPerZeptosecond
                                                              , 10.0 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per rontosecond. Defined as: ((10.0)/(1.0/1000.0)) × chain per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerRontosecond = new (
                                                                "furlong per rontosecond"
                                                              , "fur/rs"
                                                              , ChainPerYoctosecond
                                                              , 10.0 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per quectosecond. Defined as: ((10.0)/(1.0/1000.0)) × chain per rontosecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerQuectosecond = new (
                                                                 "furlong per quectosecond"
                                                               , "fur/qs"
                                                               , ChainPerRontosecond
                                                               , 10.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) inch per million years. Defined as: ((2.54)/(1000.0)) × SI centimeter per millennium + (0).
   /// </summary>
   public static readonly Velocity InchPerMillionYears = new (
                                                              "inch per million years"
                                                            , "in/Myr"
                                                            , SI.Velocities.CentimeterPerMillennium
                                                            , 2.54 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) mile per second. Defined as: ((8.0)/(1.0)) × furlong per second + (0).
   /// </summary>
   public static readonly Velocity MilePerSecond = new ("mile per second", "mi/s", FurlongPerSecond, 8.0 / 1.0, 0);

   /// <summary>
   /// A(n) mile per decisecond. Defined as: ((8.0)/(1.0/10.0)) × furlong per second + (0).
   /// </summary>
   public static readonly Velocity MilePerDecisecond = new (
                                                            "mile per decisecond"
                                                          , "mi/ds"
                                                          , FurlongPerSecond
                                                          , 8.0 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mile per centisecond. Defined as: ((8.0)/(1.0/10.0)) × furlong per decisecond + (0).
   /// </summary>
   public static readonly Velocity MilePerCentisecond = new (
                                                             "mile per centisecond"
                                                           , "mi/cs"
                                                           , FurlongPerDecisecond
                                                           , 8.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per millisecond. Defined as: ((8.0)/(1.0/10.0)) × furlong per centisecond + (0).
   /// </summary>
   public static readonly Velocity MilePerMillisecond = new (
                                                             "mile per millisecond"
                                                           , "mi/ms"
                                                           , FurlongPerCentisecond
                                                           , 8.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per microsecond. Defined as: ((8.0)/(1.0/1000.0)) × furlong per millisecond + (0).
   /// </summary>
   public static readonly Velocity MilePerMicrosecond = new (
                                                             "mile per microsecond"
                                                           , "mi/μs"
                                                           , FurlongPerMillisecond
                                                           , 8.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per nanosecond. Defined as: ((8.0)/(1.0/1000.0)) × furlong per microsecond + (0).
   /// </summary>
   public static readonly Velocity MilePerNanosecond = new (
                                                            "mile per nanosecond"
                                                          , "mi/ns"
                                                          , FurlongPerMicrosecond
                                                          , 8.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mile per picosecond. Defined as: ((8.0)/(1.0/1000.0)) × furlong per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerPicosecond = new (
                                                            "mile per picosecond"
                                                          , "mi/ps"
                                                          , FurlongPerNanosecond
                                                          , 8.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mile per femtosecond. Defined as: ((8.0)/(1.0/1000.0)) × furlong per picosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerFemtosecond = new (
                                                             "mile per femtosecond"
                                                           , "mi/fs"
                                                           , FurlongPerPicosecond
                                                           , 8.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per attosecond. Defined as: ((8.0)/(1.0/1000.0)) × furlong per femtosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerAttosecond = new (
                                                            "mile per attosecond"
                                                          , "mi/as"
                                                          , FurlongPerFemtosecond
                                                          , 8.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mile per zeptosecond. Defined as: ((8.0)/(1.0/1000.0)) × furlong per attosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerZeptosecond = new (
                                                             "mile per zeptosecond"
                                                           , "mi/zs"
                                                           , FurlongPerAttosecond
                                                           , 8.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per yoctosecond. Defined as: ((8.0)/(1.0/1000.0)) × furlong per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerYoctosecond = new (
                                                             "mile per yoctosecond"
                                                           , "mi/ys"
                                                           , FurlongPerZeptosecond
                                                           , 8.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per rontosecond. Defined as: ((8.0)/(1.0/1000.0)) × furlong per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerRontosecond = new (
                                                             "mile per rontosecond"
                                                           , "mi/rs"
                                                           , FurlongPerYoctosecond
                                                           , 8.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per quectosecond. Defined as: ((8.0)/(1.0/1000.0)) × furlong per rontosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerQuectosecond = new (
                                                              "mile per quectosecond"
                                                            , "mi/qs"
                                                            , FurlongPerRontosecond
                                                            , 8.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) inch per billion years. Defined as: ((2.54)/(1000.0)) × SI centimeter per million years + (0).
   /// </summary>
   public static readonly Velocity InchPerBillionYears = new (
                                                              "inch per billion years"
                                                            , "in/Gyr"
                                                            , SI.Velocities.CentimeterPerMillionYears
                                                            , 2.54 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) league per second. Defined as: ((3.0)/(1.0)) × mile per second + (0).
   /// </summary>
   public static readonly Velocity LeaguePerSecond = new ("league per second", "lea/s", MilePerSecond, 3.0 / 1.0, 0);

   /// <summary>
   /// A(n) league per decisecond. Defined as: ((3.0)/(1.0/10.0)) × mile per second + (0).
   /// </summary>
   public static readonly Velocity LeaguePerDecisecond =
            new ("league per decisecond", "lea/ds", MilePerSecond, 3.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) league per centisecond. Defined as: ((3.0)/(1.0/10.0)) × mile per decisecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerCentisecond =
            new ("league per centisecond", "lea/cs", MilePerDecisecond, 3.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) league per millisecond. Defined as: ((3.0)/(1.0/10.0)) × mile per centisecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerMillisecond =
            new ("league per millisecond", "lea/ms", MilePerCentisecond, 3.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) league per microsecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per millisecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerMicrosecond = new (
                                                               "league per microsecond"
                                                             , "lea/μs"
                                                             , MilePerMillisecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per nanosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per microsecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerNanosecond = new (
                                                              "league per nanosecond"
                                                            , "lea/ns"
                                                            , MilePerMicrosecond
                                                            , 3.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) league per picosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per nanosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerPicosecond =
            new ("league per picosecond", "lea/ps", MilePerNanosecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) league per femtosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per picosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerFemtosecond =
            new ("league per femtosecond", "lea/fs", MilePerPicosecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) league per attosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per femtosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerAttosecond = new (
                                                              "league per attosecond"
                                                            , "lea/as"
                                                            , MilePerFemtosecond
                                                            , 3.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) league per zeptosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per attosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerZeptosecond =
            new ("league per zeptosecond", "lea/zs", MilePerAttosecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) league per yoctosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerYoctosecond = new (
                                                               "league per yoctosecond"
                                                             , "lea/ys"
                                                             , MilePerZeptosecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per rontosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerRontosecond = new (
                                                               "league per rontosecond"
                                                             , "lea/rs"
                                                             , MilePerYoctosecond
                                                             , 3.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per quectosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per rontosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerQuectosecond = new (
                                                                "league per quectosecond"
                                                              , "lea/qs"
                                                              , MilePerRontosecond
                                                              , 3.0 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) inch per trillion years. Defined as: ((2.54)/(1000.0)) × SI centimeter per billion years + (0).
   /// </summary>
   public static readonly Velocity InchPerTrillionYears = new (
                                                               "inch per trillion years"
                                                             , "in/Tyr"
                                                             , SI.Velocities.CentimeterPerBillionYears
                                                             , 2.54 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) fathom per second. Defined as: ((6.0)/(1.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity FathomPerSecond = new ("fathom per second", "ftm/s", FootPerSecond, 6.0 / 1.0, 0);

   /// <summary>
   /// A(n) fathom per decisecond. Defined as: ((6.0)/(1.0/10.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity FathomPerDecisecond =
            new ("fathom per decisecond", "ftm/ds", FootPerSecond, 6.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) fathom per centisecond. Defined as: ((6.0)/(1.0/10.0)) × foot per decisecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerCentisecond =
            new ("fathom per centisecond", "ftm/cs", FootPerDecisecond, 6.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) fathom per millisecond. Defined as: ((6.0)/(1.0/10.0)) × foot per centisecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerMillisecond =
            new ("fathom per millisecond", "ftm/ms", FootPerCentisecond, 6.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) fathom per microsecond. Defined as: ((6.0)/(1.0/1000.0)) × foot per millisecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerMicrosecond = new (
                                                               "fathom per microsecond"
                                                             , "ftm/μs"
                                                             , FootPerMillisecond
                                                             , 6.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) fathom per nanosecond. Defined as: ((6.0)/(1.0/1000.0)) × foot per microsecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerNanosecond = new (
                                                              "fathom per nanosecond"
                                                            , "ftm/ns"
                                                            , FootPerMicrosecond
                                                            , 6.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) fathom per picosecond. Defined as: ((6.0)/(1.0/1000.0)) × foot per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerPicosecond =
            new ("fathom per picosecond", "ftm/ps", FootPerNanosecond, 6.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) fathom per femtosecond. Defined as: ((6.0)/(1.0/1000.0)) × foot per picosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerFemtosecond =
            new ("fathom per femtosecond", "ftm/fs", FootPerPicosecond, 6.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) fathom per attosecond. Defined as: ((6.0)/(1.0/1000.0)) × foot per femtosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerAttosecond = new (
                                                              "fathom per attosecond"
                                                            , "ftm/as"
                                                            , FootPerFemtosecond
                                                            , 6.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) fathom per zeptosecond. Defined as: ((6.0)/(1.0/1000.0)) × foot per attosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerZeptosecond =
            new ("fathom per zeptosecond", "ftm/zs", FootPerAttosecond, 6.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) fathom per yoctosecond. Defined as: ((6.0)/(1.0/1000.0)) × foot per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerYoctosecond = new (
                                                               "fathom per yoctosecond"
                                                             , "ftm/ys"
                                                             , FootPerZeptosecond
                                                             , 6.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) fathom per rontosecond. Defined as: ((6.0)/(1.0/1000.0)) × foot per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerRontosecond = new (
                                                               "fathom per rontosecond"
                                                             , "ftm/rs"
                                                             , FootPerYoctosecond
                                                             , 6.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) fathom per quectosecond. Defined as: ((6.0)/(1.0/1000.0)) × foot per rontosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerQuectosecond = new (
                                                                "fathom per quectosecond"
                                                              , "ftm/qs"
                                                              , FootPerRontosecond
                                                              , 6.0 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) inch per quadrillion years. Defined as: ((2.54)/(1000.0)) × SI centimeter per trillion years + (0).
   /// </summary>
   public static readonly Velocity InchPerQuadrillionYears = new (
                                                                  "inch per quadrillion years"
                                                                , "in/Pyr"
                                                                , SI.Velocities.CentimeterPerTrillionYears
                                                                , 2.54 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) cable per second. Defined as: ((100.0)/(1.0)) × fathom per second + (0).
   /// </summary>
   public static readonly Velocity CablePerSecond = new (
                                                         "cable per second"
                                                       , "cable/s"
                                                       , FathomPerSecond
                                                       , 100.0 / 1.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cable per decisecond. Defined as: ((100.0)/(1.0/10.0)) × fathom per second + (0).
   /// </summary>
   public static readonly Velocity CablePerDecisecond = new (
                                                             "cable per decisecond"
                                                           , "cable/ds"
                                                           , FathomPerSecond
                                                           , 100.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) cable per centisecond. Defined as: ((100.0)/(1.0/10.0)) × fathom per decisecond + (0).
   /// </summary>
   public static readonly Velocity CablePerCentisecond = new (
                                                              "cable per centisecond"
                                                            , "cable/cs"
                                                            , FathomPerDecisecond
                                                            , 100.0 / (1.0 / 10.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per millisecond. Defined as: ((100.0)/(1.0/10.0)) × fathom per centisecond + (0).
   /// </summary>
   public static readonly Velocity CablePerMillisecond = new (
                                                              "cable per millisecond"
                                                            , "cable/ms"
                                                            , FathomPerCentisecond
                                                            , 100.0 / (1.0 / 10.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per microsecond. Defined as: ((100.0)/(1.0/1000.0)) × fathom per millisecond + (0).
   /// </summary>
   public static readonly Velocity CablePerMicrosecond = new (
                                                              "cable per microsecond"
                                                            , "cable/μs"
                                                            , FathomPerMillisecond
                                                            , 100.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per nanosecond. Defined as: ((100.0)/(1.0/1000.0)) × fathom per microsecond + (0).
   /// </summary>
   public static readonly Velocity CablePerNanosecond = new (
                                                             "cable per nanosecond"
                                                           , "cable/ns"
                                                           , FathomPerMicrosecond
                                                           , 100.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) cable per picosecond. Defined as: ((100.0)/(1.0/1000.0)) × fathom per nanosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerPicosecond = new (
                                                             "cable per picosecond"
                                                           , "cable/ps"
                                                           , FathomPerNanosecond
                                                           , 100.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) cable per femtosecond. Defined as: ((100.0)/(1.0/1000.0)) × fathom per picosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerFemtosecond = new (
                                                              "cable per femtosecond"
                                                            , "cable/fs"
                                                            , FathomPerPicosecond
                                                            , 100.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per attosecond. Defined as: ((100.0)/(1.0/1000.0)) × fathom per femtosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerAttosecond = new (
                                                             "cable per attosecond"
                                                           , "cable/as"
                                                           , FathomPerFemtosecond
                                                           , 100.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) cable per zeptosecond. Defined as: ((100.0)/(1.0/1000.0)) × fathom per attosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerZeptosecond = new (
                                                              "cable per zeptosecond"
                                                            , "cable/zs"
                                                            , FathomPerAttosecond
                                                            , 100.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per yoctosecond. Defined as: ((100.0)/(1.0/1000.0)) × fathom per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerYoctosecond = new (
                                                              "cable per yoctosecond"
                                                            , "cable/ys"
                                                            , FathomPerZeptosecond
                                                            , 100.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per rontosecond. Defined as: ((100.0)/(1.0/1000.0)) × fathom per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerRontosecond = new (
                                                              "cable per rontosecond"
                                                            , "cable/rs"
                                                            , FathomPerYoctosecond
                                                            , 100.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per quectosecond. Defined as: ((100.0)/(1.0/1000.0)) × fathom per rontosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerQuectosecond = new (
                                                               "cable per quectosecond"
                                                             , "cable/qs"
                                                             , FathomPerRontosecond
                                                             , 100.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) inch per quintillion years. Defined as: ((2.54)/(1000.0)) × SI centimeter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity InchPerQuintillionYears = new (
                                                                  "inch per quintillion years"
                                                                , "in/Eyr"
                                                                , SI.Velocities.CentimeterPerQuadrillionYears
                                                                , 2.54 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) nautical mile per second. Defined as: ((10.0)/(1.0)) × cable per second + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSecond =
            new ("nautical mile per second", "nmi/s", CablePerSecond, 10.0 / 1.0, 0);

   /// <summary>
   /// A(n) nautical mile per decisecond. Defined as: ((10.0)/(1.0/10.0)) × cable per second + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecisecond =
            new ("nautical mile per decisecond", "nmi/ds", CablePerSecond, 10.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) nautical mile per centisecond. Defined as: ((10.0)/(1.0/10.0)) × cable per decisecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerCentisecond = new (
                                                                     "nautical mile per centisecond"
                                                                   , "nmi/cs"
                                                                   , CablePerDecisecond
                                                                   , 10.0 / (1.0 / 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per millisecond. Defined as: ((10.0)/(1.0/10.0)) × cable per centisecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillisecond = new (
                                                                     "nautical mile per millisecond"
                                                                   , "nmi/ms"
                                                                   , CablePerCentisecond
                                                                   , 10.0 / (1.0 / 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per microsecond. Defined as: ((10.0)/(1.0/1000.0)) × cable per millisecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMicrosecond = new (
                                                                     "nautical mile per microsecond"
                                                                   , "nmi/μs"
                                                                   , CablePerMillisecond
                                                                   , 10.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per nanosecond. Defined as: ((10.0)/(1.0/1000.0)) × cable per microsecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerNanosecond = new (
                                                                    "nautical mile per nanosecond"
                                                                  , "nmi/ns"
                                                                  , CablePerMicrosecond
                                                                  , 10.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nautical mile per picosecond. Defined as: ((10.0)/(1.0/1000.0)) × cable per nanosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerPicosecond = new (
                                                                    "nautical mile per picosecond"
                                                                  , "nmi/ps"
                                                                  , CablePerNanosecond
                                                                  , 10.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nautical mile per femtosecond. Defined as: ((10.0)/(1.0/1000.0)) × cable per picosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerFemtosecond = new (
                                                                     "nautical mile per femtosecond"
                                                                   , "nmi/fs"
                                                                   , CablePerPicosecond
                                                                   , 10.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per attosecond. Defined as: ((10.0)/(1.0/1000.0)) × cable per femtosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerAttosecond = new (
                                                                    "nautical mile per attosecond"
                                                                  , "nmi/as"
                                                                  , CablePerFemtosecond
                                                                  , 10.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nautical mile per zeptosecond. Defined as: ((10.0)/(1.0/1000.0)) × cable per attosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerZeptosecond = new (
                                                                     "nautical mile per zeptosecond"
                                                                   , "nmi/zs"
                                                                   , CablePerAttosecond
                                                                   , 10.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per yoctosecond. Defined as: ((10.0)/(1.0/1000.0)) × cable per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerYoctosecond = new (
                                                                     "nautical mile per yoctosecond"
                                                                   , "nmi/ys"
                                                                   , CablePerZeptosecond
                                                                   , 10.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per rontosecond. Defined as: ((10.0)/(1.0/1000.0)) × cable per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerRontosecond = new (
                                                                     "nautical mile per rontosecond"
                                                                   , "nmi/rs"
                                                                   , CablePerYoctosecond
                                                                   , 10.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per quectosecond. Defined as: ((10.0)/(1.0/1000.0)) × cable per rontosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuectosecond = new (
                                                                      "nautical mile per quectosecond"
                                                                    , "nmi/qs"
                                                                    , CablePerRontosecond
                                                                    , 10.0 / (1.0 / 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) inch per sextillion years. Defined as: ((2.54)/(1000.0)) × SI centimeter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity InchPerSextillionYears = new (
                                                                 "inch per sextillion years"
                                                               , "in/Zyr"
                                                               , SI.Velocities.CentimeterPerQuintillionYears
                                                               , 2.54 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) inch per septillion years. Defined as: ((2.54)/(1000.0)) × SI centimeter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity InchPerSeptillionYears = new (
                                                                 "inch per septillion years"
                                                               , "in/Yyr"
                                                               , SI.Velocities.CentimeterPerSextillionYears
                                                               , 2.54 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) inch per octillion years. Defined as: ((2.54)/(1000.0)) × SI centimeter per septillion years + (0).
   /// </summary>
   public static readonly Velocity InchPerOctillionYears = new (
                                                                "inch per octillion years"
                                                              , "in/Ryr"
                                                              , SI.Velocities.CentimeterPerSeptillionYears
                                                              , 2.54 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) inch per nonillion years. Defined as: ((2.54)/(1000.0)) × SI centimeter per octillion years + (0).
   /// </summary>
   public static readonly Velocity InchPerNonillionYears = new (
                                                                "inch per nonillion years"
                                                              , "in/Qyr"
                                                              , SI.Velocities.CentimeterPerOctillionYears
                                                              , 2.54 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) inch per decillion years. Defined as: ((2.54)/(1000.0)) × SI centimeter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity InchPerDecillionYears = new (
                                                                "inch per decillion years"
                                                              , "in/decillion yr"
                                                              , SI.Velocities.CentimeterPerNonillionYears
                                                              , 2.54 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) inch per planck-time. Defined as: ((2.54)/(5.391247E-38)) × SI centimeter per microsecond + (0).
   /// </summary>
   public static readonly Velocity InchPerPlanckTime = new (
                                                            "inch per planck-time"
                                                          , "in/tₚ"
                                                          , SI.Velocities.CentimeterPerMicrosecond
                                                          , 2.54 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) inch per tick. Defined as: ((2.54)/(100.0)) × SI centimeter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity InchPerTick = new (
                                                      "inch per tick"
                                                    , "in/tick"
                                                    , SI.Velocities.CentimeterPerNanosecond
                                                    , 2.54 / 100.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) foot per planck-time. Defined as: ((12)/(5.391247E-38)) × inch per microsecond + (0).
   /// </summary>
   public static readonly Velocity FootPerPlanckTime = new (
                                                            "foot per planck-time"
                                                          , "ft/tₚ"
                                                          , InchPerMicrosecond
                                                          , 12 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per minute. Defined as: ((12)/(60.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity FootPerMinute = new ("foot per minute", "ft/min", InchPerSecond, 12 / 60.0, 0);

   /// <summary>
   /// A(n) twip per planck-time. Defined as: ((1.0/17280.0)/(5.391247E-38)) × foot per microsecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerPlanckTime = new (
                                                            "twip per planck-time"
                                                          , "twip/tₚ"
                                                          , FootPerMicrosecond
                                                          , 1.0 / 17280.0 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) hand per septillion years. Defined as: ((4.0)/(1000.0)) × inch per sextillion years + (0).
   /// </summary>
   public static readonly Velocity HandPerSeptillionYears =
            new ("hand per septillion years", "hh/Yyr", InchPerSextillionYears, 4.0 / 1000.0, 0);

   /// <summary>
   /// A(n) thou per tick. Defined as: ((1.0/12000.0)/(100.0)) × foot per nanosecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerTick = new (
                                                      "thou per tick"
                                                    , "th/tick"
                                                    , FootPerNanosecond
                                                    , 1.0 / 12000.0 / 100.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) hand per week. Defined as: ((4.0)/(7.0)) × inch per day + (0).
   /// </summary>
   public static readonly Velocity HandPerWeek = new ("hand per week", "hh/wk", InchPerDay, 4.0 / 7.0, 0);

   /// <summary>
   /// A(n) thou per planck-time. Defined as: ((1.0/12000.0)/(5.391247E-38)) × foot per microsecond + (0).
   /// </summary>
   public static readonly Velocity ThouPerPlanckTime = new (
                                                            "thou per planck-time"
                                                          , "th/tₚ"
                                                          , FootPerMicrosecond
                                                          , 1.0 / 12000.0 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per hour. Defined as: ((12)/(60.0)) × inch per minute + (0).
   /// </summary>
   public static readonly Velocity FootPerHour = new ("foot per hour", "ft/hr", InchPerMinute, 12 / 60.0, 0);

   /// <summary>
   /// A(n) twip per minute. Defined as: ((1.0/17280.0)/(60.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity TwipPerMinute = new (
                                                        "twip per minute"
                                                      , "twip/min"
                                                      , FootPerSecond
                                                      , 1.0 / 17280.0 / 60.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) barleycorn per planck-time. Defined as: ((1.0/36.0)/(5.391247E-38)) × foot per microsecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerPlanckTime = new (
                                                                  "barleycorn per planck-time"
                                                                , "barleycorn/tₚ"
                                                                , FootPerMicrosecond
                                                                , 1.0 / 36.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yard per tick. Defined as: ((3.0)/(100.0)) × foot per nanosecond + (0).
   /// </summary>
   public static readonly Velocity YardPerTick = new ("yard per tick", "yd/tick", FootPerNanosecond, 3.0 / 100.0, 0);

   /// <summary>
   /// A(n) hand per planck-time. Defined as: ((4.0)/(5.391247E-38)) × inch per microsecond + (0).
   /// </summary>
   public static readonly Velocity HandPerPlanckTime = new (
                                                            "hand per planck-time"
                                                          , "hh/tₚ"
                                                          , InchPerMicrosecond
                                                          , 4.0 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per day. Defined as: ((12)/(24.0)) × inch per hour + (0).
   /// </summary>
   public static readonly Velocity FootPerDay = new ("foot per day", "ft/dy", InchPerHour, 12 / 24.0, 0);

   /// <summary>
   /// A(n) thou per minute. Defined as: ((1.0/12000.0)/(60.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity ThouPerMinute = new (
                                                        "thou per minute"
                                                      , "th/min"
                                                      , FootPerSecond
                                                      , 1.0 / 12000.0 / 60.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) hand per millennium. Defined as: ((4.0)/(10.0)) × inch per century + (0).
   /// </summary>
   public static readonly Velocity HandPerMillennium = new (
                                                            "hand per millennium"
                                                          , "hh/kyr"
                                                          , InchPerCentury
                                                          , 4.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) yard per planck-time. Defined as: ((3.0)/(5.391247E-38)) × foot per microsecond + (0).
   /// </summary>
   public static readonly Velocity YardPerPlanckTime = new (
                                                            "yard per planck-time"
                                                          , "yd/tₚ"
                                                          , FootPerMicrosecond
                                                          , 3.0 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) fathom per hour. Defined as: ((6.0)/(60.0)) × foot per minute + (0).
   /// </summary>
   public static readonly Velocity FathomPerHour = new ("fathom per hour", "ftm/hr", FootPerMinute, 6.0 / 60.0, 0);

   /// <summary>
   /// A(n) mile per tick. Defined as: ((8.0)/(100.0)) × furlong per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerTick = new ("mile per tick", "mi/tick", FurlongPerNanosecond, 8.0 / 100.0, 0);

   /// <summary>
   /// A(n) chain per planck-time. Defined as: ((22.0)/(5.391247E-38)) × yard per microsecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerPlanckTime = new (
                                                             "chain per planck-time"
                                                           , "ch/tₚ"
                                                           , YardPerMicrosecond
                                                           , 22.0 / 5.391247E-38
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per hour. Defined as: ((1.0/17280.0)/(60.0)) × foot per minute + (0).
   /// </summary>
   public static readonly Velocity TwipPerHour = new (
                                                      "twip per hour"
                                                    , "twip/hr"
                                                    , FootPerMinute
                                                    , 1.0 / 17280.0 / 60.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) foot per week. Defined as: ((12)/(7.0)) × inch per day + (0).
   /// </summary>
   public static readonly Velocity FootPerWeek = new ("foot per week", "ft/wk", InchPerDay, 12 / 7.0, 0);

   /// <summary>
   /// A(n) barleycorn per minute. Defined as: ((1.0/36.0)/(60.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerMinute = new (
                                                              "barleycorn per minute"
                                                            , "barleycorn/min"
                                                            , FootPerSecond
                                                            , 1.0 / 36.0 / 60.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) furlong per planck-time. Defined as: ((10.0)/(5.391247E-38)) × chain per microsecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerPlanckTime = new (
                                                               "furlong per planck-time"
                                                             , "fur/tₚ"
                                                             , ChainPerMicrosecond
                                                             , 10.0 / 5.391247E-38
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) hand per quadrillion years. Defined as: ((4.0)/(1000.0)) × inch per trillion years + (0).
   /// </summary>
   public static readonly Velocity HandPerQuadrillionYears =
            new ("hand per quadrillion years", "hh/Pyr", InchPerTrillionYears, 4.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per tick. Defined as: ((100.0)/(100.0)) × fathom per nanosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerTick = new (
                                                       "cable per tick"
                                                     , "cable/tick"
                                                     , FathomPerNanosecond
                                                     , 100.0 / 100.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) mile per planck-time. Defined as: ((8.0)/(5.391247E-38)) × furlong per microsecond + (0).
   /// </summary>
   public static readonly Velocity MilePerPlanckTime = new (
                                                            "mile per planck-time"
                                                          , "mi/tₚ"
                                                          , FurlongPerMicrosecond
                                                          , 8.0 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per year. Defined as: ((12)/(365.2525)) × inch per day + (0).
   /// </summary>
   public static readonly Velocity FootPerYear = new ("foot per year", "ft/yr", InchPerDay, 12 / 365.2525, 0);

   /// <summary>
   /// A(n) hand per minute. Defined as: ((4.0)/(60.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity HandPerMinute = new ("hand per minute", "hh/min", InchPerSecond, 4.0 / 60.0, 0);

   /// <summary>
   /// A(n) league per planck-time. Defined as: ((3.0)/(5.391247E-38)) × mile per microsecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerPlanckTime =
            new ("league per planck-time", "lea/tₚ", MilePerMicrosecond, 3.0 / 5.391247E-38, 0);

   /// <summary>
   /// A(n) barleycorn per decade. Defined as: ((1.0/36.0)/(10.0)) × foot per year + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerDecade = new (
                                                              "barleycorn per decade"
                                                            , "barleycorn/decade"
                                                            , FootPerYear
                                                            , 1.0 / 36.0 / 10.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) yard per week. Defined as: ((3.0)/(7.0)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity YardPerWeek = new ("yard per week", "yd/wk", FootPerDay, 3.0 / 7.0, 0);

   /// <summary>
   /// A(n) twip per day. Defined as: ((1.0/17280.0)/(24.0)) × foot per hour + (0).
   /// </summary>
   public static readonly Velocity TwipPerDay = new ("twip per day", "twip/dy", FootPerHour, 1.0 / 17280.0 / 24.0, 0);

   /// <summary>
   /// A(n) thou per hour. Defined as: ((1.0/12000.0)/(60.0)) × foot per minute + (0).
   /// </summary>
   public static readonly Velocity ThouPerHour = new ("thou per hour", "th/hr", FootPerMinute, 1.0 / 12000.0 / 60.0, 0);

   /// <summary>
   /// A(n) foot per decade. Defined as: ((12)/(10.0)) × inch per year + (0).
   /// </summary>
   public static readonly Velocity FootPerDecade = new ("foot per decade", "ft/decade", InchPerYear, 12 / 10.0, 0);

   /// <summary>
   /// A(n) yard per minute. Defined as: ((3.0)/(60.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity YardPerMinute = new ("yard per minute", "yd/min", FootPerSecond, 3.0 / 60.0, 0);

   /// <summary>
   /// A(n) fathom per planck-time. Defined as: ((6.0)/(5.391247E-38)) × foot per microsecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerPlanckTime =
            new ("fathom per planck-time", "ftm/tₚ", FootPerMicrosecond, 6.0 / 5.391247E-38, 0);

   /// <summary>
   /// A(n) hand per octillion years. Defined as: ((4.0)/(1000.0)) × inch per septillion years + (0).
   /// </summary>
   public static readonly Velocity HandPerOctillionYears =
            new ("hand per octillion years", "hh/Ryr", InchPerSeptillionYears, 4.0 / 1000.0, 0);

   /// <summary>
   /// A(n) hand per year. Defined as: ((4.0)/(365.2525)) × inch per day + (0).
   /// </summary>
   public static readonly Velocity HandPerYear = new ("hand per year", "hh/yr", InchPerDay, 4.0 / 365.2525, 0);

   /// <summary>
   /// A(n) foot per tick. Defined as: ((12)/(100.0)) × inch per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerTick = new ("foot per tick", "ft/tick", InchPerNanosecond, 12 / 100.0, 0);

   /// <summary>
   /// A(n) cable per planck-time. Defined as: ((100.0)/(5.391247E-38)) × fathom per microsecond + (0).
   /// </summary>
   public static readonly Velocity CablePerPlanckTime = new (
                                                             "cable per planck-time"
                                                           , "cable/tₚ"
                                                           , FathomPerMicrosecond
                                                           , 100.0 / 5.391247E-38
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per century. Defined as: ((12)/(10.0)) × inch per decade + (0).
   /// </summary>
   public static readonly Velocity FootPerCentury = new ("foot per century", "ft/century", InchPerDecade, 12 / 10.0, 0);

   /// <summary>
   /// A(n) chain per minute. Defined as: ((22.0)/(60.0)) × yard per second + (0).
   /// </summary>
   public static readonly Velocity ChainPerMinute = new ("chain per minute", "ch/min", YardPerSecond, 22.0 / 60.0, 0);

   /// <summary>
   /// A(n) fathom per week. Defined as: ((6.0)/(7.0)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity FathomPerWeek = new ("fathom per week", "ftm/wk", FootPerDay, 6.0 / 7.0, 0);

   /// <summary>
   /// A(n) nautical mile per planck-time. Defined as: ((10.0)/(5.391247E-38)) × cable per microsecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerPlanckTime = new (
                                                                    "nautical mile per planck-time"
                                                                  , "nmi/tₚ"
                                                                  , CablePerMicrosecond
                                                                  , 10.0 / 5.391247E-38
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) barleycorn per tick. Defined as: ((1.0/36.0)/(100.0)) × foot per nanosecond + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerTick = new (
                                                            "barleycorn per tick"
                                                          , "barleycorn/tick"
                                                          , FootPerNanosecond
                                                          , 1.0 / 36.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) twip per week. Defined as: ((1.0/17280.0)/(7.0)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity TwipPerWeek = new ("twip per week", "twip/wk", FootPerDay, 1.0 / 17280.0 / 7.0, 0);

   /// <summary>
   /// A(n) barleycorn per hour. Defined as: ((1.0/36.0)/(60.0)) × foot per minute + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerHour = new (
                                                            "barleycorn per hour"
                                                          , "barleycorn/hr"
                                                          , FootPerMinute
                                                          , 1.0 / 36.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per millennium. Defined as: ((12)/(10.0)) × inch per century + (0).
   /// </summary>
   public static readonly Velocity FootPerMillennium = new (
                                                            "foot per millennium"
                                                          , "ft/kyr"
                                                          , InchPerCentury
                                                          , 12 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) furlong per minute. Defined as: ((10.0)/(60.0)) × chain per second + (0).
   /// </summary>
   public static readonly Velocity FurlongPerMinute = new (
                                                           "furlong per minute"
                                                         , "fur/min"
                                                         , ChainPerSecond
                                                         , 10.0 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) hand per million years. Defined as: ((4.0)/(1000.0)) × inch per millennium + (0).
   /// </summary>
   public static readonly Velocity HandPerMillionYears =
            new ("hand per million years", "hh/Myr", InchPerMillennium, 4.0 / 1000.0, 0);

   /// <summary>
   /// A(n) thou per million years. Defined as: ((1.0/12000.0)/(1000.0)) × foot per millennium + (0).
   /// </summary>
   public static readonly Velocity ThouPerMillionYears = new (
                                                              "thou per million years"
                                                            , "th/Myr"
                                                            , FootPerMillennium
                                                            , 1.0 / 12000.0 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) chain per tick. Defined as: ((22.0)/(100.0)) × yard per nanosecond + (0).
   /// </summary>
   public static readonly Velocity ChainPerTick = new ("chain per tick", "ch/tick", YardPerNanosecond, 22.0 / 100.0, 0);

   /// <summary>
   /// A(n) thou per day. Defined as: ((1.0/12000.0)/(24.0)) × foot per hour + (0).
   /// </summary>
   public static readonly Velocity ThouPerDay = new ("thou per day", "th/dy", FootPerHour, 1.0 / 12000.0 / 24.0, 0);

   /// <summary>
   /// A(n) foot per million years. Defined as: ((12)/(1000.0)) × inch per millennium + (0).
   /// </summary>
   public static readonly Velocity FootPerMillionYears =
            new ("foot per million years", "ft/Myr", InchPerMillennium, 12 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per minute. Defined as: ((8.0)/(60.0)) × furlong per second + (0).
   /// </summary>
   public static readonly Velocity MilePerMinute = new ("mile per minute", "mi/min", FurlongPerSecond, 8.0 / 60.0, 0);

   /// <summary>
   /// A(n) barleycorn per century. Defined as: ((1.0/36.0)/(10.0)) × foot per decade + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerCentury = new (
                                                               "barleycorn per century"
                                                             , "barleycorn/century"
                                                             , FootPerDecade
                                                             , 1.0 / 36.0 / 10.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) hand per quintillion years. Defined as: ((4.0)/(1000.0)) × inch per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity HandPerQuintillionYears =
            new ("hand per quintillion years", "hh/Eyr", InchPerQuadrillionYears, 4.0 / 1000.0, 0);

   /// <summary>
   /// A(n) twip per year. Defined as: ((1.0/17280.0)/(365.2525)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity TwipPerYear = new (
                                                      "twip per year"
                                                    , "twip/yr"
                                                    , FootPerDay
                                                    , 1.0 / 17280.0 / 365.2525
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) hand per hour. Defined as: ((4.0)/(60.0)) × inch per minute + (0).
   /// </summary>
   public static readonly Velocity HandPerHour = new ("hand per hour", "hh/hr", InchPerMinute, 4.0 / 60.0, 0);

   /// <summary>
   /// A(n) foot per billion years. Defined as: ((12)/(1000.0)) × inch per million years + (0).
   /// </summary>
   public static readonly Velocity FootPerBillionYears =
            new ("foot per billion years", "ft/Gyr", InchPerMillionYears, 12 / 1000.0, 0);

   /// <summary>
   /// A(n) league per minute. Defined as: ((3.0)/(60.0)) × mile per second + (0).
   /// </summary>
   public static readonly Velocity LeaguePerMinute = new ("league per minute", "lea/min", MilePerSecond, 3.0 / 60.0, 0);

   /// <summary>
   /// A(n) league per tick. Defined as: ((3.0)/(100.0)) × mile per nanosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerTick = new (
                                                        "league per tick"
                                                      , "lea/tick"
                                                      , MilePerNanosecond
                                                      , 3.0 / 100.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) fathom per trillion years. Defined as: ((6.0)/(1000.0)) × foot per billion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerTrillionYears =
            new ("fathom per trillion years", "ftm/Tyr", FootPerBillionYears, 6.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yard per trillion years. Defined as: ((3.0)/(1000.0)) × foot per billion years + (0).
   /// </summary>
   public static readonly Velocity YardPerTrillionYears =
            new ("yard per trillion years", "yd/Tyr", FootPerBillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per decade. Defined as: ((6.0)/(10.0)) × foot per year + (0).
   /// </summary>
   public static readonly Velocity FathomPerDecade = new (
                                                          "fathom per decade"
                                                        , "ftm/decade"
                                                        , FootPerYear
                                                        , 6.0 / 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) foot per trillion years. Defined as: ((12)/(1000.0)) × inch per billion years + (0).
   /// </summary>
   public static readonly Velocity FootPerTrillionYears =
            new ("foot per trillion years", "ft/Tyr", InchPerBillionYears, 12 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per minute. Defined as: ((6.0)/(60.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity FathomPerMinute = new ("fathom per minute", "ftm/min", FootPerSecond, 6.0 / 60.0, 0);

   /// <summary>
   /// A(n) yard per millennium. Defined as: ((3.0)/(10.0)) × foot per century + (0).
   /// </summary>
   public static readonly Velocity YardPerMillennium = new (
                                                            "yard per millennium"
                                                          , "yd/kyr"
                                                          , FootPerCentury
                                                          , 3.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) barleycorn per quadrillion years. Defined as: ((1.0/36.0)/(1000.0)) × foot per trillion years + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerQuadrillionYears = new (
                                                                        "barleycorn per quadrillion years"
                                                                      , "barleycorn/Pyr"
                                                                      , FootPerTrillionYears
                                                                      , 1.0 / 36.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) hand per nonillion years. Defined as: ((4.0)/(1000.0)) × inch per octillion years + (0).
   /// </summary>
   public static readonly Velocity HandPerNonillionYears =
            new ("hand per nonillion years", "hh/Qyr", InchPerOctillionYears, 4.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nautical mile per tick. Defined as: ((10.0)/(100.0)) × cable per nanosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerTick =
            new ("nautical mile per tick", "nmi/tick", CablePerNanosecond, 10.0 / 100.0, 0);

   /// <summary>
   /// A(n) hand per decade. Defined as: ((4.0)/(10.0)) × inch per year + (0).
   /// </summary>
   public static readonly Velocity HandPerDecade = new ("hand per decade", "hh/decade", InchPerYear, 4.0 / 10.0, 0);

   /// <summary>
   /// A(n) yard per year. Defined as: ((3.0)/(365.2525)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity YardPerYear = new ("yard per year", "yd/yr", FootPerDay, 3.0 / 365.2525, 0);

   /// <summary>
   /// A(n) thou per billion years. Defined as: ((1.0/12000.0)/(1000.0)) × foot per million years + (0).
   /// </summary>
   public static readonly Velocity ThouPerBillionYears = new (
                                                              "thou per billion years"
                                                            , "th/Gyr"
                                                            , FootPerMillionYears
                                                            , 1.0 / 12000.0 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) thou per week. Defined as: ((1.0/12000.0)/(7.0)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity ThouPerWeek = new ("thou per week", "th/wk", FootPerDay, 1.0 / 12000.0 / 7.0, 0);

   /// <summary>
   /// A(n) barleycorn per day. Defined as: ((1.0/36.0)/(24.0)) × foot per hour + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerDay = new (
                                                           "barleycorn per day"
                                                         , "barleycorn/dy"
                                                         , FootPerHour
                                                         , 1.0 / 36.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) twip per decade. Defined as: ((1.0/17280.0)/(10.0)) × foot per year + (0).
   /// </summary>
   public static readonly Velocity TwipPerDecade = new (
                                                        "twip per decade"
                                                      , "twip/decade"
                                                      , FootPerYear
                                                      , 1.0 / 17280.0 / 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) yard per hour. Defined as: ((3.0)/(60.0)) × foot per minute + (0).
   /// </summary>
   public static readonly Velocity YardPerHour = new ("yard per hour", "yd/hr", FootPerMinute, 3.0 / 60.0, 0);

   /// <summary>
   /// A(n) foot per quadrillion years. Defined as: ((12)/(1000.0)) × inch per trillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerQuadrillionYears =
            new ("foot per quadrillion years", "ft/Pyr", InchPerTrillionYears, 12 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per minute. Defined as: ((100.0)/(60.0)) × fathom per second + (0).
   /// </summary>
   public static readonly Velocity CablePerMinute = new (
                                                         "cable per minute"
                                                       , "cable/min"
                                                       , FathomPerSecond
                                                       , 100.0 / 60.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) foot per quintillion years. Defined as: ((12)/(1000.0)) × inch per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerQuintillionYears =
            new ("foot per quintillion years", "ft/Eyr", InchPerQuadrillionYears, 12 / 1000.0, 0);

   /// <summary>
   /// A(n) nautical mile per minute. Defined as: ((10.0)/(60.0)) × cable per second + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMinute =
            new ("nautical mile per minute", "nmi/min", CablePerSecond, 10.0 / 60.0, 0);

   /// <summary>
   /// A(n) hand per billion years. Defined as: ((4.0)/(1000.0)) × inch per million years + (0).
   /// </summary>
   public static readonly Velocity HandPerBillionYears =
            new ("hand per billion years", "hh/Gyr", InchPerMillionYears, 4.0 / 1000.0, 0);

   /// <summary>
   /// A(n) twip per tick. Defined as: ((1.0/17280.0)/(100.0)) × foot per nanosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerTick = new (
                                                      "twip per tick"
                                                    , "twip/tick"
                                                    , FootPerNanosecond
                                                    , 1.0 / 17280.0 / 100.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) barleycorn per millennium. Defined as: ((1.0/36.0)/(10.0)) × foot per century + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerMillennium = new (
                                                                  "barleycorn per millennium"
                                                                , "barleycorn/kyr"
                                                                , FootPerCentury
                                                                , 1.0 / 36.0 / 10.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) fathom per quintillion years. Defined as: ((6.0)/(1000.0)) × foot per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerQuintillionYears = new (
                                                                    "fathom per quintillion years"
                                                                  , "ftm/Eyr"
                                                                  , FootPerQuadrillionYears
                                                                  , 6.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) twip per century. Defined as: ((1.0/17280.0)/(10.0)) × foot per decade + (0).
   /// </summary>
   public static readonly Velocity TwipPerCentury = new (
                                                         "twip per century"
                                                       , "twip/century"
                                                       , FootPerDecade
                                                       , 1.0 / 17280.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) chain per hour. Defined as: ((22.0)/(60.0)) × yard per minute + (0).
   /// </summary>
   public static readonly Velocity ChainPerHour = new ("chain per hour", "ch/hr", YardPerMinute, 22.0 / 60.0, 0);

   /// <summary>
   /// A(n) foot per sextillion years. Defined as: ((12)/(1000.0)) × inch per quintillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerSextillionYears =
            new ("foot per sextillion years", "ft/Zyr", InchPerQuintillionYears, 12 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per millennium. Defined as: ((6.0)/(10.0)) × foot per century + (0).
   /// </summary>
   public static readonly Velocity FathomPerMillennium =
            new ("fathom per millennium", "ftm/kyr", FootPerCentury, 6.0 / 10.0, 0);

   /// <summary>
   /// A(n) hand per tick. Defined as: ((4.0)/(100.0)) × inch per nanosecond + (0).
   /// </summary>
   public static readonly Velocity HandPerTick = new ("hand per tick", "hh/tick", InchPerNanosecond, 4.0 / 100.0, 0);

   /// <summary>
   /// A(n) thou per trillion years. Defined as: ((1.0/12000.0)/(1000.0)) × foot per billion years + (0).
   /// </summary>
   public static readonly Velocity ThouPerTrillionYears = new (
                                                               "thou per trillion years"
                                                             , "th/Tyr"
                                                             , FootPerBillionYears
                                                             , 1.0 / 12000.0 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) fathom per day. Defined as: ((6.0)/(24.0)) × foot per hour + (0).
   /// </summary>
   public static readonly Velocity FathomPerDay = new ("fathom per day", "ftm/dy", FootPerHour, 6.0 / 24.0, 0);

   /// <summary>
   /// A(n) hand per sextillion years. Defined as: ((4.0)/(1000.0)) × inch per quintillion years + (0).
   /// </summary>
   public static readonly Velocity HandPerSextillionYears =
            new ("hand per sextillion years", "hh/Zyr", InchPerQuintillionYears, 4.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per quadrillion years. Defined as: ((100.0)/(1000.0)) × fathom per trillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerQuadrillionYears = new (
                                                                   "cable per quadrillion years"
                                                                 , "cable/Pyr"
                                                                 , FathomPerTrillionYears
                                                                 , 100.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) thou per year. Defined as: ((1.0/12000.0)/(365.2525)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity ThouPerYear = new (
                                                      "thou per year"
                                                    , "th/yr"
                                                    , FootPerDay
                                                    , 1.0 / 12000.0 / 365.2525
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) hand per day. Defined as: ((4.0)/(24.0)) × inch per hour + (0).
   /// </summary>
   public static readonly Velocity HandPerDay = new ("hand per day", "hh/dy", InchPerHour, 4.0 / 24.0, 0);

   /// <summary>
   /// A(n) foot per septillion years. Defined as: ((12)/(1000.0)) × inch per sextillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerSeptillionYears =
            new ("foot per septillion years", "ft/Yyr", InchPerSextillionYears, 12 / 1000.0, 0);

   /// <summary>
   /// A(n) barleycorn per quintillion years. Defined as: ((1.0/36.0)/(1000.0)) × foot per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerQuintillionYears = new (
                                                                        "barleycorn per quintillion years"
                                                                      , "barleycorn/Eyr"
                                                                      , FootPerQuadrillionYears
                                                                      , 1.0 / 36.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) furlong per tick. Defined as: ((10.0)/(100.0)) × chain per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FurlongPerTick = new (
                                                         "furlong per tick"
                                                       , "fur/tick"
                                                       , ChainPerNanosecond
                                                       , 10.0 / 100.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cable per million years. Defined as: ((100.0)/(1000.0)) × fathom per millennium + (0).
   /// </summary>
   public static readonly Velocity CablePerMillionYears =
            new ("cable per million years", "cable/Myr", FathomPerMillennium, 100.0 / 1000.0, 0);

   /// <summary>
   /// A(n) barleycorn per week. Defined as: ((1.0/36.0)/(7.0)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerWeek = new (
                                                            "barleycorn per week"
                                                          , "barleycorn/wk"
                                                          , FootPerDay
                                                          , 1.0 / 36.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) twip per millennium. Defined as: ((1.0/17280.0)/(10.0)) × foot per century + (0).
   /// </summary>
   public static readonly Velocity TwipPerMillennium = new (
                                                            "twip per millennium"
                                                          , "twip/kyr"
                                                          , FootPerCentury
                                                          , 1.0 / 17280.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) furlong per hour. Defined as: ((10.0)/(60.0)) × chain per minute + (0).
   /// </summary>
   public static readonly Velocity FurlongPerHour = new ("furlong per hour", "fur/hr", ChainPerMinute, 10.0 / 60.0, 0);

   /// <summary>
   /// A(n) foot per octillion years. Defined as: ((12)/(1000.0)) × inch per septillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerOctillionYears =
            new ("foot per octillion years", "ft/Ryr", InchPerSeptillionYears, 12 / 1000.0, 0);

   /// <summary>
   /// A(n) yard per septillion years. Defined as: ((3.0)/(1000.0)) × foot per sextillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerSeptillionYears =
            new ("yard per septillion years", "yd/Yyr", FootPerSextillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) hand per decillion years. Defined as: ((4.0)/(1000.0)) × inch per nonillion years + (0).
   /// </summary>
   public static readonly Velocity HandPerDecillionYears = new (
                                                                "hand per decillion years"
                                                              , "hh/decillion yr"
                                                              , InchPerNonillionYears
                                                              , 4.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) hand per century. Defined as: ((4.0)/(10.0)) × inch per decade + (0).
   /// </summary>
   public static readonly Velocity HandPerCentury = new (
                                                         "hand per century"
                                                       , "hh/century"
                                                       , InchPerDecade
                                                       , 4.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) yard per quadrillion years. Defined as: ((3.0)/(1000.0)) × foot per trillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerQuadrillionYears =
            new ("yard per quadrillion years", "yd/Pyr", FootPerTrillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per tick. Defined as: ((6.0)/(100.0)) × foot per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerTick = new (
                                                        "fathom per tick"
                                                      , "ftm/tick"
                                                      , FootPerNanosecond
                                                      , 6.0 / 100.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) foot per nonillion years. Defined as: ((12)/(1000.0)) × inch per octillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerNonillionYears =
            new ("foot per nonillion years", "ft/Qyr", InchPerOctillionYears, 12 / 1000.0, 0);

   /// <summary>
   /// A(n) yard per million years. Defined as: ((3.0)/(1000.0)) × foot per millennium + (0).
   /// </summary>
   public static readonly Velocity YardPerMillionYears =
            new ("yard per million years", "yd/Myr", FootPerMillennium, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) thou per decillion years. Defined as: ((1.0/12000.0)/(1000.0)) × foot per nonillion years + (0).
   /// </summary>
   public static readonly Velocity ThouPerDecillionYears = new (
                                                                "thou per decillion years"
                                                              , "th/decillion yr"
                                                              , FootPerNonillionYears
                                                              , 1.0 / 12000.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) chain per quintillion years. Defined as: ((22.0)/(1000.0)) × yard per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity ChainPerQuintillionYears = new (
                                                                   "chain per quintillion years"
                                                                 , "ch/Eyr"
                                                                 , YardPerQuadrillionYears
                                                                 , 22.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) fathom per septillion years. Defined as: ((6.0)/(1000.0)) × foot per sextillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerSeptillionYears =
            new ("fathom per septillion years", "ftm/Yyr", FootPerSextillionYears, 6.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yard per decade. Defined as: ((3.0)/(10.0)) × foot per year + (0).
   /// </summary>
   public static readonly Velocity YardPerDecade = new ("yard per decade", "yd/decade", FootPerYear, 3.0 / 10.0, 0);

   /// <summary>
   /// A(n) barleycorn per million years. Defined as: ((1.0/36.0)/(1000.0)) × foot per millennium + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerMillionYears = new (
                                                                    "barleycorn per million years"
                                                                  , "barleycorn/Myr"
                                                                  , FootPerMillennium
                                                                  , 1.0 / 36.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) thou per quadrillion years. Defined as: ((1.0/12000.0)/(1000.0)) × foot per trillion years + (0).
   /// </summary>
   public static readonly Velocity ThouPerQuadrillionYears = new (
                                                                  "thou per quadrillion years"
                                                                , "th/Pyr"
                                                                , FootPerTrillionYears
                                                                , 1.0 / 12000.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) cable per day. Defined as: ((100.0)/(24.0)) × fathom per hour + (0).
   /// </summary>
   public static readonly Velocity CablePerDay = new ("cable per day", "cable/dy", FathomPerHour, 100.0 / 24.0, 0);

   /// <summary>
   /// A(n) twip per decillion years. Defined as: ((1.0/17280.0)/(1000.0)) × foot per nonillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerDecillionYears = new (
                                                                "twip per decillion years"
                                                              , "twip/decillion yr"
                                                              , FootPerNonillionYears
                                                              , 1.0 / 17280.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) fathom per billion years. Defined as: ((6.0)/(1000.0)) × foot per million years + (0).
   /// </summary>
   public static readonly Velocity FathomPerBillionYears =
            new ("fathom per billion years", "ftm/Gyr", FootPerMillionYears, 6.0 / 1000.0, 0);

   /// <summary>
   /// A(n) thou per decade. Defined as: ((1.0/12000.0)/(10.0)) × foot per year + (0).
   /// </summary>
   public static readonly Velocity ThouPerDecade = new (
                                                        "thou per decade"
                                                      , "th/decade"
                                                      , FootPerYear
                                                      , 1.0 / 12000.0 / 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) yard per day. Defined as: ((3.0)/(24.0)) × foot per hour + (0).
   /// </summary>
   public static readonly Velocity YardPerDay = new ("yard per day", "yd/dy", FootPerHour, 3.0 / 24.0, 0);

   /// <summary>
   /// A(n) twip per million years. Defined as: ((1.0/17280.0)/(1000.0)) × foot per millennium + (0).
   /// </summary>
   public static readonly Velocity TwipPerMillionYears = new (
                                                              "twip per million years"
                                                            , "twip/Myr"
                                                            , FootPerMillennium
                                                            , 1.0 / 17280.0 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) mile per hour. Defined as: ((8.0)/(60.0)) × furlong per minute + (0).
   /// </summary>
   public static readonly Velocity MilePerHour = new ("mile per hour", "mi/hr", FurlongPerMinute, 8.0 / 60.0, 0);

   /// <summary>
   /// A(n) foot per decillion years. Defined as: ((12)/(1000.0)) × inch per nonillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerDecillionYears = new (
                                                                "foot per decillion years"
                                                              , "ft/decillion yr"
                                                              , InchPerNonillionYears
                                                              , 12 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) hand per trillion years. Defined as: ((4.0)/(1000.0)) × inch per billion years + (0).
   /// </summary>
   public static readonly Velocity HandPerTrillionYears =
            new ("hand per trillion years", "hh/Tyr", InchPerBillionYears, 4.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per year. Defined as: ((6.0)/(365.2525)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity FathomPerYear = new ("fathom per year", "ftm/yr", FootPerDay, 6.0 / 365.2525, 0);

   /// <summary>
   /// A(n) barleycorn per sextillion years. Defined as: ((1.0/36.0)/(1000.0)) × foot per quintillion years + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerSextillionYears = new (
                                                                       "barleycorn per sextillion years"
                                                                     , "barleycorn/Zyr"
                                                                     , FootPerQuintillionYears
                                                                     , 1.0 / 36.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) nautical mile per billion years. Defined as: ((10.0)/(1000.0)) × cable per million years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerBillionYears = new (
                                                                      "nautical mile per billion years"
                                                                    , "nmi/Gyr"
                                                                    , CablePerMillionYears
                                                                    , 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) furlong per sextillion years. Defined as: ((10.0)/(1000.0)) × chain per quintillion years + (0).
   /// </summary>
   public static readonly Velocity FurlongPerSextillionYears = new (
                                                                    "furlong per sextillion years"
                                                                  , "fur/Zyr"
                                                                  , ChainPerQuintillionYears
                                                                  , 10.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) chain per octillion years. Defined as: ((22.0)/(1000.0)) × yard per septillion years + (0).
   /// </summary>
   public static readonly Velocity ChainPerOctillionYears =
            new ("chain per octillion years", "ch/Ryr", YardPerSeptillionYears, 22.0 / 1000.0, 0);

   /// <summary>
   /// A(n) barleycorn per year. Defined as: ((1.0/36.0)/(365.2525)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerYear = new (
                                                            "barleycorn per year"
                                                          , "barleycorn/yr"
                                                          , FootPerDay
                                                          , 1.0 / 36.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) twip per billion years. Defined as: ((1.0/17280.0)/(1000.0)) × foot per million years + (0).
   /// </summary>
   public static readonly Velocity TwipPerBillionYears = new (
                                                              "twip per billion years"
                                                            , "twip/Gyr"
                                                            , FootPerMillionYears
                                                            , 1.0 / 17280.0 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) league per hour. Defined as: ((3.0)/(60.0)) × mile per minute + (0).
   /// </summary>
   public static readonly Velocity LeaguePerHour = new ("league per hour", "lea/hr", MilePerMinute, 3.0 / 60.0, 0);

   /// <summary>
   /// A(n) cable per sextillion years. Defined as: ((100.0)/(1000.0)) × fathom per quintillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerSextillionYears = new (
                                                                  "cable per sextillion years"
                                                                , "cable/Zyr"
                                                                , FathomPerQuintillionYears
                                                                , 100.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) thou per quintillion years. Defined as: ((1.0/12000.0)/(1000.0)) × foot per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity ThouPerQuintillionYears = new (
                                                                  "thou per quintillion years"
                                                                , "th/Eyr"
                                                                , FootPerQuadrillionYears
                                                                , 1.0 / 12000.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) fathom per nonillion years. Defined as: ((6.0)/(1000.0)) × foot per octillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerNonillionYears =
            new ("fathom per nonillion years", "ftm/Qyr", FootPerOctillionYears, 6.0 / 1000.0, 0);

   /// <summary>
   /// A(n) thou per century. Defined as: ((1.0/12000.0)/(10.0)) × foot per decade + (0).
   /// </summary>
   public static readonly Velocity ThouPerCentury = new (
                                                         "thou per century"
                                                       , "th/century"
                                                       , FootPerDecade
                                                       , 1.0 / 12000.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) chain per day. Defined as: ((22.0)/(24.0)) × yard per hour + (0).
   /// </summary>
   public static readonly Velocity ChainPerDay = new ("chain per day", "ch/dy", YardPerHour, 22.0 / 24.0, 0);

   /// <summary>
   /// A(n) fathom per quadrillion years. Defined as: ((6.0)/(1000.0)) × foot per trillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerQuadrillionYears =
            new ("fathom per quadrillion years", "ftm/Pyr", FootPerTrillionYears, 6.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per trillion years. Defined as: ((100.0)/(1000.0)) × fathom per billion years + (0).
   /// </summary>
   public static readonly Velocity CablePerTrillionYears = new (
                                                                "cable per trillion years"
                                                              , "cable/Tyr"
                                                              , FathomPerBillionYears
                                                              , 100.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) nautical mile per quintillion years. Defined as: ((10.0)/(1000.0)) × cable per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuintillionYears = new (
                                                                          "nautical mile per quintillion years"
                                                                        , "nmi/Eyr"
                                                                        , CablePerQuadrillionYears
                                                                        , 10.0 / 1000.0
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per year. Defined as: ((10.0)/(365.2525)) × chain per day + (0).
   /// </summary>
   public static readonly Velocity FurlongPerYear = new ("furlong per year", "fur/yr", ChainPerDay, 10.0 / 365.2525, 0);

   /// <summary>
   /// A(n) barleycorn per billion years. Defined as: ((1.0/36.0)/(1000.0)) × foot per million years + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerBillionYears = new (
                                                                    "barleycorn per billion years"
                                                                  , "barleycorn/Gyr"
                                                                  , FootPerMillionYears
                                                                  , 1.0 / 36.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) fathom per century. Defined as: ((6.0)/(10.0)) × foot per decade + (0).
   /// </summary>
   public static readonly Velocity FathomPerCentury = new (
                                                           "fathom per century"
                                                         , "ftm/century"
                                                         , FootPerDecade
                                                         , 6.0 / 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) twip per trillion years. Defined as: ((1.0/17280.0)/(1000.0)) × foot per billion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerTrillionYears = new (
                                                               "twip per trillion years"
                                                             , "twip/Tyr"
                                                             , FootPerBillionYears
                                                             , 1.0 / 17280.0 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) cable per millennium. Defined as: ((100.0)/(10.0)) × fathom per century + (0).
   /// </summary>
   public static readonly Velocity CablePerMillennium = new (
                                                             "cable per millennium"
                                                           , "cable/kyr"
                                                           , FathomPerCentury
                                                           , 100.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) yard per octillion years. Defined as: ((3.0)/(1000.0)) × foot per septillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerOctillionYears =
            new ("yard per octillion years", "yd/Ryr", FootPerSeptillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yard per quintillion years. Defined as: ((3.0)/(1000.0)) × foot per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerQuintillionYears =
            new ("yard per quintillion years", "yd/Eyr", FootPerQuadrillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yard per billion years. Defined as: ((3.0)/(1000.0)) × foot per million years + (0).
   /// </summary>
   public static readonly Velocity YardPerBillionYears =
            new ("yard per billion years", "yd/Gyr", FootPerMillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per year. Defined as: ((100.0)/(365.2525)) × fathom per day + (0).
   /// </summary>
   public static readonly Velocity CablePerYear = new ("cable per year", "cable/yr", FathomPerDay, 100.0 / 365.2525, 0);

   /// <summary>
   /// A(n) barleycorn per septillion years. Defined as: ((1.0/36.0)/(1000.0)) × foot per sextillion years + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerSeptillionYears = new (
                                                                       "barleycorn per septillion years"
                                                                     , "barleycorn/Yyr"
                                                                     , FootPerSextillionYears
                                                                     , 1.0 / 36.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yard per century. Defined as: ((3.0)/(10.0)) × foot per decade + (0).
   /// </summary>
   public static readonly Velocity YardPerCentury = new (
                                                         "yard per century"
                                                       , "yd/century"
                                                       , FootPerDecade
                                                       , 3.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) chain per decade. Defined as: ((22.0)/(10.0)) × yard per year + (0).
   /// </summary>
   public static readonly Velocity ChainPerDecade = new ("chain per decade", "ch/decade", YardPerYear, 22.0 / 10.0, 0);

   /// <summary>
   /// A(n) thou per sextillion years. Defined as: ((1.0/12000.0)/(1000.0)) × foot per quintillion years + (0).
   /// </summary>
   public static readonly Velocity ThouPerSextillionYears = new (
                                                                 "thou per sextillion years"
                                                               , "th/Zyr"
                                                               , FootPerQuintillionYears
                                                               , 1.0 / 12000.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) thou per millennium. Defined as: ((1.0/12000.0)/(10.0)) × foot per century + (0).
   /// </summary>
   public static readonly Velocity ThouPerMillennium = new (
                                                            "thou per millennium"
                                                          , "th/kyr"
                                                          , FootPerCentury
                                                          , 1.0 / 12000.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) furlong per day. Defined as: ((10.0)/(24.0)) × chain per hour + (0).
   /// </summary>
   public static readonly Velocity FurlongPerDay = new ("furlong per day", "fur/dy", ChainPerHour, 10.0 / 24.0, 0);

   /// <summary>
   /// A(n) twip per quadrillion years. Defined as: ((1.0/17280.0)/(1000.0)) × foot per trillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerQuadrillionYears = new (
                                                                  "twip per quadrillion years"
                                                                , "twip/Pyr"
                                                                , FootPerTrillionYears
                                                                , 1.0 / 17280.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) cable per hour. Defined as: ((100.0)/(60.0)) × fathom per minute + (0).
   /// </summary>
   public static readonly Velocity CablePerHour = new ("cable per hour", "cable/hr", FathomPerMinute, 100.0 / 60.0, 0);

   /// <summary>
   /// A(n) chain per sextillion years. Defined as: ((22.0)/(1000.0)) × yard per quintillion years + (0).
   /// </summary>
   public static readonly Velocity ChainPerSextillionYears = new (
                                                                  "chain per sextillion years"
                                                                , "ch/Zyr"
                                                                , YardPerQuintillionYears
                                                                , 22.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) mile per septillion years. Defined as: ((8.0)/(1000.0)) × furlong per sextillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerSeptillionYears = new (
                                                                 "mile per septillion years"
                                                               , "mi/Yyr"
                                                               , FurlongPerSextillionYears
                                                               , 8.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) nautical mile per million years. Defined as: ((10.0)/(1000.0)) × cable per millennium + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillionYears =
            new ("nautical mile per million years", "nmi/Myr", CablePerMillennium, 10.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per sextillion years. Defined as: ((6.0)/(1000.0)) × foot per quintillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerSextillionYears = new (
                                                                   "fathom per sextillion years"
                                                                 , "ftm/Zyr"
                                                                 , FootPerQuintillionYears
                                                                 , 6.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) fathom per million years. Defined as: ((6.0)/(1000.0)) × foot per millennium + (0).
   /// </summary>
   public static readonly Velocity FathomPerMillionYears =
            new ("fathom per million years", "ftm/Myr", FootPerMillennium, 6.0 / 1000.0, 0);

   /// <summary>
   /// A(n) furlong per nonillion years. Defined as: ((10.0)/(1000.0)) × chain per octillion years + (0).
   /// </summary>
   public static readonly Velocity FurlongPerNonillionYears = new (
                                                                   "furlong per nonillion years"
                                                                 , "fur/Qyr"
                                                                 , ChainPerOctillionYears
                                                                 , 10.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) barleycorn per trillion years. Defined as: ((1.0/36.0)/(1000.0)) × foot per billion years + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerTrillionYears = new (
                                                                     "barleycorn per trillion years"
                                                                   , "barleycorn/Tyr"
                                                                   , FootPerBillionYears
                                                                   , 1.0 / 36.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) cable per octillion years. Defined as: ((100.0)/(1000.0)) × fathom per septillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerOctillionYears = new (
                                                                 "cable per octillion years"
                                                               , "cable/Ryr"
                                                               , FathomPerSeptillionYears
                                                               , 100.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) twip per quintillion years. Defined as: ((1.0/17280.0)/(1000.0)) × foot per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerQuintillionYears = new (
                                                                  "twip per quintillion years"
                                                                , "twip/Eyr"
                                                                , FootPerQuadrillionYears
                                                                , 1.0 / 17280.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) nautical mile per hour. Defined as: ((10.0)/(60.0)) × cable per minute + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerHour =
            new ("nautical mile per hour", "nmi/hr", CablePerMinute, 10.0 / 60.0, 0);

   /// <summary>
   /// A(n) chain per million years. Defined as: ((22.0)/(1000.0)) × yard per millennium + (0).
   /// </summary>
   public static readonly Velocity ChainPerMillionYears =
            new ("chain per million years", "ch/Myr", YardPerMillennium, 22.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per year. Defined as: ((8.0)/(365.2525)) × furlong per day + (0).
   /// </summary>
   public static readonly Velocity MilePerYear = new ("mile per year", "mi/yr", FurlongPerDay, 8.0 / 365.2525, 0);

   /// <summary>
   /// A(n) thou per septillion years. Defined as: ((1.0/12000.0)/(1000.0)) × foot per sextillion years + (0).
   /// </summary>
   public static readonly Velocity ThouPerSeptillionYears = new (
                                                                 "thou per septillion years"
                                                               , "th/Yyr"
                                                               , FootPerSextillionYears
                                                               , 1.0 / 12000.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) chain per nonillion years. Defined as: ((22.0)/(1000.0)) × yard per octillion years + (0).
   /// </summary>
   public static readonly Velocity ChainPerNonillionYears =
            new ("chain per nonillion years", "ch/Qyr", YardPerOctillionYears, 22.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per quintillion years. Defined as: ((100.0)/(1000.0)) × fathom per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerQuintillionYears = new (
                                                                   "cable per quintillion years"
                                                                 , "cable/Eyr"
                                                                 , FathomPerQuadrillionYears
                                                                 , 100.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nautical mile per quadrillion years. Defined as: ((10.0)/(1000.0)) × cable per trillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuadrillionYears = new (
                                                                          "nautical mile per quadrillion years"
                                                                        , "nmi/Pyr"
                                                                        , CablePerTrillionYears
                                                                        , 10.0 / 1000.0
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) mile per day. Defined as: ((8.0)/(24.0)) × furlong per hour + (0).
   /// </summary>
   public static readonly Velocity MilePerDay = new ("mile per day", "mi/dy", FurlongPerHour, 8.0 / 24.0, 0);

   /// <summary>
   /// A(n) barleycorn per octillion years. Defined as: ((1.0/36.0)/(1000.0)) × foot per septillion years + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerOctillionYears = new (
                                                                      "barleycorn per octillion years"
                                                                    , "barleycorn/Ryr"
                                                                    , FootPerSeptillionYears
                                                                    , 1.0 / 36.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) cable per billion years. Defined as: ((100.0)/(1000.0)) × fathom per million years + (0).
   /// </summary>
   public static readonly Velocity CablePerBillionYears = new (
                                                               "cable per billion years"
                                                             , "cable/Gyr"
                                                             , FathomPerMillionYears
                                                             , 100.0 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per septillion years. Defined as: ((10.0)/(1000.0)) × chain per sextillion years + (0).
   /// </summary>
   public static readonly Velocity FurlongPerSeptillionYears = new (
                                                                    "furlong per septillion years"
                                                                  , "fur/Yyr"
                                                                  , ChainPerSextillionYears
                                                                  , 10.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) chain per week. Defined as: ((22.0)/(7.0)) × yard per day + (0).
   /// </summary>
   public static readonly Velocity ChainPerWeek = new ("chain per week", "ch/wk", YardPerDay, 22.0 / 7.0, 0);

   /// <summary>
   /// A(n) twip per sextillion years. Defined as: ((1.0/17280.0)/(1000.0)) × foot per quintillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerSextillionYears = new (
                                                                 "twip per sextillion years"
                                                               , "twip/Zyr"
                                                               , FootPerQuintillionYears
                                                               , 1.0 / 17280.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) nautical mile per year. Defined as: ((10.0)/(365.2525)) × cable per day + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerYear =
            new ("nautical mile per year", "nmi/yr", CablePerDay, 10.0 / 365.2525, 0);

   /// <summary>
   /// A(n) yard per nonillion years. Defined as: ((3.0)/(1000.0)) × foot per octillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerNonillionYears =
            new ("yard per nonillion years", "yd/Qyr", FootPerOctillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per octillion years. Defined as: ((6.0)/(1000.0)) × foot per septillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerOctillionYears =
            new ("fathom per octillion years", "ftm/Ryr", FootPerSeptillionYears, 6.0 / 1000.0, 0);

   /// <summary>
   /// A(n) chain per quadrillion years. Defined as: ((22.0)/(1000.0)) × yard per trillion years + (0).
   /// </summary>
   public static readonly Velocity ChainPerQuadrillionYears =
            new ("chain per quadrillion years", "ch/Pyr", YardPerTrillionYears, 22.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per century. Defined as: ((100.0)/(10.0)) × fathom per decade + (0).
   /// </summary>
   public static readonly Velocity CablePerCentury = new (
                                                          "cable per century"
                                                        , "cable/century"
                                                        , FathomPerDecade
                                                        , 100.0 / 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) yard per sextillion years. Defined as: ((3.0)/(1000.0)) × foot per quintillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerSextillionYears =
            new ("yard per sextillion years", "yd/Zyr", FootPerQuintillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nautical mile per septillion years. Defined as: ((10.0)/(1000.0)) × cable per sextillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSeptillionYears = new (
                                                                         "nautical mile per septillion years"
                                                                       , "nmi/Yyr"
                                                                       , CablePerSextillionYears
                                                                       , 10.0 / 1000.0
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) cable per week. Defined as: ((100.0)/(7.0)) × fathom per day + (0).
   /// </summary>
   public static readonly Velocity CablePerWeek = new ("cable per week", "cable/wk", FathomPerDay, 100.0 / 7.0, 0);

   /// <summary>
   /// A(n) thou per octillion years. Defined as: ((1.0/12000.0)/(1000.0)) × foot per septillion years + (0).
   /// </summary>
   public static readonly Velocity ThouPerOctillionYears = new (
                                                                "thou per octillion years"
                                                              , "th/Ryr"
                                                              , FootPerSeptillionYears
                                                              , 1.0 / 12000.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) league per day. Defined as: ((3.0)/(24.0)) × mile per hour + (0).
   /// </summary>
   public static readonly Velocity LeaguePerDay = new ("league per day", "lea/dy", MilePerHour, 3.0 / 24.0, 0);

   /// <summary>
   /// A(n) twip per septillion years. Defined as: ((1.0/17280.0)/(1000.0)) × foot per sextillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerSeptillionYears = new (
                                                                 "twip per septillion years"
                                                               , "twip/Yyr"
                                                               , FootPerSextillionYears
                                                               , 1.0 / 17280.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) furlong per quintillion years. Defined as: ((10.0)/(1000.0)) × chain per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity FurlongPerQuintillionYears = new (
                                                                     "furlong per quintillion years"
                                                                   , "fur/Eyr"
                                                                   , ChainPerQuadrillionYears
                                                                   , 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per millennium. Defined as: ((10.0)/(10.0)) × cable per century + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillennium =
            new ("nautical mile per millennium", "nmi/kyr", CablePerCentury, 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) chain per century. Defined as: ((22.0)/(10.0)) × yard per decade + (0).
   /// </summary>
   public static readonly Velocity ChainPerCentury = new (
                                                          "chain per century"
                                                        , "ch/century"
                                                        , YardPerDecade
                                                        , 22.0 / 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) league per octillion years. Defined as: ((3.0)/(1000.0)) × mile per septillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerOctillionYears =
            new ("league per octillion years", "lea/Ryr", MilePerSeptillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) barleycorn per nonillion years. Defined as: ((1.0/36.0)/(1000.0)) × foot per octillion years + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerNonillionYears = new (
                                                                      "barleycorn per nonillion years"
                                                                    , "barleycorn/Qyr"
                                                                    , FootPerOctillionYears
                                                                    , 1.0 / 36.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) chain per septillion years. Defined as: ((22.0)/(1000.0)) × yard per sextillion years + (0).
   /// </summary>
   public static readonly Velocity ChainPerSeptillionYears =
            new ("chain per septillion years", "ch/Yyr", YardPerSextillionYears, 22.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per decillion years. Defined as: ((100.0)/(1000.0)) × fathom per nonillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerDecillionYears = new (
                                                                 "cable per decillion years"
                                                               , "cable/decillion yr"
                                                               , FathomPerNonillionYears
                                                               , 100.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) league per year. Defined as: ((3.0)/(365.2525)) × mile per day + (0).
   /// </summary>
   public static readonly Velocity LeaguePerYear = new ("league per year", "lea/yr", MilePerDay, 3.0 / 365.2525, 0);

   /// <summary>
   /// A(n) fathom per decillion years. Defined as: ((6.0)/(1000.0)) × foot per nonillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerDecillionYears = new (
                                                                  "fathom per decillion years"
                                                                , "ftm/decillion yr"
                                                                , FootPerNonillionYears
                                                                , 6.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) furlong per week. Defined as: ((10.0)/(7.0)) × chain per day + (0).
   /// </summary>
   public static readonly Velocity FurlongPerWeek = new ("furlong per week", "fur/wk", ChainPerDay, 10.0 / 7.0, 0);

   /// <summary>
   /// A(n) twip per octillion years. Defined as: ((1.0/17280.0)/(1000.0)) × foot per septillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerOctillionYears = new (
                                                                "twip per octillion years"
                                                              , "twip/Ryr"
                                                              , FootPerSeptillionYears
                                                              , 1.0 / 17280.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) nautical mile per trillion years. Defined as: ((10.0)/(1000.0)) × cable per billion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerTrillionYears = new (
                                                                       "nautical mile per trillion years"
                                                                     , "nmi/Tyr"
                                                                     , CablePerBillionYears
                                                                     , 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) cable per septillion years. Defined as: ((100.0)/(1000.0)) × fathom per sextillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerSeptillionYears = new (
                                                                  "cable per septillion years"
                                                                , "cable/Yyr"
                                                                , FathomPerSextillionYears
                                                                , 100.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) thou per nonillion years. Defined as: ((1.0/12000.0)/(1000.0)) × foot per octillion years + (0).
   /// </summary>
   public static readonly Velocity ThouPerNonillionYears = new (
                                                                "thou per nonillion years"
                                                              , "th/Qyr"
                                                              , FootPerOctillionYears
                                                              , 1.0 / 12000.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) mile per decillion years. Defined as: ((8.0)/(1000.0)) × furlong per nonillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerDecillionYears = new (
                                                                "mile per decillion years"
                                                              , "mi/decillion yr"
                                                              , FurlongPerNonillionYears
                                                              , 8.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) chain per billion years. Defined as: ((22.0)/(1000.0)) × yard per million years + (0).
   /// </summary>
   public static readonly Velocity ChainPerBillionYears =
            new ("chain per billion years", "ch/Gyr", YardPerMillionYears, 22.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per octillion years. Defined as: ((8.0)/(1000.0)) × furlong per septillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerOctillionYears = new (
                                                                "mile per octillion years"
                                                              , "mi/Ryr"
                                                              , FurlongPerSeptillionYears
                                                              , 8.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per decillion years. Defined as: ((10.0)/(1000.0)) × chain per nonillion years + (0).
   /// </summary>
   public static readonly Velocity FurlongPerDecillionYears = new (
                                                                   "furlong per decillion years"
                                                                 , "fur/decillion yr"
                                                                 , ChainPerNonillionYears
                                                                 , 10.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nautical mile per week. Defined as: ((10.0)/(7.0)) × cable per day + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerWeek =
            new ("nautical mile per week", "nmi/wk", CablePerDay, 10.0 / 7.0, 0);

   /// <summary>
   /// A(n) mile per sextillion years. Defined as: ((8.0)/(1000.0)) × furlong per quintillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerSextillionYears = new (
                                                                 "mile per sextillion years"
                                                               , "mi/Zyr"
                                                               , FurlongPerQuintillionYears
                                                               , 8.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) chain per decillion years. Defined as: ((22.0)/(1000.0)) × yard per nonillion years + (0).
   /// </summary>
   public static readonly Velocity ChainPerDecillionYears = new (
                                                                 "chain per decillion years"
                                                               , "ch/decillion yr"
                                                               , YardPerNonillionYears
                                                               , 22.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) twip per nonillion years. Defined as: ((1.0/17280.0)/(1000.0)) × foot per octillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerNonillionYears = new (
                                                                "twip per nonillion years"
                                                              , "twip/Qyr"
                                                              , FootPerOctillionYears
                                                              , 1.0 / 17280.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) yard per decillion years. Defined as: ((3.0)/(1000.0)) × foot per nonillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerDecillionYears = new (
                                                                "yard per decillion years"
                                                              , "yd/decillion yr"
                                                              , FootPerNonillionYears
                                                              , 3.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) nautical mile per sextillion years. Defined as: ((10.0)/(1000.0)) × cable per quintillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSextillionYears = new (
                                                                         "nautical mile per sextillion years"
                                                                       , "nmi/Zyr"
                                                                       , CablePerQuintillionYears
                                                                       , 10.0 / 1000.0
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) chain per year. Defined as: ((22.0)/(365.2525)) × yard per day + (0).
   /// </summary>
   public static readonly Velocity ChainPerYear = new ("chain per year", "ch/yr", YardPerDay, 22.0 / 365.2525, 0);

   /// <summary>
   /// A(n) cable per decade. Defined as: ((100.0)/(10.0)) × fathom per year + (0).
   /// </summary>
   public static readonly Velocity CablePerDecade = new (
                                                         "cable per decade"
                                                       , "cable/decade"
                                                       , FathomPerYear
                                                       , 100.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) barleycorn per decillion years. Defined as: ((1.0/36.0)/(1000.0)) × foot per nonillion years + (0).
   /// </summary>
   public static readonly Velocity BarleycornPerDecillionYears = new (
                                                                      "barleycorn per decillion years"
                                                                    , "barleycorn/decillion yr"
                                                                    , FootPerNonillionYears
                                                                    , 1.0 / 36.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mile per decade. Defined as: ((8.0)/(10.0)) × furlong per year + (0).
   /// </summary>
   public static readonly Velocity MilePerDecade = new ("mile per decade", "mi/decade", FurlongPerYear, 8.0 / 10.0, 0);

   /// <summary>
   /// A(n) nautical mile per century. Defined as: ((10.0)/(10.0)) × cable per decade + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerCentury =
            new ("nautical mile per century", "nmi/century", CablePerDecade, 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) furlong per octillion years. Defined as: ((10.0)/(1000.0)) × chain per septillion years + (0).
   /// </summary>
   public static readonly Velocity FurlongPerOctillionYears = new (
                                                                   "furlong per octillion years"
                                                                 , "fur/Ryr"
                                                                 , ChainPerSeptillionYears
                                                                 , 10.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) mile per week. Defined as: ((8.0)/(7.0)) × furlong per day + (0).
   /// </summary>
   public static readonly Velocity MilePerWeek = new ("mile per week", "mi/wk", FurlongPerDay, 8.0 / 7.0, 0);

   /// <summary>
   /// A(n) nautical mile per nonillion years. Defined as: ((10.0)/(1000.0)) × cable per octillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerNonillionYears = new (
                                                                        "nautical mile per nonillion years"
                                                                      , "nmi/Qyr"
                                                                      , CablePerOctillionYears
                                                                      , 10.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per millennium. Defined as: ((22.0)/(10.0)) × yard per century + (0).
   /// </summary>
   public static readonly Velocity ChainPerMillennium = new (
                                                             "chain per millennium"
                                                           , "ch/kyr"
                                                           , YardPerCentury
                                                           , 22.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) furlong per century. Defined as: ((10.0)/(10.0)) × chain per decade + (0).
   /// </summary>
   public static readonly Velocity FurlongPerCentury = new (
                                                            "furlong per century"
                                                          , "fur/century"
                                                          , ChainPerDecade
                                                          , 10.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) cable per nonillion years. Defined as: ((100.0)/(1000.0)) × fathom per octillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerNonillionYears = new (
                                                                 "cable per nonillion years"
                                                               , "cable/Qyr"
                                                               , FathomPerOctillionYears
                                                               , 100.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) nautical mile per day. Defined as: ((10.0)/(24.0)) × cable per hour + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDay = new (
                                                             "nautical mile per day"
                                                           , "nmi/dy"
                                                           , CablePerHour
                                                           , 10.0 / 24.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) league per septillion years. Defined as: ((3.0)/(1000.0)) × mile per sextillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerSeptillionYears =
            new ("league per septillion years", "lea/Yyr", MilePerSextillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per week. Defined as: ((3.0)/(7.0)) × mile per day + (0).
   /// </summary>
   public static readonly Velocity LeaguePerWeek = new ("league per week", "lea/wk", MilePerDay, 3.0 / 7.0, 0);

   /// <summary>
   /// A(n) chain per trillion years. Defined as: ((22.0)/(1000.0)) × yard per billion years + (0).
   /// </summary>
   public static readonly Velocity ChainPerTrillionYears =
            new ("chain per trillion years", "ch/Tyr", YardPerBillionYears, 22.0 / 1000.0, 0);

   /// <summary>
   /// A(n) furlong per quadrillion years. Defined as: ((10.0)/(1000.0)) × chain per trillion years + (0).
   /// </summary>
   public static readonly Velocity FurlongPerQuadrillionYears = new (
                                                                     "furlong per quadrillion years"
                                                                   , "fur/Pyr"
                                                                   , ChainPerTrillionYears
                                                                   , 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) league per nonillion years. Defined as: ((3.0)/(1000.0)) × mile per octillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerNonillionYears =
            new ("league per nonillion years", "lea/Qyr", MilePerOctillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nautical mile per decade. Defined as: ((10.0)/(10.0)) × cable per year + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecade =
            new ("nautical mile per decade", "nmi/decade", CablePerYear, 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) league per decade. Defined as: ((3.0)/(10.0)) × mile per year + (0).
   /// </summary>
   public static readonly Velocity LeaguePerDecade = new (
                                                          "league per decade"
                                                        , "lea/decade"
                                                        , MilePerYear
                                                        , 3.0 / 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) nautical mile per octillion years. Defined as: ((10.0)/(1000.0)) × cable per septillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerOctillionYears = new (
                                                                        "nautical mile per octillion years"
                                                                      , "nmi/Ryr"
                                                                      , CablePerSeptillionYears
                                                                      , 10.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) mile per nonillion years. Defined as: ((8.0)/(1000.0)) × furlong per octillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerNonillionYears =
            new ("mile per nonillion years", "mi/Qyr", FurlongPerOctillionYears, 8.0 / 1000.0, 0);

   /// <summary>
   /// A(n) furlong per billion years. Defined as: ((10.0)/(1000.0)) × chain per million years + (0).
   /// </summary>
   public static readonly Velocity FurlongPerBillionYears =
            new ("furlong per billion years", "fur/Gyr", ChainPerMillionYears, 10.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per quintillion years. Defined as: ((8.0)/(1000.0)) × furlong per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerQuintillionYears = new (
                                                                  "mile per quintillion years"
                                                                , "mi/Eyr"
                                                                , FurlongPerQuadrillionYears
                                                                , 8.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) mile per trillion years. Defined as: ((8.0)/(1000.0)) × furlong per billion years + (0).
   /// </summary>
   public static readonly Velocity MilePerTrillionYears =
            new ("mile per trillion years", "mi/Tyr", FurlongPerBillionYears, 8.0 / 1000.0, 0);

   /// <summary>
   /// A(n) furlong per millennium. Defined as: ((10.0)/(10.0)) × chain per century + (0).
   /// </summary>
   public static readonly Velocity FurlongPerMillennium =
            new ("furlong per millennium", "fur/kyr", ChainPerCentury, 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) league per quadrillion years. Defined as: ((3.0)/(1000.0)) × mile per trillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerQuadrillionYears =
            new ("league per quadrillion years", "lea/Pyr", MilePerTrillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per sextillion years. Defined as: ((3.0)/(1000.0)) × mile per quintillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerSextillionYears = new (
                                                                   "league per sextillion years"
                                                                 , "lea/Zyr"
                                                                 , MilePerQuintillionYears
                                                                 , 3.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) furlong per decade. Defined as: ((10.0)/(10.0)) × chain per year + (0).
   /// </summary>
   public static readonly Velocity FurlongPerDecade = new (
                                                           "furlong per decade"
                                                         , "fur/decade"
                                                         , ChainPerYear
                                                         , 10.0 / 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) nautical mile per decillion years. Defined as: ((10.0)/(1000.0)) × cable per nonillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecillionYears = new (
                                                                        "nautical mile per decillion years"
                                                                      , "nmi/decillion yr"
                                                                      , CablePerNonillionYears
                                                                      , 10.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per decillion years. Defined as: ((3.0)/(1000.0)) × mile per nonillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerDecillionYears = new (
                                                                  "league per decillion years"
                                                                , "lea/decillion yr"
                                                                , MilePerNonillionYears
                                                                , 3.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) furlong per trillion years. Defined as: ((10.0)/(1000.0)) × chain per billion years + (0).
   /// </summary>
   public static readonly Velocity FurlongPerTrillionYears =
            new ("furlong per trillion years", "fur/Tyr", ChainPerBillionYears, 10.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per century. Defined as: ((3.0)/(10.0)) × mile per decade + (0).
   /// </summary>
   public static readonly Velocity LeaguePerCentury = new (
                                                           "league per century"
                                                         , "lea/century"
                                                         , MilePerDecade
                                                         , 3.0 / 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) mile per quadrillion years. Defined as: ((8.0)/(1000.0)) × furlong per trillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerQuadrillionYears =
            new ("mile per quadrillion years", "mi/Pyr", FurlongPerTrillionYears, 8.0 / 1000.0, 0);

   /// <summary>
   /// A(n) furlong per million years. Defined as: ((10.0)/(1000.0)) × chain per millennium + (0).
   /// </summary>
   public static readonly Velocity FurlongPerMillionYears =
            new ("furlong per million years", "fur/Myr", ChainPerMillennium, 10.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per millennium. Defined as: ((8.0)/(10.0)) × furlong per century + (0).
   /// </summary>
   public static readonly Velocity MilePerMillennium = new (
                                                            "mile per millennium"
                                                          , "mi/kyr"
                                                          , FurlongPerCentury
                                                          , 8.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) league per quintillion years. Defined as: ((3.0)/(1000.0)) × mile per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerQuintillionYears = new (
                                                                    "league per quintillion years"
                                                                  , "lea/Eyr"
                                                                  , MilePerQuadrillionYears
                                                                  , 3.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) mile per million years. Defined as: ((8.0)/(1000.0)) × furlong per millennium + (0).
   /// </summary>
   public static readonly Velocity MilePerMillionYears =
            new ("mile per million years", "mi/Myr", FurlongPerMillennium, 8.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per century. Defined as: ((8.0)/(10.0)) × furlong per decade + (0).
   /// </summary>
   public static readonly Velocity MilePerCentury = new (
                                                         "mile per century"
                                                       , "mi/century"
                                                       , FurlongPerDecade
                                                       , 8.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) league per billion years. Defined as: ((3.0)/(1000.0)) × mile per million years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerBillionYears =
            new ("league per billion years", "lea/Gyr", MilePerMillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per billion years. Defined as: ((8.0)/(1000.0)) × furlong per million years + (0).
   /// </summary>
   public static readonly Velocity MilePerBillionYears =
            new ("mile per billion years", "mi/Gyr", FurlongPerMillionYears, 8.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per million years. Defined as: ((3.0)/(1000.0)) × mile per millennium + (0).
   /// </summary>
   public static readonly Velocity LeaguePerMillionYears =
            new ("league per million years", "lea/Myr", MilePerMillennium, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per trillion years. Defined as: ((3.0)/(1000.0)) × mile per billion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerTrillionYears =
            new ("league per trillion years", "lea/Tyr", MilePerBillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per millennium. Defined as: ((3.0)/(10.0)) × mile per century + (0).
   /// </summary>
   public static readonly Velocity LeaguePerMillennium =
            new ("league per millennium", "lea/kyr", MilePerCentury, 3.0 / 10.0, 0);
}
