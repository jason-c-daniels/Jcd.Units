#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Acceleration.
/// </summary>
public class Accelerations : UnitOfMeasureEnumeration<Accelerations, Acceleration>
{
   /// <summary>
   /// A(n) meter per square second.
   /// </summary>
   public static readonly Acceleration MeterPerSquareSecond = new ("meter per square second", "m/s²");

   /// <summary>
   /// A(n) meter per square decisecond. Defined as: (1.0)/((1.0/10.0)*(1.0/10.0)) × meter per square second.
   /// </summary>
   public static readonly Acceleration MeterPerSquareDecisecond = new (
                                                                       "meter per square decisecond"
                                                                     , "m/ds²"
                                                                     , MeterPerSquareSecond
                                                                     , 1.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) decimeter per square second. Defined as: (1.0/10.0)/((1.0)*(1.0)) × meter per square second.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareSecond = new (
                                                                       "decimeter per square second"
                                                                     , "dm/s²"
                                                                     , MeterPerSquareSecond
                                                                     , 1.0 / 10.0 / (1.0 * 1.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square centisecond. Defined as: (1.0)/((1.0/10.0)*(1.0/10.0)) × meter per square decisecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquareCentisecond = new (
                                                                        "meter per square centisecond"
                                                                      , "m/cs²"
                                                                      , MeterPerSquareDecisecond
                                                                      , 1.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) decimeter per square decisecond. Defined as: (1.0/10.0)/((1.0/10.0)*(1.0/10.0)) × meter per square second.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareDecisecond = new (
                                                                           "decimeter per square decisecond"
                                                                         , "dm/ds²"
                                                                         , MeterPerSquareSecond
                                                                         , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) centimeter per square second. Defined as: (1.0/10.0)/((1.0)*(1.0)) × decimeter per square second.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareSecond = new (
                                                                        "centimeter per square second"
                                                                      , "cm/s²"
                                                                      , DecimeterPerSquareSecond
                                                                      , 1.0 / 10.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square millisecond. Defined as: (1.0)/((1.0/10.0)*(1.0/10.0)) × meter per square centisecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquareMillisecond = new (
                                                                        "meter per square millisecond"
                                                                      , "m/ms²"
                                                                      , MeterPerSquareCentisecond
                                                                      , 1.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) decimeter per square centisecond. Defined as: (1.0/10.0)/((1.0/10.0)*(1.0/10.0)) × meter per square decisecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareCentisecond = new (
                                                                            "decimeter per square centisecond"
                                                                          , "dm/cs²"
                                                                          , MeterPerSquareDecisecond
                                                                          , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) centimeter per square decisecond. Defined as: (1.0/10.0)/((1.0/10.0)*(1.0/10.0)) × decimeter per square second.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareDecisecond = new (
                                                                            "centimeter per square decisecond"
                                                                          , "cm/ds²"
                                                                          , DecimeterPerSquareSecond
                                                                          , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) millimeter per square second. Defined as: (1.0/10.0)/((1.0)*(1.0)) × centimeter per square second.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareSecond = new (
                                                                        "millimeter per square second"
                                                                      , "mm/s²"
                                                                      , CentimeterPerSquareSecond
                                                                      , 1.0 / 10.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square microsecond. Defined as: (1.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square millisecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquareMicrosecond = new (
                                                                        "meter per square microsecond"
                                                                      , "m/μs²"
                                                                      , MeterPerSquareMillisecond
                                                                      , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) decimeter per square millisecond. Defined as: (1.0/10.0)/((1.0/10.0)*(1.0/10.0)) × meter per square centisecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareMillisecond = new (
                                                                            "decimeter per square millisecond"
                                                                          , "dm/ms²"
                                                                          , MeterPerSquareCentisecond
                                                                          , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) centimeter per square centisecond. Defined as: (1.0/10.0)/((1.0/10.0)*(1.0/10.0)) × decimeter per square decisecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareCentisecond = new (
                                                                             "centimeter per square centisecond"
                                                                           , "cm/cs²"
                                                                           , DecimeterPerSquareDecisecond
                                                                           , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) millimeter per square decisecond. Defined as: (1.0/10.0)/((1.0/10.0)*(1.0/10.0)) × centimeter per square second.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareDecisecond = new (
                                                                            "millimeter per square decisecond"
                                                                          , "mm/ds²"
                                                                          , CentimeterPerSquareSecond
                                                                          , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) micrometer per square second. Defined as: (1.0/1000.0)/((1.0)*(1.0)) × millimeter per square second.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareSecond = new (
                                                                        "micrometer per square second"
                                                                      , "μm/s²"
                                                                      , MillimeterPerSquareSecond
                                                                      , 1.0 / 1000.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square nanosecond. Defined as: (1.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square microsecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquareNanosecond = new (
                                                                       "meter per square nanosecond"
                                                                     , "m/ns²"
                                                                     , MeterPerSquareMicrosecond
                                                                     , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) decimeter per square microsecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square millisecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareMicrosecond = new (
                                                                            "decimeter per square microsecond"
                                                                          , "dm/μs²"
                                                                          , MeterPerSquareMillisecond
                                                                          , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) centimeter per square millisecond. Defined as: (1.0/10.0)/((1.0/10.0)*(1.0/10.0)) × decimeter per square centisecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareMillisecond = new (
                                                                             "centimeter per square millisecond"
                                                                           , "cm/ms²"
                                                                           , DecimeterPerSquareCentisecond
                                                                           , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) millimeter per square centisecond. Defined as: (1.0/10.0)/((1.0/10.0)*(1.0/10.0)) × centimeter per square decisecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareCentisecond = new (
                                                                             "millimeter per square centisecond"
                                                                           , "mm/cs²"
                                                                           , CentimeterPerSquareDecisecond
                                                                           , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) micrometer per square decisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × millimeter per square second.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareDecisecond = new (
                                                                            "micrometer per square decisecond"
                                                                          , "μm/ds²"
                                                                          , MillimeterPerSquareSecond
                                                                          , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) nanometer per square second. Defined as: (1.0/1000.0)/((1.0)*(1.0)) × micrometer per square second.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareSecond = new (
                                                                       "nanometer per square second"
                                                                     , "nm/s²"
                                                                     , MicrometerPerSquareSecond
                                                                     , 1.0 / 1000.0 / (1.0 * 1.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square picosecond. Defined as: (1.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square nanosecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquarePicosecond = new (
                                                                       "meter per square picosecond"
                                                                     , "m/ps²"
                                                                     , MeterPerSquareNanosecond
                                                                     , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) decimeter per square nanosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square microsecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareNanosecond = new (
                                                                           "decimeter per square nanosecond"
                                                                         , "dm/ns²"
                                                                         , MeterPerSquareMicrosecond
                                                                         , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) centimeter per square microsecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × decimeter per square millisecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareMicrosecond = new (
                                                                             "centimeter per square microsecond"
                                                                           , "cm/μs²"
                                                                           , DecimeterPerSquareMillisecond
                                                                           , 1.0
                                                                           / 10.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) millimeter per square millisecond. Defined as: (1.0/10.0)/((1.0/10.0)*(1.0/10.0)) × centimeter per square centisecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareMillisecond = new (
                                                                             "millimeter per square millisecond"
                                                                           , "mm/ms²"
                                                                           , CentimeterPerSquareCentisecond
                                                                           , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) micrometer per square centisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × millimeter per square decisecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareCentisecond = new (
                                                                             "micrometer per square centisecond"
                                                                           , "μm/cs²"
                                                                           , MillimeterPerSquareDecisecond
                                                                           , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) nanometer per square decisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × micrometer per square second.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareDecisecond = new (
                                                                           "nanometer per square decisecond"
                                                                         , "nm/ds²"
                                                                         , MicrometerPerSquareSecond
                                                                         , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) picometer per square second. Defined as: (1.0/1000.0)/((1.0)*(1.0)) × nanometer per square second.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareSecond = new (
                                                                       "picometer per square second"
                                                                     , "pm/s²"
                                                                     , NanometerPerSquareSecond
                                                                     , 1.0 / 1000.0 / (1.0 * 1.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square femtosecond. Defined as: (1.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square picosecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquareFemtosecond = new (
                                                                        "meter per square femtosecond"
                                                                      , "m/fs²"
                                                                      , MeterPerSquarePicosecond
                                                                      , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) decimeter per square picosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square nanosecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquarePicosecond = new (
                                                                           "decimeter per square picosecond"
                                                                         , "dm/ps²"
                                                                         , MeterPerSquareNanosecond
                                                                         , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) centimeter per square nanosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × decimeter per square microsecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareNanosecond = new (
                                                                            "centimeter per square nanosecond"
                                                                          , "cm/ns²"
                                                                          , DecimeterPerSquareMicrosecond
                                                                          , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) millimeter per square microsecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × centimeter per square millisecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareMicrosecond = new (
                                                                             "millimeter per square microsecond"
                                                                           , "mm/μs²"
                                                                           , CentimeterPerSquareMillisecond
                                                                           , 1.0
                                                                           / 10.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) micrometer per square millisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × millimeter per square centisecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareMillisecond = new (
                                                                             "micrometer per square millisecond"
                                                                           , "μm/ms²"
                                                                           , MillimeterPerSquareCentisecond
                                                                           , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) nanometer per square centisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × micrometer per square decisecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareCentisecond = new (
                                                                            "nanometer per square centisecond"
                                                                          , "nm/cs²"
                                                                          , MicrometerPerSquareDecisecond
                                                                          , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) picometer per square decisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × nanometer per square second.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareDecisecond = new (
                                                                           "picometer per square decisecond"
                                                                         , "pm/ds²"
                                                                         , NanometerPerSquareSecond
                                                                         , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) femtometer per square second. Defined as: (1.0/1000.0)/((1.0)*(1.0)) × picometer per square second.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareSecond = new (
                                                                        "femtometer per square second"
                                                                      , "fm/s²"
                                                                      , PicometerPerSquareSecond
                                                                      , 1.0 / 1000.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square attosecond. Defined as: (1.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square femtosecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquareAttosecond = new (
                                                                       "meter per square attosecond"
                                                                     , "m/as²"
                                                                     , MeterPerSquareFemtosecond
                                                                     , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) decimeter per square femtosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square picosecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareFemtosecond = new (
                                                                            "decimeter per square femtosecond"
                                                                          , "dm/fs²"
                                                                          , MeterPerSquarePicosecond
                                                                          , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) centimeter per square picosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × decimeter per square nanosecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquarePicosecond = new (
                                                                            "centimeter per square picosecond"
                                                                          , "cm/ps²"
                                                                          , DecimeterPerSquareNanosecond
                                                                          , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) millimeter per square nanosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × centimeter per square microsecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareNanosecond = new (
                                                                            "millimeter per square nanosecond"
                                                                          , "mm/ns²"
                                                                          , CentimeterPerSquareMicrosecond
                                                                          , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) micrometer per square microsecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × millimeter per square millisecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareMicrosecond = new (
                                                                             "micrometer per square microsecond"
                                                                           , "μm/μs²"
                                                                           , MillimeterPerSquareMillisecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) nanometer per square millisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × micrometer per square centisecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareMillisecond = new (
                                                                            "nanometer per square millisecond"
                                                                          , "nm/ms²"
                                                                          , MicrometerPerSquareCentisecond
                                                                          , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) picometer per square centisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × nanometer per square decisecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareCentisecond = new (
                                                                            "picometer per square centisecond"
                                                                          , "pm/cs²"
                                                                          , NanometerPerSquareDecisecond
                                                                          , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) femtometer per square decisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × picometer per square second.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareDecisecond = new (
                                                                            "femtometer per square decisecond"
                                                                          , "fm/ds²"
                                                                          , PicometerPerSquareSecond
                                                                          , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) attometer per square second. Defined as: (1.0/1000.0)/((1.0)*(1.0)) × femtometer per square second.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareSecond = new (
                                                                       "attometer per square second"
                                                                     , "am/s²"
                                                                     , FemtometerPerSquareSecond
                                                                     , 1.0 / 1000.0 / (1.0 * 1.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square zeptosecond. Defined as: (1.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square attosecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquareZeptosecond = new (
                                                                        "meter per square zeptosecond"
                                                                      , "m/zs²"
                                                                      , MeterPerSquareAttosecond
                                                                      , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) decimeter per square attosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square femtosecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareAttosecond = new (
                                                                           "decimeter per square attosecond"
                                                                         , "dm/as²"
                                                                         , MeterPerSquareFemtosecond
                                                                         , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) centimeter per square femtosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × decimeter per square picosecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareFemtosecond = new (
                                                                             "centimeter per square femtosecond"
                                                                           , "cm/fs²"
                                                                           , DecimeterPerSquarePicosecond
                                                                           , 1.0
                                                                           / 10.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) millimeter per square picosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × centimeter per square nanosecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquarePicosecond = new (
                                                                            "millimeter per square picosecond"
                                                                          , "mm/ps²"
                                                                          , CentimeterPerSquareNanosecond
                                                                          , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) micrometer per square nanosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × millimeter per square microsecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareNanosecond = new (
                                                                            "micrometer per square nanosecond"
                                                                          , "μm/ns²"
                                                                          , MillimeterPerSquareMicrosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) nanometer per square microsecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × micrometer per square millisecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareMicrosecond = new (
                                                                            "nanometer per square microsecond"
                                                                          , "nm/μs²"
                                                                          , MicrometerPerSquareMillisecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) picometer per square millisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × nanometer per square centisecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareMillisecond = new (
                                                                            "picometer per square millisecond"
                                                                          , "pm/ms²"
                                                                          , NanometerPerSquareCentisecond
                                                                          , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) femtometer per square centisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × picometer per square decisecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareCentisecond = new (
                                                                             "femtometer per square centisecond"
                                                                           , "fm/cs²"
                                                                           , PicometerPerSquareDecisecond
                                                                           , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) attometer per square decisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × femtometer per square second.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareDecisecond = new (
                                                                           "attometer per square decisecond"
                                                                         , "am/ds²"
                                                                         , FemtometerPerSquareSecond
                                                                         , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) zeptometer per square second. Defined as: (1.0/1000.0)/((1.0)*(1.0)) × attometer per square second.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareSecond = new (
                                                                        "zeptometer per square second"
                                                                      , "zm/s²"
                                                                      , AttometerPerSquareSecond
                                                                      , 1.0 / 1000.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square yoctosecond. Defined as: (1.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquareYoctosecond = new (
                                                                        "meter per square yoctosecond"
                                                                      , "m/ys²"
                                                                      , MeterPerSquareZeptosecond
                                                                      , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) decimeter per square zeptosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square attosecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareZeptosecond = new (
                                                                            "decimeter per square zeptosecond"
                                                                          , "dm/zs²"
                                                                          , MeterPerSquareAttosecond
                                                                          , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) centimeter per square attosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × decimeter per square femtosecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareAttosecond = new (
                                                                            "centimeter per square attosecond"
                                                                          , "cm/as²"
                                                                          , DecimeterPerSquareFemtosecond
                                                                          , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) millimeter per square femtosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × centimeter per square picosecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareFemtosecond = new (
                                                                             "millimeter per square femtosecond"
                                                                           , "mm/fs²"
                                                                           , CentimeterPerSquarePicosecond
                                                                           , 1.0
                                                                           / 10.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) micrometer per square picosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × millimeter per square nanosecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquarePicosecond = new (
                                                                            "micrometer per square picosecond"
                                                                          , "μm/ps²"
                                                                          , MillimeterPerSquareNanosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) nanometer per square nanosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × micrometer per square microsecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareNanosecond = new (
                                                                           "nanometer per square nanosecond"
                                                                         , "nm/ns²"
                                                                         , MicrometerPerSquareMicrosecond
                                                                         , 1.0
                                                                         / 1000.0
                                                                         / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) picometer per square microsecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × nanometer per square millisecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareMicrosecond = new (
                                                                            "picometer per square microsecond"
                                                                          , "pm/μs²"
                                                                          , NanometerPerSquareMillisecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) femtometer per square millisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × picometer per square centisecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareMillisecond = new (
                                                                             "femtometer per square millisecond"
                                                                           , "fm/ms²"
                                                                           , PicometerPerSquareCentisecond
                                                                           , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) attometer per square centisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × femtometer per square decisecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareCentisecond = new (
                                                                            "attometer per square centisecond"
                                                                          , "am/cs²"
                                                                          , FemtometerPerSquareDecisecond
                                                                          , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zeptometer per square decisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × attometer per square second.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareDecisecond = new (
                                                                            "zeptometer per square decisecond"
                                                                          , "zm/ds²"
                                                                          , AttometerPerSquareSecond
                                                                          , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yoctometer per square second. Defined as: (1.0/1000.0)/((1.0)*(1.0)) × zeptometer per square second.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareSecond = new (
                                                                        "yoctometer per square second"
                                                                      , "ym/s²"
                                                                      , ZeptometerPerSquareSecond
                                                                      , 1.0 / 1000.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square rontosecond. Defined as: (1.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquareRontosecond = new (
                                                                        "meter per square rontosecond"
                                                                      , "m/rs²"
                                                                      , MeterPerSquareYoctosecond
                                                                      , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) decimeter per square yoctosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareYoctosecond = new (
                                                                            "decimeter per square yoctosecond"
                                                                          , "dm/ys²"
                                                                          , MeterPerSquareZeptosecond
                                                                          , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) centimeter per square zeptosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × decimeter per square attosecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareZeptosecond = new (
                                                                             "centimeter per square zeptosecond"
                                                                           , "cm/zs²"
                                                                           , DecimeterPerSquareAttosecond
                                                                           , 1.0
                                                                           / 10.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) millimeter per square attosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × centimeter per square femtosecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareAttosecond = new (
                                                                            "millimeter per square attosecond"
                                                                          , "mm/as²"
                                                                          , CentimeterPerSquareFemtosecond
                                                                          , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) micrometer per square femtosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × millimeter per square picosecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareFemtosecond = new (
                                                                             "micrometer per square femtosecond"
                                                                           , "μm/fs²"
                                                                           , MillimeterPerSquarePicosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) nanometer per square picosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × micrometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquarePicosecond = new (
                                                                           "nanometer per square picosecond"
                                                                         , "nm/ps²"
                                                                         , MicrometerPerSquareNanosecond
                                                                         , 1.0
                                                                         / 1000.0
                                                                         / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) picometer per square nanosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × nanometer per square microsecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareNanosecond = new (
                                                                           "picometer per square nanosecond"
                                                                         , "pm/ns²"
                                                                         , NanometerPerSquareMicrosecond
                                                                         , 1.0
                                                                         / 1000.0
                                                                         / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) femtometer per square microsecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × picometer per square millisecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareMicrosecond = new (
                                                                             "femtometer per square microsecond"
                                                                           , "fm/μs²"
                                                                           , PicometerPerSquareMillisecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) attometer per square millisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × femtometer per square centisecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareMillisecond = new (
                                                                            "attometer per square millisecond"
                                                                          , "am/ms²"
                                                                          , FemtometerPerSquareCentisecond
                                                                          , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zeptometer per square centisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × attometer per square decisecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareCentisecond = new (
                                                                             "zeptometer per square centisecond"
                                                                           , "zm/cs²"
                                                                           , AttometerPerSquareDecisecond
                                                                           , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yoctometer per square decisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × zeptometer per square second.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareDecisecond = new (
                                                                            "yoctometer per square decisecond"
                                                                          , "ym/ds²"
                                                                          , ZeptometerPerSquareSecond
                                                                          , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) rontometer per square second. Defined as: (1.0/1000.0)/((1.0)*(1.0)) × yoctometer per square second.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareSecond = new (
                                                                        "rontometer per square second"
                                                                      , "rm/s²"
                                                                      , YoctometerPerSquareSecond
                                                                      , 1.0 / 1000.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square quectosecond. Defined as: (1.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square rontosecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquareQuectosecond = new (
                                                                         "meter per square quectosecond"
                                                                       , "m/qs²"
                                                                       , MeterPerSquareRontosecond
                                                                       , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) decimeter per square rontosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareRontosecond = new (
                                                                            "decimeter per square rontosecond"
                                                                          , "dm/rs²"
                                                                          , MeterPerSquareYoctosecond
                                                                          , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) centimeter per square yoctosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × decimeter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareYoctosecond = new (
                                                                             "centimeter per square yoctosecond"
                                                                           , "cm/ys²"
                                                                           , DecimeterPerSquareZeptosecond
                                                                           , 1.0
                                                                           / 10.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) millimeter per square zeptosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × centimeter per square attosecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareZeptosecond = new (
                                                                             "millimeter per square zeptosecond"
                                                                           , "mm/zs²"
                                                                           , CentimeterPerSquareAttosecond
                                                                           , 1.0
                                                                           / 10.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) micrometer per square attosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × millimeter per square femtosecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareAttosecond = new (
                                                                            "micrometer per square attosecond"
                                                                          , "μm/as²"
                                                                          , MillimeterPerSquareFemtosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) nanometer per square femtosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × micrometer per square picosecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareFemtosecond = new (
                                                                            "nanometer per square femtosecond"
                                                                          , "nm/fs²"
                                                                          , MicrometerPerSquarePicosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) picometer per square picosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × nanometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquarePicosecond = new (
                                                                           "picometer per square picosecond"
                                                                         , "pm/ps²"
                                                                         , NanometerPerSquareNanosecond
                                                                         , 1.0
                                                                         / 1000.0
                                                                         / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) femtometer per square nanosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × picometer per square microsecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareNanosecond = new (
                                                                            "femtometer per square nanosecond"
                                                                          , "fm/ns²"
                                                                          , PicometerPerSquareMicrosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) attometer per square microsecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × femtometer per square millisecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareMicrosecond = new (
                                                                            "attometer per square microsecond"
                                                                          , "am/μs²"
                                                                          , FemtometerPerSquareMillisecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zeptometer per square millisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × attometer per square centisecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareMillisecond = new (
                                                                             "zeptometer per square millisecond"
                                                                           , "zm/ms²"
                                                                           , AttometerPerSquareCentisecond
                                                                           , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yoctometer per square centisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × zeptometer per square decisecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareCentisecond = new (
                                                                             "yoctometer per square centisecond"
                                                                           , "ym/cs²"
                                                                           , ZeptometerPerSquareDecisecond
                                                                           , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) rontometer per square decisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × yoctometer per square second.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareDecisecond = new (
                                                                            "rontometer per square decisecond"
                                                                          , "rm/ds²"
                                                                          , YoctometerPerSquareSecond
                                                                          , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) quectometer per square second. Defined as: (1.0/1000.0)/((1.0)*(1.0)) × rontometer per square second.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareSecond = new (
                                                                         "quectometer per square second"
                                                                       , "qm/s²"
                                                                       , RontometerPerSquareSecond
                                                                       , 1.0 / 1000.0 / (1.0 * 1.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) dekameter per square second. Defined as: (10.0)/((1.0)*(1.0)) × meter per square second.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareSecond =
            new ("dekameter per square second", "dam/s²", MeterPerSquareSecond, 10.0 / (1.0 * 1.0), 0);

   /// <summary>
   /// A(n) decimeter per square quectosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square rontosecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareQuectosecond = new (
                                                                             "decimeter per square quectosecond"
                                                                           , "dm/qs²"
                                                                           , MeterPerSquareRontosecond
                                                                           , 1.0
                                                                           / 10.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) centimeter per square rontosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × decimeter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareRontosecond = new (
                                                                             "centimeter per square rontosecond"
                                                                           , "cm/rs²"
                                                                           , DecimeterPerSquareYoctosecond
                                                                           , 1.0
                                                                           / 10.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) millimeter per square yoctosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × centimeter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareYoctosecond = new (
                                                                             "millimeter per square yoctosecond"
                                                                           , "mm/ys²"
                                                                           , CentimeterPerSquareZeptosecond
                                                                           , 1.0
                                                                           / 10.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) micrometer per square zeptosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × millimeter per square attosecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareZeptosecond = new (
                                                                             "micrometer per square zeptosecond"
                                                                           , "μm/zs²"
                                                                           , MillimeterPerSquareAttosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) nanometer per square attosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × micrometer per square femtosecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareAttosecond = new (
                                                                           "nanometer per square attosecond"
                                                                         , "nm/as²"
                                                                         , MicrometerPerSquareFemtosecond
                                                                         , 1.0
                                                                         / 1000.0
                                                                         / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) picometer per square femtosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × nanometer per square picosecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareFemtosecond = new (
                                                                            "picometer per square femtosecond"
                                                                          , "pm/fs²"
                                                                          , NanometerPerSquarePicosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) femtometer per square picosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × picometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquarePicosecond = new (
                                                                            "femtometer per square picosecond"
                                                                          , "fm/ps²"
                                                                          , PicometerPerSquareNanosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) attometer per square nanosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × femtometer per square microsecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareNanosecond = new (
                                                                           "attometer per square nanosecond"
                                                                         , "am/ns²"
                                                                         , FemtometerPerSquareMicrosecond
                                                                         , 1.0
                                                                         / 1000.0
                                                                         / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) zeptometer per square microsecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × attometer per square millisecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareMicrosecond = new (
                                                                             "zeptometer per square microsecond"
                                                                           , "zm/μs²"
                                                                           , AttometerPerSquareMillisecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yoctometer per square millisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × zeptometer per square centisecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareMillisecond = new (
                                                                             "yoctometer per square millisecond"
                                                                           , "ym/ms²"
                                                                           , ZeptometerPerSquareCentisecond
                                                                           , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) rontometer per square centisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × yoctometer per square decisecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareCentisecond = new (
                                                                             "rontometer per square centisecond"
                                                                           , "rm/cs²"
                                                                           , YoctometerPerSquareDecisecond
                                                                           , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quectometer per square decisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × rontometer per square second.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareDecisecond = new (
                                                                             "quectometer per square decisecond"
                                                                           , "qm/ds²"
                                                                           , RontometerPerSquareSecond
                                                                           , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) hectometer per square second. Defined as: (10.0)/((1.0)*(1.0)) × dekameter per square second.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareSecond = new (
                                                                        "hectometer per square second"
                                                                      , "hm/s²"
                                                                      , DekameterPerSquareSecond
                                                                      , 10.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) dekameter per square decisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × meter per square second.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareDecisecond = new (
                                                                           "dekameter per square decisecond"
                                                                         , "dam/ds²"
                                                                         , MeterPerSquareSecond
                                                                         , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) centimeter per square quectosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × decimeter per square rontosecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareQuectosecond = new (
                                                                              "centimeter per square quectosecond"
                                                                            , "cm/qs²"
                                                                            , DecimeterPerSquareRontosecond
                                                                            , 1.0
                                                                            / 10.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) millimeter per square rontosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × centimeter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareRontosecond = new (
                                                                             "millimeter per square rontosecond"
                                                                           , "mm/rs²"
                                                                           , CentimeterPerSquareYoctosecond
                                                                           , 1.0
                                                                           / 10.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) micrometer per square yoctosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × millimeter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareYoctosecond = new (
                                                                             "micrometer per square yoctosecond"
                                                                           , "μm/ys²"
                                                                           , MillimeterPerSquareZeptosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) nanometer per square zeptosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × micrometer per square attosecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareZeptosecond = new (
                                                                            "nanometer per square zeptosecond"
                                                                          , "nm/zs²"
                                                                          , MicrometerPerSquareAttosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) picometer per square attosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × nanometer per square femtosecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareAttosecond = new (
                                                                           "picometer per square attosecond"
                                                                         , "pm/as²"
                                                                         , NanometerPerSquareFemtosecond
                                                                         , 1.0
                                                                         / 1000.0
                                                                         / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) femtometer per square femtosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × picometer per square picosecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareFemtosecond = new (
                                                                             "femtometer per square femtosecond"
                                                                           , "fm/fs²"
                                                                           , PicometerPerSquarePicosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) attometer per square picosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × femtometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquarePicosecond = new (
                                                                           "attometer per square picosecond"
                                                                         , "am/ps²"
                                                                         , FemtometerPerSquareNanosecond
                                                                         , 1.0
                                                                         / 1000.0
                                                                         / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) zeptometer per square nanosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × attometer per square microsecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareNanosecond = new (
                                                                            "zeptometer per square nanosecond"
                                                                          , "zm/ns²"
                                                                          , AttometerPerSquareMicrosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yoctometer per square microsecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zeptometer per square millisecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareMicrosecond = new (
                                                                             "yoctometer per square microsecond"
                                                                           , "ym/μs²"
                                                                           , ZeptometerPerSquareMillisecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) rontometer per square millisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × yoctometer per square centisecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareMillisecond = new (
                                                                             "rontometer per square millisecond"
                                                                           , "rm/ms²"
                                                                           , YoctometerPerSquareCentisecond
                                                                           , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quectometer per square centisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × rontometer per square decisecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareCentisecond = new (
                                                                              "quectometer per square centisecond"
                                                                            , "qm/cs²"
                                                                            , RontometerPerSquareDecisecond
                                                                            , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) kilometer per square second. Defined as: (10.0)/((1.0)*(1.0)) × hectometer per square second.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareSecond = new (
                                                                       "kilometer per square second"
                                                                     , "km/s²"
                                                                     , HectometerPerSquareSecond
                                                                     , 10.0 / (1.0 * 1.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hectometer per square decisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × dekameter per square second.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareDecisecond = new (
                                                                            "hectometer per square decisecond"
                                                                          , "hm/ds²"
                                                                          , DekameterPerSquareSecond
                                                                          , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) dekameter per square centisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × meter per square decisecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareCentisecond = new (
                                                                            "dekameter per square centisecond"
                                                                          , "dam/cs²"
                                                                          , MeterPerSquareDecisecond
                                                                          , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) millimeter per square quectosecond. Defined as: (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)) × centimeter per square rontosecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareQuectosecond = new (
                                                                              "millimeter per square quectosecond"
                                                                            , "mm/qs²"
                                                                            , CentimeterPerSquareRontosecond
                                                                            , 1.0
                                                                            / 10.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) micrometer per square rontosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × millimeter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareRontosecond = new (
                                                                             "micrometer per square rontosecond"
                                                                           , "μm/rs²"
                                                                           , MillimeterPerSquareYoctosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) nanometer per square yoctosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × micrometer per square zeptosecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareYoctosecond = new (
                                                                            "nanometer per square yoctosecond"
                                                                          , "nm/ys²"
                                                                          , MicrometerPerSquareZeptosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) picometer per square zeptosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × nanometer per square attosecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareZeptosecond = new (
                                                                            "picometer per square zeptosecond"
                                                                          , "pm/zs²"
                                                                          , NanometerPerSquareAttosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) femtometer per square attosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × picometer per square femtosecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareAttosecond = new (
                                                                            "femtometer per square attosecond"
                                                                          , "fm/as²"
                                                                          , PicometerPerSquareFemtosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) attometer per square femtosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × femtometer per square picosecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareFemtosecond = new (
                                                                            "attometer per square femtosecond"
                                                                          , "am/fs²"
                                                                          , FemtometerPerSquarePicosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zeptometer per square picosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × attometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquarePicosecond = new (
                                                                            "zeptometer per square picosecond"
                                                                          , "zm/ps²"
                                                                          , AttometerPerSquareNanosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yoctometer per square nanosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zeptometer per square microsecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareNanosecond = new (
                                                                            "yoctometer per square nanosecond"
                                                                          , "ym/ns²"
                                                                          , ZeptometerPerSquareMicrosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) rontometer per square microsecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yoctometer per square millisecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareMicrosecond = new (
                                                                             "rontometer per square microsecond"
                                                                           , "rm/μs²"
                                                                           , YoctometerPerSquareMillisecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quectometer per square millisecond. Defined as: (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)) × rontometer per square centisecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareMillisecond = new (
                                                                              "quectometer per square millisecond"
                                                                            , "qm/ms²"
                                                                            , RontometerPerSquareCentisecond
                                                                            , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) megameter per square second. Defined as: (1000.0)/((1.0)*(1.0)) × kilometer per square second.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareSecond = new (
                                                                       "megameter per square second"
                                                                     , "Mm/s²"
                                                                     , KilometerPerSquareSecond
                                                                     , 1000.0 / (1.0 * 1.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) kilometer per square decisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × hectometer per square second.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareDecisecond = new (
                                                                           "kilometer per square decisecond"
                                                                         , "km/ds²"
                                                                         , HectometerPerSquareSecond
                                                                         , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) hectometer per square centisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × dekameter per square decisecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareCentisecond = new (
                                                                             "hectometer per square centisecond"
                                                                           , "hm/cs²"
                                                                           , DekameterPerSquareDecisecond
                                                                           , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) dekameter per square millisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × meter per square centisecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareMillisecond = new (
                                                                            "dekameter per square millisecond"
                                                                          , "dam/ms²"
                                                                          , MeterPerSquareCentisecond
                                                                          , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) micrometer per square quectosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × millimeter per square rontosecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareQuectosecond = new (
                                                                              "micrometer per square quectosecond"
                                                                            , "μm/qs²"
                                                                            , MillimeterPerSquareRontosecond
                                                                            , 1.0
                                                                            / 1000.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) nanometer per square rontosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × micrometer per square yoctosecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareRontosecond = new (
                                                                            "nanometer per square rontosecond"
                                                                          , "nm/rs²"
                                                                          , MicrometerPerSquareYoctosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) picometer per square yoctosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × nanometer per square zeptosecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareYoctosecond = new (
                                                                            "picometer per square yoctosecond"
                                                                          , "pm/ys²"
                                                                          , NanometerPerSquareZeptosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) femtometer per square zeptosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × picometer per square attosecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareZeptosecond = new (
                                                                             "femtometer per square zeptosecond"
                                                                           , "fm/zs²"
                                                                           , PicometerPerSquareAttosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) attometer per square attosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × femtometer per square femtosecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareAttosecond = new (
                                                                           "attometer per square attosecond"
                                                                         , "am/as²"
                                                                         , FemtometerPerSquareFemtosecond
                                                                         , 1.0
                                                                         / 1000.0
                                                                         / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) zeptometer per square femtosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × attometer per square picosecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareFemtosecond = new (
                                                                             "zeptometer per square femtosecond"
                                                                           , "zm/fs²"
                                                                           , AttometerPerSquarePicosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yoctometer per square picosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zeptometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquarePicosecond = new (
                                                                            "yoctometer per square picosecond"
                                                                          , "ym/ps²"
                                                                          , ZeptometerPerSquareNanosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) rontometer per square nanosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yoctometer per square microsecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareNanosecond = new (
                                                                            "rontometer per square nanosecond"
                                                                          , "rm/ns²"
                                                                          , YoctometerPerSquareMicrosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) quectometer per square microsecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × rontometer per square millisecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareMicrosecond = new (
                                                                              "quectometer per square microsecond"
                                                                            , "qm/μs²"
                                                                            , RontometerPerSquareMillisecond
                                                                            , 1.0
                                                                            / 1000.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) gigameter per square second. Defined as: (1000.0)/((1.0)*(1.0)) × megameter per square second.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareSecond = new (
                                                                       "gigameter per square second"
                                                                     , "Gm/s²"
                                                                     , MegameterPerSquareSecond
                                                                     , 1000.0 / (1.0 * 1.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) megameter per square decisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × kilometer per square second.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareDecisecond = new (
                                                                           "megameter per square decisecond"
                                                                         , "Mm/ds²"
                                                                         , KilometerPerSquareSecond
                                                                         , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) kilometer per square centisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × hectometer per square decisecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareCentisecond = new (
                                                                            "kilometer per square centisecond"
                                                                          , "km/cs²"
                                                                          , HectometerPerSquareDecisecond
                                                                          , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) hectometer per square millisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × dekameter per square centisecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareMillisecond = new (
                                                                             "hectometer per square millisecond"
                                                                           , "hm/ms²"
                                                                           , DekameterPerSquareCentisecond
                                                                           , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) dekameter per square microsecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square millisecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareMicrosecond = new (
                                                                            "dekameter per square microsecond"
                                                                          , "dam/μs²"
                                                                          , MeterPerSquareMillisecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) nanometer per square quectosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × micrometer per square rontosecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareQuectosecond = new (
                                                                             "nanometer per square quectosecond"
                                                                           , "nm/qs²"
                                                                           , MicrometerPerSquareRontosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) picometer per square rontosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × nanometer per square yoctosecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareRontosecond = new (
                                                                            "picometer per square rontosecond"
                                                                          , "pm/rs²"
                                                                          , NanometerPerSquareYoctosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) femtometer per square yoctosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × picometer per square zeptosecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareYoctosecond = new (
                                                                             "femtometer per square yoctosecond"
                                                                           , "fm/ys²"
                                                                           , PicometerPerSquareZeptosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) attometer per square zeptosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × femtometer per square attosecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareZeptosecond = new (
                                                                            "attometer per square zeptosecond"
                                                                          , "am/zs²"
                                                                          , FemtometerPerSquareAttosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zeptometer per square attosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × attometer per square femtosecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareAttosecond = new (
                                                                            "zeptometer per square attosecond"
                                                                          , "zm/as²"
                                                                          , AttometerPerSquareFemtosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yoctometer per square femtosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zeptometer per square picosecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareFemtosecond = new (
                                                                             "yoctometer per square femtosecond"
                                                                           , "ym/fs²"
                                                                           , ZeptometerPerSquarePicosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) rontometer per square picosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yoctometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquarePicosecond = new (
                                                                            "rontometer per square picosecond"
                                                                          , "rm/ps²"
                                                                          , YoctometerPerSquareNanosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) quectometer per square nanosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × rontometer per square microsecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareNanosecond = new (
                                                                             "quectometer per square nanosecond"
                                                                           , "qm/ns²"
                                                                           , RontometerPerSquareMicrosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) terameter per square second. Defined as: (1000.0)/((1.0)*(1.0)) × gigameter per square second.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareSecond = new (
                                                                       "terameter per square second"
                                                                     , "Tm/s²"
                                                                     , GigameterPerSquareSecond
                                                                     , 1000.0 / (1.0 * 1.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) gigameter per square decisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × megameter per square second.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareDecisecond = new (
                                                                           "gigameter per square decisecond"
                                                                         , "Gm/ds²"
                                                                         , MegameterPerSquareSecond
                                                                         , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) megameter per square centisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × kilometer per square decisecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareCentisecond = new (
                                                                            "megameter per square centisecond"
                                                                          , "Mm/cs²"
                                                                          , KilometerPerSquareDecisecond
                                                                          , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) kilometer per square millisecond. Defined as: (10.0)/((1.0/10.0)*(1.0/10.0)) × hectometer per square centisecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareMillisecond = new (
                                                                            "kilometer per square millisecond"
                                                                          , "km/ms²"
                                                                          , HectometerPerSquareCentisecond
                                                                          , 10.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) hectometer per square microsecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × dekameter per square millisecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareMicrosecond = new (
                                                                             "hectometer per square microsecond"
                                                                           , "hm/μs²"
                                                                           , DekameterPerSquareMillisecond
                                                                           , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) dekameter per square nanosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square microsecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareNanosecond = new (
                                                                           "dekameter per square nanosecond"
                                                                         , "dam/ns²"
                                                                         , MeterPerSquareMicrosecond
                                                                         , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) picometer per square quectosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × nanometer per square rontosecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareQuectosecond = new (
                                                                             "picometer per square quectosecond"
                                                                           , "pm/qs²"
                                                                           , NanometerPerSquareRontosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) femtometer per square rontosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × picometer per square yoctosecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareRontosecond = new (
                                                                             "femtometer per square rontosecond"
                                                                           , "fm/rs²"
                                                                           , PicometerPerSquareYoctosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) attometer per square yoctosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × femtometer per square zeptosecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareYoctosecond = new (
                                                                            "attometer per square yoctosecond"
                                                                          , "am/ys²"
                                                                          , FemtometerPerSquareZeptosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zeptometer per square zeptosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × attometer per square attosecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareZeptosecond = new (
                                                                             "zeptometer per square zeptosecond"
                                                                           , "zm/zs²"
                                                                           , AttometerPerSquareAttosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yoctometer per square attosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zeptometer per square femtosecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareAttosecond = new (
                                                                            "yoctometer per square attosecond"
                                                                          , "ym/as²"
                                                                          , ZeptometerPerSquareFemtosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) rontometer per square femtosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yoctometer per square picosecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareFemtosecond = new (
                                                                             "rontometer per square femtosecond"
                                                                           , "rm/fs²"
                                                                           , YoctometerPerSquarePicosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quectometer per square picosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × rontometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquarePicosecond = new (
                                                                             "quectometer per square picosecond"
                                                                           , "qm/ps²"
                                                                           , RontometerPerSquareNanosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) petameter per square second. Defined as: (1000.0)/((1.0)*(1.0)) × terameter per square second.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareSecond = new (
                                                                       "petameter per square second"
                                                                     , "Pm/s²"
                                                                     , TerameterPerSquareSecond
                                                                     , 1000.0 / (1.0 * 1.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) terameter per square decisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × gigameter per square second.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareDecisecond = new (
                                                                           "terameter per square decisecond"
                                                                         , "Tm/ds²"
                                                                         , GigameterPerSquareSecond
                                                                         , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) gigameter per square centisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × megameter per square decisecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareCentisecond = new (
                                                                            "gigameter per square centisecond"
                                                                          , "Gm/cs²"
                                                                          , MegameterPerSquareDecisecond
                                                                          , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) megameter per square millisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × kilometer per square centisecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareMillisecond = new (
                                                                            "megameter per square millisecond"
                                                                          , "Mm/ms²"
                                                                          , KilometerPerSquareCentisecond
                                                                          , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) kilometer per square microsecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × hectometer per square millisecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareMicrosecond = new (
                                                                            "kilometer per square microsecond"
                                                                          , "km/μs²"
                                                                          , HectometerPerSquareMillisecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) hectometer per square nanosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × dekameter per square microsecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareNanosecond = new (
                                                                            "hectometer per square nanosecond"
                                                                          , "hm/ns²"
                                                                          , DekameterPerSquareMicrosecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) dekameter per square picosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square nanosecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquarePicosecond = new (
                                                                           "dekameter per square picosecond"
                                                                         , "dam/ps²"
                                                                         , MeterPerSquareNanosecond
                                                                         , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) femtometer per square quectosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × picometer per square rontosecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareQuectosecond = new (
                                                                              "femtometer per square quectosecond"
                                                                            , "fm/qs²"
                                                                            , PicometerPerSquareRontosecond
                                                                            , 1.0
                                                                            / 1000.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) attometer per square rontosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × femtometer per square yoctosecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareRontosecond = new (
                                                                            "attometer per square rontosecond"
                                                                          , "am/rs²"
                                                                          , FemtometerPerSquareYoctosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zeptometer per square yoctosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × attometer per square zeptosecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareYoctosecond = new (
                                                                             "zeptometer per square yoctosecond"
                                                                           , "zm/ys²"
                                                                           , AttometerPerSquareZeptosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yoctometer per square zeptosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zeptometer per square attosecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareZeptosecond = new (
                                                                             "yoctometer per square zeptosecond"
                                                                           , "ym/zs²"
                                                                           , ZeptometerPerSquareAttosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) rontometer per square attosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yoctometer per square femtosecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareAttosecond = new (
                                                                            "rontometer per square attosecond"
                                                                          , "rm/as²"
                                                                          , YoctometerPerSquareFemtosecond
                                                                          , 1.0
                                                                          / 1000.0
                                                                          / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) quectometer per square femtosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × rontometer per square picosecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareFemtosecond = new (
                                                                              "quectometer per square femtosecond"
                                                                            , "qm/fs²"
                                                                            , RontometerPerSquarePicosecond
                                                                            , 1.0
                                                                            / 1000.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) exameter per square second. Defined as: (1000.0)/((1.0)*(1.0)) × petameter per square second.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareSecond = new (
                                                                      "exameter per square second"
                                                                    , "Em/s²"
                                                                    , PetameterPerSquareSecond
                                                                    , 1000.0 / (1.0 * 1.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) petameter per square decisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × terameter per square second.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareDecisecond = new (
                                                                           "petameter per square decisecond"
                                                                         , "Pm/ds²"
                                                                         , TerameterPerSquareSecond
                                                                         , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square centisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × gigameter per square decisecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareCentisecond = new (
                                                                            "terameter per square centisecond"
                                                                          , "Tm/cs²"
                                                                          , GigameterPerSquareDecisecond
                                                                          , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) gigameter per square millisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × megameter per square centisecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareMillisecond = new (
                                                                            "gigameter per square millisecond"
                                                                          , "Gm/ms²"
                                                                          , MegameterPerSquareCentisecond
                                                                          , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) megameter per square microsecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × kilometer per square millisecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareMicrosecond = new (
                                                                            "megameter per square microsecond"
                                                                          , "Mm/μs²"
                                                                          , KilometerPerSquareMillisecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) kilometer per square nanosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × hectometer per square microsecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareNanosecond = new (
                                                                           "kilometer per square nanosecond"
                                                                         , "km/ns²"
                                                                         , HectometerPerSquareMicrosecond
                                                                         , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) hectometer per square picosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × dekameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquarePicosecond = new (
                                                                            "hectometer per square picosecond"
                                                                          , "hm/ps²"
                                                                          , DekameterPerSquareNanosecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) dekameter per square femtosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square picosecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareFemtosecond = new (
                                                                            "dekameter per square femtosecond"
                                                                          , "dam/fs²"
                                                                          , MeterPerSquarePicosecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) attometer per square quectosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × femtometer per square rontosecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareQuectosecond = new (
                                                                             "attometer per square quectosecond"
                                                                           , "am/qs²"
                                                                           , FemtometerPerSquareRontosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zeptometer per square rontosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × attometer per square yoctosecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareRontosecond = new (
                                                                             "zeptometer per square rontosecond"
                                                                           , "zm/rs²"
                                                                           , AttometerPerSquareYoctosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yoctometer per square yoctosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zeptometer per square zeptosecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareYoctosecond = new (
                                                                             "yoctometer per square yoctosecond"
                                                                           , "ym/ys²"
                                                                           , ZeptometerPerSquareZeptosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) rontometer per square zeptosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yoctometer per square attosecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareZeptosecond = new (
                                                                             "rontometer per square zeptosecond"
                                                                           , "rm/zs²"
                                                                           , YoctometerPerSquareAttosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quectometer per square attosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × rontometer per square femtosecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareAttosecond = new (
                                                                             "quectometer per square attosecond"
                                                                           , "qm/as²"
                                                                           , RontometerPerSquareFemtosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zettameter per square second. Defined as: (1000.0)/((1.0)*(1.0)) × exameter per square second.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareSecond = new (
                                                                        "zettameter per square second"
                                                                      , "Zm/s²"
                                                                      , ExameterPerSquareSecond
                                                                      , 1000.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) exameter per square decisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × petameter per square second.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareDecisecond = new (
                                                                          "exameter per square decisecond"
                                                                        , "Em/ds²"
                                                                        , PetameterPerSquareSecond
                                                                        , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) petameter per square centisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × terameter per square decisecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareCentisecond = new (
                                                                            "petameter per square centisecond"
                                                                          , "Pm/cs²"
                                                                          , TerameterPerSquareDecisecond
                                                                          , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square millisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × gigameter per square centisecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareMillisecond = new (
                                                                            "terameter per square millisecond"
                                                                          , "Tm/ms²"
                                                                          , GigameterPerSquareCentisecond
                                                                          , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) gigameter per square microsecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × megameter per square millisecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareMicrosecond = new (
                                                                            "gigameter per square microsecond"
                                                                          , "Gm/μs²"
                                                                          , MegameterPerSquareMillisecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) megameter per square nanosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × kilometer per square microsecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareNanosecond = new (
                                                                           "megameter per square nanosecond"
                                                                         , "Mm/ns²"
                                                                         , KilometerPerSquareMicrosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) kilometer per square picosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × hectometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquarePicosecond = new (
                                                                           "kilometer per square picosecond"
                                                                         , "km/ps²"
                                                                         , HectometerPerSquareNanosecond
                                                                         , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) hectometer per square femtosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × dekameter per square picosecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareFemtosecond = new (
                                                                             "hectometer per square femtosecond"
                                                                           , "hm/fs²"
                                                                           , DekameterPerSquarePicosecond
                                                                           , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) dekameter per square attosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square femtosecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareAttosecond = new (
                                                                           "dekameter per square attosecond"
                                                                         , "dam/as²"
                                                                         , MeterPerSquareFemtosecond
                                                                         , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) zeptometer per square quectosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × attometer per square rontosecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareQuectosecond = new (
                                                                              "zeptometer per square quectosecond"
                                                                            , "zm/qs²"
                                                                            , AttometerPerSquareRontosecond
                                                                            , 1.0
                                                                            / 1000.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) yoctometer per square rontosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zeptometer per square yoctosecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareRontosecond = new (
                                                                             "yoctometer per square rontosecond"
                                                                           , "ym/rs²"
                                                                           , ZeptometerPerSquareYoctosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) rontometer per square yoctosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yoctometer per square zeptosecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareYoctosecond = new (
                                                                             "rontometer per square yoctosecond"
                                                                           , "rm/ys²"
                                                                           , YoctometerPerSquareZeptosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quectometer per square zeptosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × rontometer per square attosecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareZeptosecond = new (
                                                                              "quectometer per square zeptosecond"
                                                                            , "qm/zs²"
                                                                            , RontometerPerSquareAttosecond
                                                                            , 1.0
                                                                            / 1000.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) yottameter per square second. Defined as: (1000.0)/((1.0)*(1.0)) × zettameter per square second.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareSecond = new (
                                                                        "yottameter per square second"
                                                                      , "Ym/s²"
                                                                      , ZettameterPerSquareSecond
                                                                      , 1000.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) zettameter per square decisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × exameter per square second.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareDecisecond = new (
                                                                            "zettameter per square decisecond"
                                                                          , "Zm/ds²"
                                                                          , ExameterPerSquareSecond
                                                                          , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) exameter per square centisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × petameter per square decisecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareCentisecond = new (
                                                                           "exameter per square centisecond"
                                                                         , "Em/cs²"
                                                                         , PetameterPerSquareDecisecond
                                                                         , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) petameter per square millisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × terameter per square centisecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareMillisecond = new (
                                                                            "petameter per square millisecond"
                                                                          , "Pm/ms²"
                                                                          , TerameterPerSquareCentisecond
                                                                          , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square microsecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × gigameter per square millisecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareMicrosecond = new (
                                                                            "terameter per square microsecond"
                                                                          , "Tm/μs²"
                                                                          , GigameterPerSquareMillisecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) gigameter per square nanosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × megameter per square microsecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareNanosecond = new (
                                                                           "gigameter per square nanosecond"
                                                                         , "Gm/ns²"
                                                                         , MegameterPerSquareMicrosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) megameter per square picosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × kilometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquarePicosecond = new (
                                                                           "megameter per square picosecond"
                                                                         , "Mm/ps²"
                                                                         , KilometerPerSquareNanosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) kilometer per square femtosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × hectometer per square picosecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareFemtosecond = new (
                                                                            "kilometer per square femtosecond"
                                                                          , "km/fs²"
                                                                          , HectometerPerSquarePicosecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) hectometer per square attosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × dekameter per square femtosecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareAttosecond = new (
                                                                            "hectometer per square attosecond"
                                                                          , "hm/as²"
                                                                          , DekameterPerSquareFemtosecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) dekameter per square zeptosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square attosecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareZeptosecond = new (
                                                                            "dekameter per square zeptosecond"
                                                                          , "dam/zs²"
                                                                          , MeterPerSquareAttosecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yoctometer per square quectosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zeptometer per square rontosecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareQuectosecond = new (
                                                                              "yoctometer per square quectosecond"
                                                                            , "ym/qs²"
                                                                            , ZeptometerPerSquareRontosecond
                                                                            , 1.0
                                                                            / 1000.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) rontometer per square rontosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yoctometer per square yoctosecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareRontosecond = new (
                                                                             "rontometer per square rontosecond"
                                                                           , "rm/rs²"
                                                                           , YoctometerPerSquareYoctosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quectometer per square yoctosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × rontometer per square zeptosecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareYoctosecond = new (
                                                                              "quectometer per square yoctosecond"
                                                                            , "qm/ys²"
                                                                            , RontometerPerSquareZeptosecond
                                                                            , 1.0
                                                                            / 1000.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) ronnameter per square second. Defined as: (1000.0)/((1.0)*(1.0)) × yottameter per square second.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareSecond = new (
                                                                        "ronnameter per square second"
                                                                      , "Rm/s²"
                                                                      , YottameterPerSquareSecond
                                                                      , 1000.0 / (1.0 * 1.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) yottameter per square decisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × zettameter per square second.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareDecisecond = new (
                                                                            "yottameter per square decisecond"
                                                                          , "Ym/ds²"
                                                                          , ZettameterPerSquareSecond
                                                                          , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zettameter per square centisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × exameter per square decisecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareCentisecond = new (
                                                                             "zettameter per square centisecond"
                                                                           , "Zm/cs²"
                                                                           , ExameterPerSquareDecisecond
                                                                           , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) exameter per square millisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × petameter per square centisecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareMillisecond = new (
                                                                           "exameter per square millisecond"
                                                                         , "Em/ms²"
                                                                         , PetameterPerSquareCentisecond
                                                                         , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) petameter per square microsecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × terameter per square millisecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareMicrosecond = new (
                                                                            "petameter per square microsecond"
                                                                          , "Pm/μs²"
                                                                          , TerameterPerSquareMillisecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square nanosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × gigameter per square microsecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareNanosecond = new (
                                                                           "terameter per square nanosecond"
                                                                         , "Tm/ns²"
                                                                         , GigameterPerSquareMicrosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) gigameter per square picosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × megameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquarePicosecond = new (
                                                                           "gigameter per square picosecond"
                                                                         , "Gm/ps²"
                                                                         , MegameterPerSquareNanosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) megameter per square femtosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × kilometer per square picosecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareFemtosecond = new (
                                                                            "megameter per square femtosecond"
                                                                          , "Mm/fs²"
                                                                          , KilometerPerSquarePicosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) kilometer per square attosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × hectometer per square femtosecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareAttosecond = new (
                                                                           "kilometer per square attosecond"
                                                                         , "km/as²"
                                                                         , HectometerPerSquareFemtosecond
                                                                         , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) hectometer per square zeptosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × dekameter per square attosecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareZeptosecond = new (
                                                                             "hectometer per square zeptosecond"
                                                                           , "hm/zs²"
                                                                           , DekameterPerSquareAttosecond
                                                                           , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) dekameter per square yoctosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareYoctosecond = new (
                                                                            "dekameter per square yoctosecond"
                                                                          , "dam/ys²"
                                                                          , MeterPerSquareZeptosecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) rontometer per square quectosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yoctometer per square rontosecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareQuectosecond = new (
                                                                              "rontometer per square quectosecond"
                                                                            , "rm/qs²"
                                                                            , YoctometerPerSquareRontosecond
                                                                            , 1.0
                                                                            / 1000.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) quectometer per square rontosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × rontometer per square yoctosecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareRontosecond = new (
                                                                              "quectometer per square rontosecond"
                                                                            , "qm/rs²"
                                                                            , RontometerPerSquareYoctosecond
                                                                            , 1.0
                                                                            / 1000.0
                                                                            / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) quettameter per square second. Defined as: (1000.0)/((1.0)*(1.0)) × ronnameter per square second.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareSecond = new (
                                                                         "quettameter per square second"
                                                                       , "Qm/s²"
                                                                       , RonnameterPerSquareSecond
                                                                       , 1000.0 / (1.0 * 1.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) ronnameter per square decisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × yottameter per square second.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareDecisecond = new (
                                                                            "ronnameter per square decisecond"
                                                                          , "Rm/ds²"
                                                                          , YottameterPerSquareSecond
                                                                          , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yottameter per square centisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × zettameter per square decisecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareCentisecond = new (
                                                                             "yottameter per square centisecond"
                                                                           , "Ym/cs²"
                                                                           , ZettameterPerSquareDecisecond
                                                                           , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zettameter per square millisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × exameter per square centisecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareMillisecond = new (
                                                                             "zettameter per square millisecond"
                                                                           , "Zm/ms²"
                                                                           , ExameterPerSquareCentisecond
                                                                           , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) exameter per square microsecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × petameter per square millisecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareMicrosecond = new (
                                                                           "exameter per square microsecond"
                                                                         , "Em/μs²"
                                                                         , PetameterPerSquareMillisecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) petameter per square nanosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × terameter per square microsecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareNanosecond = new (
                                                                           "petameter per square nanosecond"
                                                                         , "Pm/ns²"
                                                                         , TerameterPerSquareMicrosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square picosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × gigameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquarePicosecond = new (
                                                                           "terameter per square picosecond"
                                                                         , "Tm/ps²"
                                                                         , GigameterPerSquareNanosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) gigameter per square femtosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × megameter per square picosecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareFemtosecond = new (
                                                                            "gigameter per square femtosecond"
                                                                          , "Gm/fs²"
                                                                          , MegameterPerSquarePicosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) megameter per square attosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × kilometer per square femtosecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareAttosecond = new (
                                                                           "megameter per square attosecond"
                                                                         , "Mm/as²"
                                                                         , KilometerPerSquareFemtosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) kilometer per square zeptosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × hectometer per square attosecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareZeptosecond = new (
                                                                            "kilometer per square zeptosecond"
                                                                          , "km/zs²"
                                                                          , HectometerPerSquareAttosecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) hectometer per square yoctosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × dekameter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareYoctosecond = new (
                                                                             "hectometer per square yoctosecond"
                                                                           , "hm/ys²"
                                                                           , DekameterPerSquareZeptosecond
                                                                           , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) dekameter per square rontosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareRontosecond = new (
                                                                            "dekameter per square rontosecond"
                                                                          , "dam/rs²"
                                                                          , MeterPerSquareYoctosecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) quectometer per square quectosecond. Defined as: (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)) × rontometer per square rontosecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareQuectosecond = new (
                                                                               "quectometer per square quectosecond"
                                                                             , "qm/qs²"
                                                                             , RontometerPerSquareRontosecond
                                                                             , 1.0
                                                                             / 1000.0
                                                                             / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) quettameter per square decisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × ronnameter per square second.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareDecisecond = new (
                                                                             "quettameter per square decisecond"
                                                                           , "Qm/ds²"
                                                                           , RonnameterPerSquareSecond
                                                                           , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) ronnameter per square centisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × yottameter per square decisecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareCentisecond = new (
                                                                             "ronnameter per square centisecond"
                                                                           , "Rm/cs²"
                                                                           , YottameterPerSquareDecisecond
                                                                           , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yottameter per square millisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × zettameter per square centisecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareMillisecond = new (
                                                                             "yottameter per square millisecond"
                                                                           , "Ym/ms²"
                                                                           , ZettameterPerSquareCentisecond
                                                                           , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zettameter per square microsecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × exameter per square millisecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareMicrosecond = new (
                                                                             "zettameter per square microsecond"
                                                                           , "Zm/μs²"
                                                                           , ExameterPerSquareMillisecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) exameter per square nanosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × petameter per square microsecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareNanosecond = new (
                                                                          "exameter per square nanosecond"
                                                                        , "Em/ns²"
                                                                        , PetameterPerSquareMicrosecond
                                                                        , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) petameter per square picosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × terameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquarePicosecond = new (
                                                                           "petameter per square picosecond"
                                                                         , "Pm/ps²"
                                                                         , TerameterPerSquareNanosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square femtosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × gigameter per square picosecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareFemtosecond = new (
                                                                            "terameter per square femtosecond"
                                                                          , "Tm/fs²"
                                                                          , GigameterPerSquarePicosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) gigameter per square attosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × megameter per square femtosecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareAttosecond = new (
                                                                           "gigameter per square attosecond"
                                                                         , "Gm/as²"
                                                                         , MegameterPerSquareFemtosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) megameter per square zeptosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × kilometer per square attosecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareZeptosecond = new (
                                                                            "megameter per square zeptosecond"
                                                                          , "Mm/zs²"
                                                                          , KilometerPerSquareAttosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) kilometer per square yoctosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × hectometer per square zeptosecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareYoctosecond = new (
                                                                            "kilometer per square yoctosecond"
                                                                          , "km/ys²"
                                                                          , HectometerPerSquareZeptosecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) hectometer per square rontosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × dekameter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareRontosecond = new (
                                                                             "hectometer per square rontosecond"
                                                                           , "hm/rs²"
                                                                           , DekameterPerSquareYoctosecond
                                                                           , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) dekameter per square quectosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × meter per square rontosecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareQuectosecond = new (
                                                                             "dekameter per square quectosecond"
                                                                           , "dam/qs²"
                                                                           , MeterPerSquareRontosecond
                                                                           , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quettameter per square centisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × ronnameter per square decisecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareCentisecond = new (
                                                                              "quettameter per square centisecond"
                                                                            , "Qm/cs²"
                                                                            , RonnameterPerSquareDecisecond
                                                                            , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) ronnameter per square millisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × yottameter per square centisecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareMillisecond = new (
                                                                             "ronnameter per square millisecond"
                                                                           , "Rm/ms²"
                                                                           , YottameterPerSquareCentisecond
                                                                           , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yottameter per square microsecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zettameter per square millisecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareMicrosecond = new (
                                                                             "yottameter per square microsecond"
                                                                           , "Ym/μs²"
                                                                           , ZettameterPerSquareMillisecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zettameter per square nanosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × exameter per square microsecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareNanosecond = new (
                                                                            "zettameter per square nanosecond"
                                                                          , "Zm/ns²"
                                                                          , ExameterPerSquareMicrosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) exameter per square picosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × petameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquarePicosecond = new (
                                                                          "exameter per square picosecond"
                                                                        , "Em/ps²"
                                                                        , PetameterPerSquareNanosecond
                                                                        , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) petameter per square femtosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × terameter per square picosecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareFemtosecond = new (
                                                                            "petameter per square femtosecond"
                                                                          , "Pm/fs²"
                                                                          , TerameterPerSquarePicosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square attosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × gigameter per square femtosecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareAttosecond = new (
                                                                           "terameter per square attosecond"
                                                                         , "Tm/as²"
                                                                         , GigameterPerSquareFemtosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) gigameter per square zeptosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × megameter per square attosecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareZeptosecond = new (
                                                                            "gigameter per square zeptosecond"
                                                                          , "Gm/zs²"
                                                                          , MegameterPerSquareAttosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) megameter per square yoctosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × kilometer per square zeptosecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareYoctosecond = new (
                                                                            "megameter per square yoctosecond"
                                                                          , "Mm/ys²"
                                                                          , KilometerPerSquareZeptosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) kilometer per square rontosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × hectometer per square yoctosecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareRontosecond = new (
                                                                            "kilometer per square rontosecond"
                                                                          , "km/rs²"
                                                                          , HectometerPerSquareYoctosecond
                                                                          , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) hectometer per square quectosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × dekameter per square rontosecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareQuectosecond = new (
                                                                              "hectometer per square quectosecond"
                                                                            , "hm/qs²"
                                                                            , DekameterPerSquareRontosecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) quettameter per square millisecond. Defined as: (1000.0)/((1.0/10.0)*(1.0/10.0)) × ronnameter per square centisecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareMillisecond = new (
                                                                              "quettameter per square millisecond"
                                                                            , "Qm/ms²"
                                                                            , RonnameterPerSquareCentisecond
                                                                            , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) ronnameter per square microsecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yottameter per square millisecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareMicrosecond = new (
                                                                             "ronnameter per square microsecond"
                                                                           , "Rm/μs²"
                                                                           , YottameterPerSquareMillisecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yottameter per square nanosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zettameter per square microsecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareNanosecond = new (
                                                                            "yottameter per square nanosecond"
                                                                          , "Ym/ns²"
                                                                          , ZettameterPerSquareMicrosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zettameter per square picosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × exameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquarePicosecond = new (
                                                                            "zettameter per square picosecond"
                                                                          , "Zm/ps²"
                                                                          , ExameterPerSquareNanosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) exameter per square femtosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × petameter per square picosecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareFemtosecond = new (
                                                                           "exameter per square femtosecond"
                                                                         , "Em/fs²"
                                                                         , PetameterPerSquarePicosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) petameter per square attosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × terameter per square femtosecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareAttosecond = new (
                                                                           "petameter per square attosecond"
                                                                         , "Pm/as²"
                                                                         , TerameterPerSquareFemtosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square zeptosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × gigameter per square attosecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareZeptosecond = new (
                                                                            "terameter per square zeptosecond"
                                                                          , "Tm/zs²"
                                                                          , GigameterPerSquareAttosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) gigameter per square yoctosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × megameter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareYoctosecond = new (
                                                                            "gigameter per square yoctosecond"
                                                                          , "Gm/ys²"
                                                                          , MegameterPerSquareZeptosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) megameter per square rontosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × kilometer per square yoctosecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareRontosecond = new (
                                                                            "megameter per square rontosecond"
                                                                          , "Mm/rs²"
                                                                          , KilometerPerSquareYoctosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) kilometer per square quectosecond. Defined as: (10.0)/((1.0/1000.0)*(1.0/1000.0)) × hectometer per square rontosecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareQuectosecond = new (
                                                                             "kilometer per square quectosecond"
                                                                           , "km/qs²"
                                                                           , HectometerPerSquareRontosecond
                                                                           , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quettameter per square microsecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × ronnameter per square millisecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareMicrosecond = new (
                                                                              "quettameter per square microsecond"
                                                                            , "Qm/μs²"
                                                                            , RonnameterPerSquareMillisecond
                                                                            , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) ronnameter per square nanosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yottameter per square microsecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareNanosecond = new (
                                                                            "ronnameter per square nanosecond"
                                                                          , "Rm/ns²"
                                                                          , YottameterPerSquareMicrosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yottameter per square picosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zettameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquarePicosecond = new (
                                                                            "yottameter per square picosecond"
                                                                          , "Ym/ps²"
                                                                          , ZettameterPerSquareNanosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zettameter per square femtosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × exameter per square picosecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareFemtosecond = new (
                                                                             "zettameter per square femtosecond"
                                                                           , "Zm/fs²"
                                                                           , ExameterPerSquarePicosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) exameter per square attosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × petameter per square femtosecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareAttosecond = new (
                                                                          "exameter per square attosecond"
                                                                        , "Em/as²"
                                                                        , PetameterPerSquareFemtosecond
                                                                        , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) petameter per square zeptosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × terameter per square attosecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareZeptosecond = new (
                                                                            "petameter per square zeptosecond"
                                                                          , "Pm/zs²"
                                                                          , TerameterPerSquareAttosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square yoctosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × gigameter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareYoctosecond = new (
                                                                            "terameter per square yoctosecond"
                                                                          , "Tm/ys²"
                                                                          , GigameterPerSquareZeptosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) gigameter per square rontosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × megameter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareRontosecond = new (
                                                                            "gigameter per square rontosecond"
                                                                          , "Gm/rs²"
                                                                          , MegameterPerSquareYoctosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) megameter per square quectosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × kilometer per square rontosecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareQuectosecond = new (
                                                                             "megameter per square quectosecond"
                                                                           , "Mm/qs²"
                                                                           , KilometerPerSquareRontosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quettameter per square nanosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × ronnameter per square microsecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareNanosecond = new (
                                                                             "quettameter per square nanosecond"
                                                                           , "Qm/ns²"
                                                                           , RonnameterPerSquareMicrosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) ronnameter per square picosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yottameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquarePicosecond = new (
                                                                            "ronnameter per square picosecond"
                                                                          , "Rm/ps²"
                                                                          , YottameterPerSquareNanosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yottameter per square femtosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zettameter per square picosecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareFemtosecond = new (
                                                                             "yottameter per square femtosecond"
                                                                           , "Ym/fs²"
                                                                           , ZettameterPerSquarePicosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zettameter per square attosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × exameter per square femtosecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareAttosecond = new (
                                                                            "zettameter per square attosecond"
                                                                          , "Zm/as²"
                                                                          , ExameterPerSquareFemtosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) exameter per square zeptosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × petameter per square attosecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareZeptosecond = new (
                                                                           "exameter per square zeptosecond"
                                                                         , "Em/zs²"
                                                                         , PetameterPerSquareAttosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) petameter per square yoctosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × terameter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareYoctosecond = new (
                                                                            "petameter per square yoctosecond"
                                                                          , "Pm/ys²"
                                                                          , TerameterPerSquareZeptosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square rontosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × gigameter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareRontosecond = new (
                                                                            "terameter per square rontosecond"
                                                                          , "Tm/rs²"
                                                                          , GigameterPerSquareYoctosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) gigameter per square quectosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × megameter per square rontosecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareQuectosecond = new (
                                                                             "gigameter per square quectosecond"
                                                                           , "Gm/qs²"
                                                                           , MegameterPerSquareRontosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quettameter per square picosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × ronnameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquarePicosecond = new (
                                                                             "quettameter per square picosecond"
                                                                           , "Qm/ps²"
                                                                           , RonnameterPerSquareNanosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) ronnameter per square femtosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yottameter per square picosecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareFemtosecond = new (
                                                                             "ronnameter per square femtosecond"
                                                                           , "Rm/fs²"
                                                                           , YottameterPerSquarePicosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yottameter per square attosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zettameter per square femtosecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareAttosecond = new (
                                                                            "yottameter per square attosecond"
                                                                          , "Ym/as²"
                                                                          , ZettameterPerSquareFemtosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zettameter per square zeptosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × exameter per square attosecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareZeptosecond = new (
                                                                             "zettameter per square zeptosecond"
                                                                           , "Zm/zs²"
                                                                           , ExameterPerSquareAttosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) exameter per square yoctosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × petameter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareYoctosecond = new (
                                                                           "exameter per square yoctosecond"
                                                                         , "Em/ys²"
                                                                         , PetameterPerSquareZeptosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) petameter per square rontosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × terameter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareRontosecond = new (
                                                                            "petameter per square rontosecond"
                                                                          , "Pm/rs²"
                                                                          , TerameterPerSquareYoctosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square quectosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × gigameter per square rontosecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareQuectosecond = new (
                                                                             "terameter per square quectosecond"
                                                                           , "Tm/qs²"
                                                                           , GigameterPerSquareRontosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quettameter per square femtosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × ronnameter per square picosecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareFemtosecond = new (
                                                                              "quettameter per square femtosecond"
                                                                            , "Qm/fs²"
                                                                            , RonnameterPerSquarePicosecond
                                                                            , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) ronnameter per square attosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yottameter per square femtosecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareAttosecond = new (
                                                                            "ronnameter per square attosecond"
                                                                          , "Rm/as²"
                                                                          , YottameterPerSquareFemtosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yottameter per square zeptosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zettameter per square attosecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareZeptosecond = new (
                                                                             "yottameter per square zeptosecond"
                                                                           , "Ym/zs²"
                                                                           , ZettameterPerSquareAttosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zettameter per square yoctosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × exameter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareYoctosecond = new (
                                                                             "zettameter per square yoctosecond"
                                                                           , "Zm/ys²"
                                                                           , ExameterPerSquareZeptosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) exameter per square rontosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × petameter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareRontosecond = new (
                                                                           "exameter per square rontosecond"
                                                                         , "Em/rs²"
                                                                         , PetameterPerSquareYoctosecond
                                                                         , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) petameter per square quectosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × terameter per square rontosecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareQuectosecond = new (
                                                                             "petameter per square quectosecond"
                                                                           , "Pm/qs²"
                                                                           , TerameterPerSquareRontosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quettameter per square attosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × ronnameter per square femtosecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareAttosecond = new (
                                                                             "quettameter per square attosecond"
                                                                           , "Qm/as²"
                                                                           , RonnameterPerSquareFemtosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) ronnameter per square zeptosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yottameter per square attosecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareZeptosecond = new (
                                                                             "ronnameter per square zeptosecond"
                                                                           , "Rm/zs²"
                                                                           , YottameterPerSquareAttosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yottameter per square yoctosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zettameter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareYoctosecond = new (
                                                                             "yottameter per square yoctosecond"
                                                                           , "Ym/ys²"
                                                                           , ZettameterPerSquareZeptosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zettameter per square rontosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × exameter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareRontosecond = new (
                                                                             "zettameter per square rontosecond"
                                                                           , "Zm/rs²"
                                                                           , ExameterPerSquareYoctosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) exameter per square quectosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × petameter per square rontosecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareQuectosecond = new (
                                                                            "exameter per square quectosecond"
                                                                          , "Em/qs²"
                                                                          , PetameterPerSquareRontosecond
                                                                          , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) quettameter per square zeptosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × ronnameter per square attosecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareZeptosecond = new (
                                                                              "quettameter per square zeptosecond"
                                                                            , "Qm/zs²"
                                                                            , RonnameterPerSquareAttosecond
                                                                            , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) ronnameter per square yoctosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yottameter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareYoctosecond = new (
                                                                             "ronnameter per square yoctosecond"
                                                                           , "Rm/ys²"
                                                                           , YottameterPerSquareZeptosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yottameter per square rontosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zettameter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareRontosecond = new (
                                                                             "yottameter per square rontosecond"
                                                                           , "Ym/rs²"
                                                                           , ZettameterPerSquareYoctosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zettameter per square quectosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × exameter per square rontosecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareQuectosecond = new (
                                                                              "zettameter per square quectosecond"
                                                                            , "Zm/qs²"
                                                                            , ExameterPerSquareRontosecond
                                                                            , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) quettameter per square yoctosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × ronnameter per square zeptosecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareYoctosecond = new (
                                                                              "quettameter per square yoctosecond"
                                                                            , "Qm/ys²"
                                                                            , RonnameterPerSquareZeptosecond
                                                                            , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) ronnameter per square rontosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yottameter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareRontosecond = new (
                                                                             "ronnameter per square rontosecond"
                                                                           , "Rm/rs²"
                                                                           , YottameterPerSquareYoctosecond
                                                                           , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yottameter per square quectosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × zettameter per square rontosecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareQuectosecond = new (
                                                                              "yottameter per square quectosecond"
                                                                            , "Ym/qs²"
                                                                            , ZettameterPerSquareRontosecond
                                                                            , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) quettameter per square rontosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × ronnameter per square yoctosecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareRontosecond = new (
                                                                              "quettameter per square rontosecond"
                                                                            , "Qm/rs²"
                                                                            , RonnameterPerSquareYoctosecond
                                                                            , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) ronnameter per square quectosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × yottameter per square rontosecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareQuectosecond = new (
                                                                              "ronnameter per square quectosecond"
                                                                            , "Rm/qs²"
                                                                            , YottameterPerSquareRontosecond
                                                                            , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) quettameter per square quectosecond. Defined as: (1000.0)/((1.0/1000.0)*(1.0/1000.0)) × ronnameter per square rontosecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareQuectosecond = new (
                                                                               "quettameter per square quectosecond"
                                                                             , "Qm/qs²"
                                                                             , RonnameterPerSquareRontosecond
                                                                             , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) meter per square minute. Defined as: (1.0)/((60.0)*(60.0)) × meter per square second.
   /// </summary>
   public static readonly Acceleration MeterPerSquareMinute =
            new ("meter per square minute", "m/min²", MeterPerSquareSecond, 1.0 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) meter per square hour. Defined as: (1.0)/((60.0)*(60.0)) × meter per square minute.
   /// </summary>
   public static readonly Acceleration MeterPerSquareHour =
            new ("meter per square hour", "m/hr²", MeterPerSquareMinute, 1.0 / (60.0 * 60.0), 0);

   /// <summary>
   /// A(n) decimeter per square minute. Defined as: (1.0/10.0)/((60.0)*(60.0)) × meter per square second.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareMinute = new (
                                                                       "decimeter per square minute"
                                                                     , "dm/min²"
                                                                     , MeterPerSquareSecond
                                                                     , 1.0 / 10.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square day. Defined as: (1.0)/((24.0)*(24.0)) × meter per square hour.
   /// </summary>
   public static readonly Acceleration MeterPerSquareDay = new (
                                                                "meter per square day"
                                                              , "m/dy²"
                                                              , MeterPerSquareHour
                                                              , 1.0 / (24.0 * 24.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) centimeter per square minute. Defined as: (1.0/10.0)/((60.0)*(60.0)) × decimeter per square second.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareMinute = new (
                                                                        "centimeter per square minute"
                                                                      , "cm/min²"
                                                                      , DecimeterPerSquareSecond
                                                                      , 1.0 / 10.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square week. Defined as: (1.0)/((7.0)*(7.0)) × meter per square day.
   /// </summary>
   public static readonly Acceleration MeterPerSquareWeek =
            new ("meter per square week", "m/wk²", MeterPerSquareDay, 1.0 / (7.0 * 7.0), 0);

   /// <summary>
   /// A(n) decimeter per square hour. Defined as: (1.0/10.0)/((60.0)*(60.0)) × meter per square minute.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareHour = new (
                                                                     "decimeter per square hour"
                                                                   , "dm/hr²"
                                                                   , MeterPerSquareMinute
                                                                   , 1.0 / 10.0 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) millimeter per square minute. Defined as: (1.0/10.0)/((60.0)*(60.0)) × centimeter per square second.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareMinute = new (
                                                                        "millimeter per square minute"
                                                                      , "mm/min²"
                                                                      , CentimeterPerSquareSecond
                                                                      , 1.0 / 10.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square year. Defined as: (1.0)/((365.2525)*(365.2525)) × meter per square day.
   /// </summary>
   public static readonly Acceleration MeterPerSquareYear = new (
                                                                 "meter per square year"
                                                               , "m/yr²"
                                                               , MeterPerSquareDay
                                                               , 1.0 / (365.2525 * 365.2525)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) micrometer per square minute. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × millimeter per square second.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareMinute = new (
                                                                        "micrometer per square minute"
                                                                      , "μm/min²"
                                                                      , MillimeterPerSquareSecond
                                                                      , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square decade. Defined as: (1.0)/((10.0)*(10.0)) × meter per square year.
   /// </summary>
   public static readonly Acceleration MeterPerSquareDecade = new (
                                                                   "meter per square decade"
                                                                 , "m/decade²"
                                                                 , MeterPerSquareYear
                                                                 , 1.0 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) decimeter per square day. Defined as: (1.0/10.0)/((24.0)*(24.0)) × meter per square hour.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareDay = new (
                                                                    "decimeter per square day"
                                                                  , "dm/dy²"
                                                                  , MeterPerSquareHour
                                                                  , 1.0 / 10.0 / (24.0 * 24.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centimeter per square hour. Defined as: (1.0/10.0)/((60.0)*(60.0)) × decimeter per square minute.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareHour = new (
                                                                      "centimeter per square hour"
                                                                    , "cm/hr²"
                                                                    , DecimeterPerSquareMinute
                                                                    , 1.0 / 10.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) nanometer per square minute. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × micrometer per square second.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareMinute = new (
                                                                       "nanometer per square minute"
                                                                     , "nm/min²"
                                                                     , MicrometerPerSquareSecond
                                                                     , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square century. Defined as: (1.0)/((10.0)*(10.0)) × meter per square decade.
   /// </summary>
   public static readonly Acceleration MeterPerSquareCentury = new (
                                                                    "meter per square century"
                                                                  , "m/century²"
                                                                  , MeterPerSquareDecade
                                                                  , 1.0 / (10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picometer per square minute. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × nanometer per square second.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareMinute = new (
                                                                       "picometer per square minute"
                                                                     , "pm/min²"
                                                                     , NanometerPerSquareSecond
                                                                     , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square millennium. Defined as: (1.0)/((10.0)*(10.0)) × meter per square century.
   /// </summary>
   public static readonly Acceleration MeterPerSquareMillennium = new (
                                                                       "meter per square millennium"
                                                                     , "m/kyr²"
                                                                     , MeterPerSquareCentury
                                                                     , 1.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) decimeter per square week. Defined as: (1.0/10.0)/((7.0)*(7.0)) × meter per square day.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareWeek = new (
                                                                     "decimeter per square week"
                                                                   , "dm/wk²"
                                                                   , MeterPerSquareDay
                                                                   , 1.0 / 10.0 / (7.0 * 7.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) millimeter per square hour. Defined as: (1.0/10.0)/((60.0)*(60.0)) × centimeter per square minute.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareHour = new (
                                                                      "millimeter per square hour"
                                                                    , "mm/hr²"
                                                                    , CentimeterPerSquareMinute
                                                                    , 1.0 / 10.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) femtometer per square minute. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × picometer per square second.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareMinute = new (
                                                                        "femtometer per square minute"
                                                                      , "fm/min²"
                                                                      , PicometerPerSquareSecond
                                                                      , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square million years. Defined as: (1.0)/((1000.0)*(1000.0)) × meter per square millennium.
   /// </summary>
   public static readonly Acceleration MeterPerSquareMillionYears = new (
                                                                         "meter per square million years"
                                                                       , "m/Myr²"
                                                                       , MeterPerSquareMillennium
                                                                       , 1.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) centimeter per square day. Defined as: (1.0/10.0)/((24.0)*(24.0)) × decimeter per square hour.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareDay = new (
                                                                     "centimeter per square day"
                                                                   , "cm/dy²"
                                                                   , DecimeterPerSquareHour
                                                                   , 1.0 / 10.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attometer per square minute. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × femtometer per square second.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareMinute = new (
                                                                       "attometer per square minute"
                                                                     , "am/min²"
                                                                     , FemtometerPerSquareSecond
                                                                     , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square billion years. Defined as: (1.0)/((1000.0)*(1000.0)) × meter per square million years.
   /// </summary>
   public static readonly Acceleration MeterPerSquareBillionYears = new (
                                                                         "meter per square billion years"
                                                                       , "m/Gyr²"
                                                                       , MeterPerSquareMillionYears
                                                                       , 1.0 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) decimeter per square year. Defined as: (1.0/10.0)/((365.2525)*(365.2525)) × meter per square day.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareYear = new (
                                                                     "decimeter per square year"
                                                                   , "dm/yr²"
                                                                   , MeterPerSquareDay
                                                                   , 1.0 / 10.0 / (365.2525 * 365.2525)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) micrometer per square hour. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × millimeter per square minute.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareHour = new (
                                                                      "micrometer per square hour"
                                                                    , "μm/hr²"
                                                                    , MillimeterPerSquareMinute
                                                                    , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) zeptometer per square minute. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × attometer per square second.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareMinute = new (
                                                                        "zeptometer per square minute"
                                                                      , "zm/min²"
                                                                      , AttometerPerSquareSecond
                                                                      , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square trillion years. Defined as: (1.0)/((1000.0)*(1000.0)) × meter per square billion years.
   /// </summary>
   public static readonly Acceleration MeterPerSquareTrillionYears = new (
                                                                          "meter per square trillion years"
                                                                        , "m/Tyr²"
                                                                        , MeterPerSquareBillionYears
                                                                        , 1.0 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) yoctometer per square minute. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × zeptometer per square second.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareMinute = new (
                                                                        "yoctometer per square minute"
                                                                      , "ym/min²"
                                                                      , ZeptometerPerSquareSecond
                                                                      , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square quadrillion years. Defined as: (1.0)/((1000.0)*(1000.0)) × meter per square trillion years.
   /// </summary>
   public static readonly Acceleration MeterPerSquareQuadrillionYears = new (
                                                                             "meter per square quadrillion years"
                                                                           , "m/Pyr²"
                                                                           , MeterPerSquareTrillionYears
                                                                           , 1.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) decimeter per square decade. Defined as: (1.0/10.0)/((10.0)*(10.0)) × meter per square year.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareDecade = new (
                                                                       "decimeter per square decade"
                                                                     , "dm/decade²"
                                                                     , MeterPerSquareYear
                                                                     , 1.0 / 10.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) centimeter per square week. Defined as: (1.0/10.0)/((7.0)*(7.0)) × decimeter per square day.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareWeek = new (
                                                                      "centimeter per square week"
                                                                    , "cm/wk²"
                                                                    , DecimeterPerSquareDay
                                                                    , 1.0 / 10.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) millimeter per square day. Defined as: (1.0/10.0)/((24.0)*(24.0)) × centimeter per square hour.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareDay = new (
                                                                     "millimeter per square day"
                                                                   , "mm/dy²"
                                                                   , CentimeterPerSquareHour
                                                                   , 1.0 / 10.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanometer per square hour. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × micrometer per square minute.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareHour = new (
                                                                     "nanometer per square hour"
                                                                   , "nm/hr²"
                                                                   , MicrometerPerSquareMinute
                                                                   , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontometer per square minute. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × yoctometer per square second.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareMinute = new (
                                                                        "rontometer per square minute"
                                                                      , "rm/min²"
                                                                      , YoctometerPerSquareSecond
                                                                      , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square quintillion years. Defined as: (1.0)/((1000.0)*(1000.0)) × meter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration MeterPerSquareQuintillionYears = new (
                                                                             "meter per square quintillion years"
                                                                           , "m/Eyr²"
                                                                           , MeterPerSquareQuadrillionYears
                                                                           , 1.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quectometer per square minute. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × rontometer per square second.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareMinute = new (
                                                                         "quectometer per square minute"
                                                                       , "qm/min²"
                                                                       , RontometerPerSquareSecond
                                                                       , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) meter per square sextillion years. Defined as: (1.0)/((1000.0)*(1000.0)) × meter per square quintillion years.
   /// </summary>
   public static readonly Acceleration MeterPerSquareSextillionYears = new (
                                                                            "meter per square sextillion years"
                                                                          , "m/Zyr²"
                                                                          , MeterPerSquareQuintillionYears
                                                                          , 1.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) decimeter per square century. Defined as: (1.0/10.0)/((10.0)*(10.0)) × meter per square decade.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareCentury = new (
                                                                        "decimeter per square century"
                                                                      , "dm/century²"
                                                                      , MeterPerSquareDecade
                                                                      , 1.0 / 10.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) picometer per square hour. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × nanometer per square minute.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareHour = new (
                                                                     "picometer per square hour"
                                                                   , "pm/hr²"
                                                                   , NanometerPerSquareMinute
                                                                   , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekameter per square minute. Defined as: (10.0)/((60.0)*(60.0)) × meter per square second.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareMinute = new (
                                                                       "dekameter per square minute"
                                                                     , "dam/min²"
                                                                     , MeterPerSquareSecond
                                                                     , 10.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square septillion years. Defined as: (1.0)/((1000.0)*(1000.0)) × meter per square sextillion years.
   /// </summary>
   public static readonly Acceleration MeterPerSquareSeptillionYears = new (
                                                                            "meter per square septillion years"
                                                                          , "m/Yyr²"
                                                                          , MeterPerSquareSextillionYears
                                                                          , 1.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) centimeter per square year. Defined as: (1.0/10.0)/((365.2525)*(365.2525)) × decimeter per square day.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareYear = new (
                                                                      "centimeter per square year"
                                                                    , "cm/yr²"
                                                                    , DecimeterPerSquareDay
                                                                    , 1.0 / 10.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) micrometer per square day. Defined as: (1.0/1000.0)/((24.0)*(24.0)) × millimeter per square hour.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareDay = new (
                                                                     "micrometer per square day"
                                                                   , "μm/dy²"
                                                                   , MillimeterPerSquareHour
                                                                   , 1.0 / 1000.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) hectometer per square minute. Defined as: (10.0)/((60.0)*(60.0)) × dekameter per square second.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareMinute = new (
                                                                        "hectometer per square minute"
                                                                      , "hm/min²"
                                                                      , DekameterPerSquareSecond
                                                                      , 10.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square octillion years. Defined as: (1.0)/((1000.0)*(1000.0)) × meter per square septillion years.
   /// </summary>
   public static readonly Acceleration MeterPerSquareOctillionYears = new (
                                                                           "meter per square octillion years"
                                                                         , "m/Ryr²"
                                                                         , MeterPerSquareSeptillionYears
                                                                         , 1.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) decimeter per square millennium. Defined as: (1.0/10.0)/((10.0)*(10.0)) × meter per square century.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareMillennium = new (
                                                                           "decimeter per square millennium"
                                                                         , "dm/kyr²"
                                                                         , MeterPerSquareCentury
                                                                         , 1.0 / 10.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) millimeter per square week. Defined as: (1.0/10.0)/((7.0)*(7.0)) × centimeter per square day.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareWeek = new (
                                                                      "millimeter per square week"
                                                                    , "mm/wk²"
                                                                    , CentimeterPerSquareDay
                                                                    , 1.0 / 10.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) femtometer per square hour. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × picometer per square minute.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareHour = new (
                                                                      "femtometer per square hour"
                                                                    , "fm/hr²"
                                                                    , PicometerPerSquareMinute
                                                                    , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) kilometer per square minute. Defined as: (10.0)/((60.0)*(60.0)) × hectometer per square second.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareMinute = new (
                                                                       "kilometer per square minute"
                                                                     , "km/min²"
                                                                     , HectometerPerSquareSecond
                                                                     , 10.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square nonillion years. Defined as: (1.0)/((1000.0)*(1000.0)) × meter per square octillion years.
   /// </summary>
   public static readonly Acceleration MeterPerSquareNonillionYears = new (
                                                                           "meter per square nonillion years"
                                                                         , "m/Qyr²"
                                                                         , MeterPerSquareOctillionYears
                                                                         , 1.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) megameter per square minute. Defined as: (1000.0)/((60.0)*(60.0)) × kilometer per square second.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareMinute = new (
                                                                       "megameter per square minute"
                                                                     , "Mm/min²"
                                                                     , KilometerPerSquareSecond
                                                                     , 1000.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square decillion years. Defined as: (1.0)/((1000.0)*(1000.0)) × meter per square nonillion years.
   /// </summary>
   public static readonly Acceleration MeterPerSquareDecillionYears = new (
                                                                           "meter per square decillion years"
                                                                         , "m/decillion yr²"
                                                                         , MeterPerSquareNonillionYears
                                                                         , 1.0 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) decimeter per square million years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × meter per square millennium.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareMillionYears = new (
                                                                             "decimeter per square million years"
                                                                           , "dm/Myr²"
                                                                           , MeterPerSquareMillennium
                                                                           , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) centimeter per square decade. Defined as: (1.0/10.0)/((10.0)*(10.0)) × decimeter per square year.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareDecade = new (
                                                                        "centimeter per square decade"
                                                                      , "cm/decade²"
                                                                      , DecimeterPerSquareYear
                                                                      , 1.0 / 10.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) nanometer per square day. Defined as: (1.0/1000.0)/((24.0)*(24.0)) × micrometer per square hour.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareDay = new (
                                                                    "nanometer per square day"
                                                                  , "nm/dy²"
                                                                  , MicrometerPerSquareHour
                                                                  , 1.0 / 1000.0 / (24.0 * 24.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attometer per square hour. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × femtometer per square minute.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareHour = new (
                                                                     "attometer per square hour"
                                                                   , "am/hr²"
                                                                   , FemtometerPerSquareMinute
                                                                   , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) gigameter per square minute. Defined as: (1000.0)/((60.0)*(60.0)) × megameter per square second.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareMinute = new (
                                                                       "gigameter per square minute"
                                                                     , "Gm/min²"
                                                                     , MegameterPerSquareSecond
                                                                     , 1000.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) meter per square planck-time. Defined as: (1.0)/((5.391247E-38)*(5.391247E-38)) × meter per square microsecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquarePlanckTime = new (
                                                                       "meter per square planck-time"
                                                                     , "m/tₚ²"
                                                                     , MeterPerSquareMicrosecond
                                                                     , 1.0 / (5.391247E-38 * 5.391247E-38)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) terameter per square minute. Defined as: (1000.0)/((60.0)*(60.0)) × gigameter per square second.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareMinute = new (
                                                                       "terameter per square minute"
                                                                     , "Tm/min²"
                                                                     , GigameterPerSquareSecond
                                                                     , 1000.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) decimeter per square billion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × meter per square million years.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareBillionYears = new (
                                                                             "decimeter per square billion years"
                                                                           , "dm/Gyr²"
                                                                           , MeterPerSquareMillionYears
                                                                           , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) millimeter per square year. Defined as: (1.0/10.0)/((365.2525)*(365.2525)) × centimeter per square day.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareYear = new (
                                                                      "millimeter per square year"
                                                                    , "mm/yr²"
                                                                    , CentimeterPerSquareDay
                                                                    , 1.0 / 10.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) micrometer per square week. Defined as: (1.0/1000.0)/((7.0)*(7.0)) × millimeter per square day.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareWeek = new (
                                                                      "micrometer per square week"
                                                                    , "μm/wk²"
                                                                    , MillimeterPerSquareDay
                                                                    , 1.0 / 1000.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) zeptometer per square hour. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × attometer per square minute.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareHour = new (
                                                                      "zeptometer per square hour"
                                                                    , "zm/hr²"
                                                                    , AttometerPerSquareMinute
                                                                    , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) petameter per square minute. Defined as: (1000.0)/((60.0)*(60.0)) × terameter per square second.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareMinute = new (
                                                                       "petameter per square minute"
                                                                     , "Pm/min²"
                                                                     , TerameterPerSquareSecond
                                                                     , 1000.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) centimeter per square century. Defined as: (1.0/10.0)/((10.0)*(10.0)) × decimeter per square decade.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareCentury = new (
                                                                         "centimeter per square century"
                                                                       , "cm/century²"
                                                                       , DecimeterPerSquareDecade
                                                                       , 1.0 / 10.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) picometer per square day. Defined as: (1.0/1000.0)/((24.0)*(24.0)) × nanometer per square hour.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareDay = new (
                                                                    "picometer per square day"
                                                                  , "pm/dy²"
                                                                  , NanometerPerSquareHour
                                                                  , 1.0 / 1000.0 / (24.0 * 24.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exameter per square minute. Defined as: (1000.0)/((60.0)*(60.0)) × petameter per square second.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareMinute = new (
                                                                      "exameter per square minute"
                                                                    , "Em/min²"
                                                                    , PetameterPerSquareSecond
                                                                    , 1000.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) decimeter per square trillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × meter per square billion years.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareTrillionYears = new (
                                                                              "decimeter per square trillion years"
                                                                            , "dm/Tyr²"
                                                                            , MeterPerSquareBillionYears
                                                                            , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) yoctometer per square hour. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × zeptometer per square minute.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareHour = new (
                                                                      "yoctometer per square hour"
                                                                    , "ym/hr²"
                                                                    , ZeptometerPerSquareMinute
                                                                    , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) zettameter per square minute. Defined as: (1000.0)/((60.0)*(60.0)) × exameter per square second.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareMinute = new (
                                                                        "zettameter per square minute"
                                                                      , "Zm/min²"
                                                                      , ExameterPerSquareSecond
                                                                      , 1000.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) yottameter per square minute. Defined as: (1000.0)/((60.0)*(60.0)) × zettameter per square second.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareMinute = new (
                                                                        "yottameter per square minute"
                                                                      , "Ym/min²"
                                                                      , ZettameterPerSquareSecond
                                                                      , 1000.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) decimeter per square quadrillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × meter per square trillion years.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareQuadrillionYears = new (
       "decimeter per square quadrillion years"
     , "dm/Pyr²"
     , MeterPerSquareTrillionYears
     , 1.0 / 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) centimeter per square millennium. Defined as: (1.0/10.0)/((10.0)*(10.0)) × decimeter per square century.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareMillennium = new (
                                                                            "centimeter per square millennium"
                                                                          , "cm/kyr²"
                                                                          , DecimeterPerSquareCentury
                                                                          , 1.0 / 10.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) millimeter per square decade. Defined as: (1.0/10.0)/((10.0)*(10.0)) × centimeter per square year.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareDecade = new (
                                                                        "millimeter per square decade"
                                                                      , "mm/decade²"
                                                                      , CentimeterPerSquareYear
                                                                      , 1.0 / 10.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) nanometer per square week. Defined as: (1.0/1000.0)/((7.0)*(7.0)) × micrometer per square day.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareWeek = new (
                                                                     "nanometer per square week"
                                                                   , "nm/wk²"
                                                                   , MicrometerPerSquareDay
                                                                   , 1.0 / 1000.0 / (7.0 * 7.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) femtometer per square day. Defined as: (1.0/1000.0)/((24.0)*(24.0)) × picometer per square hour.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareDay = new (
                                                                     "femtometer per square day"
                                                                   , "fm/dy²"
                                                                   , PicometerPerSquareHour
                                                                   , 1.0 / 1000.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontometer per square hour. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × yoctometer per square minute.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareHour = new (
                                                                      "rontometer per square hour"
                                                                    , "rm/hr²"
                                                                    , YoctometerPerSquareMinute
                                                                    , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnameter per square minute. Defined as: (1000.0)/((60.0)*(60.0)) × yottameter per square second.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareMinute = new (
                                                                        "ronnameter per square minute"
                                                                      , "Rm/min²"
                                                                      , YottameterPerSquareSecond
                                                                      , 1000.0 / (60.0 * 60.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) meter per square tick. Defined as: (1.0)/((100.0)*(100.0)) × meter per square nanosecond.
   /// </summary>
   public static readonly Acceleration MeterPerSquareTick = new (
                                                                 "meter per square tick"
                                                               , "m/tick²"
                                                               , MeterPerSquareNanosecond
                                                               , 1.0 / (100.0 * 100.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) micrometer per square year. Defined as: (1.0/1000.0)/((365.2525)*(365.2525)) × millimeter per square day.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareYear = new (
                                                                      "micrometer per square year"
                                                                    , "μm/yr²"
                                                                    , MillimeterPerSquareDay
                                                                    , 1.0 / 1000.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettameter per square minute. Defined as: (1000.0)/((60.0)*(60.0)) × ronnameter per square second.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareMinute = new (
                                                                         "quettameter per square minute"
                                                                       , "Qm/min²"
                                                                       , RonnameterPerSquareSecond
                                                                       , 1000.0 / (60.0 * 60.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) decimeter per square quintillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × meter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareQuintillionYears = new (
       "decimeter per square quintillion years"
     , "dm/Eyr²"
     , MeterPerSquareQuadrillionYears
     , 1.0 / 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quectometer per square hour. Defined as: (1.0/1000.0)/((60.0)*(60.0)) × rontometer per square minute.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareHour = new (
                                                                       "quectometer per square hour"
                                                                     , "qm/hr²"
                                                                     , RontometerPerSquareMinute
                                                                     , 1.0 / 1000.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) centimeter per square million years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × decimeter per square millennium.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareMillionYears = new (
                                                                              "centimeter per square million years"
                                                                            , "cm/Myr²"
                                                                            , DecimeterPerSquareMillennium
                                                                            , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) attometer per square day. Defined as: (1.0/1000.0)/((24.0)*(24.0)) × femtometer per square hour.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareDay = new (
                                                                    "attometer per square day"
                                                                  , "am/dy²"
                                                                  , FemtometerPerSquareHour
                                                                  , 1.0 / 1000.0 / (24.0 * 24.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) decimeter per square sextillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × meter per square quintillion years.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareSextillionYears = new (
                                                                                "decimeter per square sextillion years"
                                                                              , "dm/Zyr²"
                                                                              , MeterPerSquareQuintillionYears
                                                                              , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) millimeter per square century. Defined as: (1.0/10.0)/((10.0)*(10.0)) × centimeter per square decade.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareCentury = new (
                                                                         "millimeter per square century"
                                                                       , "mm/century²"
                                                                       , CentimeterPerSquareDecade
                                                                       , 1.0 / 10.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) picometer per square week. Defined as: (1.0/1000.0)/((7.0)*(7.0)) × nanometer per square day.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareWeek = new (
                                                                     "picometer per square week"
                                                                   , "pm/wk²"
                                                                   , NanometerPerSquareDay
                                                                   , 1.0 / 1000.0 / (7.0 * 7.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekameter per square hour. Defined as: (10.0)/((60.0)*(60.0)) × meter per square minute.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareHour = new (
                                                                     "dekameter per square hour"
                                                                   , "dam/hr²"
                                                                   , MeterPerSquareMinute
                                                                   , 10.0 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) decimeter per square septillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × meter per square sextillion years.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareSeptillionYears = new (
                                                                                "decimeter per square septillion years"
                                                                              , "dm/Yyr²"
                                                                              , MeterPerSquareSextillionYears
                                                                              , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) centimeter per square billion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × decimeter per square million years.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareBillionYears = new (
                                                                              "centimeter per square billion years"
                                                                            , "cm/Gyr²"
                                                                            , DecimeterPerSquareMillionYears
                                                                            , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) micrometer per square decade. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × millimeter per square year.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareDecade = new (
                                                                        "micrometer per square decade"
                                                                      , "μm/decade²"
                                                                      , MillimeterPerSquareYear
                                                                      , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) nanometer per square year. Defined as: (1.0/1000.0)/((365.2525)*(365.2525)) × micrometer per square day.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareYear = new (
                                                                     "nanometer per square year"
                                                                   , "nm/yr²"
                                                                   , MicrometerPerSquareDay
                                                                   , 1.0 / 1000.0 / (365.2525 * 365.2525)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zeptometer per square day. Defined as: (1.0/1000.0)/((24.0)*(24.0)) × attometer per square hour.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareDay = new (
                                                                     "zeptometer per square day"
                                                                   , "zm/dy²"
                                                                   , AttometerPerSquareHour
                                                                   , 1.0 / 1000.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) hectometer per square hour. Defined as: (10.0)/((60.0)*(60.0)) × dekameter per square minute.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareHour = new (
                                                                      "hectometer per square hour"
                                                                    , "hm/hr²"
                                                                    , DekameterPerSquareMinute
                                                                    , 10.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) decimeter per square octillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × meter per square septillion years.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareOctillionYears = new (
                                                                               "decimeter per square octillion years"
                                                                             , "dm/Ryr²"
                                                                             , MeterPerSquareSeptillionYears
                                                                             , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) millimeter per square millennium. Defined as: (1.0/10.0)/((10.0)*(10.0)) × centimeter per square century.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareMillennium = new (
                                                                            "millimeter per square millennium"
                                                                          , "mm/kyr²"
                                                                          , CentimeterPerSquareCentury
                                                                          , 1.0 / 10.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) femtometer per square week. Defined as: (1.0/1000.0)/((7.0)*(7.0)) × picometer per square day.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareWeek = new (
                                                                      "femtometer per square week"
                                                                    , "fm/wk²"
                                                                    , PicometerPerSquareDay
                                                                    , 1.0 / 1000.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) kilometer per square hour. Defined as: (10.0)/((60.0)*(60.0)) × hectometer per square minute.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareHour = new (
                                                                     "kilometer per square hour"
                                                                   , "km/hr²"
                                                                   , HectometerPerSquareMinute
                                                                   , 10.0 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) centimeter per square trillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × decimeter per square billion years.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareTrillionYears = new (
                                                                               "centimeter per square trillion years"
                                                                             , "cm/Tyr²"
                                                                             , DecimeterPerSquareBillionYears
                                                                             , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) yoctometer per square day. Defined as: (1.0/1000.0)/((24.0)*(24.0)) × zeptometer per square hour.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareDay = new (
                                                                     "yoctometer per square day"
                                                                   , "ym/dy²"
                                                                   , ZeptometerPerSquareHour
                                                                   , 1.0 / 1000.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) decimeter per square nonillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × meter per square octillion years.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareNonillionYears = new (
                                                                               "decimeter per square nonillion years"
                                                                             , "dm/Qyr²"
                                                                             , MeterPerSquareOctillionYears
                                                                             , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) megameter per square hour. Defined as: (1000.0)/((60.0)*(60.0)) × kilometer per square minute.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareHour = new (
                                                                     "megameter per square hour"
                                                                   , "Mm/hr²"
                                                                   , KilometerPerSquareMinute
                                                                   , 1000.0 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) micrometer per square century. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × millimeter per square decade.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareCentury = new (
                                                                         "micrometer per square century"
                                                                       , "μm/century²"
                                                                       , MillimeterPerSquareDecade
                                                                       , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) picometer per square year. Defined as: (1.0/1000.0)/((365.2525)*(365.2525)) × nanometer per square day.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareYear = new (
                                                                     "picometer per square year"
                                                                   , "pm/yr²"
                                                                   , NanometerPerSquareDay
                                                                   , 1.0 / 1000.0 / (365.2525 * 365.2525)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) decimeter per square decillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × meter per square nonillion years.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareDecillionYears = new (
                                                                               "decimeter per square decillion years"
                                                                             , "dm/decillion yr²"
                                                                             , MeterPerSquareNonillionYears
                                                                             , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) centimeter per square quadrillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × decimeter per square trillion years.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareQuadrillionYears = new (
       "centimeter per square quadrillion years"
     , "cm/Pyr²"
     , DecimeterPerSquareTrillionYears
     , 1.0 / 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) millimeter per square million years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × centimeter per square millennium.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareMillionYears = new (
                                                                              "millimeter per square million years"
                                                                            , "mm/Myr²"
                                                                            , CentimeterPerSquareMillennium
                                                                            , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) nanometer per square decade. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × micrometer per square year.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareDecade = new (
                                                                       "nanometer per square decade"
                                                                     , "nm/decade²"
                                                                     , MicrometerPerSquareYear
                                                                     , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) attometer per square week. Defined as: (1.0/1000.0)/((7.0)*(7.0)) × femtometer per square day.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareWeek = new (
                                                                     "attometer per square week"
                                                                   , "am/wk²"
                                                                   , FemtometerPerSquareDay
                                                                   , 1.0 / 1000.0 / (7.0 * 7.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontometer per square day. Defined as: (1.0/1000.0)/((24.0)*(24.0)) × yoctometer per square hour.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareDay = new (
                                                                     "rontometer per square day"
                                                                   , "rm/dy²"
                                                                   , YoctometerPerSquareHour
                                                                   , 1.0 / 1000.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) gigameter per square hour. Defined as: (1000.0)/((60.0)*(60.0)) × megameter per square minute.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareHour = new (
                                                                     "gigameter per square hour"
                                                                   , "Gm/hr²"
                                                                   , MegameterPerSquareMinute
                                                                   , 1000.0 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) decimeter per square planck-time. Defined as: (1.0/10.0)/((5.391247E-38)*(5.391247E-38)) × meter per square microsecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquarePlanckTime = new (
                                                                           "decimeter per square planck-time"
                                                                         , "dm/tₚ²"
                                                                         , MeterPerSquareMicrosecond
                                                                         , 1.0 / 10.0 / (5.391247E-38 * 5.391247E-38)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square hour. Defined as: (1000.0)/((60.0)*(60.0)) × gigameter per square minute.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareHour = new (
                                                                     "terameter per square hour"
                                                                   , "Tm/hr²"
                                                                   , GigameterPerSquareMinute
                                                                   , 1000.0 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) centimeter per square quintillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × decimeter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareQuintillionYears = new (
       "centimeter per square quintillion years"
     , "cm/Eyr²"
     , DecimeterPerSquareQuadrillionYears
     , 1.0 / 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quectometer per square day. Defined as: (1.0/1000.0)/((24.0)*(24.0)) × rontometer per square hour.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareDay = new (
                                                                      "quectometer per square day"
                                                                    , "qm/dy²"
                                                                    , RontometerPerSquareHour
                                                                    , 1.0 / 1000.0 / (24.0 * 24.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) millimeter per square billion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × centimeter per square million years.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareBillionYears = new (
                                                                              "millimeter per square billion years"
                                                                            , "mm/Gyr²"
                                                                            , CentimeterPerSquareMillionYears
                                                                            , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) micrometer per square millennium. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × millimeter per square century.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareMillennium = new (
                                                                            "micrometer per square millennium"
                                                                          , "μm/kyr²"
                                                                          , MillimeterPerSquareCentury
                                                                          , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) femtometer per square year. Defined as: (1.0/1000.0)/((365.2525)*(365.2525)) × picometer per square day.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareYear = new (
                                                                      "femtometer per square year"
                                                                    , "fm/yr²"
                                                                    , PicometerPerSquareDay
                                                                    , 1.0 / 1000.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) zeptometer per square week. Defined as: (1.0/1000.0)/((7.0)*(7.0)) × attometer per square day.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareWeek = new (
                                                                      "zeptometer per square week"
                                                                    , "zm/wk²"
                                                                    , AttometerPerSquareDay
                                                                    , 1.0 / 1000.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) petameter per square hour. Defined as: (1000.0)/((60.0)*(60.0)) × terameter per square minute.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareHour = new (
                                                                     "petameter per square hour"
                                                                   , "Pm/hr²"
                                                                   , TerameterPerSquareMinute
                                                                   , 1000.0 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) centimeter per square sextillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × decimeter per square quintillion years.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareSextillionYears = new (
       "centimeter per square sextillion years"
     , "cm/Zyr²"
     , DecimeterPerSquareQuintillionYears
     , 1.0 / 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) nanometer per square century. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × micrometer per square decade.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareCentury = new (
                                                                        "nanometer per square century"
                                                                      , "nm/century²"
                                                                      , MicrometerPerSquareDecade
                                                                      , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) picometer per square decade. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × nanometer per square year.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareDecade = new (
                                                                       "picometer per square decade"
                                                                     , "pm/decade²"
                                                                     , NanometerPerSquareYear
                                                                     , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) dekameter per square day. Defined as: (10.0)/((24.0)*(24.0)) × meter per square hour.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareDay =
            new ("dekameter per square day", "dam/dy²", MeterPerSquareHour, 10.0 / (24.0 * 24.0), 0);

   /// <summary>
   /// A(n) exameter per square hour. Defined as: (1000.0)/((60.0)*(60.0)) × petameter per square minute.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareHour = new (
                                                                    "exameter per square hour"
                                                                  , "Em/hr²"
                                                                  , PetameterPerSquareMinute
                                                                  , 1000.0 / (60.0 * 60.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) millimeter per square trillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × centimeter per square billion years.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareTrillionYears = new (
                                                                               "millimeter per square trillion years"
                                                                             , "mm/Tyr²"
                                                                             , CentimeterPerSquareBillionYears
                                                                             , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) yoctometer per square week. Defined as: (1.0/1000.0)/((7.0)*(7.0)) × zeptometer per square day.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareWeek = new (
                                                                      "yoctometer per square week"
                                                                    , "ym/wk²"
                                                                    , ZeptometerPerSquareDay
                                                                    , 1.0 / 1000.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) zettameter per square hour. Defined as: (1000.0)/((60.0)*(60.0)) × exameter per square minute.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareHour = new (
                                                                      "zettameter per square hour"
                                                                    , "Zm/hr²"
                                                                    , ExameterPerSquareMinute
                                                                    , 1000.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) centimeter per square septillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × decimeter per square sextillion years.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareSeptillionYears = new (
       "centimeter per square septillion years"
     , "cm/Yyr²"
     , DecimeterPerSquareSextillionYears
     , 1.0 / 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) micrometer per square million years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × millimeter per square millennium.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareMillionYears = new (
                                                                              "micrometer per square million years"
                                                                            , "μm/Myr²"
                                                                            , MillimeterPerSquareMillennium
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) attometer per square year. Defined as: (1.0/1000.0)/((365.2525)*(365.2525)) × femtometer per square day.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareYear = new (
                                                                     "attometer per square year"
                                                                   , "am/yr²"
                                                                   , FemtometerPerSquareDay
                                                                   , 1.0 / 1000.0 / (365.2525 * 365.2525)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) hectometer per square day. Defined as: (10.0)/((24.0)*(24.0)) × dekameter per square hour.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareDay = new (
                                                                     "hectometer per square day"
                                                                   , "hm/dy²"
                                                                   , DekameterPerSquareHour
                                                                   , 10.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottameter per square hour. Defined as: (1000.0)/((60.0)*(60.0)) × zettameter per square minute.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareHour = new (
                                                                      "yottameter per square hour"
                                                                    , "Ym/hr²"
                                                                    , ZettameterPerSquareMinute
                                                                    , 1000.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) centimeter per square octillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × decimeter per square septillion years.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareOctillionYears = new (
                                                                                "centimeter per square octillion years"
                                                                              , "cm/Ryr²"
                                                                              , DecimeterPerSquareSeptillionYears
                                                                              , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) millimeter per square quadrillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × centimeter per square trillion years.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareQuadrillionYears = new (
       "millimeter per square quadrillion years"
     , "mm/Pyr²"
     , CentimeterPerSquareTrillionYears
     , 1.0 / 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) nanometer per square millennium. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × micrometer per square century.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareMillennium = new (
                                                                           "nanometer per square millennium"
                                                                         , "nm/kyr²"
                                                                         , MicrometerPerSquareCentury
                                                                         , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) femtometer per square decade. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × picometer per square year.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareDecade = new (
                                                                        "femtometer per square decade"
                                                                      , "fm/decade²"
                                                                      , PicometerPerSquareYear
                                                                      , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) rontometer per square week. Defined as: (1.0/1000.0)/((7.0)*(7.0)) × yoctometer per square day.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareWeek = new (
                                                                      "rontometer per square week"
                                                                    , "rm/wk²"
                                                                    , YoctometerPerSquareDay
                                                                    , 1.0 / 1000.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) kilometer per square day. Defined as: (10.0)/((24.0)*(24.0)) × hectometer per square hour.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareDay = new (
                                                                    "kilometer per square day"
                                                                  , "km/dy²"
                                                                  , HectometerPerSquareHour
                                                                  , 10.0 / (24.0 * 24.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) ronnameter per square hour. Defined as: (1000.0)/((60.0)*(60.0)) × yottameter per square minute.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareHour = new (
                                                                      "ronnameter per square hour"
                                                                    , "Rm/hr²"
                                                                    , YottameterPerSquareMinute
                                                                    , 1000.0 / (60.0 * 60.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) picometer per square century. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × nanometer per square decade.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareCentury = new (
                                                                        "picometer per square century"
                                                                      , "pm/century²"
                                                                      , NanometerPerSquareDecade
                                                                      , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) decimeter per square tick. Defined as: (1.0/10.0)/((100.0)*(100.0)) × meter per square nanosecond.
   /// </summary>
   public static readonly Acceleration DecimeterPerSquareTick = new (
                                                                     "decimeter per square tick"
                                                                   , "dm/tick²"
                                                                   , MeterPerSquareNanosecond
                                                                   , 1.0 / 10.0 / (100.0 * 100.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) micrometer per square billion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × millimeter per square million years.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareBillionYears = new (
                                                                              "micrometer per square billion years"
                                                                            , "μm/Gyr²"
                                                                            , MillimeterPerSquareMillionYears
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) zeptometer per square year. Defined as: (1.0/1000.0)/((365.2525)*(365.2525)) × attometer per square day.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareYear = new (
                                                                      "zeptometer per square year"
                                                                    , "zm/yr²"
                                                                    , AttometerPerSquareDay
                                                                    , 1.0 / 1000.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettameter per square hour. Defined as: (1000.0)/((60.0)*(60.0)) × ronnameter per square minute.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareHour = new (
                                                                       "quettameter per square hour"
                                                                     , "Qm/hr²"
                                                                     , RonnameterPerSquareMinute
                                                                     , 1000.0 / (60.0 * 60.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) centimeter per square nonillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × decimeter per square octillion years.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareNonillionYears = new (
                                                                                "centimeter per square nonillion years"
                                                                              , "cm/Qyr²"
                                                                              , DecimeterPerSquareOctillionYears
                                                                              , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) megameter per square day. Defined as: (1000.0)/((24.0)*(24.0)) × kilometer per square hour.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareDay = new (
                                                                    "megameter per square day"
                                                                  , "Mm/dy²"
                                                                  , KilometerPerSquareHour
                                                                  , 1000.0 / (24.0 * 24.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) millimeter per square quintillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × centimeter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareQuintillionYears = new (
       "millimeter per square quintillion years"
     , "mm/Eyr²"
     , CentimeterPerSquareQuadrillionYears
     , 1.0 / 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quectometer per square week. Defined as: (1.0/1000.0)/((7.0)*(7.0)) × rontometer per square day.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareWeek = new (
                                                                       "quectometer per square week"
                                                                     , "qm/wk²"
                                                                     , RontometerPerSquareDay
                                                                     , 1.0 / 1000.0 / (7.0 * 7.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) centimeter per square decillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × decimeter per square nonillion years.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareDecillionYears = new (
                                                                                "centimeter per square decillion years"
                                                                              , "cm/decillion yr²"
                                                                              , DecimeterPerSquareNonillionYears
                                                                              , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) nanometer per square million years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × micrometer per square millennium.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareMillionYears = new (
                                                                             "nanometer per square million years"
                                                                           , "nm/Myr²"
                                                                           , MicrometerPerSquareMillennium
                                                                           , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) attometer per square decade. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × femtometer per square year.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareDecade = new (
                                                                       "attometer per square decade"
                                                                     , "am/decade²"
                                                                     , FemtometerPerSquareYear
                                                                     , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) gigameter per square day. Defined as: (1000.0)/((24.0)*(24.0)) × megameter per square hour.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareDay = new (
                                                                    "gigameter per square day"
                                                                  , "Gm/dy²"
                                                                  , MegameterPerSquareHour
                                                                  , 1000.0 / (24.0 * 24.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) micrometer per square trillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × millimeter per square billion years.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareTrillionYears = new (
                                                                               "micrometer per square trillion years"
                                                                             , "μm/Tyr²"
                                                                             , MillimeterPerSquareBillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) yoctometer per square year. Defined as: (1.0/1000.0)/((365.2525)*(365.2525)) × zeptometer per square day.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareYear = new (
                                                                      "yoctometer per square year"
                                                                    , "ym/yr²"
                                                                    , ZeptometerPerSquareDay
                                                                    , 1.0 / 1000.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) millimeter per square sextillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × centimeter per square quintillion years.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareSextillionYears = new (
       "millimeter per square sextillion years"
     , "mm/Zyr²"
     , CentimeterPerSquareQuintillionYears
     , 1.0 / 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) picometer per square millennium. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × nanometer per square century.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareMillennium = new (
                                                                           "picometer per square millennium"
                                                                         , "pm/kyr²"
                                                                         , NanometerPerSquareCentury
                                                                         , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) femtometer per square century. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × picometer per square decade.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareCentury = new (
                                                                         "femtometer per square century"
                                                                       , "fm/century²"
                                                                       , PicometerPerSquareDecade
                                                                       , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) dekameter per square week. Defined as: (10.0)/((7.0)*(7.0)) × meter per square day.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareWeek =
            new ("dekameter per square week", "dam/wk²", MeterPerSquareDay, 10.0 / (7.0 * 7.0), 0);

   /// <summary>
   /// A(n) centimeter per square planck-time. Defined as: (1.0/10.0)/((5.391247E-38)*(5.391247E-38)) × decimeter per square microsecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquarePlanckTime = new (
                                                                            "centimeter per square planck-time"
                                                                          , "cm/tₚ²"
                                                                          , DecimeterPerSquareMicrosecond
                                                                          , 1.0 / 10.0 / (5.391247E-38 * 5.391247E-38)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square day. Defined as: (1000.0)/((24.0)*(24.0)) × gigameter per square hour.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareDay = new (
                                                                    "terameter per square day"
                                                                  , "Tm/dy²"
                                                                  , GigameterPerSquareHour
                                                                  , 1000.0 / (24.0 * 24.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) millimeter per square septillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × centimeter per square sextillion years.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareSeptillionYears = new (
       "millimeter per square septillion years"
     , "mm/Yyr²"
     , CentimeterPerSquareSextillionYears
     , 1.0 / 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) micrometer per square quadrillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × millimeter per square trillion years.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareQuadrillionYears = new (
       "micrometer per square quadrillion years"
     , "μm/Pyr²"
     , MillimeterPerSquareTrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) nanometer per square billion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × micrometer per square million years.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareBillionYears = new (
                                                                             "nanometer per square billion years"
                                                                           , "nm/Gyr²"
                                                                           , MicrometerPerSquareMillionYears
                                                                           , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zeptometer per square decade. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × attometer per square year.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareDecade = new (
                                                                        "zeptometer per square decade"
                                                                      , "zm/decade²"
                                                                      , AttometerPerSquareYear
                                                                      , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) rontometer per square year. Defined as: (1.0/1000.0)/((365.2525)*(365.2525)) × yoctometer per square day.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareYear = new (
                                                                      "rontometer per square year"
                                                                    , "rm/yr²"
                                                                    , YoctometerPerSquareDay
                                                                    , 1.0 / 1000.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hectometer per square week. Defined as: (10.0)/((7.0)*(7.0)) × dekameter per square day.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareWeek = new (
                                                                      "hectometer per square week"
                                                                    , "hm/wk²"
                                                                    , DekameterPerSquareDay
                                                                    , 10.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) petameter per square day. Defined as: (1000.0)/((24.0)*(24.0)) × terameter per square hour.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareDay = new (
                                                                    "petameter per square day"
                                                                  , "Pm/dy²"
                                                                  , TerameterPerSquareHour
                                                                  , 1000.0 / (24.0 * 24.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picometer per square million years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × nanometer per square millennium.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareMillionYears = new (
                                                                             "picometer per square million years"
                                                                           , "pm/Myr²"
                                                                           , NanometerPerSquareMillennium
                                                                           , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) attometer per square century. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × femtometer per square decade.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareCentury = new (
                                                                        "attometer per square century"
                                                                      , "am/century²"
                                                                      , FemtometerPerSquareDecade
                                                                      , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) exameter per square day. Defined as: (1000.0)/((24.0)*(24.0)) × petameter per square hour.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareDay = new (
                                                                   "exameter per square day"
                                                                 , "Em/dy²"
                                                                 , PetameterPerSquareHour
                                                                 , 1000.0 / (24.0 * 24.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) millimeter per square octillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × centimeter per square septillion years.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareOctillionYears = new (
                                                                                "millimeter per square octillion years"
                                                                              , "mm/Ryr²"
                                                                              , CentimeterPerSquareSeptillionYears
                                                                              , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) femtometer per square millennium. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × picometer per square century.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareMillennium = new (
                                                                            "femtometer per square millennium"
                                                                          , "fm/kyr²"
                                                                          , PicometerPerSquareCentury
                                                                          , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) kilometer per square week. Defined as: (10.0)/((7.0)*(7.0)) × hectometer per square day.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareWeek = new (
                                                                     "kilometer per square week"
                                                                   , "km/wk²"
                                                                   , HectometerPerSquareDay
                                                                   , 10.0 / (7.0 * 7.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) micrometer per square quintillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × millimeter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareQuintillionYears = new (
       "micrometer per square quintillion years"
     , "μm/Eyr²"
     , MillimeterPerSquareQuadrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quectometer per square year. Defined as: (1.0/1000.0)/((365.2525)*(365.2525)) × rontometer per square day.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareYear = new (
                                                                       "quectometer per square year"
                                                                     , "qm/yr²"
                                                                     , RontometerPerSquareDay
                                                                     , 1.0 / 1000.0 / (365.2525 * 365.2525)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) nanometer per square trillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × micrometer per square billion years.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareTrillionYears = new (
                                                                              "nanometer per square trillion years"
                                                                            , "nm/Tyr²"
                                                                            , MicrometerPerSquareBillionYears
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) yoctometer per square decade. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × zeptometer per square year.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareDecade = new (
                                                                        "yoctometer per square decade"
                                                                      , "ym/decade²"
                                                                      , ZeptometerPerSquareYear
                                                                      , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) zettameter per square day. Defined as: (1000.0)/((24.0)*(24.0)) × exameter per square hour.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareDay = new (
                                                                     "zettameter per square day"
                                                                   , "Zm/dy²"
                                                                   , ExameterPerSquareHour
                                                                   , 1000.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) millimeter per square nonillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × centimeter per square octillion years.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareNonillionYears = new (
                                                                                "millimeter per square nonillion years"
                                                                              , "mm/Qyr²"
                                                                              , CentimeterPerSquareOctillionYears
                                                                              , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) megameter per square week. Defined as: (1000.0)/((7.0)*(7.0)) × kilometer per square day.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareWeek = new (
                                                                     "megameter per square week"
                                                                   , "Mm/wk²"
                                                                   , KilometerPerSquareDay
                                                                   , 1000.0 / (7.0 * 7.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottameter per square day. Defined as: (1000.0)/((24.0)*(24.0)) × zettameter per square hour.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareDay = new (
                                                                     "yottameter per square day"
                                                                   , "Ym/dy²"
                                                                   , ZettameterPerSquareHour
                                                                   , 1000.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) micrometer per square sextillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × millimeter per square quintillion years.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareSextillionYears = new (
       "micrometer per square sextillion years"
     , "μm/Zyr²"
     , MillimeterPerSquareQuintillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) picometer per square billion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × nanometer per square million years.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareBillionYears = new (
                                                                             "picometer per square billion years"
                                                                           , "pm/Gyr²"
                                                                           , NanometerPerSquareMillionYears
                                                                           , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zeptometer per square century. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × attometer per square decade.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareCentury = new (
                                                                         "zeptometer per square century"
                                                                       , "zm/century²"
                                                                       , AttometerPerSquareDecade
                                                                       , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) dekameter per square year. Defined as: (10.0)/((365.2525)*(365.2525)) × meter per square day.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareYear = new (
                                                                     "dekameter per square year"
                                                                   , "dam/yr²"
                                                                   , MeterPerSquareDay
                                                                   , 10.0 / (365.2525 * 365.2525)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) millimeter per square decillion years. Defined as: (1.0/10.0)/((1000.0)*(1000.0)) × centimeter per square nonillion years.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareDecillionYears = new (
                                                                                "millimeter per square decillion years"
                                                                              , "mm/decillion yr²"
                                                                              , CentimeterPerSquareNonillionYears
                                                                              , 1.0 / 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) nanometer per square quadrillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × micrometer per square trillion years.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareQuadrillionYears = new (
       "nanometer per square quadrillion years"
     , "nm/Pyr²"
     , MicrometerPerSquareTrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) femtometer per square million years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × picometer per square millennium.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareMillionYears = new (
                                                                              "femtometer per square million years"
                                                                            , "fm/Myr²"
                                                                            , PicometerPerSquareMillennium
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) attometer per square millennium. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × femtometer per square century.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareMillennium = new (
                                                                           "attometer per square millennium"
                                                                         , "am/kyr²"
                                                                         , FemtometerPerSquareCentury
                                                                         , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) rontometer per square decade. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × yoctometer per square year.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareDecade = new (
                                                                        "rontometer per square decade"
                                                                      , "rm/decade²"
                                                                      , YoctometerPerSquareYear
                                                                      , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) gigameter per square week. Defined as: (1000.0)/((7.0)*(7.0)) × megameter per square day.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareWeek = new (
                                                                     "gigameter per square week"
                                                                   , "Gm/wk²"
                                                                   , MegameterPerSquareDay
                                                                   , 1000.0 / (7.0 * 7.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnameter per square day. Defined as: (1000.0)/((24.0)*(24.0)) × yottameter per square hour.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareDay = new (
                                                                     "ronnameter per square day"
                                                                   , "Rm/dy²"
                                                                   , YottameterPerSquareHour
                                                                   , 1000.0 / (24.0 * 24.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) centimeter per square tick. Defined as: (1.0/10.0)/((100.0)*(100.0)) × decimeter per square nanosecond.
   /// </summary>
   public static readonly Acceleration CentimeterPerSquareTick = new (
                                                                      "centimeter per square tick"
                                                                    , "cm/tick²"
                                                                    , DecimeterPerSquareNanosecond
                                                                    , 1.0 / 10.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) micrometer per square septillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × millimeter per square sextillion years.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareSeptillionYears = new (
       "micrometer per square septillion years"
     , "μm/Yyr²"
     , MillimeterPerSquareSextillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) hectometer per square year. Defined as: (10.0)/((365.2525)*(365.2525)) × dekameter per square day.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareYear = new (
                                                                      "hectometer per square year"
                                                                    , "hm/yr²"
                                                                    , DekameterPerSquareDay
                                                                    , 10.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettameter per square day. Defined as: (1000.0)/((24.0)*(24.0)) × ronnameter per square hour.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareDay = new (
                                                                      "quettameter per square day"
                                                                    , "Qm/dy²"
                                                                    , RonnameterPerSquareHour
                                                                    , 1000.0 / (24.0 * 24.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) millimeter per square planck-time. Defined as: (1.0/10.0)/((5.391247E-38)*(5.391247E-38)) × centimeter per square microsecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquarePlanckTime = new (
                                                                            "millimeter per square planck-time"
                                                                          , "mm/tₚ²"
                                                                          , CentimeterPerSquareMicrosecond
                                                                          , 1.0 / 10.0 / (5.391247E-38 * 5.391247E-38)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square week. Defined as: (1000.0)/((7.0)*(7.0)) × gigameter per square day.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareWeek = new (
                                                                     "terameter per square week"
                                                                   , "Tm/wk²"
                                                                   , GigameterPerSquareDay
                                                                   , 1000.0 / (7.0 * 7.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) picometer per square trillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × nanometer per square billion years.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareTrillionYears = new (
                                                                              "picometer per square trillion years"
                                                                            , "pm/Tyr²"
                                                                            , NanometerPerSquareBillionYears
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) yoctometer per square century. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × zeptometer per square decade.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareCentury = new (
                                                                         "yoctometer per square century"
                                                                       , "ym/century²"
                                                                       , ZeptometerPerSquareDecade
                                                                       , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) nanometer per square quintillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × micrometer per square quadrillion years.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareQuintillionYears = new (
       "nanometer per square quintillion years"
     , "nm/Eyr²"
     , MicrometerPerSquareQuadrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quectometer per square decade. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × rontometer per square year.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareDecade = new (
                                                                         "quectometer per square decade"
                                                                       , "qm/decade²"
                                                                       , RontometerPerSquareYear
                                                                       , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) micrometer per square octillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × millimeter per square septillion years.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareOctillionYears = new (
                                                                                "micrometer per square octillion years"
                                                                              , "μm/Ryr²"
                                                                              , MillimeterPerSquareSeptillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) femtometer per square billion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × picometer per square million years.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareBillionYears = new (
                                                                              "femtometer per square billion years"
                                                                            , "fm/Gyr²"
                                                                            , PicometerPerSquareMillionYears
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) zeptometer per square millennium. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × attometer per square century.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareMillennium = new (
                                                                            "zeptometer per square millennium"
                                                                          , "zm/kyr²"
                                                                          , AttometerPerSquareCentury
                                                                          , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) kilometer per square year. Defined as: (10.0)/((365.2525)*(365.2525)) × hectometer per square day.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareYear = new (
                                                                     "kilometer per square year"
                                                                   , "km/yr²"
                                                                   , HectometerPerSquareDay
                                                                   , 10.0 / (365.2525 * 365.2525)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) petameter per square week. Defined as: (1000.0)/((7.0)*(7.0)) × terameter per square day.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareWeek = new (
                                                                     "petameter per square week"
                                                                   , "Pm/wk²"
                                                                   , TerameterPerSquareDay
                                                                   , 1000.0 / (7.0 * 7.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attometer per square million years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × femtometer per square millennium.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareMillionYears = new (
                                                                             "attometer per square million years"
                                                                           , "am/Myr²"
                                                                           , FemtometerPerSquareMillennium
                                                                           , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) nanometer per square sextillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × micrometer per square quintillion years.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareSextillionYears = new (
                                                                                "nanometer per square sextillion years"
                                                                              , "nm/Zyr²"
                                                                              , MicrometerPerSquareQuintillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) picometer per square quadrillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × nanometer per square trillion years.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareQuadrillionYears = new (
       "picometer per square quadrillion years"
     , "pm/Pyr²"
     , NanometerPerSquareTrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) rontometer per square century. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × yoctometer per square decade.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareCentury = new (
                                                                         "rontometer per square century"
                                                                       , "rm/century²"
                                                                       , YoctometerPerSquareDecade
                                                                       , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) dekameter per square decade. Defined as: (10.0)/((10.0)*(10.0)) × meter per square year.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareDecade = new (
                                                                       "dekameter per square decade"
                                                                     , "dam/decade²"
                                                                     , MeterPerSquareYear
                                                                     , 10.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) exameter per square week. Defined as: (1000.0)/((7.0)*(7.0)) × petameter per square day.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareWeek = new (
                                                                    "exameter per square week"
                                                                  , "Em/wk²"
                                                                  , PetameterPerSquareDay
                                                                  , 1000.0 / (7.0 * 7.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) micrometer per square nonillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × millimeter per square octillion years.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareNonillionYears = new (
                                                                                "micrometer per square nonillion years"
                                                                              , "μm/Qyr²"
                                                                              , MillimeterPerSquareOctillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) megameter per square year. Defined as: (1000.0)/((365.2525)*(365.2525)) × kilometer per square day.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareYear = new (
                                                                     "megameter per square year"
                                                                   , "Mm/yr²"
                                                                   , KilometerPerSquareDay
                                                                   , 1000.0 / (365.2525 * 365.2525)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) femtometer per square trillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × picometer per square billion years.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareTrillionYears = new (
                                                                               "femtometer per square trillion years"
                                                                             , "fm/Tyr²"
                                                                             , PicometerPerSquareBillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) yoctometer per square millennium. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × zeptometer per square century.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareMillennium = new (
                                                                            "yoctometer per square millennium"
                                                                          , "ym/kyr²"
                                                                          , ZeptometerPerSquareCentury
                                                                          , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zettameter per square week. Defined as: (1000.0)/((7.0)*(7.0)) × exameter per square day.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareWeek = new (
                                                                      "zettameter per square week"
                                                                    , "Zm/wk²"
                                                                    , ExameterPerSquareDay
                                                                    , 1000.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) micrometer per square decillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × millimeter per square nonillion years.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareDecillionYears = new (
                                                                                "micrometer per square decillion years"
                                                                              , "μm/decillion yr²"
                                                                              , MillimeterPerSquareNonillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) nanometer per square septillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × micrometer per square sextillion years.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareSeptillionYears = new (
                                                                                "nanometer per square septillion years"
                                                                              , "nm/Yyr²"
                                                                              , MicrometerPerSquareSextillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) attometer per square billion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × femtometer per square million years.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareBillionYears = new (
                                                                             "attometer per square billion years"
                                                                           , "am/Gyr²"
                                                                           , FemtometerPerSquareMillionYears
                                                                           , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) zeptometer per square million years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × attometer per square millennium.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareMillionYears = new (
                                                                              "zeptometer per square million years"
                                                                            , "zm/Myr²"
                                                                            , AttometerPerSquareMillennium
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) hectometer per square decade. Defined as: (10.0)/((10.0)*(10.0)) × dekameter per square year.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareDecade = new (
                                                                        "hectometer per square decade"
                                                                      , "hm/decade²"
                                                                      , DekameterPerSquareYear
                                                                      , 10.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) gigameter per square year. Defined as: (1000.0)/((365.2525)*(365.2525)) × megameter per square day.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareYear = new (
                                                                     "gigameter per square year"
                                                                   , "Gm/yr²"
                                                                   , MegameterPerSquareDay
                                                                   , 1000.0 / (365.2525 * 365.2525)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) picometer per square quintillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × nanometer per square quadrillion years.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareQuintillionYears = new (
       "picometer per square quintillion years"
     , "pm/Eyr²"
     , NanometerPerSquareQuadrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quectometer per square century. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × rontometer per square decade.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareCentury = new (
                                                                          "quectometer per square century"
                                                                        , "qm/century²"
                                                                        , RontometerPerSquareDecade
                                                                        , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) yottameter per square week. Defined as: (1000.0)/((7.0)*(7.0)) × zettameter per square day.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareWeek = new (
                                                                      "yottameter per square week"
                                                                    , "Ym/wk²"
                                                                    , ZettameterPerSquareDay
                                                                    , 1000.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) micrometer per square planck-time. Defined as: (1.0/1000.0)/((5.391247E-38)*(5.391247E-38)) × millimeter per square microsecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquarePlanckTime = new (
                                                                            "micrometer per square planck-time"
                                                                          , "μm/tₚ²"
                                                                          , MillimeterPerSquareMicrosecond
                                                                          , 1.0 / 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square year. Defined as: (1000.0)/((365.2525)*(365.2525)) × gigameter per square day.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareYear = new (
                                                                     "terameter per square year"
                                                                   , "Tm/yr²"
                                                                   , GigameterPerSquareDay
                                                                   , 1000.0 / (365.2525 * 365.2525)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanometer per square octillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × micrometer per square septillion years.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareOctillionYears = new (
                                                                               "nanometer per square octillion years"
                                                                             , "nm/Ryr²"
                                                                             , MicrometerPerSquareSeptillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) femtometer per square quadrillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × picometer per square trillion years.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareQuadrillionYears = new (
       "femtometer per square quadrillion years"
     , "fm/Pyr²"
     , PicometerPerSquareTrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) rontometer per square millennium. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × yoctometer per square century.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareMillennium = new (
                                                                            "rontometer per square millennium"
                                                                          , "rm/kyr²"
                                                                          , YoctometerPerSquareCentury
                                                                          , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) kilometer per square decade. Defined as: (10.0)/((10.0)*(10.0)) × hectometer per square year.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareDecade = new (
                                                                       "kilometer per square decade"
                                                                     , "km/decade²"
                                                                     , HectometerPerSquareYear
                                                                     , 10.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) ronnameter per square week. Defined as: (1000.0)/((7.0)*(7.0)) × yottameter per square day.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareWeek = new (
                                                                      "ronnameter per square week"
                                                                    , "Rm/wk²"
                                                                    , YottameterPerSquareDay
                                                                    , 1000.0 / (7.0 * 7.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) picometer per square sextillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × nanometer per square quintillion years.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareSextillionYears = new (
                                                                                "picometer per square sextillion years"
                                                                              , "pm/Zyr²"
                                                                              , NanometerPerSquareQuintillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) dekameter per square century. Defined as: (10.0)/((10.0)*(10.0)) × meter per square decade.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareCentury = new (
                                                                        "dekameter per square century"
                                                                      , "dam/century²"
                                                                      , MeterPerSquareDecade
                                                                      , 10.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) attometer per square trillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × femtometer per square billion years.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareTrillionYears = new (
                                                                              "attometer per square trillion years"
                                                                            , "am/Tyr²"
                                                                            , FemtometerPerSquareBillionYears
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) yoctometer per square million years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × zeptometer per square millennium.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareMillionYears = new (
                                                                              "yoctometer per square million years"
                                                                            , "ym/Myr²"
                                                                            , ZeptometerPerSquareMillennium
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) millimeter per square tick. Defined as: (1.0/10.0)/((100.0)*(100.0)) × centimeter per square nanosecond.
   /// </summary>
   public static readonly Acceleration MillimeterPerSquareTick = new (
                                                                      "millimeter per square tick"
                                                                    , "mm/tick²"
                                                                    , CentimeterPerSquareNanosecond
                                                                    , 1.0 / 10.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) zeptometer per square billion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × attometer per square million years.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareBillionYears = new (
                                                                              "zeptometer per square billion years"
                                                                            , "zm/Gyr²"
                                                                            , AttometerPerSquareMillionYears
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) petameter per square year. Defined as: (1000.0)/((365.2525)*(365.2525)) × terameter per square day.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareYear = new (
                                                                     "petameter per square year"
                                                                   , "Pm/yr²"
                                                                   , TerameterPerSquareDay
                                                                   , 1000.0 / (365.2525 * 365.2525)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettameter per square week. Defined as: (1000.0)/((7.0)*(7.0)) × ronnameter per square day.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareWeek = new (
                                                                       "quettameter per square week"
                                                                     , "Qm/wk²"
                                                                     , RonnameterPerSquareDay
                                                                     , 1000.0 / (7.0 * 7.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) nanometer per square nonillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × micrometer per square octillion years.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareNonillionYears = new (
                                                                               "nanometer per square nonillion years"
                                                                             , "nm/Qyr²"
                                                                             , MicrometerPerSquareOctillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) megameter per square decade. Defined as: (1000.0)/((10.0)*(10.0)) × kilometer per square year.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareDecade = new (
                                                                       "megameter per square decade"
                                                                     , "Mm/decade²"
                                                                     , KilometerPerSquareYear
                                                                     , 1000.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) femtometer per square quintillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × picometer per square quadrillion years.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareQuintillionYears = new (
       "femtometer per square quintillion years"
     , "fm/Eyr²"
     , PicometerPerSquareQuadrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quectometer per square millennium. Defined as: (1.0/1000.0)/((10.0)*(10.0)) × rontometer per square century.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareMillennium = new (
                                                                             "quectometer per square millennium"
                                                                           , "qm/kyr²"
                                                                           , RontometerPerSquareCentury
                                                                           , 1.0 / 1000.0 / (10.0 * 10.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) picometer per square septillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × nanometer per square sextillion years.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareSeptillionYears = new (
                                                                                "picometer per square septillion years"
                                                                              , "pm/Yyr²"
                                                                              , NanometerPerSquareSextillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) hectometer per square century. Defined as: (10.0)/((10.0)*(10.0)) × dekameter per square decade.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareCentury = new (
                                                                         "hectometer per square century"
                                                                       , "hm/century²"
                                                                       , DekameterPerSquareDecade
                                                                       , 10.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) exameter per square year. Defined as: (1000.0)/((365.2525)*(365.2525)) × petameter per square day.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareYear = new (
                                                                    "exameter per square year"
                                                                  , "Em/yr²"
                                                                  , PetameterPerSquareDay
                                                                  , 1000.0 / (365.2525 * 365.2525)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanometer per square decillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × micrometer per square nonillion years.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareDecillionYears = new (
                                                                               "nanometer per square decillion years"
                                                                             , "nm/decillion yr²"
                                                                             , MicrometerPerSquareNonillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) attometer per square quadrillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × femtometer per square trillion years.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareQuadrillionYears = new (
       "attometer per square quadrillion years"
     , "am/Pyr²"
     , FemtometerPerSquareTrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) rontometer per square million years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × yoctometer per square millennium.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareMillionYears = new (
                                                                              "rontometer per square million years"
                                                                            , "rm/Myr²"
                                                                            , YoctometerPerSquareMillennium
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) gigameter per square decade. Defined as: (1000.0)/((10.0)*(10.0)) × megameter per square year.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareDecade = new (
                                                                       "gigameter per square decade"
                                                                     , "Gm/decade²"
                                                                     , MegameterPerSquareYear
                                                                     , 1000.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) zeptometer per square trillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × attometer per square billion years.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareTrillionYears = new (
                                                                               "zeptometer per square trillion years"
                                                                             , "zm/Tyr²"
                                                                             , AttometerPerSquareBillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) yoctometer per square billion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × zeptometer per square million years.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareBillionYears = new (
                                                                              "yoctometer per square billion years"
                                                                            , "ym/Gyr²"
                                                                            , ZeptometerPerSquareMillionYears
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) zettameter per square year. Defined as: (1000.0)/((365.2525)*(365.2525)) × exameter per square day.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareYear = new (
                                                                      "zettameter per square year"
                                                                    , "Zm/yr²"
                                                                    , ExameterPerSquareDay
                                                                    , 1000.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) picometer per square octillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × nanometer per square septillion years.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareOctillionYears = new (
                                                                               "picometer per square octillion years"
                                                                             , "pm/Ryr²"
                                                                             , NanometerPerSquareSeptillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) femtometer per square sextillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × picometer per square quintillion years.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareSextillionYears = new (
       "femtometer per square sextillion years"
     , "fm/Zyr²"
     , PicometerPerSquareQuintillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) dekameter per square millennium. Defined as: (10.0)/((10.0)*(10.0)) × meter per square century.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareMillennium = new (
                                                                           "dekameter per square millennium"
                                                                         , "dam/kyr²"
                                                                         , MeterPerSquareCentury
                                                                         , 10.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) kilometer per square century. Defined as: (10.0)/((10.0)*(10.0)) × hectometer per square decade.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareCentury = new (
                                                                        "kilometer per square century"
                                                                      , "km/century²"
                                                                      , HectometerPerSquareDecade
                                                                      , 10.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) nanometer per square planck-time. Defined as: (1.0/1000.0)/((5.391247E-38)*(5.391247E-38)) × micrometer per square microsecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquarePlanckTime = new (
                                                                           "nanometer per square planck-time"
                                                                         , "nm/tₚ²"
                                                                         , MicrometerPerSquareMicrosecond
                                                                         , 1.0 / 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square decade. Defined as: (1000.0)/((10.0)*(10.0)) × gigameter per square year.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareDecade = new (
                                                                       "terameter per square decade"
                                                                     , "Tm/decade²"
                                                                     , GigameterPerSquareYear
                                                                     , 1000.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yottameter per square year. Defined as: (1000.0)/((365.2525)*(365.2525)) × zettameter per square day.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareYear = new (
                                                                      "yottameter per square year"
                                                                    , "Ym/yr²"
                                                                    , ZettameterPerSquareDay
                                                                    , 1000.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) attometer per square quintillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × femtometer per square quadrillion years.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareQuintillionYears = new (
       "attometer per square quintillion years"
     , "am/Eyr²"
     , FemtometerPerSquareQuadrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quectometer per square million years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × rontometer per square millennium.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareMillionYears = new (
                                                                               "quectometer per square million years"
                                                                             , "qm/Myr²"
                                                                             , RontometerPerSquareMillennium
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) picometer per square nonillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × nanometer per square octillion years.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareNonillionYears = new (
                                                                               "picometer per square nonillion years"
                                                                             , "pm/Qyr²"
                                                                             , NanometerPerSquareOctillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) megameter per square century. Defined as: (1000.0)/((10.0)*(10.0)) × kilometer per square decade.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareCentury = new (
                                                                        "megameter per square century"
                                                                      , "Mm/century²"
                                                                      , KilometerPerSquareDecade
                                                                      , 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) femtometer per square septillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × picometer per square sextillion years.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareSeptillionYears = new (
       "femtometer per square septillion years"
     , "fm/Yyr²"
     , PicometerPerSquareSextillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) zeptometer per square quadrillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × attometer per square trillion years.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareQuadrillionYears = new (
       "zeptometer per square quadrillion years"
     , "zm/Pyr²"
     , AttometerPerSquareTrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) rontometer per square billion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × yoctometer per square million years.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareBillionYears = new (
                                                                              "rontometer per square billion years"
                                                                            , "rm/Gyr²"
                                                                            , YoctometerPerSquareMillionYears
                                                                            , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) hectometer per square millennium. Defined as: (10.0)/((10.0)*(10.0)) × dekameter per square century.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareMillennium = new (
                                                                            "hectometer per square millennium"
                                                                          , "hm/kyr²"
                                                                          , DekameterPerSquareCentury
                                                                          , 10.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) petameter per square decade. Defined as: (1000.0)/((10.0)*(10.0)) × terameter per square year.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareDecade = new (
                                                                       "petameter per square decade"
                                                                     , "Pm/decade²"
                                                                     , TerameterPerSquareYear
                                                                     , 1000.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) ronnameter per square year. Defined as: (1000.0)/((365.2525)*(365.2525)) × yottameter per square day.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareYear = new (
                                                                      "ronnameter per square year"
                                                                    , "Rm/yr²"
                                                                    , YottameterPerSquareDay
                                                                    , 1000.0 / (365.2525 * 365.2525)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yoctometer per square trillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × zeptometer per square billion years.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareTrillionYears = new (
                                                                               "yoctometer per square trillion years"
                                                                             , "ym/Tyr²"
                                                                             , ZeptometerPerSquareBillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) micrometer per square tick. Defined as: (1.0/1000.0)/((100.0)*(100.0)) × millimeter per square nanosecond.
   /// </summary>
   public static readonly Acceleration MicrometerPerSquareTick = new (
                                                                      "micrometer per square tick"
                                                                    , "μm/tick²"
                                                                    , MillimeterPerSquareNanosecond
                                                                    , 1.0 / 1000.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettameter per square year. Defined as: (1000.0)/((365.2525)*(365.2525)) × ronnameter per square day.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareYear = new (
                                                                       "quettameter per square year"
                                                                     , "Qm/yr²"
                                                                     , RonnameterPerSquareDay
                                                                     , 1000.0 / (365.2525 * 365.2525)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) picometer per square decillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × nanometer per square nonillion years.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareDecillionYears = new (
                                                                               "picometer per square decillion years"
                                                                             , "pm/decillion yr²"
                                                                             , NanometerPerSquareNonillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) attometer per square sextillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × femtometer per square quintillion years.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareSextillionYears = new (
                                                                                "attometer per square sextillion years"
                                                                              , "am/Zyr²"
                                                                              , FemtometerPerSquareQuintillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) dekameter per square million years. Defined as: (10.0)/((1000.0)*(1000.0)) × meter per square millennium.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareMillionYears = new (
                                                                             "dekameter per square million years"
                                                                           , "dam/Myr²"
                                                                           , MeterPerSquareMillennium
                                                                           , 10.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) gigameter per square century. Defined as: (1000.0)/((10.0)*(10.0)) × megameter per square decade.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareCentury = new (
                                                                        "gigameter per square century"
                                                                      , "Gm/century²"
                                                                      , MegameterPerSquareDecade
                                                                      , 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) exameter per square decade. Defined as: (1000.0)/((10.0)*(10.0)) × petameter per square year.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareDecade = new (
                                                                      "exameter per square decade"
                                                                    , "Em/decade²"
                                                                    , PetameterPerSquareYear
                                                                    , 1000.0 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) femtometer per square octillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × picometer per square septillion years.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareOctillionYears = new (
                                                                                "femtometer per square octillion years"
                                                                              , "fm/Ryr²"
                                                                              , PicometerPerSquareSeptillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) kilometer per square millennium. Defined as: (10.0)/((10.0)*(10.0)) × hectometer per square century.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareMillennium = new (
                                                                           "kilometer per square millennium"
                                                                         , "km/kyr²"
                                                                         , HectometerPerSquareCentury
                                                                         , 10.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) zeptometer per square quintillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × attometer per square quadrillion years.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareQuintillionYears = new (
       "zeptometer per square quintillion years"
     , "zm/Eyr²"
     , AttometerPerSquareQuadrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quectometer per square billion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × rontometer per square million years.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareBillionYears = new (
                                                                               "quectometer per square billion years"
                                                                             , "qm/Gyr²"
                                                                             , RontometerPerSquareMillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) yoctometer per square quadrillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × zeptometer per square trillion years.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareQuadrillionYears = new (
       "yoctometer per square quadrillion years"
     , "ym/Pyr²"
     , ZeptometerPerSquareTrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) rontometer per square trillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × yoctometer per square billion years.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareTrillionYears = new (
                                                                               "rontometer per square trillion years"
                                                                             , "rm/Tyr²"
                                                                             , YoctometerPerSquareBillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) zettameter per square decade. Defined as: (1000.0)/((10.0)*(10.0)) × exameter per square year.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareDecade = new (
                                                                        "zettameter per square decade"
                                                                      , "Zm/decade²"
                                                                      , ExameterPerSquareYear
                                                                      , 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) picometer per square planck-time. Defined as: (1.0/1000.0)/((5.391247E-38)*(5.391247E-38)) × nanometer per square microsecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquarePlanckTime = new (
                                                                           "picometer per square planck-time"
                                                                         , "pm/tₚ²"
                                                                         , NanometerPerSquareMicrosecond
                                                                         , 1.0 / 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square century. Defined as: (1000.0)/((10.0)*(10.0)) × gigameter per square decade.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareCentury = new (
                                                                        "terameter per square century"
                                                                      , "Tm/century²"
                                                                      , GigameterPerSquareDecade
                                                                      , 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) attometer per square septillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × femtometer per square sextillion years.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareSeptillionYears = new (
                                                                                "attometer per square septillion years"
                                                                              , "am/Yyr²"
                                                                              , FemtometerPerSquareSextillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) hectometer per square million years. Defined as: (10.0)/((1000.0)*(1000.0)) × dekameter per square millennium.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareMillionYears = new (
                                                                              "hectometer per square million years"
                                                                            , "hm/Myr²"
                                                                            , DekameterPerSquareMillennium
                                                                            , 10.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) femtometer per square nonillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × picometer per square octillion years.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareNonillionYears = new (
                                                                                "femtometer per square nonillion years"
                                                                              , "fm/Qyr²"
                                                                              , PicometerPerSquareOctillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) megameter per square millennium. Defined as: (1000.0)/((10.0)*(10.0)) × kilometer per square century.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareMillennium = new (
                                                                           "megameter per square millennium"
                                                                         , "Mm/kyr²"
                                                                         , KilometerPerSquareCentury
                                                                         , 1000.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) yottameter per square decade. Defined as: (1000.0)/((10.0)*(10.0)) × zettameter per square year.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareDecade = new (
                                                                        "yottameter per square decade"
                                                                      , "Ym/decade²"
                                                                      , ZettameterPerSquareYear
                                                                      , 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) zeptometer per square sextillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × attometer per square quintillion years.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareSextillionYears = new (
       "zeptometer per square sextillion years"
     , "zm/Zyr²"
     , AttometerPerSquareQuintillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) dekameter per square billion years. Defined as: (10.0)/((1000.0)*(1000.0)) × meter per square million years.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareBillionYears = new (
                                                                             "dekameter per square billion years"
                                                                           , "dam/Gyr²"
                                                                           , MeterPerSquareMillionYears
                                                                           , 10.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) petameter per square century. Defined as: (1000.0)/((10.0)*(10.0)) × terameter per square decade.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareCentury = new (
                                                                        "petameter per square century"
                                                                      , "Pm/century²"
                                                                      , TerameterPerSquareDecade
                                                                      , 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) yoctometer per square quintillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × zeptometer per square quadrillion years.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareQuintillionYears = new (
       "yoctometer per square quintillion years"
     , "ym/Eyr²"
     , ZeptometerPerSquareQuadrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quectometer per square trillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × rontometer per square billion years.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareTrillionYears = new (
                                                                                "quectometer per square trillion years"
                                                                              , "qm/Tyr²"
                                                                              , RontometerPerSquareBillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) femtometer per square decillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × picometer per square nonillion years.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareDecillionYears = new (
                                                                                "femtometer per square decillion years"
                                                                              , "fm/decillion yr²"
                                                                              , PicometerPerSquareNonillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) attometer per square octillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × femtometer per square septillion years.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareOctillionYears = new (
                                                                               "attometer per square octillion years"
                                                                             , "am/Ryr²"
                                                                             , FemtometerPerSquareSeptillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) rontometer per square quadrillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × yoctometer per square trillion years.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareQuadrillionYears = new (
       "rontometer per square quadrillion years"
     , "rm/Pyr²"
     , YoctometerPerSquareTrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) kilometer per square million years. Defined as: (10.0)/((1000.0)*(1000.0)) × hectometer per square millennium.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareMillionYears = new (
                                                                             "kilometer per square million years"
                                                                           , "km/Myr²"
                                                                           , HectometerPerSquareMillennium
                                                                           , 10.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) gigameter per square millennium. Defined as: (1000.0)/((10.0)*(10.0)) × megameter per square century.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareMillennium = new (
                                                                           "gigameter per square millennium"
                                                                         , "Gm/kyr²"
                                                                         , MegameterPerSquareCentury
                                                                         , 1000.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) ronnameter per square decade. Defined as: (1000.0)/((10.0)*(10.0)) × yottameter per square year.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareDecade = new (
                                                                        "ronnameter per square decade"
                                                                      , "Rm/decade²"
                                                                      , YottameterPerSquareYear
                                                                      , 1000.0 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) exameter per square century. Defined as: (1000.0)/((10.0)*(10.0)) × petameter per square decade.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareCentury = new (
                                                                       "exameter per square century"
                                                                     , "Em/century²"
                                                                     , PetameterPerSquareDecade
                                                                     , 1000.0 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) nanometer per square tick. Defined as: (1.0/1000.0)/((100.0)*(100.0)) × micrometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration NanometerPerSquareTick = new (
                                                                     "nanometer per square tick"
                                                                   , "nm/tick²"
                                                                   , MicrometerPerSquareNanosecond
                                                                   , 1.0 / 1000.0 / (100.0 * 100.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zeptometer per square septillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × attometer per square sextillion years.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareSeptillionYears = new (
       "zeptometer per square septillion years"
     , "zm/Yyr²"
     , AttometerPerSquareSextillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) hectometer per square billion years. Defined as: (10.0)/((1000.0)*(1000.0)) × dekameter per square million years.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareBillionYears = new (
                                                                              "hectometer per square billion years"
                                                                            , "hm/Gyr²"
                                                                            , DekameterPerSquareMillionYears
                                                                            , 10.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) quettameter per square decade. Defined as: (1000.0)/((10.0)*(10.0)) × ronnameter per square year.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareDecade = new (
                                                                         "quettameter per square decade"
                                                                       , "Qm/decade²"
                                                                       , RonnameterPerSquareYear
                                                                       , 1000.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) femtometer per square planck-time. Defined as: (1.0/1000.0)/((5.391247E-38)*(5.391247E-38)) × picometer per square microsecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquarePlanckTime = new (
                                                                            "femtometer per square planck-time"
                                                                          , "fm/tₚ²"
                                                                          , PicometerPerSquareMicrosecond
                                                                          , 1.0 / 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square millennium. Defined as: (1000.0)/((10.0)*(10.0)) × gigameter per square century.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareMillennium = new (
                                                                           "terameter per square millennium"
                                                                         , "Tm/kyr²"
                                                                         , GigameterPerSquareCentury
                                                                         , 1000.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) attometer per square nonillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × femtometer per square octillion years.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareNonillionYears = new (
                                                                               "attometer per square nonillion years"
                                                                             , "am/Qyr²"
                                                                             , FemtometerPerSquareOctillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) megameter per square million years. Defined as: (1000.0)/((1000.0)*(1000.0)) × kilometer per square millennium.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareMillionYears = new (
                                                                             "megameter per square million years"
                                                                           , "Mm/Myr²"
                                                                           , KilometerPerSquareMillennium
                                                                           , 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yoctometer per square sextillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × zeptometer per square quintillion years.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareSextillionYears = new (
       "yoctometer per square sextillion years"
     , "ym/Zyr²"
     , ZeptometerPerSquareQuintillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) dekameter per square trillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × meter per square billion years.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareTrillionYears = new (
                                                                              "dekameter per square trillion years"
                                                                            , "dam/Tyr²"
                                                                            , MeterPerSquareBillionYears
                                                                            , 10.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) zettameter per square century. Defined as: (1000.0)/((10.0)*(10.0)) × exameter per square decade.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareCentury = new (
                                                                         "zettameter per square century"
                                                                       , "Zm/century²"
                                                                       , ExameterPerSquareDecade
                                                                       , 1000.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) rontometer per square quintillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × yoctometer per square quadrillion years.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareQuintillionYears = new (
       "rontometer per square quintillion years"
     , "rm/Eyr²"
     , YoctometerPerSquareQuadrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quectometer per square quadrillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × rontometer per square trillion years.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareQuadrillionYears = new (
       "quectometer per square quadrillion years"
     , "qm/Pyr²"
     , RontometerPerSquareTrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) zeptometer per square octillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × attometer per square septillion years.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareOctillionYears = new (
                                                                                "zeptometer per square octillion years"
                                                                              , "zm/Ryr²"
                                                                              , AttometerPerSquareSeptillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) kilometer per square billion years. Defined as: (10.0)/((1000.0)*(1000.0)) × hectometer per square million years.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareBillionYears = new (
                                                                             "kilometer per square billion years"
                                                                           , "km/Gyr²"
                                                                           , HectometerPerSquareMillionYears
                                                                           , 10.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) petameter per square millennium. Defined as: (1000.0)/((10.0)*(10.0)) × terameter per square century.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareMillennium = new (
                                                                           "petameter per square millennium"
                                                                         , "Pm/kyr²"
                                                                         , TerameterPerSquareCentury
                                                                         , 1000.0 / (10.0 * 10.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) yottameter per square century. Defined as: (1000.0)/((10.0)*(10.0)) × zettameter per square decade.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareCentury = new (
                                                                         "yottameter per square century"
                                                                       , "Ym/century²"
                                                                       , ZettameterPerSquareDecade
                                                                       , 1000.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) attometer per square decillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × femtometer per square nonillion years.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareDecillionYears = new (
                                                                               "attometer per square decillion years"
                                                                             , "am/decillion yr²"
                                                                             , FemtometerPerSquareNonillionYears
                                                                             , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) gigameter per square million years. Defined as: (1000.0)/((1000.0)*(1000.0)) × megameter per square millennium.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareMillionYears = new (
                                                                             "gigameter per square million years"
                                                                           , "Gm/Myr²"
                                                                           , MegameterPerSquareMillennium
                                                                           , 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) yoctometer per square septillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × zeptometer per square sextillion years.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareSeptillionYears = new (
       "yoctometer per square septillion years"
     , "ym/Yyr²"
     , ZeptometerPerSquareSextillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) hectometer per square trillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × dekameter per square billion years.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareTrillionYears = new (
                                                                               "hectometer per square trillion years"
                                                                             , "hm/Tyr²"
                                                                             , DekameterPerSquareBillionYears
                                                                             , 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) rontometer per square sextillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × yoctometer per square quintillion years.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareSextillionYears = new (
       "rontometer per square sextillion years"
     , "rm/Zyr²"
     , YoctometerPerSquareQuintillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) dekameter per square quadrillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × meter per square trillion years.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareQuadrillionYears = new (
       "dekameter per square quadrillion years"
     , "dam/Pyr²"
     , MeterPerSquareTrillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) exameter per square millennium. Defined as: (1000.0)/((10.0)*(10.0)) × petameter per square century.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareMillennium = new (
                                                                          "exameter per square millennium"
                                                                        , "Em/kyr²"
                                                                        , PetameterPerSquareCentury
                                                                        , 1000.0 / (10.0 * 10.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) ronnameter per square century. Defined as: (1000.0)/((10.0)*(10.0)) × yottameter per square decade.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareCentury = new (
                                                                         "ronnameter per square century"
                                                                       , "Rm/century²"
                                                                       , YottameterPerSquareDecade
                                                                       , 1000.0 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) quectometer per square quintillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × rontometer per square quadrillion years.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareQuintillionYears = new (
       "quectometer per square quintillion years"
     , "qm/Eyr²"
     , RontometerPerSquareQuadrillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) zeptometer per square nonillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × attometer per square octillion years.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareNonillionYears = new (
                                                                                "zeptometer per square nonillion years"
                                                                              , "zm/Qyr²"
                                                                              , AttometerPerSquareOctillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) megameter per square billion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × kilometer per square million years.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareBillionYears = new (
                                                                             "megameter per square billion years"
                                                                           , "Mm/Gyr²"
                                                                           , KilometerPerSquareMillionYears
                                                                           , 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) attometer per square planck-time. Defined as: (1.0/1000.0)/((5.391247E-38)*(5.391247E-38)) × femtometer per square microsecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquarePlanckTime = new (
                                                                           "attometer per square planck-time"
                                                                         , "am/tₚ²"
                                                                         , FemtometerPerSquareMicrosecond
                                                                         , 1.0 / 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square million years. Defined as: (1000.0)/((1000.0)*(1000.0)) × gigameter per square millennium.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareMillionYears = new (
                                                                             "terameter per square million years"
                                                                           , "Tm/Myr²"
                                                                           , GigameterPerSquareMillennium
                                                                           , 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) picometer per square tick. Defined as: (1.0/1000.0)/((100.0)*(100.0)) × nanometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration PicometerPerSquareTick = new (
                                                                     "picometer per square tick"
                                                                   , "pm/tick²"
                                                                   , NanometerPerSquareNanosecond
                                                                   , 1.0 / 1000.0 / (100.0 * 100.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettameter per square century. Defined as: (1000.0)/((10.0)*(10.0)) × ronnameter per square decade.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareCentury = new (
                                                                          "quettameter per square century"
                                                                        , "Qm/century²"
                                                                        , RonnameterPerSquareDecade
                                                                        , 1000.0 / (10.0 * 10.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) yoctometer per square octillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × zeptometer per square septillion years.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareOctillionYears = new (
                                                                                "yoctometer per square octillion years"
                                                                              , "ym/Ryr²"
                                                                              , ZeptometerPerSquareSeptillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) kilometer per square trillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × hectometer per square billion years.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareTrillionYears = new (
                                                                              "kilometer per square trillion years"
                                                                            , "km/Tyr²"
                                                                            , HectometerPerSquareBillionYears
                                                                            , 10.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) zettameter per square millennium. Defined as: (1000.0)/((10.0)*(10.0)) × exameter per square century.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareMillennium = new (
                                                                            "zettameter per square millennium"
                                                                          , "Zm/kyr²"
                                                                          , ExameterPerSquareCentury
                                                                          , 1000.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zeptometer per square decillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × attometer per square nonillion years.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareDecillionYears = new (
                                                                                "zeptometer per square decillion years"
                                                                              , "zm/decillion yr²"
                                                                              , AttometerPerSquareNonillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) rontometer per square septillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × yoctometer per square sextillion years.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareSeptillionYears = new (
       "rontometer per square septillion years"
     , "rm/Yyr²"
     , YoctometerPerSquareSextillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) hectometer per square quadrillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × dekameter per square trillion years.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareQuadrillionYears = new (
       "hectometer per square quadrillion years"
     , "hm/Pyr²"
     , DekameterPerSquareTrillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) gigameter per square billion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × megameter per square million years.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareBillionYears = new (
                                                                             "gigameter per square billion years"
                                                                           , "Gm/Gyr²"
                                                                           , MegameterPerSquareMillionYears
                                                                           , 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) petameter per square million years. Defined as: (1000.0)/((1000.0)*(1000.0)) × terameter per square millennium.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareMillionYears = new (
                                                                             "petameter per square million years"
                                                                           , "Pm/Myr²"
                                                                           , TerameterPerSquareMillennium
                                                                           , 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quectometer per square sextillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × rontometer per square quintillion years.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareSextillionYears = new (
       "quectometer per square sextillion years"
     , "qm/Zyr²"
     , RontometerPerSquareQuintillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) dekameter per square quintillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × meter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareQuintillionYears = new (
       "dekameter per square quintillion years"
     , "dam/Eyr²"
     , MeterPerSquareQuadrillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) yottameter per square millennium. Defined as: (1000.0)/((10.0)*(10.0)) × zettameter per square century.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareMillennium = new (
                                                                            "yottameter per square millennium"
                                                                          , "Ym/kyr²"
                                                                          , ZettameterPerSquareCentury
                                                                          , 1000.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) yoctometer per square nonillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × zeptometer per square octillion years.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareNonillionYears = new (
                                                                                "yoctometer per square nonillion years"
                                                                              , "ym/Qyr²"
                                                                              , ZeptometerPerSquareOctillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) megameter per square trillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × kilometer per square billion years.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareTrillionYears = new (
                                                                              "megameter per square trillion years"
                                                                            , "Mm/Tyr²"
                                                                            , KilometerPerSquareBillionYears
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) exameter per square million years. Defined as: (1000.0)/((1000.0)*(1000.0)) × petameter per square millennium.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareMillionYears = new (
                                                                            "exameter per square million years"
                                                                          , "Em/Myr²"
                                                                          , PetameterPerSquareMillennium
                                                                          , 1000.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) zeptometer per square planck-time. Defined as: (1.0/1000.0)/((5.391247E-38)*(5.391247E-38)) × attometer per square microsecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquarePlanckTime = new (
                                                                            "zeptometer per square planck-time"
                                                                          , "zm/tₚ²"
                                                                          , AttometerPerSquareMicrosecond
                                                                          , 1.0 / 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square billion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × gigameter per square million years.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareBillionYears = new (
                                                                             "terameter per square billion years"
                                                                           , "Tm/Gyr²"
                                                                           , GigameterPerSquareMillionYears
                                                                           , 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) rontometer per square octillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × yoctometer per square septillion years.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareOctillionYears = new (
                                                                                "rontometer per square octillion years"
                                                                              , "rm/Ryr²"
                                                                              , YoctometerPerSquareSeptillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) kilometer per square quadrillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × hectometer per square trillion years.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareQuadrillionYears = new (
       "kilometer per square quadrillion years"
     , "km/Pyr²"
     , HectometerPerSquareTrillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) ronnameter per square millennium. Defined as: (1000.0)/((10.0)*(10.0)) × yottameter per square century.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareMillennium = new (
                                                                            "ronnameter per square millennium"
                                                                          , "Rm/kyr²"
                                                                          , YottameterPerSquareCentury
                                                                          , 1000.0 / (10.0 * 10.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) quectometer per square septillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × rontometer per square sextillion years.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareSeptillionYears = new (
       "quectometer per square septillion years"
     , "qm/Yyr²"
     , RontometerPerSquareSextillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) hectometer per square quintillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × dekameter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareQuintillionYears = new (
       "hectometer per square quintillion years"
     , "hm/Eyr²"
     , DekameterPerSquareQuadrillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) dekameter per square sextillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × meter per square quintillion years.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareSextillionYears = new (
                                                                                "dekameter per square sextillion years"
                                                                              , "dam/Zyr²"
                                                                              , MeterPerSquareQuintillionYears
                                                                              , 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) yoctometer per square decillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × zeptometer per square nonillion years.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareDecillionYears = new (
                                                                                "yoctometer per square decillion years"
                                                                              , "ym/decillion yr²"
                                                                              , ZeptometerPerSquareNonillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) gigameter per square trillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × megameter per square billion years.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareTrillionYears = new (
                                                                              "gigameter per square trillion years"
                                                                            , "Gm/Tyr²"
                                                                            , MegameterPerSquareBillionYears
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) zettameter per square million years. Defined as: (1000.0)/((1000.0)*(1000.0)) × exameter per square millennium.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareMillionYears = new (
                                                                              "zettameter per square million years"
                                                                            , "Zm/Myr²"
                                                                            , ExameterPerSquareMillennium
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) femtometer per square tick. Defined as: (1.0/1000.0)/((100.0)*(100.0)) × picometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration FemtometerPerSquareTick = new (
                                                                      "femtometer per square tick"
                                                                    , "fm/tick²"
                                                                    , PicometerPerSquareNanosecond
                                                                    , 1.0 / 1000.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) petameter per square billion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × terameter per square million years.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareBillionYears = new (
                                                                             "petameter per square billion years"
                                                                           , "Pm/Gyr²"
                                                                           , TerameterPerSquareMillionYears
                                                                           , 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quettameter per square millennium. Defined as: (1000.0)/((10.0)*(10.0)) × ronnameter per square century.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareMillennium = new (
                                                                             "quettameter per square millennium"
                                                                           , "Qm/kyr²"
                                                                           , RonnameterPerSquareCentury
                                                                           , 1000.0 / (10.0 * 10.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) rontometer per square nonillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × yoctometer per square octillion years.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareNonillionYears = new (
                                                                                "rontometer per square nonillion years"
                                                                              , "rm/Qyr²"
                                                                              , YoctometerPerSquareOctillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) megameter per square quadrillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × kilometer per square trillion years.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareQuadrillionYears = new (
       "megameter per square quadrillion years"
     , "Mm/Pyr²"
     , KilometerPerSquareTrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) yottameter per square million years. Defined as: (1000.0)/((1000.0)*(1000.0)) × zettameter per square millennium.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareMillionYears = new (
                                                                              "yottameter per square million years"
                                                                            , "Ym/Myr²"
                                                                            , ZettameterPerSquareMillennium
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) quectometer per square octillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × rontometer per square septillion years.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareOctillionYears = new (
       "quectometer per square octillion years"
     , "qm/Ryr²"
     , RontometerPerSquareSeptillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) kilometer per square quintillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × hectometer per square quadrillion years.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareQuintillionYears = new (
       "kilometer per square quintillion years"
     , "km/Eyr²"
     , HectometerPerSquareQuadrillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) yoctometer per square planck-time. Defined as: (1.0/1000.0)/((5.391247E-38)*(5.391247E-38)) × zeptometer per square microsecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquarePlanckTime = new (
                                                                            "yoctometer per square planck-time"
                                                                          , "ym/tₚ²"
                                                                          , ZeptometerPerSquareMicrosecond
                                                                          , 1.0 / 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square trillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × gigameter per square billion years.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareTrillionYears = new (
                                                                              "terameter per square trillion years"
                                                                            , "Tm/Tyr²"
                                                                            , GigameterPerSquareBillionYears
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) dekameter per square septillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × meter per square sextillion years.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareSeptillionYears = new (
                                                                                "dekameter per square septillion years"
                                                                              , "dam/Yyr²"
                                                                              , MeterPerSquareSextillionYears
                                                                              , 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) hectometer per square sextillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × dekameter per square quintillion years.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareSextillionYears = new (
       "hectometer per square sextillion years"
     , "hm/Zyr²"
     , DekameterPerSquareQuintillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) exameter per square billion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × petameter per square million years.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareBillionYears = new (
                                                                            "exameter per square billion years"
                                                                          , "Em/Gyr²"
                                                                          , PetameterPerSquareMillionYears
                                                                          , 1000.0 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) rontometer per square decillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × yoctometer per square nonillion years.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareDecillionYears = new (
                                                                                "rontometer per square decillion years"
                                                                              , "rm/decillion yr²"
                                                                              , YoctometerPerSquareNonillionYears
                                                                              , 1.0 / 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) gigameter per square quadrillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × megameter per square trillion years.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareQuadrillionYears = new (
       "gigameter per square quadrillion years"
     , "Gm/Pyr²"
     , MegameterPerSquareTrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) ronnameter per square million years. Defined as: (1000.0)/((1000.0)*(1000.0)) × yottameter per square millennium.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareMillionYears = new (
                                                                              "ronnameter per square million years"
                                                                            , "Rm/Myr²"
                                                                            , YottameterPerSquareMillennium
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) petameter per square trillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × terameter per square billion years.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareTrillionYears = new (
                                                                              "petameter per square trillion years"
                                                                            , "Pm/Tyr²"
                                                                            , TerameterPerSquareBillionYears
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) zettameter per square billion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × exameter per square million years.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareBillionYears = new (
                                                                              "zettameter per square billion years"
                                                                            , "Zm/Gyr²"
                                                                            , ExameterPerSquareMillionYears
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) quectometer per square nonillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × rontometer per square octillion years.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareNonillionYears = new (
       "quectometer per square nonillion years"
     , "qm/Qyr²"
     , RontometerPerSquareOctillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) megameter per square quintillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × kilometer per square quadrillion years.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareQuintillionYears = new (
       "megameter per square quintillion years"
     , "Mm/Eyr²"
     , KilometerPerSquareQuadrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) dekameter per square octillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × meter per square septillion years.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareOctillionYears = new (
                                                                               "dekameter per square octillion years"
                                                                             , "dam/Ryr²"
                                                                             , MeterPerSquareSeptillionYears
                                                                             , 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) kilometer per square sextillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × hectometer per square quintillion years.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareSextillionYears = new (
                                                                                "kilometer per square sextillion years"
                                                                              , "km/Zyr²"
                                                                              , HectometerPerSquareQuintillionYears
                                                                              , 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) attometer per square tick. Defined as: (1.0/1000.0)/((100.0)*(100.0)) × femtometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration AttometerPerSquareTick = new (
                                                                     "attometer per square tick"
                                                                   , "am/tick²"
                                                                   , FemtometerPerSquareNanosecond
                                                                   , 1.0 / 1000.0 / (100.0 * 100.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) hectometer per square septillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × dekameter per square sextillion years.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareSeptillionYears = new (
       "hectometer per square septillion years"
     , "hm/Yyr²"
     , DekameterPerSquareSextillionYears
     , 10.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) quettameter per square million years. Defined as: (1000.0)/((1000.0)*(1000.0)) × ronnameter per square millennium.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareMillionYears = new (
                                                                               "quettameter per square million years"
                                                                             , "Qm/Myr²"
                                                                             , RonnameterPerSquareMillennium
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) rontometer per square planck-time. Defined as: (1.0/1000.0)/((5.391247E-38)*(5.391247E-38)) × yoctometer per square microsecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquarePlanckTime = new (
                                                                            "rontometer per square planck-time"
                                                                          , "rm/tₚ²"
                                                                          , YoctometerPerSquareMicrosecond
                                                                          , 1.0 / 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square quadrillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × gigameter per square trillion years.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareQuadrillionYears = new (
       "terameter per square quadrillion years"
     , "Tm/Pyr²"
     , GigameterPerSquareTrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) yottameter per square billion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × zettameter per square million years.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareBillionYears = new (
                                                                              "yottameter per square billion years"
                                                                            , "Ym/Gyr²"
                                                                            , ZettameterPerSquareMillionYears
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) exameter per square trillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × petameter per square billion years.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareTrillionYears = new (
                                                                             "exameter per square trillion years"
                                                                           , "Em/Tyr²"
                                                                           , PetameterPerSquareBillionYears
                                                                           , 1000.0 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) quectometer per square decillion years. Defined as: (1.0/1000.0)/((1000.0)*(1000.0)) × rontometer per square nonillion years.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareDecillionYears = new (
       "quectometer per square decillion years"
     , "qm/decillion yr²"
     , RontometerPerSquareNonillionYears
     , 1.0 / 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) gigameter per square quintillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × megameter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareQuintillionYears = new (
       "gigameter per square quintillion years"
     , "Gm/Eyr²"
     , MegameterPerSquareQuadrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) dekameter per square nonillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × meter per square octillion years.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareNonillionYears = new (
                                                                               "dekameter per square nonillion years"
                                                                             , "dam/Qyr²"
                                                                             , MeterPerSquareOctillionYears
                                                                             , 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) megameter per square sextillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × kilometer per square quintillion years.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareSextillionYears = new (
                                                                                "megameter per square sextillion years"
                                                                              , "Mm/Zyr²"
                                                                              , KilometerPerSquareQuintillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) hectometer per square octillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × dekameter per square septillion years.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareOctillionYears = new (
                                                                                "hectometer per square octillion years"
                                                                              , "hm/Ryr²"
                                                                              , DekameterPerSquareSeptillionYears
                                                                              , 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) kilometer per square septillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × hectometer per square sextillion years.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareSeptillionYears = new (
                                                                                "kilometer per square septillion years"
                                                                              , "km/Yyr²"
                                                                              , HectometerPerSquareSextillionYears
                                                                              , 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) petameter per square quadrillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × terameter per square trillion years.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareQuadrillionYears = new (
       "petameter per square quadrillion years"
     , "Pm/Pyr²"
     , TerameterPerSquareTrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) ronnameter per square billion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × yottameter per square million years.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareBillionYears = new (
                                                                              "ronnameter per square billion years"
                                                                            , "Rm/Gyr²"
                                                                            , YottameterPerSquareMillionYears
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) zettameter per square trillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × exameter per square billion years.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareTrillionYears = new (
                                                                               "zettameter per square trillion years"
                                                                             , "Zm/Tyr²"
                                                                             , ExameterPerSquareBillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) quectometer per square planck-time. Defined as: (1.0/1000.0)/((5.391247E-38)*(5.391247E-38)) × rontometer per square microsecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquarePlanckTime = new (
                                                                             "quectometer per square planck-time"
                                                                           , "qm/tₚ²"
                                                                           , RontometerPerSquareMicrosecond
                                                                           , 1.0
                                                                           / 1000.0
                                                                           / (5.391247E-38 * 5.391247E-38)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) terameter per square quintillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × gigameter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareQuintillionYears = new (
       "terameter per square quintillion years"
     , "Tm/Eyr²"
     , GigameterPerSquareQuadrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) zeptometer per square tick. Defined as: (1.0/1000.0)/((100.0)*(100.0)) × attometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration ZeptometerPerSquareTick = new (
                                                                      "zeptometer per square tick"
                                                                    , "zm/tick²"
                                                                    , AttometerPerSquareNanosecond
                                                                    , 1.0 / 1000.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettameter per square billion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × ronnameter per square million years.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareBillionYears = new (
                                                                               "quettameter per square billion years"
                                                                             , "Qm/Gyr²"
                                                                             , RonnameterPerSquareMillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) dekameter per square decillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × meter per square nonillion years.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareDecillionYears = new (
                                                                               "dekameter per square decillion years"
                                                                             , "dam/decillion yr²"
                                                                             , MeterPerSquareNonillionYears
                                                                             , 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) gigameter per square sextillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × megameter per square quintillion years.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareSextillionYears = new (
                                                                                "gigameter per square sextillion years"
                                                                              , "Gm/Zyr²"
                                                                              , MegameterPerSquareQuintillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) exameter per square quadrillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × petameter per square trillion years.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareQuadrillionYears = new (
                                                                                "exameter per square quadrillion years"
                                                                              , "Em/Pyr²"
                                                                              , PetameterPerSquareTrillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) yottameter per square trillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × zettameter per square billion years.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareTrillionYears = new (
                                                                               "yottameter per square trillion years"
                                                                             , "Ym/Tyr²"
                                                                             , ZettameterPerSquareBillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) hectometer per square nonillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × dekameter per square octillion years.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareNonillionYears = new (
                                                                                "hectometer per square nonillion years"
                                                                              , "hm/Qyr²"
                                                                              , DekameterPerSquareOctillionYears
                                                                              , 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) megameter per square septillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × kilometer per square sextillion years.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareSeptillionYears = new (
                                                                                "megameter per square septillion years"
                                                                              , "Mm/Yyr²"
                                                                              , KilometerPerSquareSextillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) kilometer per square octillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × hectometer per square septillion years.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareOctillionYears = new (
                                                                               "kilometer per square octillion years"
                                                                             , "km/Ryr²"
                                                                             , HectometerPerSquareSeptillionYears
                                                                             , 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) petameter per square quintillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × terameter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareQuintillionYears = new (
       "petameter per square quintillion years"
     , "Pm/Eyr²"
     , TerameterPerSquareQuadrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) zettameter per square quadrillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × exameter per square trillion years.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareQuadrillionYears = new (
       "zettameter per square quadrillion years"
     , "Zm/Pyr²"
     , ExameterPerSquareTrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) ronnameter per square trillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × yottameter per square billion years.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareTrillionYears = new (
                                                                               "ronnameter per square trillion years"
                                                                             , "Rm/Tyr²"
                                                                             , YottameterPerSquareBillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) dekameter per square planck-time. Defined as: (10.0)/((5.391247E-38)*(5.391247E-38)) × meter per square microsecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquarePlanckTime = new (
                                                                           "dekameter per square planck-time"
                                                                         , "dam/tₚ²"
                                                                         , MeterPerSquareMicrosecond
                                                                         , 10.0 / (5.391247E-38 * 5.391247E-38)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square sextillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × gigameter per square quintillion years.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareSextillionYears = new (
                                                                                "terameter per square sextillion years"
                                                                              , "Tm/Zyr²"
                                                                              , GigameterPerSquareQuintillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) hectometer per square decillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × dekameter per square nonillion years.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareDecillionYears = new (
                                                                                "hectometer per square decillion years"
                                                                              , "hm/decillion yr²"
                                                                              , DekameterPerSquareNonillionYears
                                                                              , 10.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) gigameter per square septillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × megameter per square sextillion years.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareSeptillionYears = new (
                                                                                "gigameter per square septillion years"
                                                                              , "Gm/Yyr²"
                                                                              , MegameterPerSquareSextillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) kilometer per square nonillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × hectometer per square octillion years.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareNonillionYears = new (
                                                                               "kilometer per square nonillion years"
                                                                             , "km/Qyr²"
                                                                             , HectometerPerSquareOctillionYears
                                                                             , 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) megameter per square octillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × kilometer per square septillion years.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareOctillionYears = new (
                                                                               "megameter per square octillion years"
                                                                             , "Mm/Ryr²"
                                                                             , KilometerPerSquareSeptillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) exameter per square quintillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × petameter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareQuintillionYears = new (
                                                                                "exameter per square quintillion years"
                                                                              , "Em/Eyr²"
                                                                              , PetameterPerSquareQuadrillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) yoctometer per square tick. Defined as: (1.0/1000.0)/((100.0)*(100.0)) × zeptometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration YoctometerPerSquareTick = new (
                                                                      "yoctometer per square tick"
                                                                    , "ym/tick²"
                                                                    , ZeptometerPerSquareNanosecond
                                                                    , 1.0 / 1000.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettameter per square trillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × ronnameter per square billion years.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareTrillionYears = new (
                                                                                "quettameter per square trillion years"
                                                                              , "Qm/Tyr²"
                                                                              , RonnameterPerSquareBillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) yottameter per square quadrillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × zettameter per square trillion years.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareQuadrillionYears = new (
       "yottameter per square quadrillion years"
     , "Ym/Pyr²"
     , ZettameterPerSquareTrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) petameter per square sextillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × terameter per square quintillion years.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareSextillionYears = new (
                                                                                "petameter per square sextillion years"
                                                                              , "Pm/Zyr²"
                                                                              , TerameterPerSquareQuintillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) hectometer per square planck-time. Defined as: (10.0)/((5.391247E-38)*(5.391247E-38)) × dekameter per square microsecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquarePlanckTime = new (
                                                                            "hectometer per square planck-time"
                                                                          , "hm/tₚ²"
                                                                          , DekameterPerSquareMicrosecond
                                                                          , 10.0 / (5.391247E-38 * 5.391247E-38)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square septillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × gigameter per square sextillion years.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareSeptillionYears = new (
                                                                                "terameter per square septillion years"
                                                                              , "Tm/Yyr²"
                                                                              , GigameterPerSquareSextillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) zettameter per square quintillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × exameter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareQuintillionYears = new (
       "zettameter per square quintillion years"
     , "Zm/Eyr²"
     , ExameterPerSquareQuadrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) kilometer per square decillion years. Defined as: (10.0)/((1000.0)*(1000.0)) × hectometer per square nonillion years.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareDecillionYears = new (
                                                                               "kilometer per square decillion years"
                                                                             , "km/decillion yr²"
                                                                             , HectometerPerSquareNonillionYears
                                                                             , 10.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) gigameter per square octillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × megameter per square septillion years.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareOctillionYears = new (
                                                                               "gigameter per square octillion years"
                                                                             , "Gm/Ryr²"
                                                                             , MegameterPerSquareSeptillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) ronnameter per square quadrillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × yottameter per square trillion years.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareQuadrillionYears = new (
       "ronnameter per square quadrillion years"
     , "Rm/Pyr²"
     , YottameterPerSquareTrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) megameter per square nonillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × kilometer per square octillion years.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareNonillionYears = new (
                                                                               "megameter per square nonillion years"
                                                                             , "Mm/Qyr²"
                                                                             , KilometerPerSquareOctillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) exameter per square sextillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × petameter per square quintillion years.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareSextillionYears = new (
                                                                               "exameter per square sextillion years"
                                                                             , "Em/Zyr²"
                                                                             , PetameterPerSquareQuintillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) yottameter per square quintillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × zettameter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareQuintillionYears = new (
       "yottameter per square quintillion years"
     , "Ym/Eyr²"
     , ZettameterPerSquareQuadrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) rontometer per square tick. Defined as: (1.0/1000.0)/((100.0)*(100.0)) × yoctometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration RontometerPerSquareTick = new (
                                                                      "rontometer per square tick"
                                                                    , "rm/tick²"
                                                                    , YoctometerPerSquareNanosecond
                                                                    , 1.0 / 1000.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) petameter per square septillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × terameter per square sextillion years.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareSeptillionYears = new (
                                                                                "petameter per square septillion years"
                                                                              , "Pm/Yyr²"
                                                                              , TerameterPerSquareSextillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) quettameter per square quadrillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × ronnameter per square trillion years.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareQuadrillionYears = new (
       "quettameter per square quadrillion years"
     , "Qm/Pyr²"
     , RonnameterPerSquareTrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) kilometer per square planck-time. Defined as: (10.0)/((5.391247E-38)*(5.391247E-38)) × hectometer per square microsecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquarePlanckTime = new (
                                                                           "kilometer per square planck-time"
                                                                         , "km/tₚ²"
                                                                         , HectometerPerSquareMicrosecond
                                                                         , 10.0 / (5.391247E-38 * 5.391247E-38)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square octillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × gigameter per square septillion years.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareOctillionYears = new (
                                                                               "terameter per square octillion years"
                                                                             , "Tm/Ryr²"
                                                                             , GigameterPerSquareSeptillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) megameter per square decillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × kilometer per square nonillion years.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareDecillionYears = new (
                                                                               "megameter per square decillion years"
                                                                             , "Mm/decillion yr²"
                                                                             , KilometerPerSquareNonillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) gigameter per square nonillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × megameter per square octillion years.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareNonillionYears = new (
                                                                               "gigameter per square nonillion years"
                                                                             , "Gm/Qyr²"
                                                                             , MegameterPerSquareOctillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) zettameter per square sextillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × exameter per square quintillion years.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareSextillionYears = new (
       "zettameter per square sextillion years"
     , "Zm/Zyr²"
     , ExameterPerSquareQuintillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) ronnameter per square quintillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × yottameter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareQuintillionYears = new (
       "ronnameter per square quintillion years"
     , "Rm/Eyr²"
     , YottameterPerSquareQuadrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) exameter per square septillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × petameter per square sextillion years.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareSeptillionYears = new (
                                                                               "exameter per square septillion years"
                                                                             , "Em/Yyr²"
                                                                             , PetameterPerSquareSextillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) petameter per square octillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × terameter per square septillion years.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareOctillionYears = new (
                                                                               "petameter per square octillion years"
                                                                             , "Pm/Ryr²"
                                                                             , TerameterPerSquareSeptillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) yottameter per square sextillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × zettameter per square quintillion years.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareSextillionYears = new (
       "yottameter per square sextillion years"
     , "Ym/Zyr²"
     , ZettameterPerSquareQuintillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) megameter per square planck-time. Defined as: (1000.0)/((5.391247E-38)*(5.391247E-38)) × kilometer per square microsecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquarePlanckTime = new (
                                                                           "megameter per square planck-time"
                                                                         , "Mm/tₚ²"
                                                                         , KilometerPerSquareMicrosecond
                                                                         , 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square nonillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × gigameter per square octillion years.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareNonillionYears = new (
                                                                               "terameter per square nonillion years"
                                                                             , "Tm/Qyr²"
                                                                             , GigameterPerSquareOctillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) gigameter per square decillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × megameter per square nonillion years.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareDecillionYears = new (
                                                                               "gigameter per square decillion years"
                                                                             , "Gm/decillion yr²"
                                                                             , MegameterPerSquareNonillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) quectometer per square tick. Defined as: (1.0/1000.0)/((100.0)*(100.0)) × rontometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration QuectometerPerSquareTick = new (
                                                                       "quectometer per square tick"
                                                                     , "qm/tick²"
                                                                     , RontometerPerSquareNanosecond
                                                                     , 1.0 / 1000.0 / (100.0 * 100.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) quettameter per square quintillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × ronnameter per square quadrillion years.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareQuintillionYears = new (
       "quettameter per square quintillion years"
     , "Qm/Eyr²"
     , RonnameterPerSquareQuadrillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) zettameter per square septillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × exameter per square sextillion years.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareSeptillionYears = new (
       "zettameter per square septillion years"
     , "Zm/Yyr²"
     , ExameterPerSquareSextillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) exameter per square octillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × petameter per square septillion years.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareOctillionYears = new (
                                                                              "exameter per square octillion years"
                                                                            , "Em/Ryr²"
                                                                            , PetameterPerSquareSeptillionYears
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) ronnameter per square sextillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × yottameter per square quintillion years.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareSextillionYears = new (
       "ronnameter per square sextillion years"
     , "Rm/Zyr²"
     , YottameterPerSquareQuintillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) petameter per square nonillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × terameter per square octillion years.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareNonillionYears = new (
                                                                               "petameter per square nonillion years"
                                                                             , "Pm/Qyr²"
                                                                             , TerameterPerSquareOctillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) gigameter per square planck-time. Defined as: (1000.0)/((5.391247E-38)*(5.391247E-38)) × megameter per square microsecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquarePlanckTime = new (
                                                                           "gigameter per square planck-time"
                                                                         , "Gm/tₚ²"
                                                                         , MegameterPerSquareMicrosecond
                                                                         , 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) terameter per square decillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × gigameter per square nonillion years.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareDecillionYears = new (
                                                                               "terameter per square decillion years"
                                                                             , "Tm/decillion yr²"
                                                                             , GigameterPerSquareNonillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) yottameter per square septillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × zettameter per square sextillion years.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareSeptillionYears = new (
       "yottameter per square septillion years"
     , "Ym/Yyr²"
     , ZettameterPerSquareSextillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) dekameter per square tick. Defined as: (10.0)/((100.0)*(100.0)) × meter per square nanosecond.
   /// </summary>
   public static readonly Acceleration DekameterPerSquareTick = new (
                                                                     "dekameter per square tick"
                                                                   , "dam/tick²"
                                                                   , MeterPerSquareNanosecond
                                                                   , 10.0 / (100.0 * 100.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettameter per square sextillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × ronnameter per square quintillion years.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareSextillionYears = new (
       "quettameter per square sextillion years"
     , "Qm/Zyr²"
     , RonnameterPerSquareQuintillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) zettameter per square octillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × exameter per square septillion years.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareOctillionYears = new (
                                                                                "zettameter per square octillion years"
                                                                              , "Zm/Ryr²"
                                                                              , ExameterPerSquareSeptillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) exameter per square nonillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × petameter per square octillion years.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareNonillionYears = new (
                                                                              "exameter per square nonillion years"
                                                                            , "Em/Qyr²"
                                                                            , PetameterPerSquareOctillionYears
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) petameter per square decillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × terameter per square nonillion years.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareDecillionYears = new (
                                                                               "petameter per square decillion years"
                                                                             , "Pm/decillion yr²"
                                                                             , TerameterPerSquareNonillionYears
                                                                             , 1000.0 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) ronnameter per square septillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × yottameter per square sextillion years.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareSeptillionYears = new (
       "ronnameter per square septillion years"
     , "Rm/Yyr²"
     , YottameterPerSquareSextillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) terameter per square planck-time. Defined as: (1000.0)/((5.391247E-38)*(5.391247E-38)) × gigameter per square microsecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquarePlanckTime = new (
                                                                           "terameter per square planck-time"
                                                                         , "Tm/tₚ²"
                                                                         , GigameterPerSquareMicrosecond
                                                                         , 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) yottameter per square octillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × zettameter per square septillion years.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareOctillionYears = new (
                                                                                "yottameter per square octillion years"
                                                                              , "Ym/Ryr²"
                                                                              , ZettameterPerSquareSeptillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) zettameter per square nonillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × exameter per square octillion years.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareNonillionYears = new (
                                                                                "zettameter per square nonillion years"
                                                                              , "Zm/Qyr²"
                                                                              , ExameterPerSquareOctillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) hectometer per square tick. Defined as: (10.0)/((100.0)*(100.0)) × dekameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration HectometerPerSquareTick = new (
                                                                      "hectometer per square tick"
                                                                    , "hm/tick²"
                                                                    , DekameterPerSquareNanosecond
                                                                    , 10.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettameter per square septillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × ronnameter per square sextillion years.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareSeptillionYears = new (
       "quettameter per square septillion years"
     , "Qm/Yyr²"
     , RonnameterPerSquareSextillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) exameter per square decillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × petameter per square nonillion years.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareDecillionYears = new (
                                                                              "exameter per square decillion years"
                                                                            , "Em/decillion yr²"
                                                                            , PetameterPerSquareNonillionYears
                                                                            , 1000.0 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) petameter per square planck-time. Defined as: (1000.0)/((5.391247E-38)*(5.391247E-38)) × terameter per square microsecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquarePlanckTime = new (
                                                                           "petameter per square planck-time"
                                                                         , "Pm/tₚ²"
                                                                         , TerameterPerSquareMicrosecond
                                                                         , 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) ronnameter per square octillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × yottameter per square septillion years.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareOctillionYears = new (
                                                                                "ronnameter per square octillion years"
                                                                              , "Rm/Ryr²"
                                                                              , YottameterPerSquareSeptillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) yottameter per square nonillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × zettameter per square octillion years.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareNonillionYears = new (
                                                                                "yottameter per square nonillion years"
                                                                              , "Ym/Qyr²"
                                                                              , ZettameterPerSquareOctillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) zettameter per square decillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × exameter per square nonillion years.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareDecillionYears = new (
                                                                                "zettameter per square decillion years"
                                                                              , "Zm/decillion yr²"
                                                                              , ExameterPerSquareNonillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) exameter per square planck-time. Defined as: (1000.0)/((5.391247E-38)*(5.391247E-38)) × petameter per square microsecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquarePlanckTime = new (
                                                                          "exameter per square planck-time"
                                                                        , "Em/tₚ²"
                                                                        , PetameterPerSquareMicrosecond
                                                                        , 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) kilometer per square tick. Defined as: (10.0)/((100.0)*(100.0)) × hectometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration KilometerPerSquareTick = new (
                                                                     "kilometer per square tick"
                                                                   , "km/tick²"
                                                                   , HectometerPerSquareNanosecond
                                                                   , 10.0 / (100.0 * 100.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettameter per square octillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × ronnameter per square septillion years.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareOctillionYears = new (
       "quettameter per square octillion years"
     , "Qm/Ryr²"
     , RonnameterPerSquareSeptillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) ronnameter per square nonillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × yottameter per square octillion years.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareNonillionYears = new (
                                                                                "ronnameter per square nonillion years"
                                                                              , "Rm/Qyr²"
                                                                              , YottameterPerSquareOctillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) yottameter per square decillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × zettameter per square nonillion years.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareDecillionYears = new (
                                                                                "yottameter per square decillion years"
                                                                              , "Ym/decillion yr²"
                                                                              , ZettameterPerSquareNonillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) zettameter per square planck-time. Defined as: (1000.0)/((5.391247E-38)*(5.391247E-38)) × exameter per square microsecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquarePlanckTime = new (
                                                                            "zettameter per square planck-time"
                                                                          , "Zm/tₚ²"
                                                                          , ExameterPerSquareMicrosecond
                                                                          , 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) megameter per square tick. Defined as: (1000.0)/((100.0)*(100.0)) × kilometer per square nanosecond.
   /// </summary>
   public static readonly Acceleration MegameterPerSquareTick = new (
                                                                     "megameter per square tick"
                                                                   , "Mm/tick²"
                                                                   , KilometerPerSquareNanosecond
                                                                   , 1000.0 / (100.0 * 100.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettameter per square nonillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × ronnameter per square octillion years.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareNonillionYears = new (
       "quettameter per square nonillion years"
     , "Qm/Qyr²"
     , RonnameterPerSquareOctillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) ronnameter per square decillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × yottameter per square nonillion years.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareDecillionYears = new (
                                                                                "ronnameter per square decillion years"
                                                                              , "Rm/decillion yr²"
                                                                              , YottameterPerSquareNonillionYears
                                                                              , 1000.0 / (1000.0 * 1000.0)
                                                                              , 0
                                                                               );

   /// <summary>
   /// A(n) yottameter per square planck-time. Defined as: (1000.0)/((5.391247E-38)*(5.391247E-38)) × zettameter per square microsecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquarePlanckTime = new (
                                                                            "yottameter per square planck-time"
                                                                          , "Ym/tₚ²"
                                                                          , ZettameterPerSquareMicrosecond
                                                                          , 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) gigameter per square tick. Defined as: (1000.0)/((100.0)*(100.0)) × megameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration GigameterPerSquareTick = new (
                                                                     "gigameter per square tick"
                                                                   , "Gm/tick²"
                                                                   , MegameterPerSquareNanosecond
                                                                   , 1000.0 / (100.0 * 100.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettameter per square decillion years. Defined as: (1000.0)/((1000.0)*(1000.0)) × ronnameter per square nonillion years.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareDecillionYears = new (
       "quettameter per square decillion years"
     , "Qm/decillion yr²"
     , RonnameterPerSquareNonillionYears
     , 1000.0 / (1000.0 * 1000.0)
     , 0
      );

   /// <summary>
   /// A(n) ronnameter per square planck-time. Defined as: (1000.0)/((5.391247E-38)*(5.391247E-38)) × yottameter per square microsecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquarePlanckTime = new (
                                                                            "ronnameter per square planck-time"
                                                                          , "Rm/tₚ²"
                                                                          , YottameterPerSquareMicrosecond
                                                                          , 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) terameter per square tick. Defined as: (1000.0)/((100.0)*(100.0)) × gigameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration TerameterPerSquareTick = new (
                                                                     "terameter per square tick"
                                                                   , "Tm/tick²"
                                                                   , GigameterPerSquareNanosecond
                                                                   , 1000.0 / (100.0 * 100.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettameter per square planck-time. Defined as: (1000.0)/((5.391247E-38)*(5.391247E-38)) × ronnameter per square microsecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquarePlanckTime = new (
                                                                             "quettameter per square planck-time"
                                                                           , "Qm/tₚ²"
                                                                           , RonnameterPerSquareMicrosecond
                                                                           , 1000.0 / (5.391247E-38 * 5.391247E-38)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) petameter per square tick. Defined as: (1000.0)/((100.0)*(100.0)) × terameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration PetameterPerSquareTick = new (
                                                                     "petameter per square tick"
                                                                   , "Pm/tick²"
                                                                   , TerameterPerSquareNanosecond
                                                                   , 1000.0 / (100.0 * 100.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exameter per square tick. Defined as: (1000.0)/((100.0)*(100.0)) × petameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration ExameterPerSquareTick = new (
                                                                    "exameter per square tick"
                                                                  , "Em/tick²"
                                                                  , PetameterPerSquareNanosecond
                                                                  , 1000.0 / (100.0 * 100.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettameter per square tick. Defined as: (1000.0)/((100.0)*(100.0)) × exameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration ZettameterPerSquareTick = new (
                                                                      "zettameter per square tick"
                                                                    , "Zm/tick²"
                                                                    , ExameterPerSquareNanosecond
                                                                    , 1000.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yottameter per square tick. Defined as: (1000.0)/((100.0)*(100.0)) × zettameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration YottameterPerSquareTick = new (
                                                                      "yottameter per square tick"
                                                                    , "Ym/tick²"
                                                                    , ZettameterPerSquareNanosecond
                                                                    , 1000.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnameter per square tick. Defined as: (1000.0)/((100.0)*(100.0)) × yottameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration RonnameterPerSquareTick = new (
                                                                      "ronnameter per square tick"
                                                                    , "Rm/tick²"
                                                                    , YottameterPerSquareNanosecond
                                                                    , 1000.0 / (100.0 * 100.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettameter per square tick. Defined as: (1000.0)/((100.0)*(100.0)) × ronnameter per square nanosecond.
   /// </summary>
   public static readonly Acceleration QuettameterPerSquareTick = new (
                                                                       "quettameter per square tick"
                                                                     , "Qm/tick²"
                                                                     , RonnameterPerSquareNanosecond
                                                                     , 1000.0 / (100.0 * 100.0)
                                                                     , 0
                                                                      );
}
