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
   /// A(n) square inch. Defined as: (2.54)*(2.54) × SI square centimeter.
   /// </summary>
   public static readonly Area SquareInch = new ("square inch", "in²", SI.Areas.SquareCentimeter, 2.54 * 2.54, 0);

   /// <summary>
   /// A(n) square foot. Defined as: (12)*(12) × square inch.
   /// </summary>
   public static readonly Area SquareFoot = new ("square foot", "ft²", SquareInch, 12 * 12, 0);

   /// <summary>
   /// A(n) square twip. Defined as: (1.0/17280.0)*(1.0/17280.0) × square foot.
   /// </summary>
   public static readonly Area SquareTwip = new (
                                                 "square twip"
                                               , "twip²"
                                               , SquareFoot
                                               , 1.0 / 17280.0 * (1.0 / 17280.0)
                                               , 0
                                                );

   /// <summary>
   /// A(n) square thou. Defined as: (1.0/12000.0)*(1.0/12000.0) × square foot.
   /// </summary>
   public static readonly Area SquareThou = new ("square thou", "th²", SquareFoot, 1.0 / 12000.0 * (1.0 / 12000.0), 0);

   /// <summary>
   /// A(n) square barleycorn. Defined as: (1.0/36.0)*(1.0/36.0) × square foot.
   /// </summary>
   public static readonly Area SquareBarleycorn = new (
                                                       "square barleycorn"
                                                     , "barleycorn²"
                                                     , SquareFoot
                                                     , 1.0 / 36.0 * (1.0 / 36.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square hand. Defined as: (4.0)*(4.0) × square inch.
   /// </summary>
   public static readonly Area SquareHand = new ("square hand", "hh²", SquareInch, 4.0 * 4.0, 0);

   /// <summary>
   /// A(n) square yard. Defined as: (3.0)*(3.0) × square foot.
   /// </summary>
   public static readonly Area SquareYard = new ("square yard", "yd²", SquareFoot, 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) square chain. Defined as: (22.0)*(22.0) × square yard.
   /// </summary>
   public static readonly Area SquareChain = new ("square chain", "ch²", SquareYard, 22.0 * 22.0, 0);

   /// <summary>
   /// A(n) square furlong. Defined as: (10.0)*(10.0) × square chain.
   /// </summary>
   public static readonly Area SquareFurlong = new ("square furlong", "fur²", SquareChain, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square mile. Defined as: (8.0)*(8.0) × square furlong.
   /// </summary>
   public static readonly Area SquareMile = new ("square mile", "mi²", SquareFurlong, 8.0 * 8.0, 0);

   /// <summary>
   /// A(n) square league. Defined as: (3.0)*(3.0) × square mile.
   /// </summary>
   public static readonly Area SquareLeague = new ("square league", "lea²", SquareMile, 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) square fathom. Defined as: (6.0)*(6.0) × square foot.
   /// </summary>
   public static readonly Area SquareFathom = new ("square fathom", "ftm²", SquareFoot, 6.0 * 6.0, 0);

   /// <summary>
   /// A(n) square cable. Defined as: (100.0)*(100.0) × square fathom.
   /// </summary>
   public static readonly Area SquareCable = new ("square cable", "cable²", SquareFathom, 100.0 * 100.0, 0);

   /// <summary>
   /// A(n) square nautical mile. Defined as: (10.0)*(10.0) × square cable.
   /// </summary>
   public static readonly Area SquareNauticalMile = new ("square nautical mile", "nmi²", SquareCable, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) perch. Defined as: 272.25 × square foot.
   /// </summary>
   public static readonly Area Perch = new ("perch", "perch", SquareFoot, 272.25, 0);

   /// <summary>
   /// A(n) rood. Defined as: 40.0 × perch.
   /// </summary>
   public static readonly Area Rood = new ("rood", "rood", Perch, 40.0, 0);

   /// <summary>
   /// A(n) acre. Defined as: 4.0 × rood.
   /// </summary>
   public static readonly Area Acre = new ("acre", "acre", Rood, 4.0, 0);
}
