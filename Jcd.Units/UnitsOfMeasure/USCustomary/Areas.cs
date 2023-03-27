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
/// United States Customary Units for measuring Area.
/// </summary>
public class Areas : UnitOfMeasureEnumeration<Areas, Area>
{
   /// <summary>
   /// A(n) square inch. Defined as: ((2.54)*(2.54)) × SI square centimeter + (0).
   /// </summary>
   public static readonly Area SquareInch = new ("square inch", "in²", SI.Areas.SquareCentimeter, 2.54 * 2.54, 0);

   /// <summary>
   /// A(n) square mil. Defined as: ((1.0/1000.0)*(1.0/1000.0)) × square inch + (0).
   /// </summary>
   public static readonly Area SquareMil = new ("square mil", "mil²", SquareInch, 1.0 / 1000.0 * (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) square point. Defined as: ((1.0/72.0)*(1.0/72.0)) × square inch + (0).
   /// </summary>
   public static readonly Area SquarePoint = new ("square point", "p²", SquareInch, 1.0 / 72.0 * (1.0 / 72.0), 0);

   /// <summary>
   /// A(n) square twip. Defined as: ((1.0/20.0)*(1.0/20.0)) × square point + (0).
   /// </summary>
   public static readonly Area SquareTwip = new ("square twip", "twip²", SquarePoint, 1.0 / 20.0 * (1.0 / 20.0), 0);

   /// <summary>
   /// A(n) square pica. Defined as: ((12.0)*(12.0)) × square point + (0).
   /// </summary>
   public static readonly Area SquarePica = new ("square pica", "P²", SquarePoint, 12.0 * 12.0, 0);

   /// <summary>
   /// A(n) square foot. Defined as: ((12.0)*(12.0)) × square inch + (0).
   /// </summary>
   public static readonly Area SquareFoot = new ("square foot", "ft²", SquareInch, 12.0 * 12.0, 0);

   /// <summary>
   /// A(n) square yard. Defined as: ((3.0)*(3.0)) × square foot + (0).
   /// </summary>
   public static readonly Area SquareYard = new ("square yard", "yd²", SquareFoot, 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) square mile. Defined as: ((1760.0)*(1760.0)) × square yard + (0).
   /// </summary>
   public static readonly Area SquareMile = new ("square mile", "mi²", SquareYard, 1760.0 * 1760.0, 0);

   /// <summary>
   /// A(n) square league. Defined as: ((3.0)*(3.0)) × square mile + (0).
   /// </summary>
   public static readonly Area SquareLeague = new ("square league", "le²", SquareMile, 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) square fathom. Defined as: ((2.0)*(2.0)) × square yard + (0).
   /// </summary>
   public static readonly Area SquareFathom = new ("square fathom", "ftm²", SquareYard, 2.0 * 2.0, 0);

   /// <summary>
   /// A(n) square cable. Defined as: ((120.0)*(120.0)) × square fathom + (0).
   /// </summary>
   public static readonly Area SquareCable = new ("square cable", "cb²", SquareFathom, 120.0 * 120.0, 0);

   /// <summary>
   /// A(n) square nautical mile. Defined as: ((1852.0)*(1852.0)) × SI square meter + (0).
   /// </summary>
   public static readonly Area SquareNauticalMile = new (
                                                         "square nautical mile"
                                                       , "nmi²"
                                                       , SI.Areas.SquareMeter
                                                       , 1852.0 * 1852.0
                                                       , 0
                                                        );
}
