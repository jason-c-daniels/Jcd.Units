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
public class Areas : UnitOfMeasureEnumeration<Areas, Area>
{
   /// <summary>
   /// A(n) square link. Defined as: (0.20116)*(0.20116) × SI square meter.
   /// </summary>
   public static readonly Area SquareLink = new ("square link", "li²", SI.Areas.SquareMeter, 0.20116 * 0.20116, 0);

   /// <summary>
   /// A(n) square rod. Defined as: (5.0292)*(5.0292) × SI square meter.
   /// </summary>
   public static readonly Area SquareRod = new ("square rod", "rd²", SI.Areas.SquareMeter, 5.0292 * 5.0292, 0);

   /// <summary>
   /// A(n) square chain. Defined as: (20.1168)*(20.1168) × SI square meter.
   /// </summary>
   public static readonly Area SquareChain = new ("square chain", "ch²", SI.Areas.SquareMeter, 20.1168 * 20.1168, 0);

   /// <summary>
   /// A(n) square furlong. Defined as: (201.168)*(201.168) × SI square meter.
   /// </summary>
   public static readonly Area SquareFurlong = new (
                                                    "square furlong"
                                                  , "fur²"
                                                  , SI.Areas.SquareMeter
                                                  , 201.168 * 201.168
                                                  , 0
                                                   );

   /// <summary>
   /// A(n) square league. Defined as: (4828.032)*(4828.032) × SI square meter.
   /// </summary>
   public static readonly Area SquareLeague = new (
                                                   "square league"
                                                 , "lea²"
                                                 , SI.Areas.SquareMeter
                                                 , 4828.032 * 4828.032
                                                 , 0
                                                  );
}
