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
   /// square link, defined as: SI square meter × (0.20116)*(0.20116)
   /// </summary>
   public static readonly Area SquareLink = new ("square link", "li²", SI.Areas.SquareMeter, 0.20116 * 0.20116);

   /// <summary>
   /// square rod, defined as: SI square meter × (5.0292)*(5.0292)
   /// </summary>
   public static readonly Area SquareRod = new ("square rod", "rd²", SI.Areas.SquareMeter, 5.0292 * 5.0292);

   /// <summary>
   /// square chain, defined as: SI square meter × (20.1168)*(20.1168)
   /// </summary>
   public static readonly Area SquareChain = new ("square chain", "ch²", SI.Areas.SquareMeter, 20.1168 * 20.1168);

   /// <summary>
   /// square furlong, defined as: SI square meter × (201.168)*(201.168)
   /// </summary>
   public static readonly Area SquareFurlong = new ("square furlong", "fur²", SI.Areas.SquareMeter, 201.168 * 201.168);

   /// <summary>
   /// square league, defined as: SI square meter × (4828.032)*(4828.032)
   /// </summary>
   public static readonly Area SquareLeague = new ("square league", "lea²", SI.Areas.SquareMeter, 4828.032 * 4828.032);
}
