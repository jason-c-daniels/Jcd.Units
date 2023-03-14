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
/// Astronomical Units for measuring Area.
/// </summary>
public class Areas : Enumeration<Areas, Area>
{
   /// <summary>
   /// A(n) square astronomical unit. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareAstronomicalUnit = new (
                                                             "square astronomical unit"
                                                           , "AU^2"
                                                           , SI.Areas.SquareKilometer
                                                           , 149597870.691 * 149597870.691
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) square earth radius. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareEarthRadius = new (
                                                        "square earth radius"
                                                      , "R(⊕)^2"
                                                      , SI.Areas.SquareKilometer
                                                      , 6_371 * 6_371
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square lunar radius. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareLunarRadius = new (
                                                        "square lunar radius"
                                                      , "R(L)^2"
                                                      , SI.Areas.SquareKilometer
                                                      , 1_737.4 * 1_737.4
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square mars radius. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareMarsRadius = new (
                                                       "square mars radius"
                                                     , "R(♂)^2"
                                                     , SI.Areas.SquareKilometer
                                                     , 3_389.5 * 3_389.5
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square earth diameter. Defined in terms of a(n) square earth radius.
   /// </summary>
   public static readonly Area SquareEarthDiameter = new (
                                                          "square earth diameter"
                                                        , "D(⊕)^2"
                                                        , SquareEarthRadius
                                                        , 2 * 2
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square lunar diameter. Defined in terms of a(n) square lunar radius.
   /// </summary>
   public static readonly Area SquareLunarDiameter = new (
                                                          "square lunar diameter"
                                                        , "D(L)^2"
                                                        , SquareLunarRadius
                                                        , 2 * 2
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square mars diameter. Defined in terms of a(n) square mars radius.
   /// </summary>
   public static readonly Area SquareMarsDiameter = new ("square mars diameter", "D(♂)^2", SquareMarsRadius, 2 * 2, 0);

   /// <summary>
   /// A(n) square earth circumference. Defined in terms of a(n) square earth diameter.
   /// </summary>
   public static readonly Area SquareEarthCircumference = new (
                                                               "square earth circumference"
                                                             , "C(⊕)^2"
                                                             , SquareEarthDiameter
                                                             , 3.14159_26535_89793_23846 * 3.14159_26535_89793_23846
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) square lunar circumference. Defined in terms of a(n) square lunar diameter.
   /// </summary>
   public static readonly Area SquareLunarCircumference = new (
                                                               "square lunar circumference"
                                                             , "C(L)^2"
                                                             , SquareLunarDiameter
                                                             , 3.14159_26535_89793_23846 * 3.14159_26535_89793_23846
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) square mars circumference. Defined in terms of a(n) square mars diameter.
   /// </summary>
   public static readonly Area SquareMarsCircumference = new (
                                                              "square mars circumference"
                                                            , "C(♂)^2"
                                                            , SquareMarsDiameter
                                                            , 3.14159_26535_89793_23846 * 3.14159_26535_89793_23846
                                                            , 0
                                                             );
}
