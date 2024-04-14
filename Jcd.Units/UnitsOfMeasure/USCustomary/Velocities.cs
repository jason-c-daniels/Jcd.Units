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
/// United States Customary Units for measuring Velocity.
/// </summary>
public class Velocities : UnitOfMeasureEnumeration<Velocities, Velocity>
{
   /// <summary>
   /// nautical mile per octillion years defined such that: SI meter per septillion years = nmi/Ryr × (1852.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerOctillionYears =
      new("nautical mile per octillion years", "nmi/Ryr", SI.Velocities.MeterPerSeptillionYears, 1852.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per trillion years defined such that: SI meter per billion years = nmi/Tyr × (1852.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerTrillionYears =
      new("nautical mile per trillion years", "nmi/Tyr", SI.Velocities.MeterPerBillionYears, 1852.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per decade defined such that: SI meter per year = nmi/decade × (1852.0)/(10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecade =
      new("nautical mile per decade", "nmi/decade", SI.Velocities.MeterPerYear, 1852.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per minute defined such that: SI meter per second = nmi/min × (1852.0)/(60.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMinute =
      new("nautical mile per minute", "nmi/min", SI.Velocities.MeterPerSecond, 1852.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per decillion years defined such that: SI meter per nonillion years = nmi/decillion yr ×
   /// (1852.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecillionYears = new("nautical mile per decillion years"
                                                                     , "nmi/decillion yr"
                                                                     , SI.Velocities.MeterPerNonillionYears
                                                                     , 1852.0 / 1000.0
                                                                     , system: "US Customary"
                                                                      );
   
   /// <summary>
   /// nautical mile per quintillion years defined such that: SI meter per quadrillion years = nmi/Eyr × (1852.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuintillionYears =
      new("nautical mile per quintillion years", "nmi/Eyr", SI.Velocities.MeterPerQuadrillionYears, 1852.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per millennium defined such that: SI meter per century = nmi/kyr × (1852.0)/(10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillennium =
      new("nautical mile per millennium", "nmi/kyr", SI.Velocities.MeterPerCentury, 1852.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per day defined such that: SI meter per hour = nmi/dy × (1852.0)/(24.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDay = new("nautical mile per day", "nmi/dy", SI.Velocities.MeterPerHour, 1852.0 / 24.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per tick defined such that: SI meter per nanosecond = nmi/tick × (1852.0)/(100.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerTick =
      new("nautical mile per tick", "nmi/tick", SI.Velocities.MeterPerNanosecond, 1852.0 / 100.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per septillion years defined such that: SI meter per sextillion years = nmi/Yyr × (1852.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSeptillionYears =
      new("nautical mile per septillion years", "nmi/Yyr", SI.Velocities.MeterPerSextillionYears, 1852.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per billion years defined such that: SI meter per million years = nmi/Gyr × (1852.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerBillionYears =
      new("nautical mile per billion years", "nmi/Gyr", SI.Velocities.MeterPerMillionYears, 1852.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per year defined such that: SI meter per day = nmi/yr × (1852.0)/(365.2525).
   /// </summary>
   public static readonly Velocity NauticalMilePerYear =
      new("nautical mile per year", "nmi/yr", SI.Velocities.MeterPerDay, 1852.0 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// inch per second defined such that: SI centimeter per second = in/s × (2.54)/(1.0).
   /// </summary>
   public static readonly Velocity InchPerSecond = new("inch per second", "in/s", SI.Velocities.CentimeterPerSecond, 2.54 / 1.0, system: "US Customary");
   
   /// <summary>
   /// inch per planck-time defined such that: SI centimeter per microsecond = in/tₚ × (2.54)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity InchPerPlanckTime =
      new("inch per planck-time", "in/tₚ", SI.Velocities.CentimeterPerMicrosecond, 2.54 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// inch per decisecond defined such that: SI centimeter per second = in/ds × (2.54)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity InchPerDecisecond =
      new("inch per decisecond", "in/ds", SI.Velocities.CentimeterPerSecond, 2.54 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// inch per centisecond defined such that: SI centimeter per decisecond = in/cs × (2.54)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity InchPerCentisecond =
      new("inch per centisecond", "in/cs", SI.Velocities.CentimeterPerDecisecond, 2.54 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// inch per millisecond defined such that: SI centimeter per centisecond = in/ms × (2.54)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity InchPerMillisecond =
      new("inch per millisecond", "in/ms", SI.Velocities.CentimeterPerCentisecond, 2.54 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// inch per microsecond defined such that: SI centimeter per millisecond = in/μs × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerMicrosecond =
      new("inch per microsecond", "in/μs", SI.Velocities.CentimeterPerMillisecond, 2.54 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per nanosecond defined such that: SI centimeter per microsecond = in/ns × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerNanosecond =
      new("inch per nanosecond", "in/ns", SI.Velocities.CentimeterPerMicrosecond, 2.54 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per picosecond defined such that: SI centimeter per nanosecond = in/ps × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerPicosecond =
      new("inch per picosecond", "in/ps", SI.Velocities.CentimeterPerNanosecond, 2.54 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per femtosecond defined such that: SI centimeter per picosecond = in/fs × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerFemtosecond =
      new("inch per femtosecond", "in/fs", SI.Velocities.CentimeterPerPicosecond, 2.54 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per attosecond defined such that: SI centimeter per femtosecond = in/as × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerAttosecond =
      new("inch per attosecond", "in/as", SI.Velocities.CentimeterPerFemtosecond, 2.54 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per zeptosecond defined such that: SI centimeter per attosecond = in/zs × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerZeptosecond =
      new("inch per zeptosecond", "in/zs", SI.Velocities.CentimeterPerAttosecond, 2.54 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per yoctosecond defined such that: SI centimeter per zeptosecond = in/ys × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerYoctosecond =
      new("inch per yoctosecond", "in/ys", SI.Velocities.CentimeterPerZeptosecond, 2.54 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per rontosecond defined such that: SI centimeter per yoctosecond = in/rs × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerRontosecond =
      new("inch per rontosecond", "in/rs", SI.Velocities.CentimeterPerYoctosecond, 2.54 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per quectosecond defined such that: SI centimeter per rontosecond = in/qs × (2.54)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity InchPerQuectosecond =
      new("inch per quectosecond", "in/qs", SI.Velocities.CentimeterPerRontosecond, 2.54 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per minute defined such that: SI centimeter per second = in/min × (2.54)/(60.0).
   /// </summary>
   public static readonly Velocity InchPerMinute = new("inch per minute", "in/min", SI.Velocities.CentimeterPerSecond, 2.54 / 60.0, system: "US Customary");
   
   /// <summary>
   /// mil per second defined such that: inch per second = mil/s × (1.0/1000.0)/(1.0).
   /// </summary>
   public static readonly Velocity MilPerSecond = new("mil per second", "mil/s", InchPerSecond, 1.0 / 1000.0 / 1.0, system: "US Customary");
   
   /// <summary>
   /// mil per planck-time defined such that: inch per microsecond = mil/tₚ × (1.0/1000.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity MilPerPlanckTime = new("mil per planck-time", "mil/tₚ", InchPerMicrosecond, 1.0 / 1000.0 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// mil per decisecond defined such that: inch per second = mil/ds × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MilPerDecisecond = new("mil per decisecond", "mil/ds", InchPerSecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// mil per centisecond defined such that: inch per decisecond = mil/cs × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MilPerCentisecond = new("mil per centisecond", "mil/cs", InchPerDecisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// mil per millisecond defined such that: inch per centisecond = mil/ms × (1.0/1000.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MilPerMillisecond = new("mil per millisecond", "mil/ms", InchPerCentisecond, 1.0 / 1000.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// mil per microsecond defined such that: inch per millisecond = mil/μs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilPerMicrosecond =
      new("mil per microsecond", "mil/μs", InchPerMillisecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mil per nanosecond defined such that: inch per microsecond = mil/ns × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilPerNanosecond = new("mil per nanosecond", "mil/ns", InchPerMicrosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mil per picosecond defined such that: inch per nanosecond = mil/ps × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilPerPicosecond = new("mil per picosecond", "mil/ps", InchPerNanosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mil per femtosecond defined such that: inch per picosecond = mil/fs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilPerFemtosecond =
      new("mil per femtosecond", "mil/fs", InchPerPicosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mil per attosecond defined such that: inch per femtosecond = mil/as × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilPerAttosecond = new("mil per attosecond", "mil/as", InchPerFemtosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mil per zeptosecond defined such that: inch per attosecond = mil/zs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilPerZeptosecond =
      new("mil per zeptosecond", "mil/zs", InchPerAttosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mil per yoctosecond defined such that: inch per zeptosecond = mil/ys × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilPerYoctosecond =
      new("mil per yoctosecond", "mil/ys", InchPerZeptosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mil per rontosecond defined such that: inch per yoctosecond = mil/rs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilPerRontosecond =
      new("mil per rontosecond", "mil/rs", InchPerYoctosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mil per quectosecond defined such that: inch per rontosecond = mil/qs × (1.0/1000.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilPerQuectosecond =
      new("mil per quectosecond", "mil/qs", InchPerRontosecond, 1.0 / 1000.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per hour defined such that: SI centimeter per minute = in/hr × (2.54)/(60.0).
   /// </summary>
   public static readonly Velocity InchPerHour = new("inch per hour", "in/hr", SI.Velocities.CentimeterPerMinute, 2.54 / 60.0, system: "US Customary");
   
   /// <summary>
   /// point per second defined such that: inch per second = p/s × (1.0/72.0)/(1.0).
   /// </summary>
   public static readonly Velocity PointPerSecond = new("point per second", "p/s", InchPerSecond, 1.0 / 72.0 / 1.0, system: "US Customary");
   
   /// <summary>
   /// point per planck-time defined such that: inch per microsecond = p/tₚ × (1.0/72.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity PointPerPlanckTime = new("point per planck-time", "p/tₚ", InchPerMicrosecond, 1.0 / 72.0 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// point per decisecond defined such that: inch per second = p/ds × (1.0/72.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PointPerDecisecond = new("point per decisecond", "p/ds", InchPerSecond, 1.0 / 72.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// point per centisecond defined such that: inch per decisecond = p/cs × (1.0/72.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PointPerCentisecond = new("point per centisecond", "p/cs", InchPerDecisecond, 1.0 / 72.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// point per millisecond defined such that: inch per centisecond = p/ms × (1.0/72.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PointPerMillisecond = new("point per millisecond", "p/ms", InchPerCentisecond, 1.0 / 72.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// point per microsecond defined such that: inch per millisecond = p/μs × (1.0/72.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PointPerMicrosecond =
      new("point per microsecond", "p/μs", InchPerMillisecond, 1.0 / 72.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// point per nanosecond defined such that: inch per microsecond = p/ns × (1.0/72.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PointPerNanosecond = new("point per nanosecond", "p/ns", InchPerMicrosecond, 1.0 / 72.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// point per picosecond defined such that: inch per nanosecond = p/ps × (1.0/72.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PointPerPicosecond = new("point per picosecond", "p/ps", InchPerNanosecond, 1.0 / 72.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// point per femtosecond defined such that: inch per picosecond = p/fs × (1.0/72.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PointPerFemtosecond =
      new("point per femtosecond", "p/fs", InchPerPicosecond, 1.0 / 72.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// point per attosecond defined such that: inch per femtosecond = p/as × (1.0/72.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PointPerAttosecond = new("point per attosecond", "p/as", InchPerFemtosecond, 1.0 / 72.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// point per zeptosecond defined such that: inch per attosecond = p/zs × (1.0/72.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PointPerZeptosecond =
      new("point per zeptosecond", "p/zs", InchPerAttosecond, 1.0 / 72.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// point per yoctosecond defined such that: inch per zeptosecond = p/ys × (1.0/72.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PointPerYoctosecond =
      new("point per yoctosecond", "p/ys", InchPerZeptosecond, 1.0 / 72.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// point per rontosecond defined such that: inch per yoctosecond = p/rs × (1.0/72.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PointPerRontosecond =
      new("point per rontosecond", "p/rs", InchPerYoctosecond, 1.0 / 72.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// point per quectosecond defined such that: inch per rontosecond = p/qs × (1.0/72.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PointPerQuectosecond =
      new("point per quectosecond", "p/qs", InchPerRontosecond, 1.0 / 72.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per day defined such that: SI centimeter per hour = in/dy × (2.54)/(24.0).
   /// </summary>
   public static readonly Velocity InchPerDay = new("inch per day", "in/dy", SI.Velocities.CentimeterPerHour, 2.54 / 24.0, system: "US Customary");
   
   /// <summary>
   /// twip per second defined such that: point per second = twip/s × (1.0/20.0)/(1.0).
   /// </summary>
   public static readonly Velocity TwipPerSecond = new("twip per second", "twip/s", PointPerSecond, 1.0 / 20.0 / 1.0, system: "US Customary");
   
   /// <summary>
   /// twip per planck-time defined such that: point per microsecond = twip/tₚ × (1.0/20.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity TwipPerPlanckTime =
      new("twip per planck-time", "twip/tₚ", PointPerMicrosecond, 1.0 / 20.0 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// twip per decisecond defined such that: point per second = twip/ds × (1.0/20.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity TwipPerDecisecond = new("twip per decisecond", "twip/ds", PointPerSecond, 1.0 / 20.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// twip per centisecond defined such that: point per decisecond = twip/cs × (1.0/20.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity TwipPerCentisecond =
      new("twip per centisecond", "twip/cs", PointPerDecisecond, 1.0 / 20.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// twip per millisecond defined such that: point per centisecond = twip/ms × (1.0/20.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity TwipPerMillisecond =
      new("twip per millisecond", "twip/ms", PointPerCentisecond, 1.0 / 20.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// twip per microsecond defined such that: point per millisecond = twip/μs × (1.0/20.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerMicrosecond =
      new("twip per microsecond", "twip/μs", PointPerMillisecond, 1.0 / 20.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// twip per nanosecond defined such that: point per microsecond = twip/ns × (1.0/20.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerNanosecond =
      new("twip per nanosecond", "twip/ns", PointPerMicrosecond, 1.0 / 20.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// twip per picosecond defined such that: point per nanosecond = twip/ps × (1.0/20.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerPicosecond =
      new("twip per picosecond", "twip/ps", PointPerNanosecond, 1.0 / 20.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// twip per femtosecond defined such that: point per picosecond = twip/fs × (1.0/20.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerFemtosecond =
      new("twip per femtosecond", "twip/fs", PointPerPicosecond, 1.0 / 20.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// twip per attosecond defined such that: point per femtosecond = twip/as × (1.0/20.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerAttosecond =
      new("twip per attosecond", "twip/as", PointPerFemtosecond, 1.0 / 20.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// twip per zeptosecond defined such that: point per attosecond = twip/zs × (1.0/20.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerZeptosecond =
      new("twip per zeptosecond", "twip/zs", PointPerAttosecond, 1.0 / 20.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// twip per yoctosecond defined such that: point per zeptosecond = twip/ys × (1.0/20.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerYoctosecond =
      new("twip per yoctosecond", "twip/ys", PointPerZeptosecond, 1.0 / 20.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// twip per rontosecond defined such that: point per yoctosecond = twip/rs × (1.0/20.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerRontosecond =
      new("twip per rontosecond", "twip/rs", PointPerYoctosecond, 1.0 / 20.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// twip per quectosecond defined such that: point per rontosecond = twip/qs × (1.0/20.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity TwipPerQuectosecond =
      new("twip per quectosecond", "twip/qs", PointPerRontosecond, 1.0 / 20.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per week defined such that: SI centimeter per day = in/wk × (2.54)/(7.0).
   /// </summary>
   public static readonly Velocity InchPerWeek = new("inch per week", "in/wk", SI.Velocities.CentimeterPerDay, 2.54 / 7.0, system: "US Customary");
   
   /// <summary>
   /// pica per second defined such that: point per second = P/s × (12.0)/(1.0).
   /// </summary>
   public static readonly Velocity PicaPerSecond = new("pica per second", "P/s", PointPerSecond, 12.0 / 1.0, system: "US Customary");
   
   /// <summary>
   /// pica per planck-time defined such that: point per microsecond = P/tₚ × (12.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity PicaPerPlanckTime = new("pica per planck-time", "P/tₚ", PointPerMicrosecond, 12.0 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// pica per decisecond defined such that: point per second = P/ds × (12.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PicaPerDecisecond = new("pica per decisecond", "P/ds", PointPerSecond, 12.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// pica per centisecond defined such that: point per decisecond = P/cs × (12.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PicaPerCentisecond = new("pica per centisecond", "P/cs", PointPerDecisecond, 12.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// pica per millisecond defined such that: point per centisecond = P/ms × (12.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity PicaPerMillisecond = new("pica per millisecond", "P/ms", PointPerCentisecond, 12.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// pica per microsecond defined such that: point per millisecond = P/μs × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicaPerMicrosecond = new("pica per microsecond", "P/μs", PointPerMillisecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// pica per nanosecond defined such that: point per microsecond = P/ns × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicaPerNanosecond = new("pica per nanosecond", "P/ns", PointPerMicrosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// pica per picosecond defined such that: point per nanosecond = P/ps × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicaPerPicosecond = new("pica per picosecond", "P/ps", PointPerNanosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// pica per femtosecond defined such that: point per picosecond = P/fs × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicaPerFemtosecond = new("pica per femtosecond", "P/fs", PointPerPicosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// pica per attosecond defined such that: point per femtosecond = P/as × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicaPerAttosecond = new("pica per attosecond", "P/as", PointPerFemtosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// pica per zeptosecond defined such that: point per attosecond = P/zs × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicaPerZeptosecond = new("pica per zeptosecond", "P/zs", PointPerAttosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// pica per yoctosecond defined such that: point per zeptosecond = P/ys × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicaPerYoctosecond = new("pica per yoctosecond", "P/ys", PointPerZeptosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// pica per rontosecond defined such that: point per yoctosecond = P/rs × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicaPerRontosecond = new("pica per rontosecond", "P/rs", PointPerYoctosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// pica per quectosecond defined such that: point per rontosecond = P/qs × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity PicaPerQuectosecond = new("pica per quectosecond", "P/qs", PointPerRontosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per year defined such that: SI centimeter per day = in/yr × (2.54)/(365.2525).
   /// </summary>
   public static readonly Velocity InchPerYear = new("inch per year", "in/yr", SI.Velocities.CentimeterPerDay, 2.54 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// foot per second defined such that: inch per second = ft/s × (12.0)/(1.0).
   /// </summary>
   public static readonly Velocity FootPerSecond = new("foot per second", "ft/s", InchPerSecond, 12.0 / 1.0, system: "US Customary");
   
   /// <summary>
   /// foot per planck-time defined such that: inch per microsecond = ft/tₚ × (12.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity FootPerPlanckTime = new("foot per planck-time", "ft/tₚ", InchPerMicrosecond, 12.0 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// foot per decisecond defined such that: inch per second = ft/ds × (12.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FootPerDecisecond = new("foot per decisecond", "ft/ds", InchPerSecond, 12.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// foot per centisecond defined such that: inch per decisecond = ft/cs × (12.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FootPerCentisecond = new("foot per centisecond", "ft/cs", InchPerDecisecond, 12.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// foot per millisecond defined such that: inch per centisecond = ft/ms × (12.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FootPerMillisecond = new("foot per millisecond", "ft/ms", InchPerCentisecond, 12.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// foot per microsecond defined such that: inch per millisecond = ft/μs × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerMicrosecond = new("foot per microsecond", "ft/μs", InchPerMillisecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// foot per nanosecond defined such that: inch per microsecond = ft/ns × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerNanosecond = new("foot per nanosecond", "ft/ns", InchPerMicrosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// foot per picosecond defined such that: inch per nanosecond = ft/ps × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerPicosecond = new("foot per picosecond", "ft/ps", InchPerNanosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// foot per femtosecond defined such that: inch per picosecond = ft/fs × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerFemtosecond = new("foot per femtosecond", "ft/fs", InchPerPicosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// foot per attosecond defined such that: inch per femtosecond = ft/as × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerAttosecond = new("foot per attosecond", "ft/as", InchPerFemtosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// foot per zeptosecond defined such that: inch per attosecond = ft/zs × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerZeptosecond = new("foot per zeptosecond", "ft/zs", InchPerAttosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// foot per yoctosecond defined such that: inch per zeptosecond = ft/ys × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerYoctosecond = new("foot per yoctosecond", "ft/ys", InchPerZeptosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// foot per rontosecond defined such that: inch per yoctosecond = ft/rs × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerRontosecond = new("foot per rontosecond", "ft/rs", InchPerYoctosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// foot per quectosecond defined such that: inch per rontosecond = ft/qs × (12.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FootPerQuectosecond = new("foot per quectosecond", "ft/qs", InchPerRontosecond, 12.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per decade defined such that: SI centimeter per year = in/decade × (2.54)/(10.0).
   /// </summary>
   public static readonly Velocity InchPerDecade = new("inch per decade", "in/decade", SI.Velocities.CentimeterPerYear, 2.54 / 10.0, system: "US Customary");
   
   /// <summary>
   /// yard per second defined such that: foot per second = yd/s × (3.0)/(1.0).
   /// </summary>
   public static readonly Velocity YardPerSecond = new("yard per second", "yd/s", FootPerSecond, 3.0 / 1.0, system: "US Customary");
   
   /// <summary>
   /// yard per planck-time defined such that: foot per microsecond = yd/tₚ × (3.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity YardPerPlanckTime = new("yard per planck-time", "yd/tₚ", FootPerMicrosecond, 3.0 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// yard per decisecond defined such that: foot per second = yd/ds × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YardPerDecisecond = new("yard per decisecond", "yd/ds", FootPerSecond, 3.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// yard per centisecond defined such that: foot per decisecond = yd/cs × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YardPerCentisecond = new("yard per centisecond", "yd/cs", FootPerDecisecond, 3.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// yard per millisecond defined such that: foot per centisecond = yd/ms × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity YardPerMillisecond = new("yard per millisecond", "yd/ms", FootPerCentisecond, 3.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// yard per microsecond defined such that: foot per millisecond = yd/μs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerMicrosecond = new("yard per microsecond", "yd/μs", FootPerMillisecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// yard per nanosecond defined such that: foot per microsecond = yd/ns × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerNanosecond = new("yard per nanosecond", "yd/ns", FootPerMicrosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// yard per picosecond defined such that: foot per nanosecond = yd/ps × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerPicosecond = new("yard per picosecond", "yd/ps", FootPerNanosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// yard per femtosecond defined such that: foot per picosecond = yd/fs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerFemtosecond = new("yard per femtosecond", "yd/fs", FootPerPicosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// yard per attosecond defined such that: foot per femtosecond = yd/as × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerAttosecond = new("yard per attosecond", "yd/as", FootPerFemtosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// yard per zeptosecond defined such that: foot per attosecond = yd/zs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerZeptosecond = new("yard per zeptosecond", "yd/zs", FootPerAttosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// yard per yoctosecond defined such that: foot per zeptosecond = yd/ys × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerYoctosecond = new("yard per yoctosecond", "yd/ys", FootPerZeptosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// yard per rontosecond defined such that: foot per yoctosecond = yd/rs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerRontosecond = new("yard per rontosecond", "yd/rs", FootPerYoctosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// yard per quectosecond defined such that: foot per rontosecond = yd/qs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity YardPerQuectosecond = new("yard per quectosecond", "yd/qs", FootPerRontosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per century defined such that: SI centimeter per decade = in/century × (2.54)/(10.0).
   /// </summary>
   public static readonly Velocity InchPerCentury = new("inch per century", "in/century", SI.Velocities.CentimeterPerDecade, 2.54 / 10.0, system: "US Customary");
   
   /// <summary>
   /// mile per second defined such that: yard per second = mi/s × (1760.0)/(1.0).
   /// </summary>
   public static readonly Velocity MilePerSecond = new("mile per second", "mi/s", YardPerSecond, 1760.0 / 1.0, system: "US Customary");
   
   /// <summary>
   /// mile per planck-time defined such that: yard per microsecond = mi/tₚ × (1760.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity MilePerPlanckTime = new("mile per planck-time", "mi/tₚ", YardPerMicrosecond, 1760.0 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// mile per decisecond defined such that: yard per second = mi/ds × (1760.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MilePerDecisecond = new("mile per decisecond", "mi/ds", YardPerSecond, 1760.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// mile per centisecond defined such that: yard per decisecond = mi/cs × (1760.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MilePerCentisecond = new("mile per centisecond", "mi/cs", YardPerDecisecond, 1760.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// mile per millisecond defined such that: yard per centisecond = mi/ms × (1760.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity MilePerMillisecond = new("mile per millisecond", "mi/ms", YardPerCentisecond, 1760.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// mile per microsecond defined such that: yard per millisecond = mi/μs × (1760.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerMicrosecond = new("mile per microsecond", "mi/μs", YardPerMillisecond, 1760.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mile per nanosecond defined such that: yard per microsecond = mi/ns × (1760.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerNanosecond = new("mile per nanosecond", "mi/ns", YardPerMicrosecond, 1760.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mile per picosecond defined such that: yard per nanosecond = mi/ps × (1760.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerPicosecond = new("mile per picosecond", "mi/ps", YardPerNanosecond, 1760.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mile per femtosecond defined such that: yard per picosecond = mi/fs × (1760.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerFemtosecond = new("mile per femtosecond", "mi/fs", YardPerPicosecond, 1760.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mile per attosecond defined such that: yard per femtosecond = mi/as × (1760.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerAttosecond = new("mile per attosecond", "mi/as", YardPerFemtosecond, 1760.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mile per zeptosecond defined such that: yard per attosecond = mi/zs × (1760.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerZeptosecond = new("mile per zeptosecond", "mi/zs", YardPerAttosecond, 1760.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mile per yoctosecond defined such that: yard per zeptosecond = mi/ys × (1760.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerYoctosecond = new("mile per yoctosecond", "mi/ys", YardPerZeptosecond, 1760.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mile per rontosecond defined such that: yard per yoctosecond = mi/rs × (1760.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerRontosecond = new("mile per rontosecond", "mi/rs", YardPerYoctosecond, 1760.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// mile per quectosecond defined such that: yard per rontosecond = mi/qs × (1760.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity MilePerQuectosecond = new("mile per quectosecond", "mi/qs", YardPerRontosecond, 1760.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per millennium defined such that: SI centimeter per century = in/kyr × (2.54)/(10.0).
   /// </summary>
   public static readonly Velocity InchPerMillennium = new("inch per millennium", "in/kyr", SI.Velocities.CentimeterPerCentury, 2.54 / 10.0, system: "US Customary");
   
   /// <summary>
   /// league per second defined such that: mile per second = le/s × (3.0)/(1.0).
   /// </summary>
   public static readonly Velocity LeaguePerSecond = new("league per second", "le/s", MilePerSecond, 3.0 / 1.0, system: "US Customary");
   
   /// <summary>
   /// league per planck-time defined such that: mile per microsecond = le/tₚ × (3.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity LeaguePerPlanckTime = new("league per planck-time", "le/tₚ", MilePerMicrosecond, 3.0 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// league per decisecond defined such that: mile per second = le/ds × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LeaguePerDecisecond = new("league per decisecond", "le/ds", MilePerSecond, 3.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// league per centisecond defined such that: mile per decisecond = le/cs × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LeaguePerCentisecond = new("league per centisecond", "le/cs", MilePerDecisecond, 3.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// league per millisecond defined such that: mile per centisecond = le/ms × (3.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity LeaguePerMillisecond = new("league per millisecond", "le/ms", MilePerCentisecond, 3.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// league per microsecond defined such that: mile per millisecond = le/μs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerMicrosecond = new("league per microsecond", "le/μs", MilePerMillisecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// league per nanosecond defined such that: mile per microsecond = le/ns × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerNanosecond = new("league per nanosecond", "le/ns", MilePerMicrosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// league per picosecond defined such that: mile per nanosecond = le/ps × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerPicosecond = new("league per picosecond", "le/ps", MilePerNanosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// league per femtosecond defined such that: mile per picosecond = le/fs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerFemtosecond = new("league per femtosecond", "le/fs", MilePerPicosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// league per attosecond defined such that: mile per femtosecond = le/as × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerAttosecond = new("league per attosecond", "le/as", MilePerFemtosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// league per zeptosecond defined such that: mile per attosecond = le/zs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerZeptosecond = new("league per zeptosecond", "le/zs", MilePerAttosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// league per yoctosecond defined such that: mile per zeptosecond = le/ys × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerYoctosecond = new("league per yoctosecond", "le/ys", MilePerZeptosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// league per rontosecond defined such that: mile per yoctosecond = le/rs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerRontosecond = new("league per rontosecond", "le/rs", MilePerYoctosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// league per quectosecond defined such that: mile per rontosecond = le/qs × (3.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerQuectosecond = new("league per quectosecond", "le/qs", MilePerRontosecond, 3.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per million years defined such that: SI centimeter per millennium = in/Myr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerMillionYears =
      new("inch per million years", "in/Myr", SI.Velocities.CentimeterPerMillennium, 2.54 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per second defined such that: yard per second = ftm/s × (2.0)/(1.0).
   /// </summary>
   public static readonly Velocity FathomPerSecond = new("fathom per second", "ftm/s", YardPerSecond, 2.0 / 1.0, system: "US Customary");
   
   /// <summary>
   /// fathom per planck-time defined such that: yard per microsecond = ftm/tₚ × (2.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity FathomPerPlanckTime = new("fathom per planck-time", "ftm/tₚ", YardPerMicrosecond, 2.0 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// fathom per decisecond defined such that: yard per second = ftm/ds × (2.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FathomPerDecisecond = new("fathom per decisecond", "ftm/ds", YardPerSecond, 2.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// fathom per centisecond defined such that: yard per decisecond = ftm/cs × (2.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FathomPerCentisecond = new("fathom per centisecond", "ftm/cs", YardPerDecisecond, 2.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// fathom per millisecond defined such that: yard per centisecond = ftm/ms × (2.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity FathomPerMillisecond = new("fathom per millisecond", "ftm/ms", YardPerCentisecond, 2.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// fathom per microsecond defined such that: yard per millisecond = ftm/μs × (2.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerMicrosecond = new("fathom per microsecond", "ftm/μs", YardPerMillisecond, 2.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// fathom per nanosecond defined such that: yard per microsecond = ftm/ns × (2.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerNanosecond = new("fathom per nanosecond", "ftm/ns", YardPerMicrosecond, 2.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// fathom per picosecond defined such that: yard per nanosecond = ftm/ps × (2.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerPicosecond = new("fathom per picosecond", "ftm/ps", YardPerNanosecond, 2.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// fathom per femtosecond defined such that: yard per picosecond = ftm/fs × (2.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerFemtosecond = new("fathom per femtosecond", "ftm/fs", YardPerPicosecond, 2.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// fathom per attosecond defined such that: yard per femtosecond = ftm/as × (2.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerAttosecond = new("fathom per attosecond", "ftm/as", YardPerFemtosecond, 2.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// fathom per zeptosecond defined such that: yard per attosecond = ftm/zs × (2.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerZeptosecond = new("fathom per zeptosecond", "ftm/zs", YardPerAttosecond, 2.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// fathom per yoctosecond defined such that: yard per zeptosecond = ftm/ys × (2.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerYoctosecond = new("fathom per yoctosecond", "ftm/ys", YardPerZeptosecond, 2.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// fathom per rontosecond defined such that: yard per yoctosecond = ftm/rs × (2.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerRontosecond = new("fathom per rontosecond", "ftm/rs", YardPerYoctosecond, 2.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// fathom per quectosecond defined such that: yard per rontosecond = ftm/qs × (2.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity FathomPerQuectosecond =
      new("fathom per quectosecond", "ftm/qs", YardPerRontosecond, 2.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per billion years defined such that: SI centimeter per million years = in/Gyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerBillionYears =
      new("inch per billion years", "in/Gyr", SI.Velocities.CentimeterPerMillionYears, 2.54 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per second defined such that: fathom per second = cb/s × (120.0)/(1.0).
   /// </summary>
   public static readonly Velocity CablePerSecond = new("cable per second", "cb/s", FathomPerSecond, 120.0 / 1.0, system: "US Customary");
   
   /// <summary>
   /// cable per planck-time defined such that: fathom per microsecond = cb/tₚ × (120.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity CablePerPlanckTime = new("cable per planck-time", "cb/tₚ", FathomPerMicrosecond, 120.0 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// cable per decisecond defined such that: fathom per second = cb/ds × (120.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity CablePerDecisecond = new("cable per decisecond", "cb/ds", FathomPerSecond, 120.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// cable per centisecond defined such that: fathom per decisecond = cb/cs × (120.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity CablePerCentisecond = new("cable per centisecond", "cb/cs", FathomPerDecisecond, 120.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// cable per millisecond defined such that: fathom per centisecond = cb/ms × (120.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity CablePerMillisecond = new("cable per millisecond", "cb/ms", FathomPerCentisecond, 120.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// cable per microsecond defined such that: fathom per millisecond = cb/μs × (120.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerMicrosecond = new("cable per microsecond", "cb/μs", FathomPerMillisecond, 120.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// cable per nanosecond defined such that: fathom per microsecond = cb/ns × (120.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerNanosecond = new("cable per nanosecond", "cb/ns", FathomPerMicrosecond, 120.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// cable per picosecond defined such that: fathom per nanosecond = cb/ps × (120.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerPicosecond = new("cable per picosecond", "cb/ps", FathomPerNanosecond, 120.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// cable per femtosecond defined such that: fathom per picosecond = cb/fs × (120.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerFemtosecond = new("cable per femtosecond", "cb/fs", FathomPerPicosecond, 120.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// cable per attosecond defined such that: fathom per femtosecond = cb/as × (120.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerAttosecond = new("cable per attosecond", "cb/as", FathomPerFemtosecond, 120.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// cable per zeptosecond defined such that: fathom per attosecond = cb/zs × (120.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerZeptosecond = new("cable per zeptosecond", "cb/zs", FathomPerAttosecond, 120.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// cable per yoctosecond defined such that: fathom per zeptosecond = cb/ys × (120.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerYoctosecond = new("cable per yoctosecond", "cb/ys", FathomPerZeptosecond, 120.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// cable per rontosecond defined such that: fathom per yoctosecond = cb/rs × (120.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerRontosecond = new("cable per rontosecond", "cb/rs", FathomPerYoctosecond, 120.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// cable per quectosecond defined such that: fathom per rontosecond = cb/qs × (120.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity CablePerQuectosecond =
      new("cable per quectosecond", "cb/qs", FathomPerRontosecond, 120.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per trillion years defined such that: SI centimeter per billion years = in/Tyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerTrillionYears =
      new("inch per trillion years", "in/Tyr", SI.Velocities.CentimeterPerBillionYears, 2.54 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per second defined such that: SI meter per second = nmi/s × (1852.0)/(1.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSecond =
      new("nautical mile per second", "nmi/s", SI.Velocities.MeterPerSecond, 1852.0 / 1.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per planck-time defined such that: SI meter per microsecond = nmi/tₚ × (1852.0)/(5.391247E-38).
   /// </summary>
   public static readonly Velocity NauticalMilePerPlanckTime =
      new("nautical mile per planck-time", "nmi/tₚ", SI.Velocities.MeterPerMicrosecond, 1852.0 / 5.391247E-38, system: "US Customary");
   
   /// <summary>
   /// nautical mile per decisecond defined such that: SI meter per second = nmi/ds × (1852.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerDecisecond =
      new("nautical mile per decisecond", "nmi/ds", SI.Velocities.MeterPerSecond, 1852.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// nautical mile per centisecond defined such that: SI meter per decisecond = nmi/cs × (1852.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerCentisecond =
      new("nautical mile per centisecond", "nmi/cs", SI.Velocities.MeterPerDecisecond, 1852.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// nautical mile per millisecond defined such that: SI meter per centisecond = nmi/ms × (1852.0)/(1.0/10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillisecond =
      new("nautical mile per millisecond", "nmi/ms", SI.Velocities.MeterPerCentisecond, 1852.0 / (1.0 / 10.0), system: "US Customary");
   
   /// <summary>
   /// nautical mile per microsecond defined such that: SI meter per millisecond = nmi/μs × (1852.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMicrosecond =
      new("nautical mile per microsecond", "nmi/μs", SI.Velocities.MeterPerMillisecond, 1852.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// nautical mile per nanosecond defined such that: SI meter per microsecond = nmi/ns × (1852.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerNanosecond =
      new("nautical mile per nanosecond", "nmi/ns", SI.Velocities.MeterPerMicrosecond, 1852.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// nautical mile per picosecond defined such that: SI meter per nanosecond = nmi/ps × (1852.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerPicosecond =
      new("nautical mile per picosecond", "nmi/ps", SI.Velocities.MeterPerNanosecond, 1852.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// nautical mile per femtosecond defined such that: SI meter per picosecond = nmi/fs × (1852.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerFemtosecond =
      new("nautical mile per femtosecond", "nmi/fs", SI.Velocities.MeterPerPicosecond, 1852.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// nautical mile per attosecond defined such that: SI meter per femtosecond = nmi/as × (1852.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerAttosecond =
      new("nautical mile per attosecond", "nmi/as", SI.Velocities.MeterPerFemtosecond, 1852.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// nautical mile per zeptosecond defined such that: SI meter per attosecond = nmi/zs × (1852.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerZeptosecond =
      new("nautical mile per zeptosecond", "nmi/zs", SI.Velocities.MeterPerAttosecond, 1852.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// nautical mile per yoctosecond defined such that: SI meter per zeptosecond = nmi/ys × (1852.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerYoctosecond =
      new("nautical mile per yoctosecond", "nmi/ys", SI.Velocities.MeterPerZeptosecond, 1852.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// nautical mile per rontosecond defined such that: SI meter per yoctosecond = nmi/rs × (1852.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerRontosecond =
      new("nautical mile per rontosecond", "nmi/rs", SI.Velocities.MeterPerYoctosecond, 1852.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// nautical mile per quectosecond defined such that: SI meter per rontosecond = nmi/qs × (1852.0)/(1.0/1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuectosecond =
      new("nautical mile per quectosecond", "nmi/qs", SI.Velocities.MeterPerRontosecond, 1852.0 / (1.0 / 1000.0), system: "US Customary");
   
   /// <summary>
   /// inch per quadrillion years defined such that: SI centimeter per trillion years = in/Pyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerQuadrillionYears =
      new("inch per quadrillion years", "in/Pyr", SI.Velocities.CentimeterPerTrillionYears, 2.54 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// inch per quintillion years defined such that: SI centimeter per quadrillion years = in/Eyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerQuintillionYears =
      new("inch per quintillion years", "in/Eyr", SI.Velocities.CentimeterPerQuadrillionYears, 2.54 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// inch per sextillion years defined such that: SI centimeter per quintillion years = in/Zyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerSextillionYears =
      new("inch per sextillion years", "in/Zyr", SI.Velocities.CentimeterPerQuintillionYears, 2.54 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// inch per septillion years defined such that: SI centimeter per sextillion years = in/Yyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerSeptillionYears =
      new("inch per septillion years", "in/Yyr", SI.Velocities.CentimeterPerSextillionYears, 2.54 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// inch per octillion years defined such that: SI centimeter per septillion years = in/Ryr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerOctillionYears =
      new("inch per octillion years", "in/Ryr", SI.Velocities.CentimeterPerSeptillionYears, 2.54 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// inch per nonillion years defined such that: SI centimeter per octillion years = in/Qyr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerNonillionYears =
      new("inch per nonillion years", "in/Qyr", SI.Velocities.CentimeterPerOctillionYears, 2.54 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// inch per decillion years defined such that: SI centimeter per nonillion years = in/decillion yr × (2.54)/(1000.0).
   /// </summary>
   public static readonly Velocity InchPerDecillionYears = new("inch per decillion years"
                                                             , "in/decillion yr"
                                                             , SI.Velocities.CentimeterPerNonillionYears
                                                             , 2.54 / 1000.0
                                                             , system: "US Customary"
                                                              );
   
   /// <summary>
   /// inch per tick defined such that: SI centimeter per nanosecond = in/tick × (2.54)/(100.0).
   /// </summary>
   public static readonly Velocity InchPerTick = new("inch per tick", "in/tick", SI.Velocities.CentimeterPerNanosecond, 2.54 / 100.0, system: "US Customary");
   
   /// <summary>
   /// mil per minute defined such that: inch per second = mil/min × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity MilPerMinute = new("mil per minute", "mil/min", InchPerSecond, 1.0 / 1000.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// foot per septillion years defined such that: inch per sextillion years = ft/Yyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerSeptillionYears =
      new("foot per septillion years", "ft/Yyr", InchPerSextillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// foot per week defined such that: inch per day = ft/wk × (12.0)/(7.0).
   /// </summary>
   public static readonly Velocity FootPerWeek = new("foot per week", "ft/wk", InchPerDay, 12.0 / 7.0, system: "US Customary");
   
   /// <summary>
   /// point per billion years defined such that: inch per million years = p/Gyr × (1.0/72.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PointPerBillionYears = new("point per billion years", "p/Gyr", InchPerMillionYears, 1.0 / 72.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mil per tick defined such that: inch per nanosecond = mil/tick × (1.0/1000.0)/(100.0).
   /// </summary>
   public static readonly Velocity MilPerTick = new("mil per tick", "mil/tick", InchPerNanosecond, 1.0 / 1000.0 / 100.0, system: "US Customary");
   
   /// <summary>
   /// mil per hour defined such that: inch per minute = mil/hr × (1.0/1000.0)/(60.0).
   /// </summary>
   public static readonly Velocity MilPerHour = new("mil per hour", "mil/hr", InchPerMinute, 1.0 / 1000.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// point per minute defined such that: inch per second = p/min × (1.0/72.0)/(60.0).
   /// </summary>
   public static readonly Velocity PointPerMinute = new("point per minute", "p/min", InchPerSecond, 1.0 / 72.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per nonillion years defined such that: SI meter per octillion years = nmi/Qyr × (1852.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerNonillionYears =
      new("nautical mile per nonillion years", "nmi/Qyr", SI.Velocities.MeterPerOctillionYears, 1852.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per quadrillion years defined such that: SI meter per trillion years = nmi/Pyr × (1852.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerQuadrillionYears =
      new("nautical mile per quadrillion years", "nmi/Pyr", SI.Velocities.MeterPerTrillionYears, 1852.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mil per day defined such that: inch per hour = mil/dy × (1.0/1000.0)/(24.0).
   /// </summary>
   public static readonly Velocity MilPerDay = new("mil per day", "mil/dy", InchPerHour, 1.0 / 1000.0 / 24.0, system: "US Customary");
   
   /// <summary>
   /// twip per minute defined such that: point per second = twip/min × (1.0/20.0)/(60.0).
   /// </summary>
   public static readonly Velocity TwipPerMinute = new("twip per minute", "twip/min", PointPerSecond, 1.0 / 20.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// foot per millennium defined such that: inch per century = ft/kyr × (12.0)/(10.0).
   /// </summary>
   public static readonly Velocity FootPerMillennium = new("foot per millennium", "ft/kyr", InchPerCentury, 12.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// point per tick defined such that: inch per nanosecond = p/tick × (1.0/72.0)/(100.0).
   /// </summary>
   public static readonly Velocity PointPerTick = new("point per tick", "p/tick", InchPerNanosecond, 1.0 / 72.0 / 100.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per century defined such that: SI meter per decade = nmi/century × (1852.0)/(10.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerCentury =
      new("nautical mile per century", "nmi/century", SI.Velocities.MeterPerDecade, 1852.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// point per trillion years defined such that: inch per billion years = p/Tyr × (1.0/72.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PointPerTrillionYears =
      new("point per trillion years", "p/Tyr", InchPerBillionYears, 1.0 / 72.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per hour defined such that: SI meter per minute = nmi/hr × (1852.0)/(60.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerHour =
      new("nautical mile per hour", "nmi/hr", SI.Velocities.MeterPerMinute, 1852.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// yard per octillion years defined such that: foot per septillion years = yd/Ryr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerOctillionYears = new("yard per octillion years", "yd/Ryr", FootPerSeptillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// point per hour defined such that: inch per minute = p/hr × (1.0/72.0)/(60.0).
   /// </summary>
   public static readonly Velocity PointPerHour = new("point per hour", "p/hr", InchPerMinute, 1.0 / 72.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// mil per week defined such that: inch per day = mil/wk × (1.0/1000.0)/(7.0).
   /// </summary>
   public static readonly Velocity MilPerWeek = new("mil per week", "mil/wk", InchPerDay, 1.0 / 1000.0 / 7.0, system: "US Customary");
   
   /// <summary>
   /// pica per minute defined such that: point per second = P/min × (12.0)/(60.0).
   /// </summary>
   public static readonly Velocity PicaPerMinute = new("pica per minute", "P/min", PointPerSecond, 12.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// foot per quadrillion years defined such that: inch per trillion years = ft/Pyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerQuadrillionYears =
      new("foot per quadrillion years", "ft/Pyr", InchPerTrillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// twip per tick defined such that: point per nanosecond = twip/tick × (1.0/20.0)/(100.0).
   /// </summary>
   public static readonly Velocity TwipPerTick = new("twip per tick", "twip/tick", PointPerNanosecond, 1.0 / 20.0 / 100.0, system: "US Customary");
   
   /// <summary>
   /// mil per year defined such that: inch per day = mil/yr × (1.0/1000.0)/(365.2525).
   /// </summary>
   public static readonly Velocity MilPerYear = new("mil per year", "mil/yr", InchPerDay, 1.0 / 1000.0 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// foot per minute defined such that: inch per second = ft/min × (12.0)/(60.0).
   /// </summary>
   public static readonly Velocity FootPerMinute = new("foot per minute", "ft/min", InchPerSecond, 12.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// fathom per nonillion years defined such that: yard per octillion years = ftm/Qyr × (2.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerNonillionYears =
      new("fathom per nonillion years", "ftm/Qyr", YardPerOctillionYears, 2.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// point per quadrillion years defined such that: inch per trillion years = p/Pyr × (1.0/72.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PointPerQuadrillionYears =
      new("point per quadrillion years", "p/Pyr", InchPerTrillionYears, 1.0 / 72.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// point per day defined such that: inch per hour = p/dy × (1.0/72.0)/(24.0).
   /// </summary>
   public static readonly Velocity PointPerDay = new("point per day", "p/dy", InchPerHour, 1.0 / 72.0 / 24.0, system: "US Customary");
   
   /// <summary>
   /// twip per hour defined such that: point per minute = twip/hr × (1.0/20.0)/(60.0).
   /// </summary>
   public static readonly Velocity TwipPerHour = new("twip per hour", "twip/hr", PointPerMinute, 1.0 / 20.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// mil per decade defined such that: inch per year = mil/decade × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity MilPerDecade = new("mil per decade", "mil/decade", InchPerYear, 1.0 / 1000.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// yard per minute defined such that: foot per second = yd/min × (3.0)/(60.0).
   /// </summary>
   public static readonly Velocity YardPerMinute = new("yard per minute", "yd/min", FootPerSecond, 3.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// foot per octillion years defined such that: inch per septillion years = ft/Ryr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerOctillionYears = new("foot per octillion years", "ft/Ryr", InchPerSeptillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// pica per tick defined such that: point per nanosecond = P/tick × (12.0)/(100.0).
   /// </summary>
   public static readonly Velocity PicaPerTick = new("pica per tick", "P/tick", PointPerNanosecond, 12.0 / 100.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per sextillion years defined such that: SI meter per quintillion years = nmi/Zyr × (1852.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerSextillionYears =
      new("nautical mile per sextillion years", "nmi/Zyr", SI.Velocities.MeterPerQuintillionYears, 1852.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// foot per year defined such that: inch per day = ft/yr × (12.0)/(365.2525).
   /// </summary>
   public static readonly Velocity FootPerYear = new("foot per year", "ft/yr", InchPerDay, 12.0 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// nautical mile per million years defined such that: SI meter per millennium = nmi/Myr × (1852.0)/(1000.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerMillionYears =
      new("nautical mile per million years", "nmi/Myr", SI.Velocities.MeterPerMillennium, 1852.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mil per century defined such that: inch per decade = mil/century × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity MilPerCentury = new("mil per century", "mil/century", InchPerDecade, 1.0 / 1000.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// mile per minute defined such that: yard per second = mi/min × (1760.0)/(60.0).
   /// </summary>
   public static readonly Velocity MilePerMinute = new("mile per minute", "mi/min", YardPerSecond, 1760.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// pica per trillion years defined such that: point per billion years = P/Tyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicaPerTrillionYears = new("pica per trillion years", "P/Tyr", PointPerBillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// nautical mile per week defined such that: SI meter per day = nmi/wk × (1852.0)/(7.0).
   /// </summary>
   public static readonly Velocity NauticalMilePerWeek = new("nautical mile per week", "nmi/wk", SI.Velocities.MeterPerDay, 1852.0 / 7.0, system: "US Customary");
   
   /// <summary>
   /// point per quintillion years defined such that: inch per quadrillion years = p/Eyr × (1.0/72.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PointPerQuintillionYears =
      new("point per quintillion years", "p/Eyr", InchPerQuadrillionYears, 1.0 / 72.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// foot per tick defined such that: inch per nanosecond = ft/tick × (12.0)/(100.0).
   /// </summary>
   public static readonly Velocity FootPerTick = new("foot per tick", "ft/tick", InchPerNanosecond, 12.0 / 100.0, system: "US Customary");
   
   /// <summary>
   /// point per week defined such that: inch per day = p/wk × (1.0/72.0)/(7.0).
   /// </summary>
   public static readonly Velocity PointPerWeek = new("point per week", "p/wk", InchPerDay, 1.0 / 72.0 / 7.0, system: "US Customary");
   
   /// <summary>
   /// pica per hour defined such that: point per minute = P/hr × (12.0)/(60.0).
   /// </summary>
   public static readonly Velocity PicaPerHour = new("pica per hour", "P/hr", PointPerMinute, 12.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// mil per millennium defined such that: inch per century = mil/kyr × (1.0/1000.0)/(10.0).
   /// </summary>
   public static readonly Velocity MilPerMillennium = new("mil per millennium", "mil/kyr", InchPerCentury, 1.0 / 1000.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// league per minute defined such that: mile per second = le/min × (3.0)/(60.0).
   /// </summary>
   public static readonly Velocity LeaguePerMinute = new("league per minute", "le/min", MilePerSecond, 3.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// foot per million years defined such that: inch per millennium = ft/Myr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerMillionYears = new("foot per million years", "ft/Myr", InchPerMillennium, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mile per nonillion years defined such that: yard per octillion years = mi/Qyr × (1760.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerNonillionYears = new("mile per nonillion years", "mi/Qyr", YardPerOctillionYears, 1760.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// twip per day defined such that: point per hour = twip/dy × (1.0/20.0)/(24.0).
   /// </summary>
   public static readonly Velocity TwipPerDay = new("twip per day", "twip/dy", PointPerHour, 1.0 / 20.0 / 24.0, system: "US Customary");
   
   /// <summary>
   /// mil per million years defined such that: inch per millennium = mil/Myr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilPerMillionYears = new("mil per million years", "mil/Myr", InchPerMillennium, 1.0 / 1000.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per minute defined such that: yard per second = ftm/min × (2.0)/(60.0).
   /// </summary>
   public static readonly Velocity FathomPerMinute = new("fathom per minute", "ftm/min", YardPerSecond, 2.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// yard per tick defined such that: foot per nanosecond = yd/tick × (3.0)/(100.0).
   /// </summary>
   public static readonly Velocity YardPerTick = new("yard per tick", "yd/tick", FootPerNanosecond, 3.0 / 100.0, system: "US Customary");
   
   /// <summary>
   /// point per sextillion years defined such that: inch per quintillion years = p/Zyr × (1.0/72.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PointPerSextillionYears =
      new("point per sextillion years", "p/Zyr", InchPerQuintillionYears, 1.0 / 72.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// foot per quintillion years defined such that: inch per quadrillion years = ft/Eyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerQuintillionYears =
      new("foot per quintillion years", "ft/Eyr", InchPerQuadrillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yard per nonillion years defined such that: foot per octillion years = yd/Qyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerNonillionYears = new("yard per nonillion years", "yd/Qyr", FootPerOctillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// point per year defined such that: inch per day = p/yr × (1.0/72.0)/(365.2525).
   /// </summary>
   public static readonly Velocity PointPerYear = new("point per year", "p/yr", InchPerDay, 1.0 / 72.0 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// foot per hour defined such that: inch per minute = ft/hr × (12.0)/(60.0).
   /// </summary>
   public static readonly Velocity FootPerHour = new("foot per hour", "ft/hr", InchPerMinute, 12.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// mil per billion years defined such that: inch per million years = mil/Gyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilPerBillionYears = new("mil per billion years", "mil/Gyr", InchPerMillionYears, 1.0 / 1000.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per minute defined such that: fathom per second = cb/min × (120.0)/(60.0).
   /// </summary>
   public static readonly Velocity CablePerMinute = new("cable per minute", "cb/min", FathomPerSecond, 120.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// yard per sextillion years defined such that: foot per quintillion years = yd/Zyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerSextillionYears =
      new("yard per sextillion years", "yd/Zyr", FootPerQuintillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mile per tick defined such that: yard per nanosecond = mi/tick × (1760.0)/(100.0).
   /// </summary>
   public static readonly Velocity MilePerTick = new("mile per tick", "mi/tick", YardPerNanosecond, 1760.0 / 100.0, system: "US Customary");
   
   /// <summary>
   /// mil per trillion years defined such that: inch per billion years = mil/Tyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilPerTrillionYears =
      new("mil per trillion years", "mil/Tyr", InchPerBillionYears, 1.0 / 1000.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// pica per quadrillion years defined such that: point per trillion years = P/Pyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicaPerQuadrillionYears =
      new("pica per quadrillion years", "P/Pyr", PointPerTrillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// foot per nonillion years defined such that: inch per octillion years = ft/Qyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerNonillionYears = new("foot per nonillion years", "ft/Qyr", InchPerOctillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// foot per decade defined such that: inch per year = ft/decade × (12.0)/(10.0).
   /// </summary>
   public static readonly Velocity FootPerDecade = new("foot per decade", "ft/decade", InchPerYear, 12.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// point per septillion years defined such that: inch per sextillion years = p/Yyr × (1.0/72.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PointPerSeptillionYears =
      new("point per septillion years", "p/Yyr", InchPerSextillionYears, 1.0 / 72.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// twip per week defined such that: point per day = twip/wk × (1.0/20.0)/(7.0).
   /// </summary>
   public static readonly Velocity TwipPerWeek = new("twip per week", "twip/wk", PointPerDay, 1.0 / 20.0 / 7.0, system: "US Customary");
   
   /// <summary>
   /// pica per day defined such that: point per hour = P/dy × (12.0)/(24.0).
   /// </summary>
   public static readonly Velocity PicaPerDay = new("pica per day", "P/dy", PointPerHour, 12.0 / 24.0, system: "US Customary");
   
   /// <summary>
   /// point per decade defined such that: inch per year = p/decade × (1.0/72.0)/(10.0).
   /// </summary>
   public static readonly Velocity PointPerDecade = new("point per decade", "p/decade", InchPerYear, 1.0 / 72.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// yard per hour defined such that: foot per minute = yd/hr × (3.0)/(60.0).
   /// </summary>
   public static readonly Velocity YardPerHour = new("yard per hour", "yd/hr", FootPerMinute, 3.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// mil per quadrillion years defined such that: inch per trillion years = mil/Pyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilPerQuadrillionYears =
      new("mil per quadrillion years", "mil/Pyr", InchPerTrillionYears, 1.0 / 1000.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per tick defined such that: mile per nanosecond = le/tick × (3.0)/(100.0).
   /// </summary>
   public static readonly Velocity LeaguePerTick = new("league per tick", "le/tick", MilePerNanosecond, 3.0 / 100.0, system: "US Customary");
   
   /// <summary>
   /// mile per septillion years defined such that: yard per sextillion years = mi/Yyr × (1760.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerSeptillionYears =
      new("mile per septillion years", "mi/Yyr", YardPerSextillionYears, 1760.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mil per quintillion years defined such that: inch per quadrillion years = mil/Eyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilPerQuintillionYears =
      new("mil per quintillion years", "mil/Eyr", InchPerQuadrillionYears, 1.0 / 1000.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// foot per billion years defined such that: inch per million years = ft/Gyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerBillionYears = new("foot per billion years", "ft/Gyr", InchPerMillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// point per octillion years defined such that: inch per septillion years = p/Ryr × (1.0/72.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PointPerOctillionYears =
      new("point per octillion years", "p/Ryr", InchPerSeptillionYears, 1.0 / 72.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per decillion years defined such that: fathom per nonillion years = cb/decillion yr × (120.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerDecillionYears =
      new("cable per decillion years", "cb/decillion yr", FathomPerNonillionYears, 120.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per tick defined such that: yard per nanosecond = ftm/tick × (2.0)/(100.0).
   /// </summary>
   public static readonly Velocity FathomPerTick = new("fathom per tick", "ftm/tick", YardPerNanosecond, 2.0 / 100.0, system: "US Customary");
   
   /// <summary>
   /// point per century defined such that: inch per decade = p/century × (1.0/72.0)/(10.0).
   /// </summary>
   public static readonly Velocity PointPerCentury = new("point per century", "p/century", InchPerDecade, 1.0 / 72.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// mile per hour defined such that: yard per minute = mi/hr × (1760.0)/(60.0).
   /// </summary>
   public static readonly Velocity MilePerHour = new("mile per hour", "mi/hr", YardPerMinute, 1760.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// mil per sextillion years defined such that: inch per quintillion years = mil/Zyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilPerSextillionYears =
      new("mil per sextillion years", "mil/Zyr", InchPerQuintillionYears, 1.0 / 1000.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// twip per nonillion years defined such that: point per octillion years = twip/Qyr × (1.0/20.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerNonillionYears =
      new("twip per nonillion years", "twip/Qyr", PointPerOctillionYears, 1.0 / 20.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per decillion years defined such that: yard per nonillion years = ftm/decillion yr × (2.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerDecillionYears =
      new("fathom per decillion years", "ftm/decillion yr", YardPerNonillionYears, 2.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// twip per trillion years defined such that: point per billion years = twip/Tyr × (1.0/20.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerTrillionYears =
      new("twip per trillion years", "twip/Tyr", PointPerBillionYears, 1.0 / 20.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// foot per sextillion years defined such that: inch per quintillion years = ft/Zyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerSextillionYears =
      new("foot per sextillion years", "ft/Zyr", InchPerQuintillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per decillion years defined such that: mile per nonillion years = le/decillion yr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerDecillionYears =
      new("league per decillion years", "le/decillion yr", MilePerNonillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// twip per year defined such that: point per day = twip/yr × (1.0/20.0)/(365.2525).
   /// </summary>
   public static readonly Velocity TwipPerYear = new("twip per year", "twip/yr", PointPerDay, 1.0 / 20.0 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// foot per day defined such that: inch per hour = ft/dy × (12.0)/(24.0).
   /// </summary>
   public static readonly Velocity FootPerDay = new("foot per day", "ft/dy", InchPerHour, 12.0 / 24.0, system: "US Customary");
   
   /// <summary>
   /// mil per septillion years defined such that: inch per sextillion years = mil/Yyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilPerSeptillionYears =
      new("mil per septillion years", "mil/Yyr", InchPerSextillionYears, 1.0 / 1000.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// pica per quintillion years defined such that: point per quadrillion years = P/Eyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicaPerQuintillionYears =
      new("pica per quintillion years", "P/Eyr", PointPerQuadrillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mile per decillion years defined such that: yard per nonillion years = mi/decillion yr × (1760.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerDecillionYears =
      new("mile per decillion years", "mi/decillion yr", YardPerNonillionYears, 1760.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per tick defined such that: fathom per nanosecond = cb/tick × (120.0)/(100.0).
   /// </summary>
   public static readonly Velocity CablePerTick = new("cable per tick", "cb/tick", FathomPerNanosecond, 120.0 / 100.0, system: "US Customary");
   
   /// <summary>
   /// point per nonillion years defined such that: inch per octillion years = p/Qyr × (1.0/72.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PointPerNonillionYears =
      new("point per nonillion years", "p/Qyr", InchPerOctillionYears, 1.0 / 72.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yard per decillion years defined such that: foot per nonillion years = yd/decillion yr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerDecillionYears =
      new("yard per decillion years", "yd/decillion yr", FootPerNonillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// pica per week defined such that: point per day = P/wk × (12.0)/(7.0).
   /// </summary>
   public static readonly Velocity PicaPerWeek = new("pica per week", "P/wk", PointPerDay, 12.0 / 7.0, system: "US Customary");
   
   /// <summary>
   /// point per millennium defined such that: inch per century = p/kyr × (1.0/72.0)/(10.0).
   /// </summary>
   public static readonly Velocity PointPerMillennium = new("point per millennium", "p/kyr", InchPerCentury, 1.0 / 72.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// league per hour defined such that: mile per minute = le/hr × (3.0)/(60.0).
   /// </summary>
   public static readonly Velocity LeaguePerHour = new("league per hour", "le/hr", MilePerMinute, 3.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// mil per octillion years defined such that: inch per septillion years = mil/Ryr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilPerOctillionYears =
      new("mil per octillion years", "mil/Ryr", InchPerSeptillionYears, 1.0 / 1000.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yard per septillion years defined such that: foot per sextillion years = yd/Yyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerSeptillionYears = new("yard per septillion years", "yd/Yyr", FootPerSextillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// foot per decillion years defined such that: inch per nonillion years = ft/decillion yr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerDecillionYears =
      new("foot per decillion years", "ft/decillion yr", InchPerNonillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// foot per century defined such that: inch per decade = ft/century × (12.0)/(10.0).
   /// </summary>
   public static readonly Velocity FootPerCentury = new("foot per century", "ft/century", InchPerDecade, 12.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// pica per decillion years defined such that: point per nonillion years = P/decillion yr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicaPerDecillionYears =
      new("pica per decillion years", "P/decillion yr", PointPerNonillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mil per nonillion years defined such that: inch per octillion years = mil/Qyr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilPerNonillionYears =
      new("mil per nonillion years", "mil/Qyr", InchPerOctillionYears, 1.0 / 1000.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yard per million years defined such that: foot per millennium = yd/Myr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerMillionYears = new("yard per million years", "yd/Myr", FootPerMillennium, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// twip per decillion years defined such that: point per nonillion years = twip/decillion yr × (1.0/20.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerDecillionYears =
      new("twip per decillion years", "twip/decillion yr", PointPerNonillionYears, 1.0 / 20.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per octillion years defined such that: mile per septillion years = le/Ryr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerOctillionYears =
      new("league per octillion years", "le/Ryr", MilePerSeptillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yard per decade defined such that: foot per year = yd/decade × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity YardPerDecade = new("yard per decade", "yd/decade", FootPerYear, 3.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// pica per million years defined such that: point per millennium = P/Myr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicaPerMillionYears = new("pica per million years", "P/Myr", PointPerMillennium, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// twip per quadrillion years defined such that: point per trillion years = twip/Pyr × (1.0/20.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerQuadrillionYears =
      new("twip per quadrillion years", "twip/Pyr", PointPerTrillionYears, 1.0 / 20.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// point per decillion years defined such that: inch per nonillion years = p/decillion yr × (1.0/72.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PointPerDecillionYears =
      new("point per decillion years", "p/decillion yr", InchPerNonillionYears, 1.0 / 72.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// twip per decade defined such that: point per year = twip/decade × (1.0/20.0)/(10.0).
   /// </summary>
   public static readonly Velocity TwipPerDecade = new("twip per decade", "twip/decade", PointPerYear, 1.0 / 20.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// yard per day defined such that: foot per hour = yd/dy × (3.0)/(24.0).
   /// </summary>
   public static readonly Velocity YardPerDay = new("yard per day", "yd/dy", FootPerHour, 3.0 / 24.0, system: "US Customary");
   
   /// <summary>
   /// point per million years defined such that: inch per millennium = p/Myr × (1.0/72.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PointPerMillionYears = new("point per million years", "p/Myr", InchPerMillennium, 1.0 / 72.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per hour defined such that: yard per minute = ftm/hr × (2.0)/(60.0).
   /// </summary>
   public static readonly Velocity FathomPerHour = new("fathom per hour", "ftm/hr", YardPerMinute, 2.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// mil per decillion years defined such that: inch per nonillion years = mil/decillion yr × (1.0/1000.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilPerDecillionYears =
      new("mil per decillion years", "mil/decillion yr", InchPerNonillionYears, 1.0 / 1000.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// foot per trillion years defined such that: inch per billion years = ft/Tyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FootPerTrillionYears = new("foot per trillion years", "ft/Tyr", InchPerBillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// pica per sextillion years defined such that: point per quintillion years = P/Zyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicaPerSextillionYears =
      new("pica per sextillion years", "P/Zyr", PointPerQuintillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mile per octillion years defined such that: yard per septillion years = mi/Ryr × (1760.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerOctillionYears =
      new("mile per octillion years", "mi/Ryr", YardPerSeptillionYears, 1760.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// pica per year defined such that: point per day = P/yr × (12.0)/(365.2525).
   /// </summary>
   public static readonly Velocity PicaPerYear = new("pica per year", "P/yr", PointPerDay, 12.0 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// cable per hour defined such that: fathom per minute = cb/hr × (120.0)/(60.0).
   /// </summary>
   public static readonly Velocity CablePerHour = new("cable per hour", "cb/hr", FathomPerMinute, 120.0 / 60.0, system: "US Customary");
   
   /// <summary>
   /// twip per quintillion years defined such that: point per quadrillion years = twip/Eyr × (1.0/20.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerQuintillionYears =
      new("twip per quintillion years", "twip/Eyr", PointPerQuadrillionYears, 1.0 / 20.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// twip per century defined such that: point per decade = twip/century × (1.0/20.0)/(10.0).
   /// </summary>
   public static readonly Velocity TwipPerCentury = new("twip per century", "twip/century", PointPerDecade, 1.0 / 20.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// mile per day defined such that: yard per hour = mi/dy × (1760.0)/(24.0).
   /// </summary>
   public static readonly Velocity MilePerDay = new("mile per day", "mi/dy", YardPerHour, 1760.0 / 24.0, system: "US Customary");
   
   /// <summary>
   /// league per year defined such that: mile per day = le/yr × (3.0)/(365.2525).
   /// </summary>
   public static readonly Velocity LeaguePerYear = new("league per year", "le/yr", MilePerDay, 3.0 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// pica per billion years defined such that: point per million years = P/Gyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicaPerBillionYears = new("pica per billion years", "P/Gyr", PointPerMillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yard per quintillion years defined such that: foot per quadrillion years = yd/Eyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerQuintillionYears =
      new("yard per quintillion years", "yd/Eyr", FootPerQuadrillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yard per billion years defined such that: foot per million years = yd/Gyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerBillionYears = new("yard per billion years", "yd/Gyr", FootPerMillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// pica per septillion years defined such that: point per sextillion years = P/Yyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicaPerSeptillionYears =
      new("pica per septillion years", "P/Yyr", PointPerSextillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yard per century defined such that: foot per decade = yd/century × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity YardPerCentury = new("yard per century", "yd/century", FootPerDecade, 3.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// twip per sextillion years defined such that: point per quintillion years = twip/Zyr × (1.0/20.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerSextillionYears =
      new("twip per sextillion years", "twip/Zyr", PointPerQuintillionYears, 1.0 / 20.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// pica per decade defined such that: point per year = P/decade × (12.0)/(10.0).
   /// </summary>
   public static readonly Velocity PicaPerDecade = new("pica per decade", "P/decade", PointPerYear, 12.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// yard per week defined such that: foot per day = yd/wk × (3.0)/(7.0).
   /// </summary>
   public static readonly Velocity YardPerWeek = new("yard per week", "yd/wk", FootPerDay, 3.0 / 7.0, system: "US Customary");
   
   /// <summary>
   /// twip per millennium defined such that: point per century = twip/kyr × (1.0/20.0)/(10.0).
   /// </summary>
   public static readonly Velocity TwipPerMillennium = new("twip per millennium", "twip/kyr", PointPerCentury, 1.0 / 20.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// league per day defined such that: mile per hour = le/dy × (3.0)/(24.0).
   /// </summary>
   public static readonly Velocity LeaguePerDay = new("league per day", "le/dy", MilePerHour, 3.0 / 24.0, system: "US Customary");
   
   /// <summary>
   /// mile per sextillion years defined such that: yard per quintillion years = mi/Zyr × (1760.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerSextillionYears =
      new("mile per sextillion years", "mi/Zyr", YardPerQuintillionYears, 1760.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per septillion years defined such that: yard per sextillion years = ftm/Yyr × (2.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerSeptillionYears =
      new("fathom per septillion years", "ftm/Yyr", YardPerSextillionYears, 2.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per trillion years defined such that: yard per billion years = ftm/Tyr × (2.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerTrillionYears = new("fathom per trillion years", "ftm/Tyr", YardPerBillionYears, 2.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per nonillion years defined such that: mile per octillion years = le/Qyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerNonillionYears =
      new("league per nonillion years", "le/Qyr", MilePerOctillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per century defined such that: yard per decade = ftm/century × (2.0)/(10.0).
   /// </summary>
   public static readonly Velocity FathomPerCentury = new("fathom per century", "ftm/century", YardPerDecade, 2.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// fathom per year defined such that: yard per day = ftm/yr × (2.0)/(365.2525).
   /// </summary>
   public static readonly Velocity FathomPerYear = new("fathom per year", "ftm/yr", YardPerDay, 2.0 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// twip per septillion years defined such that: point per sextillion years = twip/Yyr × (1.0/20.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerSeptillionYears =
      new("twip per septillion years", "twip/Yyr", PointPerSextillionYears, 1.0 / 20.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// twip per million years defined such that: point per millennium = twip/Myr × (1.0/20.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerMillionYears = new("twip per million years", "twip/Myr", PointPerMillennium, 1.0 / 20.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per day defined such that: yard per hour = ftm/dy × (2.0)/(24.0).
   /// </summary>
   public static readonly Velocity FathomPerDay = new("fathom per day", "ftm/dy", YardPerHour, 2.0 / 24.0, system: "US Customary");
   
   /// <summary>
   /// pica per octillion years defined such that: point per septillion years = P/Ryr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicaPerOctillionYears = new("pica per octillion years", "P/Ryr", PointPerSeptillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per quadrillion years defined such that: fathom per trillion years = cb/Pyr × (120.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerQuadrillionYears =
      new("cable per quadrillion years", "cb/Pyr", FathomPerTrillionYears, 120.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per septillion years defined such that: mile per sextillion years = le/Yyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerSeptillionYears =
      new("league per septillion years", "le/Yyr", MilePerSextillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// pica per century defined such that: point per decade = P/century × (12.0)/(10.0).
   /// </summary>
   public static readonly Velocity PicaPerCentury = new("pica per century", "P/century", PointPerDecade, 12.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// mile per week defined such that: yard per day = mi/wk × (1760.0)/(7.0).
   /// </summary>
   public static readonly Velocity MilePerWeek = new("mile per week", "mi/wk", YardPerDay, 1760.0 / 7.0, system: "US Customary");
   
   /// <summary>
   /// yard per trillion years defined such that: foot per billion years = yd/Tyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerTrillionYears = new("yard per trillion years", "yd/Tyr", FootPerBillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yard per millennium defined such that: foot per century = yd/kyr × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity YardPerMillennium = new("yard per millennium", "yd/kyr", FootPerCentury, 3.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// twip per octillion years defined such that: point per septillion years = twip/Ryr × (1.0/20.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerOctillionYears =
      new("twip per octillion years", "twip/Ryr", PointPerSeptillionYears, 1.0 / 20.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yard per year defined such that: foot per day = yd/yr × (3.0)/(365.2525).
   /// </summary>
   public static readonly Velocity YardPerYear = new("yard per year", "yd/yr", FootPerDay, 3.0 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// twip per billion years defined such that: point per million years = twip/Gyr × (1.0/20.0)/(1000.0).
   /// </summary>
   public static readonly Velocity TwipPerBillionYears =
      new("twip per billion years", "twip/Gyr", PointPerMillionYears, 1.0 / 20.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per day defined such that: fathom per hour = cb/dy × (120.0)/(24.0).
   /// </summary>
   public static readonly Velocity CablePerDay = new("cable per day", "cb/dy", FathomPerHour, 120.0 / 24.0, system: "US Customary");
   
   /// <summary>
   /// mile per century defined such that: yard per decade = mi/century × (1760.0)/(10.0).
   /// </summary>
   public static readonly Velocity MilePerCentury = new("mile per century", "mi/century", YardPerDecade, 1760.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// cable per octillion years defined such that: fathom per septillion years = cb/Ryr × (120.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerOctillionYears =
      new("cable per octillion years", "cb/Ryr", FathomPerSeptillionYears, 120.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// pica per nonillion years defined such that: point per octillion years = P/Qyr × (12.0)/(1000.0).
   /// </summary>
   public static readonly Velocity PicaPerNonillionYears = new("pica per nonillion years", "P/Qyr", PointPerOctillionYears, 12.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per year defined such that: fathom per day = cb/yr × (120.0)/(365.2525).
   /// </summary>
   public static readonly Velocity CablePerYear = new("cable per year", "cb/yr", FathomPerDay, 120.0 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// pica per millennium defined such that: point per century = P/kyr × (12.0)/(10.0).
   /// </summary>
   public static readonly Velocity PicaPerMillennium = new("pica per millennium", "P/kyr", PointPerCentury, 12.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// league per week defined such that: mile per day = le/wk × (3.0)/(7.0).
   /// </summary>
   public static readonly Velocity LeaguePerWeek = new("league per week", "le/wk", MilePerDay, 3.0 / 7.0, system: "US Customary");
   
   /// <summary>
   /// mile per billion years defined such that: yard per million years = mi/Gyr × (1760.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerBillionYears = new("mile per billion years", "mi/Gyr", YardPerMillionYears, 1760.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per octillion years defined such that: yard per septillion years = ftm/Ryr × (2.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerOctillionYears =
      new("fathom per octillion years", "ftm/Ryr", YardPerSeptillionYears, 2.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per sextillion years defined such that: yard per quintillion years = ftm/Zyr × (2.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerSextillionYears =
      new("fathom per sextillion years", "ftm/Zyr", YardPerQuintillionYears, 2.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per quadrillion years defined such that: yard per trillion years = ftm/Pyr × (2.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerQuadrillionYears =
      new("fathom per quadrillion years", "ftm/Pyr", YardPerTrillionYears, 2.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per billion years defined such that: yard per million years = ftm/Gyr × (2.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerBillionYears = new("fathom per billion years", "ftm/Gyr", YardPerMillionYears, 2.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mile per year defined such that: yard per day = mi/yr × (1760.0)/(365.2525).
   /// </summary>
   public static readonly Velocity MilePerYear = new("mile per year", "mi/yr", YardPerDay, 1760.0 / 365.2525, system: "US Customary");
   
   /// <summary>
   /// fathom per millennium defined such that: yard per century = ftm/kyr × (2.0)/(10.0).
   /// </summary>
   public static readonly Velocity FathomPerMillennium = new("fathom per millennium", "ftm/kyr", YardPerCentury, 2.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// yard per quadrillion years defined such that: foot per trillion years = yd/Pyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity YardPerQuadrillionYears = new("yard per quadrillion years", "yd/Pyr", FootPerTrillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per decade defined such that: yard per year = ftm/decade × (2.0)/(10.0).
   /// </summary>
   public static readonly Velocity FathomPerDecade = new("fathom per decade", "ftm/decade", YardPerYear, 2.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// mile per quintillion years defined such that: yard per quadrillion years = mi/Eyr × (1760.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerQuintillionYears =
      new("mile per quintillion years", "mi/Eyr", YardPerQuadrillionYears, 1760.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per week defined such that: yard per day = ftm/wk × (2.0)/(7.0).
   /// </summary>
   public static readonly Velocity FathomPerWeek = new("fathom per week", "ftm/wk", YardPerDay, 2.0 / 7.0, system: "US Customary");
   
   /// <summary>
   /// cable per trillion years defined such that: fathom per billion years = cb/Tyr × (120.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerTrillionYears = new("cable per trillion years", "cb/Tyr", FathomPerBillionYears, 120.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mile per millennium defined such that: yard per century = mi/kyr × (1760.0)/(10.0).
   /// </summary>
   public static readonly Velocity MilePerMillennium = new("mile per millennium", "mi/kyr", YardPerCentury, 1760.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// cable per quintillion years defined such that: fathom per quadrillion years = cb/Eyr × (120.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerQuintillionYears =
      new("cable per quintillion years", "cb/Eyr", FathomPerQuadrillionYears, 120.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per sextillion years defined such that: mile per quintillion years = le/Zyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerSextillionYears =
      new("league per sextillion years", "le/Zyr", MilePerQuintillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per septillion years defined such that: fathom per sextillion years = cb/Yyr × (120.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerSeptillionYears =
      new("cable per septillion years", "cb/Yyr", FathomPerSextillionYears, 120.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per week defined such that: fathom per day = cb/wk × (120.0)/(7.0).
   /// </summary>
   public static readonly Velocity CablePerWeek = new("cable per week", "cb/wk", FathomPerDay, 120.0 / 7.0, system: "US Customary");
   
   /// <summary>
   /// mile per trillion years defined such that: yard per billion years = mi/Tyr × (1760.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerTrillionYears = new("mile per trillion years", "mi/Tyr", YardPerBillionYears, 1760.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per quadrillion years defined such that: mile per trillion years = le/Pyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerQuadrillionYears =
      new("league per quadrillion years", "le/Pyr", MilePerTrillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per nonillion years defined such that: fathom per octillion years = cb/Qyr × (120.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerNonillionYears =
      new("cable per nonillion years", "cb/Qyr", FathomPerOctillionYears, 120.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per decade defined such that: fathom per year = cb/decade × (120.0)/(10.0).
   /// </summary>
   public static readonly Velocity CablePerDecade = new("cable per decade", "cb/decade", FathomPerYear, 120.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// mile per decade defined such that: yard per year = mi/decade × (1760.0)/(10.0).
   /// </summary>
   public static readonly Velocity MilePerDecade = new("mile per decade", "mi/decade", YardPerYear, 1760.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// cable per millennium defined such that: fathom per century = cb/kyr × (120.0)/(10.0).
   /// </summary>
   public static readonly Velocity CablePerMillennium = new("cable per millennium", "cb/kyr", FathomPerCentury, 120.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// fathom per quintillion years defined such that: yard per quadrillion years = ftm/Eyr × (2.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerQuintillionYears =
      new("fathom per quintillion years", "ftm/Eyr", YardPerQuadrillionYears, 2.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// fathom per million years defined such that: yard per millennium = ftm/Myr × (2.0)/(1000.0).
   /// </summary>
   public static readonly Velocity FathomPerMillionYears = new("fathom per million years", "ftm/Myr", YardPerMillennium, 2.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// mile per million years defined such that: yard per millennium = mi/Myr × (1760.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerMillionYears = new("mile per million years", "mi/Myr", YardPerMillennium, 1760.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per billion years defined such that: fathom per million years = cb/Gyr × (120.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerBillionYears = new("cable per billion years", "cb/Gyr", FathomPerMillionYears, 120.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per millennium defined such that: mile per century = le/kyr × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity LeaguePerMillennium = new("league per millennium", "le/kyr", MilePerCentury, 3.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// mile per quadrillion years defined such that: yard per trillion years = mi/Pyr × (1760.0)/(1000.0).
   /// </summary>
   public static readonly Velocity MilePerQuadrillionYears =
      new("mile per quadrillion years", "mi/Pyr", YardPerTrillionYears, 1760.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per sextillion years defined such that: fathom per quintillion years = cb/Zyr × (120.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerSextillionYears =
      new("cable per sextillion years", "cb/Zyr", FathomPerQuintillionYears, 120.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per decade defined such that: mile per year = le/decade × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity LeaguePerDecade = new("league per decade", "le/decade", MilePerYear, 3.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// league per quintillion years defined such that: mile per quadrillion years = le/Eyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerQuintillionYears =
      new("league per quintillion years", "le/Eyr", MilePerQuadrillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per trillion years defined such that: mile per billion years = le/Tyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerTrillionYears = new("league per trillion years", "le/Tyr", MilePerBillionYears, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// cable per century defined such that: fathom per decade = cb/century × (120.0)/(10.0).
   /// </summary>
   public static readonly Velocity CablePerCentury = new("cable per century", "cb/century", FathomPerDecade, 120.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// cable per million years defined such that: fathom per millennium = cb/Myr × (120.0)/(1000.0).
   /// </summary>
   public static readonly Velocity CablePerMillionYears = new("cable per million years", "cb/Myr", FathomPerMillennium, 120.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per million years defined such that: mile per millennium = le/Myr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerMillionYears = new("league per million years", "le/Myr", MilePerMillennium, 3.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// league per century defined such that: mile per decade = le/century × (3.0)/(10.0).
   /// </summary>
   public static readonly Velocity LeaguePerCentury = new("league per century", "le/century", MilePerDecade, 3.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// league per billion years defined such that: mile per million years = le/Gyr × (3.0)/(1000.0).
   /// </summary>
   public static readonly Velocity LeaguePerBillionYears = new("league per billion years", "le/Gyr", MilePerMillionYears, 3.0 / 1000.0, system: "US Customary");
}