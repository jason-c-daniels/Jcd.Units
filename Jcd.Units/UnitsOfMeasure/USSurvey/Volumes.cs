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
/// United States Survey Units for measuring Volume.
/// </summary>
public class Volumes : UnitOfMeasureEnumeration<Volumes, Volume>
{
   /// <summary>
   /// cubic link defined such that: SI cubic meter = li³ × (0.20116)*(0.20116)*(0.20116).
   /// </summary>
   public static readonly Volume CubicLink = new("cubic link", "li³", SI.Volumes.CubicMeter, 0.20116 * 0.20116 * 0.20116, system: "US Survey");
   
   /// <summary>
   /// cubic rod defined such that: SI cubic meter = rd³ × (5.0292)*(5.0292)*(5.0292).
   /// </summary>
   public static readonly Volume CubicRod = new("cubic rod", "rd³", SI.Volumes.CubicMeter, 5.0292 * 5.0292 * 5.0292, system: "US Survey");
   
   /// <summary>
   /// cubic chain defined such that: SI cubic meter = ch³ × (20.1168)*(20.1168)*(20.1168).
   /// </summary>
   public static readonly Volume CubicChain = new("cubic chain", "ch³", SI.Volumes.CubicMeter, 20.1168 * 20.1168 * 20.1168, system: "US Survey");
   
   /// <summary>
   /// cubic furlong defined such that: SI cubic meter = fur³ × (201.168)*(201.168)*(201.168).
   /// </summary>
   public static readonly Volume CubicFurlong = new("cubic furlong", "fur³", SI.Volumes.CubicMeter, 201.168 * 201.168 * 201.168, system: "US Survey");
   
   /// <summary>
   /// cubic league defined such that: SI cubic meter = lea³ × (4828.032)*(4828.032)*(4828.032).
   /// </summary>
   public static readonly Volume CubicLeague = new("cubic league", "lea³", SI.Volumes.CubicMeter, 4828.032 * 4828.032 * 4828.032, system: "US Survey");
}