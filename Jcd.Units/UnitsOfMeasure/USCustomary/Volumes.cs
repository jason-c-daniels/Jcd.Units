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
   /// A(n) cubic inch. Defined as: (2.54)*(2.54)*(2.54) × SI cubic centimeter.
   /// </summary>
   public static readonly Volume CubicInch = new (
                                                  "cubic inch"
                                                , "in³"
                                                , SI.Volumes.CubicCentimeter
                                                , 2.54 * 2.54 * 2.54
                                                , 0
                                                 );

   /// <summary>
   /// A(n) cubic mil. Defined as: (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0) × cubic inch.
   /// </summary>
   public static readonly Volume CubicMil = new (
                                                 "cubic mil"
                                               , "mil³"
                                               , CubicInch
                                               , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                               , 0
                                                );

   /// <summary>
   /// A(n) cubic point. Defined as: (1.0/72.0)*(1.0/72.0)*(1.0/72.0) × cubic inch.
   /// </summary>
   public static readonly Volume CubicPoint = new (
                                                   "cubic point"
                                                 , "p³"
                                                 , CubicInch
                                                 , 1.0 / 72.0 * (1.0 / 72.0) * (1.0 / 72.0)
                                                 , 0
                                                  );

   /// <summary>
   /// A(n) cubic twip. Defined as: (1.0/20.0)*(1.0/20.0)*(1.0/20.0) × cubic point.
   /// </summary>
   public static readonly Volume CubicTwip = new (
                                                  "cubic twip"
                                                , "twip³"
                                                , CubicPoint
                                                , 1.0 / 20.0 * (1.0 / 20.0) * (1.0 / 20.0)
                                                , 0
                                                 );

   /// <summary>
   /// A(n) cubic pica. Defined as: (12.0)*(12.0)*(12.0) × cubic point.
   /// </summary>
   public static readonly Volume CubicPica = new ("cubic pica", "P³", CubicPoint, 12.0 * 12.0 * 12.0, 0);

   /// <summary>
   /// A(n) cubic foot. Defined as: (12.0)*(12.0)*(12.0) × cubic inch.
   /// </summary>
   public static readonly Volume CubicFoot = new ("cubic foot", "ft³", CubicInch, 12.0 * 12.0 * 12.0, 0);

   /// <summary>
   /// A(n) cubic yard. Defined as: (3.0)*(3.0)*(3.0) × cubic foot.
   /// </summary>
   public static readonly Volume CubicYard = new ("cubic yard", "yd³", CubicFoot, 3.0 * 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) cubic mile. Defined as: (1760.0)*(1760.0)*(1760.0) × cubic yard.
   /// </summary>
   public static readonly Volume CubicMile = new ("cubic mile", "mi³", CubicYard, 1760.0 * 1760.0 * 1760.0, 0);

   /// <summary>
   /// A(n) cubic league. Defined as: (3.0)*(3.0)*(3.0) × cubic mile.
   /// </summary>
   public static readonly Volume CubicLeague = new ("cubic league", "le³", CubicMile, 3.0 * 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) cubic fathom. Defined as: (2.0)*(2.0)*(2.0) × cubic yard.
   /// </summary>
   public static readonly Volume CubicFathom = new ("cubic fathom", "ftm³", CubicYard, 2.0 * 2.0 * 2.0, 0);

   /// <summary>
   /// A(n) cubic cable. Defined as: (120.0)*(120.0)*(120.0) × cubic fathom.
   /// </summary>
   public static readonly Volume CubicCable = new ("cubic cable", "cb³", CubicFathom, 120.0 * 120.0 * 120.0, 0);

   /// <summary>
   /// A(n) cubic nautical mile. Defined as: (1852.0)*(1852.0)*(1852.0) × SI cubic meter.
   /// </summary>
   public static readonly Volume CubicNauticalMile = new (
                                                          "cubic nautical mile"
                                                        , "nmi³"
                                                        , SI.Volumes.CubicMeter
                                                        , 1852.0 * 1852.0 * 1852.0
                                                        , 0
                                                         );
}
