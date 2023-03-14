#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.USSurvey;

/// <summary>
/// United States Survey Units for measuring Area.
/// </summary>
public class Areas : Enumeration<Areas, Area>
{
   /// <summary>
   /// A(n) square link. Defined in terms of a(n) SI square meter.
   /// </summary>
   public static readonly Area SquareLink = new ("square link", "li^2", SI.Areas.SquareMeter, 0.20116 * 0.20116, 0);

   /// <summary>
   /// A(n) square rod. Defined in terms of a(n) SI square meter.
   /// </summary>
   public static readonly Area SquareRod = new ("square rod", "rd^2", SI.Areas.SquareMeter, 5.0292 * 5.0292, 0);

   /// <summary>
   /// A(n) square chain. Defined in terms of a(n) SI square meter.
   /// </summary>
   public static readonly Area SquareChain = new ("square chain", "ch^2", SI.Areas.SquareMeter, 20.1168 * 20.1168, 0);

   /// <summary>
   /// A(n) square furlong. Defined in terms of a(n) SI square meter.
   /// </summary>
   public static readonly Area SquareFurlong = new (
                                                    "square furlong"
                                                  , "fur^2"
                                                  , SI.Areas.SquareMeter
                                                  , 201.168 * 201.168
                                                  , 0
                                                   );

   /// <summary>
   /// A(n) square league. Defined in terms of a(n) SI square meter.
   /// </summary>
   public static readonly Area SquareLeague = new (
                                                   "square league"
                                                 , "lea^2"
                                                 , SI.Areas.SquareMeter
                                                 , 4828.032 * 4828.032
                                                 , 0
                                                  );
}
