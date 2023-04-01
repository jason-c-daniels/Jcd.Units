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
public class Areas : UnitOfMeasureEnumeration<Areas, Area>
{
   /// <summary>
   /// square light-year, defined as: SI square meter × (9_460_730_472_580_800.0)*(9_460_730_472_580_800.0)
   /// </summary>
   public static readonly Area SquareLightYear = new (
                                                      "square light-year"
                                                    , "ly²"
                                                    , SI.Areas.SquareMeter
                                                    , 9_460_730_472_580_800.0 * 9_460_730_472_580_800.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// square light-second, defined as: SI square meter × (299_792_458.0)*(299_792_458.0)
   /// </summary>
   public static readonly Area SquareLightSecond = new (
                                                        "square light-second"
                                                      , "ls²"
                                                      , SI.Areas.SquareMeter
                                                      , 299_792_458.0 * 299_792_458.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// square light-minute, defined as: square light-second × (60.0)*(60.0)
   /// </summary>
   public static readonly Area SquareLightMinute = new (
                                                        "square light-minute"
                                                      , "lm²"
                                                      , SquareLightSecond
                                                      , 60.0 * 60.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// square astronomical unit, defined as: SI square kilometer × (149597870.691)*(149597870.691)
   /// </summary>
   public static readonly Area SquareAstronomicalUnit = new (
                                                             "square astronomical unit"
                                                           , "AU²"
                                                           , SI.Areas.SquareKilometer
                                                           , 149597870.691 * 149597870.691
                                                           , system: "Astronomical"
                                                            );

   /// <summary>
   /// square light-hour, defined as: square light-minute × (60.0)*(60.0)
   /// </summary>
   public static readonly Area SquareLightHour = new (
                                                      "square light-hour"
                                                    , "lh²"
                                                    , SquareLightMinute
                                                    , 60.0 * 60.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// square light-day, defined as: square light-hour × (24.0)*(24.0)
   /// </summary>
   public static readonly Area SquareLightDay = new (
                                                     "square light-day"
                                                   , "ld²"
                                                   , SquareLightHour
                                                   , 24.0 * 24.0
                                                   , system: "Astronomical"
                                                    );

   /// <summary>
   /// square light-week, defined as: square light-day × (7.0)*(7.0)
   /// </summary>
   public static readonly Area SquareLightWeek = new (
                                                      "square light-week"
                                                    , "lw²"
                                                    , SquareLightDay
                                                    , 7.0 * 7.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// square parsec, defined as: square light-year × (3.2615637769757)*(3.2615637769757)
   /// </summary>
   public static readonly Area SquareParsec = new (
                                                   "square parsec"
                                                 , "pc²"
                                                 , SquareLightYear
                                                 , 3.2615637769757 * 3.2615637769757
                                                 , system: "Astronomical"
                                                  );

   /// <summary>
   /// square earth radius, defined as: SI square kilometer × (6_371.0)*(6_371.0)
   /// </summary>
   public static readonly Area SquareEarthRadius = new (
                                                        "square earth radius"
                                                      , "R(⊕)²"
                                                      , SI.Areas.SquareKilometer
                                                      , 6_371.0 * 6_371.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// square jovian radius, defined as: SI square kilometer × (69_911.0)*(69_911.0)
   /// </summary>
   public static readonly Area SquareJovianRadius = new (
                                                         "square jovian radius"
                                                       , "R(J)²"
                                                       , SI.Areas.SquareKilometer
                                                       , 69_911.0 * 69_911.0
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// square lunar radius, defined as: SI square kilometer × (1_737.4)*(1_737.4)
   /// </summary>
   public static readonly Area SquareLunarRadius = new (
                                                        "square lunar radius"
                                                      , "R(L)²"
                                                      , SI.Areas.SquareKilometer
                                                      , 1_737.4 * 1_737.4
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// square mars radius, defined as: SI square kilometer × (3_389.5)*(3_389.5)
   /// </summary>
   public static readonly Area SquareMarsRadius = new (
                                                       "square mars radius"
                                                     , "R(♂)²"
                                                     , SI.Areas.SquareKilometer
                                                     , 3_389.5 * 3_389.5
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// square solar radius, defined as: SI square kilometer × (695_700.0)*(695_700.0)
   /// </summary>
   public static readonly Area SquareSolarRadius = new (
                                                        "square solar radius"
                                                      , "R(☉)²"
                                                      , SI.Areas.SquareKilometer
                                                      , 695_700.0 * 695_700.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// square earth diameter, defined as: square earth radius × (2.0)*(2.0)
   /// </summary>
   public static readonly Area SquareEarthDiameter = new (
                                                          "square earth diameter"
                                                        , "D(⊕)²"
                                                        , SquareEarthRadius
                                                        , 2.0 * 2.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// square dekalight-year, defined as: square light-year × (10.0)*(10.0)
   /// </summary>
   public static readonly Area SquareDekalightYear = new (
                                                          "square dekalight-year"
                                                        , "daly²"
                                                        , SquareLightYear
                                                        , 10.0 * 10.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// square jovian diameter, defined as: square jovian radius × (2.0)*(2.0)
   /// </summary>
   public static readonly Area SquareJovianDiameter = new (
                                                           "square jovian diameter"
                                                         , "D(J)²"
                                                         , SquareJovianRadius
                                                         , 2.0 * 2.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// square hectolight-year, defined as: square dekalight-year × (10.0)*(10.0)
   /// </summary>
   public static readonly Area SquareHectolightYear = new (
                                                           "square hectolight-year"
                                                         , "hly²"
                                                         , SquareDekalightYear
                                                         , 10.0 * 10.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// square lunar diameter, defined as: square lunar radius × (2.0)*(2.0)
   /// </summary>
   public static readonly Area SquareLunarDiameter = new (
                                                          "square lunar diameter"
                                                        , "D(L)²"
                                                        , SquareLunarRadius
                                                        , 2.0 * 2.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// square kilolight-year, defined as: square hectolight-year × (10.0)*(10.0)
   /// </summary>
   public static readonly Area SquareKilolightYear = new (
                                                          "square kilolight-year"
                                                        , "kly²"
                                                        , SquareHectolightYear
                                                        , 10.0 * 10.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// square mars diameter, defined as: square mars radius × (2.0)*(2.0)
   /// </summary>
   public static readonly Area SquareMarsDiameter = new (
                                                         "square mars diameter"
                                                       , "D(♂)²"
                                                       , SquareMarsRadius
                                                       , 2.0 * 2.0
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// square megalight-year, defined as: square kilolight-year × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareMegalightYear = new (
                                                          "square megalight-year"
                                                        , "Mly²"
                                                        , SquareKilolightYear
                                                        , 1000.0 * 1000.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// square solar diameter, defined as: square solar radius × (2.0)*(2.0)
   /// </summary>
   public static readonly Area SquareSolarDiameter = new (
                                                          "square solar diameter"
                                                        , "D(☉)²"
                                                        , SquareSolarRadius
                                                        , 2.0 * 2.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// square gigalight-year, defined as: square megalight-year × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareGigalightYear = new (
                                                          "square gigalight-year"
                                                        , "Gly²"
                                                        , SquareMegalightYear
                                                        , 1000.0 * 1000.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// square earth circumference, defined as: square earth diameter × (Math.PI)*(Math.PI)
   /// </summary>
   public static readonly Area SquareEarthCircumference = new (
                                                               "square earth circumference"
                                                             , "C(⊕)²"
                                                             , SquareEarthDiameter
                                                             , Math.PI * Math.PI
                                                             , system: "Astronomical"
                                                              );

   /// <summary>
   /// square teralight-year, defined as: square gigalight-year × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareTeralightYear = new (
                                                          "square teralight-year"
                                                        , "Tly²"
                                                        , SquareGigalightYear
                                                        , 1000.0 * 1000.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// square jovian circumference, defined as: square jovian diameter × (Math.PI)*(Math.PI)
   /// </summary>
   public static readonly Area SquareJovianCircumference = new (
                                                                "square jovian circumference"
                                                              , "C(J)²"
                                                              , SquareJovianDiameter
                                                              , Math.PI * Math.PI
                                                              , system: "Astronomical"
                                                               );

   /// <summary>
   /// square petalight-year, defined as: square teralight-year × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquarePetalightYear = new (
                                                          "square petalight-year"
                                                        , "Ply²"
                                                        , SquareTeralightYear
                                                        , 1000.0 * 1000.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// square lunar circumference, defined as: square lunar diameter × (Math.PI)*(Math.PI)
   /// </summary>
   public static readonly Area SquareLunarCircumference = new (
                                                               "square lunar circumference"
                                                             , "C(L)²"
                                                             , SquareLunarDiameter
                                                             , Math.PI * Math.PI
                                                             , system: "Astronomical"
                                                              );

   /// <summary>
   /// square exalight-year, defined as: square petalight-year × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareExalightYear = new (
                                                         "square exalight-year"
                                                       , "Ely²"
                                                       , SquarePetalightYear
                                                       , 1000.0 * 1000.0
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// square mars circumference, defined as: square mars diameter × (Math.PI)*(Math.PI)
   /// </summary>
   public static readonly Area SquareMarsCircumference = new (
                                                              "square mars circumference"
                                                            , "C(♂)²"
                                                            , SquareMarsDiameter
                                                            , Math.PI * Math.PI
                                                            , system: "Astronomical"
                                                             );

   /// <summary>
   /// square zettalight-year, defined as: square exalight-year × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareZettalightYear = new (
                                                           "square zettalight-year"
                                                         , "Zly²"
                                                         , SquareExalightYear
                                                         , 1000.0 * 1000.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// square solar circumference, defined as: square solar diameter × (Math.PI)*(Math.PI)
   /// </summary>
   public static readonly Area SquareSolarCircumference = new (
                                                               "square solar circumference"
                                                             , "C(☉)²"
                                                             , SquareSolarDiameter
                                                             , Math.PI * Math.PI
                                                             , system: "Astronomical"
                                                              );

   /// <summary>
   /// square yottalight-year, defined as: square zettalight-year × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareYottalightYear = new (
                                                           "square yottalight-year"
                                                         , "Yly²"
                                                         , SquareZettalightYear
                                                         , 1000.0 * 1000.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// square ronnalight-year, defined as: square yottalight-year × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareRonnalightYear = new (
                                                           "square ronnalight-year"
                                                         , "Rly²"
                                                         , SquareYottalightYear
                                                         , 1000.0 * 1000.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// square quettalight-year, defined as: square ronnalight-year × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareQuettalightYear = new (
                                                            "square quettalight-year"
                                                          , "Qly²"
                                                          , SquareRonnalightYear
                                                          , 1000.0 * 1000.0
                                                          , system: "Astronomical"
                                                           );

   /// <summary>
   /// square dekaparsec, defined as: square parsec × (10.0)*(10.0)
   /// </summary>
   public static readonly Area SquareDekaparsec = new (
                                                       "square dekaparsec"
                                                     , "dapc²"
                                                     , SquareParsec
                                                     , 10.0 * 10.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// square hectoparsec, defined as: square dekaparsec × (10.0)*(10.0)
   /// </summary>
   public static readonly Area SquareHectoparsec = new (
                                                        "square hectoparsec"
                                                      , "hpc²"
                                                      , SquareDekaparsec
                                                      , 10.0 * 10.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// square kiloparsec, defined as: square hectoparsec × (10.0)*(10.0)
   /// </summary>
   public static readonly Area SquareKiloparsec = new (
                                                       "square kiloparsec"
                                                     , "kpc²"
                                                     , SquareHectoparsec
                                                     , 10.0 * 10.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// square megaparsec, defined as: square kiloparsec × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareMegaparsec = new (
                                                       "square megaparsec"
                                                     , "Mpc²"
                                                     , SquareKiloparsec
                                                     , 1000.0 * 1000.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// square gigaparsec, defined as: square megaparsec × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareGigaparsec = new (
                                                       "square gigaparsec"
                                                     , "Gpc²"
                                                     , SquareMegaparsec
                                                     , 1000.0 * 1000.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// square teraparsec, defined as: square gigaparsec × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareTeraparsec = new (
                                                       "square teraparsec"
                                                     , "Tpc²"
                                                     , SquareGigaparsec
                                                     , 1000.0 * 1000.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// square petaparsec, defined as: square teraparsec × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquarePetaparsec = new (
                                                       "square petaparsec"
                                                     , "Ppc²"
                                                     , SquareTeraparsec
                                                     , 1000.0 * 1000.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// square exaparsec, defined as: square petaparsec × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareExaparsec = new (
                                                      "square exaparsec"
                                                    , "Epc²"
                                                    , SquarePetaparsec
                                                    , 1000.0 * 1000.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// square zettaparsec, defined as: square exaparsec × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareZettaparsec = new (
                                                        "square zettaparsec"
                                                      , "Zpc²"
                                                      , SquareExaparsec
                                                      , 1000.0 * 1000.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// square yottaparsec, defined as: square zettaparsec × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareYottaparsec = new (
                                                        "square yottaparsec"
                                                      , "Ypc²"
                                                      , SquareZettaparsec
                                                      , 1000.0 * 1000.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// square ronnaparsec, defined as: square yottaparsec × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareRonnaparsec = new (
                                                        "square ronnaparsec"
                                                      , "Rpc²"
                                                      , SquareYottaparsec
                                                      , 1000.0 * 1000.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// square quettaparsec, defined as: square ronnaparsec × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareQuettaparsec = new (
                                                         "square quettaparsec"
                                                       , "Qpc²"
                                                       , SquareRonnaparsec
                                                       , 1000.0 * 1000.0
                                                       , system: "Astronomical"
                                                        );
}
