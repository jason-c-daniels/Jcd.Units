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
   /// degrees rankine defined such that: SI degrees kelvin = °R × 5.0/9.0.
   /// </summary>
   public static readonly Temperature DegreesRankine = new (
                                                            "degrees rankine"
                                                          , "°R"
                                                          , SI.Temperatures.DegreesKelvin
                                                          , 5.0 / 9.0
                                                          , system: ""
                                                           );

   /// <summary>
   /// degrees delisle defined such that: SI degrees celcius = (°De + -150) × -2.0/3.0.
   /// </summary>
   public static readonly Temperature DegreesDelisle = new (
                                                            "degrees delisle"
                                                          , "°De"
                                                          , SI.Temperatures.DegreesCelcius
                                                          , -2.0 / 3.0
                                                          , -150
                                                          , system: ""
                                                           );

   /// <summary>
   /// degrees newton defined such that: SI degrees celcius = °N × 100.0/33.0.
   /// </summary>
   public static readonly Temperature DegreesNewton = new (
                                                           "degrees newton"
                                                         , "°N"
                                                         , SI.Temperatures.DegreesCelcius
                                                         , 100.0 / 33.0
                                                         , system: ""
                                                          );

   /// <summary>
   /// degrees réaumur defined such that: SI degrees celcius = °Ré × 5.0/4.0.
   /// </summary>
   public static readonly Temperature DegreesRéaumur = new (
                                                            "degrees réaumur"
                                                          , "°Ré"
                                                          , SI.Temperatures.DegreesCelcius
                                                          , 5.0 / 4.0
                                                          , system: ""
                                                           );

   /// <summary>
   /// degrees rømer defined such that: SI degrees celcius = (°Rø + -7.5) × 40.0/21.0.
   /// </summary>
   public static readonly Temperature DegreesRømer = new (
                                                          "degrees rømer"
                                                        , "°Rø"
                                                        , SI.Temperatures.DegreesCelcius
                                                        , 40.0 / 21.0
                                                        , -7.5
                                                        , system: ""
                                                         );
}
