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
public class Volumes : Enumeration<Volumes, Volume>
{
   /// <summary>
   /// A(n) cubic link. Defined in terms of a(n) SI cubic meter.
   /// </summary>
   public static readonly Volume CubicLink = new ("cubic link", "li^3", SI.Volumes.CubicMeter, 0.20116 * 0.20116, 0);

   /// <summary>
   /// A(n) cubic rod. Defined in terms of a(n) SI cubic meter.
   /// </summary>
   public static readonly Volume CubicRod = new ("cubic rod", "rd^3", SI.Volumes.CubicMeter, 5.0292 * 5.0292, 0);

   /// <summary>
   /// A(n) cubic chain. Defined in terms of a(n) SI cubic meter.
   /// </summary>
   public static readonly Volume CubicChain = new ("cubic chain", "ch^3", SI.Volumes.CubicMeter, 20.1168 * 20.1168, 0);

   /// <summary>
   /// A(n) cubic furlong. Defined in terms of a(n) SI cubic meter.
   /// </summary>
   public static readonly Volume CubicFurlong = new (
                                                     "cubic furlong"
                                                   , "fur^3"
                                                   , SI.Volumes.CubicMeter
                                                   , 201.168 * 201.168
                                                   , 0
                                                    );

   /// <summary>
   /// A(n) cubic league. Defined in terms of a(n) SI cubic meter.
   /// </summary>
   public static readonly Volume CubicLeague = new (
                                                    "cubic league"
                                                  , "lea^3"
                                                  , SI.Volumes.CubicMeter
                                                  , 4828.032 * 4828.032
                                                  , 0
                                                   );
}
