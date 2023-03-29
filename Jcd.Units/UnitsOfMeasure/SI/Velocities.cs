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
/// International System of Units for measuring Velocity.
/// </summary>
public class Velocities : UnitOfMeasureEnumeration<Velocities, Velocity>
{
   /// <summary>
   /// A(n) meter per second.
   /// </summary>
   public static readonly Velocity MeterPerSecond = new ("meter per second", "m/s");

   /// <summary>
   /// A(n) meter per decisecond. Defined as: ((1.0)/(1.0/10.0)) × meter per second + (0).
   /// </summary>
   public static readonly Velocity MeterPerDecisecond = new (
                                                             "meter per decisecond"
                                                           , "m/ds"
                                                           , MeterPerSecond
                                                           , 1.0 / (1.0 / 10.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) decimeter per second. Defined as: ((1.0/10.0)/(1.0)) × meter per second + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerSecond = new (
                                                             "decimeter per second"
                                                           , "dm/s"
                                                           , MeterPerSecond
                                                           , 1.0 / 10.0 / 1.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per centisecond. Defined as: ((1.0)/(1.0/10.0)) × meter per decisecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerCentisecond =
            new ("meter per centisecond", "m/cs", MeterPerDecisecond, 1.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) decimeter per decisecond. Defined as: ((1.0/10.0)/(1.0/10.0)) × meter per second + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerDecisecond = new (
                                                                 "decimeter per decisecond"
                                                               , "dm/ds"
                                                               , MeterPerSecond
                                                               , 1.0 / 10.0 / (1.0 / 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) centimeter per second. Defined as: ((1.0/10.0)/(1.0)) × decimeter per second + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerSecond =
            new ("centimeter per second", "cm/s", DecimeterPerSecond, 1.0 / 10.0 / 1.0, 0);

   /// <summary>
   /// A(n) meter per millisecond. Defined as: ((1.0)/(1.0/10.0)) × meter per centisecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerMillisecond =
            new ("meter per millisecond", "m/ms", MeterPerCentisecond, 1.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) decimeter per centisecond. Defined as: ((1.0/10.0)/(1.0/10.0)) × meter per decisecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerCentisecond = new (
                                                                  "decimeter per centisecond"
                                                                , "dm/cs"
                                                                , MeterPerDecisecond
                                                                , 1.0 / 10.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) centimeter per decisecond. Defined as: ((1.0/10.0)/(1.0/10.0)) × decimeter per second + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerDecisecond = new (
                                                                  "centimeter per decisecond"
                                                                , "cm/ds"
                                                                , DecimeterPerSecond
                                                                , 1.0 / 10.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) millimeter per second. Defined as: ((1.0/10.0)/(1.0)) × centimeter per second + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerSecond =
            new ("millimeter per second", "mm/s", CentimeterPerSecond, 1.0 / 10.0 / 1.0, 0);

   /// <summary>
   /// A(n) meter per microsecond. Defined as: ((1.0)/(1.0/1000.0)) × meter per millisecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerMicrosecond =
            new ("meter per microsecond", "m/μs", MeterPerMillisecond, 1.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) decimeter per millisecond. Defined as: ((1.0/10.0)/(1.0/10.0)) × meter per centisecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerMillisecond = new (
                                                                  "decimeter per millisecond"
                                                                , "dm/ms"
                                                                , MeterPerCentisecond
                                                                , 1.0 / 10.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) centimeter per centisecond. Defined as: ((1.0/10.0)/(1.0/10.0)) × decimeter per decisecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerCentisecond = new (
                                                                   "centimeter per centisecond"
                                                                 , "cm/cs"
                                                                 , DecimeterPerDecisecond
                                                                 , 1.0 / 10.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) millimeter per decisecond. Defined as: ((1.0/10.0)/(1.0/10.0)) × centimeter per second + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerDecisecond = new (
                                                                  "millimeter per decisecond"
                                                                , "mm/ds"
                                                                , CentimeterPerSecond
                                                                , 1.0 / 10.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) micrometer per second. Defined as: ((1.0/1000.0)/(1.0)) × millimeter per second + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerSecond =
            new ("micrometer per second", "μm/s", MillimeterPerSecond, 1.0 / 1000.0 / 1.0, 0);

   /// <summary>
   /// A(n) meter per nanosecond. Defined as: ((1.0)/(1.0/1000.0)) × meter per microsecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerNanosecond = new (
                                                             "meter per nanosecond"
                                                           , "m/ns"
                                                           , MeterPerMicrosecond
                                                           , 1.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) decimeter per microsecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × meter per millisecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerMicrosecond = new (
                                                                  "decimeter per microsecond"
                                                                , "dm/μs"
                                                                , MeterPerMillisecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) centimeter per millisecond. Defined as: ((1.0/10.0)/(1.0/10.0)) × decimeter per centisecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerMillisecond = new (
                                                                   "centimeter per millisecond"
                                                                 , "cm/ms"
                                                                 , DecimeterPerCentisecond
                                                                 , 1.0 / 10.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) millimeter per centisecond. Defined as: ((1.0/10.0)/(1.0/10.0)) × centimeter per decisecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerCentisecond = new (
                                                                   "millimeter per centisecond"
                                                                 , "mm/cs"
                                                                 , CentimeterPerDecisecond
                                                                 , 1.0 / 10.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) micrometer per decisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × millimeter per second + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerDecisecond = new (
                                                                  "micrometer per decisecond"
                                                                , "μm/ds"
                                                                , MillimeterPerSecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) nanometer per second. Defined as: ((1.0/1000.0)/(1.0)) × micrometer per second + (0).
   /// </summary>
   public static readonly Velocity NanometerPerSecond = new (
                                                             "nanometer per second"
                                                           , "nm/s"
                                                           , MicrometerPerSecond
                                                           , 1.0 / 1000.0 / 1.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per picosecond. Defined as: ((1.0)/(1.0/1000.0)) × meter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerPicosecond = new (
                                                             "meter per picosecond"
                                                           , "m/ps"
                                                           , MeterPerNanosecond
                                                           , 1.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) decimeter per nanosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × meter per microsecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerNanosecond = new (
                                                                 "decimeter per nanosecond"
                                                               , "dm/ns"
                                                               , MeterPerMicrosecond
                                                               , 1.0 / 10.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) centimeter per microsecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × decimeter per millisecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerMicrosecond = new (
                                                                   "centimeter per microsecond"
                                                                 , "cm/μs"
                                                                 , DecimeterPerMillisecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) millimeter per millisecond. Defined as: ((1.0/10.0)/(1.0/10.0)) × centimeter per centisecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerMillisecond = new (
                                                                   "millimeter per millisecond"
                                                                 , "mm/ms"
                                                                 , CentimeterPerCentisecond
                                                                 , 1.0 / 10.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) micrometer per centisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × millimeter per decisecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerCentisecond = new (
                                                                   "micrometer per centisecond"
                                                                 , "μm/cs"
                                                                 , MillimeterPerDecisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nanometer per decisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × micrometer per second + (0).
   /// </summary>
   public static readonly Velocity NanometerPerDecisecond = new (
                                                                 "nanometer per decisecond"
                                                               , "nm/ds"
                                                               , MicrometerPerSecond
                                                               , 1.0 / 1000.0 / (1.0 / 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) picometer per second. Defined as: ((1.0/1000.0)/(1.0)) × nanometer per second + (0).
   /// </summary>
   public static readonly Velocity PicometerPerSecond = new (
                                                             "picometer per second"
                                                           , "pm/s"
                                                           , NanometerPerSecond
                                                           , 1.0 / 1000.0 / 1.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per femtosecond. Defined as: ((1.0)/(1.0/1000.0)) × meter per picosecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerFemtosecond =
            new ("meter per femtosecond", "m/fs", MeterPerPicosecond, 1.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) decimeter per picosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × meter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerPicosecond = new (
                                                                 "decimeter per picosecond"
                                                               , "dm/ps"
                                                               , MeterPerNanosecond
                                                               , 1.0 / 10.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) centimeter per nanosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × decimeter per microsecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerNanosecond = new (
                                                                  "centimeter per nanosecond"
                                                                , "cm/ns"
                                                                , DecimeterPerMicrosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) millimeter per microsecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × centimeter per millisecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerMicrosecond = new (
                                                                   "millimeter per microsecond"
                                                                 , "mm/μs"
                                                                 , CentimeterPerMillisecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) micrometer per millisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × millimeter per centisecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerMillisecond = new (
                                                                   "micrometer per millisecond"
                                                                 , "μm/ms"
                                                                 , MillimeterPerCentisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nanometer per centisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × micrometer per decisecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerCentisecond = new (
                                                                  "nanometer per centisecond"
                                                                , "nm/cs"
                                                                , MicrometerPerDecisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) picometer per decisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × nanometer per second + (0).
   /// </summary>
   public static readonly Velocity PicometerPerDecisecond = new (
                                                                 "picometer per decisecond"
                                                               , "pm/ds"
                                                               , NanometerPerSecond
                                                               , 1.0 / 1000.0 / (1.0 / 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) femtometer per second. Defined as: ((1.0/1000.0)/(1.0)) × picometer per second + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerSecond =
            new ("femtometer per second", "fm/s", PicometerPerSecond, 1.0 / 1000.0 / 1.0, 0);

   /// <summary>
   /// A(n) meter per attosecond. Defined as: ((1.0)/(1.0/1000.0)) × meter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerAttosecond = new (
                                                             "meter per attosecond"
                                                           , "m/as"
                                                           , MeterPerFemtosecond
                                                           , 1.0 / (1.0 / 1000.0)
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) decimeter per femtosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × meter per picosecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerFemtosecond = new (
                                                                  "decimeter per femtosecond"
                                                                , "dm/fs"
                                                                , MeterPerPicosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) centimeter per picosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × decimeter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerPicosecond = new (
                                                                  "centimeter per picosecond"
                                                                , "cm/ps"
                                                                , DecimeterPerNanosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) millimeter per nanosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × centimeter per microsecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerNanosecond = new (
                                                                  "millimeter per nanosecond"
                                                                , "mm/ns"
                                                                , CentimeterPerMicrosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) micrometer per microsecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × millimeter per millisecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerMicrosecond = new (
                                                                   "micrometer per microsecond"
                                                                 , "μm/μs"
                                                                 , MillimeterPerMillisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nanometer per millisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × micrometer per centisecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerMillisecond = new (
                                                                  "nanometer per millisecond"
                                                                , "nm/ms"
                                                                , MicrometerPerCentisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) picometer per centisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × nanometer per decisecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerCentisecond = new (
                                                                  "picometer per centisecond"
                                                                , "pm/cs"
                                                                , NanometerPerDecisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) femtometer per decisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × picometer per second + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerDecisecond = new (
                                                                  "femtometer per decisecond"
                                                                , "fm/ds"
                                                                , PicometerPerSecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) attometer per second. Defined as: ((1.0/1000.0)/(1.0)) × femtometer per second + (0).
   /// </summary>
   public static readonly Velocity AttometerPerSecond = new (
                                                             "attometer per second"
                                                           , "am/s"
                                                           , FemtometerPerSecond
                                                           , 1.0 / 1000.0 / 1.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per zeptosecond. Defined as: ((1.0)/(1.0/1000.0)) × meter per attosecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerZeptosecond =
            new ("meter per zeptosecond", "m/zs", MeterPerAttosecond, 1.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) decimeter per attosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × meter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerAttosecond = new (
                                                                 "decimeter per attosecond"
                                                               , "dm/as"
                                                               , MeterPerFemtosecond
                                                               , 1.0 / 10.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) centimeter per femtosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × decimeter per picosecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerFemtosecond = new (
                                                                   "centimeter per femtosecond"
                                                                 , "cm/fs"
                                                                 , DecimeterPerPicosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) millimeter per picosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × centimeter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerPicosecond = new (
                                                                  "millimeter per picosecond"
                                                                , "mm/ps"
                                                                , CentimeterPerNanosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) micrometer per nanosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × millimeter per microsecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerNanosecond = new (
                                                                  "micrometer per nanosecond"
                                                                , "μm/ns"
                                                                , MillimeterPerMicrosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) nanometer per microsecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × micrometer per millisecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerMicrosecond = new (
                                                                  "nanometer per microsecond"
                                                                , "nm/μs"
                                                                , MicrometerPerMillisecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) picometer per millisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × nanometer per centisecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerMillisecond = new (
                                                                  "picometer per millisecond"
                                                                , "pm/ms"
                                                                , NanometerPerCentisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) femtometer per centisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × picometer per decisecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerCentisecond = new (
                                                                   "femtometer per centisecond"
                                                                 , "fm/cs"
                                                                 , PicometerPerDecisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attometer per decisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × femtometer per second + (0).
   /// </summary>
   public static readonly Velocity AttometerPerDecisecond = new (
                                                                 "attometer per decisecond"
                                                               , "am/ds"
                                                               , FemtometerPerSecond
                                                               , 1.0 / 1000.0 / (1.0 / 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) zeptometer per second. Defined as: ((1.0/1000.0)/(1.0)) × attometer per second + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerSecond =
            new ("zeptometer per second", "zm/s", AttometerPerSecond, 1.0 / 1000.0 / 1.0, 0);

   /// <summary>
   /// A(n) meter per yoctosecond. Defined as: ((1.0)/(1.0/1000.0)) × meter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerYoctosecond =
            new ("meter per yoctosecond", "m/ys", MeterPerZeptosecond, 1.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) decimeter per zeptosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × meter per attosecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerZeptosecond = new (
                                                                  "decimeter per zeptosecond"
                                                                , "dm/zs"
                                                                , MeterPerAttosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) centimeter per attosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × decimeter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerAttosecond = new (
                                                                  "centimeter per attosecond"
                                                                , "cm/as"
                                                                , DecimeterPerFemtosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) millimeter per femtosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × centimeter per picosecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerFemtosecond = new (
                                                                   "millimeter per femtosecond"
                                                                 , "mm/fs"
                                                                 , CentimeterPerPicosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) micrometer per picosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × millimeter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerPicosecond = new (
                                                                  "micrometer per picosecond"
                                                                , "μm/ps"
                                                                , MillimeterPerNanosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) nanometer per nanosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × micrometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerNanosecond = new (
                                                                 "nanometer per nanosecond"
                                                               , "nm/ns"
                                                               , MicrometerPerMicrosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) picometer per microsecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × nanometer per millisecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerMicrosecond = new (
                                                                  "picometer per microsecond"
                                                                , "pm/μs"
                                                                , NanometerPerMillisecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) femtometer per millisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × picometer per centisecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerMillisecond = new (
                                                                   "femtometer per millisecond"
                                                                 , "fm/ms"
                                                                 , PicometerPerCentisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attometer per centisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × femtometer per decisecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerCentisecond = new (
                                                                  "attometer per centisecond"
                                                                , "am/cs"
                                                                , FemtometerPerDecisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zeptometer per decisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × attometer per second + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerDecisecond = new (
                                                                  "zeptometer per decisecond"
                                                                , "zm/ds"
                                                                , AttometerPerSecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yoctometer per second. Defined as: ((1.0/1000.0)/(1.0)) × zeptometer per second + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerSecond =
            new ("yoctometer per second", "ym/s", ZeptometerPerSecond, 1.0 / 1000.0 / 1.0, 0);

   /// <summary>
   /// A(n) meter per rontosecond. Defined as: ((1.0)/(1.0/1000.0)) × meter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerRontosecond =
            new ("meter per rontosecond", "m/rs", MeterPerYoctosecond, 1.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) decimeter per yoctosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × meter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerYoctosecond = new (
                                                                  "decimeter per yoctosecond"
                                                                , "dm/ys"
                                                                , MeterPerZeptosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) centimeter per zeptosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × decimeter per attosecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerZeptosecond = new (
                                                                   "centimeter per zeptosecond"
                                                                 , "cm/zs"
                                                                 , DecimeterPerAttosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) millimeter per attosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × centimeter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerAttosecond = new (
                                                                  "millimeter per attosecond"
                                                                , "mm/as"
                                                                , CentimeterPerFemtosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) micrometer per femtosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × millimeter per picosecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerFemtosecond = new (
                                                                   "micrometer per femtosecond"
                                                                 , "μm/fs"
                                                                 , MillimeterPerPicosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nanometer per picosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × micrometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerPicosecond = new (
                                                                 "nanometer per picosecond"
                                                               , "nm/ps"
                                                               , MicrometerPerNanosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) picometer per nanosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × nanometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerNanosecond = new (
                                                                 "picometer per nanosecond"
                                                               , "pm/ns"
                                                               , NanometerPerMicrosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) femtometer per microsecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × picometer per millisecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerMicrosecond = new (
                                                                   "femtometer per microsecond"
                                                                 , "fm/μs"
                                                                 , PicometerPerMillisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attometer per millisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × femtometer per centisecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerMillisecond = new (
                                                                  "attometer per millisecond"
                                                                , "am/ms"
                                                                , FemtometerPerCentisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zeptometer per centisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × attometer per decisecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerCentisecond = new (
                                                                   "zeptometer per centisecond"
                                                                 , "zm/cs"
                                                                 , AttometerPerDecisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yoctometer per decisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × zeptometer per second + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerDecisecond = new (
                                                                  "yoctometer per decisecond"
                                                                , "ym/ds"
                                                                , ZeptometerPerSecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) rontometer per second. Defined as: ((1.0/1000.0)/(1.0)) × yoctometer per second + (0).
   /// </summary>
   public static readonly Velocity RontometerPerSecond =
            new ("rontometer per second", "rm/s", YoctometerPerSecond, 1.0 / 1000.0 / 1.0, 0);

   /// <summary>
   /// A(n) meter per quectosecond. Defined as: ((1.0)/(1.0/1000.0)) × meter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerQuectosecond =
            new ("meter per quectosecond", "m/qs", MeterPerRontosecond, 1.0 / (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) decimeter per rontosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × meter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerRontosecond = new (
                                                                  "decimeter per rontosecond"
                                                                , "dm/rs"
                                                                , MeterPerYoctosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) centimeter per yoctosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × decimeter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerYoctosecond = new (
                                                                   "centimeter per yoctosecond"
                                                                 , "cm/ys"
                                                                 , DecimeterPerZeptosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) millimeter per zeptosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × centimeter per attosecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerZeptosecond = new (
                                                                   "millimeter per zeptosecond"
                                                                 , "mm/zs"
                                                                 , CentimeterPerAttosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) micrometer per attosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × millimeter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerAttosecond = new (
                                                                  "micrometer per attosecond"
                                                                , "μm/as"
                                                                , MillimeterPerFemtosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) nanometer per femtosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × micrometer per picosecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerFemtosecond = new (
                                                                  "nanometer per femtosecond"
                                                                , "nm/fs"
                                                                , MicrometerPerPicosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) picometer per picosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × nanometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerPicosecond = new (
                                                                 "picometer per picosecond"
                                                               , "pm/ps"
                                                               , NanometerPerNanosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) femtometer per nanosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × picometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerNanosecond = new (
                                                                  "femtometer per nanosecond"
                                                                , "fm/ns"
                                                                , PicometerPerMicrosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) attometer per microsecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × femtometer per millisecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerMicrosecond = new (
                                                                  "attometer per microsecond"
                                                                , "am/μs"
                                                                , FemtometerPerMillisecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zeptometer per millisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × attometer per centisecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerMillisecond = new (
                                                                   "zeptometer per millisecond"
                                                                 , "zm/ms"
                                                                 , AttometerPerCentisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yoctometer per centisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × zeptometer per decisecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerCentisecond = new (
                                                                   "yoctometer per centisecond"
                                                                 , "ym/cs"
                                                                 , ZeptometerPerDecisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rontometer per decisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × yoctometer per second + (0).
   /// </summary>
   public static readonly Velocity RontometerPerDecisecond = new (
                                                                  "rontometer per decisecond"
                                                                , "rm/ds"
                                                                , YoctometerPerSecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) quectometer per second. Defined as: ((1.0/1000.0)/(1.0)) × rontometer per second + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerSecond =
            new ("quectometer per second", "qm/s", RontometerPerSecond, 1.0 / 1000.0 / 1.0, 0);

   /// <summary>
   /// A(n) dekameter per second. Defined as: ((10.0)/(1.0)) × meter per second + (0).
   /// </summary>
   public static readonly Velocity DekameterPerSecond = new (
                                                             "dekameter per second"
                                                           , "dam/s"
                                                           , MeterPerSecond
                                                           , 10.0 / 1.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) decimeter per quectosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × meter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerQuectosecond = new (
                                                                   "decimeter per quectosecond"
                                                                 , "dm/qs"
                                                                 , MeterPerRontosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centimeter per rontosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × decimeter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerRontosecond = new (
                                                                   "centimeter per rontosecond"
                                                                 , "cm/rs"
                                                                 , DecimeterPerYoctosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) millimeter per yoctosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × centimeter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerYoctosecond = new (
                                                                   "millimeter per yoctosecond"
                                                                 , "mm/ys"
                                                                 , CentimeterPerZeptosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) micrometer per zeptosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × millimeter per attosecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerZeptosecond = new (
                                                                   "micrometer per zeptosecond"
                                                                 , "μm/zs"
                                                                 , MillimeterPerAttosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nanometer per attosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × micrometer per femtosecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerAttosecond = new (
                                                                 "nanometer per attosecond"
                                                               , "nm/as"
                                                               , MicrometerPerFemtosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) picometer per femtosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × nanometer per picosecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerFemtosecond = new (
                                                                  "picometer per femtosecond"
                                                                , "pm/fs"
                                                                , NanometerPerPicosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) femtometer per picosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × picometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerPicosecond = new (
                                                                  "femtometer per picosecond"
                                                                , "fm/ps"
                                                                , PicometerPerNanosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) attometer per nanosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × femtometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerNanosecond = new (
                                                                 "attometer per nanosecond"
                                                               , "am/ns"
                                                               , FemtometerPerMicrosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) zeptometer per microsecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × attometer per millisecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerMicrosecond = new (
                                                                   "zeptometer per microsecond"
                                                                 , "zm/μs"
                                                                 , AttometerPerMillisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yoctometer per millisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × zeptometer per centisecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerMillisecond = new (
                                                                   "yoctometer per millisecond"
                                                                 , "ym/ms"
                                                                 , ZeptometerPerCentisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rontometer per centisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × yoctometer per decisecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerCentisecond = new (
                                                                   "rontometer per centisecond"
                                                                 , "rm/cs"
                                                                 , YoctometerPerDecisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quectometer per decisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × rontometer per second + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerDecisecond = new (
                                                                   "quectometer per decisecond"
                                                                 , "qm/ds"
                                                                 , RontometerPerSecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) hectometer per second. Defined as: ((10.0)/(1.0)) × dekameter per second + (0).
   /// </summary>
   public static readonly Velocity HectometerPerSecond =
            new ("hectometer per second", "hm/s", DekameterPerSecond, 10.0 / 1.0, 0);

   /// <summary>
   /// A(n) dekameter per decisecond. Defined as: ((10.0)/(1.0/10.0)) × meter per second + (0).
   /// </summary>
   public static readonly Velocity DekameterPerDecisecond =
            new ("dekameter per decisecond", "dam/ds", MeterPerSecond, 10.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) centimeter per quectosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × decimeter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerQuectosecond = new (
                                                                    "centimeter per quectosecond"
                                                                  , "cm/qs"
                                                                  , DecimeterPerRontosecond
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) millimeter per rontosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × centimeter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerRontosecond = new (
                                                                   "millimeter per rontosecond"
                                                                 , "mm/rs"
                                                                 , CentimeterPerYoctosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) micrometer per yoctosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × millimeter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerYoctosecond = new (
                                                                   "micrometer per yoctosecond"
                                                                 , "μm/ys"
                                                                 , MillimeterPerZeptosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nanometer per zeptosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × micrometer per attosecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerZeptosecond = new (
                                                                  "nanometer per zeptosecond"
                                                                , "nm/zs"
                                                                , MicrometerPerAttosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) picometer per attosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × nanometer per femtosecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerAttosecond = new (
                                                                 "picometer per attosecond"
                                                               , "pm/as"
                                                               , NanometerPerFemtosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) femtometer per femtosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × picometer per picosecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerFemtosecond = new (
                                                                   "femtometer per femtosecond"
                                                                 , "fm/fs"
                                                                 , PicometerPerPicosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attometer per picosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × femtometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerPicosecond = new (
                                                                 "attometer per picosecond"
                                                               , "am/ps"
                                                               , FemtometerPerNanosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) zeptometer per nanosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × attometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerNanosecond = new (
                                                                  "zeptometer per nanosecond"
                                                                , "zm/ns"
                                                                , AttometerPerMicrosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yoctometer per microsecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × zeptometer per millisecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerMicrosecond = new (
                                                                   "yoctometer per microsecond"
                                                                 , "ym/μs"
                                                                 , ZeptometerPerMillisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rontometer per millisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × yoctometer per centisecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerMillisecond = new (
                                                                   "rontometer per millisecond"
                                                                 , "rm/ms"
                                                                 , YoctometerPerCentisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quectometer per centisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × rontometer per decisecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerCentisecond = new (
                                                                    "quectometer per centisecond"
                                                                  , "qm/cs"
                                                                  , RontometerPerDecisecond
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilometer per second. Defined as: ((10.0)/(1.0)) × hectometer per second + (0).
   /// </summary>
   public static readonly Velocity KilometerPerSecond = new (
                                                             "kilometer per second"
                                                           , "km/s"
                                                           , HectometerPerSecond
                                                           , 10.0 / 1.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) hectometer per decisecond. Defined as: ((10.0)/(1.0/10.0)) × dekameter per second + (0).
   /// </summary>
   public static readonly Velocity HectometerPerDecisecond =
            new ("hectometer per decisecond", "hm/ds", DekameterPerSecond, 10.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) dekameter per centisecond. Defined as: ((10.0)/(1.0/10.0)) × meter per decisecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerCentisecond = new (
                                                                  "dekameter per centisecond"
                                                                , "dam/cs"
                                                                , MeterPerDecisecond
                                                                , 10.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) millimeter per quectosecond. Defined as: ((1.0/10.0)/(1.0/1000.0)) × centimeter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerQuectosecond = new (
                                                                    "millimeter per quectosecond"
                                                                  , "mm/qs"
                                                                  , CentimeterPerRontosecond
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) micrometer per rontosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × millimeter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerRontosecond = new (
                                                                   "micrometer per rontosecond"
                                                                 , "μm/rs"
                                                                 , MillimeterPerYoctosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nanometer per yoctosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × micrometer per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerYoctosecond = new (
                                                                  "nanometer per yoctosecond"
                                                                , "nm/ys"
                                                                , MicrometerPerZeptosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) picometer per zeptosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × nanometer per attosecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerZeptosecond = new (
                                                                  "picometer per zeptosecond"
                                                                , "pm/zs"
                                                                , NanometerPerAttosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) femtometer per attosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × picometer per femtosecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerAttosecond = new (
                                                                  "femtometer per attosecond"
                                                                , "fm/as"
                                                                , PicometerPerFemtosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) attometer per femtosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × femtometer per picosecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerFemtosecond = new (
                                                                  "attometer per femtosecond"
                                                                , "am/fs"
                                                                , FemtometerPerPicosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zeptometer per picosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × attometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerPicosecond = new (
                                                                  "zeptometer per picosecond"
                                                                , "zm/ps"
                                                                , AttometerPerNanosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yoctometer per nanosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × zeptometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerNanosecond = new (
                                                                  "yoctometer per nanosecond"
                                                                , "ym/ns"
                                                                , ZeptometerPerMicrosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) rontometer per microsecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × yoctometer per millisecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerMicrosecond = new (
                                                                   "rontometer per microsecond"
                                                                 , "rm/μs"
                                                                 , YoctometerPerMillisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quectometer per millisecond. Defined as: ((1.0/1000.0)/(1.0/10.0)) × rontometer per centisecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerMillisecond = new (
                                                                    "quectometer per millisecond"
                                                                  , "qm/ms"
                                                                  , RontometerPerCentisecond
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megameter per second. Defined as: ((1000.0)/(1.0)) × kilometer per second + (0).
   /// </summary>
   public static readonly Velocity MegameterPerSecond = new (
                                                             "megameter per second"
                                                           , "Mm/s"
                                                           , KilometerPerSecond
                                                           , 1000.0 / 1.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) kilometer per decisecond. Defined as: ((10.0)/(1.0/10.0)) × hectometer per second + (0).
   /// </summary>
   public static readonly Velocity KilometerPerDecisecond =
            new ("kilometer per decisecond", "km/ds", HectometerPerSecond, 10.0 / (1.0 / 10.0), 0);

   /// <summary>
   /// A(n) hectometer per centisecond. Defined as: ((10.0)/(1.0/10.0)) × dekameter per decisecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerCentisecond = new (
                                                                   "hectometer per centisecond"
                                                                 , "hm/cs"
                                                                 , DekameterPerDecisecond
                                                                 , 10.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) dekameter per millisecond. Defined as: ((10.0)/(1.0/10.0)) × meter per centisecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerMillisecond = new (
                                                                  "dekameter per millisecond"
                                                                , "dam/ms"
                                                                , MeterPerCentisecond
                                                                , 10.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) micrometer per quectosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × millimeter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerQuectosecond = new (
                                                                    "micrometer per quectosecond"
                                                                  , "μm/qs"
                                                                  , MillimeterPerRontosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanometer per rontosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × micrometer per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerRontosecond = new (
                                                                  "nanometer per rontosecond"
                                                                , "nm/rs"
                                                                , MicrometerPerYoctosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) picometer per yoctosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × nanometer per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerYoctosecond = new (
                                                                  "picometer per yoctosecond"
                                                                , "pm/ys"
                                                                , NanometerPerZeptosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) femtometer per zeptosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × picometer per attosecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerZeptosecond = new (
                                                                   "femtometer per zeptosecond"
                                                                 , "fm/zs"
                                                                 , PicometerPerAttosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attometer per attosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × femtometer per femtosecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerAttosecond = new (
                                                                 "attometer per attosecond"
                                                               , "am/as"
                                                               , FemtometerPerFemtosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) zeptometer per femtosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × attometer per picosecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerFemtosecond = new (
                                                                   "zeptometer per femtosecond"
                                                                 , "zm/fs"
                                                                 , AttometerPerPicosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yoctometer per picosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × zeptometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerPicosecond = new (
                                                                  "yoctometer per picosecond"
                                                                , "ym/ps"
                                                                , ZeptometerPerNanosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) rontometer per nanosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × yoctometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerNanosecond = new (
                                                                  "rontometer per nanosecond"
                                                                , "rm/ns"
                                                                , YoctometerPerMicrosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) quectometer per microsecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × rontometer per millisecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerMicrosecond = new (
                                                                    "quectometer per microsecond"
                                                                  , "qm/μs"
                                                                  , RontometerPerMillisecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigameter per second. Defined as: ((1000.0)/(1.0)) × megameter per second + (0).
   /// </summary>
   public static readonly Velocity GigameterPerSecond = new (
                                                             "gigameter per second"
                                                           , "Gm/s"
                                                           , MegameterPerSecond
                                                           , 1000.0 / 1.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) megameter per decisecond. Defined as: ((1000.0)/(1.0/10.0)) × kilometer per second + (0).
   /// </summary>
   public static readonly Velocity MegameterPerDecisecond = new (
                                                                 "megameter per decisecond"
                                                               , "Mm/ds"
                                                               , KilometerPerSecond
                                                               , 1000.0 / (1.0 / 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) kilometer per centisecond. Defined as: ((10.0)/(1.0/10.0)) × hectometer per decisecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerCentisecond = new (
                                                                  "kilometer per centisecond"
                                                                , "km/cs"
                                                                , HectometerPerDecisecond
                                                                , 10.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) hectometer per millisecond. Defined as: ((10.0)/(1.0/10.0)) × dekameter per centisecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerMillisecond = new (
                                                                   "hectometer per millisecond"
                                                                 , "hm/ms"
                                                                 , DekameterPerCentisecond
                                                                 , 10.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) dekameter per microsecond. Defined as: ((10.0)/(1.0/1000.0)) × meter per millisecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerMicrosecond = new (
                                                                  "dekameter per microsecond"
                                                                , "dam/μs"
                                                                , MeterPerMillisecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) nanometer per quectosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × micrometer per rontosecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerQuectosecond = new (
                                                                   "nanometer per quectosecond"
                                                                 , "nm/qs"
                                                                 , MicrometerPerRontosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picometer per rontosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × nanometer per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerRontosecond = new (
                                                                  "picometer per rontosecond"
                                                                , "pm/rs"
                                                                , NanometerPerYoctosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) femtometer per yoctosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × picometer per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerYoctosecond = new (
                                                                   "femtometer per yoctosecond"
                                                                 , "fm/ys"
                                                                 , PicometerPerZeptosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attometer per zeptosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × femtometer per attosecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerZeptosecond = new (
                                                                  "attometer per zeptosecond"
                                                                , "am/zs"
                                                                , FemtometerPerAttosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zeptometer per attosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × attometer per femtosecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerAttosecond = new (
                                                                  "zeptometer per attosecond"
                                                                , "zm/as"
                                                                , AttometerPerFemtosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yoctometer per femtosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × zeptometer per picosecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerFemtosecond = new (
                                                                   "yoctometer per femtosecond"
                                                                 , "ym/fs"
                                                                 , ZeptometerPerPicosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rontometer per picosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × yoctometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerPicosecond = new (
                                                                  "rontometer per picosecond"
                                                                , "rm/ps"
                                                                , YoctometerPerNanosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) quectometer per nanosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × rontometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerNanosecond = new (
                                                                   "quectometer per nanosecond"
                                                                 , "qm/ns"
                                                                 , RontometerPerMicrosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) terameter per second. Defined as: ((1000.0)/(1.0)) × gigameter per second + (0).
   /// </summary>
   public static readonly Velocity TerameterPerSecond = new (
                                                             "terameter per second"
                                                           , "Tm/s"
                                                           , GigameterPerSecond
                                                           , 1000.0 / 1.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) gigameter per decisecond. Defined as: ((1000.0)/(1.0/10.0)) × megameter per second + (0).
   /// </summary>
   public static readonly Velocity GigameterPerDecisecond = new (
                                                                 "gigameter per decisecond"
                                                               , "Gm/ds"
                                                               , MegameterPerSecond
                                                               , 1000.0 / (1.0 / 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) megameter per centisecond. Defined as: ((1000.0)/(1.0/10.0)) × kilometer per decisecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerCentisecond = new (
                                                                  "megameter per centisecond"
                                                                , "Mm/cs"
                                                                , KilometerPerDecisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) kilometer per millisecond. Defined as: ((10.0)/(1.0/10.0)) × hectometer per centisecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerMillisecond = new (
                                                                  "kilometer per millisecond"
                                                                , "km/ms"
                                                                , HectometerPerCentisecond
                                                                , 10.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) hectometer per microsecond. Defined as: ((10.0)/(1.0/1000.0)) × dekameter per millisecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerMicrosecond = new (
                                                                   "hectometer per microsecond"
                                                                 , "hm/μs"
                                                                 , DekameterPerMillisecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) dekameter per nanosecond. Defined as: ((10.0)/(1.0/1000.0)) × meter per microsecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerNanosecond = new (
                                                                 "dekameter per nanosecond"
                                                               , "dam/ns"
                                                               , MeterPerMicrosecond
                                                               , 10.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) picometer per quectosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × nanometer per rontosecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerQuectosecond = new (
                                                                   "picometer per quectosecond"
                                                                 , "pm/qs"
                                                                 , NanometerPerRontosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtometer per rontosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × picometer per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerRontosecond = new (
                                                                   "femtometer per rontosecond"
                                                                 , "fm/rs"
                                                                 , PicometerPerYoctosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attometer per yoctosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × femtometer per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerYoctosecond = new (
                                                                  "attometer per yoctosecond"
                                                                , "am/ys"
                                                                , FemtometerPerZeptosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zeptometer per zeptosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × attometer per attosecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerZeptosecond = new (
                                                                   "zeptometer per zeptosecond"
                                                                 , "zm/zs"
                                                                 , AttometerPerAttosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yoctometer per attosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × zeptometer per femtosecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerAttosecond = new (
                                                                  "yoctometer per attosecond"
                                                                , "ym/as"
                                                                , ZeptometerPerFemtosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) rontometer per femtosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × yoctometer per picosecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerFemtosecond = new (
                                                                   "rontometer per femtosecond"
                                                                 , "rm/fs"
                                                                 , YoctometerPerPicosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quectometer per picosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × rontometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerPicosecond = new (
                                                                   "quectometer per picosecond"
                                                                 , "qm/ps"
                                                                 , RontometerPerNanosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petameter per second. Defined as: ((1000.0)/(1.0)) × terameter per second + (0).
   /// </summary>
   public static readonly Velocity PetameterPerSecond = new (
                                                             "petameter per second"
                                                           , "Pm/s"
                                                           , TerameterPerSecond
                                                           , 1000.0 / 1.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) terameter per decisecond. Defined as: ((1000.0)/(1.0/10.0)) × gigameter per second + (0).
   /// </summary>
   public static readonly Velocity TerameterPerDecisecond = new (
                                                                 "terameter per decisecond"
                                                               , "Tm/ds"
                                                               , GigameterPerSecond
                                                               , 1000.0 / (1.0 / 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) gigameter per centisecond. Defined as: ((1000.0)/(1.0/10.0)) × megameter per decisecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerCentisecond = new (
                                                                  "gigameter per centisecond"
                                                                , "Gm/cs"
                                                                , MegameterPerDecisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) megameter per millisecond. Defined as: ((1000.0)/(1.0/10.0)) × kilometer per centisecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerMillisecond = new (
                                                                  "megameter per millisecond"
                                                                , "Mm/ms"
                                                                , KilometerPerCentisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) kilometer per microsecond. Defined as: ((10.0)/(1.0/1000.0)) × hectometer per millisecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerMicrosecond = new (
                                                                  "kilometer per microsecond"
                                                                , "km/μs"
                                                                , HectometerPerMillisecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) hectometer per nanosecond. Defined as: ((10.0)/(1.0/1000.0)) × dekameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerNanosecond = new (
                                                                  "hectometer per nanosecond"
                                                                , "hm/ns"
                                                                , DekameterPerMicrosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) dekameter per picosecond. Defined as: ((10.0)/(1.0/1000.0)) × meter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerPicosecond = new (
                                                                 "dekameter per picosecond"
                                                               , "dam/ps"
                                                               , MeterPerNanosecond
                                                               , 10.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) femtometer per quectosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × picometer per rontosecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerQuectosecond = new (
                                                                    "femtometer per quectosecond"
                                                                  , "fm/qs"
                                                                  , PicometerPerRontosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attometer per rontosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × femtometer per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerRontosecond = new (
                                                                  "attometer per rontosecond"
                                                                , "am/rs"
                                                                , FemtometerPerYoctosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zeptometer per yoctosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × attometer per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerYoctosecond = new (
                                                                   "zeptometer per yoctosecond"
                                                                 , "zm/ys"
                                                                 , AttometerPerZeptosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yoctometer per zeptosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × zeptometer per attosecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerZeptosecond = new (
                                                                   "yoctometer per zeptosecond"
                                                                 , "ym/zs"
                                                                 , ZeptometerPerAttosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rontometer per attosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × yoctometer per femtosecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerAttosecond = new (
                                                                  "rontometer per attosecond"
                                                                , "rm/as"
                                                                , YoctometerPerFemtosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) quectometer per femtosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × rontometer per picosecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerFemtosecond = new (
                                                                    "quectometer per femtosecond"
                                                                  , "qm/fs"
                                                                  , RontometerPerPicosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exameter per second. Defined as: ((1000.0)/(1.0)) × petameter per second + (0).
   /// </summary>
   public static readonly Velocity ExameterPerSecond = new (
                                                            "exameter per second"
                                                          , "Em/s"
                                                          , PetameterPerSecond
                                                          , 1000.0 / 1.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) petameter per decisecond. Defined as: ((1000.0)/(1.0/10.0)) × terameter per second + (0).
   /// </summary>
   public static readonly Velocity PetameterPerDecisecond = new (
                                                                 "petameter per decisecond"
                                                               , "Pm/ds"
                                                               , TerameterPerSecond
                                                               , 1000.0 / (1.0 / 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per centisecond. Defined as: ((1000.0)/(1.0/10.0)) × gigameter per decisecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerCentisecond = new (
                                                                  "terameter per centisecond"
                                                                , "Tm/cs"
                                                                , GigameterPerDecisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) gigameter per millisecond. Defined as: ((1000.0)/(1.0/10.0)) × megameter per centisecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerMillisecond = new (
                                                                  "gigameter per millisecond"
                                                                , "Gm/ms"
                                                                , MegameterPerCentisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) megameter per microsecond. Defined as: ((1000.0)/(1.0/1000.0)) × kilometer per millisecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerMicrosecond = new (
                                                                  "megameter per microsecond"
                                                                , "Mm/μs"
                                                                , KilometerPerMillisecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) kilometer per nanosecond. Defined as: ((10.0)/(1.0/1000.0)) × hectometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerNanosecond = new (
                                                                 "kilometer per nanosecond"
                                                               , "km/ns"
                                                               , HectometerPerMicrosecond
                                                               , 10.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) hectometer per picosecond. Defined as: ((10.0)/(1.0/1000.0)) × dekameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerPicosecond = new (
                                                                  "hectometer per picosecond"
                                                                , "hm/ps"
                                                                , DekameterPerNanosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) dekameter per femtosecond. Defined as: ((10.0)/(1.0/1000.0)) × meter per picosecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerFemtosecond = new (
                                                                  "dekameter per femtosecond"
                                                                , "dam/fs"
                                                                , MeterPerPicosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) attometer per quectosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × femtometer per rontosecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerQuectosecond = new (
                                                                   "attometer per quectosecond"
                                                                 , "am/qs"
                                                                 , FemtometerPerRontosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptometer per rontosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × attometer per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerRontosecond = new (
                                                                   "zeptometer per rontosecond"
                                                                 , "zm/rs"
                                                                 , AttometerPerYoctosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yoctometer per yoctosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × zeptometer per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerYoctosecond = new (
                                                                   "yoctometer per yoctosecond"
                                                                 , "ym/ys"
                                                                 , ZeptometerPerZeptosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rontometer per zeptosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × yoctometer per attosecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerZeptosecond = new (
                                                                   "rontometer per zeptosecond"
                                                                 , "rm/zs"
                                                                 , YoctometerPerAttosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quectometer per attosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × rontometer per femtosecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerAttosecond = new (
                                                                   "quectometer per attosecond"
                                                                 , "qm/as"
                                                                 , RontometerPerFemtosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zettameter per second. Defined as: ((1000.0)/(1.0)) × exameter per second + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerSecond =
            new ("zettameter per second", "Zm/s", ExameterPerSecond, 1000.0 / 1.0, 0);

   /// <summary>
   /// A(n) exameter per decisecond. Defined as: ((1000.0)/(1.0/10.0)) × petameter per second + (0).
   /// </summary>
   public static readonly Velocity ExameterPerDecisecond = new (
                                                                "exameter per decisecond"
                                                              , "Em/ds"
                                                              , PetameterPerSecond
                                                              , 1000.0 / (1.0 / 10.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) petameter per centisecond. Defined as: ((1000.0)/(1.0/10.0)) × terameter per decisecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerCentisecond = new (
                                                                  "petameter per centisecond"
                                                                , "Pm/cs"
                                                                , TerameterPerDecisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per millisecond. Defined as: ((1000.0)/(1.0/10.0)) × gigameter per centisecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerMillisecond = new (
                                                                  "terameter per millisecond"
                                                                , "Tm/ms"
                                                                , GigameterPerCentisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) gigameter per microsecond. Defined as: ((1000.0)/(1.0/1000.0)) × megameter per millisecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerMicrosecond = new (
                                                                  "gigameter per microsecond"
                                                                , "Gm/μs"
                                                                , MegameterPerMillisecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) megameter per nanosecond. Defined as: ((1000.0)/(1.0/1000.0)) × kilometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerNanosecond = new (
                                                                 "megameter per nanosecond"
                                                               , "Mm/ns"
                                                               , KilometerPerMicrosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) kilometer per picosecond. Defined as: ((10.0)/(1.0/1000.0)) × hectometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerPicosecond = new (
                                                                 "kilometer per picosecond"
                                                               , "km/ps"
                                                               , HectometerPerNanosecond
                                                               , 10.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) hectometer per femtosecond. Defined as: ((10.0)/(1.0/1000.0)) × dekameter per picosecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerFemtosecond = new (
                                                                   "hectometer per femtosecond"
                                                                 , "hm/fs"
                                                                 , DekameterPerPicosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) dekameter per attosecond. Defined as: ((10.0)/(1.0/1000.0)) × meter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerAttosecond = new (
                                                                 "dekameter per attosecond"
                                                               , "dam/as"
                                                               , MeterPerFemtosecond
                                                               , 10.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) zeptometer per quectosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × attometer per rontosecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerQuectosecond = new (
                                                                    "zeptometer per quectosecond"
                                                                  , "zm/qs"
                                                                  , AttometerPerRontosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctometer per rontosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × zeptometer per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerRontosecond = new (
                                                                   "yoctometer per rontosecond"
                                                                 , "ym/rs"
                                                                 , ZeptometerPerYoctosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rontometer per yoctosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × yoctometer per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerYoctosecond = new (
                                                                   "rontometer per yoctosecond"
                                                                 , "rm/ys"
                                                                 , YoctometerPerZeptosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quectometer per zeptosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × rontometer per attosecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerZeptosecond = new (
                                                                    "quectometer per zeptosecond"
                                                                  , "qm/zs"
                                                                  , RontometerPerAttosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yottameter per second. Defined as: ((1000.0)/(1.0)) × zettameter per second + (0).
   /// </summary>
   public static readonly Velocity YottameterPerSecond =
            new ("yottameter per second", "Ym/s", ZettameterPerSecond, 1000.0 / 1.0, 0);

   /// <summary>
   /// A(n) zettameter per decisecond. Defined as: ((1000.0)/(1.0/10.0)) × exameter per second + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerDecisecond = new (
                                                                  "zettameter per decisecond"
                                                                , "Zm/ds"
                                                                , ExameterPerSecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) exameter per centisecond. Defined as: ((1000.0)/(1.0/10.0)) × petameter per decisecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerCentisecond = new (
                                                                 "exameter per centisecond"
                                                               , "Em/cs"
                                                               , PetameterPerDecisecond
                                                               , 1000.0 / (1.0 / 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) petameter per millisecond. Defined as: ((1000.0)/(1.0/10.0)) × terameter per centisecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerMillisecond = new (
                                                                  "petameter per millisecond"
                                                                , "Pm/ms"
                                                                , TerameterPerCentisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per microsecond. Defined as: ((1000.0)/(1.0/1000.0)) × gigameter per millisecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerMicrosecond = new (
                                                                  "terameter per microsecond"
                                                                , "Tm/μs"
                                                                , GigameterPerMillisecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) gigameter per nanosecond. Defined as: ((1000.0)/(1.0/1000.0)) × megameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerNanosecond = new (
                                                                 "gigameter per nanosecond"
                                                               , "Gm/ns"
                                                               , MegameterPerMicrosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) megameter per picosecond. Defined as: ((1000.0)/(1.0/1000.0)) × kilometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerPicosecond = new (
                                                                 "megameter per picosecond"
                                                               , "Mm/ps"
                                                               , KilometerPerNanosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) kilometer per femtosecond. Defined as: ((10.0)/(1.0/1000.0)) × hectometer per picosecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerFemtosecond = new (
                                                                  "kilometer per femtosecond"
                                                                , "km/fs"
                                                                , HectometerPerPicosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) hectometer per attosecond. Defined as: ((10.0)/(1.0/1000.0)) × dekameter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerAttosecond = new (
                                                                  "hectometer per attosecond"
                                                                , "hm/as"
                                                                , DekameterPerFemtosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) dekameter per zeptosecond. Defined as: ((10.0)/(1.0/1000.0)) × meter per attosecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerZeptosecond = new (
                                                                  "dekameter per zeptosecond"
                                                                , "dam/zs"
                                                                , MeterPerAttosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yoctometer per quectosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × zeptometer per rontosecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerQuectosecond = new (
                                                                    "yoctometer per quectosecond"
                                                                  , "ym/qs"
                                                                  , ZeptometerPerRontosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontometer per rontosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × yoctometer per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerRontosecond = new (
                                                                   "rontometer per rontosecond"
                                                                 , "rm/rs"
                                                                 , YoctometerPerYoctosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quectometer per yoctosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × rontometer per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerYoctosecond = new (
                                                                    "quectometer per yoctosecond"
                                                                  , "qm/ys"
                                                                  , RontometerPerZeptosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) ronnameter per second. Defined as: ((1000.0)/(1.0)) × yottameter per second + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerSecond =
            new ("ronnameter per second", "Rm/s", YottameterPerSecond, 1000.0 / 1.0, 0);

   /// <summary>
   /// A(n) yottameter per decisecond. Defined as: ((1000.0)/(1.0/10.0)) × zettameter per second + (0).
   /// </summary>
   public static readonly Velocity YottameterPerDecisecond = new (
                                                                  "yottameter per decisecond"
                                                                , "Ym/ds"
                                                                , ZettameterPerSecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zettameter per centisecond. Defined as: ((1000.0)/(1.0/10.0)) × exameter per decisecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerCentisecond = new (
                                                                   "zettameter per centisecond"
                                                                 , "Zm/cs"
                                                                 , ExameterPerDecisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) exameter per millisecond. Defined as: ((1000.0)/(1.0/10.0)) × petameter per centisecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerMillisecond = new (
                                                                 "exameter per millisecond"
                                                               , "Em/ms"
                                                               , PetameterPerCentisecond
                                                               , 1000.0 / (1.0 / 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) petameter per microsecond. Defined as: ((1000.0)/(1.0/1000.0)) × terameter per millisecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerMicrosecond = new (
                                                                  "petameter per microsecond"
                                                                , "Pm/μs"
                                                                , TerameterPerMillisecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per nanosecond. Defined as: ((1000.0)/(1.0/1000.0)) × gigameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerNanosecond = new (
                                                                 "terameter per nanosecond"
                                                               , "Tm/ns"
                                                               , GigameterPerMicrosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) gigameter per picosecond. Defined as: ((1000.0)/(1.0/1000.0)) × megameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerPicosecond = new (
                                                                 "gigameter per picosecond"
                                                               , "Gm/ps"
                                                               , MegameterPerNanosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) megameter per femtosecond. Defined as: ((1000.0)/(1.0/1000.0)) × kilometer per picosecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerFemtosecond = new (
                                                                  "megameter per femtosecond"
                                                                , "Mm/fs"
                                                                , KilometerPerPicosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) kilometer per attosecond. Defined as: ((10.0)/(1.0/1000.0)) × hectometer per femtosecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerAttosecond = new (
                                                                 "kilometer per attosecond"
                                                               , "km/as"
                                                               , HectometerPerFemtosecond
                                                               , 10.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) hectometer per zeptosecond. Defined as: ((10.0)/(1.0/1000.0)) × dekameter per attosecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerZeptosecond = new (
                                                                   "hectometer per zeptosecond"
                                                                 , "hm/zs"
                                                                 , DekameterPerAttosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) dekameter per yoctosecond. Defined as: ((10.0)/(1.0/1000.0)) × meter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerYoctosecond = new (
                                                                  "dekameter per yoctosecond"
                                                                , "dam/ys"
                                                                , MeterPerZeptosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) rontometer per quectosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × yoctometer per rontosecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerQuectosecond = new (
                                                                    "rontometer per quectosecond"
                                                                  , "rm/qs"
                                                                  , YoctometerPerRontosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectometer per rontosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × rontometer per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerRontosecond = new (
                                                                    "quectometer per rontosecond"
                                                                  , "qm/rs"
                                                                  , RontometerPerYoctosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quettameter per second. Defined as: ((1000.0)/(1.0)) × ronnameter per second + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerSecond =
            new ("quettameter per second", "Qm/s", RonnameterPerSecond, 1000.0 / 1.0, 0);

   /// <summary>
   /// A(n) ronnameter per decisecond. Defined as: ((1000.0)/(1.0/10.0)) × yottameter per second + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerDecisecond = new (
                                                                  "ronnameter per decisecond"
                                                                , "Rm/ds"
                                                                , YottameterPerSecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yottameter per centisecond. Defined as: ((1000.0)/(1.0/10.0)) × zettameter per decisecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerCentisecond = new (
                                                                   "yottameter per centisecond"
                                                                 , "Ym/cs"
                                                                 , ZettameterPerDecisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zettameter per millisecond. Defined as: ((1000.0)/(1.0/10.0)) × exameter per centisecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerMillisecond = new (
                                                                   "zettameter per millisecond"
                                                                 , "Zm/ms"
                                                                 , ExameterPerCentisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) exameter per microsecond. Defined as: ((1000.0)/(1.0/1000.0)) × petameter per millisecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerMicrosecond = new (
                                                                 "exameter per microsecond"
                                                               , "Em/μs"
                                                               , PetameterPerMillisecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) petameter per nanosecond. Defined as: ((1000.0)/(1.0/1000.0)) × terameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerNanosecond = new (
                                                                 "petameter per nanosecond"
                                                               , "Pm/ns"
                                                               , TerameterPerMicrosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per picosecond. Defined as: ((1000.0)/(1.0/1000.0)) × gigameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerPicosecond = new (
                                                                 "terameter per picosecond"
                                                               , "Tm/ps"
                                                               , GigameterPerNanosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) gigameter per femtosecond. Defined as: ((1000.0)/(1.0/1000.0)) × megameter per picosecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerFemtosecond = new (
                                                                  "gigameter per femtosecond"
                                                                , "Gm/fs"
                                                                , MegameterPerPicosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) megameter per attosecond. Defined as: ((1000.0)/(1.0/1000.0)) × kilometer per femtosecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerAttosecond = new (
                                                                 "megameter per attosecond"
                                                               , "Mm/as"
                                                               , KilometerPerFemtosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) kilometer per zeptosecond. Defined as: ((10.0)/(1.0/1000.0)) × hectometer per attosecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerZeptosecond = new (
                                                                  "kilometer per zeptosecond"
                                                                , "km/zs"
                                                                , HectometerPerAttosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) hectometer per yoctosecond. Defined as: ((10.0)/(1.0/1000.0)) × dekameter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerYoctosecond = new (
                                                                   "hectometer per yoctosecond"
                                                                 , "hm/ys"
                                                                 , DekameterPerZeptosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) dekameter per rontosecond. Defined as: ((10.0)/(1.0/1000.0)) × meter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerRontosecond = new (
                                                                  "dekameter per rontosecond"
                                                                , "dam/rs"
                                                                , MeterPerYoctosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) quectometer per quectosecond. Defined as: ((1.0/1000.0)/(1.0/1000.0)) × rontometer per rontosecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerQuectosecond = new (
                                                                     "quectometer per quectosecond"
                                                                   , "qm/qs"
                                                                   , RontometerPerRontosecond
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettameter per decisecond. Defined as: ((1000.0)/(1.0/10.0)) × ronnameter per second + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerDecisecond = new (
                                                                   "quettameter per decisecond"
                                                                 , "Qm/ds"
                                                                 , RonnameterPerSecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) ronnameter per centisecond. Defined as: ((1000.0)/(1.0/10.0)) × yottameter per decisecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerCentisecond = new (
                                                                   "ronnameter per centisecond"
                                                                 , "Rm/cs"
                                                                 , YottameterPerDecisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yottameter per millisecond. Defined as: ((1000.0)/(1.0/10.0)) × zettameter per centisecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerMillisecond = new (
                                                                   "yottameter per millisecond"
                                                                 , "Ym/ms"
                                                                 , ZettameterPerCentisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zettameter per microsecond. Defined as: ((1000.0)/(1.0/1000.0)) × exameter per millisecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerMicrosecond = new (
                                                                   "zettameter per microsecond"
                                                                 , "Zm/μs"
                                                                 , ExameterPerMillisecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) exameter per nanosecond. Defined as: ((1000.0)/(1.0/1000.0)) × petameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerNanosecond = new (
                                                                "exameter per nanosecond"
                                                              , "Em/ns"
                                                              , PetameterPerMicrosecond
                                                              , 1000.0 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) petameter per picosecond. Defined as: ((1000.0)/(1.0/1000.0)) × terameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerPicosecond = new (
                                                                 "petameter per picosecond"
                                                               , "Pm/ps"
                                                               , TerameterPerNanosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per femtosecond. Defined as: ((1000.0)/(1.0/1000.0)) × gigameter per picosecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerFemtosecond = new (
                                                                  "terameter per femtosecond"
                                                                , "Tm/fs"
                                                                , GigameterPerPicosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) gigameter per attosecond. Defined as: ((1000.0)/(1.0/1000.0)) × megameter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerAttosecond = new (
                                                                 "gigameter per attosecond"
                                                               , "Gm/as"
                                                               , MegameterPerFemtosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) megameter per zeptosecond. Defined as: ((1000.0)/(1.0/1000.0)) × kilometer per attosecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerZeptosecond = new (
                                                                  "megameter per zeptosecond"
                                                                , "Mm/zs"
                                                                , KilometerPerAttosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) kilometer per yoctosecond. Defined as: ((10.0)/(1.0/1000.0)) × hectometer per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerYoctosecond = new (
                                                                  "kilometer per yoctosecond"
                                                                , "km/ys"
                                                                , HectometerPerZeptosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) hectometer per rontosecond. Defined as: ((10.0)/(1.0/1000.0)) × dekameter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerRontosecond = new (
                                                                   "hectometer per rontosecond"
                                                                 , "hm/rs"
                                                                 , DekameterPerYoctosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) dekameter per quectosecond. Defined as: ((10.0)/(1.0/1000.0)) × meter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerQuectosecond = new (
                                                                   "dekameter per quectosecond"
                                                                 , "dam/qs"
                                                                 , MeterPerRontosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quettameter per centisecond. Defined as: ((1000.0)/(1.0/10.0)) × ronnameter per decisecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerCentisecond = new (
                                                                    "quettameter per centisecond"
                                                                  , "Qm/cs"
                                                                  , RonnameterPerDecisecond
                                                                  , 1000.0 / (1.0 / 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) ronnameter per millisecond. Defined as: ((1000.0)/(1.0/10.0)) × yottameter per centisecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerMillisecond = new (
                                                                   "ronnameter per millisecond"
                                                                 , "Rm/ms"
                                                                 , YottameterPerCentisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yottameter per microsecond. Defined as: ((1000.0)/(1.0/1000.0)) × zettameter per millisecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerMicrosecond = new (
                                                                   "yottameter per microsecond"
                                                                 , "Ym/μs"
                                                                 , ZettameterPerMillisecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zettameter per nanosecond. Defined as: ((1000.0)/(1.0/1000.0)) × exameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerNanosecond = new (
                                                                  "zettameter per nanosecond"
                                                                , "Zm/ns"
                                                                , ExameterPerMicrosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) exameter per picosecond. Defined as: ((1000.0)/(1.0/1000.0)) × petameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerPicosecond = new (
                                                                "exameter per picosecond"
                                                              , "Em/ps"
                                                              , PetameterPerNanosecond
                                                              , 1000.0 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) petameter per femtosecond. Defined as: ((1000.0)/(1.0/1000.0)) × terameter per picosecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerFemtosecond = new (
                                                                  "petameter per femtosecond"
                                                                , "Pm/fs"
                                                                , TerameterPerPicosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per attosecond. Defined as: ((1000.0)/(1.0/1000.0)) × gigameter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerAttosecond = new (
                                                                 "terameter per attosecond"
                                                               , "Tm/as"
                                                               , GigameterPerFemtosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) gigameter per zeptosecond. Defined as: ((1000.0)/(1.0/1000.0)) × megameter per attosecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerZeptosecond = new (
                                                                  "gigameter per zeptosecond"
                                                                , "Gm/zs"
                                                                , MegameterPerAttosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) megameter per yoctosecond. Defined as: ((1000.0)/(1.0/1000.0)) × kilometer per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerYoctosecond = new (
                                                                  "megameter per yoctosecond"
                                                                , "Mm/ys"
                                                                , KilometerPerZeptosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) kilometer per rontosecond. Defined as: ((10.0)/(1.0/1000.0)) × hectometer per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerRontosecond = new (
                                                                  "kilometer per rontosecond"
                                                                , "km/rs"
                                                                , HectometerPerYoctosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) hectometer per quectosecond. Defined as: ((10.0)/(1.0/1000.0)) × dekameter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerQuectosecond = new (
                                                                    "hectometer per quectosecond"
                                                                  , "hm/qs"
                                                                  , DekameterPerRontosecond
                                                                  , 10.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quettameter per millisecond. Defined as: ((1000.0)/(1.0/10.0)) × ronnameter per centisecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerMillisecond = new (
                                                                    "quettameter per millisecond"
                                                                  , "Qm/ms"
                                                                  , RonnameterPerCentisecond
                                                                  , 1000.0 / (1.0 / 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) ronnameter per microsecond. Defined as: ((1000.0)/(1.0/1000.0)) × yottameter per millisecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerMicrosecond = new (
                                                                   "ronnameter per microsecond"
                                                                 , "Rm/μs"
                                                                 , YottameterPerMillisecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yottameter per nanosecond. Defined as: ((1000.0)/(1.0/1000.0)) × zettameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerNanosecond = new (
                                                                  "yottameter per nanosecond"
                                                                , "Ym/ns"
                                                                , ZettameterPerMicrosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zettameter per picosecond. Defined as: ((1000.0)/(1.0/1000.0)) × exameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerPicosecond = new (
                                                                  "zettameter per picosecond"
                                                                , "Zm/ps"
                                                                , ExameterPerNanosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) exameter per femtosecond. Defined as: ((1000.0)/(1.0/1000.0)) × petameter per picosecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerFemtosecond = new (
                                                                 "exameter per femtosecond"
                                                               , "Em/fs"
                                                               , PetameterPerPicosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) petameter per attosecond. Defined as: ((1000.0)/(1.0/1000.0)) × terameter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerAttosecond = new (
                                                                 "petameter per attosecond"
                                                               , "Pm/as"
                                                               , TerameterPerFemtosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per zeptosecond. Defined as: ((1000.0)/(1.0/1000.0)) × gigameter per attosecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerZeptosecond = new (
                                                                  "terameter per zeptosecond"
                                                                , "Tm/zs"
                                                                , GigameterPerAttosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) gigameter per yoctosecond. Defined as: ((1000.0)/(1.0/1000.0)) × megameter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerYoctosecond = new (
                                                                  "gigameter per yoctosecond"
                                                                , "Gm/ys"
                                                                , MegameterPerZeptosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) megameter per rontosecond. Defined as: ((1000.0)/(1.0/1000.0)) × kilometer per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerRontosecond = new (
                                                                  "megameter per rontosecond"
                                                                , "Mm/rs"
                                                                , KilometerPerYoctosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) kilometer per quectosecond. Defined as: ((10.0)/(1.0/1000.0)) × hectometer per rontosecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerQuectosecond = new (
                                                                   "kilometer per quectosecond"
                                                                 , "km/qs"
                                                                 , HectometerPerRontosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quettameter per microsecond. Defined as: ((1000.0)/(1.0/1000.0)) × ronnameter per millisecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerMicrosecond = new (
                                                                    "quettameter per microsecond"
                                                                  , "Qm/μs"
                                                                  , RonnameterPerMillisecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) ronnameter per nanosecond. Defined as: ((1000.0)/(1.0/1000.0)) × yottameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerNanosecond = new (
                                                                  "ronnameter per nanosecond"
                                                                , "Rm/ns"
                                                                , YottameterPerMicrosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yottameter per picosecond. Defined as: ((1000.0)/(1.0/1000.0)) × zettameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerPicosecond = new (
                                                                  "yottameter per picosecond"
                                                                , "Ym/ps"
                                                                , ZettameterPerNanosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zettameter per femtosecond. Defined as: ((1000.0)/(1.0/1000.0)) × exameter per picosecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerFemtosecond = new (
                                                                   "zettameter per femtosecond"
                                                                 , "Zm/fs"
                                                                 , ExameterPerPicosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) exameter per attosecond. Defined as: ((1000.0)/(1.0/1000.0)) × petameter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerAttosecond = new (
                                                                "exameter per attosecond"
                                                              , "Em/as"
                                                              , PetameterPerFemtosecond
                                                              , 1000.0 / (1.0 / 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) petameter per zeptosecond. Defined as: ((1000.0)/(1.0/1000.0)) × terameter per attosecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerZeptosecond = new (
                                                                  "petameter per zeptosecond"
                                                                , "Pm/zs"
                                                                , TerameterPerAttosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per yoctosecond. Defined as: ((1000.0)/(1.0/1000.0)) × gigameter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerYoctosecond = new (
                                                                  "terameter per yoctosecond"
                                                                , "Tm/ys"
                                                                , GigameterPerZeptosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) gigameter per rontosecond. Defined as: ((1000.0)/(1.0/1000.0)) × megameter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerRontosecond = new (
                                                                  "gigameter per rontosecond"
                                                                , "Gm/rs"
                                                                , MegameterPerYoctosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) megameter per quectosecond. Defined as: ((1000.0)/(1.0/1000.0)) × kilometer per rontosecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerQuectosecond = new (
                                                                   "megameter per quectosecond"
                                                                 , "Mm/qs"
                                                                 , KilometerPerRontosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quettameter per nanosecond. Defined as: ((1000.0)/(1.0/1000.0)) × ronnameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerNanosecond = new (
                                                                   "quettameter per nanosecond"
                                                                 , "Qm/ns"
                                                                 , RonnameterPerMicrosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) ronnameter per picosecond. Defined as: ((1000.0)/(1.0/1000.0)) × yottameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerPicosecond = new (
                                                                  "ronnameter per picosecond"
                                                                , "Rm/ps"
                                                                , YottameterPerNanosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yottameter per femtosecond. Defined as: ((1000.0)/(1.0/1000.0)) × zettameter per picosecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerFemtosecond = new (
                                                                   "yottameter per femtosecond"
                                                                 , "Ym/fs"
                                                                 , ZettameterPerPicosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zettameter per attosecond. Defined as: ((1000.0)/(1.0/1000.0)) × exameter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerAttosecond = new (
                                                                  "zettameter per attosecond"
                                                                , "Zm/as"
                                                                , ExameterPerFemtosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) exameter per zeptosecond. Defined as: ((1000.0)/(1.0/1000.0)) × petameter per attosecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerZeptosecond = new (
                                                                 "exameter per zeptosecond"
                                                               , "Em/zs"
                                                               , PetameterPerAttosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) petameter per yoctosecond. Defined as: ((1000.0)/(1.0/1000.0)) × terameter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerYoctosecond = new (
                                                                  "petameter per yoctosecond"
                                                                , "Pm/ys"
                                                                , TerameterPerZeptosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per rontosecond. Defined as: ((1000.0)/(1.0/1000.0)) × gigameter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerRontosecond = new (
                                                                  "terameter per rontosecond"
                                                                , "Tm/rs"
                                                                , GigameterPerYoctosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) gigameter per quectosecond. Defined as: ((1000.0)/(1.0/1000.0)) × megameter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerQuectosecond = new (
                                                                   "gigameter per quectosecond"
                                                                 , "Gm/qs"
                                                                 , MegameterPerRontosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quettameter per picosecond. Defined as: ((1000.0)/(1.0/1000.0)) × ronnameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerPicosecond = new (
                                                                   "quettameter per picosecond"
                                                                 , "Qm/ps"
                                                                 , RonnameterPerNanosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) ronnameter per femtosecond. Defined as: ((1000.0)/(1.0/1000.0)) × yottameter per picosecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerFemtosecond = new (
                                                                   "ronnameter per femtosecond"
                                                                 , "Rm/fs"
                                                                 , YottameterPerPicosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yottameter per attosecond. Defined as: ((1000.0)/(1.0/1000.0)) × zettameter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerAttosecond = new (
                                                                  "yottameter per attosecond"
                                                                , "Ym/as"
                                                                , ZettameterPerFemtosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zettameter per zeptosecond. Defined as: ((1000.0)/(1.0/1000.0)) × exameter per attosecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerZeptosecond = new (
                                                                   "zettameter per zeptosecond"
                                                                 , "Zm/zs"
                                                                 , ExameterPerAttosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) exameter per yoctosecond. Defined as: ((1000.0)/(1.0/1000.0)) × petameter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerYoctosecond = new (
                                                                 "exameter per yoctosecond"
                                                               , "Em/ys"
                                                               , PetameterPerZeptosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) petameter per rontosecond. Defined as: ((1000.0)/(1.0/1000.0)) × terameter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerRontosecond = new (
                                                                  "petameter per rontosecond"
                                                                , "Pm/rs"
                                                                , TerameterPerYoctosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per quectosecond. Defined as: ((1000.0)/(1.0/1000.0)) × gigameter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerQuectosecond = new (
                                                                   "terameter per quectosecond"
                                                                 , "Tm/qs"
                                                                 , GigameterPerRontosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quettameter per femtosecond. Defined as: ((1000.0)/(1.0/1000.0)) × ronnameter per picosecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerFemtosecond = new (
                                                                    "quettameter per femtosecond"
                                                                  , "Qm/fs"
                                                                  , RonnameterPerPicosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) ronnameter per attosecond. Defined as: ((1000.0)/(1.0/1000.0)) × yottameter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerAttosecond = new (
                                                                  "ronnameter per attosecond"
                                                                , "Rm/as"
                                                                , YottameterPerFemtosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) yottameter per zeptosecond. Defined as: ((1000.0)/(1.0/1000.0)) × zettameter per attosecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerZeptosecond = new (
                                                                   "yottameter per zeptosecond"
                                                                 , "Ym/zs"
                                                                 , ZettameterPerAttosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zettameter per yoctosecond. Defined as: ((1000.0)/(1.0/1000.0)) × exameter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerYoctosecond = new (
                                                                   "zettameter per yoctosecond"
                                                                 , "Zm/ys"
                                                                 , ExameterPerZeptosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) exameter per rontosecond. Defined as: ((1000.0)/(1.0/1000.0)) × petameter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerRontosecond = new (
                                                                 "exameter per rontosecond"
                                                               , "Em/rs"
                                                               , PetameterPerYoctosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) petameter per quectosecond. Defined as: ((1000.0)/(1.0/1000.0)) × terameter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerQuectosecond = new (
                                                                   "petameter per quectosecond"
                                                                 , "Pm/qs"
                                                                 , TerameterPerRontosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quettameter per attosecond. Defined as: ((1000.0)/(1.0/1000.0)) × ronnameter per femtosecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerAttosecond = new (
                                                                   "quettameter per attosecond"
                                                                 , "Qm/as"
                                                                 , RonnameterPerFemtosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) ronnameter per zeptosecond. Defined as: ((1000.0)/(1.0/1000.0)) × yottameter per attosecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerZeptosecond = new (
                                                                   "ronnameter per zeptosecond"
                                                                 , "Rm/zs"
                                                                 , YottameterPerAttosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yottameter per yoctosecond. Defined as: ((1000.0)/(1.0/1000.0)) × zettameter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerYoctosecond = new (
                                                                   "yottameter per yoctosecond"
                                                                 , "Ym/ys"
                                                                 , ZettameterPerZeptosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zettameter per rontosecond. Defined as: ((1000.0)/(1.0/1000.0)) × exameter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerRontosecond = new (
                                                                   "zettameter per rontosecond"
                                                                 , "Zm/rs"
                                                                 , ExameterPerYoctosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) exameter per quectosecond. Defined as: ((1000.0)/(1.0/1000.0)) × petameter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerQuectosecond = new (
                                                                  "exameter per quectosecond"
                                                                , "Em/qs"
                                                                , PetameterPerRontosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) quettameter per zeptosecond. Defined as: ((1000.0)/(1.0/1000.0)) × ronnameter per attosecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerZeptosecond = new (
                                                                    "quettameter per zeptosecond"
                                                                  , "Qm/zs"
                                                                  , RonnameterPerAttosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) ronnameter per yoctosecond. Defined as: ((1000.0)/(1.0/1000.0)) × yottameter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerYoctosecond = new (
                                                                   "ronnameter per yoctosecond"
                                                                 , "Rm/ys"
                                                                 , YottameterPerZeptosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yottameter per rontosecond. Defined as: ((1000.0)/(1.0/1000.0)) × zettameter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerRontosecond = new (
                                                                   "yottameter per rontosecond"
                                                                 , "Ym/rs"
                                                                 , ZettameterPerYoctosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zettameter per quectosecond. Defined as: ((1000.0)/(1.0/1000.0)) × exameter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerQuectosecond = new (
                                                                    "zettameter per quectosecond"
                                                                  , "Zm/qs"
                                                                  , ExameterPerRontosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quettameter per yoctosecond. Defined as: ((1000.0)/(1.0/1000.0)) × ronnameter per zeptosecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerYoctosecond = new (
                                                                    "quettameter per yoctosecond"
                                                                  , "Qm/ys"
                                                                  , RonnameterPerZeptosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) ronnameter per rontosecond. Defined as: ((1000.0)/(1.0/1000.0)) × yottameter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerRontosecond = new (
                                                                   "ronnameter per rontosecond"
                                                                 , "Rm/rs"
                                                                 , YottameterPerYoctosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yottameter per quectosecond. Defined as: ((1000.0)/(1.0/1000.0)) × zettameter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerQuectosecond = new (
                                                                    "yottameter per quectosecond"
                                                                  , "Ym/qs"
                                                                  , ZettameterPerRontosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quettameter per rontosecond. Defined as: ((1000.0)/(1.0/1000.0)) × ronnameter per yoctosecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerRontosecond = new (
                                                                    "quettameter per rontosecond"
                                                                  , "Qm/rs"
                                                                  , RonnameterPerYoctosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) ronnameter per quectosecond. Defined as: ((1000.0)/(1.0/1000.0)) × yottameter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerQuectosecond = new (
                                                                    "ronnameter per quectosecond"
                                                                  , "Rm/qs"
                                                                  , YottameterPerRontosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quettameter per quectosecond. Defined as: ((1000.0)/(1.0/1000.0)) × ronnameter per rontosecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerQuectosecond = new (
                                                                     "quettameter per quectosecond"
                                                                   , "Qm/qs"
                                                                   , RonnameterPerRontosecond
                                                                   , 1000.0 / (1.0 / 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) meter per minute. Defined as: ((1.0)/(60.0)) × meter per second + (0).
   /// </summary>
   public static readonly Velocity MeterPerMinute = new ("meter per minute", "m/min", MeterPerSecond, 1.0 / 60.0, 0);

   /// <summary>
   /// A(n) meter per hour. Defined as: ((1.0)/(60.0)) × meter per minute + (0).
   /// </summary>
   public static readonly Velocity MeterPerHour = new ("meter per hour", "m/hr", MeterPerMinute, 1.0 / 60.0, 0);

   /// <summary>
   /// A(n) decimeter per minute. Defined as: ((1.0/10.0)/(60.0)) × meter per second + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerMinute = new (
                                                             "decimeter per minute"
                                                           , "dm/min"
                                                           , MeterPerSecond
                                                           , 1.0 / 10.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per day. Defined as: ((1.0)/(24.0)) × meter per hour + (0).
   /// </summary>
   public static readonly Velocity MeterPerDay = new ("meter per day", "m/dy", MeterPerHour, 1.0 / 24.0, 0);

   /// <summary>
   /// A(n) centimeter per minute. Defined as: ((1.0/10.0)/(60.0)) × decimeter per second + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerMinute =
            new ("centimeter per minute", "cm/min", DecimeterPerSecond, 1.0 / 10.0 / 60.0, 0);

   /// <summary>
   /// A(n) meter per week. Defined as: ((1.0)/(7.0)) × meter per day + (0).
   /// </summary>
   public static readonly Velocity MeterPerWeek = new ("meter per week", "m/wk", MeterPerDay, 1.0 / 7.0, 0);

   /// <summary>
   /// A(n) decimeter per hour. Defined as: ((1.0/10.0)/(60.0)) × meter per minute + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerHour = new (
                                                           "decimeter per hour"
                                                         , "dm/hr"
                                                         , MeterPerMinute
                                                         , 1.0 / 10.0 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) millimeter per minute. Defined as: ((1.0/10.0)/(60.0)) × centimeter per second + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerMinute =
            new ("millimeter per minute", "mm/min", CentimeterPerSecond, 1.0 / 10.0 / 60.0, 0);

   /// <summary>
   /// A(n) meter per year. Defined as: ((1.0)/(365.2525)) × meter per day + (0).
   /// </summary>
   public static readonly Velocity MeterPerYear = new ("meter per year", "m/yr", MeterPerDay, 1.0 / 365.2525, 0);

   /// <summary>
   /// A(n) micrometer per minute. Defined as: ((1.0/1000.0)/(60.0)) × millimeter per second + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerMinute = new (
                                                              "micrometer per minute"
                                                            , "μm/min"
                                                            , MillimeterPerSecond
                                                            , 1.0 / 1000.0 / 60.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) meter per decade. Defined as: ((1.0)/(10.0)) × meter per year + (0).
   /// </summary>
   public static readonly Velocity MeterPerDecade = new ("meter per decade", "m/decade", MeterPerYear, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) decimeter per day. Defined as: ((1.0/10.0)/(24.0)) × meter per hour + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerDay = new (
                                                          "decimeter per day"
                                                        , "dm/dy"
                                                        , MeterPerHour
                                                        , 1.0 / 10.0 / 24.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) centimeter per hour. Defined as: ((1.0/10.0)/(60.0)) × decimeter per minute + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerHour = new (
                                                            "centimeter per hour"
                                                          , "cm/hr"
                                                          , DecimeterPerMinute
                                                          , 1.0 / 10.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) nanometer per minute. Defined as: ((1.0/1000.0)/(60.0)) × micrometer per second + (0).
   /// </summary>
   public static readonly Velocity NanometerPerMinute = new (
                                                             "nanometer per minute"
                                                           , "nm/min"
                                                           , MicrometerPerSecond
                                                           , 1.0 / 1000.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per century. Defined as: ((1.0)/(10.0)) × meter per decade + (0).
   /// </summary>
   public static readonly Velocity MeterPerCentury = new (
                                                          "meter per century"
                                                        , "m/century"
                                                        , MeterPerDecade
                                                        , 1.0 / 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) picometer per minute. Defined as: ((1.0/1000.0)/(60.0)) × nanometer per second + (0).
   /// </summary>
   public static readonly Velocity PicometerPerMinute = new (
                                                             "picometer per minute"
                                                           , "pm/min"
                                                           , NanometerPerSecond
                                                           , 1.0 / 1000.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per millennium. Defined as: ((1.0)/(10.0)) × meter per century + (0).
   /// </summary>
   public static readonly Velocity MeterPerMillennium = new (
                                                             "meter per millennium"
                                                           , "m/kyr"
                                                           , MeterPerCentury
                                                           , 1.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) decimeter per week. Defined as: ((1.0/10.0)/(7.0)) × meter per day + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerWeek = new (
                                                           "decimeter per week"
                                                         , "dm/wk"
                                                         , MeterPerDay
                                                         , 1.0 / 10.0 / 7.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) millimeter per hour. Defined as: ((1.0/10.0)/(60.0)) × centimeter per minute + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerHour = new (
                                                            "millimeter per hour"
                                                          , "mm/hr"
                                                          , CentimeterPerMinute
                                                          , 1.0 / 10.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) femtometer per minute. Defined as: ((1.0/1000.0)/(60.0)) × picometer per second + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerMinute =
            new ("femtometer per minute", "fm/min", PicometerPerSecond, 1.0 / 1000.0 / 60.0, 0);

   /// <summary>
   /// A(n) meter per million years. Defined as: ((1.0)/(1000.0)) × meter per millennium + (0).
   /// </summary>
   public static readonly Velocity MeterPerMillionYears =
            new ("meter per million years", "m/Myr", MeterPerMillennium, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) centimeter per day. Defined as: ((1.0/10.0)/(24.0)) × decimeter per hour + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerDay = new (
                                                           "centimeter per day"
                                                         , "cm/dy"
                                                         , DecimeterPerHour
                                                         , 1.0 / 10.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) attometer per minute. Defined as: ((1.0/1000.0)/(60.0)) × femtometer per second + (0).
   /// </summary>
   public static readonly Velocity AttometerPerMinute = new (
                                                             "attometer per minute"
                                                           , "am/min"
                                                           , FemtometerPerSecond
                                                           , 1.0 / 1000.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per billion years. Defined as: ((1.0)/(1000.0)) × meter per million years + (0).
   /// </summary>
   public static readonly Velocity MeterPerBillionYears =
            new ("meter per billion years", "m/Gyr", MeterPerMillionYears, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) decimeter per year. Defined as: ((1.0/10.0)/(365.2525)) × meter per day + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerYear = new (
                                                           "decimeter per year"
                                                         , "dm/yr"
                                                         , MeterPerDay
                                                         , 1.0 / 10.0 / 365.2525
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) micrometer per hour. Defined as: ((1.0/1000.0)/(60.0)) × millimeter per minute + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerHour = new (
                                                            "micrometer per hour"
                                                          , "μm/hr"
                                                          , MillimeterPerMinute
                                                          , 1.0 / 1000.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) zeptometer per minute. Defined as: ((1.0/1000.0)/(60.0)) × attometer per second + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerMinute =
            new ("zeptometer per minute", "zm/min", AttometerPerSecond, 1.0 / 1000.0 / 60.0, 0);

   /// <summary>
   /// A(n) meter per trillion years. Defined as: ((1.0)/(1000.0)) × meter per billion years + (0).
   /// </summary>
   public static readonly Velocity MeterPerTrillionYears =
            new ("meter per trillion years", "m/Tyr", MeterPerBillionYears, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctometer per minute. Defined as: ((1.0/1000.0)/(60.0)) × zeptometer per second + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerMinute = new (
                                                              "yoctometer per minute"
                                                            , "ym/min"
                                                            , ZeptometerPerSecond
                                                            , 1.0 / 1000.0 / 60.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) meter per quadrillion years. Defined as: ((1.0)/(1000.0)) × meter per trillion years + (0).
   /// </summary>
   public static readonly Velocity MeterPerQuadrillionYears =
            new ("meter per quadrillion years", "m/Pyr", MeterPerTrillionYears, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) decimeter per decade. Defined as: ((1.0/10.0)/(10.0)) × meter per year + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerDecade = new (
                                                             "decimeter per decade"
                                                           , "dm/decade"
                                                           , MeterPerYear
                                                           , 1.0 / 10.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) centimeter per week. Defined as: ((1.0/10.0)/(7.0)) × decimeter per day + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerWeek = new (
                                                            "centimeter per week"
                                                          , "cm/wk"
                                                          , DecimeterPerDay
                                                          , 1.0 / 10.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) millimeter per day. Defined as: ((1.0/10.0)/(24.0)) × centimeter per hour + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerDay = new (
                                                           "millimeter per day"
                                                         , "mm/dy"
                                                         , CentimeterPerHour
                                                         , 1.0 / 10.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) nanometer per hour. Defined as: ((1.0/1000.0)/(60.0)) × micrometer per minute + (0).
   /// </summary>
   public static readonly Velocity NanometerPerHour = new (
                                                           "nanometer per hour"
                                                         , "nm/hr"
                                                         , MicrometerPerMinute
                                                         , 1.0 / 1000.0 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) rontometer per minute. Defined as: ((1.0/1000.0)/(60.0)) × yoctometer per second + (0).
   /// </summary>
   public static readonly Velocity RontometerPerMinute = new (
                                                              "rontometer per minute"
                                                            , "rm/min"
                                                            , YoctometerPerSecond
                                                            , 1.0 / 1000.0 / 60.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) meter per quintillion years. Defined as: ((1.0)/(1000.0)) × meter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity MeterPerQuintillionYears =
            new ("meter per quintillion years", "m/Eyr", MeterPerQuadrillionYears, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectometer per minute. Defined as: ((1.0/1000.0)/(60.0)) × rontometer per second + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerMinute = new (
                                                               "quectometer per minute"
                                                             , "qm/min"
                                                             , RontometerPerSecond
                                                             , 1.0 / 1000.0 / 60.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) meter per sextillion years. Defined as: ((1.0)/(1000.0)) × meter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity MeterPerSextillionYears =
            new ("meter per sextillion years", "m/Zyr", MeterPerQuintillionYears, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) decimeter per century. Defined as: ((1.0/10.0)/(10.0)) × meter per decade + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerCentury =
            new ("decimeter per century", "dm/century", MeterPerDecade, 1.0 / 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) picometer per hour. Defined as: ((1.0/1000.0)/(60.0)) × nanometer per minute + (0).
   /// </summary>
   public static readonly Velocity PicometerPerHour = new (
                                                           "picometer per hour"
                                                         , "pm/hr"
                                                         , NanometerPerMinute
                                                         , 1.0 / 1000.0 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) dekameter per minute. Defined as: ((10.0)/(60.0)) × meter per second + (0).
   /// </summary>
   public static readonly Velocity DekameterPerMinute = new (
                                                             "dekameter per minute"
                                                           , "dam/min"
                                                           , MeterPerSecond
                                                           , 10.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per septillion years. Defined as: ((1.0)/(1000.0)) × meter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity MeterPerSeptillionYears =
            new ("meter per septillion years", "m/Yyr", MeterPerSextillionYears, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) centimeter per year. Defined as: ((1.0/10.0)/(365.2525)) × decimeter per day + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerYear = new (
                                                            "centimeter per year"
                                                          , "cm/yr"
                                                          , DecimeterPerDay
                                                          , 1.0 / 10.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) micrometer per day. Defined as: ((1.0/1000.0)/(24.0)) × millimeter per hour + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerDay = new (
                                                           "micrometer per day"
                                                         , "μm/dy"
                                                         , MillimeterPerHour
                                                         , 1.0 / 1000.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) hectometer per minute. Defined as: ((10.0)/(60.0)) × dekameter per second + (0).
   /// </summary>
   public static readonly Velocity HectometerPerMinute =
            new ("hectometer per minute", "hm/min", DekameterPerSecond, 10.0 / 60.0, 0);

   /// <summary>
   /// A(n) meter per octillion years. Defined as: ((1.0)/(1000.0)) × meter per septillion years + (0).
   /// </summary>
   public static readonly Velocity MeterPerOctillionYears =
            new ("meter per octillion years", "m/Ryr", MeterPerSeptillionYears, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) decimeter per millennium. Defined as: ((1.0/10.0)/(10.0)) × meter per century + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerMillennium =
            new ("decimeter per millennium", "dm/kyr", MeterPerCentury, 1.0 / 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) millimeter per week. Defined as: ((1.0/10.0)/(7.0)) × centimeter per day + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerWeek = new (
                                                            "millimeter per week"
                                                          , "mm/wk"
                                                          , CentimeterPerDay
                                                          , 1.0 / 10.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) femtometer per hour. Defined as: ((1.0/1000.0)/(60.0)) × picometer per minute + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerHour = new (
                                                            "femtometer per hour"
                                                          , "fm/hr"
                                                          , PicometerPerMinute
                                                          , 1.0 / 1000.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) kilometer per minute. Defined as: ((10.0)/(60.0)) × hectometer per second + (0).
   /// </summary>
   public static readonly Velocity KilometerPerMinute = new (
                                                             "kilometer per minute"
                                                           , "km/min"
                                                           , HectometerPerSecond
                                                           , 10.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per nonillion years. Defined as: ((1.0)/(1000.0)) × meter per octillion years + (0).
   /// </summary>
   public static readonly Velocity MeterPerNonillionYears =
            new ("meter per nonillion years", "m/Qyr", MeterPerOctillionYears, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) megameter per minute. Defined as: ((1000.0)/(60.0)) × kilometer per second + (0).
   /// </summary>
   public static readonly Velocity MegameterPerMinute = new (
                                                             "megameter per minute"
                                                           , "Mm/min"
                                                           , KilometerPerSecond
                                                           , 1000.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per decillion years. Defined as: ((1.0)/(1000.0)) × meter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity MeterPerDecillionYears = new (
                                                                 "meter per decillion years"
                                                               , "m/decillion yr"
                                                               , MeterPerNonillionYears
                                                               , 1.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) decimeter per million years. Defined as: ((1.0/10.0)/(1000.0)) × meter per millennium + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerMillionYears = new (
                                                                   "decimeter per million years"
                                                                 , "dm/Myr"
                                                                 , MeterPerMillennium
                                                                 , 1.0 / 10.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centimeter per decade. Defined as: ((1.0/10.0)/(10.0)) × decimeter per year + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerDecade =
            new ("centimeter per decade", "cm/decade", DecimeterPerYear, 1.0 / 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) nanometer per day. Defined as: ((1.0/1000.0)/(24.0)) × micrometer per hour + (0).
   /// </summary>
   public static readonly Velocity NanometerPerDay = new (
                                                          "nanometer per day"
                                                        , "nm/dy"
                                                        , MicrometerPerHour
                                                        , 1.0 / 1000.0 / 24.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) attometer per hour. Defined as: ((1.0/1000.0)/(60.0)) × femtometer per minute + (0).
   /// </summary>
   public static readonly Velocity AttometerPerHour = new (
                                                           "attometer per hour"
                                                         , "am/hr"
                                                         , FemtometerPerMinute
                                                         , 1.0 / 1000.0 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) gigameter per minute. Defined as: ((1000.0)/(60.0)) × megameter per second + (0).
   /// </summary>
   public static readonly Velocity GigameterPerMinute = new (
                                                             "gigameter per minute"
                                                           , "Gm/min"
                                                           , MegameterPerSecond
                                                           , 1000.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) meter per planck-time. Defined as: ((1.0)/(5.391247E-38)) × meter per microsecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerPlanckTime = new (
                                                             "meter per planck-time"
                                                           , "m/tₚ"
                                                           , MeterPerMicrosecond
                                                           , 1.0 / 5.391247E-38
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) terameter per minute. Defined as: ((1000.0)/(60.0)) × gigameter per second + (0).
   /// </summary>
   public static readonly Velocity TerameterPerMinute = new (
                                                             "terameter per minute"
                                                           , "Tm/min"
                                                           , GigameterPerSecond
                                                           , 1000.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) decimeter per billion years. Defined as: ((1.0/10.0)/(1000.0)) × meter per million years + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerBillionYears = new (
                                                                   "decimeter per billion years"
                                                                 , "dm/Gyr"
                                                                 , MeterPerMillionYears
                                                                 , 1.0 / 10.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) millimeter per year. Defined as: ((1.0/10.0)/(365.2525)) × centimeter per day + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerYear = new (
                                                            "millimeter per year"
                                                          , "mm/yr"
                                                          , CentimeterPerDay
                                                          , 1.0 / 10.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) micrometer per week. Defined as: ((1.0/1000.0)/(7.0)) × millimeter per day + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerWeek = new (
                                                            "micrometer per week"
                                                          , "μm/wk"
                                                          , MillimeterPerDay
                                                          , 1.0 / 1000.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) zeptometer per hour. Defined as: ((1.0/1000.0)/(60.0)) × attometer per minute + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerHour = new (
                                                            "zeptometer per hour"
                                                          , "zm/hr"
                                                          , AttometerPerMinute
                                                          , 1.0 / 1000.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) petameter per minute. Defined as: ((1000.0)/(60.0)) × terameter per second + (0).
   /// </summary>
   public static readonly Velocity PetameterPerMinute = new (
                                                             "petameter per minute"
                                                           , "Pm/min"
                                                           , TerameterPerSecond
                                                           , 1000.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) centimeter per century. Defined as: ((1.0/10.0)/(10.0)) × decimeter per decade + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerCentury = new (
                                                               "centimeter per century"
                                                             , "cm/century"
                                                             , DecimeterPerDecade
                                                             , 1.0 / 10.0 / 10.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) picometer per day. Defined as: ((1.0/1000.0)/(24.0)) × nanometer per hour + (0).
   /// </summary>
   public static readonly Velocity PicometerPerDay = new (
                                                          "picometer per day"
                                                        , "pm/dy"
                                                        , NanometerPerHour
                                                        , 1.0 / 1000.0 / 24.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) exameter per minute. Defined as: ((1000.0)/(60.0)) × petameter per second + (0).
   /// </summary>
   public static readonly Velocity ExameterPerMinute = new (
                                                            "exameter per minute"
                                                          , "Em/min"
                                                          , PetameterPerSecond
                                                          , 1000.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) decimeter per trillion years. Defined as: ((1.0/10.0)/(1000.0)) × meter per billion years + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerTrillionYears = new (
                                                                    "decimeter per trillion years"
                                                                  , "dm/Tyr"
                                                                  , MeterPerBillionYears
                                                                  , 1.0 / 10.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctometer per hour. Defined as: ((1.0/1000.0)/(60.0)) × zeptometer per minute + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerHour = new (
                                                            "yoctometer per hour"
                                                          , "ym/hr"
                                                          , ZeptometerPerMinute
                                                          , 1.0 / 1000.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) zettameter per minute. Defined as: ((1000.0)/(60.0)) × exameter per second + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerMinute =
            new ("zettameter per minute", "Zm/min", ExameterPerSecond, 1000.0 / 60.0, 0);

   /// <summary>
   /// A(n) yottameter per minute. Defined as: ((1000.0)/(60.0)) × zettameter per second + (0).
   /// </summary>
   public static readonly Velocity YottameterPerMinute =
            new ("yottameter per minute", "Ym/min", ZettameterPerSecond, 1000.0 / 60.0, 0);

   /// <summary>
   /// A(n) decimeter per quadrillion years. Defined as: ((1.0/10.0)/(1000.0)) × meter per trillion years + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerQuadrillionYears = new (
                                                                       "decimeter per quadrillion years"
                                                                     , "dm/Pyr"
                                                                     , MeterPerTrillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) centimeter per millennium. Defined as: ((1.0/10.0)/(10.0)) × decimeter per century + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerMillennium =
            new ("centimeter per millennium", "cm/kyr", DecimeterPerCentury, 1.0 / 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) millimeter per decade. Defined as: ((1.0/10.0)/(10.0)) × centimeter per year + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerDecade =
            new ("millimeter per decade", "mm/decade", CentimeterPerYear, 1.0 / 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) nanometer per week. Defined as: ((1.0/1000.0)/(7.0)) × micrometer per day + (0).
   /// </summary>
   public static readonly Velocity NanometerPerWeek = new (
                                                           "nanometer per week"
                                                         , "nm/wk"
                                                         , MicrometerPerDay
                                                         , 1.0 / 1000.0 / 7.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) femtometer per day. Defined as: ((1.0/1000.0)/(24.0)) × picometer per hour + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerDay = new (
                                                           "femtometer per day"
                                                         , "fm/dy"
                                                         , PicometerPerHour
                                                         , 1.0 / 1000.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) rontometer per hour. Defined as: ((1.0/1000.0)/(60.0)) × yoctometer per minute + (0).
   /// </summary>
   public static readonly Velocity RontometerPerHour = new (
                                                            "rontometer per hour"
                                                          , "rm/hr"
                                                          , YoctometerPerMinute
                                                          , 1.0 / 1000.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) ronnameter per minute. Defined as: ((1000.0)/(60.0)) × yottameter per second + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerMinute =
            new ("ronnameter per minute", "Rm/min", YottameterPerSecond, 1000.0 / 60.0, 0);

   /// <summary>
   /// A(n) meter per tick. Defined as: ((1.0)/(100.0)) × meter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MeterPerTick = new ("meter per tick", "m/tick", MeterPerNanosecond, 1.0 / 100.0, 0);

   /// <summary>
   /// A(n) micrometer per year. Defined as: ((1.0/1000.0)/(365.2525)) × millimeter per day + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerYear = new (
                                                            "micrometer per year"
                                                          , "μm/yr"
                                                          , MillimeterPerDay
                                                          , 1.0 / 1000.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) quettameter per minute. Defined as: ((1000.0)/(60.0)) × ronnameter per second + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerMinute =
            new ("quettameter per minute", "Qm/min", RonnameterPerSecond, 1000.0 / 60.0, 0);

   /// <summary>
   /// A(n) decimeter per quintillion years. Defined as: ((1.0/10.0)/(1000.0)) × meter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerQuintillionYears = new (
                                                                       "decimeter per quintillion years"
                                                                     , "dm/Eyr"
                                                                     , MeterPerQuadrillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) quectometer per hour. Defined as: ((1.0/1000.0)/(60.0)) × rontometer per minute + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerHour = new (
                                                             "quectometer per hour"
                                                           , "qm/hr"
                                                           , RontometerPerMinute
                                                           , 1.0 / 1000.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) centimeter per million years. Defined as: ((1.0/10.0)/(1000.0)) × decimeter per millennium + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerMillionYears = new (
                                                                    "centimeter per million years"
                                                                  , "cm/Myr"
                                                                  , DecimeterPerMillennium
                                                                  , 1.0 / 10.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attometer per day. Defined as: ((1.0/1000.0)/(24.0)) × femtometer per hour + (0).
   /// </summary>
   public static readonly Velocity AttometerPerDay = new (
                                                          "attometer per day"
                                                        , "am/dy"
                                                        , FemtometerPerHour
                                                        , 1.0 / 1000.0 / 24.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) decimeter per sextillion years. Defined as: ((1.0/10.0)/(1000.0)) × meter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerSextillionYears = new (
                                                                      "decimeter per sextillion years"
                                                                    , "dm/Zyr"
                                                                    , MeterPerQuintillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) millimeter per century. Defined as: ((1.0/10.0)/(10.0)) × centimeter per decade + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerCentury = new (
                                                               "millimeter per century"
                                                             , "mm/century"
                                                             , CentimeterPerDecade
                                                             , 1.0 / 10.0 / 10.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) picometer per week. Defined as: ((1.0/1000.0)/(7.0)) × nanometer per day + (0).
   /// </summary>
   public static readonly Velocity PicometerPerWeek = new (
                                                           "picometer per week"
                                                         , "pm/wk"
                                                         , NanometerPerDay
                                                         , 1.0 / 1000.0 / 7.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) dekameter per hour. Defined as: ((10.0)/(60.0)) × meter per minute + (0).
   /// </summary>
   public static readonly Velocity DekameterPerHour = new (
                                                           "dekameter per hour"
                                                         , "dam/hr"
                                                         , MeterPerMinute
                                                         , 10.0 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) decimeter per septillion years. Defined as: ((1.0/10.0)/(1000.0)) × meter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerSeptillionYears = new (
                                                                      "decimeter per septillion years"
                                                                    , "dm/Yyr"
                                                                    , MeterPerSextillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) centimeter per billion years. Defined as: ((1.0/10.0)/(1000.0)) × decimeter per million years + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerBillionYears = new (
                                                                    "centimeter per billion years"
                                                                  , "cm/Gyr"
                                                                  , DecimeterPerMillionYears
                                                                  , 1.0 / 10.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) micrometer per decade. Defined as: ((1.0/1000.0)/(10.0)) × millimeter per year + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerDecade = new (
                                                              "micrometer per decade"
                                                            , "μm/decade"
                                                            , MillimeterPerYear
                                                            , 1.0 / 1000.0 / 10.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) nanometer per year. Defined as: ((1.0/1000.0)/(365.2525)) × micrometer per day + (0).
   /// </summary>
   public static readonly Velocity NanometerPerYear = new (
                                                           "nanometer per year"
                                                         , "nm/yr"
                                                         , MicrometerPerDay
                                                         , 1.0 / 1000.0 / 365.2525
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) zeptometer per day. Defined as: ((1.0/1000.0)/(24.0)) × attometer per hour + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerDay = new (
                                                           "zeptometer per day"
                                                         , "zm/dy"
                                                         , AttometerPerHour
                                                         , 1.0 / 1000.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) hectometer per hour. Defined as: ((10.0)/(60.0)) × dekameter per minute + (0).
   /// </summary>
   public static readonly Velocity HectometerPerHour = new (
                                                            "hectometer per hour"
                                                          , "hm/hr"
                                                          , DekameterPerMinute
                                                          , 10.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) decimeter per octillion years. Defined as: ((1.0/10.0)/(1000.0)) × meter per septillion years + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerOctillionYears = new (
                                                                     "decimeter per octillion years"
                                                                   , "dm/Ryr"
                                                                   , MeterPerSeptillionYears
                                                                   , 1.0 / 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) millimeter per millennium. Defined as: ((1.0/10.0)/(10.0)) × centimeter per century + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerMillennium = new (
                                                                  "millimeter per millennium"
                                                                , "mm/kyr"
                                                                , CentimeterPerCentury
                                                                , 1.0 / 10.0 / 10.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) femtometer per week. Defined as: ((1.0/1000.0)/(7.0)) × picometer per day + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerWeek = new (
                                                            "femtometer per week"
                                                          , "fm/wk"
                                                          , PicometerPerDay
                                                          , 1.0 / 1000.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) kilometer per hour. Defined as: ((10.0)/(60.0)) × hectometer per minute + (0).
   /// </summary>
   public static readonly Velocity KilometerPerHour = new (
                                                           "kilometer per hour"
                                                         , "km/hr"
                                                         , HectometerPerMinute
                                                         , 10.0 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) centimeter per trillion years. Defined as: ((1.0/10.0)/(1000.0)) × decimeter per billion years + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerTrillionYears = new (
                                                                     "centimeter per trillion years"
                                                                   , "cm/Tyr"
                                                                   , DecimeterPerBillionYears
                                                                   , 1.0 / 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctometer per day. Defined as: ((1.0/1000.0)/(24.0)) × zeptometer per hour + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerDay = new (
                                                           "yoctometer per day"
                                                         , "ym/dy"
                                                         , ZeptometerPerHour
                                                         , 1.0 / 1000.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) decimeter per nonillion years. Defined as: ((1.0/10.0)/(1000.0)) × meter per octillion years + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerNonillionYears = new (
                                                                     "decimeter per nonillion years"
                                                                   , "dm/Qyr"
                                                                   , MeterPerOctillionYears
                                                                   , 1.0 / 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) megameter per hour. Defined as: ((1000.0)/(60.0)) × kilometer per minute + (0).
   /// </summary>
   public static readonly Velocity MegameterPerHour = new (
                                                           "megameter per hour"
                                                         , "Mm/hr"
                                                         , KilometerPerMinute
                                                         , 1000.0 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) micrometer per century. Defined as: ((1.0/1000.0)/(10.0)) × millimeter per decade + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerCentury = new (
                                                               "micrometer per century"
                                                             , "μm/century"
                                                             , MillimeterPerDecade
                                                             , 1.0 / 1000.0 / 10.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) picometer per year. Defined as: ((1.0/1000.0)/(365.2525)) × nanometer per day + (0).
   /// </summary>
   public static readonly Velocity PicometerPerYear = new (
                                                           "picometer per year"
                                                         , "pm/yr"
                                                         , NanometerPerDay
                                                         , 1.0 / 1000.0 / 365.2525
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) decimeter per decillion years. Defined as: ((1.0/10.0)/(1000.0)) × meter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerDecillionYears = new (
                                                                     "decimeter per decillion years"
                                                                   , "dm/decillion yr"
                                                                   , MeterPerNonillionYears
                                                                   , 1.0 / 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) centimeter per quadrillion years. Defined as: ((1.0/10.0)/(1000.0)) × decimeter per trillion years + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerQuadrillionYears = new (
                                                                        "centimeter per quadrillion years"
                                                                      , "cm/Pyr"
                                                                      , DecimeterPerTrillionYears
                                                                      , 1.0 / 10.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) millimeter per million years. Defined as: ((1.0/10.0)/(1000.0)) × centimeter per millennium + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerMillionYears = new (
                                                                    "millimeter per million years"
                                                                  , "mm/Myr"
                                                                  , CentimeterPerMillennium
                                                                  , 1.0 / 10.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanometer per decade. Defined as: ((1.0/1000.0)/(10.0)) × micrometer per year + (0).
   /// </summary>
   public static readonly Velocity NanometerPerDecade = new (
                                                             "nanometer per decade"
                                                           , "nm/decade"
                                                           , MicrometerPerYear
                                                           , 1.0 / 1000.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) attometer per week. Defined as: ((1.0/1000.0)/(7.0)) × femtometer per day + (0).
   /// </summary>
   public static readonly Velocity AttometerPerWeek = new (
                                                           "attometer per week"
                                                         , "am/wk"
                                                         , FemtometerPerDay
                                                         , 1.0 / 1000.0 / 7.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) rontometer per day. Defined as: ((1.0/1000.0)/(24.0)) × yoctometer per hour + (0).
   /// </summary>
   public static readonly Velocity RontometerPerDay = new (
                                                           "rontometer per day"
                                                         , "rm/dy"
                                                         , YoctometerPerHour
                                                         , 1.0 / 1000.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) gigameter per hour. Defined as: ((1000.0)/(60.0)) × megameter per minute + (0).
   /// </summary>
   public static readonly Velocity GigameterPerHour = new (
                                                           "gigameter per hour"
                                                         , "Gm/hr"
                                                         , MegameterPerMinute
                                                         , 1000.0 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) decimeter per planck-time. Defined as: ((1.0/10.0)/(5.391247E-38)) × meter per microsecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerPlanckTime = new (
                                                                 "decimeter per planck-time"
                                                               , "dm/tₚ"
                                                               , MeterPerMicrosecond
                                                               , 1.0 / 10.0 / 5.391247E-38
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per hour. Defined as: ((1000.0)/(60.0)) × gigameter per minute + (0).
   /// </summary>
   public static readonly Velocity TerameterPerHour = new (
                                                           "terameter per hour"
                                                         , "Tm/hr"
                                                         , GigameterPerMinute
                                                         , 1000.0 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) centimeter per quintillion years. Defined as: ((1.0/10.0)/(1000.0)) × decimeter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerQuintillionYears = new (
                                                                        "centimeter per quintillion years"
                                                                      , "cm/Eyr"
                                                                      , DecimeterPerQuadrillionYears
                                                                      , 1.0 / 10.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) quectometer per day. Defined as: ((1.0/1000.0)/(24.0)) × rontometer per hour + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerDay = new (
                                                            "quectometer per day"
                                                          , "qm/dy"
                                                          , RontometerPerHour
                                                          , 1.0 / 1000.0 / 24.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) millimeter per billion years. Defined as: ((1.0/10.0)/(1000.0)) × centimeter per million years + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerBillionYears = new (
                                                                    "millimeter per billion years"
                                                                  , "mm/Gyr"
                                                                  , CentimeterPerMillionYears
                                                                  , 1.0 / 10.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) micrometer per millennium. Defined as: ((1.0/1000.0)/(10.0)) × millimeter per century + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerMillennium = new (
                                                                  "micrometer per millennium"
                                                                , "μm/kyr"
                                                                , MillimeterPerCentury
                                                                , 1.0 / 1000.0 / 10.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) femtometer per year. Defined as: ((1.0/1000.0)/(365.2525)) × picometer per day + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerYear = new (
                                                            "femtometer per year"
                                                          , "fm/yr"
                                                          , PicometerPerDay
                                                          , 1.0 / 1000.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) zeptometer per week. Defined as: ((1.0/1000.0)/(7.0)) × attometer per day + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerWeek = new (
                                                            "zeptometer per week"
                                                          , "zm/wk"
                                                          , AttometerPerDay
                                                          , 1.0 / 1000.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) petameter per hour. Defined as: ((1000.0)/(60.0)) × terameter per minute + (0).
   /// </summary>
   public static readonly Velocity PetameterPerHour = new (
                                                           "petameter per hour"
                                                         , "Pm/hr"
                                                         , TerameterPerMinute
                                                         , 1000.0 / 60.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) centimeter per sextillion years. Defined as: ((1.0/10.0)/(1000.0)) × decimeter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerSextillionYears = new (
                                                                       "centimeter per sextillion years"
                                                                     , "cm/Zyr"
                                                                     , DecimeterPerQuintillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) nanometer per century. Defined as: ((1.0/1000.0)/(10.0)) × micrometer per decade + (0).
   /// </summary>
   public static readonly Velocity NanometerPerCentury = new (
                                                              "nanometer per century"
                                                            , "nm/century"
                                                            , MicrometerPerDecade
                                                            , 1.0 / 1000.0 / 10.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) picometer per decade. Defined as: ((1.0/1000.0)/(10.0)) × nanometer per year + (0).
   /// </summary>
   public static readonly Velocity PicometerPerDecade = new (
                                                             "picometer per decade"
                                                           , "pm/decade"
                                                           , NanometerPerYear
                                                           , 1.0 / 1000.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) dekameter per day. Defined as: ((10.0)/(24.0)) × meter per hour + (0).
   /// </summary>
   public static readonly Velocity DekameterPerDay = new ("dekameter per day", "dam/dy", MeterPerHour, 10.0 / 24.0, 0);

   /// <summary>
   /// A(n) exameter per hour. Defined as: ((1000.0)/(60.0)) × petameter per minute + (0).
   /// </summary>
   public static readonly Velocity ExameterPerHour = new (
                                                          "exameter per hour"
                                                        , "Em/hr"
                                                        , PetameterPerMinute
                                                        , 1000.0 / 60.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) millimeter per trillion years. Defined as: ((1.0/10.0)/(1000.0)) × centimeter per billion years + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerTrillionYears = new (
                                                                     "millimeter per trillion years"
                                                                   , "mm/Tyr"
                                                                   , CentimeterPerBillionYears
                                                                   , 1.0 / 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctometer per week. Defined as: ((1.0/1000.0)/(7.0)) × zeptometer per day + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerWeek = new (
                                                            "yoctometer per week"
                                                          , "ym/wk"
                                                          , ZeptometerPerDay
                                                          , 1.0 / 1000.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) zettameter per hour. Defined as: ((1000.0)/(60.0)) × exameter per minute + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerHour = new (
                                                            "zettameter per hour"
                                                          , "Zm/hr"
                                                          , ExameterPerMinute
                                                          , 1000.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) centimeter per septillion years. Defined as: ((1.0/10.0)/(1000.0)) × decimeter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerSeptillionYears = new (
                                                                       "centimeter per septillion years"
                                                                     , "cm/Yyr"
                                                                     , DecimeterPerSextillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) micrometer per million years. Defined as: ((1.0/1000.0)/(1000.0)) × millimeter per millennium + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerMillionYears = new (
                                                                    "micrometer per million years"
                                                                  , "μm/Myr"
                                                                  , MillimeterPerMillennium
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attometer per year. Defined as: ((1.0/1000.0)/(365.2525)) × femtometer per day + (0).
   /// </summary>
   public static readonly Velocity AttometerPerYear = new (
                                                           "attometer per year"
                                                         , "am/yr"
                                                         , FemtometerPerDay
                                                         , 1.0 / 1000.0 / 365.2525
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) hectometer per day. Defined as: ((10.0)/(24.0)) × dekameter per hour + (0).
   /// </summary>
   public static readonly Velocity HectometerPerDay = new (
                                                           "hectometer per day"
                                                         , "hm/dy"
                                                         , DekameterPerHour
                                                         , 10.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) yottameter per hour. Defined as: ((1000.0)/(60.0)) × zettameter per minute + (0).
   /// </summary>
   public static readonly Velocity YottameterPerHour = new (
                                                            "yottameter per hour"
                                                          , "Ym/hr"
                                                          , ZettameterPerMinute
                                                          , 1000.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) centimeter per octillion years. Defined as: ((1.0/10.0)/(1000.0)) × decimeter per septillion years + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerOctillionYears = new (
                                                                      "centimeter per octillion years"
                                                                    , "cm/Ryr"
                                                                    , DecimeterPerSeptillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) millimeter per quadrillion years. Defined as: ((1.0/10.0)/(1000.0)) × centimeter per trillion years + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerQuadrillionYears = new (
                                                                        "millimeter per quadrillion years"
                                                                      , "mm/Pyr"
                                                                      , CentimeterPerTrillionYears
                                                                      , 1.0 / 10.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) nanometer per millennium. Defined as: ((1.0/1000.0)/(10.0)) × micrometer per century + (0).
   /// </summary>
   public static readonly Velocity NanometerPerMillennium = new (
                                                                 "nanometer per millennium"
                                                               , "nm/kyr"
                                                               , MicrometerPerCentury
                                                               , 1.0 / 1000.0 / 10.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) femtometer per decade. Defined as: ((1.0/1000.0)/(10.0)) × picometer per year + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerDecade = new (
                                                              "femtometer per decade"
                                                            , "fm/decade"
                                                            , PicometerPerYear
                                                            , 1.0 / 1000.0 / 10.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) rontometer per week. Defined as: ((1.0/1000.0)/(7.0)) × yoctometer per day + (0).
   /// </summary>
   public static readonly Velocity RontometerPerWeek = new (
                                                            "rontometer per week"
                                                          , "rm/wk"
                                                          , YoctometerPerDay
                                                          , 1.0 / 1000.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) kilometer per day. Defined as: ((10.0)/(24.0)) × hectometer per hour + (0).
   /// </summary>
   public static readonly Velocity KilometerPerDay = new (
                                                          "kilometer per day"
                                                        , "km/dy"
                                                        , HectometerPerHour
                                                        , 10.0 / 24.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) ronnameter per hour. Defined as: ((1000.0)/(60.0)) × yottameter per minute + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerHour = new (
                                                            "ronnameter per hour"
                                                          , "Rm/hr"
                                                          , YottameterPerMinute
                                                          , 1000.0 / 60.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) picometer per century. Defined as: ((1.0/1000.0)/(10.0)) × nanometer per decade + (0).
   /// </summary>
   public static readonly Velocity PicometerPerCentury = new (
                                                              "picometer per century"
                                                            , "pm/century"
                                                            , NanometerPerDecade
                                                            , 1.0 / 1000.0 / 10.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) decimeter per tick. Defined as: ((1.0/10.0)/(100.0)) × meter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity DecimeterPerTick = new (
                                                           "decimeter per tick"
                                                         , "dm/tick"
                                                         , MeterPerNanosecond
                                                         , 1.0 / 10.0 / 100.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) micrometer per billion years. Defined as: ((1.0/1000.0)/(1000.0)) × millimeter per million years + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerBillionYears = new (
                                                                    "micrometer per billion years"
                                                                  , "μm/Gyr"
                                                                  , MillimeterPerMillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptometer per year. Defined as: ((1.0/1000.0)/(365.2525)) × attometer per day + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerYear = new (
                                                            "zeptometer per year"
                                                          , "zm/yr"
                                                          , AttometerPerDay
                                                          , 1.0 / 1000.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) quettameter per hour. Defined as: ((1000.0)/(60.0)) × ronnameter per minute + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerHour = new (
                                                             "quettameter per hour"
                                                           , "Qm/hr"
                                                           , RonnameterPerMinute
                                                           , 1000.0 / 60.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) centimeter per nonillion years. Defined as: ((1.0/10.0)/(1000.0)) × decimeter per octillion years + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerNonillionYears = new (
                                                                      "centimeter per nonillion years"
                                                                    , "cm/Qyr"
                                                                    , DecimeterPerOctillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) megameter per day. Defined as: ((1000.0)/(24.0)) × kilometer per hour + (0).
   /// </summary>
   public static readonly Velocity MegameterPerDay = new (
                                                          "megameter per day"
                                                        , "Mm/dy"
                                                        , KilometerPerHour
                                                        , 1000.0 / 24.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) millimeter per quintillion years. Defined as: ((1.0/10.0)/(1000.0)) × centimeter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerQuintillionYears = new (
                                                                        "millimeter per quintillion years"
                                                                      , "mm/Eyr"
                                                                      , CentimeterPerQuadrillionYears
                                                                      , 1.0 / 10.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) quectometer per week. Defined as: ((1.0/1000.0)/(7.0)) × rontometer per day + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerWeek = new (
                                                             "quectometer per week"
                                                           , "qm/wk"
                                                           , RontometerPerDay
                                                           , 1.0 / 1000.0 / 7.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) centimeter per decillion years. Defined as: ((1.0/10.0)/(1000.0)) × decimeter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerDecillionYears = new (
                                                                      "centimeter per decillion years"
                                                                    , "cm/decillion yr"
                                                                    , DecimeterPerNonillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) nanometer per million years. Defined as: ((1.0/1000.0)/(1000.0)) × micrometer per millennium + (0).
   /// </summary>
   public static readonly Velocity NanometerPerMillionYears = new (
                                                                   "nanometer per million years"
                                                                 , "nm/Myr"
                                                                 , MicrometerPerMillennium
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attometer per decade. Defined as: ((1.0/1000.0)/(10.0)) × femtometer per year + (0).
   /// </summary>
   public static readonly Velocity AttometerPerDecade = new (
                                                             "attometer per decade"
                                                           , "am/decade"
                                                           , FemtometerPerYear
                                                           , 1.0 / 1000.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) gigameter per day. Defined as: ((1000.0)/(24.0)) × megameter per hour + (0).
   /// </summary>
   public static readonly Velocity GigameterPerDay = new (
                                                          "gigameter per day"
                                                        , "Gm/dy"
                                                        , MegameterPerHour
                                                        , 1000.0 / 24.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) micrometer per trillion years. Defined as: ((1.0/1000.0)/(1000.0)) × millimeter per billion years + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerTrillionYears = new (
                                                                     "micrometer per trillion years"
                                                                   , "μm/Tyr"
                                                                   , MillimeterPerBillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctometer per year. Defined as: ((1.0/1000.0)/(365.2525)) × zeptometer per day + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerYear = new (
                                                            "yoctometer per year"
                                                          , "ym/yr"
                                                          , ZeptometerPerDay
                                                          , 1.0 / 1000.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) millimeter per sextillion years. Defined as: ((1.0/10.0)/(1000.0)) × centimeter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerSextillionYears = new (
                                                                       "millimeter per sextillion years"
                                                                     , "mm/Zyr"
                                                                     , CentimeterPerQuintillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) picometer per millennium. Defined as: ((1.0/1000.0)/(10.0)) × nanometer per century + (0).
   /// </summary>
   public static readonly Velocity PicometerPerMillennium = new (
                                                                 "picometer per millennium"
                                                               , "pm/kyr"
                                                               , NanometerPerCentury
                                                               , 1.0 / 1000.0 / 10.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) femtometer per century. Defined as: ((1.0/1000.0)/(10.0)) × picometer per decade + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerCentury = new (
                                                               "femtometer per century"
                                                             , "fm/century"
                                                             , PicometerPerDecade
                                                             , 1.0 / 1000.0 / 10.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) dekameter per week. Defined as: ((10.0)/(7.0)) × meter per day + (0).
   /// </summary>
   public static readonly Velocity DekameterPerWeek = new ("dekameter per week", "dam/wk", MeterPerDay, 10.0 / 7.0, 0);

   /// <summary>
   /// A(n) centimeter per planck-time. Defined as: ((1.0/10.0)/(5.391247E-38)) × decimeter per microsecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerPlanckTime = new (
                                                                  "centimeter per planck-time"
                                                                , "cm/tₚ"
                                                                , DecimeterPerMicrosecond
                                                                , 1.0 / 10.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per day. Defined as: ((1000.0)/(24.0)) × gigameter per hour + (0).
   /// </summary>
   public static readonly Velocity TerameterPerDay = new (
                                                          "terameter per day"
                                                        , "Tm/dy"
                                                        , GigameterPerHour
                                                        , 1000.0 / 24.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) millimeter per septillion years. Defined as: ((1.0/10.0)/(1000.0)) × centimeter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerSeptillionYears = new (
                                                                       "millimeter per septillion years"
                                                                     , "mm/Yyr"
                                                                     , CentimeterPerSextillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) micrometer per quadrillion years. Defined as: ((1.0/1000.0)/(1000.0)) × millimeter per trillion years + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerQuadrillionYears = new (
                                                                        "micrometer per quadrillion years"
                                                                      , "μm/Pyr"
                                                                      , MillimeterPerTrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) nanometer per billion years. Defined as: ((1.0/1000.0)/(1000.0)) × micrometer per million years + (0).
   /// </summary>
   public static readonly Velocity NanometerPerBillionYears = new (
                                                                   "nanometer per billion years"
                                                                 , "nm/Gyr"
                                                                 , MicrometerPerMillionYears
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptometer per decade. Defined as: ((1.0/1000.0)/(10.0)) × attometer per year + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerDecade = new (
                                                              "zeptometer per decade"
                                                            , "zm/decade"
                                                            , AttometerPerYear
                                                            , 1.0 / 1000.0 / 10.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) rontometer per year. Defined as: ((1.0/1000.0)/(365.2525)) × yoctometer per day + (0).
   /// </summary>
   public static readonly Velocity RontometerPerYear = new (
                                                            "rontometer per year"
                                                          , "rm/yr"
                                                          , YoctometerPerDay
                                                          , 1.0 / 1000.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) hectometer per week. Defined as: ((10.0)/(7.0)) × dekameter per day + (0).
   /// </summary>
   public static readonly Velocity HectometerPerWeek = new (
                                                            "hectometer per week"
                                                          , "hm/wk"
                                                          , DekameterPerDay
                                                          , 10.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) petameter per day. Defined as: ((1000.0)/(24.0)) × terameter per hour + (0).
   /// </summary>
   public static readonly Velocity PetameterPerDay = new (
                                                          "petameter per day"
                                                        , "Pm/dy"
                                                        , TerameterPerHour
                                                        , 1000.0 / 24.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) picometer per million years. Defined as: ((1.0/1000.0)/(1000.0)) × nanometer per millennium + (0).
   /// </summary>
   public static readonly Velocity PicometerPerMillionYears = new (
                                                                   "picometer per million years"
                                                                 , "pm/Myr"
                                                                 , NanometerPerMillennium
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attometer per century. Defined as: ((1.0/1000.0)/(10.0)) × femtometer per decade + (0).
   /// </summary>
   public static readonly Velocity AttometerPerCentury = new (
                                                              "attometer per century"
                                                            , "am/century"
                                                            , FemtometerPerDecade
                                                            , 1.0 / 1000.0 / 10.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) exameter per day. Defined as: ((1000.0)/(24.0)) × petameter per hour + (0).
   /// </summary>
   public static readonly Velocity ExameterPerDay = new (
                                                         "exameter per day"
                                                       , "Em/dy"
                                                       , PetameterPerHour
                                                       , 1000.0 / 24.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) millimeter per octillion years. Defined as: ((1.0/10.0)/(1000.0)) × centimeter per septillion years + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerOctillionYears = new (
                                                                      "millimeter per octillion years"
                                                                    , "mm/Ryr"
                                                                    , CentimeterPerSeptillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) femtometer per millennium. Defined as: ((1.0/1000.0)/(10.0)) × picometer per century + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerMillennium = new (
                                                                  "femtometer per millennium"
                                                                , "fm/kyr"
                                                                , PicometerPerCentury
                                                                , 1.0 / 1000.0 / 10.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) kilometer per week. Defined as: ((10.0)/(7.0)) × hectometer per day + (0).
   /// </summary>
   public static readonly Velocity KilometerPerWeek = new (
                                                           "kilometer per week"
                                                         , "km/wk"
                                                         , HectometerPerDay
                                                         , 10.0 / 7.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) micrometer per quintillion years. Defined as: ((1.0/1000.0)/(1000.0)) × millimeter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerQuintillionYears = new (
                                                                        "micrometer per quintillion years"
                                                                      , "μm/Eyr"
                                                                      , MillimeterPerQuadrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) quectometer per year. Defined as: ((1.0/1000.0)/(365.2525)) × rontometer per day + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerYear = new (
                                                             "quectometer per year"
                                                           , "qm/yr"
                                                           , RontometerPerDay
                                                           , 1.0 / 1000.0 / 365.2525
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) nanometer per trillion years. Defined as: ((1.0/1000.0)/(1000.0)) × micrometer per billion years + (0).
   /// </summary>
   public static readonly Velocity NanometerPerTrillionYears = new (
                                                                    "nanometer per trillion years"
                                                                  , "nm/Tyr"
                                                                  , MicrometerPerBillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctometer per decade. Defined as: ((1.0/1000.0)/(10.0)) × zeptometer per year + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerDecade = new (
                                                              "yoctometer per decade"
                                                            , "ym/decade"
                                                            , ZeptometerPerYear
                                                            , 1.0 / 1000.0 / 10.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) zettameter per day. Defined as: ((1000.0)/(24.0)) × exameter per hour + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerDay = new (
                                                           "zettameter per day"
                                                         , "Zm/dy"
                                                         , ExameterPerHour
                                                         , 1000.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) millimeter per nonillion years. Defined as: ((1.0/10.0)/(1000.0)) × centimeter per octillion years + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerNonillionYears = new (
                                                                      "millimeter per nonillion years"
                                                                    , "mm/Qyr"
                                                                    , CentimeterPerOctillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) megameter per week. Defined as: ((1000.0)/(7.0)) × kilometer per day + (0).
   /// </summary>
   public static readonly Velocity MegameterPerWeek = new (
                                                           "megameter per week"
                                                         , "Mm/wk"
                                                         , KilometerPerDay
                                                         , 1000.0 / 7.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) yottameter per day. Defined as: ((1000.0)/(24.0)) × zettameter per hour + (0).
   /// </summary>
   public static readonly Velocity YottameterPerDay = new (
                                                           "yottameter per day"
                                                         , "Ym/dy"
                                                         , ZettameterPerHour
                                                         , 1000.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) micrometer per sextillion years. Defined as: ((1.0/1000.0)/(1000.0)) × millimeter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerSextillionYears = new (
                                                                       "micrometer per sextillion years"
                                                                     , "μm/Zyr"
                                                                     , MillimeterPerQuintillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) picometer per billion years. Defined as: ((1.0/1000.0)/(1000.0)) × nanometer per million years + (0).
   /// </summary>
   public static readonly Velocity PicometerPerBillionYears = new (
                                                                   "picometer per billion years"
                                                                 , "pm/Gyr"
                                                                 , NanometerPerMillionYears
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptometer per century. Defined as: ((1.0/1000.0)/(10.0)) × attometer per decade + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerCentury = new (
                                                               "zeptometer per century"
                                                             , "zm/century"
                                                             , AttometerPerDecade
                                                             , 1.0 / 1000.0 / 10.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) dekameter per year. Defined as: ((10.0)/(365.2525)) × meter per day + (0).
   /// </summary>
   public static readonly Velocity DekameterPerYear = new (
                                                           "dekameter per year"
                                                         , "dam/yr"
                                                         , MeterPerDay
                                                         , 10.0 / 365.2525
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) millimeter per decillion years. Defined as: ((1.0/10.0)/(1000.0)) × centimeter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerDecillionYears = new (
                                                                      "millimeter per decillion years"
                                                                    , "mm/decillion yr"
                                                                    , CentimeterPerNonillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) nanometer per quadrillion years. Defined as: ((1.0/1000.0)/(1000.0)) × micrometer per trillion years + (0).
   /// </summary>
   public static readonly Velocity NanometerPerQuadrillionYears = new (
                                                                       "nanometer per quadrillion years"
                                                                     , "nm/Pyr"
                                                                     , MicrometerPerTrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) femtometer per million years. Defined as: ((1.0/1000.0)/(1000.0)) × picometer per millennium + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerMillionYears = new (
                                                                    "femtometer per million years"
                                                                  , "fm/Myr"
                                                                  , PicometerPerMillennium
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attometer per millennium. Defined as: ((1.0/1000.0)/(10.0)) × femtometer per century + (0).
   /// </summary>
   public static readonly Velocity AttometerPerMillennium = new (
                                                                 "attometer per millennium"
                                                               , "am/kyr"
                                                               , FemtometerPerCentury
                                                               , 1.0 / 1000.0 / 10.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) rontometer per decade. Defined as: ((1.0/1000.0)/(10.0)) × yoctometer per year + (0).
   /// </summary>
   public static readonly Velocity RontometerPerDecade = new (
                                                              "rontometer per decade"
                                                            , "rm/decade"
                                                            , YoctometerPerYear
                                                            , 1.0 / 1000.0 / 10.0
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) gigameter per week. Defined as: ((1000.0)/(7.0)) × megameter per day + (0).
   /// </summary>
   public static readonly Velocity GigameterPerWeek = new (
                                                           "gigameter per week"
                                                         , "Gm/wk"
                                                         , MegameterPerDay
                                                         , 1000.0 / 7.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) ronnameter per day. Defined as: ((1000.0)/(24.0)) × yottameter per hour + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerDay = new (
                                                           "ronnameter per day"
                                                         , "Rm/dy"
                                                         , YottameterPerHour
                                                         , 1000.0 / 24.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) centimeter per tick. Defined as: ((1.0/10.0)/(100.0)) × decimeter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity CentimeterPerTick = new (
                                                            "centimeter per tick"
                                                          , "cm/tick"
                                                          , DecimeterPerNanosecond
                                                          , 1.0 / 10.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) micrometer per septillion years. Defined as: ((1.0/1000.0)/(1000.0)) × millimeter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerSeptillionYears = new (
                                                                       "micrometer per septillion years"
                                                                     , "μm/Yyr"
                                                                     , MillimeterPerSextillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hectometer per year. Defined as: ((10.0)/(365.2525)) × dekameter per day + (0).
   /// </summary>
   public static readonly Velocity HectometerPerYear = new (
                                                            "hectometer per year"
                                                          , "hm/yr"
                                                          , DekameterPerDay
                                                          , 10.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) quettameter per day. Defined as: ((1000.0)/(24.0)) × ronnameter per hour + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerDay = new (
                                                            "quettameter per day"
                                                          , "Qm/dy"
                                                          , RonnameterPerHour
                                                          , 1000.0 / 24.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) millimeter per planck-time. Defined as: ((1.0/10.0)/(5.391247E-38)) × centimeter per microsecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerPlanckTime = new (
                                                                  "millimeter per planck-time"
                                                                , "mm/tₚ"
                                                                , CentimeterPerMicrosecond
                                                                , 1.0 / 10.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per week. Defined as: ((1000.0)/(7.0)) × gigameter per day + (0).
   /// </summary>
   public static readonly Velocity TerameterPerWeek = new (
                                                           "terameter per week"
                                                         , "Tm/wk"
                                                         , GigameterPerDay
                                                         , 1000.0 / 7.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) picometer per trillion years. Defined as: ((1.0/1000.0)/(1000.0)) × nanometer per billion years + (0).
   /// </summary>
   public static readonly Velocity PicometerPerTrillionYears = new (
                                                                    "picometer per trillion years"
                                                                  , "pm/Tyr"
                                                                  , NanometerPerBillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctometer per century. Defined as: ((1.0/1000.0)/(10.0)) × zeptometer per decade + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerCentury = new (
                                                               "yoctometer per century"
                                                             , "ym/century"
                                                             , ZeptometerPerDecade
                                                             , 1.0 / 1000.0 / 10.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) nanometer per quintillion years. Defined as: ((1.0/1000.0)/(1000.0)) × micrometer per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity NanometerPerQuintillionYears = new (
                                                                       "nanometer per quintillion years"
                                                                     , "nm/Eyr"
                                                                     , MicrometerPerQuadrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) quectometer per decade. Defined as: ((1.0/1000.0)/(10.0)) × rontometer per year + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerDecade = new (
                                                               "quectometer per decade"
                                                             , "qm/decade"
                                                             , RontometerPerYear
                                                             , 1.0 / 1000.0 / 10.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) micrometer per octillion years. Defined as: ((1.0/1000.0)/(1000.0)) × millimeter per septillion years + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerOctillionYears = new (
                                                                      "micrometer per octillion years"
                                                                    , "μm/Ryr"
                                                                    , MillimeterPerSeptillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) femtometer per billion years. Defined as: ((1.0/1000.0)/(1000.0)) × picometer per million years + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerBillionYears = new (
                                                                    "femtometer per billion years"
                                                                  , "fm/Gyr"
                                                                  , PicometerPerMillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptometer per millennium. Defined as: ((1.0/1000.0)/(10.0)) × attometer per century + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerMillennium = new (
                                                                  "zeptometer per millennium"
                                                                , "zm/kyr"
                                                                , AttometerPerCentury
                                                                , 1.0 / 1000.0 / 10.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) kilometer per year. Defined as: ((10.0)/(365.2525)) × hectometer per day + (0).
   /// </summary>
   public static readonly Velocity KilometerPerYear = new (
                                                           "kilometer per year"
                                                         , "km/yr"
                                                         , HectometerPerDay
                                                         , 10.0 / 365.2525
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) petameter per week. Defined as: ((1000.0)/(7.0)) × terameter per day + (0).
   /// </summary>
   public static readonly Velocity PetameterPerWeek = new (
                                                           "petameter per week"
                                                         , "Pm/wk"
                                                         , TerameterPerDay
                                                         , 1000.0 / 7.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) attometer per million years. Defined as: ((1.0/1000.0)/(1000.0)) × femtometer per millennium + (0).
   /// </summary>
   public static readonly Velocity AttometerPerMillionYears = new (
                                                                   "attometer per million years"
                                                                 , "am/Myr"
                                                                 , FemtometerPerMillennium
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nanometer per sextillion years. Defined as: ((1.0/1000.0)/(1000.0)) × micrometer per quintillion years + (0).
   /// </summary>
   public static readonly Velocity NanometerPerSextillionYears = new (
                                                                      "nanometer per sextillion years"
                                                                    , "nm/Zyr"
                                                                    , MicrometerPerQuintillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) picometer per quadrillion years. Defined as: ((1.0/1000.0)/(1000.0)) × nanometer per trillion years + (0).
   /// </summary>
   public static readonly Velocity PicometerPerQuadrillionYears = new (
                                                                       "picometer per quadrillion years"
                                                                     , "pm/Pyr"
                                                                     , NanometerPerTrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) rontometer per century. Defined as: ((1.0/1000.0)/(10.0)) × yoctometer per decade + (0).
   /// </summary>
   public static readonly Velocity RontometerPerCentury = new (
                                                               "rontometer per century"
                                                             , "rm/century"
                                                             , YoctometerPerDecade
                                                             , 1.0 / 1000.0 / 10.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) dekameter per decade. Defined as: ((10.0)/(10.0)) × meter per year + (0).
   /// </summary>
   public static readonly Velocity DekameterPerDecade = new (
                                                             "dekameter per decade"
                                                           , "dam/decade"
                                                           , MeterPerYear
                                                           , 10.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) exameter per week. Defined as: ((1000.0)/(7.0)) × petameter per day + (0).
   /// </summary>
   public static readonly Velocity ExameterPerWeek = new (
                                                          "exameter per week"
                                                        , "Em/wk"
                                                        , PetameterPerDay
                                                        , 1000.0 / 7.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) micrometer per nonillion years. Defined as: ((1.0/1000.0)/(1000.0)) × millimeter per octillion years + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerNonillionYears = new (
                                                                      "micrometer per nonillion years"
                                                                    , "μm/Qyr"
                                                                    , MillimeterPerOctillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) megameter per year. Defined as: ((1000.0)/(365.2525)) × kilometer per day + (0).
   /// </summary>
   public static readonly Velocity MegameterPerYear = new (
                                                           "megameter per year"
                                                         , "Mm/yr"
                                                         , KilometerPerDay
                                                         , 1000.0 / 365.2525
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) femtometer per trillion years. Defined as: ((1.0/1000.0)/(1000.0)) × picometer per billion years + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerTrillionYears = new (
                                                                     "femtometer per trillion years"
                                                                   , "fm/Tyr"
                                                                   , PicometerPerBillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctometer per millennium. Defined as: ((1.0/1000.0)/(10.0)) × zeptometer per century + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerMillennium = new (
                                                                  "yoctometer per millennium"
                                                                , "ym/kyr"
                                                                , ZeptometerPerCentury
                                                                , 1.0 / 1000.0 / 10.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zettameter per week. Defined as: ((1000.0)/(7.0)) × exameter per day + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerWeek = new (
                                                            "zettameter per week"
                                                          , "Zm/wk"
                                                          , ExameterPerDay
                                                          , 1000.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) micrometer per decillion years. Defined as: ((1.0/1000.0)/(1000.0)) × millimeter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerDecillionYears = new (
                                                                      "micrometer per decillion years"
                                                                    , "μm/decillion yr"
                                                                    , MillimeterPerNonillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) nanometer per septillion years. Defined as: ((1.0/1000.0)/(1000.0)) × micrometer per sextillion years + (0).
   /// </summary>
   public static readonly Velocity NanometerPerSeptillionYears = new (
                                                                      "nanometer per septillion years"
                                                                    , "nm/Yyr"
                                                                    , MicrometerPerSextillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) attometer per billion years. Defined as: ((1.0/1000.0)/(1000.0)) × femtometer per million years + (0).
   /// </summary>
   public static readonly Velocity AttometerPerBillionYears = new (
                                                                   "attometer per billion years"
                                                                 , "am/Gyr"
                                                                 , FemtometerPerMillionYears
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptometer per million years. Defined as: ((1.0/1000.0)/(1000.0)) × attometer per millennium + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerMillionYears = new (
                                                                    "zeptometer per million years"
                                                                  , "zm/Myr"
                                                                  , AttometerPerMillennium
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectometer per decade. Defined as: ((10.0)/(10.0)) × dekameter per year + (0).
   /// </summary>
   public static readonly Velocity HectometerPerDecade =
            new ("hectometer per decade", "hm/decade", DekameterPerYear, 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) gigameter per year. Defined as: ((1000.0)/(365.2525)) × megameter per day + (0).
   /// </summary>
   public static readonly Velocity GigameterPerYear = new (
                                                           "gigameter per year"
                                                         , "Gm/yr"
                                                         , MegameterPerDay
                                                         , 1000.0 / 365.2525
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) picometer per quintillion years. Defined as: ((1.0/1000.0)/(1000.0)) × nanometer per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity PicometerPerQuintillionYears = new (
                                                                       "picometer per quintillion years"
                                                                     , "pm/Eyr"
                                                                     , NanometerPerQuadrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) quectometer per century. Defined as: ((1.0/1000.0)/(10.0)) × rontometer per decade + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerCentury = new (
                                                                "quectometer per century"
                                                              , "qm/century"
                                                              , RontometerPerDecade
                                                              , 1.0 / 1000.0 / 10.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) yottameter per week. Defined as: ((1000.0)/(7.0)) × zettameter per day + (0).
   /// </summary>
   public static readonly Velocity YottameterPerWeek = new (
                                                            "yottameter per week"
                                                          , "Ym/wk"
                                                          , ZettameterPerDay
                                                          , 1000.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) micrometer per planck-time. Defined as: ((1.0/1000.0)/(5.391247E-38)) × millimeter per microsecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerPlanckTime = new (
                                                                  "micrometer per planck-time"
                                                                , "μm/tₚ"
                                                                , MillimeterPerMicrosecond
                                                                , 1.0 / 1000.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per year. Defined as: ((1000.0)/(365.2525)) × gigameter per day + (0).
   /// </summary>
   public static readonly Velocity TerameterPerYear = new (
                                                           "terameter per year"
                                                         , "Tm/yr"
                                                         , GigameterPerDay
                                                         , 1000.0 / 365.2525
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) nanometer per octillion years. Defined as: ((1.0/1000.0)/(1000.0)) × micrometer per septillion years + (0).
   /// </summary>
   public static readonly Velocity NanometerPerOctillionYears = new (
                                                                     "nanometer per octillion years"
                                                                   , "nm/Ryr"
                                                                   , MicrometerPerSeptillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) femtometer per quadrillion years. Defined as: ((1.0/1000.0)/(1000.0)) × picometer per trillion years + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerQuadrillionYears = new (
                                                                        "femtometer per quadrillion years"
                                                                      , "fm/Pyr"
                                                                      , PicometerPerTrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) rontometer per millennium. Defined as: ((1.0/1000.0)/(10.0)) × yoctometer per century + (0).
   /// </summary>
   public static readonly Velocity RontometerPerMillennium = new (
                                                                  "rontometer per millennium"
                                                                , "rm/kyr"
                                                                , YoctometerPerCentury
                                                                , 1.0 / 1000.0 / 10.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) kilometer per decade. Defined as: ((10.0)/(10.0)) × hectometer per year + (0).
   /// </summary>
   public static readonly Velocity KilometerPerDecade = new (
                                                             "kilometer per decade"
                                                           , "km/decade"
                                                           , HectometerPerYear
                                                           , 10.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) ronnameter per week. Defined as: ((1000.0)/(7.0)) × yottameter per day + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerWeek = new (
                                                            "ronnameter per week"
                                                          , "Rm/wk"
                                                          , YottameterPerDay
                                                          , 1000.0 / 7.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) picometer per sextillion years. Defined as: ((1.0/1000.0)/(1000.0)) × nanometer per quintillion years + (0).
   /// </summary>
   public static readonly Velocity PicometerPerSextillionYears = new (
                                                                      "picometer per sextillion years"
                                                                    , "pm/Zyr"
                                                                    , NanometerPerQuintillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) dekameter per century. Defined as: ((10.0)/(10.0)) × meter per decade + (0).
   /// </summary>
   public static readonly Velocity DekameterPerCentury =
            new ("dekameter per century", "dam/century", MeterPerDecade, 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) attometer per trillion years. Defined as: ((1.0/1000.0)/(1000.0)) × femtometer per billion years + (0).
   /// </summary>
   public static readonly Velocity AttometerPerTrillionYears = new (
                                                                    "attometer per trillion years"
                                                                  , "am/Tyr"
                                                                  , FemtometerPerBillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctometer per million years. Defined as: ((1.0/1000.0)/(1000.0)) × zeptometer per millennium + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerMillionYears = new (
                                                                    "yoctometer per million years"
                                                                  , "ym/Myr"
                                                                  , ZeptometerPerMillennium
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) millimeter per tick. Defined as: ((1.0/10.0)/(100.0)) × centimeter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MillimeterPerTick = new (
                                                            "millimeter per tick"
                                                          , "mm/tick"
                                                          , CentimeterPerNanosecond
                                                          , 1.0 / 10.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) zeptometer per billion years. Defined as: ((1.0/1000.0)/(1000.0)) × attometer per million years + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerBillionYears = new (
                                                                    "zeptometer per billion years"
                                                                  , "zm/Gyr"
                                                                  , AttometerPerMillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) petameter per year. Defined as: ((1000.0)/(365.2525)) × terameter per day + (0).
   /// </summary>
   public static readonly Velocity PetameterPerYear = new (
                                                           "petameter per year"
                                                         , "Pm/yr"
                                                         , TerameterPerDay
                                                         , 1000.0 / 365.2525
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) quettameter per week. Defined as: ((1000.0)/(7.0)) × ronnameter per day + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerWeek = new (
                                                             "quettameter per week"
                                                           , "Qm/wk"
                                                           , RonnameterPerDay
                                                           , 1000.0 / 7.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) nanometer per nonillion years. Defined as: ((1.0/1000.0)/(1000.0)) × micrometer per octillion years + (0).
   /// </summary>
   public static readonly Velocity NanometerPerNonillionYears = new (
                                                                     "nanometer per nonillion years"
                                                                   , "nm/Qyr"
                                                                   , MicrometerPerOctillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) megameter per decade. Defined as: ((1000.0)/(10.0)) × kilometer per year + (0).
   /// </summary>
   public static readonly Velocity MegameterPerDecade = new (
                                                             "megameter per decade"
                                                           , "Mm/decade"
                                                           , KilometerPerYear
                                                           , 1000.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) femtometer per quintillion years. Defined as: ((1.0/1000.0)/(1000.0)) × picometer per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerQuintillionYears = new (
                                                                        "femtometer per quintillion years"
                                                                      , "fm/Eyr"
                                                                      , PicometerPerQuadrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) quectometer per millennium. Defined as: ((1.0/1000.0)/(10.0)) × rontometer per century + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerMillennium = new (
                                                                   "quectometer per millennium"
                                                                 , "qm/kyr"
                                                                 , RontometerPerCentury
                                                                 , 1.0 / 1000.0 / 10.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picometer per septillion years. Defined as: ((1.0/1000.0)/(1000.0)) × nanometer per sextillion years + (0).
   /// </summary>
   public static readonly Velocity PicometerPerSeptillionYears = new (
                                                                      "picometer per septillion years"
                                                                    , "pm/Yyr"
                                                                    , NanometerPerSextillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hectometer per century. Defined as: ((10.0)/(10.0)) × dekameter per decade + (0).
   /// </summary>
   public static readonly Velocity HectometerPerCentury =
            new ("hectometer per century", "hm/century", DekameterPerDecade, 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) exameter per year. Defined as: ((1000.0)/(365.2525)) × petameter per day + (0).
   /// </summary>
   public static readonly Velocity ExameterPerYear = new (
                                                          "exameter per year"
                                                        , "Em/yr"
                                                        , PetameterPerDay
                                                        , 1000.0 / 365.2525
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) nanometer per decillion years. Defined as: ((1.0/1000.0)/(1000.0)) × micrometer per nonillion years + (0).
   /// </summary>
   public static readonly Velocity NanometerPerDecillionYears = new (
                                                                     "nanometer per decillion years"
                                                                   , "nm/decillion yr"
                                                                   , MicrometerPerNonillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attometer per quadrillion years. Defined as: ((1.0/1000.0)/(1000.0)) × femtometer per trillion years + (0).
   /// </summary>
   public static readonly Velocity AttometerPerQuadrillionYears = new (
                                                                       "attometer per quadrillion years"
                                                                     , "am/Pyr"
                                                                     , FemtometerPerTrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) rontometer per million years. Defined as: ((1.0/1000.0)/(1000.0)) × yoctometer per millennium + (0).
   /// </summary>
   public static readonly Velocity RontometerPerMillionYears = new (
                                                                    "rontometer per million years"
                                                                  , "rm/Myr"
                                                                  , YoctometerPerMillennium
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigameter per decade. Defined as: ((1000.0)/(10.0)) × megameter per year + (0).
   /// </summary>
   public static readonly Velocity GigameterPerDecade = new (
                                                             "gigameter per decade"
                                                           , "Gm/decade"
                                                           , MegameterPerYear
                                                           , 1000.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) zeptometer per trillion years. Defined as: ((1.0/1000.0)/(1000.0)) × attometer per billion years + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerTrillionYears = new (
                                                                     "zeptometer per trillion years"
                                                                   , "zm/Tyr"
                                                                   , AttometerPerBillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctometer per billion years. Defined as: ((1.0/1000.0)/(1000.0)) × zeptometer per million years + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerBillionYears = new (
                                                                    "yoctometer per billion years"
                                                                  , "ym/Gyr"
                                                                  , ZeptometerPerMillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettameter per year. Defined as: ((1000.0)/(365.2525)) × exameter per day + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerYear = new (
                                                            "zettameter per year"
                                                          , "Zm/yr"
                                                          , ExameterPerDay
                                                          , 1000.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) picometer per octillion years. Defined as: ((1.0/1000.0)/(1000.0)) × nanometer per septillion years + (0).
   /// </summary>
   public static readonly Velocity PicometerPerOctillionYears = new (
                                                                     "picometer per octillion years"
                                                                   , "pm/Ryr"
                                                                   , NanometerPerSeptillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) femtometer per sextillion years. Defined as: ((1.0/1000.0)/(1000.0)) × picometer per quintillion years + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerSextillionYears = new (
                                                                       "femtometer per sextillion years"
                                                                     , "fm/Zyr"
                                                                     , PicometerPerQuintillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) dekameter per millennium. Defined as: ((10.0)/(10.0)) × meter per century + (0).
   /// </summary>
   public static readonly Velocity DekameterPerMillennium =
            new ("dekameter per millennium", "dam/kyr", MeterPerCentury, 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) kilometer per century. Defined as: ((10.0)/(10.0)) × hectometer per decade + (0).
   /// </summary>
   public static readonly Velocity KilometerPerCentury =
            new ("kilometer per century", "km/century", HectometerPerDecade, 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) nanometer per planck-time. Defined as: ((1.0/1000.0)/(5.391247E-38)) × micrometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerPlanckTime = new (
                                                                 "nanometer per planck-time"
                                                               , "nm/tₚ"
                                                               , MicrometerPerMicrosecond
                                                               , 1.0 / 1000.0 / 5.391247E-38
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per decade. Defined as: ((1000.0)/(10.0)) × gigameter per year + (0).
   /// </summary>
   public static readonly Velocity TerameterPerDecade = new (
                                                             "terameter per decade"
                                                           , "Tm/decade"
                                                           , GigameterPerYear
                                                           , 1000.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) yottameter per year. Defined as: ((1000.0)/(365.2525)) × zettameter per day + (0).
   /// </summary>
   public static readonly Velocity YottameterPerYear = new (
                                                            "yottameter per year"
                                                          , "Ym/yr"
                                                          , ZettameterPerDay
                                                          , 1000.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) attometer per quintillion years. Defined as: ((1.0/1000.0)/(1000.0)) × femtometer per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity AttometerPerQuintillionYears = new (
                                                                       "attometer per quintillion years"
                                                                     , "am/Eyr"
                                                                     , FemtometerPerQuadrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) quectometer per million years. Defined as: ((1.0/1000.0)/(1000.0)) × rontometer per millennium + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerMillionYears = new (
                                                                     "quectometer per million years"
                                                                   , "qm/Myr"
                                                                   , RontometerPerMillennium
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) picometer per nonillion years. Defined as: ((1.0/1000.0)/(1000.0)) × nanometer per octillion years + (0).
   /// </summary>
   public static readonly Velocity PicometerPerNonillionYears = new (
                                                                     "picometer per nonillion years"
                                                                   , "pm/Qyr"
                                                                   , NanometerPerOctillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) megameter per century. Defined as: ((1000.0)/(10.0)) × kilometer per decade + (0).
   /// </summary>
   public static readonly Velocity MegameterPerCentury =
            new ("megameter per century", "Mm/century", KilometerPerDecade, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) femtometer per septillion years. Defined as: ((1.0/1000.0)/(1000.0)) × picometer per sextillion years + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerSeptillionYears = new (
                                                                       "femtometer per septillion years"
                                                                     , "fm/Yyr"
                                                                     , PicometerPerSextillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) zeptometer per quadrillion years. Defined as: ((1.0/1000.0)/(1000.0)) × attometer per trillion years + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerQuadrillionYears = new (
                                                                        "zeptometer per quadrillion years"
                                                                      , "zm/Pyr"
                                                                      , AttometerPerTrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) rontometer per billion years. Defined as: ((1.0/1000.0)/(1000.0)) × yoctometer per million years + (0).
   /// </summary>
   public static readonly Velocity RontometerPerBillionYears = new (
                                                                    "rontometer per billion years"
                                                                  , "rm/Gyr"
                                                                  , YoctometerPerMillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectometer per millennium. Defined as: ((10.0)/(10.0)) × dekameter per century + (0).
   /// </summary>
   public static readonly Velocity HectometerPerMillennium =
            new ("hectometer per millennium", "hm/kyr", DekameterPerCentury, 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) petameter per decade. Defined as: ((1000.0)/(10.0)) × terameter per year + (0).
   /// </summary>
   public static readonly Velocity PetameterPerDecade = new (
                                                             "petameter per decade"
                                                           , "Pm/decade"
                                                           , TerameterPerYear
                                                           , 1000.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) ronnameter per year. Defined as: ((1000.0)/(365.2525)) × yottameter per day + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerYear = new (
                                                            "ronnameter per year"
                                                          , "Rm/yr"
                                                          , YottameterPerDay
                                                          , 1000.0 / 365.2525
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) yoctometer per trillion years. Defined as: ((1.0/1000.0)/(1000.0)) × zeptometer per billion years + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerTrillionYears = new (
                                                                     "yoctometer per trillion years"
                                                                   , "ym/Tyr"
                                                                   , ZeptometerPerBillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) micrometer per tick. Defined as: ((1.0/1000.0)/(100.0)) × millimeter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MicrometerPerTick = new (
                                                            "micrometer per tick"
                                                          , "μm/tick"
                                                          , MillimeterPerNanosecond
                                                          , 1.0 / 1000.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) quettameter per year. Defined as: ((1000.0)/(365.2525)) × ronnameter per day + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerYear = new (
                                                             "quettameter per year"
                                                           , "Qm/yr"
                                                           , RonnameterPerDay
                                                           , 1000.0 / 365.2525
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) picometer per decillion years. Defined as: ((1.0/1000.0)/(1000.0)) × nanometer per nonillion years + (0).
   /// </summary>
   public static readonly Velocity PicometerPerDecillionYears = new (
                                                                     "picometer per decillion years"
                                                                   , "pm/decillion yr"
                                                                   , NanometerPerNonillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attometer per sextillion years. Defined as: ((1.0/1000.0)/(1000.0)) × femtometer per quintillion years + (0).
   /// </summary>
   public static readonly Velocity AttometerPerSextillionYears = new (
                                                                      "attometer per sextillion years"
                                                                    , "am/Zyr"
                                                                    , FemtometerPerQuintillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) dekameter per million years. Defined as: ((10.0)/(1000.0)) × meter per millennium + (0).
   /// </summary>
   public static readonly Velocity DekameterPerMillionYears =
            new ("dekameter per million years", "dam/Myr", MeterPerMillennium, 10.0 / 1000.0, 0);

   /// <summary>
   /// A(n) gigameter per century. Defined as: ((1000.0)/(10.0)) × megameter per decade + (0).
   /// </summary>
   public static readonly Velocity GigameterPerCentury =
            new ("gigameter per century", "Gm/century", MegameterPerDecade, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) exameter per decade. Defined as: ((1000.0)/(10.0)) × petameter per year + (0).
   /// </summary>
   public static readonly Velocity ExameterPerDecade = new (
                                                            "exameter per decade"
                                                          , "Em/decade"
                                                          , PetameterPerYear
                                                          , 1000.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) femtometer per octillion years. Defined as: ((1.0/1000.0)/(1000.0)) × picometer per septillion years + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerOctillionYears = new (
                                                                      "femtometer per octillion years"
                                                                    , "fm/Ryr"
                                                                    , PicometerPerSeptillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) kilometer per millennium. Defined as: ((10.0)/(10.0)) × hectometer per century + (0).
   /// </summary>
   public static readonly Velocity KilometerPerMillennium =
            new ("kilometer per millennium", "km/kyr", HectometerPerCentury, 10.0 / 10.0, 0);

   /// <summary>
   /// A(n) zeptometer per quintillion years. Defined as: ((1.0/1000.0)/(1000.0)) × attometer per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerQuintillionYears = new (
                                                                        "zeptometer per quintillion years"
                                                                      , "zm/Eyr"
                                                                      , AttometerPerQuadrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) quectometer per billion years. Defined as: ((1.0/1000.0)/(1000.0)) × rontometer per million years + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerBillionYears = new (
                                                                     "quectometer per billion years"
                                                                   , "qm/Gyr"
                                                                   , RontometerPerMillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctometer per quadrillion years. Defined as: ((1.0/1000.0)/(1000.0)) × zeptometer per trillion years + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerQuadrillionYears = new (
                                                                        "yoctometer per quadrillion years"
                                                                      , "ym/Pyr"
                                                                      , ZeptometerPerTrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) rontometer per trillion years. Defined as: ((1.0/1000.0)/(1000.0)) × yoctometer per billion years + (0).
   /// </summary>
   public static readonly Velocity RontometerPerTrillionYears = new (
                                                                     "rontometer per trillion years"
                                                                   , "rm/Tyr"
                                                                   , YoctometerPerBillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettameter per decade. Defined as: ((1000.0)/(10.0)) × exameter per year + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerDecade =
            new ("zettameter per decade", "Zm/decade", ExameterPerYear, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) picometer per planck-time. Defined as: ((1.0/1000.0)/(5.391247E-38)) × nanometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerPlanckTime = new (
                                                                 "picometer per planck-time"
                                                               , "pm/tₚ"
                                                               , NanometerPerMicrosecond
                                                               , 1.0 / 1000.0 / 5.391247E-38
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per century. Defined as: ((1000.0)/(10.0)) × gigameter per decade + (0).
   /// </summary>
   public static readonly Velocity TerameterPerCentury =
            new ("terameter per century", "Tm/century", GigameterPerDecade, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) attometer per septillion years. Defined as: ((1.0/1000.0)/(1000.0)) × femtometer per sextillion years + (0).
   /// </summary>
   public static readonly Velocity AttometerPerSeptillionYears = new (
                                                                      "attometer per septillion years"
                                                                    , "am/Yyr"
                                                                    , FemtometerPerSextillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hectometer per million years. Defined as: ((10.0)/(1000.0)) × dekameter per millennium + (0).
   /// </summary>
   public static readonly Velocity HectometerPerMillionYears = new (
                                                                    "hectometer per million years"
                                                                  , "hm/Myr"
                                                                  , DekameterPerMillennium
                                                                  , 10.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtometer per nonillion years. Defined as: ((1.0/1000.0)/(1000.0)) × picometer per octillion years + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerNonillionYears = new (
                                                                      "femtometer per nonillion years"
                                                                    , "fm/Qyr"
                                                                    , PicometerPerOctillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) megameter per millennium. Defined as: ((1000.0)/(10.0)) × kilometer per century + (0).
   /// </summary>
   public static readonly Velocity MegameterPerMillennium =
            new ("megameter per millennium", "Mm/kyr", KilometerPerCentury, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) yottameter per decade. Defined as: ((1000.0)/(10.0)) × zettameter per year + (0).
   /// </summary>
   public static readonly Velocity YottameterPerDecade =
            new ("yottameter per decade", "Ym/decade", ZettameterPerYear, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) zeptometer per sextillion years. Defined as: ((1.0/1000.0)/(1000.0)) × attometer per quintillion years + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerSextillionYears = new (
                                                                       "zeptometer per sextillion years"
                                                                     , "zm/Zyr"
                                                                     , AttometerPerQuintillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) dekameter per billion years. Defined as: ((10.0)/(1000.0)) × meter per million years + (0).
   /// </summary>
   public static readonly Velocity DekameterPerBillionYears =
            new ("dekameter per billion years", "dam/Gyr", MeterPerMillionYears, 10.0 / 1000.0, 0);

   /// <summary>
   /// A(n) petameter per century. Defined as: ((1000.0)/(10.0)) × terameter per decade + (0).
   /// </summary>
   public static readonly Velocity PetameterPerCentury =
            new ("petameter per century", "Pm/century", TerameterPerDecade, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) yoctometer per quintillion years. Defined as: ((1.0/1000.0)/(1000.0)) × zeptometer per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerQuintillionYears = new (
                                                                        "yoctometer per quintillion years"
                                                                      , "ym/Eyr"
                                                                      , ZeptometerPerQuadrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) quectometer per trillion years. Defined as: ((1.0/1000.0)/(1000.0)) × rontometer per billion years + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerTrillionYears = new (
                                                                      "quectometer per trillion years"
                                                                    , "qm/Tyr"
                                                                    , RontometerPerBillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) femtometer per decillion years. Defined as: ((1.0/1000.0)/(1000.0)) × picometer per nonillion years + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerDecillionYears = new (
                                                                      "femtometer per decillion years"
                                                                    , "fm/decillion yr"
                                                                    , PicometerPerNonillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) attometer per octillion years. Defined as: ((1.0/1000.0)/(1000.0)) × femtometer per septillion years + (0).
   /// </summary>
   public static readonly Velocity AttometerPerOctillionYears = new (
                                                                     "attometer per octillion years"
                                                                   , "am/Ryr"
                                                                   , FemtometerPerSeptillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontometer per quadrillion years. Defined as: ((1.0/1000.0)/(1000.0)) × yoctometer per trillion years + (0).
   /// </summary>
   public static readonly Velocity RontometerPerQuadrillionYears = new (
                                                                        "rontometer per quadrillion years"
                                                                      , "rm/Pyr"
                                                                      , YoctometerPerTrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) kilometer per million years. Defined as: ((10.0)/(1000.0)) × hectometer per millennium + (0).
   /// </summary>
   public static readonly Velocity KilometerPerMillionYears = new (
                                                                   "kilometer per million years"
                                                                 , "km/Myr"
                                                                 , HectometerPerMillennium
                                                                 , 10.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gigameter per millennium. Defined as: ((1000.0)/(10.0)) × megameter per century + (0).
   /// </summary>
   public static readonly Velocity GigameterPerMillennium =
            new ("gigameter per millennium", "Gm/kyr", MegameterPerCentury, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) ronnameter per decade. Defined as: ((1000.0)/(10.0)) × yottameter per year + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerDecade =
            new ("ronnameter per decade", "Rm/decade", YottameterPerYear, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) exameter per century. Defined as: ((1000.0)/(10.0)) × petameter per decade + (0).
   /// </summary>
   public static readonly Velocity ExameterPerCentury = new (
                                                             "exameter per century"
                                                           , "Em/century"
                                                           , PetameterPerDecade
                                                           , 1000.0 / 10.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) nanometer per tick. Defined as: ((1.0/1000.0)/(100.0)) × micrometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity NanometerPerTick = new (
                                                           "nanometer per tick"
                                                         , "nm/tick"
                                                         , MicrometerPerNanosecond
                                                         , 1.0 / 1000.0 / 100.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) zeptometer per septillion years. Defined as: ((1.0/1000.0)/(1000.0)) × attometer per sextillion years + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerSeptillionYears = new (
                                                                       "zeptometer per septillion years"
                                                                     , "zm/Yyr"
                                                                     , AttometerPerSextillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hectometer per billion years. Defined as: ((10.0)/(1000.0)) × dekameter per million years + (0).
   /// </summary>
   public static readonly Velocity HectometerPerBillionYears = new (
                                                                    "hectometer per billion years"
                                                                  , "hm/Gyr"
                                                                  , DekameterPerMillionYears
                                                                  , 10.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quettameter per decade. Defined as: ((1000.0)/(10.0)) × ronnameter per year + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerDecade =
            new ("quettameter per decade", "Qm/decade", RonnameterPerYear, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) femtometer per planck-time. Defined as: ((1.0/1000.0)/(5.391247E-38)) × picometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerPlanckTime = new (
                                                                  "femtometer per planck-time"
                                                                , "fm/tₚ"
                                                                , PicometerPerMicrosecond
                                                                , 1.0 / 1000.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per millennium. Defined as: ((1000.0)/(10.0)) × gigameter per century + (0).
   /// </summary>
   public static readonly Velocity TerameterPerMillennium =
            new ("terameter per millennium", "Tm/kyr", GigameterPerCentury, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) attometer per nonillion years. Defined as: ((1.0/1000.0)/(1000.0)) × femtometer per octillion years + (0).
   /// </summary>
   public static readonly Velocity AttometerPerNonillionYears = new (
                                                                     "attometer per nonillion years"
                                                                   , "am/Qyr"
                                                                   , FemtometerPerOctillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) megameter per million years. Defined as: ((1000.0)/(1000.0)) × kilometer per millennium + (0).
   /// </summary>
   public static readonly Velocity MegameterPerMillionYears = new (
                                                                   "megameter per million years"
                                                                 , "Mm/Myr"
                                                                 , KilometerPerMillennium
                                                                 , 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yoctometer per sextillion years. Defined as: ((1.0/1000.0)/(1000.0)) × zeptometer per quintillion years + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerSextillionYears = new (
                                                                       "yoctometer per sextillion years"
                                                                     , "ym/Zyr"
                                                                     , ZeptometerPerQuintillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) dekameter per trillion years. Defined as: ((10.0)/(1000.0)) × meter per billion years + (0).
   /// </summary>
   public static readonly Velocity DekameterPerTrillionYears =
            new ("dekameter per trillion years", "dam/Tyr", MeterPerBillionYears, 10.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zettameter per century. Defined as: ((1000.0)/(10.0)) × exameter per decade + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerCentury =
            new ("zettameter per century", "Zm/century", ExameterPerDecade, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) rontometer per quintillion years. Defined as: ((1.0/1000.0)/(1000.0)) × yoctometer per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity RontometerPerQuintillionYears = new (
                                                                        "rontometer per quintillion years"
                                                                      , "rm/Eyr"
                                                                      , YoctometerPerQuadrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) quectometer per quadrillion years. Defined as: ((1.0/1000.0)/(1000.0)) × rontometer per trillion years + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerQuadrillionYears = new (
                                                                         "quectometer per quadrillion years"
                                                                       , "qm/Pyr"
                                                                       , RontometerPerTrillionYears
                                                                       , 1.0 / 1000.0 / 1000.0
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) zeptometer per octillion years. Defined as: ((1.0/1000.0)/(1000.0)) × attometer per septillion years + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerOctillionYears = new (
                                                                      "zeptometer per octillion years"
                                                                    , "zm/Ryr"
                                                                    , AttometerPerSeptillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) kilometer per billion years. Defined as: ((10.0)/(1000.0)) × hectometer per million years + (0).
   /// </summary>
   public static readonly Velocity KilometerPerBillionYears = new (
                                                                   "kilometer per billion years"
                                                                 , "km/Gyr"
                                                                 , HectometerPerMillionYears
                                                                 , 10.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petameter per millennium. Defined as: ((1000.0)/(10.0)) × terameter per century + (0).
   /// </summary>
   public static readonly Velocity PetameterPerMillennium =
            new ("petameter per millennium", "Pm/kyr", TerameterPerCentury, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) yottameter per century. Defined as: ((1000.0)/(10.0)) × zettameter per decade + (0).
   /// </summary>
   public static readonly Velocity YottameterPerCentury =
            new ("yottameter per century", "Ym/century", ZettameterPerDecade, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) attometer per decillion years. Defined as: ((1.0/1000.0)/(1000.0)) × femtometer per nonillion years + (0).
   /// </summary>
   public static readonly Velocity AttometerPerDecillionYears = new (
                                                                     "attometer per decillion years"
                                                                   , "am/decillion yr"
                                                                   , FemtometerPerNonillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) gigameter per million years. Defined as: ((1000.0)/(1000.0)) × megameter per millennium + (0).
   /// </summary>
   public static readonly Velocity GigameterPerMillionYears = new (
                                                                   "gigameter per million years"
                                                                 , "Gm/Myr"
                                                                 , MegameterPerMillennium
                                                                 , 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yoctometer per septillion years. Defined as: ((1.0/1000.0)/(1000.0)) × zeptometer per sextillion years + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerSeptillionYears = new (
                                                                       "yoctometer per septillion years"
                                                                     , "ym/Yyr"
                                                                     , ZeptometerPerSextillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hectometer per trillion years. Defined as: ((10.0)/(1000.0)) × dekameter per billion years + (0).
   /// </summary>
   public static readonly Velocity HectometerPerTrillionYears = new (
                                                                     "hectometer per trillion years"
                                                                   , "hm/Tyr"
                                                                   , DekameterPerBillionYears
                                                                   , 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontometer per sextillion years. Defined as: ((1.0/1000.0)/(1000.0)) × yoctometer per quintillion years + (0).
   /// </summary>
   public static readonly Velocity RontometerPerSextillionYears = new (
                                                                       "rontometer per sextillion years"
                                                                     , "rm/Zyr"
                                                                     , YoctometerPerQuintillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) dekameter per quadrillion years. Defined as: ((10.0)/(1000.0)) × meter per trillion years + (0).
   /// </summary>
   public static readonly Velocity DekameterPerQuadrillionYears = new (
                                                                       "dekameter per quadrillion years"
                                                                     , "dam/Pyr"
                                                                     , MeterPerTrillionYears
                                                                     , 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) exameter per millennium. Defined as: ((1000.0)/(10.0)) × petameter per century + (0).
   /// </summary>
   public static readonly Velocity ExameterPerMillennium =
            new ("exameter per millennium", "Em/kyr", PetameterPerCentury, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) ronnameter per century. Defined as: ((1000.0)/(10.0)) × yottameter per decade + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerCentury =
            new ("ronnameter per century", "Rm/century", YottameterPerDecade, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) quectometer per quintillion years. Defined as: ((1.0/1000.0)/(1000.0)) × rontometer per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerQuintillionYears = new (
                                                                         "quectometer per quintillion years"
                                                                       , "qm/Eyr"
                                                                       , RontometerPerQuadrillionYears
                                                                       , 1.0 / 1000.0 / 1000.0
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) zeptometer per nonillion years. Defined as: ((1.0/1000.0)/(1000.0)) × attometer per octillion years + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerNonillionYears = new (
                                                                      "zeptometer per nonillion years"
                                                                    , "zm/Qyr"
                                                                    , AttometerPerOctillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) megameter per billion years. Defined as: ((1000.0)/(1000.0)) × kilometer per million years + (0).
   /// </summary>
   public static readonly Velocity MegameterPerBillionYears = new (
                                                                   "megameter per billion years"
                                                                 , "Mm/Gyr"
                                                                 , KilometerPerMillionYears
                                                                 , 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attometer per planck-time. Defined as: ((1.0/1000.0)/(5.391247E-38)) × femtometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerPlanckTime = new (
                                                                 "attometer per planck-time"
                                                               , "am/tₚ"
                                                               , FemtometerPerMicrosecond
                                                               , 1.0 / 1000.0 / 5.391247E-38
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per million years. Defined as: ((1000.0)/(1000.0)) × gigameter per millennium + (0).
   /// </summary>
   public static readonly Velocity TerameterPerMillionYears = new (
                                                                   "terameter per million years"
                                                                 , "Tm/Myr"
                                                                 , GigameterPerMillennium
                                                                 , 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picometer per tick. Defined as: ((1.0/1000.0)/(100.0)) × nanometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity PicometerPerTick = new (
                                                           "picometer per tick"
                                                         , "pm/tick"
                                                         , NanometerPerNanosecond
                                                         , 1.0 / 1000.0 / 100.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) quettameter per century. Defined as: ((1000.0)/(10.0)) × ronnameter per decade + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerCentury =
            new ("quettameter per century", "Qm/century", RonnameterPerDecade, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) yoctometer per octillion years. Defined as: ((1.0/1000.0)/(1000.0)) × zeptometer per septillion years + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerOctillionYears = new (
                                                                      "yoctometer per octillion years"
                                                                    , "ym/Ryr"
                                                                    , ZeptometerPerSeptillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) kilometer per trillion years. Defined as: ((10.0)/(1000.0)) × hectometer per billion years + (0).
   /// </summary>
   public static readonly Velocity KilometerPerTrillionYears = new (
                                                                    "kilometer per trillion years"
                                                                  , "km/Tyr"
                                                                  , HectometerPerBillionYears
                                                                  , 10.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettameter per millennium. Defined as: ((1000.0)/(10.0)) × exameter per century + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerMillennium =
            new ("zettameter per millennium", "Zm/kyr", ExameterPerCentury, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) zeptometer per decillion years. Defined as: ((1.0/1000.0)/(1000.0)) × attometer per nonillion years + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerDecillionYears = new (
                                                                      "zeptometer per decillion years"
                                                                    , "zm/decillion yr"
                                                                    , AttometerPerNonillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rontometer per septillion years. Defined as: ((1.0/1000.0)/(1000.0)) × yoctometer per sextillion years + (0).
   /// </summary>
   public static readonly Velocity RontometerPerSeptillionYears = new (
                                                                       "rontometer per septillion years"
                                                                     , "rm/Yyr"
                                                                     , YoctometerPerSextillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) hectometer per quadrillion years. Defined as: ((10.0)/(1000.0)) × dekameter per trillion years + (0).
   /// </summary>
   public static readonly Velocity HectometerPerQuadrillionYears = new (
                                                                        "hectometer per quadrillion years"
                                                                      , "hm/Pyr"
                                                                      , DekameterPerTrillionYears
                                                                      , 10.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) gigameter per billion years. Defined as: ((1000.0)/(1000.0)) × megameter per million years + (0).
   /// </summary>
   public static readonly Velocity GigameterPerBillionYears = new (
                                                                   "gigameter per billion years"
                                                                 , "Gm/Gyr"
                                                                 , MegameterPerMillionYears
                                                                 , 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petameter per million years. Defined as: ((1000.0)/(1000.0)) × terameter per millennium + (0).
   /// </summary>
   public static readonly Velocity PetameterPerMillionYears = new (
                                                                   "petameter per million years"
                                                                 , "Pm/Myr"
                                                                 , TerameterPerMillennium
                                                                 , 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quectometer per sextillion years. Defined as: ((1.0/1000.0)/(1000.0)) × rontometer per quintillion years + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerSextillionYears = new (
                                                                        "quectometer per sextillion years"
                                                                      , "qm/Zyr"
                                                                      , RontometerPerQuintillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) dekameter per quintillion years. Defined as: ((10.0)/(1000.0)) × meter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity DekameterPerQuintillionYears = new (
                                                                       "dekameter per quintillion years"
                                                                     , "dam/Eyr"
                                                                     , MeterPerQuadrillionYears
                                                                     , 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yottameter per millennium. Defined as: ((1000.0)/(10.0)) × zettameter per century + (0).
   /// </summary>
   public static readonly Velocity YottameterPerMillennium =
            new ("yottameter per millennium", "Ym/kyr", ZettameterPerCentury, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) yoctometer per nonillion years. Defined as: ((1.0/1000.0)/(1000.0)) × zeptometer per octillion years + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerNonillionYears = new (
                                                                      "yoctometer per nonillion years"
                                                                    , "ym/Qyr"
                                                                    , ZeptometerPerOctillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) megameter per trillion years. Defined as: ((1000.0)/(1000.0)) × kilometer per billion years + (0).
   /// </summary>
   public static readonly Velocity MegameterPerTrillionYears = new (
                                                                    "megameter per trillion years"
                                                                  , "Mm/Tyr"
                                                                  , KilometerPerBillionYears
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exameter per million years. Defined as: ((1000.0)/(1000.0)) × petameter per millennium + (0).
   /// </summary>
   public static readonly Velocity ExameterPerMillionYears = new (
                                                                  "exameter per million years"
                                                                , "Em/Myr"
                                                                , PetameterPerMillennium
                                                                , 1000.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zeptometer per planck-time. Defined as: ((1.0/1000.0)/(5.391247E-38)) × attometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerPlanckTime = new (
                                                                  "zeptometer per planck-time"
                                                                , "zm/tₚ"
                                                                , AttometerPerMicrosecond
                                                                , 1.0 / 1000.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per billion years. Defined as: ((1000.0)/(1000.0)) × gigameter per million years + (0).
   /// </summary>
   public static readonly Velocity TerameterPerBillionYears = new (
                                                                   "terameter per billion years"
                                                                 , "Tm/Gyr"
                                                                 , GigameterPerMillionYears
                                                                 , 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rontometer per octillion years. Defined as: ((1.0/1000.0)/(1000.0)) × yoctometer per septillion years + (0).
   /// </summary>
   public static readonly Velocity RontometerPerOctillionYears = new (
                                                                      "rontometer per octillion years"
                                                                    , "rm/Ryr"
                                                                    , YoctometerPerSeptillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) kilometer per quadrillion years. Defined as: ((10.0)/(1000.0)) × hectometer per trillion years + (0).
   /// </summary>
   public static readonly Velocity KilometerPerQuadrillionYears = new (
                                                                       "kilometer per quadrillion years"
                                                                     , "km/Pyr"
                                                                     , HectometerPerTrillionYears
                                                                     , 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) ronnameter per millennium. Defined as: ((1000.0)/(10.0)) × yottameter per century + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerMillennium =
            new ("ronnameter per millennium", "Rm/kyr", YottameterPerCentury, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) quectometer per septillion years. Defined as: ((1.0/1000.0)/(1000.0)) × rontometer per sextillion years + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerSeptillionYears = new (
                                                                        "quectometer per septillion years"
                                                                      , "qm/Yyr"
                                                                      , RontometerPerSextillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) hectometer per quintillion years. Defined as: ((10.0)/(1000.0)) × dekameter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity HectometerPerQuintillionYears = new (
                                                                        "hectometer per quintillion years"
                                                                      , "hm/Eyr"
                                                                      , DekameterPerQuadrillionYears
                                                                      , 10.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) dekameter per sextillion years. Defined as: ((10.0)/(1000.0)) × meter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity DekameterPerSextillionYears = new (
                                                                      "dekameter per sextillion years"
                                                                    , "dam/Zyr"
                                                                    , MeterPerQuintillionYears
                                                                    , 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yoctometer per decillion years. Defined as: ((1.0/1000.0)/(1000.0)) × zeptometer per nonillion years + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerDecillionYears = new (
                                                                      "yoctometer per decillion years"
                                                                    , "ym/decillion yr"
                                                                    , ZeptometerPerNonillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) gigameter per trillion years. Defined as: ((1000.0)/(1000.0)) × megameter per billion years + (0).
   /// </summary>
   public static readonly Velocity GigameterPerTrillionYears = new (
                                                                    "gigameter per trillion years"
                                                                  , "Gm/Tyr"
                                                                  , MegameterPerBillionYears
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettameter per million years. Defined as: ((1000.0)/(1000.0)) × exameter per millennium + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerMillionYears = new (
                                                                    "zettameter per million years"
                                                                  , "Zm/Myr"
                                                                  , ExameterPerMillennium
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtometer per tick. Defined as: ((1.0/1000.0)/(100.0)) × picometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity FemtometerPerTick = new (
                                                            "femtometer per tick"
                                                          , "fm/tick"
                                                          , PicometerPerNanosecond
                                                          , 1.0 / 1000.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) petameter per billion years. Defined as: ((1000.0)/(1000.0)) × terameter per million years + (0).
   /// </summary>
   public static readonly Velocity PetameterPerBillionYears = new (
                                                                   "petameter per billion years"
                                                                 , "Pm/Gyr"
                                                                 , TerameterPerMillionYears
                                                                 , 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quettameter per millennium. Defined as: ((1000.0)/(10.0)) × ronnameter per century + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerMillennium =
            new ("quettameter per millennium", "Qm/kyr", RonnameterPerCentury, 1000.0 / 10.0, 0);

   /// <summary>
   /// A(n) rontometer per nonillion years. Defined as: ((1.0/1000.0)/(1000.0)) × yoctometer per octillion years + (0).
   /// </summary>
   public static readonly Velocity RontometerPerNonillionYears = new (
                                                                      "rontometer per nonillion years"
                                                                    , "rm/Qyr"
                                                                    , YoctometerPerOctillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) megameter per quadrillion years. Defined as: ((1000.0)/(1000.0)) × kilometer per trillion years + (0).
   /// </summary>
   public static readonly Velocity MegameterPerQuadrillionYears = new (
                                                                       "megameter per quadrillion years"
                                                                     , "Mm/Pyr"
                                                                     , KilometerPerTrillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yottameter per million years. Defined as: ((1000.0)/(1000.0)) × zettameter per millennium + (0).
   /// </summary>
   public static readonly Velocity YottameterPerMillionYears = new (
                                                                    "yottameter per million years"
                                                                  , "Ym/Myr"
                                                                  , ZettameterPerMillennium
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectometer per octillion years. Defined as: ((1.0/1000.0)/(1000.0)) × rontometer per septillion years + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerOctillionYears = new (
                                                                       "quectometer per octillion years"
                                                                     , "qm/Ryr"
                                                                     , RontometerPerSeptillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) kilometer per quintillion years. Defined as: ((10.0)/(1000.0)) × hectometer per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity KilometerPerQuintillionYears = new (
                                                                       "kilometer per quintillion years"
                                                                     , "km/Eyr"
                                                                     , HectometerPerQuadrillionYears
                                                                     , 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yoctometer per planck-time. Defined as: ((1.0/1000.0)/(5.391247E-38)) × zeptometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerPlanckTime = new (
                                                                  "yoctometer per planck-time"
                                                                , "ym/tₚ"
                                                                , ZeptometerPerMicrosecond
                                                                , 1.0 / 1000.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per trillion years. Defined as: ((1000.0)/(1000.0)) × gigameter per billion years + (0).
   /// </summary>
   public static readonly Velocity TerameterPerTrillionYears = new (
                                                                    "terameter per trillion years"
                                                                  , "Tm/Tyr"
                                                                  , GigameterPerBillionYears
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) dekameter per septillion years. Defined as: ((10.0)/(1000.0)) × meter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity DekameterPerSeptillionYears = new (
                                                                      "dekameter per septillion years"
                                                                    , "dam/Yyr"
                                                                    , MeterPerSextillionYears
                                                                    , 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hectometer per sextillion years. Defined as: ((10.0)/(1000.0)) × dekameter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity HectometerPerSextillionYears = new (
                                                                       "hectometer per sextillion years"
                                                                     , "hm/Zyr"
                                                                     , DekameterPerQuintillionYears
                                                                     , 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) exameter per billion years. Defined as: ((1000.0)/(1000.0)) × petameter per million years + (0).
   /// </summary>
   public static readonly Velocity ExameterPerBillionYears = new (
                                                                  "exameter per billion years"
                                                                , "Em/Gyr"
                                                                , PetameterPerMillionYears
                                                                , 1000.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) rontometer per decillion years. Defined as: ((1.0/1000.0)/(1000.0)) × yoctometer per nonillion years + (0).
   /// </summary>
   public static readonly Velocity RontometerPerDecillionYears = new (
                                                                      "rontometer per decillion years"
                                                                    , "rm/decillion yr"
                                                                    , YoctometerPerNonillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) gigameter per quadrillion years. Defined as: ((1000.0)/(1000.0)) × megameter per trillion years + (0).
   /// </summary>
   public static readonly Velocity GigameterPerQuadrillionYears = new (
                                                                       "gigameter per quadrillion years"
                                                                     , "Gm/Pyr"
                                                                     , MegameterPerTrillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) ronnameter per million years. Defined as: ((1000.0)/(1000.0)) × yottameter per millennium + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerMillionYears = new (
                                                                    "ronnameter per million years"
                                                                  , "Rm/Myr"
                                                                  , YottameterPerMillennium
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) petameter per trillion years. Defined as: ((1000.0)/(1000.0)) × terameter per billion years + (0).
   /// </summary>
   public static readonly Velocity PetameterPerTrillionYears = new (
                                                                    "petameter per trillion years"
                                                                  , "Pm/Tyr"
                                                                  , TerameterPerBillionYears
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettameter per billion years. Defined as: ((1000.0)/(1000.0)) × exameter per million years + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerBillionYears = new (
                                                                    "zettameter per billion years"
                                                                  , "Zm/Gyr"
                                                                  , ExameterPerMillionYears
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectometer per nonillion years. Defined as: ((1.0/1000.0)/(1000.0)) × rontometer per octillion years + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerNonillionYears = new (
                                                                       "quectometer per nonillion years"
                                                                     , "qm/Qyr"
                                                                     , RontometerPerOctillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) megameter per quintillion years. Defined as: ((1000.0)/(1000.0)) × kilometer per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity MegameterPerQuintillionYears = new (
                                                                       "megameter per quintillion years"
                                                                     , "Mm/Eyr"
                                                                     , KilometerPerQuadrillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) dekameter per octillion years. Defined as: ((10.0)/(1000.0)) × meter per septillion years + (0).
   /// </summary>
   public static readonly Velocity DekameterPerOctillionYears = new (
                                                                     "dekameter per octillion years"
                                                                   , "dam/Ryr"
                                                                   , MeterPerSeptillionYears
                                                                   , 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) kilometer per sextillion years. Defined as: ((10.0)/(1000.0)) × hectometer per quintillion years + (0).
   /// </summary>
   public static readonly Velocity KilometerPerSextillionYears = new (
                                                                      "kilometer per sextillion years"
                                                                    , "km/Zyr"
                                                                    , HectometerPerQuintillionYears
                                                                    , 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) attometer per tick. Defined as: ((1.0/1000.0)/(100.0)) × femtometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity AttometerPerTick = new (
                                                           "attometer per tick"
                                                         , "am/tick"
                                                         , FemtometerPerNanosecond
                                                         , 1.0 / 1000.0 / 100.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) hectometer per septillion years. Defined as: ((10.0)/(1000.0)) × dekameter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity HectometerPerSeptillionYears = new (
                                                                       "hectometer per septillion years"
                                                                     , "hm/Yyr"
                                                                     , DekameterPerSextillionYears
                                                                     , 10.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) quettameter per million years. Defined as: ((1000.0)/(1000.0)) × ronnameter per millennium + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerMillionYears = new (
                                                                     "quettameter per million years"
                                                                   , "Qm/Myr"
                                                                   , RonnameterPerMillennium
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontometer per planck-time. Defined as: ((1.0/1000.0)/(5.391247E-38)) × yoctometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerPlanckTime = new (
                                                                  "rontometer per planck-time"
                                                                , "rm/tₚ"
                                                                , YoctometerPerMicrosecond
                                                                , 1.0 / 1000.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per quadrillion years. Defined as: ((1000.0)/(1000.0)) × gigameter per trillion years + (0).
   /// </summary>
   public static readonly Velocity TerameterPerQuadrillionYears = new (
                                                                       "terameter per quadrillion years"
                                                                     , "Tm/Pyr"
                                                                     , GigameterPerTrillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) yottameter per billion years. Defined as: ((1000.0)/(1000.0)) × zettameter per million years + (0).
   /// </summary>
   public static readonly Velocity YottameterPerBillionYears = new (
                                                                    "yottameter per billion years"
                                                                  , "Ym/Gyr"
                                                                  , ZettameterPerMillionYears
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exameter per trillion years. Defined as: ((1000.0)/(1000.0)) × petameter per billion years + (0).
   /// </summary>
   public static readonly Velocity ExameterPerTrillionYears = new (
                                                                   "exameter per trillion years"
                                                                 , "Em/Tyr"
                                                                 , PetameterPerBillionYears
                                                                 , 1000.0 / 1000.0
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quectometer per decillion years. Defined as: ((1.0/1000.0)/(1000.0)) × rontometer per nonillion years + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerDecillionYears = new (
                                                                       "quectometer per decillion years"
                                                                     , "qm/decillion yr"
                                                                     , RontometerPerNonillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) gigameter per quintillion years. Defined as: ((1000.0)/(1000.0)) × megameter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity GigameterPerQuintillionYears = new (
                                                                       "gigameter per quintillion years"
                                                                     , "Gm/Eyr"
                                                                     , MegameterPerQuadrillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) dekameter per nonillion years. Defined as: ((10.0)/(1000.0)) × meter per octillion years + (0).
   /// </summary>
   public static readonly Velocity DekameterPerNonillionYears = new (
                                                                     "dekameter per nonillion years"
                                                                   , "dam/Qyr"
                                                                   , MeterPerOctillionYears
                                                                   , 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) megameter per sextillion years. Defined as: ((1000.0)/(1000.0)) × kilometer per quintillion years + (0).
   /// </summary>
   public static readonly Velocity MegameterPerSextillionYears = new (
                                                                      "megameter per sextillion years"
                                                                    , "Mm/Zyr"
                                                                    , KilometerPerQuintillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hectometer per octillion years. Defined as: ((10.0)/(1000.0)) × dekameter per septillion years + (0).
   /// </summary>
   public static readonly Velocity HectometerPerOctillionYears = new (
                                                                      "hectometer per octillion years"
                                                                    , "hm/Ryr"
                                                                    , DekameterPerSeptillionYears
                                                                    , 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) kilometer per septillion years. Defined as: ((10.0)/(1000.0)) × hectometer per sextillion years + (0).
   /// </summary>
   public static readonly Velocity KilometerPerSeptillionYears = new (
                                                                      "kilometer per septillion years"
                                                                    , "km/Yyr"
                                                                    , HectometerPerSextillionYears
                                                                    , 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) petameter per quadrillion years. Defined as: ((1000.0)/(1000.0)) × terameter per trillion years + (0).
   /// </summary>
   public static readonly Velocity PetameterPerQuadrillionYears = new (
                                                                       "petameter per quadrillion years"
                                                                     , "Pm/Pyr"
                                                                     , TerameterPerTrillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) ronnameter per billion years. Defined as: ((1000.0)/(1000.0)) × yottameter per million years + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerBillionYears = new (
                                                                    "ronnameter per billion years"
                                                                  , "Rm/Gyr"
                                                                  , YottameterPerMillionYears
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettameter per trillion years. Defined as: ((1000.0)/(1000.0)) × exameter per billion years + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerTrillionYears = new (
                                                                     "zettameter per trillion years"
                                                                   , "Zm/Tyr"
                                                                   , ExameterPerBillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectometer per planck-time. Defined as: ((1.0/1000.0)/(5.391247E-38)) × rontometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerPlanckTime = new (
                                                                   "quectometer per planck-time"
                                                                 , "qm/tₚ"
                                                                 , RontometerPerMicrosecond
                                                                 , 1.0 / 1000.0 / 5.391247E-38
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) terameter per quintillion years. Defined as: ((1000.0)/(1000.0)) × gigameter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity TerameterPerQuintillionYears = new (
                                                                       "terameter per quintillion years"
                                                                     , "Tm/Eyr"
                                                                     , GigameterPerQuadrillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) zeptometer per tick. Defined as: ((1.0/1000.0)/(100.0)) × attometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity ZeptometerPerTick = new (
                                                            "zeptometer per tick"
                                                          , "zm/tick"
                                                          , AttometerPerNanosecond
                                                          , 1.0 / 1000.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) quettameter per billion years. Defined as: ((1000.0)/(1000.0)) × ronnameter per million years + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerBillionYears = new (
                                                                     "quettameter per billion years"
                                                                   , "Qm/Gyr"
                                                                   , RonnameterPerMillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekameter per decillion years. Defined as: ((10.0)/(1000.0)) × meter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity DekameterPerDecillionYears = new (
                                                                     "dekameter per decillion years"
                                                                   , "dam/decillion yr"
                                                                   , MeterPerNonillionYears
                                                                   , 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) gigameter per sextillion years. Defined as: ((1000.0)/(1000.0)) × megameter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity GigameterPerSextillionYears = new (
                                                                      "gigameter per sextillion years"
                                                                    , "Gm/Zyr"
                                                                    , MegameterPerQuintillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) exameter per quadrillion years. Defined as: ((1000.0)/(1000.0)) × petameter per trillion years + (0).
   /// </summary>
   public static readonly Velocity ExameterPerQuadrillionYears = new (
                                                                      "exameter per quadrillion years"
                                                                    , "Em/Pyr"
                                                                    , PetameterPerTrillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yottameter per trillion years. Defined as: ((1000.0)/(1000.0)) × zettameter per billion years + (0).
   /// </summary>
   public static readonly Velocity YottameterPerTrillionYears = new (
                                                                     "yottameter per trillion years"
                                                                   , "Ym/Tyr"
                                                                   , ZettameterPerBillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) hectometer per nonillion years. Defined as: ((10.0)/(1000.0)) × dekameter per octillion years + (0).
   /// </summary>
   public static readonly Velocity HectometerPerNonillionYears = new (
                                                                      "hectometer per nonillion years"
                                                                    , "hm/Qyr"
                                                                    , DekameterPerOctillionYears
                                                                    , 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) megameter per septillion years. Defined as: ((1000.0)/(1000.0)) × kilometer per sextillion years + (0).
   /// </summary>
   public static readonly Velocity MegameterPerSeptillionYears = new (
                                                                      "megameter per septillion years"
                                                                    , "Mm/Yyr"
                                                                    , KilometerPerSextillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) kilometer per octillion years. Defined as: ((10.0)/(1000.0)) × hectometer per septillion years + (0).
   /// </summary>
   public static readonly Velocity KilometerPerOctillionYears = new (
                                                                     "kilometer per octillion years"
                                                                   , "km/Ryr"
                                                                   , HectometerPerSeptillionYears
                                                                   , 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) petameter per quintillion years. Defined as: ((1000.0)/(1000.0)) × terameter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity PetameterPerQuintillionYears = new (
                                                                       "petameter per quintillion years"
                                                                     , "Pm/Eyr"
                                                                     , TerameterPerQuadrillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) zettameter per quadrillion years. Defined as: ((1000.0)/(1000.0)) × exameter per trillion years + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerQuadrillionYears = new (
                                                                        "zettameter per quadrillion years"
                                                                      , "Zm/Pyr"
                                                                      , ExameterPerTrillionYears
                                                                      , 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) ronnameter per trillion years. Defined as: ((1000.0)/(1000.0)) × yottameter per billion years + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerTrillionYears = new (
                                                                     "ronnameter per trillion years"
                                                                   , "Rm/Tyr"
                                                                   , YottameterPerBillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekameter per planck-time. Defined as: ((10.0)/(5.391247E-38)) × meter per microsecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerPlanckTime = new (
                                                                 "dekameter per planck-time"
                                                               , "dam/tₚ"
                                                               , MeterPerMicrosecond
                                                               , 10.0 / 5.391247E-38
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per sextillion years. Defined as: ((1000.0)/(1000.0)) × gigameter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity TerameterPerSextillionYears = new (
                                                                      "terameter per sextillion years"
                                                                    , "Tm/Zyr"
                                                                    , GigameterPerQuintillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hectometer per decillion years. Defined as: ((10.0)/(1000.0)) × dekameter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity HectometerPerDecillionYears = new (
                                                                      "hectometer per decillion years"
                                                                    , "hm/decillion yr"
                                                                    , DekameterPerNonillionYears
                                                                    , 10.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) gigameter per septillion years. Defined as: ((1000.0)/(1000.0)) × megameter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity GigameterPerSeptillionYears = new (
                                                                      "gigameter per septillion years"
                                                                    , "Gm/Yyr"
                                                                    , MegameterPerSextillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) kilometer per nonillion years. Defined as: ((10.0)/(1000.0)) × hectometer per octillion years + (0).
   /// </summary>
   public static readonly Velocity KilometerPerNonillionYears = new (
                                                                     "kilometer per nonillion years"
                                                                   , "km/Qyr"
                                                                   , HectometerPerOctillionYears
                                                                   , 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) megameter per octillion years. Defined as: ((1000.0)/(1000.0)) × kilometer per septillion years + (0).
   /// </summary>
   public static readonly Velocity MegameterPerOctillionYears = new (
                                                                     "megameter per octillion years"
                                                                   , "Mm/Ryr"
                                                                   , KilometerPerSeptillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exameter per quintillion years. Defined as: ((1000.0)/(1000.0)) × petameter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity ExameterPerQuintillionYears = new (
                                                                      "exameter per quintillion years"
                                                                    , "Em/Eyr"
                                                                    , PetameterPerQuadrillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yoctometer per tick. Defined as: ((1.0/1000.0)/(100.0)) × zeptometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity YoctometerPerTick = new (
                                                            "yoctometer per tick"
                                                          , "ym/tick"
                                                          , ZeptometerPerNanosecond
                                                          , 1.0 / 1000.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) quettameter per trillion years. Defined as: ((1000.0)/(1000.0)) × ronnameter per billion years + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerTrillionYears = new (
                                                                      "quettameter per trillion years"
                                                                    , "Qm/Tyr"
                                                                    , RonnameterPerBillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yottameter per quadrillion years. Defined as: ((1000.0)/(1000.0)) × zettameter per trillion years + (0).
   /// </summary>
   public static readonly Velocity YottameterPerQuadrillionYears = new (
                                                                        "yottameter per quadrillion years"
                                                                      , "Ym/Pyr"
                                                                      , ZettameterPerTrillionYears
                                                                      , 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) petameter per sextillion years. Defined as: ((1000.0)/(1000.0)) × terameter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity PetameterPerSextillionYears = new (
                                                                      "petameter per sextillion years"
                                                                    , "Pm/Zyr"
                                                                    , TerameterPerQuintillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hectometer per planck-time. Defined as: ((10.0)/(5.391247E-38)) × dekameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerPlanckTime = new (
                                                                  "hectometer per planck-time"
                                                                , "hm/tₚ"
                                                                , DekameterPerMicrosecond
                                                                , 10.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per septillion years. Defined as: ((1000.0)/(1000.0)) × gigameter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity TerameterPerSeptillionYears = new (
                                                                      "terameter per septillion years"
                                                                    , "Tm/Yyr"
                                                                    , GigameterPerSextillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) zettameter per quintillion years. Defined as: ((1000.0)/(1000.0)) × exameter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerQuintillionYears = new (
                                                                        "zettameter per quintillion years"
                                                                      , "Zm/Eyr"
                                                                      , ExameterPerQuadrillionYears
                                                                      , 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) kilometer per decillion years. Defined as: ((10.0)/(1000.0)) × hectometer per nonillion years + (0).
   /// </summary>
   public static readonly Velocity KilometerPerDecillionYears = new (
                                                                     "kilometer per decillion years"
                                                                   , "km/decillion yr"
                                                                   , HectometerPerNonillionYears
                                                                   , 10.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) gigameter per octillion years. Defined as: ((1000.0)/(1000.0)) × megameter per septillion years + (0).
   /// </summary>
   public static readonly Velocity GigameterPerOctillionYears = new (
                                                                     "gigameter per octillion years"
                                                                   , "Gm/Ryr"
                                                                   , MegameterPerSeptillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnameter per quadrillion years. Defined as: ((1000.0)/(1000.0)) × yottameter per trillion years + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerQuadrillionYears = new (
                                                                        "ronnameter per quadrillion years"
                                                                      , "Rm/Pyr"
                                                                      , YottameterPerTrillionYears
                                                                      , 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) megameter per nonillion years. Defined as: ((1000.0)/(1000.0)) × kilometer per octillion years + (0).
   /// </summary>
   public static readonly Velocity MegameterPerNonillionYears = new (
                                                                     "megameter per nonillion years"
                                                                   , "Mm/Qyr"
                                                                   , KilometerPerOctillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exameter per sextillion years. Defined as: ((1000.0)/(1000.0)) × petameter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity ExameterPerSextillionYears = new (
                                                                     "exameter per sextillion years"
                                                                   , "Em/Zyr"
                                                                   , PetameterPerQuintillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottameter per quintillion years. Defined as: ((1000.0)/(1000.0)) × zettameter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity YottameterPerQuintillionYears = new (
                                                                        "yottameter per quintillion years"
                                                                      , "Ym/Eyr"
                                                                      , ZettameterPerQuadrillionYears
                                                                      , 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) rontometer per tick. Defined as: ((1.0/1000.0)/(100.0)) × yoctometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity RontometerPerTick = new (
                                                            "rontometer per tick"
                                                          , "rm/tick"
                                                          , YoctometerPerNanosecond
                                                          , 1.0 / 1000.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) petameter per septillion years. Defined as: ((1000.0)/(1000.0)) × terameter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity PetameterPerSeptillionYears = new (
                                                                      "petameter per septillion years"
                                                                    , "Pm/Yyr"
                                                                    , TerameterPerSextillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettameter per quadrillion years. Defined as: ((1000.0)/(1000.0)) × ronnameter per trillion years + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerQuadrillionYears = new (
                                                                         "quettameter per quadrillion years"
                                                                       , "Qm/Pyr"
                                                                       , RonnameterPerTrillionYears
                                                                       , 1000.0 / 1000.0
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) kilometer per planck-time. Defined as: ((10.0)/(5.391247E-38)) × hectometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerPlanckTime = new (
                                                                 "kilometer per planck-time"
                                                               , "km/tₚ"
                                                               , HectometerPerMicrosecond
                                                               , 10.0 / 5.391247E-38
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per octillion years. Defined as: ((1000.0)/(1000.0)) × gigameter per septillion years + (0).
   /// </summary>
   public static readonly Velocity TerameterPerOctillionYears = new (
                                                                     "terameter per octillion years"
                                                                   , "Tm/Ryr"
                                                                   , GigameterPerSeptillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) megameter per decillion years. Defined as: ((1000.0)/(1000.0)) × kilometer per nonillion years + (0).
   /// </summary>
   public static readonly Velocity MegameterPerDecillionYears = new (
                                                                     "megameter per decillion years"
                                                                   , "Mm/decillion yr"
                                                                   , KilometerPerNonillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) gigameter per nonillion years. Defined as: ((1000.0)/(1000.0)) × megameter per octillion years + (0).
   /// </summary>
   public static readonly Velocity GigameterPerNonillionYears = new (
                                                                     "gigameter per nonillion years"
                                                                   , "Gm/Qyr"
                                                                   , MegameterPerOctillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettameter per sextillion years. Defined as: ((1000.0)/(1000.0)) × exameter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerSextillionYears = new (
                                                                       "zettameter per sextillion years"
                                                                     , "Zm/Zyr"
                                                                     , ExameterPerQuintillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) ronnameter per quintillion years. Defined as: ((1000.0)/(1000.0)) × yottameter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerQuintillionYears = new (
                                                                        "ronnameter per quintillion years"
                                                                      , "Rm/Eyr"
                                                                      , YottameterPerQuadrillionYears
                                                                      , 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) exameter per septillion years. Defined as: ((1000.0)/(1000.0)) × petameter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity ExameterPerSeptillionYears = new (
                                                                     "exameter per septillion years"
                                                                   , "Em/Yyr"
                                                                   , PetameterPerSextillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) petameter per octillion years. Defined as: ((1000.0)/(1000.0)) × terameter per septillion years + (0).
   /// </summary>
   public static readonly Velocity PetameterPerOctillionYears = new (
                                                                     "petameter per octillion years"
                                                                   , "Pm/Ryr"
                                                                   , TerameterPerSeptillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottameter per sextillion years. Defined as: ((1000.0)/(1000.0)) × zettameter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity YottameterPerSextillionYears = new (
                                                                       "yottameter per sextillion years"
                                                                     , "Ym/Zyr"
                                                                     , ZettameterPerQuintillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) megameter per planck-time. Defined as: ((1000.0)/(5.391247E-38)) × kilometer per microsecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerPlanckTime = new (
                                                                 "megameter per planck-time"
                                                               , "Mm/tₚ"
                                                               , KilometerPerMicrosecond
                                                               , 1000.0 / 5.391247E-38
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per nonillion years. Defined as: ((1000.0)/(1000.0)) × gigameter per octillion years + (0).
   /// </summary>
   public static readonly Velocity TerameterPerNonillionYears = new (
                                                                     "terameter per nonillion years"
                                                                   , "Tm/Qyr"
                                                                   , GigameterPerOctillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) gigameter per decillion years. Defined as: ((1000.0)/(1000.0)) × megameter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity GigameterPerDecillionYears = new (
                                                                     "gigameter per decillion years"
                                                                   , "Gm/decillion yr"
                                                                   , MegameterPerNonillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectometer per tick. Defined as: ((1.0/1000.0)/(100.0)) × rontometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity QuectometerPerTick = new (
                                                             "quectometer per tick"
                                                           , "qm/tick"
                                                           , RontometerPerNanosecond
                                                           , 1.0 / 1000.0 / 100.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) quettameter per quintillion years. Defined as: ((1000.0)/(1000.0)) × ronnameter per quadrillion years + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerQuintillionYears = new (
                                                                         "quettameter per quintillion years"
                                                                       , "Qm/Eyr"
                                                                       , RonnameterPerQuadrillionYears
                                                                       , 1000.0 / 1000.0
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) zettameter per septillion years. Defined as: ((1000.0)/(1000.0)) × exameter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerSeptillionYears = new (
                                                                       "zettameter per septillion years"
                                                                     , "Zm/Yyr"
                                                                     , ExameterPerSextillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) exameter per octillion years. Defined as: ((1000.0)/(1000.0)) × petameter per septillion years + (0).
   /// </summary>
   public static readonly Velocity ExameterPerOctillionYears = new (
                                                                    "exameter per octillion years"
                                                                  , "Em/Ryr"
                                                                  , PetameterPerSeptillionYears
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) ronnameter per sextillion years. Defined as: ((1000.0)/(1000.0)) × yottameter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerSextillionYears = new (
                                                                       "ronnameter per sextillion years"
                                                                     , "Rm/Zyr"
                                                                     , YottameterPerQuintillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) petameter per nonillion years. Defined as: ((1000.0)/(1000.0)) × terameter per octillion years + (0).
   /// </summary>
   public static readonly Velocity PetameterPerNonillionYears = new (
                                                                     "petameter per nonillion years"
                                                                   , "Pm/Qyr"
                                                                   , TerameterPerOctillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) gigameter per planck-time. Defined as: ((1000.0)/(5.391247E-38)) × megameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerPlanckTime = new (
                                                                 "gigameter per planck-time"
                                                               , "Gm/tₚ"
                                                               , MegameterPerMicrosecond
                                                               , 1000.0 / 5.391247E-38
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) terameter per decillion years. Defined as: ((1000.0)/(1000.0)) × gigameter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity TerameterPerDecillionYears = new (
                                                                     "terameter per decillion years"
                                                                   , "Tm/decillion yr"
                                                                   , GigameterPerNonillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottameter per septillion years. Defined as: ((1000.0)/(1000.0)) × zettameter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity YottameterPerSeptillionYears = new (
                                                                       "yottameter per septillion years"
                                                                     , "Ym/Yyr"
                                                                     , ZettameterPerSextillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) dekameter per tick. Defined as: ((10.0)/(100.0)) × meter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity DekameterPerTick = new (
                                                           "dekameter per tick"
                                                         , "dam/tick"
                                                         , MeterPerNanosecond
                                                         , 10.0 / 100.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) quettameter per sextillion years. Defined as: ((1000.0)/(1000.0)) × ronnameter per quintillion years + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerSextillionYears = new (
                                                                        "quettameter per sextillion years"
                                                                      , "Qm/Zyr"
                                                                      , RonnameterPerQuintillionYears
                                                                      , 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) zettameter per octillion years. Defined as: ((1000.0)/(1000.0)) × exameter per septillion years + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerOctillionYears = new (
                                                                      "zettameter per octillion years"
                                                                    , "Zm/Ryr"
                                                                    , ExameterPerSeptillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) exameter per nonillion years. Defined as: ((1000.0)/(1000.0)) × petameter per octillion years + (0).
   /// </summary>
   public static readonly Velocity ExameterPerNonillionYears = new (
                                                                    "exameter per nonillion years"
                                                                  , "Em/Qyr"
                                                                  , PetameterPerOctillionYears
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) petameter per decillion years. Defined as: ((1000.0)/(1000.0)) × terameter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity PetameterPerDecillionYears = new (
                                                                     "petameter per decillion years"
                                                                   , "Pm/decillion yr"
                                                                   , TerameterPerNonillionYears
                                                                   , 1000.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnameter per septillion years. Defined as: ((1000.0)/(1000.0)) × yottameter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerSeptillionYears = new (
                                                                       "ronnameter per septillion years"
                                                                     , "Rm/Yyr"
                                                                     , YottameterPerSextillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) terameter per planck-time. Defined as: ((1000.0)/(5.391247E-38)) × gigameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerPlanckTime = new (
                                                                 "terameter per planck-time"
                                                               , "Tm/tₚ"
                                                               , GigameterPerMicrosecond
                                                               , 1000.0 / 5.391247E-38
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) yottameter per octillion years. Defined as: ((1000.0)/(1000.0)) × zettameter per septillion years + (0).
   /// </summary>
   public static readonly Velocity YottameterPerOctillionYears = new (
                                                                      "yottameter per octillion years"
                                                                    , "Ym/Ryr"
                                                                    , ZettameterPerSeptillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) zettameter per nonillion years. Defined as: ((1000.0)/(1000.0)) × exameter per octillion years + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerNonillionYears = new (
                                                                      "zettameter per nonillion years"
                                                                    , "Zm/Qyr"
                                                                    , ExameterPerOctillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) hectometer per tick. Defined as: ((10.0)/(100.0)) × dekameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity HectometerPerTick = new (
                                                            "hectometer per tick"
                                                          , "hm/tick"
                                                          , DekameterPerNanosecond
                                                          , 10.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) quettameter per septillion years. Defined as: ((1000.0)/(1000.0)) × ronnameter per sextillion years + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerSeptillionYears = new (
                                                                        "quettameter per septillion years"
                                                                      , "Qm/Yyr"
                                                                      , RonnameterPerSextillionYears
                                                                      , 1000.0 / 1000.0
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) exameter per decillion years. Defined as: ((1000.0)/(1000.0)) × petameter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity ExameterPerDecillionYears = new (
                                                                    "exameter per decillion years"
                                                                  , "Em/decillion yr"
                                                                  , PetameterPerNonillionYears
                                                                  , 1000.0 / 1000.0
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) petameter per planck-time. Defined as: ((1000.0)/(5.391247E-38)) × terameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerPlanckTime = new (
                                                                 "petameter per planck-time"
                                                               , "Pm/tₚ"
                                                               , TerameterPerMicrosecond
                                                               , 1000.0 / 5.391247E-38
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) ronnameter per octillion years. Defined as: ((1000.0)/(1000.0)) × yottameter per septillion years + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerOctillionYears = new (
                                                                      "ronnameter per octillion years"
                                                                    , "Rm/Ryr"
                                                                    , YottameterPerSeptillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yottameter per nonillion years. Defined as: ((1000.0)/(1000.0)) × zettameter per octillion years + (0).
   /// </summary>
   public static readonly Velocity YottameterPerNonillionYears = new (
                                                                      "yottameter per nonillion years"
                                                                    , "Ym/Qyr"
                                                                    , ZettameterPerOctillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) zettameter per decillion years. Defined as: ((1000.0)/(1000.0)) × exameter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerDecillionYears = new (
                                                                      "zettameter per decillion years"
                                                                    , "Zm/decillion yr"
                                                                    , ExameterPerNonillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) exameter per planck-time. Defined as: ((1000.0)/(5.391247E-38)) × petameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerPlanckTime = new (
                                                                "exameter per planck-time"
                                                              , "Em/tₚ"
                                                              , PetameterPerMicrosecond
                                                              , 1000.0 / 5.391247E-38
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) kilometer per tick. Defined as: ((10.0)/(100.0)) × hectometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity KilometerPerTick = new (
                                                           "kilometer per tick"
                                                         , "km/tick"
                                                         , HectometerPerNanosecond
                                                         , 10.0 / 100.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) quettameter per octillion years. Defined as: ((1000.0)/(1000.0)) × ronnameter per septillion years + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerOctillionYears = new (
                                                                       "quettameter per octillion years"
                                                                     , "Qm/Ryr"
                                                                     , RonnameterPerSeptillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) ronnameter per nonillion years. Defined as: ((1000.0)/(1000.0)) × yottameter per octillion years + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerNonillionYears = new (
                                                                      "ronnameter per nonillion years"
                                                                    , "Rm/Qyr"
                                                                    , YottameterPerOctillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yottameter per decillion years. Defined as: ((1000.0)/(1000.0)) × zettameter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity YottameterPerDecillionYears = new (
                                                                      "yottameter per decillion years"
                                                                    , "Ym/decillion yr"
                                                                    , ZettameterPerNonillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) zettameter per planck-time. Defined as: ((1000.0)/(5.391247E-38)) × exameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerPlanckTime = new (
                                                                  "zettameter per planck-time"
                                                                , "Zm/tₚ"
                                                                , ExameterPerMicrosecond
                                                                , 1000.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) megameter per tick. Defined as: ((1000.0)/(100.0)) × kilometer per nanosecond + (0).
   /// </summary>
   public static readonly Velocity MegameterPerTick = new (
                                                           "megameter per tick"
                                                         , "Mm/tick"
                                                         , KilometerPerNanosecond
                                                         , 1000.0 / 100.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) quettameter per nonillion years. Defined as: ((1000.0)/(1000.0)) × ronnameter per octillion years + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerNonillionYears = new (
                                                                       "quettameter per nonillion years"
                                                                     , "Qm/Qyr"
                                                                     , RonnameterPerOctillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) ronnameter per decillion years. Defined as: ((1000.0)/(1000.0)) × yottameter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerDecillionYears = new (
                                                                      "ronnameter per decillion years"
                                                                    , "Rm/decillion yr"
                                                                    , YottameterPerNonillionYears
                                                                    , 1000.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yottameter per planck-time. Defined as: ((1000.0)/(5.391247E-38)) × zettameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerPlanckTime = new (
                                                                  "yottameter per planck-time"
                                                                , "Ym/tₚ"
                                                                , ZettameterPerMicrosecond
                                                                , 1000.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) gigameter per tick. Defined as: ((1000.0)/(100.0)) × megameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity GigameterPerTick = new (
                                                           "gigameter per tick"
                                                         , "Gm/tick"
                                                         , MegameterPerNanosecond
                                                         , 1000.0 / 100.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) quettameter per decillion years. Defined as: ((1000.0)/(1000.0)) × ronnameter per nonillion years + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerDecillionYears = new (
                                                                       "quettameter per decillion years"
                                                                     , "Qm/decillion yr"
                                                                     , RonnameterPerNonillionYears
                                                                     , 1000.0 / 1000.0
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) ronnameter per planck-time. Defined as: ((1000.0)/(5.391247E-38)) × yottameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerPlanckTime = new (
                                                                  "ronnameter per planck-time"
                                                                , "Rm/tₚ"
                                                                , YottameterPerMicrosecond
                                                                , 1000.0 / 5.391247E-38
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) terameter per tick. Defined as: ((1000.0)/(100.0)) × gigameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity TerameterPerTick = new (
                                                           "terameter per tick"
                                                         , "Tm/tick"
                                                         , GigameterPerNanosecond
                                                         , 1000.0 / 100.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) quettameter per planck-time. Defined as: ((1000.0)/(5.391247E-38)) × ronnameter per microsecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerPlanckTime = new (
                                                                   "quettameter per planck-time"
                                                                 , "Qm/tₚ"
                                                                 , RonnameterPerMicrosecond
                                                                 , 1000.0 / 5.391247E-38
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petameter per tick. Defined as: ((1000.0)/(100.0)) × terameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity PetameterPerTick = new (
                                                           "petameter per tick"
                                                         , "Pm/tick"
                                                         , TerameterPerNanosecond
                                                         , 1000.0 / 100.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) exameter per tick. Defined as: ((1000.0)/(100.0)) × petameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity ExameterPerTick = new (
                                                          "exameter per tick"
                                                        , "Em/tick"
                                                        , PetameterPerNanosecond
                                                        , 1000.0 / 100.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) zettameter per tick. Defined as: ((1000.0)/(100.0)) × exameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity ZettameterPerTick = new (
                                                            "zettameter per tick"
                                                          , "Zm/tick"
                                                          , ExameterPerNanosecond
                                                          , 1000.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) yottameter per tick. Defined as: ((1000.0)/(100.0)) × zettameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity YottameterPerTick = new (
                                                            "yottameter per tick"
                                                          , "Ym/tick"
                                                          , ZettameterPerNanosecond
                                                          , 1000.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) ronnameter per tick. Defined as: ((1000.0)/(100.0)) × yottameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity RonnameterPerTick = new (
                                                            "ronnameter per tick"
                                                          , "Rm/tick"
                                                          , YottameterPerNanosecond
                                                          , 1000.0 / 100.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) quettameter per tick. Defined as: ((1000.0)/(100.0)) × ronnameter per nanosecond + (0).
   /// </summary>
   public static readonly Velocity QuettameterPerTick = new (
                                                             "quettameter per tick"
                                                           , "Qm/tick"
                                                           , RonnameterPerNanosecond
                                                           , 1000.0 / 100.0
                                                           , 0
                                                            );
}
