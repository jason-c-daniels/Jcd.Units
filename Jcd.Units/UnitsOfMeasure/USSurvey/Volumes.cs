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
   /// cubic link, defined as: SI cubic meter × (0.20116)*(0.20116)*(0.20116)
   /// </summary>
   public static readonly Volume CubicLink = new (
                                                  "cubic link"
                                                , "li³"
                                                , SI.Volumes.CubicMeter
                                                , 0.20116 * 0.20116 * 0.20116
                                                 );

   /// <summary>
   /// cubic rod, defined as: SI cubic meter × (5.0292)*(5.0292)*(5.0292)
   /// </summary>
   public static readonly Volume CubicRod = new ("cubic rod", "rd³", SI.Volumes.CubicMeter, 5.0292 * 5.0292 * 5.0292);

   /// <summary>
   /// cubic chain, defined as: SI cubic meter × (20.1168)*(20.1168)*(20.1168)
   /// </summary>
   public static readonly Volume CubicChain = new (
                                                   "cubic chain"
                                                 , "ch³"
                                                 , SI.Volumes.CubicMeter
                                                 , 20.1168 * 20.1168 * 20.1168
                                                  );

   /// <summary>
   /// cubic furlong, defined as: SI cubic meter × (201.168)*(201.168)*(201.168)
   /// </summary>
   public static readonly Volume CubicFurlong = new (
                                                     "cubic furlong"
                                                   , "fur³"
                                                   , SI.Volumes.CubicMeter
                                                   , 201.168 * 201.168 * 201.168
                                                    );

   /// <summary>
   /// cubic league, defined as: SI cubic meter × (4828.032)*(4828.032)*(4828.032)
   /// </summary>
   public static readonly Volume CubicLeague = new (
                                                    "cubic league"
                                                  , "lea³"
                                                  , SI.Volumes.CubicMeter
                                                  , 4828.032 * 4828.032 * 4828.032
                                                   );
}
