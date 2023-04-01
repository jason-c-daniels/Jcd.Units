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
/// United States Customary Units for measuring Acceleration.
/// </summary>
public class Accelerations : UnitOfMeasureEnumeration<Accelerations, Acceleration>
{
   /// <summary>
   /// nautical mile per square octillion years, defined as: SI meter per square septillion years × (1852.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareOctillionYears = new (
       "nautical mile per square octillion years"
     , "nmi/Ryr²"
     , SI.Accelerations.MeterPerSquareSeptillionYears
     , 1852.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// nautical mile per square trillion years, defined as: SI meter per square billion years × (1852.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareTrillionYears = new (
       "nautical mile per square trillion years"
     , "nmi/Tyr²"
     , SI.Accelerations.MeterPerSquareBillionYears
     , 1852.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// nautical mile per square decade, defined as: SI meter per square year × (1852.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecade = new (
                                                                          "nautical mile per square decade"
                                                                        , "nmi/decade²"
                                                                        , SI.Accelerations.MeterPerSquareYear
                                                                        , 1852.0 / (10.0 * 10.0)
                                                                         );

   /// <summary>
   /// nautical mile per square minute, defined as: SI meter per square second × (1852.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMinute = new (
                                                                          "nautical mile per square minute"
                                                                        , "nmi/min²"
                                                                        , SI.Accelerations.MeterPerSquareSecond
                                                                        , 1852.0 / (60.0 * 60.0)
                                                                         );

   /// <summary>
   /// nautical mile per square decillion years, defined as: SI meter per square nonillion years × (1852.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecillionYears = new (
       "nautical mile per square decillion years"
     , "nmi/decillion yr²"
     , SI.Accelerations.MeterPerSquareNonillionYears
     , 1852.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// nautical mile per square quintillion years, defined as: SI meter per square quadrillion years × (1852.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuintillionYears = new (
       "nautical mile per square quintillion years"
     , "nmi/Eyr²"
     , SI.Accelerations.MeterPerSquareQuadrillionYears
     , 1852.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// nautical mile per square millennium, defined as: SI meter per square century × (1852.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillennium = new (
                                                                              "nautical mile per square millennium"
                                                                            , "nmi/kyr²"
                                                                            , SI.Accelerations.MeterPerSquareCentury
                                                                            , 1852.0 / (10.0 * 10.0)
                                                                             );

   /// <summary>
   /// nautical mile per square day, defined as: SI meter per square hour × (1852.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDay = new (
                                                                       "nautical mile per square day"
                                                                     , "nmi/dy²"
                                                                     , SI.Accelerations.MeterPerSquareHour
                                                                     , 1852.0 / (24.0 * 24.0)
                                                                      );

   /// <summary>
   /// nautical mile per square tick, defined as: SI meter per square nanosecond × (1852.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareTick = new (
                                                                        "nautical mile per square tick"
                                                                      , "nmi/tick²"
                                                                      , SI.Accelerations.MeterPerSquareNanosecond
                                                                      , 1852.0 / (100.0 * 100.0)
                                                                       );

   /// <summary>
   /// nautical mile per square septillion years, defined as: SI meter per square sextillion years × (1852.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSeptillionYears = new (
       "nautical mile per square septillion years"
     , "nmi/Yyr²"
     , SI.Accelerations.MeterPerSquareSextillionYears
     , 1852.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// nautical mile per square billion years, defined as: SI meter per square million years × (1852.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareBillionYears = new (
                                                                                "nautical mile per square billion years"
                                                                              , "nmi/Gyr²"
                                                                              , SI.Accelerations
                                                                                        .MeterPerSquareMillionYears
                                                                              , 1852.0 / (1000.0 * 1000.0)
                                                                               );

   /// <summary>
   /// nautical mile per square year, defined as: SI meter per square day × (1852.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareYear = new (
                                                                        "nautical mile per square year"
                                                                      , "nmi/yr²"
                                                                      , SI.Accelerations.MeterPerSquareDay
                                                                      , 1852.0 / (365.2525 * 365.2525)
                                                                       );

   /// <summary>
   /// inch per square second, defined as: SI centimeter per square second × (2.54)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareSecond = new (
                                                                  "inch per square second"
                                                                , "in/s²"
                                                                , SI.Accelerations.CentimeterPerSquareSecond
                                                                , 2.54 / (1.0 * 1.0)
                                                                 );

   /// <summary>
   /// inch per square planck-time, defined as: SI centimeter per square microsecond × (2.54)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration InchPerSquarePlanckTime = new (
                                                                      "inch per square planck-time"
                                                                    , "in/tₚ²"
                                                                    , SI.Accelerations.CentimeterPerSquareMicrosecond
                                                                    , 2.54 / (5.391247E-38 * 5.391247E-38)
                                                                     );

   /// <summary>
   /// inch per square decisecond, defined as: SI centimeter per square second × (2.54)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareDecisecond = new (
                                                                      "inch per square decisecond"
                                                                    , "in/ds²"
                                                                    , SI.Accelerations.CentimeterPerSquareSecond
                                                                    , 2.54 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// inch per square centisecond, defined as: SI centimeter per square decisecond × (2.54)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareCentisecond = new (
                                                                       "inch per square centisecond"
                                                                     , "in/cs²"
                                                                     , SI.Accelerations.CentimeterPerSquareDecisecond
                                                                     , 2.54 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// inch per square millisecond, defined as: SI centimeter per square centisecond × (2.54)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareMillisecond = new (
                                                                       "inch per square millisecond"
                                                                     , "in/ms²"
                                                                     , SI.Accelerations.CentimeterPerSquareCentisecond
                                                                     , 2.54 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// inch per square microsecond, defined as: SI centimeter per square millisecond × (2.54)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareMicrosecond = new (
                                                                       "inch per square microsecond"
                                                                     , "in/μs²"
                                                                     , SI.Accelerations.CentimeterPerSquareMillisecond
                                                                     , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// inch per square nanosecond, defined as: SI centimeter per square microsecond × (2.54)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareNanosecond = new (
                                                                      "inch per square nanosecond"
                                                                    , "in/ns²"
                                                                    , SI.Accelerations.CentimeterPerSquareMicrosecond
                                                                    , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// inch per square picosecond, defined as: SI centimeter per square nanosecond × (2.54)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquarePicosecond = new (
                                                                      "inch per square picosecond"
                                                                    , "in/ps²"
                                                                    , SI.Accelerations.CentimeterPerSquareNanosecond
                                                                    , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// inch per square femtosecond, defined as: SI centimeter per square picosecond × (2.54)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareFemtosecond = new (
                                                                       "inch per square femtosecond"
                                                                     , "in/fs²"
                                                                     , SI.Accelerations.CentimeterPerSquarePicosecond
                                                                     , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// inch per square attosecond, defined as: SI centimeter per square femtosecond × (2.54)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareAttosecond = new (
                                                                      "inch per square attosecond"
                                                                    , "in/as²"
                                                                    , SI.Accelerations.CentimeterPerSquareFemtosecond
                                                                    , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// inch per square zeptosecond, defined as: SI centimeter per square attosecond × (2.54)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareZeptosecond = new (
                                                                       "inch per square zeptosecond"
                                                                     , "in/zs²"
                                                                     , SI.Accelerations.CentimeterPerSquareAttosecond
                                                                     , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// inch per square yoctosecond, defined as: SI centimeter per square zeptosecond × (2.54)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareYoctosecond = new (
                                                                       "inch per square yoctosecond"
                                                                     , "in/ys²"
                                                                     , SI.Accelerations.CentimeterPerSquareZeptosecond
                                                                     , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// inch per square rontosecond, defined as: SI centimeter per square yoctosecond × (2.54)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareRontosecond = new (
                                                                       "inch per square rontosecond"
                                                                     , "in/rs²"
                                                                     , SI.Accelerations.CentimeterPerSquareYoctosecond
                                                                     , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// inch per square quectosecond, defined as: SI centimeter per square rontosecond × (2.54)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareQuectosecond = new (
                                                                        "inch per square quectosecond"
                                                                      , "in/qs²"
                                                                      , SI.Accelerations.CentimeterPerSquareRontosecond
                                                                      , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// inch per square minute, defined as: SI centimeter per square second × (2.54)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareMinute = new (
                                                                  "inch per square minute"
                                                                , "in/min²"
                                                                , SI.Accelerations.CentimeterPerSquareSecond
                                                                , 2.54 / (60.0 * 60.0)
                                                                 );

   /// <summary>
   /// mil per square second, defined as: inch per square second × (1.0/1000.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareSecond = new (
                                                                 "mil per square second"
                                                               , "mil/s²"
                                                               , InchPerSquareSecond
                                                               , 1.0 / 1000.0 / (1.0 * 1.0)
                                                                );

   /// <summary>
   /// mil per square planck-time, defined as: inch per square microsecond × (1.0/1000.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration MilPerSquarePlanckTime = new (
                                                                     "mil per square planck-time"
                                                                   , "mil/tₚ²"
                                                                   , InchPerSquareMicrosecond
                                                                   , 1.0 / 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                    );

   /// <summary>
   /// mil per square decisecond, defined as: inch per square second × (1.0/1000.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareDecisecond = new (
                                                                     "mil per square decisecond"
                                                                   , "mil/ds²"
                                                                   , InchPerSquareSecond
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    );

   /// <summary>
   /// mil per square centisecond, defined as: inch per square decisecond × (1.0/1000.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareCentisecond = new (
                                                                      "mil per square centisecond"
                                                                    , "mil/cs²"
                                                                    , InchPerSquareDecisecond
                                                                    , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// mil per square millisecond, defined as: inch per square centisecond × (1.0/1000.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareMillisecond = new (
                                                                      "mil per square millisecond"
                                                                    , "mil/ms²"
                                                                    , InchPerSquareCentisecond
                                                                    , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// mil per square microsecond, defined as: inch per square millisecond × (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareMicrosecond = new (
                                                                      "mil per square microsecond"
                                                                    , "mil/μs²"
                                                                    , InchPerSquareMillisecond
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// mil per square nanosecond, defined as: inch per square microsecond × (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareNanosecond = new (
                                                                     "mil per square nanosecond"
                                                                   , "mil/ns²"
                                                                   , InchPerSquareMicrosecond
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    );

   /// <summary>
   /// mil per square picosecond, defined as: inch per square nanosecond × (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquarePicosecond = new (
                                                                     "mil per square picosecond"
                                                                   , "mil/ps²"
                                                                   , InchPerSquareNanosecond
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    );

   /// <summary>
   /// mil per square femtosecond, defined as: inch per square picosecond × (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareFemtosecond = new (
                                                                      "mil per square femtosecond"
                                                                    , "mil/fs²"
                                                                    , InchPerSquarePicosecond
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// mil per square attosecond, defined as: inch per square femtosecond × (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareAttosecond = new (
                                                                     "mil per square attosecond"
                                                                   , "mil/as²"
                                                                   , InchPerSquareFemtosecond
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    );

   /// <summary>
   /// mil per square zeptosecond, defined as: inch per square attosecond × (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareZeptosecond = new (
                                                                      "mil per square zeptosecond"
                                                                    , "mil/zs²"
                                                                    , InchPerSquareAttosecond
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// mil per square yoctosecond, defined as: inch per square zeptosecond × (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareYoctosecond = new (
                                                                      "mil per square yoctosecond"
                                                                    , "mil/ys²"
                                                                    , InchPerSquareZeptosecond
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// mil per square rontosecond, defined as: inch per square yoctosecond × (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareRontosecond = new (
                                                                      "mil per square rontosecond"
                                                                    , "mil/rs²"
                                                                    , InchPerSquareYoctosecond
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// mil per square quectosecond, defined as: inch per square rontosecond × (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareQuectosecond = new (
                                                                       "mil per square quectosecond"
                                                                     , "mil/qs²"
                                                                     , InchPerSquareRontosecond
                                                                     , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// inch per square hour, defined as: SI centimeter per square minute × (2.54)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareHour = new (
                                                                "inch per square hour"
                                                              , "in/hr²"
                                                              , SI.Accelerations.CentimeterPerSquareMinute
                                                              , 2.54 / (60.0 * 60.0)
                                                               );

   /// <summary>
   /// point per square second, defined as: inch per square second × (1.0/72.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareSecond =
            new ("point per square second", "p/s²", InchPerSquareSecond, 1.0 / 72.0 / (1.0 * 1.0));

   /// <summary>
   /// point per square planck-time, defined as: inch per square microsecond × (1.0/72.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration PointPerSquarePlanckTime = new (
                                                                       "point per square planck-time"
                                                                     , "p/tₚ²"
                                                                     , InchPerSquareMicrosecond
                                                                     , 1.0 / 72.0 / (5.391247E-38 * 5.391247E-38)
                                                                      );

   /// <summary>
   /// point per square decisecond, defined as: inch per square second × (1.0/72.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareDecisecond = new (
                                                                       "point per square decisecond"
                                                                     , "p/ds²"
                                                                     , InchPerSquareSecond
                                                                     , 1.0 / 72.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// point per square centisecond, defined as: inch per square decisecond × (1.0/72.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareCentisecond = new (
                                                                        "point per square centisecond"
                                                                      , "p/cs²"
                                                                      , InchPerSquareDecisecond
                                                                      , 1.0 / 72.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// point per square millisecond, defined as: inch per square centisecond × (1.0/72.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareMillisecond = new (
                                                                        "point per square millisecond"
                                                                      , "p/ms²"
                                                                      , InchPerSquareCentisecond
                                                                      , 1.0 / 72.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// point per square microsecond, defined as: inch per square millisecond × (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareMicrosecond = new (
                                                                        "point per square microsecond"
                                                                      , "p/μs²"
                                                                      , InchPerSquareMillisecond
                                                                      , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// point per square nanosecond, defined as: inch per square microsecond × (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareNanosecond = new (
                                                                       "point per square nanosecond"
                                                                     , "p/ns²"
                                                                     , InchPerSquareMicrosecond
                                                                     , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// point per square picosecond, defined as: inch per square nanosecond × (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquarePicosecond = new (
                                                                       "point per square picosecond"
                                                                     , "p/ps²"
                                                                     , InchPerSquareNanosecond
                                                                     , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// point per square femtosecond, defined as: inch per square picosecond × (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareFemtosecond = new (
                                                                        "point per square femtosecond"
                                                                      , "p/fs²"
                                                                      , InchPerSquarePicosecond
                                                                      , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// point per square attosecond, defined as: inch per square femtosecond × (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareAttosecond = new (
                                                                       "point per square attosecond"
                                                                     , "p/as²"
                                                                     , InchPerSquareFemtosecond
                                                                     , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// point per square zeptosecond, defined as: inch per square attosecond × (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareZeptosecond = new (
                                                                        "point per square zeptosecond"
                                                                      , "p/zs²"
                                                                      , InchPerSquareAttosecond
                                                                      , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// point per square yoctosecond, defined as: inch per square zeptosecond × (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareYoctosecond = new (
                                                                        "point per square yoctosecond"
                                                                      , "p/ys²"
                                                                      , InchPerSquareZeptosecond
                                                                      , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// point per square rontosecond, defined as: inch per square yoctosecond × (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareRontosecond = new (
                                                                        "point per square rontosecond"
                                                                      , "p/rs²"
                                                                      , InchPerSquareYoctosecond
                                                                      , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// point per square quectosecond, defined as: inch per square rontosecond × (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareQuectosecond = new (
                                                                         "point per square quectosecond"
                                                                       , "p/qs²"
                                                                       , InchPerSquareRontosecond
                                                                       , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// inch per square day, defined as: SI centimeter per square hour × (2.54)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareDay = new (
                                                               "inch per square day"
                                                             , "in/dy²"
                                                             , SI.Accelerations.CentimeterPerSquareHour
                                                             , 2.54 / (24.0 * 24.0)
                                                              );

   /// <summary>
   /// twip per square second, defined as: point per square second × (1.0/20.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareSecond = new (
                                                                  "twip per square second"
                                                                , "twip/s²"
                                                                , PointPerSquareSecond
                                                                , 1.0 / 20.0 / (1.0 * 1.0)
                                                                 );

   /// <summary>
   /// twip per square planck-time, defined as: point per square microsecond × (1.0/20.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration TwipPerSquarePlanckTime = new (
                                                                      "twip per square planck-time"
                                                                    , "twip/tₚ²"
                                                                    , PointPerSquareMicrosecond
                                                                    , 1.0 / 20.0 / (5.391247E-38 * 5.391247E-38)
                                                                     );

   /// <summary>
   /// twip per square decisecond, defined as: point per square second × (1.0/20.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecisecond = new (
                                                                      "twip per square decisecond"
                                                                    , "twip/ds²"
                                                                    , PointPerSquareSecond
                                                                    , 1.0 / 20.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// twip per square centisecond, defined as: point per square decisecond × (1.0/20.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareCentisecond = new (
                                                                       "twip per square centisecond"
                                                                     , "twip/cs²"
                                                                     , PointPerSquareDecisecond
                                                                     , 1.0 / 20.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// twip per square millisecond, defined as: point per square centisecond × (1.0/20.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillisecond = new (
                                                                       "twip per square millisecond"
                                                                     , "twip/ms²"
                                                                     , PointPerSquareCentisecond
                                                                     , 1.0 / 20.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// twip per square microsecond, defined as: point per square millisecond × (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareMicrosecond = new (
                                                                       "twip per square microsecond"
                                                                     , "twip/μs²"
                                                                     , PointPerSquareMillisecond
                                                                     , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// twip per square nanosecond, defined as: point per square microsecond × (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareNanosecond = new (
                                                                      "twip per square nanosecond"
                                                                    , "twip/ns²"
                                                                    , PointPerSquareMicrosecond
                                                                    , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// twip per square picosecond, defined as: point per square nanosecond × (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquarePicosecond = new (
                                                                      "twip per square picosecond"
                                                                    , "twip/ps²"
                                                                    , PointPerSquareNanosecond
                                                                    , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// twip per square femtosecond, defined as: point per square picosecond × (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareFemtosecond = new (
                                                                       "twip per square femtosecond"
                                                                     , "twip/fs²"
                                                                     , PointPerSquarePicosecond
                                                                     , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// twip per square attosecond, defined as: point per square femtosecond × (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareAttosecond = new (
                                                                      "twip per square attosecond"
                                                                    , "twip/as²"
                                                                    , PointPerSquareFemtosecond
                                                                    , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// twip per square zeptosecond, defined as: point per square attosecond × (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareZeptosecond = new (
                                                                       "twip per square zeptosecond"
                                                                     , "twip/zs²"
                                                                     , PointPerSquareAttosecond
                                                                     , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// twip per square yoctosecond, defined as: point per square zeptosecond × (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareYoctosecond = new (
                                                                       "twip per square yoctosecond"
                                                                     , "twip/ys²"
                                                                     , PointPerSquareZeptosecond
                                                                     , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// twip per square rontosecond, defined as: point per square yoctosecond × (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareRontosecond = new (
                                                                       "twip per square rontosecond"
                                                                     , "twip/rs²"
                                                                     , PointPerSquareYoctosecond
                                                                     , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// twip per square quectosecond, defined as: point per square rontosecond × (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuectosecond = new (
                                                                        "twip per square quectosecond"
                                                                      , "twip/qs²"
                                                                      , PointPerSquareRontosecond
                                                                      , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// inch per square week, defined as: SI centimeter per square day × (2.54)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareWeek = new (
                                                                "inch per square week"
                                                              , "in/wk²"
                                                              , SI.Accelerations.CentimeterPerSquareDay
                                                              , 2.54 / (7.0 * 7.0)
                                                               );

   /// <summary>
   /// pica per square second, defined as: point per square second × (12.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareSecond =
            new ("pica per square second", "P/s²", PointPerSquareSecond, 12.0 / (1.0 * 1.0));

   /// <summary>
   /// pica per square planck-time, defined as: point per square microsecond × (12.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration PicaPerSquarePlanckTime = new (
                                                                      "pica per square planck-time"
                                                                    , "P/tₚ²"
                                                                    , PointPerSquareMicrosecond
                                                                    , 12.0 / (5.391247E-38 * 5.391247E-38)
                                                                     );

   /// <summary>
   /// pica per square decisecond, defined as: point per square second × (12.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareDecisecond = new (
                                                                      "pica per square decisecond"
                                                                    , "P/ds²"
                                                                    , PointPerSquareSecond
                                                                    , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// pica per square centisecond, defined as: point per square decisecond × (12.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareCentisecond = new (
                                                                       "pica per square centisecond"
                                                                     , "P/cs²"
                                                                     , PointPerSquareDecisecond
                                                                     , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// pica per square millisecond, defined as: point per square centisecond × (12.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareMillisecond = new (
                                                                       "pica per square millisecond"
                                                                     , "P/ms²"
                                                                     , PointPerSquareCentisecond
                                                                     , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// pica per square microsecond, defined as: point per square millisecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareMicrosecond = new (
                                                                       "pica per square microsecond"
                                                                     , "P/μs²"
                                                                     , PointPerSquareMillisecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// pica per square nanosecond, defined as: point per square microsecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareNanosecond = new (
                                                                      "pica per square nanosecond"
                                                                    , "P/ns²"
                                                                    , PointPerSquareMicrosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// pica per square picosecond, defined as: point per square nanosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquarePicosecond = new (
                                                                      "pica per square picosecond"
                                                                    , "P/ps²"
                                                                    , PointPerSquareNanosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// pica per square femtosecond, defined as: point per square picosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareFemtosecond = new (
                                                                       "pica per square femtosecond"
                                                                     , "P/fs²"
                                                                     , PointPerSquarePicosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// pica per square attosecond, defined as: point per square femtosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareAttosecond = new (
                                                                      "pica per square attosecond"
                                                                    , "P/as²"
                                                                    , PointPerSquareFemtosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// pica per square zeptosecond, defined as: point per square attosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareZeptosecond = new (
                                                                       "pica per square zeptosecond"
                                                                     , "P/zs²"
                                                                     , PointPerSquareAttosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// pica per square yoctosecond, defined as: point per square zeptosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareYoctosecond = new (
                                                                       "pica per square yoctosecond"
                                                                     , "P/ys²"
                                                                     , PointPerSquareZeptosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// pica per square rontosecond, defined as: point per square yoctosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareRontosecond = new (
                                                                       "pica per square rontosecond"
                                                                     , "P/rs²"
                                                                     , PointPerSquareYoctosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// pica per square quectosecond, defined as: point per square rontosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareQuectosecond = new (
                                                                        "pica per square quectosecond"
                                                                      , "P/qs²"
                                                                      , PointPerSquareRontosecond
                                                                      , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// inch per square year, defined as: SI centimeter per square day × (2.54)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration InchPerSquareYear = new (
                                                                "inch per square year"
                                                              , "in/yr²"
                                                              , SI.Accelerations.CentimeterPerSquareDay
                                                              , 2.54 / (365.2525 * 365.2525)
                                                               );

   /// <summary>
   /// foot per square second, defined as: inch per square second × (12.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareSecond =
            new ("foot per square second", "ft/s²", InchPerSquareSecond, 12.0 / (1.0 * 1.0));

   /// <summary>
   /// foot per square planck-time, defined as: inch per square microsecond × (12.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration FootPerSquarePlanckTime = new (
                                                                      "foot per square planck-time"
                                                                    , "ft/tₚ²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 12.0 / (5.391247E-38 * 5.391247E-38)
                                                                     );

   /// <summary>
   /// foot per square decisecond, defined as: inch per square second × (12.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareDecisecond = new (
                                                                      "foot per square decisecond"
                                                                    , "ft/ds²"
                                                                    , InchPerSquareSecond
                                                                    , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// foot per square centisecond, defined as: inch per square decisecond × (12.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareCentisecond = new (
                                                                       "foot per square centisecond"
                                                                     , "ft/cs²"
                                                                     , InchPerSquareDecisecond
                                                                     , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// foot per square millisecond, defined as: inch per square centisecond × (12.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareMillisecond = new (
                                                                       "foot per square millisecond"
                                                                     , "ft/ms²"
                                                                     , InchPerSquareCentisecond
                                                                     , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// foot per square microsecond, defined as: inch per square millisecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareMicrosecond = new (
                                                                       "foot per square microsecond"
                                                                     , "ft/μs²"
                                                                     , InchPerSquareMillisecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// foot per square nanosecond, defined as: inch per square microsecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareNanosecond = new (
                                                                      "foot per square nanosecond"
                                                                    , "ft/ns²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// foot per square picosecond, defined as: inch per square nanosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquarePicosecond = new (
                                                                      "foot per square picosecond"
                                                                    , "ft/ps²"
                                                                    , InchPerSquareNanosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// foot per square femtosecond, defined as: inch per square picosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareFemtosecond = new (
                                                                       "foot per square femtosecond"
                                                                     , "ft/fs²"
                                                                     , InchPerSquarePicosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// foot per square attosecond, defined as: inch per square femtosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareAttosecond = new (
                                                                      "foot per square attosecond"
                                                                    , "ft/as²"
                                                                    , InchPerSquareFemtosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// foot per square zeptosecond, defined as: inch per square attosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareZeptosecond = new (
                                                                       "foot per square zeptosecond"
                                                                     , "ft/zs²"
                                                                     , InchPerSquareAttosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// foot per square yoctosecond, defined as: inch per square zeptosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareYoctosecond = new (
                                                                       "foot per square yoctosecond"
                                                                     , "ft/ys²"
                                                                     , InchPerSquareZeptosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// foot per square rontosecond, defined as: inch per square yoctosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareRontosecond = new (
                                                                       "foot per square rontosecond"
                                                                     , "ft/rs²"
                                                                     , InchPerSquareYoctosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// foot per square quectosecond, defined as: inch per square rontosecond × (12.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareQuectosecond = new (
                                                                        "foot per square quectosecond"
                                                                      , "ft/qs²"
                                                                      , InchPerSquareRontosecond
                                                                      , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// inch per square decade, defined as: SI centimeter per square year × (2.54)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareDecade = new (
                                                                  "inch per square decade"
                                                                , "in/decade²"
                                                                , SI.Accelerations.CentimeterPerSquareYear
                                                                , 2.54 / (10.0 * 10.0)
                                                                 );

   /// <summary>
   /// yard per square second, defined as: foot per square second × (3.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareSecond =
            new ("yard per square second", "yd/s²", FootPerSquareSecond, 3.0 / (1.0 * 1.0));

   /// <summary>
   /// yard per square planck-time, defined as: foot per square microsecond × (3.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration YardPerSquarePlanckTime = new (
                                                                      "yard per square planck-time"
                                                                    , "yd/tₚ²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 3.0 / (5.391247E-38 * 5.391247E-38)
                                                                     );

   /// <summary>
   /// yard per square decisecond, defined as: foot per square second × (3.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareDecisecond = new (
                                                                      "yard per square decisecond"
                                                                    , "yd/ds²"
                                                                    , FootPerSquareSecond
                                                                    , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// yard per square centisecond, defined as: foot per square decisecond × (3.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareCentisecond = new (
                                                                       "yard per square centisecond"
                                                                     , "yd/cs²"
                                                                     , FootPerSquareDecisecond
                                                                     , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// yard per square millisecond, defined as: foot per square centisecond × (3.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareMillisecond = new (
                                                                       "yard per square millisecond"
                                                                     , "yd/ms²"
                                                                     , FootPerSquareCentisecond
                                                                     , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// yard per square microsecond, defined as: foot per square millisecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareMicrosecond = new (
                                                                       "yard per square microsecond"
                                                                     , "yd/μs²"
                                                                     , FootPerSquareMillisecond
                                                                     , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// yard per square nanosecond, defined as: foot per square microsecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareNanosecond = new (
                                                                      "yard per square nanosecond"
                                                                    , "yd/ns²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// yard per square picosecond, defined as: foot per square nanosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquarePicosecond = new (
                                                                      "yard per square picosecond"
                                                                    , "yd/ps²"
                                                                    , FootPerSquareNanosecond
                                                                    , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// yard per square femtosecond, defined as: foot per square picosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareFemtosecond = new (
                                                                       "yard per square femtosecond"
                                                                     , "yd/fs²"
                                                                     , FootPerSquarePicosecond
                                                                     , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// yard per square attosecond, defined as: foot per square femtosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareAttosecond = new (
                                                                      "yard per square attosecond"
                                                                    , "yd/as²"
                                                                    , FootPerSquareFemtosecond
                                                                    , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// yard per square zeptosecond, defined as: foot per square attosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareZeptosecond = new (
                                                                       "yard per square zeptosecond"
                                                                     , "yd/zs²"
                                                                     , FootPerSquareAttosecond
                                                                     , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// yard per square yoctosecond, defined as: foot per square zeptosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareYoctosecond = new (
                                                                       "yard per square yoctosecond"
                                                                     , "yd/ys²"
                                                                     , FootPerSquareZeptosecond
                                                                     , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// yard per square rontosecond, defined as: foot per square yoctosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareRontosecond = new (
                                                                       "yard per square rontosecond"
                                                                     , "yd/rs²"
                                                                     , FootPerSquareYoctosecond
                                                                     , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// yard per square quectosecond, defined as: foot per square rontosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareQuectosecond = new (
                                                                        "yard per square quectosecond"
                                                                      , "yd/qs²"
                                                                      , FootPerSquareRontosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// inch per square century, defined as: SI centimeter per square decade × (2.54)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareCentury = new (
                                                                   "inch per square century"
                                                                 , "in/century²"
                                                                 , SI.Accelerations.CentimeterPerSquareDecade
                                                                 , 2.54 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// mile per square second, defined as: yard per square second × (1760.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareSecond =
            new ("mile per square second", "mi/s²", YardPerSquareSecond, 1760.0 / (1.0 * 1.0));

   /// <summary>
   /// mile per square planck-time, defined as: yard per square microsecond × (1760.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration MilePerSquarePlanckTime = new (
                                                                      "mile per square planck-time"
                                                                    , "mi/tₚ²"
                                                                    , YardPerSquareMicrosecond
                                                                    , 1760.0 / (5.391247E-38 * 5.391247E-38)
                                                                     );

   /// <summary>
   /// mile per square decisecond, defined as: yard per square second × (1760.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareDecisecond = new (
                                                                      "mile per square decisecond"
                                                                    , "mi/ds²"
                                                                    , YardPerSquareSecond
                                                                    , 1760.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// mile per square centisecond, defined as: yard per square decisecond × (1760.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareCentisecond = new (
                                                                       "mile per square centisecond"
                                                                     , "mi/cs²"
                                                                     , YardPerSquareDecisecond
                                                                     , 1760.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// mile per square millisecond, defined as: yard per square centisecond × (1760.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareMillisecond = new (
                                                                       "mile per square millisecond"
                                                                     , "mi/ms²"
                                                                     , YardPerSquareCentisecond
                                                                     , 1760.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// mile per square microsecond, defined as: yard per square millisecond × (1760.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareMicrosecond = new (
                                                                       "mile per square microsecond"
                                                                     , "mi/μs²"
                                                                     , YardPerSquareMillisecond
                                                                     , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// mile per square nanosecond, defined as: yard per square microsecond × (1760.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareNanosecond = new (
                                                                      "mile per square nanosecond"
                                                                    , "mi/ns²"
                                                                    , YardPerSquareMicrosecond
                                                                    , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// mile per square picosecond, defined as: yard per square nanosecond × (1760.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquarePicosecond = new (
                                                                      "mile per square picosecond"
                                                                    , "mi/ps²"
                                                                    , YardPerSquareNanosecond
                                                                    , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// mile per square femtosecond, defined as: yard per square picosecond × (1760.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareFemtosecond = new (
                                                                       "mile per square femtosecond"
                                                                     , "mi/fs²"
                                                                     , YardPerSquarePicosecond
                                                                     , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// mile per square attosecond, defined as: yard per square femtosecond × (1760.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareAttosecond = new (
                                                                      "mile per square attosecond"
                                                                    , "mi/as²"
                                                                    , YardPerSquareFemtosecond
                                                                    , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// mile per square zeptosecond, defined as: yard per square attosecond × (1760.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareZeptosecond = new (
                                                                       "mile per square zeptosecond"
                                                                     , "mi/zs²"
                                                                     , YardPerSquareAttosecond
                                                                     , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// mile per square yoctosecond, defined as: yard per square zeptosecond × (1760.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareYoctosecond = new (
                                                                       "mile per square yoctosecond"
                                                                     , "mi/ys²"
                                                                     , YardPerSquareZeptosecond
                                                                     , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// mile per square rontosecond, defined as: yard per square yoctosecond × (1760.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareRontosecond = new (
                                                                       "mile per square rontosecond"
                                                                     , "mi/rs²"
                                                                     , YardPerSquareYoctosecond
                                                                     , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// mile per square quectosecond, defined as: yard per square rontosecond × (1760.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareQuectosecond = new (
                                                                        "mile per square quectosecond"
                                                                      , "mi/qs²"
                                                                      , YardPerSquareRontosecond
                                                                      , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// inch per square millennium, defined as: SI centimeter per square century × (2.54)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareMillennium = new (
                                                                      "inch per square millennium"
                                                                    , "in/kyr²"
                                                                    , SI.Accelerations.CentimeterPerSquareCentury
                                                                    , 2.54 / (10.0 * 10.0)
                                                                     );

   /// <summary>
   /// league per square second, defined as: mile per square second × (3.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSecond =
            new ("league per square second", "le/s²", MilePerSquareSecond, 3.0 / (1.0 * 1.0));

   /// <summary>
   /// league per square planck-time, defined as: mile per square microsecond × (3.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePlanckTime = new (
                                                                        "league per square planck-time"
                                                                      , "le/tₚ²"
                                                                      , MilePerSquareMicrosecond
                                                                      , 3.0 / (5.391247E-38 * 5.391247E-38)
                                                                       );

   /// <summary>
   /// league per square decisecond, defined as: mile per square second × (3.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecisecond = new (
                                                                        "league per square decisecond"
                                                                      , "le/ds²"
                                                                      , MilePerSquareSecond
                                                                      , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// league per square centisecond, defined as: mile per square decisecond × (3.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentisecond = new (
                                                                         "league per square centisecond"
                                                                       , "le/cs²"
                                                                       , MilePerSquareDecisecond
                                                                       , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        );

   /// <summary>
   /// league per square millisecond, defined as: mile per square centisecond × (3.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillisecond = new (
                                                                         "league per square millisecond"
                                                                       , "le/ms²"
                                                                       , MilePerSquareCentisecond
                                                                       , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        );

   /// <summary>
   /// league per square microsecond, defined as: mile per square millisecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMicrosecond = new (
                                                                         "league per square microsecond"
                                                                       , "le/μs²"
                                                                       , MilePerSquareMillisecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// league per square nanosecond, defined as: mile per square microsecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNanosecond = new (
                                                                        "league per square nanosecond"
                                                                      , "le/ns²"
                                                                      , MilePerSquareMicrosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// league per square picosecond, defined as: mile per square nanosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePicosecond = new (
                                                                        "league per square picosecond"
                                                                      , "le/ps²"
                                                                      , MilePerSquareNanosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// league per square femtosecond, defined as: mile per square picosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareFemtosecond = new (
                                                                         "league per square femtosecond"
                                                                       , "le/fs²"
                                                                       , MilePerSquarePicosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// league per square attosecond, defined as: mile per square femtosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareAttosecond = new (
                                                                        "league per square attosecond"
                                                                      , "le/as²"
                                                                      , MilePerSquareFemtosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// league per square zeptosecond, defined as: mile per square attosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareZeptosecond = new (
                                                                         "league per square zeptosecond"
                                                                       , "le/zs²"
                                                                       , MilePerSquareAttosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// league per square yoctosecond, defined as: mile per square zeptosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYoctosecond = new (
                                                                         "league per square yoctosecond"
                                                                       , "le/ys²"
                                                                       , MilePerSquareZeptosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// league per square rontosecond, defined as: mile per square yoctosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareRontosecond = new (
                                                                         "league per square rontosecond"
                                                                       , "le/rs²"
                                                                       , MilePerSquareYoctosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// league per square quectosecond, defined as: mile per square rontosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuectosecond = new (
                                                                          "league per square quectosecond"
                                                                        , "le/qs²"
                                                                        , MilePerSquareRontosecond
                                                                        , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         );

   /// <summary>
   /// inch per square million years, defined as: SI centimeter per square millennium × (2.54)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareMillionYears = new (
                                                                        "inch per square million years"
                                                                      , "in/Myr²"
                                                                      , SI.Accelerations.CentimeterPerSquareMillennium
                                                                      , 2.54 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// fathom per square second, defined as: yard per square second × (2.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareSecond =
            new ("fathom per square second", "ftm/s²", YardPerSquareSecond, 2.0 / (1.0 * 1.0));

   /// <summary>
   /// fathom per square planck-time, defined as: yard per square microsecond × (2.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration FathomPerSquarePlanckTime = new (
                                                                        "fathom per square planck-time"
                                                                      , "ftm/tₚ²"
                                                                      , YardPerSquareMicrosecond
                                                                      , 2.0 / (5.391247E-38 * 5.391247E-38)
                                                                       );

   /// <summary>
   /// fathom per square decisecond, defined as: yard per square second × (2.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecisecond = new (
                                                                        "fathom per square decisecond"
                                                                      , "ftm/ds²"
                                                                      , YardPerSquareSecond
                                                                      , 2.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// fathom per square centisecond, defined as: yard per square decisecond × (2.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareCentisecond = new (
                                                                         "fathom per square centisecond"
                                                                       , "ftm/cs²"
                                                                       , YardPerSquareDecisecond
                                                                       , 2.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        );

   /// <summary>
   /// fathom per square millisecond, defined as: yard per square centisecond × (2.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillisecond = new (
                                                                         "fathom per square millisecond"
                                                                       , "ftm/ms²"
                                                                       , YardPerSquareCentisecond
                                                                       , 2.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        );

   /// <summary>
   /// fathom per square microsecond, defined as: yard per square millisecond × (2.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareMicrosecond = new (
                                                                         "fathom per square microsecond"
                                                                       , "ftm/μs²"
                                                                       , YardPerSquareMillisecond
                                                                       , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// fathom per square nanosecond, defined as: yard per square microsecond × (2.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareNanosecond = new (
                                                                        "fathom per square nanosecond"
                                                                      , "ftm/ns²"
                                                                      , YardPerSquareMicrosecond
                                                                      , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// fathom per square picosecond, defined as: yard per square nanosecond × (2.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquarePicosecond = new (
                                                                        "fathom per square picosecond"
                                                                      , "ftm/ps²"
                                                                      , YardPerSquareNanosecond
                                                                      , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// fathom per square femtosecond, defined as: yard per square picosecond × (2.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareFemtosecond = new (
                                                                         "fathom per square femtosecond"
                                                                       , "ftm/fs²"
                                                                       , YardPerSquarePicosecond
                                                                       , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// fathom per square attosecond, defined as: yard per square femtosecond × (2.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareAttosecond = new (
                                                                        "fathom per square attosecond"
                                                                      , "ftm/as²"
                                                                      , YardPerSquareFemtosecond
                                                                      , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// fathom per square zeptosecond, defined as: yard per square attosecond × (2.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareZeptosecond = new (
                                                                         "fathom per square zeptosecond"
                                                                       , "ftm/zs²"
                                                                       , YardPerSquareAttosecond
                                                                       , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// fathom per square yoctosecond, defined as: yard per square zeptosecond × (2.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareYoctosecond = new (
                                                                         "fathom per square yoctosecond"
                                                                       , "ftm/ys²"
                                                                       , YardPerSquareZeptosecond
                                                                       , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// fathom per square rontosecond, defined as: yard per square yoctosecond × (2.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareRontosecond = new (
                                                                         "fathom per square rontosecond"
                                                                       , "ftm/rs²"
                                                                       , YardPerSquareYoctosecond
                                                                       , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// fathom per square quectosecond, defined as: yard per square rontosecond × (2.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuectosecond = new (
                                                                          "fathom per square quectosecond"
                                                                        , "ftm/qs²"
                                                                        , YardPerSquareRontosecond
                                                                        , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         );

   /// <summary>
   /// inch per square billion years, defined as: SI centimeter per square million years × (2.54)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareBillionYears = new (
                                                                        "inch per square billion years"
                                                                      , "in/Gyr²"
                                                                      , SI.Accelerations.CentimeterPerSquareMillionYears
                                                                      , 2.54 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// cable per square second, defined as: fathom per square second × (120.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareSecond =
            new ("cable per square second", "cb/s²", FathomPerSquareSecond, 120.0 / (1.0 * 1.0));

   /// <summary>
   /// cable per square planck-time, defined as: fathom per square microsecond × (120.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration CablePerSquarePlanckTime = new (
                                                                       "cable per square planck-time"
                                                                     , "cb/tₚ²"
                                                                     , FathomPerSquareMicrosecond
                                                                     , 120.0 / (5.391247E-38 * 5.391247E-38)
                                                                      );

   /// <summary>
   /// cable per square decisecond, defined as: fathom per square second × (120.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareDecisecond = new (
                                                                       "cable per square decisecond"
                                                                     , "cb/ds²"
                                                                     , FathomPerSquareSecond
                                                                     , 120.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// cable per square centisecond, defined as: fathom per square decisecond × (120.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareCentisecond = new (
                                                                        "cable per square centisecond"
                                                                      , "cb/cs²"
                                                                      , FathomPerSquareDecisecond
                                                                      , 120.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// cable per square millisecond, defined as: fathom per square centisecond × (120.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareMillisecond = new (
                                                                        "cable per square millisecond"
                                                                      , "cb/ms²"
                                                                      , FathomPerSquareCentisecond
                                                                      , 120.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// cable per square microsecond, defined as: fathom per square millisecond × (120.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareMicrosecond = new (
                                                                        "cable per square microsecond"
                                                                      , "cb/μs²"
                                                                      , FathomPerSquareMillisecond
                                                                      , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// cable per square nanosecond, defined as: fathom per square microsecond × (120.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareNanosecond = new (
                                                                       "cable per square nanosecond"
                                                                     , "cb/ns²"
                                                                     , FathomPerSquareMicrosecond
                                                                     , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// cable per square picosecond, defined as: fathom per square nanosecond × (120.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquarePicosecond = new (
                                                                       "cable per square picosecond"
                                                                     , "cb/ps²"
                                                                     , FathomPerSquareNanosecond
                                                                     , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// cable per square femtosecond, defined as: fathom per square picosecond × (120.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareFemtosecond = new (
                                                                        "cable per square femtosecond"
                                                                      , "cb/fs²"
                                                                      , FathomPerSquarePicosecond
                                                                      , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// cable per square attosecond, defined as: fathom per square femtosecond × (120.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareAttosecond = new (
                                                                       "cable per square attosecond"
                                                                     , "cb/as²"
                                                                     , FathomPerSquareFemtosecond
                                                                     , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// cable per square zeptosecond, defined as: fathom per square attosecond × (120.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareZeptosecond = new (
                                                                        "cable per square zeptosecond"
                                                                      , "cb/zs²"
                                                                      , FathomPerSquareAttosecond
                                                                      , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// cable per square yoctosecond, defined as: fathom per square zeptosecond × (120.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareYoctosecond = new (
                                                                        "cable per square yoctosecond"
                                                                      , "cb/ys²"
                                                                      , FathomPerSquareZeptosecond
                                                                      , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// cable per square rontosecond, defined as: fathom per square yoctosecond × (120.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareRontosecond = new (
                                                                        "cable per square rontosecond"
                                                                      , "cb/rs²"
                                                                      , FathomPerSquareYoctosecond
                                                                      , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// cable per square quectosecond, defined as: fathom per square rontosecond × (120.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareQuectosecond = new (
                                                                         "cable per square quectosecond"
                                                                       , "cb/qs²"
                                                                       , FathomPerSquareRontosecond
                                                                       , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// inch per square trillion years, defined as: SI centimeter per square billion years × (2.54)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareTrillionYears = new (
                                                                         "inch per square trillion years"
                                                                       , "in/Tyr²"
                                                                       , SI.Accelerations
                                                                           .CentimeterPerSquareBillionYears
                                                                       , 2.54 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// nautical mile per square second, defined as: SI meter per square second × (1852.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSecond = new (
                                                                          "nautical mile per square second"
                                                                        , "nmi/s²"
                                                                        , SI.Accelerations.MeterPerSquareSecond
                                                                        , 1852.0 / (1.0 * 1.0)
                                                                         );

   /// <summary>
   /// nautical mile per square planck-time, defined as: SI meter per square microsecond × (1852.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquarePlanckTime = new (
                                                                              "nautical mile per square planck-time"
                                                                            , "nmi/tₚ²"
                                                                            , SI.Accelerations.MeterPerSquareMicrosecond
                                                                            , 1852.0 / (5.391247E-38 * 5.391247E-38)
                                                                             );

   /// <summary>
   /// nautical mile per square decisecond, defined as: SI meter per square second × (1852.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecisecond = new (
                                                                              "nautical mile per square decisecond"
                                                                            , "nmi/ds²"
                                                                            , SI.Accelerations.MeterPerSquareSecond
                                                                            , 1852.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                             );

   /// <summary>
   /// nautical mile per square centisecond, defined as: SI meter per square decisecond × (1852.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareCentisecond = new (
                                                                               "nautical mile per square centisecond"
                                                                             , "nmi/cs²"
                                                                             , SI.Accelerations.MeterPerSquareDecisecond
                                                                             , 1852.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                              );

   /// <summary>
   /// nautical mile per square millisecond, defined as: SI meter per square centisecond × (1852.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillisecond = new (
                                                                               "nautical mile per square millisecond"
                                                                             , "nmi/ms²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareCentisecond
                                                                             , 1852.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                              );

   /// <summary>
   /// nautical mile per square microsecond, defined as: SI meter per square millisecond × (1852.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMicrosecond = new (
                                                                               "nautical mile per square microsecond"
                                                                             , "nmi/μs²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareMillisecond
                                                                             , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              );

   /// <summary>
   /// nautical mile per square nanosecond, defined as: SI meter per square microsecond × (1852.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareNanosecond = new (
                                                                              "nautical mile per square nanosecond"
                                                                            , "nmi/ns²"
                                                                            , SI.Accelerations.MeterPerSquareMicrosecond
                                                                            , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             );

   /// <summary>
   /// nautical mile per square picosecond, defined as: SI meter per square nanosecond × (1852.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquarePicosecond = new (
                                                                              "nautical mile per square picosecond"
                                                                            , "nmi/ps²"
                                                                            , SI.Accelerations.MeterPerSquareNanosecond
                                                                            , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             );

   /// <summary>
   /// nautical mile per square femtosecond, defined as: SI meter per square picosecond × (1852.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareFemtosecond = new (
                                                                               "nautical mile per square femtosecond"
                                                                             , "nmi/fs²"
                                                                             , SI.Accelerations.MeterPerSquarePicosecond
                                                                             , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              );

   /// <summary>
   /// nautical mile per square attosecond, defined as: SI meter per square femtosecond × (1852.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareAttosecond = new (
                                                                              "nautical mile per square attosecond"
                                                                            , "nmi/as²"
                                                                            , SI.Accelerations.MeterPerSquareFemtosecond
                                                                            , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             );

   /// <summary>
   /// nautical mile per square zeptosecond, defined as: SI meter per square attosecond × (1852.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareZeptosecond = new (
                                                                               "nautical mile per square zeptosecond"
                                                                             , "nmi/zs²"
                                                                             , SI.Accelerations.MeterPerSquareAttosecond
                                                                             , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              );

   /// <summary>
   /// nautical mile per square yoctosecond, defined as: SI meter per square zeptosecond × (1852.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareYoctosecond = new (
                                                                               "nautical mile per square yoctosecond"
                                                                             , "nmi/ys²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareZeptosecond
                                                                             , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              );

   /// <summary>
   /// nautical mile per square rontosecond, defined as: SI meter per square yoctosecond × (1852.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareRontosecond = new (
                                                                               "nautical mile per square rontosecond"
                                                                             , "nmi/rs²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareYoctosecond
                                                                             , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              );

   /// <summary>
   /// nautical mile per square quectosecond, defined as: SI meter per square rontosecond × (1852.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuectosecond = new (
                                                                                "nautical mile per square quectosecond"
                                                                              , "nmi/qs²"
                                                                              , SI.Accelerations
                                                                                        .MeterPerSquareRontosecond
                                                                              , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                               );

   /// <summary>
   /// inch per square quadrillion years, defined as: SI centimeter per square trillion years × (2.54)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareQuadrillionYears = new (
                                                                            "inch per square quadrillion years"
                                                                          , "in/Pyr²"
                                                                          , SI.Accelerations
                                                                              .CentimeterPerSquareTrillionYears
                                                                          , 2.54 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// inch per square quintillion years, defined as: SI centimeter per square quadrillion years × (2.54)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareQuintillionYears = new (
                                                                            "inch per square quintillion years"
                                                                          , "in/Eyr²"
                                                                          , SI.Accelerations
                                                                              .CentimeterPerSquareQuadrillionYears
                                                                          , 2.54 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// inch per square sextillion years, defined as: SI centimeter per square quintillion years × (2.54)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareSextillionYears = new (
                                                                           "inch per square sextillion years"
                                                                         , "in/Zyr²"
                                                                         , SI.Accelerations
                                                                             .CentimeterPerSquareQuintillionYears
                                                                         , 2.54 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// inch per square septillion years, defined as: SI centimeter per square sextillion years × (2.54)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareSeptillionYears = new (
                                                                           "inch per square septillion years"
                                                                         , "in/Yyr²"
                                                                         , SI.Accelerations
                                                                             .CentimeterPerSquareSextillionYears
                                                                         , 2.54 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// inch per square octillion years, defined as: SI centimeter per square septillion years × (2.54)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareOctillionYears = new (
                                                                          "inch per square octillion years"
                                                                        , "in/Ryr²"
                                                                        , SI.Accelerations
                                                                            .CentimeterPerSquareSeptillionYears
                                                                        , 2.54 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// inch per square nonillion years, defined as: SI centimeter per square octillion years × (2.54)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareNonillionYears = new (
                                                                          "inch per square nonillion years"
                                                                        , "in/Qyr²"
                                                                        , SI.Accelerations
                                                                            .CentimeterPerSquareOctillionYears
                                                                        , 2.54 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// inch per square decillion years, defined as: SI centimeter per square nonillion years × (2.54)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareDecillionYears = new (
                                                                          "inch per square decillion years"
                                                                        , "in/decillion yr²"
                                                                        , SI.Accelerations
                                                                            .CentimeterPerSquareNonillionYears
                                                                        , 2.54 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// inch per square tick, defined as: SI centimeter per square nanosecond × (2.54)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration InchPerSquareTick = new (
                                                                "inch per square tick"
                                                              , "in/tick²"
                                                              , SI.Accelerations.CentimeterPerSquareNanosecond
                                                              , 2.54 / (100.0 * 100.0)
                                                               );

   /// <summary>
   /// mil per square minute, defined as: inch per square second × (1.0/1000.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareMinute = new (
                                                                 "mil per square minute"
                                                               , "mil/min²"
                                                               , InchPerSquareSecond
                                                               , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                );

   /// <summary>
   /// foot per square septillion years, defined as: inch per square sextillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareSeptillionYears = new (
                                                                           "foot per square septillion years"
                                                                         , "ft/Yyr²"
                                                                         , InchPerSquareSextillionYears
                                                                         , 12.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// foot per square week, defined as: inch per square day × (12.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareWeek = new (
                                                                "foot per square week"
                                                              , "ft/wk²"
                                                              , InchPerSquareDay
                                                              , 12.0 / (7.0 * 7.0)
                                                               );

   /// <summary>
   /// point per square billion years, defined as: inch per square million years × (1.0/72.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareBillionYears = new (
                                                                         "point per square billion years"
                                                                       , "p/Gyr²"
                                                                       , InchPerSquareMillionYears
                                                                       , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// mil per square tick, defined as: inch per square nanosecond × (1.0/1000.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareTick = new (
                                                               "mil per square tick"
                                                             , "mil/tick²"
                                                             , InchPerSquareNanosecond
                                                             , 1.0 / 1000.0 / (100.0 * 100.0)
                                                              );

   /// <summary>
   /// mil per square hour, defined as: inch per square minute × (1.0/1000.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareHour = new (
                                                               "mil per square hour"
                                                             , "mil/hr²"
                                                             , InchPerSquareMinute
                                                             , 1.0 / 1000.0 / (60.0 * 60.0)
                                                              );

   /// <summary>
   /// point per square minute, defined as: inch per square second × (1.0/72.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareMinute = new (
                                                                   "point per square minute"
                                                                 , "p/min²"
                                                                 , InchPerSquareSecond
                                                                 , 1.0 / 72.0 / (60.0 * 60.0)
                                                                  );

   /// <summary>
   /// nautical mile per square nonillion years, defined as: SI meter per square octillion years × (1852.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareNonillionYears = new (
       "nautical mile per square nonillion years"
     , "nmi/Qyr²"
     , SI.Accelerations.MeterPerSquareOctillionYears
     , 1852.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// nautical mile per square quadrillion years, defined as: SI meter per square trillion years × (1852.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuadrillionYears = new (
       "nautical mile per square quadrillion years"
     , "nmi/Pyr²"
     , SI.Accelerations.MeterPerSquareTrillionYears
     , 1852.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// mil per square day, defined as: inch per square hour × (1.0/1000.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareDay = new (
                                                              "mil per square day"
                                                            , "mil/dy²"
                                                            , InchPerSquareHour
                                                            , 1.0 / 1000.0 / (24.0 * 24.0)
                                                             );

   /// <summary>
   /// twip per square minute, defined as: point per square second × (1.0/20.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareMinute = new (
                                                                  "twip per square minute"
                                                                , "twip/min²"
                                                                , PointPerSquareSecond
                                                                , 1.0 / 20.0 / (60.0 * 60.0)
                                                                 );

   /// <summary>
   /// foot per square millennium, defined as: inch per square century × (12.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareMillennium =
            new ("foot per square millennium", "ft/kyr²", InchPerSquareCentury, 12.0 / (10.0 * 10.0));

   /// <summary>
   /// point per square tick, defined as: inch per square nanosecond × (1.0/72.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareTick = new (
                                                                 "point per square tick"
                                                               , "p/tick²"
                                                               , InchPerSquareNanosecond
                                                               , 1.0 / 72.0 / (100.0 * 100.0)
                                                                );

   /// <summary>
   /// nautical mile per square century, defined as: SI meter per square decade × (1852.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareCentury = new (
                                                                           "nautical mile per square century"
                                                                         , "nmi/century²"
                                                                         , SI.Accelerations.MeterPerSquareDecade
                                                                         , 1852.0 / (10.0 * 10.0)
                                                                          );

   /// <summary>
   /// point per square trillion years, defined as: inch per square billion years × (1.0/72.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareTrillionYears = new (
                                                                          "point per square trillion years"
                                                                        , "p/Tyr²"
                                                                        , InchPerSquareBillionYears
                                                                        , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// nautical mile per square hour, defined as: SI meter per square minute × (1852.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareHour = new (
                                                                        "nautical mile per square hour"
                                                                      , "nmi/hr²"
                                                                      , SI.Accelerations.MeterPerSquareMinute
                                                                      , 1852.0 / (60.0 * 60.0)
                                                                       );

   /// <summary>
   /// yard per square octillion years, defined as: foot per square septillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareOctillionYears = new (
                                                                          "yard per square octillion years"
                                                                        , "yd/Ryr²"
                                                                        , FootPerSquareSeptillionYears
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// point per square hour, defined as: inch per square minute × (1.0/72.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareHour = new (
                                                                 "point per square hour"
                                                               , "p/hr²"
                                                               , InchPerSquareMinute
                                                               , 1.0 / 72.0 / (60.0 * 60.0)
                                                                );

   /// <summary>
   /// mil per square week, defined as: inch per square day × (1.0/1000.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareWeek = new (
                                                               "mil per square week"
                                                             , "mil/wk²"
                                                             , InchPerSquareDay
                                                             , 1.0 / 1000.0 / (7.0 * 7.0)
                                                              );

   /// <summary>
   /// pica per square minute, defined as: point per square second × (12.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareMinute =
            new ("pica per square minute", "P/min²", PointPerSquareSecond, 12.0 / (60.0 * 60.0));

   /// <summary>
   /// foot per square quadrillion years, defined as: inch per square trillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareQuadrillionYears = new (
                                                                            "foot per square quadrillion years"
                                                                          , "ft/Pyr²"
                                                                          , InchPerSquareTrillionYears
                                                                          , 12.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// twip per square tick, defined as: point per square nanosecond × (1.0/20.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareTick = new (
                                                                "twip per square tick"
                                                              , "twip/tick²"
                                                              , PointPerSquareNanosecond
                                                              , 1.0 / 20.0 / (100.0 * 100.0)
                                                               );

   /// <summary>
   /// mil per square year, defined as: inch per square day × (1.0/1000.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration MilPerSquareYear = new (
                                                               "mil per square year"
                                                             , "mil/yr²"
                                                             , InchPerSquareDay
                                                             , 1.0 / 1000.0 / (365.2525 * 365.2525)
                                                              );

   /// <summary>
   /// foot per square minute, defined as: inch per square second × (12.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareMinute =
            new ("foot per square minute", "ft/min²", InchPerSquareSecond, 12.0 / (60.0 * 60.0));

   /// <summary>
   /// fathom per square nonillion years, defined as: yard per square octillion years × (2.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareNonillionYears = new (
                                                                            "fathom per square nonillion years"
                                                                          , "ftm/Qyr²"
                                                                          , YardPerSquareOctillionYears
                                                                          , 2.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// point per square quadrillion years, defined as: inch per square trillion years × (1.0/72.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareQuadrillionYears = new (
                                                                             "point per square quadrillion years"
                                                                           , "p/Pyr²"
                                                                           , InchPerSquareTrillionYears
                                                                           , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// point per square day, defined as: inch per square hour × (1.0/72.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareDay = new (
                                                                "point per square day"
                                                              , "p/dy²"
                                                              , InchPerSquareHour
                                                              , 1.0 / 72.0 / (24.0 * 24.0)
                                                               );

   /// <summary>
   /// twip per square hour, defined as: point per square minute × (1.0/20.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareHour = new (
                                                                "twip per square hour"
                                                              , "twip/hr²"
                                                              , PointPerSquareMinute
                                                              , 1.0 / 20.0 / (60.0 * 60.0)
                                                               );

   /// <summary>
   /// mil per square decade, defined as: inch per square year × (1.0/1000.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareDecade = new (
                                                                 "mil per square decade"
                                                               , "mil/decade²"
                                                               , InchPerSquareYear
                                                               , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                );

   /// <summary>
   /// yard per square minute, defined as: foot per square second × (3.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareMinute =
            new ("yard per square minute", "yd/min²", FootPerSquareSecond, 3.0 / (60.0 * 60.0));

   /// <summary>
   /// foot per square octillion years, defined as: inch per square septillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareOctillionYears = new (
                                                                          "foot per square octillion years"
                                                                        , "ft/Ryr²"
                                                                        , InchPerSquareSeptillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// pica per square tick, defined as: point per square nanosecond × (12.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareTick = new (
                                                                "pica per square tick"
                                                              , "P/tick²"
                                                              , PointPerSquareNanosecond
                                                              , 12.0 / (100.0 * 100.0)
                                                               );

   /// <summary>
   /// nautical mile per square sextillion years, defined as: SI meter per square quintillion years × (1852.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSextillionYears = new (
       "nautical mile per square sextillion years"
     , "nmi/Zyr²"
     , SI.Accelerations.MeterPerSquareQuintillionYears
     , 1852.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// foot per square year, defined as: inch per square day × (12.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration FootPerSquareYear = new (
                                                                "foot per square year"
                                                              , "ft/yr²"
                                                              , InchPerSquareDay
                                                              , 12.0 / (365.2525 * 365.2525)
                                                               );

   /// <summary>
   /// nautical mile per square million years, defined as: SI meter per square millennium × (1852.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillionYears = new (
                                                                                "nautical mile per square million years"
                                                                              , "nmi/Myr²"
                                                                              , SI.Accelerations
                                                                                        .MeterPerSquareMillennium
                                                                              , 1852.0 / (1000.0 * 1000.0)
                                                                               );

   /// <summary>
   /// mil per square century, defined as: inch per square decade × (1.0/1000.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareCentury = new (
                                                                  "mil per square century"
                                                                , "mil/century²"
                                                                , InchPerSquareDecade
                                                                , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                 );

   /// <summary>
   /// mile per square minute, defined as: yard per square second × (1760.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareMinute =
            new ("mile per square minute", "mi/min²", YardPerSquareSecond, 1760.0 / (60.0 * 60.0));

   /// <summary>
   /// pica per square trillion years, defined as: point per square billion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareTrillionYears = new (
                                                                         "pica per square trillion years"
                                                                       , "P/Tyr²"
                                                                       , PointPerSquareBillionYears
                                                                       , 12.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// nautical mile per square week, defined as: SI meter per square day × (1852.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareWeek = new (
                                                                        "nautical mile per square week"
                                                                      , "nmi/wk²"
                                                                      , SI.Accelerations.MeterPerSquareDay
                                                                      , 1852.0 / (7.0 * 7.0)
                                                                       );

   /// <summary>
   /// point per square quintillion years, defined as: inch per square quadrillion years × (1.0/72.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareQuintillionYears = new (
                                                                             "point per square quintillion years"
                                                                           , "p/Eyr²"
                                                                           , InchPerSquareQuadrillionYears
                                                                           , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// foot per square tick, defined as: inch per square nanosecond × (12.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareTick = new (
                                                                "foot per square tick"
                                                              , "ft/tick²"
                                                              , InchPerSquareNanosecond
                                                              , 12.0 / (100.0 * 100.0)
                                                               );

   /// <summary>
   /// point per square week, defined as: inch per square day × (1.0/72.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareWeek =
            new ("point per square week", "p/wk²", InchPerSquareDay, 1.0 / 72.0 / (7.0 * 7.0));

   /// <summary>
   /// pica per square hour, defined as: point per square minute × (12.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareHour = new (
                                                                "pica per square hour"
                                                              , "P/hr²"
                                                              , PointPerSquareMinute
                                                              , 12.0 / (60.0 * 60.0)
                                                               );

   /// <summary>
   /// mil per square millennium, defined as: inch per square century × (1.0/1000.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareMillennium = new (
                                                                     "mil per square millennium"
                                                                   , "mil/kyr²"
                                                                   , InchPerSquareCentury
                                                                   , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                    );

   /// <summary>
   /// league per square minute, defined as: mile per square second × (3.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMinute =
            new ("league per square minute", "le/min²", MilePerSquareSecond, 3.0 / (60.0 * 60.0));

   /// <summary>
   /// foot per square million years, defined as: inch per square millennium × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareMillionYears = new (
                                                                        "foot per square million years"
                                                                      , "ft/Myr²"
                                                                      , InchPerSquareMillennium
                                                                      , 12.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// mile per square nonillion years, defined as: yard per square octillion years × (1760.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareNonillionYears = new (
                                                                          "mile per square nonillion years"
                                                                        , "mi/Qyr²"
                                                                        , YardPerSquareOctillionYears
                                                                        , 1760.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// twip per square day, defined as: point per square hour × (1.0/20.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareDay = new (
                                                               "twip per square day"
                                                             , "twip/dy²"
                                                             , PointPerSquareHour
                                                             , 1.0 / 20.0 / (24.0 * 24.0)
                                                              );

   /// <summary>
   /// mil per square million years, defined as: inch per square millennium × (1.0/1000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareMillionYears = new (
                                                                       "mil per square million years"
                                                                     , "mil/Myr²"
                                                                     , InchPerSquareMillennium
                                                                     , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                      );

   /// <summary>
   /// fathom per square minute, defined as: yard per square second × (2.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareMinute =
            new ("fathom per square minute", "ftm/min²", YardPerSquareSecond, 2.0 / (60.0 * 60.0));

   /// <summary>
   /// yard per square tick, defined as: foot per square nanosecond × (3.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareTick = new (
                                                                "yard per square tick"
                                                              , "yd/tick²"
                                                              , FootPerSquareNanosecond
                                                              , 3.0 / (100.0 * 100.0)
                                                               );

   /// <summary>
   /// point per square sextillion years, defined as: inch per square quintillion years × (1.0/72.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareSextillionYears = new (
                                                                            "point per square sextillion years"
                                                                          , "p/Zyr²"
                                                                          , InchPerSquareQuintillionYears
                                                                          , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// foot per square quintillion years, defined as: inch per square quadrillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareQuintillionYears = new (
                                                                            "foot per square quintillion years"
                                                                          , "ft/Eyr²"
                                                                          , InchPerSquareQuadrillionYears
                                                                          , 12.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// yard per square nonillion years, defined as: foot per square octillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareNonillionYears = new (
                                                                          "yard per square nonillion years"
                                                                        , "yd/Qyr²"
                                                                        , FootPerSquareOctillionYears
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// point per square year, defined as: inch per square day × (1.0/72.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration PointPerSquareYear = new (
                                                                 "point per square year"
                                                               , "p/yr²"
                                                               , InchPerSquareDay
                                                               , 1.0 / 72.0 / (365.2525 * 365.2525)
                                                                );

   /// <summary>
   /// foot per square hour, defined as: inch per square minute × (12.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareHour = new (
                                                                "foot per square hour"
                                                              , "ft/hr²"
                                                              , InchPerSquareMinute
                                                              , 12.0 / (60.0 * 60.0)
                                                               );

   /// <summary>
   /// mil per square billion years, defined as: inch per square million years × (1.0/1000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareBillionYears = new (
                                                                       "mil per square billion years"
                                                                     , "mil/Gyr²"
                                                                     , InchPerSquareMillionYears
                                                                     , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                      );

   /// <summary>
   /// cable per square minute, defined as: fathom per square second × (120.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareMinute = new (
                                                                   "cable per square minute"
                                                                 , "cb/min²"
                                                                 , FathomPerSquareSecond
                                                                 , 120.0 / (60.0 * 60.0)
                                                                  );

   /// <summary>
   /// yard per square sextillion years, defined as: foot per square quintillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareSextillionYears = new (
                                                                           "yard per square sextillion years"
                                                                         , "yd/Zyr²"
                                                                         , FootPerSquareQuintillionYears
                                                                         , 3.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// mile per square tick, defined as: yard per square nanosecond × (1760.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareTick = new (
                                                                "mile per square tick"
                                                              , "mi/tick²"
                                                              , YardPerSquareNanosecond
                                                              , 1760.0 / (100.0 * 100.0)
                                                               );

   /// <summary>
   /// mil per square trillion years, defined as: inch per square billion years × (1.0/1000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareTrillionYears = new (
                                                                        "mil per square trillion years"
                                                                      , "mil/Tyr²"
                                                                      , InchPerSquareBillionYears
                                                                      , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// pica per square quadrillion years, defined as: point per square trillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareQuadrillionYears = new (
                                                                            "pica per square quadrillion years"
                                                                          , "P/Pyr²"
                                                                          , PointPerSquareTrillionYears
                                                                          , 12.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// foot per square nonillion years, defined as: inch per square octillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareNonillionYears = new (
                                                                          "foot per square nonillion years"
                                                                        , "ft/Qyr²"
                                                                        , InchPerSquareOctillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// foot per square decade, defined as: inch per square year × (12.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareDecade =
            new ("foot per square decade", "ft/decade²", InchPerSquareYear, 12.0 / (10.0 * 10.0));

   /// <summary>
   /// point per square septillion years, defined as: inch per square sextillion years × (1.0/72.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareSeptillionYears = new (
                                                                            "point per square septillion years"
                                                                          , "p/Yyr²"
                                                                          , InchPerSquareSextillionYears
                                                                          , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// twip per square week, defined as: point per square day × (1.0/20.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareWeek = new (
                                                                "twip per square week"
                                                              , "twip/wk²"
                                                              , PointPerSquareDay
                                                              , 1.0 / 20.0 / (7.0 * 7.0)
                                                               );

   /// <summary>
   /// pica per square day, defined as: point per square hour × (12.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareDay = new (
                                                               "pica per square day"
                                                             , "P/dy²"
                                                             , PointPerSquareHour
                                                             , 12.0 / (24.0 * 24.0)
                                                              );

   /// <summary>
   /// point per square decade, defined as: inch per square year × (1.0/72.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareDecade = new (
                                                                   "point per square decade"
                                                                 , "p/decade²"
                                                                 , InchPerSquareYear
                                                                 , 1.0 / 72.0 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// yard per square hour, defined as: foot per square minute × (3.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareHour = new (
                                                                "yard per square hour"
                                                              , "yd/hr²"
                                                              , FootPerSquareMinute
                                                              , 3.0 / (60.0 * 60.0)
                                                               );

   /// <summary>
   /// mil per square quadrillion years, defined as: inch per square trillion years × (1.0/1000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareQuadrillionYears = new (
                                                                           "mil per square quadrillion years"
                                                                         , "mil/Pyr²"
                                                                         , InchPerSquareTrillionYears
                                                                         , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// league per square tick, defined as: mile per square nanosecond × (3.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTick = new (
                                                                  "league per square tick"
                                                                , "le/tick²"
                                                                , MilePerSquareNanosecond
                                                                , 3.0 / (100.0 * 100.0)
                                                                 );

   /// <summary>
   /// mile per square septillion years, defined as: yard per square sextillion years × (1760.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareSeptillionYears = new (
                                                                           "mile per square septillion years"
                                                                         , "mi/Yyr²"
                                                                         , YardPerSquareSextillionYears
                                                                         , 1760.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// mil per square quintillion years, defined as: inch per square quadrillion years × (1.0/1000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareQuintillionYears = new (
                                                                           "mil per square quintillion years"
                                                                         , "mil/Eyr²"
                                                                         , InchPerSquareQuadrillionYears
                                                                         , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// foot per square billion years, defined as: inch per square million years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareBillionYears = new (
                                                                        "foot per square billion years"
                                                                      , "ft/Gyr²"
                                                                      , InchPerSquareMillionYears
                                                                      , 12.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// point per square octillion years, defined as: inch per square septillion years × (1.0/72.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareOctillionYears = new (
                                                                           "point per square octillion years"
                                                                         , "p/Ryr²"
                                                                         , InchPerSquareSeptillionYears
                                                                         , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// cable per square decillion years, defined as: fathom per square nonillion years × (120.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareDecillionYears = new (
                                                                           "cable per square decillion years"
                                                                         , "cb/decillion yr²"
                                                                         , FathomPerSquareNonillionYears
                                                                         , 120.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// fathom per square tick, defined as: yard per square nanosecond × (2.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareTick = new (
                                                                  "fathom per square tick"
                                                                , "ftm/tick²"
                                                                , YardPerSquareNanosecond
                                                                , 2.0 / (100.0 * 100.0)
                                                                 );

   /// <summary>
   /// point per square century, defined as: inch per square decade × (1.0/72.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareCentury = new (
                                                                    "point per square century"
                                                                  , "p/century²"
                                                                  , InchPerSquareDecade
                                                                  , 1.0 / 72.0 / (10.0 * 10.0)
                                                                   );

   /// <summary>
   /// mile per square hour, defined as: yard per square minute × (1760.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareHour = new (
                                                                "mile per square hour"
                                                              , "mi/hr²"
                                                              , YardPerSquareMinute
                                                              , 1760.0 / (60.0 * 60.0)
                                                               );

   /// <summary>
   /// mil per square sextillion years, defined as: inch per square quintillion years × (1.0/1000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareSextillionYears = new (
                                                                          "mil per square sextillion years"
                                                                        , "mil/Zyr²"
                                                                        , InchPerSquareQuintillionYears
                                                                        , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// twip per square nonillion years, defined as: point per square octillion years × (1.0/20.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareNonillionYears = new (
                                                                          "twip per square nonillion years"
                                                                        , "twip/Qyr²"
                                                                        , PointPerSquareOctillionYears
                                                                        , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// fathom per square decillion years, defined as: yard per square nonillion years × (2.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecillionYears = new (
                                                                            "fathom per square decillion years"
                                                                          , "ftm/decillion yr²"
                                                                          , YardPerSquareNonillionYears
                                                                          , 2.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// twip per square trillion years, defined as: point per square billion years × (1.0/20.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareTrillionYears = new (
                                                                         "twip per square trillion years"
                                                                       , "twip/Tyr²"
                                                                       , PointPerSquareBillionYears
                                                                       , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// foot per square sextillion years, defined as: inch per square quintillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareSextillionYears = new (
                                                                           "foot per square sextillion years"
                                                                         , "ft/Zyr²"
                                                                         , InchPerSquareQuintillionYears
                                                                         , 12.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// league per square decillion years, defined as: mile per square nonillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecillionYears = new (
                                                                            "league per square decillion years"
                                                                          , "le/decillion yr²"
                                                                          , MilePerSquareNonillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// twip per square year, defined as: point per square day × (1.0/20.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration TwipPerSquareYear = new (
                                                                "twip per square year"
                                                              , "twip/yr²"
                                                              , PointPerSquareDay
                                                              , 1.0 / 20.0 / (365.2525 * 365.2525)
                                                               );

   /// <summary>
   /// foot per square day, defined as: inch per square hour × (12.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareDay = new (
                                                               "foot per square day"
                                                             , "ft/dy²"
                                                             , InchPerSquareHour
                                                             , 12.0 / (24.0 * 24.0)
                                                              );

   /// <summary>
   /// mil per square septillion years, defined as: inch per square sextillion years × (1.0/1000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareSeptillionYears = new (
                                                                          "mil per square septillion years"
                                                                        , "mil/Yyr²"
                                                                        , InchPerSquareSextillionYears
                                                                        , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// pica per square quintillion years, defined as: point per square quadrillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareQuintillionYears = new (
                                                                            "pica per square quintillion years"
                                                                          , "P/Eyr²"
                                                                          , PointPerSquareQuadrillionYears
                                                                          , 12.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// mile per square decillion years, defined as: yard per square nonillion years × (1760.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareDecillionYears = new (
                                                                          "mile per square decillion years"
                                                                        , "mi/decillion yr²"
                                                                        , YardPerSquareNonillionYears
                                                                        , 1760.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// cable per square tick, defined as: fathom per square nanosecond × (120.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareTick = new (
                                                                 "cable per square tick"
                                                               , "cb/tick²"
                                                               , FathomPerSquareNanosecond
                                                               , 120.0 / (100.0 * 100.0)
                                                                );

   /// <summary>
   /// point per square nonillion years, defined as: inch per square octillion years × (1.0/72.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareNonillionYears = new (
                                                                           "point per square nonillion years"
                                                                         , "p/Qyr²"
                                                                         , InchPerSquareOctillionYears
                                                                         , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// yard per square decillion years, defined as: foot per square nonillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareDecillionYears = new (
                                                                          "yard per square decillion years"
                                                                        , "yd/decillion yr²"
                                                                        , FootPerSquareNonillionYears
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// pica per square week, defined as: point per square day × (12.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareWeek = new (
                                                                "pica per square week"
                                                              , "P/wk²"
                                                              , PointPerSquareDay
                                                              , 12.0 / (7.0 * 7.0)
                                                               );

   /// <summary>
   /// point per square millennium, defined as: inch per square century × (1.0/72.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareMillennium = new (
                                                                       "point per square millennium"
                                                                     , "p/kyr²"
                                                                     , InchPerSquareCentury
                                                                     , 1.0 / 72.0 / (10.0 * 10.0)
                                                                      );

   /// <summary>
   /// league per square hour, defined as: mile per square minute × (3.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareHour =
            new ("league per square hour", "le/hr²", MilePerSquareMinute, 3.0 / (60.0 * 60.0));

   /// <summary>
   /// mil per square octillion years, defined as: inch per square septillion years × (1.0/1000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareOctillionYears = new (
                                                                         "mil per square octillion years"
                                                                       , "mil/Ryr²"
                                                                       , InchPerSquareSeptillionYears
                                                                       , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// yard per square septillion years, defined as: foot per square sextillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareSeptillionYears = new (
                                                                           "yard per square septillion years"
                                                                         , "yd/Yyr²"
                                                                         , FootPerSquareSextillionYears
                                                                         , 3.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// foot per square decillion years, defined as: inch per square nonillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareDecillionYears = new (
                                                                          "foot per square decillion years"
                                                                        , "ft/decillion yr²"
                                                                        , InchPerSquareNonillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// foot per square century, defined as: inch per square decade × (12.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareCentury = new (
                                                                   "foot per square century"
                                                                 , "ft/century²"
                                                                 , InchPerSquareDecade
                                                                 , 12.0 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// pica per square decillion years, defined as: point per square nonillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareDecillionYears = new (
                                                                          "pica per square decillion years"
                                                                        , "P/decillion yr²"
                                                                        , PointPerSquareNonillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// mil per square nonillion years, defined as: inch per square octillion years × (1.0/1000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareNonillionYears = new (
                                                                         "mil per square nonillion years"
                                                                       , "mil/Qyr²"
                                                                       , InchPerSquareOctillionYears
                                                                       , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// yard per square million years, defined as: foot per square millennium × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareMillionYears = new (
                                                                        "yard per square million years"
                                                                      , "yd/Myr²"
                                                                      , FootPerSquareMillennium
                                                                      , 3.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// twip per square decillion years, defined as: point per square nonillion years × (1.0/20.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecillionYears = new (
                                                                          "twip per square decillion years"
                                                                        , "twip/decillion yr²"
                                                                        , PointPerSquareNonillionYears
                                                                        , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// league per square octillion years, defined as: mile per square septillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareOctillionYears = new (
                                                                            "league per square octillion years"
                                                                          , "le/Ryr²"
                                                                          , MilePerSquareSeptillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// yard per square decade, defined as: foot per square year × (3.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareDecade =
            new ("yard per square decade", "yd/decade²", FootPerSquareYear, 3.0 / (10.0 * 10.0));

   /// <summary>
   /// pica per square million years, defined as: point per square millennium × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareMillionYears = new (
                                                                        "pica per square million years"
                                                                      , "P/Myr²"
                                                                      , PointPerSquareMillennium
                                                                      , 12.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// twip per square quadrillion years, defined as: point per square trillion years × (1.0/20.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuadrillionYears = new (
                                                                            "twip per square quadrillion years"
                                                                          , "twip/Pyr²"
                                                                          , PointPerSquareTrillionYears
                                                                          , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// point per square decillion years, defined as: inch per square nonillion years × (1.0/72.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareDecillionYears = new (
                                                                           "point per square decillion years"
                                                                         , "p/decillion yr²"
                                                                         , InchPerSquareNonillionYears
                                                                         , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// twip per square decade, defined as: point per square year × (1.0/20.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecade = new (
                                                                  "twip per square decade"
                                                                , "twip/decade²"
                                                                , PointPerSquareYear
                                                                , 1.0 / 20.0 / (10.0 * 10.0)
                                                                 );

   /// <summary>
   /// yard per square day, defined as: foot per square hour × (3.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareDay = new (
                                                               "yard per square day"
                                                             , "yd/dy²"
                                                             , FootPerSquareHour
                                                             , 3.0 / (24.0 * 24.0)
                                                              );

   /// <summary>
   /// point per square million years, defined as: inch per square millennium × (1.0/72.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PointPerSquareMillionYears = new (
                                                                         "point per square million years"
                                                                       , "p/Myr²"
                                                                       , InchPerSquareMillennium
                                                                       , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// fathom per square hour, defined as: yard per square minute × (2.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareHour =
            new ("fathom per square hour", "ftm/hr²", YardPerSquareMinute, 2.0 / (60.0 * 60.0));

   /// <summary>
   /// mil per square decillion years, defined as: inch per square nonillion years × (1.0/1000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilPerSquareDecillionYears = new (
                                                                         "mil per square decillion years"
                                                                       , "mil/decillion yr²"
                                                                       , InchPerSquareNonillionYears
                                                                       , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// foot per square trillion years, defined as: inch per square billion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareTrillionYears = new (
                                                                         "foot per square trillion years"
                                                                       , "ft/Tyr²"
                                                                       , InchPerSquareBillionYears
                                                                       , 12.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// pica per square sextillion years, defined as: point per square quintillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareSextillionYears = new (
                                                                           "pica per square sextillion years"
                                                                         , "P/Zyr²"
                                                                         , PointPerSquareQuintillionYears
                                                                         , 12.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// mile per square octillion years, defined as: yard per square septillion years × (1760.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareOctillionYears = new (
                                                                          "mile per square octillion years"
                                                                        , "mi/Ryr²"
                                                                        , YardPerSquareSeptillionYears
                                                                        , 1760.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// pica per square year, defined as: point per square day × (12.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration PicaPerSquareYear = new (
                                                                "pica per square year"
                                                              , "P/yr²"
                                                              , PointPerSquareDay
                                                              , 12.0 / (365.2525 * 365.2525)
                                                               );

   /// <summary>
   /// cable per square hour, defined as: fathom per square minute × (120.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareHour =
            new ("cable per square hour", "cb/hr²", FathomPerSquareMinute, 120.0 / (60.0 * 60.0));

   /// <summary>
   /// twip per square quintillion years, defined as: point per square quadrillion years × (1.0/20.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuintillionYears = new (
                                                                            "twip per square quintillion years"
                                                                          , "twip/Eyr²"
                                                                          , PointPerSquareQuadrillionYears
                                                                          , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// twip per square century, defined as: point per square decade × (1.0/20.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareCentury = new (
                                                                   "twip per square century"
                                                                 , "twip/century²"
                                                                 , PointPerSquareDecade
                                                                 , 1.0 / 20.0 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// mile per square day, defined as: yard per square hour × (1760.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareDay = new (
                                                               "mile per square day"
                                                             , "mi/dy²"
                                                             , YardPerSquareHour
                                                             , 1760.0 / (24.0 * 24.0)
                                                              );

   /// <summary>
   /// league per square year, defined as: mile per square day × (3.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYear = new (
                                                                  "league per square year"
                                                                , "le/yr²"
                                                                , MilePerSquareDay
                                                                , 3.0 / (365.2525 * 365.2525)
                                                                 );

   /// <summary>
   /// pica per square billion years, defined as: point per square million years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareBillionYears = new (
                                                                        "pica per square billion years"
                                                                      , "P/Gyr²"
                                                                      , PointPerSquareMillionYears
                                                                      , 12.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// yard per square quintillion years, defined as: foot per square quadrillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareQuintillionYears = new (
                                                                            "yard per square quintillion years"
                                                                          , "yd/Eyr²"
                                                                          , FootPerSquareQuadrillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// yard per square billion years, defined as: foot per square million years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareBillionYears = new (
                                                                        "yard per square billion years"
                                                                      , "yd/Gyr²"
                                                                      , FootPerSquareMillionYears
                                                                      , 3.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// pica per square septillion years, defined as: point per square sextillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareSeptillionYears = new (
                                                                           "pica per square septillion years"
                                                                         , "P/Yyr²"
                                                                         , PointPerSquareSextillionYears
                                                                         , 12.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// yard per square century, defined as: foot per square decade × (3.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareCentury = new (
                                                                   "yard per square century"
                                                                 , "yd/century²"
                                                                 , FootPerSquareDecade
                                                                 , 3.0 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// twip per square sextillion years, defined as: point per square quintillion years × (1.0/20.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareSextillionYears = new (
                                                                           "twip per square sextillion years"
                                                                         , "twip/Zyr²"
                                                                         , PointPerSquareQuintillionYears
                                                                         , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// pica per square decade, defined as: point per square year × (12.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareDecade =
            new ("pica per square decade", "P/decade²", PointPerSquareYear, 12.0 / (10.0 * 10.0));

   /// <summary>
   /// yard per square week, defined as: foot per square day × (3.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareWeek = new (
                                                                "yard per square week"
                                                              , "yd/wk²"
                                                              , FootPerSquareDay
                                                              , 3.0 / (7.0 * 7.0)
                                                               );

   /// <summary>
   /// twip per square millennium, defined as: point per square century × (1.0/20.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillennium = new (
                                                                      "twip per square millennium"
                                                                    , "twip/kyr²"
                                                                    , PointPerSquareCentury
                                                                    , 1.0 / 20.0 / (10.0 * 10.0)
                                                                     );

   /// <summary>
   /// league per square day, defined as: mile per square hour × (3.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDay =
            new ("league per square day", "le/dy²", MilePerSquareHour, 3.0 / (24.0 * 24.0));

   /// <summary>
   /// mile per square sextillion years, defined as: yard per square quintillion years × (1760.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareSextillionYears = new (
                                                                           "mile per square sextillion years"
                                                                         , "mi/Zyr²"
                                                                         , YardPerSquareQuintillionYears
                                                                         , 1760.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// fathom per square septillion years, defined as: yard per square sextillion years × (2.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareSeptillionYears = new (
                                                                             "fathom per square septillion years"
                                                                           , "ftm/Yyr²"
                                                                           , YardPerSquareSextillionYears
                                                                           , 2.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// fathom per square trillion years, defined as: yard per square billion years × (2.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareTrillionYears = new (
                                                                           "fathom per square trillion years"
                                                                         , "ftm/Tyr²"
                                                                         , YardPerSquareBillionYears
                                                                         , 2.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// league per square nonillion years, defined as: mile per square octillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNonillionYears = new (
                                                                            "league per square nonillion years"
                                                                          , "le/Qyr²"
                                                                          , MilePerSquareOctillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// fathom per square century, defined as: yard per square decade × (2.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareCentury = new (
                                                                     "fathom per square century"
                                                                   , "ftm/century²"
                                                                   , YardPerSquareDecade
                                                                   , 2.0 / (10.0 * 10.0)
                                                                    );

   /// <summary>
   /// fathom per square year, defined as: yard per square day × (2.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration FathomPerSquareYear = new (
                                                                  "fathom per square year"
                                                                , "ftm/yr²"
                                                                , YardPerSquareDay
                                                                , 2.0 / (365.2525 * 365.2525)
                                                                 );

   /// <summary>
   /// twip per square septillion years, defined as: point per square sextillion years × (1.0/20.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareSeptillionYears = new (
                                                                           "twip per square septillion years"
                                                                         , "twip/Yyr²"
                                                                         , PointPerSquareSextillionYears
                                                                         , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// twip per square million years, defined as: point per square millennium × (1.0/20.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillionYears = new (
                                                                        "twip per square million years"
                                                                      , "twip/Myr²"
                                                                      , PointPerSquareMillennium
                                                                      , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// fathom per square day, defined as: yard per square hour × (2.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareDay =
            new ("fathom per square day", "ftm/dy²", YardPerSquareHour, 2.0 / (24.0 * 24.0));

   /// <summary>
   /// pica per square octillion years, defined as: point per square septillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareOctillionYears = new (
                                                                          "pica per square octillion years"
                                                                        , "P/Ryr²"
                                                                        , PointPerSquareSeptillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// cable per square quadrillion years, defined as: fathom per square trillion years × (120.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareQuadrillionYears = new (
                                                                             "cable per square quadrillion years"
                                                                           , "cb/Pyr²"
                                                                           , FathomPerSquareTrillionYears
                                                                           , 120.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// league per square septillion years, defined as: mile per square sextillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSeptillionYears = new (
                                                                             "league per square septillion years"
                                                                           , "le/Yyr²"
                                                                           , MilePerSquareSextillionYears
                                                                           , 3.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// pica per square century, defined as: point per square decade × (12.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareCentury = new (
                                                                   "pica per square century"
                                                                 , "P/century²"
                                                                 , PointPerSquareDecade
                                                                 , 12.0 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// mile per square week, defined as: yard per square day × (1760.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareWeek = new (
                                                                "mile per square week"
                                                              , "mi/wk²"
                                                              , YardPerSquareDay
                                                              , 1760.0 / (7.0 * 7.0)
                                                               );

   /// <summary>
   /// yard per square trillion years, defined as: foot per square billion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareTrillionYears = new (
                                                                         "yard per square trillion years"
                                                                       , "yd/Tyr²"
                                                                       , FootPerSquareBillionYears
                                                                       , 3.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// yard per square millennium, defined as: foot per square century × (3.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareMillennium =
            new ("yard per square millennium", "yd/kyr²", FootPerSquareCentury, 3.0 / (10.0 * 10.0));

   /// <summary>
   /// twip per square octillion years, defined as: point per square septillion years × (1.0/20.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareOctillionYears = new (
                                                                          "twip per square octillion years"
                                                                        , "twip/Ryr²"
                                                                        , PointPerSquareSeptillionYears
                                                                        , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// yard per square year, defined as: foot per square day × (3.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration YardPerSquareYear = new (
                                                                "yard per square year"
                                                              , "yd/yr²"
                                                              , FootPerSquareDay
                                                              , 3.0 / (365.2525 * 365.2525)
                                                               );

   /// <summary>
   /// twip per square billion years, defined as: point per square million years × (1.0/20.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareBillionYears = new (
                                                                        "twip per square billion years"
                                                                      , "twip/Gyr²"
                                                                      , PointPerSquareMillionYears
                                                                      , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// cable per square day, defined as: fathom per square hour × (120.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareDay = new (
                                                                "cable per square day"
                                                              , "cb/dy²"
                                                              , FathomPerSquareHour
                                                              , 120.0 / (24.0 * 24.0)
                                                               );

   /// <summary>
   /// mile per square century, defined as: yard per square decade × (1760.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareCentury = new (
                                                                   "mile per square century"
                                                                 , "mi/century²"
                                                                 , YardPerSquareDecade
                                                                 , 1760.0 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// cable per square octillion years, defined as: fathom per square septillion years × (120.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareOctillionYears = new (
                                                                           "cable per square octillion years"
                                                                         , "cb/Ryr²"
                                                                         , FathomPerSquareSeptillionYears
                                                                         , 120.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// pica per square nonillion years, defined as: point per square octillion years × (12.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareNonillionYears = new (
                                                                          "pica per square nonillion years"
                                                                        , "P/Qyr²"
                                                                        , PointPerSquareOctillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// cable per square year, defined as: fathom per square day × (120.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration CablePerSquareYear = new (
                                                                 "cable per square year"
                                                               , "cb/yr²"
                                                               , FathomPerSquareDay
                                                               , 120.0 / (365.2525 * 365.2525)
                                                                );

   /// <summary>
   /// pica per square millennium, defined as: point per square century × (12.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration PicaPerSquareMillennium =
            new ("pica per square millennium", "P/kyr²", PointPerSquareCentury, 12.0 / (10.0 * 10.0));

   /// <summary>
   /// league per square week, defined as: mile per square day × (3.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareWeek =
            new ("league per square week", "le/wk²", MilePerSquareDay, 3.0 / (7.0 * 7.0));

   /// <summary>
   /// mile per square billion years, defined as: yard per square million years × (1760.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareBillionYears = new (
                                                                        "mile per square billion years"
                                                                      , "mi/Gyr²"
                                                                      , YardPerSquareMillionYears
                                                                      , 1760.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// fathom per square octillion years, defined as: yard per square septillion years × (2.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareOctillionYears = new (
                                                                            "fathom per square octillion years"
                                                                          , "ftm/Ryr²"
                                                                          , YardPerSquareSeptillionYears
                                                                          , 2.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// fathom per square sextillion years, defined as: yard per square quintillion years × (2.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareSextillionYears = new (
                                                                             "fathom per square sextillion years"
                                                                           , "ftm/Zyr²"
                                                                           , YardPerSquareQuintillionYears
                                                                           , 2.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// fathom per square quadrillion years, defined as: yard per square trillion years × (2.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuadrillionYears = new (
                                                                              "fathom per square quadrillion years"
                                                                            , "ftm/Pyr²"
                                                                            , YardPerSquareTrillionYears
                                                                            , 2.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// fathom per square billion years, defined as: yard per square million years × (2.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareBillionYears = new (
                                                                          "fathom per square billion years"
                                                                        , "ftm/Gyr²"
                                                                        , YardPerSquareMillionYears
                                                                        , 2.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// mile per square year, defined as: yard per square day × (1760.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration MilePerSquareYear = new (
                                                                "mile per square year"
                                                              , "mi/yr²"
                                                              , YardPerSquareDay
                                                              , 1760.0 / (365.2525 * 365.2525)
                                                               );

   /// <summary>
   /// fathom per square millennium, defined as: yard per square century × (2.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillennium = new (
                                                                        "fathom per square millennium"
                                                                      , "ftm/kyr²"
                                                                      , YardPerSquareCentury
                                                                      , 2.0 / (10.0 * 10.0)
                                                                       );

   /// <summary>
   /// yard per square quadrillion years, defined as: foot per square trillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareQuadrillionYears = new (
                                                                            "yard per square quadrillion years"
                                                                          , "yd/Pyr²"
                                                                          , FootPerSquareTrillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// fathom per square decade, defined as: yard per square year × (2.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecade =
            new ("fathom per square decade", "ftm/decade²", YardPerSquareYear, 2.0 / (10.0 * 10.0));

   /// <summary>
   /// mile per square quintillion years, defined as: yard per square quadrillion years × (1760.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareQuintillionYears = new (
                                                                            "mile per square quintillion years"
                                                                          , "mi/Eyr²"
                                                                          , YardPerSquareQuadrillionYears
                                                                          , 1760.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// fathom per square week, defined as: yard per square day × (2.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareWeek =
            new ("fathom per square week", "ftm/wk²", YardPerSquareDay, 2.0 / (7.0 * 7.0));

   /// <summary>
   /// cable per square trillion years, defined as: fathom per square billion years × (120.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareTrillionYears = new (
                                                                          "cable per square trillion years"
                                                                        , "cb/Tyr²"
                                                                        , FathomPerSquareBillionYears
                                                                        , 120.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// mile per square millennium, defined as: yard per square century × (1760.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareMillennium = new (
                                                                      "mile per square millennium"
                                                                    , "mi/kyr²"
                                                                    , YardPerSquareCentury
                                                                    , 1760.0 / (10.0 * 10.0)
                                                                     );

   /// <summary>
   /// cable per square quintillion years, defined as: fathom per square quadrillion years × (120.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareQuintillionYears = new (
                                                                             "cable per square quintillion years"
                                                                           , "cb/Eyr²"
                                                                           , FathomPerSquareQuadrillionYears
                                                                           , 120.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// league per square sextillion years, defined as: mile per square quintillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSextillionYears = new (
                                                                             "league per square sextillion years"
                                                                           , "le/Zyr²"
                                                                           , MilePerSquareQuintillionYears
                                                                           , 3.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// cable per square septillion years, defined as: fathom per square sextillion years × (120.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareSeptillionYears = new (
                                                                            "cable per square septillion years"
                                                                          , "cb/Yyr²"
                                                                          , FathomPerSquareSextillionYears
                                                                          , 120.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// cable per square week, defined as: fathom per square day × (120.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareWeek =
            new ("cable per square week", "cb/wk²", FathomPerSquareDay, 120.0 / (7.0 * 7.0));

   /// <summary>
   /// mile per square trillion years, defined as: yard per square billion years × (1760.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareTrillionYears = new (
                                                                         "mile per square trillion years"
                                                                       , "mi/Tyr²"
                                                                       , YardPerSquareBillionYears
                                                                       , 1760.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// league per square quadrillion years, defined as: mile per square trillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuadrillionYears = new (
                                                                              "league per square quadrillion years"
                                                                            , "le/Pyr²"
                                                                            , MilePerSquareTrillionYears
                                                                            , 3.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// cable per square nonillion years, defined as: fathom per square octillion years × (120.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareNonillionYears = new (
                                                                           "cable per square nonillion years"
                                                                         , "cb/Qyr²"
                                                                         , FathomPerSquareOctillionYears
                                                                         , 120.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// cable per square decade, defined as: fathom per square year × (120.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareDecade = new (
                                                                   "cable per square decade"
                                                                 , "cb/decade²"
                                                                 , FathomPerSquareYear
                                                                 , 120.0 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// mile per square decade, defined as: yard per square year × (1760.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareDecade = new (
                                                                  "mile per square decade"
                                                                , "mi/decade²"
                                                                , YardPerSquareYear
                                                                , 1760.0 / (10.0 * 10.0)
                                                                 );

   /// <summary>
   /// cable per square millennium, defined as: fathom per square century × (120.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareMillennium = new (
                                                                       "cable per square millennium"
                                                                     , "cb/kyr²"
                                                                     , FathomPerSquareCentury
                                                                     , 120.0 / (10.0 * 10.0)
                                                                      );

   /// <summary>
   /// fathom per square quintillion years, defined as: yard per square quadrillion years × (2.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuintillionYears = new (
                                                                              "fathom per square quintillion years"
                                                                            , "ftm/Eyr²"
                                                                            , YardPerSquareQuadrillionYears
                                                                            , 2.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// fathom per square million years, defined as: yard per square millennium × (2.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillionYears = new (
                                                                          "fathom per square million years"
                                                                        , "ftm/Myr²"
                                                                        , YardPerSquareMillennium
                                                                        , 2.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// mile per square million years, defined as: yard per square millennium × (1760.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareMillionYears = new (
                                                                        "mile per square million years"
                                                                      , "mi/Myr²"
                                                                      , YardPerSquareMillennium
                                                                      , 1760.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// cable per square billion years, defined as: fathom per square million years × (120.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareBillionYears = new (
                                                                         "cable per square billion years"
                                                                       , "cb/Gyr²"
                                                                       , FathomPerSquareMillionYears
                                                                       , 120.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// league per square millennium, defined as: mile per square century × (3.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillennium =
            new ("league per square millennium", "le/kyr²", MilePerSquareCentury, 3.0 / (10.0 * 10.0));

   /// <summary>
   /// mile per square quadrillion years, defined as: yard per square trillion years × (1760.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareQuadrillionYears = new (
                                                                            "mile per square quadrillion years"
                                                                          , "mi/Pyr²"
                                                                          , YardPerSquareTrillionYears
                                                                          , 1760.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// cable per square sextillion years, defined as: fathom per square quintillion years × (120.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareSextillionYears = new (
                                                                            "cable per square sextillion years"
                                                                          , "cb/Zyr²"
                                                                          , FathomPerSquareQuintillionYears
                                                                          , 120.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// league per square decade, defined as: mile per square year × (3.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecade =
            new ("league per square decade", "le/decade²", MilePerSquareYear, 3.0 / (10.0 * 10.0));

   /// <summary>
   /// league per square quintillion years, defined as: mile per square quadrillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuintillionYears = new (
                                                                              "league per square quintillion years"
                                                                            , "le/Eyr²"
                                                                            , MilePerSquareQuadrillionYears
                                                                            , 3.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// league per square trillion years, defined as: mile per square billion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTrillionYears = new (
                                                                           "league per square trillion years"
                                                                         , "le/Tyr²"
                                                                         , MilePerSquareBillionYears
                                                                         , 3.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// cable per square century, defined as: fathom per square decade × (120.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareCentury = new (
                                                                    "cable per square century"
                                                                  , "cb/century²"
                                                                  , FathomPerSquareDecade
                                                                  , 120.0 / (10.0 * 10.0)
                                                                   );

   /// <summary>
   /// cable per square million years, defined as: fathom per square millennium × (120.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareMillionYears = new (
                                                                         "cable per square million years"
                                                                       , "cb/Myr²"
                                                                       , FathomPerSquareMillennium
                                                                       , 120.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// league per square million years, defined as: mile per square millennium × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillionYears = new (
                                                                          "league per square million years"
                                                                        , "le/Myr²"
                                                                        , MilePerSquareMillennium
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// league per square century, defined as: mile per square decade × (3.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentury = new (
                                                                     "league per square century"
                                                                   , "le/century²"
                                                                   , MilePerSquareDecade
                                                                   , 3.0 / (10.0 * 10.0)
                                                                    );

   /// <summary>
   /// league per square billion years, defined as: mile per square million years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareBillionYears = new (
                                                                          "league per square billion years"
                                                                        , "le/Gyr²"
                                                                        , MilePerSquareMillionYears
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                         );
}
