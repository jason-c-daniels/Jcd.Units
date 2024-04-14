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
   /// square link defined such that: SI square meter = li² × (0.20116)*(0.20116).
   /// </summary>
   public static readonly Area SquareLink = new("square link", "li²", SI.Areas.SquareMeter, 0.20116 * 0.20116, system: "US Survey");
   
   /// <summary>
   /// square rod defined such that: SI square meter = rd² × (5.0292)*(5.0292).
   /// </summary>
   public static readonly Area SquareRod = new("square rod", "rd²", SI.Areas.SquareMeter, 5.0292 * 5.0292, system: "US Survey");
   
   /// <summary>
   /// square chain defined such that: SI square meter = ch² × (20.1168)*(20.1168).
   /// </summary>
   public static readonly Area SquareChain = new("square chain", "ch²", SI.Areas.SquareMeter, 20.1168 * 20.1168, system: "US Survey");
   
   /// <summary>
   /// square furlong defined such that: SI square meter = fur² × (201.168)*(201.168).
   /// </summary>
   public static readonly Area SquareFurlong = new("square furlong", "fur²", SI.Areas.SquareMeter, 201.168 * 201.168, system: "US Survey");
   
   /// <summary>
   /// square league defined such that: SI square meter = lea² × (4828.032)*(4828.032).
   /// </summary>
   public static readonly Area SquareLeague = new("square league", "lea²", SI.Areas.SquareMeter, 4828.032 * 4828.032, system: "US Survey");
}