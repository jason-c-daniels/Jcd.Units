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
/// British Imperial Units for measuring Volume.
/// </summary>
public class Volumes : UnitOfMeasureEnumeration<Volumes, Volume>
{
   /// <summary>
   /// A(n) cubic inch. Defined in terms of a(n) SI cubic centimeter.
   /// </summary>
   public static readonly Volume CubicInch = new (
                                                  "cubic inch"
                                                , "in.^3"
                                                , SI.Volumes.CubicCentimeter
                                                , 2.54 * 2.54 * 2.54
                                                , 0
                                                 );

   /// <summary>
   /// A(n) cubic foot. Defined in terms of a(n) cubic inch.
   /// </summary>
   public static readonly Volume CubicFoot = new ("cubic foot", "ft.^3", CubicInch, 12 * 12 * 12, 0);

   /// <summary>
   /// A(n) cubic twip. Defined in terms of a(n) cubic foot.
   /// </summary>
   public static readonly Volume CubicTwip = new (
                                                  "cubic twip"
                                                , "twip^3"
                                                , CubicFoot
                                                , 1.0 / 17280.0 * (1.0 / 17280.0) * (1.0 / 17280.0)
                                                , 0
                                                 );

   /// <summary>
   /// A(n) cubic thou. Defined in terms of a(n) cubic foot.
   /// </summary>
   public static readonly Volume CubicThou = new (
                                                  "cubic thou"
                                                , "th^3"
                                                , CubicFoot
                                                , 1.0 / 12000.0 * (1.0 / 12000.0) * (1.0 / 12000.0)
                                                , 0
                                                 );

   /// <summary>
   /// A(n) cubic barleycorn. Defined in terms of a(n) cubic foot.
   /// </summary>
   public static readonly Volume CubicBarleycorn = new (
                                                        "cubic barleycorn"
                                                      , "barleycorn^3"
                                                      , CubicFoot
                                                      , 1.0 / 36.0 * (1.0 / 36.0) * (1.0 / 36.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic hand. Defined in terms of a(n) cubic inch.
   /// </summary>
   public static readonly Volume CubicHand = new ("cubic hand", "hh^3", CubicInch, 4.0 * 4.0 * 4.0, 0);

   /// <summary>
   /// A(n) cubic yard. Defined in terms of a(n) cubic foot.
   /// </summary>
   public static readonly Volume CubicYard = new ("cubic yard", "yd^3", CubicFoot, 3.0 * 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) cubic chain. Defined in terms of a(n) cubic yard.
   /// </summary>
   public static readonly Volume CubicChain = new ("cubic chain", "ch^3", CubicYard, 22.0 * 22.0 * 22.0, 0);

   /// <summary>
   /// A(n) cubic furlong. Defined in terms of a(n) cubic chain.
   /// </summary>
   public static readonly Volume CubicFurlong = new ("cubic furlong", "fur^3", CubicChain, 10.0 * 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) cubic mile. Defined in terms of a(n) cubic furlong.
   /// </summary>
   public static readonly Volume CubicMile = new ("cubic mile", "mi^3", CubicFurlong, 8.0 * 8.0 * 8.0, 0);

   /// <summary>
   /// A(n) cubic league. Defined in terms of a(n) cubic mile.
   /// </summary>
   public static readonly Volume CubicLeague = new ("cubic league", "lea^3", CubicMile, 3.0 * 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) cubic fathom. Defined in terms of a(n) cubic foot.
   /// </summary>
   public static readonly Volume CubicFathom = new ("cubic fathom", "ftm^3", CubicFoot, 6.0 * 6.0 * 6.0, 0);

   /// <summary>
   /// A(n) cubic cable. Defined in terms of a(n) cubic fathom.
   /// </summary>
   public static readonly Volume CubicCable = new ("cubic cable", "cable^3", CubicFathom, 100.0 * 100.0 * 100.0, 0);

   /// <summary>
   /// A(n) cubic nautical mile. Defined in terms of a(n) cubic cable.
   /// </summary>
   public static readonly Volume CubicNauticalMile = new (
                                                          "cubic nautical mile"
                                                        , "nmi^3"
                                                        , CubicCable
                                                        , 10.0 * 10.0 * 10.0
                                                        , 0
                                                         );
}
