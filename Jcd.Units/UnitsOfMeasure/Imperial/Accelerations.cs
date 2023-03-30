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
/// British Imperial Units for measuring Acceleration.
/// </summary>
public class Accelerations : UnitOfMeasureEnumeration<Accelerations, Acceleration>
{
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
   /// A(n) foot per square second. Defined as: (12)/((1.0)*(1.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration FootPerSquareSecond =
            new ("foot per square second", "ft/s²", InchPerSquareSecond, 12 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) foot per square decisecond. Defined as: (12)/((1.0/10.0)*(1.0/10.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration FootPerSquareDecisecond = new (
                                                                      "foot per square decisecond"
                                                                    , "ft/ds²"
                                                                    , InchPerSquareSecond
                                                                    , 12 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square centisecond. Defined as: (12)/((1.0/10.0)*(1.0/10.0)) × inch per square decisecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareCentisecond = new (
                                                                       "foot per square centisecond"
                                                                     , "ft/cs²"
                                                                     , InchPerSquareDecisecond
                                                                     , 12 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square millisecond. Defined as: (12)/((1.0/10.0)*(1.0/10.0)) × inch per square centisecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareMillisecond = new (
                                                                       "foot per square millisecond"
                                                                     , "ft/ms²"
                                                                     , InchPerSquareCentisecond
                                                                     , 12 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square microsecond. Defined as: (12)/((1.0/1000.0)*(1.0/1000.0)) × inch per square millisecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareMicrosecond = new (
                                                                       "foot per square microsecond"
                                                                     , "ft/μs²"
                                                                     , InchPerSquareMillisecond
                                                                     , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square nanosecond. Defined as: (12)/((1.0/1000.0)*(1.0/1000.0)) × inch per square microsecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareNanosecond = new (
                                                                      "foot per square nanosecond"
                                                                    , "ft/ns²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square picosecond. Defined as: (12)/((1.0/1000.0)*(1.0/1000.0)) × inch per square nanosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquarePicosecond = new (
                                                                      "foot per square picosecond"
                                                                    , "ft/ps²"
                                                                    , InchPerSquareNanosecond
                                                                    , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square femtosecond. Defined as: (12)/((1.0/1000.0)*(1.0/1000.0)) × inch per square picosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareFemtosecond = new (
                                                                       "foot per square femtosecond"
                                                                     , "ft/fs²"
                                                                     , InchPerSquarePicosecond
                                                                     , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square attosecond. Defined as: (12)/((1.0/1000.0)*(1.0/1000.0)) × inch per square femtosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareAttosecond = new (
                                                                      "foot per square attosecond"
                                                                    , "ft/as²"
                                                                    , InchPerSquareFemtosecond
                                                                    , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square zeptosecond. Defined as: (12)/((1.0/1000.0)*(1.0/1000.0)) × inch per square attosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareZeptosecond = new (
                                                                       "foot per square zeptosecond"
                                                                     , "ft/zs²"
                                                                     , InchPerSquareAttosecond
                                                                     , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square yoctosecond. Defined as: (12)/((1.0/1000.0)*(1.0/1000.0)) × inch per square zeptosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareYoctosecond = new (
                                                                       "foot per square yoctosecond"
                                                                     , "ft/ys²"
                                                                     , InchPerSquareZeptosecond
                                                                     , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square rontosecond. Defined as: (12)/((1.0/1000.0)*(1.0/1000.0)) × inch per square yoctosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareRontosecond = new (
                                                                       "foot per square rontosecond"
                                                                     , "ft/rs²"
                                                                     , InchPerSquareYoctosecond
                                                                     , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square quectosecond. Defined as: (12)/((1.0/1000.0)*(1.0/1000.0)) × inch per square rontosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareQuectosecond = new (
                                                                        "foot per square quectosecond"
                                                                      , "ft/qs²"
                                                                      , InchPerSquareRontosecond
                                                                      , 12 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) twip per square second. Defined as: (1.0/17280.0)/((1.0)*(1.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration TwipPerSquareSecond = new (
                                                                  "twip per square second"
                                                                , "twip/s²"
                                                                , FootPerSquareSecond
                                                                , 1.0 / 17280.0 / (1.0 * 1.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) twip per square decisecond. Defined as: (1.0/17280.0)/((1.0/10.0)*(1.0/10.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecisecond = new (
                                                                      "twip per square decisecond"
                                                                    , "twip/ds²"
                                                                    , FootPerSquareSecond
                                                                    , 1.0 / 17280.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square centisecond. Defined as: (1.0/17280.0)/((1.0/10.0)*(1.0/10.0)) × foot per square decisecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareCentisecond = new (
                                                                       "twip per square centisecond"
                                                                     , "twip/cs²"
                                                                     , FootPerSquareDecisecond
                                                                     , 1.0 / 17280.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square millisecond. Defined as: (1.0/17280.0)/((1.0/10.0)*(1.0/10.0)) × foot per square centisecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillisecond = new (
                                                                       "twip per square millisecond"
                                                                     , "twip/ms²"
                                                                     , FootPerSquareCentisecond
                                                                     , 1.0 / 17280.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square microsecond. Defined as: (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square millisecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareMicrosecond = new (
                                                                       "twip per square microsecond"
                                                                     , "twip/μs²"
                                                                     , FootPerSquareMillisecond
                                                                     , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square nanosecond. Defined as: (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square microsecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareNanosecond = new (
                                                                      "twip per square nanosecond"
                                                                    , "twip/ns²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square picosecond. Defined as: (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square nanosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquarePicosecond = new (
                                                                      "twip per square picosecond"
                                                                    , "twip/ps²"
                                                                    , FootPerSquareNanosecond
                                                                    , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square femtosecond. Defined as: (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square picosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareFemtosecond = new (
                                                                       "twip per square femtosecond"
                                                                     , "twip/fs²"
                                                                     , FootPerSquarePicosecond
                                                                     , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square attosecond. Defined as: (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square femtosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareAttosecond = new (
                                                                      "twip per square attosecond"
                                                                    , "twip/as²"
                                                                    , FootPerSquareFemtosecond
                                                                    , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square zeptosecond. Defined as: (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square attosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareZeptosecond = new (
                                                                       "twip per square zeptosecond"
                                                                     , "twip/zs²"
                                                                     , FootPerSquareAttosecond
                                                                     , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square yoctosecond. Defined as: (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square zeptosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareYoctosecond = new (
                                                                       "twip per square yoctosecond"
                                                                     , "twip/ys²"
                                                                     , FootPerSquareZeptosecond
                                                                     , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square rontosecond. Defined as: (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square yoctosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareRontosecond = new (
                                                                       "twip per square rontosecond"
                                                                     , "twip/rs²"
                                                                     , FootPerSquareYoctosecond
                                                                     , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square quectosecond. Defined as: (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square rontosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuectosecond = new (
                                                                        "twip per square quectosecond"
                                                                      , "twip/qs²"
                                                                      , FootPerSquareRontosecond
                                                                      , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) thou per square second. Defined as: (1.0/12000.0)/((1.0)*(1.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration ThouPerSquareSecond = new (
                                                                  "thou per square second"
                                                                , "th/s²"
                                                                , FootPerSquareSecond
                                                                , 1.0 / 12000.0 / (1.0 * 1.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) thou per square decisecond. Defined as: (1.0/12000.0)/((1.0/10.0)*(1.0/10.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration ThouPerSquareDecisecond = new (
                                                                      "thou per square decisecond"
                                                                    , "th/ds²"
                                                                    , FootPerSquareSecond
                                                                    , 1.0 / 12000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) thou per square centisecond. Defined as: (1.0/12000.0)/((1.0/10.0)*(1.0/10.0)) × foot per square decisecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquareCentisecond = new (
                                                                       "thou per square centisecond"
                                                                     , "th/cs²"
                                                                     , FootPerSquareDecisecond
                                                                     , 1.0 / 12000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) thou per square millisecond. Defined as: (1.0/12000.0)/((1.0/10.0)*(1.0/10.0)) × foot per square centisecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquareMillisecond = new (
                                                                       "thou per square millisecond"
                                                                     , "th/ms²"
                                                                     , FootPerSquareCentisecond
                                                                     , 1.0 / 12000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) thou per square microsecond. Defined as: (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square millisecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquareMicrosecond = new (
                                                                       "thou per square microsecond"
                                                                     , "th/μs²"
                                                                     , FootPerSquareMillisecond
                                                                     , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) thou per square nanosecond. Defined as: (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square microsecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquareNanosecond = new (
                                                                      "thou per square nanosecond"
                                                                    , "th/ns²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) thou per square picosecond. Defined as: (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square nanosecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquarePicosecond = new (
                                                                      "thou per square picosecond"
                                                                    , "th/ps²"
                                                                    , FootPerSquareNanosecond
                                                                    , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) thou per square femtosecond. Defined as: (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square picosecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquareFemtosecond = new (
                                                                       "thou per square femtosecond"
                                                                     , "th/fs²"
                                                                     , FootPerSquarePicosecond
                                                                     , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) thou per square attosecond. Defined as: (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square femtosecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquareAttosecond = new (
                                                                      "thou per square attosecond"
                                                                    , "th/as²"
                                                                    , FootPerSquareFemtosecond
                                                                    , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) thou per square zeptosecond. Defined as: (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square attosecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquareZeptosecond = new (
                                                                       "thou per square zeptosecond"
                                                                     , "th/zs²"
                                                                     , FootPerSquareAttosecond
                                                                     , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) thou per square yoctosecond. Defined as: (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square zeptosecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquareYoctosecond = new (
                                                                       "thou per square yoctosecond"
                                                                     , "th/ys²"
                                                                     , FootPerSquareZeptosecond
                                                                     , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) thou per square rontosecond. Defined as: (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square yoctosecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquareRontosecond = new (
                                                                       "thou per square rontosecond"
                                                                     , "th/rs²"
                                                                     , FootPerSquareYoctosecond
                                                                     , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) thou per square quectosecond. Defined as: (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square rontosecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquareQuectosecond = new (
                                                                        "thou per square quectosecond"
                                                                      , "th/qs²"
                                                                      , FootPerSquareRontosecond
                                                                      , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) barleycorn per square second. Defined as: (1.0/36.0)/((1.0)*(1.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareSecond = new (
                                                                        "barleycorn per square second"
                                                                      , "barleycorn/s²"
                                                                      , FootPerSquareSecond
                                                                      , 1.0 / 36.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) barleycorn per square decisecond. Defined as: (1.0/36.0)/((1.0/10.0)*(1.0/10.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDecisecond = new (
                                                                            "barleycorn per square decisecond"
                                                                          , "barleycorn/ds²"
                                                                          , FootPerSquareSecond
                                                                          , 1.0 / 36.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) barleycorn per square centisecond. Defined as: (1.0/36.0)/((1.0/10.0)*(1.0/10.0)) × foot per square decisecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareCentisecond = new (
                                                                             "barleycorn per square centisecond"
                                                                           , "barleycorn/cs²"
                                                                           , FootPerSquareDecisecond
                                                                           , 1.0 / 36.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) barleycorn per square millisecond. Defined as: (1.0/36.0)/((1.0/10.0)*(1.0/10.0)) × foot per square centisecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMillisecond = new (
                                                                             "barleycorn per square millisecond"
                                                                           , "barleycorn/ms²"
                                                                           , FootPerSquareCentisecond
                                                                           , 1.0 / 36.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) barleycorn per square microsecond. Defined as: (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square millisecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMicrosecond = new (
                                                                             "barleycorn per square microsecond"
                                                                           , "barleycorn/μs²"
                                                                           , FootPerSquareMillisecond
                                                                           , 1.0
                                                                           / 36.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) barleycorn per square nanosecond. Defined as: (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square microsecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareNanosecond = new (
                                                                            "barleycorn per square nanosecond"
                                                                          , "barleycorn/ns²"
                                                                          , FootPerSquareMicrosecond
                                                                          , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) barleycorn per square picosecond. Defined as: (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square nanosecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquarePicosecond = new (
                                                                            "barleycorn per square picosecond"
                                                                          , "barleycorn/ps²"
                                                                          , FootPerSquareNanosecond
                                                                          , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) barleycorn per square femtosecond. Defined as: (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square picosecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareFemtosecond = new (
                                                                             "barleycorn per square femtosecond"
                                                                           , "barleycorn/fs²"
                                                                           , FootPerSquarePicosecond
                                                                           , 1.0
                                                                           / 36.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) barleycorn per square attosecond. Defined as: (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square femtosecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareAttosecond = new (
                                                                            "barleycorn per square attosecond"
                                                                          , "barleycorn/as²"
                                                                          , FootPerSquareFemtosecond
                                                                          , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) barleycorn per square zeptosecond. Defined as: (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square attosecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareZeptosecond = new (
                                                                             "barleycorn per square zeptosecond"
                                                                           , "barleycorn/zs²"
                                                                           , FootPerSquareAttosecond
                                                                           , 1.0
                                                                           / 36.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) barleycorn per square yoctosecond. Defined as: (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square zeptosecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareYoctosecond = new (
                                                                             "barleycorn per square yoctosecond"
                                                                           , "barleycorn/ys²"
                                                                           , FootPerSquareZeptosecond
                                                                           , 1.0
                                                                           / 36.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) barleycorn per square rontosecond. Defined as: (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square yoctosecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareRontosecond = new (
                                                                             "barleycorn per square rontosecond"
                                                                           , "barleycorn/rs²"
                                                                           , FootPerSquareYoctosecond
                                                                           , 1.0
                                                                           / 36.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) barleycorn per square quectosecond. Defined as: (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square rontosecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareQuectosecond = new (
                                                                              "barleycorn per square quectosecond"
                                                                            , "barleycorn/qs²"
                                                                            , FootPerSquareRontosecond
                                                                            , 1.0
                                                                            / 36.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) hand per square second. Defined as: (4.0)/((1.0)*(1.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration HandPerSquareSecond =
            new ("hand per square second", "hh/s²", InchPerSquareSecond, 4.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) hand per square decisecond. Defined as: (4.0)/((1.0/10.0)*(1.0/10.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration HandPerSquareDecisecond = new (
                                                                      "hand per square decisecond"
                                                                    , "hh/ds²"
                                                                    , InchPerSquareSecond
                                                                    , 4.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hand per square centisecond. Defined as: (4.0)/((1.0/10.0)*(1.0/10.0)) × inch per square decisecond.
   /// </summary>
   public static readonly Acceleration HandPerSquareCentisecond = new (
                                                                       "hand per square centisecond"
                                                                     , "hh/cs²"
                                                                     , InchPerSquareDecisecond
                                                                     , 4.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hand per square millisecond. Defined as: (4.0)/((1.0/10.0)*(1.0/10.0)) × inch per square centisecond.
   /// </summary>
   public static readonly Acceleration HandPerSquareMillisecond = new (
                                                                       "hand per square millisecond"
                                                                     , "hh/ms²"
                                                                     , InchPerSquareCentisecond
                                                                     , 4.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hand per square microsecond. Defined as: (4.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square millisecond.
   /// </summary>
   public static readonly Acceleration HandPerSquareMicrosecond = new (
                                                                       "hand per square microsecond"
                                                                     , "hh/μs²"
                                                                     , InchPerSquareMillisecond
                                                                     , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hand per square nanosecond. Defined as: (4.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square microsecond.
   /// </summary>
   public static readonly Acceleration HandPerSquareNanosecond = new (
                                                                      "hand per square nanosecond"
                                                                    , "hh/ns²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hand per square picosecond. Defined as: (4.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square nanosecond.
   /// </summary>
   public static readonly Acceleration HandPerSquarePicosecond = new (
                                                                      "hand per square picosecond"
                                                                    , "hh/ps²"
                                                                    , InchPerSquareNanosecond
                                                                    , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hand per square femtosecond. Defined as: (4.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square picosecond.
   /// </summary>
   public static readonly Acceleration HandPerSquareFemtosecond = new (
                                                                       "hand per square femtosecond"
                                                                     , "hh/fs²"
                                                                     , InchPerSquarePicosecond
                                                                     , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hand per square attosecond. Defined as: (4.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square femtosecond.
   /// </summary>
   public static readonly Acceleration HandPerSquareAttosecond = new (
                                                                      "hand per square attosecond"
                                                                    , "hh/as²"
                                                                    , InchPerSquareFemtosecond
                                                                    , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hand per square zeptosecond. Defined as: (4.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square attosecond.
   /// </summary>
   public static readonly Acceleration HandPerSquareZeptosecond = new (
                                                                       "hand per square zeptosecond"
                                                                     , "hh/zs²"
                                                                     , InchPerSquareAttosecond
                                                                     , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hand per square yoctosecond. Defined as: (4.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square zeptosecond.
   /// </summary>
   public static readonly Acceleration HandPerSquareYoctosecond = new (
                                                                       "hand per square yoctosecond"
                                                                     , "hh/ys²"
                                                                     , InchPerSquareZeptosecond
                                                                     , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hand per square rontosecond. Defined as: (4.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square yoctosecond.
   /// </summary>
   public static readonly Acceleration HandPerSquareRontosecond = new (
                                                                       "hand per square rontosecond"
                                                                     , "hh/rs²"
                                                                     , InchPerSquareYoctosecond
                                                                     , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hand per square quectosecond. Defined as: (4.0)/((1.0/1000.0)*(1.0/1000.0)) × inch per square rontosecond.
   /// </summary>
   public static readonly Acceleration HandPerSquareQuectosecond = new (
                                                                        "hand per square quectosecond"
                                                                      , "hh/qs²"
                                                                      , InchPerSquareRontosecond
                                                                      , 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) chain per square second. Defined as: (22.0)/((1.0)*(1.0)) × yard per square second.
   /// </summary>
   public static readonly Acceleration ChainPerSquareSecond =
            new ("chain per square second", "ch/s²", YardPerSquareSecond, 22.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) chain per square decisecond. Defined as: (22.0)/((1.0/10.0)*(1.0/10.0)) × yard per square second.
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecisecond = new (
                                                                       "chain per square decisecond"
                                                                     , "ch/ds²"
                                                                     , YardPerSquareSecond
                                                                     , 22.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) chain per square centisecond. Defined as: (22.0)/((1.0/10.0)*(1.0/10.0)) × yard per square decisecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquareCentisecond = new (
                                                                        "chain per square centisecond"
                                                                      , "ch/cs²"
                                                                      , YardPerSquareDecisecond
                                                                      , 22.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square millisecond. Defined as: (22.0)/((1.0/10.0)*(1.0/10.0)) × yard per square centisecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillisecond = new (
                                                                        "chain per square millisecond"
                                                                      , "ch/ms²"
                                                                      , YardPerSquareCentisecond
                                                                      , 22.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square microsecond. Defined as: (22.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square millisecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquareMicrosecond = new (
                                                                        "chain per square microsecond"
                                                                      , "ch/μs²"
                                                                      , YardPerSquareMillisecond
                                                                      , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square nanosecond. Defined as: (22.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square microsecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquareNanosecond = new (
                                                                       "chain per square nanosecond"
                                                                     , "ch/ns²"
                                                                     , YardPerSquareMicrosecond
                                                                     , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) chain per square picosecond. Defined as: (22.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square nanosecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquarePicosecond = new (
                                                                       "chain per square picosecond"
                                                                     , "ch/ps²"
                                                                     , YardPerSquareNanosecond
                                                                     , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) chain per square femtosecond. Defined as: (22.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square picosecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquareFemtosecond = new (
                                                                        "chain per square femtosecond"
                                                                      , "ch/fs²"
                                                                      , YardPerSquarePicosecond
                                                                      , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square attosecond. Defined as: (22.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square femtosecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquareAttosecond = new (
                                                                       "chain per square attosecond"
                                                                     , "ch/as²"
                                                                     , YardPerSquareFemtosecond
                                                                     , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) chain per square zeptosecond. Defined as: (22.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square attosecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquareZeptosecond = new (
                                                                        "chain per square zeptosecond"
                                                                      , "ch/zs²"
                                                                      , YardPerSquareAttosecond
                                                                      , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square yoctosecond. Defined as: (22.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square zeptosecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquareYoctosecond = new (
                                                                        "chain per square yoctosecond"
                                                                      , "ch/ys²"
                                                                      , YardPerSquareZeptosecond
                                                                      , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square rontosecond. Defined as: (22.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square yoctosecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquareRontosecond = new (
                                                                        "chain per square rontosecond"
                                                                      , "ch/rs²"
                                                                      , YardPerSquareYoctosecond
                                                                      , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square quectosecond. Defined as: (22.0)/((1.0/1000.0)*(1.0/1000.0)) × yard per square rontosecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuectosecond = new (
                                                                         "chain per square quectosecond"
                                                                       , "ch/qs²"
                                                                       , YardPerSquareRontosecond
                                                                       , 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) furlong per square second. Defined as: (10.0)/((1.0)*(1.0)) × chain per square second.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSecond =
            new ("furlong per square second", "fur/s²", ChainPerSquareSecond, 10.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) furlong per square decisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × chain per square second.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecisecond = new (
                                                                         "furlong per square decisecond"
                                                                       , "fur/ds²"
                                                                       , ChainPerSquareSecond
                                                                       , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square centisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × chain per square decisecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareCentisecond = new (
                                                                          "furlong per square centisecond"
                                                                        , "fur/cs²"
                                                                        , ChainPerSquareDecisecond
                                                                        , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square millisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × chain per square centisecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillisecond = new (
                                                                          "furlong per square millisecond"
                                                                        , "fur/ms²"
                                                                        , ChainPerSquareCentisecond
                                                                        , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square microsecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × chain per square millisecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMicrosecond = new (
                                                                          "furlong per square microsecond"
                                                                        , "fur/μs²"
                                                                        , ChainPerSquareMillisecond
                                                                        , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square nanosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × chain per square microsecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareNanosecond = new (
                                                                         "furlong per square nanosecond"
                                                                       , "fur/ns²"
                                                                       , ChainPerSquareMicrosecond
                                                                       , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square picosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × chain per square nanosecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquarePicosecond = new (
                                                                         "furlong per square picosecond"
                                                                       , "fur/ps²"
                                                                       , ChainPerSquareNanosecond
                                                                       , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square femtosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × chain per square picosecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareFemtosecond = new (
                                                                          "furlong per square femtosecond"
                                                                        , "fur/fs²"
                                                                        , ChainPerSquarePicosecond
                                                                        , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square attosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × chain per square femtosecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareAttosecond = new (
                                                                         "furlong per square attosecond"
                                                                       , "fur/as²"
                                                                       , ChainPerSquareFemtosecond
                                                                       , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square zeptosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × chain per square attosecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareZeptosecond = new (
                                                                          "furlong per square zeptosecond"
                                                                        , "fur/zs²"
                                                                        , ChainPerSquareAttosecond
                                                                        , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square yoctosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × chain per square zeptosecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareYoctosecond = new (
                                                                          "furlong per square yoctosecond"
                                                                        , "fur/ys²"
                                                                        , ChainPerSquareZeptosecond
                                                                        , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square rontosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × chain per square yoctosecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareRontosecond = new (
                                                                          "furlong per square rontosecond"
                                                                        , "fur/rs²"
                                                                        , ChainPerSquareYoctosecond
                                                                        , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square quectosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × chain per square rontosecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuectosecond = new (
                                                                           "furlong per square quectosecond"
                                                                         , "fur/qs²"
                                                                         , ChainPerSquareRontosecond
                                                                         , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) mile per square second. Defined as: (8.0)/((1.0)*(1.0)) × furlong per square second.
   /// </summary>
   public static readonly Acceleration MilePerSquareSecond =
            new ("mile per square second", "mi/s²", FurlongPerSquareSecond, 8.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) mile per square decisecond. Defined as: (8.0)/((1.0/10.0)*(1.0/10.0)) × furlong per square second.
   /// </summary>
   public static readonly Acceleration MilePerSquareDecisecond = new (
                                                                      "mile per square decisecond"
                                                                    , "mi/ds²"
                                                                    , FurlongPerSquareSecond
                                                                    , 8.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mile per square centisecond. Defined as: (8.0)/((1.0/10.0)*(1.0/10.0)) × furlong per square decisecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareCentisecond = new (
                                                                       "mile per square centisecond"
                                                                     , "mi/cs²"
                                                                     , FurlongPerSquareDecisecond
                                                                     , 8.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square millisecond. Defined as: (8.0)/((1.0/10.0)*(1.0/10.0)) × furlong per square centisecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareMillisecond = new (
                                                                       "mile per square millisecond"
                                                                     , "mi/ms²"
                                                                     , FurlongPerSquareCentisecond
                                                                     , 8.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square microsecond. Defined as: (8.0)/((1.0/1000.0)*(1.0/1000.0)) × furlong per square millisecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareMicrosecond = new (
                                                                       "mile per square microsecond"
                                                                     , "mi/μs²"
                                                                     , FurlongPerSquareMillisecond
                                                                     , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square nanosecond. Defined as: (8.0)/((1.0/1000.0)*(1.0/1000.0)) × furlong per square microsecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareNanosecond = new (
                                                                      "mile per square nanosecond"
                                                                    , "mi/ns²"
                                                                    , FurlongPerSquareMicrosecond
                                                                    , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mile per square picosecond. Defined as: (8.0)/((1.0/1000.0)*(1.0/1000.0)) × furlong per square nanosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquarePicosecond = new (
                                                                      "mile per square picosecond"
                                                                    , "mi/ps²"
                                                                    , FurlongPerSquareNanosecond
                                                                    , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mile per square femtosecond. Defined as: (8.0)/((1.0/1000.0)*(1.0/1000.0)) × furlong per square picosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareFemtosecond = new (
                                                                       "mile per square femtosecond"
                                                                     , "mi/fs²"
                                                                     , FurlongPerSquarePicosecond
                                                                     , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square attosecond. Defined as: (8.0)/((1.0/1000.0)*(1.0/1000.0)) × furlong per square femtosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareAttosecond = new (
                                                                      "mile per square attosecond"
                                                                    , "mi/as²"
                                                                    , FurlongPerSquareFemtosecond
                                                                    , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) mile per square zeptosecond. Defined as: (8.0)/((1.0/1000.0)*(1.0/1000.0)) × furlong per square attosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareZeptosecond = new (
                                                                       "mile per square zeptosecond"
                                                                     , "mi/zs²"
                                                                     , FurlongPerSquareAttosecond
                                                                     , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square yoctosecond. Defined as: (8.0)/((1.0/1000.0)*(1.0/1000.0)) × furlong per square zeptosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareYoctosecond = new (
                                                                       "mile per square yoctosecond"
                                                                     , "mi/ys²"
                                                                     , FurlongPerSquareZeptosecond
                                                                     , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square rontosecond. Defined as: (8.0)/((1.0/1000.0)*(1.0/1000.0)) × furlong per square yoctosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareRontosecond = new (
                                                                       "mile per square rontosecond"
                                                                     , "mi/rs²"
                                                                     , FurlongPerSquareYoctosecond
                                                                     , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) mile per square quectosecond. Defined as: (8.0)/((1.0/1000.0)*(1.0/1000.0)) × furlong per square rontosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareQuectosecond = new (
                                                                        "mile per square quectosecond"
                                                                      , "mi/qs²"
                                                                      , FurlongPerSquareRontosecond
                                                                      , 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) league per square second. Defined as: (3.0)/((1.0)*(1.0)) × mile per square second.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSecond =
            new ("league per square second", "lea/s²", MilePerSquareSecond, 3.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) league per square decisecond. Defined as: (3.0)/((1.0/10.0)*(1.0/10.0)) × mile per square second.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecisecond = new (
                                                                        "league per square decisecond"
                                                                      , "lea/ds²"
                                                                      , MilePerSquareSecond
                                                                      , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square centisecond. Defined as: (3.0)/((1.0/10.0)*(1.0/10.0)) × mile per square decisecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentisecond = new (
                                                                         "league per square centisecond"
                                                                       , "lea/cs²"
                                                                       , MilePerSquareDecisecond
                                                                       , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square millisecond. Defined as: (3.0)/((1.0/10.0)*(1.0/10.0)) × mile per square centisecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillisecond = new (
                                                                         "league per square millisecond"
                                                                       , "lea/ms²"
                                                                       , MilePerSquareCentisecond
                                                                       , 3.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square microsecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square millisecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMicrosecond = new (
                                                                         "league per square microsecond"
                                                                       , "lea/μs²"
                                                                       , MilePerSquareMillisecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square nanosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square microsecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNanosecond = new (
                                                                        "league per square nanosecond"
                                                                      , "lea/ns²"
                                                                      , MilePerSquareMicrosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square picosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square nanosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePicosecond = new (
                                                                        "league per square picosecond"
                                                                      , "lea/ps²"
                                                                      , MilePerSquareNanosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square femtosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square picosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareFemtosecond = new (
                                                                         "league per square femtosecond"
                                                                       , "lea/fs²"
                                                                       , MilePerSquarePicosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square attosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square femtosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareAttosecond = new (
                                                                        "league per square attosecond"
                                                                      , "lea/as²"
                                                                      , MilePerSquareFemtosecond
                                                                      , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square zeptosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square attosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareZeptosecond = new (
                                                                         "league per square zeptosecond"
                                                                       , "lea/zs²"
                                                                       , MilePerSquareAttosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square yoctosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square zeptosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYoctosecond = new (
                                                                         "league per square yoctosecond"
                                                                       , "lea/ys²"
                                                                       , MilePerSquareZeptosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square rontosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square yoctosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareRontosecond = new (
                                                                         "league per square rontosecond"
                                                                       , "lea/rs²"
                                                                       , MilePerSquareYoctosecond
                                                                       , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square quectosecond. Defined as: (3.0)/((1.0/1000.0)*(1.0/1000.0)) × mile per square rontosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuectosecond = new (
                                                                          "league per square quectosecond"
                                                                        , "lea/qs²"
                                                                        , MilePerSquareRontosecond
                                                                        , 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) fathom per square second. Defined as: (6.0)/((1.0)*(1.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration FathomPerSquareSecond =
            new ("fathom per square second", "ftm/s²", FootPerSquareSecond, 6.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) fathom per square decisecond. Defined as: (6.0)/((1.0/10.0)*(1.0/10.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecisecond = new (
                                                                        "fathom per square decisecond"
                                                                      , "ftm/ds²"
                                                                      , FootPerSquareSecond
                                                                      , 6.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square centisecond. Defined as: (6.0)/((1.0/10.0)*(1.0/10.0)) × foot per square decisecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareCentisecond = new (
                                                                         "fathom per square centisecond"
                                                                       , "ftm/cs²"
                                                                       , FootPerSquareDecisecond
                                                                       , 6.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square millisecond. Defined as: (6.0)/((1.0/10.0)*(1.0/10.0)) × foot per square centisecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillisecond = new (
                                                                         "fathom per square millisecond"
                                                                       , "ftm/ms²"
                                                                       , FootPerSquareCentisecond
                                                                       , 6.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square microsecond. Defined as: (6.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square millisecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareMicrosecond = new (
                                                                         "fathom per square microsecond"
                                                                       , "ftm/μs²"
                                                                       , FootPerSquareMillisecond
                                                                       , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square nanosecond. Defined as: (6.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square microsecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareNanosecond = new (
                                                                        "fathom per square nanosecond"
                                                                      , "ftm/ns²"
                                                                      , FootPerSquareMicrosecond
                                                                      , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square picosecond. Defined as: (6.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square nanosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquarePicosecond = new (
                                                                        "fathom per square picosecond"
                                                                      , "ftm/ps²"
                                                                      , FootPerSquareNanosecond
                                                                      , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square femtosecond. Defined as: (6.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square picosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareFemtosecond = new (
                                                                         "fathom per square femtosecond"
                                                                       , "ftm/fs²"
                                                                       , FootPerSquarePicosecond
                                                                       , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square attosecond. Defined as: (6.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square femtosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareAttosecond = new (
                                                                        "fathom per square attosecond"
                                                                      , "ftm/as²"
                                                                      , FootPerSquareFemtosecond
                                                                      , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) fathom per square zeptosecond. Defined as: (6.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square attosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareZeptosecond = new (
                                                                         "fathom per square zeptosecond"
                                                                       , "ftm/zs²"
                                                                       , FootPerSquareAttosecond
                                                                       , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square yoctosecond. Defined as: (6.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square zeptosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareYoctosecond = new (
                                                                         "fathom per square yoctosecond"
                                                                       , "ftm/ys²"
                                                                       , FootPerSquareZeptosecond
                                                                       , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square rontosecond. Defined as: (6.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square yoctosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareRontosecond = new (
                                                                         "fathom per square rontosecond"
                                                                       , "ftm/rs²"
                                                                       , FootPerSquareYoctosecond
                                                                       , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square quectosecond. Defined as: (6.0)/((1.0/1000.0)*(1.0/1000.0)) × foot per square rontosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuectosecond = new (
                                                                          "fathom per square quectosecond"
                                                                        , "ftm/qs²"
                                                                        , FootPerSquareRontosecond
                                                                        , 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) cable per square second. Defined as: (100.0)/((1.0)*(1.0)) × fathom per square second.
   /// </summary>
   public static readonly Acceleration CablePerSquareSecond = new (
                                                                   "cable per square second"
                                                                 , "cable/s²"
                                                                 , FathomPerSquareSecond
                                                                 , 100.0 / (1.0 * 1.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) cable per square decisecond. Defined as: (100.0)/((1.0/10.0)*(1.0/10.0)) × fathom per square second.
   /// </summary>
   public static readonly Acceleration CablePerSquareDecisecond = new (
                                                                       "cable per square decisecond"
                                                                     , "cable/ds²"
                                                                     , FathomPerSquareSecond
                                                                     , 100.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) cable per square centisecond. Defined as: (100.0)/((1.0/10.0)*(1.0/10.0)) × fathom per square decisecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareCentisecond = new (
                                                                        "cable per square centisecond"
                                                                      , "cable/cs²"
                                                                      , FathomPerSquareDecisecond
                                                                      , 100.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square millisecond. Defined as: (100.0)/((1.0/10.0)*(1.0/10.0)) × fathom per square centisecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareMillisecond = new (
                                                                        "cable per square millisecond"
                                                                      , "cable/ms²"
                                                                      , FathomPerSquareCentisecond
                                                                      , 100.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square microsecond. Defined as: (100.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square millisecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareMicrosecond = new (
                                                                        "cable per square microsecond"
                                                                      , "cable/μs²"
                                                                      , FathomPerSquareMillisecond
                                                                      , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square nanosecond. Defined as: (100.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square microsecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareNanosecond = new (
                                                                       "cable per square nanosecond"
                                                                     , "cable/ns²"
                                                                     , FathomPerSquareMicrosecond
                                                                     , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) cable per square picosecond. Defined as: (100.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square nanosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquarePicosecond = new (
                                                                       "cable per square picosecond"
                                                                     , "cable/ps²"
                                                                     , FathomPerSquareNanosecond
                                                                     , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) cable per square femtosecond. Defined as: (100.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square picosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareFemtosecond = new (
                                                                        "cable per square femtosecond"
                                                                      , "cable/fs²"
                                                                      , FathomPerSquarePicosecond
                                                                      , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square attosecond. Defined as: (100.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square femtosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareAttosecond = new (
                                                                       "cable per square attosecond"
                                                                     , "cable/as²"
                                                                     , FathomPerSquareFemtosecond
                                                                     , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) cable per square zeptosecond. Defined as: (100.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square attosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareZeptosecond = new (
                                                                        "cable per square zeptosecond"
                                                                      , "cable/zs²"
                                                                      , FathomPerSquareAttosecond
                                                                      , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square yoctosecond. Defined as: (100.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square zeptosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareYoctosecond = new (
                                                                        "cable per square yoctosecond"
                                                                      , "cable/ys²"
                                                                      , FathomPerSquareZeptosecond
                                                                      , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square rontosecond. Defined as: (100.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square yoctosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareRontosecond = new (
                                                                        "cable per square rontosecond"
                                                                      , "cable/rs²"
                                                                      , FathomPerSquareYoctosecond
                                                                      , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) cable per square quectosecond. Defined as: (100.0)/((1.0/1000.0)*(1.0/1000.0)) × fathom per square rontosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareQuectosecond = new (
                                                                         "cable per square quectosecond"
                                                                       , "cable/qs²"
                                                                       , FathomPerSquareRontosecond
                                                                       , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) nautical mile per square second. Defined as: (10.0)/((1.0)*(1.0)) × cable per square second.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSecond = new (
                                                                          "nautical mile per square second"
                                                                        , "nmi/s²"
                                                                        , CablePerSquareSecond
                                                                        , 10.0 / (1.0 * 1.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) nautical mile per square decisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × cable per square second.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecisecond = new (
                                                                              "nautical mile per square decisecond"
                                                                            , "nmi/ds²"
                                                                            , CablePerSquareSecond
                                                                            , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) nautical mile per square centisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × cable per square decisecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareCentisecond = new (
                                                                               "nautical mile per square centisecond"
                                                                             , "nmi/cs²"
                                                                             , CablePerSquareDecisecond
                                                                             , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square millisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × cable per square centisecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillisecond = new (
                                                                               "nautical mile per square millisecond"
                                                                             , "nmi/ms²"
                                                                             , CablePerSquareCentisecond
                                                                             , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square microsecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × cable per square millisecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMicrosecond = new (
                                                                               "nautical mile per square microsecond"
                                                                             , "nmi/μs²"
                                                                             , CablePerSquareMillisecond
                                                                             , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square nanosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × cable per square microsecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareNanosecond = new (
                                                                              "nautical mile per square nanosecond"
                                                                            , "nmi/ns²"
                                                                            , CablePerSquareMicrosecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) nautical mile per square picosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × cable per square nanosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquarePicosecond = new (
                                                                              "nautical mile per square picosecond"
                                                                            , "nmi/ps²"
                                                                            , CablePerSquareNanosecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) nautical mile per square femtosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × cable per square picosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareFemtosecond = new (
                                                                               "nautical mile per square femtosecond"
                                                                             , "nmi/fs²"
                                                                             , CablePerSquarePicosecond
                                                                             , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square attosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × cable per square femtosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareAttosecond = new (
                                                                              "nautical mile per square attosecond"
                                                                            , "nmi/as²"
                                                                            , CablePerSquareFemtosecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) nautical mile per square zeptosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × cable per square attosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareZeptosecond = new (
                                                                               "nautical mile per square zeptosecond"
                                                                             , "nmi/zs²"
                                                                             , CablePerSquareAttosecond
                                                                             , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square yoctosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × cable per square zeptosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareYoctosecond = new (
                                                                               "nautical mile per square yoctosecond"
                                                                             , "nmi/ys²"
                                                                             , CablePerSquareZeptosecond
                                                                             , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square rontosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × cable per square yoctosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareRontosecond = new (
                                                                               "nautical mile per square rontosecond"
                                                                             , "nmi/rs²"
                                                                             , CablePerSquareYoctosecond
                                                                             , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square quectosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × cable per square rontosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuectosecond = new (
                                                                                "nautical mile per square quectosecond"
                                                                              , "nmi/qs²"
                                                                              , CablePerSquareRontosecond
                                                                              , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
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
   /// A(n) foot per square planck-time. Defined as: (12)/((5.391247E-38)*(5.391247E-38)) × inch per square microsecond.
   /// </summary>
   public static readonly Acceleration FootPerSquarePlanckTime = new (
                                                                      "foot per square planck-time"
                                                                    , "ft/tₚ²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 12 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square minute. Defined as: (12)/((60.0)*(60.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration FootPerSquareMinute =
            new ("foot per square minute", "ft/min²", InchPerSquareSecond, 12 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) twip per square planck-time. Defined as: (1.0/17280.0)/((5.391247E-38)*(5.391247E-38)) × foot per square microsecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquarePlanckTime = new (
                                                                      "twip per square planck-time"
                                                                    , "twip/tₚ²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 1.0 / 17280.0 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hand per square septillion years. Defined as: (4.0)/((1000.0)*(1000.0)) × inch per square sextillion years.
   /// </summary>
   public static readonly Acceleration HandPerSquareSeptillionYears = new (
                                                                           "hand per square septillion years"
                                                                         , "hh/Yyr²"
                                                                         , InchPerSquareSextillionYears
                                                                         , 4.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) thou per square tick. Defined as: (1.0/12000.0)/((100.0)*(100.0)) × foot per square nanosecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquareTick = new (
                                                                "thou per square tick"
                                                              , "th/tick²"
                                                              , FootPerSquareNanosecond
                                                              , 1.0 / 12000.0 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) hand per square week. Defined as: (4.0)/((7.0)*(7.0)) × inch per square day.
   /// </summary>
   public static readonly Acceleration HandPerSquareWeek = new (
                                                                "hand per square week"
                                                              , "hh/wk²"
                                                              , InchPerSquareDay
                                                              , 4.0 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) thou per square planck-time. Defined as: (1.0/12000.0)/((5.391247E-38)*(5.391247E-38)) × foot per square microsecond.
   /// </summary>
   public static readonly Acceleration ThouPerSquarePlanckTime = new (
                                                                      "thou per square planck-time"
                                                                    , "th/tₚ²"
                                                                    , FootPerSquareMicrosecond
                                                                    , 1.0 / 12000.0 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square hour. Defined as: (12)/((60.0)*(60.0)) × inch per square minute.
   /// </summary>
   public static readonly Acceleration FootPerSquareHour = new (
                                                                "foot per square hour"
                                                              , "ft/hr²"
                                                              , InchPerSquareMinute
                                                              , 12 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) twip per square minute. Defined as: (1.0/17280.0)/((60.0)*(60.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration TwipPerSquareMinute = new (
                                                                  "twip per square minute"
                                                                , "twip/min²"
                                                                , FootPerSquareSecond
                                                                , 1.0 / 17280.0 / (60.0 * 60.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) barleycorn per square planck-time. Defined as: (1.0/36.0)/((5.391247E-38)*(5.391247E-38)) × foot per square microsecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquarePlanckTime = new (
                                                                            "barleycorn per square planck-time"
                                                                          , "barleycorn/tₚ²"
                                                                          , FootPerSquareMicrosecond
                                                                          , 1.0 / 36.0 / (5.391247E-38 * 5.391247E-38)
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
   /// A(n) hand per square planck-time. Defined as: (4.0)/((5.391247E-38)*(5.391247E-38)) × inch per square microsecond.
   /// </summary>
   public static readonly Acceleration HandPerSquarePlanckTime = new (
                                                                      "hand per square planck-time"
                                                                    , "hh/tₚ²"
                                                                    , InchPerSquareMicrosecond
                                                                    , 4.0 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square day. Defined as: (12)/((24.0)*(24.0)) × inch per square hour.
   /// </summary>
   public static readonly Acceleration FootPerSquareDay = new (
                                                               "foot per square day"
                                                             , "ft/dy²"
                                                             , InchPerSquareHour
                                                             , 12 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) thou per square minute. Defined as: (1.0/12000.0)/((60.0)*(60.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration ThouPerSquareMinute = new (
                                                                  "thou per square minute"
                                                                , "th/min²"
                                                                , FootPerSquareSecond
                                                                , 1.0 / 12000.0 / (60.0 * 60.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) hand per square millennium. Defined as: (4.0)/((10.0)*(10.0)) × inch per square century.
   /// </summary>
   public static readonly Acceleration HandPerSquareMillennium = new (
                                                                      "hand per square millennium"
                                                                    , "hh/kyr²"
                                                                    , InchPerSquareCentury
                                                                    , 4.0 / (10.0 * 10.0)
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
   /// A(n) fathom per square hour. Defined as: (6.0)/((60.0)*(60.0)) × foot per square minute.
   /// </summary>
   public static readonly Acceleration FathomPerSquareHour =
            new ("fathom per square hour", "ftm/hr²", FootPerSquareMinute, 6.0 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) mile per square tick. Defined as: (8.0)/((100.0)*(100.0)) × furlong per square nanosecond.
   /// </summary>
   public static readonly Acceleration MilePerSquareTick = new (
                                                                "mile per square tick"
                                                              , "mi/tick²"
                                                              , FurlongPerSquareNanosecond
                                                              , 8.0 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) chain per square planck-time. Defined as: (22.0)/((5.391247E-38)*(5.391247E-38)) × yard per square microsecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquarePlanckTime = new (
                                                                       "chain per square planck-time"
                                                                     , "ch/tₚ²"
                                                                     , YardPerSquareMicrosecond
                                                                     , 22.0 / (5.391247E-38 * 5.391247E-38)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) twip per square hour. Defined as: (1.0/17280.0)/((60.0)*(60.0)) × foot per square minute.
   /// </summary>
   public static readonly Acceleration TwipPerSquareHour = new (
                                                                "twip per square hour"
                                                              , "twip/hr²"
                                                              , FootPerSquareMinute
                                                              , 1.0 / 17280.0 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) foot per square week. Defined as: (12)/((7.0)*(7.0)) × inch per square day.
   /// </summary>
   public static readonly Acceleration FootPerSquareWeek = new (
                                                                "foot per square week"
                                                              , "ft/wk²"
                                                              , InchPerSquareDay
                                                              , 12 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) barleycorn per square minute. Defined as: (1.0/36.0)/((60.0)*(60.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMinute = new (
                                                                        "barleycorn per square minute"
                                                                      , "barleycorn/min²"
                                                                      , FootPerSquareSecond
                                                                      , 1.0 / 36.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) furlong per square planck-time. Defined as: (10.0)/((5.391247E-38)*(5.391247E-38)) × chain per square microsecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquarePlanckTime = new (
                                                                         "furlong per square planck-time"
                                                                       , "fur/tₚ²"
                                                                       , ChainPerSquareMicrosecond
                                                                       , 10.0 / (5.391247E-38 * 5.391247E-38)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) hand per square quadrillion years. Defined as: (4.0)/((1000.0)*(1000.0)) × inch per square trillion years.
   /// </summary>
   public static readonly Acceleration HandPerSquareQuadrillionYears = new (
                                                                            "hand per square quadrillion years"
                                                                          , "hh/Pyr²"
                                                                          , InchPerSquareTrillionYears
                                                                          , 4.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) cable per square tick. Defined as: (100.0)/((100.0)*(100.0)) × fathom per square nanosecond.
   /// </summary>
   public static readonly Acceleration CablePerSquareTick = new (
                                                                 "cable per square tick"
                                                               , "cable/tick²"
                                                               , FathomPerSquareNanosecond
                                                               , 100.0 / (100.0 * 100.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) mile per square planck-time. Defined as: (8.0)/((5.391247E-38)*(5.391247E-38)) × furlong per square microsecond.
   /// </summary>
   public static readonly Acceleration MilePerSquarePlanckTime = new (
                                                                      "mile per square planck-time"
                                                                    , "mi/tₚ²"
                                                                    , FurlongPerSquareMicrosecond
                                                                    , 8.0 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square year. Defined as: (12)/((365.2525)*(365.2525)) × inch per square day.
   /// </summary>
   public static readonly Acceleration FootPerSquareYear = new (
                                                                "foot per square year"
                                                              , "ft/yr²"
                                                              , InchPerSquareDay
                                                              , 12 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) hand per square minute. Defined as: (4.0)/((60.0)*(60.0)) × inch per square second.
   /// </summary>
   public static readonly Acceleration HandPerSquareMinute =
            new ("hand per square minute", "hh/min²", InchPerSquareSecond, 4.0 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) league per square planck-time. Defined as: (3.0)/((5.391247E-38)*(5.391247E-38)) × mile per square microsecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePlanckTime = new (
                                                                        "league per square planck-time"
                                                                      , "lea/tₚ²"
                                                                      , MilePerSquareMicrosecond
                                                                      , 3.0 / (5.391247E-38 * 5.391247E-38)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) barleycorn per square decade. Defined as: (1.0/36.0)/((10.0)*(10.0)) × foot per square year.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDecade = new (
                                                                        "barleycorn per square decade"
                                                                      , "barleycorn/decade²"
                                                                      , FootPerSquareYear
                                                                      , 1.0 / 36.0 / (10.0 * 10.0)
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
   /// A(n) twip per square day. Defined as: (1.0/17280.0)/((24.0)*(24.0)) × foot per square hour.
   /// </summary>
   public static readonly Acceleration TwipPerSquareDay = new (
                                                               "twip per square day"
                                                             , "twip/dy²"
                                                             , FootPerSquareHour
                                                             , 1.0 / 17280.0 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) thou per square hour. Defined as: (1.0/12000.0)/((60.0)*(60.0)) × foot per square minute.
   /// </summary>
   public static readonly Acceleration ThouPerSquareHour = new (
                                                                "thou per square hour"
                                                              , "th/hr²"
                                                              , FootPerSquareMinute
                                                              , 1.0 / 12000.0 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) foot per square decade. Defined as: (12)/((10.0)*(10.0)) × inch per square year.
   /// </summary>
   public static readonly Acceleration FootPerSquareDecade =
            new ("foot per square decade", "ft/decade²", InchPerSquareYear, 12 / (10.0 * 10.0), 0);

   /// <summary>
   /// A(n) yard per square minute. Defined as: (3.0)/((60.0)*(60.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration YardPerSquareMinute =
            new ("yard per square minute", "yd/min²", FootPerSquareSecond, 3.0 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) fathom per square planck-time. Defined as: (6.0)/((5.391247E-38)*(5.391247E-38)) × foot per square microsecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquarePlanckTime = new (
                                                                        "fathom per square planck-time"
                                                                      , "ftm/tₚ²"
                                                                      , FootPerSquareMicrosecond
                                                                      , 6.0 / (5.391247E-38 * 5.391247E-38)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) hand per square octillion years. Defined as: (4.0)/((1000.0)*(1000.0)) × inch per square septillion years.
   /// </summary>
   public static readonly Acceleration HandPerSquareOctillionYears = new (
                                                                          "hand per square octillion years"
                                                                        , "hh/Ryr²"
                                                                        , InchPerSquareSeptillionYears
                                                                        , 4.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) hand per square year. Defined as: (4.0)/((365.2525)*(365.2525)) × inch per square day.
   /// </summary>
   public static readonly Acceleration HandPerSquareYear = new (
                                                                "hand per square year"
                                                              , "hh/yr²"
                                                              , InchPerSquareDay
                                                              , 4.0 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) foot per square tick. Defined as: (12)/((100.0)*(100.0)) × inch per square nanosecond.
   /// </summary>
   public static readonly Acceleration FootPerSquareTick = new (
                                                                "foot per square tick"
                                                              , "ft/tick²"
                                                              , InchPerSquareNanosecond
                                                              , 12 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) cable per square planck-time. Defined as: (100.0)/((5.391247E-38)*(5.391247E-38)) × fathom per square microsecond.
   /// </summary>
   public static readonly Acceleration CablePerSquarePlanckTime = new (
                                                                       "cable per square planck-time"
                                                                     , "cable/tₚ²"
                                                                     , FathomPerSquareMicrosecond
                                                                     , 100.0 / (5.391247E-38 * 5.391247E-38)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) foot per square century. Defined as: (12)/((10.0)*(10.0)) × inch per square decade.
   /// </summary>
   public static readonly Acceleration FootPerSquareCentury = new (
                                                                   "foot per square century"
                                                                 , "ft/century²"
                                                                 , InchPerSquareDecade
                                                                 , 12 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) chain per square minute. Defined as: (22.0)/((60.0)*(60.0)) × yard per square second.
   /// </summary>
   public static readonly Acceleration ChainPerSquareMinute = new (
                                                                   "chain per square minute"
                                                                 , "ch/min²"
                                                                 , YardPerSquareSecond
                                                                 , 22.0 / (60.0 * 60.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) fathom per square week. Defined as: (6.0)/((7.0)*(7.0)) × foot per square day.
   /// </summary>
   public static readonly Acceleration FathomPerSquareWeek =
            new ("fathom per square week", "ftm/wk²", FootPerSquareDay, 6.0 / (7.0 * 7.0), 0);

   /// <summary>
   /// A(n) nautical mile per square planck-time. Defined as: (10.0)/((5.391247E-38)*(5.391247E-38)) × cable per square microsecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquarePlanckTime = new (
                                                                              "nautical mile per square planck-time"
                                                                            , "nmi/tₚ²"
                                                                            , CablePerSquareMicrosecond
                                                                            , 10.0 / (5.391247E-38 * 5.391247E-38)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) barleycorn per square tick. Defined as: (1.0/36.0)/((100.0)*(100.0)) × foot per square nanosecond.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareTick = new (
                                                                      "barleycorn per square tick"
                                                                    , "barleycorn/tick²"
                                                                    , FootPerSquareNanosecond
                                                                    , 1.0 / 36.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square week. Defined as: (1.0/17280.0)/((7.0)*(7.0)) × foot per square day.
   /// </summary>
   public static readonly Acceleration TwipPerSquareWeek = new (
                                                                "twip per square week"
                                                              , "twip/wk²"
                                                              , FootPerSquareDay
                                                              , 1.0 / 17280.0 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) barleycorn per square hour. Defined as: (1.0/36.0)/((60.0)*(60.0)) × foot per square minute.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareHour = new (
                                                                      "barleycorn per square hour"
                                                                    , "barleycorn/hr²"
                                                                    , FootPerSquareMinute
                                                                    , 1.0 / 36.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) foot per square millennium. Defined as: (12)/((10.0)*(10.0)) × inch per square century.
   /// </summary>
   public static readonly Acceleration FootPerSquareMillennium = new (
                                                                      "foot per square millennium"
                                                                    , "ft/kyr²"
                                                                    , InchPerSquareCentury
                                                                    , 12 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) furlong per square minute. Defined as: (10.0)/((60.0)*(60.0)) × chain per square second.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMinute = new (
                                                                     "furlong per square minute"
                                                                   , "fur/min²"
                                                                   , ChainPerSquareSecond
                                                                   , 10.0 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) hand per square million years. Defined as: (4.0)/((1000.0)*(1000.0)) × inch per square millennium.
   /// </summary>
   public static readonly Acceleration HandPerSquareMillionYears = new (
                                                                        "hand per square million years"
                                                                      , "hh/Myr²"
                                                                      , InchPerSquareMillennium
                                                                      , 4.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) thou per square million years. Defined as: (1.0/12000.0)/((1000.0)*(1000.0)) × foot per square millennium.
   /// </summary>
   public static readonly Acceleration ThouPerSquareMillionYears = new (
                                                                        "thou per square million years"
                                                                      , "th/Myr²"
                                                                      , FootPerSquareMillennium
                                                                      , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square tick. Defined as: (22.0)/((100.0)*(100.0)) × yard per square nanosecond.
   /// </summary>
   public static readonly Acceleration ChainPerSquareTick = new (
                                                                 "chain per square tick"
                                                               , "ch/tick²"
                                                               , YardPerSquareNanosecond
                                                               , 22.0 / (100.0 * 100.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) thou per square day. Defined as: (1.0/12000.0)/((24.0)*(24.0)) × foot per square hour.
   /// </summary>
   public static readonly Acceleration ThouPerSquareDay = new (
                                                               "thou per square day"
                                                             , "th/dy²"
                                                             , FootPerSquareHour
                                                             , 1.0 / 12000.0 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) foot per square million years. Defined as: (12)/((1000.0)*(1000.0)) × inch per square millennium.
   /// </summary>
   public static readonly Acceleration FootPerSquareMillionYears = new (
                                                                        "foot per square million years"
                                                                      , "ft/Myr²"
                                                                      , InchPerSquareMillennium
                                                                      , 12 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) mile per square minute. Defined as: (8.0)/((60.0)*(60.0)) × furlong per square second.
   /// </summary>
   public static readonly Acceleration MilePerSquareMinute = new (
                                                                  "mile per square minute"
                                                                , "mi/min²"
                                                                , FurlongPerSquareSecond
                                                                , 8.0 / (60.0 * 60.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) barleycorn per square century. Defined as: (1.0/36.0)/((10.0)*(10.0)) × foot per square decade.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareCentury = new (
                                                                         "barleycorn per square century"
                                                                       , "barleycorn/century²"
                                                                       , FootPerSquareDecade
                                                                       , 1.0 / 36.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) hand per square quintillion years. Defined as: (4.0)/((1000.0)*(1000.0)) × inch per square quadrillion years.
   /// </summary>
   public static readonly Acceleration HandPerSquareQuintillionYears = new (
                                                                            "hand per square quintillion years"
                                                                          , "hh/Eyr²"
                                                                          , InchPerSquareQuadrillionYears
                                                                          , 4.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) twip per square year. Defined as: (1.0/17280.0)/((365.2525)*(365.2525)) × foot per square day.
   /// </summary>
   public static readonly Acceleration TwipPerSquareYear = new (
                                                                "twip per square year"
                                                              , "twip/yr²"
                                                              , FootPerSquareDay
                                                              , 1.0 / 17280.0 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) hand per square hour. Defined as: (4.0)/((60.0)*(60.0)) × inch per square minute.
   /// </summary>
   public static readonly Acceleration HandPerSquareHour = new (
                                                                "hand per square hour"
                                                              , "hh/hr²"
                                                              , InchPerSquareMinute
                                                              , 4.0 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) foot per square billion years. Defined as: (12)/((1000.0)*(1000.0)) × inch per square million years.
   /// </summary>
   public static readonly Acceleration FootPerSquareBillionYears = new (
                                                                        "foot per square billion years"
                                                                      , "ft/Gyr²"
                                                                      , InchPerSquareMillionYears
                                                                      , 12 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square minute. Defined as: (3.0)/((60.0)*(60.0)) × mile per square second.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMinute = new (
                                                                    "league per square minute"
                                                                  , "lea/min²"
                                                                  , MilePerSquareSecond
                                                                  , 3.0 / (60.0 * 60.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) league per square tick. Defined as: (3.0)/((100.0)*(100.0)) × mile per square nanosecond.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTick = new (
                                                                  "league per square tick"
                                                                , "lea/tick²"
                                                                , MilePerSquareNanosecond
                                                                , 3.0 / (100.0 * 100.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) fathom per square trillion years. Defined as: (6.0)/((1000.0)*(1000.0)) × foot per square billion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareTrillionYears = new (
                                                                           "fathom per square trillion years"
                                                                         , "ftm/Tyr²"
                                                                         , FootPerSquareBillionYears
                                                                         , 6.0 / (1000.0 * 1000.0)
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
   /// A(n) fathom per square decade. Defined as: (6.0)/((10.0)*(10.0)) × foot per square year.
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecade = new (
                                                                    "fathom per square decade"
                                                                  , "ftm/decade²"
                                                                  , FootPerSquareYear
                                                                  , 6.0 / (10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) foot per square trillion years. Defined as: (12)/((1000.0)*(1000.0)) × inch per square billion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareTrillionYears = new (
                                                                         "foot per square trillion years"
                                                                       , "ft/Tyr²"
                                                                       , InchPerSquareBillionYears
                                                                       , 12 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square minute. Defined as: (6.0)/((60.0)*(60.0)) × foot per square second.
   /// </summary>
   public static readonly Acceleration FathomPerSquareMinute = new (
                                                                    "fathom per square minute"
                                                                  , "ftm/min²"
                                                                  , FootPerSquareSecond
                                                                  , 6.0 / (60.0 * 60.0)
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
   /// A(n) barleycorn per square quadrillion years. Defined as: (1.0/36.0)/((1000.0)*(1000.0)) × foot per square trillion years.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareQuadrillionYears = new (
       "barleycorn per square quadrillion years"
     , "barleycorn/Pyr²"
     , FootPerSquareTrillionYears
     , 1.0 / 36.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) hand per square nonillion years. Defined as: (4.0)/((1000.0)*(1000.0)) × inch per square octillion years.
   /// </summary>
   public static readonly Acceleration HandPerSquareNonillionYears = new (
                                                                          "hand per square nonillion years"
                                                                        , "hh/Qyr²"
                                                                        , InchPerSquareOctillionYears
                                                                        , 4.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) nautical mile per square tick. Defined as: (10.0)/((100.0)*(100.0)) × cable per square nanosecond.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareTick = new (
                                                                        "nautical mile per square tick"
                                                                      , "nmi/tick²"
                                                                      , CablePerSquareNanosecond
                                                                      , 10.0 / (100.0 * 100.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) hand per square decade. Defined as: (4.0)/((10.0)*(10.0)) × inch per square year.
   /// </summary>
   public static readonly Acceleration HandPerSquareDecade = new (
                                                                  "hand per square decade"
                                                                , "hh/decade²"
                                                                , InchPerSquareYear
                                                                , 4.0 / (10.0 * 10.0)
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
   /// A(n) thou per square billion years. Defined as: (1.0/12000.0)/((1000.0)*(1000.0)) × foot per square million years.
   /// </summary>
   public static readonly Acceleration ThouPerSquareBillionYears = new (
                                                                        "thou per square billion years"
                                                                      , "th/Gyr²"
                                                                      , FootPerSquareMillionYears
                                                                      , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) thou per square week. Defined as: (1.0/12000.0)/((7.0)*(7.0)) × foot per square day.
   /// </summary>
   public static readonly Acceleration ThouPerSquareWeek = new (
                                                                "thou per square week"
                                                              , "th/wk²"
                                                              , FootPerSquareDay
                                                              , 1.0 / 12000.0 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) barleycorn per square day. Defined as: (1.0/36.0)/((24.0)*(24.0)) × foot per square hour.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDay = new (
                                                                     "barleycorn per square day"
                                                                   , "barleycorn/dy²"
                                                                   , FootPerSquareHour
                                                                   , 1.0 / 36.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) twip per square decade. Defined as: (1.0/17280.0)/((10.0)*(10.0)) × foot per square year.
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecade = new (
                                                                  "twip per square decade"
                                                                , "twip/decade²"
                                                                , FootPerSquareYear
                                                                , 1.0 / 17280.0 / (10.0 * 10.0)
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
   /// A(n) foot per square quadrillion years. Defined as: (12)/((1000.0)*(1000.0)) × inch per square trillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareQuadrillionYears = new (
                                                                            "foot per square quadrillion years"
                                                                          , "ft/Pyr²"
                                                                          , InchPerSquareTrillionYears
                                                                          , 12 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) cable per square minute. Defined as: (100.0)/((60.0)*(60.0)) × fathom per square second.
   /// </summary>
   public static readonly Acceleration CablePerSquareMinute = new (
                                                                   "cable per square minute"
                                                                 , "cable/min²"
                                                                 , FathomPerSquareSecond
                                                                 , 100.0 / (60.0 * 60.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) foot per square quintillion years. Defined as: (12)/((1000.0)*(1000.0)) × inch per square quadrillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareQuintillionYears = new (
                                                                            "foot per square quintillion years"
                                                                          , "ft/Eyr²"
                                                                          , InchPerSquareQuadrillionYears
                                                                          , 12 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) nautical mile per square minute. Defined as: (10.0)/((60.0)*(60.0)) × cable per square second.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMinute = new (
                                                                          "nautical mile per square minute"
                                                                        , "nmi/min²"
                                                                        , CablePerSquareSecond
                                                                        , 10.0 / (60.0 * 60.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) hand per square billion years. Defined as: (4.0)/((1000.0)*(1000.0)) × inch per square million years.
   /// </summary>
   public static readonly Acceleration HandPerSquareBillionYears = new (
                                                                        "hand per square billion years"
                                                                      , "hh/Gyr²"
                                                                      , InchPerSquareMillionYears
                                                                      , 4.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) twip per square tick. Defined as: (1.0/17280.0)/((100.0)*(100.0)) × foot per square nanosecond.
   /// </summary>
   public static readonly Acceleration TwipPerSquareTick = new (
                                                                "twip per square tick"
                                                              , "twip/tick²"
                                                              , FootPerSquareNanosecond
                                                              , 1.0 / 17280.0 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) barleycorn per square millennium. Defined as: (1.0/36.0)/((10.0)*(10.0)) × foot per square century.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMillennium = new (
                                                                            "barleycorn per square millennium"
                                                                          , "barleycorn/kyr²"
                                                                          , FootPerSquareCentury
                                                                          , 1.0 / 36.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) fathom per square quintillion years. Defined as: (6.0)/((1000.0)*(1000.0)) × foot per square quadrillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuintillionYears = new (
                                                                              "fathom per square quintillion years"
                                                                            , "ftm/Eyr²"
                                                                            , FootPerSquareQuadrillionYears
                                                                            , 6.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) twip per square century. Defined as: (1.0/17280.0)/((10.0)*(10.0)) × foot per square decade.
   /// </summary>
   public static readonly Acceleration TwipPerSquareCentury = new (
                                                                   "twip per square century"
                                                                 , "twip/century²"
                                                                 , FootPerSquareDecade
                                                                 , 1.0 / 17280.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) chain per square hour. Defined as: (22.0)/((60.0)*(60.0)) × yard per square minute.
   /// </summary>
   public static readonly Acceleration ChainPerSquareHour =
            new ("chain per square hour", "ch/hr²", YardPerSquareMinute, 22.0 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) foot per square sextillion years. Defined as: (12)/((1000.0)*(1000.0)) × inch per square quintillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareSextillionYears = new (
                                                                           "foot per square sextillion years"
                                                                         , "ft/Zyr²"
                                                                         , InchPerSquareQuintillionYears
                                                                         , 12 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) fathom per square millennium. Defined as: (6.0)/((10.0)*(10.0)) × foot per square century.
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillennium = new (
                                                                        "fathom per square millennium"
                                                                      , "ftm/kyr²"
                                                                      , FootPerSquareCentury
                                                                      , 6.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) hand per square tick. Defined as: (4.0)/((100.0)*(100.0)) × inch per square nanosecond.
   /// </summary>
   public static readonly Acceleration HandPerSquareTick = new (
                                                                "hand per square tick"
                                                              , "hh/tick²"
                                                              , InchPerSquareNanosecond
                                                              , 4.0 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) thou per square trillion years. Defined as: (1.0/12000.0)/((1000.0)*(1000.0)) × foot per square billion years.
   /// </summary>
   public static readonly Acceleration ThouPerSquareTrillionYears = new (
                                                                         "thou per square trillion years"
                                                                       , "th/Tyr²"
                                                                       , FootPerSquareBillionYears
                                                                       , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square day. Defined as: (6.0)/((24.0)*(24.0)) × foot per square hour.
   /// </summary>
   public static readonly Acceleration FathomPerSquareDay =
            new ("fathom per square day", "ftm/dy²", FootPerSquareHour, 6.0 / (24.0 * 24.0), 0);

   /// <summary>
   /// A(n) hand per square sextillion years. Defined as: (4.0)/((1000.0)*(1000.0)) × inch per square quintillion years.
   /// </summary>
   public static readonly Acceleration HandPerSquareSextillionYears = new (
                                                                           "hand per square sextillion years"
                                                                         , "hh/Zyr²"
                                                                         , InchPerSquareQuintillionYears
                                                                         , 4.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) cable per square quadrillion years. Defined as: (100.0)/((1000.0)*(1000.0)) × fathom per square trillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareQuadrillionYears = new (
                                                                             "cable per square quadrillion years"
                                                                           , "cable/Pyr²"
                                                                           , FathomPerSquareTrillionYears
                                                                           , 100.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) thou per square year. Defined as: (1.0/12000.0)/((365.2525)*(365.2525)) × foot per square day.
   /// </summary>
   public static readonly Acceleration ThouPerSquareYear = new (
                                                                "thou per square year"
                                                              , "th/yr²"
                                                              , FootPerSquareDay
                                                              , 1.0 / 12000.0 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) hand per square day. Defined as: (4.0)/((24.0)*(24.0)) × inch per square hour.
   /// </summary>
   public static readonly Acceleration HandPerSquareDay = new (
                                                               "hand per square day"
                                                             , "hh/dy²"
                                                             , InchPerSquareHour
                                                             , 4.0 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) foot per square septillion years. Defined as: (12)/((1000.0)*(1000.0)) × inch per square sextillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareSeptillionYears = new (
                                                                           "foot per square septillion years"
                                                                         , "ft/Yyr²"
                                                                         , InchPerSquareSextillionYears
                                                                         , 12 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) barleycorn per square quintillion years. Defined as: (1.0/36.0)/((1000.0)*(1000.0)) × foot per square quadrillion years.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareQuintillionYears = new (
       "barleycorn per square quintillion years"
     , "barleycorn/Eyr²"
     , FootPerSquareQuadrillionYears
     , 1.0 / 36.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) furlong per square tick. Defined as: (10.0)/((100.0)*(100.0)) × chain per square nanosecond.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareTick = new (
                                                                   "furlong per square tick"
                                                                 , "fur/tick²"
                                                                 , ChainPerSquareNanosecond
                                                                 , 10.0 / (100.0 * 100.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) cable per square million years. Defined as: (100.0)/((1000.0)*(1000.0)) × fathom per square millennium.
   /// </summary>
   public static readonly Acceleration CablePerSquareMillionYears = new (
                                                                         "cable per square million years"
                                                                       , "cable/Myr²"
                                                                       , FathomPerSquareMillennium
                                                                       , 100.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) barleycorn per square week. Defined as: (1.0/36.0)/((7.0)*(7.0)) × foot per square day.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareWeek = new (
                                                                      "barleycorn per square week"
                                                                    , "barleycorn/wk²"
                                                                    , FootPerSquareDay
                                                                    , 1.0 / 36.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square millennium. Defined as: (1.0/17280.0)/((10.0)*(10.0)) × foot per square century.
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillennium = new (
                                                                      "twip per square millennium"
                                                                    , "twip/kyr²"
                                                                    , FootPerSquareCentury
                                                                    , 1.0 / 17280.0 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) furlong per square hour. Defined as: (10.0)/((60.0)*(60.0)) × chain per square minute.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareHour = new (
                                                                   "furlong per square hour"
                                                                 , "fur/hr²"
                                                                 , ChainPerSquareMinute
                                                                 , 10.0 / (60.0 * 60.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) foot per square octillion years. Defined as: (12)/((1000.0)*(1000.0)) × inch per square septillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareOctillionYears = new (
                                                                          "foot per square octillion years"
                                                                        , "ft/Ryr²"
                                                                        , InchPerSquareSeptillionYears
                                                                        , 12 / (1000.0 * 1000.0)
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
   /// A(n) hand per square decillion years. Defined as: (4.0)/((1000.0)*(1000.0)) × inch per square nonillion years.
   /// </summary>
   public static readonly Acceleration HandPerSquareDecillionYears = new (
                                                                          "hand per square decillion years"
                                                                        , "hh/decillion yr²"
                                                                        , InchPerSquareNonillionYears
                                                                        , 4.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) hand per square century. Defined as: (4.0)/((10.0)*(10.0)) × inch per square decade.
   /// </summary>
   public static readonly Acceleration HandPerSquareCentury = new (
                                                                   "hand per square century"
                                                                 , "hh/century²"
                                                                 , InchPerSquareDecade
                                                                 , 4.0 / (10.0 * 10.0)
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
   /// A(n) fathom per square tick. Defined as: (6.0)/((100.0)*(100.0)) × foot per square nanosecond.
   /// </summary>
   public static readonly Acceleration FathomPerSquareTick = new (
                                                                  "fathom per square tick"
                                                                , "ftm/tick²"
                                                                , FootPerSquareNanosecond
                                                                , 6.0 / (100.0 * 100.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) foot per square nonillion years. Defined as: (12)/((1000.0)*(1000.0)) × inch per square octillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareNonillionYears = new (
                                                                          "foot per square nonillion years"
                                                                        , "ft/Qyr²"
                                                                        , InchPerSquareOctillionYears
                                                                        , 12 / (1000.0 * 1000.0)
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
   /// A(n) thou per square decillion years. Defined as: (1.0/12000.0)/((1000.0)*(1000.0)) × foot per square nonillion years.
   /// </summary>
   public static readonly Acceleration ThouPerSquareDecillionYears = new (
                                                                          "thou per square decillion years"
                                                                        , "th/decillion yr²"
                                                                        , FootPerSquareNonillionYears
                                                                        , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) chain per square quintillion years. Defined as: (22.0)/((1000.0)*(1000.0)) × yard per square quadrillion years.
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuintillionYears = new (
                                                                             "chain per square quintillion years"
                                                                           , "ch/Eyr²"
                                                                           , YardPerSquareQuadrillionYears
                                                                           , 22.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) fathom per square septillion years. Defined as: (6.0)/((1000.0)*(1000.0)) × foot per square sextillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareSeptillionYears = new (
                                                                             "fathom per square septillion years"
                                                                           , "ftm/Yyr²"
                                                                           , FootPerSquareSextillionYears
                                                                           , 6.0 / (1000.0 * 1000.0)
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
   /// A(n) barleycorn per square million years. Defined as: (1.0/36.0)/((1000.0)*(1000.0)) × foot per square millennium.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMillionYears = new (
                                                                              "barleycorn per square million years"
                                                                            , "barleycorn/Myr²"
                                                                            , FootPerSquareMillennium
                                                                            , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) thou per square quadrillion years. Defined as: (1.0/12000.0)/((1000.0)*(1000.0)) × foot per square trillion years.
   /// </summary>
   public static readonly Acceleration ThouPerSquareQuadrillionYears = new (
                                                                            "thou per square quadrillion years"
                                                                          , "th/Pyr²"
                                                                          , FootPerSquareTrillionYears
                                                                          , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) cable per square day. Defined as: (100.0)/((24.0)*(24.0)) × fathom per square hour.
   /// </summary>
   public static readonly Acceleration CablePerSquareDay = new (
                                                                "cable per square day"
                                                              , "cable/dy²"
                                                              , FathomPerSquareHour
                                                              , 100.0 / (24.0 * 24.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) twip per square decillion years. Defined as: (1.0/17280.0)/((1000.0)*(1000.0)) × foot per square nonillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecillionYears = new (
                                                                          "twip per square decillion years"
                                                                        , "twip/decillion yr²"
                                                                        , FootPerSquareNonillionYears
                                                                        , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) fathom per square billion years. Defined as: (6.0)/((1000.0)*(1000.0)) × foot per square million years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareBillionYears = new (
                                                                          "fathom per square billion years"
                                                                        , "ftm/Gyr²"
                                                                        , FootPerSquareMillionYears
                                                                        , 6.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) thou per square decade. Defined as: (1.0/12000.0)/((10.0)*(10.0)) × foot per square year.
   /// </summary>
   public static readonly Acceleration ThouPerSquareDecade = new (
                                                                  "thou per square decade"
                                                                , "th/decade²"
                                                                , FootPerSquareYear
                                                                , 1.0 / 12000.0 / (10.0 * 10.0)
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
   /// A(n) twip per square million years. Defined as: (1.0/17280.0)/((1000.0)*(1000.0)) × foot per square millennium.
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillionYears = new (
                                                                        "twip per square million years"
                                                                      , "twip/Myr²"
                                                                      , FootPerSquareMillennium
                                                                      , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) mile per square hour. Defined as: (8.0)/((60.0)*(60.0)) × furlong per square minute.
   /// </summary>
   public static readonly Acceleration MilePerSquareHour = new (
                                                                "mile per square hour"
                                                              , "mi/hr²"
                                                              , FurlongPerSquareMinute
                                                              , 8.0 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) foot per square decillion years. Defined as: (12)/((1000.0)*(1000.0)) × inch per square nonillion years.
   /// </summary>
   public static readonly Acceleration FootPerSquareDecillionYears = new (
                                                                          "foot per square decillion years"
                                                                        , "ft/decillion yr²"
                                                                        , InchPerSquareNonillionYears
                                                                        , 12 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) hand per square trillion years. Defined as: (4.0)/((1000.0)*(1000.0)) × inch per square billion years.
   /// </summary>
   public static readonly Acceleration HandPerSquareTrillionYears = new (
                                                                         "hand per square trillion years"
                                                                       , "hh/Tyr²"
                                                                       , InchPerSquareBillionYears
                                                                       , 4.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) fathom per square year. Defined as: (6.0)/((365.2525)*(365.2525)) × foot per square day.
   /// </summary>
   public static readonly Acceleration FathomPerSquareYear = new (
                                                                  "fathom per square year"
                                                                , "ftm/yr²"
                                                                , FootPerSquareDay
                                                                , 6.0 / (365.2525 * 365.2525)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) barleycorn per square sextillion years. Defined as: (1.0/36.0)/((1000.0)*(1000.0)) × foot per square quintillion years.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareSextillionYears = new (
       "barleycorn per square sextillion years"
     , "barleycorn/Zyr²"
     , FootPerSquareQuintillionYears
     , 1.0 / 36.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) nautical mile per square billion years. Defined as: (10.0)/((1000.0)*(1000.0)) × cable per square million years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareBillionYears = new (
                                                                                "nautical mile per square billion years"
                                                                              , "nmi/Gyr²"
                                                                              , CablePerSquareMillionYears
                                                                              , 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) furlong per square sextillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × chain per square quintillion years.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSextillionYears = new (
                                                                              "furlong per square sextillion years"
                                                                            , "fur/Zyr²"
                                                                            , ChainPerSquareQuintillionYears
                                                                            , 10.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) chain per square octillion years. Defined as: (22.0)/((1000.0)*(1000.0)) × yard per square septillion years.
   /// </summary>
   public static readonly Acceleration ChainPerSquareOctillionYears = new (
                                                                           "chain per square octillion years"
                                                                         , "ch/Ryr²"
                                                                         , YardPerSquareSeptillionYears
                                                                         , 22.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) barleycorn per square year. Defined as: (1.0/36.0)/((365.2525)*(365.2525)) × foot per square day.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareYear = new (
                                                                      "barleycorn per square year"
                                                                    , "barleycorn/yr²"
                                                                    , FootPerSquareDay
                                                                    , 1.0 / 36.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) twip per square billion years. Defined as: (1.0/17280.0)/((1000.0)*(1000.0)) × foot per square million years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareBillionYears = new (
                                                                        "twip per square billion years"
                                                                      , "twip/Gyr²"
                                                                      , FootPerSquareMillionYears
                                                                      , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square hour. Defined as: (3.0)/((60.0)*(60.0)) × mile per square minute.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareHour =
            new ("league per square hour", "lea/hr²", MilePerSquareMinute, 3.0 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) cable per square sextillion years. Defined as: (100.0)/((1000.0)*(1000.0)) × fathom per square quintillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareSextillionYears = new (
                                                                            "cable per square sextillion years"
                                                                          , "cable/Zyr²"
                                                                          , FathomPerSquareQuintillionYears
                                                                          , 100.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) thou per square quintillion years. Defined as: (1.0/12000.0)/((1000.0)*(1000.0)) × foot per square quadrillion years.
   /// </summary>
   public static readonly Acceleration ThouPerSquareQuintillionYears = new (
                                                                            "thou per square quintillion years"
                                                                          , "th/Eyr²"
                                                                          , FootPerSquareQuadrillionYears
                                                                          , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) fathom per square nonillion years. Defined as: (6.0)/((1000.0)*(1000.0)) × foot per square octillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareNonillionYears = new (
                                                                            "fathom per square nonillion years"
                                                                          , "ftm/Qyr²"
                                                                          , FootPerSquareOctillionYears
                                                                          , 6.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) thou per square century. Defined as: (1.0/12000.0)/((10.0)*(10.0)) × foot per square decade.
   /// </summary>
   public static readonly Acceleration ThouPerSquareCentury = new (
                                                                   "thou per square century"
                                                                 , "th/century²"
                                                                 , FootPerSquareDecade
                                                                 , 1.0 / 12000.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) chain per square day. Defined as: (22.0)/((24.0)*(24.0)) × yard per square hour.
   /// </summary>
   public static readonly Acceleration ChainPerSquareDay = new (
                                                                "chain per square day"
                                                              , "ch/dy²"
                                                              , YardPerSquareHour
                                                              , 22.0 / (24.0 * 24.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) fathom per square quadrillion years. Defined as: (6.0)/((1000.0)*(1000.0)) × foot per square trillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuadrillionYears = new (
                                                                              "fathom per square quadrillion years"
                                                                            , "ftm/Pyr²"
                                                                            , FootPerSquareTrillionYears
                                                                            , 6.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) cable per square trillion years. Defined as: (100.0)/((1000.0)*(1000.0)) × fathom per square billion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareTrillionYears = new (
                                                                          "cable per square trillion years"
                                                                        , "cable/Tyr²"
                                                                        , FathomPerSquareBillionYears
                                                                        , 100.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) nautical mile per square quintillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × cable per square quadrillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuintillionYears = new (
       "nautical mile per square quintillion years"
     , "nmi/Eyr²"
     , CablePerSquareQuadrillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) furlong per square year. Defined as: (10.0)/((365.2525)*(365.2525)) × chain per square day.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareYear = new (
                                                                   "furlong per square year"
                                                                 , "fur/yr²"
                                                                 , ChainPerSquareDay
                                                                 , 10.0 / (365.2525 * 365.2525)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) barleycorn per square billion years. Defined as: (1.0/36.0)/((1000.0)*(1000.0)) × foot per square million years.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareBillionYears = new (
                                                                              "barleycorn per square billion years"
                                                                            , "barleycorn/Gyr²"
                                                                            , FootPerSquareMillionYears
                                                                            , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) fathom per square century. Defined as: (6.0)/((10.0)*(10.0)) × foot per square decade.
   /// </summary>
   public static readonly Acceleration FathomPerSquareCentury = new (
                                                                     "fathom per square century"
                                                                   , "ftm/century²"
                                                                   , FootPerSquareDecade
                                                                   , 6.0 / (10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) twip per square trillion years. Defined as: (1.0/17280.0)/((1000.0)*(1000.0)) × foot per square billion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareTrillionYears = new (
                                                                         "twip per square trillion years"
                                                                       , "twip/Tyr²"
                                                                       , FootPerSquareBillionYears
                                                                       , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) cable per square millennium. Defined as: (100.0)/((10.0)*(10.0)) × fathom per square century.
   /// </summary>
   public static readonly Acceleration CablePerSquareMillennium = new (
                                                                       "cable per square millennium"
                                                                     , "cable/kyr²"
                                                                     , FathomPerSquareCentury
                                                                     , 100.0 / (10.0 * 10.0)
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
   /// A(n) cable per square year. Defined as: (100.0)/((365.2525)*(365.2525)) × fathom per square day.
   /// </summary>
   public static readonly Acceleration CablePerSquareYear = new (
                                                                 "cable per square year"
                                                               , "cable/yr²"
                                                               , FathomPerSquareDay
                                                               , 100.0 / (365.2525 * 365.2525)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) barleycorn per square septillion years. Defined as: (1.0/36.0)/((1000.0)*(1000.0)) × foot per square sextillion years.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareSeptillionYears = new (
       "barleycorn per square septillion years"
     , "barleycorn/Yyr²"
     , FootPerSquareSextillionYears
     , 1.0 / 36.0 / (1000.0 * 1000.0)
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
   /// A(n) chain per square decade. Defined as: (22.0)/((10.0)*(10.0)) × yard per square year.
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecade = new (
                                                                   "chain per square decade"
                                                                 , "ch/decade²"
                                                                 , YardPerSquareYear
                                                                 , 22.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) thou per square sextillion years. Defined as: (1.0/12000.0)/((1000.0)*(1000.0)) × foot per square quintillion years.
   /// </summary>
   public static readonly Acceleration ThouPerSquareSextillionYears = new (
                                                                           "thou per square sextillion years"
                                                                         , "th/Zyr²"
                                                                         , FootPerSquareQuintillionYears
                                                                         , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) thou per square millennium. Defined as: (1.0/12000.0)/((10.0)*(10.0)) × foot per square century.
   /// </summary>
   public static readonly Acceleration ThouPerSquareMillennium = new (
                                                                      "thou per square millennium"
                                                                    , "th/kyr²"
                                                                    , FootPerSquareCentury
                                                                    , 1.0 / 12000.0 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) furlong per square day. Defined as: (10.0)/((24.0)*(24.0)) × chain per square hour.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDay =
            new ("furlong per square day", "fur/dy²", ChainPerSquareHour, 10.0 / (24.0 * 24.0), 0);

   /// <summary>
   /// A(n) twip per square quadrillion years. Defined as: (1.0/17280.0)/((1000.0)*(1000.0)) × foot per square trillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuadrillionYears = new (
                                                                            "twip per square quadrillion years"
                                                                          , "twip/Pyr²"
                                                                          , FootPerSquareTrillionYears
                                                                          , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) cable per square hour. Defined as: (100.0)/((60.0)*(60.0)) × fathom per square minute.
   /// </summary>
   public static readonly Acceleration CablePerSquareHour = new (
                                                                 "cable per square hour"
                                                               , "cable/hr²"
                                                               , FathomPerSquareMinute
                                                               , 100.0 / (60.0 * 60.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) chain per square sextillion years. Defined as: (22.0)/((1000.0)*(1000.0)) × yard per square quintillion years.
   /// </summary>
   public static readonly Acceleration ChainPerSquareSextillionYears = new (
                                                                            "chain per square sextillion years"
                                                                          , "ch/Zyr²"
                                                                          , YardPerSquareQuintillionYears
                                                                          , 22.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) mile per square septillion years. Defined as: (8.0)/((1000.0)*(1000.0)) × furlong per square sextillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareSeptillionYears = new (
                                                                           "mile per square septillion years"
                                                                         , "mi/Yyr²"
                                                                         , FurlongPerSquareSextillionYears
                                                                         , 8.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) nautical mile per square million years. Defined as: (10.0)/((1000.0)*(1000.0)) × cable per square millennium.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillionYears = new (
                                                                                "nautical mile per square million years"
                                                                              , "nmi/Myr²"
                                                                              , CablePerSquareMillennium
                                                                              , 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) fathom per square sextillion years. Defined as: (6.0)/((1000.0)*(1000.0)) × foot per square quintillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareSextillionYears = new (
                                                                             "fathom per square sextillion years"
                                                                           , "ftm/Zyr²"
                                                                           , FootPerSquareQuintillionYears
                                                                           , 6.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) fathom per square million years. Defined as: (6.0)/((1000.0)*(1000.0)) × foot per square millennium.
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillionYears = new (
                                                                          "fathom per square million years"
                                                                        , "ftm/Myr²"
                                                                        , FootPerSquareMillennium
                                                                        , 6.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square nonillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × chain per square octillion years.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareNonillionYears = new (
                                                                             "furlong per square nonillion years"
                                                                           , "fur/Qyr²"
                                                                           , ChainPerSquareOctillionYears
                                                                           , 10.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) barleycorn per square trillion years. Defined as: (1.0/36.0)/((1000.0)*(1000.0)) × foot per square billion years.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareTrillionYears = new (
                                                                               "barleycorn per square trillion years"
                                                                             , "barleycorn/Tyr²"
                                                                             , FootPerSquareBillionYears
                                                                             , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) cable per square octillion years. Defined as: (100.0)/((1000.0)*(1000.0)) × fathom per square septillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareOctillionYears = new (
                                                                           "cable per square octillion years"
                                                                         , "cable/Ryr²"
                                                                         , FathomPerSquareSeptillionYears
                                                                         , 100.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) twip per square quintillion years. Defined as: (1.0/17280.0)/((1000.0)*(1000.0)) × foot per square quadrillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuintillionYears = new (
                                                                            "twip per square quintillion years"
                                                                          , "twip/Eyr²"
                                                                          , FootPerSquareQuadrillionYears
                                                                          , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) nautical mile per square hour. Defined as: (10.0)/((60.0)*(60.0)) × cable per square minute.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareHour = new (
                                                                        "nautical mile per square hour"
                                                                      , "nmi/hr²"
                                                                      , CablePerSquareMinute
                                                                      , 10.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square million years. Defined as: (22.0)/((1000.0)*(1000.0)) × yard per square millennium.
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillionYears = new (
                                                                         "chain per square million years"
                                                                       , "ch/Myr²"
                                                                       , YardPerSquareMillennium
                                                                       , 22.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) mile per square year. Defined as: (8.0)/((365.2525)*(365.2525)) × furlong per square day.
   /// </summary>
   public static readonly Acceleration MilePerSquareYear = new (
                                                                "mile per square year"
                                                              , "mi/yr²"
                                                              , FurlongPerSquareDay
                                                              , 8.0 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) thou per square septillion years. Defined as: (1.0/12000.0)/((1000.0)*(1000.0)) × foot per square sextillion years.
   /// </summary>
   public static readonly Acceleration ThouPerSquareSeptillionYears = new (
                                                                           "thou per square septillion years"
                                                                         , "th/Yyr²"
                                                                         , FootPerSquareSextillionYears
                                                                         , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) chain per square nonillion years. Defined as: (22.0)/((1000.0)*(1000.0)) × yard per square octillion years.
   /// </summary>
   public static readonly Acceleration ChainPerSquareNonillionYears = new (
                                                                           "chain per square nonillion years"
                                                                         , "ch/Qyr²"
                                                                         , YardPerSquareOctillionYears
                                                                         , 22.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) cable per square quintillion years. Defined as: (100.0)/((1000.0)*(1000.0)) × fathom per square quadrillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareQuintillionYears = new (
                                                                             "cable per square quintillion years"
                                                                           , "cable/Eyr²"
                                                                           , FathomPerSquareQuadrillionYears
                                                                           , 100.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) nautical mile per square quadrillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × cable per square trillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuadrillionYears = new (
       "nautical mile per square quadrillion years"
     , "nmi/Pyr²"
     , CablePerSquareTrillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) mile per square day. Defined as: (8.0)/((24.0)*(24.0)) × furlong per square hour.
   /// </summary>
   public static readonly Acceleration MilePerSquareDay = new (
                                                               "mile per square day"
                                                             , "mi/dy²"
                                                             , FurlongPerSquareHour
                                                             , 8.0 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) barleycorn per square octillion years. Defined as: (1.0/36.0)/((1000.0)*(1000.0)) × foot per square septillion years.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareOctillionYears = new (
                                                                                "barleycorn per square octillion years"
                                                                              , "barleycorn/Ryr²"
                                                                              , FootPerSquareSeptillionYears
                                                                              , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) cable per square billion years. Defined as: (100.0)/((1000.0)*(1000.0)) × fathom per square million years.
   /// </summary>
   public static readonly Acceleration CablePerSquareBillionYears = new (
                                                                         "cable per square billion years"
                                                                       , "cable/Gyr²"
                                                                       , FathomPerSquareMillionYears
                                                                       , 100.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square septillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × chain per square sextillion years.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSeptillionYears = new (
                                                                              "furlong per square septillion years"
                                                                            , "fur/Yyr²"
                                                                            , ChainPerSquareSextillionYears
                                                                            , 10.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) chain per square week. Defined as: (22.0)/((7.0)*(7.0)) × yard per square day.
   /// </summary>
   public static readonly Acceleration ChainPerSquareWeek =
            new ("chain per square week", "ch/wk²", YardPerSquareDay, 22.0 / (7.0 * 7.0), 0);

   /// <summary>
   /// A(n) twip per square sextillion years. Defined as: (1.0/17280.0)/((1000.0)*(1000.0)) × foot per square quintillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareSextillionYears = new (
                                                                           "twip per square sextillion years"
                                                                         , "twip/Zyr²"
                                                                         , FootPerSquareQuintillionYears
                                                                         , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) nautical mile per square year. Defined as: (10.0)/((365.2525)*(365.2525)) × cable per square day.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareYear = new (
                                                                        "nautical mile per square year"
                                                                      , "nmi/yr²"
                                                                      , CablePerSquareDay
                                                                      , 10.0 / (365.2525 * 365.2525)
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
   /// A(n) fathom per square octillion years. Defined as: (6.0)/((1000.0)*(1000.0)) × foot per square septillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareOctillionYears = new (
                                                                            "fathom per square octillion years"
                                                                          , "ftm/Ryr²"
                                                                          , FootPerSquareSeptillionYears
                                                                          , 6.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) chain per square quadrillion years. Defined as: (22.0)/((1000.0)*(1000.0)) × yard per square trillion years.
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuadrillionYears = new (
                                                                             "chain per square quadrillion years"
                                                                           , "ch/Pyr²"
                                                                           , YardPerSquareTrillionYears
                                                                           , 22.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) cable per square century. Defined as: (100.0)/((10.0)*(10.0)) × fathom per square decade.
   /// </summary>
   public static readonly Acceleration CablePerSquareCentury = new (
                                                                    "cable per square century"
                                                                  , "cable/century²"
                                                                  , FathomPerSquareDecade
                                                                  , 100.0 / (10.0 * 10.0)
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
   /// A(n) nautical mile per square septillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × cable per square sextillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSeptillionYears = new (
       "nautical mile per square septillion years"
     , "nmi/Yyr²"
     , CablePerSquareSextillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) cable per square week. Defined as: (100.0)/((7.0)*(7.0)) × fathom per square day.
   /// </summary>
   public static readonly Acceleration CablePerSquareWeek = new (
                                                                 "cable per square week"
                                                               , "cable/wk²"
                                                               , FathomPerSquareDay
                                                               , 100.0 / (7.0 * 7.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) thou per square octillion years. Defined as: (1.0/12000.0)/((1000.0)*(1000.0)) × foot per square septillion years.
   /// </summary>
   public static readonly Acceleration ThouPerSquareOctillionYears = new (
                                                                          "thou per square octillion years"
                                                                        , "th/Ryr²"
                                                                        , FootPerSquareSeptillionYears
                                                                        , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) league per square day. Defined as: (3.0)/((24.0)*(24.0)) × mile per square hour.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDay =
            new ("league per square day", "lea/dy²", MilePerSquareHour, 3.0 / (24.0 * 24.0), 0);

   /// <summary>
   /// A(n) twip per square septillion years. Defined as: (1.0/17280.0)/((1000.0)*(1000.0)) × foot per square sextillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareSeptillionYears = new (
                                                                           "twip per square septillion years"
                                                                         , "twip/Yyr²"
                                                                         , FootPerSquareSextillionYears
                                                                         , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) furlong per square quintillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × chain per square quadrillion years.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuintillionYears = new (
                                                                               "furlong per square quintillion years"
                                                                             , "fur/Eyr²"
                                                                             , ChainPerSquareQuadrillionYears
                                                                             , 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) nautical mile per square millennium. Defined as: (10.0)/((10.0)*(10.0)) × cable per square century.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillennium = new (
                                                                              "nautical mile per square millennium"
                                                                            , "nmi/kyr²"
                                                                            , CablePerSquareCentury
                                                                            , 10.0 / (10.0 * 10.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) chain per square century. Defined as: (22.0)/((10.0)*(10.0)) × yard per square decade.
   /// </summary>
   public static readonly Acceleration ChainPerSquareCentury = new (
                                                                    "chain per square century"
                                                                  , "ch/century²"
                                                                  , YardPerSquareDecade
                                                                  , 22.0 / (10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) league per square octillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square septillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareOctillionYears = new (
                                                                            "league per square octillion years"
                                                                          , "lea/Ryr²"
                                                                          , MilePerSquareSeptillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) barleycorn per square nonillion years. Defined as: (1.0/36.0)/((1000.0)*(1000.0)) × foot per square octillion years.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareNonillionYears = new (
                                                                                "barleycorn per square nonillion years"
                                                                              , "barleycorn/Qyr²"
                                                                              , FootPerSquareOctillionYears
                                                                              , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) chain per square septillion years. Defined as: (22.0)/((1000.0)*(1000.0)) × yard per square sextillion years.
   /// </summary>
   public static readonly Acceleration ChainPerSquareSeptillionYears = new (
                                                                            "chain per square septillion years"
                                                                          , "ch/Yyr²"
                                                                          , YardPerSquareSextillionYears
                                                                          , 22.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) cable per square decillion years. Defined as: (100.0)/((1000.0)*(1000.0)) × fathom per square nonillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareDecillionYears = new (
                                                                           "cable per square decillion years"
                                                                         , "cable/decillion yr²"
                                                                         , FathomPerSquareNonillionYears
                                                                         , 100.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) league per square year. Defined as: (3.0)/((365.2525)*(365.2525)) × mile per square day.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYear = new (
                                                                  "league per square year"
                                                                , "lea/yr²"
                                                                , MilePerSquareDay
                                                                , 3.0 / (365.2525 * 365.2525)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) fathom per square decillion years. Defined as: (6.0)/((1000.0)*(1000.0)) × foot per square nonillion years.
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecillionYears = new (
                                                                            "fathom per square decillion years"
                                                                          , "ftm/decillion yr²"
                                                                          , FootPerSquareNonillionYears
                                                                          , 6.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) furlong per square week. Defined as: (10.0)/((7.0)*(7.0)) × chain per square day.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareWeek =
            new ("furlong per square week", "fur/wk²", ChainPerSquareDay, 10.0 / (7.0 * 7.0), 0);

   /// <summary>
   /// A(n) twip per square octillion years. Defined as: (1.0/17280.0)/((1000.0)*(1000.0)) × foot per square septillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareOctillionYears = new (
                                                                          "twip per square octillion years"
                                                                        , "twip/Ryr²"
                                                                        , FootPerSquareSeptillionYears
                                                                        , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) nautical mile per square trillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × cable per square billion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareTrillionYears = new (
       "nautical mile per square trillion years"
     , "nmi/Tyr²"
     , CablePerSquareBillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) cable per square septillion years. Defined as: (100.0)/((1000.0)*(1000.0)) × fathom per square sextillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareSeptillionYears = new (
                                                                            "cable per square septillion years"
                                                                          , "cable/Yyr²"
                                                                          , FathomPerSquareSextillionYears
                                                                          , 100.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) thou per square nonillion years. Defined as: (1.0/12000.0)/((1000.0)*(1000.0)) × foot per square octillion years.
   /// </summary>
   public static readonly Acceleration ThouPerSquareNonillionYears = new (
                                                                          "thou per square nonillion years"
                                                                        , "th/Qyr²"
                                                                        , FootPerSquareOctillionYears
                                                                        , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) mile per square decillion years. Defined as: (8.0)/((1000.0)*(1000.0)) × furlong per square nonillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareDecillionYears = new (
                                                                          "mile per square decillion years"
                                                                        , "mi/decillion yr²"
                                                                        , FurlongPerSquareNonillionYears
                                                                        , 8.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) chain per square billion years. Defined as: (22.0)/((1000.0)*(1000.0)) × yard per square million years.
   /// </summary>
   public static readonly Acceleration ChainPerSquareBillionYears = new (
                                                                         "chain per square billion years"
                                                                       , "ch/Gyr²"
                                                                       , YardPerSquareMillionYears
                                                                       , 22.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) mile per square octillion years. Defined as: (8.0)/((1000.0)*(1000.0)) × furlong per square septillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareOctillionYears = new (
                                                                          "mile per square octillion years"
                                                                        , "mi/Ryr²"
                                                                        , FurlongPerSquareSeptillionYears
                                                                        , 8.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square decillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × chain per square nonillion years.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecillionYears = new (
                                                                             "furlong per square decillion years"
                                                                           , "fur/decillion yr²"
                                                                           , ChainPerSquareNonillionYears
                                                                           , 10.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) nautical mile per square week. Defined as: (10.0)/((7.0)*(7.0)) × cable per square day.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareWeek =
            new ("nautical mile per square week", "nmi/wk²", CablePerSquareDay, 10.0 / (7.0 * 7.0), 0);

   /// <summary>
   /// A(n) mile per square sextillion years. Defined as: (8.0)/((1000.0)*(1000.0)) × furlong per square quintillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareSextillionYears = new (
                                                                           "mile per square sextillion years"
                                                                         , "mi/Zyr²"
                                                                         , FurlongPerSquareQuintillionYears
                                                                         , 8.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) chain per square decillion years. Defined as: (22.0)/((1000.0)*(1000.0)) × yard per square nonillion years.
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecillionYears = new (
                                                                           "chain per square decillion years"
                                                                         , "ch/decillion yr²"
                                                                         , YardPerSquareNonillionYears
                                                                         , 22.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) twip per square nonillion years. Defined as: (1.0/17280.0)/((1000.0)*(1000.0)) × foot per square octillion years.
   /// </summary>
   public static readonly Acceleration TwipPerSquareNonillionYears = new (
                                                                          "twip per square nonillion years"
                                                                        , "twip/Qyr²"
                                                                        , FootPerSquareOctillionYears
                                                                        , 1.0 / 17280.0 / (1000.0 * 1000.0)
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
   /// A(n) nautical mile per square sextillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × cable per square quintillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSextillionYears = new (
       "nautical mile per square sextillion years"
     , "nmi/Zyr²"
     , CablePerSquareQuintillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) chain per square year. Defined as: (22.0)/((365.2525)*(365.2525)) × yard per square day.
   /// </summary>
   public static readonly Acceleration ChainPerSquareYear = new (
                                                                 "chain per square year"
                                                               , "ch/yr²"
                                                               , YardPerSquareDay
                                                               , 22.0 / (365.2525 * 365.2525)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) cable per square decade. Defined as: (100.0)/((10.0)*(10.0)) × fathom per square year.
   /// </summary>
   public static readonly Acceleration CablePerSquareDecade = new (
                                                                   "cable per square decade"
                                                                 , "cable/decade²"
                                                                 , FathomPerSquareYear
                                                                 , 100.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) barleycorn per square decillion years. Defined as: (1.0/36.0)/((1000.0)*(1000.0)) × foot per square nonillion years.
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDecillionYears = new (
                                                                                "barleycorn per square decillion years"
                                                                              , "barleycorn/decillion yr²"
                                                                              , FootPerSquareNonillionYears
                                                                              , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) mile per square decade. Defined as: (8.0)/((10.0)*(10.0)) × furlong per square year.
   /// </summary>
   public static readonly Acceleration MilePerSquareDecade = new (
                                                                  "mile per square decade"
                                                                , "mi/decade²"
                                                                , FurlongPerSquareYear
                                                                , 8.0 / (10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) nautical mile per square century. Defined as: (10.0)/((10.0)*(10.0)) × cable per square decade.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareCentury = new (
                                                                           "nautical mile per square century"
                                                                         , "nmi/century²"
                                                                         , CablePerSquareDecade
                                                                         , 10.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) furlong per square octillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × chain per square septillion years.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareOctillionYears = new (
                                                                             "furlong per square octillion years"
                                                                           , "fur/Ryr²"
                                                                           , ChainPerSquareSeptillionYears
                                                                           , 10.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) mile per square week. Defined as: (8.0)/((7.0)*(7.0)) × furlong per square day.
   /// </summary>
   public static readonly Acceleration MilePerSquareWeek = new (
                                                                "mile per square week"
                                                              , "mi/wk²"
                                                              , FurlongPerSquareDay
                                                              , 8.0 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) nautical mile per square nonillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × cable per square octillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareNonillionYears = new (
       "nautical mile per square nonillion years"
     , "nmi/Qyr²"
     , CablePerSquareOctillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) chain per square millennium. Defined as: (22.0)/((10.0)*(10.0)) × yard per square century.
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillennium = new (
                                                                       "chain per square millennium"
                                                                     , "ch/kyr²"
                                                                     , YardPerSquareCentury
                                                                     , 22.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) furlong per square century. Defined as: (10.0)/((10.0)*(10.0)) × chain per square decade.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareCentury = new (
                                                                      "furlong per square century"
                                                                    , "fur/century²"
                                                                    , ChainPerSquareDecade
                                                                    , 10.0 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) cable per square nonillion years. Defined as: (100.0)/((1000.0)*(1000.0)) × fathom per square octillion years.
   /// </summary>
   public static readonly Acceleration CablePerSquareNonillionYears = new (
                                                                           "cable per square nonillion years"
                                                                         , "cable/Qyr²"
                                                                         , FathomPerSquareOctillionYears
                                                                         , 100.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) nautical mile per square day. Defined as: (10.0)/((24.0)*(24.0)) × cable per square hour.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDay = new (
                                                                       "nautical mile per square day"
                                                                     , "nmi/dy²"
                                                                     , CablePerSquareHour
                                                                     , 10.0 / (24.0 * 24.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) league per square septillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square sextillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSeptillionYears = new (
                                                                             "league per square septillion years"
                                                                           , "lea/Yyr²"
                                                                           , MilePerSquareSextillionYears
                                                                           , 3.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) league per square week. Defined as: (3.0)/((7.0)*(7.0)) × mile per square day.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareWeek =
            new ("league per square week", "lea/wk²", MilePerSquareDay, 3.0 / (7.0 * 7.0), 0);

   /// <summary>
   /// A(n) chain per square trillion years. Defined as: (22.0)/((1000.0)*(1000.0)) × yard per square billion years.
   /// </summary>
   public static readonly Acceleration ChainPerSquareTrillionYears = new (
                                                                          "chain per square trillion years"
                                                                        , "ch/Tyr²"
                                                                        , YardPerSquareBillionYears
                                                                        , 22.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square quadrillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × chain per square trillion years.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuadrillionYears = new (
                                                                               "furlong per square quadrillion years"
                                                                             , "fur/Pyr²"
                                                                             , ChainPerSquareTrillionYears
                                                                             , 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) league per square nonillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square octillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNonillionYears = new (
                                                                            "league per square nonillion years"
                                                                          , "lea/Qyr²"
                                                                          , MilePerSquareOctillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) nautical mile per square decade. Defined as: (10.0)/((10.0)*(10.0)) × cable per square year.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecade = new (
                                                                          "nautical mile per square decade"
                                                                        , "nmi/decade²"
                                                                        , CablePerSquareYear
                                                                        , 10.0 / (10.0 * 10.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) league per square decade. Defined as: (3.0)/((10.0)*(10.0)) × mile per square year.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecade = new (
                                                                    "league per square decade"
                                                                  , "lea/decade²"
                                                                  , MilePerSquareYear
                                                                  , 3.0 / (10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nautical mile per square octillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × cable per square septillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareOctillionYears = new (
       "nautical mile per square octillion years"
     , "nmi/Ryr²"
     , CablePerSquareSeptillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) mile per square nonillion years. Defined as: (8.0)/((1000.0)*(1000.0)) × furlong per square octillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareNonillionYears = new (
                                                                          "mile per square nonillion years"
                                                                        , "mi/Qyr²"
                                                                        , FurlongPerSquareOctillionYears
                                                                        , 8.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square billion years. Defined as: (10.0)/((1000.0)*(1000.0)) × chain per square million years.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareBillionYears = new (
                                                                           "furlong per square billion years"
                                                                         , "fur/Gyr²"
                                                                         , ChainPerSquareMillionYears
                                                                         , 10.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) mile per square quintillion years. Defined as: (8.0)/((1000.0)*(1000.0)) × furlong per square quadrillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareQuintillionYears = new (
                                                                            "mile per square quintillion years"
                                                                          , "mi/Eyr²"
                                                                          , FurlongPerSquareQuadrillionYears
                                                                          , 8.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) mile per square trillion years. Defined as: (8.0)/((1000.0)*(1000.0)) × furlong per square billion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareTrillionYears = new (
                                                                         "mile per square trillion years"
                                                                       , "mi/Tyr²"
                                                                       , FurlongPerSquareBillionYears
                                                                       , 8.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square millennium. Defined as: (10.0)/((10.0)*(10.0)) × chain per square century.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillennium = new (
                                                                         "furlong per square millennium"
                                                                       , "fur/kyr²"
                                                                       , ChainPerSquareCentury
                                                                       , 10.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square quadrillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square trillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuadrillionYears = new (
                                                                              "league per square quadrillion years"
                                                                            , "lea/Pyr²"
                                                                            , MilePerSquareTrillionYears
                                                                            , 3.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) league per square sextillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square quintillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSextillionYears = new (
                                                                             "league per square sextillion years"
                                                                           , "lea/Zyr²"
                                                                           , MilePerSquareQuintillionYears
                                                                           , 3.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) furlong per square decade. Defined as: (10.0)/((10.0)*(10.0)) × chain per square year.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecade = new (
                                                                     "furlong per square decade"
                                                                   , "fur/decade²"
                                                                   , ChainPerSquareYear
                                                                   , 10.0 / (10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nautical mile per square decillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × cable per square nonillion years.
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecillionYears = new (
       "nautical mile per square decillion years"
     , "nmi/decillion yr²"
     , CablePerSquareNonillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) league per square decillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square nonillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecillionYears = new (
                                                                            "league per square decillion years"
                                                                          , "lea/decillion yr²"
                                                                          , MilePerSquareNonillionYears
                                                                          , 3.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) furlong per square trillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × chain per square billion years.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareTrillionYears = new (
                                                                            "furlong per square trillion years"
                                                                          , "fur/Tyr²"
                                                                          , ChainPerSquareBillionYears
                                                                          , 10.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) league per square century. Defined as: (3.0)/((10.0)*(10.0)) × mile per square decade.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentury = new (
                                                                     "league per square century"
                                                                   , "lea/century²"
                                                                   , MilePerSquareDecade
                                                                   , 3.0 / (10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) mile per square quadrillion years. Defined as: (8.0)/((1000.0)*(1000.0)) × furlong per square trillion years.
   /// </summary>
   public static readonly Acceleration MilePerSquareQuadrillionYears = new (
                                                                            "mile per square quadrillion years"
                                                                          , "mi/Pyr²"
                                                                          , FurlongPerSquareTrillionYears
                                                                          , 8.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) furlong per square million years. Defined as: (10.0)/((1000.0)*(1000.0)) × chain per square millennium.
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillionYears = new (
                                                                           "furlong per square million years"
                                                                         , "fur/Myr²"
                                                                         , ChainPerSquareMillennium
                                                                         , 10.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) mile per square millennium. Defined as: (8.0)/((10.0)*(10.0)) × furlong per square century.
   /// </summary>
   public static readonly Acceleration MilePerSquareMillennium = new (
                                                                      "mile per square millennium"
                                                                    , "mi/kyr²"
                                                                    , FurlongPerSquareCentury
                                                                    , 8.0 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) league per square quintillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square quadrillion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuintillionYears = new (
                                                                              "league per square quintillion years"
                                                                            , "lea/Eyr²"
                                                                            , MilePerSquareQuadrillionYears
                                                                            , 3.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) mile per square million years. Defined as: (8.0)/((1000.0)*(1000.0)) × furlong per square millennium.
   /// </summary>
   public static readonly Acceleration MilePerSquareMillionYears = new (
                                                                        "mile per square million years"
                                                                      , "mi/Myr²"
                                                                      , FurlongPerSquareMillennium
                                                                      , 8.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) mile per square century. Defined as: (8.0)/((10.0)*(10.0)) × furlong per square decade.
   /// </summary>
   public static readonly Acceleration MilePerSquareCentury = new (
                                                                   "mile per square century"
                                                                 , "mi/century²"
                                                                 , FurlongPerSquareDecade
                                                                 , 8.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) league per square billion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square million years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareBillionYears = new (
                                                                          "league per square billion years"
                                                                        , "lea/Gyr²"
                                                                        , MilePerSquareMillionYears
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) mile per square billion years. Defined as: (8.0)/((1000.0)*(1000.0)) × furlong per square million years.
   /// </summary>
   public static readonly Acceleration MilePerSquareBillionYears = new (
                                                                        "mile per square billion years"
                                                                      , "mi/Gyr²"
                                                                      , FurlongPerSquareMillionYears
                                                                      , 8.0 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square million years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square millennium.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillionYears = new (
                                                                          "league per square million years"
                                                                        , "lea/Myr²"
                                                                        , MilePerSquareMillennium
                                                                        , 3.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) league per square trillion years. Defined as: (3.0)/((1000.0)*(1000.0)) × mile per square billion years.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTrillionYears = new (
                                                                           "league per square trillion years"
                                                                         , "lea/Tyr²"
                                                                         , MilePerSquareBillionYears
                                                                         , 3.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) league per square millennium. Defined as: (3.0)/((10.0)*(10.0)) × mile per square century.
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillennium = new (
                                                                        "league per square millennium"
                                                                      , "lea/kyr²"
                                                                      , MilePerSquareCentury
                                                                      , 3.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );
}
