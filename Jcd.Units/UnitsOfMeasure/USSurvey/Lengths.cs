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
/// United States Survey Units for measuring Length.
/// </summary>
public class Lengths : UnitOfMeasureEnumeration<Lengths, Length>
{
   /// <summary>
   /// link defined such that: SI meter = li × 0.20116.
   /// </summary>
   public static readonly Length Link = new("link", "li", SI.Lengths.Meter, 0.20116, system: "US Survey");

   /// <summary>
   /// rod defined such that: SI meter = rd × 5.0292.
   /// </summary>
   public static readonly Length Rod = new("rod", "rd", SI.Lengths.Meter, 5.0292, system: "US Survey");

   /// <summary>
   /// chain defined such that: SI meter = ch × 20.1168.
   /// </summary>
   public static readonly Length Chain = new("chain", "ch", SI.Lengths.Meter, 20.1168, system: "US Survey");

   /// <summary>
   /// furlong defined such that: SI meter = fur × 201.168.
   /// </summary>
   public static readonly Length Furlong = new("furlong", "fur", SI.Lengths.Meter, 201.168, system: "US Survey");

   /// <summary>
   /// league defined such that: SI meter = lea × 4828.032.
   /// </summary>
   public static readonly Length League = new("league", "lea", SI.Lengths.Meter, 4828.032, system: "US Survey");
}