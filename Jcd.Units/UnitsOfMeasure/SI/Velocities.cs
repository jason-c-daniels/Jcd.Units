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
   /// meter per second, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Velocity MeterPerSecond = new ("meter per second", "m/s");

   /// <summary>
   /// meter per decisecond, defined as: meter per second × (1.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MeterPerDecisecond = new (
                                                             "meter per decisecond"
                                                           , "m/ds"
                                                           , MeterPerSecond
                                                           , 1.0 / (1.0 / 10.0)
                                                            );

   /// <summary>
   /// decimeter per second, defined as: meter per second × (1.0/10.0)/(1.0)
   /// </summary>
   public static readonly Velocity DecimeterPerSecond = new (
                                                             "decimeter per second"
                                                           , "dm/s"
                                                           , MeterPerSecond
                                                           , 1.0 / 10.0 / 1.0
                                                            );

   /// <summary>
   /// meter per centisecond, defined as: meter per decisecond × (1.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MeterPerCentisecond =
            new ("meter per centisecond", "m/cs", MeterPerDecisecond, 1.0 / (1.0 / 10.0));

   /// <summary>
   /// decimeter per decisecond, defined as: meter per second × (1.0/10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity DecimeterPerDecisecond =
            new ("decimeter per decisecond", "dm/ds", MeterPerSecond, 1.0 / 10.0 / (1.0 / 10.0));

   /// <summary>
   /// centimeter per second, defined as: decimeter per second × (1.0/10.0)/(1.0)
   /// </summary>
   public static readonly Velocity CentimeterPerSecond =
            new ("centimeter per second", "cm/s", DecimeterPerSecond, 1.0 / 10.0 / 1.0);

   /// <summary>
   /// meter per millisecond, defined as: meter per centisecond × (1.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MeterPerMillisecond =
            new ("meter per millisecond", "m/ms", MeterPerCentisecond, 1.0 / (1.0 / 10.0));

   /// <summary>
   /// decimeter per centisecond, defined as: meter per decisecond × (1.0/10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity DecimeterPerCentisecond = new (
                                                                  "decimeter per centisecond"
                                                                , "dm/cs"
                                                                , MeterPerDecisecond
                                                                , 1.0 / 10.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// centimeter per decisecond, defined as: decimeter per second × (1.0/10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity CentimeterPerDecisecond = new (
                                                                  "centimeter per decisecond"
                                                                , "cm/ds"
                                                                , DecimeterPerSecond
                                                                , 1.0 / 10.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// millimeter per second, defined as: centimeter per second × (1.0/10.0)/(1.0)
   /// </summary>
   public static readonly Velocity MillimeterPerSecond =
            new ("millimeter per second", "mm/s", CentimeterPerSecond, 1.0 / 10.0 / 1.0);

   /// <summary>
   /// meter per microsecond, defined as: meter per millisecond × (1.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MeterPerMicrosecond =
            new ("meter per microsecond", "m/μs", MeterPerMillisecond, 1.0 / (1.0 / 1000.0));

   /// <summary>
   /// decimeter per millisecond, defined as: meter per centisecond × (1.0/10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity DecimeterPerMillisecond = new (
                                                                  "decimeter per millisecond"
                                                                , "dm/ms"
                                                                , MeterPerCentisecond
                                                                , 1.0 / 10.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// centimeter per centisecond, defined as: decimeter per decisecond × (1.0/10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity CentimeterPerCentisecond = new (
                                                                   "centimeter per centisecond"
                                                                 , "cm/cs"
                                                                 , DecimeterPerDecisecond
                                                                 , 1.0 / 10.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// millimeter per decisecond, defined as: centimeter per second × (1.0/10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MillimeterPerDecisecond = new (
                                                                  "millimeter per decisecond"
                                                                , "mm/ds"
                                                                , CentimeterPerSecond
                                                                , 1.0 / 10.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// micrometer per second, defined as: millimeter per second × (1.0/1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity MicrometerPerSecond =
            new ("micrometer per second", "μm/s", MillimeterPerSecond, 1.0 / 1000.0 / 1.0);

   /// <summary>
   /// meter per nanosecond, defined as: meter per microsecond × (1.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MeterPerNanosecond = new (
                                                             "meter per nanosecond"
                                                           , "m/ns"
                                                           , MeterPerMicrosecond
                                                           , 1.0 / (1.0 / 1000.0)
                                                            );

   /// <summary>
   /// decimeter per microsecond, defined as: meter per millisecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerMicrosecond = new (
                                                                  "decimeter per microsecond"
                                                                , "dm/μs"
                                                                , MeterPerMillisecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// centimeter per millisecond, defined as: decimeter per centisecond × (1.0/10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity CentimeterPerMillisecond = new (
                                                                   "centimeter per millisecond"
                                                                 , "cm/ms"
                                                                 , DecimeterPerCentisecond
                                                                 , 1.0 / 10.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// millimeter per centisecond, defined as: centimeter per decisecond × (1.0/10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MillimeterPerCentisecond = new (
                                                                   "millimeter per centisecond"
                                                                 , "mm/cs"
                                                                 , CentimeterPerDecisecond
                                                                 , 1.0 / 10.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// micrometer per decisecond, defined as: millimeter per second × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MicrometerPerDecisecond = new (
                                                                  "micrometer per decisecond"
                                                                , "μm/ds"
                                                                , MillimeterPerSecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// nanometer per second, defined as: micrometer per second × (1.0/1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity NanometerPerSecond = new (
                                                             "nanometer per second"
                                                           , "nm/s"
                                                           , MicrometerPerSecond
                                                           , 1.0 / 1000.0 / 1.0
                                                            );

   /// <summary>
   /// meter per picosecond, defined as: meter per nanosecond × (1.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MeterPerPicosecond = new (
                                                             "meter per picosecond"
                                                           , "m/ps"
                                                           , MeterPerNanosecond
                                                           , 1.0 / (1.0 / 1000.0)
                                                            );

   /// <summary>
   /// decimeter per nanosecond, defined as: meter per microsecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerNanosecond = new (
                                                                 "decimeter per nanosecond"
                                                               , "dm/ns"
                                                               , MeterPerMicrosecond
                                                               , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// centimeter per microsecond, defined as: decimeter per millisecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerMicrosecond = new (
                                                                   "centimeter per microsecond"
                                                                 , "cm/μs"
                                                                 , DecimeterPerMillisecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// millimeter per millisecond, defined as: centimeter per centisecond × (1.0/10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MillimeterPerMillisecond = new (
                                                                   "millimeter per millisecond"
                                                                 , "mm/ms"
                                                                 , CentimeterPerCentisecond
                                                                 , 1.0 / 10.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// micrometer per centisecond, defined as: millimeter per decisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MicrometerPerCentisecond = new (
                                                                   "micrometer per centisecond"
                                                                 , "μm/cs"
                                                                 , MillimeterPerDecisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// nanometer per decisecond, defined as: micrometer per second × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity NanometerPerDecisecond = new (
                                                                 "nanometer per decisecond"
                                                               , "nm/ds"
                                                               , MicrometerPerSecond
                                                               , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                );

   /// <summary>
   /// picometer per second, defined as: nanometer per second × (1.0/1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity PicometerPerSecond = new (
                                                             "picometer per second"
                                                           , "pm/s"
                                                           , NanometerPerSecond
                                                           , 1.0 / 1000.0 / 1.0
                                                            );

   /// <summary>
   /// meter per femtosecond, defined as: meter per picosecond × (1.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MeterPerFemtosecond =
            new ("meter per femtosecond", "m/fs", MeterPerPicosecond, 1.0 / (1.0 / 1000.0));

   /// <summary>
   /// decimeter per picosecond, defined as: meter per nanosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerPicosecond = new (
                                                                 "decimeter per picosecond"
                                                               , "dm/ps"
                                                               , MeterPerNanosecond
                                                               , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// centimeter per nanosecond, defined as: decimeter per microsecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerNanosecond = new (
                                                                  "centimeter per nanosecond"
                                                                , "cm/ns"
                                                                , DecimeterPerMicrosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// millimeter per microsecond, defined as: centimeter per millisecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerMicrosecond = new (
                                                                   "millimeter per microsecond"
                                                                 , "mm/μs"
                                                                 , CentimeterPerMillisecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// micrometer per millisecond, defined as: millimeter per centisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MicrometerPerMillisecond = new (
                                                                   "micrometer per millisecond"
                                                                 , "μm/ms"
                                                                 , MillimeterPerCentisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// nanometer per centisecond, defined as: micrometer per decisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity NanometerPerCentisecond = new (
                                                                  "nanometer per centisecond"
                                                                , "nm/cs"
                                                                , MicrometerPerDecisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// picometer per decisecond, defined as: nanometer per second × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PicometerPerDecisecond = new (
                                                                 "picometer per decisecond"
                                                               , "pm/ds"
                                                               , NanometerPerSecond
                                                               , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                );

   /// <summary>
   /// femtometer per second, defined as: picometer per second × (1.0/1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity FemtometerPerSecond =
            new ("femtometer per second", "fm/s", PicometerPerSecond, 1.0 / 1000.0 / 1.0);

   /// <summary>
   /// meter per attosecond, defined as: meter per femtosecond × (1.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MeterPerAttosecond = new (
                                                             "meter per attosecond"
                                                           , "m/as"
                                                           , MeterPerFemtosecond
                                                           , 1.0 / (1.0 / 1000.0)
                                                            );

   /// <summary>
   /// decimeter per femtosecond, defined as: meter per picosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerFemtosecond = new (
                                                                  "decimeter per femtosecond"
                                                                , "dm/fs"
                                                                , MeterPerPicosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// centimeter per picosecond, defined as: decimeter per nanosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerPicosecond = new (
                                                                  "centimeter per picosecond"
                                                                , "cm/ps"
                                                                , DecimeterPerNanosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// millimeter per nanosecond, defined as: centimeter per microsecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerNanosecond = new (
                                                                  "millimeter per nanosecond"
                                                                , "mm/ns"
                                                                , CentimeterPerMicrosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// micrometer per microsecond, defined as: millimeter per millisecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerMicrosecond = new (
                                                                   "micrometer per microsecond"
                                                                 , "μm/μs"
                                                                 , MillimeterPerMillisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// nanometer per millisecond, defined as: micrometer per centisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity NanometerPerMillisecond = new (
                                                                  "nanometer per millisecond"
                                                                , "nm/ms"
                                                                , MicrometerPerCentisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// picometer per centisecond, defined as: nanometer per decisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PicometerPerCentisecond = new (
                                                                  "picometer per centisecond"
                                                                , "pm/cs"
                                                                , NanometerPerDecisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// femtometer per decisecond, defined as: picometer per second × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FemtometerPerDecisecond = new (
                                                                  "femtometer per decisecond"
                                                                , "fm/ds"
                                                                , PicometerPerSecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// attometer per second, defined as: femtometer per second × (1.0/1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity AttometerPerSecond = new (
                                                             "attometer per second"
                                                           , "am/s"
                                                           , FemtometerPerSecond
                                                           , 1.0 / 1000.0 / 1.0
                                                            );

   /// <summary>
   /// meter per zeptosecond, defined as: meter per attosecond × (1.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MeterPerZeptosecond =
            new ("meter per zeptosecond", "m/zs", MeterPerAttosecond, 1.0 / (1.0 / 1000.0));

   /// <summary>
   /// decimeter per attosecond, defined as: meter per femtosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerAttosecond = new (
                                                                 "decimeter per attosecond"
                                                               , "dm/as"
                                                               , MeterPerFemtosecond
                                                               , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// centimeter per femtosecond, defined as: decimeter per picosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerFemtosecond = new (
                                                                   "centimeter per femtosecond"
                                                                 , "cm/fs"
                                                                 , DecimeterPerPicosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// millimeter per picosecond, defined as: centimeter per nanosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerPicosecond = new (
                                                                  "millimeter per picosecond"
                                                                , "mm/ps"
                                                                , CentimeterPerNanosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// micrometer per nanosecond, defined as: millimeter per microsecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerNanosecond = new (
                                                                  "micrometer per nanosecond"
                                                                , "μm/ns"
                                                                , MillimeterPerMicrosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// nanometer per microsecond, defined as: micrometer per millisecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerMicrosecond = new (
                                                                  "nanometer per microsecond"
                                                                , "nm/μs"
                                                                , MicrometerPerMillisecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// picometer per millisecond, defined as: nanometer per centisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PicometerPerMillisecond = new (
                                                                  "picometer per millisecond"
                                                                , "pm/ms"
                                                                , NanometerPerCentisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// femtometer per centisecond, defined as: picometer per decisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FemtometerPerCentisecond = new (
                                                                   "femtometer per centisecond"
                                                                 , "fm/cs"
                                                                 , PicometerPerDecisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// attometer per decisecond, defined as: femtometer per second × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity AttometerPerDecisecond = new (
                                                                 "attometer per decisecond"
                                                               , "am/ds"
                                                               , FemtometerPerSecond
                                                               , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                );

   /// <summary>
   /// zeptometer per second, defined as: attometer per second × (1.0/1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerSecond =
            new ("zeptometer per second", "zm/s", AttometerPerSecond, 1.0 / 1000.0 / 1.0);

   /// <summary>
   /// meter per yoctosecond, defined as: meter per zeptosecond × (1.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MeterPerYoctosecond =
            new ("meter per yoctosecond", "m/ys", MeterPerZeptosecond, 1.0 / (1.0 / 1000.0));

   /// <summary>
   /// decimeter per zeptosecond, defined as: meter per attosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerZeptosecond = new (
                                                                  "decimeter per zeptosecond"
                                                                , "dm/zs"
                                                                , MeterPerAttosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// centimeter per attosecond, defined as: decimeter per femtosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerAttosecond = new (
                                                                  "centimeter per attosecond"
                                                                , "cm/as"
                                                                , DecimeterPerFemtosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// millimeter per femtosecond, defined as: centimeter per picosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerFemtosecond = new (
                                                                   "millimeter per femtosecond"
                                                                 , "mm/fs"
                                                                 , CentimeterPerPicosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// micrometer per picosecond, defined as: millimeter per nanosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerPicosecond = new (
                                                                  "micrometer per picosecond"
                                                                , "μm/ps"
                                                                , MillimeterPerNanosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// nanometer per nanosecond, defined as: micrometer per microsecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerNanosecond = new (
                                                                 "nanometer per nanosecond"
                                                               , "nm/ns"
                                                               , MicrometerPerMicrosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// picometer per microsecond, defined as: nanometer per millisecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerMicrosecond = new (
                                                                  "picometer per microsecond"
                                                                , "pm/μs"
                                                                , NanometerPerMillisecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// femtometer per millisecond, defined as: picometer per centisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity FemtometerPerMillisecond = new (
                                                                   "femtometer per millisecond"
                                                                 , "fm/ms"
                                                                 , PicometerPerCentisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// attometer per centisecond, defined as: femtometer per decisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity AttometerPerCentisecond = new (
                                                                  "attometer per centisecond"
                                                                , "am/cs"
                                                                , FemtometerPerDecisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// zeptometer per decisecond, defined as: attometer per second × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerDecisecond = new (
                                                                  "zeptometer per decisecond"
                                                                , "zm/ds"
                                                                , AttometerPerSecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// yoctometer per second, defined as: zeptometer per second × (1.0/1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity YoctometerPerSecond =
            new ("yoctometer per second", "ym/s", ZeptometerPerSecond, 1.0 / 1000.0 / 1.0);

   /// <summary>
   /// meter per rontosecond, defined as: meter per yoctosecond × (1.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MeterPerRontosecond =
            new ("meter per rontosecond", "m/rs", MeterPerYoctosecond, 1.0 / (1.0 / 1000.0));

   /// <summary>
   /// decimeter per yoctosecond, defined as: meter per zeptosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerYoctosecond = new (
                                                                  "decimeter per yoctosecond"
                                                                , "dm/ys"
                                                                , MeterPerZeptosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// centimeter per zeptosecond, defined as: decimeter per attosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerZeptosecond = new (
                                                                   "centimeter per zeptosecond"
                                                                 , "cm/zs"
                                                                 , DecimeterPerAttosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// millimeter per attosecond, defined as: centimeter per femtosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerAttosecond = new (
                                                                  "millimeter per attosecond"
                                                                , "mm/as"
                                                                , CentimeterPerFemtosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// micrometer per femtosecond, defined as: millimeter per picosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerFemtosecond = new (
                                                                   "micrometer per femtosecond"
                                                                 , "μm/fs"
                                                                 , MillimeterPerPicosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// nanometer per picosecond, defined as: micrometer per nanosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerPicosecond = new (
                                                                 "nanometer per picosecond"
                                                               , "nm/ps"
                                                               , MicrometerPerNanosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// picometer per nanosecond, defined as: nanometer per microsecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerNanosecond = new (
                                                                 "picometer per nanosecond"
                                                               , "pm/ns"
                                                               , NanometerPerMicrosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// femtometer per microsecond, defined as: picometer per millisecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerMicrosecond = new (
                                                                   "femtometer per microsecond"
                                                                 , "fm/μs"
                                                                 , PicometerPerMillisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// attometer per millisecond, defined as: femtometer per centisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity AttometerPerMillisecond = new (
                                                                  "attometer per millisecond"
                                                                , "am/ms"
                                                                , FemtometerPerCentisecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// zeptometer per centisecond, defined as: attometer per decisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerCentisecond = new (
                                                                   "zeptometer per centisecond"
                                                                 , "zm/cs"
                                                                 , AttometerPerDecisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// yoctometer per decisecond, defined as: zeptometer per second × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity YoctometerPerDecisecond = new (
                                                                  "yoctometer per decisecond"
                                                                , "ym/ds"
                                                                , ZeptometerPerSecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// rontometer per second, defined as: yoctometer per second × (1.0/1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity RontometerPerSecond =
            new ("rontometer per second", "rm/s", YoctometerPerSecond, 1.0 / 1000.0 / 1.0);

   /// <summary>
   /// meter per quectosecond, defined as: meter per rontosecond × (1.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MeterPerQuectosecond =
            new ("meter per quectosecond", "m/qs", MeterPerRontosecond, 1.0 / (1.0 / 1000.0));

   /// <summary>
   /// decimeter per rontosecond, defined as: meter per yoctosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerRontosecond = new (
                                                                  "decimeter per rontosecond"
                                                                , "dm/rs"
                                                                , MeterPerYoctosecond
                                                                , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// centimeter per yoctosecond, defined as: decimeter per zeptosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerYoctosecond = new (
                                                                   "centimeter per yoctosecond"
                                                                 , "cm/ys"
                                                                 , DecimeterPerZeptosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// millimeter per zeptosecond, defined as: centimeter per attosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerZeptosecond = new (
                                                                   "millimeter per zeptosecond"
                                                                 , "mm/zs"
                                                                 , CentimeterPerAttosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// micrometer per attosecond, defined as: millimeter per femtosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerAttosecond = new (
                                                                  "micrometer per attosecond"
                                                                , "μm/as"
                                                                , MillimeterPerFemtosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// nanometer per femtosecond, defined as: micrometer per picosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerFemtosecond = new (
                                                                  "nanometer per femtosecond"
                                                                , "nm/fs"
                                                                , MicrometerPerPicosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// picometer per picosecond, defined as: nanometer per nanosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerPicosecond = new (
                                                                 "picometer per picosecond"
                                                               , "pm/ps"
                                                               , NanometerPerNanosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// femtometer per nanosecond, defined as: picometer per microsecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerNanosecond = new (
                                                                  "femtometer per nanosecond"
                                                                , "fm/ns"
                                                                , PicometerPerMicrosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// attometer per microsecond, defined as: femtometer per millisecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerMicrosecond = new (
                                                                  "attometer per microsecond"
                                                                , "am/μs"
                                                                , FemtometerPerMillisecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// zeptometer per millisecond, defined as: attometer per centisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerMillisecond = new (
                                                                   "zeptometer per millisecond"
                                                                 , "zm/ms"
                                                                 , AttometerPerCentisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// yoctometer per centisecond, defined as: zeptometer per decisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity YoctometerPerCentisecond = new (
                                                                   "yoctometer per centisecond"
                                                                 , "ym/cs"
                                                                 , ZeptometerPerDecisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// rontometer per decisecond, defined as: yoctometer per second × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity RontometerPerDecisecond = new (
                                                                  "rontometer per decisecond"
                                                                , "rm/ds"
                                                                , YoctometerPerSecond
                                                                , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// quectometer per second, defined as: rontometer per second × (1.0/1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity QuectometerPerSecond =
            new ("quectometer per second", "qm/s", RontometerPerSecond, 1.0 / 1000.0 / 1.0);

   /// <summary>
   /// dekameter per second, defined as: meter per second × (10.0)/(1.0)
   /// </summary>
   public static readonly Velocity DekameterPerSecond = new (
                                                             "dekameter per second"
                                                           , "dam/s"
                                                           , MeterPerSecond
                                                           , 10.0 / 1.0
                                                            );

   /// <summary>
   /// dekameter per planck-time, defined as: meter per microsecond × (10.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity DekameterPerPlanckTime =
            new ("dekameter per planck-time", "dam/tₚ", MeterPerMicrosecond, 10.0 / 5.391247E-38);

   /// <summary>
   /// decimeter per quectosecond, defined as: meter per rontosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerQuectosecond = new (
                                                                   "decimeter per quectosecond"
                                                                 , "dm/qs"
                                                                 , MeterPerRontosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// centimeter per rontosecond, defined as: decimeter per yoctosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerRontosecond = new (
                                                                   "centimeter per rontosecond"
                                                                 , "cm/rs"
                                                                 , DecimeterPerYoctosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// millimeter per yoctosecond, defined as: centimeter per zeptosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerYoctosecond = new (
                                                                   "millimeter per yoctosecond"
                                                                 , "mm/ys"
                                                                 , CentimeterPerZeptosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// micrometer per zeptosecond, defined as: millimeter per attosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerZeptosecond = new (
                                                                   "micrometer per zeptosecond"
                                                                 , "μm/zs"
                                                                 , MillimeterPerAttosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// nanometer per attosecond, defined as: micrometer per femtosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerAttosecond = new (
                                                                 "nanometer per attosecond"
                                                               , "nm/as"
                                                               , MicrometerPerFemtosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// picometer per femtosecond, defined as: nanometer per picosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerFemtosecond = new (
                                                                  "picometer per femtosecond"
                                                                , "pm/fs"
                                                                , NanometerPerPicosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// femtometer per picosecond, defined as: picometer per nanosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerPicosecond = new (
                                                                  "femtometer per picosecond"
                                                                , "fm/ps"
                                                                , PicometerPerNanosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// attometer per nanosecond, defined as: femtometer per microsecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerNanosecond = new (
                                                                 "attometer per nanosecond"
                                                               , "am/ns"
                                                               , FemtometerPerMicrosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// zeptometer per microsecond, defined as: attometer per millisecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerMicrosecond = new (
                                                                   "zeptometer per microsecond"
                                                                 , "zm/μs"
                                                                 , AttometerPerMillisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// yoctometer per millisecond, defined as: zeptometer per centisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity YoctometerPerMillisecond = new (
                                                                   "yoctometer per millisecond"
                                                                 , "ym/ms"
                                                                 , ZeptometerPerCentisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// rontometer per centisecond, defined as: yoctometer per decisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity RontometerPerCentisecond = new (
                                                                   "rontometer per centisecond"
                                                                 , "rm/cs"
                                                                 , YoctometerPerDecisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// quectometer per decisecond, defined as: rontometer per second × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity QuectometerPerDecisecond = new (
                                                                   "quectometer per decisecond"
                                                                 , "qm/ds"
                                                                 , RontometerPerSecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// hectometer per second, defined as: dekameter per second × (10.0)/(1.0)
   /// </summary>
   public static readonly Velocity HectometerPerSecond =
            new ("hectometer per second", "hm/s", DekameterPerSecond, 10.0 / 1.0);

   /// <summary>
   /// dekameter per decisecond, defined as: meter per second × (10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity DekameterPerDecisecond =
            new ("dekameter per decisecond", "dam/ds", MeterPerSecond, 10.0 / (1.0 / 10.0));

   /// <summary>
   /// centimeter per quectosecond, defined as: decimeter per rontosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerQuectosecond = new (
                                                                    "centimeter per quectosecond"
                                                                  , "cm/qs"
                                                                  , DecimeterPerRontosecond
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// millimeter per rontosecond, defined as: centimeter per yoctosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerRontosecond = new (
                                                                   "millimeter per rontosecond"
                                                                 , "mm/rs"
                                                                 , CentimeterPerYoctosecond
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// micrometer per yoctosecond, defined as: millimeter per zeptosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerYoctosecond = new (
                                                                   "micrometer per yoctosecond"
                                                                 , "μm/ys"
                                                                 , MillimeterPerZeptosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// nanometer per zeptosecond, defined as: micrometer per attosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerZeptosecond = new (
                                                                  "nanometer per zeptosecond"
                                                                , "nm/zs"
                                                                , MicrometerPerAttosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// picometer per attosecond, defined as: nanometer per femtosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerAttosecond = new (
                                                                 "picometer per attosecond"
                                                               , "pm/as"
                                                               , NanometerPerFemtosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// femtometer per femtosecond, defined as: picometer per picosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerFemtosecond = new (
                                                                   "femtometer per femtosecond"
                                                                 , "fm/fs"
                                                                 , PicometerPerPicosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// attometer per picosecond, defined as: femtometer per nanosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerPicosecond = new (
                                                                 "attometer per picosecond"
                                                               , "am/ps"
                                                               , FemtometerPerNanosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// zeptometer per nanosecond, defined as: attometer per microsecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerNanosecond = new (
                                                                  "zeptometer per nanosecond"
                                                                , "zm/ns"
                                                                , AttometerPerMicrosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// yoctometer per microsecond, defined as: zeptometer per millisecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerMicrosecond = new (
                                                                   "yoctometer per microsecond"
                                                                 , "ym/μs"
                                                                 , ZeptometerPerMillisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// rontometer per millisecond, defined as: yoctometer per centisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity RontometerPerMillisecond = new (
                                                                   "rontometer per millisecond"
                                                                 , "rm/ms"
                                                                 , YoctometerPerCentisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// quectometer per centisecond, defined as: rontometer per decisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity QuectometerPerCentisecond = new (
                                                                    "quectometer per centisecond"
                                                                  , "qm/cs"
                                                                  , RontometerPerDecisecond
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                   );

   /// <summary>
   /// kilometer per second, defined as: hectometer per second × (10.0)/(1.0)
   /// </summary>
   public static readonly Velocity KilometerPerSecond = new (
                                                             "kilometer per second"
                                                           , "km/s"
                                                           , HectometerPerSecond
                                                           , 10.0 / 1.0
                                                            );

   /// <summary>
   /// hectometer per decisecond, defined as: dekameter per second × (10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity HectometerPerDecisecond =
            new ("hectometer per decisecond", "hm/ds", DekameterPerSecond, 10.0 / (1.0 / 10.0));

   /// <summary>
   /// dekameter per centisecond, defined as: meter per decisecond × (10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity DekameterPerCentisecond =
            new ("dekameter per centisecond", "dam/cs", MeterPerDecisecond, 10.0 / (1.0 / 10.0));

   /// <summary>
   /// millimeter per quectosecond, defined as: centimeter per rontosecond × (1.0/10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerQuectosecond = new (
                                                                    "millimeter per quectosecond"
                                                                  , "mm/qs"
                                                                  , CentimeterPerRontosecond
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// micrometer per rontosecond, defined as: millimeter per yoctosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerRontosecond = new (
                                                                   "micrometer per rontosecond"
                                                                 , "μm/rs"
                                                                 , MillimeterPerYoctosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// nanometer per yoctosecond, defined as: micrometer per zeptosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerYoctosecond = new (
                                                                  "nanometer per yoctosecond"
                                                                , "nm/ys"
                                                                , MicrometerPerZeptosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// picometer per zeptosecond, defined as: nanometer per attosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerZeptosecond = new (
                                                                  "picometer per zeptosecond"
                                                                , "pm/zs"
                                                                , NanometerPerAttosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// femtometer per attosecond, defined as: picometer per femtosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerAttosecond = new (
                                                                  "femtometer per attosecond"
                                                                , "fm/as"
                                                                , PicometerPerFemtosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// attometer per femtosecond, defined as: femtometer per picosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerFemtosecond = new (
                                                                  "attometer per femtosecond"
                                                                , "am/fs"
                                                                , FemtometerPerPicosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// zeptometer per picosecond, defined as: attometer per nanosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerPicosecond = new (
                                                                  "zeptometer per picosecond"
                                                                , "zm/ps"
                                                                , AttometerPerNanosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// yoctometer per nanosecond, defined as: zeptometer per microsecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerNanosecond = new (
                                                                  "yoctometer per nanosecond"
                                                                , "ym/ns"
                                                                , ZeptometerPerMicrosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// rontometer per microsecond, defined as: yoctometer per millisecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerMicrosecond = new (
                                                                   "rontometer per microsecond"
                                                                 , "rm/μs"
                                                                 , YoctometerPerMillisecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// quectometer per millisecond, defined as: rontometer per centisecond × (1.0/1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity QuectometerPerMillisecond = new (
                                                                    "quectometer per millisecond"
                                                                  , "qm/ms"
                                                                  , RontometerPerCentisecond
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0)
                                                                   );

   /// <summary>
   /// megameter per second, defined as: kilometer per second × (1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity MegameterPerSecond = new (
                                                             "megameter per second"
                                                           , "Mm/s"
                                                           , KilometerPerSecond
                                                           , 1000.0 / 1.0
                                                            );

   /// <summary>
   /// kilometer per decisecond, defined as: hectometer per second × (10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity KilometerPerDecisecond =
            new ("kilometer per decisecond", "km/ds", HectometerPerSecond, 10.0 / (1.0 / 10.0));

   /// <summary>
   /// hectometer per centisecond, defined as: dekameter per decisecond × (10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity HectometerPerCentisecond = new (
                                                                   "hectometer per centisecond"
                                                                 , "hm/cs"
                                                                 , DekameterPerDecisecond
                                                                 , 10.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// dekameter per millisecond, defined as: meter per centisecond × (10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity DekameterPerMillisecond =
            new ("dekameter per millisecond", "dam/ms", MeterPerCentisecond, 10.0 / (1.0 / 10.0));

   /// <summary>
   /// micrometer per quectosecond, defined as: millimeter per rontosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerQuectosecond = new (
                                                                    "micrometer per quectosecond"
                                                                  , "μm/qs"
                                                                  , MillimeterPerRontosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// nanometer per rontosecond, defined as: micrometer per yoctosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerRontosecond = new (
                                                                  "nanometer per rontosecond"
                                                                , "nm/rs"
                                                                , MicrometerPerYoctosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// picometer per yoctosecond, defined as: nanometer per zeptosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerYoctosecond = new (
                                                                  "picometer per yoctosecond"
                                                                , "pm/ys"
                                                                , NanometerPerZeptosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// femtometer per zeptosecond, defined as: picometer per attosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerZeptosecond = new (
                                                                   "femtometer per zeptosecond"
                                                                 , "fm/zs"
                                                                 , PicometerPerAttosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// attometer per attosecond, defined as: femtometer per femtosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerAttosecond = new (
                                                                 "attometer per attosecond"
                                                               , "am/as"
                                                               , FemtometerPerFemtosecond
                                                               , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// zeptometer per femtosecond, defined as: attometer per picosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerFemtosecond = new (
                                                                   "zeptometer per femtosecond"
                                                                 , "zm/fs"
                                                                 , AttometerPerPicosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// yoctometer per picosecond, defined as: zeptometer per nanosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerPicosecond = new (
                                                                  "yoctometer per picosecond"
                                                                , "ym/ps"
                                                                , ZeptometerPerNanosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// rontometer per nanosecond, defined as: yoctometer per microsecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerNanosecond = new (
                                                                  "rontometer per nanosecond"
                                                                , "rm/ns"
                                                                , YoctometerPerMicrosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// quectometer per microsecond, defined as: rontometer per millisecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerMicrosecond = new (
                                                                    "quectometer per microsecond"
                                                                  , "qm/μs"
                                                                  , RontometerPerMillisecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// gigameter per second, defined as: megameter per second × (1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity GigameterPerSecond = new (
                                                             "gigameter per second"
                                                           , "Gm/s"
                                                           , MegameterPerSecond
                                                           , 1000.0 / 1.0
                                                            );

   /// <summary>
   /// megameter per decisecond, defined as: kilometer per second × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MegameterPerDecisecond =
            new ("megameter per decisecond", "Mm/ds", KilometerPerSecond, 1000.0 / (1.0 / 10.0));

   /// <summary>
   /// kilometer per centisecond, defined as: hectometer per decisecond × (10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity KilometerPerCentisecond = new (
                                                                  "kilometer per centisecond"
                                                                , "km/cs"
                                                                , HectometerPerDecisecond
                                                                , 10.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// hectometer per millisecond, defined as: dekameter per centisecond × (10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity HectometerPerMillisecond = new (
                                                                   "hectometer per millisecond"
                                                                 , "hm/ms"
                                                                 , DekameterPerCentisecond
                                                                 , 10.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// dekameter per microsecond, defined as: meter per millisecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerMicrosecond = new (
                                                                  "dekameter per microsecond"
                                                                , "dam/μs"
                                                                , MeterPerMillisecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// nanometer per quectosecond, defined as: micrometer per rontosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerQuectosecond = new (
                                                                   "nanometer per quectosecond"
                                                                 , "nm/qs"
                                                                 , MicrometerPerRontosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// picometer per rontosecond, defined as: nanometer per yoctosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerRontosecond = new (
                                                                  "picometer per rontosecond"
                                                                , "pm/rs"
                                                                , NanometerPerYoctosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// femtometer per yoctosecond, defined as: picometer per zeptosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerYoctosecond = new (
                                                                   "femtometer per yoctosecond"
                                                                 , "fm/ys"
                                                                 , PicometerPerZeptosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// attometer per zeptosecond, defined as: femtometer per attosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerZeptosecond = new (
                                                                  "attometer per zeptosecond"
                                                                , "am/zs"
                                                                , FemtometerPerAttosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// zeptometer per attosecond, defined as: attometer per femtosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerAttosecond = new (
                                                                  "zeptometer per attosecond"
                                                                , "zm/as"
                                                                , AttometerPerFemtosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// yoctometer per femtosecond, defined as: zeptometer per picosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerFemtosecond = new (
                                                                   "yoctometer per femtosecond"
                                                                 , "ym/fs"
                                                                 , ZeptometerPerPicosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// rontometer per picosecond, defined as: yoctometer per nanosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerPicosecond = new (
                                                                  "rontometer per picosecond"
                                                                , "rm/ps"
                                                                , YoctometerPerNanosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// quectometer per nanosecond, defined as: rontometer per microsecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerNanosecond = new (
                                                                   "quectometer per nanosecond"
                                                                 , "qm/ns"
                                                                 , RontometerPerMicrosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// terameter per second, defined as: gigameter per second × (1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity TerameterPerSecond = new (
                                                             "terameter per second"
                                                           , "Tm/s"
                                                           , GigameterPerSecond
                                                           , 1000.0 / 1.0
                                                            );

   /// <summary>
   /// gigameter per decisecond, defined as: megameter per second × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity GigameterPerDecisecond =
            new ("gigameter per decisecond", "Gm/ds", MegameterPerSecond, 1000.0 / (1.0 / 10.0));

   /// <summary>
   /// megameter per centisecond, defined as: kilometer per decisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MegameterPerCentisecond = new (
                                                                  "megameter per centisecond"
                                                                , "Mm/cs"
                                                                , KilometerPerDecisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// kilometer per millisecond, defined as: hectometer per centisecond × (10.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity KilometerPerMillisecond = new (
                                                                  "kilometer per millisecond"
                                                                , "km/ms"
                                                                , HectometerPerCentisecond
                                                                , 10.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// hectometer per microsecond, defined as: dekameter per millisecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerMicrosecond = new (
                                                                   "hectometer per microsecond"
                                                                 , "hm/μs"
                                                                 , DekameterPerMillisecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// dekameter per nanosecond, defined as: meter per microsecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerNanosecond =
            new ("dekameter per nanosecond", "dam/ns", MeterPerMicrosecond, 10.0 / (1.0 / 1000.0));

   /// <summary>
   /// picometer per quectosecond, defined as: nanometer per rontosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerQuectosecond = new (
                                                                   "picometer per quectosecond"
                                                                 , "pm/qs"
                                                                 , NanometerPerRontosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// femtometer per rontosecond, defined as: picometer per yoctosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerRontosecond = new (
                                                                   "femtometer per rontosecond"
                                                                 , "fm/rs"
                                                                 , PicometerPerYoctosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// attometer per yoctosecond, defined as: femtometer per zeptosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerYoctosecond = new (
                                                                  "attometer per yoctosecond"
                                                                , "am/ys"
                                                                , FemtometerPerZeptosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// zeptometer per zeptosecond, defined as: attometer per attosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerZeptosecond = new (
                                                                   "zeptometer per zeptosecond"
                                                                 , "zm/zs"
                                                                 , AttometerPerAttosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// yoctometer per attosecond, defined as: zeptometer per femtosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerAttosecond = new (
                                                                  "yoctometer per attosecond"
                                                                , "ym/as"
                                                                , ZeptometerPerFemtosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// rontometer per femtosecond, defined as: yoctometer per picosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerFemtosecond = new (
                                                                   "rontometer per femtosecond"
                                                                 , "rm/fs"
                                                                 , YoctometerPerPicosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// quectometer per picosecond, defined as: rontometer per nanosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerPicosecond = new (
                                                                   "quectometer per picosecond"
                                                                 , "qm/ps"
                                                                 , RontometerPerNanosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// petameter per second, defined as: terameter per second × (1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity PetameterPerSecond = new (
                                                             "petameter per second"
                                                           , "Pm/s"
                                                           , TerameterPerSecond
                                                           , 1000.0 / 1.0
                                                            );

   /// <summary>
   /// terameter per decisecond, defined as: gigameter per second × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity TerameterPerDecisecond =
            new ("terameter per decisecond", "Tm/ds", GigameterPerSecond, 1000.0 / (1.0 / 10.0));

   /// <summary>
   /// gigameter per centisecond, defined as: megameter per decisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity GigameterPerCentisecond = new (
                                                                  "gigameter per centisecond"
                                                                , "Gm/cs"
                                                                , MegameterPerDecisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// megameter per millisecond, defined as: kilometer per centisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity MegameterPerMillisecond = new (
                                                                  "megameter per millisecond"
                                                                , "Mm/ms"
                                                                , KilometerPerCentisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// kilometer per microsecond, defined as: hectometer per millisecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerMicrosecond = new (
                                                                  "kilometer per microsecond"
                                                                , "km/μs"
                                                                , HectometerPerMillisecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// hectometer per nanosecond, defined as: dekameter per microsecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerNanosecond = new (
                                                                  "hectometer per nanosecond"
                                                                , "hm/ns"
                                                                , DekameterPerMicrosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// dekameter per picosecond, defined as: meter per nanosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerPicosecond =
            new ("dekameter per picosecond", "dam/ps", MeterPerNanosecond, 10.0 / (1.0 / 1000.0));

   /// <summary>
   /// femtometer per quectosecond, defined as: picometer per rontosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerQuectosecond = new (
                                                                    "femtometer per quectosecond"
                                                                  , "fm/qs"
                                                                  , PicometerPerRontosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// attometer per rontosecond, defined as: femtometer per yoctosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerRontosecond = new (
                                                                  "attometer per rontosecond"
                                                                , "am/rs"
                                                                , FemtometerPerYoctosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// zeptometer per yoctosecond, defined as: attometer per zeptosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerYoctosecond = new (
                                                                   "zeptometer per yoctosecond"
                                                                 , "zm/ys"
                                                                 , AttometerPerZeptosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// yoctometer per zeptosecond, defined as: zeptometer per attosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerZeptosecond = new (
                                                                   "yoctometer per zeptosecond"
                                                                 , "ym/zs"
                                                                 , ZeptometerPerAttosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// rontometer per attosecond, defined as: yoctometer per femtosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerAttosecond = new (
                                                                  "rontometer per attosecond"
                                                                , "rm/as"
                                                                , YoctometerPerFemtosecond
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// quectometer per femtosecond, defined as: rontometer per picosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerFemtosecond = new (
                                                                    "quectometer per femtosecond"
                                                                  , "qm/fs"
                                                                  , RontometerPerPicosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// exameter per second, defined as: petameter per second × (1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity ExameterPerSecond = new (
                                                            "exameter per second"
                                                          , "Em/s"
                                                          , PetameterPerSecond
                                                          , 1000.0 / 1.0
                                                           );

   /// <summary>
   /// petameter per decisecond, defined as: terameter per second × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PetameterPerDecisecond =
            new ("petameter per decisecond", "Pm/ds", TerameterPerSecond, 1000.0 / (1.0 / 10.0));

   /// <summary>
   /// terameter per centisecond, defined as: gigameter per decisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity TerameterPerCentisecond = new (
                                                                  "terameter per centisecond"
                                                                , "Tm/cs"
                                                                , GigameterPerDecisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// gigameter per millisecond, defined as: megameter per centisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity GigameterPerMillisecond = new (
                                                                  "gigameter per millisecond"
                                                                , "Gm/ms"
                                                                , MegameterPerCentisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// megameter per microsecond, defined as: kilometer per millisecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerMicrosecond = new (
                                                                  "megameter per microsecond"
                                                                , "Mm/μs"
                                                                , KilometerPerMillisecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// kilometer per nanosecond, defined as: hectometer per microsecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerNanosecond = new (
                                                                 "kilometer per nanosecond"
                                                               , "km/ns"
                                                               , HectometerPerMicrosecond
                                                               , 10.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// hectometer per picosecond, defined as: dekameter per nanosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerPicosecond = new (
                                                                  "hectometer per picosecond"
                                                                , "hm/ps"
                                                                , DekameterPerNanosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// dekameter per femtosecond, defined as: meter per picosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerFemtosecond =
            new ("dekameter per femtosecond", "dam/fs", MeterPerPicosecond, 10.0 / (1.0 / 1000.0));

   /// <summary>
   /// attometer per quectosecond, defined as: femtometer per rontosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerQuectosecond = new (
                                                                   "attometer per quectosecond"
                                                                 , "am/qs"
                                                                 , FemtometerPerRontosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// zeptometer per rontosecond, defined as: attometer per yoctosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerRontosecond = new (
                                                                   "zeptometer per rontosecond"
                                                                 , "zm/rs"
                                                                 , AttometerPerYoctosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// yoctometer per yoctosecond, defined as: zeptometer per zeptosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerYoctosecond = new (
                                                                   "yoctometer per yoctosecond"
                                                                 , "ym/ys"
                                                                 , ZeptometerPerZeptosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// rontometer per zeptosecond, defined as: yoctometer per attosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerZeptosecond = new (
                                                                   "rontometer per zeptosecond"
                                                                 , "rm/zs"
                                                                 , YoctometerPerAttosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// quectometer per attosecond, defined as: rontometer per femtosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerAttosecond = new (
                                                                   "quectometer per attosecond"
                                                                 , "qm/as"
                                                                 , RontometerPerFemtosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// zettameter per second, defined as: exameter per second × (1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity ZettameterPerSecond =
            new ("zettameter per second", "Zm/s", ExameterPerSecond, 1000.0 / 1.0);

   /// <summary>
   /// exameter per decisecond, defined as: petameter per second × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ExameterPerDecisecond =
            new ("exameter per decisecond", "Em/ds", PetameterPerSecond, 1000.0 / (1.0 / 10.0));

   /// <summary>
   /// petameter per centisecond, defined as: terameter per decisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PetameterPerCentisecond = new (
                                                                  "petameter per centisecond"
                                                                , "Pm/cs"
                                                                , TerameterPerDecisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// terameter per millisecond, defined as: gigameter per centisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity TerameterPerMillisecond = new (
                                                                  "terameter per millisecond"
                                                                , "Tm/ms"
                                                                , GigameterPerCentisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// gigameter per microsecond, defined as: megameter per millisecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerMicrosecond = new (
                                                                  "gigameter per microsecond"
                                                                , "Gm/μs"
                                                                , MegameterPerMillisecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// megameter per nanosecond, defined as: kilometer per microsecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerNanosecond = new (
                                                                 "megameter per nanosecond"
                                                               , "Mm/ns"
                                                               , KilometerPerMicrosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// kilometer per picosecond, defined as: hectometer per nanosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerPicosecond = new (
                                                                 "kilometer per picosecond"
                                                               , "km/ps"
                                                               , HectometerPerNanosecond
                                                               , 10.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// hectometer per femtosecond, defined as: dekameter per picosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerFemtosecond = new (
                                                                   "hectometer per femtosecond"
                                                                 , "hm/fs"
                                                                 , DekameterPerPicosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// dekameter per attosecond, defined as: meter per femtosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerAttosecond =
            new ("dekameter per attosecond", "dam/as", MeterPerFemtosecond, 10.0 / (1.0 / 1000.0));

   /// <summary>
   /// zeptometer per quectosecond, defined as: attometer per rontosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerQuectosecond = new (
                                                                    "zeptometer per quectosecond"
                                                                  , "zm/qs"
                                                                  , AttometerPerRontosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// yoctometer per rontosecond, defined as: zeptometer per yoctosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerRontosecond = new (
                                                                   "yoctometer per rontosecond"
                                                                 , "ym/rs"
                                                                 , ZeptometerPerYoctosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// rontometer per yoctosecond, defined as: yoctometer per zeptosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerYoctosecond = new (
                                                                   "rontometer per yoctosecond"
                                                                 , "rm/ys"
                                                                 , YoctometerPerZeptosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// quectometer per zeptosecond, defined as: rontometer per attosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerZeptosecond = new (
                                                                    "quectometer per zeptosecond"
                                                                  , "qm/zs"
                                                                  , RontometerPerAttosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// yottameter per second, defined as: zettameter per second × (1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity YottameterPerSecond =
            new ("yottameter per second", "Ym/s", ZettameterPerSecond, 1000.0 / 1.0);

   /// <summary>
   /// zettameter per decisecond, defined as: exameter per second × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ZettameterPerDecisecond =
            new ("zettameter per decisecond", "Zm/ds", ExameterPerSecond, 1000.0 / (1.0 / 10.0));

   /// <summary>
   /// exameter per centisecond, defined as: petameter per decisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ExameterPerCentisecond = new (
                                                                 "exameter per centisecond"
                                                               , "Em/cs"
                                                               , PetameterPerDecisecond
                                                               , 1000.0 / (1.0 / 10.0)
                                                                );

   /// <summary>
   /// petameter per millisecond, defined as: terameter per centisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity PetameterPerMillisecond = new (
                                                                  "petameter per millisecond"
                                                                , "Pm/ms"
                                                                , TerameterPerCentisecond
                                                                , 1000.0 / (1.0 / 10.0)
                                                                 );

   /// <summary>
   /// terameter per microsecond, defined as: gigameter per millisecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerMicrosecond = new (
                                                                  "terameter per microsecond"
                                                                , "Tm/μs"
                                                                , GigameterPerMillisecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// gigameter per nanosecond, defined as: megameter per microsecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerNanosecond = new (
                                                                 "gigameter per nanosecond"
                                                               , "Gm/ns"
                                                               , MegameterPerMicrosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// megameter per picosecond, defined as: kilometer per nanosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerPicosecond = new (
                                                                 "megameter per picosecond"
                                                               , "Mm/ps"
                                                               , KilometerPerNanosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// kilometer per femtosecond, defined as: hectometer per picosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerFemtosecond = new (
                                                                  "kilometer per femtosecond"
                                                                , "km/fs"
                                                                , HectometerPerPicosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// hectometer per attosecond, defined as: dekameter per femtosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerAttosecond = new (
                                                                  "hectometer per attosecond"
                                                                , "hm/as"
                                                                , DekameterPerFemtosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// dekameter per zeptosecond, defined as: meter per attosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerZeptosecond =
            new ("dekameter per zeptosecond", "dam/zs", MeterPerAttosecond, 10.0 / (1.0 / 1000.0));

   /// <summary>
   /// yoctometer per quectosecond, defined as: zeptometer per rontosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerQuectosecond = new (
                                                                    "yoctometer per quectosecond"
                                                                  , "ym/qs"
                                                                  , ZeptometerPerRontosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// rontometer per rontosecond, defined as: yoctometer per yoctosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerRontosecond = new (
                                                                   "rontometer per rontosecond"
                                                                 , "rm/rs"
                                                                 , YoctometerPerYoctosecond
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// quectometer per yoctosecond, defined as: rontometer per zeptosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerYoctosecond = new (
                                                                    "quectometer per yoctosecond"
                                                                  , "qm/ys"
                                                                  , RontometerPerZeptosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// ronnameter per second, defined as: yottameter per second × (1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity RonnameterPerSecond =
            new ("ronnameter per second", "Rm/s", YottameterPerSecond, 1000.0 / 1.0);

   /// <summary>
   /// yottameter per decisecond, defined as: zettameter per second × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity YottameterPerDecisecond =
            new ("yottameter per decisecond", "Ym/ds", ZettameterPerSecond, 1000.0 / (1.0 / 10.0));

   /// <summary>
   /// zettameter per centisecond, defined as: exameter per decisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ZettameterPerCentisecond = new (
                                                                   "zettameter per centisecond"
                                                                 , "Zm/cs"
                                                                 , ExameterPerDecisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// exameter per millisecond, defined as: petameter per centisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ExameterPerMillisecond = new (
                                                                 "exameter per millisecond"
                                                               , "Em/ms"
                                                               , PetameterPerCentisecond
                                                               , 1000.0 / (1.0 / 10.0)
                                                                );

   /// <summary>
   /// petameter per microsecond, defined as: terameter per millisecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerMicrosecond = new (
                                                                  "petameter per microsecond"
                                                                , "Pm/μs"
                                                                , TerameterPerMillisecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// terameter per nanosecond, defined as: gigameter per microsecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerNanosecond = new (
                                                                 "terameter per nanosecond"
                                                               , "Tm/ns"
                                                               , GigameterPerMicrosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// gigameter per picosecond, defined as: megameter per nanosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerPicosecond = new (
                                                                 "gigameter per picosecond"
                                                               , "Gm/ps"
                                                               , MegameterPerNanosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// megameter per femtosecond, defined as: kilometer per picosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerFemtosecond = new (
                                                                  "megameter per femtosecond"
                                                                , "Mm/fs"
                                                                , KilometerPerPicosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// kilometer per attosecond, defined as: hectometer per femtosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerAttosecond = new (
                                                                 "kilometer per attosecond"
                                                               , "km/as"
                                                               , HectometerPerFemtosecond
                                                               , 10.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// hectometer per zeptosecond, defined as: dekameter per attosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerZeptosecond = new (
                                                                   "hectometer per zeptosecond"
                                                                 , "hm/zs"
                                                                 , DekameterPerAttosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// dekameter per yoctosecond, defined as: meter per zeptosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerYoctosecond = new (
                                                                  "dekameter per yoctosecond"
                                                                , "dam/ys"
                                                                , MeterPerZeptosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// rontometer per quectosecond, defined as: yoctometer per rontosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerQuectosecond = new (
                                                                    "rontometer per quectosecond"
                                                                  , "rm/qs"
                                                                  , YoctometerPerRontosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// quectometer per rontosecond, defined as: rontometer per yoctosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerRontosecond = new (
                                                                    "quectometer per rontosecond"
                                                                  , "qm/rs"
                                                                  , RontometerPerYoctosecond
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// quettameter per second, defined as: ronnameter per second × (1000.0)/(1.0)
   /// </summary>
   public static readonly Velocity QuettameterPerSecond =
            new ("quettameter per second", "Qm/s", RonnameterPerSecond, 1000.0 / 1.0);

   /// <summary>
   /// ronnameter per decisecond, defined as: yottameter per second × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity RonnameterPerDecisecond =
            new ("ronnameter per decisecond", "Rm/ds", YottameterPerSecond, 1000.0 / (1.0 / 10.0));

   /// <summary>
   /// yottameter per centisecond, defined as: zettameter per decisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity YottameterPerCentisecond = new (
                                                                   "yottameter per centisecond"
                                                                 , "Ym/cs"
                                                                 , ZettameterPerDecisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// zettameter per millisecond, defined as: exameter per centisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity ZettameterPerMillisecond = new (
                                                                   "zettameter per millisecond"
                                                                 , "Zm/ms"
                                                                 , ExameterPerCentisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// exameter per microsecond, defined as: petameter per millisecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerMicrosecond = new (
                                                                 "exameter per microsecond"
                                                               , "Em/μs"
                                                               , PetameterPerMillisecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// petameter per nanosecond, defined as: terameter per microsecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerNanosecond = new (
                                                                 "petameter per nanosecond"
                                                               , "Pm/ns"
                                                               , TerameterPerMicrosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// terameter per picosecond, defined as: gigameter per nanosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerPicosecond = new (
                                                                 "terameter per picosecond"
                                                               , "Tm/ps"
                                                               , GigameterPerNanosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// gigameter per femtosecond, defined as: megameter per picosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerFemtosecond = new (
                                                                  "gigameter per femtosecond"
                                                                , "Gm/fs"
                                                                , MegameterPerPicosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// megameter per attosecond, defined as: kilometer per femtosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerAttosecond = new (
                                                                 "megameter per attosecond"
                                                               , "Mm/as"
                                                               , KilometerPerFemtosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// kilometer per zeptosecond, defined as: hectometer per attosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerZeptosecond = new (
                                                                  "kilometer per zeptosecond"
                                                                , "km/zs"
                                                                , HectometerPerAttosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// hectometer per yoctosecond, defined as: dekameter per zeptosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerYoctosecond = new (
                                                                   "hectometer per yoctosecond"
                                                                 , "hm/ys"
                                                                 , DekameterPerZeptosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// dekameter per rontosecond, defined as: meter per yoctosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerRontosecond = new (
                                                                  "dekameter per rontosecond"
                                                                , "dam/rs"
                                                                , MeterPerYoctosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// quectometer per quectosecond, defined as: rontometer per rontosecond × (1.0/1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerQuectosecond = new (
                                                                     "quectometer per quectosecond"
                                                                   , "qm/qs"
                                                                   , RontometerPerRontosecond
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0)
                                                                    );

   /// <summary>
   /// quettameter per decisecond, defined as: ronnameter per second × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity QuettameterPerDecisecond =
            new ("quettameter per decisecond", "Qm/ds", RonnameterPerSecond, 1000.0 / (1.0 / 10.0));

   /// <summary>
   /// ronnameter per centisecond, defined as: yottameter per decisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity RonnameterPerCentisecond = new (
                                                                   "ronnameter per centisecond"
                                                                 , "Rm/cs"
                                                                 , YottameterPerDecisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// yottameter per millisecond, defined as: zettameter per centisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity YottameterPerMillisecond = new (
                                                                   "yottameter per millisecond"
                                                                 , "Ym/ms"
                                                                 , ZettameterPerCentisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// zettameter per microsecond, defined as: exameter per millisecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerMicrosecond = new (
                                                                   "zettameter per microsecond"
                                                                 , "Zm/μs"
                                                                 , ExameterPerMillisecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// exameter per nanosecond, defined as: petameter per microsecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerNanosecond = new (
                                                                "exameter per nanosecond"
                                                              , "Em/ns"
                                                              , PetameterPerMicrosecond
                                                              , 1000.0 / (1.0 / 1000.0)
                                                               );

   /// <summary>
   /// petameter per picosecond, defined as: terameter per nanosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerPicosecond = new (
                                                                 "petameter per picosecond"
                                                               , "Pm/ps"
                                                               , TerameterPerNanosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// terameter per femtosecond, defined as: gigameter per picosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerFemtosecond = new (
                                                                  "terameter per femtosecond"
                                                                , "Tm/fs"
                                                                , GigameterPerPicosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// gigameter per attosecond, defined as: megameter per femtosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerAttosecond = new (
                                                                 "gigameter per attosecond"
                                                               , "Gm/as"
                                                               , MegameterPerFemtosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// megameter per zeptosecond, defined as: kilometer per attosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerZeptosecond = new (
                                                                  "megameter per zeptosecond"
                                                                , "Mm/zs"
                                                                , KilometerPerAttosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// kilometer per yoctosecond, defined as: hectometer per zeptosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerYoctosecond = new (
                                                                  "kilometer per yoctosecond"
                                                                , "km/ys"
                                                                , HectometerPerZeptosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// hectometer per rontosecond, defined as: dekameter per yoctosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerRontosecond = new (
                                                                   "hectometer per rontosecond"
                                                                 , "hm/rs"
                                                                 , DekameterPerYoctosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// dekameter per quectosecond, defined as: meter per rontosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerQuectosecond = new (
                                                                   "dekameter per quectosecond"
                                                                 , "dam/qs"
                                                                 , MeterPerRontosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// quettameter per centisecond, defined as: ronnameter per decisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity QuettameterPerCentisecond = new (
                                                                    "quettameter per centisecond"
                                                                  , "Qm/cs"
                                                                  , RonnameterPerDecisecond
                                                                  , 1000.0 / (1.0 / 10.0)
                                                                   );

   /// <summary>
   /// ronnameter per millisecond, defined as: yottameter per centisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity RonnameterPerMillisecond = new (
                                                                   "ronnameter per millisecond"
                                                                 , "Rm/ms"
                                                                 , YottameterPerCentisecond
                                                                 , 1000.0 / (1.0 / 10.0)
                                                                  );

   /// <summary>
   /// yottameter per microsecond, defined as: zettameter per millisecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerMicrosecond = new (
                                                                   "yottameter per microsecond"
                                                                 , "Ym/μs"
                                                                 , ZettameterPerMillisecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// zettameter per nanosecond, defined as: exameter per microsecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerNanosecond = new (
                                                                  "zettameter per nanosecond"
                                                                , "Zm/ns"
                                                                , ExameterPerMicrosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// exameter per picosecond, defined as: petameter per nanosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerPicosecond = new (
                                                                "exameter per picosecond"
                                                              , "Em/ps"
                                                              , PetameterPerNanosecond
                                                              , 1000.0 / (1.0 / 1000.0)
                                                               );

   /// <summary>
   /// petameter per femtosecond, defined as: terameter per picosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerFemtosecond = new (
                                                                  "petameter per femtosecond"
                                                                , "Pm/fs"
                                                                , TerameterPerPicosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// terameter per attosecond, defined as: gigameter per femtosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerAttosecond = new (
                                                                 "terameter per attosecond"
                                                               , "Tm/as"
                                                               , GigameterPerFemtosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// gigameter per zeptosecond, defined as: megameter per attosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerZeptosecond = new (
                                                                  "gigameter per zeptosecond"
                                                                , "Gm/zs"
                                                                , MegameterPerAttosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// megameter per yoctosecond, defined as: kilometer per zeptosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerYoctosecond = new (
                                                                  "megameter per yoctosecond"
                                                                , "Mm/ys"
                                                                , KilometerPerZeptosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// kilometer per rontosecond, defined as: hectometer per yoctosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerRontosecond = new (
                                                                  "kilometer per rontosecond"
                                                                , "km/rs"
                                                                , HectometerPerYoctosecond
                                                                , 10.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// hectometer per quectosecond, defined as: dekameter per rontosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerQuectosecond = new (
                                                                    "hectometer per quectosecond"
                                                                  , "hm/qs"
                                                                  , DekameterPerRontosecond
                                                                  , 10.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// quettameter per millisecond, defined as: ronnameter per centisecond × (1000.0)/(1.0/10.0)
   /// </summary>
   public static readonly Velocity QuettameterPerMillisecond = new (
                                                                    "quettameter per millisecond"
                                                                  , "Qm/ms"
                                                                  , RonnameterPerCentisecond
                                                                  , 1000.0 / (1.0 / 10.0)
                                                                   );

   /// <summary>
   /// ronnameter per microsecond, defined as: yottameter per millisecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerMicrosecond = new (
                                                                   "ronnameter per microsecond"
                                                                 , "Rm/μs"
                                                                 , YottameterPerMillisecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// yottameter per nanosecond, defined as: zettameter per microsecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerNanosecond = new (
                                                                  "yottameter per nanosecond"
                                                                , "Ym/ns"
                                                                , ZettameterPerMicrosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// zettameter per picosecond, defined as: exameter per nanosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerPicosecond = new (
                                                                  "zettameter per picosecond"
                                                                , "Zm/ps"
                                                                , ExameterPerNanosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// exameter per femtosecond, defined as: petameter per picosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerFemtosecond = new (
                                                                 "exameter per femtosecond"
                                                               , "Em/fs"
                                                               , PetameterPerPicosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// petameter per attosecond, defined as: terameter per femtosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerAttosecond = new (
                                                                 "petameter per attosecond"
                                                               , "Pm/as"
                                                               , TerameterPerFemtosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// terameter per zeptosecond, defined as: gigameter per attosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerZeptosecond = new (
                                                                  "terameter per zeptosecond"
                                                                , "Tm/zs"
                                                                , GigameterPerAttosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// gigameter per yoctosecond, defined as: megameter per zeptosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerYoctosecond = new (
                                                                  "gigameter per yoctosecond"
                                                                , "Gm/ys"
                                                                , MegameterPerZeptosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// megameter per rontosecond, defined as: kilometer per yoctosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerRontosecond = new (
                                                                  "megameter per rontosecond"
                                                                , "Mm/rs"
                                                                , KilometerPerYoctosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// kilometer per quectosecond, defined as: hectometer per rontosecond × (10.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerQuectosecond = new (
                                                                   "kilometer per quectosecond"
                                                                 , "km/qs"
                                                                 , HectometerPerRontosecond
                                                                 , 10.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// quettameter per microsecond, defined as: ronnameter per millisecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerMicrosecond = new (
                                                                    "quettameter per microsecond"
                                                                  , "Qm/μs"
                                                                  , RonnameterPerMillisecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// ronnameter per nanosecond, defined as: yottameter per microsecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerNanosecond = new (
                                                                  "ronnameter per nanosecond"
                                                                , "Rm/ns"
                                                                , YottameterPerMicrosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// yottameter per picosecond, defined as: zettameter per nanosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerPicosecond = new (
                                                                  "yottameter per picosecond"
                                                                , "Ym/ps"
                                                                , ZettameterPerNanosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// zettameter per femtosecond, defined as: exameter per picosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerFemtosecond = new (
                                                                   "zettameter per femtosecond"
                                                                 , "Zm/fs"
                                                                 , ExameterPerPicosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// exameter per attosecond, defined as: petameter per femtosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerAttosecond = new (
                                                                "exameter per attosecond"
                                                              , "Em/as"
                                                              , PetameterPerFemtosecond
                                                              , 1000.0 / (1.0 / 1000.0)
                                                               );

   /// <summary>
   /// petameter per zeptosecond, defined as: terameter per attosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerZeptosecond = new (
                                                                  "petameter per zeptosecond"
                                                                , "Pm/zs"
                                                                , TerameterPerAttosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// terameter per yoctosecond, defined as: gigameter per zeptosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerYoctosecond = new (
                                                                  "terameter per yoctosecond"
                                                                , "Tm/ys"
                                                                , GigameterPerZeptosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// gigameter per rontosecond, defined as: megameter per yoctosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerRontosecond = new (
                                                                  "gigameter per rontosecond"
                                                                , "Gm/rs"
                                                                , MegameterPerYoctosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// megameter per quectosecond, defined as: kilometer per rontosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerQuectosecond = new (
                                                                   "megameter per quectosecond"
                                                                 , "Mm/qs"
                                                                 , KilometerPerRontosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// quettameter per nanosecond, defined as: ronnameter per microsecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerNanosecond = new (
                                                                   "quettameter per nanosecond"
                                                                 , "Qm/ns"
                                                                 , RonnameterPerMicrosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// ronnameter per picosecond, defined as: yottameter per nanosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerPicosecond = new (
                                                                  "ronnameter per picosecond"
                                                                , "Rm/ps"
                                                                , YottameterPerNanosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// yottameter per femtosecond, defined as: zettameter per picosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerFemtosecond = new (
                                                                   "yottameter per femtosecond"
                                                                 , "Ym/fs"
                                                                 , ZettameterPerPicosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// zettameter per attosecond, defined as: exameter per femtosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerAttosecond = new (
                                                                  "zettameter per attosecond"
                                                                , "Zm/as"
                                                                , ExameterPerFemtosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// exameter per zeptosecond, defined as: petameter per attosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerZeptosecond = new (
                                                                 "exameter per zeptosecond"
                                                               , "Em/zs"
                                                               , PetameterPerAttosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// petameter per yoctosecond, defined as: terameter per zeptosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerYoctosecond = new (
                                                                  "petameter per yoctosecond"
                                                                , "Pm/ys"
                                                                , TerameterPerZeptosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// terameter per rontosecond, defined as: gigameter per yoctosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerRontosecond = new (
                                                                  "terameter per rontosecond"
                                                                , "Tm/rs"
                                                                , GigameterPerYoctosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// gigameter per quectosecond, defined as: megameter per rontosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerQuectosecond = new (
                                                                   "gigameter per quectosecond"
                                                                 , "Gm/qs"
                                                                 , MegameterPerRontosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// quettameter per picosecond, defined as: ronnameter per nanosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerPicosecond = new (
                                                                   "quettameter per picosecond"
                                                                 , "Qm/ps"
                                                                 , RonnameterPerNanosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// ronnameter per femtosecond, defined as: yottameter per picosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerFemtosecond = new (
                                                                   "ronnameter per femtosecond"
                                                                 , "Rm/fs"
                                                                 , YottameterPerPicosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// yottameter per attosecond, defined as: zettameter per femtosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerAttosecond = new (
                                                                  "yottameter per attosecond"
                                                                , "Ym/as"
                                                                , ZettameterPerFemtosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// zettameter per zeptosecond, defined as: exameter per attosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerZeptosecond = new (
                                                                   "zettameter per zeptosecond"
                                                                 , "Zm/zs"
                                                                 , ExameterPerAttosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// exameter per yoctosecond, defined as: petameter per zeptosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerYoctosecond = new (
                                                                 "exameter per yoctosecond"
                                                               , "Em/ys"
                                                               , PetameterPerZeptosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// petameter per rontosecond, defined as: terameter per yoctosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerRontosecond = new (
                                                                  "petameter per rontosecond"
                                                                , "Pm/rs"
                                                                , TerameterPerYoctosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// terameter per quectosecond, defined as: gigameter per rontosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerQuectosecond = new (
                                                                   "terameter per quectosecond"
                                                                 , "Tm/qs"
                                                                 , GigameterPerRontosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// quettameter per femtosecond, defined as: ronnameter per picosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerFemtosecond = new (
                                                                    "quettameter per femtosecond"
                                                                  , "Qm/fs"
                                                                  , RonnameterPerPicosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// ronnameter per attosecond, defined as: yottameter per femtosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerAttosecond = new (
                                                                  "ronnameter per attosecond"
                                                                , "Rm/as"
                                                                , YottameterPerFemtosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// yottameter per zeptosecond, defined as: zettameter per attosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerZeptosecond = new (
                                                                   "yottameter per zeptosecond"
                                                                 , "Ym/zs"
                                                                 , ZettameterPerAttosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// zettameter per yoctosecond, defined as: exameter per zeptosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerYoctosecond = new (
                                                                   "zettameter per yoctosecond"
                                                                 , "Zm/ys"
                                                                 , ExameterPerZeptosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// exameter per rontosecond, defined as: petameter per yoctosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerRontosecond = new (
                                                                 "exameter per rontosecond"
                                                               , "Em/rs"
                                                               , PetameterPerYoctosecond
                                                               , 1000.0 / (1.0 / 1000.0)
                                                                );

   /// <summary>
   /// petameter per quectosecond, defined as: terameter per rontosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerQuectosecond = new (
                                                                   "petameter per quectosecond"
                                                                 , "Pm/qs"
                                                                 , TerameterPerRontosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// quettameter per attosecond, defined as: ronnameter per femtosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerAttosecond = new (
                                                                   "quettameter per attosecond"
                                                                 , "Qm/as"
                                                                 , RonnameterPerFemtosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// ronnameter per zeptosecond, defined as: yottameter per attosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerZeptosecond = new (
                                                                   "ronnameter per zeptosecond"
                                                                 , "Rm/zs"
                                                                 , YottameterPerAttosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// yottameter per yoctosecond, defined as: zettameter per zeptosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerYoctosecond = new (
                                                                   "yottameter per yoctosecond"
                                                                 , "Ym/ys"
                                                                 , ZettameterPerZeptosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// zettameter per rontosecond, defined as: exameter per yoctosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerRontosecond = new (
                                                                   "zettameter per rontosecond"
                                                                 , "Zm/rs"
                                                                 , ExameterPerYoctosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// exameter per quectosecond, defined as: petameter per rontosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerQuectosecond = new (
                                                                  "exameter per quectosecond"
                                                                , "Em/qs"
                                                                , PetameterPerRontosecond
                                                                , 1000.0 / (1.0 / 1000.0)
                                                                 );

   /// <summary>
   /// quettameter per zeptosecond, defined as: ronnameter per attosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerZeptosecond = new (
                                                                    "quettameter per zeptosecond"
                                                                  , "Qm/zs"
                                                                  , RonnameterPerAttosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// ronnameter per yoctosecond, defined as: yottameter per zeptosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerYoctosecond = new (
                                                                   "ronnameter per yoctosecond"
                                                                 , "Rm/ys"
                                                                 , YottameterPerZeptosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// yottameter per rontosecond, defined as: zettameter per yoctosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerRontosecond = new (
                                                                   "yottameter per rontosecond"
                                                                 , "Ym/rs"
                                                                 , ZettameterPerYoctosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// zettameter per quectosecond, defined as: exameter per rontosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerQuectosecond = new (
                                                                    "zettameter per quectosecond"
                                                                  , "Zm/qs"
                                                                  , ExameterPerRontosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// quettameter per yoctosecond, defined as: ronnameter per zeptosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerYoctosecond = new (
                                                                    "quettameter per yoctosecond"
                                                                  , "Qm/ys"
                                                                  , RonnameterPerZeptosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// ronnameter per rontosecond, defined as: yottameter per yoctosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerRontosecond = new (
                                                                   "ronnameter per rontosecond"
                                                                 , "Rm/rs"
                                                                 , YottameterPerYoctosecond
                                                                 , 1000.0 / (1.0 / 1000.0)
                                                                  );

   /// <summary>
   /// yottameter per quectosecond, defined as: zettameter per rontosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerQuectosecond = new (
                                                                    "yottameter per quectosecond"
                                                                  , "Ym/qs"
                                                                  , ZettameterPerRontosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// quettameter per rontosecond, defined as: ronnameter per yoctosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerRontosecond = new (
                                                                    "quettameter per rontosecond"
                                                                  , "Qm/rs"
                                                                  , RonnameterPerYoctosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// ronnameter per quectosecond, defined as: yottameter per rontosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerQuectosecond = new (
                                                                    "ronnameter per quectosecond"
                                                                  , "Rm/qs"
                                                                  , YottameterPerRontosecond
                                                                  , 1000.0 / (1.0 / 1000.0)
                                                                   );

   /// <summary>
   /// quettameter per quectosecond, defined as: ronnameter per rontosecond × (1000.0)/(1.0/1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerQuectosecond = new (
                                                                     "quettameter per quectosecond"
                                                                   , "Qm/qs"
                                                                   , RonnameterPerRontosecond
                                                                   , 1000.0 / (1.0 / 1000.0)
                                                                    );

   /// <summary>
   /// meter per minute, defined as: meter per second × (1.0)/(60.0)
   /// </summary>
   public static readonly Velocity MeterPerMinute = new ("meter per minute", "m/min", MeterPerSecond, 1.0 / 60.0);

   /// <summary>
   /// meter per hour, defined as: meter per minute × (1.0)/(60.0)
   /// </summary>
   public static readonly Velocity MeterPerHour = new ("meter per hour", "m/hr", MeterPerMinute, 1.0 / 60.0);

   /// <summary>
   /// decimeter per minute, defined as: meter per second × (1.0/10.0)/(60.0)
   /// </summary>
   public static readonly Velocity DecimeterPerMinute = new (
                                                             "decimeter per minute"
                                                           , "dm/min"
                                                           , MeterPerSecond
                                                           , 1.0 / 10.0 / 60.0
                                                            );

   /// <summary>
   /// meter per day, defined as: meter per hour × (1.0)/(24.0)
   /// </summary>
   public static readonly Velocity MeterPerDay = new ("meter per day", "m/dy", MeterPerHour, 1.0 / 24.0);

   /// <summary>
   /// centimeter per minute, defined as: decimeter per second × (1.0/10.0)/(60.0)
   /// </summary>
   public static readonly Velocity CentimeterPerMinute =
            new ("centimeter per minute", "cm/min", DecimeterPerSecond, 1.0 / 10.0 / 60.0);

   /// <summary>
   /// meter per week, defined as: meter per day × (1.0)/(7.0)
   /// </summary>
   public static readonly Velocity MeterPerWeek = new ("meter per week", "m/wk", MeterPerDay, 1.0 / 7.0);

   /// <summary>
   /// decimeter per hour, defined as: meter per minute × (1.0/10.0)/(60.0)
   /// </summary>
   public static readonly Velocity DecimeterPerHour = new (
                                                           "decimeter per hour"
                                                         , "dm/hr"
                                                         , MeterPerMinute
                                                         , 1.0 / 10.0 / 60.0
                                                          );

   /// <summary>
   /// millimeter per minute, defined as: centimeter per second × (1.0/10.0)/(60.0)
   /// </summary>
   public static readonly Velocity MillimeterPerMinute =
            new ("millimeter per minute", "mm/min", CentimeterPerSecond, 1.0 / 10.0 / 60.0);

   /// <summary>
   /// meter per year, defined as: meter per day × (1.0)/(365.2525)
   /// </summary>
   public static readonly Velocity MeterPerYear = new ("meter per year", "m/yr", MeterPerDay, 1.0 / 365.2525);

   /// <summary>
   /// micrometer per minute, defined as: millimeter per second × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity MicrometerPerMinute =
            new ("micrometer per minute", "μm/min", MillimeterPerSecond, 1.0 / 1000.0 / 60.0);

   /// <summary>
   /// meter per decade, defined as: meter per year × (1.0)/(10.0)
   /// </summary>
   public static readonly Velocity MeterPerDecade = new ("meter per decade", "m/decade", MeterPerYear, 1.0 / 10.0);

   /// <summary>
   /// decimeter per day, defined as: meter per hour × (1.0/10.0)/(24.0)
   /// </summary>
   public static readonly Velocity DecimeterPerDay = new (
                                                          "decimeter per day"
                                                        , "dm/dy"
                                                        , MeterPerHour
                                                        , 1.0 / 10.0 / 24.0
                                                         );

   /// <summary>
   /// centimeter per hour, defined as: decimeter per minute × (1.0/10.0)/(60.0)
   /// </summary>
   public static readonly Velocity CentimeterPerHour = new (
                                                            "centimeter per hour"
                                                          , "cm/hr"
                                                          , DecimeterPerMinute
                                                          , 1.0 / 10.0 / 60.0
                                                           );

   /// <summary>
   /// nanometer per minute, defined as: micrometer per second × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity NanometerPerMinute = new (
                                                             "nanometer per minute"
                                                           , "nm/min"
                                                           , MicrometerPerSecond
                                                           , 1.0 / 1000.0 / 60.0
                                                            );

   /// <summary>
   /// meter per century, defined as: meter per decade × (1.0)/(10.0)
   /// </summary>
   public static readonly Velocity MeterPerCentury = new ("meter per century", "m/century", MeterPerDecade, 1.0 / 10.0);

   /// <summary>
   /// picometer per minute, defined as: nanometer per second × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity PicometerPerMinute = new (
                                                             "picometer per minute"
                                                           , "pm/min"
                                                           , NanometerPerSecond
                                                           , 1.0 / 1000.0 / 60.0
                                                            );

   /// <summary>
   /// meter per millennium, defined as: meter per century × (1.0)/(10.0)
   /// </summary>
   public static readonly Velocity MeterPerMillennium = new (
                                                             "meter per millennium"
                                                           , "m/kyr"
                                                           , MeterPerCentury
                                                           , 1.0 / 10.0
                                                            );

   /// <summary>
   /// decimeter per week, defined as: meter per day × (1.0/10.0)/(7.0)
   /// </summary>
   public static readonly Velocity DecimeterPerWeek = new (
                                                           "decimeter per week"
                                                         , "dm/wk"
                                                         , MeterPerDay
                                                         , 1.0 / 10.0 / 7.0
                                                          );

   /// <summary>
   /// millimeter per hour, defined as: centimeter per minute × (1.0/10.0)/(60.0)
   /// </summary>
   public static readonly Velocity MillimeterPerHour = new (
                                                            "millimeter per hour"
                                                          , "mm/hr"
                                                          , CentimeterPerMinute
                                                          , 1.0 / 10.0 / 60.0
                                                           );

   /// <summary>
   /// femtometer per minute, defined as: picometer per second × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity FemtometerPerMinute =
            new ("femtometer per minute", "fm/min", PicometerPerSecond, 1.0 / 1000.0 / 60.0);

   /// <summary>
   /// meter per million years, defined as: meter per millennium × (1.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MeterPerMillionYears =
            new ("meter per million years", "m/Myr", MeterPerMillennium, 1.0 / 1000.0);

   /// <summary>
   /// centimeter per day, defined as: decimeter per hour × (1.0/10.0)/(24.0)
   /// </summary>
   public static readonly Velocity CentimeterPerDay = new (
                                                           "centimeter per day"
                                                         , "cm/dy"
                                                         , DecimeterPerHour
                                                         , 1.0 / 10.0 / 24.0
                                                          );

   /// <summary>
   /// attometer per minute, defined as: femtometer per second × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity AttometerPerMinute = new (
                                                             "attometer per minute"
                                                           , "am/min"
                                                           , FemtometerPerSecond
                                                           , 1.0 / 1000.0 / 60.0
                                                            );

   /// <summary>
   /// meter per billion years, defined as: meter per million years × (1.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MeterPerBillionYears =
            new ("meter per billion years", "m/Gyr", MeterPerMillionYears, 1.0 / 1000.0);

   /// <summary>
   /// decimeter per year, defined as: meter per day × (1.0/10.0)/(365.2525)
   /// </summary>
   public static readonly Velocity DecimeterPerYear = new (
                                                           "decimeter per year"
                                                         , "dm/yr"
                                                         , MeterPerDay
                                                         , 1.0 / 10.0 / 365.2525
                                                          );

   /// <summary>
   /// micrometer per hour, defined as: millimeter per minute × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity MicrometerPerHour = new (
                                                            "micrometer per hour"
                                                          , "μm/hr"
                                                          , MillimeterPerMinute
                                                          , 1.0 / 1000.0 / 60.0
                                                           );

   /// <summary>
   /// zeptometer per minute, defined as: attometer per second × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerMinute =
            new ("zeptometer per minute", "zm/min", AttometerPerSecond, 1.0 / 1000.0 / 60.0);

   /// <summary>
   /// meter per trillion years, defined as: meter per billion years × (1.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MeterPerTrillionYears =
            new ("meter per trillion years", "m/Tyr", MeterPerBillionYears, 1.0 / 1000.0);

   /// <summary>
   /// yoctometer per minute, defined as: zeptometer per second × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity YoctometerPerMinute =
            new ("yoctometer per minute", "ym/min", ZeptometerPerSecond, 1.0 / 1000.0 / 60.0);

   /// <summary>
   /// meter per quadrillion years, defined as: meter per trillion years × (1.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MeterPerQuadrillionYears =
            new ("meter per quadrillion years", "m/Pyr", MeterPerTrillionYears, 1.0 / 1000.0);

   /// <summary>
   /// decimeter per decade, defined as: meter per year × (1.0/10.0)/(10.0)
   /// </summary>
   public static readonly Velocity DecimeterPerDecade = new (
                                                             "decimeter per decade"
                                                           , "dm/decade"
                                                           , MeterPerYear
                                                           , 1.0 / 10.0 / 10.0
                                                            );

   /// <summary>
   /// centimeter per week, defined as: decimeter per day × (1.0/10.0)/(7.0)
   /// </summary>
   public static readonly Velocity CentimeterPerWeek = new (
                                                            "centimeter per week"
                                                          , "cm/wk"
                                                          , DecimeterPerDay
                                                          , 1.0 / 10.0 / 7.0
                                                           );

   /// <summary>
   /// millimeter per day, defined as: centimeter per hour × (1.0/10.0)/(24.0)
   /// </summary>
   public static readonly Velocity MillimeterPerDay = new (
                                                           "millimeter per day"
                                                         , "mm/dy"
                                                         , CentimeterPerHour
                                                         , 1.0 / 10.0 / 24.0
                                                          );

   /// <summary>
   /// nanometer per hour, defined as: micrometer per minute × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity NanometerPerHour = new (
                                                           "nanometer per hour"
                                                         , "nm/hr"
                                                         , MicrometerPerMinute
                                                         , 1.0 / 1000.0 / 60.0
                                                          );

   /// <summary>
   /// rontometer per minute, defined as: yoctometer per second × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity RontometerPerMinute =
            new ("rontometer per minute", "rm/min", YoctometerPerSecond, 1.0 / 1000.0 / 60.0);

   /// <summary>
   /// meter per quintillion years, defined as: meter per quadrillion years × (1.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MeterPerQuintillionYears =
            new ("meter per quintillion years", "m/Eyr", MeterPerQuadrillionYears, 1.0 / 1000.0);

   /// <summary>
   /// quectometer per minute, defined as: rontometer per second × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity QuectometerPerMinute =
            new ("quectometer per minute", "qm/min", RontometerPerSecond, 1.0 / 1000.0 / 60.0);

   /// <summary>
   /// meter per sextillion years, defined as: meter per quintillion years × (1.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MeterPerSextillionYears =
            new ("meter per sextillion years", "m/Zyr", MeterPerQuintillionYears, 1.0 / 1000.0);

   /// <summary>
   /// decimeter per century, defined as: meter per decade × (1.0/10.0)/(10.0)
   /// </summary>
   public static readonly Velocity DecimeterPerCentury =
            new ("decimeter per century", "dm/century", MeterPerDecade, 1.0 / 10.0 / 10.0);

   /// <summary>
   /// picometer per hour, defined as: nanometer per minute × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity PicometerPerHour = new (
                                                           "picometer per hour"
                                                         , "pm/hr"
                                                         , NanometerPerMinute
                                                         , 1.0 / 1000.0 / 60.0
                                                          );

   /// <summary>
   /// dekameter per minute, defined as: meter per second × (10.0)/(60.0)
   /// </summary>
   public static readonly Velocity DekameterPerMinute = new (
                                                             "dekameter per minute"
                                                           , "dam/min"
                                                           , MeterPerSecond
                                                           , 10.0 / 60.0
                                                            );

   /// <summary>
   /// meter per septillion years, defined as: meter per sextillion years × (1.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MeterPerSeptillionYears =
            new ("meter per septillion years", "m/Yyr", MeterPerSextillionYears, 1.0 / 1000.0);

   /// <summary>
   /// centimeter per year, defined as: decimeter per day × (1.0/10.0)/(365.2525)
   /// </summary>
   public static readonly Velocity CentimeterPerYear = new (
                                                            "centimeter per year"
                                                          , "cm/yr"
                                                          , DecimeterPerDay
                                                          , 1.0 / 10.0 / 365.2525
                                                           );

   /// <summary>
   /// micrometer per day, defined as: millimeter per hour × (1.0/1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity MicrometerPerDay = new (
                                                           "micrometer per day"
                                                         , "μm/dy"
                                                         , MillimeterPerHour
                                                         , 1.0 / 1000.0 / 24.0
                                                          );

   /// <summary>
   /// hectometer per minute, defined as: dekameter per second × (10.0)/(60.0)
   /// </summary>
   public static readonly Velocity HectometerPerMinute =
            new ("hectometer per minute", "hm/min", DekameterPerSecond, 10.0 / 60.0);

   /// <summary>
   /// meter per octillion years, defined as: meter per septillion years × (1.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MeterPerOctillionYears =
            new ("meter per octillion years", "m/Ryr", MeterPerSeptillionYears, 1.0 / 1000.0);

   /// <summary>
   /// decimeter per millennium, defined as: meter per century × (1.0/10.0)/(10.0)
   /// </summary>
   public static readonly Velocity DecimeterPerMillennium =
            new ("decimeter per millennium", "dm/kyr", MeterPerCentury, 1.0 / 10.0 / 10.0);

   /// <summary>
   /// millimeter per week, defined as: centimeter per day × (1.0/10.0)/(7.0)
   /// </summary>
   public static readonly Velocity MillimeterPerWeek = new (
                                                            "millimeter per week"
                                                          , "mm/wk"
                                                          , CentimeterPerDay
                                                          , 1.0 / 10.0 / 7.0
                                                           );

   /// <summary>
   /// femtometer per hour, defined as: picometer per minute × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity FemtometerPerHour = new (
                                                            "femtometer per hour"
                                                          , "fm/hr"
                                                          , PicometerPerMinute
                                                          , 1.0 / 1000.0 / 60.0
                                                           );

   /// <summary>
   /// kilometer per minute, defined as: hectometer per second × (10.0)/(60.0)
   /// </summary>
   public static readonly Velocity KilometerPerMinute = new (
                                                             "kilometer per minute"
                                                           , "km/min"
                                                           , HectometerPerSecond
                                                           , 10.0 / 60.0
                                                            );

   /// <summary>
   /// meter per nonillion years, defined as: meter per octillion years × (1.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MeterPerNonillionYears =
            new ("meter per nonillion years", "m/Qyr", MeterPerOctillionYears, 1.0 / 1000.0);

   /// <summary>
   /// megameter per minute, defined as: kilometer per second × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity MegameterPerMinute = new (
                                                             "megameter per minute"
                                                           , "Mm/min"
                                                           , KilometerPerSecond
                                                           , 1000.0 / 60.0
                                                            );

   /// <summary>
   /// meter per decillion years, defined as: meter per nonillion years × (1.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MeterPerDecillionYears = new (
                                                                 "meter per decillion years"
                                                               , "m/decillion yr"
                                                               , MeterPerNonillionYears
                                                               , 1.0 / 1000.0
                                                                );

   /// <summary>
   /// decimeter per million years, defined as: meter per millennium × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerMillionYears =
            new ("decimeter per million years", "dm/Myr", MeterPerMillennium, 1.0 / 10.0 / 1000.0);

   /// <summary>
   /// centimeter per decade, defined as: decimeter per year × (1.0/10.0)/(10.0)
   /// </summary>
   public static readonly Velocity CentimeterPerDecade =
            new ("centimeter per decade", "cm/decade", DecimeterPerYear, 1.0 / 10.0 / 10.0);

   /// <summary>
   /// nanometer per day, defined as: micrometer per hour × (1.0/1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity NanometerPerDay = new (
                                                          "nanometer per day"
                                                        , "nm/dy"
                                                        , MicrometerPerHour
                                                        , 1.0 / 1000.0 / 24.0
                                                         );

   /// <summary>
   /// attometer per hour, defined as: femtometer per minute × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity AttometerPerHour = new (
                                                           "attometer per hour"
                                                         , "am/hr"
                                                         , FemtometerPerMinute
                                                         , 1.0 / 1000.0 / 60.0
                                                          );

   /// <summary>
   /// gigameter per minute, defined as: megameter per second × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity GigameterPerMinute = new (
                                                             "gigameter per minute"
                                                           , "Gm/min"
                                                           , MegameterPerSecond
                                                           , 1000.0 / 60.0
                                                            );

   /// <summary>
   /// terameter per minute, defined as: gigameter per second × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity TerameterPerMinute = new (
                                                             "terameter per minute"
                                                           , "Tm/min"
                                                           , GigameterPerSecond
                                                           , 1000.0 / 60.0
                                                            );

   /// <summary>
   /// meter per tick, defined as: meter per nanosecond × (1.0)/(100.0)
   /// </summary>
   public static readonly Velocity MeterPerTick = new ("meter per tick", "m/tick", MeterPerNanosecond, 1.0 / 100.0);

   /// <summary>
   /// decimeter per billion years, defined as: meter per million years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerBillionYears = new (
                                                                   "decimeter per billion years"
                                                                 , "dm/Gyr"
                                                                 , MeterPerMillionYears
                                                                 , 1.0 / 10.0 / 1000.0
                                                                  );

   /// <summary>
   /// millimeter per year, defined as: centimeter per day × (1.0/10.0)/(365.2525)
   /// </summary>
   public static readonly Velocity MillimeterPerYear = new (
                                                            "millimeter per year"
                                                          , "mm/yr"
                                                          , CentimeterPerDay
                                                          , 1.0 / 10.0 / 365.2525
                                                           );

   /// <summary>
   /// micrometer per week, defined as: millimeter per day × (1.0/1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity MicrometerPerWeek = new (
                                                            "micrometer per week"
                                                          , "μm/wk"
                                                          , MillimeterPerDay
                                                          , 1.0 / 1000.0 / 7.0
                                                           );

   /// <summary>
   /// zeptometer per hour, defined as: attometer per minute × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerHour = new (
                                                            "zeptometer per hour"
                                                          , "zm/hr"
                                                          , AttometerPerMinute
                                                          , 1.0 / 1000.0 / 60.0
                                                           );

   /// <summary>
   /// petameter per minute, defined as: terameter per second × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity PetameterPerMinute = new (
                                                             "petameter per minute"
                                                           , "Pm/min"
                                                           , TerameterPerSecond
                                                           , 1000.0 / 60.0
                                                            );

   /// <summary>
   /// centimeter per century, defined as: decimeter per decade × (1.0/10.0)/(10.0)
   /// </summary>
   public static readonly Velocity CentimeterPerCentury =
            new ("centimeter per century", "cm/century", DecimeterPerDecade, 1.0 / 10.0 / 10.0);

   /// <summary>
   /// picometer per day, defined as: nanometer per hour × (1.0/1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity PicometerPerDay = new (
                                                          "picometer per day"
                                                        , "pm/dy"
                                                        , NanometerPerHour
                                                        , 1.0 / 1000.0 / 24.0
                                                         );

   /// <summary>
   /// exameter per minute, defined as: petameter per second × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity ExameterPerMinute = new (
                                                            "exameter per minute"
                                                          , "Em/min"
                                                          , PetameterPerSecond
                                                          , 1000.0 / 60.0
                                                           );

   /// <summary>
   /// decimeter per trillion years, defined as: meter per billion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerTrillionYears = new (
                                                                    "decimeter per trillion years"
                                                                  , "dm/Tyr"
                                                                  , MeterPerBillionYears
                                                                  , 1.0 / 10.0 / 1000.0
                                                                   );

   /// <summary>
   /// yoctometer per hour, defined as: zeptometer per minute × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity YoctometerPerHour = new (
                                                            "yoctometer per hour"
                                                          , "ym/hr"
                                                          , ZeptometerPerMinute
                                                          , 1.0 / 1000.0 / 60.0
                                                           );

   /// <summary>
   /// zettameter per minute, defined as: exameter per second × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity ZettameterPerMinute =
            new ("zettameter per minute", "Zm/min", ExameterPerSecond, 1000.0 / 60.0);

   /// <summary>
   /// yottameter per minute, defined as: zettameter per second × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity YottameterPerMinute =
            new ("yottameter per minute", "Ym/min", ZettameterPerSecond, 1000.0 / 60.0);

   /// <summary>
   /// decimeter per quadrillion years, defined as: meter per trillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerQuadrillionYears = new (
                                                                       "decimeter per quadrillion years"
                                                                     , "dm/Pyr"
                                                                     , MeterPerTrillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                      );

   /// <summary>
   /// centimeter per millennium, defined as: decimeter per century × (1.0/10.0)/(10.0)
   /// </summary>
   public static readonly Velocity CentimeterPerMillennium =
            new ("centimeter per millennium", "cm/kyr", DecimeterPerCentury, 1.0 / 10.0 / 10.0);

   /// <summary>
   /// millimeter per decade, defined as: centimeter per year × (1.0/10.0)/(10.0)
   /// </summary>
   public static readonly Velocity MillimeterPerDecade =
            new ("millimeter per decade", "mm/decade", CentimeterPerYear, 1.0 / 10.0 / 10.0);

   /// <summary>
   /// nanometer per week, defined as: micrometer per day × (1.0/1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity NanometerPerWeek = new (
                                                           "nanometer per week"
                                                         , "nm/wk"
                                                         , MicrometerPerDay
                                                         , 1.0 / 1000.0 / 7.0
                                                          );

   /// <summary>
   /// femtometer per day, defined as: picometer per hour × (1.0/1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity FemtometerPerDay = new (
                                                           "femtometer per day"
                                                         , "fm/dy"
                                                         , PicometerPerHour
                                                         , 1.0 / 1000.0 / 24.0
                                                          );

   /// <summary>
   /// rontometer per hour, defined as: yoctometer per minute × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity RontometerPerHour = new (
                                                            "rontometer per hour"
                                                          , "rm/hr"
                                                          , YoctometerPerMinute
                                                          , 1.0 / 1000.0 / 60.0
                                                           );

   /// <summary>
   /// ronnameter per minute, defined as: yottameter per second × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity RonnameterPerMinute =
            new ("ronnameter per minute", "Rm/min", YottameterPerSecond, 1000.0 / 60.0);

   /// <summary>
   /// micrometer per year, defined as: millimeter per day × (1.0/1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity MicrometerPerYear = new (
                                                            "micrometer per year"
                                                          , "μm/yr"
                                                          , MillimeterPerDay
                                                          , 1.0 / 1000.0 / 365.2525
                                                           );

   /// <summary>
   /// quettameter per minute, defined as: ronnameter per second × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity QuettameterPerMinute =
            new ("quettameter per minute", "Qm/min", RonnameterPerSecond, 1000.0 / 60.0);

   /// <summary>
   /// decimeter per quintillion years, defined as: meter per quadrillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerQuintillionYears = new (
                                                                       "decimeter per quintillion years"
                                                                     , "dm/Eyr"
                                                                     , MeterPerQuadrillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                      );

   /// <summary>
   /// quectometer per hour, defined as: rontometer per minute × (1.0/1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity QuectometerPerHour = new (
                                                             "quectometer per hour"
                                                           , "qm/hr"
                                                           , RontometerPerMinute
                                                           , 1.0 / 1000.0 / 60.0
                                                            );

   /// <summary>
   /// centimeter per million years, defined as: decimeter per millennium × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerMillionYears = new (
                                                                    "centimeter per million years"
                                                                  , "cm/Myr"
                                                                  , DecimeterPerMillennium
                                                                  , 1.0 / 10.0 / 1000.0
                                                                   );

   /// <summary>
   /// attometer per day, defined as: femtometer per hour × (1.0/1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity AttometerPerDay = new (
                                                          "attometer per day"
                                                        , "am/dy"
                                                        , FemtometerPerHour
                                                        , 1.0 / 1000.0 / 24.0
                                                         );

   /// <summary>
   /// decimeter per sextillion years, defined as: meter per quintillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerSextillionYears = new (
                                                                      "decimeter per sextillion years"
                                                                    , "dm/Zyr"
                                                                    , MeterPerQuintillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// millimeter per century, defined as: centimeter per decade × (1.0/10.0)/(10.0)
   /// </summary>
   public static readonly Velocity MillimeterPerCentury =
            new ("millimeter per century", "mm/century", CentimeterPerDecade, 1.0 / 10.0 / 10.0);

   /// <summary>
   /// picometer per week, defined as: nanometer per day × (1.0/1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity PicometerPerWeek = new (
                                                           "picometer per week"
                                                         , "pm/wk"
                                                         , NanometerPerDay
                                                         , 1.0 / 1000.0 / 7.0
                                                          );

   /// <summary>
   /// dekameter per hour, defined as: meter per minute × (10.0)/(60.0)
   /// </summary>
   public static readonly Velocity DekameterPerHour = new ("dekameter per hour", "dam/hr", MeterPerMinute, 10.0 / 60.0);

   /// <summary>
   /// decimeter per septillion years, defined as: meter per sextillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerSeptillionYears = new (
                                                                      "decimeter per septillion years"
                                                                    , "dm/Yyr"
                                                                    , MeterPerSextillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// centimeter per billion years, defined as: decimeter per million years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerBillionYears = new (
                                                                    "centimeter per billion years"
                                                                  , "cm/Gyr"
                                                                  , DecimeterPerMillionYears
                                                                  , 1.0 / 10.0 / 1000.0
                                                                   );

   /// <summary>
   /// micrometer per decade, defined as: millimeter per year × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity MicrometerPerDecade =
            new ("micrometer per decade", "μm/decade", MillimeterPerYear, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// nanometer per year, defined as: micrometer per day × (1.0/1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity NanometerPerYear = new (
                                                           "nanometer per year"
                                                         , "nm/yr"
                                                         , MicrometerPerDay
                                                         , 1.0 / 1000.0 / 365.2525
                                                          );

   /// <summary>
   /// zeptometer per day, defined as: attometer per hour × (1.0/1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerDay = new (
                                                           "zeptometer per day"
                                                         , "zm/dy"
                                                         , AttometerPerHour
                                                         , 1.0 / 1000.0 / 24.0
                                                          );

   /// <summary>
   /// hectometer per hour, defined as: dekameter per minute × (10.0)/(60.0)
   /// </summary>
   public static readonly Velocity HectometerPerHour = new (
                                                            "hectometer per hour"
                                                          , "hm/hr"
                                                          , DekameterPerMinute
                                                          , 10.0 / 60.0
                                                           );

   /// <summary>
   /// decimeter per octillion years, defined as: meter per septillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerOctillionYears = new (
                                                                     "decimeter per octillion years"
                                                                   , "dm/Ryr"
                                                                   , MeterPerSeptillionYears
                                                                   , 1.0 / 10.0 / 1000.0
                                                                    );

   /// <summary>
   /// millimeter per millennium, defined as: centimeter per century × (1.0/10.0)/(10.0)
   /// </summary>
   public static readonly Velocity MillimeterPerMillennium =
            new ("millimeter per millennium", "mm/kyr", CentimeterPerCentury, 1.0 / 10.0 / 10.0);

   /// <summary>
   /// femtometer per week, defined as: picometer per day × (1.0/1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity FemtometerPerWeek = new (
                                                            "femtometer per week"
                                                          , "fm/wk"
                                                          , PicometerPerDay
                                                          , 1.0 / 1000.0 / 7.0
                                                           );

   /// <summary>
   /// kilometer per hour, defined as: hectometer per minute × (10.0)/(60.0)
   /// </summary>
   public static readonly Velocity KilometerPerHour = new (
                                                           "kilometer per hour"
                                                         , "km/hr"
                                                         , HectometerPerMinute
                                                         , 10.0 / 60.0
                                                          );

   /// <summary>
   /// centimeter per trillion years, defined as: decimeter per billion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerTrillionYears = new (
                                                                     "centimeter per trillion years"
                                                                   , "cm/Tyr"
                                                                   , DecimeterPerBillionYears
                                                                   , 1.0 / 10.0 / 1000.0
                                                                    );

   /// <summary>
   /// yoctometer per day, defined as: zeptometer per hour × (1.0/1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity YoctometerPerDay = new (
                                                           "yoctometer per day"
                                                         , "ym/dy"
                                                         , ZeptometerPerHour
                                                         , 1.0 / 1000.0 / 24.0
                                                          );

   /// <summary>
   /// decimeter per nonillion years, defined as: meter per octillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerNonillionYears = new (
                                                                     "decimeter per nonillion years"
                                                                   , "dm/Qyr"
                                                                   , MeterPerOctillionYears
                                                                   , 1.0 / 10.0 / 1000.0
                                                                    );

   /// <summary>
   /// megameter per hour, defined as: kilometer per minute × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity MegameterPerHour = new (
                                                           "megameter per hour"
                                                         , "Mm/hr"
                                                         , KilometerPerMinute
                                                         , 1000.0 / 60.0
                                                          );

   /// <summary>
   /// micrometer per century, defined as: millimeter per decade × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity MicrometerPerCentury = new (
                                                               "micrometer per century"
                                                             , "μm/century"
                                                             , MillimeterPerDecade
                                                             , 1.0 / 1000.0 / 10.0
                                                              );

   /// <summary>
   /// picometer per year, defined as: nanometer per day × (1.0/1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity PicometerPerYear = new (
                                                           "picometer per year"
                                                         , "pm/yr"
                                                         , NanometerPerDay
                                                         , 1.0 / 1000.0 / 365.2525
                                                          );

   /// <summary>
   /// decimeter per decillion years, defined as: meter per nonillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DecimeterPerDecillionYears = new (
                                                                     "decimeter per decillion years"
                                                                   , "dm/decillion yr"
                                                                   , MeterPerNonillionYears
                                                                   , 1.0 / 10.0 / 1000.0
                                                                    );

   /// <summary>
   /// centimeter per quadrillion years, defined as: decimeter per trillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerQuadrillionYears = new (
                                                                        "centimeter per quadrillion years"
                                                                      , "cm/Pyr"
                                                                      , DecimeterPerTrillionYears
                                                                      , 1.0 / 10.0 / 1000.0
                                                                       );

   /// <summary>
   /// millimeter per million years, defined as: centimeter per millennium × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerMillionYears = new (
                                                                    "millimeter per million years"
                                                                  , "mm/Myr"
                                                                  , CentimeterPerMillennium
                                                                  , 1.0 / 10.0 / 1000.0
                                                                   );

   /// <summary>
   /// nanometer per decade, defined as: micrometer per year × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity NanometerPerDecade = new (
                                                             "nanometer per decade"
                                                           , "nm/decade"
                                                           , MicrometerPerYear
                                                           , 1.0 / 1000.0 / 10.0
                                                            );

   /// <summary>
   /// attometer per week, defined as: femtometer per day × (1.0/1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity AttometerPerWeek = new (
                                                           "attometer per week"
                                                         , "am/wk"
                                                         , FemtometerPerDay
                                                         , 1.0 / 1000.0 / 7.0
                                                          );

   /// <summary>
   /// rontometer per day, defined as: yoctometer per hour × (1.0/1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity RontometerPerDay = new (
                                                           "rontometer per day"
                                                         , "rm/dy"
                                                         , YoctometerPerHour
                                                         , 1.0 / 1000.0 / 24.0
                                                          );

   /// <summary>
   /// gigameter per hour, defined as: megameter per minute × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity GigameterPerHour = new (
                                                           "gigameter per hour"
                                                         , "Gm/hr"
                                                         , MegameterPerMinute
                                                         , 1000.0 / 60.0
                                                          );

   /// <summary>
   /// terameter per hour, defined as: gigameter per minute × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity TerameterPerHour = new (
                                                           "terameter per hour"
                                                         , "Tm/hr"
                                                         , GigameterPerMinute
                                                         , 1000.0 / 60.0
                                                          );

   /// <summary>
   /// centimeter per quintillion years, defined as: decimeter per quadrillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerQuintillionYears = new (
                                                                        "centimeter per quintillion years"
                                                                      , "cm/Eyr"
                                                                      , DecimeterPerQuadrillionYears
                                                                      , 1.0 / 10.0 / 1000.0
                                                                       );

   /// <summary>
   /// quectometer per day, defined as: rontometer per hour × (1.0/1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity QuectometerPerDay = new (
                                                            "quectometer per day"
                                                          , "qm/dy"
                                                          , RontometerPerHour
                                                          , 1.0 / 1000.0 / 24.0
                                                           );

   /// <summary>
   /// decimeter per tick, defined as: meter per nanosecond × (1.0/10.0)/(100.0)
   /// </summary>
   public static readonly Velocity DecimeterPerTick = new (
                                                           "decimeter per tick"
                                                         , "dm/tick"
                                                         , MeterPerNanosecond
                                                         , 1.0 / 10.0 / 100.0
                                                          );

   /// <summary>
   /// millimeter per billion years, defined as: centimeter per million years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerBillionYears = new (
                                                                    "millimeter per billion years"
                                                                  , "mm/Gyr"
                                                                  , CentimeterPerMillionYears
                                                                  , 1.0 / 10.0 / 1000.0
                                                                   );

   /// <summary>
   /// micrometer per millennium, defined as: millimeter per century × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity MicrometerPerMillennium =
            new ("micrometer per millennium", "μm/kyr", MillimeterPerCentury, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// femtometer per year, defined as: picometer per day × (1.0/1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity FemtometerPerYear = new (
                                                            "femtometer per year"
                                                          , "fm/yr"
                                                          , PicometerPerDay
                                                          , 1.0 / 1000.0 / 365.2525
                                                           );

   /// <summary>
   /// zeptometer per week, defined as: attometer per day × (1.0/1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerWeek = new (
                                                            "zeptometer per week"
                                                          , "zm/wk"
                                                          , AttometerPerDay
                                                          , 1.0 / 1000.0 / 7.0
                                                           );

   /// <summary>
   /// petameter per hour, defined as: terameter per minute × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity PetameterPerHour = new (
                                                           "petameter per hour"
                                                         , "Pm/hr"
                                                         , TerameterPerMinute
                                                         , 1000.0 / 60.0
                                                          );

   /// <summary>
   /// centimeter per sextillion years, defined as: decimeter per quintillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerSextillionYears = new (
                                                                       "centimeter per sextillion years"
                                                                     , "cm/Zyr"
                                                                     , DecimeterPerQuintillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                      );

   /// <summary>
   /// nanometer per century, defined as: micrometer per decade × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity NanometerPerCentury = new (
                                                              "nanometer per century"
                                                            , "nm/century"
                                                            , MicrometerPerDecade
                                                            , 1.0 / 1000.0 / 10.0
                                                             );

   /// <summary>
   /// picometer per decade, defined as: nanometer per year × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity PicometerPerDecade = new (
                                                             "picometer per decade"
                                                           , "pm/decade"
                                                           , NanometerPerYear
                                                           , 1.0 / 1000.0 / 10.0
                                                            );

   /// <summary>
   /// dekameter per day, defined as: meter per hour × (10.0)/(24.0)
   /// </summary>
   public static readonly Velocity DekameterPerDay = new ("dekameter per day", "dam/dy", MeterPerHour, 10.0 / 24.0);

   /// <summary>
   /// exameter per hour, defined as: petameter per minute × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity ExameterPerHour = new (
                                                          "exameter per hour"
                                                        , "Em/hr"
                                                        , PetameterPerMinute
                                                        , 1000.0 / 60.0
                                                         );

   /// <summary>
   /// millimeter per trillion years, defined as: centimeter per billion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerTrillionYears = new (
                                                                     "millimeter per trillion years"
                                                                   , "mm/Tyr"
                                                                   , CentimeterPerBillionYears
                                                                   , 1.0 / 10.0 / 1000.0
                                                                    );

   /// <summary>
   /// yoctometer per week, defined as: zeptometer per day × (1.0/1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity YoctometerPerWeek = new (
                                                            "yoctometer per week"
                                                          , "ym/wk"
                                                          , ZeptometerPerDay
                                                          , 1.0 / 1000.0 / 7.0
                                                           );

   /// <summary>
   /// zettameter per hour, defined as: exameter per minute × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity ZettameterPerHour = new (
                                                            "zettameter per hour"
                                                          , "Zm/hr"
                                                          , ExameterPerMinute
                                                          , 1000.0 / 60.0
                                                           );

   /// <summary>
   /// centimeter per septillion years, defined as: decimeter per sextillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerSeptillionYears = new (
                                                                       "centimeter per septillion years"
                                                                     , "cm/Yyr"
                                                                     , DecimeterPerSextillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                      );

   /// <summary>
   /// micrometer per million years, defined as: millimeter per millennium × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerMillionYears = new (
                                                                    "micrometer per million years"
                                                                  , "μm/Myr"
                                                                  , MillimeterPerMillennium
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// attometer per year, defined as: femtometer per day × (1.0/1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity AttometerPerYear = new (
                                                           "attometer per year"
                                                         , "am/yr"
                                                         , FemtometerPerDay
                                                         , 1.0 / 1000.0 / 365.2525
                                                          );

   /// <summary>
   /// hectometer per day, defined as: dekameter per hour × (10.0)/(24.0)
   /// </summary>
   public static readonly Velocity HectometerPerDay = new (
                                                           "hectometer per day"
                                                         , "hm/dy"
                                                         , DekameterPerHour
                                                         , 10.0 / 24.0
                                                          );

   /// <summary>
   /// yottameter per hour, defined as: zettameter per minute × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity YottameterPerHour = new (
                                                            "yottameter per hour"
                                                          , "Ym/hr"
                                                          , ZettameterPerMinute
                                                          , 1000.0 / 60.0
                                                           );

   /// <summary>
   /// centimeter per octillion years, defined as: decimeter per septillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerOctillionYears = new (
                                                                      "centimeter per octillion years"
                                                                    , "cm/Ryr"
                                                                    , DecimeterPerSeptillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// millimeter per quadrillion years, defined as: centimeter per trillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerQuadrillionYears = new (
                                                                        "millimeter per quadrillion years"
                                                                      , "mm/Pyr"
                                                                      , CentimeterPerTrillionYears
                                                                      , 1.0 / 10.0 / 1000.0
                                                                       );

   /// <summary>
   /// nanometer per millennium, defined as: micrometer per century × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity NanometerPerMillennium =
            new ("nanometer per millennium", "nm/kyr", MicrometerPerCentury, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// femtometer per decade, defined as: picometer per year × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity FemtometerPerDecade =
            new ("femtometer per decade", "fm/decade", PicometerPerYear, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// rontometer per week, defined as: yoctometer per day × (1.0/1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity RontometerPerWeek = new (
                                                            "rontometer per week"
                                                          , "rm/wk"
                                                          , YoctometerPerDay
                                                          , 1.0 / 1000.0 / 7.0
                                                           );

   /// <summary>
   /// kilometer per day, defined as: hectometer per hour × (10.0)/(24.0)
   /// </summary>
   public static readonly Velocity KilometerPerDay = new ("kilometer per day", "km/dy", HectometerPerHour, 10.0 / 24.0);

   /// <summary>
   /// ronnameter per hour, defined as: yottameter per minute × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity RonnameterPerHour = new (
                                                            "ronnameter per hour"
                                                          , "Rm/hr"
                                                          , YottameterPerMinute
                                                          , 1000.0 / 60.0
                                                           );

   /// <summary>
   /// picometer per century, defined as: nanometer per decade × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity PicometerPerCentury = new (
                                                              "picometer per century"
                                                            , "pm/century"
                                                            , NanometerPerDecade
                                                            , 1.0 / 1000.0 / 10.0
                                                             );

   /// <summary>
   /// micrometer per billion years, defined as: millimeter per million years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerBillionYears = new (
                                                                    "micrometer per billion years"
                                                                  , "μm/Gyr"
                                                                  , MillimeterPerMillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// zeptometer per year, defined as: attometer per day × (1.0/1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity ZeptometerPerYear = new (
                                                            "zeptometer per year"
                                                          , "zm/yr"
                                                          , AttometerPerDay
                                                          , 1.0 / 1000.0 / 365.2525
                                                           );

   /// <summary>
   /// quettameter per hour, defined as: ronnameter per minute × (1000.0)/(60.0)
   /// </summary>
   public static readonly Velocity QuettameterPerHour = new (
                                                             "quettameter per hour"
                                                           , "Qm/hr"
                                                           , RonnameterPerMinute
                                                           , 1000.0 / 60.0
                                                            );

   /// <summary>
   /// centimeter per nonillion years, defined as: decimeter per octillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerNonillionYears = new (
                                                                      "centimeter per nonillion years"
                                                                    , "cm/Qyr"
                                                                    , DecimeterPerOctillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// megameter per day, defined as: kilometer per hour × (1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity MegameterPerDay = new (
                                                          "megameter per day"
                                                        , "Mm/dy"
                                                        , KilometerPerHour
                                                        , 1000.0 / 24.0
                                                         );

   /// <summary>
   /// millimeter per quintillion years, defined as: centimeter per quadrillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerQuintillionYears = new (
                                                                        "millimeter per quintillion years"
                                                                      , "mm/Eyr"
                                                                      , CentimeterPerQuadrillionYears
                                                                      , 1.0 / 10.0 / 1000.0
                                                                       );

   /// <summary>
   /// quectometer per week, defined as: rontometer per day × (1.0/1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity QuectometerPerWeek = new (
                                                             "quectometer per week"
                                                           , "qm/wk"
                                                           , RontometerPerDay
                                                           , 1.0 / 1000.0 / 7.0
                                                            );

   /// <summary>
   /// centimeter per decillion years, defined as: decimeter per nonillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity CentimeterPerDecillionYears = new (
                                                                      "centimeter per decillion years"
                                                                    , "cm/decillion yr"
                                                                    , DecimeterPerNonillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// nanometer per million years, defined as: micrometer per millennium × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerMillionYears = new (
                                                                   "nanometer per million years"
                                                                 , "nm/Myr"
                                                                 , MicrometerPerMillennium
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                  );

   /// <summary>
   /// attometer per decade, defined as: femtometer per year × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity AttometerPerDecade = new (
                                                             "attometer per decade"
                                                           , "am/decade"
                                                           , FemtometerPerYear
                                                           , 1.0 / 1000.0 / 10.0
                                                            );

   /// <summary>
   /// gigameter per day, defined as: megameter per hour × (1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity GigameterPerDay = new (
                                                          "gigameter per day"
                                                        , "Gm/dy"
                                                        , MegameterPerHour
                                                        , 1000.0 / 24.0
                                                         );

   /// <summary>
   /// micrometer per trillion years, defined as: millimeter per billion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerTrillionYears = new (
                                                                     "micrometer per trillion years"
                                                                   , "μm/Tyr"
                                                                   , MillimeterPerBillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// yoctometer per year, defined as: zeptometer per day × (1.0/1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity YoctometerPerYear = new (
                                                            "yoctometer per year"
                                                          , "ym/yr"
                                                          , ZeptometerPerDay
                                                          , 1.0 / 1000.0 / 365.2525
                                                           );

   /// <summary>
   /// millimeter per sextillion years, defined as: centimeter per quintillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerSextillionYears = new (
                                                                       "millimeter per sextillion years"
                                                                     , "mm/Zyr"
                                                                     , CentimeterPerQuintillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                      );

   /// <summary>
   /// picometer per millennium, defined as: nanometer per century × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity PicometerPerMillennium =
            new ("picometer per millennium", "pm/kyr", NanometerPerCentury, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// femtometer per century, defined as: picometer per decade × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity FemtometerPerCentury = new (
                                                               "femtometer per century"
                                                             , "fm/century"
                                                             , PicometerPerDecade
                                                             , 1.0 / 1000.0 / 10.0
                                                              );

   /// <summary>
   /// dekameter per week, defined as: meter per day × (10.0)/(7.0)
   /// </summary>
   public static readonly Velocity DekameterPerWeek = new ("dekameter per week", "dam/wk", MeterPerDay, 10.0 / 7.0);

   /// <summary>
   /// terameter per day, defined as: gigameter per hour × (1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity TerameterPerDay = new (
                                                          "terameter per day"
                                                        , "Tm/dy"
                                                        , GigameterPerHour
                                                        , 1000.0 / 24.0
                                                         );

   /// <summary>
   /// centimeter per tick, defined as: decimeter per nanosecond × (1.0/10.0)/(100.0)
   /// </summary>
   public static readonly Velocity CentimeterPerTick = new (
                                                            "centimeter per tick"
                                                          , "cm/tick"
                                                          , DecimeterPerNanosecond
                                                          , 1.0 / 10.0 / 100.0
                                                           );

   /// <summary>
   /// millimeter per septillion years, defined as: centimeter per sextillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerSeptillionYears = new (
                                                                       "millimeter per septillion years"
                                                                     , "mm/Yyr"
                                                                     , CentimeterPerSextillionYears
                                                                     , 1.0 / 10.0 / 1000.0
                                                                      );

   /// <summary>
   /// micrometer per quadrillion years, defined as: millimeter per trillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerQuadrillionYears = new (
                                                                        "micrometer per quadrillion years"
                                                                      , "μm/Pyr"
                                                                      , MillimeterPerTrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// nanometer per billion years, defined as: micrometer per million years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerBillionYears = new (
                                                                   "nanometer per billion years"
                                                                 , "nm/Gyr"
                                                                 , MicrometerPerMillionYears
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                  );

   /// <summary>
   /// zeptometer per decade, defined as: attometer per year × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerDecade =
            new ("zeptometer per decade", "zm/decade", AttometerPerYear, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// rontometer per year, defined as: yoctometer per day × (1.0/1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity RontometerPerYear = new (
                                                            "rontometer per year"
                                                          , "rm/yr"
                                                          , YoctometerPerDay
                                                          , 1.0 / 1000.0 / 365.2525
                                                           );

   /// <summary>
   /// hectometer per week, defined as: dekameter per day × (10.0)/(7.0)
   /// </summary>
   public static readonly Velocity HectometerPerWeek = new (
                                                            "hectometer per week"
                                                          , "hm/wk"
                                                          , DekameterPerDay
                                                          , 10.0 / 7.0
                                                           );

   /// <summary>
   /// petameter per day, defined as: terameter per hour × (1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity PetameterPerDay = new (
                                                          "petameter per day"
                                                        , "Pm/dy"
                                                        , TerameterPerHour
                                                        , 1000.0 / 24.0
                                                         );

   /// <summary>
   /// picometer per million years, defined as: nanometer per millennium × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerMillionYears = new (
                                                                   "picometer per million years"
                                                                 , "pm/Myr"
                                                                 , NanometerPerMillennium
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                  );

   /// <summary>
   /// attometer per century, defined as: femtometer per decade × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity AttometerPerCentury = new (
                                                              "attometer per century"
                                                            , "am/century"
                                                            , FemtometerPerDecade
                                                            , 1.0 / 1000.0 / 10.0
                                                             );

   /// <summary>
   /// exameter per day, defined as: petameter per hour × (1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity ExameterPerDay = new ("exameter per day", "Em/dy", PetameterPerHour, 1000.0 / 24.0);

   /// <summary>
   /// millimeter per octillion years, defined as: centimeter per septillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerOctillionYears = new (
                                                                      "millimeter per octillion years"
                                                                    , "mm/Ryr"
                                                                    , CentimeterPerSeptillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// femtometer per millennium, defined as: picometer per century × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity FemtometerPerMillennium =
            new ("femtometer per millennium", "fm/kyr", PicometerPerCentury, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// kilometer per week, defined as: hectometer per day × (10.0)/(7.0)
   /// </summary>
   public static readonly Velocity KilometerPerWeek = new ("kilometer per week", "km/wk", HectometerPerDay, 10.0 / 7.0);

   /// <summary>
   /// micrometer per quintillion years, defined as: millimeter per quadrillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerQuintillionYears = new (
                                                                        "micrometer per quintillion years"
                                                                      , "μm/Eyr"
                                                                      , MillimeterPerQuadrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// quectometer per year, defined as: rontometer per day × (1.0/1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity QuectometerPerYear = new (
                                                             "quectometer per year"
                                                           , "qm/yr"
                                                           , RontometerPerDay
                                                           , 1.0 / 1000.0 / 365.2525
                                                            );

   /// <summary>
   /// nanometer per trillion years, defined as: micrometer per billion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerTrillionYears = new (
                                                                    "nanometer per trillion years"
                                                                  , "nm/Tyr"
                                                                  , MicrometerPerBillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// yoctometer per decade, defined as: zeptometer per year × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity YoctometerPerDecade =
            new ("yoctometer per decade", "ym/decade", ZeptometerPerYear, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// zettameter per day, defined as: exameter per hour × (1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity ZettameterPerDay = new (
                                                           "zettameter per day"
                                                         , "Zm/dy"
                                                         , ExameterPerHour
                                                         , 1000.0 / 24.0
                                                          );

   /// <summary>
   /// millimeter per nonillion years, defined as: centimeter per octillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerNonillionYears = new (
                                                                      "millimeter per nonillion years"
                                                                    , "mm/Qyr"
                                                                    , CentimeterPerOctillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// megameter per week, defined as: kilometer per day × (1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity MegameterPerWeek = new (
                                                           "megameter per week"
                                                         , "Mm/wk"
                                                         , KilometerPerDay
                                                         , 1000.0 / 7.0
                                                          );

   /// <summary>
   /// yottameter per day, defined as: zettameter per hour × (1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity YottameterPerDay = new (
                                                           "yottameter per day"
                                                         , "Ym/dy"
                                                         , ZettameterPerHour
                                                         , 1000.0 / 24.0
                                                          );

   /// <summary>
   /// micrometer per sextillion years, defined as: millimeter per quintillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerSextillionYears = new (
                                                                       "micrometer per sextillion years"
                                                                     , "μm/Zyr"
                                                                     , MillimeterPerQuintillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// picometer per billion years, defined as: nanometer per million years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerBillionYears = new (
                                                                   "picometer per billion years"
                                                                 , "pm/Gyr"
                                                                 , NanometerPerMillionYears
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                  );

   /// <summary>
   /// zeptometer per century, defined as: attometer per decade × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerCentury = new (
                                                               "zeptometer per century"
                                                             , "zm/century"
                                                             , AttometerPerDecade
                                                             , 1.0 / 1000.0 / 10.0
                                                              );

   /// <summary>
   /// dekameter per year, defined as: meter per day × (10.0)/(365.2525)
   /// </summary>
   public static readonly Velocity DekameterPerYear = new (
                                                           "dekameter per year"
                                                         , "dam/yr"
                                                         , MeterPerDay
                                                         , 10.0 / 365.2525
                                                          );

   /// <summary>
   /// millimeter per decillion years, defined as: centimeter per nonillion years × (1.0/10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MillimeterPerDecillionYears = new (
                                                                      "millimeter per decillion years"
                                                                    , "mm/decillion yr"
                                                                    , CentimeterPerNonillionYears
                                                                    , 1.0 / 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// nanometer per quadrillion years, defined as: micrometer per trillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerQuadrillionYears = new (
                                                                       "nanometer per quadrillion years"
                                                                     , "nm/Pyr"
                                                                     , MicrometerPerTrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// femtometer per million years, defined as: picometer per millennium × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerMillionYears = new (
                                                                    "femtometer per million years"
                                                                  , "fm/Myr"
                                                                  , PicometerPerMillennium
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// attometer per millennium, defined as: femtometer per century × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity AttometerPerMillennium =
            new ("attometer per millennium", "am/kyr", FemtometerPerCentury, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// rontometer per decade, defined as: yoctometer per year × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity RontometerPerDecade =
            new ("rontometer per decade", "rm/decade", YoctometerPerYear, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// gigameter per week, defined as: megameter per day × (1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity GigameterPerWeek = new (
                                                           "gigameter per week"
                                                         , "Gm/wk"
                                                         , MegameterPerDay
                                                         , 1000.0 / 7.0
                                                          );

   /// <summary>
   /// ronnameter per day, defined as: yottameter per hour × (1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity RonnameterPerDay = new (
                                                           "ronnameter per day"
                                                         , "Rm/dy"
                                                         , YottameterPerHour
                                                         , 1000.0 / 24.0
                                                          );

   /// <summary>
   /// micrometer per septillion years, defined as: millimeter per sextillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerSeptillionYears = new (
                                                                       "micrometer per septillion years"
                                                                     , "μm/Yyr"
                                                                     , MillimeterPerSextillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// hectometer per year, defined as: dekameter per day × (10.0)/(365.2525)
   /// </summary>
   public static readonly Velocity HectometerPerYear = new (
                                                            "hectometer per year"
                                                          , "hm/yr"
                                                          , DekameterPerDay
                                                          , 10.0 / 365.2525
                                                           );

   /// <summary>
   /// quettameter per day, defined as: ronnameter per hour × (1000.0)/(24.0)
   /// </summary>
   public static readonly Velocity QuettameterPerDay = new (
                                                            "quettameter per day"
                                                          , "Qm/dy"
                                                          , RonnameterPerHour
                                                          , 1000.0 / 24.0
                                                           );

   /// <summary>
   /// terameter per week, defined as: gigameter per day × (1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity TerameterPerWeek = new (
                                                           "terameter per week"
                                                         , "Tm/wk"
                                                         , GigameterPerDay
                                                         , 1000.0 / 7.0
                                                          );

   /// <summary>
   /// picometer per trillion years, defined as: nanometer per billion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerTrillionYears = new (
                                                                    "picometer per trillion years"
                                                                  , "pm/Tyr"
                                                                  , NanometerPerBillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// yoctometer per century, defined as: zeptometer per decade × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity YoctometerPerCentury = new (
                                                               "yoctometer per century"
                                                             , "ym/century"
                                                             , ZeptometerPerDecade
                                                             , 1.0 / 1000.0 / 10.0
                                                              );

   /// <summary>
   /// nanometer per quintillion years, defined as: micrometer per quadrillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerQuintillionYears = new (
                                                                       "nanometer per quintillion years"
                                                                     , "nm/Eyr"
                                                                     , MicrometerPerQuadrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// quectometer per decade, defined as: rontometer per year × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity QuectometerPerDecade =
            new ("quectometer per decade", "qm/decade", RontometerPerYear, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// millimeter per tick, defined as: centimeter per nanosecond × (1.0/10.0)/(100.0)
   /// </summary>
   public static readonly Velocity MillimeterPerTick = new (
                                                            "millimeter per tick"
                                                          , "mm/tick"
                                                          , CentimeterPerNanosecond
                                                          , 1.0 / 10.0 / 100.0
                                                           );

   /// <summary>
   /// micrometer per octillion years, defined as: millimeter per septillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerOctillionYears = new (
                                                                      "micrometer per octillion years"
                                                                    , "μm/Ryr"
                                                                    , MillimeterPerSeptillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// femtometer per billion years, defined as: picometer per million years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerBillionYears = new (
                                                                    "femtometer per billion years"
                                                                  , "fm/Gyr"
                                                                  , PicometerPerMillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// zeptometer per millennium, defined as: attometer per century × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerMillennium =
            new ("zeptometer per millennium", "zm/kyr", AttometerPerCentury, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// kilometer per year, defined as: hectometer per day × (10.0)/(365.2525)
   /// </summary>
   public static readonly Velocity KilometerPerYear = new (
                                                           "kilometer per year"
                                                         , "km/yr"
                                                         , HectometerPerDay
                                                         , 10.0 / 365.2525
                                                          );

   /// <summary>
   /// petameter per week, defined as: terameter per day × (1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity PetameterPerWeek = new (
                                                           "petameter per week"
                                                         , "Pm/wk"
                                                         , TerameterPerDay
                                                         , 1000.0 / 7.0
                                                          );

   /// <summary>
   /// attometer per million years, defined as: femtometer per millennium × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerMillionYears = new (
                                                                   "attometer per million years"
                                                                 , "am/Myr"
                                                                 , FemtometerPerMillennium
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                  );

   /// <summary>
   /// nanometer per sextillion years, defined as: micrometer per quintillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerSextillionYears = new (
                                                                      "nanometer per sextillion years"
                                                                    , "nm/Zyr"
                                                                    , MicrometerPerQuintillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// picometer per quadrillion years, defined as: nanometer per trillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerQuadrillionYears = new (
                                                                       "picometer per quadrillion years"
                                                                     , "pm/Pyr"
                                                                     , NanometerPerTrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// rontometer per century, defined as: yoctometer per decade × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity RontometerPerCentury = new (
                                                               "rontometer per century"
                                                             , "rm/century"
                                                             , YoctometerPerDecade
                                                             , 1.0 / 1000.0 / 10.0
                                                              );

   /// <summary>
   /// dekameter per decade, defined as: meter per year × (10.0)/(10.0)
   /// </summary>
   public static readonly Velocity DekameterPerDecade = new (
                                                             "dekameter per decade"
                                                           , "dam/decade"
                                                           , MeterPerYear
                                                           , 10.0 / 10.0
                                                            );

   /// <summary>
   /// exameter per week, defined as: petameter per day × (1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity ExameterPerWeek = new ("exameter per week", "Em/wk", PetameterPerDay, 1000.0 / 7.0);

   /// <summary>
   /// micrometer per nonillion years, defined as: millimeter per octillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerNonillionYears = new (
                                                                      "micrometer per nonillion years"
                                                                    , "μm/Qyr"
                                                                    , MillimeterPerOctillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// megameter per year, defined as: kilometer per day × (1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity MegameterPerYear = new (
                                                           "megameter per year"
                                                         , "Mm/yr"
                                                         , KilometerPerDay
                                                         , 1000.0 / 365.2525
                                                          );

   /// <summary>
   /// femtometer per trillion years, defined as: picometer per billion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerTrillionYears = new (
                                                                     "femtometer per trillion years"
                                                                   , "fm/Tyr"
                                                                   , PicometerPerBillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// yoctometer per millennium, defined as: zeptometer per century × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity YoctometerPerMillennium =
            new ("yoctometer per millennium", "ym/kyr", ZeptometerPerCentury, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// zettameter per week, defined as: exameter per day × (1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity ZettameterPerWeek = new (
                                                            "zettameter per week"
                                                          , "Zm/wk"
                                                          , ExameterPerDay
                                                          , 1000.0 / 7.0
                                                           );

   /// <summary>
   /// micrometer per decillion years, defined as: millimeter per nonillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MicrometerPerDecillionYears = new (
                                                                      "micrometer per decillion years"
                                                                    , "μm/decillion yr"
                                                                    , MillimeterPerNonillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// nanometer per septillion years, defined as: micrometer per sextillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerSeptillionYears = new (
                                                                      "nanometer per septillion years"
                                                                    , "nm/Yyr"
                                                                    , MicrometerPerSextillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// attometer per billion years, defined as: femtometer per million years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerBillionYears = new (
                                                                   "attometer per billion years"
                                                                 , "am/Gyr"
                                                                 , FemtometerPerMillionYears
                                                                 , 1.0 / 1000.0 / 1000.0
                                                                  );

   /// <summary>
   /// zeptometer per million years, defined as: attometer per millennium × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerMillionYears = new (
                                                                    "zeptometer per million years"
                                                                  , "zm/Myr"
                                                                  , AttometerPerMillennium
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// hectometer per decade, defined as: dekameter per year × (10.0)/(10.0)
   /// </summary>
   public static readonly Velocity HectometerPerDecade =
            new ("hectometer per decade", "hm/decade", DekameterPerYear, 10.0 / 10.0);

   /// <summary>
   /// gigameter per year, defined as: megameter per day × (1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity GigameterPerYear = new (
                                                           "gigameter per year"
                                                         , "Gm/yr"
                                                         , MegameterPerDay
                                                         , 1000.0 / 365.2525
                                                          );

   /// <summary>
   /// picometer per quintillion years, defined as: nanometer per quadrillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerQuintillionYears = new (
                                                                       "picometer per quintillion years"
                                                                     , "pm/Eyr"
                                                                     , NanometerPerQuadrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// quectometer per century, defined as: rontometer per decade × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity QuectometerPerCentury = new (
                                                                "quectometer per century"
                                                              , "qm/century"
                                                              , RontometerPerDecade
                                                              , 1.0 / 1000.0 / 10.0
                                                               );

   /// <summary>
   /// yottameter per week, defined as: zettameter per day × (1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity YottameterPerWeek = new (
                                                            "yottameter per week"
                                                          , "Ym/wk"
                                                          , ZettameterPerDay
                                                          , 1000.0 / 7.0
                                                           );

   /// <summary>
   /// terameter per year, defined as: gigameter per day × (1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity TerameterPerYear = new (
                                                           "terameter per year"
                                                         , "Tm/yr"
                                                         , GigameterPerDay
                                                         , 1000.0 / 365.2525
                                                          );

   /// <summary>
   /// nanometer per octillion years, defined as: micrometer per septillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerOctillionYears = new (
                                                                     "nanometer per octillion years"
                                                                   , "nm/Ryr"
                                                                   , MicrometerPerSeptillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// femtometer per quadrillion years, defined as: picometer per trillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerQuadrillionYears = new (
                                                                        "femtometer per quadrillion years"
                                                                      , "fm/Pyr"
                                                                      , PicometerPerTrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// rontometer per millennium, defined as: yoctometer per century × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity RontometerPerMillennium =
            new ("rontometer per millennium", "rm/kyr", YoctometerPerCentury, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// kilometer per decade, defined as: hectometer per year × (10.0)/(10.0)
   /// </summary>
   public static readonly Velocity KilometerPerDecade = new (
                                                             "kilometer per decade"
                                                           , "km/decade"
                                                           , HectometerPerYear
                                                           , 10.0 / 10.0
                                                            );

   /// <summary>
   /// ronnameter per week, defined as: yottameter per day × (1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity RonnameterPerWeek = new (
                                                            "ronnameter per week"
                                                          , "Rm/wk"
                                                          , YottameterPerDay
                                                          , 1000.0 / 7.0
                                                           );

   /// <summary>
   /// picometer per sextillion years, defined as: nanometer per quintillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerSextillionYears = new (
                                                                      "picometer per sextillion years"
                                                                    , "pm/Zyr"
                                                                    , NanometerPerQuintillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// dekameter per century, defined as: meter per decade × (10.0)/(10.0)
   /// </summary>
   public static readonly Velocity DekameterPerCentury =
            new ("dekameter per century", "dam/century", MeterPerDecade, 10.0 / 10.0);

   /// <summary>
   /// attometer per trillion years, defined as: femtometer per billion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerTrillionYears = new (
                                                                    "attometer per trillion years"
                                                                  , "am/Tyr"
                                                                  , FemtometerPerBillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// yoctometer per million years, defined as: zeptometer per millennium × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerMillionYears = new (
                                                                    "yoctometer per million years"
                                                                  , "ym/Myr"
                                                                  , ZeptometerPerMillennium
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// micrometer per tick, defined as: millimeter per nanosecond × (1.0/1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity MicrometerPerTick = new (
                                                            "micrometer per tick"
                                                          , "μm/tick"
                                                          , MillimeterPerNanosecond
                                                          , 1.0 / 1000.0 / 100.0
                                                           );

   /// <summary>
   /// zeptometer per billion years, defined as: attometer per million years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerBillionYears = new (
                                                                    "zeptometer per billion years"
                                                                  , "zm/Gyr"
                                                                  , AttometerPerMillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// petameter per year, defined as: terameter per day × (1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity PetameterPerYear = new (
                                                           "petameter per year"
                                                         , "Pm/yr"
                                                         , TerameterPerDay
                                                         , 1000.0 / 365.2525
                                                          );

   /// <summary>
   /// quettameter per week, defined as: ronnameter per day × (1000.0)/(7.0)
   /// </summary>
   public static readonly Velocity QuettameterPerWeek = new (
                                                             "quettameter per week"
                                                           , "Qm/wk"
                                                           , RonnameterPerDay
                                                           , 1000.0 / 7.0
                                                            );

   /// <summary>
   /// nanometer per nonillion years, defined as: micrometer per octillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerNonillionYears = new (
                                                                     "nanometer per nonillion years"
                                                                   , "nm/Qyr"
                                                                   , MicrometerPerOctillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// megameter per decade, defined as: kilometer per year × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity MegameterPerDecade = new (
                                                             "megameter per decade"
                                                           , "Mm/decade"
                                                           , KilometerPerYear
                                                           , 1000.0 / 10.0
                                                            );

   /// <summary>
   /// femtometer per quintillion years, defined as: picometer per quadrillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerQuintillionYears = new (
                                                                        "femtometer per quintillion years"
                                                                      , "fm/Eyr"
                                                                      , PicometerPerQuadrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// quectometer per millennium, defined as: rontometer per century × (1.0/1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity QuectometerPerMillennium =
            new ("quectometer per millennium", "qm/kyr", RontometerPerCentury, 1.0 / 1000.0 / 10.0);

   /// <summary>
   /// picometer per septillion years, defined as: nanometer per sextillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerSeptillionYears = new (
                                                                      "picometer per septillion years"
                                                                    , "pm/Yyr"
                                                                    , NanometerPerSextillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// hectometer per century, defined as: dekameter per decade × (10.0)/(10.0)
   /// </summary>
   public static readonly Velocity HectometerPerCentury =
            new ("hectometer per century", "hm/century", DekameterPerDecade, 10.0 / 10.0);

   /// <summary>
   /// exameter per year, defined as: petameter per day × (1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity ExameterPerYear = new (
                                                          "exameter per year"
                                                        , "Em/yr"
                                                        , PetameterPerDay
                                                        , 1000.0 / 365.2525
                                                         );

   /// <summary>
   /// nanometer per decillion years, defined as: micrometer per nonillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity NanometerPerDecillionYears = new (
                                                                     "nanometer per decillion years"
                                                                   , "nm/decillion yr"
                                                                   , MicrometerPerNonillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// attometer per quadrillion years, defined as: femtometer per trillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerQuadrillionYears = new (
                                                                       "attometer per quadrillion years"
                                                                     , "am/Pyr"
                                                                     , FemtometerPerTrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// rontometer per million years, defined as: yoctometer per millennium × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerMillionYears = new (
                                                                    "rontometer per million years"
                                                                  , "rm/Myr"
                                                                  , YoctometerPerMillennium
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// gigameter per decade, defined as: megameter per year × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity GigameterPerDecade = new (
                                                             "gigameter per decade"
                                                           , "Gm/decade"
                                                           , MegameterPerYear
                                                           , 1000.0 / 10.0
                                                            );

   /// <summary>
   /// zeptometer per trillion years, defined as: attometer per billion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerTrillionYears = new (
                                                                     "zeptometer per trillion years"
                                                                   , "zm/Tyr"
                                                                   , AttometerPerBillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// yoctometer per billion years, defined as: zeptometer per million years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerBillionYears = new (
                                                                    "yoctometer per billion years"
                                                                  , "ym/Gyr"
                                                                  , ZeptometerPerMillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// zettameter per year, defined as: exameter per day × (1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity ZettameterPerYear = new (
                                                            "zettameter per year"
                                                          , "Zm/yr"
                                                          , ExameterPerDay
                                                          , 1000.0 / 365.2525
                                                           );

   /// <summary>
   /// picometer per octillion years, defined as: nanometer per septillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerOctillionYears = new (
                                                                     "picometer per octillion years"
                                                                   , "pm/Ryr"
                                                                   , NanometerPerSeptillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// femtometer per sextillion years, defined as: picometer per quintillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerSextillionYears = new (
                                                                       "femtometer per sextillion years"
                                                                     , "fm/Zyr"
                                                                     , PicometerPerQuintillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// dekameter per millennium, defined as: meter per century × (10.0)/(10.0)
   /// </summary>
   public static readonly Velocity DekameterPerMillennium =
            new ("dekameter per millennium", "dam/kyr", MeterPerCentury, 10.0 / 10.0);

   /// <summary>
   /// kilometer per century, defined as: hectometer per decade × (10.0)/(10.0)
   /// </summary>
   public static readonly Velocity KilometerPerCentury =
            new ("kilometer per century", "km/century", HectometerPerDecade, 10.0 / 10.0);

   /// <summary>
   /// terameter per decade, defined as: gigameter per year × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity TerameterPerDecade = new (
                                                             "terameter per decade"
                                                           , "Tm/decade"
                                                           , GigameterPerYear
                                                           , 1000.0 / 10.0
                                                            );

   /// <summary>
   /// yottameter per year, defined as: zettameter per day × (1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity YottameterPerYear = new (
                                                            "yottameter per year"
                                                          , "Ym/yr"
                                                          , ZettameterPerDay
                                                          , 1000.0 / 365.2525
                                                           );

   /// <summary>
   /// attometer per quintillion years, defined as: femtometer per quadrillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerQuintillionYears = new (
                                                                       "attometer per quintillion years"
                                                                     , "am/Eyr"
                                                                     , FemtometerPerQuadrillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// quectometer per million years, defined as: rontometer per millennium × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerMillionYears = new (
                                                                     "quectometer per million years"
                                                                   , "qm/Myr"
                                                                   , RontometerPerMillennium
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// picometer per nonillion years, defined as: nanometer per octillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerNonillionYears = new (
                                                                     "picometer per nonillion years"
                                                                   , "pm/Qyr"
                                                                   , NanometerPerOctillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// megameter per century, defined as: kilometer per decade × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity MegameterPerCentury =
            new ("megameter per century", "Mm/century", KilometerPerDecade, 1000.0 / 10.0);

   /// <summary>
   /// nanometer per tick, defined as: micrometer per nanosecond × (1.0/1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity NanometerPerTick = new (
                                                           "nanometer per tick"
                                                         , "nm/tick"
                                                         , MicrometerPerNanosecond
                                                         , 1.0 / 1000.0 / 100.0
                                                          );

   /// <summary>
   /// femtometer per septillion years, defined as: picometer per sextillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerSeptillionYears = new (
                                                                       "femtometer per septillion years"
                                                                     , "fm/Yyr"
                                                                     , PicometerPerSextillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// zeptometer per quadrillion years, defined as: attometer per trillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerQuadrillionYears = new (
                                                                        "zeptometer per quadrillion years"
                                                                      , "zm/Pyr"
                                                                      , AttometerPerTrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// rontometer per billion years, defined as: yoctometer per million years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerBillionYears = new (
                                                                    "rontometer per billion years"
                                                                  , "rm/Gyr"
                                                                  , YoctometerPerMillionYears
                                                                  , 1.0 / 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// hectometer per millennium, defined as: dekameter per century × (10.0)/(10.0)
   /// </summary>
   public static readonly Velocity HectometerPerMillennium =
            new ("hectometer per millennium", "hm/kyr", DekameterPerCentury, 10.0 / 10.0);

   /// <summary>
   /// petameter per decade, defined as: terameter per year × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity PetameterPerDecade = new (
                                                             "petameter per decade"
                                                           , "Pm/decade"
                                                           , TerameterPerYear
                                                           , 1000.0 / 10.0
                                                            );

   /// <summary>
   /// ronnameter per year, defined as: yottameter per day × (1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity RonnameterPerYear = new (
                                                            "ronnameter per year"
                                                          , "Rm/yr"
                                                          , YottameterPerDay
                                                          , 1000.0 / 365.2525
                                                           );

   /// <summary>
   /// yoctometer per trillion years, defined as: zeptometer per billion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerTrillionYears = new (
                                                                     "yoctometer per trillion years"
                                                                   , "ym/Tyr"
                                                                   , ZeptometerPerBillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// quettameter per year, defined as: ronnameter per day × (1000.0)/(365.2525)
   /// </summary>
   public static readonly Velocity QuettameterPerYear = new (
                                                             "quettameter per year"
                                                           , "Qm/yr"
                                                           , RonnameterPerDay
                                                           , 1000.0 / 365.2525
                                                            );

   /// <summary>
   /// picometer per decillion years, defined as: nanometer per nonillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PicometerPerDecillionYears = new (
                                                                     "picometer per decillion years"
                                                                   , "pm/decillion yr"
                                                                   , NanometerPerNonillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// attometer per sextillion years, defined as: femtometer per quintillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerSextillionYears = new (
                                                                      "attometer per sextillion years"
                                                                    , "am/Zyr"
                                                                    , FemtometerPerQuintillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// dekameter per million years, defined as: meter per millennium × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerMillionYears =
            new ("dekameter per million years", "dam/Myr", MeterPerMillennium, 10.0 / 1000.0);

   /// <summary>
   /// gigameter per century, defined as: megameter per decade × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity GigameterPerCentury =
            new ("gigameter per century", "Gm/century", MegameterPerDecade, 1000.0 / 10.0);

   /// <summary>
   /// exameter per decade, defined as: petameter per year × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity ExameterPerDecade = new (
                                                            "exameter per decade"
                                                          , "Em/decade"
                                                          , PetameterPerYear
                                                          , 1000.0 / 10.0
                                                           );

   /// <summary>
   /// femtometer per octillion years, defined as: picometer per septillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerOctillionYears = new (
                                                                      "femtometer per octillion years"
                                                                    , "fm/Ryr"
                                                                    , PicometerPerSeptillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// kilometer per millennium, defined as: hectometer per century × (10.0)/(10.0)
   /// </summary>
   public static readonly Velocity KilometerPerMillennium =
            new ("kilometer per millennium", "km/kyr", HectometerPerCentury, 10.0 / 10.0);

   /// <summary>
   /// zeptometer per quintillion years, defined as: attometer per quadrillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerQuintillionYears = new (
                                                                        "zeptometer per quintillion years"
                                                                      , "zm/Eyr"
                                                                      , AttometerPerQuadrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// quectometer per billion years, defined as: rontometer per million years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerBillionYears = new (
                                                                     "quectometer per billion years"
                                                                   , "qm/Gyr"
                                                                   , RontometerPerMillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// yoctometer per quadrillion years, defined as: zeptometer per trillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerQuadrillionYears = new (
                                                                        "yoctometer per quadrillion years"
                                                                      , "ym/Pyr"
                                                                      , ZeptometerPerTrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// rontometer per trillion years, defined as: yoctometer per billion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerTrillionYears = new (
                                                                     "rontometer per trillion years"
                                                                   , "rm/Tyr"
                                                                   , YoctometerPerBillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// zettameter per decade, defined as: exameter per year × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity ZettameterPerDecade =
            new ("zettameter per decade", "Zm/decade", ExameterPerYear, 1000.0 / 10.0);

   /// <summary>
   /// terameter per century, defined as: gigameter per decade × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity TerameterPerCentury =
            new ("terameter per century", "Tm/century", GigameterPerDecade, 1000.0 / 10.0);

   /// <summary>
   /// attometer per septillion years, defined as: femtometer per sextillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerSeptillionYears = new (
                                                                      "attometer per septillion years"
                                                                    , "am/Yyr"
                                                                    , FemtometerPerSextillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// hectometer per million years, defined as: dekameter per millennium × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerMillionYears =
            new ("hectometer per million years", "hm/Myr", DekameterPerMillennium, 10.0 / 1000.0);

   /// <summary>
   /// femtometer per nonillion years, defined as: picometer per octillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerNonillionYears = new (
                                                                      "femtometer per nonillion years"
                                                                    , "fm/Qyr"
                                                                    , PicometerPerOctillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// megameter per millennium, defined as: kilometer per century × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity MegameterPerMillennium =
            new ("megameter per millennium", "Mm/kyr", KilometerPerCentury, 1000.0 / 10.0);

   /// <summary>
   /// yottameter per decade, defined as: zettameter per year × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity YottameterPerDecade =
            new ("yottameter per decade", "Ym/decade", ZettameterPerYear, 1000.0 / 10.0);

   /// <summary>
   /// picometer per tick, defined as: nanometer per nanosecond × (1.0/1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity PicometerPerTick = new (
                                                           "picometer per tick"
                                                         , "pm/tick"
                                                         , NanometerPerNanosecond
                                                         , 1.0 / 1000.0 / 100.0
                                                          );

   /// <summary>
   /// zeptometer per sextillion years, defined as: attometer per quintillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerSextillionYears = new (
                                                                       "zeptometer per sextillion years"
                                                                     , "zm/Zyr"
                                                                     , AttometerPerQuintillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// dekameter per billion years, defined as: meter per million years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerBillionYears =
            new ("dekameter per billion years", "dam/Gyr", MeterPerMillionYears, 10.0 / 1000.0);

   /// <summary>
   /// petameter per century, defined as: terameter per decade × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity PetameterPerCentury =
            new ("petameter per century", "Pm/century", TerameterPerDecade, 1000.0 / 10.0);

   /// <summary>
   /// yoctometer per quintillion years, defined as: zeptometer per quadrillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerQuintillionYears = new (
                                                                        "yoctometer per quintillion years"
                                                                      , "ym/Eyr"
                                                                      , ZeptometerPerQuadrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// quectometer per trillion years, defined as: rontometer per billion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerTrillionYears = new (
                                                                      "quectometer per trillion years"
                                                                    , "qm/Tyr"
                                                                    , RontometerPerBillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// femtometer per decillion years, defined as: picometer per nonillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity FemtometerPerDecillionYears = new (
                                                                      "femtometer per decillion years"
                                                                    , "fm/decillion yr"
                                                                    , PicometerPerNonillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// attometer per octillion years, defined as: femtometer per septillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerOctillionYears = new (
                                                                     "attometer per octillion years"
                                                                   , "am/Ryr"
                                                                   , FemtometerPerSeptillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// rontometer per quadrillion years, defined as: yoctometer per trillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerQuadrillionYears = new (
                                                                        "rontometer per quadrillion years"
                                                                      , "rm/Pyr"
                                                                      , YoctometerPerTrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// kilometer per million years, defined as: hectometer per millennium × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerMillionYears =
            new ("kilometer per million years", "km/Myr", HectometerPerMillennium, 10.0 / 1000.0);

   /// <summary>
   /// gigameter per millennium, defined as: megameter per century × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity GigameterPerMillennium =
            new ("gigameter per millennium", "Gm/kyr", MegameterPerCentury, 1000.0 / 10.0);

   /// <summary>
   /// ronnameter per decade, defined as: yottameter per year × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity RonnameterPerDecade =
            new ("ronnameter per decade", "Rm/decade", YottameterPerYear, 1000.0 / 10.0);

   /// <summary>
   /// exameter per century, defined as: petameter per decade × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity ExameterPerCentury = new (
                                                             "exameter per century"
                                                           , "Em/century"
                                                           , PetameterPerDecade
                                                           , 1000.0 / 10.0
                                                            );

   /// <summary>
   /// zeptometer per septillion years, defined as: attometer per sextillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerSeptillionYears = new (
                                                                       "zeptometer per septillion years"
                                                                     , "zm/Yyr"
                                                                     , AttometerPerSextillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// hectometer per billion years, defined as: dekameter per million years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerBillionYears =
            new ("hectometer per billion years", "hm/Gyr", DekameterPerMillionYears, 10.0 / 1000.0);

   /// <summary>
   /// quettameter per decade, defined as: ronnameter per year × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity QuettameterPerDecade =
            new ("quettameter per decade", "Qm/decade", RonnameterPerYear, 1000.0 / 10.0);

   /// <summary>
   /// terameter per millennium, defined as: gigameter per century × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity TerameterPerMillennium =
            new ("terameter per millennium", "Tm/kyr", GigameterPerCentury, 1000.0 / 10.0);

   /// <summary>
   /// attometer per nonillion years, defined as: femtometer per octillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerNonillionYears = new (
                                                                     "attometer per nonillion years"
                                                                   , "am/Qyr"
                                                                   , FemtometerPerOctillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// megameter per million years, defined as: kilometer per millennium × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerMillionYears =
            new ("megameter per million years", "Mm/Myr", KilometerPerMillennium, 1000.0 / 1000.0);

   /// <summary>
   /// yoctometer per sextillion years, defined as: zeptometer per quintillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerSextillionYears = new (
                                                                       "yoctometer per sextillion years"
                                                                     , "ym/Zyr"
                                                                     , ZeptometerPerQuintillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// dekameter per trillion years, defined as: meter per billion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerTrillionYears =
            new ("dekameter per trillion years", "dam/Tyr", MeterPerBillionYears, 10.0 / 1000.0);

   /// <summary>
   /// zettameter per century, defined as: exameter per decade × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity ZettameterPerCentury =
            new ("zettameter per century", "Zm/century", ExameterPerDecade, 1000.0 / 10.0);

   /// <summary>
   /// rontometer per quintillion years, defined as: yoctometer per quadrillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerQuintillionYears = new (
                                                                        "rontometer per quintillion years"
                                                                      , "rm/Eyr"
                                                                      , YoctometerPerQuadrillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// quectometer per quadrillion years, defined as: rontometer per trillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerQuadrillionYears = new (
                                                                         "quectometer per quadrillion years"
                                                                       , "qm/Pyr"
                                                                       , RontometerPerTrillionYears
                                                                       , 1.0 / 1000.0 / 1000.0
                                                                        );

   /// <summary>
   /// femtometer per tick, defined as: picometer per nanosecond × (1.0/1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity FemtometerPerTick = new (
                                                            "femtometer per tick"
                                                          , "fm/tick"
                                                          , PicometerPerNanosecond
                                                          , 1.0 / 1000.0 / 100.0
                                                           );

   /// <summary>
   /// zeptometer per octillion years, defined as: attometer per septillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerOctillionYears = new (
                                                                      "zeptometer per octillion years"
                                                                    , "zm/Ryr"
                                                                    , AttometerPerSeptillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// kilometer per billion years, defined as: hectometer per million years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerBillionYears =
            new ("kilometer per billion years", "km/Gyr", HectometerPerMillionYears, 10.0 / 1000.0);

   /// <summary>
   /// petameter per millennium, defined as: terameter per century × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity PetameterPerMillennium =
            new ("petameter per millennium", "Pm/kyr", TerameterPerCentury, 1000.0 / 10.0);

   /// <summary>
   /// yottameter per century, defined as: zettameter per decade × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity YottameterPerCentury =
            new ("yottameter per century", "Ym/century", ZettameterPerDecade, 1000.0 / 10.0);

   /// <summary>
   /// attometer per decillion years, defined as: femtometer per nonillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity AttometerPerDecillionYears = new (
                                                                     "attometer per decillion years"
                                                                   , "am/decillion yr"
                                                                   , FemtometerPerNonillionYears
                                                                   , 1.0 / 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// gigameter per million years, defined as: megameter per millennium × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerMillionYears =
            new ("gigameter per million years", "Gm/Myr", MegameterPerMillennium, 1000.0 / 1000.0);

   /// <summary>
   /// yoctometer per septillion years, defined as: zeptometer per sextillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerSeptillionYears = new (
                                                                       "yoctometer per septillion years"
                                                                     , "ym/Yyr"
                                                                     , ZeptometerPerSextillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// hectometer per trillion years, defined as: dekameter per billion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerTrillionYears =
            new ("hectometer per trillion years", "hm/Tyr", DekameterPerBillionYears, 10.0 / 1000.0);

   /// <summary>
   /// rontometer per sextillion years, defined as: yoctometer per quintillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerSextillionYears = new (
                                                                       "rontometer per sextillion years"
                                                                     , "rm/Zyr"
                                                                     , YoctometerPerQuintillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// dekameter per quadrillion years, defined as: meter per trillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerQuadrillionYears =
            new ("dekameter per quadrillion years", "dam/Pyr", MeterPerTrillionYears, 10.0 / 1000.0);

   /// <summary>
   /// exameter per millennium, defined as: petameter per century × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity ExameterPerMillennium =
            new ("exameter per millennium", "Em/kyr", PetameterPerCentury, 1000.0 / 10.0);

   /// <summary>
   /// ronnameter per century, defined as: yottameter per decade × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity RonnameterPerCentury =
            new ("ronnameter per century", "Rm/century", YottameterPerDecade, 1000.0 / 10.0);

   /// <summary>
   /// quectometer per quintillion years, defined as: rontometer per quadrillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerQuintillionYears = new (
                                                                         "quectometer per quintillion years"
                                                                       , "qm/Eyr"
                                                                       , RontometerPerQuadrillionYears
                                                                       , 1.0 / 1000.0 / 1000.0
                                                                        );

   /// <summary>
   /// zeptometer per nonillion years, defined as: attometer per octillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerNonillionYears = new (
                                                                      "zeptometer per nonillion years"
                                                                    , "zm/Qyr"
                                                                    , AttometerPerOctillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// megameter per billion years, defined as: kilometer per million years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerBillionYears = new (
                                                                   "megameter per billion years"
                                                                 , "Mm/Gyr"
                                                                 , KilometerPerMillionYears
                                                                 , 1000.0 / 1000.0
                                                                  );

   /// <summary>
   /// terameter per million years, defined as: gigameter per millennium × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerMillionYears =
            new ("terameter per million years", "Tm/Myr", GigameterPerMillennium, 1000.0 / 1000.0);

   /// <summary>
   /// quettameter per century, defined as: ronnameter per decade × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity QuettameterPerCentury =
            new ("quettameter per century", "Qm/century", RonnameterPerDecade, 1000.0 / 10.0);

   /// <summary>
   /// yoctometer per octillion years, defined as: zeptometer per septillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerOctillionYears = new (
                                                                      "yoctometer per octillion years"
                                                                    , "ym/Ryr"
                                                                    , ZeptometerPerSeptillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// kilometer per trillion years, defined as: hectometer per billion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerTrillionYears = new (
                                                                    "kilometer per trillion years"
                                                                  , "km/Tyr"
                                                                  , HectometerPerBillionYears
                                                                  , 10.0 / 1000.0
                                                                   );

   /// <summary>
   /// zettameter per millennium, defined as: exameter per century × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity ZettameterPerMillennium =
            new ("zettameter per millennium", "Zm/kyr", ExameterPerCentury, 1000.0 / 10.0);

   /// <summary>
   /// attometer per tick, defined as: femtometer per nanosecond × (1.0/1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity AttometerPerTick = new (
                                                           "attometer per tick"
                                                         , "am/tick"
                                                         , FemtometerPerNanosecond
                                                         , 1.0 / 1000.0 / 100.0
                                                          );

   /// <summary>
   /// zeptometer per decillion years, defined as: attometer per nonillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerDecillionYears = new (
                                                                      "zeptometer per decillion years"
                                                                    , "zm/decillion yr"
                                                                    , AttometerPerNonillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// rontometer per septillion years, defined as: yoctometer per sextillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerSeptillionYears = new (
                                                                       "rontometer per septillion years"
                                                                     , "rm/Yyr"
                                                                     , YoctometerPerSextillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// hectometer per quadrillion years, defined as: dekameter per trillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerQuadrillionYears = new (
                                                                        "hectometer per quadrillion years"
                                                                      , "hm/Pyr"
                                                                      , DekameterPerTrillionYears
                                                                      , 10.0 / 1000.0
                                                                       );

   /// <summary>
   /// gigameter per billion years, defined as: megameter per million years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerBillionYears = new (
                                                                   "gigameter per billion years"
                                                                 , "Gm/Gyr"
                                                                 , MegameterPerMillionYears
                                                                 , 1000.0 / 1000.0
                                                                  );

   /// <summary>
   /// petameter per million years, defined as: terameter per millennium × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerMillionYears =
            new ("petameter per million years", "Pm/Myr", TerameterPerMillennium, 1000.0 / 1000.0);

   /// <summary>
   /// quectometer per sextillion years, defined as: rontometer per quintillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerSextillionYears = new (
                                                                        "quectometer per sextillion years"
                                                                      , "qm/Zyr"
                                                                      , RontometerPerQuintillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// dekameter per quintillion years, defined as: meter per quadrillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerQuintillionYears = new (
                                                                       "dekameter per quintillion years"
                                                                     , "dam/Eyr"
                                                                     , MeterPerQuadrillionYears
                                                                     , 10.0 / 1000.0
                                                                      );

   /// <summary>
   /// yottameter per millennium, defined as: zettameter per century × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity YottameterPerMillennium =
            new ("yottameter per millennium", "Ym/kyr", ZettameterPerCentury, 1000.0 / 10.0);

   /// <summary>
   /// yoctometer per nonillion years, defined as: zeptometer per octillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerNonillionYears = new (
                                                                      "yoctometer per nonillion years"
                                                                    , "ym/Qyr"
                                                                    , ZeptometerPerOctillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// megameter per trillion years, defined as: kilometer per billion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerTrillionYears = new (
                                                                    "megameter per trillion years"
                                                                  , "Mm/Tyr"
                                                                  , KilometerPerBillionYears
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// exameter per million years, defined as: petameter per millennium × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerMillionYears =
            new ("exameter per million years", "Em/Myr", PetameterPerMillennium, 1000.0 / 1000.0);

   /// <summary>
   /// terameter per billion years, defined as: gigameter per million years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerBillionYears = new (
                                                                   "terameter per billion years"
                                                                 , "Tm/Gyr"
                                                                 , GigameterPerMillionYears
                                                                 , 1000.0 / 1000.0
                                                                  );

   /// <summary>
   /// rontometer per octillion years, defined as: yoctometer per septillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerOctillionYears = new (
                                                                      "rontometer per octillion years"
                                                                    , "rm/Ryr"
                                                                    , YoctometerPerSeptillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// kilometer per quadrillion years, defined as: hectometer per trillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerQuadrillionYears = new (
                                                                       "kilometer per quadrillion years"
                                                                     , "km/Pyr"
                                                                     , HectometerPerTrillionYears
                                                                     , 10.0 / 1000.0
                                                                      );

   /// <summary>
   /// ronnameter per millennium, defined as: yottameter per century × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity RonnameterPerMillennium =
            new ("ronnameter per millennium", "Rm/kyr", YottameterPerCentury, 1000.0 / 10.0);

   /// <summary>
   /// quectometer per septillion years, defined as: rontometer per sextillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerSeptillionYears = new (
                                                                        "quectometer per septillion years"
                                                                      , "qm/Yyr"
                                                                      , RontometerPerSextillionYears
                                                                      , 1.0 / 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// hectometer per quintillion years, defined as: dekameter per quadrillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerQuintillionYears = new (
                                                                        "hectometer per quintillion years"
                                                                      , "hm/Eyr"
                                                                      , DekameterPerQuadrillionYears
                                                                      , 10.0 / 1000.0
                                                                       );

   /// <summary>
   /// dekameter per sextillion years, defined as: meter per quintillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerSextillionYears = new (
                                                                      "dekameter per sextillion years"
                                                                    , "dam/Zyr"
                                                                    , MeterPerQuintillionYears
                                                                    , 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// yoctometer per decillion years, defined as: zeptometer per nonillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YoctometerPerDecillionYears = new (
                                                                      "yoctometer per decillion years"
                                                                    , "ym/decillion yr"
                                                                    , ZeptometerPerNonillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// gigameter per trillion years, defined as: megameter per billion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerTrillionYears = new (
                                                                    "gigameter per trillion years"
                                                                  , "Gm/Tyr"
                                                                  , MegameterPerBillionYears
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// zettameter per million years, defined as: exameter per millennium × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerMillionYears =
            new ("zettameter per million years", "Zm/Myr", ExameterPerMillennium, 1000.0 / 1000.0);

   /// <summary>
   /// zeptometer per tick, defined as: attometer per nanosecond × (1.0/1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity ZeptometerPerTick = new (
                                                            "zeptometer per tick"
                                                          , "zm/tick"
                                                          , AttometerPerNanosecond
                                                          , 1.0 / 1000.0 / 100.0
                                                           );

   /// <summary>
   /// petameter per billion years, defined as: terameter per million years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerBillionYears = new (
                                                                   "petameter per billion years"
                                                                 , "Pm/Gyr"
                                                                 , TerameterPerMillionYears
                                                                 , 1000.0 / 1000.0
                                                                  );

   /// <summary>
   /// quettameter per millennium, defined as: ronnameter per century × (1000.0)/(10.0)
   /// </summary>
   public static readonly Velocity QuettameterPerMillennium =
            new ("quettameter per millennium", "Qm/kyr", RonnameterPerCentury, 1000.0 / 10.0);

   /// <summary>
   /// rontometer per nonillion years, defined as: yoctometer per octillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerNonillionYears = new (
                                                                      "rontometer per nonillion years"
                                                                    , "rm/Qyr"
                                                                    , YoctometerPerOctillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// megameter per quadrillion years, defined as: kilometer per trillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerQuadrillionYears = new (
                                                                       "megameter per quadrillion years"
                                                                     , "Mm/Pyr"
                                                                     , KilometerPerTrillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// yottameter per million years, defined as: zettameter per millennium × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerMillionYears = new (
                                                                    "yottameter per million years"
                                                                  , "Ym/Myr"
                                                                  , ZettameterPerMillennium
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// quectometer per octillion years, defined as: rontometer per septillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerOctillionYears = new (
                                                                       "quectometer per octillion years"
                                                                     , "qm/Ryr"
                                                                     , RontometerPerSeptillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// kilometer per quintillion years, defined as: hectometer per quadrillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerQuintillionYears = new (
                                                                       "kilometer per quintillion years"
                                                                     , "km/Eyr"
                                                                     , HectometerPerQuadrillionYears
                                                                     , 10.0 / 1000.0
                                                                      );

   /// <summary>
   /// terameter per trillion years, defined as: gigameter per billion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerTrillionYears = new (
                                                                    "terameter per trillion years"
                                                                  , "Tm/Tyr"
                                                                  , GigameterPerBillionYears
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// dekameter per septillion years, defined as: meter per sextillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerSeptillionYears = new (
                                                                      "dekameter per septillion years"
                                                                    , "dam/Yyr"
                                                                    , MeterPerSextillionYears
                                                                    , 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// hectometer per sextillion years, defined as: dekameter per quintillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerSextillionYears = new (
                                                                       "hectometer per sextillion years"
                                                                     , "hm/Zyr"
                                                                     , DekameterPerQuintillionYears
                                                                     , 10.0 / 1000.0
                                                                      );

   /// <summary>
   /// exameter per billion years, defined as: petameter per million years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerBillionYears = new (
                                                                  "exameter per billion years"
                                                                , "Em/Gyr"
                                                                , PetameterPerMillionYears
                                                                , 1000.0 / 1000.0
                                                                 );

   /// <summary>
   /// rontometer per decillion years, defined as: yoctometer per nonillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RontometerPerDecillionYears = new (
                                                                      "rontometer per decillion years"
                                                                    , "rm/decillion yr"
                                                                    , YoctometerPerNonillionYears
                                                                    , 1.0 / 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// gigameter per quadrillion years, defined as: megameter per trillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerQuadrillionYears = new (
                                                                       "gigameter per quadrillion years"
                                                                     , "Gm/Pyr"
                                                                     , MegameterPerTrillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// ronnameter per million years, defined as: yottameter per millennium × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerMillionYears = new (
                                                                    "ronnameter per million years"
                                                                  , "Rm/Myr"
                                                                  , YottameterPerMillennium
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// yoctometer per tick, defined as: zeptometer per nanosecond × (1.0/1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity YoctometerPerTick = new (
                                                            "yoctometer per tick"
                                                          , "ym/tick"
                                                          , ZeptometerPerNanosecond
                                                          , 1.0 / 1000.0 / 100.0
                                                           );

   /// <summary>
   /// petameter per trillion years, defined as: terameter per billion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerTrillionYears = new (
                                                                    "petameter per trillion years"
                                                                  , "Pm/Tyr"
                                                                  , TerameterPerBillionYears
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// zettameter per billion years, defined as: exameter per million years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerBillionYears = new (
                                                                    "zettameter per billion years"
                                                                  , "Zm/Gyr"
                                                                  , ExameterPerMillionYears
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// quectometer per nonillion years, defined as: rontometer per octillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerNonillionYears = new (
                                                                       "quectometer per nonillion years"
                                                                     , "qm/Qyr"
                                                                     , RontometerPerOctillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// megameter per quintillion years, defined as: kilometer per quadrillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerQuintillionYears = new (
                                                                       "megameter per quintillion years"
                                                                     , "Mm/Eyr"
                                                                     , KilometerPerQuadrillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// dekameter per octillion years, defined as: meter per septillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerOctillionYears =
            new ("dekameter per octillion years", "dam/Ryr", MeterPerSeptillionYears, 10.0 / 1000.0);

   /// <summary>
   /// kilometer per sextillion years, defined as: hectometer per quintillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerSextillionYears = new (
                                                                      "kilometer per sextillion years"
                                                                    , "km/Zyr"
                                                                    , HectometerPerQuintillionYears
                                                                    , 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// hectometer per septillion years, defined as: dekameter per sextillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerSeptillionYears = new (
                                                                       "hectometer per septillion years"
                                                                     , "hm/Yyr"
                                                                     , DekameterPerSextillionYears
                                                                     , 10.0 / 1000.0
                                                                      );

   /// <summary>
   /// quettameter per million years, defined as: ronnameter per millennium × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerMillionYears = new (
                                                                     "quettameter per million years"
                                                                   , "Qm/Myr"
                                                                   , RonnameterPerMillennium
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// terameter per quadrillion years, defined as: gigameter per trillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerQuadrillionYears = new (
                                                                       "terameter per quadrillion years"
                                                                     , "Tm/Pyr"
                                                                     , GigameterPerTrillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// yottameter per billion years, defined as: zettameter per million years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerBillionYears = new (
                                                                    "yottameter per billion years"
                                                                  , "Ym/Gyr"
                                                                  , ZettameterPerMillionYears
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// exameter per trillion years, defined as: petameter per billion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerTrillionYears = new (
                                                                   "exameter per trillion years"
                                                                 , "Em/Tyr"
                                                                 , PetameterPerBillionYears
                                                                 , 1000.0 / 1000.0
                                                                  );

   /// <summary>
   /// quectometer per decillion years, defined as: rontometer per nonillion years × (1.0/1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuectometerPerDecillionYears = new (
                                                                       "quectometer per decillion years"
                                                                     , "qm/decillion yr"
                                                                     , RontometerPerNonillionYears
                                                                     , 1.0 / 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// gigameter per quintillion years, defined as: megameter per quadrillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerQuintillionYears = new (
                                                                       "gigameter per quintillion years"
                                                                     , "Gm/Eyr"
                                                                     , MegameterPerQuadrillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// dekameter per nonillion years, defined as: meter per octillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerNonillionYears =
            new ("dekameter per nonillion years", "dam/Qyr", MeterPerOctillionYears, 10.0 / 1000.0);

   /// <summary>
   /// megameter per sextillion years, defined as: kilometer per quintillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerSextillionYears = new (
                                                                      "megameter per sextillion years"
                                                                    , "Mm/Zyr"
                                                                    , KilometerPerQuintillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// rontometer per tick, defined as: yoctometer per nanosecond × (1.0/1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity RontometerPerTick = new (
                                                            "rontometer per tick"
                                                          , "rm/tick"
                                                          , YoctometerPerNanosecond
                                                          , 1.0 / 1000.0 / 100.0
                                                           );

   /// <summary>
   /// hectometer per octillion years, defined as: dekameter per septillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerOctillionYears = new (
                                                                      "hectometer per octillion years"
                                                                    , "hm/Ryr"
                                                                    , DekameterPerSeptillionYears
                                                                    , 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// kilometer per septillion years, defined as: hectometer per sextillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerSeptillionYears = new (
                                                                      "kilometer per septillion years"
                                                                    , "km/Yyr"
                                                                    , HectometerPerSextillionYears
                                                                    , 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// petameter per quadrillion years, defined as: terameter per trillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerQuadrillionYears = new (
                                                                       "petameter per quadrillion years"
                                                                     , "Pm/Pyr"
                                                                     , TerameterPerTrillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// ronnameter per billion years, defined as: yottameter per million years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerBillionYears = new (
                                                                    "ronnameter per billion years"
                                                                  , "Rm/Gyr"
                                                                  , YottameterPerMillionYears
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// zettameter per trillion years, defined as: exameter per billion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerTrillionYears = new (
                                                                     "zettameter per trillion years"
                                                                   , "Zm/Tyr"
                                                                   , ExameterPerBillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// terameter per quintillion years, defined as: gigameter per quadrillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerQuintillionYears = new (
                                                                       "terameter per quintillion years"
                                                                     , "Tm/Eyr"
                                                                     , GigameterPerQuadrillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// quettameter per billion years, defined as: ronnameter per million years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerBillionYears = new (
                                                                     "quettameter per billion years"
                                                                   , "Qm/Gyr"
                                                                   , RonnameterPerMillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// dekameter per decillion years, defined as: meter per nonillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity DekameterPerDecillionYears = new (
                                                                     "dekameter per decillion years"
                                                                   , "dam/decillion yr"
                                                                   , MeterPerNonillionYears
                                                                   , 10.0 / 1000.0
                                                                    );

   /// <summary>
   /// gigameter per sextillion years, defined as: megameter per quintillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerSextillionYears = new (
                                                                      "gigameter per sextillion years"
                                                                    , "Gm/Zyr"
                                                                    , MegameterPerQuintillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// exameter per quadrillion years, defined as: petameter per trillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerQuadrillionYears = new (
                                                                      "exameter per quadrillion years"
                                                                    , "Em/Pyr"
                                                                    , PetameterPerTrillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// yottameter per trillion years, defined as: zettameter per billion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerTrillionYears = new (
                                                                     "yottameter per trillion years"
                                                                   , "Ym/Tyr"
                                                                   , ZettameterPerBillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// hectometer per nonillion years, defined as: dekameter per octillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerNonillionYears = new (
                                                                      "hectometer per nonillion years"
                                                                    , "hm/Qyr"
                                                                    , DekameterPerOctillionYears
                                                                    , 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// megameter per septillion years, defined as: kilometer per sextillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerSeptillionYears = new (
                                                                      "megameter per septillion years"
                                                                    , "Mm/Yyr"
                                                                    , KilometerPerSextillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// kilometer per octillion years, defined as: hectometer per septillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerOctillionYears = new (
                                                                     "kilometer per octillion years"
                                                                   , "km/Ryr"
                                                                   , HectometerPerSeptillionYears
                                                                   , 10.0 / 1000.0
                                                                    );

   /// <summary>
   /// quectometer per tick, defined as: rontometer per nanosecond × (1.0/1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity QuectometerPerTick = new (
                                                             "quectometer per tick"
                                                           , "qm/tick"
                                                           , RontometerPerNanosecond
                                                           , 1.0 / 1000.0 / 100.0
                                                            );

   /// <summary>
   /// petameter per quintillion years, defined as: terameter per quadrillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerQuintillionYears = new (
                                                                       "petameter per quintillion years"
                                                                     , "Pm/Eyr"
                                                                     , TerameterPerQuadrillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// zettameter per quadrillion years, defined as: exameter per trillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerQuadrillionYears = new (
                                                                        "zettameter per quadrillion years"
                                                                      , "Zm/Pyr"
                                                                      , ExameterPerTrillionYears
                                                                      , 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// ronnameter per trillion years, defined as: yottameter per billion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerTrillionYears = new (
                                                                     "ronnameter per trillion years"
                                                                   , "Rm/Tyr"
                                                                   , YottameterPerBillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// terameter per sextillion years, defined as: gigameter per quintillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerSextillionYears = new (
                                                                      "terameter per sextillion years"
                                                                    , "Tm/Zyr"
                                                                    , GigameterPerQuintillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// hectometer per decillion years, defined as: dekameter per nonillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity HectometerPerDecillionYears = new (
                                                                      "hectometer per decillion years"
                                                                    , "hm/decillion yr"
                                                                    , DekameterPerNonillionYears
                                                                    , 10.0 / 1000.0
                                                                     );

   /// <summary>
   /// gigameter per septillion years, defined as: megameter per sextillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerSeptillionYears = new (
                                                                      "gigameter per septillion years"
                                                                    , "Gm/Yyr"
                                                                    , MegameterPerSextillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// kilometer per nonillion years, defined as: hectometer per octillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerNonillionYears = new (
                                                                     "kilometer per nonillion years"
                                                                   , "km/Qyr"
                                                                   , HectometerPerOctillionYears
                                                                   , 10.0 / 1000.0
                                                                    );

   /// <summary>
   /// megameter per octillion years, defined as: kilometer per septillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerOctillionYears = new (
                                                                     "megameter per octillion years"
                                                                   , "Mm/Ryr"
                                                                   , KilometerPerSeptillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// exameter per quintillion years, defined as: petameter per quadrillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerQuintillionYears = new (
                                                                      "exameter per quintillion years"
                                                                    , "Em/Eyr"
                                                                    , PetameterPerQuadrillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// quettameter per trillion years, defined as: ronnameter per billion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerTrillionYears = new (
                                                                      "quettameter per trillion years"
                                                                    , "Qm/Tyr"
                                                                    , RonnameterPerBillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// yottameter per quadrillion years, defined as: zettameter per trillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerQuadrillionYears = new (
                                                                        "yottameter per quadrillion years"
                                                                      , "Ym/Pyr"
                                                                      , ZettameterPerTrillionYears
                                                                      , 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// dekameter per tick, defined as: meter per nanosecond × (10.0)/(100.0)
   /// </summary>
   public static readonly Velocity DekameterPerTick = new (
                                                           "dekameter per tick"
                                                         , "dam/tick"
                                                         , MeterPerNanosecond
                                                         , 10.0 / 100.0
                                                          );

   /// <summary>
   /// petameter per sextillion years, defined as: terameter per quintillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerSextillionYears = new (
                                                                      "petameter per sextillion years"
                                                                    , "Pm/Zyr"
                                                                    , TerameterPerQuintillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// terameter per septillion years, defined as: gigameter per sextillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerSeptillionYears = new (
                                                                      "terameter per septillion years"
                                                                    , "Tm/Yyr"
                                                                    , GigameterPerSextillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// zettameter per quintillion years, defined as: exameter per quadrillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerQuintillionYears = new (
                                                                        "zettameter per quintillion years"
                                                                      , "Zm/Eyr"
                                                                      , ExameterPerQuadrillionYears
                                                                      , 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// kilometer per decillion years, defined as: hectometer per nonillion years × (10.0)/(1000.0)
   /// </summary>
   public static readonly Velocity KilometerPerDecillionYears = new (
                                                                     "kilometer per decillion years"
                                                                   , "km/decillion yr"
                                                                   , HectometerPerNonillionYears
                                                                   , 10.0 / 1000.0
                                                                    );

   /// <summary>
   /// gigameter per octillion years, defined as: megameter per septillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerOctillionYears = new (
                                                                     "gigameter per octillion years"
                                                                   , "Gm/Ryr"
                                                                   , MegameterPerSeptillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// ronnameter per quadrillion years, defined as: yottameter per trillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerQuadrillionYears = new (
                                                                        "ronnameter per quadrillion years"
                                                                      , "Rm/Pyr"
                                                                      , YottameterPerTrillionYears
                                                                      , 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// megameter per nonillion years, defined as: kilometer per octillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerNonillionYears = new (
                                                                     "megameter per nonillion years"
                                                                   , "Mm/Qyr"
                                                                   , KilometerPerOctillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// exameter per sextillion years, defined as: petameter per quintillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerSextillionYears = new (
                                                                     "exameter per sextillion years"
                                                                   , "Em/Zyr"
                                                                   , PetameterPerQuintillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// yottameter per quintillion years, defined as: zettameter per quadrillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerQuintillionYears = new (
                                                                        "yottameter per quintillion years"
                                                                      , "Ym/Eyr"
                                                                      , ZettameterPerQuadrillionYears
                                                                      , 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// hectometer per tick, defined as: dekameter per nanosecond × (10.0)/(100.0)
   /// </summary>
   public static readonly Velocity HectometerPerTick = new (
                                                            "hectometer per tick"
                                                          , "hm/tick"
                                                          , DekameterPerNanosecond
                                                          , 10.0 / 100.0
                                                           );

   /// <summary>
   /// petameter per septillion years, defined as: terameter per sextillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerSeptillionYears = new (
                                                                      "petameter per septillion years"
                                                                    , "Pm/Yyr"
                                                                    , TerameterPerSextillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// quettameter per quadrillion years, defined as: ronnameter per trillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerQuadrillionYears = new (
                                                                         "quettameter per quadrillion years"
                                                                       , "Qm/Pyr"
                                                                       , RonnameterPerTrillionYears
                                                                       , 1000.0 / 1000.0
                                                                        );

   /// <summary>
   /// terameter per octillion years, defined as: gigameter per septillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerOctillionYears = new (
                                                                     "terameter per octillion years"
                                                                   , "Tm/Ryr"
                                                                   , GigameterPerSeptillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// megameter per decillion years, defined as: kilometer per nonillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity MegameterPerDecillionYears = new (
                                                                     "megameter per decillion years"
                                                                   , "Mm/decillion yr"
                                                                   , KilometerPerNonillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// gigameter per nonillion years, defined as: megameter per octillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerNonillionYears = new (
                                                                     "gigameter per nonillion years"
                                                                   , "Gm/Qyr"
                                                                   , MegameterPerOctillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// zettameter per sextillion years, defined as: exameter per quintillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerSextillionYears = new (
                                                                       "zettameter per sextillion years"
                                                                     , "Zm/Zyr"
                                                                     , ExameterPerQuintillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// ronnameter per quintillion years, defined as: yottameter per quadrillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerQuintillionYears = new (
                                                                        "ronnameter per quintillion years"
                                                                      , "Rm/Eyr"
                                                                      , YottameterPerQuadrillionYears
                                                                      , 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// exameter per septillion years, defined as: petameter per sextillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerSeptillionYears = new (
                                                                     "exameter per septillion years"
                                                                   , "Em/Yyr"
                                                                   , PetameterPerSextillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// kilometer per tick, defined as: hectometer per nanosecond × (10.0)/(100.0)
   /// </summary>
   public static readonly Velocity KilometerPerTick = new (
                                                           "kilometer per tick"
                                                         , "km/tick"
                                                         , HectometerPerNanosecond
                                                         , 10.0 / 100.0
                                                          );

   /// <summary>
   /// petameter per octillion years, defined as: terameter per septillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerOctillionYears = new (
                                                                     "petameter per octillion years"
                                                                   , "Pm/Ryr"
                                                                   , TerameterPerSeptillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// yottameter per sextillion years, defined as: zettameter per quintillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerSextillionYears = new (
                                                                       "yottameter per sextillion years"
                                                                     , "Ym/Zyr"
                                                                     , ZettameterPerQuintillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// terameter per nonillion years, defined as: gigameter per octillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerNonillionYears = new (
                                                                     "terameter per nonillion years"
                                                                   , "Tm/Qyr"
                                                                   , GigameterPerOctillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// gigameter per decillion years, defined as: megameter per nonillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity GigameterPerDecillionYears = new (
                                                                     "gigameter per decillion years"
                                                                   , "Gm/decillion yr"
                                                                   , MegameterPerNonillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// quettameter per quintillion years, defined as: ronnameter per quadrillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerQuintillionYears = new (
                                                                         "quettameter per quintillion years"
                                                                       , "Qm/Eyr"
                                                                       , RonnameterPerQuadrillionYears
                                                                       , 1000.0 / 1000.0
                                                                        );

   /// <summary>
   /// zettameter per septillion years, defined as: exameter per sextillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerSeptillionYears = new (
                                                                       "zettameter per septillion years"
                                                                     , "Zm/Yyr"
                                                                     , ExameterPerSextillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// exameter per octillion years, defined as: petameter per septillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerOctillionYears = new (
                                                                    "exameter per octillion years"
                                                                  , "Em/Ryr"
                                                                  , PetameterPerSeptillionYears
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// ronnameter per sextillion years, defined as: yottameter per quintillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerSextillionYears = new (
                                                                       "ronnameter per sextillion years"
                                                                     , "Rm/Zyr"
                                                                     , YottameterPerQuintillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// megameter per tick, defined as: kilometer per nanosecond × (1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity MegameterPerTick = new (
                                                           "megameter per tick"
                                                         , "Mm/tick"
                                                         , KilometerPerNanosecond
                                                         , 1000.0 / 100.0
                                                          );

   /// <summary>
   /// petameter per nonillion years, defined as: terameter per octillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerNonillionYears = new (
                                                                     "petameter per nonillion years"
                                                                   , "Pm/Qyr"
                                                                   , TerameterPerOctillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// terameter per decillion years, defined as: gigameter per nonillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity TerameterPerDecillionYears = new (
                                                                     "terameter per decillion years"
                                                                   , "Tm/decillion yr"
                                                                   , GigameterPerNonillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// yottameter per septillion years, defined as: zettameter per sextillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerSeptillionYears = new (
                                                                       "yottameter per septillion years"
                                                                     , "Ym/Yyr"
                                                                     , ZettameterPerSextillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// quettameter per sextillion years, defined as: ronnameter per quintillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerSextillionYears = new (
                                                                        "quettameter per sextillion years"
                                                                      , "Qm/Zyr"
                                                                      , RonnameterPerQuintillionYears
                                                                      , 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// zettameter per octillion years, defined as: exameter per septillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerOctillionYears = new (
                                                                      "zettameter per octillion years"
                                                                    , "Zm/Ryr"
                                                                    , ExameterPerSeptillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// exameter per nonillion years, defined as: petameter per octillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerNonillionYears = new (
                                                                    "exameter per nonillion years"
                                                                  , "Em/Qyr"
                                                                  , PetameterPerOctillionYears
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// gigameter per tick, defined as: megameter per nanosecond × (1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity GigameterPerTick = new (
                                                           "gigameter per tick"
                                                         , "Gm/tick"
                                                         , MegameterPerNanosecond
                                                         , 1000.0 / 100.0
                                                          );

   /// <summary>
   /// petameter per decillion years, defined as: terameter per nonillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity PetameterPerDecillionYears = new (
                                                                     "petameter per decillion years"
                                                                   , "Pm/decillion yr"
                                                                   , TerameterPerNonillionYears
                                                                   , 1000.0 / 1000.0
                                                                    );

   /// <summary>
   /// ronnameter per septillion years, defined as: yottameter per sextillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerSeptillionYears = new (
                                                                       "ronnameter per septillion years"
                                                                     , "Rm/Yyr"
                                                                     , YottameterPerSextillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// yottameter per octillion years, defined as: zettameter per septillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerOctillionYears = new (
                                                                      "yottameter per octillion years"
                                                                    , "Ym/Ryr"
                                                                    , ZettameterPerSeptillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// zettameter per nonillion years, defined as: exameter per octillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerNonillionYears = new (
                                                                      "zettameter per nonillion years"
                                                                    , "Zm/Qyr"
                                                                    , ExameterPerOctillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// quettameter per septillion years, defined as: ronnameter per sextillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerSeptillionYears = new (
                                                                        "quettameter per septillion years"
                                                                      , "Qm/Yyr"
                                                                      , RonnameterPerSextillionYears
                                                                      , 1000.0 / 1000.0
                                                                       );

   /// <summary>
   /// exameter per decillion years, defined as: petameter per nonillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ExameterPerDecillionYears = new (
                                                                    "exameter per decillion years"
                                                                  , "Em/decillion yr"
                                                                  , PetameterPerNonillionYears
                                                                  , 1000.0 / 1000.0
                                                                   );

   /// <summary>
   /// terameter per tick, defined as: gigameter per nanosecond × (1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity TerameterPerTick = new (
                                                           "terameter per tick"
                                                         , "Tm/tick"
                                                         , GigameterPerNanosecond
                                                         , 1000.0 / 100.0
                                                          );

   /// <summary>
   /// ronnameter per octillion years, defined as: yottameter per septillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerOctillionYears = new (
                                                                      "ronnameter per octillion years"
                                                                    , "Rm/Ryr"
                                                                    , YottameterPerSeptillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// yottameter per nonillion years, defined as: zettameter per octillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerNonillionYears = new (
                                                                      "yottameter per nonillion years"
                                                                    , "Ym/Qyr"
                                                                    , ZettameterPerOctillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// zettameter per decillion years, defined as: exameter per nonillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity ZettameterPerDecillionYears = new (
                                                                      "zettameter per decillion years"
                                                                    , "Zm/decillion yr"
                                                                    , ExameterPerNonillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// petameter per tick, defined as: terameter per nanosecond × (1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity PetameterPerTick = new (
                                                           "petameter per tick"
                                                         , "Pm/tick"
                                                         , TerameterPerNanosecond
                                                         , 1000.0 / 100.0
                                                          );

   /// <summary>
   /// quettameter per octillion years, defined as: ronnameter per septillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerOctillionYears = new (
                                                                       "quettameter per octillion years"
                                                                     , "Qm/Ryr"
                                                                     , RonnameterPerSeptillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// ronnameter per nonillion years, defined as: yottameter per octillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerNonillionYears = new (
                                                                      "ronnameter per nonillion years"
                                                                    , "Rm/Qyr"
                                                                    , YottameterPerOctillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// yottameter per decillion years, defined as: zettameter per nonillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity YottameterPerDecillionYears = new (
                                                                      "yottameter per decillion years"
                                                                    , "Ym/decillion yr"
                                                                    , ZettameterPerNonillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// exameter per tick, defined as: petameter per nanosecond × (1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity ExameterPerTick = new (
                                                          "exameter per tick"
                                                        , "Em/tick"
                                                        , PetameterPerNanosecond
                                                        , 1000.0 / 100.0
                                                         );

   /// <summary>
   /// quettameter per nonillion years, defined as: ronnameter per octillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerNonillionYears = new (
                                                                       "quettameter per nonillion years"
                                                                     , "Qm/Qyr"
                                                                     , RonnameterPerOctillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// ronnameter per decillion years, defined as: yottameter per nonillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity RonnameterPerDecillionYears = new (
                                                                      "ronnameter per decillion years"
                                                                    , "Rm/decillion yr"
                                                                    , YottameterPerNonillionYears
                                                                    , 1000.0 / 1000.0
                                                                     );

   /// <summary>
   /// zettameter per tick, defined as: exameter per nanosecond × (1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity ZettameterPerTick = new (
                                                            "zettameter per tick"
                                                          , "Zm/tick"
                                                          , ExameterPerNanosecond
                                                          , 1000.0 / 100.0
                                                           );

   /// <summary>
   /// quettameter per decillion years, defined as: ronnameter per nonillion years × (1000.0)/(1000.0)
   /// </summary>
   public static readonly Velocity QuettameterPerDecillionYears = new (
                                                                       "quettameter per decillion years"
                                                                     , "Qm/decillion yr"
                                                                     , RonnameterPerNonillionYears
                                                                     , 1000.0 / 1000.0
                                                                      );

   /// <summary>
   /// yottameter per tick, defined as: zettameter per nanosecond × (1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity YottameterPerTick = new (
                                                            "yottameter per tick"
                                                          , "Ym/tick"
                                                          , ZettameterPerNanosecond
                                                          , 1000.0 / 100.0
                                                           );

   /// <summary>
   /// ronnameter per tick, defined as: yottameter per nanosecond × (1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity RonnameterPerTick = new (
                                                            "ronnameter per tick"
                                                          , "Rm/tick"
                                                          , YottameterPerNanosecond
                                                          , 1000.0 / 100.0
                                                           );

   /// <summary>
   /// quettameter per tick, defined as: ronnameter per nanosecond × (1000.0)/(100.0)
   /// </summary>
   public static readonly Velocity QuettameterPerTick = new (
                                                             "quettameter per tick"
                                                           , "Qm/tick"
                                                           , RonnameterPerNanosecond
                                                           , 1000.0 / 100.0
                                                            );

   /// <summary>
   /// meter per planck-time, defined as: meter per microsecond × (1.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity MeterPerPlanckTime = new (
                                                             "meter per planck-time"
                                                           , "m/tₚ"
                                                           , MeterPerMicrosecond
                                                           , 1.0 / 5.391247E-38
                                                            );

   /// <summary>
   /// decimeter per planck-time, defined as: meter per microsecond × (1.0/10.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity DecimeterPerPlanckTime = new (
                                                                 "decimeter per planck-time"
                                                               , "dm/tₚ"
                                                               , MeterPerMicrosecond
                                                               , 1.0 / 10.0 / 5.391247E-38
                                                                );

   /// <summary>
   /// centimeter per planck-time, defined as: decimeter per microsecond × (1.0/10.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity CentimeterPerPlanckTime = new (
                                                                  "centimeter per planck-time"
                                                                , "cm/tₚ"
                                                                , DecimeterPerMicrosecond
                                                                , 1.0 / 10.0 / 5.391247E-38
                                                                 );

   /// <summary>
   /// millimeter per planck-time, defined as: centimeter per microsecond × (1.0/10.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity MillimeterPerPlanckTime = new (
                                                                  "millimeter per planck-time"
                                                                , "mm/tₚ"
                                                                , CentimeterPerMicrosecond
                                                                , 1.0 / 10.0 / 5.391247E-38
                                                                 );

   /// <summary>
   /// micrometer per planck-time, defined as: millimeter per microsecond × (1.0/1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity MicrometerPerPlanckTime = new (
                                                                  "micrometer per planck-time"
                                                                , "μm/tₚ"
                                                                , MillimeterPerMicrosecond
                                                                , 1.0 / 1000.0 / 5.391247E-38
                                                                 );

   /// <summary>
   /// nanometer per planck-time, defined as: micrometer per microsecond × (1.0/1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity NanometerPerPlanckTime = new (
                                                                 "nanometer per planck-time"
                                                               , "nm/tₚ"
                                                               , MicrometerPerMicrosecond
                                                               , 1.0 / 1000.0 / 5.391247E-38
                                                                );

   /// <summary>
   /// picometer per planck-time, defined as: nanometer per microsecond × (1.0/1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity PicometerPerPlanckTime = new (
                                                                 "picometer per planck-time"
                                                               , "pm/tₚ"
                                                               , NanometerPerMicrosecond
                                                               , 1.0 / 1000.0 / 5.391247E-38
                                                                );

   /// <summary>
   /// femtometer per planck-time, defined as: picometer per microsecond × (1.0/1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity FemtometerPerPlanckTime = new (
                                                                  "femtometer per planck-time"
                                                                , "fm/tₚ"
                                                                , PicometerPerMicrosecond
                                                                , 1.0 / 1000.0 / 5.391247E-38
                                                                 );

   /// <summary>
   /// attometer per planck-time, defined as: femtometer per microsecond × (1.0/1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity AttometerPerPlanckTime = new (
                                                                 "attometer per planck-time"
                                                               , "am/tₚ"
                                                               , FemtometerPerMicrosecond
                                                               , 1.0 / 1000.0 / 5.391247E-38
                                                                );

   /// <summary>
   /// zeptometer per planck-time, defined as: attometer per microsecond × (1.0/1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity ZeptometerPerPlanckTime = new (
                                                                  "zeptometer per planck-time"
                                                                , "zm/tₚ"
                                                                , AttometerPerMicrosecond
                                                                , 1.0 / 1000.0 / 5.391247E-38
                                                                 );

   /// <summary>
   /// yoctometer per planck-time, defined as: zeptometer per microsecond × (1.0/1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity YoctometerPerPlanckTime = new (
                                                                  "yoctometer per planck-time"
                                                                , "ym/tₚ"
                                                                , ZeptometerPerMicrosecond
                                                                , 1.0 / 1000.0 / 5.391247E-38
                                                                 );

   /// <summary>
   /// rontometer per planck-time, defined as: yoctometer per microsecond × (1.0/1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity RontometerPerPlanckTime = new (
                                                                  "rontometer per planck-time"
                                                                , "rm/tₚ"
                                                                , YoctometerPerMicrosecond
                                                                , 1.0 / 1000.0 / 5.391247E-38
                                                                 );

   /// <summary>
   /// quectometer per planck-time, defined as: rontometer per microsecond × (1.0/1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity QuectometerPerPlanckTime = new (
                                                                   "quectometer per planck-time"
                                                                 , "qm/tₚ"
                                                                 , RontometerPerMicrosecond
                                                                 , 1.0 / 1000.0 / 5.391247E-38
                                                                  );

   /// <summary>
   /// hectometer per planck-time, defined as: dekameter per microsecond × (10.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity HectometerPerPlanckTime = new (
                                                                  "hectometer per planck-time"
                                                                , "hm/tₚ"
                                                                , DekameterPerMicrosecond
                                                                , 10.0 / 5.391247E-38
                                                                 );

   /// <summary>
   /// kilometer per planck-time, defined as: hectometer per microsecond × (10.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity KilometerPerPlanckTime = new (
                                                                 "kilometer per planck-time"
                                                               , "km/tₚ"
                                                               , HectometerPerMicrosecond
                                                               , 10.0 / 5.391247E-38
                                                                );

   /// <summary>
   /// megameter per planck-time, defined as: kilometer per microsecond × (1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity MegameterPerPlanckTime = new (
                                                                 "megameter per planck-time"
                                                               , "Mm/tₚ"
                                                               , KilometerPerMicrosecond
                                                               , 1000.0 / 5.391247E-38
                                                                );

   /// <summary>
   /// gigameter per planck-time, defined as: megameter per microsecond × (1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity GigameterPerPlanckTime = new (
                                                                 "gigameter per planck-time"
                                                               , "Gm/tₚ"
                                                               , MegameterPerMicrosecond
                                                               , 1000.0 / 5.391247E-38
                                                                );

   /// <summary>
   /// terameter per planck-time, defined as: gigameter per microsecond × (1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity TerameterPerPlanckTime = new (
                                                                 "terameter per planck-time"
                                                               , "Tm/tₚ"
                                                               , GigameterPerMicrosecond
                                                               , 1000.0 / 5.391247E-38
                                                                );

   /// <summary>
   /// petameter per planck-time, defined as: terameter per microsecond × (1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity PetameterPerPlanckTime = new (
                                                                 "petameter per planck-time"
                                                               , "Pm/tₚ"
                                                               , TerameterPerMicrosecond
                                                               , 1000.0 / 5.391247E-38
                                                                );

   /// <summary>
   /// exameter per planck-time, defined as: petameter per microsecond × (1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity ExameterPerPlanckTime = new (
                                                                "exameter per planck-time"
                                                              , "Em/tₚ"
                                                              , PetameterPerMicrosecond
                                                              , 1000.0 / 5.391247E-38
                                                               );

   /// <summary>
   /// zettameter per planck-time, defined as: exameter per microsecond × (1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity ZettameterPerPlanckTime = new (
                                                                  "zettameter per planck-time"
                                                                , "Zm/tₚ"
                                                                , ExameterPerMicrosecond
                                                                , 1000.0 / 5.391247E-38
                                                                 );

   /// <summary>
   /// yottameter per planck-time, defined as: zettameter per microsecond × (1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity YottameterPerPlanckTime = new (
                                                                  "yottameter per planck-time"
                                                                , "Ym/tₚ"
                                                                , ZettameterPerMicrosecond
                                                                , 1000.0 / 5.391247E-38
                                                                 );

   /// <summary>
   /// ronnameter per planck-time, defined as: yottameter per microsecond × (1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity RonnameterPerPlanckTime = new (
                                                                  "ronnameter per planck-time"
                                                                , "Rm/tₚ"
                                                                , YottameterPerMicrosecond
                                                                , 1000.0 / 5.391247E-38
                                                                 );

   /// <summary>
   /// quettameter per planck-time, defined as: ronnameter per microsecond × (1000.0)/(5.391247E-38)
   /// </summary>
   public static readonly Velocity QuettameterPerPlanckTime = new (
                                                                   "quettameter per planck-time"
                                                                 , "Qm/tₚ"
                                                                 , RonnameterPerMicrosecond
                                                                 , 1000.0 / 5.391247E-38
                                                                  );
}
