#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure;

/// <summary>
/// Uncategorized Units for measuring Temperature.
/// </summary>
public class Temperatures : UnitOfMeasureEnumeration<Temperatures, Temperature>
{
   /// <summary>
   /// degrees rankine, defined as: SI degrees kelvin × 5.0/9.0
   /// </summary>
   public static readonly Temperature DegreesRankine = new (
                                                            "degrees rankine"
                                                          , "°R"
                                                          , SI.Temperatures.DegreesKelvin
                                                          , 5.0 / 9.0
                                                           );

   /// <summary>
   /// degrees delisle, defined as: (SI degrees celcius + -150) × -2d/3d.
   /// </summary>
   public static readonly Temperature DegreesDelisle = new (
                                                            "degrees delisle"
                                                          , "°De"
                                                          , SI.Temperatures.DegreesCelcius
                                                          , -2d / 3d
                                                          , -150
                                                           );

   /// <summary>
   /// degrees newton, defined as: SI degrees celcius × 100.0/33.0
   /// </summary>
   public static readonly Temperature DegreesNewton = new (
                                                           "degrees newton"
                                                         , "°N"
                                                         , SI.Temperatures.DegreesCelcius
                                                         , 100.0 / 33.0
                                                          );

   /// <summary>
   /// degrees réaumur, defined as: SI degrees celcius × 5.0/4.0
   /// </summary>
   public static readonly Temperature DegreesRéaumur = new (
                                                            "degrees réaumur"
                                                          , "°Ré"
                                                          , SI.Temperatures.DegreesCelcius
                                                          , 5.0 / 4.0
                                                           );

   /// <summary>
   /// degrees rømer, defined as: (SI degrees celcius + -7.5) × 40.0/21.0.
   /// </summary>
   public static readonly Temperature DegreesRømer = new (
                                                          "degrees rømer"
                                                        , "°Rø"
                                                        , SI.Temperatures.DegreesCelcius
                                                        , 40.0 / 21.0
                                                        , -7.5
                                                         );
}
