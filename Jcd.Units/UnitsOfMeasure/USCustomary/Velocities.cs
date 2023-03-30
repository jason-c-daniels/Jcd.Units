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
   /// A(n) nautical mile per octillion years. Defined as: ((1852.0)/(1000.0)) × SI meter per septillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerOctillionYears = new (
                                                                        "nautical mile per octillion years"
                                                                      , "nmi/Ryr"
                                                                      , SI.Velocities.MeterPerSeptillionYears
                                                                      , 1852.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) nautical mile per trillion years. Defined as: ((1852.0)/(1000.0)) × SI meter per billion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerTrillionYears = new (
                                                                       "nautical mile per trillion years"
                                                                     , "nmi/Tyr"
                                                                     , SI.Velocities.MeterPerBillionYears
                                                                     , 1852.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) nautical mile per decade. Defined as: ((1852.0)/(10.0)) × SI meter per year + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecade = new (
                                                                "nautical mile per decade"
                                                              , "nmi/decade"
                                                              , SI.Velocities.MeterPerYear
                                                              , 1852.0 / 10.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) nautical mile per minute. Defined as: ((1852.0)/(60.0)) × SI meter per second + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMinute = new (
                                                                "nautical mile per minute"
                                                              , "nmi/min"
                                                              , SI.Velocities.MeterPerSecond
                                                              , 1852.0 / 60.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) nautical mile per decillion years. Defined as: ((1852.0)/(1000.0)) × SI meter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecillionYears = new (
                                                                        "nautical mile per decillion years"
                                                                      , "nmi/decillion yr"
                                                                      , SI.Velocities.MeterPerNonillionYears
                                                                      , 1852.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) nautical mile per quintillion years. Defined as: ((1852.0)/(1000.0)) × SI meter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuintillionYears = new (
                                                                          "nautical mile per quintillion years"
                                                                        , "nmi/Eyr"
                                                                        , SI.Velocities.MeterPerQuadrillionYears
                                                                        , 1852.0 / 1000.0
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) nautical mile per millennium. Defined as: ((1852.0)/(10.0)) × SI meter per century + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillennium = new (
                                                                    "nautical mile per millennium"
                                                                  , "nmi/kyr"
                                                                  , SI.Velocities.MeterPerCentury
                                                                  , 1852.0 / 10.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nautical mile per day. Defined as: ((1852.0)/(24.0)) × SI meter per hour + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDay = new (
                                                             "nautical mile per day"
                                                           , "nmi/dy"
                                                           , SI.Velocities.MeterPerHour
                                                           , 1852.0 / 24.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) nautical mile per tick. Defined as: ((1852.0)/(100.0)) × SI meter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerTick = new (
                                                              "nautical mile per tick"
                                                            , "nmi/tick"
                                                            , SI.Velocities.MeterPerNanosecond
                                                            , 1852.0 / 100.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) nautical mile per septillion years. Defined as: ((1852.0)/(1000.0)) × SI meter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSeptillionYears = new (
                                                                         "nautical mile per septillion years"
                                                                       , "nmi/Yyr"
                                                                       , SI.Velocities.MeterPerSextillionYears
                                                                       , 1852.0 / 1000.0
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) nautical mile per billion years. Defined as: ((1852.0)/(1000.0)) × SI meter per million years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerBillionYears = new (
                                                                      "nautical mile per billion years"
                                                                    , "nmi/Gyr"
                                                                    , SI.Velocities.MeterPerMillionYears
                                                                    , 1852.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) nautical mile per year. Defined as: ((1852.0)/(365.2525)) × SI meter per day + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerYear = new (
                                                              "nautical mile per year"
                                                            , "nmi/yr"
                                                            , SI.Velocities.MeterPerDay
                                                            , 1852.0 / 365.2525
                                                            , 0
                                                             );

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
   /// A(n) mil per second. Defined as: ((1.0/1000.0)/(1.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity MilPerSecond = new ("mil per second", "mil/s", InchPerSecond, 1.0 / 1000.0 / 1.0, 0);

   /// <summary>
   /// A(n) mil per decisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity MilPerDecisecond = new (
                                                           "mil per decisecond"
                                                         , "mil/ds"
                                                         , InchPerSecond
                                                         , 1.0 / 1000.0 / (1.0 / 10.0)
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) mil per centisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × inch per decisecond + (0).
   /// </summary>
   public static readonly Velocity MilPerCentisecond = new (
                                                            "mil per centisecond"
                                                          , "mil/cs"
                                                          , InchPerDecisecond
                                                          , 1.0 / 1000.0 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mil per millisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × inch per centisecond + (0).
   /// </summary>
   public static readonly Velocity MilPerMillisecond = new (
                                                            "mil per millisecond"
                                                          , "mil/ms"
                                                          , InchPerCentisecond
                                                          , 1.0 / 1000.0 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mil per microsecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × inch per millisecond + (0).
   /// </summary>
   public static readonly Velocity MilPerMicrosecond = new (
                                                            "mil per microsecond"
                                                          , "mil/μs"
                                                          , InchPerMillisecond
                                                          , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mil per nanosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × inch per microsecond + (0).
   /// </summary>
   public static readonly Velocity MilPerNanosecond = new (
                                                           "mil per nanosecond"
                                                         , "mil/ns"
                                                         , InchPerMicrosecond
                                                         , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) mil per picosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × inch per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MilPerPicosecond = new (
                                                           "mil per picosecond"
                                                         , "mil/ps"
                                                         , InchPerNanosecond
                                                         , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) mil per femtosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × inch per picosecond + (0).
   /// </summary>
   public static readonly Velocity MilPerFemtosecond = new (
                                                            "mil per femtosecond"
                                                          , "mil/fs"
                                                          , InchPerPicosecond
                                                          , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mil per attosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × inch per femtosecond + (0).
   /// </summary>
   public static readonly Velocity MilPerAttosecond = new (
                                                           "mil per attosecond"
                                                         , "mil/as"
                                                         , InchPerFemtosecond
                                                         , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) mil per zeptosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × inch per attosecond + (0).
   /// </summary>
   public static readonly Velocity MilPerZeptosecond = new (
                                                            "mil per zeptosecond"
                                                          , "mil/zs"
                                                          , InchPerAttosecond
                                                          , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mil per yoctosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × inch per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity MilPerYoctosecond = new (
                                                            "mil per yoctosecond"
                                                          , "mil/ys"
                                                          , InchPerZeptosecond
                                                          , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mil per rontosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × inch per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity MilPerRontosecond = new (
                                                            "mil per rontosecond"
                                                          , "mil/rs"
                                                          , InchPerYoctosecond
                                                          , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mil per quectosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × inch per rontosecond + (0).
   /// </summary>
   public static readonly Velocity MilPerQuectosecond = new (
                                                             "mil per quectosecond"
                                                           , "mil/qs"
                                                           , InchPerRontosecond
                                                           , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

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
   /// A(n) point per second. Defined as: ((1.0/72.0)/(1.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity PointPerSecond = new ("point per second", "p/s", InchPerSecond, 1.0 / 72.0 / 1.0, 0);

   /// <summary>
   /// A(n) point per decisecond. Defined as: ((1.0/72.0)/(1.0/10.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity PointPerDecisecond = new (
                                                             "point per decisecond"
                                                           , "p/ds"
                                                           , InchPerSecond
                                                           , 1.0 / 72.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) point per centisecond. Defined as: ((1.0/72.0)/(1.0/10.0)) × inch per decisecond + (0).
   /// </summary>
   public static readonly Velocity PointPerCentisecond = new (
                                                              "point per centisecond"
                                                            , "p/cs"
                                                            , InchPerDecisecond
                                                            , 1.0 / 72.0 / (1.0 / 10.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) point per millisecond. Defined as: ((1.0/72.0)/(1.0/10.0)) × inch per centisecond + (0).
   /// </summary>
   public static readonly Velocity PointPerMillisecond = new (
                                                              "point per millisecond"
                                                            , "p/ms"
                                                            , InchPerCentisecond
                                                            , 1.0 / 72.0 / (1.0 / 10.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) point per microsecond. Defined as: ((1.0/72.0)/(1.0/1000.0)) × inch per millisecond + (0).
   /// </summary>
   public static readonly Velocity PointPerMicrosecond = new (
                                                              "point per microsecond"
                                                            , "p/μs"
                                                            , InchPerMillisecond
                                                            , 1.0 / 72.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) point per nanosecond. Defined as: ((1.0/72.0)/(1.0/1000.0)) × inch per microsecond + (0).
   /// </summary>
   public static readonly Velocity PointPerNanosecond = new (
                                                             "point per nanosecond"
                                                           , "p/ns"
                                                           , InchPerMicrosecond
                                                           , 1.0 / 72.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) point per picosecond. Defined as: ((1.0/72.0)/(1.0/1000.0)) × inch per nanosecond + (0).
   /// </summary>
   public static readonly Velocity PointPerPicosecond = new (
                                                             "point per picosecond"
                                                           , "p/ps"
                                                           , InchPerNanosecond
                                                           , 1.0 / 72.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) point per femtosecond. Defined as: ((1.0/72.0)/(1.0/1000.0)) × inch per picosecond + (0).
   /// </summary>
   public static readonly Velocity PointPerFemtosecond = new (
                                                              "point per femtosecond"
                                                            , "p/fs"
                                                            , InchPerPicosecond
                                                            , 1.0 / 72.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) point per attosecond. Defined as: ((1.0/72.0)/(1.0/1000.0)) × inch per femtosecond + (0).
   /// </summary>
   public static readonly Velocity PointPerAttosecond = new (
                                                             "point per attosecond"
                                                           , "p/as"
                                                           , InchPerFemtosecond
                                                           , 1.0 / 72.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) point per zeptosecond. Defined as: ((1.0/72.0)/(1.0/1000.0)) × inch per attosecond + (0).
   /// </summary>
   public static readonly Velocity PointPerZeptosecond = new (
                                                              "point per zeptosecond"
                                                            , "p/zs"
                                                            , InchPerAttosecond
                                                            , 1.0 / 72.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) point per yoctosecond. Defined as: ((1.0/72.0)/(1.0/1000.0)) × inch per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity PointPerYoctosecond = new (
                                                              "point per yoctosecond"
                                                            , "p/ys"
                                                            , InchPerZeptosecond
                                                            , 1.0 / 72.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) point per rontosecond. Defined as: ((1.0/72.0)/(1.0/1000.0)) × inch per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity PointPerRontosecond = new (
                                                              "point per rontosecond"
                                                            , "p/rs"
                                                            , InchPerYoctosecond
                                                            , 1.0 / 72.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) point per quectosecond. Defined as: ((1.0/72.0)/(1.0/1000.0)) × inch per rontosecond + (0).
   /// </summary>
   public static readonly Velocity PointPerQuectosecond = new (
                                                               "point per quectosecond"
                                                             , "p/qs"
                                                             , InchPerRontosecond
                                                             , 1.0 / 72.0 / (1.0 / 1000.0)
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
   /// A(n) twip per second. Defined as: ((1.0/20.0)/(1.0)) × point per second + (0).
   /// </summary>
   public static readonly Velocity TwipPerSecond = new (
                                                        "twip per second"
                                                      , "twip/s"
                                                      , PointPerSecond
                                                      , 1.0 / 20.0 / 1.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) twip per decisecond. Defined as: ((1.0/20.0)/(1.0/10.0)) × point per second + (0).
   /// </summary>
   public static readonly Velocity TwipPerDecisecond = new (
                                                            "twip per decisecond"
                                                          , "twip/ds"
                                                          , PointPerSecond
                                                          , 1.0 / 20.0 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) twip per centisecond. Defined as: ((1.0/20.0)/(1.0/10.0)) × point per decisecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerCentisecond = new (
                                                             "twip per centisecond"
                                                           , "twip/cs"
                                                           , PointPerDecisecond
                                                           , 1.0 / 20.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per millisecond. Defined as: ((1.0/20.0)/(1.0/10.0)) × point per centisecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerMillisecond = new (
                                                             "twip per millisecond"
                                                           , "twip/ms"
                                                           , PointPerCentisecond
                                                           , 1.0 / 20.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per microsecond. Defined as: ((1.0/20.0)/(1.0/1000.0)) × point per millisecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerMicrosecond = new (
                                                             "twip per microsecond"
                                                           , "twip/μs"
                                                           , PointPerMillisecond
                                                           , 1.0 / 20.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per nanosecond. Defined as: ((1.0/20.0)/(1.0/1000.0)) × point per microsecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerNanosecond = new (
                                                            "twip per nanosecond"
                                                          , "twip/ns"
                                                          , PointPerMicrosecond
                                                          , 1.0 / 20.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) twip per picosecond. Defined as: ((1.0/20.0)/(1.0/1000.0)) × point per nanosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerPicosecond = new (
                                                            "twip per picosecond"
                                                          , "twip/ps"
                                                          , PointPerNanosecond
                                                          , 1.0 / 20.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) twip per femtosecond. Defined as: ((1.0/20.0)/(1.0/1000.0)) × point per picosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerFemtosecond = new (
                                                             "twip per femtosecond"
                                                           , "twip/fs"
                                                           , PointPerPicosecond
                                                           , 1.0 / 20.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per attosecond. Defined as: ((1.0/20.0)/(1.0/1000.0)) × point per femtosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerAttosecond = new (
                                                            "twip per attosecond"
                                                          , "twip/as"
                                                          , PointPerFemtosecond
                                                          , 1.0 / 20.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) twip per zeptosecond. Defined as: ((1.0/20.0)/(1.0/1000.0)) × point per attosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerZeptosecond = new (
                                                             "twip per zeptosecond"
                                                           , "twip/zs"
                                                           , PointPerAttosecond
                                                           , 1.0 / 20.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per yoctosecond. Defined as: ((1.0/20.0)/(1.0/1000.0)) × point per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerYoctosecond = new (
                                                             "twip per yoctosecond"
                                                           , "twip/ys"
                                                           , PointPerZeptosecond
                                                           , 1.0 / 20.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per rontosecond. Defined as: ((1.0/20.0)/(1.0/1000.0)) × point per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerRontosecond = new (
                                                             "twip per rontosecond"
                                                           , "twip/rs"
                                                           , PointPerYoctosecond
                                                           , 1.0 / 20.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) twip per quectosecond. Defined as: ((1.0/20.0)/(1.0/1000.0)) × point per rontosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerQuectosecond = new (
                                                              "twip per quectosecond"
                                                            , "twip/qs"
                                                            , PointPerRontosecond
                                                            , 1.0 / 20.0 / (1.0 / 1000.0)
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
   /// A(n) pica per second. Defined as: ((12.0)/(1.0)) × point per second + (0).
   /// </summary>
   public static readonly Velocity PicaPerSecond = new ("pica per second", "P/s", PointPerSecond, 12.0 / 1.0, 0);

   /// <summary>
   /// A(n) pica per decisecond. Defined as: ((12.0)/(1.0/10.0)) × point per second + (0).
   /// </summary>
   public static readonly Velocity PicaPerDecisecond = new (
                                                            "pica per decisecond"
                                                          , "P/ds"
                                                          , PointPerSecond
                                                          , 12.0 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) pica per centisecond. Defined as: ((12.0)/(1.0/10.0)) × point per decisecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerCentisecond = new (
                                                             "pica per centisecond"
                                                           , "P/cs"
                                                           , PointPerDecisecond
                                                           , 12.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) pica per millisecond. Defined as: ((12.0)/(1.0/10.0)) × point per centisecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerMillisecond = new (
                                                             "pica per millisecond"
                                                           , "P/ms"
                                                           , PointPerCentisecond
                                                           , 12.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) pica per microsecond. Defined as: ((12.0)/(1.0/1000.0)) × point per millisecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerMicrosecond = new (
                                                             "pica per microsecond"
                                                           , "P/μs"
                                                           , PointPerMillisecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) pica per nanosecond. Defined as: ((12.0)/(1.0/1000.0)) × point per microsecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerNanosecond = new (
                                                            "pica per nanosecond"
                                                          , "P/ns"
                                                          , PointPerMicrosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) pica per picosecond. Defined as: ((12.0)/(1.0/1000.0)) × point per nanosecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerPicosecond = new (
                                                            "pica per picosecond"
                                                          , "P/ps"
                                                          , PointPerNanosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) pica per femtosecond. Defined as: ((12.0)/(1.0/1000.0)) × point per picosecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerFemtosecond = new (
                                                             "pica per femtosecond"
                                                           , "P/fs"
                                                           , PointPerPicosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) pica per attosecond. Defined as: ((12.0)/(1.0/1000.0)) × point per femtosecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerAttosecond = new (
                                                            "pica per attosecond"
                                                          , "P/as"
                                                          , PointPerFemtosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) pica per zeptosecond. Defined as: ((12.0)/(1.0/1000.0)) × point per attosecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerZeptosecond = new (
                                                             "pica per zeptosecond"
                                                           , "P/zs"
                                                           , PointPerAttosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) pica per yoctosecond. Defined as: ((12.0)/(1.0/1000.0)) × point per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerYoctosecond = new (
                                                             "pica per yoctosecond"
                                                           , "P/ys"
                                                           , PointPerZeptosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) pica per rontosecond. Defined as: ((12.0)/(1.0/1000.0)) × point per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerRontosecond = new (
                                                             "pica per rontosecond"
                                                           , "P/rs"
                                                           , PointPerYoctosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) pica per quectosecond. Defined as: ((12.0)/(1.0/1000.0)) × point per rontosecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerQuectosecond = new (
                                                              "pica per quectosecond"
                                                            , "P/qs"
                                                            , PointPerRontosecond
                                                            , 12.0 / (1.0 / 1000.0)
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
   /// A(n) foot per second. Defined as: ((12.0)/(1.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity FootPerSecond = new ("foot per second", "ft/s", InchPerSecond, 12.0 / 1.0, 0);

   /// <summary>
   /// A(n) foot per decisecond. Defined as: ((12.0)/(1.0/10.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity FootPerDecisecond = new (
                                                            "foot per decisecond"
                                                          , "ft/ds"
                                                          , InchPerSecond
                                                          , 12.0 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per centisecond. Defined as: ((12.0)/(1.0/10.0)) × inch per decisecond + (0).
   /// </summary>
   public static readonly Velocity FootPerCentisecond = new (
                                                             "foot per centisecond"
                                                           , "ft/cs"
                                                           , InchPerDecisecond
                                                           , 12.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per millisecond. Defined as: ((12.0)/(1.0/10.0)) × inch per centisecond + (0).
   /// </summary>
   public static readonly Velocity FootPerMillisecond = new (
                                                             "foot per millisecond"
                                                           , "ft/ms"
                                                           , InchPerCentisecond
                                                           , 12.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per microsecond. Defined as: ((12.0)/(1.0/1000.0)) × inch per millisecond + (0).
   /// </summary>
   public static readonly Velocity FootPerMicrosecond = new (
                                                             "foot per microsecond"
                                                           , "ft/μs"
                                                           , InchPerMillisecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per nanosecond. Defined as: ((12.0)/(1.0/1000.0)) × inch per microsecond + (0).
   /// </summary>
   public static readonly Velocity FootPerNanosecond = new (
                                                            "foot per nanosecond"
                                                          , "ft/ns"
                                                          , InchPerMicrosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per picosecond. Defined as: ((12.0)/(1.0/1000.0)) × inch per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerPicosecond = new (
                                                            "foot per picosecond"
                                                          , "ft/ps"
                                                          , InchPerNanosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per femtosecond. Defined as: ((12.0)/(1.0/1000.0)) × inch per picosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerFemtosecond = new (
                                                             "foot per femtosecond"
                                                           , "ft/fs"
                                                           , InchPerPicosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per attosecond. Defined as: ((12.0)/(1.0/1000.0)) × inch per femtosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerAttosecond = new (
                                                            "foot per attosecond"
                                                          , "ft/as"
                                                          , InchPerFemtosecond
                                                          , 12.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) foot per zeptosecond. Defined as: ((12.0)/(1.0/1000.0)) × inch per attosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerZeptosecond = new (
                                                             "foot per zeptosecond"
                                                           , "ft/zs"
                                                           , InchPerAttosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per yoctosecond. Defined as: ((12.0)/(1.0/1000.0)) × inch per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerYoctosecond = new (
                                                             "foot per yoctosecond"
                                                           , "ft/ys"
                                                           , InchPerZeptosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per rontosecond. Defined as: ((12.0)/(1.0/1000.0)) × inch per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerRontosecond = new (
                                                             "foot per rontosecond"
                                                           , "ft/rs"
                                                           , InchPerYoctosecond
                                                           , 12.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per quectosecond. Defined as: ((12.0)/(1.0/1000.0)) × inch per rontosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerQuectosecond = new (
                                                              "foot per quectosecond"
                                                            , "ft/qs"
                                                            , InchPerRontosecond
                                                            , 12.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

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
   /// A(n) mile per second. Defined as: ((1760.0)/(1.0)) × yard per second + (0).
   /// </summary>
   public static readonly Velocity MilePerSecond = new ("mile per second", "mi/s", YardPerSecond, 1760.0 / 1.0, 0);

   /// <summary>
   /// A(n) mile per decisecond. Defined as: ((1760.0)/(1.0/10.0)) × yard per second + (0).
   /// </summary>
   public static readonly Velocity MilePerDecisecond = new (
                                                            "mile per decisecond"
                                                          , "mi/ds"
                                                          , YardPerSecond
                                                          , 1760.0 / (1.0 / 10.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mile per centisecond. Defined as: ((1760.0)/(1.0/10.0)) × yard per decisecond + (0).
   /// </summary>
   public static readonly Velocity MilePerCentisecond = new (
                                                             "mile per centisecond"
                                                           , "mi/cs"
                                                           , YardPerDecisecond
                                                           , 1760.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per millisecond. Defined as: ((1760.0)/(1.0/10.0)) × yard per centisecond + (0).
   /// </summary>
   public static readonly Velocity MilePerMillisecond = new (
                                                             "mile per millisecond"
                                                           , "mi/ms"
                                                           , YardPerCentisecond
                                                           , 1760.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per microsecond. Defined as: ((1760.0)/(1.0/1000.0)) × yard per millisecond + (0).
   /// </summary>
   public static readonly Velocity MilePerMicrosecond = new (
                                                             "mile per microsecond"
                                                           , "mi/μs"
                                                           , YardPerMillisecond
                                                           , 1760.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per nanosecond. Defined as: ((1760.0)/(1.0/1000.0)) × yard per microsecond + (0).
   /// </summary>
   public static readonly Velocity MilePerNanosecond = new (
                                                            "mile per nanosecond"
                                                          , "mi/ns"
                                                          , YardPerMicrosecond
                                                          , 1760.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mile per picosecond. Defined as: ((1760.0)/(1.0/1000.0)) × yard per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerPicosecond = new (
                                                            "mile per picosecond"
                                                          , "mi/ps"
                                                          , YardPerNanosecond
                                                          , 1760.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mile per femtosecond. Defined as: ((1760.0)/(1.0/1000.0)) × yard per picosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerFemtosecond = new (
                                                             "mile per femtosecond"
                                                           , "mi/fs"
                                                           , YardPerPicosecond
                                                           , 1760.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per attosecond. Defined as: ((1760.0)/(1.0/1000.0)) × yard per femtosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerAttosecond = new (
                                                            "mile per attosecond"
                                                          , "mi/as"
                                                          , YardPerFemtosecond
                                                          , 1760.0 / (1.0 / 1000.0)
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mile per zeptosecond. Defined as: ((1760.0)/(1.0/1000.0)) × yard per attosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerZeptosecond = new (
                                                             "mile per zeptosecond"
                                                           , "mi/zs"
                                                           , YardPerAttosecond
                                                           , 1760.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per yoctosecond. Defined as: ((1760.0)/(1.0/1000.0)) × yard per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerYoctosecond = new (
                                                             "mile per yoctosecond"
                                                           , "mi/ys"
                                                           , YardPerZeptosecond
                                                           , 1760.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per rontosecond. Defined as: ((1760.0)/(1.0/1000.0)) × yard per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerRontosecond = new (
                                                             "mile per rontosecond"
                                                           , "mi/rs"
                                                           , YardPerYoctosecond
                                                           , 1760.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) mile per quectosecond. Defined as: ((1760.0)/(1.0/1000.0)) × yard per rontosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerQuectosecond = new (
                                                              "mile per quectosecond"
                                                            , "mi/qs"
                                                            , YardPerRontosecond
                                                            , 1760.0 / (1.0 / 1000.0)
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
   /// A(n) league per second. Defined as: ((3.0)/(1.0)) × mile per second + (0).
   /// </summary>
   public static readonly Velocity LeaguePerSecond = new ("league per second", "le/s", MilePerSecond, 3.0 / 1.0, 0);

   /// <summary>
   /// A(n) league per decisecond. Defined as: ((3.0)/(1.0/10.0)) × mile per second + (0).
   /// </summary>
   public static readonly Velocity LeaguePerDecisecond =
            new ("league per decisecond", "le/ds", MilePerSecond, 3.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) league per centisecond. Defined as: ((3.0)/(1.0/10.0)) × mile per decisecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerCentisecond =
            new ("league per centisecond", "le/cs", MilePerDecisecond, 3.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) league per millisecond. Defined as: ((3.0)/(1.0/10.0)) × mile per centisecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerMillisecond =
            new ("league per millisecond", "le/ms", MilePerCentisecond, 3.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) league per microsecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per millisecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerMicrosecond =
            new ("league per microsecond", "le/μs", MilePerMillisecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) league per nanosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per microsecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerNanosecond =
            new ("league per nanosecond", "le/ns", MilePerMicrosecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) league per picosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per nanosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerPicosecond =
            new ("league per picosecond", "le/ps", MilePerNanosecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) league per femtosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per picosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerFemtosecond =
            new ("league per femtosecond", "le/fs", MilePerPicosecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) league per attosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per femtosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerAttosecond =
            new ("league per attosecond", "le/as", MilePerFemtosecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) league per zeptosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per attosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerZeptosecond =
            new ("league per zeptosecond", "le/zs", MilePerAttosecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) league per yoctosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerYoctosecond =
            new ("league per yoctosecond", "le/ys", MilePerZeptosecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) league per rontosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerRontosecond =
            new ("league per rontosecond", "le/rs", MilePerYoctosecond, 3.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) league per quectosecond. Defined as: ((3.0)/(1.0/1000.0)) × mile per rontosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerQuectosecond =
            new ("league per quectosecond", "le/qs", MilePerRontosecond, 3.0 / (1.0 / 1000.0), 0);

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
   /// A(n) fathom per second. Defined as: ((2.0)/(1.0)) × yard per second + (0).
   /// </summary>
   public static readonly Velocity FathomPerSecond = new ("fathom per second", "ftm/s", YardPerSecond, 2.0 / 1.0, 0);

   /// <summary>
   /// A(n) fathom per decisecond. Defined as: ((2.0)/(1.0/10.0)) × yard per second + (0).
   /// </summary>
   public static readonly Velocity FathomPerDecisecond =
            new ("fathom per decisecond", "ftm/ds", YardPerSecond, 2.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) fathom per centisecond. Defined as: ((2.0)/(1.0/10.0)) × yard per decisecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerCentisecond =
            new ("fathom per centisecond", "ftm/cs", YardPerDecisecond, 2.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) fathom per millisecond. Defined as: ((2.0)/(1.0/10.0)) × yard per centisecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerMillisecond =
            new ("fathom per millisecond", "ftm/ms", YardPerCentisecond, 2.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) fathom per microsecond. Defined as: ((2.0)/(1.0/1000.0)) × yard per millisecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerMicrosecond = new (
                                                               "fathom per microsecond"
                                                             , "ftm/μs"
                                                             , YardPerMillisecond
                                                             , 2.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) fathom per nanosecond. Defined as: ((2.0)/(1.0/1000.0)) × yard per microsecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerNanosecond = new (
                                                              "fathom per nanosecond"
                                                            , "ftm/ns"
                                                            , YardPerMicrosecond
                                                            , 2.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) fathom per picosecond. Defined as: ((2.0)/(1.0/1000.0)) × yard per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerPicosecond =
            new ("fathom per picosecond", "ftm/ps", YardPerNanosecond, 2.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) fathom per femtosecond. Defined as: ((2.0)/(1.0/1000.0)) × yard per picosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerFemtosecond =
            new ("fathom per femtosecond", "ftm/fs", YardPerPicosecond, 2.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) fathom per attosecond. Defined as: ((2.0)/(1.0/1000.0)) × yard per femtosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerAttosecond = new (
                                                              "fathom per attosecond"
                                                            , "ftm/as"
                                                            , YardPerFemtosecond
                                                            , 2.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) fathom per zeptosecond. Defined as: ((2.0)/(1.0/1000.0)) × yard per attosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerZeptosecond =
            new ("fathom per zeptosecond", "ftm/zs", YardPerAttosecond, 2.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) fathom per yoctosecond. Defined as: ((2.0)/(1.0/1000.0)) × yard per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerYoctosecond = new (
                                                               "fathom per yoctosecond"
                                                             , "ftm/ys"
                                                             , YardPerZeptosecond
                                                             , 2.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) fathom per rontosecond. Defined as: ((2.0)/(1.0/1000.0)) × yard per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerRontosecond = new (
                                                               "fathom per rontosecond"
                                                             , "ftm/rs"
                                                             , YardPerYoctosecond
                                                             , 2.0 / (1.0 / 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) fathom per quectosecond. Defined as: ((2.0)/(1.0/1000.0)) × yard per rontosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerQuectosecond = new (
                                                                "fathom per quectosecond"
                                                              , "ftm/qs"
                                                              , YardPerRontosecond
                                                              , 2.0 / (1.0 / 1000.0)
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
   /// A(n) cable per second. Defined as: ((120.0)/(1.0)) × fathom per second + (0).
   /// </summary>
   public static readonly Velocity CablePerSecond = new ("cable per second", "cb/s", FathomPerSecond, 120.0 / 1.0, 0);

   /// <summary>
   /// A(n) cable per decisecond. Defined as: ((120.0)/(1.0/10.0)) × fathom per second + (0).
   /// </summary>
   public static readonly Velocity CablePerDecisecond = new (
                                                             "cable per decisecond"
                                                           , "cb/ds"
                                                           , FathomPerSecond
                                                           , 120.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) cable per centisecond. Defined as: ((120.0)/(1.0/10.0)) × fathom per decisecond + (0).
   /// </summary>
   public static readonly Velocity CablePerCentisecond = new (
                                                              "cable per centisecond"
                                                            , "cb/cs"
                                                            , FathomPerDecisecond
                                                            , 120.0 / (1.0 / 10.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per millisecond. Defined as: ((120.0)/(1.0/10.0)) × fathom per centisecond + (0).
   /// </summary>
   public static readonly Velocity CablePerMillisecond = new (
                                                              "cable per millisecond"
                                                            , "cb/ms"
                                                            , FathomPerCentisecond
                                                            , 120.0 / (1.0 / 10.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per microsecond. Defined as: ((120.0)/(1.0/1000.0)) × fathom per millisecond + (0).
   /// </summary>
   public static readonly Velocity CablePerMicrosecond = new (
                                                              "cable per microsecond"
                                                            , "cb/μs"
                                                            , FathomPerMillisecond
                                                            , 120.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per nanosecond. Defined as: ((120.0)/(1.0/1000.0)) × fathom per microsecond + (0).
   /// </summary>
   public static readonly Velocity CablePerNanosecond = new (
                                                             "cable per nanosecond"
                                                           , "cb/ns"
                                                           , FathomPerMicrosecond
                                                           , 120.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) cable per picosecond. Defined as: ((120.0)/(1.0/1000.0)) × fathom per nanosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerPicosecond = new (
                                                             "cable per picosecond"
                                                           , "cb/ps"
                                                           , FathomPerNanosecond
                                                           , 120.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) cable per femtosecond. Defined as: ((120.0)/(1.0/1000.0)) × fathom per picosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerFemtosecond = new (
                                                              "cable per femtosecond"
                                                            , "cb/fs"
                                                            , FathomPerPicosecond
                                                            , 120.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per attosecond. Defined as: ((120.0)/(1.0/1000.0)) × fathom per femtosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerAttosecond = new (
                                                             "cable per attosecond"
                                                           , "cb/as"
                                                           , FathomPerFemtosecond
                                                           , 120.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) cable per zeptosecond. Defined as: ((120.0)/(1.0/1000.0)) × fathom per attosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerZeptosecond = new (
                                                              "cable per zeptosecond"
                                                            , "cb/zs"
                                                            , FathomPerAttosecond
                                                            , 120.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per yoctosecond. Defined as: ((120.0)/(1.0/1000.0)) × fathom per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerYoctosecond = new (
                                                              "cable per yoctosecond"
                                                            , "cb/ys"
                                                            , FathomPerZeptosecond
                                                            , 120.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per rontosecond. Defined as: ((120.0)/(1.0/1000.0)) × fathom per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerRontosecond = new (
                                                              "cable per rontosecond"
                                                            , "cb/rs"
                                                            , FathomPerYoctosecond
                                                            , 120.0 / (1.0 / 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per quectosecond. Defined as: ((120.0)/(1.0/1000.0)) × fathom per rontosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerQuectosecond = new (
                                                               "cable per quectosecond"
                                                             , "cb/qs"
                                                             , FathomPerRontosecond
                                                             , 120.0 / (1.0 / 1000.0)
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
   /// A(n) nautical mile per second. Defined as: ((1852.0)/(1.0)) × SI meter per second + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSecond = new (
                                                                "nautical mile per second"
                                                              , "nmi/s"
                                                              , SI.Velocities.MeterPerSecond
                                                              , 1852.0 / 1.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) nautical mile per decisecond. Defined as: ((1852.0)/(1.0/10.0)) × SI meter per second + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecisecond = new (
                                                                    "nautical mile per decisecond"
                                                                  , "nmi/ds"
                                                                  , SI.Velocities.MeterPerSecond
                                                                  , 1852.0 / (1.0 / 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nautical mile per centisecond. Defined as: ((1852.0)/(1.0/10.0)) × SI meter per decisecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerCentisecond = new (
                                                                     "nautical mile per centisecond"
                                                                   , "nmi/cs"
                                                                   , SI.Velocities.MeterPerDecisecond
                                                                   , 1852.0 / (1.0 / 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per millisecond. Defined as: ((1852.0)/(1.0/10.0)) × SI meter per centisecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillisecond = new (
                                                                     "nautical mile per millisecond"
                                                                   , "nmi/ms"
                                                                   , SI.Velocities.MeterPerCentisecond
                                                                   , 1852.0 / (1.0 / 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per microsecond. Defined as: ((1852.0)/(1.0/1000.0)) × SI meter per millisecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMicrosecond = new (
                                                                     "nautical mile per microsecond"
                                                                   , "nmi/μs"
                                                                   , SI.Velocities.MeterPerMillisecond
                                                                   , 1852.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per nanosecond. Defined as: ((1852.0)/(1.0/1000.0)) × SI meter per microsecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerNanosecond = new (
                                                                    "nautical mile per nanosecond"
                                                                  , "nmi/ns"
                                                                  , SI.Velocities.MeterPerMicrosecond
                                                                  , 1852.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nautical mile per picosecond. Defined as: ((1852.0)/(1.0/1000.0)) × SI meter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerPicosecond = new (
                                                                    "nautical mile per picosecond"
                                                                  , "nmi/ps"
                                                                  , SI.Velocities.MeterPerNanosecond
                                                                  , 1852.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nautical mile per femtosecond. Defined as: ((1852.0)/(1.0/1000.0)) × SI meter per picosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerFemtosecond = new (
                                                                     "nautical mile per femtosecond"
                                                                   , "nmi/fs"
                                                                   , SI.Velocities.MeterPerPicosecond
                                                                   , 1852.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per attosecond. Defined as: ((1852.0)/(1.0/1000.0)) × SI meter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerAttosecond = new (
                                                                    "nautical mile per attosecond"
                                                                  , "nmi/as"
                                                                  , SI.Velocities.MeterPerFemtosecond
                                                                  , 1852.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nautical mile per zeptosecond. Defined as: ((1852.0)/(1.0/1000.0)) × SI meter per attosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerZeptosecond = new (
                                                                     "nautical mile per zeptosecond"
                                                                   , "nmi/zs"
                                                                   , SI.Velocities.MeterPerAttosecond
                                                                   , 1852.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per yoctosecond. Defined as: ((1852.0)/(1.0/1000.0)) × SI meter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerYoctosecond = new (
                                                                     "nautical mile per yoctosecond"
                                                                   , "nmi/ys"
                                                                   , SI.Velocities.MeterPerZeptosecond
                                                                   , 1852.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per rontosecond. Defined as: ((1852.0)/(1.0/1000.0)) × SI meter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerRontosecond = new (
                                                                     "nautical mile per rontosecond"
                                                                   , "nmi/rs"
                                                                   , SI.Velocities.MeterPerYoctosecond
                                                                   , 1852.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per quectosecond. Defined as: ((1852.0)/(1.0/1000.0)) × SI meter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuectosecond = new (
                                                                      "nautical mile per quectosecond"
                                                                    , "nmi/qs"
                                                                    , SI.Velocities.MeterPerRontosecond
                                                                    , 1852.0 / (1.0 / 1000.0)
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
   /// A(n) mil per planck-time. Defined as: ((1.0/1000.0)/(5.391247E-38)) × inch per microsecond + (0).
   /// </summary>
   public static readonly Velocity MilPerPlanckTime = new (
                                                           "mil per planck-time"
                                                         , "mil/tₚ"
                                                         , InchPerMicrosecond
                                                         , 1.0 / 1000.0 / 5.391247E-38
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) mil per minute. Defined as: ((1.0/1000.0)/(60.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity MilPerMinute = new (
                                                       "mil per minute"
                                                     , "mil/min"
                                                     , InchPerSecond
                                                     , 1.0 / 1000.0 / 60.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) point per planck-time. Defined as: ((1.0/72.0)/(5.391247E-38)) × inch per microsecond + (0).
   /// </summary>
   public static readonly Velocity PointPerPlanckTime = new (
                                                             "point per planck-time"
                                                           , "p/tₚ"
                                                           , InchPerMicrosecond
                                                           , 1.0 / 72.0 / 5.391247E-38
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) foot per septillion years. Defined as: ((12.0)/(1000.0)) × inch per sextillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerSeptillionYears =
            new ("foot per septillion years", "ft/Yyr", InchPerSextillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) twip per tick. Defined as: ((1.0/20.0)/(100.0)) × point per nanosecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerTick = new (
                                                      "twip per tick"
                                                    , "twip/tick"
                                                    , PointPerNanosecond
                                                    , 1.0 / 20.0 / 100.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) foot per week. Defined as: ((12.0)/(7.0)) × inch per day + (0).
   /// </summary>
   public static readonly Velocity FootPerWeek = new ("foot per week", "ft/wk", InchPerDay, 12.0 / 7.0, 0);

   /// <summary>
   /// A(n) point per billion years. Defined as: ((1.0/72.0)/(1000.0)) × inch per million years + (0).
   /// </summary>
   public static readonly Velocity PointPerBillionYears = new (
                                                               "point per billion years"
                                                             , "p/Gyr"
                                                             , InchPerMillionYears
                                                             , 1.0 / 72.0 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) twip per planck-time. Defined as: ((1.0/20.0)/(5.391247E-38)) × point per microsecond + (0).
   /// </summary>
   public static readonly Velocity TwipPerPlanckTime = new (
                                                            "twip per planck-time"
                                                          , "twip/tₚ"
                                                          , PointPerMicrosecond
                                                          , 1.0 / 20.0 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) mil per hour. Defined as: ((1.0/1000.0)/(60.0)) × inch per minute + (0).
   /// </summary>
   public static readonly Velocity MilPerHour = new ("mil per hour", "mil/hr", InchPerMinute, 1.0 / 1000.0 / 60.0, 0);

   /// <summary>
   /// A(n) point per minute. Defined as: ((1.0/72.0)/(60.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity PointPerMinute = new (
                                                         "point per minute"
                                                       , "p/min"
                                                       , InchPerSecond
                                                       , 1.0 / 72.0 / 60.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) pica per planck-time. Defined as: ((12.0)/(5.391247E-38)) × point per microsecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerPlanckTime = new (
                                                            "pica per planck-time"
                                                          , "P/tₚ"
                                                          , PointPerMicrosecond
                                                          , 12.0 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) yard per tick. Defined as: ((3.0)/(100.0)) × foot per nanosecond + (0).
   /// </summary>
   public static readonly Velocity YardPerTick = new ("yard per tick", "yd/tick", FootPerNanosecond, 3.0 / 100.0, 0);

   /// <summary>
   /// A(n) nautical mile per nonillion years. Defined as: ((1852.0)/(1000.0)) × SI meter per octillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerNonillionYears = new (
                                                                        "nautical mile per nonillion years"
                                                                      , "nmi/Qyr"
                                                                      , SI.Velocities.MeterPerOctillionYears
                                                                      , 1852.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) foot per planck-time. Defined as: ((12.0)/(5.391247E-38)) × inch per microsecond + (0).
   /// </summary>
   public static readonly Velocity FootPerPlanckTime = new (
                                                            "foot per planck-time"
                                                          , "ft/tₚ"
                                                          , InchPerMicrosecond
                                                          , 12.0 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) nautical mile per quadrillion years. Defined as: ((1852.0)/(1000.0)) × SI meter per trillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuadrillionYears = new (
                                                                          "nautical mile per quadrillion years"
                                                                        , "nmi/Pyr"
                                                                        , SI.Velocities.MeterPerTrillionYears
                                                                        , 1852.0 / 1000.0
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) mil per day. Defined as: ((1.0/1000.0)/(24.0)) × inch per hour + (0).
   /// </summary>
   public static readonly Velocity MilPerDay = new ("mil per day", "mil/dy", InchPerHour, 1.0 / 1000.0 / 24.0, 0);

   /// <summary>
   /// A(n) twip per minute. Defined as: ((1.0/20.0)/(60.0)) × point per second + (0).
   /// </summary>
   public static readonly Velocity TwipPerMinute = new (
                                                        "twip per minute"
                                                      , "twip/min"
                                                      , PointPerSecond
                                                      , 1.0 / 20.0 / 60.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) foot per millennium. Defined as: ((12.0)/(10.0)) × inch per century + (0).
   /// </summary>
   public static readonly Velocity FootPerMillennium = new (
                                                            "foot per millennium"
                                                          , "ft/kyr"
                                                          , InchPerCentury
                                                          , 12.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) nautical mile per century. Defined as: ((1852.0)/(10.0)) × SI meter per decade + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerCentury = new (
                                                                 "nautical mile per century"
                                                               , "nmi/century"
                                                               , SI.Velocities.MeterPerDecade
                                                               , 1852.0 / 10.0
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
   /// A(n) point per trillion years. Defined as: ((1.0/72.0)/(1000.0)) × inch per billion years + (0).
   /// </summary>
   public static readonly Velocity PointPerTrillionYears = new (
                                                                "point per trillion years"
                                                              , "p/Tyr"
                                                              , InchPerBillionYears
                                                              , 1.0 / 72.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) nautical mile per hour. Defined as: ((1852.0)/(60.0)) × SI meter per minute + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerHour = new (
                                                              "nautical mile per hour"
                                                            , "nmi/hr"
                                                            , SI.Velocities.MeterPerMinute
                                                            , 1852.0 / 60.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) fathom per tick. Defined as: ((2.0)/(100.0)) × yard per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerTick = new (
                                                        "fathom per tick"
                                                      , "ftm/tick"
                                                      , YardPerNanosecond
                                                      , 2.0 / 100.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) yard per octillion years. Defined as: ((3.0)/(1000.0)) × foot per septillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerOctillionYears =
            new ("yard per octillion years", "yd/Ryr", FootPerSeptillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per planck-time. Defined as: ((1760.0)/(5.391247E-38)) × yard per microsecond + (0).
   /// </summary>
   public static readonly Velocity MilePerPlanckTime = new (
                                                            "mile per planck-time"
                                                          , "mi/tₚ"
                                                          , YardPerMicrosecond
                                                          , 1760.0 / 5.391247E-38
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) point per hour. Defined as: ((1.0/72.0)/(60.0)) × inch per minute + (0).
   /// </summary>
   public static readonly Velocity PointPerHour = new ("point per hour", "p/hr", InchPerMinute, 1.0 / 72.0 / 60.0, 0);

   /// <summary>
   /// A(n) mil per week. Defined as: ((1.0/1000.0)/(7.0)) × inch per day + (0).
   /// </summary>
   public static readonly Velocity MilPerWeek = new ("mil per week", "mil/wk", InchPerDay, 1.0 / 1000.0 / 7.0, 0);

   /// <summary>
   /// A(n) pica per minute. Defined as: ((12.0)/(60.0)) × point per second + (0).
   /// </summary>
   public static readonly Velocity PicaPerMinute = new ("pica per minute", "P/min", PointPerSecond, 12.0 / 60.0, 0);

   /// <summary>
   /// A(n) league per planck-time. Defined as: ((3.0)/(5.391247E-38)) × mile per microsecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerPlanckTime =
            new ("league per planck-time", "le/tₚ", MilePerMicrosecond, 3.0 / 5.391247E-38, 0);

   /// <summary>
   /// A(n) foot per quadrillion years. Defined as: ((12.0)/(1000.0)) × inch per trillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerQuadrillionYears =
            new ("foot per quadrillion years", "ft/Pyr", InchPerTrillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per planck-time. Defined as: ((2.0)/(5.391247E-38)) × yard per microsecond + (0).
   /// </summary>
   public static readonly Velocity FathomPerPlanckTime =
            new ("fathom per planck-time", "ftm/tₚ", YardPerMicrosecond, 2.0 / 5.391247E-38, 0);

   /// <summary>
   /// A(n) mil per year. Defined as: ((1.0/1000.0)/(365.2525)) × inch per day + (0).
   /// </summary>
   public static readonly Velocity MilPerYear = new ("mil per year", "mil/yr", InchPerDay, 1.0 / 1000.0 / 365.2525, 0);

   /// <summary>
   /// A(n) foot per minute. Defined as: ((12.0)/(60.0)) × inch per second + (0).
   /// </summary>
   public static readonly Velocity FootPerMinute = new ("foot per minute", "ft/min", InchPerSecond, 12.0 / 60.0, 0);

   /// <summary>
   /// A(n) fathom per nonillion years. Defined as: ((2.0)/(1000.0)) × yard per octillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerNonillionYears =
            new ("fathom per nonillion years", "ftm/Qyr", YardPerOctillionYears, 2.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per planck-time. Defined as: ((120.0)/(5.391247E-38)) × fathom per microsecond + (0).
   /// </summary>
   public static readonly Velocity CablePerPlanckTime = new (
                                                             "cable per planck-time"
                                                           , "cb/tₚ"
                                                           , FathomPerMicrosecond
                                                           , 120.0 / 5.391247E-38
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) point per quadrillion years. Defined as: ((1.0/72.0)/(1000.0)) × inch per trillion years + (0).
   /// </summary>
   public static readonly Velocity PointPerQuadrillionYears = new (
                                                                   "point per quadrillion years"
                                                                 , "p/Pyr"
                                                                 , InchPerTrillionYears
                                                                 , 1.0 / 72.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) point per day. Defined as: ((1.0/72.0)/(24.0)) × inch per hour + (0).
   /// </summary>
   public static readonly Velocity PointPerDay = new ("point per day", "p/dy", InchPerHour, 1.0 / 72.0 / 24.0, 0);

   /// <summary>
   /// A(n) twip per hour. Defined as: ((1.0/20.0)/(60.0)) × point per minute + (0).
   /// </summary>
   public static readonly Velocity TwipPerHour = new ("twip per hour", "twip/hr", PointPerMinute, 1.0 / 20.0 / 60.0, 0);

   /// <summary>
   /// A(n) mil per decade. Defined as: ((1.0/1000.0)/(10.0)) × inch per year + (0).
   /// </summary>
   public static readonly Velocity MilPerDecade = new (
                                                       "mil per decade"
                                                     , "mil/decade"
                                                     , InchPerYear
                                                     , 1.0 / 1000.0 / 10.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) yard per minute. Defined as: ((3.0)/(60.0)) × foot per second + (0).
   /// </summary>
   public static readonly Velocity YardPerMinute = new ("yard per minute", "yd/min", FootPerSecond, 3.0 / 60.0, 0);

   /// <summary>
   /// A(n) nautical mile per planck-time. Defined as: ((1852.0)/(5.391247E-38)) × SI meter per microsecond + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerPlanckTime = new (
                                                                    "nautical mile per planck-time"
                                                                  , "nmi/tₚ"
                                                                  , SI.Velocities.MeterPerMicrosecond
                                                                  , 1852.0 / 5.391247E-38
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) foot per octillion years. Defined as: ((12.0)/(1000.0)) × inch per septillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerOctillionYears =
            new ("foot per octillion years", "ft/Ryr", InchPerSeptillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nautical mile per sextillion years. Defined as: ((1852.0)/(1000.0)) × SI meter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSextillionYears = new (
                                                                         "nautical mile per sextillion years"
                                                                       , "nmi/Zyr"
                                                                       , SI.Velocities.MeterPerQuintillionYears
                                                                       , 1852.0 / 1000.0
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) foot per year. Defined as: ((12.0)/(365.2525)) × inch per day + (0).
   /// </summary>
   public static readonly Velocity FootPerYear = new ("foot per year", "ft/yr", InchPerDay, 12.0 / 365.2525, 0);

   /// <summary>
   /// A(n) mil per tick. Defined as: ((1.0/1000.0)/(100.0)) × inch per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MilPerTick = new (
                                                     "mil per tick"
                                                   , "mil/tick"
                                                   , InchPerNanosecond
                                                   , 1.0 / 1000.0 / 100.0
                                                   , 0
                                                    );

   /// <summary>
   /// A(n) nautical mile per million years. Defined as: ((1852.0)/(1000.0)) × SI meter per millennium + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillionYears = new (
                                                                      "nautical mile per million years"
                                                                    , "nmi/Myr"
                                                                    , SI.Velocities.MeterPerMillennium
                                                                    , 1852.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mil per century. Defined as: ((1.0/1000.0)/(10.0)) × inch per decade + (0).
   /// </summary>
   public static readonly Velocity MilPerCentury = new (
                                                        "mil per century"
                                                      , "mil/century"
                                                      , InchPerDecade
                                                      , 1.0 / 1000.0 / 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) mile per minute. Defined as: ((1760.0)/(60.0)) × yard per second + (0).
   /// </summary>
   public static readonly Velocity MilePerMinute = new ("mile per minute", "mi/min", YardPerSecond, 1760.0 / 60.0, 0);

   /// <summary>
   /// A(n) pica per trillion years. Defined as: ((12.0)/(1000.0)) × point per billion years + (0).
   /// </summary>
   public static readonly Velocity PicaPerTrillionYears =
            new ("pica per trillion years", "P/Tyr", PointPerBillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nautical mile per week. Defined as: ((1852.0)/(7.0)) × SI meter per day + (0).
   /// </summary>
   public static readonly Velocity NauticalMilePerWeek = new (
                                                              "nautical mile per week"
                                                            , "nmi/wk"
                                                            , SI.Velocities.MeterPerDay
                                                            , 1852.0 / 7.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) point per quintillion years. Defined as: ((1.0/72.0)/(1000.0)) × inch per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity PointPerQuintillionYears = new (
                                                                   "point per quintillion years"
                                                                 , "p/Eyr"
                                                                 , InchPerQuadrillionYears
                                                                 , 1.0 / 72.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) pica per tick. Defined as: ((12.0)/(100.0)) × point per nanosecond + (0).
   /// </summary>
   public static readonly Velocity PicaPerTick = new ("pica per tick", "P/tick", PointPerNanosecond, 12.0 / 100.0, 0);

   /// <summary>
   /// A(n) point per week. Defined as: ((1.0/72.0)/(7.0)) × inch per day + (0).
   /// </summary>
   public static readonly Velocity PointPerWeek = new ("point per week", "p/wk", InchPerDay, 1.0 / 72.0 / 7.0, 0);

   /// <summary>
   /// A(n) pica per hour. Defined as: ((12.0)/(60.0)) × point per minute + (0).
   /// </summary>
   public static readonly Velocity PicaPerHour = new ("pica per hour", "P/hr", PointPerMinute, 12.0 / 60.0, 0);

   /// <summary>
   /// A(n) mil per millennium. Defined as: ((1.0/1000.0)/(10.0)) × inch per century + (0).
   /// </summary>
   public static readonly Velocity MilPerMillennium = new (
                                                           "mil per millennium"
                                                         , "mil/kyr"
                                                         , InchPerCentury
                                                         , 1.0 / 1000.0 / 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) league per minute. Defined as: ((3.0)/(60.0)) × mile per second + (0).
   /// </summary>
   public static readonly Velocity LeaguePerMinute = new ("league per minute", "le/min", MilePerSecond, 3.0 / 60.0, 0);

   /// <summary>
   /// A(n) foot per million years. Defined as: ((12.0)/(1000.0)) × inch per millennium + (0).
   /// </summary>
   public static readonly Velocity FootPerMillionYears =
            new ("foot per million years", "ft/Myr", InchPerMillennium, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per nonillion years. Defined as: ((1760.0)/(1000.0)) × yard per octillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerNonillionYears =
            new ("mile per nonillion years", "mi/Qyr", YardPerOctillionYears, 1760.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per tick. Defined as: ((1760.0)/(100.0)) × yard per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MilePerTick = new ("mile per tick", "mi/tick", YardPerNanosecond, 1760.0 / 100.0, 0);

   /// <summary>
   /// A(n) twip per day. Defined as: ((1.0/20.0)/(24.0)) × point per hour + (0).
   /// </summary>
   public static readonly Velocity TwipPerDay = new ("twip per day", "twip/dy", PointPerHour, 1.0 / 20.0 / 24.0, 0);

   /// <summary>
   /// A(n) mil per million years. Defined as: ((1.0/1000.0)/(1000.0)) × inch per millennium + (0).
   /// </summary>
   public static readonly Velocity MilPerMillionYears = new (
                                                             "mil per million years"
                                                           , "mil/Myr"
                                                           , InchPerMillennium
                                                           , 1.0 / 1000.0 / 1000.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) fathom per minute. Defined as: ((2.0)/(60.0)) × yard per second + (0).
   /// </summary>
   public static readonly Velocity FathomPerMinute = new ("fathom per minute", "ftm/min", YardPerSecond, 2.0 / 60.0, 0);

   /// <summary>
   /// A(n) point per sextillion years. Defined as: ((1.0/72.0)/(1000.0)) × inch per quintillion years + (0).
   /// </summary>
   public static readonly Velocity PointPerSextillionYears = new (
                                                                  "point per sextillion years"
                                                                , "p/Zyr"
                                                                , InchPerQuintillionYears
                                                                , 1.0 / 72.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) foot per quintillion years. Defined as: ((12.0)/(1000.0)) × inch per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerQuintillionYears = new (
                                                                  "foot per quintillion years"
                                                                , "ft/Eyr"
                                                                , InchPerQuadrillionYears
                                                                , 12.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yard per nonillion years. Defined as: ((3.0)/(1000.0)) × foot per octillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerNonillionYears =
            new ("yard per nonillion years", "yd/Qyr", FootPerOctillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) point per year. Defined as: ((1.0/72.0)/(365.2525)) × inch per day + (0).
   /// </summary>
   public static readonly Velocity PointPerYear = new ("point per year", "p/yr", InchPerDay, 1.0 / 72.0 / 365.2525, 0);

   /// <summary>
   /// A(n) foot per hour. Defined as: ((12.0)/(60.0)) × inch per minute + (0).
   /// </summary>
   public static readonly Velocity FootPerHour = new ("foot per hour", "ft/hr", InchPerMinute, 12.0 / 60.0, 0);

   /// <summary>
   /// A(n) mil per billion years. Defined as: ((1.0/1000.0)/(1000.0)) × inch per million years + (0).
   /// </summary>
   public static readonly Velocity MilPerBillionYears = new (
                                                             "mil per billion years"
                                                           , "mil/Gyr"
                                                           , InchPerMillionYears
                                                           , 1.0 / 1000.0 / 1000.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) cable per minute. Defined as: ((120.0)/(60.0)) × fathom per second + (0).
   /// </summary>
   public static readonly Velocity CablePerMinute = new (
                                                         "cable per minute"
                                                       , "cb/min"
                                                       , FathomPerSecond
                                                       , 120.0 / 60.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cable per tick. Defined as: ((120.0)/(100.0)) × fathom per nanosecond + (0).
   /// </summary>
   public static readonly Velocity CablePerTick = new (
                                                       "cable per tick"
                                                     , "cb/tick"
                                                     , FathomPerNanosecond
                                                     , 120.0 / 100.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) yard per sextillion years. Defined as: ((3.0)/(1000.0)) × foot per quintillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerSextillionYears =
            new ("yard per sextillion years", "yd/Zyr", FootPerQuintillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mil per trillion years. Defined as: ((1.0/1000.0)/(1000.0)) × inch per billion years + (0).
   /// </summary>
   public static readonly Velocity MilPerTrillionYears = new (
                                                              "mil per trillion years"
                                                            , "mil/Tyr"
                                                            , InchPerBillionYears
                                                            , 1.0 / 1000.0 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) pica per quadrillion years. Defined as: ((12.0)/(1000.0)) × point per trillion years + (0).
   /// </summary>
   public static readonly Velocity PicaPerQuadrillionYears =
            new ("pica per quadrillion years", "P/Pyr", PointPerTrillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) foot per nonillion years. Defined as: ((12.0)/(1000.0)) × inch per octillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerNonillionYears =
            new ("foot per nonillion years", "ft/Qyr", InchPerOctillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) foot per decade. Defined as: ((12.0)/(10.0)) × inch per year + (0).
   /// </summary>
   public static readonly Velocity FootPerDecade = new ("foot per decade", "ft/decade", InchPerYear, 12.0 / 10.0, 0);

   /// <summary>
   /// A(n) point per septillion years. Defined as: ((1.0/72.0)/(1000.0)) × inch per sextillion years + (0).
   /// </summary>
   public static readonly Velocity PointPerSeptillionYears = new (
                                                                  "point per septillion years"
                                                                , "p/Yyr"
                                                                , InchPerSextillionYears
                                                                , 1.0 / 72.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) twip per week. Defined as: ((1.0/20.0)/(7.0)) × point per day + (0).
   /// </summary>
   public static readonly Velocity TwipPerWeek = new ("twip per week", "twip/wk", PointPerDay, 1.0 / 20.0 / 7.0, 0);

   /// <summary>
   /// A(n) pica per day. Defined as: ((12.0)/(24.0)) × point per hour + (0).
   /// </summary>
   public static readonly Velocity PicaPerDay = new ("pica per day", "P/dy", PointPerHour, 12.0 / 24.0, 0);

   /// <summary>
   /// A(n) point per decade. Defined as: ((1.0/72.0)/(10.0)) × inch per year + (0).
   /// </summary>
   public static readonly Velocity PointPerDecade = new (
                                                         "point per decade"
                                                       , "p/decade"
                                                       , InchPerYear
                                                       , 1.0 / 72.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) yard per hour. Defined as: ((3.0)/(60.0)) × foot per minute + (0).
   /// </summary>
   public static readonly Velocity YardPerHour = new ("yard per hour", "yd/hr", FootPerMinute, 3.0 / 60.0, 0);

   /// <summary>
   /// A(n) mil per quadrillion years. Defined as: ((1.0/1000.0)/(1000.0)) × inch per trillion years + (0).
   /// </summary>
   public static readonly Velocity MilPerQuadrillionYears = new (
                                                                 "mil per quadrillion years"
                                                               , "mil/Pyr"
                                                               , InchPerTrillionYears
                                                               , 1.0 / 1000.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) mile per septillion years. Defined as: ((1760.0)/(1000.0)) × yard per sextillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerSeptillionYears = new (
                                                                 "mile per septillion years"
                                                               , "mi/Yyr"
                                                               , YardPerSextillionYears
                                                               , 1760.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) mil per quintillion years. Defined as: ((1.0/1000.0)/(1000.0)) × inch per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity MilPerQuintillionYears = new (
                                                                 "mil per quintillion years"
                                                               , "mil/Eyr"
                                                               , InchPerQuadrillionYears
                                                               , 1.0 / 1000.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) foot per billion years. Defined as: ((12.0)/(1000.0)) × inch per million years + (0).
   /// </summary>
   public static readonly Velocity FootPerBillionYears =
            new ("foot per billion years", "ft/Gyr", InchPerMillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) point per tick. Defined as: ((1.0/72.0)/(100.0)) × inch per nanosecond + (0).
   /// </summary>
   public static readonly Velocity PointPerTick = new (
                                                       "point per tick"
                                                     , "p/tick"
                                                     , InchPerNanosecond
                                                     , 1.0 / 72.0 / 100.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) point per octillion years. Defined as: ((1.0/72.0)/(1000.0)) × inch per septillion years + (0).
   /// </summary>
   public static readonly Velocity PointPerOctillionYears = new (
                                                                 "point per octillion years"
                                                               , "p/Ryr"
                                                               , InchPerSeptillionYears
                                                               , 1.0 / 72.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) cable per decillion years. Defined as: ((120.0)/(1000.0)) × fathom per nonillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerDecillionYears = new (
                                                                 "cable per decillion years"
                                                               , "cb/decillion yr"
                                                               , FathomPerNonillionYears
                                                               , 120.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) point per century. Defined as: ((1.0/72.0)/(10.0)) × inch per decade + (0).
   /// </summary>
   public static readonly Velocity PointPerCentury = new (
                                                          "point per century"
                                                        , "p/century"
                                                        , InchPerDecade
                                                        , 1.0 / 72.0 / 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) mile per hour. Defined as: ((1760.0)/(60.0)) × yard per minute + (0).
   /// </summary>
   public static readonly Velocity MilePerHour = new ("mile per hour", "mi/hr", YardPerMinute, 1760.0 / 60.0, 0);

   /// <summary>
   /// A(n) mil per sextillion years. Defined as: ((1.0/1000.0)/(1000.0)) × inch per quintillion years + (0).
   /// </summary>
   public static readonly Velocity MilPerSextillionYears = new (
                                                                "mil per sextillion years"
                                                              , "mil/Zyr"
                                                              , InchPerQuintillionYears
                                                              , 1.0 / 1000.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) twip per nonillion years. Defined as: ((1.0/20.0)/(1000.0)) × point per octillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerNonillionYears = new (
                                                                "twip per nonillion years"
                                                              , "twip/Qyr"
                                                              , PointPerOctillionYears
                                                              , 1.0 / 20.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) foot per tick. Defined as: ((12.0)/(100.0)) × inch per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FootPerTick = new ("foot per tick", "ft/tick", InchPerNanosecond, 12.0 / 100.0, 0);

   /// <summary>
   /// A(n) fathom per decillion years. Defined as: ((2.0)/(1000.0)) × yard per nonillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerDecillionYears = new (
                                                                  "fathom per decillion years"
                                                                , "ftm/decillion yr"
                                                                , YardPerNonillionYears
                                                                , 2.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) twip per trillion years. Defined as: ((1.0/20.0)/(1000.0)) × point per billion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerTrillionYears = new (
                                                               "twip per trillion years"
                                                             , "twip/Tyr"
                                                             , PointPerBillionYears
                                                             , 1.0 / 20.0 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) foot per sextillion years. Defined as: ((12.0)/(1000.0)) × inch per quintillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerSextillionYears =
            new ("foot per sextillion years", "ft/Zyr", InchPerQuintillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per decillion years. Defined as: ((3.0)/(1000.0)) × mile per nonillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerDecillionYears = new (
                                                                  "league per decillion years"
                                                                , "le/decillion yr"
                                                                , MilePerNonillionYears
                                                                , 3.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) twip per year. Defined as: ((1.0/20.0)/(365.2525)) × point per day + (0).
   /// </summary>
   public static readonly Velocity TwipPerYear = new (
                                                      "twip per year"
                                                    , "twip/yr"
                                                    , PointPerDay
                                                    , 1.0 / 20.0 / 365.2525
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) foot per day. Defined as: ((12.0)/(24.0)) × inch per hour + (0).
   /// </summary>
   public static readonly Velocity FootPerDay = new ("foot per day", "ft/dy", InchPerHour, 12.0 / 24.0, 0);

   /// <summary>
   /// A(n) mil per septillion years. Defined as: ((1.0/1000.0)/(1000.0)) × inch per sextillion years + (0).
   /// </summary>
   public static readonly Velocity MilPerSeptillionYears = new (
                                                                "mil per septillion years"
                                                              , "mil/Yyr"
                                                              , InchPerSextillionYears
                                                              , 1.0 / 1000.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) pica per quintillion years. Defined as: ((12.0)/(1000.0)) × point per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity PicaPerQuintillionYears = new (
                                                                  "pica per quintillion years"
                                                                , "P/Eyr"
                                                                , PointPerQuadrillionYears
                                                                , 12.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) mile per decillion years. Defined as: ((1760.0)/(1000.0)) × yard per nonillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerDecillionYears = new (
                                                                "mile per decillion years"
                                                              , "mi/decillion yr"
                                                              , YardPerNonillionYears
                                                              , 1760.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) league per tick. Defined as: ((3.0)/(100.0)) × mile per nanosecond + (0).
   /// </summary>
   public static readonly Velocity LeaguePerTick = new (
                                                        "league per tick"
                                                      , "le/tick"
                                                      , MilePerNanosecond
                                                      , 3.0 / 100.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) point per nonillion years. Defined as: ((1.0/72.0)/(1000.0)) × inch per octillion years + (0).
   /// </summary>
   public static readonly Velocity PointPerNonillionYears = new (
                                                                 "point per nonillion years"
                                                               , "p/Qyr"
                                                               , InchPerOctillionYears
                                                               , 1.0 / 72.0 / 1000.0
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
   /// A(n) pica per week. Defined as: ((12.0)/(7.0)) × point per day + (0).
   /// </summary>
   public static readonly Velocity PicaPerWeek = new ("pica per week", "P/wk", PointPerDay, 12.0 / 7.0, 0);

   /// <summary>
   /// A(n) point per millennium. Defined as: ((1.0/72.0)/(10.0)) × inch per century + (0).
   /// </summary>
   public static readonly Velocity PointPerMillennium = new (
                                                             "point per millennium"
                                                           , "p/kyr"
                                                           , InchPerCentury
                                                           , 1.0 / 72.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) league per hour. Defined as: ((3.0)/(60.0)) × mile per minute + (0).
   /// </summary>
   public static readonly Velocity LeaguePerHour = new ("league per hour", "le/hr", MilePerMinute, 3.0 / 60.0, 0);

   /// <summary>
   /// A(n) mil per octillion years. Defined as: ((1.0/1000.0)/(1000.0)) × inch per septillion years + (0).
   /// </summary>
   public static readonly Velocity MilPerOctillionYears = new (
                                                               "mil per octillion years"
                                                             , "mil/Ryr"
                                                             , InchPerSeptillionYears
                                                             , 1.0 / 1000.0 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) yard per septillion years. Defined as: ((3.0)/(1000.0)) × foot per sextillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerSeptillionYears =
            new ("yard per septillion years", "yd/Yyr", FootPerSextillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) foot per decillion years. Defined as: ((12.0)/(1000.0)) × inch per nonillion years + (0).
   /// </summary>
   public static readonly Velocity FootPerDecillionYears = new (
                                                                "foot per decillion years"
                                                              , "ft/decillion yr"
                                                              , InchPerNonillionYears
                                                              , 12.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) foot per century. Defined as: ((12.0)/(10.0)) × inch per decade + (0).
   /// </summary>
   public static readonly Velocity FootPerCentury = new (
                                                         "foot per century"
                                                       , "ft/century"
                                                       , InchPerDecade
                                                       , 12.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) pica per decillion years. Defined as: ((12.0)/(1000.0)) × point per nonillion years + (0).
   /// </summary>
   public static readonly Velocity PicaPerDecillionYears = new (
                                                                "pica per decillion years"
                                                              , "P/decillion yr"
                                                              , PointPerNonillionYears
                                                              , 12.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) mil per nonillion years. Defined as: ((1.0/1000.0)/(1000.0)) × inch per octillion years + (0).
   /// </summary>
   public static readonly Velocity MilPerNonillionYears = new (
                                                               "mil per nonillion years"
                                                             , "mil/Qyr"
                                                             , InchPerOctillionYears
                                                             , 1.0 / 1000.0 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) yard per million years. Defined as: ((3.0)/(1000.0)) × foot per millennium + (0).
   /// </summary>
   public static readonly Velocity YardPerMillionYears =
            new ("yard per million years", "yd/Myr", FootPerMillennium, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) twip per decillion years. Defined as: ((1.0/20.0)/(1000.0)) × point per nonillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerDecillionYears = new (
                                                                "twip per decillion years"
                                                              , "twip/decillion yr"
                                                              , PointPerNonillionYears
                                                              , 1.0 / 20.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) league per octillion years. Defined as: ((3.0)/(1000.0)) × mile per septillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerOctillionYears =
            new ("league per octillion years", "le/Ryr", MilePerSeptillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yard per decade. Defined as: ((3.0)/(10.0)) × foot per year + (0).
   /// </summary>
   public static readonly Velocity YardPerDecade = new ("yard per decade", "yd/decade", FootPerYear, 3.0 / 10.0, 0);

   /// <summary>
   /// A(n) pica per million years. Defined as: ((12.0)/(1000.0)) × point per millennium + (0).
   /// </summary>
   public static readonly Velocity PicaPerMillionYears =
            new ("pica per million years", "P/Myr", PointPerMillennium, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) twip per quadrillion years. Defined as: ((1.0/20.0)/(1000.0)) × point per trillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerQuadrillionYears = new (
                                                                  "twip per quadrillion years"
                                                                , "twip/Pyr"
                                                                , PointPerTrillionYears
                                                                , 1.0 / 20.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) point per decillion years. Defined as: ((1.0/72.0)/(1000.0)) × inch per nonillion years + (0).
   /// </summary>
   public static readonly Velocity PointPerDecillionYears = new (
                                                                 "point per decillion years"
                                                               , "p/decillion yr"
                                                               , InchPerNonillionYears
                                                               , 1.0 / 72.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) twip per decade. Defined as: ((1.0/20.0)/(10.0)) × point per year + (0).
   /// </summary>
   public static readonly Velocity TwipPerDecade = new (
                                                        "twip per decade"
                                                      , "twip/decade"
                                                      , PointPerYear
                                                      , 1.0 / 20.0 / 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) yard per day. Defined as: ((3.0)/(24.0)) × foot per hour + (0).
   /// </summary>
   public static readonly Velocity YardPerDay = new ("yard per day", "yd/dy", FootPerHour, 3.0 / 24.0, 0);

   /// <summary>
   /// A(n) point per million years. Defined as: ((1.0/72.0)/(1000.0)) × inch per millennium + (0).
   /// </summary>
   public static readonly Velocity PointPerMillionYears =
            new ("point per million years", "p/Myr", InchPerMillennium, 1.0 / 72.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per hour. Defined as: ((2.0)/(60.0)) × yard per minute + (0).
   /// </summary>
   public static readonly Velocity FathomPerHour = new ("fathom per hour", "ftm/hr", YardPerMinute, 2.0 / 60.0, 0);

   /// <summary>
   /// A(n) mil per decillion years. Defined as: ((1.0/1000.0)/(1000.0)) × inch per nonillion years + (0).
   /// </summary>
   public static readonly Velocity MilPerDecillionYears = new (
                                                               "mil per decillion years"
                                                             , "mil/decillion yr"
                                                             , InchPerNonillionYears
                                                             , 1.0 / 1000.0 / 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) foot per trillion years. Defined as: ((12.0)/(1000.0)) × inch per billion years + (0).
   /// </summary>
   public static readonly Velocity FootPerTrillionYears =
            new ("foot per trillion years", "ft/Tyr", InchPerBillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) pica per sextillion years. Defined as: ((12.0)/(1000.0)) × point per quintillion years + (0).
   /// </summary>
   public static readonly Velocity PicaPerSextillionYears =
            new ("pica per sextillion years", "P/Zyr", PointPerQuintillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per octillion years. Defined as: ((1760.0)/(1000.0)) × yard per septillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerOctillionYears = new (
                                                                "mile per octillion years"
                                                              , "mi/Ryr"
                                                              , YardPerSeptillionYears
                                                              , 1760.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) pica per year. Defined as: ((12.0)/(365.2525)) × point per day + (0).
   /// </summary>
   public static readonly Velocity PicaPerYear = new ("pica per year", "P/yr", PointPerDay, 12.0 / 365.2525, 0);

   /// <summary>
   /// A(n) cable per hour. Defined as: ((120.0)/(60.0)) × fathom per minute + (0).
   /// </summary>
   public static readonly Velocity CablePerHour = new ("cable per hour", "cb/hr", FathomPerMinute, 120.0 / 60.0, 0);

   /// <summary>
   /// A(n) twip per quintillion years. Defined as: ((1.0/20.0)/(1000.0)) × point per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerQuintillionYears = new (
                                                                  "twip per quintillion years"
                                                                , "twip/Eyr"
                                                                , PointPerQuadrillionYears
                                                                , 1.0 / 20.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) twip per century. Defined as: ((1.0/20.0)/(10.0)) × point per decade + (0).
   /// </summary>
   public static readonly Velocity TwipPerCentury = new (
                                                         "twip per century"
                                                       , "twip/century"
                                                       , PointPerDecade
                                                       , 1.0 / 20.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) mile per day. Defined as: ((1760.0)/(24.0)) × yard per hour + (0).
   /// </summary>
   public static readonly Velocity MilePerDay = new ("mile per day", "mi/dy", YardPerHour, 1760.0 / 24.0, 0);

   /// <summary>
   /// A(n) league per year. Defined as: ((3.0)/(365.2525)) × mile per day + (0).
   /// </summary>
   public static readonly Velocity LeaguePerYear = new ("league per year", "le/yr", MilePerDay, 3.0 / 365.2525, 0);

   /// <summary>
   /// A(n) pica per billion years. Defined as: ((12.0)/(1000.0)) × point per million years + (0).
   /// </summary>
   public static readonly Velocity PicaPerBillionYears =
            new ("pica per billion years", "P/Gyr", PointPerMillionYears, 12.0 / 1000.0, 0);

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
   /// A(n) pica per septillion years. Defined as: ((12.0)/(1000.0)) × point per sextillion years + (0).
   /// </summary>
   public static readonly Velocity PicaPerSeptillionYears =
            new ("pica per septillion years", "P/Yyr", PointPerSextillionYears, 12.0 / 1000.0, 0);

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
   /// A(n) twip per sextillion years. Defined as: ((1.0/20.0)/(1000.0)) × point per quintillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerSextillionYears = new (
                                                                 "twip per sextillion years"
                                                               , "twip/Zyr"
                                                               , PointPerQuintillionYears
                                                               , 1.0 / 20.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) pica per decade. Defined as: ((12.0)/(10.0)) × point per year + (0).
   /// </summary>
   public static readonly Velocity PicaPerDecade = new ("pica per decade", "P/decade", PointPerYear, 12.0 / 10.0, 0);

   /// <summary>
   /// A(n) yard per week. Defined as: ((3.0)/(7.0)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity YardPerWeek = new ("yard per week", "yd/wk", FootPerDay, 3.0 / 7.0, 0);

   /// <summary>
   /// A(n) twip per millennium. Defined as: ((1.0/20.0)/(10.0)) × point per century + (0).
   /// </summary>
   public static readonly Velocity TwipPerMillennium = new (
                                                            "twip per millennium"
                                                          , "twip/kyr"
                                                          , PointPerCentury
                                                          , 1.0 / 20.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) league per day. Defined as: ((3.0)/(24.0)) × mile per hour + (0).
   /// </summary>
   public static readonly Velocity LeaguePerDay = new ("league per day", "le/dy", MilePerHour, 3.0 / 24.0, 0);

   /// <summary>
   /// A(n) mile per sextillion years. Defined as: ((1760.0)/(1000.0)) × yard per quintillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerSextillionYears = new (
                                                                 "mile per sextillion years"
                                                               , "mi/Zyr"
                                                               , YardPerQuintillionYears
                                                               , 1760.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) fathom per septillion years. Defined as: ((2.0)/(1000.0)) × yard per sextillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerSeptillionYears =
            new ("fathom per septillion years", "ftm/Yyr", YardPerSextillionYears, 2.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per trillion years. Defined as: ((2.0)/(1000.0)) × yard per billion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerTrillionYears =
            new ("fathom per trillion years", "ftm/Tyr", YardPerBillionYears, 2.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per nonillion years. Defined as: ((3.0)/(1000.0)) × mile per octillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerNonillionYears =
            new ("league per nonillion years", "le/Qyr", MilePerOctillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per century. Defined as: ((2.0)/(10.0)) × yard per decade + (0).
   /// </summary>
   public static readonly Velocity FathomPerCentury = new (
                                                           "fathom per century"
                                                         , "ftm/century"
                                                         , YardPerDecade
                                                         , 2.0 / 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) fathom per year. Defined as: ((2.0)/(365.2525)) × yard per day + (0).
   /// </summary>
   public static readonly Velocity FathomPerYear = new ("fathom per year", "ftm/yr", YardPerDay, 2.0 / 365.2525, 0);

   /// <summary>
   /// A(n) twip per septillion years. Defined as: ((1.0/20.0)/(1000.0)) × point per sextillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerSeptillionYears = new (
                                                                 "twip per septillion years"
                                                               , "twip/Yyr"
                                                               , PointPerSextillionYears
                                                               , 1.0 / 20.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) twip per million years. Defined as: ((1.0/20.0)/(1000.0)) × point per millennium + (0).
   /// </summary>
   public static readonly Velocity TwipPerMillionYears = new (
                                                              "twip per million years"
                                                            , "twip/Myr"
                                                            , PointPerMillennium
                                                            , 1.0 / 20.0 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) fathom per day. Defined as: ((2.0)/(24.0)) × yard per hour + (0).
   /// </summary>
   public static readonly Velocity FathomPerDay = new ("fathom per day", "ftm/dy", YardPerHour, 2.0 / 24.0, 0);

   /// <summary>
   /// A(n) pica per octillion years. Defined as: ((12.0)/(1000.0)) × point per septillion years + (0).
   /// </summary>
   public static readonly Velocity PicaPerOctillionYears =
            new ("pica per octillion years", "P/Ryr", PointPerSeptillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per quadrillion years. Defined as: ((120.0)/(1000.0)) × fathom per trillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerQuadrillionYears = new (
                                                                   "cable per quadrillion years"
                                                                 , "cb/Pyr"
                                                                 , FathomPerTrillionYears
                                                                 , 120.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) league per septillion years. Defined as: ((3.0)/(1000.0)) × mile per sextillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerSeptillionYears =
            new ("league per septillion years", "le/Yyr", MilePerSextillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) pica per century. Defined as: ((12.0)/(10.0)) × point per decade + (0).
   /// </summary>
   public static readonly Velocity PicaPerCentury = new (
                                                         "pica per century"
                                                       , "P/century"
                                                       , PointPerDecade
                                                       , 12.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) mile per week. Defined as: ((1760.0)/(7.0)) × yard per day + (0).
   /// </summary>
   public static readonly Velocity MilePerWeek = new ("mile per week", "mi/wk", YardPerDay, 1760.0 / 7.0, 0);

   /// <summary>
   /// A(n) yard per trillion years. Defined as: ((3.0)/(1000.0)) × foot per billion years + (0).
   /// </summary>
   public static readonly Velocity YardPerTrillionYears =
            new ("yard per trillion years", "yd/Tyr", FootPerBillionYears, 3.0 / 1000.0, 0);

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
   /// A(n) twip per octillion years. Defined as: ((1.0/20.0)/(1000.0)) × point per septillion years + (0).
   /// </summary>
   public static readonly Velocity TwipPerOctillionYears = new (
                                                                "twip per octillion years"
                                                              , "twip/Ryr"
                                                              , PointPerSeptillionYears
                                                              , 1.0 / 20.0 / 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) yard per year. Defined as: ((3.0)/(365.2525)) × foot per day + (0).
   /// </summary>
   public static readonly Velocity YardPerYear = new ("yard per year", "yd/yr", FootPerDay, 3.0 / 365.2525, 0);

   /// <summary>
   /// A(n) twip per billion years. Defined as: ((1.0/20.0)/(1000.0)) × point per million years + (0).
   /// </summary>
   public static readonly Velocity TwipPerBillionYears = new (
                                                              "twip per billion years"
                                                            , "twip/Gyr"
                                                            , PointPerMillionYears
                                                            , 1.0 / 20.0 / 1000.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cable per day. Defined as: ((120.0)/(24.0)) × fathom per hour + (0).
   /// </summary>
   public static readonly Velocity CablePerDay = new ("cable per day", "cb/dy", FathomPerHour, 120.0 / 24.0, 0);

   /// <summary>
   /// A(n) mile per century. Defined as: ((1760.0)/(10.0)) × yard per decade + (0).
   /// </summary>
   public static readonly Velocity MilePerCentury = new (
                                                         "mile per century"
                                                       , "mi/century"
                                                       , YardPerDecade
                                                       , 1760.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cable per octillion years. Defined as: ((120.0)/(1000.0)) × fathom per septillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerOctillionYears = new (
                                                                 "cable per octillion years"
                                                               , "cb/Ryr"
                                                               , FathomPerSeptillionYears
                                                               , 120.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) pica per nonillion years. Defined as: ((12.0)/(1000.0)) × point per octillion years + (0).
   /// </summary>
   public static readonly Velocity PicaPerNonillionYears =
            new ("pica per nonillion years", "P/Qyr", PointPerOctillionYears, 12.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per year. Defined as: ((120.0)/(365.2525)) × fathom per day + (0).
   /// </summary>
   public static readonly Velocity CablePerYear = new ("cable per year", "cb/yr", FathomPerDay, 120.0 / 365.2525, 0);

   /// <summary>
   /// A(n) pica per millennium. Defined as: ((12.0)/(10.0)) × point per century + (0).
   /// </summary>
   public static readonly Velocity PicaPerMillennium = new (
                                                            "pica per millennium"
                                                          , "P/kyr"
                                                          , PointPerCentury
                                                          , 12.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) league per week. Defined as: ((3.0)/(7.0)) × mile per day + (0).
   /// </summary>
   public static readonly Velocity LeaguePerWeek = new ("league per week", "le/wk", MilePerDay, 3.0 / 7.0, 0);

   /// <summary>
   /// A(n) mile per billion years. Defined as: ((1760.0)/(1000.0)) × yard per million years + (0).
   /// </summary>
   public static readonly Velocity MilePerBillionYears =
            new ("mile per billion years", "mi/Gyr", YardPerMillionYears, 1760.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per octillion years. Defined as: ((2.0)/(1000.0)) × yard per septillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerOctillionYears =
            new ("fathom per octillion years", "ftm/Ryr", YardPerSeptillionYears, 2.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per sextillion years. Defined as: ((2.0)/(1000.0)) × yard per quintillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerSextillionYears = new (
                                                                   "fathom per sextillion years"
                                                                 , "ftm/Zyr"
                                                                 , YardPerQuintillionYears
                                                                 , 2.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) fathom per quadrillion years. Defined as: ((2.0)/(1000.0)) × yard per trillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerQuadrillionYears =
            new ("fathom per quadrillion years", "ftm/Pyr", YardPerTrillionYears, 2.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per billion years. Defined as: ((2.0)/(1000.0)) × yard per million years + (0).
   /// </summary>
   public static readonly Velocity FathomPerBillionYears =
            new ("fathom per billion years", "ftm/Gyr", YardPerMillionYears, 2.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per year. Defined as: ((1760.0)/(365.2525)) × yard per day + (0).
   /// </summary>
   public static readonly Velocity MilePerYear = new ("mile per year", "mi/yr", YardPerDay, 1760.0 / 365.2525, 0);

   /// <summary>
   /// A(n) fathom per millennium. Defined as: ((2.0)/(10.0)) × yard per century + (0).
   /// </summary>
   public static readonly Velocity FathomPerMillennium =
            new ("fathom per millennium", "ftm/kyr", YardPerCentury, 2.0 / 10.0, 0);

   /// <summary>
   /// A(n) yard per quadrillion years. Defined as: ((3.0)/(1000.0)) × foot per trillion years + (0).
   /// </summary>
   public static readonly Velocity YardPerQuadrillionYears =
            new ("yard per quadrillion years", "yd/Pyr", FootPerTrillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) fathom per decade. Defined as: ((2.0)/(10.0)) × yard per year + (0).
   /// </summary>
   public static readonly Velocity FathomPerDecade = new (
                                                          "fathom per decade"
                                                        , "ftm/decade"
                                                        , YardPerYear
                                                        , 2.0 / 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) mile per quintillion years. Defined as: ((1760.0)/(1000.0)) × yard per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerQuintillionYears = new (
                                                                  "mile per quintillion years"
                                                                , "mi/Eyr"
                                                                , YardPerQuadrillionYears
                                                                , 1760.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) fathom per week. Defined as: ((2.0)/(7.0)) × yard per day + (0).
   /// </summary>
   public static readonly Velocity FathomPerWeek = new ("fathom per week", "ftm/wk", YardPerDay, 2.0 / 7.0, 0);

   /// <summary>
   /// A(n) cable per trillion years. Defined as: ((120.0)/(1000.0)) × fathom per billion years + (0).
   /// </summary>
   public static readonly Velocity CablePerTrillionYears =
            new ("cable per trillion years", "cb/Tyr", FathomPerBillionYears, 120.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per millennium. Defined as: ((1760.0)/(10.0)) × yard per century + (0).
   /// </summary>
   public static readonly Velocity MilePerMillennium = new (
                                                            "mile per millennium"
                                                          , "mi/kyr"
                                                          , YardPerCentury
                                                          , 1760.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) cable per quintillion years. Defined as: ((120.0)/(1000.0)) × fathom per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerQuintillionYears = new (
                                                                   "cable per quintillion years"
                                                                 , "cb/Eyr"
                                                                 , FathomPerQuadrillionYears
                                                                 , 120.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) league per sextillion years. Defined as: ((3.0)/(1000.0)) × mile per quintillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerSextillionYears =
            new ("league per sextillion years", "le/Zyr", MilePerQuintillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per septillion years. Defined as: ((120.0)/(1000.0)) × fathom per sextillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerSeptillionYears = new (
                                                                  "cable per septillion years"
                                                                , "cb/Yyr"
                                                                , FathomPerSextillionYears
                                                                , 120.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) cable per week. Defined as: ((120.0)/(7.0)) × fathom per day + (0).
   /// </summary>
   public static readonly Velocity CablePerWeek = new ("cable per week", "cb/wk", FathomPerDay, 120.0 / 7.0, 0);

   /// <summary>
   /// A(n) mile per trillion years. Defined as: ((1760.0)/(1000.0)) × yard per billion years + (0).
   /// </summary>
   public static readonly Velocity MilePerTrillionYears =
            new ("mile per trillion years", "mi/Tyr", YardPerBillionYears, 1760.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per quadrillion years. Defined as: ((3.0)/(1000.0)) × mile per trillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerQuadrillionYears =
            new ("league per quadrillion years", "le/Pyr", MilePerTrillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per nonillion years. Defined as: ((120.0)/(1000.0)) × fathom per octillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerNonillionYears = new (
                                                                 "cable per nonillion years"
                                                               , "cb/Qyr"
                                                               , FathomPerOctillionYears
                                                               , 120.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) cable per decade. Defined as: ((120.0)/(10.0)) × fathom per year + (0).
   /// </summary>
   public static readonly Velocity CablePerDecade = new (
                                                         "cable per decade"
                                                       , "cb/decade"
                                                       , FathomPerYear
                                                       , 120.0 / 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) mile per decade. Defined as: ((1760.0)/(10.0)) × yard per year + (0).
   /// </summary>
   public static readonly Velocity MilePerDecade = new ("mile per decade", "mi/decade", YardPerYear, 1760.0 / 10.0, 0);

   /// <summary>
   /// A(n) cable per millennium. Defined as: ((120.0)/(10.0)) × fathom per century + (0).
   /// </summary>
   public static readonly Velocity CablePerMillennium = new (
                                                             "cable per millennium"
                                                           , "cb/kyr"
                                                           , FathomPerCentury
                                                           , 120.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) fathom per quintillion years. Defined as: ((2.0)/(1000.0)) × yard per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity FathomPerQuintillionYears = new (
                                                                    "fathom per quintillion years"
                                                                  , "ftm/Eyr"
                                                                  , YardPerQuadrillionYears
                                                                  , 2.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) fathom per million years. Defined as: ((2.0)/(1000.0)) × yard per millennium + (0).
   /// </summary>
   public static readonly Velocity FathomPerMillionYears =
            new ("fathom per million years", "ftm/Myr", YardPerMillennium, 2.0 / 1000.0, 0);

   /// <summary>
   /// A(n) mile per million years. Defined as: ((1760.0)/(1000.0)) × yard per millennium + (0).
   /// </summary>
   public static readonly Velocity MilePerMillionYears =
            new ("mile per million years", "mi/Myr", YardPerMillennium, 1760.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per billion years. Defined as: ((120.0)/(1000.0)) × fathom per million years + (0).
   /// </summary>
   public static readonly Velocity CablePerBillionYears =
            new ("cable per billion years", "cb/Gyr", FathomPerMillionYears, 120.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per millennium. Defined as: ((3.0)/(10.0)) × mile per century + (0).
   /// </summary>
   public static readonly Velocity LeaguePerMillennium =
            new ("league per millennium", "le/kyr", MilePerCentury, 3.0 / 10.0, 0);

   /// <summary>
   /// A(n) mile per quadrillion years. Defined as: ((1760.0)/(1000.0)) × yard per trillion years + (0).
   /// </summary>
   public static readonly Velocity MilePerQuadrillionYears =
            new ("mile per quadrillion years", "mi/Pyr", YardPerTrillionYears, 1760.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per sextillion years. Defined as: ((120.0)/(1000.0)) × fathom per quintillion years + (0).
   /// </summary>
   public static readonly Velocity CablePerSextillionYears = new (
                                                                  "cable per sextillion years"
                                                                , "cb/Zyr"
                                                                , FathomPerQuintillionYears
                                                                , 120.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) league per decade. Defined as: ((3.0)/(10.0)) × mile per year + (0).
   /// </summary>
   public static readonly Velocity LeaguePerDecade = new ("league per decade", "le/decade", MilePerYear, 3.0 / 10.0, 0);

   /// <summary>
   /// A(n) league per quintillion years. Defined as: ((3.0)/(1000.0)) × mile per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerQuintillionYears = new (
                                                                    "league per quintillion years"
                                                                  , "le/Eyr"
                                                                  , MilePerQuadrillionYears
                                                                  , 3.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) league per trillion years. Defined as: ((3.0)/(1000.0)) × mile per billion years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerTrillionYears =
            new ("league per trillion years", "le/Tyr", MilePerBillionYears, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) cable per century. Defined as: ((120.0)/(10.0)) × fathom per decade + (0).
   /// </summary>
   public static readonly Velocity CablePerCentury = new (
                                                          "cable per century"
                                                        , "cb/century"
                                                        , FathomPerDecade
                                                        , 120.0 / 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) cable per million years. Defined as: ((120.0)/(1000.0)) × fathom per millennium + (0).
   /// </summary>
   public static readonly Velocity CablePerMillionYears =
            new ("cable per million years", "cb/Myr", FathomPerMillennium, 120.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per million years. Defined as: ((3.0)/(1000.0)) × mile per millennium + (0).
   /// </summary>
   public static readonly Velocity LeaguePerMillionYears =
            new ("league per million years", "le/Myr", MilePerMillennium, 3.0 / 1000.0, 0);

   /// <summary>
   /// A(n) league per century. Defined as: ((3.0)/(10.0)) × mile per decade + (0).
   /// </summary>
   public static readonly Velocity LeaguePerCentury = new (
                                                           "league per century"
                                                         , "le/century"
                                                         , MilePerDecade
                                                         , 3.0 / 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) league per billion years. Defined as: ((3.0)/(1000.0)) × mile per million years + (0).
   /// </summary>
   public static readonly Velocity LeaguePerBillionYears =
            new ("league per billion years", "le/Gyr", MilePerMillionYears, 3.0 / 1000.0, 0);
}
