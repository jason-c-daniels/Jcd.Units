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
   /// square inch, defined as: SI square centimeter × (2.54)*(2.54)
   /// </summary>
   public static readonly Area SquareInch = new (
                                                 "square inch"
                                               , "in²"
                                               , SI.Areas.SquareCentimeter
                                               , 2.54 * 2.54
                                               , system: "Imperial"
                                                );

   /// <summary>
   /// square foot, defined as: square inch × (12)*(12)
   /// </summary>
   public static readonly Area SquareFoot = new ("square foot", "ft²", SquareInch, 12 * 12, system: "Imperial");

   /// <summary>
   /// square twip, defined as: square foot × (1.0/17280.0)*(1.0/17280.0)
   /// </summary>
   public static readonly Area SquareTwip = new (
                                                 "square twip"
                                               , "twip²"
                                               , SquareFoot
                                               , 1.0 / 17280.0 * (1.0 / 17280.0)
                                               , system: "Imperial"
                                                );

   /// <summary>
   /// square thou, defined as: square foot × (1.0/12000.0)*(1.0/12000.0)
   /// </summary>
   public static readonly Area SquareThou = new (
                                                 "square thou"
                                               , "th²"
                                               , SquareFoot
                                               , 1.0 / 12000.0 * (1.0 / 12000.0)
                                               , system: "Imperial"
                                                );

   /// <summary>
   /// square barleycorn, defined as: square foot × (1.0/36.0)*(1.0/36.0)
   /// </summary>
   public static readonly Area SquareBarleycorn = new (
                                                       "square barleycorn"
                                                     , "barleycorn²"
                                                     , SquareFoot
                                                     , 1.0 / 36.0 * (1.0 / 36.0)
                                                     , system: "Imperial"
                                                      );

   /// <summary>
   /// square hand, defined as: square inch × (4.0)*(4.0)
   /// </summary>
   public static readonly Area SquareHand = new ("square hand", "hh²", SquareInch, 4.0 * 4.0, system: "Imperial");

   /// <summary>
   /// square yard, defined as: square foot × (3.0)*(3.0)
   /// </summary>
   public static readonly Area SquareYard = new ("square yard", "yd²", SquareFoot, 3.0 * 3.0, system: "Imperial");

   /// <summary>
   /// square chain, defined as: square yard × (22.0)*(22.0)
   /// </summary>
   public static readonly Area SquareChain = new ("square chain", "ch²", SquareYard, 22.0 * 22.0, system: "Imperial");

   /// <summary>
   /// square furlong, defined as: square chain × (10.0)*(10.0)
   /// </summary>
   public static readonly Area SquareFurlong = new (
                                                    "square furlong"
                                                  , "fur²"
                                                  , SquareChain
                                                  , 10.0 * 10.0
                                                  , system: "Imperial"
                                                   );

   /// <summary>
   /// square mile, defined as: square furlong × (8.0)*(8.0)
   /// </summary>
   public static readonly Area SquareMile = new ("square mile", "mi²", SquareFurlong, 8.0 * 8.0, system: "Imperial");

   /// <summary>
   /// square league, defined as: square mile × (3.0)*(3.0)
   /// </summary>
   public static readonly Area SquareLeague = new ("square league", "lea²", SquareMile, 3.0 * 3.0, system: "Imperial");

   /// <summary>
   /// square fathom, defined as: square foot × (6.0)*(6.0)
   /// </summary>
   public static readonly Area SquareFathom = new ("square fathom", "ftm²", SquareFoot, 6.0 * 6.0, system: "Imperial");

   /// <summary>
   /// square cable, defined as: square fathom × (100.0)*(100.0)
   /// </summary>
   public static readonly Area SquareCable = new (
                                                  "square cable"
                                                , "cable²"
                                                , SquareFathom
                                                , 100.0 * 100.0
                                                , system: "Imperial"
                                                 );

   /// <summary>
   /// square nautical mile, defined as: square cable × (10.0)*(10.0)
   /// </summary>
   public static readonly Area SquareNauticalMile = new (
                                                         "square nautical mile"
                                                       , "nmi²"
                                                       , SquareCable
                                                       , 10.0 * 10.0
                                                       , system: "Imperial"
                                                        );

   /// <summary>
   /// perch, defined as: square foot × 272.25
   /// </summary>
   public static readonly Area Perch = new ("perch", "perch", SquareFoot, 272.25, system: "Imperial");

   /// <summary>
   /// rood, defined as: perch × 40.0
   /// </summary>
   public static readonly Area Rood = new ("rood", "rood", Perch, 40.0, system: "Imperial");

   /// <summary>
   /// acre, defined as: rood × 4.0
   /// </summary>
   public static readonly Area Acre = new ("acre", "acre", Rood, 4.0, system: "Imperial");
}
