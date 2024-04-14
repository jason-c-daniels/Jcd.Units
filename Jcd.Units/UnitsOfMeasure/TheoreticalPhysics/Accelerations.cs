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
/// Units used in theoretical physics for measuring Acceleration.
/// </summary>
public class Accelerations : UnitOfMeasureEnumeration<Accelerations, Acceleration>
{
   /// <summary>
   /// planck-length per square second defined such that: SI meter per square second = ℓₚ/s² ×
   /// (1.616255E-35)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareSecond = new("planck-length per square second"
                                                                       , "ℓₚ/s²"
                                                                       , SI.Accelerations.MeterPerSquareSecond
                                                                       , 1.616255E-35 / (1.0 * 1.0)
                                                                       , system: "Theoretical Physics"
                                                                        );
   
   /// <summary>
   /// planck-length per square planck-time defined such that: SI meter per square microsecond = ℓₚ/tₚ² ×
   /// (1.616255E-35)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquarePlanckTime = new("planck-length per square planck-time"
                                                                           , "ℓₚ/tₚ²"
                                                                           , SI.Accelerations.MeterPerSquareMicrosecond
                                                                           , 1.616255E-35 / (5.391247E-38 * 5.391247E-38)
                                                                           , system: "Theoretical Physics"
                                                                            );
   
   /// <summary>
   /// planck-length per square decisecond defined such that: SI meter per square second = ℓₚ/ds² ×
   /// (1.616255E-35)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareDecisecond = new("planck-length per square decisecond"
                                                                           , "ℓₚ/ds²"
                                                                           , SI.Accelerations.MeterPerSquareSecond
                                                                           , 1.616255E-35 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , system: "Theoretical Physics"
                                                                            );
   
   /// <summary>
   /// planck-length per square centisecond defined such that: SI meter per square decisecond = ℓₚ/cs² ×
   /// (1.616255E-35)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareCentisecond = new("planck-length per square centisecond"
                                                                            , "ℓₚ/cs²"
                                                                            , SI.Accelerations.MeterPerSquareDecisecond
                                                                            , 1.616255E-35 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                            , system: "Theoretical Physics"
                                                                             );
   
   /// <summary>
   /// planck-length per square millisecond defined such that: SI meter per square centisecond = ℓₚ/ms² ×
   /// (1.616255E-35)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareMillisecond = new("planck-length per square millisecond"
                                                                            , "ℓₚ/ms²"
                                                                            , SI.Accelerations.MeterPerSquareCentisecond
                                                                            , 1.616255E-35 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                            , system: "Theoretical Physics"
                                                                             );
   
   /// <summary>
   /// planck-length per square microsecond defined such that: SI meter per square millisecond = ℓₚ/μs² ×
   /// (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareMicrosecond = new("planck-length per square microsecond"
                                                                            , "ℓₚ/μs²"
                                                                            , SI.Accelerations.MeterPerSquareMillisecond
                                                                            , 1.616255E-35 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Theoretical Physics"
                                                                             );
   
   /// <summary>
   /// planck-length per square nanosecond defined such that: SI meter per square microsecond = ℓₚ/ns² ×
   /// (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareNanosecond = new("planck-length per square nanosecond"
                                                                           , "ℓₚ/ns²"
                                                                           , SI.Accelerations.MeterPerSquareMicrosecond
                                                                           , 1.616255E-35 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , system: "Theoretical Physics"
                                                                            );
   
   /// <summary>
   /// planck-length per square picosecond defined such that: SI meter per square nanosecond = ℓₚ/ps² ×
   /// (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquarePicosecond = new("planck-length per square picosecond"
                                                                           , "ℓₚ/ps²"
                                                                           , SI.Accelerations.MeterPerSquareNanosecond
                                                                           , 1.616255E-35 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , system: "Theoretical Physics"
                                                                            );
   
   /// <summary>
   /// planck-length per square femtosecond defined such that: SI meter per square picosecond = ℓₚ/fs² ×
   /// (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareFemtosecond = new("planck-length per square femtosecond"
                                                                            , "ℓₚ/fs²"
                                                                            , SI.Accelerations.MeterPerSquarePicosecond
                                                                            , 1.616255E-35 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Theoretical Physics"
                                                                             );
   
   /// <summary>
   /// planck-length per square attosecond defined such that: SI meter per square femtosecond = ℓₚ/as² ×
   /// (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareAttosecond = new("planck-length per square attosecond"
                                                                           , "ℓₚ/as²"
                                                                           , SI.Accelerations.MeterPerSquareFemtosecond
                                                                           , 1.616255E-35 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , system: "Theoretical Physics"
                                                                            );
   
   /// <summary>
   /// planck-length per square zeptosecond defined such that: SI meter per square attosecond = ℓₚ/zs² ×
   /// (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareZeptosecond = new("planck-length per square zeptosecond"
                                                                            , "ℓₚ/zs²"
                                                                            , SI.Accelerations.MeterPerSquareAttosecond
                                                                            , 1.616255E-35 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Theoretical Physics"
                                                                             );
   
   /// <summary>
   /// planck-length per square yoctosecond defined such that: SI meter per square zeptosecond = ℓₚ/ys² ×
   /// (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareYoctosecond = new("planck-length per square yoctosecond"
                                                                            , "ℓₚ/ys²"
                                                                            , SI.Accelerations.MeterPerSquareZeptosecond
                                                                            , 1.616255E-35 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Theoretical Physics"
                                                                             );
   
   /// <summary>
   /// planck-length per square rontosecond defined such that: SI meter per square yoctosecond = ℓₚ/rs² ×
   /// (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareRontosecond = new("planck-length per square rontosecond"
                                                                            , "ℓₚ/rs²"
                                                                            , SI.Accelerations.MeterPerSquareYoctosecond
                                                                            , 1.616255E-35 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Theoretical Physics"
                                                                             );
   
   /// <summary>
   /// planck-length per square quectosecond defined such that: SI meter per square rontosecond = ℓₚ/qs² ×
   /// (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareQuectosecond = new("planck-length per square quectosecond"
                                                                             , "ℓₚ/qs²"
                                                                             , SI.Accelerations.MeterPerSquareRontosecond
                                                                             , 1.616255E-35 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , system: "Theoretical Physics"
                                                                              );
   
   /// <summary>
   /// planck-length per square minute defined such that: SI meter per square second = ℓₚ/min² ×
   /// (1.616255E-35)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareMinute = new("planck-length per square minute"
                                                                       , "ℓₚ/min²"
                                                                       , SI.Accelerations.MeterPerSquareSecond
                                                                       , 1.616255E-35 / (60.0 * 60.0)
                                                                       , system: "Theoretical Physics"
                                                                        );
   
   /// <summary>
   /// planck-length per square hour defined such that: SI meter per square minute = ℓₚ/hr² ×
   /// (1.616255E-35)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareHour = new("planck-length per square hour"
                                                                     , "ℓₚ/hr²"
                                                                     , SI.Accelerations.MeterPerSquareMinute
                                                                     , 1.616255E-35 / (60.0 * 60.0)
                                                                     , system: "Theoretical Physics"
                                                                      );
   
   /// <summary>
   /// planck-length per square day defined such that: SI meter per square hour = ℓₚ/dy² × (1.616255E-35)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareDay = new("planck-length per square day"
                                                                    , "ℓₚ/dy²"
                                                                    , SI.Accelerations.MeterPerSquareHour
                                                                    , 1.616255E-35 / (24.0 * 24.0)
                                                                    , system: "Theoretical Physics"
                                                                     );
   
   /// <summary>
   /// planck-length per square week defined such that: SI meter per square day = ℓₚ/wk² × (1.616255E-35)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareWeek = new("planck-length per square week"
                                                                     , "ℓₚ/wk²"
                                                                     , SI.Accelerations.MeterPerSquareDay
                                                                     , 1.616255E-35 / (7.0 * 7.0)
                                                                     , system: "Theoretical Physics"
                                                                      );
   
   /// <summary>
   /// planck-length per square year defined such that: SI meter per square day = ℓₚ/yr² ×
   /// (1.616255E-35)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareYear = new("planck-length per square year"
                                                                     , "ℓₚ/yr²"
                                                                     , SI.Accelerations.MeterPerSquareDay
                                                                     , 1.616255E-35 / (365.2525 * 365.2525)
                                                                     , system: "Theoretical Physics"
                                                                      );
   
   /// <summary>
   /// planck-length per square decade defined such that: SI meter per square year = ℓₚ/decade² ×
   /// (1.616255E-35)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareDecade = new("planck-length per square decade"
                                                                       , "ℓₚ/decade²"
                                                                       , SI.Accelerations.MeterPerSquareYear
                                                                       , 1.616255E-35 / (10.0 * 10.0)
                                                                       , system: "Theoretical Physics"
                                                                        );
   
   /// <summary>
   /// planck-length per square century defined such that: SI meter per square decade = ℓₚ/century² ×
   /// (1.616255E-35)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareCentury = new("planck-length per square century"
                                                                        , "ℓₚ/century²"
                                                                        , SI.Accelerations.MeterPerSquareDecade
                                                                        , 1.616255E-35 / (10.0 * 10.0)
                                                                        , system: "Theoretical Physics"
                                                                         );
   
   /// <summary>
   /// planck-length per square millennium defined such that: SI meter per square century = ℓₚ/kyr² ×
   /// (1.616255E-35)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareMillennium = new("planck-length per square millennium"
                                                                           , "ℓₚ/kyr²"
                                                                           , SI.Accelerations.MeterPerSquareCentury
                                                                           , 1.616255E-35 / (10.0 * 10.0)
                                                                           , system: "Theoretical Physics"
                                                                            );
   
   /// <summary>
   /// planck-length per square million years defined such that: SI meter per square millennium = ℓₚ/Myr² ×
   /// (1.616255E-35)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareMillionYears = new("planck-length per square million years"
                                                                             , "ℓₚ/Myr²"
                                                                             , SI.Accelerations.MeterPerSquareMillennium
                                                                             , 1.616255E-35 / (1000.0 * 1000.0)
                                                                             , system: "Theoretical Physics"
                                                                              );
   
   /// <summary>
   /// planck-length per square billion years defined such that: SI meter per square million years = ℓₚ/Gyr² ×
   /// (1.616255E-35)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareBillionYears = new("planck-length per square billion years"
                                                                             , "ℓₚ/Gyr²"
                                                                             , SI.Accelerations.MeterPerSquareMillionYears
                                                                             , 1.616255E-35 / (1000.0 * 1000.0)
                                                                             , system: "Theoretical Physics"
                                                                              );
   
   /// <summary>
   /// planck-length per square trillion years defined such that: SI meter per square billion years = ℓₚ/Tyr² ×
   /// (1.616255E-35)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareTrillionYears = new("planck-length per square trillion years"
                                                                              , "ℓₚ/Tyr²"
                                                                              , SI.Accelerations.MeterPerSquareBillionYears
                                                                              , 1.616255E-35 / (1000.0 * 1000.0)
                                                                              , system: "Theoretical Physics"
                                                                               );
   
   /// <summary>
   /// planck-length per square quadrillion years defined such that: SI meter per square trillion years = ℓₚ/Pyr² ×
   /// (1.616255E-35)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareQuadrillionYears = new("planck-length per square quadrillion years"
                                                                                 , "ℓₚ/Pyr²"
                                                                                 , SI.Accelerations.MeterPerSquareTrillionYears
                                                                                 , 1.616255E-35 / (1000.0 * 1000.0)
                                                                                 , system: "Theoretical Physics"
                                                                                  );
   
   /// <summary>
   /// planck-length per square quintillion years defined such that: SI meter per square quadrillion years = ℓₚ/Eyr² ×
   /// (1.616255E-35)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareQuintillionYears = new("planck-length per square quintillion years"
                                                                                 , "ℓₚ/Eyr²"
                                                                                 , SI.Accelerations.MeterPerSquareQuadrillionYears
                                                                                 , 1.616255E-35 / (1000.0 * 1000.0)
                                                                                 , system: "Theoretical Physics"
                                                                                  );
   
   /// <summary>
   /// planck-length per square sextillion years defined such that: SI meter per square quintillion years = ℓₚ/Zyr² ×
   /// (1.616255E-35)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareSextillionYears = new("planck-length per square sextillion years"
                                                                                , "ℓₚ/Zyr²"
                                                                                , SI.Accelerations.MeterPerSquareQuintillionYears
                                                                                , 1.616255E-35 / (1000.0 * 1000.0)
                                                                                , system: "Theoretical Physics"
                                                                                 );
   
   /// <summary>
   /// planck-length per square septillion years defined such that: SI meter per square sextillion years = ℓₚ/Yyr² ×
   /// (1.616255E-35)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareSeptillionYears = new("planck-length per square septillion years"
                                                                                , "ℓₚ/Yyr²"
                                                                                , SI.Accelerations.MeterPerSquareSextillionYears
                                                                                , 1.616255E-35 / (1000.0 * 1000.0)
                                                                                , system: "Theoretical Physics"
                                                                                 );
   
   /// <summary>
   /// planck-length per square octillion years defined such that: SI meter per square septillion years = ℓₚ/Ryr² ×
   /// (1.616255E-35)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareOctillionYears = new("planck-length per square octillion years"
                                                                               , "ℓₚ/Ryr²"
                                                                               , SI.Accelerations.MeterPerSquareSeptillionYears
                                                                               , 1.616255E-35 / (1000.0 * 1000.0)
                                                                               , system: "Theoretical Physics"
                                                                                );
   
   /// <summary>
   /// planck-length per square nonillion years defined such that: SI meter per square octillion years = ℓₚ/Qyr² ×
   /// (1.616255E-35)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareNonillionYears = new("planck-length per square nonillion years"
                                                                               , "ℓₚ/Qyr²"
                                                                               , SI.Accelerations.MeterPerSquareOctillionYears
                                                                               , 1.616255E-35 / (1000.0 * 1000.0)
                                                                               , system: "Theoretical Physics"
                                                                                );
   
   /// <summary>
   /// planck-length per square decillion years defined such that: SI meter per square nonillion years = ℓₚ/decillion yr² ×
   /// (1.616255E-35)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareDecillionYears = new("planck-length per square decillion years"
                                                                               , "ℓₚ/decillion yr²"
                                                                               , SI.Accelerations.MeterPerSquareNonillionYears
                                                                               , 1.616255E-35 / (1000.0 * 1000.0)
                                                                               , system: "Theoretical Physics"
                                                                                );
   
   /// <summary>
   /// planck-length per square tick defined such that: SI meter per square nanosecond = ℓₚ/tick² ×
   /// (1.616255E-35)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareTick = new("planck-length per square tick"
                                                                     , "ℓₚ/tick²"
                                                                     , SI.Accelerations.MeterPerSquareNanosecond
                                                                     , 1.616255E-35 / (100.0 * 100.0)
                                                                     , system: "Theoretical Physics"
                                                                      );
}