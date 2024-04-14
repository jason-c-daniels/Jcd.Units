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
   /// inch per square second defined such that: SI centimeter per square second = in/s² × (2.54)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareSecond =
      new("inch per square second", "in/s²", SI.Accelerations.CentimeterPerSquareSecond, 2.54 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// inch per square planck-time defined such that: SI centimeter per square microsecond = in/tₚ² ×
   /// (2.54)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration InchPerSquarePlanckTime = new("inch per square planck-time"
                                                                   , "in/tₚ²"
                                                                   , SI.Accelerations.CentimeterPerSquareMicrosecond
                                                                   , 2.54 / (5.391247E-38 * 5.391247E-38)
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// inch per square decisecond defined such that: SI centimeter per square second = in/ds² ×
   /// (2.54)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareDecisecond = new("inch per square decisecond"
                                                                   , "in/ds²"
                                                                   , SI.Accelerations.CentimeterPerSquareSecond
                                                                   , 2.54 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// inch per square centisecond defined such that: SI centimeter per square decisecond = in/cs² ×
   /// (2.54)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareCentisecond = new("inch per square centisecond"
                                                                    , "in/cs²"
                                                                    , SI.Accelerations.CentimeterPerSquareDecisecond
                                                                    , 2.54 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// inch per square millisecond defined such that: SI centimeter per square centisecond = in/ms² ×
   /// (2.54)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareMillisecond = new("inch per square millisecond"
                                                                    , "in/ms²"
                                                                    , SI.Accelerations.CentimeterPerSquareCentisecond
                                                                    , 2.54 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// inch per square microsecond defined such that: SI centimeter per square millisecond = in/μs² ×
   /// (2.54)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareMicrosecond = new("inch per square microsecond"
                                                                    , "in/μs²"
                                                                    , SI.Accelerations.CentimeterPerSquareMillisecond
                                                                    , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// inch per square nanosecond defined such that: SI centimeter per square microsecond = in/ns² ×
   /// (2.54)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareNanosecond = new("inch per square nanosecond"
                                                                   , "in/ns²"
                                                                   , SI.Accelerations.CentimeterPerSquareMicrosecond
                                                                   , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// inch per square picosecond defined such that: SI centimeter per square nanosecond = in/ps² ×
   /// (2.54)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquarePicosecond = new("inch per square picosecond"
                                                                   , "in/ps²"
                                                                   , SI.Accelerations.CentimeterPerSquareNanosecond
                                                                   , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// inch per square femtosecond defined such that: SI centimeter per square picosecond = in/fs² ×
   /// (2.54)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareFemtosecond = new("inch per square femtosecond"
                                                                    , "in/fs²"
                                                                    , SI.Accelerations.CentimeterPerSquarePicosecond
                                                                    , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// inch per square attosecond defined such that: SI centimeter per square femtosecond = in/as² ×
   /// (2.54)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareAttosecond = new("inch per square attosecond"
                                                                   , "in/as²"
                                                                   , SI.Accelerations.CentimeterPerSquareFemtosecond
                                                                   , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// inch per square zeptosecond defined such that: SI centimeter per square attosecond = in/zs² ×
   /// (2.54)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareZeptosecond = new("inch per square zeptosecond"
                                                                    , "in/zs²"
                                                                    , SI.Accelerations.CentimeterPerSquareAttosecond
                                                                    , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// inch per square yoctosecond defined such that: SI centimeter per square zeptosecond = in/ys² ×
   /// (2.54)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareYoctosecond = new("inch per square yoctosecond"
                                                                    , "in/ys²"
                                                                    , SI.Accelerations.CentimeterPerSquareZeptosecond
                                                                    , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// inch per square rontosecond defined such that: SI centimeter per square yoctosecond = in/rs² ×
   /// (2.54)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareRontosecond = new("inch per square rontosecond"
                                                                    , "in/rs²"
                                                                    , SI.Accelerations.CentimeterPerSquareYoctosecond
                                                                    , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// inch per square quectosecond defined such that: SI centimeter per square rontosecond = in/qs² ×
   /// (2.54)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareQuectosecond = new("inch per square quectosecond"
                                                                     , "in/qs²"
                                                                     , SI.Accelerations.CentimeterPerSquareRontosecond
                                                                     , 2.54 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , system: "Imperial"
                                                                      );
   
   /// <summary>
   /// inch per square minute defined such that: SI centimeter per square second = in/min² × (2.54)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareMinute =
      new("inch per square minute", "in/min²", SI.Accelerations.CentimeterPerSquareSecond, 2.54 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// foot per square second defined such that: inch per square second = ft/s² × (12)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareSecond = new("foot per square second", "ft/s²", InchPerSquareSecond, 12 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// foot per square planck-time defined such that: inch per square microsecond = ft/tₚ² ×
   /// (12)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration FootPerSquarePlanckTime =
      new("foot per square planck-time", "ft/tₚ²", InchPerSquareMicrosecond, 12 / (5.391247E-38 * 5.391247E-38), system: "Imperial");
   
   /// <summary>
   /// foot per square decisecond defined such that: inch per square second = ft/ds² × (12)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareDecisecond =
      new("foot per square decisecond", "ft/ds²", InchPerSquareSecond, 12 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// foot per square centisecond defined such that: inch per square decisecond = ft/cs² × (12)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareCentisecond =
      new("foot per square centisecond", "ft/cs²", InchPerSquareDecisecond, 12 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// foot per square millisecond defined such that: inch per square centisecond = ft/ms² × (12)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareMillisecond =
      new("foot per square millisecond", "ft/ms²", InchPerSquareCentisecond, 12 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// foot per square microsecond defined such that: inch per square millisecond = ft/μs² ×
   /// (12)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareMicrosecond =
      new("foot per square microsecond", "ft/μs²", InchPerSquareMillisecond, 12 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// foot per square nanosecond defined such that: inch per square microsecond = ft/ns² ×
   /// (12)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareNanosecond =
      new("foot per square nanosecond", "ft/ns²", InchPerSquareMicrosecond, 12 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// foot per square picosecond defined such that: inch per square nanosecond = ft/ps² ×
   /// (12)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquarePicosecond =
      new("foot per square picosecond", "ft/ps²", InchPerSquareNanosecond, 12 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// foot per square femtosecond defined such that: inch per square picosecond = ft/fs² ×
   /// (12)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareFemtosecond =
      new("foot per square femtosecond", "ft/fs²", InchPerSquarePicosecond, 12 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// foot per square attosecond defined such that: inch per square femtosecond = ft/as² ×
   /// (12)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareAttosecond =
      new("foot per square attosecond", "ft/as²", InchPerSquareFemtosecond, 12 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// foot per square zeptosecond defined such that: inch per square attosecond = ft/zs² ×
   /// (12)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareZeptosecond =
      new("foot per square zeptosecond", "ft/zs²", InchPerSquareAttosecond, 12 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// foot per square yoctosecond defined such that: inch per square zeptosecond = ft/ys² ×
   /// (12)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareYoctosecond =
      new("foot per square yoctosecond", "ft/ys²", InchPerSquareZeptosecond, 12 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// foot per square rontosecond defined such that: inch per square yoctosecond = ft/rs² ×
   /// (12)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareRontosecond =
      new("foot per square rontosecond", "ft/rs²", InchPerSquareYoctosecond, 12 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// foot per square quectosecond defined such that: inch per square rontosecond = ft/qs² ×
   /// (12)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareQuectosecond =
      new("foot per square quectosecond", "ft/qs²", InchPerSquareRontosecond, 12 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// inch per square hour defined such that: SI centimeter per square minute = in/hr² × (2.54)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareHour =
      new("inch per square hour", "in/hr²", SI.Accelerations.CentimeterPerSquareMinute, 2.54 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// twip per square second defined such that: foot per square second = twip/s² × (1.0/17280.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareSecond =
      new("twip per square second", "twip/s²", FootPerSquareSecond, 1.0 / 17280.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// twip per square planck-time defined such that: foot per square microsecond = twip/tₚ² ×
   /// (1.0/17280.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration TwipPerSquarePlanckTime = new("twip per square planck-time"
                                                                   , "twip/tₚ²"
                                                                   , FootPerSquareMicrosecond
                                                                   , 1.0 / 17280.0 / (5.391247E-38 * 5.391247E-38)
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// twip per square decisecond defined such that: foot per square second = twip/ds² ×
   /// (1.0/17280.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecisecond =
      new("twip per square decisecond", "twip/ds²", FootPerSquareSecond, 1.0 / 17280.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// twip per square centisecond defined such that: foot per square decisecond = twip/cs² ×
   /// (1.0/17280.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareCentisecond = new("twip per square centisecond"
                                                                    , "twip/cs²"
                                                                    , FootPerSquareDecisecond
                                                                    , 1.0 / 17280.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// twip per square millisecond defined such that: foot per square centisecond = twip/ms² ×
   /// (1.0/17280.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillisecond = new("twip per square millisecond"
                                                                    , "twip/ms²"
                                                                    , FootPerSquareCentisecond
                                                                    , 1.0 / 17280.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// twip per square microsecond defined such that: foot per square millisecond = twip/μs² ×
   /// (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareMicrosecond = new("twip per square microsecond"
                                                                    , "twip/μs²"
                                                                    , FootPerSquareMillisecond
                                                                    , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// twip per square nanosecond defined such that: foot per square microsecond = twip/ns² ×
   /// (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareNanosecond = new("twip per square nanosecond"
                                                                   , "twip/ns²"
                                                                   , FootPerSquareMicrosecond
                                                                   , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// twip per square picosecond defined such that: foot per square nanosecond = twip/ps² ×
   /// (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquarePicosecond = new("twip per square picosecond"
                                                                   , "twip/ps²"
                                                                   , FootPerSquareNanosecond
                                                                   , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// twip per square femtosecond defined such that: foot per square picosecond = twip/fs² ×
   /// (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareFemtosecond = new("twip per square femtosecond"
                                                                    , "twip/fs²"
                                                                    , FootPerSquarePicosecond
                                                                    , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// twip per square attosecond defined such that: foot per square femtosecond = twip/as² ×
   /// (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareAttosecond = new("twip per square attosecond"
                                                                   , "twip/as²"
                                                                   , FootPerSquareFemtosecond
                                                                   , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// twip per square zeptosecond defined such that: foot per square attosecond = twip/zs² ×
   /// (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareZeptosecond = new("twip per square zeptosecond"
                                                                    , "twip/zs²"
                                                                    , FootPerSquareAttosecond
                                                                    , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// twip per square yoctosecond defined such that: foot per square zeptosecond = twip/ys² ×
   /// (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareYoctosecond = new("twip per square yoctosecond"
                                                                    , "twip/ys²"
                                                                    , FootPerSquareZeptosecond
                                                                    , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// twip per square rontosecond defined such that: foot per square yoctosecond = twip/rs² ×
   /// (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareRontosecond = new("twip per square rontosecond"
                                                                    , "twip/rs²"
                                                                    , FootPerSquareYoctosecond
                                                                    , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// twip per square quectosecond defined such that: foot per square rontosecond = twip/qs² ×
   /// (1.0/17280.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuectosecond = new("twip per square quectosecond"
                                                                     , "twip/qs²"
                                                                     , FootPerSquareRontosecond
                                                                     , 1.0 / 17280.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , system: "Imperial"
                                                                      );
   
   /// <summary>
   /// inch per square day defined such that: SI centimeter per square hour = in/dy² × (2.54)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareDay =
      new("inch per square day", "in/dy²", SI.Accelerations.CentimeterPerSquareHour, 2.54 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// thou per square second defined such that: foot per square second = th/s² × (1.0/12000.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareSecond =
      new("thou per square second", "th/s²", FootPerSquareSecond, 1.0 / 12000.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// thou per square planck-time defined such that: foot per square microsecond = th/tₚ² ×
   /// (1.0/12000.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration ThouPerSquarePlanckTime = new("thou per square planck-time"
                                                                   , "th/tₚ²"
                                                                   , FootPerSquareMicrosecond
                                                                   , 1.0 / 12000.0 / (5.391247E-38 * 5.391247E-38)
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// thou per square decisecond defined such that: foot per square second = th/ds² ×
   /// (1.0/12000.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareDecisecond =
      new("thou per square decisecond", "th/ds²", FootPerSquareSecond, 1.0 / 12000.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// thou per square centisecond defined such that: foot per square decisecond = th/cs² ×
   /// (1.0/12000.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareCentisecond = new("thou per square centisecond"
                                                                    , "th/cs²"
                                                                    , FootPerSquareDecisecond
                                                                    , 1.0 / 12000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// thou per square millisecond defined such that: foot per square centisecond = th/ms² ×
   /// (1.0/12000.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareMillisecond = new("thou per square millisecond"
                                                                    , "th/ms²"
                                                                    , FootPerSquareCentisecond
                                                                    , 1.0 / 12000.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// thou per square microsecond defined such that: foot per square millisecond = th/μs² ×
   /// (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareMicrosecond = new("thou per square microsecond"
                                                                    , "th/μs²"
                                                                    , FootPerSquareMillisecond
                                                                    , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// thou per square nanosecond defined such that: foot per square microsecond = th/ns² ×
   /// (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareNanosecond = new("thou per square nanosecond"
                                                                   , "th/ns²"
                                                                   , FootPerSquareMicrosecond
                                                                   , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// thou per square picosecond defined such that: foot per square nanosecond = th/ps² ×
   /// (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquarePicosecond = new("thou per square picosecond"
                                                                   , "th/ps²"
                                                                   , FootPerSquareNanosecond
                                                                   , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// thou per square femtosecond defined such that: foot per square picosecond = th/fs² ×
   /// (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareFemtosecond = new("thou per square femtosecond"
                                                                    , "th/fs²"
                                                                    , FootPerSquarePicosecond
                                                                    , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// thou per square attosecond defined such that: foot per square femtosecond = th/as² ×
   /// (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareAttosecond = new("thou per square attosecond"
                                                                   , "th/as²"
                                                                   , FootPerSquareFemtosecond
                                                                   , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , system: "Imperial"
                                                                    );
   
   /// <summary>
   /// thou per square zeptosecond defined such that: foot per square attosecond = th/zs² ×
   /// (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareZeptosecond = new("thou per square zeptosecond"
                                                                    , "th/zs²"
                                                                    , FootPerSquareAttosecond
                                                                    , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// thou per square yoctosecond defined such that: foot per square zeptosecond = th/ys² ×
   /// (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareYoctosecond = new("thou per square yoctosecond"
                                                                    , "th/ys²"
                                                                    , FootPerSquareZeptosecond
                                                                    , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// thou per square rontosecond defined such that: foot per square yoctosecond = th/rs² ×
   /// (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareRontosecond = new("thou per square rontosecond"
                                                                    , "th/rs²"
                                                                    , FootPerSquareYoctosecond
                                                                    , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// thou per square quectosecond defined such that: foot per square rontosecond = th/qs² ×
   /// (1.0/12000.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareQuectosecond = new("thou per square quectosecond"
                                                                     , "th/qs²"
                                                                     , FootPerSquareRontosecond
                                                                     , 1.0 / 12000.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , system: "Imperial"
                                                                      );
   
   /// <summary>
   /// inch per square week defined such that: SI centimeter per square day = in/wk² × (2.54)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareWeek =
      new("inch per square week", "in/wk²", SI.Accelerations.CentimeterPerSquareDay, 2.54 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square second defined such that: foot per square second = barleycorn/s² × (1.0/36.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareSecond =
      new("barleycorn per square second", "barleycorn/s²", FootPerSquareSecond, 1.0 / 36.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square planck-time defined such that: foot per square microsecond = barleycorn/tₚ² ×
   /// (1.0/36.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquarePlanckTime = new("barleycorn per square planck-time"
                                                                         , "barleycorn/tₚ²"
                                                                         , FootPerSquareMicrosecond
                                                                         , 1.0 / 36.0 / (5.391247E-38 * 5.391247E-38)
                                                                         , system: "Imperial"
                                                                          );
   
   /// <summary>
   /// barleycorn per square decisecond defined such that: foot per square second = barleycorn/ds² ×
   /// (1.0/36.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDecisecond = new("barleycorn per square decisecond"
                                                                         , "barleycorn/ds²"
                                                                         , FootPerSquareSecond
                                                                         , 1.0 / 36.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                         , system: "Imperial"
                                                                          );
   
   /// <summary>
   /// barleycorn per square centisecond defined such that: foot per square decisecond = barleycorn/cs² ×
   /// (1.0/36.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareCentisecond = new("barleycorn per square centisecond"
                                                                          , "barleycorn/cs²"
                                                                          , FootPerSquareDecisecond
                                                                          , 1.0 / 36.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , system: "Imperial"
                                                                           );
   
   /// <summary>
   /// barleycorn per square millisecond defined such that: foot per square centisecond = barleycorn/ms² ×
   /// (1.0/36.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMillisecond = new("barleycorn per square millisecond"
                                                                          , "barleycorn/ms²"
                                                                          , FootPerSquareCentisecond
                                                                          , 1.0 / 36.0 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                          , system: "Imperial"
                                                                           );
   
   /// <summary>
   /// barleycorn per square microsecond defined such that: foot per square millisecond = barleycorn/μs² ×
   /// (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMicrosecond = new("barleycorn per square microsecond"
                                                                          , "barleycorn/μs²"
                                                                          , FootPerSquareMillisecond
                                                                          , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , system: "Imperial"
                                                                           );
   
   /// <summary>
   /// barleycorn per square nanosecond defined such that: foot per square microsecond = barleycorn/ns² ×
   /// (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareNanosecond = new("barleycorn per square nanosecond"
                                                                         , "barleycorn/ns²"
                                                                         , FootPerSquareMicrosecond
                                                                         , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , system: "Imperial"
                                                                          );
   
   /// <summary>
   /// barleycorn per square picosecond defined such that: foot per square nanosecond = barleycorn/ps² ×
   /// (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquarePicosecond = new("barleycorn per square picosecond"
                                                                         , "barleycorn/ps²"
                                                                         , FootPerSquareNanosecond
                                                                         , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , system: "Imperial"
                                                                          );
   
   /// <summary>
   /// barleycorn per square femtosecond defined such that: foot per square picosecond = barleycorn/fs² ×
   /// (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareFemtosecond = new("barleycorn per square femtosecond"
                                                                          , "barleycorn/fs²"
                                                                          , FootPerSquarePicosecond
                                                                          , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , system: "Imperial"
                                                                           );
   
   /// <summary>
   /// barleycorn per square attosecond defined such that: foot per square femtosecond = barleycorn/as² ×
   /// (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareAttosecond = new("barleycorn per square attosecond"
                                                                         , "barleycorn/as²"
                                                                         , FootPerSquareFemtosecond
                                                                         , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , system: "Imperial"
                                                                          );
   
   /// <summary>
   /// barleycorn per square zeptosecond defined such that: foot per square attosecond = barleycorn/zs² ×
   /// (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareZeptosecond = new("barleycorn per square zeptosecond"
                                                                          , "barleycorn/zs²"
                                                                          , FootPerSquareAttosecond
                                                                          , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , system: "Imperial"
                                                                           );
   
   /// <summary>
   /// barleycorn per square yoctosecond defined such that: foot per square zeptosecond = barleycorn/ys² ×
   /// (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareYoctosecond = new("barleycorn per square yoctosecond"
                                                                          , "barleycorn/ys²"
                                                                          , FootPerSquareZeptosecond
                                                                          , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , system: "Imperial"
                                                                           );
   
   /// <summary>
   /// barleycorn per square rontosecond defined such that: foot per square yoctosecond = barleycorn/rs² ×
   /// (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareRontosecond = new("barleycorn per square rontosecond"
                                                                          , "barleycorn/rs²"
                                                                          , FootPerSquareYoctosecond
                                                                          , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                          , system: "Imperial"
                                                                           );
   
   /// <summary>
   /// barleycorn per square quectosecond defined such that: foot per square rontosecond = barleycorn/qs² ×
   /// (1.0/36.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareQuectosecond = new("barleycorn per square quectosecond"
                                                                           , "barleycorn/qs²"
                                                                           , FootPerSquareRontosecond
                                                                           , 1.0 / 36.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , system: "Imperial"
                                                                            );
   
   /// <summary>
   /// inch per square year defined such that: SI centimeter per square day = in/yr² × (2.54)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration InchPerSquareYear =
      new("inch per square year", "in/yr²", SI.Accelerations.CentimeterPerSquareDay, 2.54 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// hand per square second defined such that: inch per square second = hh/s² × (4.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareSecond = new("hand per square second", "hh/s²", InchPerSquareSecond, 4.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// hand per square planck-time defined such that: inch per square microsecond = hh/tₚ² ×
   /// (4.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration HandPerSquarePlanckTime =
      new("hand per square planck-time", "hh/tₚ²", InchPerSquareMicrosecond, 4.0 / (5.391247E-38 * 5.391247E-38), system: "Imperial");
   
   /// <summary>
   /// hand per square decisecond defined such that: inch per square second = hh/ds² × (4.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareDecisecond =
      new("hand per square decisecond", "hh/ds²", InchPerSquareSecond, 4.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// hand per square centisecond defined such that: inch per square decisecond = hh/cs² × (4.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareCentisecond =
      new("hand per square centisecond", "hh/cs²", InchPerSquareDecisecond, 4.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// hand per square millisecond defined such that: inch per square centisecond = hh/ms² × (4.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareMillisecond =
      new("hand per square millisecond", "hh/ms²", InchPerSquareCentisecond, 4.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// hand per square microsecond defined such that: inch per square millisecond = hh/μs² ×
   /// (4.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareMicrosecond =
      new("hand per square microsecond", "hh/μs²", InchPerSquareMillisecond, 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// hand per square nanosecond defined such that: inch per square microsecond = hh/ns² ×
   /// (4.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareNanosecond =
      new("hand per square nanosecond", "hh/ns²", InchPerSquareMicrosecond, 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// hand per square picosecond defined such that: inch per square nanosecond = hh/ps² ×
   /// (4.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquarePicosecond =
      new("hand per square picosecond", "hh/ps²", InchPerSquareNanosecond, 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// hand per square femtosecond defined such that: inch per square picosecond = hh/fs² ×
   /// (4.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareFemtosecond =
      new("hand per square femtosecond", "hh/fs²", InchPerSquarePicosecond, 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// hand per square attosecond defined such that: inch per square femtosecond = hh/as² ×
   /// (4.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareAttosecond =
      new("hand per square attosecond", "hh/as²", InchPerSquareFemtosecond, 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// hand per square zeptosecond defined such that: inch per square attosecond = hh/zs² ×
   /// (4.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareZeptosecond =
      new("hand per square zeptosecond", "hh/zs²", InchPerSquareAttosecond, 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// hand per square yoctosecond defined such that: inch per square zeptosecond = hh/ys² ×
   /// (4.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareYoctosecond =
      new("hand per square yoctosecond", "hh/ys²", InchPerSquareZeptosecond, 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// hand per square rontosecond defined such that: inch per square yoctosecond = hh/rs² ×
   /// (4.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareRontosecond =
      new("hand per square rontosecond", "hh/rs²", InchPerSquareYoctosecond, 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// hand per square quectosecond defined such that: inch per square rontosecond = hh/qs² ×
   /// (4.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareQuectosecond =
      new("hand per square quectosecond", "hh/qs²", InchPerSquareRontosecond, 4.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// inch per square decade defined such that: SI centimeter per square year = in/decade² × (2.54)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareDecade =
      new("inch per square decade", "in/decade²", SI.Accelerations.CentimeterPerSquareYear, 2.54 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// yard per square second defined such that: foot per square second = yd/s² × (3.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareSecond = new("yard per square second", "yd/s²", FootPerSquareSecond, 3.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// yard per square planck-time defined such that: foot per square microsecond = yd/tₚ² ×
   /// (3.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration YardPerSquarePlanckTime =
      new("yard per square planck-time", "yd/tₚ²", FootPerSquareMicrosecond, 3.0 / (5.391247E-38 * 5.391247E-38), system: "Imperial");
   
   /// <summary>
   /// yard per square decisecond defined such that: foot per square second = yd/ds² × (3.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareDecisecond =
      new("yard per square decisecond", "yd/ds²", FootPerSquareSecond, 3.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// yard per square centisecond defined such that: foot per square decisecond = yd/cs² × (3.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareCentisecond =
      new("yard per square centisecond", "yd/cs²", FootPerSquareDecisecond, 3.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// yard per square millisecond defined such that: foot per square centisecond = yd/ms² × (3.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareMillisecond =
      new("yard per square millisecond", "yd/ms²", FootPerSquareCentisecond, 3.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// yard per square microsecond defined such that: foot per square millisecond = yd/μs² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareMicrosecond =
      new("yard per square microsecond", "yd/μs²", FootPerSquareMillisecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// yard per square nanosecond defined such that: foot per square microsecond = yd/ns² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareNanosecond =
      new("yard per square nanosecond", "yd/ns²", FootPerSquareMicrosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// yard per square picosecond defined such that: foot per square nanosecond = yd/ps² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquarePicosecond =
      new("yard per square picosecond", "yd/ps²", FootPerSquareNanosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// yard per square femtosecond defined such that: foot per square picosecond = yd/fs² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareFemtosecond =
      new("yard per square femtosecond", "yd/fs²", FootPerSquarePicosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// yard per square attosecond defined such that: foot per square femtosecond = yd/as² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareAttosecond =
      new("yard per square attosecond", "yd/as²", FootPerSquareFemtosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// yard per square zeptosecond defined such that: foot per square attosecond = yd/zs² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareZeptosecond =
      new("yard per square zeptosecond", "yd/zs²", FootPerSquareAttosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// yard per square yoctosecond defined such that: foot per square zeptosecond = yd/ys² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareYoctosecond =
      new("yard per square yoctosecond", "yd/ys²", FootPerSquareZeptosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// yard per square rontosecond defined such that: foot per square yoctosecond = yd/rs² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareRontosecond =
      new("yard per square rontosecond", "yd/rs²", FootPerSquareYoctosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// yard per square quectosecond defined such that: foot per square rontosecond = yd/qs² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareQuectosecond =
      new("yard per square quectosecond", "yd/qs²", FootPerSquareRontosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// inch per square century defined such that: SI centimeter per square decade = in/century² × (2.54)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareCentury = new("inch per square century"
                                                                , "in/century²"
                                                                , SI.Accelerations.CentimeterPerSquareDecade
                                                                , 2.54 / (10.0 * 10.0)
                                                                , system: "Imperial"
                                                                 );
   
   /// <summary>
   /// chain per square second defined such that: yard per square second = ch/s² × (22.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareSecond = new("chain per square second", "ch/s²", YardPerSquareSecond, 22.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// chain per square planck-time defined such that: yard per square microsecond = ch/tₚ² ×
   /// (22.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration ChainPerSquarePlanckTime =
      new("chain per square planck-time", "ch/tₚ²", YardPerSquareMicrosecond, 22.0 / (5.391247E-38 * 5.391247E-38), system: "Imperial");
   
   /// <summary>
   /// chain per square decisecond defined such that: yard per square second = ch/ds² × (22.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecisecond =
      new("chain per square decisecond", "ch/ds²", YardPerSquareSecond, 22.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// chain per square centisecond defined such that: yard per square decisecond = ch/cs² ×
   /// (22.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareCentisecond =
      new("chain per square centisecond", "ch/cs²", YardPerSquareDecisecond, 22.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// chain per square millisecond defined such that: yard per square centisecond = ch/ms² ×
   /// (22.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillisecond =
      new("chain per square millisecond", "ch/ms²", YardPerSquareCentisecond, 22.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// chain per square microsecond defined such that: yard per square millisecond = ch/μs² ×
   /// (22.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareMicrosecond =
      new("chain per square microsecond", "ch/μs²", YardPerSquareMillisecond, 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// chain per square nanosecond defined such that: yard per square microsecond = ch/ns² ×
   /// (22.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareNanosecond =
      new("chain per square nanosecond", "ch/ns²", YardPerSquareMicrosecond, 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// chain per square picosecond defined such that: yard per square nanosecond = ch/ps² ×
   /// (22.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquarePicosecond =
      new("chain per square picosecond", "ch/ps²", YardPerSquareNanosecond, 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// chain per square femtosecond defined such that: yard per square picosecond = ch/fs² ×
   /// (22.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareFemtosecond =
      new("chain per square femtosecond", "ch/fs²", YardPerSquarePicosecond, 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// chain per square attosecond defined such that: yard per square femtosecond = ch/as² ×
   /// (22.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareAttosecond =
      new("chain per square attosecond", "ch/as²", YardPerSquareFemtosecond, 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// chain per square zeptosecond defined such that: yard per square attosecond = ch/zs² ×
   /// (22.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareZeptosecond =
      new("chain per square zeptosecond", "ch/zs²", YardPerSquareAttosecond, 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// chain per square yoctosecond defined such that: yard per square zeptosecond = ch/ys² ×
   /// (22.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareYoctosecond =
      new("chain per square yoctosecond", "ch/ys²", YardPerSquareZeptosecond, 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// chain per square rontosecond defined such that: yard per square yoctosecond = ch/rs² ×
   /// (22.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareRontosecond =
      new("chain per square rontosecond", "ch/rs²", YardPerSquareYoctosecond, 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// chain per square quectosecond defined such that: yard per square rontosecond = ch/qs² ×
   /// (22.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuectosecond =
      new("chain per square quectosecond", "ch/qs²", YardPerSquareRontosecond, 22.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// inch per square millennium defined such that: SI centimeter per square century = in/kyr² × (2.54)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareMillennium =
      new("inch per square millennium", "in/kyr²", SI.Accelerations.CentimeterPerSquareCentury, 2.54 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square second defined such that: chain per square second = fur/s² × (10.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSecond =
      new("furlong per square second", "fur/s²", ChainPerSquareSecond, 10.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square planck-time defined such that: chain per square microsecond = fur/tₚ² ×
   /// (10.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquarePlanckTime =
      new("furlong per square planck-time", "fur/tₚ²", ChainPerSquareMicrosecond, 10.0 / (5.391247E-38 * 5.391247E-38), system: "Imperial");
   
   /// <summary>
   /// furlong per square decisecond defined such that: chain per square second = fur/ds² × (10.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecisecond =
      new("furlong per square decisecond", "fur/ds²", ChainPerSquareSecond, 10.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// furlong per square centisecond defined such that: chain per square decisecond = fur/cs² ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareCentisecond =
      new("furlong per square centisecond", "fur/cs²", ChainPerSquareDecisecond, 10.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// furlong per square millisecond defined such that: chain per square centisecond = fur/ms² ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillisecond =
      new("furlong per square millisecond", "fur/ms²", ChainPerSquareCentisecond, 10.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// furlong per square microsecond defined such that: chain per square millisecond = fur/μs² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMicrosecond = new("furlong per square microsecond"
                                                                       , "fur/μs²"
                                                                       , ChainPerSquareMillisecond
                                                                       , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , system: "Imperial"
                                                                        );
   
   /// <summary>
   /// furlong per square nanosecond defined such that: chain per square microsecond = fur/ns² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareNanosecond =
      new("furlong per square nanosecond", "fur/ns²", ChainPerSquareMicrosecond, 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// furlong per square picosecond defined such that: chain per square nanosecond = fur/ps² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquarePicosecond =
      new("furlong per square picosecond", "fur/ps²", ChainPerSquareNanosecond, 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// furlong per square femtosecond defined such that: chain per square picosecond = fur/fs² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareFemtosecond =
      new("furlong per square femtosecond", "fur/fs²", ChainPerSquarePicosecond, 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// furlong per square attosecond defined such that: chain per square femtosecond = fur/as² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareAttosecond =
      new("furlong per square attosecond", "fur/as²", ChainPerSquareFemtosecond, 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// furlong per square zeptosecond defined such that: chain per square attosecond = fur/zs² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareZeptosecond =
      new("furlong per square zeptosecond", "fur/zs²", ChainPerSquareAttosecond, 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// furlong per square yoctosecond defined such that: chain per square zeptosecond = fur/ys² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareYoctosecond = new("furlong per square yoctosecond"
                                                                       , "fur/ys²"
                                                                       , ChainPerSquareZeptosecond
                                                                       , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , system: "Imperial"
                                                                        );
   
   /// <summary>
   /// furlong per square rontosecond defined such that: chain per square yoctosecond = fur/rs² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareRontosecond = new("furlong per square rontosecond"
                                                                       , "fur/rs²"
                                                                       , ChainPerSquareYoctosecond
                                                                       , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , system: "Imperial"
                                                                        );
   
   /// <summary>
   /// furlong per square quectosecond defined such that: chain per square rontosecond = fur/qs² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuectosecond = new("furlong per square quectosecond"
                                                                        , "fur/qs²"
                                                                        , ChainPerSquareRontosecond
                                                                        , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , system: "Imperial"
                                                                         );
   
   /// <summary>
   /// inch per square million years defined such that: SI centimeter per square millennium = in/Myr² ×
   /// (2.54)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareMillionYears = new("inch per square million years"
                                                                     , "in/Myr²"
                                                                     , SI.Accelerations.CentimeterPerSquareMillennium
                                                                     , 2.54 / (1000.0 * 1000.0)
                                                                     , system: "Imperial"
                                                                      );
   
   /// <summary>
   /// mile per square second defined such that: furlong per square second = mi/s² × (8.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareSecond = new("mile per square second", "mi/s²", FurlongPerSquareSecond, 8.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// mile per square planck-time defined such that: furlong per square microsecond = mi/tₚ² ×
   /// (8.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration MilePerSquarePlanckTime =
      new("mile per square planck-time", "mi/tₚ²", FurlongPerSquareMicrosecond, 8.0 / (5.391247E-38 * 5.391247E-38), system: "Imperial");
   
   /// <summary>
   /// mile per square decisecond defined such that: furlong per square second = mi/ds² × (8.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareDecisecond =
      new("mile per square decisecond", "mi/ds²", FurlongPerSquareSecond, 8.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// mile per square centisecond defined such that: furlong per square decisecond = mi/cs² ×
   /// (8.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareCentisecond =
      new("mile per square centisecond", "mi/cs²", FurlongPerSquareDecisecond, 8.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// mile per square millisecond defined such that: furlong per square centisecond = mi/ms² ×
   /// (8.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareMillisecond =
      new("mile per square millisecond", "mi/ms²", FurlongPerSquareCentisecond, 8.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// mile per square microsecond defined such that: furlong per square millisecond = mi/μs² ×
   /// (8.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareMicrosecond =
      new("mile per square microsecond", "mi/μs²", FurlongPerSquareMillisecond, 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// mile per square nanosecond defined such that: furlong per square microsecond = mi/ns² ×
   /// (8.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareNanosecond =
      new("mile per square nanosecond", "mi/ns²", FurlongPerSquareMicrosecond, 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// mile per square picosecond defined such that: furlong per square nanosecond = mi/ps² ×
   /// (8.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquarePicosecond =
      new("mile per square picosecond", "mi/ps²", FurlongPerSquareNanosecond, 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// mile per square femtosecond defined such that: furlong per square picosecond = mi/fs² ×
   /// (8.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareFemtosecond =
      new("mile per square femtosecond", "mi/fs²", FurlongPerSquarePicosecond, 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// mile per square attosecond defined such that: furlong per square femtosecond = mi/as² ×
   /// (8.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareAttosecond =
      new("mile per square attosecond", "mi/as²", FurlongPerSquareFemtosecond, 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// mile per square zeptosecond defined such that: furlong per square attosecond = mi/zs² ×
   /// (8.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareZeptosecond =
      new("mile per square zeptosecond", "mi/zs²", FurlongPerSquareAttosecond, 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// mile per square yoctosecond defined such that: furlong per square zeptosecond = mi/ys² ×
   /// (8.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareYoctosecond =
      new("mile per square yoctosecond", "mi/ys²", FurlongPerSquareZeptosecond, 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// mile per square rontosecond defined such that: furlong per square yoctosecond = mi/rs² ×
   /// (8.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareRontosecond =
      new("mile per square rontosecond", "mi/rs²", FurlongPerSquareYoctosecond, 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// mile per square quectosecond defined such that: furlong per square rontosecond = mi/qs² ×
   /// (8.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareQuectosecond =
      new("mile per square quectosecond", "mi/qs²", FurlongPerSquareRontosecond, 8.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// inch per square billion years defined such that: SI centimeter per square million years = in/Gyr² ×
   /// (2.54)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareBillionYears = new("inch per square billion years"
                                                                     , "in/Gyr²"
                                                                     , SI.Accelerations.CentimeterPerSquareMillionYears
                                                                     , 2.54 / (1000.0 * 1000.0)
                                                                     , system: "Imperial"
                                                                      );
   
   /// <summary>
   /// league per square second defined such that: mile per square second = lea/s² × (3.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSecond = new("league per square second", "lea/s²", MilePerSquareSecond, 3.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// league per square planck-time defined such that: mile per square microsecond = lea/tₚ² ×
   /// (3.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePlanckTime =
      new("league per square planck-time", "lea/tₚ²", MilePerSquareMicrosecond, 3.0 / (5.391247E-38 * 5.391247E-38), system: "Imperial");
   
   /// <summary>
   /// league per square decisecond defined such that: mile per square second = lea/ds² × (3.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecisecond =
      new("league per square decisecond", "lea/ds²", MilePerSquareSecond, 3.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// league per square centisecond defined such that: mile per square decisecond = lea/cs² ×
   /// (3.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentisecond =
      new("league per square centisecond", "lea/cs²", MilePerSquareDecisecond, 3.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// league per square millisecond defined such that: mile per square centisecond = lea/ms² ×
   /// (3.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillisecond =
      new("league per square millisecond", "lea/ms²", MilePerSquareCentisecond, 3.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// league per square microsecond defined such that: mile per square millisecond = lea/μs² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMicrosecond =
      new("league per square microsecond", "lea/μs²", MilePerSquareMillisecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// league per square nanosecond defined such that: mile per square microsecond = lea/ns² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNanosecond =
      new("league per square nanosecond", "lea/ns²", MilePerSquareMicrosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// league per square picosecond defined such that: mile per square nanosecond = lea/ps² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePicosecond =
      new("league per square picosecond", "lea/ps²", MilePerSquareNanosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// league per square femtosecond defined such that: mile per square picosecond = lea/fs² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareFemtosecond =
      new("league per square femtosecond", "lea/fs²", MilePerSquarePicosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// league per square attosecond defined such that: mile per square femtosecond = lea/as² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareAttosecond =
      new("league per square attosecond", "lea/as²", MilePerSquareFemtosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// league per square zeptosecond defined such that: mile per square attosecond = lea/zs² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareZeptosecond =
      new("league per square zeptosecond", "lea/zs²", MilePerSquareAttosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// league per square yoctosecond defined such that: mile per square zeptosecond = lea/ys² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYoctosecond =
      new("league per square yoctosecond", "lea/ys²", MilePerSquareZeptosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// league per square rontosecond defined such that: mile per square yoctosecond = lea/rs² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareRontosecond =
      new("league per square rontosecond", "lea/rs²", MilePerSquareYoctosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// league per square quectosecond defined such that: mile per square rontosecond = lea/qs² ×
   /// (3.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuectosecond =
      new("league per square quectosecond", "lea/qs²", MilePerSquareRontosecond, 3.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// inch per square trillion years defined such that: SI centimeter per square billion years = in/Tyr² ×
   /// (2.54)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareTrillionYears = new("inch per square trillion years"
                                                                      , "in/Tyr²"
                                                                      , SI.Accelerations.CentimeterPerSquareBillionYears
                                                                      , 2.54 / (1000.0 * 1000.0)
                                                                      , system: "Imperial"
                                                                       );
   
   /// <summary>
   /// fathom per square second defined such that: foot per square second = ftm/s² × (6.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareSecond = new("fathom per square second", "ftm/s²", FootPerSquareSecond, 6.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square planck-time defined such that: foot per square microsecond = ftm/tₚ² ×
   /// (6.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration FathomPerSquarePlanckTime =
      new("fathom per square planck-time", "ftm/tₚ²", FootPerSquareMicrosecond, 6.0 / (5.391247E-38 * 5.391247E-38), system: "Imperial");
   
   /// <summary>
   /// fathom per square decisecond defined such that: foot per square second = ftm/ds² × (6.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecisecond =
      new("fathom per square decisecond", "ftm/ds²", FootPerSquareSecond, 6.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// fathom per square centisecond defined such that: foot per square decisecond = ftm/cs² ×
   /// (6.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareCentisecond =
      new("fathom per square centisecond", "ftm/cs²", FootPerSquareDecisecond, 6.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// fathom per square millisecond defined such that: foot per square centisecond = ftm/ms² ×
   /// (6.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillisecond =
      new("fathom per square millisecond", "ftm/ms²", FootPerSquareCentisecond, 6.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// fathom per square microsecond defined such that: foot per square millisecond = ftm/μs² ×
   /// (6.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareMicrosecond =
      new("fathom per square microsecond", "ftm/μs²", FootPerSquareMillisecond, 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// fathom per square nanosecond defined such that: foot per square microsecond = ftm/ns² ×
   /// (6.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareNanosecond =
      new("fathom per square nanosecond", "ftm/ns²", FootPerSquareMicrosecond, 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// fathom per square picosecond defined such that: foot per square nanosecond = ftm/ps² ×
   /// (6.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquarePicosecond =
      new("fathom per square picosecond", "ftm/ps²", FootPerSquareNanosecond, 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// fathom per square femtosecond defined such that: foot per square picosecond = ftm/fs² ×
   /// (6.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareFemtosecond =
      new("fathom per square femtosecond", "ftm/fs²", FootPerSquarePicosecond, 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// fathom per square attosecond defined such that: foot per square femtosecond = ftm/as² ×
   /// (6.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareAttosecond =
      new("fathom per square attosecond", "ftm/as²", FootPerSquareFemtosecond, 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// fathom per square zeptosecond defined such that: foot per square attosecond = ftm/zs² ×
   /// (6.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareZeptosecond =
      new("fathom per square zeptosecond", "ftm/zs²", FootPerSquareAttosecond, 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// fathom per square yoctosecond defined such that: foot per square zeptosecond = ftm/ys² ×
   /// (6.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareYoctosecond =
      new("fathom per square yoctosecond", "ftm/ys²", FootPerSquareZeptosecond, 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// fathom per square rontosecond defined such that: foot per square yoctosecond = ftm/rs² ×
   /// (6.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareRontosecond =
      new("fathom per square rontosecond", "ftm/rs²", FootPerSquareYoctosecond, 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// fathom per square quectosecond defined such that: foot per square rontosecond = ftm/qs² ×
   /// (6.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuectosecond =
      new("fathom per square quectosecond", "ftm/qs²", FootPerSquareRontosecond, 6.0 / (1.0 / 1000.0 * (1.0 / 1000.0)), system: "Imperial");
   
   /// <summary>
   /// inch per square quadrillion years defined such that: SI centimeter per square trillion years = in/Pyr² ×
   /// (2.54)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareQuadrillionYears = new("inch per square quadrillion years"
                                                                         , "in/Pyr²"
                                                                         , SI.Accelerations.CentimeterPerSquareTrillionYears
                                                                         , 2.54 / (1000.0 * 1000.0)
                                                                         , system: "Imperial"
                                                                          );
   
   /// <summary>
   /// cable per square second defined such that: fathom per square second = cable/s² × (100.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareSecond =
      new("cable per square second", "cable/s²", FathomPerSquareSecond, 100.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// cable per square planck-time defined such that: fathom per square microsecond = cable/tₚ² ×
   /// (100.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration CablePerSquarePlanckTime = new("cable per square planck-time"
                                                                    , "cable/tₚ²"
                                                                    , FathomPerSquareMicrosecond
                                                                    , 100.0 / (5.391247E-38 * 5.391247E-38)
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// cable per square decisecond defined such that: fathom per square second = cable/ds² ×
   /// (100.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareDecisecond =
      new("cable per square decisecond", "cable/ds²", FathomPerSquareSecond, 100.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// cable per square centisecond defined such that: fathom per square decisecond = cable/cs² ×
   /// (100.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareCentisecond =
      new("cable per square centisecond", "cable/cs²", FathomPerSquareDecisecond, 100.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// cable per square millisecond defined such that: fathom per square centisecond = cable/ms² ×
   /// (100.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareMillisecond =
      new("cable per square millisecond", "cable/ms²", FathomPerSquareCentisecond, 100.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// cable per square microsecond defined such that: fathom per square millisecond = cable/μs² ×
   /// (100.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareMicrosecond = new("cable per square microsecond"
                                                                     , "cable/μs²"
                                                                     , FathomPerSquareMillisecond
                                                                     , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , system: "Imperial"
                                                                      );
   
   /// <summary>
   /// cable per square nanosecond defined such that: fathom per square microsecond = cable/ns² ×
   /// (100.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareNanosecond = new("cable per square nanosecond"
                                                                    , "cable/ns²"
                                                                    , FathomPerSquareMicrosecond
                                                                    , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// cable per square picosecond defined such that: fathom per square nanosecond = cable/ps² ×
   /// (100.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquarePicosecond = new("cable per square picosecond"
                                                                    , "cable/ps²"
                                                                    , FathomPerSquareNanosecond
                                                                    , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// cable per square femtosecond defined such that: fathom per square picosecond = cable/fs² ×
   /// (100.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareFemtosecond = new("cable per square femtosecond"
                                                                     , "cable/fs²"
                                                                     , FathomPerSquarePicosecond
                                                                     , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , system: "Imperial"
                                                                      );
   
   /// <summary>
   /// cable per square attosecond defined such that: fathom per square femtosecond = cable/as² ×
   /// (100.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareAttosecond = new("cable per square attosecond"
                                                                    , "cable/as²"
                                                                    , FathomPerSquareFemtosecond
                                                                    , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , system: "Imperial"
                                                                     );
   
   /// <summary>
   /// cable per square zeptosecond defined such that: fathom per square attosecond = cable/zs² ×
   /// (100.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareZeptosecond = new("cable per square zeptosecond"
                                                                     , "cable/zs²"
                                                                     , FathomPerSquareAttosecond
                                                                     , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , system: "Imperial"
                                                                      );
   
   /// <summary>
   /// cable per square yoctosecond defined such that: fathom per square zeptosecond = cable/ys² ×
   /// (100.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareYoctosecond = new("cable per square yoctosecond"
                                                                     , "cable/ys²"
                                                                     , FathomPerSquareZeptosecond
                                                                     , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , system: "Imperial"
                                                                      );
   
   /// <summary>
   /// cable per square rontosecond defined such that: fathom per square yoctosecond = cable/rs² ×
   /// (100.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareRontosecond = new("cable per square rontosecond"
                                                                     , "cable/rs²"
                                                                     , FathomPerSquareYoctosecond
                                                                     , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , system: "Imperial"
                                                                      );
   
   /// <summary>
   /// cable per square quectosecond defined such that: fathom per square rontosecond = cable/qs² ×
   /// (100.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareQuectosecond = new("cable per square quectosecond"
                                                                      , "cable/qs²"
                                                                      , FathomPerSquareRontosecond
                                                                      , 100.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , system: "Imperial"
                                                                       );
   
   /// <summary>
   /// inch per square quintillion years defined such that: SI centimeter per square quadrillion years = in/Eyr² ×
   /// (2.54)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareQuintillionYears = new("inch per square quintillion years"
                                                                         , "in/Eyr²"
                                                                         , SI.Accelerations.CentimeterPerSquareQuadrillionYears
                                                                         , 2.54 / (1000.0 * 1000.0)
                                                                         , system: "Imperial"
                                                                          );
   
   /// <summary>
   /// nautical mile per square second defined such that: cable per square second = nmi/s² × (10.0)/((1.0)*(1.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSecond =
      new("nautical mile per square second", "nmi/s²", CablePerSquareSecond, 10.0 / (1.0 * 1.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square planck-time defined such that: cable per square microsecond = nmi/tₚ² ×
   /// (10.0)/((5.391247E-38)*(5.391247E-38)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquarePlanckTime = new("nautical mile per square planck-time"
                                                                           , "nmi/tₚ²"
                                                                           , CablePerSquareMicrosecond
                                                                           , 10.0 / (5.391247E-38 * 5.391247E-38)
                                                                           , system: "Imperial"
                                                                            );
   
   /// <summary>
   /// nautical mile per square decisecond defined such that: cable per square second = nmi/ds² ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecisecond =
      new("nautical mile per square decisecond", "nmi/ds²", CablePerSquareSecond, 10.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square centisecond defined such that: cable per square decisecond = nmi/cs² ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareCentisecond =
      new("nautical mile per square centisecond", "nmi/cs²", CablePerSquareDecisecond, 10.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square millisecond defined such that: cable per square centisecond = nmi/ms² ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillisecond =
      new("nautical mile per square millisecond", "nmi/ms²", CablePerSquareCentisecond, 10.0 / (1.0 / 10.0 * (1.0 / 10.0)), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square microsecond defined such that: cable per square millisecond = nmi/μs² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMicrosecond = new("nautical mile per square microsecond"
                                                                            , "nmi/μs²"
                                                                            , CablePerSquareMillisecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Imperial"
                                                                             );
   
   /// <summary>
   /// nautical mile per square nanosecond defined such that: cable per square microsecond = nmi/ns² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareNanosecond = new("nautical mile per square nanosecond"
                                                                           , "nmi/ns²"
                                                                           , CablePerSquareMicrosecond
                                                                           , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , system: "Imperial"
                                                                            );
   
   /// <summary>
   /// nautical mile per square picosecond defined such that: cable per square nanosecond = nmi/ps² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquarePicosecond = new("nautical mile per square picosecond"
                                                                           , "nmi/ps²"
                                                                           , CablePerSquareNanosecond
                                                                           , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , system: "Imperial"
                                                                            );
   
   /// <summary>
   /// nautical mile per square femtosecond defined such that: cable per square picosecond = nmi/fs² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareFemtosecond = new("nautical mile per square femtosecond"
                                                                            , "nmi/fs²"
                                                                            , CablePerSquarePicosecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Imperial"
                                                                             );
   
   /// <summary>
   /// nautical mile per square attosecond defined such that: cable per square femtosecond = nmi/as² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareAttosecond = new("nautical mile per square attosecond"
                                                                           , "nmi/as²"
                                                                           , CablePerSquareFemtosecond
                                                                           , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                           , system: "Imperial"
                                                                            );
   
   /// <summary>
   /// nautical mile per square zeptosecond defined such that: cable per square attosecond = nmi/zs² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareZeptosecond = new("nautical mile per square zeptosecond"
                                                                            , "nmi/zs²"
                                                                            , CablePerSquareAttosecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Imperial"
                                                                             );
   
   /// <summary>
   /// nautical mile per square yoctosecond defined such that: cable per square zeptosecond = nmi/ys² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareYoctosecond = new("nautical mile per square yoctosecond"
                                                                            , "nmi/ys²"
                                                                            , CablePerSquareZeptosecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Imperial"
                                                                             );
   
   /// <summary>
   /// nautical mile per square rontosecond defined such that: cable per square yoctosecond = nmi/rs² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareRontosecond = new("nautical mile per square rontosecond"
                                                                            , "nmi/rs²"
                                                                            , CablePerSquareYoctosecond
                                                                            , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                            , system: "Imperial"
                                                                             );
   
   /// <summary>
   /// nautical mile per square quectosecond defined such that: cable per square rontosecond = nmi/qs² ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuectosecond = new("nautical mile per square quectosecond"
                                                                             , "nmi/qs²"
                                                                             , CablePerSquareRontosecond
                                                                             , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                             , system: "Imperial"
                                                                              );
   
   /// <summary>
   /// inch per square sextillion years defined such that: SI centimeter per square quintillion years = in/Zyr² ×
   /// (2.54)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareSextillionYears = new("inch per square sextillion years"
                                                                        , "in/Zyr²"
                                                                        , SI.Accelerations.CentimeterPerSquareQuintillionYears
                                                                        , 2.54 / (1000.0 * 1000.0)
                                                                        , system: "Imperial"
                                                                         );
   
   /// <summary>
   /// inch per square septillion years defined such that: SI centimeter per square sextillion years = in/Yyr² ×
   /// (2.54)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareSeptillionYears = new("inch per square septillion years"
                                                                        , "in/Yyr²"
                                                                        , SI.Accelerations.CentimeterPerSquareSextillionYears
                                                                        , 2.54 / (1000.0 * 1000.0)
                                                                        , system: "Imperial"
                                                                         );
   
   /// <summary>
   /// inch per square octillion years defined such that: SI centimeter per square septillion years = in/Ryr² ×
   /// (2.54)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareOctillionYears = new("inch per square octillion years"
                                                                       , "in/Ryr²"
                                                                       , SI.Accelerations.CentimeterPerSquareSeptillionYears
                                                                       , 2.54 / (1000.0 * 1000.0)
                                                                       , system: "Imperial"
                                                                        );
   
   /// <summary>
   /// inch per square nonillion years defined such that: SI centimeter per square octillion years = in/Qyr² ×
   /// (2.54)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareNonillionYears = new("inch per square nonillion years"
                                                                       , "in/Qyr²"
                                                                       , SI.Accelerations.CentimeterPerSquareOctillionYears
                                                                       , 2.54 / (1000.0 * 1000.0)
                                                                       , system: "Imperial"
                                                                        );
   
   /// <summary>
   /// inch per square decillion years defined such that: SI centimeter per square nonillion years = in/decillion yr² ×
   /// (2.54)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareDecillionYears = new("inch per square decillion years"
                                                                       , "in/decillion yr²"
                                                                       , SI.Accelerations.CentimeterPerSquareNonillionYears
                                                                       , 2.54 / (1000.0 * 1000.0)
                                                                       , system: "Imperial"
                                                                        );
   
   /// <summary>
   /// inch per square tick defined such that: SI centimeter per square nanosecond = in/tick² × (2.54)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration InchPerSquareTick = new("inch per square tick"
                                                             , "in/tick²"
                                                             , SI.Accelerations.CentimeterPerSquareNanosecond
                                                             , 2.54 / (100.0 * 100.0)
                                                             , system: "Imperial"
                                                              );
   
   /// <summary>
   /// cable per square tick defined such that: fathom per square nanosecond = cable/tick² × (100.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareTick =
      new("cable per square tick", "cable/tick²", FathomPerSquareNanosecond, 100.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// foot per square minute defined such that: inch per square second = ft/min² × (12)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareMinute = new("foot per square minute", "ft/min²", InchPerSquareSecond, 12 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// hand per square septillion years defined such that: inch per square sextillion years = hh/Yyr² ×
   /// (4.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareSeptillionYears =
      new("hand per square septillion years", "hh/Yyr²", InchPerSquareSextillionYears, 4.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// hand per square week defined such that: inch per square day = hh/wk² × (4.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareWeek = new("hand per square week", "hh/wk²", InchPerSquareDay, 4.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// foot per square tick defined such that: inch per square nanosecond = ft/tick² × (12)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareTick =
      new("foot per square tick", "ft/tick²", InchPerSquareNanosecond, 12 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square tick defined such that: cable per square nanosecond = nmi/tick² × (10.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareTick =
      new("nautical mile per square tick", "nmi/tick²", CablePerSquareNanosecond, 10.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// foot per square hour defined such that: inch per square minute = ft/hr² × (12)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareHour = new("foot per square hour", "ft/hr²", InchPerSquareMinute, 12 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// twip per square minute defined such that: foot per square second = twip/min² × (1.0/17280.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareMinute =
      new("twip per square minute", "twip/min²", FootPerSquareSecond, 1.0 / 17280.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// foot per square day defined such that: inch per square hour = ft/dy² × (12)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareDay = new("foot per square day", "ft/dy²", InchPerSquareHour, 12 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// thou per square minute defined such that: foot per square second = th/min² × (1.0/12000.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareMinute =
      new("thou per square minute", "th/min²", FootPerSquareSecond, 1.0 / 12000.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// hand per square millennium defined such that: inch per square century = hh/kyr² × (4.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareMillennium =
      new("hand per square millennium", "hh/kyr²", InchPerSquareCentury, 4.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// twip per square tick defined such that: foot per square nanosecond = twip/tick² × (1.0/17280.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareTick =
      new("twip per square tick", "twip/tick²", FootPerSquareNanosecond, 1.0 / 17280.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square hour defined such that: foot per square minute = ftm/hr² × (6.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareHour = new("fathom per square hour", "ftm/hr²", FootPerSquareMinute, 6.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// twip per square hour defined such that: foot per square minute = twip/hr² × (1.0/17280.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareHour =
      new("twip per square hour", "twip/hr²", FootPerSquareMinute, 1.0 / 17280.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// foot per square week defined such that: inch per square day = ft/wk² × (12)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareWeek = new("foot per square week", "ft/wk²", InchPerSquareDay, 12 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square minute defined such that: foot per square second = barleycorn/min² ×
   /// (1.0/36.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMinute =
      new("barleycorn per square minute", "barleycorn/min²", FootPerSquareSecond, 1.0 / 36.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// hand per square quadrillion years defined such that: inch per square trillion years = hh/Pyr² ×
   /// (4.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareQuadrillionYears =
      new("hand per square quadrillion years", "hh/Pyr²", InchPerSquareTrillionYears, 4.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// thou per square tick defined such that: foot per square nanosecond = th/tick² × (1.0/12000.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareTick =
      new("thou per square tick", "th/tick²", FootPerSquareNanosecond, 1.0 / 12000.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// foot per square year defined such that: inch per square day = ft/yr² × (12)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration FootPerSquareYear = new("foot per square year", "ft/yr²", InchPerSquareDay, 12 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// hand per square minute defined such that: inch per square second = hh/min² × (4.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareMinute = new("hand per square minute", "hh/min²", InchPerSquareSecond, 4.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square decade defined such that: foot per square year = barleycorn/decade² ×
   /// (1.0/36.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDecade =
      new("barleycorn per square decade", "barleycorn/decade²", FootPerSquareYear, 1.0 / 36.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// yard per square week defined such that: foot per square day = yd/wk² × (3.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareWeek = new("yard per square week", "yd/wk²", FootPerSquareDay, 3.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// twip per square day defined such that: foot per square hour = twip/dy² × (1.0/17280.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareDay =
      new("twip per square day", "twip/dy²", FootPerSquareHour, 1.0 / 17280.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// thou per square hour defined such that: foot per square minute = th/hr² × (1.0/12000.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareHour =
      new("thou per square hour", "th/hr²", FootPerSquareMinute, 1.0 / 12000.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// foot per square decade defined such that: inch per square year = ft/decade² × (12)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareDecade = new("foot per square decade", "ft/decade²", InchPerSquareYear, 12 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// yard per square minute defined such that: foot per square second = yd/min² × (3.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareMinute = new("yard per square minute", "yd/min²", FootPerSquareSecond, 3.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// hand per square octillion years defined such that: inch per square septillion years = hh/Ryr² ×
   /// (4.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareOctillionYears =
      new("hand per square octillion years", "hh/Ryr²", InchPerSquareSeptillionYears, 4.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square tick defined such that: foot per square nanosecond = barleycorn/tick² ×
   /// (1.0/36.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareTick =
      new("barleycorn per square tick", "barleycorn/tick²", FootPerSquareNanosecond, 1.0 / 36.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// hand per square year defined such that: inch per square day = hh/yr² × (4.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration HandPerSquareYear = new("hand per square year", "hh/yr²", InchPerSquareDay, 4.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// foot per square century defined such that: inch per square decade = ft/century² × (12)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareCentury =
      new("foot per square century", "ft/century²", InchPerSquareDecade, 12 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// chain per square minute defined such that: yard per square second = ch/min² × (22.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareMinute =
      new("chain per square minute", "ch/min²", YardPerSquareSecond, 22.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square week defined such that: foot per square day = ftm/wk² × (6.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareWeek = new("fathom per square week", "ftm/wk²", FootPerSquareDay, 6.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// hand per square tick defined such that: inch per square nanosecond = hh/tick² × (4.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareTick =
      new("hand per square tick", "hh/tick²", InchPerSquareNanosecond, 4.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// twip per square week defined such that: foot per square day = twip/wk² × (1.0/17280.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareWeek =
      new("twip per square week", "twip/wk²", FootPerSquareDay, 1.0 / 17280.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square hour defined such that: foot per square minute = barleycorn/hr² × (1.0/36.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareHour =
      new("barleycorn per square hour", "barleycorn/hr²", FootPerSquareMinute, 1.0 / 36.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// foot per square millennium defined such that: inch per square century = ft/kyr² × (12)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareMillennium =
      new("foot per square millennium", "ft/kyr²", InchPerSquareCentury, 12 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square minute defined such that: chain per square second = fur/min² × (10.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMinute =
      new("furlong per square minute", "fur/min²", ChainPerSquareSecond, 10.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// hand per square million years defined such that: inch per square millennium = hh/Myr² × (4.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareMillionYears =
      new("hand per square million years", "hh/Myr²", InchPerSquareMillennium, 4.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// thou per square million years defined such that: foot per square millennium = th/Myr² ×
   /// (1.0/12000.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareMillionYears =
      new("thou per square million years", "th/Myr²", FootPerSquareMillennium, 1.0 / 12000.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// thou per square day defined such that: foot per square hour = th/dy² × (1.0/12000.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareDay = new("thou per square day", "th/dy²", FootPerSquareHour, 1.0 / 12000.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// foot per square million years defined such that: inch per square millennium = ft/Myr² × (12)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareMillionYears =
      new("foot per square million years", "ft/Myr²", InchPerSquareMillennium, 12 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square minute defined such that: furlong per square second = mi/min² × (8.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareMinute =
      new("mile per square minute", "mi/min²", FurlongPerSquareSecond, 8.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// yard per square tick defined such that: foot per square nanosecond = yd/tick² × (3.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareTick =
      new("yard per square tick", "yd/tick²", FootPerSquareNanosecond, 3.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square century defined such that: foot per square decade = barleycorn/century² ×
   /// (1.0/36.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareCentury =
      new("barleycorn per square century", "barleycorn/century²", FootPerSquareDecade, 1.0 / 36.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// hand per square quintillion years defined such that: inch per square quadrillion years = hh/Eyr² ×
   /// (4.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareQuintillionYears =
      new("hand per square quintillion years", "hh/Eyr²", InchPerSquareQuadrillionYears, 4.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// twip per square year defined such that: foot per square day = twip/yr² × (1.0/17280.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareYear =
      new("twip per square year", "twip/yr²", FootPerSquareDay, 1.0 / 17280.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// hand per square hour defined such that: inch per square minute = hh/hr² × (4.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareHour = new("hand per square hour", "hh/hr²", InchPerSquareMinute, 4.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// foot per square billion years defined such that: inch per square million years = ft/Gyr² × (12)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareBillionYears =
      new("foot per square billion years", "ft/Gyr²", InchPerSquareMillionYears, 12 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// league per square minute defined such that: mile per square second = lea/min² × (3.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMinute =
      new("league per square minute", "lea/min²", MilePerSquareSecond, 3.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square trillion years defined such that: foot per square billion years = ftm/Tyr² ×
   /// (6.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareTrillionYears =
      new("fathom per square trillion years", "ftm/Tyr²", FootPerSquareBillionYears, 6.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// yard per square trillion years defined such that: foot per square billion years = yd/Tyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareTrillionYears =
      new("yard per square trillion years", "yd/Tyr²", FootPerSquareBillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square decade defined such that: foot per square year = ftm/decade² × (6.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecade =
      new("fathom per square decade", "ftm/decade²", FootPerSquareYear, 6.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// chain per square tick defined such that: yard per square nanosecond = ch/tick² × (22.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareTick =
      new("chain per square tick", "ch/tick²", YardPerSquareNanosecond, 22.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// foot per square trillion years defined such that: inch per square billion years = ft/Tyr² ×
   /// (12)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareTrillionYears =
      new("foot per square trillion years", "ft/Tyr²", InchPerSquareBillionYears, 12 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square minute defined such that: foot per square second = ftm/min² × (6.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareMinute =
      new("fathom per square minute", "ftm/min²", FootPerSquareSecond, 6.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// yard per square millennium defined such that: foot per square century = yd/kyr² × (3.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareMillennium =
      new("yard per square millennium", "yd/kyr²", FootPerSquareCentury, 3.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square quadrillion years defined such that: foot per square trillion years = barleycorn/Pyr² ×
   /// (1.0/36.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareQuadrillionYears = new("barleycorn per square quadrillion years"
                                                                               , "barleycorn/Pyr²"
                                                                               , FootPerSquareTrillionYears
                                                                               , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                               , system: "Imperial"
                                                                                );
   
   /// <summary>
   /// hand per square nonillion years defined such that: inch per square octillion years = hh/Qyr² ×
   /// (4.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareNonillionYears =
      new("hand per square nonillion years", "hh/Qyr²", InchPerSquareOctillionYears, 4.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// hand per square decade defined such that: inch per square year = hh/decade² × (4.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareDecade = new("hand per square decade", "hh/decade²", InchPerSquareYear, 4.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// yard per square year defined such that: foot per square day = yd/yr² × (3.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration YardPerSquareYear = new("yard per square year", "yd/yr²", FootPerSquareDay, 3.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// thou per square billion years defined such that: foot per square million years = th/Gyr² ×
   /// (1.0/12000.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareBillionYears =
      new("thou per square billion years", "th/Gyr²", FootPerSquareMillionYears, 1.0 / 12000.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// thou per square week defined such that: foot per square day = th/wk² × (1.0/12000.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareWeek = new("thou per square week", "th/wk²", FootPerSquareDay, 1.0 / 12000.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square day defined such that: foot per square hour = barleycorn/dy² × (1.0/36.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDay =
      new("barleycorn per square day", "barleycorn/dy²", FootPerSquareHour, 1.0 / 36.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// twip per square decade defined such that: foot per square year = twip/decade² × (1.0/17280.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecade =
      new("twip per square decade", "twip/decade²", FootPerSquareYear, 1.0 / 17280.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// yard per square hour defined such that: foot per square minute = yd/hr² × (3.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareHour = new("yard per square hour", "yd/hr²", FootPerSquareMinute, 3.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// foot per square quadrillion years defined such that: inch per square trillion years = ft/Pyr² ×
   /// (12)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareQuadrillionYears =
      new("foot per square quadrillion years", "ft/Pyr²", InchPerSquareTrillionYears, 12 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square minute defined such that: fathom per square second = cable/min² × (100.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareMinute =
      new("cable per square minute", "cable/min²", FathomPerSquareSecond, 100.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square tick defined such that: chain per square nanosecond = fur/tick² × (10.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareTick =
      new("furlong per square tick", "fur/tick²", ChainPerSquareNanosecond, 10.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// foot per square quintillion years defined such that: inch per square quadrillion years = ft/Eyr² ×
   /// (12)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareQuintillionYears =
      new("foot per square quintillion years", "ft/Eyr²", InchPerSquareQuadrillionYears, 12 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square minute defined such that: cable per square second = nmi/min² × (10.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMinute =
      new("nautical mile per square minute", "nmi/min²", CablePerSquareSecond, 10.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// hand per square billion years defined such that: inch per square million years = hh/Gyr² ×
   /// (4.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareBillionYears =
      new("hand per square billion years", "hh/Gyr²", InchPerSquareMillionYears, 4.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square millennium defined such that: foot per square century = barleycorn/kyr² ×
   /// (1.0/36.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMillennium =
      new("barleycorn per square millennium", "barleycorn/kyr²", FootPerSquareCentury, 1.0 / 36.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square quintillion years defined such that: foot per square quadrillion years = ftm/Eyr² ×
   /// (6.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuintillionYears =
      new("fathom per square quintillion years", "ftm/Eyr²", FootPerSquareQuadrillionYears, 6.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square tick defined such that: furlong per square nanosecond = mi/tick² × (8.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareTick =
      new("mile per square tick", "mi/tick²", FurlongPerSquareNanosecond, 8.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// twip per square century defined such that: foot per square decade = twip/century² × (1.0/17280.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareCentury =
      new("twip per square century", "twip/century²", FootPerSquareDecade, 1.0 / 17280.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// chain per square hour defined such that: yard per square minute = ch/hr² × (22.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareHour = new("chain per square hour", "ch/hr²", YardPerSquareMinute, 22.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// foot per square sextillion years defined such that: inch per square quintillion years = ft/Zyr² ×
   /// (12)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareSextillionYears =
      new("foot per square sextillion years", "ft/Zyr²", InchPerSquareQuintillionYears, 12 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square millennium defined such that: foot per square century = ftm/kyr² × (6.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillennium =
      new("fathom per square millennium", "ftm/kyr²", FootPerSquareCentury, 6.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// thou per square trillion years defined such that: foot per square billion years = th/Tyr² ×
   /// (1.0/12000.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareTrillionYears =
      new("thou per square trillion years", "th/Tyr²", FootPerSquareBillionYears, 1.0 / 12000.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square day defined such that: foot per square hour = ftm/dy² × (6.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareDay = new("fathom per square day", "ftm/dy²", FootPerSquareHour, 6.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// hand per square sextillion years defined such that: inch per square quintillion years = hh/Zyr² ×
   /// (4.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareSextillionYears =
      new("hand per square sextillion years", "hh/Zyr²", InchPerSquareQuintillionYears, 4.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square quadrillion years defined such that: fathom per square trillion years = cable/Pyr² ×
   /// (100.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareQuadrillionYears =
      new("cable per square quadrillion years", "cable/Pyr²", FathomPerSquareTrillionYears, 100.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// thou per square year defined such that: foot per square day = th/yr² × (1.0/12000.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareYear =
      new("thou per square year", "th/yr²", FootPerSquareDay, 1.0 / 12000.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// hand per square day defined such that: inch per square hour = hh/dy² × (4.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareDay = new("hand per square day", "hh/dy²", InchPerSquareHour, 4.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// foot per square septillion years defined such that: inch per square sextillion years = ft/Yyr² ×
   /// (12)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareSeptillionYears =
      new("foot per square septillion years", "ft/Yyr²", InchPerSquareSextillionYears, 12 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square quintillion years defined such that: foot per square quadrillion years = barleycorn/Eyr² ×
   /// (1.0/36.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareQuintillionYears = new("barleycorn per square quintillion years"
                                                                               , "barleycorn/Eyr²"
                                                                               , FootPerSquareQuadrillionYears
                                                                               , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                               , system: "Imperial"
                                                                                );
   
   /// <summary>
   /// league per square tick defined such that: mile per square nanosecond = lea/tick² × (3.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTick =
      new("league per square tick", "lea/tick²", MilePerSquareNanosecond, 3.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// cable per square million years defined such that: fathom per square millennium = cable/Myr² ×
   /// (100.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareMillionYears =
      new("cable per square million years", "cable/Myr²", FathomPerSquareMillennium, 100.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square week defined such that: foot per square day = barleycorn/wk² × (1.0/36.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareWeek =
      new("barleycorn per square week", "barleycorn/wk²", FootPerSquareDay, 1.0 / 36.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// twip per square millennium defined such that: foot per square century = twip/kyr² × (1.0/17280.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillennium =
      new("twip per square millennium", "twip/kyr²", FootPerSquareCentury, 1.0 / 17280.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square hour defined such that: chain per square minute = fur/hr² × (10.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareHour =
      new("furlong per square hour", "fur/hr²", ChainPerSquareMinute, 10.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// foot per square octillion years defined such that: inch per square septillion years = ft/Ryr² ×
   /// (12)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareOctillionYears =
      new("foot per square octillion years", "ft/Ryr²", InchPerSquareSeptillionYears, 12 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// yard per square septillion years defined such that: foot per square sextillion years = yd/Yyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareSeptillionYears =
      new("yard per square septillion years", "yd/Yyr²", FootPerSquareSextillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// hand per square decillion years defined such that: inch per square nonillion years = hh/decillion yr² ×
   /// (4.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareDecillionYears =
      new("hand per square decillion years", "hh/decillion yr²", InchPerSquareNonillionYears, 4.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// hand per square century defined such that: inch per square decade = hh/century² × (4.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareCentury =
      new("hand per square century", "hh/century²", InchPerSquareDecade, 4.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// yard per square quadrillion years defined such that: foot per square trillion years = yd/Pyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareQuadrillionYears =
      new("yard per square quadrillion years", "yd/Pyr²", FootPerSquareTrillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// foot per square nonillion years defined such that: inch per square octillion years = ft/Qyr² ×
   /// (12)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareNonillionYears =
      new("foot per square nonillion years", "ft/Qyr²", InchPerSquareOctillionYears, 12 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square tick defined such that: foot per square nanosecond = ftm/tick² × (6.0)/((100.0)*(100.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareTick =
      new("fathom per square tick", "ftm/tick²", FootPerSquareNanosecond, 6.0 / (100.0 * 100.0), system: "Imperial");
   
   /// <summary>
   /// yard per square million years defined such that: foot per square millennium = yd/Myr² × (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareMillionYears =
      new("yard per square million years", "yd/Myr²", FootPerSquareMillennium, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// thou per square decillion years defined such that: foot per square nonillion years = th/decillion yr² ×
   /// (1.0/12000.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareDecillionYears = new("thou per square decillion years"
                                                                       , "th/decillion yr²"
                                                                       , FootPerSquareNonillionYears
                                                                       , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                       , system: "Imperial"
                                                                        );
   
   /// <summary>
   /// chain per square quintillion years defined such that: yard per square quadrillion years = ch/Eyr² ×
   /// (22.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuintillionYears =
      new("chain per square quintillion years", "ch/Eyr²", YardPerSquareQuadrillionYears, 22.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square septillion years defined such that: foot per square sextillion years = ftm/Yyr² ×
   /// (6.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareSeptillionYears =
      new("fathom per square septillion years", "ftm/Yyr²", FootPerSquareSextillionYears, 6.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// yard per square decade defined such that: foot per square year = yd/decade² × (3.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareDecade = new("yard per square decade", "yd/decade²", FootPerSquareYear, 3.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square million years defined such that: foot per square millennium = barleycorn/Myr² ×
   /// (1.0/36.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareMillionYears =
      new("barleycorn per square million years", "barleycorn/Myr²", FootPerSquareMillennium, 1.0 / 36.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// thou per square quadrillion years defined such that: foot per square trillion years = th/Pyr² ×
   /// (1.0/12000.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareQuadrillionYears =
      new("thou per square quadrillion years", "th/Pyr²", FootPerSquareTrillionYears, 1.0 / 12000.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square day defined such that: fathom per square hour = cable/dy² × (100.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareDay = new("cable per square day", "cable/dy²", FathomPerSquareHour, 100.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// twip per square decillion years defined such that: foot per square nonillion years = twip/decillion yr² ×
   /// (1.0/17280.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareDecillionYears = new("twip per square decillion years"
                                                                       , "twip/decillion yr²"
                                                                       , FootPerSquareNonillionYears
                                                                       , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                       , system: "Imperial"
                                                                        );
   
   /// <summary>
   /// fathom per square billion years defined such that: foot per square million years = ftm/Gyr² ×
   /// (6.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareBillionYears =
      new("fathom per square billion years", "ftm/Gyr²", FootPerSquareMillionYears, 6.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// thou per square decade defined such that: foot per square year = th/decade² × (1.0/12000.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareDecade =
      new("thou per square decade", "th/decade²", FootPerSquareYear, 1.0 / 12000.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// yard per square day defined such that: foot per square hour = yd/dy² × (3.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareDay = new("yard per square day", "yd/dy²", FootPerSquareHour, 3.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// twip per square million years defined such that: foot per square millennium = twip/Myr² ×
   /// (1.0/17280.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareMillionYears =
      new("twip per square million years", "twip/Myr²", FootPerSquareMillennium, 1.0 / 17280.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square hour defined such that: furlong per square minute = mi/hr² × (8.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareHour = new("mile per square hour", "mi/hr²", FurlongPerSquareMinute, 8.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// foot per square decillion years defined such that: inch per square nonillion years = ft/decillion yr² ×
   /// (12)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FootPerSquareDecillionYears =
      new("foot per square decillion years", "ft/decillion yr²", InchPerSquareNonillionYears, 12 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// hand per square trillion years defined such that: inch per square billion years = hh/Tyr² ×
   /// (4.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration HandPerSquareTrillionYears =
      new("hand per square trillion years", "hh/Tyr²", InchPerSquareBillionYears, 4.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square year defined such that: foot per square day = ftm/yr² × (6.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareYear =
      new("fathom per square year", "ftm/yr²", FootPerSquareDay, 6.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square sextillion years defined such that: foot per square quintillion years = barleycorn/Zyr² ×
   /// (1.0/36.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareSextillionYears = new("barleycorn per square sextillion years"
                                                                              , "barleycorn/Zyr²"
                                                                              , FootPerSquareQuintillionYears
                                                                              , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                              , system: "Imperial"
                                                                               );
   
   /// <summary>
   /// nautical mile per square billion years defined such that: cable per square million years = nmi/Gyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareBillionYears =
      new("nautical mile per square billion years", "nmi/Gyr²", CablePerSquareMillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square sextillion years defined such that: chain per square quintillion years = fur/Zyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSextillionYears =
      new("furlong per square sextillion years", "fur/Zyr²", ChainPerSquareQuintillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// chain per square octillion years defined such that: yard per square septillion years = ch/Ryr² ×
   /// (22.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareOctillionYears =
      new("chain per square octillion years", "ch/Ryr²", YardPerSquareSeptillionYears, 22.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square year defined such that: foot per square day = barleycorn/yr² ×
   /// (1.0/36.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareYear =
      new("barleycorn per square year", "barleycorn/yr²", FootPerSquareDay, 1.0 / 36.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// twip per square billion years defined such that: foot per square million years = twip/Gyr² ×
   /// (1.0/17280.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareBillionYears =
      new("twip per square billion years", "twip/Gyr²", FootPerSquareMillionYears, 1.0 / 17280.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// league per square hour defined such that: mile per square minute = lea/hr² × (3.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareHour = new("league per square hour", "lea/hr²", MilePerSquareMinute, 3.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// cable per square sextillion years defined such that: fathom per square quintillion years = cable/Zyr² ×
   /// (100.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareSextillionYears =
      new("cable per square sextillion years", "cable/Zyr²", FathomPerSquareQuintillionYears, 100.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// thou per square quintillion years defined such that: foot per square quadrillion years = th/Eyr² ×
   /// (1.0/12000.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareQuintillionYears = new("thou per square quintillion years"
                                                                         , "th/Eyr²"
                                                                         , FootPerSquareQuadrillionYears
                                                                         , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                         , system: "Imperial"
                                                                          );
   
   /// <summary>
   /// fathom per square nonillion years defined such that: foot per square octillion years = ftm/Qyr² ×
   /// (6.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareNonillionYears =
      new("fathom per square nonillion years", "ftm/Qyr²", FootPerSquareOctillionYears, 6.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// thou per square century defined such that: foot per square decade = th/century² × (1.0/12000.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareCentury =
      new("thou per square century", "th/century²", FootPerSquareDecade, 1.0 / 12000.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// chain per square day defined such that: yard per square hour = ch/dy² × (22.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareDay = new("chain per square day", "ch/dy²", YardPerSquareHour, 22.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square quadrillion years defined such that: foot per square trillion years = ftm/Pyr² ×
   /// (6.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareQuadrillionYears =
      new("fathom per square quadrillion years", "ftm/Pyr²", FootPerSquareTrillionYears, 6.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square trillion years defined such that: fathom per square billion years = cable/Tyr² ×
   /// (100.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareTrillionYears =
      new("cable per square trillion years", "cable/Tyr²", FathomPerSquareBillionYears, 100.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square quintillion years defined such that: cable per square quadrillion years = nmi/Eyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuintillionYears =
      new("nautical mile per square quintillion years", "nmi/Eyr²", CablePerSquareQuadrillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square year defined such that: chain per square day = fur/yr² × (10.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareYear =
      new("furlong per square year", "fur/yr²", ChainPerSquareDay, 10.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square billion years defined such that: foot per square million years = barleycorn/Gyr² ×
   /// (1.0/36.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareBillionYears = new("barleycorn per square billion years"
                                                                           , "barleycorn/Gyr²"
                                                                           , FootPerSquareMillionYears
                                                                           , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                           , system: "Imperial"
                                                                            );
   
   /// <summary>
   /// fathom per square century defined such that: foot per square decade = ftm/century² × (6.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareCentury =
      new("fathom per square century", "ftm/century²", FootPerSquareDecade, 6.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// twip per square trillion years defined such that: foot per square billion years = twip/Tyr² ×
   /// (1.0/17280.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareTrillionYears =
      new("twip per square trillion years", "twip/Tyr²", FootPerSquareBillionYears, 1.0 / 17280.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square millennium defined such that: fathom per square century = cable/kyr² × (100.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareMillennium =
      new("cable per square millennium", "cable/kyr²", FathomPerSquareCentury, 100.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// yard per square octillion years defined such that: foot per square septillion years = yd/Ryr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareOctillionYears =
      new("yard per square octillion years", "yd/Ryr²", FootPerSquareSeptillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// yard per square quintillion years defined such that: foot per square quadrillion years = yd/Eyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareQuintillionYears =
      new("yard per square quintillion years", "yd/Eyr²", FootPerSquareQuadrillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// yard per square billion years defined such that: foot per square million years = yd/Gyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareBillionYears =
      new("yard per square billion years", "yd/Gyr²", FootPerSquareMillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square year defined such that: fathom per square day = cable/yr² × (100.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration CablePerSquareYear =
      new("cable per square year", "cable/yr²", FathomPerSquareDay, 100.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square septillion years defined such that: foot per square sextillion years = barleycorn/Yyr² ×
   /// (1.0/36.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareSeptillionYears = new("barleycorn per square septillion years"
                                                                              , "barleycorn/Yyr²"
                                                                              , FootPerSquareSextillionYears
                                                                              , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                              , system: "Imperial"
                                                                               );
   
   /// <summary>
   /// yard per square century defined such that: foot per square decade = yd/century² × (3.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareCentury =
      new("yard per square century", "yd/century²", FootPerSquareDecade, 3.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// chain per square decade defined such that: yard per square year = ch/decade² × (22.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecade =
      new("chain per square decade", "ch/decade²", YardPerSquareYear, 22.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// thou per square sextillion years defined such that: foot per square quintillion years = th/Zyr² ×
   /// (1.0/12000.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareSextillionYears = new("thou per square sextillion years"
                                                                        , "th/Zyr²"
                                                                        , FootPerSquareQuintillionYears
                                                                        , 1.0 / 12000.0 / (1000.0 * 1000.0)
                                                                        , system: "Imperial"
                                                                         );
   
   /// <summary>
   /// thou per square millennium defined such that: foot per square century = th/kyr² × (1.0/12000.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareMillennium =
      new("thou per square millennium", "th/kyr²", FootPerSquareCentury, 1.0 / 12000.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square day defined such that: chain per square hour = fur/dy² × (10.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDay = new("furlong per square day", "fur/dy²", ChainPerSquareHour, 10.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// twip per square quadrillion years defined such that: foot per square trillion years = twip/Pyr² ×
   /// (1.0/17280.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuadrillionYears =
      new("twip per square quadrillion years", "twip/Pyr²", FootPerSquareTrillionYears, 1.0 / 17280.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square hour defined such that: fathom per square minute = cable/hr² × (100.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareHour =
      new("cable per square hour", "cable/hr²", FathomPerSquareMinute, 100.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// chain per square sextillion years defined such that: yard per square quintillion years = ch/Zyr² ×
   /// (22.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareSextillionYears =
      new("chain per square sextillion years", "ch/Zyr²", YardPerSquareQuintillionYears, 22.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square septillion years defined such that: furlong per square sextillion years = mi/Yyr² ×
   /// (8.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareSeptillionYears =
      new("mile per square septillion years", "mi/Yyr²", FurlongPerSquareSextillionYears, 8.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square million years defined such that: cable per square millennium = nmi/Myr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillionYears =
      new("nautical mile per square million years", "nmi/Myr²", CablePerSquareMillennium, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square sextillion years defined such that: foot per square quintillion years = ftm/Zyr² ×
   /// (6.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareSextillionYears =
      new("fathom per square sextillion years", "ftm/Zyr²", FootPerSquareQuintillionYears, 6.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square million years defined such that: foot per square millennium = ftm/Myr² ×
   /// (6.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareMillionYears =
      new("fathom per square million years", "ftm/Myr²", FootPerSquareMillennium, 6.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square nonillion years defined such that: chain per square octillion years = fur/Qyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareNonillionYears =
      new("furlong per square nonillion years", "fur/Qyr²", ChainPerSquareOctillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square trillion years defined such that: foot per square billion years = barleycorn/Tyr² ×
   /// (1.0/36.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareTrillionYears = new("barleycorn per square trillion years"
                                                                            , "barleycorn/Tyr²"
                                                                            , FootPerSquareBillionYears
                                                                            , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                            , system: "Imperial"
                                                                             );
   
   /// <summary>
   /// cable per square octillion years defined such that: fathom per square septillion years = cable/Ryr² ×
   /// (100.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareOctillionYears =
      new("cable per square octillion years", "cable/Ryr²", FathomPerSquareSeptillionYears, 100.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// twip per square quintillion years defined such that: foot per square quadrillion years = twip/Eyr² ×
   /// (1.0/17280.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareQuintillionYears = new("twip per square quintillion years"
                                                                         , "twip/Eyr²"
                                                                         , FootPerSquareQuadrillionYears
                                                                         , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                         , system: "Imperial"
                                                                          );
   
   /// <summary>
   /// nautical mile per square hour defined such that: cable per square minute = nmi/hr² × (10.0)/((60.0)*(60.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareHour =
      new("nautical mile per square hour", "nmi/hr²", CablePerSquareMinute, 10.0 / (60.0 * 60.0), system: "Imperial");
   
   /// <summary>
   /// chain per square million years defined such that: yard per square millennium = ch/Myr² × (22.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillionYears =
      new("chain per square million years", "ch/Myr²", YardPerSquareMillennium, 22.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square year defined such that: furlong per square day = mi/yr² × (8.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration MilePerSquareYear =
      new("mile per square year", "mi/yr²", FurlongPerSquareDay, 8.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// thou per square septillion years defined such that: foot per square sextillion years = th/Yyr² ×
   /// (1.0/12000.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareSeptillionYears =
      new("thou per square septillion years", "th/Yyr²", FootPerSquareSextillionYears, 1.0 / 12000.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// chain per square nonillion years defined such that: yard per square octillion years = ch/Qyr² ×
   /// (22.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareNonillionYears =
      new("chain per square nonillion years", "ch/Qyr²", YardPerSquareOctillionYears, 22.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square quintillion years defined such that: fathom per square quadrillion years = cable/Eyr² ×
   /// (100.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareQuintillionYears =
      new("cable per square quintillion years", "cable/Eyr²", FathomPerSquareQuadrillionYears, 100.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square quadrillion years defined such that: cable per square trillion years = nmi/Pyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareQuadrillionYears =
      new("nautical mile per square quadrillion years", "nmi/Pyr²", CablePerSquareTrillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square day defined such that: furlong per square hour = mi/dy² × (8.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareDay = new("mile per square day", "mi/dy²", FurlongPerSquareHour, 8.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square octillion years defined such that: foot per square septillion years = barleycorn/Ryr² ×
   /// (1.0/36.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareOctillionYears = new("barleycorn per square octillion years"
                                                                             , "barleycorn/Ryr²"
                                                                             , FootPerSquareSeptillionYears
                                                                             , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                             , system: "Imperial"
                                                                              );
   
   /// <summary>
   /// cable per square billion years defined such that: fathom per square million years = cable/Gyr² ×
   /// (100.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareBillionYears =
      new("cable per square billion years", "cable/Gyr²", FathomPerSquareMillionYears, 100.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square septillion years defined such that: chain per square sextillion years = fur/Yyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSeptillionYears =
      new("furlong per square septillion years", "fur/Yyr²", ChainPerSquareSextillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// chain per square week defined such that: yard per square day = ch/wk² × (22.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareWeek = new("chain per square week", "ch/wk²", YardPerSquareDay, 22.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// twip per square sextillion years defined such that: foot per square quintillion years = twip/Zyr² ×
   /// (1.0/17280.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareSextillionYears = new("twip per square sextillion years"
                                                                        , "twip/Zyr²"
                                                                        , FootPerSquareQuintillionYears
                                                                        , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                        , system: "Imperial"
                                                                         );
   
   /// <summary>
   /// nautical mile per square year defined such that: cable per square day = nmi/yr² × (10.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareYear =
      new("nautical mile per square year", "nmi/yr²", CablePerSquareDay, 10.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// yard per square nonillion years defined such that: foot per square octillion years = yd/Qyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareNonillionYears =
      new("yard per square nonillion years", "yd/Qyr²", FootPerSquareOctillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// fathom per square octillion years defined such that: foot per square septillion years = ftm/Ryr² ×
   /// (6.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareOctillionYears =
      new("fathom per square octillion years", "ftm/Ryr²", FootPerSquareSeptillionYears, 6.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// chain per square quadrillion years defined such that: yard per square trillion years = ch/Pyr² ×
   /// (22.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuadrillionYears =
      new("chain per square quadrillion years", "ch/Pyr²", YardPerSquareTrillionYears, 22.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square century defined such that: fathom per square decade = cable/century² × (100.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareCentury =
      new("cable per square century", "cable/century²", FathomPerSquareDecade, 100.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// yard per square sextillion years defined such that: foot per square quintillion years = yd/Zyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareSextillionYears =
      new("yard per square sextillion years", "yd/Zyr²", FootPerSquareQuintillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square septillion years defined such that: cable per square sextillion years = nmi/Yyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSeptillionYears =
      new("nautical mile per square septillion years", "nmi/Yyr²", CablePerSquareSextillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square week defined such that: fathom per square day = cable/wk² × (100.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareWeek = new("cable per square week", "cable/wk²", FathomPerSquareDay, 100.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// thou per square octillion years defined such that: foot per square septillion years = th/Ryr² ×
   /// (1.0/12000.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareOctillionYears =
      new("thou per square octillion years", "th/Ryr²", FootPerSquareSeptillionYears, 1.0 / 12000.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// league per square day defined such that: mile per square hour = lea/dy² × (3.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDay = new("league per square day", "lea/dy²", MilePerSquareHour, 3.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// twip per square septillion years defined such that: foot per square sextillion years = twip/Yyr² ×
   /// (1.0/17280.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareSeptillionYears = new("twip per square septillion years"
                                                                        , "twip/Yyr²"
                                                                        , FootPerSquareSextillionYears
                                                                        , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                        , system: "Imperial"
                                                                         );
   
   /// <summary>
   /// furlong per square quintillion years defined such that: chain per square quadrillion years = fur/Eyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuintillionYears =
      new("furlong per square quintillion years", "fur/Eyr²", ChainPerSquareQuadrillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square millennium defined such that: cable per square century = nmi/kyr² × (10.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareMillennium =
      new("nautical mile per square millennium", "nmi/kyr²", CablePerSquareCentury, 10.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// chain per square century defined such that: yard per square decade = ch/century² × (22.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareCentury =
      new("chain per square century", "ch/century²", YardPerSquareDecade, 22.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// league per square octillion years defined such that: mile per square septillion years = lea/Ryr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareOctillionYears =
      new("league per square octillion years", "lea/Ryr²", MilePerSquareSeptillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square nonillion years defined such that: foot per square octillion years = barleycorn/Qyr² ×
   /// (1.0/36.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareNonillionYears = new("barleycorn per square nonillion years"
                                                                             , "barleycorn/Qyr²"
                                                                             , FootPerSquareOctillionYears
                                                                             , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                             , system: "Imperial"
                                                                              );
   
   /// <summary>
   /// chain per square septillion years defined such that: yard per square sextillion years = ch/Yyr² ×
   /// (22.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareSeptillionYears =
      new("chain per square septillion years", "ch/Yyr²", YardPerSquareSextillionYears, 22.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square decillion years defined such that: fathom per square nonillion years = cable/decillion yr² ×
   /// (100.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareDecillionYears = new("cable per square decillion years"
                                                                        , "cable/decillion yr²"
                                                                        , FathomPerSquareNonillionYears
                                                                        , 100.0 / (1000.0 * 1000.0)
                                                                        , system: "Imperial"
                                                                         );
   
   /// <summary>
   /// league per square year defined such that: mile per square day = lea/yr² × (3.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYear =
      new("league per square year", "lea/yr²", MilePerSquareDay, 3.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// fathom per square decillion years defined such that: foot per square nonillion years = ftm/decillion yr² ×
   /// (6.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FathomPerSquareDecillionYears =
      new("fathom per square decillion years", "ftm/decillion yr²", FootPerSquareNonillionYears, 6.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square week defined such that: chain per square day = fur/wk² × (10.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareWeek = new("furlong per square week", "fur/wk²", ChainPerSquareDay, 10.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// twip per square octillion years defined such that: foot per square septillion years = twip/Ryr² ×
   /// (1.0/17280.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareOctillionYears = new("twip per square octillion years"
                                                                       , "twip/Ryr²"
                                                                       , FootPerSquareSeptillionYears
                                                                       , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                       , system: "Imperial"
                                                                        );
   
   /// <summary>
   /// nautical mile per square trillion years defined such that: cable per square billion years = nmi/Tyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareTrillionYears =
      new("nautical mile per square trillion years", "nmi/Tyr²", CablePerSquareBillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// cable per square septillion years defined such that: fathom per square sextillion years = cable/Yyr² ×
   /// (100.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareSeptillionYears =
      new("cable per square septillion years", "cable/Yyr²", FathomPerSquareSextillionYears, 100.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// thou per square nonillion years defined such that: foot per square octillion years = th/Qyr² ×
   /// (1.0/12000.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ThouPerSquareNonillionYears =
      new("thou per square nonillion years", "th/Qyr²", FootPerSquareOctillionYears, 1.0 / 12000.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square decillion years defined such that: furlong per square nonillion years = mi/decillion yr² ×
   /// (8.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareDecillionYears = new("mile per square decillion years"
                                                                       , "mi/decillion yr²"
                                                                       , FurlongPerSquareNonillionYears
                                                                       , 8.0 / (1000.0 * 1000.0)
                                                                       , system: "Imperial"
                                                                        );
   
   /// <summary>
   /// chain per square billion years defined such that: yard per square million years = ch/Gyr² ×
   /// (22.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareBillionYears =
      new("chain per square billion years", "ch/Gyr²", YardPerSquareMillionYears, 22.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square octillion years defined such that: furlong per square septillion years = mi/Ryr² ×
   /// (8.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareOctillionYears =
      new("mile per square octillion years", "mi/Ryr²", FurlongPerSquareSeptillionYears, 8.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square decillion years defined such that: chain per square nonillion years = fur/decillion yr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecillionYears = new("furlong per square decillion years"
                                                                          , "fur/decillion yr²"
                                                                          , ChainPerSquareNonillionYears
                                                                          , 10.0 / (1000.0 * 1000.0)
                                                                          , system: "Imperial"
                                                                           );
   
   /// <summary>
   /// nautical mile per square week defined such that: cable per square day = nmi/wk² × (10.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareWeek =
      new("nautical mile per square week", "nmi/wk²", CablePerSquareDay, 10.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// mile per square sextillion years defined such that: furlong per square quintillion years = mi/Zyr² ×
   /// (8.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareSextillionYears =
      new("mile per square sextillion years", "mi/Zyr²", FurlongPerSquareQuintillionYears, 8.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// chain per square decillion years defined such that: yard per square nonillion years = ch/decillion yr² ×
   /// (22.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecillionYears =
      new("chain per square decillion years", "ch/decillion yr²", YardPerSquareNonillionYears, 22.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// twip per square nonillion years defined such that: foot per square octillion years = twip/Qyr² ×
   /// (1.0/17280.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration TwipPerSquareNonillionYears = new("twip per square nonillion years"
                                                                       , "twip/Qyr²"
                                                                       , FootPerSquareOctillionYears
                                                                       , 1.0 / 17280.0 / (1000.0 * 1000.0)
                                                                       , system: "Imperial"
                                                                        );
   
   /// <summary>
   /// yard per square decillion years defined such that: foot per square nonillion years = yd/decillion yr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration YardPerSquareDecillionYears =
      new("yard per square decillion years", "yd/decillion yr²", FootPerSquareNonillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square sextillion years defined such that: cable per square quintillion years = nmi/Zyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareSextillionYears =
      new("nautical mile per square sextillion years", "nmi/Zyr²", CablePerSquareQuintillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// chain per square year defined such that: yard per square day = ch/yr² × (22.0)/((365.2525)*(365.2525)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareYear =
      new("chain per square year", "ch/yr²", YardPerSquareDay, 22.0 / (365.2525 * 365.2525), system: "Imperial");
   
   /// <summary>
   /// cable per square decade defined such that: fathom per square year = cable/decade² × (100.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareDecade =
      new("cable per square decade", "cable/decade²", FathomPerSquareYear, 100.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// barleycorn per square decillion years defined such that: foot per square nonillion years = barleycorn/decillion yr²
   /// × (1.0/36.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration BarleycornPerSquareDecillionYears = new("barleycorn per square decillion years"
                                                                             , "barleycorn/decillion yr²"
                                                                             , FootPerSquareNonillionYears
                                                                             , 1.0 / 36.0 / (1000.0 * 1000.0)
                                                                             , system: "Imperial"
                                                                              );
   
   /// <summary>
   /// mile per square decade defined such that: furlong per square year = mi/decade² × (8.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareDecade =
      new("mile per square decade", "mi/decade²", FurlongPerSquareYear, 8.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square century defined such that: cable per square decade = nmi/century² × (10.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareCentury =
      new("nautical mile per square century", "nmi/century²", CablePerSquareDecade, 10.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square octillion years defined such that: chain per square septillion years = fur/Ryr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareOctillionYears =
      new("furlong per square octillion years", "fur/Ryr²", ChainPerSquareSeptillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square week defined such that: furlong per square day = mi/wk² × (8.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareWeek = new("mile per square week", "mi/wk²", FurlongPerSquareDay, 8.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square nonillion years defined such that: cable per square octillion years = nmi/Qyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareNonillionYears =
      new("nautical mile per square nonillion years", "nmi/Qyr²", CablePerSquareOctillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// chain per square millennium defined such that: yard per square century = ch/kyr² × (22.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillennium =
      new("chain per square millennium", "ch/kyr²", YardPerSquareCentury, 22.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square century defined such that: chain per square decade = fur/century² × (10.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareCentury =
      new("furlong per square century", "fur/century²", ChainPerSquareDecade, 10.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// cable per square nonillion years defined such that: fathom per square octillion years = cable/Qyr² ×
   /// (100.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration CablePerSquareNonillionYears =
      new("cable per square nonillion years", "cable/Qyr²", FathomPerSquareOctillionYears, 100.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square day defined such that: cable per square hour = nmi/dy² × (10.0)/((24.0)*(24.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDay =
      new("nautical mile per square day", "nmi/dy²", CablePerSquareHour, 10.0 / (24.0 * 24.0), system: "Imperial");
   
   /// <summary>
   /// league per square septillion years defined such that: mile per square sextillion years = lea/Yyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSeptillionYears =
      new("league per square septillion years", "lea/Yyr²", MilePerSquareSextillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// league per square week defined such that: mile per square day = lea/wk² × (3.0)/((7.0)*(7.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareWeek = new("league per square week", "lea/wk²", MilePerSquareDay, 3.0 / (7.0 * 7.0), system: "Imperial");
   
   /// <summary>
   /// chain per square trillion years defined such that: yard per square billion years = ch/Tyr² ×
   /// (22.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration ChainPerSquareTrillionYears =
      new("chain per square trillion years", "ch/Tyr²", YardPerSquareBillionYears, 22.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square quadrillion years defined such that: chain per square trillion years = fur/Pyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuadrillionYears =
      new("furlong per square quadrillion years", "fur/Pyr²", ChainPerSquareTrillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// league per square nonillion years defined such that: mile per square octillion years = lea/Qyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNonillionYears =
      new("league per square nonillion years", "lea/Qyr²", MilePerSquareOctillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square decade defined such that: cable per square year = nmi/decade² × (10.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecade =
      new("nautical mile per square decade", "nmi/decade²", CablePerSquareYear, 10.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// league per square decade defined such that: mile per square year = lea/decade² × (3.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecade =
      new("league per square decade", "lea/decade²", MilePerSquareYear, 3.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square octillion years defined such that: cable per square septillion years = nmi/Ryr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareOctillionYears =
      new("nautical mile per square octillion years", "nmi/Ryr²", CablePerSquareSeptillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square nonillion years defined such that: furlong per square octillion years = mi/Qyr² ×
   /// (8.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareNonillionYears =
      new("mile per square nonillion years", "mi/Qyr²", FurlongPerSquareOctillionYears, 8.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square billion years defined such that: chain per square million years = fur/Gyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareBillionYears =
      new("furlong per square billion years", "fur/Gyr²", ChainPerSquareMillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square quintillion years defined such that: furlong per square quadrillion years = mi/Eyr² ×
   /// (8.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareQuintillionYears =
      new("mile per square quintillion years", "mi/Eyr²", FurlongPerSquareQuadrillionYears, 8.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square trillion years defined such that: furlong per square billion years = mi/Tyr² ×
   /// (8.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareTrillionYears =
      new("mile per square trillion years", "mi/Tyr²", FurlongPerSquareBillionYears, 8.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square millennium defined such that: chain per square century = fur/kyr² × (10.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillennium =
      new("furlong per square millennium", "fur/kyr²", ChainPerSquareCentury, 10.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// league per square quadrillion years defined such that: mile per square trillion years = lea/Pyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuadrillionYears =
      new("league per square quadrillion years", "lea/Pyr²", MilePerSquareTrillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// league per square sextillion years defined such that: mile per square quintillion years = lea/Zyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSextillionYears =
      new("league per square sextillion years", "lea/Zyr²", MilePerSquareQuintillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square decade defined such that: chain per square year = fur/decade² × (10.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecade =
      new("furlong per square decade", "fur/decade²", ChainPerSquareYear, 10.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// nautical mile per square decillion years defined such that: cable per square nonillion years = nmi/decillion yr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration NauticalMilePerSquareDecillionYears = new("nautical mile per square decillion years"
                                                                               , "nmi/decillion yr²"
                                                                               , CablePerSquareNonillionYears
                                                                               , 10.0 / (1000.0 * 1000.0)
                                                                               , system: "Imperial"
                                                                                );
   
   /// <summary>
   /// league per square decillion years defined such that: mile per square nonillion years = lea/decillion yr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecillionYears =
      new("league per square decillion years", "lea/decillion yr²", MilePerSquareNonillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square trillion years defined such that: chain per square billion years = fur/Tyr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareTrillionYears =
      new("furlong per square trillion years", "fur/Tyr²", ChainPerSquareBillionYears, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// league per square century defined such that: mile per square decade = lea/century² × (3.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentury =
      new("league per square century", "lea/century²", MilePerSquareDecade, 3.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// mile per square quadrillion years defined such that: furlong per square trillion years = mi/Pyr² ×
   /// (8.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareQuadrillionYears =
      new("mile per square quadrillion years", "mi/Pyr²", FurlongPerSquareTrillionYears, 8.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// furlong per square million years defined such that: chain per square millennium = fur/Myr² ×
   /// (10.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillionYears =
      new("furlong per square million years", "fur/Myr²", ChainPerSquareMillennium, 10.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square millennium defined such that: furlong per square century = mi/kyr² × (8.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareMillennium =
      new("mile per square millennium", "mi/kyr²", FurlongPerSquareCentury, 8.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// league per square quintillion years defined such that: mile per square quadrillion years = lea/Eyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuintillionYears =
      new("league per square quintillion years", "lea/Eyr²", MilePerSquareQuadrillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square million years defined such that: furlong per square millennium = mi/Myr² ×
   /// (8.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareMillionYears =
      new("mile per square million years", "mi/Myr²", FurlongPerSquareMillennium, 8.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square century defined such that: furlong per square decade = mi/century² × (8.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareCentury =
      new("mile per square century", "mi/century²", FurlongPerSquareDecade, 8.0 / (10.0 * 10.0), system: "Imperial");
   
   /// <summary>
   /// league per square billion years defined such that: mile per square million years = lea/Gyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareBillionYears =
      new("league per square billion years", "lea/Gyr²", MilePerSquareMillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// mile per square billion years defined such that: furlong per square million years = mi/Gyr² ×
   /// (8.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration MilePerSquareBillionYears =
      new("mile per square billion years", "mi/Gyr²", FurlongPerSquareMillionYears, 8.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// league per square million years defined such that: mile per square millennium = lea/Myr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillionYears =
      new("league per square million years", "lea/Myr²", MilePerSquareMillennium, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// league per square trillion years defined such that: mile per square billion years = lea/Tyr² ×
   /// (3.0)/((1000.0)*(1000.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTrillionYears =
      new("league per square trillion years", "lea/Tyr²", MilePerSquareBillionYears, 3.0 / (1000.0 * 1000.0), system: "Imperial");
   
   /// <summary>
   /// league per square millennium defined such that: mile per square century = lea/kyr² × (3.0)/((10.0)*(10.0)).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillennium =
      new("league per square millennium", "lea/kyr²", MilePerSquareCentury, 3.0 / (10.0 * 10.0), system: "Imperial");
}