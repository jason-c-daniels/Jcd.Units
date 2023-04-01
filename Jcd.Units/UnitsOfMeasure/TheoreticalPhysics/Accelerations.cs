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
   /// planck-length per square second, defined as: SI meter per square second × (1.616255E-35)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareSecond = new (
                                                                          "planck-length per square second"
                                                                        , "ℓₚ/s²"
                                                                        , SI.Accelerations.MeterPerSquareSecond
                                                                        , 1.616255E-35 / (1.0 * 1.0)
                                                                        , system: "Theoretical Physics"
                                                                         );

   /// <summary>
   /// planck-length per square planck-time, defined as: SI meter per square microsecond × (1.616255E-35)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquarePlanckTime = new (
                                                                              "planck-length per square planck-time"
                                                                            , "ℓₚ/tₚ²"
                                                                            , SI.Accelerations.MeterPerSquareMicrosecond
                                                                            , 1.616255E-35
                                                                            / (5.391247E-38 * 5.391247E-38)
                                                                            , system: "Theoretical Physics"
                                                                             );

   /// <summary>
   /// planck-length per square decisecond, defined as: SI meter per square second × (1.616255E-35)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareDecisecond = new (
                                                                              "planck-length per square decisecond"
                                                                            , "ℓₚ/ds²"
                                                                            , SI.Accelerations.MeterPerSquareSecond
                                                                            , 1.616255E-35 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                            , system: "Theoretical Physics"
                                                                             );

   /// <summary>
   /// planck-length per square centisecond, defined as: SI meter per square decisecond × (1.616255E-35)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareCentisecond = new (
                                                                               "planck-length per square centisecond"
                                                                             , "ℓₚ/cs²"
                                                                             , SI.Accelerations.MeterPerSquareDecisecond
                                                                             , 1.616255E-35
                                                                             / (1.0 / 10.0 * (1.0 / 10.0))
                                                                             , system: "Theoretical Physics"
                                                                              );

   /// <summary>
   /// planck-length per square millisecond, defined as: SI meter per square centisecond × (1.616255E-35)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareMillisecond = new (
                                                                               "planck-length per square millisecond"
                                                                             , "ℓₚ/ms²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareCentisecond
                                                                             , 1.616255E-35
                                                                             / (1.0 / 10.0 * (1.0 / 10.0))
                                                                             , system: "Theoretical Physics"
                                                                              );

   /// <summary>
   /// planck-length per square microsecond, defined as: SI meter per square millisecond × (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareMicrosecond = new (
                                                                               "planck-length per square microsecond"
                                                                             , "ℓₚ/μs²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareMillisecond
                                                                             , 1.616255E-35
                                                                             / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , system: "Theoretical Physics"
                                                                              );

   /// <summary>
   /// planck-length per square nanosecond, defined as: SI meter per square microsecond × (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareNanosecond = new (
                                                                              "planck-length per square nanosecond"
                                                                            , "ℓₚ/ns²"
                                                                            , SI.Accelerations.MeterPerSquareMicrosecond
                                                                            , 1.616255E-35
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Theoretical Physics"
                                                                             );

   /// <summary>
   /// planck-length per square picosecond, defined as: SI meter per square nanosecond × (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquarePicosecond = new (
                                                                              "planck-length per square picosecond"
                                                                            , "ℓₚ/ps²"
                                                                            , SI.Accelerations.MeterPerSquareNanosecond
                                                                            , 1.616255E-35
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Theoretical Physics"
                                                                             );

   /// <summary>
   /// planck-length per square femtosecond, defined as: SI meter per square picosecond × (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareFemtosecond = new (
                                                                               "planck-length per square femtosecond"
                                                                             , "ℓₚ/fs²"
                                                                             , SI.Accelerations.MeterPerSquarePicosecond
                                                                             , 1.616255E-35
                                                                             / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , system: "Theoretical Physics"
                                                                              );

   /// <summary>
   /// planck-length per square attosecond, defined as: SI meter per square femtosecond × (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareAttosecond = new (
                                                                              "planck-length per square attosecond"
                                                                            , "ℓₚ/as²"
                                                                            , SI.Accelerations.MeterPerSquareFemtosecond
                                                                            , 1.616255E-35
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Theoretical Physics"
                                                                             );

   /// <summary>
   /// planck-length per square zeptosecond, defined as: SI meter per square attosecond × (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareZeptosecond = new (
                                                                               "planck-length per square zeptosecond"
                                                                             , "ℓₚ/zs²"
                                                                             , SI.Accelerations.MeterPerSquareAttosecond
                                                                             , 1.616255E-35
                                                                             / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , system: "Theoretical Physics"
                                                                              );

   /// <summary>
   /// planck-length per square yoctosecond, defined as: SI meter per square zeptosecond × (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareYoctosecond = new (
                                                                               "planck-length per square yoctosecond"
                                                                             , "ℓₚ/ys²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareZeptosecond
                                                                             , 1.616255E-35
                                                                             / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , system: "Theoretical Physics"
                                                                              );

   /// <summary>
   /// planck-length per square rontosecond, defined as: SI meter per square yoctosecond × (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareRontosecond = new (
                                                                               "planck-length per square rontosecond"
                                                                             , "ℓₚ/rs²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareYoctosecond
                                                                             , 1.616255E-35
                                                                             / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , system: "Theoretical Physics"
                                                                              );

   /// <summary>
   /// planck-length per square quectosecond, defined as: SI meter per square rontosecond × (1.616255E-35)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareQuectosecond = new (
                                                                                "planck-length per square quectosecond"
                                                                              , "ℓₚ/qs²"
                                                                              , SI.Accelerations
                                                                                        .MeterPerSquareRontosecond
                                                                              , 1.616255E-35
                                                                              / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              , system: "Theoretical Physics"
                                                                               );

   /// <summary>
   /// planck-length per square minute, defined as: SI meter per square second × (1.616255E-35)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareMinute = new (
                                                                          "planck-length per square minute"
                                                                        , "ℓₚ/min²"
                                                                        , SI.Accelerations.MeterPerSquareSecond
                                                                        , 1.616255E-35 / (60.0 * 60.0)
                                                                        , system: "Theoretical Physics"
                                                                         );

   /// <summary>
   /// planck-length per square hour, defined as: SI meter per square minute × (1.616255E-35)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareHour = new (
                                                                        "planck-length per square hour"
                                                                      , "ℓₚ/hr²"
                                                                      , SI.Accelerations.MeterPerSquareMinute
                                                                      , 1.616255E-35 / (60.0 * 60.0)
                                                                      , system: "Theoretical Physics"
                                                                       );

   /// <summary>
   /// planck-length per square day, defined as: SI meter per square hour × (1.616255E-35)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareDay = new (
                                                                       "planck-length per square day"
                                                                     , "ℓₚ/dy²"
                                                                     , SI.Accelerations.MeterPerSquareHour
                                                                     , 1.616255E-35 / (24.0 * 24.0)
                                                                     , system: "Theoretical Physics"
                                                                      );

   /// <summary>
   /// planck-length per square week, defined as: SI meter per square day × (1.616255E-35)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareWeek = new (
                                                                        "planck-length per square week"
                                                                      , "ℓₚ/wk²"
                                                                      , SI.Accelerations.MeterPerSquareDay
                                                                      , 1.616255E-35 / (7.0 * 7.0)
                                                                      , system: "Theoretical Physics"
                                                                       );

   /// <summary>
   /// planck-length per square year, defined as: SI meter per square day × (1.616255E-35)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareYear = new (
                                                                        "planck-length per square year"
                                                                      , "ℓₚ/yr²"
                                                                      , SI.Accelerations.MeterPerSquareDay
                                                                      , 1.616255E-35 / (365.2525 * 365.2525)
                                                                      , system: "Theoretical Physics"
                                                                       );

   /// <summary>
   /// planck-length per square decade, defined as: SI meter per square year × (1.616255E-35)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareDecade = new (
                                                                          "planck-length per square decade"
                                                                        , "ℓₚ/decade²"
                                                                        , SI.Accelerations.MeterPerSquareYear
                                                                        , 1.616255E-35 / (10.0 * 10.0)
                                                                        , system: "Theoretical Physics"
                                                                         );

   /// <summary>
   /// planck-length per square century, defined as: SI meter per square decade × (1.616255E-35)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareCentury = new (
                                                                           "planck-length per square century"
                                                                         , "ℓₚ/century²"
                                                                         , SI.Accelerations.MeterPerSquareDecade
                                                                         , 1.616255E-35 / (10.0 * 10.0)
                                                                         , system: "Theoretical Physics"
                                                                          );

   /// <summary>
   /// planck-length per square millennium, defined as: SI meter per square century × (1.616255E-35)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareMillennium = new (
                                                                              "planck-length per square millennium"
                                                                            , "ℓₚ/kyr²"
                                                                            , SI.Accelerations.MeterPerSquareCentury
                                                                            , 1.616255E-35 / (10.0 * 10.0)
                                                                            , system: "Theoretical Physics"
                                                                             );

   /// <summary>
   /// planck-length per square million years, defined as: SI meter per square millennium × (1.616255E-35)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareMillionYears = new (
                                                                                "planck-length per square million years"
                                                                              , "ℓₚ/Myr²"
                                                                              , SI.Accelerations
                                                                                        .MeterPerSquareMillennium
                                                                              , 1.616255E-35 / (1000.0 * 1000.0)
                                                                              , system: "Theoretical Physics"
                                                                               );

   /// <summary>
   /// planck-length per square billion years, defined as: SI meter per square million years × (1.616255E-35)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareBillionYears = new (
                                                                                "planck-length per square billion years"
                                                                              , "ℓₚ/Gyr²"
                                                                              , SI.Accelerations
                                                                                        .MeterPerSquareMillionYears
                                                                              , 1.616255E-35 / (1000.0 * 1000.0)
                                                                              , system: "Theoretical Physics"
                                                                               );

   /// <summary>
   /// planck-length per square trillion years, defined as: SI meter per square billion years × (1.616255E-35)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareTrillionYears = new (
       "planck-length per square trillion years"
     , "ℓₚ/Tyr²"
     , SI.Accelerations.MeterPerSquareBillionYears
     , 1.616255E-35 / (1000.0 * 1000.0)
     , system: "Theoretical Physics"
      );

   /// <summary>
   /// planck-length per square quadrillion years, defined as: SI meter per square trillion years × (1.616255E-35)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareQuadrillionYears = new (
       "planck-length per square quadrillion years"
     , "ℓₚ/Pyr²"
     , SI.Accelerations.MeterPerSquareTrillionYears
     , 1.616255E-35 / (1000.0 * 1000.0)
     , system: "Theoretical Physics"
      );

   /// <summary>
   /// planck-length per square quintillion years, defined as: SI meter per square quadrillion years × (1.616255E-35)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareQuintillionYears = new (
       "planck-length per square quintillion years"
     , "ℓₚ/Eyr²"
     , SI.Accelerations.MeterPerSquareQuadrillionYears
     , 1.616255E-35 / (1000.0 * 1000.0)
     , system: "Theoretical Physics"
      );

   /// <summary>
   /// planck-length per square sextillion years, defined as: SI meter per square quintillion years × (1.616255E-35)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareSextillionYears = new (
       "planck-length per square sextillion years"
     , "ℓₚ/Zyr²"
     , SI.Accelerations.MeterPerSquareQuintillionYears
     , 1.616255E-35 / (1000.0 * 1000.0)
     , system: "Theoretical Physics"
      );

   /// <summary>
   /// planck-length per square septillion years, defined as: SI meter per square sextillion years × (1.616255E-35)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareSeptillionYears = new (
       "planck-length per square septillion years"
     , "ℓₚ/Yyr²"
     , SI.Accelerations.MeterPerSquareSextillionYears
     , 1.616255E-35 / (1000.0 * 1000.0)
     , system: "Theoretical Physics"
      );

   /// <summary>
   /// planck-length per square octillion years, defined as: SI meter per square septillion years × (1.616255E-35)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareOctillionYears = new (
       "planck-length per square octillion years"
     , "ℓₚ/Ryr²"
     , SI.Accelerations.MeterPerSquareSeptillionYears
     , 1.616255E-35 / (1000.0 * 1000.0)
     , system: "Theoretical Physics"
      );

   /// <summary>
   /// planck-length per square nonillion years, defined as: SI meter per square octillion years × (1.616255E-35)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareNonillionYears = new (
       "planck-length per square nonillion years"
     , "ℓₚ/Qyr²"
     , SI.Accelerations.MeterPerSquareOctillionYears
     , 1.616255E-35 / (1000.0 * 1000.0)
     , system: "Theoretical Physics"
      );

   /// <summary>
   /// planck-length per square decillion years, defined as: SI meter per square nonillion years × (1.616255E-35)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareDecillionYears = new (
       "planck-length per square decillion years"
     , "ℓₚ/decillion yr²"
     , SI.Accelerations.MeterPerSquareNonillionYears
     , 1.616255E-35 / (1000.0 * 1000.0)
     , system: "Theoretical Physics"
      );

   /// <summary>
   /// planck-length per square tick, defined as: SI meter per square nanosecond × (1.616255E-35)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration PlanckLengthPerSquareTick = new (
                                                                        "planck-length per square tick"
                                                                      , "ℓₚ/tick²"
                                                                      , SI.Accelerations.MeterPerSquareNanosecond
                                                                      , 1.616255E-35 / (100.0 * 100.0)
                                                                      , system: "Theoretical Physics"
                                                                       );
}
