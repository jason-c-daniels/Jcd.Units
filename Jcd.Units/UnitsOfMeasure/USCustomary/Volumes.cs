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
public class Volumes : Enumeration<Volumes, Volume>
{
   /// <summary>
   /// A(n) cubic inch. Defined in terms of a(n) SI cubic centimeter.
   /// </summary>
   public static readonly Volume CubicInch = new (
                                                  "cubic inch"
                                                , "in^3"
                                                , SI.Volumes.CubicCentimeter
                                                , 2.54 * 2.54 * 2.54
                                                , 0
                                                 );

   /// <summary>
   /// A(n) cubic mil. Defined in terms of a(n) cubic inch.
   /// </summary>
   public static readonly Volume CubicMil = new (
                                                 "cubic mil"
                                               , "mil^3"
                                               , CubicInch
                                               , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                               , 0
                                                );

   /// <summary>
   /// A(n) cubic point. Defined in terms of a(n) cubic inch.
   /// </summary>
   public static readonly Volume CubicPoint = new (
                                                   "cubic point"
                                                 , "p^3"
                                                 , CubicInch
                                                 , 1.0 / 72.0 * (1.0 / 72.0) * (1.0 / 72.0)
                                                 , 0
                                                  );

   /// <summary>
   /// A(n) cubic twip. Defined in terms of a(n) cubic point.
   /// </summary>
   public static readonly Volume CubicTwip = new (
                                                  "cubic twip"
                                                , "twip^3"
                                                , CubicPoint
                                                , 1.0 / 20.0 * (1.0 / 20.0) * (1.0 / 20.0)
                                                , 0
                                                 );

   /// <summary>
   /// A(n) cubic pica. Defined in terms of a(n) cubic point.
   /// </summary>
   public static readonly Volume CubicPica = new ("cubic pica", "P^3", CubicPoint, 12.0 * 12.0 * 12.0, 0);

   /// <summary>
   /// A(n) cubic foot. Defined in terms of a(n) cubic inch.
   /// </summary>
   public static readonly Volume CubicFoot = new ("cubic foot", "ft^3", CubicInch, 12.0 * 12.0 * 12.0, 0);

   /// <summary>
   /// A(n) cubic yard. Defined in terms of a(n) cubic foot.
   /// </summary>
   public static readonly Volume CubicYard = new ("cubic yard", "yd^3", CubicFoot, 3.0 * 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) cubic mile. Defined in terms of a(n) cubic yard.
   /// </summary>
   public static readonly Volume CubicMile = new ("cubic mile", "mi^3", CubicYard, 1760.0 * 1760.0 * 1760.0, 0);

   /// <summary>
   /// A(n) cubic league. Defined in terms of a(n) cubic mile.
   /// </summary>
   public static readonly Volume CubicLeague = new ("cubic league", "le^3", CubicMile, 3.0 * 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) cubic fathom. Defined in terms of a(n) cubic yard.
   /// </summary>
   public static readonly Volume CubicFathom = new ("cubic fathom", "ftm^3", CubicYard, 2.0 * 2.0 * 2.0, 0);

   /// <summary>
   /// A(n) cubic cable. Defined in terms of a(n) cubic fathom.
   /// </summary>
   public static readonly Volume CubicCable = new ("cubic cable", "cb^3", CubicFathom, 120.0 * 120.0 * 120.0, 0);

   /// <summary>
   /// A(n) cubic nautical mile. Defined in terms of a(n) SI cubic meter.
   /// </summary>
   public static readonly Volume CubicNauticalMile = new (
                                                          "cubic nautical mile"
                                                        , "nmi^3"
                                                        , SI.Volumes.CubicMeter
                                                        , 1852.0 * 1852.0 * 1852.0
                                                        , 0
                                                         );
}
