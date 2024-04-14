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
   /// meter per second, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this
   /// type.)
   /// </summary>
   public static readonly Velocity MeterPerSecond = new("meter per second", "m/s", system: "SI");
   
   /// <summary>
   /// meter per decisecond defined such that: meter per second = m/ds × (1.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MeterPerDecisecond = new("meter per decisecond", "m/ds", MeterPerSecond, 1.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// decimeter per second defined such that: meter per second = dm/s × (1.0/10.0)/(1.0).
   /// </summary>
   public static readonly Velocity DecimeterPerSecond = new("decimeter per second", "dm/s", MeterPerSecond, 1.0 / 10.0 / 1.0, system: "SI");
   
   /// <summary>
   /// meter per centisecond defined such that: meter per decisecond = m/cs × (1.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MeterPerCentisecond = new("meter per centisecond", "m/cs", MeterPerDecisecond, 1.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// decimeter per decisecond defined such that: meter per second = dm/ds × (1.0/10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity DecimeterPerDecisecond = new("decimeter per decisecond", "dm/ds", MeterPerSecond, 1.0 / 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// centimeter per second defined such that: decimeter per second = cm/s × (1.0/10.0)/(1.0).
   /// </summary>
   public static readonly Velocity CentimeterPerSecond = new("centimeter per second", "cm/s", DecimeterPerSecond, 1.0 / 10.0 / 1.0, system: "SI");
   
   /// <summary>
   /// meter per millisecond defined such that: meter per centisecond = m/ms × (1.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MeterPerMillisecond = new("meter per millisecond", "m/ms", MeterPerCentisecond, 1.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// decimeter per centisecond defined such that: meter per decisecond = dm/cs × (1.0/10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity DecimeterPerCentisecond = new("decimeter per centisecond", "dm/cs", MeterPerDecisecond, 1.0 / 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// centimeter per decisecond defined such that: decimeter per second = cm/ds × (1.0/10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity CentimeterPerDecisecond = new("centimeter per decisecond", "cm/ds", DecimeterPerSecond, 1.0 / 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// millimeter per second defined such that: centimeter per second = mm/s × (1.0/10.0)/(1.0).
   /// </summary>
   public static readonly Velocity MillimeterPerSecond = new("millimeter per second", "mm/s", CentimeterPerSecond, 1.0 / 10.0 / 1.0, system: "SI");
   
   /// <summary>
   /// meter per microsecond defined such that: meter per millisecond = m/μs × (1.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MeterPerMicrosecond = new("meter per microsecond", "m/μs", MeterPerMillisecond, 1.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// decimeter per millisecond defined such that: meter per centisecond = dm/ms × (1.0/10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity DecimeterPerMillisecond = new("decimeter per millisecond", "dm/ms", MeterPerCentisecond, 1.0 / 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// centimeter per centisecond defined such that: decimeter per decisecond = cm/cs × (1.0/10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity CentimeterPerCentisecond =
      new("centimeter per centisecond", "cm/cs", DecimeterPerDecisecond, 1.0 / 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// millimeter per decisecond defined such that: centimeter per second = mm/ds × (1.0/10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MillimeterPerDecisecond = new("millimeter per decisecond", "mm/ds", CentimeterPerSecond, 1.0 / 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// micrometer per second defined such that: millimeter per second = μm/s × (1.0/1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity MicrometerPerSecond = new("micrometer per second", "μm/s", MillimeterPerSecond, 1.0 / 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// meter per nanosecond defined such that: meter per microsecond = m/ns × (1.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MeterPerNanosecond = new("meter per nanosecond", "m/ns", MeterPerMicrosecond, 1.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// decimeter per microsecond defined such that: meter per millisecond = dm/μs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerMicrosecond =
      new("decimeter per microsecond", "dm/μs", MeterPerMillisecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// centimeter per millisecond defined such that: decimeter per centisecond = cm/ms × (1.0/10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity CentimeterPerMillisecond =
      new("centimeter per millisecond", "cm/ms", DecimeterPerCentisecond, 1.0 / 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// millimeter per centisecond defined such that: centimeter per decisecond = mm/cs × (1.0/10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MillimeterPerCentisecond =
      new("millimeter per centisecond", "mm/cs", CentimeterPerDecisecond, 1.0 / 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// micrometer per decisecond defined such that: millimeter per second = μm/ds × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MicrometerPerDecisecond =
      new("micrometer per decisecond", "μm/ds", MillimeterPerSecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// nanometer per second defined such that: micrometer per second = nm/s × (1.0/1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity NanometerPerSecond = new("nanometer per second", "nm/s", MicrometerPerSecond, 1.0 / 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// meter per picosecond defined such that: meter per nanosecond = m/ps × (1.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MeterPerPicosecond = new("meter per picosecond", "m/ps", MeterPerNanosecond, 1.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// decimeter per nanosecond defined such that: meter per microsecond = dm/ns × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerNanosecond = new("decimeter per nanosecond", "dm/ns", MeterPerMicrosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// centimeter per microsecond defined such that: decimeter per millisecond = cm/μs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerMicrosecond =
      new("centimeter per microsecond", "cm/μs", DecimeterPerMillisecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// millimeter per millisecond defined such that: centimeter per centisecond = mm/ms × (1.0/10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MillimeterPerMillisecond =
      new("millimeter per millisecond", "mm/ms", CentimeterPerCentisecond, 1.0 / 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// micrometer per centisecond defined such that: millimeter per decisecond = μm/cs × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MicrometerPerCentisecond =
      new("micrometer per centisecond", "μm/cs", MillimeterPerDecisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// nanometer per decisecond defined such that: micrometer per second = nm/ds × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity NanometerPerDecisecond = new("nanometer per decisecond", "nm/ds", MicrometerPerSecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// picometer per second defined such that: nanometer per second = pm/s × (1.0/1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity PicometerPerSecond = new("picometer per second", "pm/s", NanometerPerSecond, 1.0 / 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// meter per femtosecond defined such that: meter per picosecond = m/fs × (1.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MeterPerFemtosecond = new("meter per femtosecond", "m/fs", MeterPerPicosecond, 1.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// decimeter per picosecond defined such that: meter per nanosecond = dm/ps × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerPicosecond = new("decimeter per picosecond", "dm/ps", MeterPerNanosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// centimeter per nanosecond defined such that: decimeter per microsecond = cm/ns × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerNanosecond =
      new("centimeter per nanosecond", "cm/ns", DecimeterPerMicrosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// millimeter per microsecond defined such that: centimeter per millisecond = mm/μs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerMicrosecond =
      new("millimeter per microsecond", "mm/μs", CentimeterPerMillisecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// micrometer per millisecond defined such that: millimeter per centisecond = μm/ms × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MicrometerPerMillisecond =
      new("micrometer per millisecond", "μm/ms", MillimeterPerCentisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// nanometer per centisecond defined such that: micrometer per decisecond = nm/cs × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity NanometerPerCentisecond =
      new("nanometer per centisecond", "nm/cs", MicrometerPerDecisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// picometer per decisecond defined such that: nanometer per second = pm/ds × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PicometerPerDecisecond = new("picometer per decisecond", "pm/ds", NanometerPerSecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// femtometer per second defined such that: picometer per second = fm/s × (1.0/1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity FemtometerPerSecond = new("femtometer per second", "fm/s", PicometerPerSecond, 1.0 / 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// meter per attosecond defined such that: meter per femtosecond = m/as × (1.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MeterPerAttosecond = new("meter per attosecond", "m/as", MeterPerFemtosecond, 1.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// decimeter per femtosecond defined such that: meter per picosecond = dm/fs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerFemtosecond =
      new("decimeter per femtosecond", "dm/fs", MeterPerPicosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// centimeter per picosecond defined such that: decimeter per nanosecond = cm/ps × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerPicosecond =
      new("centimeter per picosecond", "cm/ps", DecimeterPerNanosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// millimeter per nanosecond defined such that: centimeter per microsecond = mm/ns × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerNanosecond =
      new("millimeter per nanosecond", "mm/ns", CentimeterPerMicrosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// micrometer per microsecond defined such that: millimeter per millisecond = μm/μs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerMicrosecond =
      new("micrometer per microsecond", "μm/μs", MillimeterPerMillisecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// nanometer per millisecond defined such that: micrometer per centisecond = nm/ms × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity NanometerPerMillisecond =
      new("nanometer per millisecond", "nm/ms", MicrometerPerCentisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// picometer per centisecond defined such that: nanometer per decisecond = pm/cs × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PicometerPerCentisecond =
      new("picometer per centisecond", "pm/cs", NanometerPerDecisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// femtometer per decisecond defined such that: picometer per second = fm/ds × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FemtometerPerDecisecond =
      new("femtometer per decisecond", "fm/ds", PicometerPerSecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// attometer per second defined such that: femtometer per second = am/s × (1.0/1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity AttometerPerSecond = new("attometer per second", "am/s", FemtometerPerSecond, 1.0 / 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// meter per zeptosecond defined such that: meter per attosecond = m/zs × (1.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MeterPerZeptosecond = new("meter per zeptosecond", "m/zs", MeterPerAttosecond, 1.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// decimeter per attosecond defined such that: meter per femtosecond = dm/as × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerAttosecond = new("decimeter per attosecond", "dm/as", MeterPerFemtosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// centimeter per femtosecond defined such that: decimeter per picosecond = cm/fs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerFemtosecond =
      new("centimeter per femtosecond", "cm/fs", DecimeterPerPicosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// millimeter per picosecond defined such that: centimeter per nanosecond = mm/ps × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerPicosecond =
      new("millimeter per picosecond", "mm/ps", CentimeterPerNanosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// micrometer per nanosecond defined such that: millimeter per microsecond = μm/ns × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerNanosecond =
      new("micrometer per nanosecond", "μm/ns", MillimeterPerMicrosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// nanometer per microsecond defined such that: micrometer per millisecond = nm/μs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerMicrosecond =
      new("nanometer per microsecond", "nm/μs", MicrometerPerMillisecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// picometer per millisecond defined such that: nanometer per centisecond = pm/ms × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PicometerPerMillisecond =
      new("picometer per millisecond", "pm/ms", NanometerPerCentisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// femtometer per centisecond defined such that: picometer per decisecond = fm/cs × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FemtometerPerCentisecond =
      new("femtometer per centisecond", "fm/cs", PicometerPerDecisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// attometer per decisecond defined such that: femtometer per second = am/ds × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity AttometerPerDecisecond = new("attometer per decisecond", "am/ds", FemtometerPerSecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// zeptometer per second defined such that: attometer per second = zm/s × (1.0/1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerSecond = new("zeptometer per second", "zm/s", AttometerPerSecond, 1.0 / 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// meter per yoctosecond defined such that: meter per zeptosecond = m/ys × (1.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MeterPerYoctosecond = new("meter per yoctosecond", "m/ys", MeterPerZeptosecond, 1.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// decimeter per zeptosecond defined such that: meter per attosecond = dm/zs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerZeptosecond =
      new("decimeter per zeptosecond", "dm/zs", MeterPerAttosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// centimeter per attosecond defined such that: decimeter per femtosecond = cm/as × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerAttosecond =
      new("centimeter per attosecond", "cm/as", DecimeterPerFemtosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// millimeter per femtosecond defined such that: centimeter per picosecond = mm/fs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerFemtosecond =
      new("millimeter per femtosecond", "mm/fs", CentimeterPerPicosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// micrometer per picosecond defined such that: millimeter per nanosecond = μm/ps × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerPicosecond =
      new("micrometer per picosecond", "μm/ps", MillimeterPerNanosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// nanometer per nanosecond defined such that: micrometer per microsecond = nm/ns × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerNanosecond =
      new("nanometer per nanosecond", "nm/ns", MicrometerPerMicrosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// picometer per microsecond defined such that: nanometer per millisecond = pm/μs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerMicrosecond =
      new("picometer per microsecond", "pm/μs", NanometerPerMillisecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// femtometer per millisecond defined such that: picometer per centisecond = fm/ms × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FemtometerPerMillisecond =
      new("femtometer per millisecond", "fm/ms", PicometerPerCentisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// attometer per centisecond defined such that: femtometer per decisecond = am/cs × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity AttometerPerCentisecond =
      new("attometer per centisecond", "am/cs", FemtometerPerDecisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// zeptometer per decisecond defined such that: attometer per second = zm/ds × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerDecisecond =
      new("zeptometer per decisecond", "zm/ds", AttometerPerSecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// yoctometer per second defined such that: zeptometer per second = ym/s × (1.0/1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity YoctometerPerSecond = new("yoctometer per second", "ym/s", ZeptometerPerSecond, 1.0 / 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// meter per rontosecond defined such that: meter per yoctosecond = m/rs × (1.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MeterPerRontosecond = new("meter per rontosecond", "m/rs", MeterPerYoctosecond, 1.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// decimeter per yoctosecond defined such that: meter per zeptosecond = dm/ys × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerYoctosecond =
      new("decimeter per yoctosecond", "dm/ys", MeterPerZeptosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// centimeter per zeptosecond defined such that: decimeter per attosecond = cm/zs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerZeptosecond =
      new("centimeter per zeptosecond", "cm/zs", DecimeterPerAttosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// millimeter per attosecond defined such that: centimeter per femtosecond = mm/as × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerAttosecond =
      new("millimeter per attosecond", "mm/as", CentimeterPerFemtosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// micrometer per femtosecond defined such that: millimeter per picosecond = μm/fs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerFemtosecond =
      new("micrometer per femtosecond", "μm/fs", MillimeterPerPicosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// nanometer per picosecond defined such that: micrometer per nanosecond = nm/ps × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerPicosecond =
      new("nanometer per picosecond", "nm/ps", MicrometerPerNanosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// picometer per nanosecond defined such that: nanometer per microsecond = pm/ns × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerNanosecond =
      new("picometer per nanosecond", "pm/ns", NanometerPerMicrosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// femtometer per microsecond defined such that: picometer per millisecond = fm/μs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerMicrosecond =
      new("femtometer per microsecond", "fm/μs", PicometerPerMillisecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// attometer per millisecond defined such that: femtometer per centisecond = am/ms × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity AttometerPerMillisecond =
      new("attometer per millisecond", "am/ms", FemtometerPerCentisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// zeptometer per centisecond defined such that: attometer per decisecond = zm/cs × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerCentisecond =
      new("zeptometer per centisecond", "zm/cs", AttometerPerDecisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// yoctometer per decisecond defined such that: zeptometer per second = ym/ds × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YoctometerPerDecisecond =
      new("yoctometer per decisecond", "ym/ds", ZeptometerPerSecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// rontometer per second defined such that: yoctometer per second = rm/s × (1.0/1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity RontometerPerSecond = new("rontometer per second", "rm/s", YoctometerPerSecond, 1.0 / 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// meter per quectosecond defined such that: meter per rontosecond = m/qs × (1.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MeterPerQuectosecond = new("meter per quectosecond", "m/qs", MeterPerRontosecond, 1.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// decimeter per rontosecond defined such that: meter per yoctosecond = dm/rs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerRontosecond =
      new("decimeter per rontosecond", "dm/rs", MeterPerYoctosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// centimeter per yoctosecond defined such that: decimeter per zeptosecond = cm/ys × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerYoctosecond =
      new("centimeter per yoctosecond", "cm/ys", DecimeterPerZeptosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// millimeter per zeptosecond defined such that: centimeter per attosecond = mm/zs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerZeptosecond =
      new("millimeter per zeptosecond", "mm/zs", CentimeterPerAttosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// micrometer per attosecond defined such that: millimeter per femtosecond = μm/as × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerAttosecond =
      new("micrometer per attosecond", "μm/as", MillimeterPerFemtosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// nanometer per femtosecond defined such that: micrometer per picosecond = nm/fs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerFemtosecond =
      new("nanometer per femtosecond", "nm/fs", MicrometerPerPicosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// picometer per picosecond defined such that: nanometer per nanosecond = pm/ps × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerPicosecond =
      new("picometer per picosecond", "pm/ps", NanometerPerNanosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// femtometer per nanosecond defined such that: picometer per microsecond = fm/ns × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerNanosecond =
      new("femtometer per nanosecond", "fm/ns", PicometerPerMicrosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// attometer per microsecond defined such that: femtometer per millisecond = am/μs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerMicrosecond =
      new("attometer per microsecond", "am/μs", FemtometerPerMillisecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zeptometer per millisecond defined such that: attometer per centisecond = zm/ms × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerMillisecond =
      new("zeptometer per millisecond", "zm/ms", AttometerPerCentisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// yoctometer per centisecond defined such that: zeptometer per decisecond = ym/cs × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YoctometerPerCentisecond =
      new("yoctometer per centisecond", "ym/cs", ZeptometerPerDecisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// rontometer per decisecond defined such that: yoctometer per second = rm/ds × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity RontometerPerDecisecond =
      new("rontometer per decisecond", "rm/ds", YoctometerPerSecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// quectometer per second defined such that: rontometer per second = qm/s × (1.0/1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity QuectometerPerSecond = new("quectometer per second", "qm/s", RontometerPerSecond, 1.0 / 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// dekameter per second defined such that: meter per second = dam/s × (10.0)/(1.0).
   /// </summary>
   public static readonly Velocity DekameterPerSecond = new("dekameter per second", "dam/s", MeterPerSecond, 10.0 / 1.0, system: "SI");
   
   /// <summary>
   /// dekameter per planck-time defined such that: meter per microsecond = dam/tₚ × (10.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity DekameterPerPlanckTime = new("dekameter per planck-time", "dam/tₚ", MeterPerMicrosecond, 10.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// decimeter per quectosecond defined such that: meter per rontosecond = dm/qs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerQuectosecond =
      new("decimeter per quectosecond", "dm/qs", MeterPerRontosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// centimeter per rontosecond defined such that: decimeter per yoctosecond = cm/rs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerRontosecond =
      new("centimeter per rontosecond", "cm/rs", DecimeterPerYoctosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// millimeter per yoctosecond defined such that: centimeter per zeptosecond = mm/ys × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerYoctosecond =
      new("millimeter per yoctosecond", "mm/ys", CentimeterPerZeptosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// micrometer per zeptosecond defined such that: millimeter per attosecond = μm/zs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerZeptosecond =
      new("micrometer per zeptosecond", "μm/zs", MillimeterPerAttosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// nanometer per attosecond defined such that: micrometer per femtosecond = nm/as × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerAttosecond =
      new("nanometer per attosecond", "nm/as", MicrometerPerFemtosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// picometer per femtosecond defined such that: nanometer per picosecond = pm/fs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerFemtosecond =
      new("picometer per femtosecond", "pm/fs", NanometerPerPicosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// femtometer per picosecond defined such that: picometer per nanosecond = fm/ps × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerPicosecond =
      new("femtometer per picosecond", "fm/ps", PicometerPerNanosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// attometer per nanosecond defined such that: femtometer per microsecond = am/ns × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerNanosecond =
      new("attometer per nanosecond", "am/ns", FemtometerPerMicrosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zeptometer per microsecond defined such that: attometer per millisecond = zm/μs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerMicrosecond =
      new("zeptometer per microsecond", "zm/μs", AttometerPerMillisecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yoctometer per millisecond defined such that: zeptometer per centisecond = ym/ms × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YoctometerPerMillisecond =
      new("yoctometer per millisecond", "ym/ms", ZeptometerPerCentisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// rontometer per centisecond defined such that: yoctometer per decisecond = rm/cs × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity RontometerPerCentisecond =
      new("rontometer per centisecond", "rm/cs", YoctometerPerDecisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// quectometer per decisecond defined such that: rontometer per second = qm/ds × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity QuectometerPerDecisecond =
      new("quectometer per decisecond", "qm/ds", RontometerPerSecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// hectometer per second defined such that: dekameter per second = hm/s × (10.0)/(1.0).
   /// </summary>
   public static readonly Velocity HectometerPerSecond = new("hectometer per second", "hm/s", DekameterPerSecond, 10.0 / 1.0, system: "SI");
   
   /// <summary>
   /// dekameter per decisecond defined such that: meter per second = dam/ds × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity DekameterPerDecisecond = new("dekameter per decisecond", "dam/ds", MeterPerSecond, 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// centimeter per quectosecond defined such that: decimeter per rontosecond = cm/qs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerQuectosecond =
      new("centimeter per quectosecond", "cm/qs", DecimeterPerRontosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// millimeter per rontosecond defined such that: centimeter per yoctosecond = mm/rs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerRontosecond =
      new("millimeter per rontosecond", "mm/rs", CentimeterPerYoctosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// micrometer per yoctosecond defined such that: millimeter per zeptosecond = μm/ys × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerYoctosecond =
      new("micrometer per yoctosecond", "μm/ys", MillimeterPerZeptosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// nanometer per zeptosecond defined such that: micrometer per attosecond = nm/zs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerZeptosecond =
      new("nanometer per zeptosecond", "nm/zs", MicrometerPerAttosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// picometer per attosecond defined such that: nanometer per femtosecond = pm/as × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerAttosecond =
      new("picometer per attosecond", "pm/as", NanometerPerFemtosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// femtometer per femtosecond defined such that: picometer per picosecond = fm/fs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerFemtosecond =
      new("femtometer per femtosecond", "fm/fs", PicometerPerPicosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// attometer per picosecond defined such that: femtometer per nanosecond = am/ps × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerPicosecond =
      new("attometer per picosecond", "am/ps", FemtometerPerNanosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zeptometer per nanosecond defined such that: attometer per microsecond = zm/ns × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerNanosecond =
      new("zeptometer per nanosecond", "zm/ns", AttometerPerMicrosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yoctometer per microsecond defined such that: zeptometer per millisecond = ym/μs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerMicrosecond =
      new("yoctometer per microsecond", "ym/μs", ZeptometerPerMillisecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// rontometer per millisecond defined such that: yoctometer per centisecond = rm/ms × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity RontometerPerMillisecond =
      new("rontometer per millisecond", "rm/ms", YoctometerPerCentisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// quectometer per centisecond defined such that: rontometer per decisecond = qm/cs × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity QuectometerPerCentisecond =
      new("quectometer per centisecond", "qm/cs", RontometerPerDecisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// kilometer per second defined such that: hectometer per second = km/s × (10.0)/(1.0).
   /// </summary>
   public static readonly Velocity KilometerPerSecond = new("kilometer per second", "km/s", HectometerPerSecond, 10.0 / 1.0, system: "SI");
   
   /// <summary>
   /// hectometer per decisecond defined such that: dekameter per second = hm/ds × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity HectometerPerDecisecond = new("hectometer per decisecond", "hm/ds", DekameterPerSecond, 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// dekameter per centisecond defined such that: meter per decisecond = dam/cs × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity DekameterPerCentisecond = new("dekameter per centisecond", "dam/cs", MeterPerDecisecond, 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// millimeter per quectosecond defined such that: centimeter per rontosecond = mm/qs × (1.0/10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerQuectosecond =
      new("millimeter per quectosecond", "mm/qs", CentimeterPerRontosecond, 1.0 / 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// micrometer per rontosecond defined such that: millimeter per yoctosecond = μm/rs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerRontosecond =
      new("micrometer per rontosecond", "μm/rs", MillimeterPerYoctosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// nanometer per yoctosecond defined such that: micrometer per zeptosecond = nm/ys × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerYoctosecond =
      new("nanometer per yoctosecond", "nm/ys", MicrometerPerZeptosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// picometer per zeptosecond defined such that: nanometer per attosecond = pm/zs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerZeptosecond =
      new("picometer per zeptosecond", "pm/zs", NanometerPerAttosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// femtometer per attosecond defined such that: picometer per femtosecond = fm/as × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerAttosecond =
      new("femtometer per attosecond", "fm/as", PicometerPerFemtosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// attometer per femtosecond defined such that: femtometer per picosecond = am/fs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerFemtosecond =
      new("attometer per femtosecond", "am/fs", FemtometerPerPicosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zeptometer per picosecond defined such that: attometer per nanosecond = zm/ps × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerPicosecond =
      new("zeptometer per picosecond", "zm/ps", AttometerPerNanosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yoctometer per nanosecond defined such that: zeptometer per microsecond = ym/ns × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerNanosecond =
      new("yoctometer per nanosecond", "ym/ns", ZeptometerPerMicrosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// rontometer per microsecond defined such that: yoctometer per millisecond = rm/μs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerMicrosecond =
      new("rontometer per microsecond", "rm/μs", YoctometerPerMillisecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quectometer per millisecond defined such that: rontometer per centisecond = qm/ms × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity QuectometerPerMillisecond =
      new("quectometer per millisecond", "qm/ms", RontometerPerCentisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// megameter per second defined such that: kilometer per second = Mm/s × (1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity MegameterPerSecond = new("megameter per second", "Mm/s", KilometerPerSecond, 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// kilometer per decisecond defined such that: hectometer per second = km/ds × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity KilometerPerDecisecond = new("kilometer per decisecond", "km/ds", HectometerPerSecond, 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// hectometer per centisecond defined such that: dekameter per decisecond = hm/cs × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity HectometerPerCentisecond = new("hectometer per centisecond", "hm/cs", DekameterPerDecisecond, 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// dekameter per millisecond defined such that: meter per centisecond = dam/ms × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity DekameterPerMillisecond = new("dekameter per millisecond", "dam/ms", MeterPerCentisecond, 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// micrometer per quectosecond defined such that: millimeter per rontosecond = μm/qs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerQuectosecond =
      new("micrometer per quectosecond", "μm/qs", MillimeterPerRontosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// nanometer per rontosecond defined such that: micrometer per yoctosecond = nm/rs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerRontosecond =
      new("nanometer per rontosecond", "nm/rs", MicrometerPerYoctosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// picometer per yoctosecond defined such that: nanometer per zeptosecond = pm/ys × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerYoctosecond =
      new("picometer per yoctosecond", "pm/ys", NanometerPerZeptosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// femtometer per zeptosecond defined such that: picometer per attosecond = fm/zs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerZeptosecond =
      new("femtometer per zeptosecond", "fm/zs", PicometerPerAttosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// attometer per attosecond defined such that: femtometer per femtosecond = am/as × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerAttosecond =
      new("attometer per attosecond", "am/as", FemtometerPerFemtosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zeptometer per femtosecond defined such that: attometer per picosecond = zm/fs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerFemtosecond =
      new("zeptometer per femtosecond", "zm/fs", AttometerPerPicosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yoctometer per picosecond defined such that: zeptometer per nanosecond = ym/ps × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerPicosecond =
      new("yoctometer per picosecond", "ym/ps", ZeptometerPerNanosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// rontometer per nanosecond defined such that: yoctometer per microsecond = rm/ns × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerNanosecond =
      new("rontometer per nanosecond", "rm/ns", YoctometerPerMicrosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quectometer per microsecond defined such that: rontometer per millisecond = qm/μs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerMicrosecond =
      new("quectometer per microsecond", "qm/μs", RontometerPerMillisecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// gigameter per second defined such that: megameter per second = Gm/s × (1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity GigameterPerSecond = new("gigameter per second", "Gm/s", MegameterPerSecond, 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// megameter per decisecond defined such that: kilometer per second = Mm/ds × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MegameterPerDecisecond = new("megameter per decisecond", "Mm/ds", KilometerPerSecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// kilometer per centisecond defined such that: hectometer per decisecond = km/cs × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity KilometerPerCentisecond = new("kilometer per centisecond", "km/cs", HectometerPerDecisecond, 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// hectometer per millisecond defined such that: dekameter per centisecond = hm/ms × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity HectometerPerMillisecond = new("hectometer per millisecond", "hm/ms", DekameterPerCentisecond, 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// dekameter per microsecond defined such that: meter per millisecond = dam/μs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerMicrosecond = new("dekameter per microsecond", "dam/μs", MeterPerMillisecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// nanometer per quectosecond defined such that: micrometer per rontosecond = nm/qs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerQuectosecond =
      new("nanometer per quectosecond", "nm/qs", MicrometerPerRontosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// picometer per rontosecond defined such that: nanometer per yoctosecond = pm/rs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerRontosecond =
      new("picometer per rontosecond", "pm/rs", NanometerPerYoctosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// femtometer per yoctosecond defined such that: picometer per zeptosecond = fm/ys × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerYoctosecond =
      new("femtometer per yoctosecond", "fm/ys", PicometerPerZeptosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// attometer per zeptosecond defined such that: femtometer per attosecond = am/zs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerZeptosecond =
      new("attometer per zeptosecond", "am/zs", FemtometerPerAttosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zeptometer per attosecond defined such that: attometer per femtosecond = zm/as × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerAttosecond =
      new("zeptometer per attosecond", "zm/as", AttometerPerFemtosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yoctometer per femtosecond defined such that: zeptometer per picosecond = ym/fs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerFemtosecond =
      new("yoctometer per femtosecond", "ym/fs", ZeptometerPerPicosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// rontometer per picosecond defined such that: yoctometer per nanosecond = rm/ps × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerPicosecond =
      new("rontometer per picosecond", "rm/ps", YoctometerPerNanosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quectometer per nanosecond defined such that: rontometer per microsecond = qm/ns × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerNanosecond =
      new("quectometer per nanosecond", "qm/ns", RontometerPerMicrosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// terameter per second defined such that: gigameter per second = Tm/s × (1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity TerameterPerSecond = new("terameter per second", "Tm/s", GigameterPerSecond, 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// gigameter per decisecond defined such that: megameter per second = Gm/ds × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity GigameterPerDecisecond = new("gigameter per decisecond", "Gm/ds", MegameterPerSecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// megameter per centisecond defined such that: kilometer per decisecond = Mm/cs × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MegameterPerCentisecond = new("megameter per centisecond", "Mm/cs", KilometerPerDecisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// kilometer per millisecond defined such that: hectometer per centisecond = km/ms × (10.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity KilometerPerMillisecond = new("kilometer per millisecond", "km/ms", HectometerPerCentisecond, 10.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// hectometer per microsecond defined such that: dekameter per millisecond = hm/μs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerMicrosecond =
      new("hectometer per microsecond", "hm/μs", DekameterPerMillisecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// dekameter per nanosecond defined such that: meter per microsecond = dam/ns × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerNanosecond = new("dekameter per nanosecond", "dam/ns", MeterPerMicrosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// picometer per quectosecond defined such that: nanometer per rontosecond = pm/qs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerQuectosecond =
      new("picometer per quectosecond", "pm/qs", NanometerPerRontosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// femtometer per rontosecond defined such that: picometer per yoctosecond = fm/rs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerRontosecond =
      new("femtometer per rontosecond", "fm/rs", PicometerPerYoctosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// attometer per yoctosecond defined such that: femtometer per zeptosecond = am/ys × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerYoctosecond =
      new("attometer per yoctosecond", "am/ys", FemtometerPerZeptosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zeptometer per zeptosecond defined such that: attometer per attosecond = zm/zs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerZeptosecond =
      new("zeptometer per zeptosecond", "zm/zs", AttometerPerAttosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yoctometer per attosecond defined such that: zeptometer per femtosecond = ym/as × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerAttosecond =
      new("yoctometer per attosecond", "ym/as", ZeptometerPerFemtosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// rontometer per femtosecond defined such that: yoctometer per picosecond = rm/fs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerFemtosecond =
      new("rontometer per femtosecond", "rm/fs", YoctometerPerPicosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quectometer per picosecond defined such that: rontometer per nanosecond = qm/ps × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerPicosecond =
      new("quectometer per picosecond", "qm/ps", RontometerPerNanosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// petameter per second defined such that: terameter per second = Pm/s × (1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity PetameterPerSecond = new("petameter per second", "Pm/s", TerameterPerSecond, 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// terameter per decisecond defined such that: gigameter per second = Tm/ds × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity TerameterPerDecisecond = new("terameter per decisecond", "Tm/ds", GigameterPerSecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// gigameter per centisecond defined such that: megameter per decisecond = Gm/cs × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity GigameterPerCentisecond = new("gigameter per centisecond", "Gm/cs", MegameterPerDecisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// megameter per millisecond defined such that: kilometer per centisecond = Mm/ms × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MegameterPerMillisecond = new("megameter per millisecond", "Mm/ms", KilometerPerCentisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// kilometer per microsecond defined such that: hectometer per millisecond = km/μs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerMicrosecond =
      new("kilometer per microsecond", "km/μs", HectometerPerMillisecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// hectometer per nanosecond defined such that: dekameter per microsecond = hm/ns × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerNanosecond = new("hectometer per nanosecond", "hm/ns", DekameterPerMicrosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// dekameter per picosecond defined such that: meter per nanosecond = dam/ps × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerPicosecond = new("dekameter per picosecond", "dam/ps", MeterPerNanosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// femtometer per quectosecond defined such that: picometer per rontosecond = fm/qs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerQuectosecond =
      new("femtometer per quectosecond", "fm/qs", PicometerPerRontosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// attometer per rontosecond defined such that: femtometer per yoctosecond = am/rs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerRontosecond =
      new("attometer per rontosecond", "am/rs", FemtometerPerYoctosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zeptometer per yoctosecond defined such that: attometer per zeptosecond = zm/ys × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerYoctosecond =
      new("zeptometer per yoctosecond", "zm/ys", AttometerPerZeptosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yoctometer per zeptosecond defined such that: zeptometer per attosecond = ym/zs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerZeptosecond =
      new("yoctometer per zeptosecond", "ym/zs", ZeptometerPerAttosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// rontometer per attosecond defined such that: yoctometer per femtosecond = rm/as × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerAttosecond =
      new("rontometer per attosecond", "rm/as", YoctometerPerFemtosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quectometer per femtosecond defined such that: rontometer per picosecond = qm/fs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerFemtosecond =
      new("quectometer per femtosecond", "qm/fs", RontometerPerPicosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// exameter per second defined such that: petameter per second = Em/s × (1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity ExameterPerSecond = new("exameter per second", "Em/s", PetameterPerSecond, 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// petameter per decisecond defined such that: terameter per second = Pm/ds × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PetameterPerDecisecond = new("petameter per decisecond", "Pm/ds", TerameterPerSecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// terameter per centisecond defined such that: gigameter per decisecond = Tm/cs × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity TerameterPerCentisecond = new("terameter per centisecond", "Tm/cs", GigameterPerDecisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// gigameter per millisecond defined such that: megameter per centisecond = Gm/ms × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity GigameterPerMillisecond = new("gigameter per millisecond", "Gm/ms", MegameterPerCentisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// megameter per microsecond defined such that: kilometer per millisecond = Mm/μs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerMicrosecond =
      new("megameter per microsecond", "Mm/μs", KilometerPerMillisecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// kilometer per nanosecond defined such that: hectometer per microsecond = km/ns × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerNanosecond = new("kilometer per nanosecond", "km/ns", HectometerPerMicrosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// hectometer per picosecond defined such that: dekameter per nanosecond = hm/ps × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerPicosecond = new("hectometer per picosecond", "hm/ps", DekameterPerNanosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// dekameter per femtosecond defined such that: meter per picosecond = dam/fs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerFemtosecond = new("dekameter per femtosecond", "dam/fs", MeterPerPicosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// attometer per quectosecond defined such that: femtometer per rontosecond = am/qs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerQuectosecond =
      new("attometer per quectosecond", "am/qs", FemtometerPerRontosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zeptometer per rontosecond defined such that: attometer per yoctosecond = zm/rs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerRontosecond =
      new("zeptometer per rontosecond", "zm/rs", AttometerPerYoctosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yoctometer per yoctosecond defined such that: zeptometer per zeptosecond = ym/ys × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerYoctosecond =
      new("yoctometer per yoctosecond", "ym/ys", ZeptometerPerZeptosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// rontometer per zeptosecond defined such that: yoctometer per attosecond = rm/zs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerZeptosecond =
      new("rontometer per zeptosecond", "rm/zs", YoctometerPerAttosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quectometer per attosecond defined such that: rontometer per femtosecond = qm/as × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerAttosecond =
      new("quectometer per attosecond", "qm/as", RontometerPerFemtosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zettameter per second defined such that: exameter per second = Zm/s × (1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity ZettameterPerSecond = new("zettameter per second", "Zm/s", ExameterPerSecond, 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// exameter per decisecond defined such that: petameter per second = Em/ds × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ExameterPerDecisecond = new("exameter per decisecond", "Em/ds", PetameterPerSecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// petameter per centisecond defined such that: terameter per decisecond = Pm/cs × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PetameterPerCentisecond = new("petameter per centisecond", "Pm/cs", TerameterPerDecisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// terameter per millisecond defined such that: gigameter per centisecond = Tm/ms × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity TerameterPerMillisecond = new("terameter per millisecond", "Tm/ms", GigameterPerCentisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// gigameter per microsecond defined such that: megameter per millisecond = Gm/μs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerMicrosecond =
      new("gigameter per microsecond", "Gm/μs", MegameterPerMillisecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// megameter per nanosecond defined such that: kilometer per microsecond = Mm/ns × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerNanosecond = new("megameter per nanosecond", "Mm/ns", KilometerPerMicrosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// kilometer per picosecond defined such that: hectometer per nanosecond = km/ps × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerPicosecond = new("kilometer per picosecond", "km/ps", HectometerPerNanosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// hectometer per femtosecond defined such that: dekameter per picosecond = hm/fs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerFemtosecond =
      new("hectometer per femtosecond", "hm/fs", DekameterPerPicosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// dekameter per attosecond defined such that: meter per femtosecond = dam/as × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerAttosecond = new("dekameter per attosecond", "dam/as", MeterPerFemtosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zeptometer per quectosecond defined such that: attometer per rontosecond = zm/qs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerQuectosecond =
      new("zeptometer per quectosecond", "zm/qs", AttometerPerRontosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yoctometer per rontosecond defined such that: zeptometer per yoctosecond = ym/rs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerRontosecond =
      new("yoctometer per rontosecond", "ym/rs", ZeptometerPerYoctosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// rontometer per yoctosecond defined such that: yoctometer per zeptosecond = rm/ys × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerYoctosecond =
      new("rontometer per yoctosecond", "rm/ys", YoctometerPerZeptosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quectometer per zeptosecond defined such that: rontometer per attosecond = qm/zs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerZeptosecond =
      new("quectometer per zeptosecond", "qm/zs", RontometerPerAttosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yottameter per second defined such that: zettameter per second = Ym/s × (1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity YottameterPerSecond = new("yottameter per second", "Ym/s", ZettameterPerSecond, 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// zettameter per decisecond defined such that: exameter per second = Zm/ds × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ZettameterPerDecisecond = new("zettameter per decisecond", "Zm/ds", ExameterPerSecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// exameter per centisecond defined such that: petameter per decisecond = Em/cs × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ExameterPerCentisecond = new("exameter per centisecond", "Em/cs", PetameterPerDecisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// petameter per millisecond defined such that: terameter per centisecond = Pm/ms × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PetameterPerMillisecond = new("petameter per millisecond", "Pm/ms", TerameterPerCentisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// terameter per microsecond defined such that: gigameter per millisecond = Tm/μs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerMicrosecond =
      new("terameter per microsecond", "Tm/μs", GigameterPerMillisecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// gigameter per nanosecond defined such that: megameter per microsecond = Gm/ns × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerNanosecond = new("gigameter per nanosecond", "Gm/ns", MegameterPerMicrosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// megameter per picosecond defined such that: kilometer per nanosecond = Mm/ps × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerPicosecond = new("megameter per picosecond", "Mm/ps", KilometerPerNanosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// kilometer per femtosecond defined such that: hectometer per picosecond = km/fs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerFemtosecond = new("kilometer per femtosecond", "km/fs", HectometerPerPicosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// hectometer per attosecond defined such that: dekameter per femtosecond = hm/as × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerAttosecond = new("hectometer per attosecond", "hm/as", DekameterPerFemtosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// dekameter per zeptosecond defined such that: meter per attosecond = dam/zs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerZeptosecond = new("dekameter per zeptosecond", "dam/zs", MeterPerAttosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yoctometer per quectosecond defined such that: zeptometer per rontosecond = ym/qs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerQuectosecond =
      new("yoctometer per quectosecond", "ym/qs", ZeptometerPerRontosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// rontometer per rontosecond defined such that: yoctometer per yoctosecond = rm/rs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerRontosecond =
      new("rontometer per rontosecond", "rm/rs", YoctometerPerYoctosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quectometer per yoctosecond defined such that: rontometer per zeptosecond = qm/ys × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerYoctosecond =
      new("quectometer per yoctosecond", "qm/ys", RontometerPerZeptosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// ronnameter per second defined such that: yottameter per second = Rm/s × (1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity RonnameterPerSecond = new("ronnameter per second", "Rm/s", YottameterPerSecond, 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// yottameter per decisecond defined such that: zettameter per second = Ym/ds × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YottameterPerDecisecond = new("yottameter per decisecond", "Ym/ds", ZettameterPerSecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// zettameter per centisecond defined such that: exameter per decisecond = Zm/cs × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ZettameterPerCentisecond = new("zettameter per centisecond", "Zm/cs", ExameterPerDecisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// exameter per millisecond defined such that: petameter per centisecond = Em/ms × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ExameterPerMillisecond = new("exameter per millisecond", "Em/ms", PetameterPerCentisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// petameter per microsecond defined such that: terameter per millisecond = Pm/μs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerMicrosecond =
      new("petameter per microsecond", "Pm/μs", TerameterPerMillisecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// terameter per nanosecond defined such that: gigameter per microsecond = Tm/ns × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerNanosecond = new("terameter per nanosecond", "Tm/ns", GigameterPerMicrosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// gigameter per picosecond defined such that: megameter per nanosecond = Gm/ps × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerPicosecond = new("gigameter per picosecond", "Gm/ps", MegameterPerNanosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// megameter per femtosecond defined such that: kilometer per picosecond = Mm/fs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerFemtosecond =
      new("megameter per femtosecond", "Mm/fs", KilometerPerPicosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// kilometer per attosecond defined such that: hectometer per femtosecond = km/as × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerAttosecond = new("kilometer per attosecond", "km/as", HectometerPerFemtosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// hectometer per zeptosecond defined such that: dekameter per attosecond = hm/zs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerZeptosecond =
      new("hectometer per zeptosecond", "hm/zs", DekameterPerAttosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// dekameter per yoctosecond defined such that: meter per zeptosecond = dam/ys × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerYoctosecond = new("dekameter per yoctosecond", "dam/ys", MeterPerZeptosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// rontometer per quectosecond defined such that: yoctometer per rontosecond = rm/qs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerQuectosecond =
      new("rontometer per quectosecond", "rm/qs", YoctometerPerRontosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quectometer per rontosecond defined such that: rontometer per yoctosecond = qm/rs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerRontosecond =
      new("quectometer per rontosecond", "qm/rs", RontometerPerYoctosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per second defined such that: ronnameter per second = Qm/s × (1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity QuettameterPerSecond = new("quettameter per second", "Qm/s", RonnameterPerSecond, 1000.0 / 1.0, system: "SI");
   
   /// <summary>
   /// ronnameter per decisecond defined such that: yottameter per second = Rm/ds × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity RonnameterPerDecisecond = new("ronnameter per decisecond", "Rm/ds", YottameterPerSecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// yottameter per centisecond defined such that: zettameter per decisecond = Ym/cs × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YottameterPerCentisecond =
      new("yottameter per centisecond", "Ym/cs", ZettameterPerDecisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// zettameter per millisecond defined such that: exameter per centisecond = Zm/ms × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity ZettameterPerMillisecond =
      new("zettameter per millisecond", "Zm/ms", ExameterPerCentisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// exameter per microsecond defined such that: petameter per millisecond = Em/μs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerMicrosecond = new("exameter per microsecond", "Em/μs", PetameterPerMillisecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// petameter per nanosecond defined such that: terameter per microsecond = Pm/ns × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerNanosecond = new("petameter per nanosecond", "Pm/ns", TerameterPerMicrosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// terameter per picosecond defined such that: gigameter per nanosecond = Tm/ps × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerPicosecond = new("terameter per picosecond", "Tm/ps", GigameterPerNanosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// gigameter per femtosecond defined such that: megameter per picosecond = Gm/fs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerFemtosecond =
      new("gigameter per femtosecond", "Gm/fs", MegameterPerPicosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// megameter per attosecond defined such that: kilometer per femtosecond = Mm/as × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerAttosecond = new("megameter per attosecond", "Mm/as", KilometerPerFemtosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// kilometer per zeptosecond defined such that: hectometer per attosecond = km/zs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerZeptosecond = new("kilometer per zeptosecond", "km/zs", HectometerPerAttosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// hectometer per yoctosecond defined such that: dekameter per zeptosecond = hm/ys × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerYoctosecond =
      new("hectometer per yoctosecond", "hm/ys", DekameterPerZeptosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// dekameter per rontosecond defined such that: meter per yoctosecond = dam/rs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerRontosecond = new("dekameter per rontosecond", "dam/rs", MeterPerYoctosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quectometer per quectosecond defined such that: rontometer per rontosecond = qm/qs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerQuectosecond =
      new("quectometer per quectosecond", "qm/qs", RontometerPerRontosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per decisecond defined such that: ronnameter per second = Qm/ds × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity QuettameterPerDecisecond = new("quettameter per decisecond", "Qm/ds", RonnameterPerSecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// ronnameter per centisecond defined such that: yottameter per decisecond = Rm/cs × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity RonnameterPerCentisecond =
      new("ronnameter per centisecond", "Rm/cs", YottameterPerDecisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// yottameter per millisecond defined such that: zettameter per centisecond = Ym/ms × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YottameterPerMillisecond =
      new("yottameter per millisecond", "Ym/ms", ZettameterPerCentisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// zettameter per microsecond defined such that: exameter per millisecond = Zm/μs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerMicrosecond =
      new("zettameter per microsecond", "Zm/μs", ExameterPerMillisecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// exameter per nanosecond defined such that: petameter per microsecond = Em/ns × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerNanosecond = new("exameter per nanosecond", "Em/ns", PetameterPerMicrosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// petameter per picosecond defined such that: terameter per nanosecond = Pm/ps × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerPicosecond = new("petameter per picosecond", "Pm/ps", TerameterPerNanosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// terameter per femtosecond defined such that: gigameter per picosecond = Tm/fs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerFemtosecond =
      new("terameter per femtosecond", "Tm/fs", GigameterPerPicosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// gigameter per attosecond defined such that: megameter per femtosecond = Gm/as × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerAttosecond = new("gigameter per attosecond", "Gm/as", MegameterPerFemtosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// megameter per zeptosecond defined such that: kilometer per attosecond = Mm/zs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerZeptosecond =
      new("megameter per zeptosecond", "Mm/zs", KilometerPerAttosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// kilometer per yoctosecond defined such that: hectometer per zeptosecond = km/ys × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerYoctosecond =
      new("kilometer per yoctosecond", "km/ys", HectometerPerZeptosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// hectometer per rontosecond defined such that: dekameter per yoctosecond = hm/rs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerRontosecond =
      new("hectometer per rontosecond", "hm/rs", DekameterPerYoctosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// dekameter per quectosecond defined such that: meter per rontosecond = dam/qs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerQuectosecond = new("dekameter per quectosecond", "dam/qs", MeterPerRontosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per centisecond defined such that: ronnameter per decisecond = Qm/cs × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity QuettameterPerCentisecond =
      new("quettameter per centisecond", "Qm/cs", RonnameterPerDecisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// ronnameter per millisecond defined such that: yottameter per centisecond = Rm/ms × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity RonnameterPerMillisecond =
      new("ronnameter per millisecond", "Rm/ms", YottameterPerCentisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// yottameter per microsecond defined such that: zettameter per millisecond = Ym/μs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerMicrosecond =
      new("yottameter per microsecond", "Ym/μs", ZettameterPerMillisecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zettameter per nanosecond defined such that: exameter per microsecond = Zm/ns × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerNanosecond =
      new("zettameter per nanosecond", "Zm/ns", ExameterPerMicrosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// exameter per picosecond defined such that: petameter per nanosecond = Em/ps × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerPicosecond = new("exameter per picosecond", "Em/ps", PetameterPerNanosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// petameter per femtosecond defined such that: terameter per picosecond = Pm/fs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerFemtosecond =
      new("petameter per femtosecond", "Pm/fs", TerameterPerPicosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// terameter per attosecond defined such that: gigameter per femtosecond = Tm/as × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerAttosecond = new("terameter per attosecond", "Tm/as", GigameterPerFemtosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// gigameter per zeptosecond defined such that: megameter per attosecond = Gm/zs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerZeptosecond =
      new("gigameter per zeptosecond", "Gm/zs", MegameterPerAttosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// megameter per yoctosecond defined such that: kilometer per zeptosecond = Mm/ys × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerYoctosecond =
      new("megameter per yoctosecond", "Mm/ys", KilometerPerZeptosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// kilometer per rontosecond defined such that: hectometer per yoctosecond = km/rs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerRontosecond =
      new("kilometer per rontosecond", "km/rs", HectometerPerYoctosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// hectometer per quectosecond defined such that: dekameter per rontosecond = hm/qs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerQuectosecond =
      new("hectometer per quectosecond", "hm/qs", DekameterPerRontosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per millisecond defined such that: ronnameter per centisecond = Qm/ms × (1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity QuettameterPerMillisecond =
      new("quettameter per millisecond", "Qm/ms", RonnameterPerCentisecond, 1000.0 / (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// ronnameter per microsecond defined such that: yottameter per millisecond = Rm/μs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerMicrosecond =
      new("ronnameter per microsecond", "Rm/μs", YottameterPerMillisecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yottameter per nanosecond defined such that: zettameter per microsecond = Ym/ns × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerNanosecond =
      new("yottameter per nanosecond", "Ym/ns", ZettameterPerMicrosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zettameter per picosecond defined such that: exameter per nanosecond = Zm/ps × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerPicosecond = new("zettameter per picosecond", "Zm/ps", ExameterPerNanosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// exameter per femtosecond defined such that: petameter per picosecond = Em/fs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerFemtosecond = new("exameter per femtosecond", "Em/fs", PetameterPerPicosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// petameter per attosecond defined such that: terameter per femtosecond = Pm/as × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerAttosecond = new("petameter per attosecond", "Pm/as", TerameterPerFemtosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// terameter per zeptosecond defined such that: gigameter per attosecond = Tm/zs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerZeptosecond =
      new("terameter per zeptosecond", "Tm/zs", GigameterPerAttosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// gigameter per yoctosecond defined such that: megameter per zeptosecond = Gm/ys × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerYoctosecond =
      new("gigameter per yoctosecond", "Gm/ys", MegameterPerZeptosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// megameter per rontosecond defined such that: kilometer per yoctosecond = Mm/rs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerRontosecond =
      new("megameter per rontosecond", "Mm/rs", KilometerPerYoctosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// kilometer per quectosecond defined such that: hectometer per rontosecond = km/qs × (10.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerQuectosecond =
      new("kilometer per quectosecond", "km/qs", HectometerPerRontosecond, 10.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per microsecond defined such that: ronnameter per millisecond = Qm/μs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerMicrosecond =
      new("quettameter per microsecond", "Qm/μs", RonnameterPerMillisecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// ronnameter per nanosecond defined such that: yottameter per microsecond = Rm/ns × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerNanosecond =
      new("ronnameter per nanosecond", "Rm/ns", YottameterPerMicrosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yottameter per picosecond defined such that: zettameter per nanosecond = Ym/ps × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerPicosecond =
      new("yottameter per picosecond", "Ym/ps", ZettameterPerNanosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zettameter per femtosecond defined such that: exameter per picosecond = Zm/fs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerFemtosecond =
      new("zettameter per femtosecond", "Zm/fs", ExameterPerPicosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// exameter per attosecond defined such that: petameter per femtosecond = Em/as × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerAttosecond = new("exameter per attosecond", "Em/as", PetameterPerFemtosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// petameter per zeptosecond defined such that: terameter per attosecond = Pm/zs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerZeptosecond =
      new("petameter per zeptosecond", "Pm/zs", TerameterPerAttosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// terameter per yoctosecond defined such that: gigameter per zeptosecond = Tm/ys × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerYoctosecond =
      new("terameter per yoctosecond", "Tm/ys", GigameterPerZeptosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// gigameter per rontosecond defined such that: megameter per yoctosecond = Gm/rs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerRontosecond =
      new("gigameter per rontosecond", "Gm/rs", MegameterPerYoctosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// megameter per quectosecond defined such that: kilometer per rontosecond = Mm/qs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerQuectosecond =
      new("megameter per quectosecond", "Mm/qs", KilometerPerRontosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per nanosecond defined such that: ronnameter per microsecond = Qm/ns × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerNanosecond =
      new("quettameter per nanosecond", "Qm/ns", RonnameterPerMicrosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// ronnameter per picosecond defined such that: yottameter per nanosecond = Rm/ps × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerPicosecond =
      new("ronnameter per picosecond", "Rm/ps", YottameterPerNanosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yottameter per femtosecond defined such that: zettameter per picosecond = Ym/fs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerFemtosecond =
      new("yottameter per femtosecond", "Ym/fs", ZettameterPerPicosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zettameter per attosecond defined such that: exameter per femtosecond = Zm/as × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerAttosecond =
      new("zettameter per attosecond", "Zm/as", ExameterPerFemtosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// exameter per zeptosecond defined such that: petameter per attosecond = Em/zs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerZeptosecond = new("exameter per zeptosecond", "Em/zs", PetameterPerAttosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// petameter per yoctosecond defined such that: terameter per zeptosecond = Pm/ys × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerYoctosecond =
      new("petameter per yoctosecond", "Pm/ys", TerameterPerZeptosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// terameter per rontosecond defined such that: gigameter per yoctosecond = Tm/rs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerRontosecond =
      new("terameter per rontosecond", "Tm/rs", GigameterPerYoctosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// gigameter per quectosecond defined such that: megameter per rontosecond = Gm/qs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerQuectosecond =
      new("gigameter per quectosecond", "Gm/qs", MegameterPerRontosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per picosecond defined such that: ronnameter per nanosecond = Qm/ps × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerPicosecond =
      new("quettameter per picosecond", "Qm/ps", RonnameterPerNanosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// ronnameter per femtosecond defined such that: yottameter per picosecond = Rm/fs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerFemtosecond =
      new("ronnameter per femtosecond", "Rm/fs", YottameterPerPicosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yottameter per attosecond defined such that: zettameter per femtosecond = Ym/as × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerAttosecond =
      new("yottameter per attosecond", "Ym/as", ZettameterPerFemtosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zettameter per zeptosecond defined such that: exameter per attosecond = Zm/zs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerZeptosecond =
      new("zettameter per zeptosecond", "Zm/zs", ExameterPerAttosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// exameter per yoctosecond defined such that: petameter per zeptosecond = Em/ys × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerYoctosecond = new("exameter per yoctosecond", "Em/ys", PetameterPerZeptosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// petameter per rontosecond defined such that: terameter per yoctosecond = Pm/rs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerRontosecond =
      new("petameter per rontosecond", "Pm/rs", TerameterPerYoctosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// terameter per quectosecond defined such that: gigameter per rontosecond = Tm/qs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerQuectosecond =
      new("terameter per quectosecond", "Tm/qs", GigameterPerRontosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per femtosecond defined such that: ronnameter per picosecond = Qm/fs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerFemtosecond =
      new("quettameter per femtosecond", "Qm/fs", RonnameterPerPicosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// ronnameter per attosecond defined such that: yottameter per femtosecond = Rm/as × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerAttosecond =
      new("ronnameter per attosecond", "Rm/as", YottameterPerFemtosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yottameter per zeptosecond defined such that: zettameter per attosecond = Ym/zs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerZeptosecond =
      new("yottameter per zeptosecond", "Ym/zs", ZettameterPerAttosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zettameter per yoctosecond defined such that: exameter per zeptosecond = Zm/ys × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerYoctosecond =
      new("zettameter per yoctosecond", "Zm/ys", ExameterPerZeptosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// exameter per rontosecond defined such that: petameter per yoctosecond = Em/rs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerRontosecond = new("exameter per rontosecond", "Em/rs", PetameterPerYoctosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// petameter per quectosecond defined such that: terameter per rontosecond = Pm/qs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerQuectosecond =
      new("petameter per quectosecond", "Pm/qs", TerameterPerRontosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per attosecond defined such that: ronnameter per femtosecond = Qm/as × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerAttosecond =
      new("quettameter per attosecond", "Qm/as", RonnameterPerFemtosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// ronnameter per zeptosecond defined such that: yottameter per attosecond = Rm/zs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerZeptosecond =
      new("ronnameter per zeptosecond", "Rm/zs", YottameterPerAttosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yottameter per yoctosecond defined such that: zettameter per zeptosecond = Ym/ys × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerYoctosecond =
      new("yottameter per yoctosecond", "Ym/ys", ZettameterPerZeptosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zettameter per rontosecond defined such that: exameter per yoctosecond = Zm/rs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerRontosecond =
      new("zettameter per rontosecond", "Zm/rs", ExameterPerYoctosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// exameter per quectosecond defined such that: petameter per rontosecond = Em/qs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerQuectosecond =
      new("exameter per quectosecond", "Em/qs", PetameterPerRontosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per zeptosecond defined such that: ronnameter per attosecond = Qm/zs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerZeptosecond =
      new("quettameter per zeptosecond", "Qm/zs", RonnameterPerAttosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// ronnameter per yoctosecond defined such that: yottameter per zeptosecond = Rm/ys × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerYoctosecond =
      new("ronnameter per yoctosecond", "Rm/ys", YottameterPerZeptosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yottameter per rontosecond defined such that: zettameter per yoctosecond = Ym/rs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerRontosecond =
      new("yottameter per rontosecond", "Ym/rs", ZettameterPerYoctosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// zettameter per quectosecond defined such that: exameter per rontosecond = Zm/qs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerQuectosecond =
      new("zettameter per quectosecond", "Zm/qs", ExameterPerRontosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per yoctosecond defined such that: ronnameter per zeptosecond = Qm/ys × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerYoctosecond =
      new("quettameter per yoctosecond", "Qm/ys", RonnameterPerZeptosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// ronnameter per rontosecond defined such that: yottameter per yoctosecond = Rm/rs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerRontosecond =
      new("ronnameter per rontosecond", "Rm/rs", YottameterPerYoctosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// yottameter per quectosecond defined such that: zettameter per rontosecond = Ym/qs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerQuectosecond =
      new("yottameter per quectosecond", "Ym/qs", ZettameterPerRontosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per rontosecond defined such that: ronnameter per yoctosecond = Qm/rs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerRontosecond =
      new("quettameter per rontosecond", "Qm/rs", RonnameterPerYoctosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// ronnameter per quectosecond defined such that: yottameter per rontosecond = Rm/qs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerQuectosecond =
      new("ronnameter per quectosecond", "Rm/qs", YottameterPerRontosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// quettameter per quectosecond defined such that: ronnameter per rontosecond = Qm/qs × (1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerQuectosecond =
      new("quettameter per quectosecond", "Qm/qs", RonnameterPerRontosecond, 1000.0 / (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// meter per minute defined such that: meter per second = m/min × (1.0)/(60.0).
   /// </summary>
   public static readonly Velocity MeterPerMinute = new("meter per minute", "m/min", MeterPerSecond, 1.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per hour defined such that: meter per minute = m/hr × (1.0)/(60.0).
   /// </summary>
   public static readonly Velocity MeterPerHour = new("meter per hour", "m/hr", MeterPerMinute, 1.0 / 60.0, system: "SI");
   
   /// <summary>
   /// decimeter per minute defined such that: meter per second = dm/min × (1.0/10.0)/(60.0).
   /// </summary>
   public static readonly Velocity DecimeterPerMinute = new("decimeter per minute", "dm/min", MeterPerSecond, 1.0 / 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per day defined such that: meter per hour = m/dy × (1.0)/(24.0).
   /// </summary>
   public static readonly Velocity MeterPerDay = new("meter per day", "m/dy", MeterPerHour, 1.0 / 24.0, system: "SI");
   
   /// <summary>
   /// centimeter per minute defined such that: decimeter per second = cm/min × (1.0/10.0)/(60.0).
   /// </summary>
   public static readonly Velocity CentimeterPerMinute = new("centimeter per minute", "cm/min", DecimeterPerSecond, 1.0 / 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per week defined such that: meter per day = m/wk × (1.0)/(7.0).
   /// </summary>
   public static readonly Velocity MeterPerWeek = new("meter per week", "m/wk", MeterPerDay, 1.0 / 7.0, system: "SI");
   
   /// <summary>
   /// decimeter per hour defined such that: meter per minute = dm/hr × (1.0/10.0)/(60.0).
   /// </summary>
   public static readonly Velocity DecimeterPerHour = new("decimeter per hour", "dm/hr", MeterPerMinute, 1.0 / 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// millimeter per minute defined such that: centimeter per second = mm/min × (1.0/10.0)/(60.0).
   /// </summary>
   public static readonly Velocity MillimeterPerMinute = new("millimeter per minute", "mm/min", CentimeterPerSecond, 1.0 / 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per year defined such that: meter per day = m/yr × (1.0)/(365.2525).
   /// </summary>
   public static readonly Velocity MeterPerYear = new("meter per year", "m/yr", MeterPerDay, 1.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// micrometer per minute defined such that: millimeter per second = μm/min × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity MicrometerPerMinute = new("micrometer per minute", "μm/min", MillimeterPerSecond, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per decade defined such that: meter per year = m/decade × (1.0)/(10.0).
   /// </summary>
   public static readonly Velocity MeterPerDecade = new("meter per decade", "m/decade", MeterPerYear, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// decimeter per day defined such that: meter per hour = dm/dy × (1.0/10.0)/(24.0).
   /// </summary>
   public static readonly Velocity DecimeterPerDay = new("decimeter per day", "dm/dy", MeterPerHour, 1.0 / 10.0 / 24.0, system: "SI");
   
   /// <summary>
   /// centimeter per hour defined such that: decimeter per minute = cm/hr × (1.0/10.0)/(60.0).
   /// </summary>
   public static readonly Velocity CentimeterPerHour = new("centimeter per hour", "cm/hr", DecimeterPerMinute, 1.0 / 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// nanometer per minute defined such that: micrometer per second = nm/min × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity NanometerPerMinute = new("nanometer per minute", "nm/min", MicrometerPerSecond, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per century defined such that: meter per decade = m/century × (1.0)/(10.0).
   /// </summary>
   public static readonly Velocity MeterPerCentury = new("meter per century", "m/century", MeterPerDecade, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// picometer per minute defined such that: nanometer per second = pm/min × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity PicometerPerMinute = new("picometer per minute", "pm/min", NanometerPerSecond, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per millennium defined such that: meter per century = m/kyr × (1.0)/(10.0).
   /// </summary>
   public static readonly Velocity MeterPerMillennium = new("meter per millennium", "m/kyr", MeterPerCentury, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// decimeter per week defined such that: meter per day = dm/wk × (1.0/10.0)/(7.0).
   /// </summary>
   public static readonly Velocity DecimeterPerWeek = new("decimeter per week", "dm/wk", MeterPerDay, 1.0 / 10.0 / 7.0, system: "SI");
   
   /// <summary>
   /// millimeter per hour defined such that: centimeter per minute = mm/hr × (1.0/10.0)/(60.0).
   /// </summary>
   public static readonly Velocity MillimeterPerHour = new("millimeter per hour", "mm/hr", CentimeterPerMinute, 1.0 / 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// femtometer per minute defined such that: picometer per second = fm/min × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity FemtometerPerMinute = new("femtometer per minute", "fm/min", PicometerPerSecond, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per million years defined such that: meter per millennium = m/Myr × (1.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MeterPerMillionYears = new("meter per million years", "m/Myr", MeterPerMillennium, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// centimeter per day defined such that: decimeter per hour = cm/dy × (1.0/10.0)/(24.0).
   /// </summary>
   public static readonly Velocity CentimeterPerDay = new("centimeter per day", "cm/dy", DecimeterPerHour, 1.0 / 10.0 / 24.0, system: "SI");
   
   /// <summary>
   /// attometer per minute defined such that: femtometer per second = am/min × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity AttometerPerMinute = new("attometer per minute", "am/min", FemtometerPerSecond, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per billion years defined such that: meter per million years = m/Gyr × (1.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MeterPerBillionYears = new("meter per billion years", "m/Gyr", MeterPerMillionYears, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// decimeter per year defined such that: meter per day = dm/yr × (1.0/10.0)/(365.2525).
   /// </summary>
   public static readonly Velocity DecimeterPerYear = new("decimeter per year", "dm/yr", MeterPerDay, 1.0 / 10.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// micrometer per hour defined such that: millimeter per minute = μm/hr × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity MicrometerPerHour = new("micrometer per hour", "μm/hr", MillimeterPerMinute, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// zeptometer per minute defined such that: attometer per second = zm/min × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerMinute = new("zeptometer per minute", "zm/min", AttometerPerSecond, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per trillion years defined such that: meter per billion years = m/Tyr × (1.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MeterPerTrillionYears = new("meter per trillion years", "m/Tyr", MeterPerBillionYears, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per minute defined such that: zeptometer per second = ym/min × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity YoctometerPerMinute = new("yoctometer per minute", "ym/min", ZeptometerPerSecond, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per quadrillion years defined such that: meter per trillion years = m/Pyr × (1.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MeterPerQuadrillionYears = new("meter per quadrillion years", "m/Pyr", MeterPerTrillionYears, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// decimeter per decade defined such that: meter per year = dm/decade × (1.0/10.0)/(10.0).
   /// </summary>
   public static readonly Velocity DecimeterPerDecade = new("decimeter per decade", "dm/decade", MeterPerYear, 1.0 / 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// centimeter per week defined such that: decimeter per day = cm/wk × (1.0/10.0)/(7.0).
   /// </summary>
   public static readonly Velocity CentimeterPerWeek = new("centimeter per week", "cm/wk", DecimeterPerDay, 1.0 / 10.0 / 7.0, system: "SI");
   
   /// <summary>
   /// millimeter per day defined such that: centimeter per hour = mm/dy × (1.0/10.0)/(24.0).
   /// </summary>
   public static readonly Velocity MillimeterPerDay = new("millimeter per day", "mm/dy", CentimeterPerHour, 1.0 / 10.0 / 24.0, system: "SI");
   
   /// <summary>
   /// nanometer per hour defined such that: micrometer per minute = nm/hr × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity NanometerPerHour = new("nanometer per hour", "nm/hr", MicrometerPerMinute, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// rontometer per minute defined such that: yoctometer per second = rm/min × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity RontometerPerMinute = new("rontometer per minute", "rm/min", YoctometerPerSecond, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per quintillion years defined such that: meter per quadrillion years = m/Eyr × (1.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MeterPerQuintillionYears = new("meter per quintillion years", "m/Eyr", MeterPerQuadrillionYears, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per minute defined such that: rontometer per second = qm/min × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity QuectometerPerMinute = new("quectometer per minute", "qm/min", RontometerPerSecond, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per sextillion years defined such that: meter per quintillion years = m/Zyr × (1.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MeterPerSextillionYears = new("meter per sextillion years", "m/Zyr", MeterPerQuintillionYears, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// decimeter per century defined such that: meter per decade = dm/century × (1.0/10.0)/(10.0).
   /// </summary>
   public static readonly Velocity DecimeterPerCentury = new("decimeter per century", "dm/century", MeterPerDecade, 1.0 / 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// picometer per hour defined such that: nanometer per minute = pm/hr × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity PicometerPerHour = new("picometer per hour", "pm/hr", NanometerPerMinute, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// dekameter per minute defined such that: meter per second = dam/min × (10.0)/(60.0).
   /// </summary>
   public static readonly Velocity DekameterPerMinute = new("dekameter per minute", "dam/min", MeterPerSecond, 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per septillion years defined such that: meter per sextillion years = m/Yyr × (1.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MeterPerSeptillionYears = new("meter per septillion years", "m/Yyr", MeterPerSextillionYears, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// centimeter per year defined such that: decimeter per day = cm/yr × (1.0/10.0)/(365.2525).
   /// </summary>
   public static readonly Velocity CentimeterPerYear = new("centimeter per year", "cm/yr", DecimeterPerDay, 1.0 / 10.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// micrometer per day defined such that: millimeter per hour = μm/dy × (1.0/1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity MicrometerPerDay = new("micrometer per day", "μm/dy", MillimeterPerHour, 1.0 / 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// hectometer per minute defined such that: dekameter per second = hm/min × (10.0)/(60.0).
   /// </summary>
   public static readonly Velocity HectometerPerMinute = new("hectometer per minute", "hm/min", DekameterPerSecond, 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per octillion years defined such that: meter per septillion years = m/Ryr × (1.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MeterPerOctillionYears = new("meter per octillion years", "m/Ryr", MeterPerSeptillionYears, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// decimeter per millennium defined such that: meter per century = dm/kyr × (1.0/10.0)/(10.0).
   /// </summary>
   public static readonly Velocity DecimeterPerMillennium = new("decimeter per millennium", "dm/kyr", MeterPerCentury, 1.0 / 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millimeter per week defined such that: centimeter per day = mm/wk × (1.0/10.0)/(7.0).
   /// </summary>
   public static readonly Velocity MillimeterPerWeek = new("millimeter per week", "mm/wk", CentimeterPerDay, 1.0 / 10.0 / 7.0, system: "SI");
   
   /// <summary>
   /// femtometer per hour defined such that: picometer per minute = fm/hr × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity FemtometerPerHour = new("femtometer per hour", "fm/hr", PicometerPerMinute, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// kilometer per minute defined such that: hectometer per second = km/min × (10.0)/(60.0).
   /// </summary>
   public static readonly Velocity KilometerPerMinute = new("kilometer per minute", "km/min", HectometerPerSecond, 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per nonillion years defined such that: meter per octillion years = m/Qyr × (1.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MeterPerNonillionYears = new("meter per nonillion years", "m/Qyr", MeterPerOctillionYears, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per minute defined such that: kilometer per second = Mm/min × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity MegameterPerMinute = new("megameter per minute", "Mm/min", KilometerPerSecond, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per decillion years defined such that: meter per nonillion years = m/decillion yr × (1.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MeterPerDecillionYears = new("meter per decillion years", "m/decillion yr", MeterPerNonillionYears, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// decimeter per million years defined such that: meter per millennium = dm/Myr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerMillionYears = new("decimeter per million years", "dm/Myr", MeterPerMillennium, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// centimeter per decade defined such that: decimeter per year = cm/decade × (1.0/10.0)/(10.0).
   /// </summary>
   public static readonly Velocity CentimeterPerDecade = new("centimeter per decade", "cm/decade", DecimeterPerYear, 1.0 / 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// nanometer per day defined such that: micrometer per hour = nm/dy × (1.0/1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity NanometerPerDay = new("nanometer per day", "nm/dy", MicrometerPerHour, 1.0 / 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// attometer per hour defined such that: femtometer per minute = am/hr × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity AttometerPerHour = new("attometer per hour", "am/hr", FemtometerPerMinute, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// gigameter per minute defined such that: megameter per second = Gm/min × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity GigameterPerMinute = new("gigameter per minute", "Gm/min", MegameterPerSecond, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// terameter per minute defined such that: gigameter per second = Tm/min × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity TerameterPerMinute = new("terameter per minute", "Tm/min", GigameterPerSecond, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// meter per tick defined such that: meter per nanosecond = m/tick × (1.0)/(100.0).
   /// </summary>
   public static readonly Velocity MeterPerTick = new("meter per tick", "m/tick", MeterPerNanosecond, 1.0 / 100.0, system: "SI");
   
   /// <summary>
   /// decimeter per billion years defined such that: meter per million years = dm/Gyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerBillionYears = new("decimeter per billion years", "dm/Gyr", MeterPerMillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// millimeter per year defined such that: centimeter per day = mm/yr × (1.0/10.0)/(365.2525).
   /// </summary>
   public static readonly Velocity MillimeterPerYear = new("millimeter per year", "mm/yr", CentimeterPerDay, 1.0 / 10.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// micrometer per week defined such that: millimeter per day = μm/wk × (1.0/1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity MicrometerPerWeek = new("micrometer per week", "μm/wk", MillimeterPerDay, 1.0 / 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// zeptometer per hour defined such that: attometer per minute = zm/hr × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerHour = new("zeptometer per hour", "zm/hr", AttometerPerMinute, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// petameter per minute defined such that: terameter per second = Pm/min × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity PetameterPerMinute = new("petameter per minute", "Pm/min", TerameterPerSecond, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// centimeter per century defined such that: decimeter per decade = cm/century × (1.0/10.0)/(10.0).
   /// </summary>
   public static readonly Velocity CentimeterPerCentury = new("centimeter per century", "cm/century", DecimeterPerDecade, 1.0 / 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// picometer per day defined such that: nanometer per hour = pm/dy × (1.0/1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity PicometerPerDay = new("picometer per day", "pm/dy", NanometerPerHour, 1.0 / 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// exameter per minute defined such that: petameter per second = Em/min × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity ExameterPerMinute = new("exameter per minute", "Em/min", PetameterPerSecond, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// decimeter per trillion years defined such that: meter per billion years = dm/Tyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerTrillionYears =
      new("decimeter per trillion years", "dm/Tyr", MeterPerBillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per hour defined such that: zeptometer per minute = ym/hr × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity YoctometerPerHour = new("yoctometer per hour", "ym/hr", ZeptometerPerMinute, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// zettameter per minute defined such that: exameter per second = Zm/min × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity ZettameterPerMinute = new("zettameter per minute", "Zm/min", ExameterPerSecond, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// yottameter per minute defined such that: zettameter per second = Ym/min × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity YottameterPerMinute = new("yottameter per minute", "Ym/min", ZettameterPerSecond, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// decimeter per quadrillion years defined such that: meter per trillion years = dm/Pyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerQuadrillionYears =
      new("decimeter per quadrillion years", "dm/Pyr", MeterPerTrillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// centimeter per millennium defined such that: decimeter per century = cm/kyr × (1.0/10.0)/(10.0).
   /// </summary>
   public static readonly Velocity CentimeterPerMillennium = new("centimeter per millennium", "cm/kyr", DecimeterPerCentury, 1.0 / 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millimeter per decade defined such that: centimeter per year = mm/decade × (1.0/10.0)/(10.0).
   /// </summary>
   public static readonly Velocity MillimeterPerDecade = new("millimeter per decade", "mm/decade", CentimeterPerYear, 1.0 / 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// nanometer per week defined such that: micrometer per day = nm/wk × (1.0/1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity NanometerPerWeek = new("nanometer per week", "nm/wk", MicrometerPerDay, 1.0 / 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// femtometer per day defined such that: picometer per hour = fm/dy × (1.0/1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity FemtometerPerDay = new("femtometer per day", "fm/dy", PicometerPerHour, 1.0 / 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// rontometer per hour defined such that: yoctometer per minute = rm/hr × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity RontometerPerHour = new("rontometer per hour", "rm/hr", YoctometerPerMinute, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// ronnameter per minute defined such that: yottameter per second = Rm/min × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity RonnameterPerMinute = new("ronnameter per minute", "Rm/min", YottameterPerSecond, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// micrometer per year defined such that: millimeter per day = μm/yr × (1.0/1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity MicrometerPerYear = new("micrometer per year", "μm/yr", MillimeterPerDay, 1.0 / 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// quettameter per minute defined such that: ronnameter per second = Qm/min × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity QuettameterPerMinute = new("quettameter per minute", "Qm/min", RonnameterPerSecond, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// decimeter per quintillion years defined such that: meter per quadrillion years = dm/Eyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerQuintillionYears =
      new("decimeter per quintillion years", "dm/Eyr", MeterPerQuadrillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per hour defined such that: rontometer per minute = qm/hr × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity QuectometerPerHour = new("quectometer per hour", "qm/hr", RontometerPerMinute, 1.0 / 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// centimeter per million years defined such that: decimeter per millennium = cm/Myr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerMillionYears =
      new("centimeter per million years", "cm/Myr", DecimeterPerMillennium, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attometer per day defined such that: femtometer per hour = am/dy × (1.0/1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity AttometerPerDay = new("attometer per day", "am/dy", FemtometerPerHour, 1.0 / 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// decimeter per sextillion years defined such that: meter per quintillion years = dm/Zyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerSextillionYears =
      new("decimeter per sextillion years", "dm/Zyr", MeterPerQuintillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// millimeter per century defined such that: centimeter per decade = mm/century × (1.0/10.0)/(10.0).
   /// </summary>
   public static readonly Velocity MillimeterPerCentury = new("millimeter per century", "mm/century", CentimeterPerDecade, 1.0 / 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// picometer per week defined such that: nanometer per day = pm/wk × (1.0/1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity PicometerPerWeek = new("picometer per week", "pm/wk", NanometerPerDay, 1.0 / 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// dekameter per hour defined such that: meter per minute = dam/hr × (10.0)/(60.0).
   /// </summary>
   public static readonly Velocity DekameterPerHour = new("dekameter per hour", "dam/hr", MeterPerMinute, 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// decimeter per septillion years defined such that: meter per sextillion years = dm/Yyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerSeptillionYears =
      new("decimeter per septillion years", "dm/Yyr", MeterPerSextillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// centimeter per billion years defined such that: decimeter per million years = cm/Gyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerBillionYears =
      new("centimeter per billion years", "cm/Gyr", DecimeterPerMillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// micrometer per decade defined such that: millimeter per year = μm/decade × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity MicrometerPerDecade = new("micrometer per decade", "μm/decade", MillimeterPerYear, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// nanometer per year defined such that: micrometer per day = nm/yr × (1.0/1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity NanometerPerYear = new("nanometer per year", "nm/yr", MicrometerPerDay, 1.0 / 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// zeptometer per day defined such that: attometer per hour = zm/dy × (1.0/1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerDay = new("zeptometer per day", "zm/dy", AttometerPerHour, 1.0 / 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// hectometer per hour defined such that: dekameter per minute = hm/hr × (10.0)/(60.0).
   /// </summary>
   public static readonly Velocity HectometerPerHour = new("hectometer per hour", "hm/hr", DekameterPerMinute, 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// decimeter per octillion years defined such that: meter per septillion years = dm/Ryr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerOctillionYears =
      new("decimeter per octillion years", "dm/Ryr", MeterPerSeptillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// millimeter per millennium defined such that: centimeter per century = mm/kyr × (1.0/10.0)/(10.0).
   /// </summary>
   public static readonly Velocity MillimeterPerMillennium = new("millimeter per millennium", "mm/kyr", CentimeterPerCentury, 1.0 / 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// femtometer per week defined such that: picometer per day = fm/wk × (1.0/1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity FemtometerPerWeek = new("femtometer per week", "fm/wk", PicometerPerDay, 1.0 / 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// kilometer per hour defined such that: hectometer per minute = km/hr × (10.0)/(60.0).
   /// </summary>
   public static readonly Velocity KilometerPerHour = new("kilometer per hour", "km/hr", HectometerPerMinute, 10.0 / 60.0, system: "SI");
   
   /// <summary>
   /// centimeter per trillion years defined such that: decimeter per billion years = cm/Tyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerTrillionYears =
      new("centimeter per trillion years", "cm/Tyr", DecimeterPerBillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per day defined such that: zeptometer per hour = ym/dy × (1.0/1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity YoctometerPerDay = new("yoctometer per day", "ym/dy", ZeptometerPerHour, 1.0 / 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// decimeter per nonillion years defined such that: meter per octillion years = dm/Qyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerNonillionYears =
      new("decimeter per nonillion years", "dm/Qyr", MeterPerOctillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per hour defined such that: kilometer per minute = Mm/hr × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity MegameterPerHour = new("megameter per hour", "Mm/hr", KilometerPerMinute, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// micrometer per century defined such that: millimeter per decade = μm/century × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity MicrometerPerCentury = new("micrometer per century", "μm/century", MillimeterPerDecade, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// picometer per year defined such that: nanometer per day = pm/yr × (1.0/1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity PicometerPerYear = new("picometer per year", "pm/yr", NanometerPerDay, 1.0 / 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// decimeter per decillion years defined such that: meter per nonillion years = dm/decillion yr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DecimeterPerDecillionYears =
      new("decimeter per decillion years", "dm/decillion yr", MeterPerNonillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// centimeter per quadrillion years defined such that: decimeter per trillion years = cm/Pyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerQuadrillionYears =
      new("centimeter per quadrillion years", "cm/Pyr", DecimeterPerTrillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// millimeter per million years defined such that: centimeter per millennium = mm/Myr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerMillionYears =
      new("millimeter per million years", "mm/Myr", CentimeterPerMillennium, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanometer per decade defined such that: micrometer per year = nm/decade × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity NanometerPerDecade = new("nanometer per decade", "nm/decade", MicrometerPerYear, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// attometer per week defined such that: femtometer per day = am/wk × (1.0/1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity AttometerPerWeek = new("attometer per week", "am/wk", FemtometerPerDay, 1.0 / 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// rontometer per day defined such that: yoctometer per hour = rm/dy × (1.0/1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity RontometerPerDay = new("rontometer per day", "rm/dy", YoctometerPerHour, 1.0 / 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// gigameter per hour defined such that: megameter per minute = Gm/hr × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity GigameterPerHour = new("gigameter per hour", "Gm/hr", MegameterPerMinute, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// terameter per hour defined such that: gigameter per minute = Tm/hr × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity TerameterPerHour = new("terameter per hour", "Tm/hr", GigameterPerMinute, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// centimeter per quintillion years defined such that: decimeter per quadrillion years = cm/Eyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerQuintillionYears =
      new("centimeter per quintillion years", "cm/Eyr", DecimeterPerQuadrillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per day defined such that: rontometer per hour = qm/dy × (1.0/1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity QuectometerPerDay = new("quectometer per day", "qm/dy", RontometerPerHour, 1.0 / 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// decimeter per tick defined such that: meter per nanosecond = dm/tick × (1.0/10.0)/(100.0).
   /// </summary>
   public static readonly Velocity DecimeterPerTick = new("decimeter per tick", "dm/tick", MeterPerNanosecond, 1.0 / 10.0 / 100.0, system: "SI");
   
   /// <summary>
   /// millimeter per billion years defined such that: centimeter per million years = mm/Gyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerBillionYears =
      new("millimeter per billion years", "mm/Gyr", CentimeterPerMillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// micrometer per millennium defined such that: millimeter per century = μm/kyr × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity MicrometerPerMillennium = new("micrometer per millennium", "μm/kyr", MillimeterPerCentury, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// femtometer per year defined such that: picometer per day = fm/yr × (1.0/1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity FemtometerPerYear = new("femtometer per year", "fm/yr", PicometerPerDay, 1.0 / 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// zeptometer per week defined such that: attometer per day = zm/wk × (1.0/1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerWeek = new("zeptometer per week", "zm/wk", AttometerPerDay, 1.0 / 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// petameter per hour defined such that: terameter per minute = Pm/hr × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity PetameterPerHour = new("petameter per hour", "Pm/hr", TerameterPerMinute, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// centimeter per sextillion years defined such that: decimeter per quintillion years = cm/Zyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerSextillionYears =
      new("centimeter per sextillion years", "cm/Zyr", DecimeterPerQuintillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanometer per century defined such that: micrometer per decade = nm/century × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity NanometerPerCentury = new("nanometer per century", "nm/century", MicrometerPerDecade, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// picometer per decade defined such that: nanometer per year = pm/decade × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity PicometerPerDecade = new("picometer per decade", "pm/decade", NanometerPerYear, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// dekameter per day defined such that: meter per hour = dam/dy × (10.0)/(24.0).
   /// </summary>
   public static readonly Velocity DekameterPerDay = new("dekameter per day", "dam/dy", MeterPerHour, 10.0 / 24.0, system: "SI");
   
   /// <summary>
   /// exameter per hour defined such that: petameter per minute = Em/hr × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity ExameterPerHour = new("exameter per hour", "Em/hr", PetameterPerMinute, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// millimeter per trillion years defined such that: centimeter per billion years = mm/Tyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerTrillionYears =
      new("millimeter per trillion years", "mm/Tyr", CentimeterPerBillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per week defined such that: zeptometer per day = ym/wk × (1.0/1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity YoctometerPerWeek = new("yoctometer per week", "ym/wk", ZeptometerPerDay, 1.0 / 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// zettameter per hour defined such that: exameter per minute = Zm/hr × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity ZettameterPerHour = new("zettameter per hour", "Zm/hr", ExameterPerMinute, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// centimeter per septillion years defined such that: decimeter per sextillion years = cm/Yyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerSeptillionYears =
      new("centimeter per septillion years", "cm/Yyr", DecimeterPerSextillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// micrometer per million years defined such that: millimeter per millennium = μm/Myr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerMillionYears =
      new("micrometer per million years", "μm/Myr", MillimeterPerMillennium, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attometer per year defined such that: femtometer per day = am/yr × (1.0/1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity AttometerPerYear = new("attometer per year", "am/yr", FemtometerPerDay, 1.0 / 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// hectometer per day defined such that: dekameter per hour = hm/dy × (10.0)/(24.0).
   /// </summary>
   public static readonly Velocity HectometerPerDay = new("hectometer per day", "hm/dy", DekameterPerHour, 10.0 / 24.0, system: "SI");
   
   /// <summary>
   /// yottameter per hour defined such that: zettameter per minute = Ym/hr × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity YottameterPerHour = new("yottameter per hour", "Ym/hr", ZettameterPerMinute, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// centimeter per octillion years defined such that: decimeter per septillion years = cm/Ryr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerOctillionYears =
      new("centimeter per octillion years", "cm/Ryr", DecimeterPerSeptillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// millimeter per quadrillion years defined such that: centimeter per trillion years = mm/Pyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerQuadrillionYears =
      new("millimeter per quadrillion years", "mm/Pyr", CentimeterPerTrillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanometer per millennium defined such that: micrometer per century = nm/kyr × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity NanometerPerMillennium = new("nanometer per millennium", "nm/kyr", MicrometerPerCentury, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// femtometer per decade defined such that: picometer per year = fm/decade × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity FemtometerPerDecade = new("femtometer per decade", "fm/decade", PicometerPerYear, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// rontometer per week defined such that: yoctometer per day = rm/wk × (1.0/1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity RontometerPerWeek = new("rontometer per week", "rm/wk", YoctometerPerDay, 1.0 / 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// kilometer per day defined such that: hectometer per hour = km/dy × (10.0)/(24.0).
   /// </summary>
   public static readonly Velocity KilometerPerDay = new("kilometer per day", "km/dy", HectometerPerHour, 10.0 / 24.0, system: "SI");
   
   /// <summary>
   /// ronnameter per hour defined such that: yottameter per minute = Rm/hr × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity RonnameterPerHour = new("ronnameter per hour", "Rm/hr", YottameterPerMinute, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// picometer per century defined such that: nanometer per decade = pm/century × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity PicometerPerCentury = new("picometer per century", "pm/century", NanometerPerDecade, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// micrometer per billion years defined such that: millimeter per million years = μm/Gyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerBillionYears =
      new("micrometer per billion years", "μm/Gyr", MillimeterPerMillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptometer per year defined such that: attometer per day = zm/yr × (1.0/1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity ZeptometerPerYear = new("zeptometer per year", "zm/yr", AttometerPerDay, 1.0 / 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// quettameter per hour defined such that: ronnameter per minute = Qm/hr × (1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity QuettameterPerHour = new("quettameter per hour", "Qm/hr", RonnameterPerMinute, 1000.0 / 60.0, system: "SI");
   
   /// <summary>
   /// centimeter per nonillion years defined such that: decimeter per octillion years = cm/Qyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerNonillionYears =
      new("centimeter per nonillion years", "cm/Qyr", DecimeterPerOctillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per day defined such that: kilometer per hour = Mm/dy × (1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity MegameterPerDay = new("megameter per day", "Mm/dy", KilometerPerHour, 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// millimeter per quintillion years defined such that: centimeter per quadrillion years = mm/Eyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerQuintillionYears =
      new("millimeter per quintillion years", "mm/Eyr", CentimeterPerQuadrillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per week defined such that: rontometer per day = qm/wk × (1.0/1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity QuectometerPerWeek = new("quectometer per week", "qm/wk", RontometerPerDay, 1.0 / 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// centimeter per decillion years defined such that: decimeter per nonillion years = cm/decillion yr ×
   /// (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CentimeterPerDecillionYears =
      new("centimeter per decillion years", "cm/decillion yr", DecimeterPerNonillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanometer per million years defined such that: micrometer per millennium = nm/Myr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerMillionYears =
      new("nanometer per million years", "nm/Myr", MicrometerPerMillennium, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attometer per decade defined such that: femtometer per year = am/decade × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity AttometerPerDecade = new("attometer per decade", "am/decade", FemtometerPerYear, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// gigameter per day defined such that: megameter per hour = Gm/dy × (1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity GigameterPerDay = new("gigameter per day", "Gm/dy", MegameterPerHour, 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// micrometer per trillion years defined such that: millimeter per billion years = μm/Tyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerTrillionYears =
      new("micrometer per trillion years", "μm/Tyr", MillimeterPerBillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per year defined such that: zeptometer per day = ym/yr × (1.0/1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity YoctometerPerYear = new("yoctometer per year", "ym/yr", ZeptometerPerDay, 1.0 / 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// millimeter per sextillion years defined such that: centimeter per quintillion years = mm/Zyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerSextillionYears =
      new("millimeter per sextillion years", "mm/Zyr", CentimeterPerQuintillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picometer per millennium defined such that: nanometer per century = pm/kyr × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity PicometerPerMillennium = new("picometer per millennium", "pm/kyr", NanometerPerCentury, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// femtometer per century defined such that: picometer per decade = fm/century × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity FemtometerPerCentury = new("femtometer per century", "fm/century", PicometerPerDecade, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// dekameter per week defined such that: meter per day = dam/wk × (10.0)/(7.0).
   /// </summary>
   public static readonly Velocity DekameterPerWeek = new("dekameter per week", "dam/wk", MeterPerDay, 10.0 / 7.0, system: "SI");
   
   /// <summary>
   /// terameter per day defined such that: gigameter per hour = Tm/dy × (1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity TerameterPerDay = new("terameter per day", "Tm/dy", GigameterPerHour, 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// centimeter per tick defined such that: decimeter per nanosecond = cm/tick × (1.0/10.0)/(100.0).
   /// </summary>
   public static readonly Velocity CentimeterPerTick = new("centimeter per tick", "cm/tick", DecimeterPerNanosecond, 1.0 / 10.0 / 100.0, system: "SI");
   
   /// <summary>
   /// millimeter per septillion years defined such that: centimeter per sextillion years = mm/Yyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerSeptillionYears =
      new("millimeter per septillion years", "mm/Yyr", CentimeterPerSextillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// micrometer per quadrillion years defined such that: millimeter per trillion years = μm/Pyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerQuadrillionYears =
      new("micrometer per quadrillion years", "μm/Pyr", MillimeterPerTrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanometer per billion years defined such that: micrometer per million years = nm/Gyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerBillionYears =
      new("nanometer per billion years", "nm/Gyr", MicrometerPerMillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptometer per decade defined such that: attometer per year = zm/decade × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerDecade = new("zeptometer per decade", "zm/decade", AttometerPerYear, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// rontometer per year defined such that: yoctometer per day = rm/yr × (1.0/1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity RontometerPerYear = new("rontometer per year", "rm/yr", YoctometerPerDay, 1.0 / 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// hectometer per week defined such that: dekameter per day = hm/wk × (10.0)/(7.0).
   /// </summary>
   public static readonly Velocity HectometerPerWeek = new("hectometer per week", "hm/wk", DekameterPerDay, 10.0 / 7.0, system: "SI");
   
   /// <summary>
   /// petameter per day defined such that: terameter per hour = Pm/dy × (1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity PetameterPerDay = new("petameter per day", "Pm/dy", TerameterPerHour, 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// picometer per million years defined such that: nanometer per millennium = pm/Myr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerMillionYears =
      new("picometer per million years", "pm/Myr", NanometerPerMillennium, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attometer per century defined such that: femtometer per decade = am/century × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity AttometerPerCentury = new("attometer per century", "am/century", FemtometerPerDecade, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// exameter per day defined such that: petameter per hour = Em/dy × (1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity ExameterPerDay = new("exameter per day", "Em/dy", PetameterPerHour, 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// millimeter per octillion years defined such that: centimeter per septillion years = mm/Ryr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerOctillionYears =
      new("millimeter per octillion years", "mm/Ryr", CentimeterPerSeptillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtometer per millennium defined such that: picometer per century = fm/kyr × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity FemtometerPerMillennium = new("femtometer per millennium", "fm/kyr", PicometerPerCentury, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// kilometer per week defined such that: hectometer per day = km/wk × (10.0)/(7.0).
   /// </summary>
   public static readonly Velocity KilometerPerWeek = new("kilometer per week", "km/wk", HectometerPerDay, 10.0 / 7.0, system: "SI");
   
   /// <summary>
   /// micrometer per quintillion years defined such that: millimeter per quadrillion years = μm/Eyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerQuintillionYears =
      new("micrometer per quintillion years", "μm/Eyr", MillimeterPerQuadrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per year defined such that: rontometer per day = qm/yr × (1.0/1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity QuectometerPerYear = new("quectometer per year", "qm/yr", RontometerPerDay, 1.0 / 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// nanometer per trillion years defined such that: micrometer per billion years = nm/Tyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerTrillionYears =
      new("nanometer per trillion years", "nm/Tyr", MicrometerPerBillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per decade defined such that: zeptometer per year = ym/decade × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity YoctometerPerDecade = new("yoctometer per decade", "ym/decade", ZeptometerPerYear, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// zettameter per day defined such that: exameter per hour = Zm/dy × (1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity ZettameterPerDay = new("zettameter per day", "Zm/dy", ExameterPerHour, 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// millimeter per nonillion years defined such that: centimeter per octillion years = mm/Qyr × (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerNonillionYears =
      new("millimeter per nonillion years", "mm/Qyr", CentimeterPerOctillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per week defined such that: kilometer per day = Mm/wk × (1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity MegameterPerWeek = new("megameter per week", "Mm/wk", KilometerPerDay, 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// yottameter per day defined such that: zettameter per hour = Ym/dy × (1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity YottameterPerDay = new("yottameter per day", "Ym/dy", ZettameterPerHour, 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// micrometer per sextillion years defined such that: millimeter per quintillion years = μm/Zyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerSextillionYears =
      new("micrometer per sextillion years", "μm/Zyr", MillimeterPerQuintillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picometer per billion years defined such that: nanometer per million years = pm/Gyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerBillionYears =
      new("picometer per billion years", "pm/Gyr", NanometerPerMillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptometer per century defined such that: attometer per decade = zm/century × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerCentury = new("zeptometer per century", "zm/century", AttometerPerDecade, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// dekameter per year defined such that: meter per day = dam/yr × (10.0)/(365.2525).
   /// </summary>
   public static readonly Velocity DekameterPerYear = new("dekameter per year", "dam/yr", MeterPerDay, 10.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// millimeter per decillion years defined such that: centimeter per nonillion years = mm/decillion yr ×
   /// (1.0/10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MillimeterPerDecillionYears =
      new("millimeter per decillion years", "mm/decillion yr", CentimeterPerNonillionYears, 1.0 / 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanometer per quadrillion years defined such that: micrometer per trillion years = nm/Pyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerQuadrillionYears =
      new("nanometer per quadrillion years", "nm/Pyr", MicrometerPerTrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtometer per million years defined such that: picometer per millennium = fm/Myr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerMillionYears =
      new("femtometer per million years", "fm/Myr", PicometerPerMillennium, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attometer per millennium defined such that: femtometer per century = am/kyr × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity AttometerPerMillennium = new("attometer per millennium", "am/kyr", FemtometerPerCentury, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// rontometer per decade defined such that: yoctometer per year = rm/decade × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity RontometerPerDecade = new("rontometer per decade", "rm/decade", YoctometerPerYear, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// gigameter per week defined such that: megameter per day = Gm/wk × (1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity GigameterPerWeek = new("gigameter per week", "Gm/wk", MegameterPerDay, 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// ronnameter per day defined such that: yottameter per hour = Rm/dy × (1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity RonnameterPerDay = new("ronnameter per day", "Rm/dy", YottameterPerHour, 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// micrometer per septillion years defined such that: millimeter per sextillion years = μm/Yyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerSeptillionYears =
      new("micrometer per septillion years", "μm/Yyr", MillimeterPerSextillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per year defined such that: dekameter per day = hm/yr × (10.0)/(365.2525).
   /// </summary>
   public static readonly Velocity HectometerPerYear = new("hectometer per year", "hm/yr", DekameterPerDay, 10.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// quettameter per day defined such that: ronnameter per hour = Qm/dy × (1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity QuettameterPerDay = new("quettameter per day", "Qm/dy", RonnameterPerHour, 1000.0 / 24.0, system: "SI");
   
   /// <summary>
   /// terameter per week defined such that: gigameter per day = Tm/wk × (1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity TerameterPerWeek = new("terameter per week", "Tm/wk", GigameterPerDay, 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// picometer per trillion years defined such that: nanometer per billion years = pm/Tyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerTrillionYears =
      new("picometer per trillion years", "pm/Tyr", NanometerPerBillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per century defined such that: zeptometer per decade = ym/century × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity YoctometerPerCentury = new("yoctometer per century", "ym/century", ZeptometerPerDecade, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// nanometer per quintillion years defined such that: micrometer per quadrillion years = nm/Eyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerQuintillionYears =
      new("nanometer per quintillion years", "nm/Eyr", MicrometerPerQuadrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per decade defined such that: rontometer per year = qm/decade × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity QuectometerPerDecade = new("quectometer per decade", "qm/decade", RontometerPerYear, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millimeter per tick defined such that: centimeter per nanosecond = mm/tick × (1.0/10.0)/(100.0).
   /// </summary>
   public static readonly Velocity MillimeterPerTick = new("millimeter per tick", "mm/tick", CentimeterPerNanosecond, 1.0 / 10.0 / 100.0, system: "SI");
   
   /// <summary>
   /// micrometer per octillion years defined such that: millimeter per septillion years = μm/Ryr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerOctillionYears =
      new("micrometer per octillion years", "μm/Ryr", MillimeterPerSeptillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtometer per billion years defined such that: picometer per million years = fm/Gyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerBillionYears =
      new("femtometer per billion years", "fm/Gyr", PicometerPerMillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptometer per millennium defined such that: attometer per century = zm/kyr × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerMillennium = new("zeptometer per millennium", "zm/kyr", AttometerPerCentury, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// kilometer per year defined such that: hectometer per day = km/yr × (10.0)/(365.2525).
   /// </summary>
   public static readonly Velocity KilometerPerYear = new("kilometer per year", "km/yr", HectometerPerDay, 10.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// petameter per week defined such that: terameter per day = Pm/wk × (1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity PetameterPerWeek = new("petameter per week", "Pm/wk", TerameterPerDay, 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// attometer per million years defined such that: femtometer per millennium = am/Myr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerMillionYears =
      new("attometer per million years", "am/Myr", FemtometerPerMillennium, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanometer per sextillion years defined such that: micrometer per quintillion years = nm/Zyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerSextillionYears =
      new("nanometer per sextillion years", "nm/Zyr", MicrometerPerQuintillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picometer per quadrillion years defined such that: nanometer per trillion years = pm/Pyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerQuadrillionYears =
      new("picometer per quadrillion years", "pm/Pyr", NanometerPerTrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontometer per century defined such that: yoctometer per decade = rm/century × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity RontometerPerCentury = new("rontometer per century", "rm/century", YoctometerPerDecade, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// dekameter per decade defined such that: meter per year = dam/decade × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity DekameterPerDecade = new("dekameter per decade", "dam/decade", MeterPerYear, 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// exameter per week defined such that: petameter per day = Em/wk × (1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity ExameterPerWeek = new("exameter per week", "Em/wk", PetameterPerDay, 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// micrometer per nonillion years defined such that: millimeter per octillion years = μm/Qyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerNonillionYears =
      new("micrometer per nonillion years", "μm/Qyr", MillimeterPerOctillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per year defined such that: kilometer per day = Mm/yr × (1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity MegameterPerYear = new("megameter per year", "Mm/yr", KilometerPerDay, 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// femtometer per trillion years defined such that: picometer per billion years = fm/Tyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerTrillionYears =
      new("femtometer per trillion years", "fm/Tyr", PicometerPerBillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per millennium defined such that: zeptometer per century = ym/kyr × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity YoctometerPerMillennium = new("yoctometer per millennium", "ym/kyr", ZeptometerPerCentury, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// zettameter per week defined such that: exameter per day = Zm/wk × (1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity ZettameterPerWeek = new("zettameter per week", "Zm/wk", ExameterPerDay, 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// micrometer per decillion years defined such that: millimeter per nonillion years = μm/decillion yr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MicrometerPerDecillionYears =
      new("micrometer per decillion years", "μm/decillion yr", MillimeterPerNonillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanometer per septillion years defined such that: micrometer per sextillion years = nm/Yyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerSeptillionYears =
      new("nanometer per septillion years", "nm/Yyr", MicrometerPerSextillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attometer per billion years defined such that: femtometer per million years = am/Gyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerBillionYears =
      new("attometer per billion years", "am/Gyr", FemtometerPerMillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptometer per million years defined such that: attometer per millennium = zm/Myr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerMillionYears =
      new("zeptometer per million years", "zm/Myr", AttometerPerMillennium, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per decade defined such that: dekameter per year = hm/decade × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity HectometerPerDecade = new("hectometer per decade", "hm/decade", DekameterPerYear, 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// gigameter per year defined such that: megameter per day = Gm/yr × (1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity GigameterPerYear = new("gigameter per year", "Gm/yr", MegameterPerDay, 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// picometer per quintillion years defined such that: nanometer per quadrillion years = pm/Eyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerQuintillionYears =
      new("picometer per quintillion years", "pm/Eyr", NanometerPerQuadrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per century defined such that: rontometer per decade = qm/century × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity QuectometerPerCentury = new("quectometer per century", "qm/century", RontometerPerDecade, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// yottameter per week defined such that: zettameter per day = Ym/wk × (1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity YottameterPerWeek = new("yottameter per week", "Ym/wk", ZettameterPerDay, 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// terameter per year defined such that: gigameter per day = Tm/yr × (1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity TerameterPerYear = new("terameter per year", "Tm/yr", GigameterPerDay, 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// nanometer per octillion years defined such that: micrometer per septillion years = nm/Ryr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerOctillionYears =
      new("nanometer per octillion years", "nm/Ryr", MicrometerPerSeptillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtometer per quadrillion years defined such that: picometer per trillion years = fm/Pyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerQuadrillionYears =
      new("femtometer per quadrillion years", "fm/Pyr", PicometerPerTrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontometer per millennium defined such that: yoctometer per century = rm/kyr × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity RontometerPerMillennium = new("rontometer per millennium", "rm/kyr", YoctometerPerCentury, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// kilometer per decade defined such that: hectometer per year = km/decade × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity KilometerPerDecade = new("kilometer per decade", "km/decade", HectometerPerYear, 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// ronnameter per week defined such that: yottameter per day = Rm/wk × (1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity RonnameterPerWeek = new("ronnameter per week", "Rm/wk", YottameterPerDay, 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// picometer per sextillion years defined such that: nanometer per quintillion years = pm/Zyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerSextillionYears =
      new("picometer per sextillion years", "pm/Zyr", NanometerPerQuintillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per century defined such that: meter per decade = dam/century × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity DekameterPerCentury = new("dekameter per century", "dam/century", MeterPerDecade, 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// attometer per trillion years defined such that: femtometer per billion years = am/Tyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerTrillionYears =
      new("attometer per trillion years", "am/Tyr", FemtometerPerBillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per million years defined such that: zeptometer per millennium = ym/Myr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerMillionYears =
      new("yoctometer per million years", "ym/Myr", ZeptometerPerMillennium, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// micrometer per tick defined such that: millimeter per nanosecond = μm/tick × (1.0/1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity MicrometerPerTick = new("micrometer per tick", "μm/tick", MillimeterPerNanosecond, 1.0 / 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// zeptometer per billion years defined such that: attometer per million years = zm/Gyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerBillionYears =
      new("zeptometer per billion years", "zm/Gyr", AttometerPerMillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// petameter per year defined such that: terameter per day = Pm/yr × (1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity PetameterPerYear = new("petameter per year", "Pm/yr", TerameterPerDay, 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// quettameter per week defined such that: ronnameter per day = Qm/wk × (1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity QuettameterPerWeek = new("quettameter per week", "Qm/wk", RonnameterPerDay, 1000.0 / 7.0, system: "SI");
   
   /// <summary>
   /// nanometer per nonillion years defined such that: micrometer per octillion years = nm/Qyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerNonillionYears =
      new("nanometer per nonillion years", "nm/Qyr", MicrometerPerOctillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per decade defined such that: kilometer per year = Mm/decade × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity MegameterPerDecade = new("megameter per decade", "Mm/decade", KilometerPerYear, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// femtometer per quintillion years defined such that: picometer per quadrillion years = fm/Eyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerQuintillionYears =
      new("femtometer per quintillion years", "fm/Eyr", PicometerPerQuadrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per millennium defined such that: rontometer per century = qm/kyr × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity QuectometerPerMillennium = new("quectometer per millennium", "qm/kyr", RontometerPerCentury, 1.0 / 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// picometer per septillion years defined such that: nanometer per sextillion years = pm/Yyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerSeptillionYears =
      new("picometer per septillion years", "pm/Yyr", NanometerPerSextillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per century defined such that: dekameter per decade = hm/century × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity HectometerPerCentury = new("hectometer per century", "hm/century", DekameterPerDecade, 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// exameter per year defined such that: petameter per day = Em/yr × (1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity ExameterPerYear = new("exameter per year", "Em/yr", PetameterPerDay, 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// nanometer per decillion years defined such that: micrometer per nonillion years = nm/decillion yr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NanometerPerDecillionYears =
      new("nanometer per decillion years", "nm/decillion yr", MicrometerPerNonillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attometer per quadrillion years defined such that: femtometer per trillion years = am/Pyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerQuadrillionYears =
      new("attometer per quadrillion years", "am/Pyr", FemtometerPerTrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontometer per million years defined such that: yoctometer per millennium = rm/Myr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerMillionYears =
      new("rontometer per million years", "rm/Myr", YoctometerPerMillennium, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per decade defined such that: megameter per year = Gm/decade × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity GigameterPerDecade = new("gigameter per decade", "Gm/decade", MegameterPerYear, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// zeptometer per trillion years defined such that: attometer per billion years = zm/Tyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerTrillionYears =
      new("zeptometer per trillion years", "zm/Tyr", AttometerPerBillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per billion years defined such that: zeptometer per million years = ym/Gyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerBillionYears =
      new("yoctometer per billion years", "ym/Gyr", ZeptometerPerMillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per year defined such that: exameter per day = Zm/yr × (1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity ZettameterPerYear = new("zettameter per year", "Zm/yr", ExameterPerDay, 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// picometer per octillion years defined such that: nanometer per septillion years = pm/Ryr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerOctillionYears =
      new("picometer per octillion years", "pm/Ryr", NanometerPerSeptillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtometer per sextillion years defined such that: picometer per quintillion years = fm/Zyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerSextillionYears =
      new("femtometer per sextillion years", "fm/Zyr", PicometerPerQuintillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per millennium defined such that: meter per century = dam/kyr × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity DekameterPerMillennium = new("dekameter per millennium", "dam/kyr", MeterPerCentury, 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// kilometer per century defined such that: hectometer per decade = km/century × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity KilometerPerCentury = new("kilometer per century", "km/century", HectometerPerDecade, 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// terameter per decade defined such that: gigameter per year = Tm/decade × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity TerameterPerDecade = new("terameter per decade", "Tm/decade", GigameterPerYear, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// yottameter per year defined such that: zettameter per day = Ym/yr × (1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity YottameterPerYear = new("yottameter per year", "Ym/yr", ZettameterPerDay, 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// attometer per quintillion years defined such that: femtometer per quadrillion years = am/Eyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerQuintillionYears =
      new("attometer per quintillion years", "am/Eyr", FemtometerPerQuadrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per million years defined such that: rontometer per millennium = qm/Myr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerMillionYears =
      new("quectometer per million years", "qm/Myr", RontometerPerMillennium, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picometer per nonillion years defined such that: nanometer per octillion years = pm/Qyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerNonillionYears =
      new("picometer per nonillion years", "pm/Qyr", NanometerPerOctillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per century defined such that: kilometer per decade = Mm/century × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity MegameterPerCentury = new("megameter per century", "Mm/century", KilometerPerDecade, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// nanometer per tick defined such that: micrometer per nanosecond = nm/tick × (1.0/1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity NanometerPerTick = new("nanometer per tick", "nm/tick", MicrometerPerNanosecond, 1.0 / 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// femtometer per septillion years defined such that: picometer per sextillion years = fm/Yyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerSeptillionYears =
      new("femtometer per septillion years", "fm/Yyr", PicometerPerSextillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptometer per quadrillion years defined such that: attometer per trillion years = zm/Pyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerQuadrillionYears =
      new("zeptometer per quadrillion years", "zm/Pyr", AttometerPerTrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontometer per billion years defined such that: yoctometer per million years = rm/Gyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerBillionYears =
      new("rontometer per billion years", "rm/Gyr", YoctometerPerMillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per millennium defined such that: dekameter per century = hm/kyr × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity HectometerPerMillennium = new("hectometer per millennium", "hm/kyr", DekameterPerCentury, 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// petameter per decade defined such that: terameter per year = Pm/decade × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity PetameterPerDecade = new("petameter per decade", "Pm/decade", TerameterPerYear, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// ronnameter per year defined such that: yottameter per day = Rm/yr × (1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity RonnameterPerYear = new("ronnameter per year", "Rm/yr", YottameterPerDay, 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// yoctometer per trillion years defined such that: zeptometer per billion years = ym/Tyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerTrillionYears =
      new("yoctometer per trillion years", "ym/Tyr", ZeptometerPerBillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quettameter per year defined such that: ronnameter per day = Qm/yr × (1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity QuettameterPerYear = new("quettameter per year", "Qm/yr", RonnameterPerDay, 1000.0 / 365.2525, system: "SI");
   
   /// <summary>
   /// picometer per decillion years defined such that: nanometer per nonillion years = pm/decillion yr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicometerPerDecillionYears =
      new("picometer per decillion years", "pm/decillion yr", NanometerPerNonillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attometer per sextillion years defined such that: femtometer per quintillion years = am/Zyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerSextillionYears =
      new("attometer per sextillion years", "am/Zyr", FemtometerPerQuintillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per million years defined such that: meter per millennium = dam/Myr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerMillionYears = new("dekameter per million years", "dam/Myr", MeterPerMillennium, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per century defined such that: megameter per decade = Gm/century × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity GigameterPerCentury = new("gigameter per century", "Gm/century", MegameterPerDecade, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// exameter per decade defined such that: petameter per year = Em/decade × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ExameterPerDecade = new("exameter per decade", "Em/decade", PetameterPerYear, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// femtometer per octillion years defined such that: picometer per septillion years = fm/Ryr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerOctillionYears =
      new("femtometer per octillion years", "fm/Ryr", PicometerPerSeptillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per millennium defined such that: hectometer per century = km/kyr × (10.0)/(10.0).
   /// </summary>
   public static readonly Velocity KilometerPerMillennium = new("kilometer per millennium", "km/kyr", HectometerPerCentury, 10.0 / 10.0, system: "SI");
   
   /// <summary>
   /// zeptometer per quintillion years defined such that: attometer per quadrillion years = zm/Eyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerQuintillionYears =
      new("zeptometer per quintillion years", "zm/Eyr", AttometerPerQuadrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per billion years defined such that: rontometer per million years = qm/Gyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerBillionYears =
      new("quectometer per billion years", "qm/Gyr", RontometerPerMillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per quadrillion years defined such that: zeptometer per trillion years = ym/Pyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerQuadrillionYears =
      new("yoctometer per quadrillion years", "ym/Pyr", ZeptometerPerTrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontometer per trillion years defined such that: yoctometer per billion years = rm/Tyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerTrillionYears =
      new("rontometer per trillion years", "rm/Tyr", YoctometerPerBillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per decade defined such that: exameter per year = Zm/decade × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ZettameterPerDecade = new("zettameter per decade", "Zm/decade", ExameterPerYear, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// terameter per century defined such that: gigameter per decade = Tm/century × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity TerameterPerCentury = new("terameter per century", "Tm/century", GigameterPerDecade, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// attometer per septillion years defined such that: femtometer per sextillion years = am/Yyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerSeptillionYears =
      new("attometer per septillion years", "am/Yyr", FemtometerPerSextillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per million years defined such that: dekameter per millennium = hm/Myr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerMillionYears = new("hectometer per million years", "hm/Myr", DekameterPerMillennium, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtometer per nonillion years defined such that: picometer per octillion years = fm/Qyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerNonillionYears =
      new("femtometer per nonillion years", "fm/Qyr", PicometerPerOctillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per millennium defined such that: kilometer per century = Mm/kyr × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity MegameterPerMillennium = new("megameter per millennium", "Mm/kyr", KilometerPerCentury, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// yottameter per decade defined such that: zettameter per year = Ym/decade × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity YottameterPerDecade = new("yottameter per decade", "Ym/decade", ZettameterPerYear, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// picometer per tick defined such that: nanometer per nanosecond = pm/tick × (1.0/1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity PicometerPerTick = new("picometer per tick", "pm/tick", NanometerPerNanosecond, 1.0 / 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// zeptometer per sextillion years defined such that: attometer per quintillion years = zm/Zyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerSextillionYears =
      new("zeptometer per sextillion years", "zm/Zyr", AttometerPerQuintillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per billion years defined such that: meter per million years = dam/Gyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerBillionYears = new("dekameter per billion years", "dam/Gyr", MeterPerMillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// petameter per century defined such that: terameter per decade = Pm/century × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity PetameterPerCentury = new("petameter per century", "Pm/century", TerameterPerDecade, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// yoctometer per quintillion years defined such that: zeptometer per quadrillion years = ym/Eyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerQuintillionYears =
      new("yoctometer per quintillion years", "ym/Eyr", ZeptometerPerQuadrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per trillion years defined such that: rontometer per billion years = qm/Tyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerTrillionYears =
      new("quectometer per trillion years", "qm/Tyr", RontometerPerBillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtometer per decillion years defined such that: picometer per nonillion years = fm/decillion yr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FemtometerPerDecillionYears =
      new("femtometer per decillion years", "fm/decillion yr", PicometerPerNonillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attometer per octillion years defined such that: femtometer per septillion years = am/Ryr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerOctillionYears =
      new("attometer per octillion years", "am/Ryr", FemtometerPerSeptillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontometer per quadrillion years defined such that: yoctometer per trillion years = rm/Pyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerQuadrillionYears =
      new("rontometer per quadrillion years", "rm/Pyr", YoctometerPerTrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per million years defined such that: hectometer per millennium = km/Myr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerMillionYears = new("kilometer per million years", "km/Myr", HectometerPerMillennium, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per millennium defined such that: megameter per century = Gm/kyr × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity GigameterPerMillennium = new("gigameter per millennium", "Gm/kyr", MegameterPerCentury, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// ronnameter per decade defined such that: yottameter per year = Rm/decade × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity RonnameterPerDecade = new("ronnameter per decade", "Rm/decade", YottameterPerYear, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// exameter per century defined such that: petameter per decade = Em/century × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ExameterPerCentury = new("exameter per century", "Em/century", PetameterPerDecade, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// zeptometer per septillion years defined such that: attometer per sextillion years = zm/Yyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerSeptillionYears =
      new("zeptometer per septillion years", "zm/Yyr", AttometerPerSextillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per billion years defined such that: dekameter per million years = hm/Gyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerBillionYears = new("hectometer per billion years", "hm/Gyr", DekameterPerMillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quettameter per decade defined such that: ronnameter per year = Qm/decade × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity QuettameterPerDecade = new("quettameter per decade", "Qm/decade", RonnameterPerYear, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// terameter per millennium defined such that: gigameter per century = Tm/kyr × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity TerameterPerMillennium = new("terameter per millennium", "Tm/kyr", GigameterPerCentury, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// attometer per nonillion years defined such that: femtometer per octillion years = am/Qyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerNonillionYears =
      new("attometer per nonillion years", "am/Qyr", FemtometerPerOctillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per million years defined such that: kilometer per millennium = Mm/Myr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerMillionYears = new("megameter per million years", "Mm/Myr", KilometerPerMillennium, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per sextillion years defined such that: zeptometer per quintillion years = ym/Zyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerSextillionYears =
      new("yoctometer per sextillion years", "ym/Zyr", ZeptometerPerQuintillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per trillion years defined such that: meter per billion years = dam/Tyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerTrillionYears = new("dekameter per trillion years", "dam/Tyr", MeterPerBillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per century defined such that: exameter per decade = Zm/century × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ZettameterPerCentury = new("zettameter per century", "Zm/century", ExameterPerDecade, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// rontometer per quintillion years defined such that: yoctometer per quadrillion years = rm/Eyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerQuintillionYears =
      new("rontometer per quintillion years", "rm/Eyr", YoctometerPerQuadrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per quadrillion years defined such that: rontometer per trillion years = qm/Pyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerQuadrillionYears =
      new("quectometer per quadrillion years", "qm/Pyr", RontometerPerTrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtometer per tick defined such that: picometer per nanosecond = fm/tick × (1.0/1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity FemtometerPerTick = new("femtometer per tick", "fm/tick", PicometerPerNanosecond, 1.0 / 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// zeptometer per octillion years defined such that: attometer per septillion years = zm/Ryr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerOctillionYears =
      new("zeptometer per octillion years", "zm/Ryr", AttometerPerSeptillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per billion years defined such that: hectometer per million years = km/Gyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerBillionYears = new("kilometer per billion years", "km/Gyr", HectometerPerMillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// petameter per millennium defined such that: terameter per century = Pm/kyr × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity PetameterPerMillennium = new("petameter per millennium", "Pm/kyr", TerameterPerCentury, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// yottameter per century defined such that: zettameter per decade = Ym/century × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity YottameterPerCentury = new("yottameter per century", "Ym/century", ZettameterPerDecade, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// attometer per decillion years defined such that: femtometer per nonillion years = am/decillion yr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity AttometerPerDecillionYears =
      new("attometer per decillion years", "am/decillion yr", FemtometerPerNonillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per million years defined such that: megameter per millennium = Gm/Myr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerMillionYears = new("gigameter per million years", "Gm/Myr", MegameterPerMillennium, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per septillion years defined such that: zeptometer per sextillion years = ym/Yyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerSeptillionYears =
      new("yoctometer per septillion years", "ym/Yyr", ZeptometerPerSextillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per trillion years defined such that: dekameter per billion years = hm/Tyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerTrillionYears =
      new("hectometer per trillion years", "hm/Tyr", DekameterPerBillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontometer per sextillion years defined such that: yoctometer per quintillion years = rm/Zyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerSextillionYears =
      new("rontometer per sextillion years", "rm/Zyr", YoctometerPerQuintillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per quadrillion years defined such that: meter per trillion years = dam/Pyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerQuadrillionYears =
      new("dekameter per quadrillion years", "dam/Pyr", MeterPerTrillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per millennium defined such that: petameter per century = Em/kyr × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ExameterPerMillennium = new("exameter per millennium", "Em/kyr", PetameterPerCentury, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// ronnameter per century defined such that: yottameter per decade = Rm/century × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity RonnameterPerCentury = new("ronnameter per century", "Rm/century", YottameterPerDecade, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// quectometer per quintillion years defined such that: rontometer per quadrillion years = qm/Eyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerQuintillionYears =
      new("quectometer per quintillion years", "qm/Eyr", RontometerPerQuadrillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptometer per nonillion years defined such that: attometer per octillion years = zm/Qyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerNonillionYears =
      new("zeptometer per nonillion years", "zm/Qyr", AttometerPerOctillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per billion years defined such that: kilometer per million years = Mm/Gyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerBillionYears = new("megameter per billion years", "Mm/Gyr", KilometerPerMillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// terameter per million years defined such that: gigameter per millennium = Tm/Myr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerMillionYears = new("terameter per million years", "Tm/Myr", GigameterPerMillennium, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quettameter per century defined such that: ronnameter per decade = Qm/century × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity QuettameterPerCentury = new("quettameter per century", "Qm/century", RonnameterPerDecade, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// yoctometer per octillion years defined such that: zeptometer per septillion years = ym/Ryr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerOctillionYears =
      new("yoctometer per octillion years", "ym/Ryr", ZeptometerPerSeptillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per trillion years defined such that: hectometer per billion years = km/Tyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerTrillionYears = new("kilometer per trillion years", "km/Tyr", HectometerPerBillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per millennium defined such that: exameter per century = Zm/kyr × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity ZettameterPerMillennium = new("zettameter per millennium", "Zm/kyr", ExameterPerCentury, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// attometer per tick defined such that: femtometer per nanosecond = am/tick × (1.0/1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity AttometerPerTick = new("attometer per tick", "am/tick", FemtometerPerNanosecond, 1.0 / 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// zeptometer per decillion years defined such that: attometer per nonillion years = zm/decillion yr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerDecillionYears =
      new("zeptometer per decillion years", "zm/decillion yr", AttometerPerNonillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontometer per septillion years defined such that: yoctometer per sextillion years = rm/Yyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerSeptillionYears =
      new("rontometer per septillion years", "rm/Yyr", YoctometerPerSextillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per quadrillion years defined such that: dekameter per trillion years = hm/Pyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerQuadrillionYears =
      new("hectometer per quadrillion years", "hm/Pyr", DekameterPerTrillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per billion years defined such that: megameter per million years = Gm/Gyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerBillionYears = new("gigameter per billion years", "Gm/Gyr", MegameterPerMillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// petameter per million years defined such that: terameter per millennium = Pm/Myr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerMillionYears = new("petameter per million years", "Pm/Myr", TerameterPerMillennium, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per sextillion years defined such that: rontometer per quintillion years = qm/Zyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerSextillionYears =
      new("quectometer per sextillion years", "qm/Zyr", RontometerPerQuintillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per quintillion years defined such that: meter per quadrillion years = dam/Eyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerQuintillionYears =
      new("dekameter per quintillion years", "dam/Eyr", MeterPerQuadrillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per millennium defined such that: zettameter per century = Ym/kyr × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity YottameterPerMillennium = new("yottameter per millennium", "Ym/kyr", ZettameterPerCentury, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// yoctometer per nonillion years defined such that: zeptometer per octillion years = ym/Qyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerNonillionYears =
      new("yoctometer per nonillion years", "ym/Qyr", ZeptometerPerOctillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per trillion years defined such that: kilometer per billion years = Mm/Tyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerTrillionYears =
      new("megameter per trillion years", "Mm/Tyr", KilometerPerBillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per million years defined such that: petameter per millennium = Em/Myr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerMillionYears = new("exameter per million years", "Em/Myr", PetameterPerMillennium, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// terameter per billion years defined such that: gigameter per million years = Tm/Gyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerBillionYears = new("terameter per billion years", "Tm/Gyr", GigameterPerMillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontometer per octillion years defined such that: yoctometer per septillion years = rm/Ryr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerOctillionYears =
      new("rontometer per octillion years", "rm/Ryr", YoctometerPerSeptillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per quadrillion years defined such that: hectometer per trillion years = km/Pyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerQuadrillionYears =
      new("kilometer per quadrillion years", "km/Pyr", HectometerPerTrillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// ronnameter per millennium defined such that: yottameter per century = Rm/kyr × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity RonnameterPerMillennium = new("ronnameter per millennium", "Rm/kyr", YottameterPerCentury, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// quectometer per septillion years defined such that: rontometer per sextillion years = qm/Yyr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerSeptillionYears =
      new("quectometer per septillion years", "qm/Yyr", RontometerPerSextillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per quintillion years defined such that: dekameter per quadrillion years = hm/Eyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerQuintillionYears =
      new("hectometer per quintillion years", "hm/Eyr", DekameterPerQuadrillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per sextillion years defined such that: meter per quintillion years = dam/Zyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerSextillionYears =
      new("dekameter per sextillion years", "dam/Zyr", MeterPerQuintillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per decillion years defined such that: zeptometer per nonillion years = ym/decillion yr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YoctometerPerDecillionYears =
      new("yoctometer per decillion years", "ym/decillion yr", ZeptometerPerNonillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per trillion years defined such that: megameter per billion years = Gm/Tyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerTrillionYears =
      new("gigameter per trillion years", "Gm/Tyr", MegameterPerBillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per million years defined such that: exameter per millennium = Zm/Myr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerMillionYears = new("zettameter per million years", "Zm/Myr", ExameterPerMillennium, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptometer per tick defined such that: attometer per nanosecond = zm/tick × (1.0/1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity ZeptometerPerTick = new("zeptometer per tick", "zm/tick", AttometerPerNanosecond, 1.0 / 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// petameter per billion years defined such that: terameter per million years = Pm/Gyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerBillionYears = new("petameter per billion years", "Pm/Gyr", TerameterPerMillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quettameter per millennium defined such that: ronnameter per century = Qm/kyr × (1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity QuettameterPerMillennium = new("quettameter per millennium", "Qm/kyr", RonnameterPerCentury, 1000.0 / 10.0, system: "SI");
   
   /// <summary>
   /// rontometer per nonillion years defined such that: yoctometer per octillion years = rm/Qyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerNonillionYears =
      new("rontometer per nonillion years", "rm/Qyr", YoctometerPerOctillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per quadrillion years defined such that: kilometer per trillion years = Mm/Pyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerQuadrillionYears =
      new("megameter per quadrillion years", "Mm/Pyr", KilometerPerTrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per million years defined such that: zettameter per millennium = Ym/Myr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerMillionYears = new("yottameter per million years", "Ym/Myr", ZettameterPerMillennium, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per octillion years defined such that: rontometer per septillion years = qm/Ryr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerOctillionYears =
      new("quectometer per octillion years", "qm/Ryr", RontometerPerSeptillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per quintillion years defined such that: hectometer per quadrillion years = km/Eyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerQuintillionYears =
      new("kilometer per quintillion years", "km/Eyr", HectometerPerQuadrillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// terameter per trillion years defined such that: gigameter per billion years = Tm/Tyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerTrillionYears =
      new("terameter per trillion years", "Tm/Tyr", GigameterPerBillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per septillion years defined such that: meter per sextillion years = dam/Yyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerSeptillionYears =
      new("dekameter per septillion years", "dam/Yyr", MeterPerSextillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per sextillion years defined such that: dekameter per quintillion years = hm/Zyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerSextillionYears =
      new("hectometer per sextillion years", "hm/Zyr", DekameterPerQuintillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per billion years defined such that: petameter per million years = Em/Gyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerBillionYears = new("exameter per billion years", "Em/Gyr", PetameterPerMillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontometer per decillion years defined such that: yoctometer per nonillion years = rm/decillion yr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RontometerPerDecillionYears =
      new("rontometer per decillion years", "rm/decillion yr", YoctometerPerNonillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per quadrillion years defined such that: megameter per trillion years = Gm/Pyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerQuadrillionYears =
      new("gigameter per quadrillion years", "Gm/Pyr", MegameterPerTrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// ronnameter per million years defined such that: yottameter per millennium = Rm/Myr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerMillionYears = new("ronnameter per million years", "Rm/Myr", YottameterPerMillennium, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctometer per tick defined such that: zeptometer per nanosecond = ym/tick × (1.0/1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity YoctometerPerTick = new("yoctometer per tick", "ym/tick", ZeptometerPerNanosecond, 1.0 / 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// petameter per trillion years defined such that: terameter per billion years = Pm/Tyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerTrillionYears =
      new("petameter per trillion years", "Pm/Tyr", TerameterPerBillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per billion years defined such that: exameter per million years = Zm/Gyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerBillionYears = new("zettameter per billion years", "Zm/Gyr", ExameterPerMillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per nonillion years defined such that: rontometer per octillion years = qm/Qyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerNonillionYears =
      new("quectometer per nonillion years", "qm/Qyr", RontometerPerOctillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per quintillion years defined such that: kilometer per quadrillion years = Mm/Eyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerQuintillionYears =
      new("megameter per quintillion years", "Mm/Eyr", KilometerPerQuadrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per octillion years defined such that: meter per septillion years = dam/Ryr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerOctillionYears =
      new("dekameter per octillion years", "dam/Ryr", MeterPerSeptillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per sextillion years defined such that: hectometer per quintillion years = km/Zyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerSextillionYears =
      new("kilometer per sextillion years", "km/Zyr", HectometerPerQuintillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per septillion years defined such that: dekameter per sextillion years = hm/Yyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerSeptillionYears =
      new("hectometer per septillion years", "hm/Yyr", DekameterPerSextillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quettameter per million years defined such that: ronnameter per millennium = Qm/Myr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerMillionYears =
      new("quettameter per million years", "Qm/Myr", RonnameterPerMillennium, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// terameter per quadrillion years defined such that: gigameter per trillion years = Tm/Pyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerQuadrillionYears =
      new("terameter per quadrillion years", "Tm/Pyr", GigameterPerTrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per billion years defined such that: zettameter per million years = Ym/Gyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerBillionYears =
      new("yottameter per billion years", "Ym/Gyr", ZettameterPerMillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per trillion years defined such that: petameter per billion years = Em/Tyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerTrillionYears = new("exameter per trillion years", "Em/Tyr", PetameterPerBillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per decillion years defined such that: rontometer per nonillion years = qm/decillion yr ×
   /// (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuectometerPerDecillionYears =
      new("quectometer per decillion years", "qm/decillion yr", RontometerPerNonillionYears, 1.0 / 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per quintillion years defined such that: megameter per quadrillion years = Gm/Eyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerQuintillionYears =
      new("gigameter per quintillion years", "Gm/Eyr", MegameterPerQuadrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per nonillion years defined such that: meter per octillion years = dam/Qyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerNonillionYears = new("dekameter per nonillion years", "dam/Qyr", MeterPerOctillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per sextillion years defined such that: kilometer per quintillion years = Mm/Zyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerSextillionYears =
      new("megameter per sextillion years", "Mm/Zyr", KilometerPerQuintillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontometer per tick defined such that: yoctometer per nanosecond = rm/tick × (1.0/1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity RontometerPerTick = new("rontometer per tick", "rm/tick", YoctometerPerNanosecond, 1.0 / 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// hectometer per octillion years defined such that: dekameter per septillion years = hm/Ryr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerOctillionYears =
      new("hectometer per octillion years", "hm/Ryr", DekameterPerSeptillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per septillion years defined such that: hectometer per sextillion years = km/Yyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerSeptillionYears =
      new("kilometer per septillion years", "km/Yyr", HectometerPerSextillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// petameter per quadrillion years defined such that: terameter per trillion years = Pm/Pyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerQuadrillionYears =
      new("petameter per quadrillion years", "Pm/Pyr", TerameterPerTrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// ronnameter per billion years defined such that: yottameter per million years = Rm/Gyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerBillionYears =
      new("ronnameter per billion years", "Rm/Gyr", YottameterPerMillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per trillion years defined such that: exameter per billion years = Zm/Tyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerTrillionYears =
      new("zettameter per trillion years", "Zm/Tyr", ExameterPerBillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// terameter per quintillion years defined such that: gigameter per quadrillion years = Tm/Eyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerQuintillionYears =
      new("terameter per quintillion years", "Tm/Eyr", GigameterPerQuadrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quettameter per billion years defined such that: ronnameter per million years = Qm/Gyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerBillionYears =
      new("quettameter per billion years", "Qm/Gyr", RonnameterPerMillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per decillion years defined such that: meter per nonillion years = dam/decillion yr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity DekameterPerDecillionYears =
      new("dekameter per decillion years", "dam/decillion yr", MeterPerNonillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per sextillion years defined such that: megameter per quintillion years = Gm/Zyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerSextillionYears =
      new("gigameter per sextillion years", "Gm/Zyr", MegameterPerQuintillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per quadrillion years defined such that: petameter per trillion years = Em/Pyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerQuadrillionYears =
      new("exameter per quadrillion years", "Em/Pyr", PetameterPerTrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per trillion years defined such that: zettameter per billion years = Ym/Tyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerTrillionYears =
      new("yottameter per trillion years", "Ym/Tyr", ZettameterPerBillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per nonillion years defined such that: dekameter per octillion years = hm/Qyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerNonillionYears =
      new("hectometer per nonillion years", "hm/Qyr", DekameterPerOctillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per septillion years defined such that: kilometer per sextillion years = Mm/Yyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerSeptillionYears =
      new("megameter per septillion years", "Mm/Yyr", KilometerPerSextillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per octillion years defined such that: hectometer per septillion years = km/Ryr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerOctillionYears =
      new("kilometer per octillion years", "km/Ryr", HectometerPerSeptillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectometer per tick defined such that: rontometer per nanosecond = qm/tick × (1.0/1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity QuectometerPerTick = new("quectometer per tick", "qm/tick", RontometerPerNanosecond, 1.0 / 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// petameter per quintillion years defined such that: terameter per quadrillion years = Pm/Eyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerQuintillionYears =
      new("petameter per quintillion years", "Pm/Eyr", TerameterPerQuadrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per quadrillion years defined such that: exameter per trillion years = Zm/Pyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerQuadrillionYears =
      new("zettameter per quadrillion years", "Zm/Pyr", ExameterPerTrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// ronnameter per trillion years defined such that: yottameter per billion years = Rm/Tyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerTrillionYears =
      new("ronnameter per trillion years", "Rm/Tyr", YottameterPerBillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// terameter per sextillion years defined such that: gigameter per quintillion years = Tm/Zyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerSextillionYears =
      new("terameter per sextillion years", "Tm/Zyr", GigameterPerQuintillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per decillion years defined such that: dekameter per nonillion years = hm/decillion yr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity HectometerPerDecillionYears =
      new("hectometer per decillion years", "hm/decillion yr", DekameterPerNonillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per septillion years defined such that: megameter per sextillion years = Gm/Yyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerSeptillionYears =
      new("gigameter per septillion years", "Gm/Yyr", MegameterPerSextillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per nonillion years defined such that: hectometer per octillion years = km/Qyr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerNonillionYears =
      new("kilometer per nonillion years", "km/Qyr", HectometerPerOctillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per octillion years defined such that: kilometer per septillion years = Mm/Ryr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerOctillionYears =
      new("megameter per octillion years", "Mm/Ryr", KilometerPerSeptillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per quintillion years defined such that: petameter per quadrillion years = Em/Eyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerQuintillionYears =
      new("exameter per quintillion years", "Em/Eyr", PetameterPerQuadrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quettameter per trillion years defined such that: ronnameter per billion years = Qm/Tyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerTrillionYears =
      new("quettameter per trillion years", "Qm/Tyr", RonnameterPerBillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per quadrillion years defined such that: zettameter per trillion years = Ym/Pyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerQuadrillionYears =
      new("yottameter per quadrillion years", "Ym/Pyr", ZettameterPerTrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekameter per tick defined such that: meter per nanosecond = dam/tick × (10.0)/(100.0).
   /// </summary>
   public static readonly Velocity DekameterPerTick = new("dekameter per tick", "dam/tick", MeterPerNanosecond, 10.0 / 100.0, system: "SI");
   
   /// <summary>
   /// petameter per sextillion years defined such that: terameter per quintillion years = Pm/Zyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerSextillionYears =
      new("petameter per sextillion years", "Pm/Zyr", TerameterPerQuintillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// terameter per septillion years defined such that: gigameter per sextillion years = Tm/Yyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerSeptillionYears =
      new("terameter per septillion years", "Tm/Yyr", GigameterPerSextillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per quintillion years defined such that: exameter per quadrillion years = Zm/Eyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerQuintillionYears =
      new("zettameter per quintillion years", "Zm/Eyr", ExameterPerQuadrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per decillion years defined such that: hectometer per nonillion years = km/decillion yr × (10.0)/(1000.0).
   /// </summary>
   public static readonly Velocity KilometerPerDecillionYears =
      new("kilometer per decillion years", "km/decillion yr", HectometerPerNonillionYears, 10.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per octillion years defined such that: megameter per septillion years = Gm/Ryr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerOctillionYears =
      new("gigameter per octillion years", "Gm/Ryr", MegameterPerSeptillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// ronnameter per quadrillion years defined such that: yottameter per trillion years = Rm/Pyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerQuadrillionYears =
      new("ronnameter per quadrillion years", "Rm/Pyr", YottameterPerTrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per nonillion years defined such that: kilometer per octillion years = Mm/Qyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerNonillionYears =
      new("megameter per nonillion years", "Mm/Qyr", KilometerPerOctillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per sextillion years defined such that: petameter per quintillion years = Em/Zyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerSextillionYears =
      new("exameter per sextillion years", "Em/Zyr", PetameterPerQuintillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per quintillion years defined such that: zettameter per quadrillion years = Ym/Eyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerQuintillionYears =
      new("yottameter per quintillion years", "Ym/Eyr", ZettameterPerQuadrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// hectometer per tick defined such that: dekameter per nanosecond = hm/tick × (10.0)/(100.0).
   /// </summary>
   public static readonly Velocity HectometerPerTick = new("hectometer per tick", "hm/tick", DekameterPerNanosecond, 10.0 / 100.0, system: "SI");
   
   /// <summary>
   /// petameter per septillion years defined such that: terameter per sextillion years = Pm/Yyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerSeptillionYears =
      new("petameter per septillion years", "Pm/Yyr", TerameterPerSextillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quettameter per quadrillion years defined such that: ronnameter per trillion years = Qm/Pyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerQuadrillionYears =
      new("quettameter per quadrillion years", "Qm/Pyr", RonnameterPerTrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// terameter per octillion years defined such that: gigameter per septillion years = Tm/Ryr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerOctillionYears =
      new("terameter per octillion years", "Tm/Ryr", GigameterPerSeptillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per decillion years defined such that: kilometer per nonillion years = Mm/decillion yr ×
   /// (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MegameterPerDecillionYears =
      new("megameter per decillion years", "Mm/decillion yr", KilometerPerNonillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per nonillion years defined such that: megameter per octillion years = Gm/Qyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerNonillionYears =
      new("gigameter per nonillion years", "Gm/Qyr", MegameterPerOctillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per sextillion years defined such that: exameter per quintillion years = Zm/Zyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerSextillionYears =
      new("zettameter per sextillion years", "Zm/Zyr", ExameterPerQuintillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// ronnameter per quintillion years defined such that: yottameter per quadrillion years = Rm/Eyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerQuintillionYears =
      new("ronnameter per quintillion years", "Rm/Eyr", YottameterPerQuadrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per septillion years defined such that: petameter per sextillion years = Em/Yyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerSeptillionYears =
      new("exameter per septillion years", "Em/Yyr", PetameterPerSextillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// kilometer per tick defined such that: hectometer per nanosecond = km/tick × (10.0)/(100.0).
   /// </summary>
   public static readonly Velocity KilometerPerTick = new("kilometer per tick", "km/tick", HectometerPerNanosecond, 10.0 / 100.0, system: "SI");
   
   /// <summary>
   /// petameter per octillion years defined such that: terameter per septillion years = Pm/Ryr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerOctillionYears =
      new("petameter per octillion years", "Pm/Ryr", TerameterPerSeptillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per sextillion years defined such that: zettameter per quintillion years = Ym/Zyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerSextillionYears =
      new("yottameter per sextillion years", "Ym/Zyr", ZettameterPerQuintillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// terameter per nonillion years defined such that: gigameter per octillion years = Tm/Qyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerNonillionYears =
      new("terameter per nonillion years", "Tm/Qyr", GigameterPerOctillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per decillion years defined such that: megameter per nonillion years = Gm/decillion yr ×
   /// (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity GigameterPerDecillionYears =
      new("gigameter per decillion years", "Gm/decillion yr", MegameterPerNonillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quettameter per quintillion years defined such that: ronnameter per quadrillion years = Qm/Eyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerQuintillionYears =
      new("quettameter per quintillion years", "Qm/Eyr", RonnameterPerQuadrillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per septillion years defined such that: exameter per sextillion years = Zm/Yyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerSeptillionYears =
      new("zettameter per septillion years", "Zm/Yyr", ExameterPerSextillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per octillion years defined such that: petameter per septillion years = Em/Ryr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerOctillionYears =
      new("exameter per octillion years", "Em/Ryr", PetameterPerSeptillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// ronnameter per sextillion years defined such that: yottameter per quintillion years = Rm/Zyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerSextillionYears =
      new("ronnameter per sextillion years", "Rm/Zyr", YottameterPerQuintillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// megameter per tick defined such that: kilometer per nanosecond = Mm/tick × (1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity MegameterPerTick = new("megameter per tick", "Mm/tick", KilometerPerNanosecond, 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// petameter per nonillion years defined such that: terameter per octillion years = Pm/Qyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerNonillionYears =
      new("petameter per nonillion years", "Pm/Qyr", TerameterPerOctillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// terameter per decillion years defined such that: gigameter per nonillion years = Tm/decillion yr ×
   /// (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TerameterPerDecillionYears =
      new("terameter per decillion years", "Tm/decillion yr", GigameterPerNonillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per septillion years defined such that: zettameter per sextillion years = Ym/Yyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerSeptillionYears =
      new("yottameter per septillion years", "Ym/Yyr", ZettameterPerSextillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quettameter per sextillion years defined such that: ronnameter per quintillion years = Qm/Zyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerSextillionYears =
      new("quettameter per sextillion years", "Qm/Zyr", RonnameterPerQuintillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per octillion years defined such that: exameter per septillion years = Zm/Ryr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerOctillionYears =
      new("zettameter per octillion years", "Zm/Ryr", ExameterPerSeptillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per nonillion years defined such that: petameter per octillion years = Em/Qyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerNonillionYears =
      new("exameter per nonillion years", "Em/Qyr", PetameterPerOctillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// gigameter per tick defined such that: megameter per nanosecond = Gm/tick × (1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity GigameterPerTick = new("gigameter per tick", "Gm/tick", MegameterPerNanosecond, 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// petameter per decillion years defined such that: terameter per nonillion years = Pm/decillion yr ×
   /// (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PetameterPerDecillionYears =
      new("petameter per decillion years", "Pm/decillion yr", TerameterPerNonillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// ronnameter per septillion years defined such that: yottameter per sextillion years = Rm/Yyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerSeptillionYears =
      new("ronnameter per septillion years", "Rm/Yyr", YottameterPerSextillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per octillion years defined such that: zettameter per septillion years = Ym/Ryr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerOctillionYears =
      new("yottameter per octillion years", "Ym/Ryr", ZettameterPerSeptillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per nonillion years defined such that: exameter per octillion years = Zm/Qyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerNonillionYears =
      new("zettameter per nonillion years", "Zm/Qyr", ExameterPerOctillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quettameter per septillion years defined such that: ronnameter per sextillion years = Qm/Yyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerSeptillionYears =
      new("quettameter per septillion years", "Qm/Yyr", RonnameterPerSextillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per decillion years defined such that: petameter per nonillion years = Em/decillion yr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ExameterPerDecillionYears =
      new("exameter per decillion years", "Em/decillion yr", PetameterPerNonillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// terameter per tick defined such that: gigameter per nanosecond = Tm/tick × (1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity TerameterPerTick = new("terameter per tick", "Tm/tick", GigameterPerNanosecond, 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// ronnameter per octillion years defined such that: yottameter per septillion years = Rm/Ryr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerOctillionYears =
      new("ronnameter per octillion years", "Rm/Ryr", YottameterPerSeptillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per nonillion years defined such that: zettameter per octillion years = Ym/Qyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerNonillionYears =
      new("yottameter per nonillion years", "Ym/Qyr", ZettameterPerOctillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per decillion years defined such that: exameter per nonillion years = Zm/decillion yr ×
   /// (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity ZettameterPerDecillionYears =
      new("zettameter per decillion years", "Zm/decillion yr", ExameterPerNonillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// petameter per tick defined such that: terameter per nanosecond = Pm/tick × (1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity PetameterPerTick = new("petameter per tick", "Pm/tick", TerameterPerNanosecond, 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// quettameter per octillion years defined such that: ronnameter per septillion years = Qm/Ryr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerOctillionYears =
      new("quettameter per octillion years", "Qm/Ryr", RonnameterPerSeptillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// ronnameter per nonillion years defined such that: yottameter per octillion years = Rm/Qyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerNonillionYears =
      new("ronnameter per nonillion years", "Rm/Qyr", YottameterPerOctillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per decillion years defined such that: zettameter per nonillion years = Ym/decillion yr ×
   /// (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YottameterPerDecillionYears =
      new("yottameter per decillion years", "Ym/decillion yr", ZettameterPerNonillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// exameter per tick defined such that: petameter per nanosecond = Em/tick × (1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity ExameterPerTick = new("exameter per tick", "Em/tick", PetameterPerNanosecond, 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// quettameter per nonillion years defined such that: ronnameter per octillion years = Qm/Qyr × (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerNonillionYears =
      new("quettameter per nonillion years", "Qm/Qyr", RonnameterPerOctillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// ronnameter per decillion years defined such that: yottameter per nonillion years = Rm/decillion yr ×
   /// (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity RonnameterPerDecillionYears =
      new("ronnameter per decillion years", "Rm/decillion yr", YottameterPerNonillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zettameter per tick defined such that: exameter per nanosecond = Zm/tick × (1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity ZettameterPerTick = new("zettameter per tick", "Zm/tick", ExameterPerNanosecond, 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// quettameter per decillion years defined such that: ronnameter per nonillion years = Qm/decillion yr ×
   /// (1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity QuettameterPerDecillionYears =
      new("quettameter per decillion years", "Qm/decillion yr", RonnameterPerNonillionYears, 1000.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yottameter per tick defined such that: zettameter per nanosecond = Ym/tick × (1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity YottameterPerTick = new("yottameter per tick", "Ym/tick", ZettameterPerNanosecond, 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// ronnameter per tick defined such that: yottameter per nanosecond = Rm/tick × (1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity RonnameterPerTick = new("ronnameter per tick", "Rm/tick", YottameterPerNanosecond, 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// quettameter per tick defined such that: ronnameter per nanosecond = Qm/tick × (1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity QuettameterPerTick = new("quettameter per tick", "Qm/tick", RonnameterPerNanosecond, 1000.0 / 100.0, system: "SI");
   
   /// <summary>
   /// meter per planck-time defined such that: meter per microsecond = m/tₚ × (1.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity MeterPerPlanckTime = new("meter per planck-time", "m/tₚ", MeterPerMicrosecond, 1.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// decimeter per planck-time defined such that: meter per microsecond = dm/tₚ × (1.0/10.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity DecimeterPerPlanckTime = new("decimeter per planck-time", "dm/tₚ", MeterPerMicrosecond, 1.0 / 10.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// centimeter per planck-time defined such that: decimeter per microsecond = cm/tₚ × (1.0/10.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity CentimeterPerPlanckTime =
      new("centimeter per planck-time", "cm/tₚ", DecimeterPerMicrosecond, 1.0 / 10.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// millimeter per planck-time defined such that: centimeter per microsecond = mm/tₚ × (1.0/10.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity MillimeterPerPlanckTime =
      new("millimeter per planck-time", "mm/tₚ", CentimeterPerMicrosecond, 1.0 / 10.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// micrometer per planck-time defined such that: millimeter per microsecond = μm/tₚ × (1.0/1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity MicrometerPerPlanckTime =
      new("micrometer per planck-time", "μm/tₚ", MillimeterPerMicrosecond, 1.0 / 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// nanometer per planck-time defined such that: micrometer per microsecond = nm/tₚ × (1.0/1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity NanometerPerPlanckTime =
      new("nanometer per planck-time", "nm/tₚ", MicrometerPerMicrosecond, 1.0 / 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// picometer per planck-time defined such that: nanometer per microsecond = pm/tₚ × (1.0/1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity PicometerPerPlanckTime =
      new("picometer per planck-time", "pm/tₚ", NanometerPerMicrosecond, 1.0 / 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// femtometer per planck-time defined such that: picometer per microsecond = fm/tₚ × (1.0/1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity FemtometerPerPlanckTime =
      new("femtometer per planck-time", "fm/tₚ", PicometerPerMicrosecond, 1.0 / 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// attometer per planck-time defined such that: femtometer per microsecond = am/tₚ × (1.0/1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity AttometerPerPlanckTime =
      new("attometer per planck-time", "am/tₚ", FemtometerPerMicrosecond, 1.0 / 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// zeptometer per planck-time defined such that: attometer per microsecond = zm/tₚ × (1.0/1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity ZeptometerPerPlanckTime =
      new("zeptometer per planck-time", "zm/tₚ", AttometerPerMicrosecond, 1.0 / 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// yoctometer per planck-time defined such that: zeptometer per microsecond = ym/tₚ × (1.0/1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity YoctometerPerPlanckTime =
      new("yoctometer per planck-time", "ym/tₚ", ZeptometerPerMicrosecond, 1.0 / 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// rontometer per planck-time defined such that: yoctometer per microsecond = rm/tₚ × (1.0/1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity RontometerPerPlanckTime =
      new("rontometer per planck-time", "rm/tₚ", YoctometerPerMicrosecond, 1.0 / 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// quectometer per planck-time defined such that: rontometer per microsecond = qm/tₚ × (1.0/1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity QuectometerPerPlanckTime =
      new("quectometer per planck-time", "qm/tₚ", RontometerPerMicrosecond, 1.0 / 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// hectometer per planck-time defined such that: dekameter per microsecond = hm/tₚ × (10.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity HectometerPerPlanckTime = new("hectometer per planck-time", "hm/tₚ", DekameterPerMicrosecond, 10.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// kilometer per planck-time defined such that: hectometer per microsecond = km/tₚ × (10.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity KilometerPerPlanckTime = new("kilometer per planck-time", "km/tₚ", HectometerPerMicrosecond, 10.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// megameter per planck-time defined such that: kilometer per microsecond = Mm/tₚ × (1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity MegameterPerPlanckTime = new("megameter per planck-time", "Mm/tₚ", KilometerPerMicrosecond, 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// gigameter per planck-time defined such that: megameter per microsecond = Gm/tₚ × (1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity GigameterPerPlanckTime = new("gigameter per planck-time", "Gm/tₚ", MegameterPerMicrosecond, 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// terameter per planck-time defined such that: gigameter per microsecond = Tm/tₚ × (1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity TerameterPerPlanckTime = new("terameter per planck-time", "Tm/tₚ", GigameterPerMicrosecond, 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// petameter per planck-time defined such that: terameter per microsecond = Pm/tₚ × (1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity PetameterPerPlanckTime = new("petameter per planck-time", "Pm/tₚ", TerameterPerMicrosecond, 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// exameter per planck-time defined such that: petameter per microsecond = Em/tₚ × (1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity ExameterPerPlanckTime = new("exameter per planck-time", "Em/tₚ", PetameterPerMicrosecond, 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// zettameter per planck-time defined such that: exameter per microsecond = Zm/tₚ × (1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity ZettameterPerPlanckTime = new("zettameter per planck-time", "Zm/tₚ", ExameterPerMicrosecond, 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// yottameter per planck-time defined such that: zettameter per microsecond = Ym/tₚ × (1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity YottameterPerPlanckTime =
      new("yottameter per planck-time", "Ym/tₚ", ZettameterPerMicrosecond, 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// ronnameter per planck-time defined such that: yottameter per microsecond = Rm/tₚ × (1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity RonnameterPerPlanckTime =
      new("ronnameter per planck-time", "Rm/tₚ", YottameterPerMicrosecond, 1000.0 / 5.391247E-38, system: "SI");
   
   /// <summary>
   /// quettameter per planck-time defined such that: ronnameter per microsecond = Qm/tₚ × (1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity QuettameterPerPlanckTime =
      new("quettameter per planck-time", "Qm/tₚ", RonnameterPerMicrosecond, 1000.0 / 5.391247E-38, system: "SI");
}