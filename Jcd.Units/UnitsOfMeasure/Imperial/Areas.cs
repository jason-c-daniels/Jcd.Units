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
/// British Imperial Units for measuring Area.
/// </summary>
public class Areas : Enumeration<Areas, Area>
{
   /// <summary>
   /// A(n) square inch. Defined in terms of a(n) SI square centimeter.
   /// </summary>
   public static readonly Area SquareInch = new ("square inch", "in.^2", SI.Areas.SquareCentimeter, 2.54 * 2.54, 0);

   /// <summary>
   /// A(n) square foot. Defined in terms of a(n) square inch.
   /// </summary>
   public static readonly Area SquareFoot = new ("square foot", "ft.^2", SquareInch, 12 * 12, 0);

   /// <summary>
   /// A(n) square twip. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area SquareTwip = new (
                                                 "square twip"
                                               , "twip^2"
                                               , SquareFoot
                                               , 1.0 / 17280.0 * (1.0 / 17280.0)
                                               , 0
                                                );

   /// <summary>
   /// A(n) square thou. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area SquareThou = new ("square thou", "th^2", SquareFoot, 1.0 / 12000.0 * (1.0 / 12000.0), 0);

   /// <summary>
   /// A(n) square barleycorn. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area SquareBarleycorn = new (
                                                       "square barleycorn"
                                                     , "barleycorn^2"
                                                     , SquareFoot
                                                     , 1.0 / 36.0 * (1.0 / 36.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square hand. Defined in terms of a(n) square inch.
   /// </summary>
   public static readonly Area SquareHand = new ("square hand", "hh^2", SquareInch, 4.0 * 4.0, 0);

   /// <summary>
   /// A(n) square yard. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area SquareYard = new ("square yard", "yd^2", SquareFoot, 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) square chain. Defined in terms of a(n) square yard.
   /// </summary>
   public static readonly Area SquareChain = new ("square chain", "ch^2", SquareYard, 22.0 * 22.0, 0);

   /// <summary>
   /// A(n) square furlong. Defined in terms of a(n) square chain.
   /// </summary>
   public static readonly Area SquareFurlong = new ("square furlong", "fur^2", SquareChain, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square mile. Defined in terms of a(n) square furlong.
   /// </summary>
   public static readonly Area SquareMile = new ("square mile", "mi^2", SquareFurlong, 8.0 * 8.0, 0);

   /// <summary>
   /// A(n) square league. Defined in terms of a(n) square mile.
   /// </summary>
   public static readonly Area SquareLeague = new ("square league", "lea^2", SquareMile, 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) square fathom. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area SquareFathom = new ("square fathom", "ftm^2", SquareFoot, 6.0 * 6.0, 0);

   /// <summary>
   /// A(n) square cable. Defined in terms of a(n) square fathom.
   /// </summary>
   public static readonly Area SquareCable = new ("square cable", "cable^2", SquareFathom, 100.0 * 100.0, 0);

   /// <summary>
   /// A(n) square nautical mile. Defined in terms of a(n) square cable.
   /// </summary>
   public static readonly Area SquareNauticalMile = new ("square nautical mile", "nmi^2", SquareCable, 10.0 * 10.0, 0);
}
