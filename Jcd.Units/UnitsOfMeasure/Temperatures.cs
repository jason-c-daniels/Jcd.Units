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
   /// A(n) degrees rankine. Defined as: (5.0/9.0) × SI degrees kelvin + (0).
   /// </summary>
   public static readonly Temperature DegreesRankine = new (
                                                            "degrees rankine"
                                                          , "°R"
                                                          , SI.Temperatures.DegreesKelvin
                                                          , 5.0 / 9.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) degrees delisle. Defined as: (1.0/1.5) × SI degrees celcius + (100.0).
   /// </summary>
   public static readonly Temperature DegreesDelisle = new (
                                                            "degrees delisle"
                                                          , "°De"
                                                          , SI.Temperatures.DegreesCelcius
                                                          , 1.0 / 1.5
                                                          , 100.0
                                                           );

   /// <summary>
   /// A(n) degrees newton. Defined as: (100.0/33.0) × SI degrees celcius + (0).
   /// </summary>
   public static readonly Temperature DegreesNewton = new (
                                                           "degrees newton"
                                                         , "°N"
                                                         , SI.Temperatures.DegreesCelcius
                                                         , 100.0 / 33.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) degrees réaumur. Defined as: (5.0/4.0) × SI degrees celcius + (0).
   /// </summary>
   public static readonly Temperature DegreesRéaumur = new (
                                                            "degrees réaumur"
                                                          , "°Ré"
                                                          , SI.Temperatures.DegreesCelcius
                                                          , 5.0 / 4.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) degrees rømer. Defined as: (40.0/21.0) × SI degrees celcius + (-7.5).
   /// </summary>
   public static readonly Temperature DegreesRømer = new (
                                                          "degrees rømer"
                                                        , "°Rø"
                                                        , SI.Temperatures.DegreesCelcius
                                                        , 40.0 / 21.0
                                                        , -7.5
                                                         );
}
