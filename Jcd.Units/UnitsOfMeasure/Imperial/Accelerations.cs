﻿#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.Imperial;

/// <summary>
/// British Imperial Units for measuring Acceleration.
/// </summary>
public class Accelerations : UnitOfMeasureEnumeration<Accelerations, Acceleration>
{
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
   /// foot per square second, defined as: inch per square second × (12)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareSecond =
            new ("foot per square second", "ft/s²", InchPerSquareSecond, 12 / (1.0 * 1.0));

   /// <summary>
   /// foot per square decisecond, defined as: inch per square second × (12)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareDecisecond = new (
                                                                      "foot per square decisecond"
                                                                    , "ft/ds²"
                                                                    , InchPerSquareSecond
                                                                    , 12 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// foot per square centisecond, defined as: inch per square decisecond × (12)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareCentisecond = new (
                                                                       "foot per square centisecond"
                                                                     , "ft/cs²"
                                                                     , InchPerSquareDecisecond
                                                                     , 12 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// foot per square millisecond, defined as: inch per square centisecond × (12)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareMillisecond = new (
                                                                       "foot per square millisecond"
                                                                     , "ft/ms²"
                                                                     , InchPerSquareCentisecond
                                                                     , 12 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// foot per square microsecond, defined as: inch per square millisecond × (12)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareMicrosecond = new (
                                                                       "foot per square microsecond"
                                                                     , "ft/μs²"
                                                                     , InchPerSquareMillisecond
                                                                     , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// foot per square nanosecond, defined as: inch per square microsecond × (12)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareNanosecond = new (
                                                                      "foot per square nanosecond"
                                                                    , "ft/ns²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// foot per square picosecond, defined as: inch per square nanosecond × (12)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquarePicosecond = new (
                                                                      "foot per square picosecond"
                                                                    , "ft/ps²"
                                                                    , InchPerSquareNanosecond
                                                                    , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// foot per square femtosecond, defined as: inch per square picosecond × (12)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareFemtosecond = new (
                                                                       "foot per square femtosecond"
                                                                     , "ft/fs²"
                                                                     , InchPerSquarePicosecond
                                                                     , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// foot per square attosecond, defined as: inch per square femtosecond × (12)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareAttosecond = new (
                                                                      "foot per square attosecond"
                                                                    , "ft/as²"
                                                                    , InchPerSquareFemtosecond
                                                                    , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// foot per square zeptosecond, defined as: inch per square attosecond × (12)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareZeptosecond = new (
                                                                       "foot per square zeptosecond"
                                                                     , "ft/zs²"
                                                                     , InchPerSquareAttosecond
                                                                     , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// foot per square yoctosecond, defined as: inch per square zeptosecond × (12)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareYoctosecond = new (
                                                                       "foot per square yoctosecond"
                                                                     , "ft/ys²"
                                                                     , InchPerSquareZeptosecond
                                                                     , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// foot per square rontosecond, defined as: inch per square yoctosecond × (12)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareRontosecond = new (
                                                                       "foot per square rontosecond"
                                                                     , "ft/rs²"
                                                                     , InchPerSquareYoctosecond
                                                                     , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// foot per square quectosecond, defined as: inch per square rontosecond × (12)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareQuectosecond = new (
                                                                        "foot per square quectosecond"
                                                                      , "ft/qs²"
                                                                      , InchPerSquareRontosecond
                                                                      , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// twip per square second, defined as: foot per square second × (1.0/17280.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareSecond = new (
                                                                  "twip per square second"
                                                                , "twip/s²"
                                                                , FootPerSquareSecond
                                                                , 1.0 / 17280.0 / (1.0 * 1.0)
                                                                 );

   /// <summary>
   /// twip per square decisecond, defined as: foot per square second × (1.0/17280.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecisecond = new (
                                                                      "twip per square decisecond"
                                                                    , "twip/ds²"
                                                                    , FootPerSquareSecond
                                                                    , 1.0 / 17280.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// twip per square centisecond, defined as: foot per square decisecond × (1.0/17280.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareCentisecond = new (
                                                                       "twip per square centisecond"
                                                                     , "twip/cs²"
                                                                     , FootPerSquareDecisecond
                                                                     , 1.0 / 17280.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// twip per square millisecond, defined as: foot per square centisecond × (1.0/17280.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillisecond = new (
                                                                       "twip per square millisecond"
                                                                     , "twip/ms²"
                                                                     , FootPerSquareCentisecond
                                                                     , 1.0 / 17280.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// twip per square microsecond, defined as: foot per square millisecond × (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareMicrosecond = new (
                                                                       "twip per square microsecond"
                                                                     , "twip/μs²"
                                                                     , FootPerSquareMillisecond
                                                                     , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// twip per square nanosecond, defined as: foot per square microsecond × (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareNanosecond = new (
                                                                      "twip per square nanosecond"
                                                                    , "twip/ns²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// twip per square picosecond, defined as: foot per square nanosecond × (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquarePicosecond = new (
                                                                      "twip per square picosecond"
                                                                    , "twip/ps²"
                                                                    , FootPerSquareNanosecond
                                                                    , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// twip per square femtosecond, defined as: foot per square picosecond × (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareFemtosecond = new (
                                                                       "twip per square femtosecond"
                                                                     , "twip/fs²"
                                                                     , FootPerSquarePicosecond
                                                                     , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// twip per square attosecond, defined as: foot per square femtosecond × (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareAttosecond = new (
                                                                      "twip per square attosecond"
                                                                    , "twip/as²"
                                                                    , FootPerSquareFemtosecond
                                                                    , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// twip per square zeptosecond, defined as: foot per square attosecond × (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareZeptosecond = new (
                                                                       "twip per square zeptosecond"
                                                                     , "twip/zs²"
                                                                     , FootPerSquareAttosecond
                                                                     , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// twip per square yoctosecond, defined as: foot per square zeptosecond × (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareYoctosecond = new (
                                                                       "twip per square yoctosecond"
                                                                     , "twip/ys²"
                                                                     , FootPerSquareZeptosecond
                                                                     , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// twip per square rontosecond, defined as: foot per square yoctosecond × (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareRontosecond = new (
                                                                       "twip per square rontosecond"
                                                                     , "twip/rs²"
                                                                     , FootPerSquareYoctosecond
                                                                     , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// twip per square quectosecond, defined as: foot per square rontosecond × (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuectosecond = new (
                                                                        "twip per square quectosecond"
                                                                      , "twip/qs²"
                                                                      , FootPerSquareRontosecond
                                                                      , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// thou per square second, defined as: foot per square second × (1.0/12000.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareSecond = new (
                                                                  "thou per square second"
                                                                , "th/s²"
                                                                , FootPerSquareSecond
                                                                , 1.0 / 12000.0 / (1.0 * 1.0)
                                                                 );

   /// <summary>
   /// thou per square decisecond, defined as: foot per square second × (1.0/12000.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareDecisecond = new (
                                                                      "thou per square decisecond"
                                                                    , "th/ds²"
                                                                    , FootPerSquareSecond
                                                                    , 1.0 / 12000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// thou per square centisecond, defined as: foot per square decisecond × (1.0/12000.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareCentisecond = new (
                                                                       "thou per square centisecond"
                                                                     , "th/cs²"
                                                                     , FootPerSquareDecisecond
                                                                     , 1.0 / 12000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// thou per square millisecond, defined as: foot per square centisecond × (1.0/12000.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareMillisecond = new (
                                                                       "thou per square millisecond"
                                                                     , "th/ms²"
                                                                     , FootPerSquareCentisecond
                                                                     , 1.0 / 12000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// thou per square microsecond, defined as: foot per square millisecond × (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareMicrosecond = new (
                                                                       "thou per square microsecond"
                                                                     , "th/μs²"
                                                                     , FootPerSquareMillisecond
                                                                     , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// thou per square nanosecond, defined as: foot per square microsecond × (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareNanosecond = new (
                                                                      "thou per square nanosecond"
                                                                    , "th/ns²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// thou per square picosecond, defined as: foot per square nanosecond × (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquarePicosecond = new (
                                                                      "thou per square picosecond"
                                                                    , "th/ps²"
                                                                    , FootPerSquareNanosecond
                                                                    , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// thou per square femtosecond, defined as: foot per square picosecond × (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareFemtosecond = new (
                                                                       "thou per square femtosecond"
                                                                     , "th/fs²"
                                                                     , FootPerSquarePicosecond
                                                                     , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// thou per square attosecond, defined as: foot per square femtosecond × (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareAttosecond = new (
                                                                      "thou per square attosecond"
                                                                    , "th/as²"
                                                                    , FootPerSquareFemtosecond
                                                                    , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// thou per square zeptosecond, defined as: foot per square attosecond × (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareZeptosecond = new (
                                                                       "thou per square zeptosecond"
                                                                     , "th/zs²"
                                                                     , FootPerSquareAttosecond
                                                                     , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// thou per square yoctosecond, defined as: foot per square zeptosecond × (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareYoctosecond = new (
                                                                       "thou per square yoctosecond"
                                                                     , "th/ys²"
                                                                     , FootPerSquareZeptosecond
                                                                     , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// thou per square rontosecond, defined as: foot per square yoctosecond × (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareRontosecond = new (
                                                                       "thou per square rontosecond"
                                                                     , "th/rs²"
                                                                     , FootPerSquareYoctosecond
                                                                     , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// thou per square quectosecond, defined as: foot per square rontosecond × (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareQuectosecond = new (
                                                                        "thou per square quectosecond"
                                                                      , "th/qs²"
                                                                      , FootPerSquareRontosecond
                                                                      , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// barleycorn per square second, defined as: foot per square second × (1.0/36.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareSecond = new (
                                                                        "barleycorn per square second"
                                                                      , "barleycorn/s²"
                                                                      , FootPerSquareSecond
                                                                      , 1.0 / 36.0 / (1.0 * 1.0)
                                                                       );

   /// <summary>
   /// barleycorn per square decisecond, defined as: foot per square second × (1.0/36.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDecisecond = new (
                                                                            "barleycorn per square decisecond"
                                                                          , "barleycorn/ds²"
                                                                          , FootPerSquareSecond
                                                                          , 1.0 / 36.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           );

   /// <summary>
   /// barleycorn per square centisecond, defined as: foot per square decisecond × (1.0/36.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareCentisecond = new (
                                                                             "barleycorn per square centisecond"
                                                                           , "barleycorn/cs²"
                                                                           , FootPerSquareDecisecond
                                                                           , 1.0 / 36.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                            );

   /// <summary>
   /// barleycorn per square millisecond, defined as: foot per square centisecond × (1.0/36.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMillisecond = new (
                                                                             "barleycorn per square millisecond"
                                                                           , "barleycorn/ms²"
                                                                           , FootPerSquareCentisecond
                                                                           , 1.0 / 36.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                            );

   /// <summary>
   /// barleycorn per square microsecond, defined as: foot per square millisecond × (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMicrosecond = new (
                                                                             "barleycorn per square microsecond"
                                                                           , "barleycorn/μs²"
                                                                           , FootPerSquareMillisecond
                                                                           , 1.0
                                                                           / 36.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            );

   /// <summary>
   /// barleycorn per square nanosecond, defined as: foot per square microsecond × (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareNanosecond = new (
                                                                            "barleycorn per square nanosecond"
                                                                          , "barleycorn/ns²"
                                                                          , FootPerSquareMicrosecond
                                                                          , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           );

   /// <summary>
   /// barleycorn per square picosecond, defined as: foot per square nanosecond × (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquarePicosecond = new (
                                                                            "barleycorn per square picosecond"
                                                                          , "barleycorn/ps²"
                                                                          , FootPerSquareNanosecond
                                                                          , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           );

   /// <summary>
   /// barleycorn per square femtosecond, defined as: foot per square picosecond × (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareFemtosecond = new (
                                                                             "barleycorn per square femtosecond"
                                                                           , "barleycorn/fs²"
                                                                           , FootPerSquarePicosecond
                                                                           , 1.0
                                                                           / 36.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            );

   /// <summary>
   /// barleycorn per square attosecond, defined as: foot per square femtosecond × (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareAttosecond = new (
                                                                            "barleycorn per square attosecond"
                                                                          , "barleycorn/as²"
                                                                          , FootPerSquareFemtosecond
                                                                          , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           );

   /// <summary>
   /// barleycorn per square zeptosecond, defined as: foot per square attosecond × (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareZeptosecond = new (
                                                                             "barleycorn per square zeptosecond"
                                                                           , "barleycorn/zs²"
                                                                           , FootPerSquareAttosecond
                                                                           , 1.0
                                                                           / 36.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            );

   /// <summary>
   /// barleycorn per square yoctosecond, defined as: foot per square zeptosecond × (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareYoctosecond = new (
                                                                             "barleycorn per square yoctosecond"
                                                                           , "barleycorn/ys²"
                                                                           , FootPerSquareZeptosecond
                                                                           , 1.0
                                                                           / 36.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            );

   /// <summary>
   /// barleycorn per square rontosecond, defined as: foot per square yoctosecond × (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareRontosecond = new (
                                                                             "barleycorn per square rontosecond"
                                                                           , "barleycorn/rs²"
                                                                           , FootPerSquareYoctosecond
                                                                           , 1.0
                                                                           / 36.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            );

   /// <summary>
   /// barleycorn per square quectosecond, defined as: foot per square rontosecond × (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareQuectosecond = new (
                                                                              "barleycorn per square quectosecond"
                                                                            , "barleycorn/qs²"
                                                                            , FootPerSquareRontosecond
                                                                            , 1.0
                                                                            / 36.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// hand per square second, defined as: inch per square second × (4.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareSecond =
            new ("hand per square second", "hh/s²", InchPerSquareSecond, 4.0 / (1.0 * 1.0));

   /// <summary>
   /// hand per square decisecond, defined as: inch per square second × (4.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareDecisecond = new (
                                                                      "hand per square decisecond"
                                                                    , "hh/ds²"
                                                                    , InchPerSquareSecond
                                                                    , 4.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// hand per square centisecond, defined as: inch per square decisecond × (4.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareCentisecond = new (
                                                                       "hand per square centisecond"
                                                                     , "hh/cs²"
                                                                     , InchPerSquareDecisecond
                                                                     , 4.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// hand per square millisecond, defined as: inch per square centisecond × (4.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareMillisecond = new (
                                                                       "hand per square millisecond"
                                                                     , "hh/ms²"
                                                                     , InchPerSquareCentisecond
                                                                     , 4.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// hand per square microsecond, defined as: inch per square millisecond × (4.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareMicrosecond = new (
                                                                       "hand per square microsecond"
                                                                     , "hh/μs²"
                                                                     , InchPerSquareMillisecond
                                                                     , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// hand per square nanosecond, defined as: inch per square microsecond × (4.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareNanosecond = new (
                                                                      "hand per square nanosecond"
                                                                    , "hh/ns²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// hand per square picosecond, defined as: inch per square nanosecond × (4.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquarePicosecond = new (
                                                                      "hand per square picosecond"
                                                                    , "hh/ps²"
                                                                    , InchPerSquareNanosecond
                                                                    , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// hand per square femtosecond, defined as: inch per square picosecond × (4.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareFemtosecond = new (
                                                                       "hand per square femtosecond"
                                                                     , "hh/fs²"
                                                                     , InchPerSquarePicosecond
                                                                     , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// hand per square attosecond, defined as: inch per square femtosecond × (4.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareAttosecond = new (
                                                                      "hand per square attosecond"
                                                                    , "hh/as²"
                                                                    , InchPerSquareFemtosecond
                                                                    , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// hand per square zeptosecond, defined as: inch per square attosecond × (4.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareZeptosecond = new (
                                                                       "hand per square zeptosecond"
                                                                     , "hh/zs²"
                                                                     , InchPerSquareAttosecond
                                                                     , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// hand per square yoctosecond, defined as: inch per square zeptosecond × (4.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareYoctosecond = new (
                                                                       "hand per square yoctosecond"
                                                                     , "hh/ys²"
                                                                     , InchPerSquareZeptosecond
                                                                     , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// hand per square rontosecond, defined as: inch per square yoctosecond × (4.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareRontosecond = new (
                                                                       "hand per square rontosecond"
                                                                     , "hh/rs²"
                                                                     , InchPerSquareYoctosecond
                                                                     , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// hand per square quectosecond, defined as: inch per square rontosecond × (4.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareQuectosecond = new (
                                                                        "hand per square quectosecond"
                                                                      , "hh/qs²"
                                                                      , InchPerSquareRontosecond
                                                                      , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// chain per square second, defined as: yard per square second × (22.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareSecond =
            new ("chain per square second", "ch/s²", YardPerSquareSecond, 22.0 / (1.0 * 1.0));

   /// <summary>
   /// chain per square decisecond, defined as: yard per square second × (22.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecisecond = new (
                                                                       "chain per square decisecond"
                                                                     , "ch/ds²"
                                                                     , YardPerSquareSecond
                                                                     , 22.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// chain per square centisecond, defined as: yard per square decisecond × (22.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareCentisecond = new (
                                                                        "chain per square centisecond"
                                                                      , "ch/cs²"
                                                                      , YardPerSquareDecisecond
                                                                      , 22.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// chain per square millisecond, defined as: yard per square centisecond × (22.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillisecond = new (
                                                                        "chain per square millisecond"
                                                                      , "ch/ms²"
                                                                      , YardPerSquareCentisecond
                                                                      , 22.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// chain per square microsecond, defined as: yard per square millisecond × (22.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareMicrosecond = new (
                                                                        "chain per square microsecond"
                                                                      , "ch/μs²"
                                                                      , YardPerSquareMillisecond
                                                                      , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// chain per square nanosecond, defined as: yard per square microsecond × (22.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareNanosecond = new (
                                                                       "chain per square nanosecond"
                                                                     , "ch/ns²"
                                                                     , YardPerSquareMicrosecond
                                                                     , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// chain per square picosecond, defined as: yard per square nanosecond × (22.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquarePicosecond = new (
                                                                       "chain per square picosecond"
                                                                     , "ch/ps²"
                                                                     , YardPerSquareNanosecond
                                                                     , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// chain per square femtosecond, defined as: yard per square picosecond × (22.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareFemtosecond = new (
                                                                        "chain per square femtosecond"
                                                                      , "ch/fs²"
                                                                      , YardPerSquarePicosecond
                                                                      , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// chain per square attosecond, defined as: yard per square femtosecond × (22.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareAttosecond = new (
                                                                       "chain per square attosecond"
                                                                     , "ch/as²"
                                                                     , YardPerSquareFemtosecond
                                                                     , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// chain per square zeptosecond, defined as: yard per square attosecond × (22.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareZeptosecond = new (
                                                                        "chain per square zeptosecond"
                                                                      , "ch/zs²"
                                                                      , YardPerSquareAttosecond
                                                                      , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// chain per square yoctosecond, defined as: yard per square zeptosecond × (22.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareYoctosecond = new (
                                                                        "chain per square yoctosecond"
                                                                      , "ch/ys²"
                                                                      , YardPerSquareZeptosecond
                                                                      , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// chain per square rontosecond, defined as: yard per square yoctosecond × (22.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareRontosecond = new (
                                                                        "chain per square rontosecond"
                                                                      , "ch/rs²"
                                                                      , YardPerSquareYoctosecond
                                                                      , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// chain per square quectosecond, defined as: yard per square rontosecond × (22.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuectosecond = new (
                                                                         "chain per square quectosecond"
                                                                       , "ch/qs²"
                                                                       , YardPerSquareRontosecond
                                                                       , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// furlong per square second, defined as: chain per square second × (10.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSecond =
            new ("furlong per square second", "fur/s²", ChainPerSquareSecond, 10.0 / (1.0 * 1.0));

   /// <summary>
   /// furlong per square decisecond, defined as: chain per square second × (10.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecisecond = new (
                                                                         "furlong per square decisecond"
                                                                       , "fur/ds²"
                                                                       , ChainPerSquareSecond
                                                                       , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        );

   /// <summary>
   /// furlong per square centisecond, defined as: chain per square decisecond × (10.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareCentisecond = new (
                                                                          "furlong per square centisecond"
                                                                        , "fur/cs²"
                                                                        , ChainPerSquareDecisecond
                                                                        , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         );

   /// <summary>
   /// furlong per square millisecond, defined as: chain per square centisecond × (10.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillisecond = new (
                                                                          "furlong per square millisecond"
                                                                        , "fur/ms²"
                                                                        , ChainPerSquareCentisecond
                                                                        , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         );

   /// <summary>
   /// furlong per square microsecond, defined as: chain per square millisecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMicrosecond = new (
                                                                          "furlong per square microsecond"
                                                                        , "fur/μs²"
                                                                        , ChainPerSquareMillisecond
                                                                        , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         );

   /// <summary>
   /// furlong per square nanosecond, defined as: chain per square microsecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareNanosecond = new (
                                                                         "furlong per square nanosecond"
                                                                       , "fur/ns²"
                                                                       , ChainPerSquareMicrosecond
                                                                       , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// furlong per square picosecond, defined as: chain per square nanosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquarePicosecond = new (
                                                                         "furlong per square picosecond"
                                                                       , "fur/ps²"
                                                                       , ChainPerSquareNanosecond
                                                                       , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// furlong per square femtosecond, defined as: chain per square picosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareFemtosecond = new (
                                                                          "furlong per square femtosecond"
                                                                        , "fur/fs²"
                                                                        , ChainPerSquarePicosecond
                                                                        , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         );

   /// <summary>
   /// furlong per square attosecond, defined as: chain per square femtosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareAttosecond = new (
                                                                         "furlong per square attosecond"
                                                                       , "fur/as²"
                                                                       , ChainPerSquareFemtosecond
                                                                       , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// furlong per square zeptosecond, defined as: chain per square attosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareZeptosecond = new (
                                                                          "furlong per square zeptosecond"
                                                                        , "fur/zs²"
                                                                        , ChainPerSquareAttosecond
                                                                        , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         );

   /// <summary>
   /// furlong per square yoctosecond, defined as: chain per square zeptosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareYoctosecond = new (
                                                                          "furlong per square yoctosecond"
                                                                        , "fur/ys²"
                                                                        , ChainPerSquareZeptosecond
                                                                        , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         );

   /// <summary>
   /// furlong per square rontosecond, defined as: chain per square yoctosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareRontosecond = new (
                                                                          "furlong per square rontosecond"
                                                                        , "fur/rs²"
                                                                        , ChainPerSquareYoctosecond
                                                                        , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         );

   /// <summary>
   /// furlong per square quectosecond, defined as: chain per square rontosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuectosecond = new (
                                                                           "furlong per square quectosecond"
                                                                         , "fur/qs²"
                                                                         , ChainPerSquareRontosecond
                                                                         , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// mile per square second, defined as: furlong per square second × (8.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareSecond =
            new ("mile per square second", "mi/s²", FurlongPerSquareSecond, 8.0 / (1.0 * 1.0));

   /// <summary>
   /// mile per square decisecond, defined as: furlong per square second × (8.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareDecisecond = new (
                                                                      "mile per square decisecond"
                                                                    , "mi/ds²"
                                                                    , FurlongPerSquareSecond
                                                                    , 8.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     );

   /// <summary>
   /// mile per square centisecond, defined as: furlong per square decisecond × (8.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareCentisecond = new (
                                                                       "mile per square centisecond"
                                                                     , "mi/cs²"
                                                                     , FurlongPerSquareDecisecond
                                                                     , 8.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// mile per square millisecond, defined as: furlong per square centisecond × (8.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareMillisecond = new (
                                                                       "mile per square millisecond"
                                                                     , "mi/ms²"
                                                                     , FurlongPerSquareCentisecond
                                                                     , 8.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// mile per square microsecond, defined as: furlong per square millisecond × (8.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareMicrosecond = new (
                                                                       "mile per square microsecond"
                                                                     , "mi/μs²"
                                                                     , FurlongPerSquareMillisecond
                                                                     , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// mile per square nanosecond, defined as: furlong per square microsecond × (8.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareNanosecond = new (
                                                                      "mile per square nanosecond"
                                                                    , "mi/ns²"
                                                                    , FurlongPerSquareMicrosecond
                                                                    , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// mile per square picosecond, defined as: furlong per square nanosecond × (8.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquarePicosecond = new (
                                                                      "mile per square picosecond"
                                                                    , "mi/ps²"
                                                                    , FurlongPerSquareNanosecond
                                                                    , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// mile per square femtosecond, defined as: furlong per square picosecond × (8.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareFemtosecond = new (
                                                                       "mile per square femtosecond"
                                                                     , "mi/fs²"
                                                                     , FurlongPerSquarePicosecond
                                                                     , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// mile per square attosecond, defined as: furlong per square femtosecond × (8.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareAttosecond = new (
                                                                      "mile per square attosecond"
                                                                    , "mi/as²"
                                                                    , FurlongPerSquareFemtosecond
                                                                    , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     );

   /// <summary>
   /// mile per square zeptosecond, defined as: furlong per square attosecond × (8.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareZeptosecond = new (
                                                                       "mile per square zeptosecond"
                                                                     , "mi/zs²"
                                                                     , FurlongPerSquareAttosecond
                                                                     , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// mile per square yoctosecond, defined as: furlong per square zeptosecond × (8.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareYoctosecond = new (
                                                                       "mile per square yoctosecond"
                                                                     , "mi/ys²"
                                                                     , FurlongPerSquareZeptosecond
                                                                     , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// mile per square rontosecond, defined as: furlong per square yoctosecond × (8.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareRontosecond = new (
                                                                       "mile per square rontosecond"
                                                                     , "mi/rs²"
                                                                     , FurlongPerSquareYoctosecond
                                                                     , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// mile per square quectosecond, defined as: furlong per square rontosecond × (8.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareQuectosecond = new (
                                                                        "mile per square quectosecond"
                                                                      , "mi/qs²"
                                                                      , FurlongPerSquareRontosecond
                                                                      , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// league per square second, defined as: mile per square second × (3.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSecond =
            new ("league per square second", "lea/s²", MilePerSquareSecond, 3.0 / (1.0 * 1.0));

   /// <summary>
   /// league per square decisecond, defined as: mile per square second × (3.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecisecond = new (
                                                                        "league per square decisecond"
                                                                      , "lea/ds²"
                                                                      , MilePerSquareSecond
                                                                      , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// league per square centisecond, defined as: mile per square decisecond × (3.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentisecond = new (
                                                                         "league per square centisecond"
                                                                       , "lea/cs²"
                                                                       , MilePerSquareDecisecond
                                                                       , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        );

   /// <summary>
   /// league per square millisecond, defined as: mile per square centisecond × (3.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillisecond = new (
                                                                         "league per square millisecond"
                                                                       , "lea/ms²"
                                                                       , MilePerSquareCentisecond
                                                                       , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        );

   /// <summary>
   /// league per square microsecond, defined as: mile per square millisecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMicrosecond = new (
                                                                         "league per square microsecond"
                                                                       , "lea/μs²"
                                                                       , MilePerSquareMillisecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// league per square nanosecond, defined as: mile per square microsecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNanosecond = new (
                                                                        "league per square nanosecond"
                                                                      , "lea/ns²"
                                                                      , MilePerSquareMicrosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// league per square picosecond, defined as: mile per square nanosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePicosecond = new (
                                                                        "league per square picosecond"
                                                                      , "lea/ps²"
                                                                      , MilePerSquareNanosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// league per square femtosecond, defined as: mile per square picosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareFemtosecond = new (
                                                                         "league per square femtosecond"
                                                                       , "lea/fs²"
                                                                       , MilePerSquarePicosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// league per square attosecond, defined as: mile per square femtosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareAttosecond = new (
                                                                        "league per square attosecond"
                                                                      , "lea/as²"
                                                                      , MilePerSquareFemtosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// league per square zeptosecond, defined as: mile per square attosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareZeptosecond = new (
                                                                         "league per square zeptosecond"
                                                                       , "lea/zs²"
                                                                       , MilePerSquareAttosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// league per square yoctosecond, defined as: mile per square zeptosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYoctosecond = new (
                                                                         "league per square yoctosecond"
                                                                       , "lea/ys²"
                                                                       , MilePerSquareZeptosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// league per square rontosecond, defined as: mile per square yoctosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareRontosecond = new (
                                                                         "league per square rontosecond"
                                                                       , "lea/rs²"
                                                                       , MilePerSquareYoctosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// league per square quectosecond, defined as: mile per square rontosecond × (3.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuectosecond = new (
                                                                          "league per square quectosecond"
                                                                        , "lea/qs²"
                                                                        , MilePerSquareRontosecond
                                                                        , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// fathom per square second, defined as: foot per square second × (6.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareSecond =
            new ("fathom per square second", "ftm/s²", FootPerSquareSecond, 6.0 / (1.0 * 1.0));

   /// <summary>
   /// fathom per square decisecond, defined as: foot per square second × (6.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecisecond = new (
                                                                        "fathom per square decisecond"
                                                                      , "ftm/ds²"
                                                                      , FootPerSquareSecond
                                                                      , 6.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// fathom per square centisecond, defined as: foot per square decisecond × (6.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareCentisecond = new (
                                                                         "fathom per square centisecond"
                                                                       , "ftm/cs²"
                                                                       , FootPerSquareDecisecond
                                                                       , 6.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        );

   /// <summary>
   /// fathom per square millisecond, defined as: foot per square centisecond × (6.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillisecond = new (
                                                                         "fathom per square millisecond"
                                                                       , "ftm/ms²"
                                                                       , FootPerSquareCentisecond
                                                                       , 6.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        );

   /// <summary>
   /// fathom per square microsecond, defined as: foot per square millisecond × (6.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareMicrosecond = new (
                                                                         "fathom per square microsecond"
                                                                       , "ftm/μs²"
                                                                       , FootPerSquareMillisecond
                                                                       , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// fathom per square nanosecond, defined as: foot per square microsecond × (6.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareNanosecond = new (
                                                                        "fathom per square nanosecond"
                                                                      , "ftm/ns²"
                                                                      , FootPerSquareMicrosecond
                                                                      , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// fathom per square picosecond, defined as: foot per square nanosecond × (6.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquarePicosecond = new (
                                                                        "fathom per square picosecond"
                                                                      , "ftm/ps²"
                                                                      , FootPerSquareNanosecond
                                                                      , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// fathom per square femtosecond, defined as: foot per square picosecond × (6.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareFemtosecond = new (
                                                                         "fathom per square femtosecond"
                                                                       , "ftm/fs²"
                                                                       , FootPerSquarePicosecond
                                                                       , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// fathom per square attosecond, defined as: foot per square femtosecond × (6.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareAttosecond = new (
                                                                        "fathom per square attosecond"
                                                                      , "ftm/as²"
                                                                      , FootPerSquareFemtosecond
                                                                      , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// fathom per square zeptosecond, defined as: foot per square attosecond × (6.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareZeptosecond = new (
                                                                         "fathom per square zeptosecond"
                                                                       , "ftm/zs²"
                                                                       , FootPerSquareAttosecond
                                                                       , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// fathom per square yoctosecond, defined as: foot per square zeptosecond × (6.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareYoctosecond = new (
                                                                         "fathom per square yoctosecond"
                                                                       , "ftm/ys²"
                                                                       , FootPerSquareZeptosecond
                                                                       , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// fathom per square rontosecond, defined as: foot per square yoctosecond × (6.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareRontosecond = new (
                                                                         "fathom per square rontosecond"
                                                                       , "ftm/rs²"
                                                                       , FootPerSquareYoctosecond
                                                                       , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        );

   /// <summary>
   /// fathom per square quectosecond, defined as: foot per square rontosecond × (6.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuectosecond = new (
                                                                          "fathom per square quectosecond"
                                                                        , "ftm/qs²"
                                                                        , FootPerSquareRontosecond
                                                                        , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// cable per square second, defined as: fathom per square second × (100.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareSecond =
            new ("cable per square second", "cable/s²", FathomPerSquareSecond, 100.0 / (1.0 * 1.0));

   /// <summary>
   /// cable per square decisecond, defined as: fathom per square second × (100.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareDecisecond = new (
                                                                       "cable per square decisecond"
                                                                     , "cable/ds²"
                                                                     , FathomPerSquareSecond
                                                                     , 100.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      );

   /// <summary>
   /// cable per square centisecond, defined as: fathom per square decisecond × (100.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareCentisecond = new (
                                                                        "cable per square centisecond"
                                                                      , "cable/cs²"
                                                                      , FathomPerSquareDecisecond
                                                                      , 100.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// cable per square millisecond, defined as: fathom per square centisecond × (100.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareMillisecond = new (
                                                                        "cable per square millisecond"
                                                                      , "cable/ms²"
                                                                      , FathomPerSquareCentisecond
                                                                      , 100.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       );

   /// <summary>
   /// cable per square microsecond, defined as: fathom per square millisecond × (100.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareMicrosecond = new (
                                                                        "cable per square microsecond"
                                                                      , "cable/μs²"
                                                                      , FathomPerSquareMillisecond
                                                                      , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// cable per square nanosecond, defined as: fathom per square microsecond × (100.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareNanosecond = new (
                                                                       "cable per square nanosecond"
                                                                     , "cable/ns²"
                                                                     , FathomPerSquareMicrosecond
                                                                     , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// cable per square picosecond, defined as: fathom per square nanosecond × (100.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquarePicosecond = new (
                                                                       "cable per square picosecond"
                                                                     , "cable/ps²"
                                                                     , FathomPerSquareNanosecond
                                                                     , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// cable per square femtosecond, defined as: fathom per square picosecond × (100.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareFemtosecond = new (
                                                                        "cable per square femtosecond"
                                                                      , "cable/fs²"
                                                                      , FathomPerSquarePicosecond
                                                                      , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// cable per square attosecond, defined as: fathom per square femtosecond × (100.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareAttosecond = new (
                                                                       "cable per square attosecond"
                                                                     , "cable/as²"
                                                                     , FathomPerSquareFemtosecond
                                                                     , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      );

   /// <summary>
   /// cable per square zeptosecond, defined as: fathom per square attosecond × (100.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareZeptosecond = new (
                                                                        "cable per square zeptosecond"
                                                                      , "cable/zs²"
                                                                      , FathomPerSquareAttosecond
                                                                      , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// cable per square yoctosecond, defined as: fathom per square zeptosecond × (100.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareYoctosecond = new (
                                                                        "cable per square yoctosecond"
                                                                      , "cable/ys²"
                                                                      , FathomPerSquareZeptosecond
                                                                      , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// cable per square rontosecond, defined as: fathom per square yoctosecond × (100.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareRontosecond = new (
                                                                        "cable per square rontosecond"
                                                                      , "cable/rs²"
                                                                      , FathomPerSquareYoctosecond
                                                                      , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       );

   /// <summary>
   /// cable per square quectosecond, defined as: fathom per square rontosecond × (100.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareQuectosecond = new (
                                                                         "cable per square quectosecond"
                                                                       , "cable/qs²"
                                                                       , FathomPerSquareRontosecond
                                                                       , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// nautical mile per square second, defined as: cable per square second × (10.0)/((1.0)*(1.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSecond =
            new ("nautical mile per square second", "nmi/s²", CablePerSquareSecond, 10.0 / (1.0 * 1.0));

   /// <summary>
   /// nautical mile per square decisecond, defined as: cable per square second × (10.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecisecond = new (
                                                                              "nautical mile per square decisecond"
                                                                            , "nmi/ds²"
                                                                            , CablePerSquareSecond
                                                                            , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                             );

   /// <summary>
   /// nautical mile per square centisecond, defined as: cable per square decisecond × (10.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareCentisecond = new (
                                                                               "nautical mile per square centisecond"
                                                                             , "nmi/cs²"
                                                                             , CablePerSquareDecisecond
                                                                             , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                              );

   /// <summary>
   /// nautical mile per square millisecond, defined as: cable per square centisecond × (10.0)/((1.0/10.0)*(1.0/10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillisecond = new (
                                                                               "nautical mile per square millisecond"
                                                                             , "nmi/ms²"
                                                                             , CablePerSquareCentisecond
                                                                             , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                              );

   /// <summary>
   /// nautical mile per square microsecond, defined as: cable per square millisecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMicrosecond = new (
                                                                               "nautical mile per square microsecond"
                                                                             , "nmi/μs²"
                                                                             , CablePerSquareMillisecond
                                                                             , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              );

   /// <summary>
   /// nautical mile per square nanosecond, defined as: cable per square microsecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareNanosecond = new (
                                                                              "nautical mile per square nanosecond"
                                                                            , "nmi/ns²"
                                                                            , CablePerSquareMicrosecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             );

   /// <summary>
   /// nautical mile per square picosecond, defined as: cable per square nanosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquarePicosecond = new (
                                                                              "nautical mile per square picosecond"
                                                                            , "nmi/ps²"
                                                                            , CablePerSquareNanosecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             );

   /// <summary>
   /// nautical mile per square femtosecond, defined as: cable per square picosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareFemtosecond = new (
                                                                               "nautical mile per square femtosecond"
                                                                             , "nmi/fs²"
                                                                             , CablePerSquarePicosecond
                                                                             , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              );

   /// <summary>
   /// nautical mile per square attosecond, defined as: cable per square femtosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareAttosecond = new (
                                                                              "nautical mile per square attosecond"
                                                                            , "nmi/as²"
                                                                            , CablePerSquareFemtosecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             );

   /// <summary>
   /// nautical mile per square zeptosecond, defined as: cable per square attosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareZeptosecond = new (
                                                                               "nautical mile per square zeptosecond"
                                                                             , "nmi/zs²"
                                                                             , CablePerSquareAttosecond
                                                                             , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              );

   /// <summary>
   /// nautical mile per square yoctosecond, defined as: cable per square zeptosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareYoctosecond = new (
                                                                               "nautical mile per square yoctosecond"
                                                                             , "nmi/ys²"
                                                                             , CablePerSquareZeptosecond
                                                                             , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              );

   /// <summary>
   /// nautical mile per square rontosecond, defined as: cable per square yoctosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareRontosecond = new (
                                                                               "nautical mile per square rontosecond"
                                                                             , "nmi/rs²"
                                                                             , CablePerSquareYoctosecond
                                                                             , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                              );

   /// <summary>
   /// nautical mile per square quectosecond, defined as: cable per square rontosecond × (10.0)/((1.0/1000.0)*(1.0/1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuectosecond = new (
                                                                                "nautical mile per square quectosecond"
                                                                              , "nmi/qs²"
                                                                              , CablePerSquareRontosecond
                                                                              , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// inch per square planck-time, defined as: SI centimeter per square microsecond × (2.54)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration InchPerSquarePlanckTime = new (
                                                                      "inch per square planck-time"
                                                                    , "in/tₚ²"
                                                                    , SI.Accelerations.CentimeterPerSquareMicrosecond
                                                                    , 2.54 / (5.391247E-38 * 5.391247E-38)
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
   /// foot per square planck-time, defined as: inch per square microsecond × (12)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration FootPerSquarePlanckTime = new (
                                                                      "foot per square planck-time"
                                                                    , "ft/tₚ²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 12 / (5.391247E-38 * 5.391247E-38)
                                                                     );

   /// <summary>
   /// foot per square minute, defined as: inch per square second × (12)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareMinute =
            new ("foot per square minute", "ft/min²", InchPerSquareSecond, 12 / (60.0 * 60.0));

   /// <summary>
   /// twip per square planck-time, defined as: foot per square microsecond × (1.0/17280.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration TwipPerSquarePlanckTime = new (
                                                                      "twip per square planck-time"
                                                                    , "twip/tₚ²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 1.0 / 17280.0 / (5.391247E-38 * 5.391247E-38)
                                                                     );

   /// <summary>
   /// hand per square septillion years, defined as: inch per square sextillion years × (4.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareSeptillionYears = new (
                                                                           "hand per square septillion years"
                                                                         , "hh/Yyr²"
                                                                         , InchPerSquareSextillionYears
                                                                         , 4.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// thou per square tick, defined as: foot per square nanosecond × (1.0/12000.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareTick = new (
                                                                "thou per square tick"
                                                              , "th/tick²"
                                                              , FootPerSquareNanosecond
                                                              , 1.0 / 12000.0 / (100.0 * 100.0)
                                                               );

   /// <summary>
   /// hand per square week, defined as: inch per square day × (4.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareWeek = new (
                                                                "hand per square week"
                                                              , "hh/wk²"
                                                              , InchPerSquareDay
                                                              , 4.0 / (7.0 * 7.0)
                                                               );

   /// <summary>
   /// thou per square planck-time, defined as: foot per square microsecond × (1.0/12000.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration ThouPerSquarePlanckTime = new (
                                                                      "thou per square planck-time"
                                                                    , "th/tₚ²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 1.0 / 12000.0 / (5.391247E-38 * 5.391247E-38)
                                                                     );

   /// <summary>
   /// foot per square hour, defined as: inch per square minute × (12)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareHour = new (
                                                                "foot per square hour"
                                                              , "ft/hr²"
                                                              , InchPerSquareMinute
                                                              , 12 / (60.0 * 60.0)
                                                               );

   /// <summary>
   /// twip per square minute, defined as: foot per square second × (1.0/17280.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareMinute = new (
                                                                  "twip per square minute"
                                                                , "twip/min²"
                                                                , FootPerSquareSecond
                                                                , 1.0 / 17280.0 / (60.0 * 60.0)
                                                                 );

   /// <summary>
   /// barleycorn per square planck-time, defined as: foot per square microsecond × (1.0/36.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquarePlanckTime = new (
                                                                            "barleycorn per square planck-time"
                                                                          , "barleycorn/tₚ²"
                                                                          , FootPerSquareMicrosecond
                                                                          , 1.0 / 36.0 / (5.391247E-38 * 5.391247E-38)
                                                                           );

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
   /// hand per square planck-time, defined as: inch per square microsecond × (4.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration HandPerSquarePlanckTime = new (
                                                                      "hand per square planck-time"
                                                                    , "hh/tₚ²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 4.0 / (5.391247E-38 * 5.391247E-38)
                                                                     );

   /// <summary>
   /// foot per square day, defined as: inch per square hour × (12)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareDay = new (
                                                               "foot per square day"
                                                             , "ft/dy²"
                                                             , InchPerSquareHour
                                                             , 12 / (24.0 * 24.0)
                                                              );

   /// <summary>
   /// thou per square minute, defined as: foot per square second × (1.0/12000.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareMinute = new (
                                                                  "thou per square minute"
                                                                , "th/min²"
                                                                , FootPerSquareSecond
                                                                , 1.0 / 12000.0 / (60.0 * 60.0)
                                                                 );

   /// <summary>
   /// hand per square millennium, defined as: inch per square century × (4.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareMillennium =
            new ("hand per square millennium", "hh/kyr²", InchPerSquareCentury, 4.0 / (10.0 * 10.0));

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
   /// fathom per square hour, defined as: foot per square minute × (6.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareHour =
            new ("fathom per square hour", "ftm/hr²", FootPerSquareMinute, 6.0 / (60.0 * 60.0));

   /// <summary>
   /// mile per square tick, defined as: furlong per square nanosecond × (8.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareTick = new (
                                                                "mile per square tick"
                                                              , "mi/tick²"
                                                              , FurlongPerSquareNanosecond
                                                              , 8.0 / (100.0 * 100.0)
                                                               );

   /// <summary>
   /// chain per square planck-time, defined as: yard per square microsecond × (22.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration ChainPerSquarePlanckTime = new (
                                                                       "chain per square planck-time"
                                                                     , "ch/tₚ²"
                                                                     , YardPerSquareMicrosecond
                                                                     , 22.0 / (5.391247E-38 * 5.391247E-38)
                                                                      );

   /// <summary>
   /// twip per square hour, defined as: foot per square minute × (1.0/17280.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareHour = new (
                                                                "twip per square hour"
                                                              , "twip/hr²"
                                                              , FootPerSquareMinute
                                                              , 1.0 / 17280.0 / (60.0 * 60.0)
                                                               );

   /// <summary>
   /// foot per square week, defined as: inch per square day × (12)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareWeek = new (
                                                                "foot per square week"
                                                              , "ft/wk²"
                                                              , InchPerSquareDay
                                                              , 12 / (7.0 * 7.0)
                                                               );

   /// <summary>
   /// barleycorn per square minute, defined as: foot per square second × (1.0/36.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMinute = new (
                                                                        "barleycorn per square minute"
                                                                      , "barleycorn/min²"
                                                                      , FootPerSquareSecond
                                                                      , 1.0 / 36.0 / (60.0 * 60.0)
                                                                       );

   /// <summary>
   /// furlong per square planck-time, defined as: chain per square microsecond × (10.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration FurlongPerSquarePlanckTime = new (
                                                                         "furlong per square planck-time"
                                                                       , "fur/tₚ²"
                                                                       , ChainPerSquareMicrosecond
                                                                       , 10.0 / (5.391247E-38 * 5.391247E-38)
                                                                        );

   /// <summary>
   /// hand per square quadrillion years, defined as: inch per square trillion years × (4.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareQuadrillionYears = new (
                                                                            "hand per square quadrillion years"
                                                                          , "hh/Pyr²"
                                                                          , InchPerSquareTrillionYears
                                                                          , 4.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// cable per square tick, defined as: fathom per square nanosecond × (100.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareTick = new (
                                                                 "cable per square tick"
                                                               , "cable/tick²"
                                                               , FathomPerSquareNanosecond
                                                               , 100.0 / (100.0 * 100.0)
                                                                );

   /// <summary>
   /// mile per square planck-time, defined as: furlong per square microsecond × (8.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration MilePerSquarePlanckTime = new (
                                                                      "mile per square planck-time"
                                                                    , "mi/tₚ²"
                                                                    , FurlongPerSquareMicrosecond
                                                                    , 8.0 / (5.391247E-38 * 5.391247E-38)
                                                                     );

   /// <summary>
   /// foot per square year, defined as: inch per square day × (12)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration FootPerSquareYear = new (
                                                                "foot per square year"
                                                              , "ft/yr²"
                                                              , InchPerSquareDay
                                                              , 12 / (365.2525 * 365.2525)
                                                               );

   /// <summary>
   /// hand per square minute, defined as: inch per square second × (4.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareMinute =
            new ("hand per square minute", "hh/min²", InchPerSquareSecond, 4.0 / (60.0 * 60.0));

   /// <summary>
   /// league per square planck-time, defined as: mile per square microsecond × (3.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePlanckTime = new (
                                                                        "league per square planck-time"
                                                                      , "lea/tₚ²"
                                                                      , MilePerSquareMicrosecond
                                                                      , 3.0 / (5.391247E-38 * 5.391247E-38)
                                                                       );

   /// <summary>
   /// barleycorn per square decade, defined as: foot per square year × (1.0/36.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDecade = new (
                                                                        "barleycorn per square decade"
                                                                      , "barleycorn/decade²"
                                                                      , FootPerSquareYear
                                                                      , 1.0 / 36.0 / (10.0 * 10.0)
                                                                       );

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
   /// twip per square day, defined as: foot per square hour × (1.0/17280.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareDay = new (
                                                               "twip per square day"
                                                             , "twip/dy²"
                                                             , FootPerSquareHour
                                                             , 1.0 / 17280.0 / (24.0 * 24.0)
                                                              );

   /// <summary>
   /// thou per square hour, defined as: foot per square minute × (1.0/12000.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareHour = new (
                                                                "thou per square hour"
                                                              , "th/hr²"
                                                              , FootPerSquareMinute
                                                              , 1.0 / 12000.0 / (60.0 * 60.0)
                                                               );

   /// <summary>
   /// foot per square decade, defined as: inch per square year × (12)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareDecade =
            new ("foot per square decade", "ft/decade²", InchPerSquareYear, 12 / (10.0 * 10.0));

   /// <summary>
   /// yard per square minute, defined as: foot per square second × (3.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareMinute =
            new ("yard per square minute", "yd/min²", FootPerSquareSecond, 3.0 / (60.0 * 60.0));

   /// <summary>
   /// fathom per square planck-time, defined as: foot per square microsecond × (6.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration FathomPerSquarePlanckTime = new (
                                                                        "fathom per square planck-time"
                                                                      , "ftm/tₚ²"
                                                                      , FootPerSquareMicrosecond
                                                                      , 6.0 / (5.391247E-38 * 5.391247E-38)
                                                                       );

   /// <summary>
   /// hand per square octillion years, defined as: inch per square septillion years × (4.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareOctillionYears = new (
                                                                          "hand per square octillion years"
                                                                        , "hh/Ryr²"
                                                                        , InchPerSquareSeptillionYears
                                                                        , 4.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// hand per square year, defined as: inch per square day × (4.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration HandPerSquareYear = new (
                                                                "hand per square year"
                                                              , "hh/yr²"
                                                              , InchPerSquareDay
                                                              , 4.0 / (365.2525 * 365.2525)
                                                               );

   /// <summary>
   /// foot per square tick, defined as: inch per square nanosecond × (12)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareTick = new (
                                                                "foot per square tick"
                                                              , "ft/tick²"
                                                              , InchPerSquareNanosecond
                                                              , 12 / (100.0 * 100.0)
                                                               );

   /// <summary>
   /// cable per square planck-time, defined as: fathom per square microsecond × (100.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration CablePerSquarePlanckTime = new (
                                                                       "cable per square planck-time"
                                                                     , "cable/tₚ²"
                                                                     , FathomPerSquareMicrosecond
                                                                     , 100.0 / (5.391247E-38 * 5.391247E-38)
                                                                      );

   /// <summary>
   /// foot per square century, defined as: inch per square decade × (12)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareCentury =
            new ("foot per square century", "ft/century²", InchPerSquareDecade, 12 / (10.0 * 10.0));

   /// <summary>
   /// chain per square minute, defined as: yard per square second × (22.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareMinute =
            new ("chain per square minute", "ch/min²", YardPerSquareSecond, 22.0 / (60.0 * 60.0));

   /// <summary>
   /// fathom per square week, defined as: foot per square day × (6.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareWeek =
            new ("fathom per square week", "ftm/wk²", FootPerSquareDay, 6.0 / (7.0 * 7.0));

   /// <summary>
   /// nautical mile per square planck-time, defined as: cable per square microsecond × (10.0)/((5.391247E-38)*(5.391247E-38))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquarePlanckTime = new (
                                                                              "nautical mile per square planck-time"
                                                                            , "nmi/tₚ²"
                                                                            , CablePerSquareMicrosecond
                                                                            , 10.0 / (5.391247E-38 * 5.391247E-38)
                                                                             );

   /// <summary>
   /// barleycorn per square tick, defined as: foot per square nanosecond × (1.0/36.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareTick = new (
                                                                      "barleycorn per square tick"
                                                                    , "barleycorn/tick²"
                                                                    , FootPerSquareNanosecond
                                                                    , 1.0 / 36.0 / (100.0 * 100.0)
                                                                     );

   /// <summary>
   /// twip per square week, defined as: foot per square day × (1.0/17280.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareWeek = new (
                                                                "twip per square week"
                                                              , "twip/wk²"
                                                              , FootPerSquareDay
                                                              , 1.0 / 17280.0 / (7.0 * 7.0)
                                                               );

   /// <summary>
   /// barleycorn per square hour, defined as: foot per square minute × (1.0/36.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareHour = new (
                                                                      "barleycorn per square hour"
                                                                    , "barleycorn/hr²"
                                                                    , FootPerSquareMinute
                                                                    , 1.0 / 36.0 / (60.0 * 60.0)
                                                                     );

   /// <summary>
   /// foot per square millennium, defined as: inch per square century × (12)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareMillennium =
            new ("foot per square millennium", "ft/kyr²", InchPerSquareCentury, 12 / (10.0 * 10.0));

   /// <summary>
   /// furlong per square minute, defined as: chain per square second × (10.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMinute =
            new ("furlong per square minute", "fur/min²", ChainPerSquareSecond, 10.0 / (60.0 * 60.0));

   /// <summary>
   /// hand per square million years, defined as: inch per square millennium × (4.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareMillionYears = new (
                                                                        "hand per square million years"
                                                                      , "hh/Myr²"
                                                                      , InchPerSquareMillennium
                                                                      , 4.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// thou per square million years, defined as: foot per square millennium × (1.0/12000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareMillionYears = new (
                                                                        "thou per square million years"
                                                                      , "th/Myr²"
                                                                      , FootPerSquareMillennium
                                                                      , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// chain per square tick, defined as: yard per square nanosecond × (22.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareTick = new (
                                                                 "chain per square tick"
                                                               , "ch/tick²"
                                                               , YardPerSquareNanosecond
                                                               , 22.0 / (100.0 * 100.0)
                                                                );

   /// <summary>
   /// thou per square day, defined as: foot per square hour × (1.0/12000.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareDay = new (
                                                               "thou per square day"
                                                             , "th/dy²"
                                                             , FootPerSquareHour
                                                             , 1.0 / 12000.0 / (24.0 * 24.0)
                                                              );

   /// <summary>
   /// foot per square million years, defined as: inch per square millennium × (12)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareMillionYears = new (
                                                                        "foot per square million years"
                                                                      , "ft/Myr²"
                                                                      , InchPerSquareMillennium
                                                                      , 12 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// mile per square minute, defined as: furlong per square second × (8.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareMinute =
            new ("mile per square minute", "mi/min²", FurlongPerSquareSecond, 8.0 / (60.0 * 60.0));

   /// <summary>
   /// barleycorn per square century, defined as: foot per square decade × (1.0/36.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareCentury = new (
                                                                         "barleycorn per square century"
                                                                       , "barleycorn/century²"
                                                                       , FootPerSquareDecade
                                                                       , 1.0 / 36.0 / (10.0 * 10.0)
                                                                        );

   /// <summary>
   /// hand per square quintillion years, defined as: inch per square quadrillion years × (4.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareQuintillionYears = new (
                                                                            "hand per square quintillion years"
                                                                          , "hh/Eyr²"
                                                                          , InchPerSquareQuadrillionYears
                                                                          , 4.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// twip per square year, defined as: foot per square day × (1.0/17280.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration TwipPerSquareYear = new (
                                                                "twip per square year"
                                                              , "twip/yr²"
                                                              , FootPerSquareDay
                                                              , 1.0 / 17280.0 / (365.2525 * 365.2525)
                                                               );

   /// <summary>
   /// hand per square hour, defined as: inch per square minute × (4.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareHour = new (
                                                                "hand per square hour"
                                                              , "hh/hr²"
                                                              , InchPerSquareMinute
                                                              , 4.0 / (60.0 * 60.0)
                                                               );

   /// <summary>
   /// foot per square billion years, defined as: inch per square million years × (12)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareBillionYears = new (
                                                                        "foot per square billion years"
                                                                      , "ft/Gyr²"
                                                                      , InchPerSquareMillionYears
                                                                      , 12 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// league per square minute, defined as: mile per square second × (3.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMinute =
            new ("league per square minute", "lea/min²", MilePerSquareSecond, 3.0 / (60.0 * 60.0));

   /// <summary>
   /// league per square tick, defined as: mile per square nanosecond × (3.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTick = new (
                                                                  "league per square tick"
                                                                , "lea/tick²"
                                                                , MilePerSquareNanosecond
                                                                , 3.0 / (100.0 * 100.0)
                                                                 );

   /// <summary>
   /// fathom per square trillion years, defined as: foot per square billion years × (6.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareTrillionYears = new (
                                                                           "fathom per square trillion years"
                                                                         , "ftm/Tyr²"
                                                                         , FootPerSquareBillionYears
                                                                         , 6.0 / (1000.0 * 1000.0)
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
   /// fathom per square decade, defined as: foot per square year × (6.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecade =
            new ("fathom per square decade", "ftm/decade²", FootPerSquareYear, 6.0 / (10.0 * 10.0));

   /// <summary>
   /// foot per square trillion years, defined as: inch per square billion years × (12)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareTrillionYears = new (
                                                                         "foot per square trillion years"
                                                                       , "ft/Tyr²"
                                                                       , InchPerSquareBillionYears
                                                                       , 12 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// fathom per square minute, defined as: foot per square second × (6.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareMinute =
            new ("fathom per square minute", "ftm/min²", FootPerSquareSecond, 6.0 / (60.0 * 60.0));

   /// <summary>
   /// yard per square millennium, defined as: foot per square century × (3.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareMillennium =
            new ("yard per square millennium", "yd/kyr²", FootPerSquareCentury, 3.0 / (10.0 * 10.0));

   /// <summary>
   /// barleycorn per square quadrillion years, defined as: foot per square trillion years × (1.0/36.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareQuadrillionYears = new (
       "barleycorn per square quadrillion years"
     , "barleycorn/Pyr²"
     , FootPerSquareTrillionYears
     , 1.0 / 36.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// hand per square nonillion years, defined as: inch per square octillion years × (4.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareNonillionYears = new (
                                                                          "hand per square nonillion years"
                                                                        , "hh/Qyr²"
                                                                        , InchPerSquareOctillionYears
                                                                        , 4.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// nautical mile per square tick, defined as: cable per square nanosecond × (10.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareTick = new (
                                                                        "nautical mile per square tick"
                                                                      , "nmi/tick²"
                                                                      , CablePerSquareNanosecond
                                                                      , 10.0 / (100.0 * 100.0)
                                                                       );

   /// <summary>
   /// hand per square decade, defined as: inch per square year × (4.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareDecade =
            new ("hand per square decade", "hh/decade²", InchPerSquareYear, 4.0 / (10.0 * 10.0));

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
   /// thou per square billion years, defined as: foot per square million years × (1.0/12000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareBillionYears = new (
                                                                        "thou per square billion years"
                                                                      , "th/Gyr²"
                                                                      , FootPerSquareMillionYears
                                                                      , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// thou per square week, defined as: foot per square day × (1.0/12000.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareWeek = new (
                                                                "thou per square week"
                                                              , "th/wk²"
                                                              , FootPerSquareDay
                                                              , 1.0 / 12000.0 / (7.0 * 7.0)
                                                               );

   /// <summary>
   /// barleycorn per square day, defined as: foot per square hour × (1.0/36.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDay = new (
                                                                     "barleycorn per square day"
                                                                   , "barleycorn/dy²"
                                                                   , FootPerSquareHour
                                                                   , 1.0 / 36.0 / (24.0 * 24.0)
                                                                    );

   /// <summary>
   /// twip per square decade, defined as: foot per square year × (1.0/17280.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecade = new (
                                                                  "twip per square decade"
                                                                , "twip/decade²"
                                                                , FootPerSquareYear
                                                                , 1.0 / 17280.0 / (10.0 * 10.0)
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
   /// foot per square quadrillion years, defined as: inch per square trillion years × (12)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareQuadrillionYears = new (
                                                                            "foot per square quadrillion years"
                                                                          , "ft/Pyr²"
                                                                          , InchPerSquareTrillionYears
                                                                          , 12 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// cable per square minute, defined as: fathom per square second × (100.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareMinute = new (
                                                                   "cable per square minute"
                                                                 , "cable/min²"
                                                                 , FathomPerSquareSecond
                                                                 , 100.0 / (60.0 * 60.0)
                                                                  );

   /// <summary>
   /// foot per square quintillion years, defined as: inch per square quadrillion years × (12)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareQuintillionYears = new (
                                                                            "foot per square quintillion years"
                                                                          , "ft/Eyr²"
                                                                          , InchPerSquareQuadrillionYears
                                                                          , 12 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// nautical mile per square minute, defined as: cable per square second × (10.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMinute = new (
                                                                          "nautical mile per square minute"
                                                                        , "nmi/min²"
                                                                        , CablePerSquareSecond
                                                                        , 10.0 / (60.0 * 60.0)
                                                                         );

   /// <summary>
   /// hand per square billion years, defined as: inch per square million years × (4.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareBillionYears = new (
                                                                        "hand per square billion years"
                                                                      , "hh/Gyr²"
                                                                      , InchPerSquareMillionYears
                                                                      , 4.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// twip per square tick, defined as: foot per square nanosecond × (1.0/17280.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareTick = new (
                                                                "twip per square tick"
                                                              , "twip/tick²"
                                                              , FootPerSquareNanosecond
                                                              , 1.0 / 17280.0 / (100.0 * 100.0)
                                                               );

   /// <summary>
   /// barleycorn per square millennium, defined as: foot per square century × (1.0/36.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMillennium = new (
                                                                            "barleycorn per square millennium"
                                                                          , "barleycorn/kyr²"
                                                                          , FootPerSquareCentury
                                                                          , 1.0 / 36.0 / (10.0 * 10.0)
                                                                           );

   /// <summary>
   /// fathom per square quintillion years, defined as: foot per square quadrillion years × (6.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuintillionYears = new (
                                                                              "fathom per square quintillion years"
                                                                            , "ftm/Eyr²"
                                                                            , FootPerSquareQuadrillionYears
                                                                            , 6.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// twip per square century, defined as: foot per square decade × (1.0/17280.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareCentury = new (
                                                                   "twip per square century"
                                                                 , "twip/century²"
                                                                 , FootPerSquareDecade
                                                                 , 1.0 / 17280.0 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// chain per square hour, defined as: yard per square minute × (22.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareHour =
            new ("chain per square hour", "ch/hr²", YardPerSquareMinute, 22.0 / (60.0 * 60.0));

   /// <summary>
   /// foot per square sextillion years, defined as: inch per square quintillion years × (12)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareSextillionYears = new (
                                                                           "foot per square sextillion years"
                                                                         , "ft/Zyr²"
                                                                         , InchPerSquareQuintillionYears
                                                                         , 12 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// fathom per square millennium, defined as: foot per square century × (6.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillennium = new (
                                                                        "fathom per square millennium"
                                                                      , "ftm/kyr²"
                                                                      , FootPerSquareCentury
                                                                      , 6.0 / (10.0 * 10.0)
                                                                       );

   /// <summary>
   /// hand per square tick, defined as: inch per square nanosecond × (4.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareTick = new (
                                                                "hand per square tick"
                                                              , "hh/tick²"
                                                              , InchPerSquareNanosecond
                                                              , 4.0 / (100.0 * 100.0)
                                                               );

   /// <summary>
   /// thou per square trillion years, defined as: foot per square billion years × (1.0/12000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareTrillionYears = new (
                                                                         "thou per square trillion years"
                                                                       , "th/Tyr²"
                                                                       , FootPerSquareBillionYears
                                                                       , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// fathom per square day, defined as: foot per square hour × (6.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareDay =
            new ("fathom per square day", "ftm/dy²", FootPerSquareHour, 6.0 / (24.0 * 24.0));

   /// <summary>
   /// hand per square sextillion years, defined as: inch per square quintillion years × (4.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareSextillionYears = new (
                                                                           "hand per square sextillion years"
                                                                         , "hh/Zyr²"
                                                                         , InchPerSquareQuintillionYears
                                                                         , 4.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// cable per square quadrillion years, defined as: fathom per square trillion years × (100.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareQuadrillionYears = new (
                                                                             "cable per square quadrillion years"
                                                                           , "cable/Pyr²"
                                                                           , FathomPerSquareTrillionYears
                                                                           , 100.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// thou per square year, defined as: foot per square day × (1.0/12000.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration ThouPerSquareYear = new (
                                                                "thou per square year"
                                                              , "th/yr²"
                                                              , FootPerSquareDay
                                                              , 1.0 / 12000.0 / (365.2525 * 365.2525)
                                                               );

   /// <summary>
   /// hand per square day, defined as: inch per square hour × (4.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareDay = new (
                                                               "hand per square day"
                                                             , "hh/dy²"
                                                             , InchPerSquareHour
                                                             , 4.0 / (24.0 * 24.0)
                                                              );

   /// <summary>
   /// foot per square septillion years, defined as: inch per square sextillion years × (12)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareSeptillionYears = new (
                                                                           "foot per square septillion years"
                                                                         , "ft/Yyr²"
                                                                         , InchPerSquareSextillionYears
                                                                         , 12 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// barleycorn per square quintillion years, defined as: foot per square quadrillion years × (1.0/36.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareQuintillionYears = new (
       "barleycorn per square quintillion years"
     , "barleycorn/Eyr²"
     , FootPerSquareQuadrillionYears
     , 1.0 / 36.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// furlong per square tick, defined as: chain per square nanosecond × (10.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareTick = new (
                                                                   "furlong per square tick"
                                                                 , "fur/tick²"
                                                                 , ChainPerSquareNanosecond
                                                                 , 10.0 / (100.0 * 100.0)
                                                                  );

   /// <summary>
   /// cable per square million years, defined as: fathom per square millennium × (100.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareMillionYears = new (
                                                                         "cable per square million years"
                                                                       , "cable/Myr²"
                                                                       , FathomPerSquareMillennium
                                                                       , 100.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// barleycorn per square week, defined as: foot per square day × (1.0/36.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareWeek = new (
                                                                      "barleycorn per square week"
                                                                    , "barleycorn/wk²"
                                                                    , FootPerSquareDay
                                                                    , 1.0 / 36.0 / (7.0 * 7.0)
                                                                     );

   /// <summary>
   /// twip per square millennium, defined as: foot per square century × (1.0/17280.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillennium = new (
                                                                      "twip per square millennium"
                                                                    , "twip/kyr²"
                                                                    , FootPerSquareCentury
                                                                    , 1.0 / 17280.0 / (10.0 * 10.0)
                                                                     );

   /// <summary>
   /// furlong per square hour, defined as: chain per square minute × (10.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareHour =
            new ("furlong per square hour", "fur/hr²", ChainPerSquareMinute, 10.0 / (60.0 * 60.0));

   /// <summary>
   /// foot per square octillion years, defined as: inch per square septillion years × (12)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareOctillionYears = new (
                                                                          "foot per square octillion years"
                                                                        , "ft/Ryr²"
                                                                        , InchPerSquareSeptillionYears
                                                                        , 12 / (1000.0 * 1000.0)
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
   /// hand per square decillion years, defined as: inch per square nonillion years × (4.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareDecillionYears = new (
                                                                          "hand per square decillion years"
                                                                        , "hh/decillion yr²"
                                                                        , InchPerSquareNonillionYears
                                                                        , 4.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// hand per square century, defined as: inch per square decade × (4.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareCentury = new (
                                                                   "hand per square century"
                                                                 , "hh/century²"
                                                                 , InchPerSquareDecade
                                                                 , 4.0 / (10.0 * 10.0)
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
   /// fathom per square tick, defined as: foot per square nanosecond × (6.0)/((100.0)*(100.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareTick = new (
                                                                  "fathom per square tick"
                                                                , "ftm/tick²"
                                                                , FootPerSquareNanosecond
                                                                , 6.0 / (100.0 * 100.0)
                                                                 );

   /// <summary>
   /// foot per square nonillion years, defined as: inch per square octillion years × (12)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareNonillionYears = new (
                                                                          "foot per square nonillion years"
                                                                        , "ft/Qyr²"
                                                                        , InchPerSquareOctillionYears
                                                                        , 12 / (1000.0 * 1000.0)
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
   /// thou per square decillion years, defined as: foot per square nonillion years × (1.0/12000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareDecillionYears = new (
                                                                          "thou per square decillion years"
                                                                        , "th/decillion yr²"
                                                                        , FootPerSquareNonillionYears
                                                                        , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// chain per square quintillion years, defined as: yard per square quadrillion years × (22.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuintillionYears = new (
                                                                             "chain per square quintillion years"
                                                                           , "ch/Eyr²"
                                                                           , YardPerSquareQuadrillionYears
                                                                           , 22.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// fathom per square septillion years, defined as: foot per square sextillion years × (6.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareSeptillionYears = new (
                                                                             "fathom per square septillion years"
                                                                           , "ftm/Yyr²"
                                                                           , FootPerSquareSextillionYears
                                                                           , 6.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// yard per square decade, defined as: foot per square year × (3.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration YardPerSquareDecade =
            new ("yard per square decade", "yd/decade²", FootPerSquareYear, 3.0 / (10.0 * 10.0));

   /// <summary>
   /// barleycorn per square million years, defined as: foot per square millennium × (1.0/36.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMillionYears = new (
                                                                              "barleycorn per square million years"
                                                                            , "barleycorn/Myr²"
                                                                            , FootPerSquareMillennium
                                                                            , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// thou per square quadrillion years, defined as: foot per square trillion years × (1.0/12000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareQuadrillionYears = new (
                                                                            "thou per square quadrillion years"
                                                                          , "th/Pyr²"
                                                                          , FootPerSquareTrillionYears
                                                                          , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// cable per square day, defined as: fathom per square hour × (100.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareDay = new (
                                                                "cable per square day"
                                                              , "cable/dy²"
                                                              , FathomPerSquareHour
                                                              , 100.0 / (24.0 * 24.0)
                                                               );

   /// <summary>
   /// twip per square decillion years, defined as: foot per square nonillion years × (1.0/17280.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecillionYears = new (
                                                                          "twip per square decillion years"
                                                                        , "twip/decillion yr²"
                                                                        , FootPerSquareNonillionYears
                                                                        , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// fathom per square billion years, defined as: foot per square million years × (6.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareBillionYears = new (
                                                                          "fathom per square billion years"
                                                                        , "ftm/Gyr²"
                                                                        , FootPerSquareMillionYears
                                                                        , 6.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// thou per square decade, defined as: foot per square year × (1.0/12000.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareDecade = new (
                                                                  "thou per square decade"
                                                                , "th/decade²"
                                                                , FootPerSquareYear
                                                                , 1.0 / 12000.0 / (10.0 * 10.0)
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
   /// twip per square million years, defined as: foot per square millennium × (1.0/17280.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillionYears = new (
                                                                        "twip per square million years"
                                                                      , "twip/Myr²"
                                                                      , FootPerSquareMillennium
                                                                      , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// mile per square hour, defined as: furlong per square minute × (8.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareHour = new (
                                                                "mile per square hour"
                                                              , "mi/hr²"
                                                              , FurlongPerSquareMinute
                                                              , 8.0 / (60.0 * 60.0)
                                                               );

   /// <summary>
   /// foot per square decillion years, defined as: inch per square nonillion years × (12)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FootPerSquareDecillionYears = new (
                                                                          "foot per square decillion years"
                                                                        , "ft/decillion yr²"
                                                                        , InchPerSquareNonillionYears
                                                                        , 12 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// hand per square trillion years, defined as: inch per square billion years × (4.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration HandPerSquareTrillionYears = new (
                                                                         "hand per square trillion years"
                                                                       , "hh/Tyr²"
                                                                       , InchPerSquareBillionYears
                                                                       , 4.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// fathom per square year, defined as: foot per square day × (6.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration FathomPerSquareYear = new (
                                                                  "fathom per square year"
                                                                , "ftm/yr²"
                                                                , FootPerSquareDay
                                                                , 6.0 / (365.2525 * 365.2525)
                                                                 );

   /// <summary>
   /// barleycorn per square sextillion years, defined as: foot per square quintillion years × (1.0/36.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareSextillionYears = new (
       "barleycorn per square sextillion years"
     , "barleycorn/Zyr²"
     , FootPerSquareQuintillionYears
     , 1.0 / 36.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// nautical mile per square billion years, defined as: cable per square million years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareBillionYears = new (
                                                                                "nautical mile per square billion years"
                                                                              , "nmi/Gyr²"
                                                                              , CablePerSquareMillionYears
                                                                              , 10.0 / (1000.0 * 1000.0)
                                                                               );

   /// <summary>
   /// furlong per square sextillion years, defined as: chain per square quintillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSextillionYears = new (
                                                                              "furlong per square sextillion years"
                                                                            , "fur/Zyr²"
                                                                            , ChainPerSquareQuintillionYears
                                                                            , 10.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// chain per square octillion years, defined as: yard per square septillion years × (22.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareOctillionYears = new (
                                                                           "chain per square octillion years"
                                                                         , "ch/Ryr²"
                                                                         , YardPerSquareSeptillionYears
                                                                         , 22.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// barleycorn per square year, defined as: foot per square day × (1.0/36.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareYear = new (
                                                                      "barleycorn per square year"
                                                                    , "barleycorn/yr²"
                                                                    , FootPerSquareDay
                                                                    , 1.0 / 36.0 / (365.2525 * 365.2525)
                                                                     );

   /// <summary>
   /// twip per square billion years, defined as: foot per square million years × (1.0/17280.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareBillionYears = new (
                                                                        "twip per square billion years"
                                                                      , "twip/Gyr²"
                                                                      , FootPerSquareMillionYears
                                                                      , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// league per square hour, defined as: mile per square minute × (3.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareHour =
            new ("league per square hour", "lea/hr²", MilePerSquareMinute, 3.0 / (60.0 * 60.0));

   /// <summary>
   /// cable per square sextillion years, defined as: fathom per square quintillion years × (100.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareSextillionYears = new (
                                                                            "cable per square sextillion years"
                                                                          , "cable/Zyr²"
                                                                          , FathomPerSquareQuintillionYears
                                                                          , 100.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// thou per square quintillion years, defined as: foot per square quadrillion years × (1.0/12000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareQuintillionYears = new (
                                                                            "thou per square quintillion years"
                                                                          , "th/Eyr²"
                                                                          , FootPerSquareQuadrillionYears
                                                                          , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// fathom per square nonillion years, defined as: foot per square octillion years × (6.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareNonillionYears = new (
                                                                            "fathom per square nonillion years"
                                                                          , "ftm/Qyr²"
                                                                          , FootPerSquareOctillionYears
                                                                          , 6.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// thou per square century, defined as: foot per square decade × (1.0/12000.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareCentury = new (
                                                                   "thou per square century"
                                                                 , "th/century²"
                                                                 , FootPerSquareDecade
                                                                 , 1.0 / 12000.0 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// chain per square day, defined as: yard per square hour × (22.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareDay = new (
                                                                "chain per square day"
                                                              , "ch/dy²"
                                                              , YardPerSquareHour
                                                              , 22.0 / (24.0 * 24.0)
                                                               );

   /// <summary>
   /// fathom per square quadrillion years, defined as: foot per square trillion years × (6.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuadrillionYears = new (
                                                                              "fathom per square quadrillion years"
                                                                            , "ftm/Pyr²"
                                                                            , FootPerSquareTrillionYears
                                                                            , 6.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// cable per square trillion years, defined as: fathom per square billion years × (100.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareTrillionYears = new (
                                                                          "cable per square trillion years"
                                                                        , "cable/Tyr²"
                                                                        , FathomPerSquareBillionYears
                                                                        , 100.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// nautical mile per square quintillion years, defined as: cable per square quadrillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuintillionYears = new (
       "nautical mile per square quintillion years"
     , "nmi/Eyr²"
     , CablePerSquareQuadrillionYears
     , 10.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// furlong per square year, defined as: chain per square day × (10.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareYear = new (
                                                                   "furlong per square year"
                                                                 , "fur/yr²"
                                                                 , ChainPerSquareDay
                                                                 , 10.0 / (365.2525 * 365.2525)
                                                                  );

   /// <summary>
   /// barleycorn per square billion years, defined as: foot per square million years × (1.0/36.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareBillionYears = new (
                                                                              "barleycorn per square billion years"
                                                                            , "barleycorn/Gyr²"
                                                                            , FootPerSquareMillionYears
                                                                            , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// fathom per square century, defined as: foot per square decade × (6.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareCentury = new (
                                                                     "fathom per square century"
                                                                   , "ftm/century²"
                                                                   , FootPerSquareDecade
                                                                   , 6.0 / (10.0 * 10.0)
                                                                    );

   /// <summary>
   /// twip per square trillion years, defined as: foot per square billion years × (1.0/17280.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareTrillionYears = new (
                                                                         "twip per square trillion years"
                                                                       , "twip/Tyr²"
                                                                       , FootPerSquareBillionYears
                                                                       , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// cable per square millennium, defined as: fathom per square century × (100.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareMillennium = new (
                                                                       "cable per square millennium"
                                                                     , "cable/kyr²"
                                                                     , FathomPerSquareCentury
                                                                     , 100.0 / (10.0 * 10.0)
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
   /// cable per square year, defined as: fathom per square day × (100.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration CablePerSquareYear = new (
                                                                 "cable per square year"
                                                               , "cable/yr²"
                                                               , FathomPerSquareDay
                                                               , 100.0 / (365.2525 * 365.2525)
                                                                );

   /// <summary>
   /// barleycorn per square septillion years, defined as: foot per square sextillion years × (1.0/36.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareSeptillionYears = new (
       "barleycorn per square septillion years"
     , "barleycorn/Yyr²"
     , FootPerSquareSextillionYears
     , 1.0 / 36.0 / (1000.0 * 1000.0)
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
   /// chain per square decade, defined as: yard per square year × (22.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecade =
            new ("chain per square decade", "ch/decade²", YardPerSquareYear, 22.0 / (10.0 * 10.0));

   /// <summary>
   /// thou per square sextillion years, defined as: foot per square quintillion years × (1.0/12000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareSextillionYears = new (
                                                                           "thou per square sextillion years"
                                                                         , "th/Zyr²"
                                                                         , FootPerSquareQuintillionYears
                                                                         , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// thou per square millennium, defined as: foot per square century × (1.0/12000.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareMillennium = new (
                                                                      "thou per square millennium"
                                                                    , "th/kyr²"
                                                                    , FootPerSquareCentury
                                                                    , 1.0 / 12000.0 / (10.0 * 10.0)
                                                                     );

   /// <summary>
   /// furlong per square day, defined as: chain per square hour × (10.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDay =
            new ("furlong per square day", "fur/dy²", ChainPerSquareHour, 10.0 / (24.0 * 24.0));

   /// <summary>
   /// twip per square quadrillion years, defined as: foot per square trillion years × (1.0/17280.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuadrillionYears = new (
                                                                            "twip per square quadrillion years"
                                                                          , "twip/Pyr²"
                                                                          , FootPerSquareTrillionYears
                                                                          , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// cable per square hour, defined as: fathom per square minute × (100.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareHour = new (
                                                                 "cable per square hour"
                                                               , "cable/hr²"
                                                               , FathomPerSquareMinute
                                                               , 100.0 / (60.0 * 60.0)
                                                                );

   /// <summary>
   /// chain per square sextillion years, defined as: yard per square quintillion years × (22.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareSextillionYears = new (
                                                                            "chain per square sextillion years"
                                                                          , "ch/Zyr²"
                                                                          , YardPerSquareQuintillionYears
                                                                          , 22.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// mile per square septillion years, defined as: furlong per square sextillion years × (8.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareSeptillionYears = new (
                                                                           "mile per square septillion years"
                                                                         , "mi/Yyr²"
                                                                         , FurlongPerSquareSextillionYears
                                                                         , 8.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// nautical mile per square million years, defined as: cable per square millennium × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillionYears = new (
                                                                                "nautical mile per square million years"
                                                                              , "nmi/Myr²"
                                                                              , CablePerSquareMillennium
                                                                              , 10.0 / (1000.0 * 1000.0)
                                                                               );

   /// <summary>
   /// fathom per square sextillion years, defined as: foot per square quintillion years × (6.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareSextillionYears = new (
                                                                             "fathom per square sextillion years"
                                                                           , "ftm/Zyr²"
                                                                           , FootPerSquareQuintillionYears
                                                                           , 6.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// fathom per square million years, defined as: foot per square millennium × (6.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillionYears = new (
                                                                          "fathom per square million years"
                                                                        , "ftm/Myr²"
                                                                        , FootPerSquareMillennium
                                                                        , 6.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// furlong per square nonillion years, defined as: chain per square octillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareNonillionYears = new (
                                                                             "furlong per square nonillion years"
                                                                           , "fur/Qyr²"
                                                                           , ChainPerSquareOctillionYears
                                                                           , 10.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// barleycorn per square trillion years, defined as: foot per square billion years × (1.0/36.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareTrillionYears = new (
                                                                               "barleycorn per square trillion years"
                                                                             , "barleycorn/Tyr²"
                                                                             , FootPerSquareBillionYears
                                                                             , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                              );

   /// <summary>
   /// cable per square octillion years, defined as: fathom per square septillion years × (100.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareOctillionYears = new (
                                                                           "cable per square octillion years"
                                                                         , "cable/Ryr²"
                                                                         , FathomPerSquareSeptillionYears
                                                                         , 100.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// twip per square quintillion years, defined as: foot per square quadrillion years × (1.0/17280.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuintillionYears = new (
                                                                            "twip per square quintillion years"
                                                                          , "twip/Eyr²"
                                                                          , FootPerSquareQuadrillionYears
                                                                          , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// nautical mile per square hour, defined as: cable per square minute × (10.0)/((60.0)*(60.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareHour = new (
                                                                        "nautical mile per square hour"
                                                                      , "nmi/hr²"
                                                                      , CablePerSquareMinute
                                                                      , 10.0 / (60.0 * 60.0)
                                                                       );

   /// <summary>
   /// chain per square million years, defined as: yard per square millennium × (22.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillionYears = new (
                                                                         "chain per square million years"
                                                                       , "ch/Myr²"
                                                                       , YardPerSquareMillennium
                                                                       , 22.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// mile per square year, defined as: furlong per square day × (8.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration MilePerSquareYear = new (
                                                                "mile per square year"
                                                              , "mi/yr²"
                                                              , FurlongPerSquareDay
                                                              , 8.0 / (365.2525 * 365.2525)
                                                               );

   /// <summary>
   /// thou per square septillion years, defined as: foot per square sextillion years × (1.0/12000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareSeptillionYears = new (
                                                                           "thou per square septillion years"
                                                                         , "th/Yyr²"
                                                                         , FootPerSquareSextillionYears
                                                                         , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// chain per square nonillion years, defined as: yard per square octillion years × (22.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareNonillionYears = new (
                                                                           "chain per square nonillion years"
                                                                         , "ch/Qyr²"
                                                                         , YardPerSquareOctillionYears
                                                                         , 22.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// cable per square quintillion years, defined as: fathom per square quadrillion years × (100.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareQuintillionYears = new (
                                                                             "cable per square quintillion years"
                                                                           , "cable/Eyr²"
                                                                           , FathomPerSquareQuadrillionYears
                                                                           , 100.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// nautical mile per square quadrillion years, defined as: cable per square trillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuadrillionYears = new (
       "nautical mile per square quadrillion years"
     , "nmi/Pyr²"
     , CablePerSquareTrillionYears
     , 10.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// mile per square day, defined as: furlong per square hour × (8.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareDay = new (
                                                               "mile per square day"
                                                             , "mi/dy²"
                                                             , FurlongPerSquareHour
                                                             , 8.0 / (24.0 * 24.0)
                                                              );

   /// <summary>
   /// barleycorn per square octillion years, defined as: foot per square septillion years × (1.0/36.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareOctillionYears = new (
                                                                                "barleycorn per square octillion years"
                                                                              , "barleycorn/Ryr²"
                                                                              , FootPerSquareSeptillionYears
                                                                              , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                               );

   /// <summary>
   /// cable per square billion years, defined as: fathom per square million years × (100.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareBillionYears = new (
                                                                         "cable per square billion years"
                                                                       , "cable/Gyr²"
                                                                       , FathomPerSquareMillionYears
                                                                       , 100.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// furlong per square septillion years, defined as: chain per square sextillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSeptillionYears = new (
                                                                              "furlong per square septillion years"
                                                                            , "fur/Yyr²"
                                                                            , ChainPerSquareSextillionYears
                                                                            , 10.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// chain per square week, defined as: yard per square day × (22.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareWeek =
            new ("chain per square week", "ch/wk²", YardPerSquareDay, 22.0 / (7.0 * 7.0));

   /// <summary>
   /// twip per square sextillion years, defined as: foot per square quintillion years × (1.0/17280.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareSextillionYears = new (
                                                                           "twip per square sextillion years"
                                                                         , "twip/Zyr²"
                                                                         , FootPerSquareQuintillionYears
                                                                         , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// nautical mile per square year, defined as: cable per square day × (10.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareYear = new (
                                                                        "nautical mile per square year"
                                                                      , "nmi/yr²"
                                                                      , CablePerSquareDay
                                                                      , 10.0 / (365.2525 * 365.2525)
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
   /// fathom per square octillion years, defined as: foot per square septillion years × (6.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareOctillionYears = new (
                                                                            "fathom per square octillion years"
                                                                          , "ftm/Ryr²"
                                                                          , FootPerSquareSeptillionYears
                                                                          , 6.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// chain per square quadrillion years, defined as: yard per square trillion years × (22.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuadrillionYears = new (
                                                                             "chain per square quadrillion years"
                                                                           , "ch/Pyr²"
                                                                           , YardPerSquareTrillionYears
                                                                           , 22.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// cable per square century, defined as: fathom per square decade × (100.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareCentury = new (
                                                                    "cable per square century"
                                                                  , "cable/century²"
                                                                  , FathomPerSquareDecade
                                                                  , 100.0 / (10.0 * 10.0)
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
   /// nautical mile per square septillion years, defined as: cable per square sextillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSeptillionYears = new (
       "nautical mile per square septillion years"
     , "nmi/Yyr²"
     , CablePerSquareSextillionYears
     , 10.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// cable per square week, defined as: fathom per square day × (100.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareWeek =
            new ("cable per square week", "cable/wk²", FathomPerSquareDay, 100.0 / (7.0 * 7.0));

   /// <summary>
   /// thou per square octillion years, defined as: foot per square septillion years × (1.0/12000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareOctillionYears = new (
                                                                          "thou per square octillion years"
                                                                        , "th/Ryr²"
                                                                        , FootPerSquareSeptillionYears
                                                                        , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// league per square day, defined as: mile per square hour × (3.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDay =
            new ("league per square day", "lea/dy²", MilePerSquareHour, 3.0 / (24.0 * 24.0));

   /// <summary>
   /// twip per square septillion years, defined as: foot per square sextillion years × (1.0/17280.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareSeptillionYears = new (
                                                                           "twip per square septillion years"
                                                                         , "twip/Yyr²"
                                                                         , FootPerSquareSextillionYears
                                                                         , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// furlong per square quintillion years, defined as: chain per square quadrillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuintillionYears = new (
                                                                               "furlong per square quintillion years"
                                                                             , "fur/Eyr²"
                                                                             , ChainPerSquareQuadrillionYears
                                                                             , 10.0 / (1000.0 * 1000.0)
                                                                              );

   /// <summary>
   /// nautical mile per square millennium, defined as: cable per square century × (10.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillennium = new (
                                                                              "nautical mile per square millennium"
                                                                            , "nmi/kyr²"
                                                                            , CablePerSquareCentury
                                                                            , 10.0 / (10.0 * 10.0)
                                                                             );

   /// <summary>
   /// chain per square century, defined as: yard per square decade × (22.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareCentury = new (
                                                                    "chain per square century"
                                                                  , "ch/century²"
                                                                  , YardPerSquareDecade
                                                                  , 22.0 / (10.0 * 10.0)
                                                                   );

   /// <summary>
   /// league per square octillion years, defined as: mile per square septillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareOctillionYears = new (
                                                                            "league per square octillion years"
                                                                          , "lea/Ryr²"
                                                                          , MilePerSquareSeptillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// barleycorn per square nonillion years, defined as: foot per square octillion years × (1.0/36.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareNonillionYears = new (
                                                                                "barleycorn per square nonillion years"
                                                                              , "barleycorn/Qyr²"
                                                                              , FootPerSquareOctillionYears
                                                                              , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                               );

   /// <summary>
   /// chain per square septillion years, defined as: yard per square sextillion years × (22.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareSeptillionYears = new (
                                                                            "chain per square septillion years"
                                                                          , "ch/Yyr²"
                                                                          , YardPerSquareSextillionYears
                                                                          , 22.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// cable per square decillion years, defined as: fathom per square nonillion years × (100.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareDecillionYears = new (
                                                                           "cable per square decillion years"
                                                                         , "cable/decillion yr²"
                                                                         , FathomPerSquareNonillionYears
                                                                         , 100.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// league per square year, defined as: mile per square day × (3.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYear = new (
                                                                  "league per square year"
                                                                , "lea/yr²"
                                                                , MilePerSquareDay
                                                                , 3.0 / (365.2525 * 365.2525)
                                                                 );

   /// <summary>
   /// fathom per square decillion years, defined as: foot per square nonillion years × (6.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecillionYears = new (
                                                                            "fathom per square decillion years"
                                                                          , "ftm/decillion yr²"
                                                                          , FootPerSquareNonillionYears
                                                                          , 6.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// furlong per square week, defined as: chain per square day × (10.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareWeek =
            new ("furlong per square week", "fur/wk²", ChainPerSquareDay, 10.0 / (7.0 * 7.0));

   /// <summary>
   /// twip per square octillion years, defined as: foot per square septillion years × (1.0/17280.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareOctillionYears = new (
                                                                          "twip per square octillion years"
                                                                        , "twip/Ryr²"
                                                                        , FootPerSquareSeptillionYears
                                                                        , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// nautical mile per square trillion years, defined as: cable per square billion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareTrillionYears = new (
       "nautical mile per square trillion years"
     , "nmi/Tyr²"
     , CablePerSquareBillionYears
     , 10.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// cable per square septillion years, defined as: fathom per square sextillion years × (100.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareSeptillionYears = new (
                                                                            "cable per square septillion years"
                                                                          , "cable/Yyr²"
                                                                          , FathomPerSquareSextillionYears
                                                                          , 100.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// thou per square nonillion years, defined as: foot per square octillion years × (1.0/12000.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ThouPerSquareNonillionYears = new (
                                                                          "thou per square nonillion years"
                                                                        , "th/Qyr²"
                                                                        , FootPerSquareOctillionYears
                                                                        , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// mile per square decillion years, defined as: furlong per square nonillion years × (8.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareDecillionYears = new (
                                                                          "mile per square decillion years"
                                                                        , "mi/decillion yr²"
                                                                        , FurlongPerSquareNonillionYears
                                                                        , 8.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// chain per square billion years, defined as: yard per square million years × (22.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareBillionYears = new (
                                                                         "chain per square billion years"
                                                                       , "ch/Gyr²"
                                                                       , YardPerSquareMillionYears
                                                                       , 22.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// mile per square octillion years, defined as: furlong per square septillion years × (8.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareOctillionYears = new (
                                                                          "mile per square octillion years"
                                                                        , "mi/Ryr²"
                                                                        , FurlongPerSquareSeptillionYears
                                                                        , 8.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// furlong per square decillion years, defined as: chain per square nonillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecillionYears = new (
                                                                             "furlong per square decillion years"
                                                                           , "fur/decillion yr²"
                                                                           , ChainPerSquareNonillionYears
                                                                           , 10.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// nautical mile per square week, defined as: cable per square day × (10.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareWeek =
            new ("nautical mile per square week", "nmi/wk²", CablePerSquareDay, 10.0 / (7.0 * 7.0));

   /// <summary>
   /// mile per square sextillion years, defined as: furlong per square quintillion years × (8.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareSextillionYears = new (
                                                                           "mile per square sextillion years"
                                                                         , "mi/Zyr²"
                                                                         , FurlongPerSquareQuintillionYears
                                                                         , 8.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// chain per square decillion years, defined as: yard per square nonillion years × (22.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecillionYears = new (
                                                                           "chain per square decillion years"
                                                                         , "ch/decillion yr²"
                                                                         , YardPerSquareNonillionYears
                                                                         , 22.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// twip per square nonillion years, defined as: foot per square octillion years × (1.0/17280.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration TwipPerSquareNonillionYears = new (
                                                                          "twip per square nonillion years"
                                                                        , "twip/Qyr²"
                                                                        , FootPerSquareOctillionYears
                                                                        , 1.0 / 17280.0 / (1000.0 * 1000.0)
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
   /// nautical mile per square sextillion years, defined as: cable per square quintillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSextillionYears = new (
       "nautical mile per square sextillion years"
     , "nmi/Zyr²"
     , CablePerSquareQuintillionYears
     , 10.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// chain per square year, defined as: yard per square day × (22.0)/((365.2525)*(365.2525))
   /// </summary>
   public static readonly Acceleration ChainPerSquareYear = new (
                                                                 "chain per square year"
                                                               , "ch/yr²"
                                                               , YardPerSquareDay
                                                               , 22.0 / (365.2525 * 365.2525)
                                                                );

   /// <summary>
   /// cable per square decade, defined as: fathom per square year × (100.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareDecade = new (
                                                                   "cable per square decade"
                                                                 , "cable/decade²"
                                                                 , FathomPerSquareYear
                                                                 , 100.0 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// barleycorn per square decillion years, defined as: foot per square nonillion years × (1.0/36.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDecillionYears = new (
                                                                                "barleycorn per square decillion years"
                                                                              , "barleycorn/decillion yr²"
                                                                              , FootPerSquareNonillionYears
                                                                              , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                               );

   /// <summary>
   /// mile per square decade, defined as: furlong per square year × (8.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareDecade = new (
                                                                  "mile per square decade"
                                                                , "mi/decade²"
                                                                , FurlongPerSquareYear
                                                                , 8.0 / (10.0 * 10.0)
                                                                 );

   /// <summary>
   /// nautical mile per square century, defined as: cable per square decade × (10.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareCentury = new (
                                                                           "nautical mile per square century"
                                                                         , "nmi/century²"
                                                                         , CablePerSquareDecade
                                                                         , 10.0 / (10.0 * 10.0)
                                                                          );

   /// <summary>
   /// furlong per square octillion years, defined as: chain per square septillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareOctillionYears = new (
                                                                             "furlong per square octillion years"
                                                                           , "fur/Ryr²"
                                                                           , ChainPerSquareSeptillionYears
                                                                           , 10.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// mile per square week, defined as: furlong per square day × (8.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareWeek = new (
                                                                "mile per square week"
                                                              , "mi/wk²"
                                                              , FurlongPerSquareDay
                                                              , 8.0 / (7.0 * 7.0)
                                                               );

   /// <summary>
   /// nautical mile per square nonillion years, defined as: cable per square octillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareNonillionYears = new (
       "nautical mile per square nonillion years"
     , "nmi/Qyr²"
     , CablePerSquareOctillionYears
     , 10.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// chain per square millennium, defined as: yard per square century × (22.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillennium =
            new ("chain per square millennium", "ch/kyr²", YardPerSquareCentury, 22.0 / (10.0 * 10.0));

   /// <summary>
   /// furlong per square century, defined as: chain per square decade × (10.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareCentury = new (
                                                                      "furlong per square century"
                                                                    , "fur/century²"
                                                                    , ChainPerSquareDecade
                                                                    , 10.0 / (10.0 * 10.0)
                                                                     );

   /// <summary>
   /// cable per square nonillion years, defined as: fathom per square octillion years × (100.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration CablePerSquareNonillionYears = new (
                                                                           "cable per square nonillion years"
                                                                         , "cable/Qyr²"
                                                                         , FathomPerSquareOctillionYears
                                                                         , 100.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// nautical mile per square day, defined as: cable per square hour × (10.0)/((24.0)*(24.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDay =
            new ("nautical mile per square day", "nmi/dy²", CablePerSquareHour, 10.0 / (24.0 * 24.0));

   /// <summary>
   /// league per square septillion years, defined as: mile per square sextillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSeptillionYears = new (
                                                                             "league per square septillion years"
                                                                           , "lea/Yyr²"
                                                                           , MilePerSquareSextillionYears
                                                                           , 3.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// league per square week, defined as: mile per square day × (3.0)/((7.0)*(7.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareWeek =
            new ("league per square week", "lea/wk²", MilePerSquareDay, 3.0 / (7.0 * 7.0));

   /// <summary>
   /// chain per square trillion years, defined as: yard per square billion years × (22.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration ChainPerSquareTrillionYears = new (
                                                                          "chain per square trillion years"
                                                                        , "ch/Tyr²"
                                                                        , YardPerSquareBillionYears
                                                                        , 22.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// furlong per square quadrillion years, defined as: chain per square trillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuadrillionYears = new (
                                                                               "furlong per square quadrillion years"
                                                                             , "fur/Pyr²"
                                                                             , ChainPerSquareTrillionYears
                                                                             , 10.0 / (1000.0 * 1000.0)
                                                                              );

   /// <summary>
   /// league per square nonillion years, defined as: mile per square octillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNonillionYears = new (
                                                                            "league per square nonillion years"
                                                                          , "lea/Qyr²"
                                                                          , MilePerSquareOctillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// nautical mile per square decade, defined as: cable per square year × (10.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecade = new (
                                                                          "nautical mile per square decade"
                                                                        , "nmi/decade²"
                                                                        , CablePerSquareYear
                                                                        , 10.0 / (10.0 * 10.0)
                                                                         );

   /// <summary>
   /// league per square decade, defined as: mile per square year × (3.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecade =
            new ("league per square decade", "lea/decade²", MilePerSquareYear, 3.0 / (10.0 * 10.0));

   /// <summary>
   /// nautical mile per square octillion years, defined as: cable per square septillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareOctillionYears = new (
       "nautical mile per square octillion years"
     , "nmi/Ryr²"
     , CablePerSquareSeptillionYears
     , 10.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// mile per square nonillion years, defined as: furlong per square octillion years × (8.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareNonillionYears = new (
                                                                          "mile per square nonillion years"
                                                                        , "mi/Qyr²"
                                                                        , FurlongPerSquareOctillionYears
                                                                        , 8.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// furlong per square billion years, defined as: chain per square million years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareBillionYears = new (
                                                                           "furlong per square billion years"
                                                                         , "fur/Gyr²"
                                                                         , ChainPerSquareMillionYears
                                                                         , 10.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// mile per square quintillion years, defined as: furlong per square quadrillion years × (8.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareQuintillionYears = new (
                                                                            "mile per square quintillion years"
                                                                          , "mi/Eyr²"
                                                                          , FurlongPerSquareQuadrillionYears
                                                                          , 8.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// mile per square trillion years, defined as: furlong per square billion years × (8.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareTrillionYears = new (
                                                                         "mile per square trillion years"
                                                                       , "mi/Tyr²"
                                                                       , FurlongPerSquareBillionYears
                                                                       , 8.0 / (1000.0 * 1000.0)
                                                                        );

   /// <summary>
   /// furlong per square millennium, defined as: chain per square century × (10.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillennium = new (
                                                                         "furlong per square millennium"
                                                                       , "fur/kyr²"
                                                                       , ChainPerSquareCentury
                                                                       , 10.0 / (10.0 * 10.0)
                                                                        );

   /// <summary>
   /// league per square quadrillion years, defined as: mile per square trillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuadrillionYears = new (
                                                                              "league per square quadrillion years"
                                                                            , "lea/Pyr²"
                                                                            , MilePerSquareTrillionYears
                                                                            , 3.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// league per square sextillion years, defined as: mile per square quintillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSextillionYears = new (
                                                                             "league per square sextillion years"
                                                                           , "lea/Zyr²"
                                                                           , MilePerSquareQuintillionYears
                                                                           , 3.0 / (1000.0 * 1000.0)
                                                                            );

   /// <summary>
   /// furlong per square decade, defined as: chain per square year × (10.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecade = new (
                                                                     "furlong per square decade"
                                                                   , "fur/decade²"
                                                                   , ChainPerSquareYear
                                                                   , 10.0 / (10.0 * 10.0)
                                                                    );

   /// <summary>
   /// nautical mile per square decillion years, defined as: cable per square nonillion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecillionYears = new (
       "nautical mile per square decillion years"
     , "nmi/decillion yr²"
     , CablePerSquareNonillionYears
     , 10.0 / (1000.0 * 1000.0)
      );

   /// <summary>
   /// league per square decillion years, defined as: mile per square nonillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecillionYears = new (
                                                                            "league per square decillion years"
                                                                          , "lea/decillion yr²"
                                                                          , MilePerSquareNonillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// furlong per square trillion years, defined as: chain per square billion years × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareTrillionYears = new (
                                                                            "furlong per square trillion years"
                                                                          , "fur/Tyr²"
                                                                          , ChainPerSquareBillionYears
                                                                          , 10.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// league per square century, defined as: mile per square decade × (3.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentury = new (
                                                                     "league per square century"
                                                                   , "lea/century²"
                                                                   , MilePerSquareDecade
                                                                   , 3.0 / (10.0 * 10.0)
                                                                    );

   /// <summary>
   /// mile per square quadrillion years, defined as: furlong per square trillion years × (8.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareQuadrillionYears = new (
                                                                            "mile per square quadrillion years"
                                                                          , "mi/Pyr²"
                                                                          , FurlongPerSquareTrillionYears
                                                                          , 8.0 / (1000.0 * 1000.0)
                                                                           );

   /// <summary>
   /// furlong per square million years, defined as: chain per square millennium × (10.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillionYears = new (
                                                                           "furlong per square million years"
                                                                         , "fur/Myr²"
                                                                         , ChainPerSquareMillennium
                                                                         , 10.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// mile per square millennium, defined as: furlong per square century × (8.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareMillennium = new (
                                                                      "mile per square millennium"
                                                                    , "mi/kyr²"
                                                                    , FurlongPerSquareCentury
                                                                    , 8.0 / (10.0 * 10.0)
                                                                     );

   /// <summary>
   /// league per square quintillion years, defined as: mile per square quadrillion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuintillionYears = new (
                                                                              "league per square quintillion years"
                                                                            , "lea/Eyr²"
                                                                            , MilePerSquareQuadrillionYears
                                                                            , 3.0 / (1000.0 * 1000.0)
                                                                             );

   /// <summary>
   /// mile per square million years, defined as: furlong per square millennium × (8.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareMillionYears = new (
                                                                        "mile per square million years"
                                                                      , "mi/Myr²"
                                                                      , FurlongPerSquareMillennium
                                                                      , 8.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// mile per square century, defined as: furlong per square decade × (8.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareCentury = new (
                                                                   "mile per square century"
                                                                 , "mi/century²"
                                                                 , FurlongPerSquareDecade
                                                                 , 8.0 / (10.0 * 10.0)
                                                                  );

   /// <summary>
   /// league per square billion years, defined as: mile per square million years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareBillionYears = new (
                                                                          "league per square billion years"
                                                                        , "lea/Gyr²"
                                                                        , MilePerSquareMillionYears
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// mile per square billion years, defined as: furlong per square million years × (8.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration MilePerSquareBillionYears = new (
                                                                        "mile per square billion years"
                                                                      , "mi/Gyr²"
                                                                      , FurlongPerSquareMillionYears
                                                                      , 8.0 / (1000.0 * 1000.0)
                                                                       );

   /// <summary>
   /// league per square million years, defined as: mile per square millennium × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillionYears = new (
                                                                          "league per square million years"
                                                                        , "lea/Myr²"
                                                                        , MilePerSquareMillennium
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                         );

   /// <summary>
   /// league per square trillion years, defined as: mile per square billion years × (3.0)/((1000.0)*(1000.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTrillionYears = new (
                                                                           "league per square trillion years"
                                                                         , "lea/Tyr²"
                                                                         , MilePerSquareBillionYears
                                                                         , 3.0 / (1000.0 * 1000.0)
                                                                          );

   /// <summary>
   /// league per square millennium, defined as: mile per square century × (3.0)/((10.0)*(10.0))
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillennium = new (
                                                                        "league per square millennium"
                                                                      , "lea/kyr²"
                                                                      , MilePerSquareCentury
                                                                      , 3.0 / (10.0 * 10.0)
                                                                       );
}
