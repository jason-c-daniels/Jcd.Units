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
public class Areas : Enumeration<Areas, Area>
{
   /// <summary>
   /// A(n) square inch. Defined in terms of a(n) SI square centimeter.
   /// </summary>
   public static readonly Area SquareInch = new ("square inch", "in^2", SI.Areas.SquareCentimeter, 2.54 * 2.54, 0);

   /// <summary>
   /// A(n) square mil. Defined in terms of a(n) square inch.
   /// </summary>
   public static readonly Area SquareMil = new ("square mil", "mil^2", SquareInch, 1.0 / 1000.0 * (1.0 / 1000.0), 0);

   /// <summary>
   /// A(n) square point. Defined in terms of a(n) square inch.
   /// </summary>
   public static readonly Area SquarePoint = new ("square point", "p^2", SquareInch, 1.0 / 72.0 * (1.0 / 72.0), 0);

   /// <summary>
   /// A(n) square twip. Defined in terms of a(n) square point.
   /// </summary>
   public static readonly Area SquareTwip = new ("square twip", "twip^2", SquarePoint, 1.0 / 20.0 * (1.0 / 20.0), 0);

   /// <summary>
   /// A(n) square pica. Defined in terms of a(n) square point.
   /// </summary>
   public static readonly Area SquarePica = new ("square pica", "P^2", SquarePoint, 12.0 * 12.0, 0);

   /// <summary>
   /// A(n) square foot. Defined in terms of a(n) square inch.
   /// </summary>
   public static readonly Area SquareFoot = new ("square foot", "ft^2", SquareInch, 12.0 * 12.0, 0);

   /// <summary>
   /// A(n) square yard. Defined in terms of a(n) square foot.
   /// </summary>
   public static readonly Area SquareYard = new ("square yard", "yd^2", SquareFoot, 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) square mile. Defined in terms of a(n) square yard.
   /// </summary>
   public static readonly Area SquareMile = new ("square mile", "mi^2", SquareYard, 1760.0 * 1760.0, 0);

   /// <summary>
   /// A(n) square league. Defined in terms of a(n) square mile.
   /// </summary>
   public static readonly Area SquareLeague = new ("square league", "le^2", SquareMile, 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) square fathom. Defined in terms of a(n) square yard.
   /// </summary>
   public static readonly Area SquareFathom = new ("square fathom", "ftm^2", SquareYard, 2.0 * 2.0, 0);

   /// <summary>
   /// A(n) square cable. Defined in terms of a(n) square fathom.
   /// </summary>
   public static readonly Area SquareCable = new ("square cable", "cb^2", SquareFathom, 120.0 * 120.0, 0);

   /// <summary>
   /// A(n) square nautical mile. Defined in terms of a(n) SI square meter.
   /// </summary>
   public static readonly Area SquareNauticalMile = new (
                                                         "square nautical mile"
                                                       , "nmi^2"
                                                       , SI.Areas.SquareMeter
                                                       , 1852.0 * 1852.0
                                                       , 0
                                                        );
}
