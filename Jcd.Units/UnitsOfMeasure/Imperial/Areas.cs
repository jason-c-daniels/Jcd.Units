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
public class Areas : UnitOfMeasureEnumeration<Areas, Area>
{
   /// <summary>
   /// A(n) square inch. Defined in terms of a(n) SI square centimeter.
   /// </summary>
   public static readonly Area SquareInch = new ("square inch", "in.²", SI.Areas.SquareCentimeter, 2.54 * 2.54, 0);

   /// <summary>
   /// A(n) perch. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area Perch = new ("perch", "perch", SquareFoot, 272.25, 0);

   /// <summary>
   /// A(n) square foot. Defined in terms of a(n) square inch.
   /// </summary>
   public static readonly Area SquareFoot = new ("square foot", "ft.²", SquareInch, 12 * 12, 0);

   /// <summary>
   /// A(n) rood. Defined in terms of a(n) perch.
   /// </summary>
   public static readonly Area Rood = new ("rood", "rood", Perch, 40.0, 0);

   /// <summary>
   /// A(n) square twip. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area SquareTwip = new (
                                                 "square twip"
                                               , "twip²"
                                               , SquareFoot
                                               , 1.0 / 17280.0 * (1.0 / 17280.0)
                                               , 0
                                                );

   /// <summary>
   /// A(n) acre. Defined in terms of a(n) rood.
   /// </summary>
   public static readonly Area Acre = new ("acre", "acre", Rood, 4.0, 0);

   /// <summary>
   /// A(n) square thou. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area SquareThou = new ("square thou", "th²", SquareFoot, 1.0 / 12000.0 * (1.0 / 12000.0), 0);

   /// <summary>
   /// A(n) square barleycorn. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area SquareBarleycorn = new (
                                                       "square barleycorn"
                                                     , "barleycorn²"
                                                     , SquareFoot
                                                     , 1.0 / 36.0 * (1.0 / 36.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square hand. Defined in terms of a(n) square inch.
   /// </summary>
   public static readonly Area SquareHand = new ("square hand", "hh²", SquareInch, 4.0 * 4.0, 0);

   /// <summary>
   /// A(n) square yard. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area SquareYard = new ("square yard", "yd²", SquareFoot, 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) square chain. Defined in terms of a(n) square yard.
   /// </summary>
   public static readonly Area SquareChain = new ("square chain", "ch²", SquareYard, 22.0 * 22.0, 0);

   /// <summary>
   /// A(n) square furlong. Defined in terms of a(n) square chain.
   /// </summary>
   public static readonly Area SquareFurlong = new ("square furlong", "fur²", SquareChain, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square mile. Defined in terms of a(n) square furlong.
   /// </summary>
   public static readonly Area SquareMile = new ("square mile", "mi²", SquareFurlong, 8.0 * 8.0, 0);

   /// <summary>
   /// A(n) square league. Defined in terms of a(n) square mile.
   /// </summary>
   public static readonly Area SquareLeague = new ("square league", "lea²", SquareMile, 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) square fathom. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area SquareFathom = new ("square fathom", "ftm²", SquareFoot, 6.0 * 6.0, 0);

   /// <summary>
   /// A(n) square cable. Defined in terms of a(n) square fathom.
   /// </summary>
   public static readonly Area SquareCable = new ("square cable", "cable²", SquareFathom, 100.0 * 100.0, 0);

   /// <summary>
   /// A(n) square nautical mile. Defined in terms of a(n) square cable.
   /// </summary>
   public static readonly Area SquareNauticalMile = new ("square nautical mile", "nmi²", SquareCable, 10.0 * 10.0, 0);
}
