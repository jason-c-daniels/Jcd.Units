#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.Astronomical;

/// <summary>
/// Astronomical Units for measuring Volume.
/// </summary>
public class Volumes : Enumeration<Volumes, Volume>
{
   /// <summary>
   /// A(n) cubic astronomical unit. Defined in terms of a(n) SI cubic kilometer.
   /// </summary>
   public static readonly Volume CubicAstronomicalUnit = new (
                                                              "cubic astronomical unit"
                                                            , "AU^3"
                                                            , SI.Volumes.CubicKilometer
                                                            , 149597870.691 * 149597870.691
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cubic earth radius. Defined in terms of a(n) SI cubic kilometer.
   /// </summary>
   public static readonly Volume CubicEarthRadius = new (
                                                         "cubic earth radius"
                                                       , "R(⊕)^3"
                                                       , SI.Volumes.CubicKilometer
                                                       , 6_371 * 6_371
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic lunar radius. Defined in terms of a(n) SI cubic kilometer.
   /// </summary>
   public static readonly Volume CubicLunarRadius = new (
                                                         "cubic lunar radius"
                                                       , "R(L)^3"
                                                       , SI.Volumes.CubicKilometer
                                                       , 1_737.4 * 1_737.4
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic mars radius. Defined in terms of a(n) SI cubic kilometer.
   /// </summary>
   public static readonly Volume CubicMarsRadius = new (
                                                        "cubic mars radius"
                                                      , "R(♂)^3"
                                                      , SI.Volumes.CubicKilometer
                                                      , 3_389.5 * 3_389.5
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic earth diameter. Defined in terms of a(n) cubic earth radius.
   /// </summary>
   public static readonly Volume CubicEarthDiameter = new (
                                                           "cubic earth diameter"
                                                         , "D(⊕)^3"
                                                         , CubicEarthRadius
                                                         , 2 * 2
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) cubic lunar diameter. Defined in terms of a(n) cubic lunar radius.
   /// </summary>
   public static readonly Volume CubicLunarDiameter = new (
                                                           "cubic lunar diameter"
                                                         , "D(L)^3"
                                                         , CubicLunarRadius
                                                         , 2 * 2
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) cubic mars diameter. Defined in terms of a(n) cubic mars radius.
   /// </summary>
   public static readonly Volume CubicMarsDiameter = new ("cubic mars diameter", "D(♂)^3", CubicMarsRadius, 2 * 2, 0);

   /// <summary>
   /// A(n) cubic earth circumference. Defined in terms of a(n) cubic earth diameter.
   /// </summary>
   public static readonly Volume CubicEarthCircumference = new (
                                                                "cubic earth circumference"
                                                              , "C(⊕)^3"
                                                              , CubicEarthDiameter
                                                              , 3.14159_26535_89793_23846 * 3.14159_26535_89793_23846
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) cubic lunar circumference. Defined in terms of a(n) cubic lunar diameter.
   /// </summary>
   public static readonly Volume CubicLunarCircumference = new (
                                                                "cubic lunar circumference"
                                                              , "C(L)^3"
                                                              , CubicLunarDiameter
                                                              , 3.14159_26535_89793_23846 * 3.14159_26535_89793_23846
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) cubic mars circumference. Defined in terms of a(n) cubic mars diameter.
   /// </summary>
   public static readonly Volume CubicMarsCircumference = new (
                                                               "cubic mars circumference"
                                                             , "C(♂)^3"
                                                             , CubicMarsDiameter
                                                             , 3.14159_26535_89793_23846 * 3.14159_26535_89793_23846
                                                             , 0
                                                              );
}
