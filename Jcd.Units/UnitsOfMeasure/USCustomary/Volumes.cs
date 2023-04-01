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
/// United States Customary Units for measuring Volume.
/// </summary>
public class Volumes : UnitOfMeasureEnumeration<Volumes, Volume>
{
   /// <summary>
   /// cubic inch defined such that: SI cubic centimeter = in³ × (2.54)*(2.54)*(2.54).
   /// </summary>
   public static readonly Volume CubicInch = new (
                                                  "cubic inch"
                                                , "in³"
                                                , SI.Volumes.CubicCentimeter
                                                , 2.54 * 2.54 * 2.54
                                                , system: "US Customary"
                                                 );

   /// <summary>
   /// cubic mil defined such that: cubic inch = mil³ × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Volume CubicMil = new (
                                                 "cubic mil"
                                               , "mil³"
                                               , CubicInch
                                               , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                               , system: "US Customary"
                                                );

   /// <summary>
   /// cubic point defined such that: cubic inch = p³ × (1.0/72.0)*(1.0/72.0)*(1.0/72.0).
   /// </summary>
   public static readonly Volume CubicPoint = new (
                                                   "cubic point"
                                                 , "p³"
                                                 , CubicInch
                                                 , 1.0 / 72.0 * (1.0 / 72.0) * (1.0 / 72.0)
                                                 , system: "US Customary"
                                                  );

   /// <summary>
   /// cubic twip defined such that: cubic point = twip³ × (1.0/20.0)*(1.0/20.0)*(1.0/20.0).
   /// </summary>
   public static readonly Volume CubicTwip = new (
                                                  "cubic twip"
                                                , "twip³"
                                                , CubicPoint
                                                , 1.0 / 20.0 * (1.0 / 20.0) * (1.0 / 20.0)
                                                , system: "US Customary"
                                                 );

   /// <summary>
   /// cubic pica defined such that: cubic point = P³ × (12.0)*(12.0)*(12.0).
   /// </summary>
   public static readonly Volume CubicPica = new (
                                                  "cubic pica"
                                                , "P³"
                                                , CubicPoint
                                                , 12.0 * 12.0 * 12.0
                                                , system: "US Customary"
                                                 );

   /// <summary>
   /// cubic foot defined such that: cubic inch = ft³ × (12.0)*(12.0)*(12.0).
   /// </summary>
   public static readonly Volume CubicFoot = new (
                                                  "cubic foot"
                                                , "ft³"
                                                , CubicInch
                                                , 12.0 * 12.0 * 12.0
                                                , system: "US Customary"
                                                 );

   /// <summary>
   /// cubic yard defined such that: cubic foot = yd³ × (3.0)*(3.0)*(3.0).
   /// </summary>
   public static readonly Volume CubicYard = new (
                                                  "cubic yard"
                                                , "yd³"
                                                , CubicFoot
                                                , 3.0 * 3.0 * 3.0
                                                , system: "US Customary"
                                                 );

   /// <summary>
   /// cubic mile defined such that: cubic yard = mi³ × (1760.0)*(1760.0)*(1760.0).
   /// </summary>
   public static readonly Volume CubicMile = new (
                                                  "cubic mile"
                                                , "mi³"
                                                , CubicYard
                                                , 1760.0 * 1760.0 * 1760.0
                                                , system: "US Customary"
                                                 );

   /// <summary>
   /// cubic league defined such that: cubic mile = le³ × (3.0)*(3.0)*(3.0).
   /// </summary>
   public static readonly Volume CubicLeague = new (
                                                    "cubic league"
                                                  , "le³"
                                                  , CubicMile
                                                  , 3.0 * 3.0 * 3.0
                                                  , system: "US Customary"
                                                   );

   /// <summary>
   /// cubic fathom defined such that: cubic yard = ftm³ × (2.0)*(2.0)*(2.0).
   /// </summary>
   public static readonly Volume CubicFathom = new (
                                                    "cubic fathom"
                                                  , "ftm³"
                                                  , CubicYard
                                                  , 2.0 * 2.0 * 2.0
                                                  , system: "US Customary"
                                                   );

   /// <summary>
   /// cubic cable defined such that: cubic fathom = cb³ × (120.0)*(120.0)*(120.0).
   /// </summary>
   public static readonly Volume CubicCable = new (
                                                   "cubic cable"
                                                 , "cb³"
                                                 , CubicFathom
                                                 , 120.0 * 120.0 * 120.0
                                                 , system: "US Customary"
                                                  );

   /// <summary>
   /// cubic nautical mile defined such that: SI cubic meter = nmi³ × (1852.0)*(1852.0)*(1852.0).
   /// </summary>
   public static readonly Volume CubicNauticalMile = new (
                                                          "cubic nautical mile"
                                                        , "nmi³"
                                                        , SI.Volumes.CubicMeter
                                                        , 1852.0 * 1852.0 * 1852.0
                                                        , system: "US Customary"
                                                         );
}
