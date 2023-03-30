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
   /// A(n) nautical mile per square octillion years. Defined as: (1852.0)/((1000.0)*(1000.0)) × SI meter per square septillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareOctillionYears = new (
       "nautical mile per square octillion years"
     , "nmi/Ryr²"
     , SI.Accelerations.MeterPerSquareSeptillionYears
     , 1852.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) nautical mile per square trillion years. Defined as: (1852.0)/((1000.0)*(1000.0)) × SI meter per square billion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareTrillionYears = new (
       "nautical mile per square trillion years"
     , "nmi/Tyr²"
     , SI.Accelerations.MeterPerSquareBillionYears
     , 1852.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) nautical mile per square decade. Defined as: (1852.0)/((10.0)*(10.0)) × SI meter per square year.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecade = new (
                                                                          "nautical mile per square decade"
                                                                        , "nmi/decade²"
                                                                        , SI.Accelerations.MeterPerSquareYear
                                                                        , 1852.0 / (10.0 * 10.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) nautical mile per square minute. Defined as: (1852.0)/((60.0)*(60.0)) × SI meter per square second.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMinute = new (
                                                                          "nautical mile per square minute"
                                                                        , "nmi/min²"
                                                                        , SI.Accelerations.MeterPerSquareSecond
                                                                        , 1852.0 / (60.0 * 60.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) nautical mile per square decillion years. Defined as: (1852.0)/((1000.0)*(1000.0)) × SI meter per square nonillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecillionYears = new (
       "nautical mile per square decillion years"
     , "nmi/decillion yr²"
     , SI.Accelerations.MeterPerSquareNonillionYears
     , 1852.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) nautical mile per square quintillion years. Defined as: (1852.0)/((1000.0)*(1000.0)) × SI meter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuintillionYears = new (
       "nautical mile per square quintillion years"
     , "nmi/Eyr²"
     , SI.Accelerations.MeterPerSquareQuadrillionYears
     , 1852.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) nautical mile per square millennium. Defined as: (1852.0)/((10.0)*(10.0)) × SI meter per square century.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillennium = new (
                                                                              "nautical mile per square millennium"
                                                                            , "nmi/kyr²"
                                                                            , SI.Accelerations.MeterPerSquareCentury
                                                                            , 1852.0 / (10.0 * 10.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) nautical mile per square day. Defined as: (1852.0)/((24.0)*(24.0)) × SI meter per square hour.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDay = new (
                                                                       "nautical mile per square day"
                                                                     , "nmi/dy²"
                                                                     , SI.Accelerations.MeterPerSquareHour
                                                                     , 1852.0 / (24.0 * 24.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) nautical mile per square tick. Defined as: (1852.0)/((100.0)*(100.0)) × SI meter per square nanosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareTick = new (
                                                                        "nautical mile per square tick"
                                                                      , "nmi/tick²"
                                                                      , SI.Accelerations.MeterPerSquareNanosecond
                                                                      , 1852.0 / (100.0 * 100.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) nautical mile per square septillion years. Defined as: (1852.0)/((1000.0)*(1000.0)) × SI meter per square sextillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSeptillionYears = new (
       "nautical mile per square septillion years"
     , "nmi/Yyr²"
     , SI.Accelerations.MeterPerSquareSextillionYears
     , 1852.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) nautical mile per square billion years. Defined as: (1852.0)/((1000.0)*(1000.0)) × SI meter per square million years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareBillionYears = new (
                                                                                "nautical mile per square billion years"
                                                                              , "nmi/Gyr²"
                                                                              , SI.Accelerations
                                                                                        .MeterPerSquareMillionYears
                                                                              , 1852.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) nautical mile per square year. Defined as: (1852.0)/((365.2525)*(365.2525)) × SI meter per square day.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareYear = new (
                                                                        "nautical mile per square year"
                                                                      , "nmi/yr²"
                                                                      , SI.Accelerations.MeterPerSquareDay
                                                                      , 1852.0 / (365.2525 * 365.2525)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) inch per square second. Defined as: (2.54)/((1.0)*(1.0)) × SI centimeter per square second.
   /// </summary>
   public static readonly Acceleration InchPerSquareSecond = new (
                                                                  "inch per square second"
                                                                , "in/s²"
                                                                , SI.Accelerations.CentimeterPerSquareSecond
                                                                , 2.54 / (1.0 * 1.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) inch per square decisecond. Defined as: (2.54)/((1.0/10.0)*(1.0/10.0)) × SI centimeter per square second.
   /// </summary>
   public static readonly Acceleration InchPerSquareDecisecond = new (
                                                                      "inch per square decisecond"
                                                                    , "in/ds²"
                                                                    , SI.Accelerations.CentimeterPerSquareSecond
                                                                    , 2.54 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) inch per square centisecond. Defined as: (2.54)/((1.0/10.0)*(1.0/10.0)) × SI centimeter per square decisecond.
   /// </summary>
   public static readonly Acceleration InchPerSquareCentisecond = new (
                                                                       "inch per square centisecond"
                                                                     , "in/cs²"
                                                                     , SI.Accelerations.CentimeterPerSquareDecisecond
                                                                     , 2.54 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) inch per square millisecond. Defined as: (2.54)/((1.0/10.0)*(1.0/10.0)) × SI centimeter per square centisecond.
   /// </summary>
   public static readonly Acceleration InchPerSquareMillisecond = new (
                                                                       "inch per square millisecond"
                                                                     , "in/ms²"
                                                                     , SI.Accelerations.CentimeterPerSquareCentisecond
                                                                     , 2.54 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) inch per square microsecond. Defined as: (2.54)/((1.0/1000.0)*(1.0/1000.0)) × SI centimeter per square millisecond.
   /// </summary>
   public static readonly Acceleration InchPerSquareMicrosecond = new (
                                                                       "inch per square microsecond"
                                                                     , "in/μs²"
                                                                     , SI.Accelerations.CentimeterPerSquareMillisecond
                                                                     , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) inch per square nanosecond. Defined as: (2.54)/((1.0/1000.0)*(1.0/1000.0)) × SI centimeter per square microsecond.
   /// </summary>
   public static readonly Acceleration InchPerSquareNanosecond = new (
                                                                      "inch per square nanosecond"
                                                                    , "in/ns²"
                                                                    , SI.Accelerations.CentimeterPerSquareMicrosecond
                                                                    , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) inch per square picosecond. Defined as: (2.54)/((1.0/1000.0)*(1.0/1000.0)) × SI centimeter per square nanosecond.
   /// </summary>
   public static readonly Acceleration InchPerSquarePicosecond = new (
                                                                      "inch per square picosecond"
                                                                    , "in/ps²"
                                                                    , SI.Accelerations.CentimeterPerSquareNanosecond
                                                                    , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) inch per square femtosecond. Defined as: (2.54)/((1.0/1000.0)*(1.0/1000.0)) × SI centimeter per square picosecond.
   /// </summary>
   public static readonly Acceleration InchPerSquareFemtosecond = new (
                                                                       "inch per square femtosecond"
                                                                     , "in/fs²"
                                                                     , SI.Accelerations.CentimeterPerSquarePicosecond
                                                                     , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) inch per square attosecond. Defined as: (2.54)/((1.0/1000.0)*(1.0/1000.0)) × SI centimeter per square femtosecond.
   /// </summary>
   public static readonly Acceleration InchPerSquareAttosecond = new (
                                                                      "inch per square attosecond"
                                                                    , "in/as²"
                                                                    , SI.Accelerations.CentimeterPerSquareFemtosecond
                                                                    , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) inch per square zeptosecond. Defined as: (2.54)/((1.0/1000.0)*(1.0/1000.0)) × SI centimeter per square attosecond.
   /// </summary>
   public static readonly Acceleration InchPerSquareZeptosecond = new (
                                                                       "inch per square zeptosecond"
                                                                     , "in/zs²"
                                                                     , SI.Accelerations.CentimeterPerSquareAttosecond
                                                                     , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) inch per square yoctosecond. Defined as: (2.54)/((1.0/1000.0)*(1.0/1000.0)) × SI centimeter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration InchPerSquareYoctosecond = new (
                                                                       "inch per square yoctosecond"
                                                                     , "in/ys²"
                                                                     , SI.Accelerations.CentimeterPerSquareZeptosecond
                                                                     , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) inch per square rontosecond. Defined as: (2.54)/((1.0/1000.0)*(1.0/1000.0)) × SI centimeter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration InchPerSquareRontosecond = new (
                                                                       "inch per square rontosecond"
                                                                     , "in/rs²"
                                                                     , SI.Accelerations.CentimeterPerSquareYoctosecond
                                                                     , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) inch per square quectosecond. Defined as: (2.54)/((1.0/1000.0)*(1.0/1000.0)) × SI centimeter per square rontosecond.
   /// </summary>
   public static readonly Acceleration InchPerSquareQuectosecond = new (
                                                                        "inch per square quectosecond"
                                                                      , "in/qs²"
                                                                      , SI.Accelerations.CentimeterPerSquareRontosecond
                                                                      , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) inch per square minute. Defined as: (2.54)/((60.0)*(60.0)) × SI centimeter per square second.
   /// </summary>
   public static readonly Acceleration InchPerSquareMinute = new (
                                                                  "inch per square minute"
                                                                , "in/min²"
                                                                , SI.Accelerations.CentimeterPerSquareSecond
                                                                , 2.54 / (60.0 * 60.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) mil per square second. Defined as: (1.0/1000.0)/((1.0)*(1.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration MilPerSquareSecond = new (
                                                                 "mil per square second"
                                                               , "mil/s²"
                                                               , InchPerSquareSecond
                                                               , 1.0 / 1000.0 / (1.0 * 1.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) mil per square decisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration MilPerSquareDecisecond = new (
                                                                     "mil per square decisecond"
                                                                   , "mil/ds²"
                                                                   , InchPerSquareSecond
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) mil per square centisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × inch per square decisecond.
   /// </summary>
   public static readonly Acceleration MilPerSquareCentisecond = new (
                                                                      "mil per square centisecond"
                                                                    , "mil/cs²"
                                                                    , InchPerSquareDecisecond
                                                                    , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mil per square millisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × inch per square centisecond.
   /// </summary>
   public static readonly Acceleration MilPerSquareMillisecond = new (
                                                                      "mil per square millisecond"
                                                                    , "mil/ms²"
                                                                    , InchPerSquareCentisecond
                                                                    , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mil per square microsecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square millisecond.
   /// </summary>
   public static readonly Acceleration MilPerSquareMicrosecond = new (
                                                                      "mil per square microsecond"
                                                                    , "mil/μs²"
                                                                    , InchPerSquareMillisecond
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mil per square nanosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square microsecond.
   /// </summary>
   public static readonly Acceleration MilPerSquareNanosecond = new (
                                                                     "mil per square nanosecond"
                                                                   , "mil/ns²"
                                                                   , InchPerSquareMicrosecond
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) mil per square picosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square nanosecond.
   /// </summary>
   public static readonly Acceleration MilPerSquarePicosecond = new (
                                                                     "mil per square picosecond"
                                                                   , "mil/ps²"
                                                                   , InchPerSquareNanosecond
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) mil per square femtosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square picosecond.
   /// </summary>
   public static readonly Acceleration MilPerSquareFemtosecond = new (
                                                                      "mil per square femtosecond"
                                                                    , "mil/fs²"
                                                                    , InchPerSquarePicosecond
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mil per square attosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square femtosecond.
   /// </summary>
   public static readonly Acceleration MilPerSquareAttosecond = new (
                                                                     "mil per square attosecond"
                                                                   , "mil/as²"
                                                                   , InchPerSquareFemtosecond
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) mil per square zeptosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square attosecond.
   /// </summary>
   public static readonly Acceleration MilPerSquareZeptosecond = new (
                                                                      "mil per square zeptosecond"
                                                                    , "mil/zs²"
                                                                    , InchPerSquareAttosecond
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mil per square yoctosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square zeptosecond.
   /// </summary>
   public static readonly Acceleration MilPerSquareYoctosecond = new (
                                                                      "mil per square yoctosecond"
                                                                    , "mil/ys²"
                                                                    , InchPerSquareZeptosecond
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mil per square rontosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square yoctosecond.
   /// </summary>
   public static readonly Acceleration MilPerSquareRontosecond = new (
                                                                      "mil per square rontosecond"
                                                                    , "mil/rs²"
                                                                    , InchPerSquareYoctosecond
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mil per square quectosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square rontosecond.
   /// </summary>
   public static readonly Acceleration MilPerSquareQuectosecond = new (
                                                                       "mil per square quectosecond"
                                                                     , "mil/qs²"
                                                                     , InchPerSquareRontosecond
                                                                     , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) inch per square hour. Defined as: (2.54)/((60.0)*(60.0)) × SI centimeter per square minute.
   /// </summary>
   public static readonly Acceleration InchPerSquareHour = new (
                                                                "inch per square hour"
                                                              , "in/hr²"
                                                              , SI.Accelerations.CentimeterPerSquareMinute
                                                              , 2.54 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) point per square second. Defined as: (1.0/72.0)/((1.0)*(1.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration PointPerSquareSecond = new (
                                                                   "point per square second"
                                                                 , "p/s²"
                                                                 , InchPerSquareSecond
                                                                 , 1.0 / 72.0 / (1.0 * 1.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) point per square decisecond. Defined as: (1.0/72.0)/((1.0/10.0)*(1.0/10.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration PointPerSquareDecisecond = new (
                                                                       "point per square decisecond"
                                                                     , "p/ds²"
                                                                     , InchPerSquareSecond
                                                                     , 1.0 / 72.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) point per square centisecond. Defined as: (1.0/72.0)/((1.0/10.0)*(1.0/10.0)) × inch per square decisecond.
   /// </summary>
   public static readonly Acceleration PointPerSquareCentisecond = new (
                                                                        "point per square centisecond"
                                                                      , "p/cs²"
                                                                      , InchPerSquareDecisecond
                                                                      , 1.0 / 72.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) point per square millisecond. Defined as: (1.0/72.0)/((1.0/10.0)*(1.0/10.0)) × inch per square centisecond.
   /// </summary>
   public static readonly Acceleration PointPerSquareMillisecond = new (
                                                                        "point per square millisecond"
                                                                      , "p/ms²"
                                                                      , InchPerSquareCentisecond
                                                                      , 1.0 / 72.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) point per square microsecond. Defined as: (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square millisecond.
   /// </summary>
   public static readonly Acceleration PointPerSquareMicrosecond = new (
                                                                        "point per square microsecond"
                                                                      , "p/μs²"
                                                                      , InchPerSquareMillisecond
                                                                      , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) point per square nanosecond. Defined as: (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square microsecond.
   /// </summary>
   public static readonly Acceleration PointPerSquareNanosecond = new (
                                                                       "point per square nanosecond"
                                                                     , "p/ns²"
                                                                     , InchPerSquareMicrosecond
                                                                     , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) point per square picosecond. Defined as: (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square nanosecond.
   /// </summary>
   public static readonly Acceleration PointPerSquarePicosecond = new (
                                                                       "point per square picosecond"
                                                                     , "p/ps²"
                                                                     , InchPerSquareNanosecond
                                                                     , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) point per square femtosecond. Defined as: (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square picosecond.
   /// </summary>
   public static readonly Acceleration PointPerSquareFemtosecond = new (
                                                                        "point per square femtosecond"
                                                                      , "p/fs²"
                                                                      , InchPerSquarePicosecond
                                                                      , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) point per square attosecond. Defined as: (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square femtosecond.
   /// </summary>
   public static readonly Acceleration PointPerSquareAttosecond = new (
                                                                       "point per square attosecond"
                                                                     , "p/as²"
                                                                     , InchPerSquareFemtosecond
                                                                     , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) point per square zeptosecond. Defined as: (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square attosecond.
   /// </summary>
   public static readonly Acceleration PointPerSquareZeptosecond = new (
                                                                        "point per square zeptosecond"
                                                                      , "p/zs²"
                                                                      , InchPerSquareAttosecond
                                                                      , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) point per square yoctosecond. Defined as: (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square zeptosecond.
   /// </summary>
   public static readonly Acceleration PointPerSquareYoctosecond = new (
                                                                        "point per square yoctosecond"
                                                                      , "p/ys²"
                                                                      , InchPerSquareZeptosecond
                                                                      , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) point per square rontosecond. Defined as: (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square yoctosecond.
   /// </summary>
   public static readonly Acceleration PointPerSquareRontosecond = new (
                                                                        "point per square rontosecond"
                                                                      , "p/rs²"
                                                                      , InchPerSquareYoctosecond
                                                                      , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) point per square quectosecond. Defined as: (1.0/72.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square rontosecond.
   /// </summary>
   public static readonly Acceleration PointPerSquareQuectosecond = new (
                                                                         "point per square quectosecond"
                                                                       , "p/qs²"
                                                                       , InchPerSquareRontosecond
                                                                       , 1.0 / 72.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) inch per square day. Defined as: (2.54)/((24.0)*(24.0)) × SI centimeter per square hour.
   /// </summary>
   public static readonly Acceleration InchPerSquareDay = new (
                                                               "inch per square day"
                                                             , "in/dy²"
                                                             , SI.Accelerations.CentimeterPerSquareHour
                                                             , 2.54 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) twip per square second. Defined as: (1.0/20.0)/((1.0)*(1.0)) × point per square second.
   /// </summary>
   public static readonly Acceleration TwipPerSquareSecond = new (
                                                                  "twip per square second"
                                                                , "twip/s²"
                                                                , PointPerSquareSecond
                                                                , 1.0 / 20.0 / (1.0 * 1.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) twip per square decisecond. Defined as: (1.0/20.0)/((1.0/10.0)*(1.0/10.0)) × point per square second.
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecisecond = new (
                                                                      "twip per square decisecond"
                                                                    , "twip/ds²"
                                                                    , PointPerSquareSecond
                                                                    , 1.0 / 20.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square centisecond. Defined as: (1.0/20.0)/((1.0/10.0)*(1.0/10.0)) × point per square decisecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareCentisecond = new (
                                                                       "twip per square centisecond"
                                                                     , "twip/cs²"
                                                                     , PointPerSquareDecisecond
                                                                     , 1.0 / 20.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square millisecond. Defined as: (1.0/20.0)/((1.0/10.0)*(1.0/10.0)) × point per square centisecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillisecond = new (
                                                                       "twip per square millisecond"
                                                                     , "twip/ms²"
                                                                     , PointPerSquareCentisecond
                                                                     , 1.0 / 20.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square microsecond. Defined as: (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square millisecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareMicrosecond = new (
                                                                       "twip per square microsecond"
                                                                     , "twip/μs²"
                                                                     , PointPerSquareMillisecond
                                                                     , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square nanosecond. Defined as: (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square microsecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareNanosecond = new (
                                                                      "twip per square nanosecond"
                                                                    , "twip/ns²"
                                                                    , PointPerSquareMicrosecond
                                                                    , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square picosecond. Defined as: (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square nanosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquarePicosecond = new (
                                                                      "twip per square picosecond"
                                                                    , "twip/ps²"
                                                                    , PointPerSquareNanosecond
                                                                    , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square femtosecond. Defined as: (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square picosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareFemtosecond = new (
                                                                       "twip per square femtosecond"
                                                                     , "twip/fs²"
                                                                     , PointPerSquarePicosecond
                                                                     , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square attosecond. Defined as: (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square femtosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareAttosecond = new (
                                                                      "twip per square attosecond"
                                                                    , "twip/as²"
                                                                    , PointPerSquareFemtosecond
                                                                    , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square zeptosecond. Defined as: (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square attosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareZeptosecond = new (
                                                                       "twip per square zeptosecond"
                                                                     , "twip/zs²"
                                                                     , PointPerSquareAttosecond
                                                                     , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square yoctosecond. Defined as: (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square zeptosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareYoctosecond = new (
                                                                       "twip per square yoctosecond"
                                                                     , "twip/ys²"
                                                                     , PointPerSquareZeptosecond
                                                                     , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square rontosecond. Defined as: (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square yoctosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareRontosecond = new (
                                                                       "twip per square rontosecond"
                                                                     , "twip/rs²"
                                                                     , PointPerSquareYoctosecond
                                                                     , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square quectosecond. Defined as: (1.0/20.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square rontosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuectosecond = new (
                                                                        "twip per square quectosecond"
                                                                      , "twip/qs²"
                                                                      , PointPerSquareRontosecond
                                                                      , 1.0 / 20.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) inch per square week. Defined as: (2.54)/((7.0)*(7.0)) × SI centimeter per square day.
   /// </summary>
   public static readonly Acceleration InchPerSquareWeek = new (
                                                                "inch per square week"
                                                              , "in/wk²"
                                                              , SI.Accelerations.CentimeterPerSquareDay
                                                              , 2.54 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) pica per square second. Defined as: (12.0)/((1.0)*(1.0)) × point per square second.
   /// </summary>
   public static readonly Acceleration PicaPerSquareSecond =
            new ("pica per square second", "P/s²", PointPerSquareSecond, 12.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) pica per square decisecond. Defined as: (12.0)/((1.0/10.0)*(1.0/10.0)) × point per square second.
   /// </summary>
   public static readonly Acceleration PicaPerSquareDecisecond = new (
                                                                      "pica per square decisecond"
                                                                    , "P/ds²"
                                                                    , PointPerSquareSecond
                                                                    , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) pica per square centisecond. Defined as: (12.0)/((1.0/10.0)*(1.0/10.0)) × point per square decisecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquareCentisecond = new (
                                                                       "pica per square centisecond"
                                                                     , "P/cs²"
                                                                     , PointPerSquareDecisecond
                                                                     , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) pica per square millisecond. Defined as: (12.0)/((1.0/10.0)*(1.0/10.0)) × point per square centisecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquareMillisecond = new (
                                                                       "pica per square millisecond"
                                                                     , "P/ms²"
                                                                     , PointPerSquareCentisecond
                                                                     , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) pica per square microsecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square millisecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquareMicrosecond = new (
                                                                       "pica per square microsecond"
                                                                     , "P/μs²"
                                                                     , PointPerSquareMillisecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) pica per square nanosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square microsecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquareNanosecond = new (
                                                                      "pica per square nanosecond"
                                                                    , "P/ns²"
                                                                    , PointPerSquareMicrosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) pica per square picosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square nanosecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquarePicosecond = new (
                                                                      "pica per square picosecond"
                                                                    , "P/ps²"
                                                                    , PointPerSquareNanosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) pica per square femtosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square picosecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquareFemtosecond = new (
                                                                       "pica per square femtosecond"
                                                                     , "P/fs²"
                                                                     , PointPerSquarePicosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) pica per square attosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square femtosecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquareAttosecond = new (
                                                                      "pica per square attosecond"
                                                                    , "P/as²"
                                                                    , PointPerSquareFemtosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) pica per square zeptosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square attosecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquareZeptosecond = new (
                                                                       "pica per square zeptosecond"
                                                                     , "P/zs²"
                                                                     , PointPerSquareAttosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) pica per square yoctosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square zeptosecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquareYoctosecond = new (
                                                                       "pica per square yoctosecond"
                                                                     , "P/ys²"
                                                                     , PointPerSquareZeptosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) pica per square rontosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square yoctosecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquareRontosecond = new (
                                                                       "pica per square rontosecond"
                                                                     , "P/rs²"
                                                                     , PointPerSquareYoctosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) pica per square quectosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × point per square rontosecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquareQuectosecond = new (
                                                                        "pica per square quectosecond"
                                                                      , "P/qs²"
                                                                      , PointPerSquareRontosecond
                                                                      , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) inch per square year. Defined as: (2.54)/((365.2525)*(365.2525)) × SI centimeter per square day.
   /// </summary>
   public static readonly Acceleration InchPerSquareYear = new (
                                                                "inch per square year"
                                                              , "in/yr²"
                                                              , SI.Accelerations.CentimeterPerSquareDay
                                                              , 2.54 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) foot per square second. Defined as: (12.0)/((1.0)*(1.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration FootPerSquareSecond =
            new ("foot per square second", "ft/s²", InchPerSquareSecond, 12.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) foot per square decisecond. Defined as: (12.0)/((1.0/10.0)*(1.0/10.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration FootPerSquareDecisecond = new (
                                                                      "foot per square decisecond"
                                                                    , "ft/ds²"
                                                                    , InchPerSquareSecond
                                                                    , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square centisecond. Defined as: (12.0)/((1.0/10.0)*(1.0/10.0)) × inch per square decisecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareCentisecond = new (
                                                                       "foot per square centisecond"
                                                                     , "ft/cs²"
                                                                     , InchPerSquareDecisecond
                                                                     , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square millisecond. Defined as: (12.0)/((1.0/10.0)*(1.0/10.0)) × inch per square centisecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareMillisecond = new (
                                                                       "foot per square millisecond"
                                                                     , "ft/ms²"
                                                                     , InchPerSquareCentisecond
                                                                     , 12.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square microsecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square millisecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareMicrosecond = new (
                                                                       "foot per square microsecond"
                                                                     , "ft/μs²"
                                                                     , InchPerSquareMillisecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square nanosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square microsecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareNanosecond = new (
                                                                      "foot per square nanosecond"
                                                                    , "ft/ns²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square picosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square nanosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquarePicosecond = new (
                                                                      "foot per square picosecond"
                                                                    , "ft/ps²"
                                                                    , InchPerSquareNanosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square femtosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square picosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareFemtosecond = new (
                                                                       "foot per square femtosecond"
                                                                     , "ft/fs²"
                                                                     , InchPerSquarePicosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square attosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square femtosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareAttosecond = new (
                                                                      "foot per square attosecond"
                                                                    , "ft/as²"
                                                                    , InchPerSquareFemtosecond
                                                                    , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square zeptosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square attosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareZeptosecond = new (
                                                                       "foot per square zeptosecond"
                                                                     , "ft/zs²"
                                                                     , InchPerSquareAttosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square yoctosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square zeptosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareYoctosecond = new (
                                                                       "foot per square yoctosecond"
                                                                     , "ft/ys²"
                                                                     , InchPerSquareZeptosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square rontosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square yoctosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareRontosecond = new (
                                                                       "foot per square rontosecond"
                                                                     , "ft/rs²"
                                                                     , InchPerSquareYoctosecond
                                                                     , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square quectosecond. Defined as: (12.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square rontosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareQuectosecond = new (
                                                                        "foot per square quectosecond"
                                                                      , "ft/qs²"
                                                                      , InchPerSquareRontosecond
                                                                      , 12.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) inch per square decade. Defined as: (2.54)/((10.0)*(10.0)) × SI centimeter per square year.
   /// </summary>
   public static readonly Acceleration InchPerSquareDecade = new (
                                                                  "inch per square decade"
                                                                , "in/decade²"
                                                                , SI.Accelerations.CentimeterPerSquareYear
                                                                , 2.54 / (10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yard per square second. Defined as: (3.0)/((1.0)*(1.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration YardPerSquareSecond =
            new ("yard per square second", "yd/s²", FootPerSquareSecond, 3.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) yard per square decisecond. Defined as: (3.0)/((1.0/10.0)*(1.0/10.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration YardPerSquareDecisecond = new (
                                                                      "yard per square decisecond"
                                                                    , "yd/ds²"
                                                                    , FootPerSquareSecond
                                                                    , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yard per square centisecond. Defined as: (3.0)/((1.0/10.0)*(1.0/10.0)) × foot per square decisecond.
   /// </summary>
   public static readonly Acceleration YardPerSquareCentisecond = new (
                                                                       "yard per square centisecond"
                                                                     , "yd/cs²"
                                                                     , FootPerSquareDecisecond
                                                                     , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yard per square millisecond. Defined as: (3.0)/((1.0/10.0)*(1.0/10.0)) × foot per square centisecond.
   /// </summary>
   public static readonly Acceleration YardPerSquareMillisecond = new (
                                                                       "yard per square millisecond"
                                                                     , "yd/ms²"
                                                                     , FootPerSquareCentisecond
                                                                     , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yard per square microsecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square millisecond.
   /// </summary>
   public static readonly Acceleration YardPerSquareMicrosecond = new (
                                                                       "yard per square microsecond"
                                                                     , "yd/μs²"
                                                                     , FootPerSquareMillisecond
                                                                     , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yard per square nanosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square microsecond.
   /// </summary>
   public static readonly Acceleration YardPerSquareNanosecond = new (
                                                                      "yard per square nanosecond"
                                                                    , "yd/ns²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yard per square picosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square nanosecond.
   /// </summary>
   public static readonly Acceleration YardPerSquarePicosecond = new (
                                                                      "yard per square picosecond"
                                                                    , "yd/ps²"
                                                                    , FootPerSquareNanosecond
                                                                    , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yard per square femtosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square picosecond.
   /// </summary>
   public static readonly Acceleration YardPerSquareFemtosecond = new (
                                                                       "yard per square femtosecond"
                                                                     , "yd/fs²"
                                                                     , FootPerSquarePicosecond
                                                                     , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yard per square attosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square femtosecond.
   /// </summary>
   public static readonly Acceleration YardPerSquareAttosecond = new (
                                                                      "yard per square attosecond"
                                                                    , "yd/as²"
                                                                    , FootPerSquareFemtosecond
                                                                    , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yard per square zeptosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square attosecond.
   /// </summary>
   public static readonly Acceleration YardPerSquareZeptosecond = new (
                                                                       "yard per square zeptosecond"
                                                                     , "yd/zs²"
                                                                     , FootPerSquareAttosecond
                                                                     , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yard per square yoctosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square zeptosecond.
   /// </summary>
   public static readonly Acceleration YardPerSquareYoctosecond = new (
                                                                       "yard per square yoctosecond"
                                                                     , "yd/ys²"
                                                                     , FootPerSquareZeptosecond
                                                                     , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yard per square rontosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square yoctosecond.
   /// </summary>
   public static readonly Acceleration YardPerSquareRontosecond = new (
                                                                       "yard per square rontosecond"
                                                                     , "yd/rs²"
                                                                     , FootPerSquareYoctosecond
                                                                     , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yard per square quectosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square rontosecond.
   /// </summary>
   public static readonly Acceleration YardPerSquareQuectosecond = new (
                                                                        "yard per square quectosecond"
                                                                      , "yd/qs²"
                                                                      , FootPerSquareRontosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) inch per square century. Defined as: (2.54)/((10.0)*(10.0)) × SI centimeter per square decade.
   /// </summary>
   public static readonly Acceleration InchPerSquareCentury = new (
                                                                   "inch per square century"
                                                                 , "in/century²"
                                                                 , SI.Accelerations.CentimeterPerSquareDecade
                                                                 , 2.54 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) mile per square second. Defined as: (1760.0)/((1.0)*(1.0)) × yard per square second.
   /// </summary>
   public static readonly Acceleration MilePerSquareSecond =
            new ("mile per square second", "mi/s²", YardPerSquareSecond, 1760.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) mile per square decisecond. Defined as: (1760.0)/((1.0/10.0)*(1.0/10.0)) × yard per square second.
   /// </summary>
   public static readonly Acceleration MilePerSquareDecisecond = new (
                                                                      "mile per square decisecond"
                                                                    , "mi/ds²"
                                                                    , YardPerSquareSecond
                                                                    , 1760.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mile per square centisecond. Defined as: (1760.0)/((1.0/10.0)*(1.0/10.0)) × yard per square decisecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareCentisecond = new (
                                                                       "mile per square centisecond"
                                                                     , "mi/cs²"
                                                                     , YardPerSquareDecisecond
                                                                     , 1760.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square millisecond. Defined as: (1760.0)/((1.0/10.0)*(1.0/10.0)) × yard per square centisecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareMillisecond = new (
                                                                       "mile per square millisecond"
                                                                     , "mi/ms²"
                                                                     , YardPerSquareCentisecond
                                                                     , 1760.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square microsecond. Defined as: (1760.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square millisecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareMicrosecond = new (
                                                                       "mile per square microsecond"
                                                                     , "mi/μs²"
                                                                     , YardPerSquareMillisecond
                                                                     , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square nanosecond. Defined as: (1760.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square microsecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareNanosecond = new (
                                                                      "mile per square nanosecond"
                                                                    , "mi/ns²"
                                                                    , YardPerSquareMicrosecond
                                                                    , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mile per square picosecond. Defined as: (1760.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square nanosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquarePicosecond = new (
                                                                      "mile per square picosecond"
                                                                    , "mi/ps²"
                                                                    , YardPerSquareNanosecond
                                                                    , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mile per square femtosecond. Defined as: (1760.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square picosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareFemtosecond = new (
                                                                       "mile per square femtosecond"
                                                                     , "mi/fs²"
                                                                     , YardPerSquarePicosecond
                                                                     , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square attosecond. Defined as: (1760.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square femtosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareAttosecond = new (
                                                                      "mile per square attosecond"
                                                                    , "mi/as²"
                                                                    , YardPerSquareFemtosecond
                                                                    , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mile per square zeptosecond. Defined as: (1760.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square attosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareZeptosecond = new (
                                                                       "mile per square zeptosecond"
                                                                     , "mi/zs²"
                                                                     , YardPerSquareAttosecond
                                                                     , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square yoctosecond. Defined as: (1760.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square zeptosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareYoctosecond = new (
                                                                       "mile per square yoctosecond"
                                                                     , "mi/ys²"
                                                                     , YardPerSquareZeptosecond
                                                                     , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square rontosecond. Defined as: (1760.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square yoctosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareRontosecond = new (
                                                                       "mile per square rontosecond"
                                                                     , "mi/rs²"
                                                                     , YardPerSquareYoctosecond
                                                                     , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square quectosecond. Defined as: (1760.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square rontosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareQuectosecond = new (
                                                                        "mile per square quectosecond"
                                                                      , "mi/qs²"
                                                                      , YardPerSquareRontosecond
                                                                      , 1760.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) inch per square millennium. Defined as: (2.54)/((10.0)*(10.0)) × SI centimeter per square century.
   /// </summary>
   public static readonly Acceleration InchPerSquareMillennium = new (
                                                                      "inch per square millennium"
                                                                    , "in/kyr²"
                                                                    , SI.Accelerations.CentimeterPerSquareCentury
                                                                    , 2.54 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) league per square second. Defined as: (3.0)/((1.0)*(1.0)) × mile per square second.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSecond =
            new ("league per square second", "le/s²", MilePerSquareSecond, 3.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) league per square decisecond. Defined as: (3.0)/((1.0/10.0)*(1.0/10.0)) × mile per square second.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecisecond = new (
                                                                        "league per square decisecond"
                                                                      , "le/ds²"
                                                                      , MilePerSquareSecond
                                                                      , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square centisecond. Defined as: (3.0)/((1.0/10.0)*(1.0/10.0)) × mile per square decisecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentisecond = new (
                                                                         "league per square centisecond"
                                                                       , "le/cs²"
                                                                       , MilePerSquareDecisecond
                                                                       , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square millisecond. Defined as: (3.0)/((1.0/10.0)*(1.0/10.0)) × mile per square centisecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillisecond = new (
                                                                         "league per square millisecond"
                                                                       , "le/ms²"
                                                                       , MilePerSquareCentisecond
                                                                       , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square microsecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square millisecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMicrosecond = new (
                                                                         "league per square microsecond"
                                                                       , "le/μs²"
                                                                       , MilePerSquareMillisecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square nanosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square microsecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNanosecond = new (
                                                                        "league per square nanosecond"
                                                                      , "le/ns²"
                                                                      , MilePerSquareMicrosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square picosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square nanosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePicosecond = new (
                                                                        "league per square picosecond"
                                                                      , "le/ps²"
                                                                      , MilePerSquareNanosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square femtosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square picosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareFemtosecond = new (
                                                                         "league per square femtosecond"
                                                                       , "le/fs²"
                                                                       , MilePerSquarePicosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square attosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square femtosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareAttosecond = new (
                                                                        "league per square attosecond"
                                                                      , "le/as²"
                                                                      , MilePerSquareFemtosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square zeptosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square attosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareZeptosecond = new (
                                                                         "league per square zeptosecond"
                                                                       , "le/zs²"
                                                                       , MilePerSquareAttosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square yoctosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square zeptosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYoctosecond = new (
                                                                         "league per square yoctosecond"
                                                                       , "le/ys²"
                                                                       , MilePerSquareZeptosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square rontosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square yoctosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareRontosecond = new (
                                                                         "league per square rontosecond"
                                                                       , "le/rs²"
                                                                       , MilePerSquareYoctosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square quectosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square rontosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuectosecond = new (
                                                                          "league per square quectosecond"
                                                                        , "le/qs²"
                                                                        , MilePerSquareRontosecond
                                                                        , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) inch per square million years. Defined as: (2.54)/((1000.0)*(1000.0)) × SI centimeter per square millennium.
   /// </summary>
   public static readonly Acceleration InchPerSquareMillionYears = new (
                                                                        "inch per square million years"
                                                                      , "in/Myr²"
                                                                      , SI.Accelerations.CentimeterPerSquareMillennium
                                                                      , 2.54 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square second. Defined as: (2.0)/((1.0)*(1.0)) × yard per square second.
   /// </summary>
   public static readonly Acceleration FathomPerSquareSecond =
            new ("fathom per square second", "ftm/s²", YardPerSquareSecond, 2.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) fathom per square decisecond. Defined as: (2.0)/((1.0/10.0)*(1.0/10.0)) × yard per square second.
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecisecond = new (
                                                                        "fathom per square decisecond"
                                                                      , "ftm/ds²"
                                                                      , YardPerSquareSecond
                                                                      , 2.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square centisecond. Defined as: (2.0)/((1.0/10.0)*(1.0/10.0)) × yard per square decisecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareCentisecond = new (
                                                                         "fathom per square centisecond"
                                                                       , "ftm/cs²"
                                                                       , YardPerSquareDecisecond
                                                                       , 2.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square millisecond. Defined as: (2.0)/((1.0/10.0)*(1.0/10.0)) × yard per square centisecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillisecond = new (
                                                                         "fathom per square millisecond"
                                                                       , "ftm/ms²"
                                                                       , YardPerSquareCentisecond
                                                                       , 2.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square microsecond. Defined as: (2.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square millisecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareMicrosecond = new (
                                                                         "fathom per square microsecond"
                                                                       , "ftm/μs²"
                                                                       , YardPerSquareMillisecond
                                                                       , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square nanosecond. Defined as: (2.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square microsecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareNanosecond = new (
                                                                        "fathom per square nanosecond"
                                                                      , "ftm/ns²"
                                                                      , YardPerSquareMicrosecond
                                                                      , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square picosecond. Defined as: (2.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square nanosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquarePicosecond = new (
                                                                        "fathom per square picosecond"
                                                                      , "ftm/ps²"
                                                                      , YardPerSquareNanosecond
                                                                      , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square femtosecond. Defined as: (2.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square picosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareFemtosecond = new (
                                                                         "fathom per square femtosecond"
                                                                       , "ftm/fs²"
                                                                       , YardPerSquarePicosecond
                                                                       , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square attosecond. Defined as: (2.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square femtosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareAttosecond = new (
                                                                        "fathom per square attosecond"
                                                                      , "ftm/as²"
                                                                      , YardPerSquareFemtosecond
                                                                      , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square zeptosecond. Defined as: (2.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square attosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareZeptosecond = new (
                                                                         "fathom per square zeptosecond"
                                                                       , "ftm/zs²"
                                                                       , YardPerSquareAttosecond
                                                                       , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square yoctosecond. Defined as: (2.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square zeptosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareYoctosecond = new (
                                                                         "fathom per square yoctosecond"
                                                                       , "ftm/ys²"
                                                                       , YardPerSquareZeptosecond
                                                                       , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square rontosecond. Defined as: (2.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square yoctosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareRontosecond = new (
                                                                         "fathom per square rontosecond"
                                                                       , "ftm/rs²"
                                                                       , YardPerSquareYoctosecond
                                                                       , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square quectosecond. Defined as: (2.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square rontosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuectosecond = new (
                                                                          "fathom per square quectosecond"
                                                                        , "ftm/qs²"
                                                                        , YardPerSquareRontosecond
                                                                        , 2.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) inch per square billion years. Defined as: (2.54)/((1000.0)*(1000.0)) × SI centimeter per square million years.
   /// </summary>
   public static readonly Acceleration InchPerSquareBillionYears = new (
                                                                        "inch per square billion years"
                                                                      , "in/Gyr²"
                                                                      , SI.Accelerations.CentimeterPerSquareMillionYears
                                                                      , 2.54 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square second. Defined as: (120.0)/((1.0)*(1.0)) × fathom per square second.
   /// </summary>
   public static readonly Acceleration CablePerSquareSecond =
            new ("cable per square second", "cb/s²", FathomPerSquareSecond, 120.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) cable per square decisecond. Defined as: (120.0)/((1.0/10.0)*(1.0/10.0)) × fathom per square second.
   /// </summary>
   public static readonly Acceleration CablePerSquareDecisecond = new (
                                                                       "cable per square decisecond"
                                                                     , "cb/ds²"
                                                                     , FathomPerSquareSecond
                                                                     , 120.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) cable per square centisecond. Defined as: (120.0)/((1.0/10.0)*(1.0/10.0)) × fathom per square decisecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareCentisecond = new (
                                                                        "cable per square centisecond"
                                                                      , "cb/cs²"
                                                                      , FathomPerSquareDecisecond
                                                                      , 120.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square millisecond. Defined as: (120.0)/((1.0/10.0)*(1.0/10.0)) × fathom per square centisecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareMillisecond = new (
                                                                        "cable per square millisecond"
                                                                      , "cb/ms²"
                                                                      , FathomPerSquareCentisecond
                                                                      , 120.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square microsecond. Defined as: (120.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square millisecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareMicrosecond = new (
                                                                        "cable per square microsecond"
                                                                      , "cb/μs²"
                                                                      , FathomPerSquareMillisecond
                                                                      , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square nanosecond. Defined as: (120.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square microsecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareNanosecond = new (
                                                                       "cable per square nanosecond"
                                                                     , "cb/ns²"
                                                                     , FathomPerSquareMicrosecond
                                                                     , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) cable per square picosecond. Defined as: (120.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square nanosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquarePicosecond = new (
                                                                       "cable per square picosecond"
                                                                     , "cb/ps²"
                                                                     , FathomPerSquareNanosecond
                                                                     , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) cable per square femtosecond. Defined as: (120.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square picosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareFemtosecond = new (
                                                                        "cable per square femtosecond"
                                                                      , "cb/fs²"
                                                                      , FathomPerSquarePicosecond
                                                                      , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square attosecond. Defined as: (120.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square femtosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareAttosecond = new (
                                                                       "cable per square attosecond"
                                                                     , "cb/as²"
                                                                     , FathomPerSquareFemtosecond
                                                                     , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) cable per square zeptosecond. Defined as: (120.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square attosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareZeptosecond = new (
                                                                        "cable per square zeptosecond"
                                                                      , "cb/zs²"
                                                                      , FathomPerSquareAttosecond
                                                                      , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square yoctosecond. Defined as: (120.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square zeptosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareYoctosecond = new (
                                                                        "cable per square yoctosecond"
                                                                      , "cb/ys²"
                                                                      , FathomPerSquareZeptosecond
                                                                      , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square rontosecond. Defined as: (120.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square yoctosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareRontosecond = new (
                                                                        "cable per square rontosecond"
                                                                      , "cb/rs²"
                                                                      , FathomPerSquareYoctosecond
                                                                      , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square quectosecond. Defined as: (120.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square rontosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareQuectosecond = new (
                                                                         "cable per square quectosecond"
                                                                       , "cb/qs²"
                                                                       , FathomPerSquareRontosecond
                                                                       , 120.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) inch per square trillion years. Defined as: (2.54)/((1000.0)*(1000.0)) × SI centimeter per square billion years.
   /// </summary>
   public static readonly Acceleration InchPerSquareTrillionYears = new (
                                                                         "inch per square trillion years"
                                                                       , "in/Tyr²"
                                                                       , SI.Accelerations
                                                                           .CentimeterPerSquareBillionYears
                                                                       , 2.54 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) nautical mile per square second. Defined as: (1852.0)/((1.0)*(1.0)) × SI meter per square second.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSecond = new (
                                                                          "nautical mile per square second"
                                                                        , "nmi/s²"
                                                                        , SI.Accelerations.MeterPerSquareSecond
                                                                        , 1852.0 / (1.0 * 1.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) nautical mile per square decisecond. Defined as: (1852.0)/((1.0/10.0)*(1.0/10.0)) × SI meter per square second.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecisecond = new (
                                                                              "nautical mile per square decisecond"
                                                                            , "nmi/ds²"
                                                                            , SI.Accelerations.MeterPerSquareSecond
                                                                            , 1852.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) nautical mile per square centisecond. Defined as: (1852.0)/((1.0/10.0)*(1.0/10.0)) × SI meter per square decisecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareCentisecond = new (
                                                                               "nautical mile per square centisecond"
                                                                             , "nmi/cs²"
                                                                             , SI.Accelerations.MeterPerSquareDecisecond
                                                                             , 1852.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square millisecond. Defined as: (1852.0)/((1.0/10.0)*(1.0/10.0)) × SI meter per square centisecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillisecond = new (
                                                                               "nautical mile per square millisecond"
                                                                             , "nmi/ms²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareCentisecond
                                                                             , 1852.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square microsecond. Defined as: (1852.0)/((1.0/1000.0)*(1.0/1000.0)) × SI meter per square millisecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMicrosecond = new (
                                                                               "nautical mile per square microsecond"
                                                                             , "nmi/μs²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareMillisecond
                                                                             , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square nanosecond. Defined as: (1852.0)/((1.0/1000.0)*(1.0/1000.0)) × SI meter per square microsecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareNanosecond = new (
                                                                              "nautical mile per square nanosecond"
                                                                            , "nmi/ns²"
                                                                            , SI.Accelerations.MeterPerSquareMicrosecond
                                                                            , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) nautical mile per square picosecond. Defined as: (1852.0)/((1.0/1000.0)*(1.0/1000.0)) × SI meter per square nanosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquarePicosecond = new (
                                                                              "nautical mile per square picosecond"
                                                                            , "nmi/ps²"
                                                                            , SI.Accelerations.MeterPerSquareNanosecond
                                                                            , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) nautical mile per square femtosecond. Defined as: (1852.0)/((1.0/1000.0)*(1.0/1000.0)) × SI meter per square picosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareFemtosecond = new (
                                                                               "nautical mile per square femtosecond"
                                                                             , "nmi/fs²"
                                                                             , SI.Accelerations.MeterPerSquarePicosecond
                                                                             , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square attosecond. Defined as: (1852.0)/((1.0/1000.0)*(1.0/1000.0)) × SI meter per square femtosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareAttosecond = new (
                                                                              "nautical mile per square attosecond"
                                                                            , "nmi/as²"
                                                                            , SI.Accelerations.MeterPerSquareFemtosecond
                                                                            , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) nautical mile per square zeptosecond. Defined as: (1852.0)/((1.0/1000.0)*(1.0/1000.0)) × SI meter per square attosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareZeptosecond = new (
                                                                               "nautical mile per square zeptosecond"
                                                                             , "nmi/zs²"
                                                                             , SI.Accelerations.MeterPerSquareAttosecond
                                                                             , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square yoctosecond. Defined as: (1852.0)/((1.0/1000.0)*(1.0/1000.0)) × SI meter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareYoctosecond = new (
                                                                               "nautical mile per square yoctosecond"
                                                                             , "nmi/ys²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareZeptosecond
                                                                             , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square rontosecond. Defined as: (1852.0)/((1.0/1000.0)*(1.0/1000.0)) × SI meter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareRontosecond = new (
                                                                               "nautical mile per square rontosecond"
                                                                             , "nmi/rs²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareYoctosecond
                                                                             , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square quectosecond. Defined as: (1852.0)/((1.0/1000.0)*(1.0/1000.0)) × SI meter per square rontosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuectosecond = new (
                                                                                "nautical mile per square quectosecond"
                                                                              , "nmi/qs²"
                                                                              , SI.Accelerations
                                                                                        .MeterPerSquareRontosecond
                                                                              , 1852.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) inch per square quadrillion years. Defined as: (2.54)/((1000.0)*(1000.0)) × SI centimeter per square trillion years.
   /// </summary>
   public static readonly Acceleration InchPerSquareQuadrillionYears = new (
                                                                            "inch per square quadrillion years"
                                                                          , "in/Pyr²"
                                                                          , SI.Accelerations
                                                                              .CentimeterPerSquareTrillionYears
                                                                          , 2.54 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) inch per square quintillion years. Defined as: (2.54)/((1000.0)*(1000.0)) × SI centimeter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration InchPerSquareQuintillionYears = new (
                                                                            "inch per square quintillion years"
                                                                          , "in/Eyr²"
                                                                          , SI.Accelerations
                                                                              .CentimeterPerSquareQuadrillionYears
                                                                          , 2.54 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) inch per square sextillion years. Defined as: (2.54)/((1000.0)*(1000.0)) × SI centimeter per square quintillion years.
   /// </summary>
   public static readonly Acceleration InchPerSquareSextillionYears = new (
                                                                           "inch per square sextillion years"
                                                                         , "in/Zyr²"
                                                                         , SI.Accelerations
                                                                             .CentimeterPerSquareQuintillionYears
                                                                         , 2.54 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) inch per square septillion years. Defined as: (2.54)/((1000.0)*(1000.0)) × SI centimeter per square sextillion years.
   /// </summary>
   public static readonly Acceleration InchPerSquareSeptillionYears = new (
                                                                           "inch per square septillion years"
                                                                         , "in/Yyr²"
                                                                         , SI.Accelerations
                                                                             .CentimeterPerSquareSextillionYears
                                                                         , 2.54 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) inch per square octillion years. Defined as: (2.54)/((1000.0)*(1000.0)) × SI centimeter per square septillion years.
   /// </summary>
   public static readonly Acceleration InchPerSquareOctillionYears = new (
                                                                          "inch per square octillion years"
                                                                        , "in/Ryr²"
                                                                        , SI.Accelerations
                                                                            .CentimeterPerSquareSeptillionYears
                                                                        , 2.54 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) inch per square nonillion years. Defined as: (2.54)/((1000.0)*(1000.0)) × SI centimeter per square octillion years.
   /// </summary>
   public static readonly Acceleration InchPerSquareNonillionYears = new (
                                                                          "inch per square nonillion years"
                                                                        , "in/Qyr²"
                                                                        , SI.Accelerations
                                                                            .CentimeterPerSquareOctillionYears
                                                                        , 2.54 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) inch per square decillion years. Defined as: (2.54)/((1000.0)*(1000.0)) × SI centimeter per square nonillion years.
   /// </summary>
   public static readonly Acceleration InchPerSquareDecillionYears = new (
                                                                          "inch per square decillion years"
                                                                        , "in/decillion yr²"
                                                                        , SI.Accelerations
                                                                            .CentimeterPerSquareNonillionYears
                                                                        , 2.54 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) inch per square planck-time. Defined as: (2.54)/((5.391247E-38)*(5.391247E-38)) × SI centimeter per square microsecond.
   /// </summary>
   public static readonly Acceleration InchPerSquarePlanckTime = new (
                                                                      "inch per square planck-time"
                                                                    , "in/tₚ²"
                                                                    , SI.Accelerations.CentimeterPerSquareMicrosecond
                                                                    , 2.54 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) inch per square tick. Defined as: (2.54)/((100.0)*(100.0)) × SI centimeter per square nanosecond.
   /// </summary>
   public static readonly Acceleration InchPerSquareTick = new (
                                                                "inch per square tick"
                                                              , "in/tick²"
                                                              , SI.Accelerations.CentimeterPerSquareNanosecond
                                                              , 2.54 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) mil per square planck-time. Defined as: (1.0/1000.0)/((5.391247E-38)*(5.391247E-38)) × inch per square microsecond.
   /// </summary>
   public static readonly Acceleration MilPerSquarePlanckTime = new (
                                                                     "mil per square planck-time"
                                                                   , "mil/tₚ²"
                                                                   , InchPerSquareMicrosecond
                                                                   , 1.0 / 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) mil per square minute. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration MilPerSquareMinute = new (
                                                                 "mil per square minute"
                                                               , "mil/min²"
                                                               , InchPerSquareSecond
                                                               , 1.0 / 1000.0 / (60.0 * 60.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) point per square planck-time. Defined as: (1.0/72.0)/((5.391247E-38)*(5.391247E-38)) × inch per square microsecond.
   /// </summary>
   public static readonly Acceleration PointPerSquarePlanckTime = new (
                                                                       "point per square planck-time"
                                                                     , "p/tₚ²"
                                                                     , InchPerSquareMicrosecond
                                                                     , 1.0 / 72.0 / (5.391247E-38 * 5.391247E-38)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square septillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × inch per square sextillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareSeptillionYears = new (
                                                                           "foot per square septillion years"
                                                                         , "ft/Yyr²"
                                                                         , InchPerSquareSextillionYears
                                                                         , 12.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) twip per square tick. Defined as: (1.0/20.0)/((100.0)*(100.0)) × point per square nanosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareTick = new (
                                                                "twip per square tick"
                                                              , "twip/tick²"
                                                              , PointPerSquareNanosecond
                                                              , 1.0 / 20.0 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) foot per square week. Defined as: (12.0)/((7.0)*(7.0)) × inch per square day.
   /// </summary>
   public static readonly Acceleration FootPerSquareWeek = new (
                                                                "foot per square week"
                                                              , "ft/wk²"
                                                              , InchPerSquareDay
                                                              , 12.0 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) point per square billion years. Defined as: (1.0/72.0)/((1000.0)*(1000.0)) × inch per square million years.
   /// </summary>
   public static readonly Acceleration PointPerSquareBillionYears = new (
                                                                         "point per square billion years"
                                                                       , "p/Gyr²"
                                                                       , InchPerSquareMillionYears
                                                                       , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) twip per square planck-time. Defined as: (1.0/20.0)/((5.391247E-38)*(5.391247E-38)) × point per square microsecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquarePlanckTime = new (
                                                                      "twip per square planck-time"
                                                                    , "twip/tₚ²"
                                                                    , PointPerSquareMicrosecond
                                                                    , 1.0 / 20.0 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mil per square hour. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × inch per square minute.
   /// </summary>
   public static readonly Acceleration MilPerSquareHour = new (
                                                               "mil per square hour"
                                                             , "mil/hr²"
                                                             , InchPerSquareMinute
                                                             , 1.0 / 1000.0 / (60.0 * 60.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) point per square minute. Defined as: (1.0/72.0)/((60.0)*(60.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration PointPerSquareMinute = new (
                                                                   "point per square minute"
                                                                 , "p/min²"
                                                                 , InchPerSquareSecond
                                                                 , 1.0 / 72.0 / (60.0 * 60.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) pica per square planck-time. Defined as: (12.0)/((5.391247E-38)*(5.391247E-38)) × point per square microsecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquarePlanckTime = new (
                                                                      "pica per square planck-time"
                                                                    , "P/tₚ²"
                                                                    , PointPerSquareMicrosecond
                                                                    , 12.0 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yard per square tick. Defined as: (3.0)/((100.0)*(100.0)) × foot per square nanosecond.
   /// </summary>
   public static readonly Acceleration YardPerSquareTick = new (
                                                                "yard per square tick"
                                                              , "yd/tick²"
                                                              , FootPerSquareNanosecond
                                                              , 3.0 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) nautical mile per square nonillion years. Defined as: (1852.0)/((1000.0)*(1000.0)) × SI meter per square octillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareNonillionYears = new (
       "nautical mile per square nonillion years"
     , "nmi/Qyr²"
     , SI.Accelerations.MeterPerSquareOctillionYears
     , 1852.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) foot per square planck-time. Defined as: (12.0)/((5.391247E-38)*(5.391247E-38)) × inch per square microsecond.
   /// </summary>
   public static readonly Acceleration FootPerSquarePlanckTime = new (
                                                                      "foot per square planck-time"
                                                                    , "ft/tₚ²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 12.0 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) nautical mile per square quadrillion years. Defined as: (1852.0)/((1000.0)*(1000.0)) × SI meter per square trillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuadrillionYears = new (
       "nautical mile per square quadrillion years"
     , "nmi/Pyr²"
     , SI.Accelerations.MeterPerSquareTrillionYears
     , 1852.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) mil per square day. Defined as: (1.0/1000.0)/((24.0)*(24.0)) × inch per square hour.
   /// </summary>
   public static readonly Acceleration MilPerSquareDay = new (
                                                              "mil per square day"
                                                            , "mil/dy²"
                                                            , InchPerSquareHour
                                                            , 1.0 / 1000.0 / (24.0 * 24.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) twip per square minute. Defined as: (1.0/20.0)/((60.0)*(60.0)) × point per square second.
   /// </summary>
   public static readonly Acceleration TwipPerSquareMinute = new (
                                                                  "twip per square minute"
                                                                , "twip/min²"
                                                                , PointPerSquareSecond
                                                                , 1.0 / 20.0 / (60.0 * 60.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) foot per square millennium. Defined as: (12.0)/((10.0)*(10.0)) × inch per square century.
   /// </summary>
   public static readonly Acceleration FootPerSquareMillennium = new (
                                                                      "foot per square millennium"
                                                                    , "ft/kyr²"
                                                                    , InchPerSquareCentury
                                                                    , 12.0 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) nautical mile per square century. Defined as: (1852.0)/((10.0)*(10.0)) × SI meter per square decade.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareCentury = new (
                                                                           "nautical mile per square century"
                                                                         , "nmi/century²"
                                                                         , SI.Accelerations.MeterPerSquareDecade
                                                                         , 1852.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) yard per square planck-time. Defined as: (3.0)/((5.391247E-38)*(5.391247E-38)) × foot per square microsecond.
   /// </summary>
   public static readonly Acceleration YardPerSquarePlanckTime = new (
                                                                      "yard per square planck-time"
                                                                    , "yd/tₚ²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 3.0 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) point per square trillion years. Defined as: (1.0/72.0)/((1000.0)*(1000.0)) × inch per square billion years.
   /// </summary>
   public static readonly Acceleration PointPerSquareTrillionYears = new (
                                                                          "point per square trillion years"
                                                                        , "p/Tyr²"
                                                                        , InchPerSquareBillionYears
                                                                        , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) nautical mile per square hour. Defined as: (1852.0)/((60.0)*(60.0)) × SI meter per square minute.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareHour = new (
                                                                        "nautical mile per square hour"
                                                                      , "nmi/hr²"
                                                                      , SI.Accelerations.MeterPerSquareMinute
                                                                      , 1852.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square tick. Defined as: (2.0)/((100.0)*(100.0)) × yard per square nanosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareTick = new (
                                                                  "fathom per square tick"
                                                                , "ftm/tick²"
                                                                , YardPerSquareNanosecond
                                                                , 2.0 / (100.0 * 100.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yard per square octillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × foot per square septillion years.
   /// </summary>
   public static readonly Acceleration YardPerSquareOctillionYears = new (
                                                                          "yard per square octillion years"
                                                                        , "yd/Ryr²"
                                                                        , FootPerSquareSeptillionYears
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) mile per square planck-time. Defined as: (1760.0)/((5.391247E-38)*(5.391247E-38)) × yard per square microsecond.
   /// </summary>
   public static readonly Acceleration MilePerSquarePlanckTime = new (
                                                                      "mile per square planck-time"
                                                                    , "mi/tₚ²"
                                                                    , YardPerSquareMicrosecond
                                                                    , 1760.0 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) point per square hour. Defined as: (1.0/72.0)/((60.0)*(60.0)) × inch per square minute.
   /// </summary>
   public static readonly Acceleration PointPerSquareHour = new (
                                                                 "point per square hour"
                                                               , "p/hr²"
                                                               , InchPerSquareMinute
                                                               , 1.0 / 72.0 / (60.0 * 60.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) mil per square week. Defined as: (1.0/1000.0)/((7.0)*(7.0)) × inch per square day.
   /// </summary>
   public static readonly Acceleration MilPerSquareWeek = new (
                                                               "mil per square week"
                                                             , "mil/wk²"
                                                             , InchPerSquareDay
                                                             , 1.0 / 1000.0 / (7.0 * 7.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) pica per square minute. Defined as: (12.0)/((60.0)*(60.0)) × point per square second.
   /// </summary>
   public static readonly Acceleration PicaPerSquareMinute = new (
                                                                  "pica per square minute"
                                                                , "P/min²"
                                                                , PointPerSquareSecond
                                                                , 12.0 / (60.0 * 60.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) league per square planck-time. Defined as: (3.0)/((5.391247E-38)*(5.391247E-38)) × mile per square microsecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePlanckTime = new (
                                                                        "league per square planck-time"
                                                                      , "le/tₚ²"
                                                                      , MilePerSquareMicrosecond
                                                                      , 3.0 / (5.391247E-38 * 5.391247E-38)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) foot per square quadrillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × inch per square trillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareQuadrillionYears = new (
                                                                            "foot per square quadrillion years"
                                                                          , "ft/Pyr²"
                                                                          , InchPerSquareTrillionYears
                                                                          , 12.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) fathom per square planck-time. Defined as: (2.0)/((5.391247E-38)*(5.391247E-38)) × yard per square microsecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquarePlanckTime = new (
                                                                        "fathom per square planck-time"
                                                                      , "ftm/tₚ²"
                                                                      , YardPerSquareMicrosecond
                                                                      , 2.0 / (5.391247E-38 * 5.391247E-38)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) mil per square year. Defined as: (1.0/1000.0)/((365.2525)*(365.2525)) × inch per square day.
   /// </summary>
   public static readonly Acceleration MilPerSquareYear = new (
                                                               "mil per square year"
                                                             , "mil/yr²"
                                                             , InchPerSquareDay
                                                             , 1.0 / 1000.0 / (365.2525 * 365.2525)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) foot per square minute. Defined as: (12.0)/((60.0)*(60.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration FootPerSquareMinute = new (
                                                                  "foot per square minute"
                                                                , "ft/min²"
                                                                , InchPerSquareSecond
                                                                , 12.0 / (60.0 * 60.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) fathom per square nonillion years. Defined as: (2.0)/((1000.0)*(1000.0)) × yard per square octillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareNonillionYears = new (
                                                                            "fathom per square nonillion years"
                                                                          , "ftm/Qyr²"
                                                                          , YardPerSquareOctillionYears
                                                                          , 2.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) cable per square planck-time. Defined as: (120.0)/((5.391247E-38)*(5.391247E-38)) × fathom per square microsecond.
   /// </summary>
   public static readonly Acceleration CablePerSquarePlanckTime = new (
                                                                       "cable per square planck-time"
                                                                     , "cb/tₚ²"
                                                                     , FathomPerSquareMicrosecond
                                                                     , 120.0 / (5.391247E-38 * 5.391247E-38)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) point per square quadrillion years. Defined as: (1.0/72.0)/((1000.0)*(1000.0)) × inch per square trillion years.
   /// </summary>
   public static readonly Acceleration PointPerSquareQuadrillionYears = new (
                                                                             "point per square quadrillion years"
                                                                           , "p/Pyr²"
                                                                           , InchPerSquareTrillionYears
                                                                           , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) point per square day. Defined as: (1.0/72.0)/((24.0)*(24.0)) × inch per square hour.
   /// </summary>
   public static readonly Acceleration PointPerSquareDay = new (
                                                                "point per square day"
                                                              , "p/dy²"
                                                              , InchPerSquareHour
                                                              , 1.0 / 72.0 / (24.0 * 24.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) twip per square hour. Defined as: (1.0/20.0)/((60.0)*(60.0)) × point per square minute.
   /// </summary>
   public static readonly Acceleration TwipPerSquareHour = new (
                                                                "twip per square hour"
                                                              , "twip/hr²"
                                                              , PointPerSquareMinute
                                                              , 1.0 / 20.0 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) mil per square decade. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × inch per square year.
   /// </summary>
   public static readonly Acceleration MilPerSquareDecade = new (
                                                                 "mil per square decade"
                                                               , "mil/decade²"
                                                               , InchPerSquareYear
                                                               , 1.0 / 1000.0 / (10.0 * 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) yard per square minute. Defined as: (3.0)/((60.0)*(60.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration YardPerSquareMinute =
            new ("yard per square minute", "yd/min²", FootPerSquareSecond, 3.0 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) nautical mile per square planck-time. Defined as: (1852.0)/((5.391247E-38)*(5.391247E-38)) × SI meter per square microsecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquarePlanckTime = new (
                                                                              "nautical mile per square planck-time"
                                                                            , "nmi/tₚ²"
                                                                            , SI.Accelerations.MeterPerSquareMicrosecond
                                                                            , 1852.0 / (5.391247E-38 * 5.391247E-38)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) foot per square octillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × inch per square septillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareOctillionYears = new (
                                                                          "foot per square octillion years"
                                                                        , "ft/Ryr²"
                                                                        , InchPerSquareSeptillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) nautical mile per square sextillion years. Defined as: (1852.0)/((1000.0)*(1000.0)) × SI meter per square quintillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSextillionYears = new (
       "nautical mile per square sextillion years"
     , "nmi/Zyr²"
     , SI.Accelerations.MeterPerSquareQuintillionYears
     , 1852.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) foot per square year. Defined as: (12.0)/((365.2525)*(365.2525)) × inch per square day.
   /// </summary>
   public static readonly Acceleration FootPerSquareYear = new (
                                                                "foot per square year"
                                                              , "ft/yr²"
                                                              , InchPerSquareDay
                                                              , 12.0 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) mil per square tick. Defined as: (1.0/1000.0)/((100.0)*(100.0)) × inch per square nanosecond.
   /// </summary>
   public static readonly Acceleration MilPerSquareTick = new (
                                                               "mil per square tick"
                                                             , "mil/tick²"
                                                             , InchPerSquareNanosecond
                                                             , 1.0 / 1000.0 / (100.0 * 100.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) nautical mile per square million years. Defined as: (1852.0)/((1000.0)*(1000.0)) × SI meter per square millennium.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillionYears = new (
                                                                                "nautical mile per square million years"
                                                                              , "nmi/Myr²"
                                                                              , SI.Accelerations
                                                                                        .MeterPerSquareMillennium
                                                                              , 1852.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) mil per square century. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × inch per square decade.
   /// </summary>
   public static readonly Acceleration MilPerSquareCentury = new (
                                                                  "mil per square century"
                                                                , "mil/century²"
                                                                , InchPerSquareDecade
                                                                , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) mile per square minute. Defined as: (1760.0)/((60.0)*(60.0)) × yard per square second.
   /// </summary>
   public static readonly Acceleration MilePerSquareMinute = new (
                                                                  "mile per square minute"
                                                                , "mi/min²"
                                                                , YardPerSquareSecond
                                                                , 1760.0 / (60.0 * 60.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) pica per square trillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × point per square billion years.
   /// </summary>
   public static readonly Acceleration PicaPerSquareTrillionYears = new (
                                                                         "pica per square trillion years"
                                                                       , "P/Tyr²"
                                                                       , PointPerSquareBillionYears
                                                                       , 12.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) nautical mile per square week. Defined as: (1852.0)/((7.0)*(7.0)) × SI meter per square day.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareWeek = new (
                                                                        "nautical mile per square week"
                                                                      , "nmi/wk²"
                                                                      , SI.Accelerations.MeterPerSquareDay
                                                                      , 1852.0 / (7.0 * 7.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) point per square quintillion years. Defined as: (1.0/72.0)/((1000.0)*(1000.0)) × inch per square quadrillion years.
   /// </summary>
   public static readonly Acceleration PointPerSquareQuintillionYears = new (
                                                                             "point per square quintillion years"
                                                                           , "p/Eyr²"
                                                                           , InchPerSquareQuadrillionYears
                                                                           , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) pica per square tick. Defined as: (12.0)/((100.0)*(100.0)) × point per square nanosecond.
   /// </summary>
   public static readonly Acceleration PicaPerSquareTick = new (
                                                                "pica per square tick"
                                                              , "P/tick²"
                                                              , PointPerSquareNanosecond
                                                              , 12.0 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) point per square week. Defined as: (1.0/72.0)/((7.0)*(7.0)) × inch per square day.
   /// </summary>
   public static readonly Acceleration PointPerSquareWeek =
            new ("point per square week", "p/wk²", InchPerSquareDay, 1.0 / 72.0 / (7.0 * 7.0), 0);

   /// <summary>
   /// A(n) pica per square hour. Defined as: (12.0)/((60.0)*(60.0)) × point per square minute.
   /// </summary>
   public static readonly Acceleration PicaPerSquareHour = new (
                                                                "pica per square hour"
                                                              , "P/hr²"
                                                              , PointPerSquareMinute
                                                              , 12.0 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) mil per square millennium. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × inch per square century.
   /// </summary>
   public static readonly Acceleration MilPerSquareMillennium = new (
                                                                     "mil per square millennium"
                                                                   , "mil/kyr²"
                                                                   , InchPerSquareCentury
                                                                   , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) league per square minute. Defined as: (3.0)/((60.0)*(60.0)) × mile per square second.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMinute =
            new ("league per square minute", "le/min²", MilePerSquareSecond, 3.0 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) foot per square million years. Defined as: (12.0)/((1000.0)*(1000.0)) × inch per square millennium.
   /// </summary>
   public static readonly Acceleration FootPerSquareMillionYears = new (
                                                                        "foot per square million years"
                                                                      , "ft/Myr²"
                                                                      , InchPerSquareMillennium
                                                                      , 12.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) mile per square nonillion years. Defined as: (1760.0)/((1000.0)*(1000.0)) × yard per square octillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareNonillionYears = new (
                                                                          "mile per square nonillion years"
                                                                        , "mi/Qyr²"
                                                                        , YardPerSquareOctillionYears
                                                                        , 1760.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) mile per square tick. Defined as: (1760.0)/((100.0)*(100.0)) × yard per square nanosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareTick = new (
                                                                "mile per square tick"
                                                              , "mi/tick²"
                                                              , YardPerSquareNanosecond
                                                              , 1760.0 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) twip per square day. Defined as: (1.0/20.0)/((24.0)*(24.0)) × point per square hour.
   /// </summary>
   public static readonly Acceleration TwipPerSquareDay = new (
                                                               "twip per square day"
                                                             , "twip/dy²"
                                                             , PointPerSquareHour
                                                             , 1.0 / 20.0 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) mil per square million years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × inch per square millennium.
   /// </summary>
   public static readonly Acceleration MilPerSquareMillionYears = new (
                                                                       "mil per square million years"
                                                                     , "mil/Myr²"
                                                                     , InchPerSquareMillennium
                                                                     , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) fathom per square minute. Defined as: (2.0)/((60.0)*(60.0)) × yard per square second.
   /// </summary>
   public static readonly Acceleration FathomPerSquareMinute = new (
                                                                    "fathom per square minute"
                                                                  , "ftm/min²"
                                                                  , YardPerSquareSecond
                                                                  , 2.0 / (60.0 * 60.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) point per square sextillion years. Defined as: (1.0/72.0)/((1000.0)*(1000.0)) × inch per square quintillion years.
   /// </summary>
   public static readonly Acceleration PointPerSquareSextillionYears = new (
                                                                            "point per square sextillion years"
                                                                          , "p/Zyr²"
                                                                          , InchPerSquareQuintillionYears
                                                                          , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) foot per square quintillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × inch per square quadrillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareQuintillionYears = new (
                                                                            "foot per square quintillion years"
                                                                          , "ft/Eyr²"
                                                                          , InchPerSquareQuadrillionYears
                                                                          , 12.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yard per square nonillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × foot per square octillion years.
   /// </summary>
   public static readonly Acceleration YardPerSquareNonillionYears = new (
                                                                          "yard per square nonillion years"
                                                                        , "yd/Qyr²"
                                                                        , FootPerSquareOctillionYears
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) point per square year. Defined as: (1.0/72.0)/((365.2525)*(365.2525)) × inch per square day.
   /// </summary>
   public static readonly Acceleration PointPerSquareYear = new (
                                                                 "point per square year"
                                                               , "p/yr²"
                                                               , InchPerSquareDay
                                                               , 1.0 / 72.0 / (365.2525 * 365.2525)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) foot per square hour. Defined as: (12.0)/((60.0)*(60.0)) × inch per square minute.
   /// </summary>
   public static readonly Acceleration FootPerSquareHour = new (
                                                                "foot per square hour"
                                                              , "ft/hr²"
                                                              , InchPerSquareMinute
                                                              , 12.0 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) mil per square billion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × inch per square million years.
   /// </summary>
   public static readonly Acceleration MilPerSquareBillionYears = new (
                                                                       "mil per square billion years"
                                                                     , "mil/Gyr²"
                                                                     , InchPerSquareMillionYears
                                                                     , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) cable per square minute. Defined as: (120.0)/((60.0)*(60.0)) × fathom per square second.
   /// </summary>
   public static readonly Acceleration CablePerSquareMinute = new (
                                                                   "cable per square minute"
                                                                 , "cb/min²"
                                                                 , FathomPerSquareSecond
                                                                 , 120.0 / (60.0 * 60.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) cable per square tick. Defined as: (120.0)/((100.0)*(100.0)) × fathom per square nanosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareTick = new (
                                                                 "cable per square tick"
                                                               , "cb/tick²"
                                                               , FathomPerSquareNanosecond
                                                               , 120.0 / (100.0 * 100.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) yard per square sextillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × foot per square quintillion years.
   /// </summary>
   public static readonly Acceleration YardPerSquareSextillionYears = new (
                                                                           "yard per square sextillion years"
                                                                         , "yd/Zyr²"
                                                                         , FootPerSquareQuintillionYears
                                                                         , 3.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) mil per square trillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × inch per square billion years.
   /// </summary>
   public static readonly Acceleration MilPerSquareTrillionYears = new (
                                                                        "mil per square trillion years"
                                                                      , "mil/Tyr²"
                                                                      , InchPerSquareBillionYears
                                                                      , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) pica per square quadrillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × point per square trillion years.
   /// </summary>
   public static readonly Acceleration PicaPerSquareQuadrillionYears = new (
                                                                            "pica per square quadrillion years"
                                                                          , "P/Pyr²"
                                                                          , PointPerSquareTrillionYears
                                                                          , 12.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) foot per square nonillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × inch per square octillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareNonillionYears = new (
                                                                          "foot per square nonillion years"
                                                                        , "ft/Qyr²"
                                                                        , InchPerSquareOctillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) foot per square decade. Defined as: (12.0)/((10.0)*(10.0)) × inch per square year.
   /// </summary>
   public static readonly Acceleration FootPerSquareDecade = new (
                                                                  "foot per square decade"
                                                                , "ft/decade²"
                                                                , InchPerSquareYear
                                                                , 12.0 / (10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) point per square septillion years. Defined as: (1.0/72.0)/((1000.0)*(1000.0)) × inch per square sextillion years.
   /// </summary>
   public static readonly Acceleration PointPerSquareSeptillionYears = new (
                                                                            "point per square septillion years"
                                                                          , "p/Yyr²"
                                                                          , InchPerSquareSextillionYears
                                                                          , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) twip per square week. Defined as: (1.0/20.0)/((7.0)*(7.0)) × point per square day.
   /// </summary>
   public static readonly Acceleration TwipPerSquareWeek = new (
                                                                "twip per square week"
                                                              , "twip/wk²"
                                                              , PointPerSquareDay
                                                              , 1.0 / 20.0 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) pica per square day. Defined as: (12.0)/((24.0)*(24.0)) × point per square hour.
   /// </summary>
   public static readonly Acceleration PicaPerSquareDay = new (
                                                               "pica per square day"
                                                             , "P/dy²"
                                                             , PointPerSquareHour
                                                             , 12.0 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) point per square decade. Defined as: (1.0/72.0)/((10.0)*(10.0)) × inch per square year.
   /// </summary>
   public static readonly Acceleration PointPerSquareDecade = new (
                                                                   "point per square decade"
                                                                 , "p/decade²"
                                                                 , InchPerSquareYear
                                                                 , 1.0 / 72.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yard per square hour. Defined as: (3.0)/((60.0)*(60.0)) × foot per square minute.
   /// </summary>
   public static readonly Acceleration YardPerSquareHour = new (
                                                                "yard per square hour"
                                                              , "yd/hr²"
                                                              , FootPerSquareMinute
                                                              , 3.0 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) mil per square quadrillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × inch per square trillion years.
   /// </summary>
   public static readonly Acceleration MilPerSquareQuadrillionYears = new (
                                                                           "mil per square quadrillion years"
                                                                         , "mil/Pyr²"
                                                                         , InchPerSquareTrillionYears
                                                                         , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) mile per square septillion years. Defined as: (1760.0)/((1000.0)*(1000.0)) × yard per square sextillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareSeptillionYears = new (
                                                                           "mile per square septillion years"
                                                                         , "mi/Yyr²"
                                                                         , YardPerSquareSextillionYears
                                                                         , 1760.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) mil per square quintillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × inch per square quadrillion years.
   /// </summary>
   public static readonly Acceleration MilPerSquareQuintillionYears = new (
                                                                           "mil per square quintillion years"
                                                                         , "mil/Eyr²"
                                                                         , InchPerSquareQuadrillionYears
                                                                         , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) foot per square billion years. Defined as: (12.0)/((1000.0)*(1000.0)) × inch per square million years.
   /// </summary>
   public static readonly Acceleration FootPerSquareBillionYears = new (
                                                                        "foot per square billion years"
                                                                      , "ft/Gyr²"
                                                                      , InchPerSquareMillionYears
                                                                      , 12.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) point per square tick. Defined as: (1.0/72.0)/((100.0)*(100.0)) × inch per square nanosecond.
   /// </summary>
   public static readonly Acceleration PointPerSquareTick = new (
                                                                 "point per square tick"
                                                               , "p/tick²"
                                                               , InchPerSquareNanosecond
                                                               , 1.0 / 72.0 / (100.0 * 100.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) point per square octillion years. Defined as: (1.0/72.0)/((1000.0)*(1000.0)) × inch per square septillion years.
   /// </summary>
   public static readonly Acceleration PointPerSquareOctillionYears = new (
                                                                           "point per square octillion years"
                                                                         , "p/Ryr²"
                                                                         , InchPerSquareSeptillionYears
                                                                         , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) cable per square decillion years. Defined as: (120.0)/((1000.0)*(1000.0)) × fathom per square nonillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareDecillionYears = new (
                                                                           "cable per square decillion years"
                                                                         , "cb/decillion yr²"
                                                                         , FathomPerSquareNonillionYears
                                                                         , 120.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) point per square century. Defined as: (1.0/72.0)/((10.0)*(10.0)) × inch per square decade.
   /// </summary>
   public static readonly Acceleration PointPerSquareCentury = new (
                                                                    "point per square century"
                                                                  , "p/century²"
                                                                  , InchPerSquareDecade
                                                                  , 1.0 / 72.0 / (10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) mile per square hour. Defined as: (1760.0)/((60.0)*(60.0)) × yard per square minute.
   /// </summary>
   public static readonly Acceleration MilePerSquareHour = new (
                                                                "mile per square hour"
                                                              , "mi/hr²"
                                                              , YardPerSquareMinute
                                                              , 1760.0 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) mil per square sextillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × inch per square quintillion years.
   /// </summary>
   public static readonly Acceleration MilPerSquareSextillionYears = new (
                                                                          "mil per square sextillion years"
                                                                        , "mil/Zyr²"
                                                                        , InchPerSquareQuintillionYears
                                                                        , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) twip per square nonillion years. Defined as: (1.0/20.0)/((1000.0)*(1000.0)) × point per square octillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareNonillionYears = new (
                                                                          "twip per square nonillion years"
                                                                        , "twip/Qyr²"
                                                                        , PointPerSquareOctillionYears
                                                                        , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) foot per square tick. Defined as: (12.0)/((100.0)*(100.0)) × inch per square nanosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareTick = new (
                                                                "foot per square tick"
                                                              , "ft/tick²"
                                                              , InchPerSquareNanosecond
                                                              , 12.0 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) fathom per square decillion years. Defined as: (2.0)/((1000.0)*(1000.0)) × yard per square nonillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecillionYears = new (
                                                                            "fathom per square decillion years"
                                                                          , "ftm/decillion yr²"
                                                                          , YardPerSquareNonillionYears
                                                                          , 2.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) twip per square trillion years. Defined as: (1.0/20.0)/((1000.0)*(1000.0)) × point per square billion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareTrillionYears = new (
                                                                         "twip per square trillion years"
                                                                       , "twip/Tyr²"
                                                                       , PointPerSquareBillionYears
                                                                       , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) foot per square sextillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × inch per square quintillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareSextillionYears = new (
                                                                           "foot per square sextillion years"
                                                                         , "ft/Zyr²"
                                                                         , InchPerSquareQuintillionYears
                                                                         , 12.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) league per square decillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square nonillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecillionYears = new (
                                                                            "league per square decillion years"
                                                                          , "le/decillion yr²"
                                                                          , MilePerSquareNonillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) twip per square year. Defined as: (1.0/20.0)/((365.2525)*(365.2525)) × point per square day.
   /// </summary>
   public static readonly Acceleration TwipPerSquareYear = new (
                                                                "twip per square year"
                                                              , "twip/yr²"
                                                              , PointPerSquareDay
                                                              , 1.0 / 20.0 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) foot per square day. Defined as: (12.0)/((24.0)*(24.0)) × inch per square hour.
   /// </summary>
   public static readonly Acceleration FootPerSquareDay = new (
                                                               "foot per square day"
                                                             , "ft/dy²"
                                                             , InchPerSquareHour
                                                             , 12.0 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) mil per square septillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × inch per square sextillion years.
   /// </summary>
   public static readonly Acceleration MilPerSquareSeptillionYears = new (
                                                                          "mil per square septillion years"
                                                                        , "mil/Yyr²"
                                                                        , InchPerSquareSextillionYears
                                                                        , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) pica per square quintillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × point per square quadrillion years.
   /// </summary>
   public static readonly Acceleration PicaPerSquareQuintillionYears = new (
                                                                            "pica per square quintillion years"
                                                                          , "P/Eyr²"
                                                                          , PointPerSquareQuadrillionYears
                                                                          , 12.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) mile per square decillion years. Defined as: (1760.0)/((1000.0)*(1000.0)) × yard per square nonillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareDecillionYears = new (
                                                                          "mile per square decillion years"
                                                                        , "mi/decillion yr²"
                                                                        , YardPerSquareNonillionYears
                                                                        , 1760.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) league per square tick. Defined as: (3.0)/((100.0)*(100.0)) × mile per square nanosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTick = new (
                                                                  "league per square tick"
                                                                , "le/tick²"
                                                                , MilePerSquareNanosecond
                                                                , 3.0 / (100.0 * 100.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) point per square nonillion years. Defined as: (1.0/72.0)/((1000.0)*(1000.0)) × inch per square octillion years.
   /// </summary>
   public static readonly Acceleration PointPerSquareNonillionYears = new (
                                                                           "point per square nonillion years"
                                                                         , "p/Qyr²"
                                                                         , InchPerSquareOctillionYears
                                                                         , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) yard per square decillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × foot per square nonillion years.
   /// </summary>
   public static readonly Acceleration YardPerSquareDecillionYears = new (
                                                                          "yard per square decillion years"
                                                                        , "yd/decillion yr²"
                                                                        , FootPerSquareNonillionYears
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) pica per square week. Defined as: (12.0)/((7.0)*(7.0)) × point per square day.
   /// </summary>
   public static readonly Acceleration PicaPerSquareWeek = new (
                                                                "pica per square week"
                                                              , "P/wk²"
                                                              , PointPerSquareDay
                                                              , 12.0 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) point per square millennium. Defined as: (1.0/72.0)/((10.0)*(10.0)) × inch per square century.
   /// </summary>
   public static readonly Acceleration PointPerSquareMillennium = new (
                                                                       "point per square millennium"
                                                                     , "p/kyr²"
                                                                     , InchPerSquareCentury
                                                                     , 1.0 / 72.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) league per square hour. Defined as: (3.0)/((60.0)*(60.0)) × mile per square minute.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareHour =
            new ("league per square hour", "le/hr²", MilePerSquareMinute, 3.0 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) mil per square octillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × inch per square septillion years.
   /// </summary>
   public static readonly Acceleration MilPerSquareOctillionYears = new (
                                                                         "mil per square octillion years"
                                                                       , "mil/Ryr²"
                                                                       , InchPerSquareSeptillionYears
                                                                       , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) yard per square septillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × foot per square sextillion years.
   /// </summary>
   public static readonly Acceleration YardPerSquareSeptillionYears = new (
                                                                           "yard per square septillion years"
                                                                         , "yd/Yyr²"
                                                                         , FootPerSquareSextillionYears
                                                                         , 3.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) foot per square decillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × inch per square nonillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareDecillionYears = new (
                                                                          "foot per square decillion years"
                                                                        , "ft/decillion yr²"
                                                                        , InchPerSquareNonillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) foot per square century. Defined as: (12.0)/((10.0)*(10.0)) × inch per square decade.
   /// </summary>
   public static readonly Acceleration FootPerSquareCentury = new (
                                                                   "foot per square century"
                                                                 , "ft/century²"
                                                                 , InchPerSquareDecade
                                                                 , 12.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) pica per square decillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × point per square nonillion years.
   /// </summary>
   public static readonly Acceleration PicaPerSquareDecillionYears = new (
                                                                          "pica per square decillion years"
                                                                        , "P/decillion yr²"
                                                                        , PointPerSquareNonillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) mil per square nonillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × inch per square octillion years.
   /// </summary>
   public static readonly Acceleration MilPerSquareNonillionYears = new (
                                                                         "mil per square nonillion years"
                                                                       , "mil/Qyr²"
                                                                       , InchPerSquareOctillionYears
                                                                       , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) yard per square million years. Defined as: (3.0)/((1000.0)*(1000.0)) × foot per square millennium.
   /// </summary>
   public static readonly Acceleration YardPerSquareMillionYears = new (
                                                                        "yard per square million years"
                                                                      , "yd/Myr²"
                                                                      , FootPerSquareMillennium
                                                                      , 3.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) twip per square decillion years. Defined as: (1.0/20.0)/((1000.0)*(1000.0)) × point per square nonillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecillionYears = new (
                                                                          "twip per square decillion years"
                                                                        , "twip/decillion yr²"
                                                                        , PointPerSquareNonillionYears
                                                                        , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) league per square octillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square septillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareOctillionYears = new (
                                                                            "league per square octillion years"
                                                                          , "le/Ryr²"
                                                                          , MilePerSquareSeptillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yard per square decade. Defined as: (3.0)/((10.0)*(10.0)) × foot per square year.
   /// </summary>
   public static readonly Acceleration YardPerSquareDecade = new (
                                                                  "yard per square decade"
                                                                , "yd/decade²"
                                                                , FootPerSquareYear
                                                                , 3.0 / (10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) pica per square million years. Defined as: (12.0)/((1000.0)*(1000.0)) × point per square millennium.
   /// </summary>
   public static readonly Acceleration PicaPerSquareMillionYears = new (
                                                                        "pica per square million years"
                                                                      , "P/Myr²"
                                                                      , PointPerSquareMillennium
                                                                      , 12.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) twip per square quadrillion years. Defined as: (1.0/20.0)/((1000.0)*(1000.0)) × point per square trillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuadrillionYears = new (
                                                                            "twip per square quadrillion years"
                                                                          , "twip/Pyr²"
                                                                          , PointPerSquareTrillionYears
                                                                          , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) point per square decillion years. Defined as: (1.0/72.0)/((1000.0)*(1000.0)) × inch per square nonillion years.
   /// </summary>
   public static readonly Acceleration PointPerSquareDecillionYears = new (
                                                                           "point per square decillion years"
                                                                         , "p/decillion yr²"
                                                                         , InchPerSquareNonillionYears
                                                                         , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) twip per square decade. Defined as: (1.0/20.0)/((10.0)*(10.0)) × point per square year.
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecade = new (
                                                                  "twip per square decade"
                                                                , "twip/decade²"
                                                                , PointPerSquareYear
                                                                , 1.0 / 20.0 / (10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yard per square day. Defined as: (3.0)/((24.0)*(24.0)) × foot per square hour.
   /// </summary>
   public static readonly Acceleration YardPerSquareDay = new (
                                                               "yard per square day"
                                                             , "yd/dy²"
                                                             , FootPerSquareHour
                                                             , 3.0 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) point per square million years. Defined as: (1.0/72.0)/((1000.0)*(1000.0)) × inch per square millennium.
   /// </summary>
   public static readonly Acceleration PointPerSquareMillionYears = new (
                                                                         "point per square million years"
                                                                       , "p/Myr²"
                                                                       , InchPerSquareMillennium
                                                                       , 1.0 / 72.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square hour. Defined as: (2.0)/((60.0)*(60.0)) × yard per square minute.
   /// </summary>
   public static readonly Acceleration FathomPerSquareHour =
            new ("fathom per square hour", "ftm/hr²", YardPerSquareMinute, 2.0 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) mil per square decillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × inch per square nonillion years.
   /// </summary>
   public static readonly Acceleration MilPerSquareDecillionYears = new (
                                                                         "mil per square decillion years"
                                                                       , "mil/decillion yr²"
                                                                       , InchPerSquareNonillionYears
                                                                       , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) foot per square trillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × inch per square billion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareTrillionYears = new (
                                                                         "foot per square trillion years"
                                                                       , "ft/Tyr²"
                                                                       , InchPerSquareBillionYears
                                                                       , 12.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) pica per square sextillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × point per square quintillion years.
   /// </summary>
   public static readonly Acceleration PicaPerSquareSextillionYears = new (
                                                                           "pica per square sextillion years"
                                                                         , "P/Zyr²"
                                                                         , PointPerSquareQuintillionYears
                                                                         , 12.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) mile per square octillion years. Defined as: (1760.0)/((1000.0)*(1000.0)) × yard per square septillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareOctillionYears = new (
                                                                          "mile per square octillion years"
                                                                        , "mi/Ryr²"
                                                                        , YardPerSquareSeptillionYears
                                                                        , 1760.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) pica per square year. Defined as: (12.0)/((365.2525)*(365.2525)) × point per square day.
   /// </summary>
   public static readonly Acceleration PicaPerSquareYear = new (
                                                                "pica per square year"
                                                              , "P/yr²"
                                                              , PointPerSquareDay
                                                              , 12.0 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) cable per square hour. Defined as: (120.0)/((60.0)*(60.0)) × fathom per square minute.
   /// </summary>
   public static readonly Acceleration CablePerSquareHour = new (
                                                                 "cable per square hour"
                                                               , "cb/hr²"
                                                               , FathomPerSquareMinute
                                                               , 120.0 / (60.0 * 60.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) twip per square quintillion years. Defined as: (1.0/20.0)/((1000.0)*(1000.0)) × point per square quadrillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuintillionYears = new (
                                                                            "twip per square quintillion years"
                                                                          , "twip/Eyr²"
                                                                          , PointPerSquareQuadrillionYears
                                                                          , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) twip per square century. Defined as: (1.0/20.0)/((10.0)*(10.0)) × point per square decade.
   /// </summary>
   public static readonly Acceleration TwipPerSquareCentury = new (
                                                                   "twip per square century"
                                                                 , "twip/century²"
                                                                 , PointPerSquareDecade
                                                                 , 1.0 / 20.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) mile per square day. Defined as: (1760.0)/((24.0)*(24.0)) × yard per square hour.
   /// </summary>
   public static readonly Acceleration MilePerSquareDay = new (
                                                               "mile per square day"
                                                             , "mi/dy²"
                                                             , YardPerSquareHour
                                                             , 1760.0 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per square year. Defined as: (3.0)/((365.2525)*(365.2525)) × mile per square day.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYear = new (
                                                                  "league per square year"
                                                                , "le/yr²"
                                                                , MilePerSquareDay
                                                                , 3.0 / (365.2525 * 365.2525)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) pica per square billion years. Defined as: (12.0)/((1000.0)*(1000.0)) × point per square million years.
   /// </summary>
   public static readonly Acceleration PicaPerSquareBillionYears = new (
                                                                        "pica per square billion years"
                                                                      , "P/Gyr²"
                                                                      , PointPerSquareMillionYears
                                                                      , 12.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) yard per square quintillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × foot per square quadrillion years.
   /// </summary>
   public static readonly Acceleration YardPerSquareQuintillionYears = new (
                                                                            "yard per square quintillion years"
                                                                          , "yd/Eyr²"
                                                                          , FootPerSquareQuadrillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yard per square billion years. Defined as: (3.0)/((1000.0)*(1000.0)) × foot per square million years.
   /// </summary>
   public static readonly Acceleration YardPerSquareBillionYears = new (
                                                                        "yard per square billion years"
                                                                      , "yd/Gyr²"
                                                                      , FootPerSquareMillionYears
                                                                      , 3.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) pica per square septillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × point per square sextillion years.
   /// </summary>
   public static readonly Acceleration PicaPerSquareSeptillionYears = new (
                                                                           "pica per square septillion years"
                                                                         , "P/Yyr²"
                                                                         , PointPerSquareSextillionYears
                                                                         , 12.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) yard per square century. Defined as: (3.0)/((10.0)*(10.0)) × foot per square decade.
   /// </summary>
   public static readonly Acceleration YardPerSquareCentury = new (
                                                                   "yard per square century"
                                                                 , "yd/century²"
                                                                 , FootPerSquareDecade
                                                                 , 3.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) twip per square sextillion years. Defined as: (1.0/20.0)/((1000.0)*(1000.0)) × point per square quintillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareSextillionYears = new (
                                                                           "twip per square sextillion years"
                                                                         , "twip/Zyr²"
                                                                         , PointPerSquareQuintillionYears
                                                                         , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) pica per square decade. Defined as: (12.0)/((10.0)*(10.0)) × point per square year.
   /// </summary>
   public static readonly Acceleration PicaPerSquareDecade = new (
                                                                  "pica per square decade"
                                                                , "P/decade²"
                                                                , PointPerSquareYear
                                                                , 12.0 / (10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yard per square week. Defined as: (3.0)/((7.0)*(7.0)) × foot per square day.
   /// </summary>
   public static readonly Acceleration YardPerSquareWeek = new (
                                                                "yard per square week"
                                                              , "yd/wk²"
                                                              , FootPerSquareDay
                                                              , 3.0 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) twip per square millennium. Defined as: (1.0/20.0)/((10.0)*(10.0)) × point per square century.
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillennium = new (
                                                                      "twip per square millennium"
                                                                    , "twip/kyr²"
                                                                    , PointPerSquareCentury
                                                                    , 1.0 / 20.0 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) league per square day. Defined as: (3.0)/((24.0)*(24.0)) × mile per square hour.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDay =
            new ("league per square day", "le/dy²", MilePerSquareHour, 3.0 / (24.0 * 24.0), 0);

   /// <summary>
   /// A(n) mile per square sextillion years. Defined as: (1760.0)/((1000.0)*(1000.0)) × yard per square quintillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareSextillionYears = new (
                                                                           "mile per square sextillion years"
                                                                         , "mi/Zyr²"
                                                                         , YardPerSquareQuintillionYears
                                                                         , 1760.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) fathom per square septillion years. Defined as: (2.0)/((1000.0)*(1000.0)) × yard per square sextillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareSeptillionYears = new (
                                                                             "fathom per square septillion years"
                                                                           , "ftm/Yyr²"
                                                                           , YardPerSquareSextillionYears
                                                                           , 2.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) fathom per square trillion years. Defined as: (2.0)/((1000.0)*(1000.0)) × yard per square billion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareTrillionYears = new (
                                                                           "fathom per square trillion years"
                                                                         , "ftm/Tyr²"
                                                                         , YardPerSquareBillionYears
                                                                         , 2.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) league per square nonillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square octillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNonillionYears = new (
                                                                            "league per square nonillion years"
                                                                          , "le/Qyr²"
                                                                          , MilePerSquareOctillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) fathom per square century. Defined as: (2.0)/((10.0)*(10.0)) × yard per square decade.
   /// </summary>
   public static readonly Acceleration FathomPerSquareCentury = new (
                                                                     "fathom per square century"
                                                                   , "ftm/century²"
                                                                   , YardPerSquareDecade
                                                                   , 2.0 / (10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) fathom per square year. Defined as: (2.0)/((365.2525)*(365.2525)) × yard per square day.
   /// </summary>
   public static readonly Acceleration FathomPerSquareYear = new (
                                                                  "fathom per square year"
                                                                , "ftm/yr²"
                                                                , YardPerSquareDay
                                                                , 2.0 / (365.2525 * 365.2525)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) twip per square septillion years. Defined as: (1.0/20.0)/((1000.0)*(1000.0)) × point per square sextillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareSeptillionYears = new (
                                                                           "twip per square septillion years"
                                                                         , "twip/Yyr²"
                                                                         , PointPerSquareSextillionYears
                                                                         , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) twip per square million years. Defined as: (1.0/20.0)/((1000.0)*(1000.0)) × point per square millennium.
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillionYears = new (
                                                                        "twip per square million years"
                                                                      , "twip/Myr²"
                                                                      , PointPerSquareMillennium
                                                                      , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square day. Defined as: (2.0)/((24.0)*(24.0)) × yard per square hour.
   /// </summary>
   public static readonly Acceleration FathomPerSquareDay =
            new ("fathom per square day", "ftm/dy²", YardPerSquareHour, 2.0 / (24.0 * 24.0), 0);

   /// <summary>
   /// A(n) pica per square octillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × point per square septillion years.
   /// </summary>
   public static readonly Acceleration PicaPerSquareOctillionYears = new (
                                                                          "pica per square octillion years"
                                                                        , "P/Ryr²"
                                                                        , PointPerSquareSeptillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) cable per square quadrillion years. Defined as: (120.0)/((1000.0)*(1000.0)) × fathom per square trillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareQuadrillionYears = new (
                                                                             "cable per square quadrillion years"
                                                                           , "cb/Pyr²"
                                                                           , FathomPerSquareTrillionYears
                                                                           , 120.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) league per square septillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square sextillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSeptillionYears = new (
                                                                             "league per square septillion years"
                                                                           , "le/Yyr²"
                                                                           , MilePerSquareSextillionYears
                                                                           , 3.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) pica per square century. Defined as: (12.0)/((10.0)*(10.0)) × point per square decade.
   /// </summary>
   public static readonly Acceleration PicaPerSquareCentury = new (
                                                                   "pica per square century"
                                                                 , "P/century²"
                                                                 , PointPerSquareDecade
                                                                 , 12.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) mile per square week. Defined as: (1760.0)/((7.0)*(7.0)) × yard per square day.
   /// </summary>
   public static readonly Acceleration MilePerSquareWeek = new (
                                                                "mile per square week"
                                                              , "mi/wk²"
                                                              , YardPerSquareDay
                                                              , 1760.0 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) yard per square trillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × foot per square billion years.
   /// </summary>
   public static readonly Acceleration YardPerSquareTrillionYears = new (
                                                                         "yard per square trillion years"
                                                                       , "yd/Tyr²"
                                                                       , FootPerSquareBillionYears
                                                                       , 3.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) yard per square millennium. Defined as: (3.0)/((10.0)*(10.0)) × foot per square century.
   /// </summary>
   public static readonly Acceleration YardPerSquareMillennium = new (
                                                                      "yard per square millennium"
                                                                    , "yd/kyr²"
                                                                    , FootPerSquareCentury
                                                                    , 3.0 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square octillion years. Defined as: (1.0/20.0)/((1000.0)*(1000.0)) × point per square septillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareOctillionYears = new (
                                                                          "twip per square octillion years"
                                                                        , "twip/Ryr²"
                                                                        , PointPerSquareSeptillionYears
                                                                        , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) yard per square year. Defined as: (3.0)/((365.2525)*(365.2525)) × foot per square day.
   /// </summary>
   public static readonly Acceleration YardPerSquareYear = new (
                                                                "yard per square year"
                                                              , "yd/yr²"
                                                              , FootPerSquareDay
                                                              , 3.0 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) twip per square billion years. Defined as: (1.0/20.0)/((1000.0)*(1000.0)) × point per square million years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareBillionYears = new (
                                                                        "twip per square billion years"
                                                                      , "twip/Gyr²"
                                                                      , PointPerSquareMillionYears
                                                                      , 1.0 / 20.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square day. Defined as: (120.0)/((24.0)*(24.0)) × fathom per square hour.
   /// </summary>
   public static readonly Acceleration CablePerSquareDay = new (
                                                                "cable per square day"
                                                              , "cb/dy²"
                                                              , FathomPerSquareHour
                                                              , 120.0 / (24.0 * 24.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) mile per square century. Defined as: (1760.0)/((10.0)*(10.0)) × yard per square decade.
   /// </summary>
   public static readonly Acceleration MilePerSquareCentury = new (
                                                                   "mile per square century"
                                                                 , "mi/century²"
                                                                 , YardPerSquareDecade
                                                                 , 1760.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) cable per square octillion years. Defined as: (120.0)/((1000.0)*(1000.0)) × fathom per square septillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareOctillionYears = new (
                                                                           "cable per square octillion years"
                                                                         , "cb/Ryr²"
                                                                         , FathomPerSquareSeptillionYears
                                                                         , 120.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) pica per square nonillion years. Defined as: (12.0)/((1000.0)*(1000.0)) × point per square octillion years.
   /// </summary>
   public static readonly Acceleration PicaPerSquareNonillionYears = new (
                                                                          "pica per square nonillion years"
                                                                        , "P/Qyr²"
                                                                        , PointPerSquareOctillionYears
                                                                        , 12.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) cable per square year. Defined as: (120.0)/((365.2525)*(365.2525)) × fathom per square day.
   /// </summary>
   public static readonly Acceleration CablePerSquareYear = new (
                                                                 "cable per square year"
                                                               , "cb/yr²"
                                                               , FathomPerSquareDay
                                                               , 120.0 / (365.2525 * 365.2525)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) pica per square millennium. Defined as: (12.0)/((10.0)*(10.0)) × point per square century.
   /// </summary>
   public static readonly Acceleration PicaPerSquareMillennium = new (
                                                                      "pica per square millennium"
                                                                    , "P/kyr²"
                                                                    , PointPerSquareCentury
                                                                    , 12.0 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) league per square week. Defined as: (3.0)/((7.0)*(7.0)) × mile per square day.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareWeek =
            new ("league per square week", "le/wk²", MilePerSquareDay, 3.0 / (7.0 * 7.0), 0);

   /// <summary>
   /// A(n) mile per square billion years. Defined as: (1760.0)/((1000.0)*(1000.0)) × yard per square million years.
   /// </summary>
   public static readonly Acceleration MilePerSquareBillionYears = new (
                                                                        "mile per square billion years"
                                                                      , "mi/Gyr²"
                                                                      , YardPerSquareMillionYears
                                                                      , 1760.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square octillion years. Defined as: (2.0)/((1000.0)*(1000.0)) × yard per square septillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareOctillionYears = new (
                                                                            "fathom per square octillion years"
                                                                          , "ftm/Ryr²"
                                                                          , YardPerSquareSeptillionYears
                                                                          , 2.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) fathom per square sextillion years. Defined as: (2.0)/((1000.0)*(1000.0)) × yard per square quintillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareSextillionYears = new (
                                                                             "fathom per square sextillion years"
                                                                           , "ftm/Zyr²"
                                                                           , YardPerSquareQuintillionYears
                                                                           , 2.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) fathom per square quadrillion years. Defined as: (2.0)/((1000.0)*(1000.0)) × yard per square trillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuadrillionYears = new (
                                                                              "fathom per square quadrillion years"
                                                                            , "ftm/Pyr²"
                                                                            , YardPerSquareTrillionYears
                                                                            , 2.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) fathom per square billion years. Defined as: (2.0)/((1000.0)*(1000.0)) × yard per square million years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareBillionYears = new (
                                                                          "fathom per square billion years"
                                                                        , "ftm/Gyr²"
                                                                        , YardPerSquareMillionYears
                                                                        , 2.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) mile per square year. Defined as: (1760.0)/((365.2525)*(365.2525)) × yard per square day.
   /// </summary>
   public static readonly Acceleration MilePerSquareYear = new (
                                                                "mile per square year"
                                                              , "mi/yr²"
                                                              , YardPerSquareDay
                                                              , 1760.0 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) fathom per square millennium. Defined as: (2.0)/((10.0)*(10.0)) × yard per square century.
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillennium = new (
                                                                        "fathom per square millennium"
                                                                      , "ftm/kyr²"
                                                                      , YardPerSquareCentury
                                                                      , 2.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) yard per square quadrillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × foot per square trillion years.
   /// </summary>
   public static readonly Acceleration YardPerSquareQuadrillionYears = new (
                                                                            "yard per square quadrillion years"
                                                                          , "yd/Pyr²"
                                                                          , FootPerSquareTrillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) fathom per square decade. Defined as: (2.0)/((10.0)*(10.0)) × yard per square year.
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecade = new (
                                                                    "fathom per square decade"
                                                                  , "ftm/decade²"
                                                                  , YardPerSquareYear
                                                                  , 2.0 / (10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) mile per square quintillion years. Defined as: (1760.0)/((1000.0)*(1000.0)) × yard per square quadrillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareQuintillionYears = new (
                                                                            "mile per square quintillion years"
                                                                          , "mi/Eyr²"
                                                                          , YardPerSquareQuadrillionYears
                                                                          , 1760.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) fathom per square week. Defined as: (2.0)/((7.0)*(7.0)) × yard per square day.
   /// </summary>
   public static readonly Acceleration FathomPerSquareWeek =
            new ("fathom per square week", "ftm/wk²", YardPerSquareDay, 2.0 / (7.0 * 7.0), 0);

   /// <summary>
   /// A(n) cable per square trillion years. Defined as: (120.0)/((1000.0)*(1000.0)) × fathom per square billion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareTrillionYears = new (
                                                                          "cable per square trillion years"
                                                                        , "cb/Tyr²"
                                                                        , FathomPerSquareBillionYears
                                                                        , 120.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) mile per square millennium. Defined as: (1760.0)/((10.0)*(10.0)) × yard per square century.
   /// </summary>
   public static readonly Acceleration MilePerSquareMillennium = new (
                                                                      "mile per square millennium"
                                                                    , "mi/kyr²"
                                                                    , YardPerSquareCentury
                                                                    , 1760.0 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) cable per square quintillion years. Defined as: (120.0)/((1000.0)*(1000.0)) × fathom per square quadrillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareQuintillionYears = new (
                                                                             "cable per square quintillion years"
                                                                           , "cb/Eyr²"
                                                                           , FathomPerSquareQuadrillionYears
                                                                           , 120.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) league per square sextillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square quintillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSextillionYears = new (
                                                                             "league per square sextillion years"
                                                                           , "le/Zyr²"
                                                                           , MilePerSquareQuintillionYears
                                                                           , 3.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) cable per square septillion years. Defined as: (120.0)/((1000.0)*(1000.0)) × fathom per square sextillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareSeptillionYears = new (
                                                                            "cable per square septillion years"
                                                                          , "cb/Yyr²"
                                                                          , FathomPerSquareSextillionYears
                                                                          , 120.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) cable per square week. Defined as: (120.0)/((7.0)*(7.0)) × fathom per square day.
   /// </summary>
   public static readonly Acceleration CablePerSquareWeek =
            new ("cable per square week", "cb/wk²", FathomPerSquareDay, 120.0 / (7.0 * 7.0), 0);

   /// <summary>
   /// A(n) mile per square trillion years. Defined as: (1760.0)/((1000.0)*(1000.0)) × yard per square billion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareTrillionYears = new (
                                                                         "mile per square trillion years"
                                                                       , "mi/Tyr²"
                                                                       , YardPerSquareBillionYears
                                                                       , 1760.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square quadrillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square trillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuadrillionYears = new (
                                                                              "league per square quadrillion years"
                                                                            , "le/Pyr²"
                                                                            , MilePerSquareTrillionYears
                                                                            , 3.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) cable per square nonillion years. Defined as: (120.0)/((1000.0)*(1000.0)) × fathom per square octillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareNonillionYears = new (
                                                                           "cable per square nonillion years"
                                                                         , "cb/Qyr²"
                                                                         , FathomPerSquareOctillionYears
                                                                         , 120.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) cable per square decade. Defined as: (120.0)/((10.0)*(10.0)) × fathom per square year.
   /// </summary>
   public static readonly Acceleration CablePerSquareDecade = new (
                                                                   "cable per square decade"
                                                                 , "cb/decade²"
                                                                 , FathomPerSquareYear
                                                                 , 120.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) mile per square decade. Defined as: (1760.0)/((10.0)*(10.0)) × yard per square year.
   /// </summary>
   public static readonly Acceleration MilePerSquareDecade = new (
                                                                  "mile per square decade"
                                                                , "mi/decade²"
                                                                , YardPerSquareYear
                                                                , 1760.0 / (10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) cable per square millennium. Defined as: (120.0)/((10.0)*(10.0)) × fathom per square century.
   /// </summary>
   public static readonly Acceleration CablePerSquareMillennium = new (
                                                                       "cable per square millennium"
                                                                     , "cb/kyr²"
                                                                     , FathomPerSquareCentury
                                                                     , 120.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) fathom per square quintillion years. Defined as: (2.0)/((1000.0)*(1000.0)) × yard per square quadrillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuintillionYears = new (
                                                                              "fathom per square quintillion years"
                                                                            , "ftm/Eyr²"
                                                                            , YardPerSquareQuadrillionYears
                                                                            , 2.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) fathom per square million years. Defined as: (2.0)/((1000.0)*(1000.0)) × yard per square millennium.
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillionYears = new (
                                                                          "fathom per square million years"
                                                                        , "ftm/Myr²"
                                                                        , YardPerSquareMillennium
                                                                        , 2.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) mile per square million years. Defined as: (1760.0)/((1000.0)*(1000.0)) × yard per square millennium.
   /// </summary>
   public static readonly Acceleration MilePerSquareMillionYears = new (
                                                                        "mile per square million years"
                                                                      , "mi/Myr²"
                                                                      , YardPerSquareMillennium
                                                                      , 1760.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square billion years. Defined as: (120.0)/((1000.0)*(1000.0)) × fathom per square million years.
   /// </summary>
   public static readonly Acceleration CablePerSquareBillionYears = new (
                                                                         "cable per square billion years"
                                                                       , "cb/Gyr²"
                                                                       , FathomPerSquareMillionYears
                                                                       , 120.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square millennium. Defined as: (3.0)/((10.0)*(10.0)) × mile per square century.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillennium = new (
                                                                        "league per square millennium"
                                                                      , "le/kyr²"
                                                                      , MilePerSquareCentury
                                                                      , 3.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) mile per square quadrillion years. Defined as: (1760.0)/((1000.0)*(1000.0)) × yard per square trillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareQuadrillionYears = new (
                                                                            "mile per square quadrillion years"
                                                                          , "mi/Pyr²"
                                                                          , YardPerSquareTrillionYears
                                                                          , 1760.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) cable per square sextillion years. Defined as: (120.0)/((1000.0)*(1000.0)) × fathom per square quintillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareSextillionYears = new (
                                                                            "cable per square sextillion years"
                                                                          , "cb/Zyr²"
                                                                          , FathomPerSquareQuintillionYears
                                                                          , 120.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) league per square decade. Defined as: (3.0)/((10.0)*(10.0)) × mile per square year.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecade = new (
                                                                    "league per square decade"
                                                                  , "le/decade²"
                                                                  , MilePerSquareYear
                                                                  , 3.0 / (10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) league per square quintillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square quadrillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuintillionYears = new (
                                                                              "league per square quintillion years"
                                                                            , "le/Eyr²"
                                                                            , MilePerSquareQuadrillionYears
                                                                            , 3.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) league per square trillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square billion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTrillionYears = new (
                                                                           "league per square trillion years"
                                                                         , "le/Tyr²"
                                                                         , MilePerSquareBillionYears
                                                                         , 3.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) cable per square century. Defined as: (120.0)/((10.0)*(10.0)) × fathom per square decade.
   /// </summary>
   public static readonly Acceleration CablePerSquareCentury = new (
                                                                    "cable per square century"
                                                                  , "cb/century²"
                                                                  , FathomPerSquareDecade
                                                                  , 120.0 / (10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) cable per square million years. Defined as: (120.0)/((1000.0)*(1000.0)) × fathom per square millennium.
   /// </summary>
   public static readonly Acceleration CablePerSquareMillionYears = new (
                                                                         "cable per square million years"
                                                                       , "cb/Myr²"
                                                                       , FathomPerSquareMillennium
                                                                       , 120.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square million years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square millennium.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillionYears = new (
                                                                          "league per square million years"
                                                                        , "le/Myr²"
                                                                        , MilePerSquareMillennium
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) league per square century. Defined as: (3.0)/((10.0)*(10.0)) × mile per square decade.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentury = new (
                                                                     "league per square century"
                                                                   , "le/century²"
                                                                   , MilePerSquareDecade
                                                                   , 3.0 / (10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) league per square billion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square million years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareBillionYears = new (
                                                                          "league per square billion years"
                                                                        , "le/Gyr²"
                                                                        , MilePerSquareMillionYears
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );
}
