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
   /// A(n) cubic link. Defined as: (0.20116)*(0.20116)*(0.20116) × SI cubic meter.
   /// </summary>
   public static readonly Volume CubicLink = new (
                                                  "cubic link"
                                                , "li³"
                                                , SI.Volumes.CubicMeter
                                                , 0.20116 * 0.20116 * 0.20116
                                                , 0
                                                 );

   /// <summary>
   /// A(n) cubic rod. Defined as: (5.0292)*(5.0292)*(5.0292) × SI cubic meter.
   /// </summary>
   public static readonly Volume CubicRod = new (
                                                 "cubic rod"
                                               , "rd³"
                                               , SI.Volumes.CubicMeter
                                               , 5.0292 * 5.0292 * 5.0292
                                               , 0
                                                );

   /// <summary>
   /// A(n) cubic chain. Defined as: (20.1168)*(20.1168)*(20.1168) × SI cubic meter.
   /// </summary>
   public static readonly Volume CubicChain = new (
                                                   "cubic chain"
                                                 , "ch³"
                                                 , SI.Volumes.CubicMeter
                                                 , 20.1168 * 20.1168 * 20.1168
                                                 , 0
                                                  );

   /// <summary>
   /// A(n) cubic furlong. Defined as: (201.168)*(201.168)*(201.168) × SI cubic meter.
   /// </summary>
   public static readonly Volume CubicFurlong = new (
                                                     "cubic furlong"
                                                   , "fur³"
                                                   , SI.Volumes.CubicMeter
                                                   , 201.168 * 201.168 * 201.168
                                                   , 0
                                                    );

   /// <summary>
   /// A(n) cubic league. Defined as: (4828.032)*(4828.032)*(4828.032) × SI cubic meter.
   /// </summary>
   public static readonly Volume CubicLeague = new (
                                                    "cubic league"
                                                  , "lea³"
                                                  , SI.Volumes.CubicMeter
                                                  , 4828.032 * 4828.032 * 4828.032
                                                  , 0
                                                   );
}
