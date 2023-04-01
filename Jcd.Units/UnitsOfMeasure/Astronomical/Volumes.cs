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
public class Volumes : UnitOfMeasureEnumeration<Volumes, Volume>
{
   /// <summary>
   /// cubic light-year defined such that: SI cubic meter = ly³ × (9_460_730_472_580_800.0)*(9_460_730_472_580_800.0)*(9_460_730_472_580_800.0).
   /// </summary>
   public static readonly Volume CubicLightYear = new (
                                                       "cubic light-year"
                                                     , "ly³"
                                                     , SI.Volumes.CubicMeter
                                                     , 9_460_730_472_580_800.0
                                                     * 9_460_730_472_580_800.0
                                                     * 9_460_730_472_580_800.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// cubic light-second defined such that: SI cubic meter = ls³ × (299_792_458.0)*(299_792_458.0)*(299_792_458.0).
   /// </summary>
   public static readonly Volume CubicLightSecond = new (
                                                         "cubic light-second"
                                                       , "ls³"
                                                       , SI.Volumes.CubicMeter
                                                       , 299_792_458.0 * 299_792_458.0 * 299_792_458.0
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// cubic light-minute defined such that: cubic light-second = lm³ × (60.0)*(60.0)*(60.0).
   /// </summary>
   public static readonly Volume CubicLightMinute = new (
                                                         "cubic light-minute"
                                                       , "lm³"
                                                       , CubicLightSecond
                                                       , 60.0 * 60.0 * 60.0
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// cubic astronomical unit defined such that: SI cubic kilometer = AU³ × (149597870.691)*(149597870.691)*(149597870.691).
   /// </summary>
   public static readonly Volume CubicAstronomicalUnit = new (
                                                              "cubic astronomical unit"
                                                            , "AU³"
                                                            , SI.Volumes.CubicKilometer
                                                            , 149597870.691 * 149597870.691 * 149597870.691
                                                            , system: "Astronomical"
                                                             );

   /// <summary>
   /// cubic light-hour defined such that: cubic light-minute = lh³ × (60.0)*(60.0)*(60.0).
   /// </summary>
   public static readonly Volume CubicLightHour = new (
                                                       "cubic light-hour"
                                                     , "lh³"
                                                     , CubicLightMinute
                                                     , 60.0 * 60.0 * 60.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// cubic light-day defined such that: cubic light-hour = ld³ × (24.0)*(24.0)*(24.0).
   /// </summary>
   public static readonly Volume CubicLightDay = new (
                                                      "cubic light-day"
                                                    , "ld³"
                                                    , CubicLightHour
                                                    , 24.0 * 24.0 * 24.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// cubic light-week defined such that: cubic light-day = lw³ × (7.0)*(7.0)*(7.0).
   /// </summary>
   public static readonly Volume CubicLightWeek = new (
                                                       "cubic light-week"
                                                     , "lw³"
                                                     , CubicLightDay
                                                     , 7.0 * 7.0 * 7.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// cubic parsec defined such that: cubic light-year = pc³ × (3.2615637769757)*(3.2615637769757)*(3.2615637769757).
   /// </summary>
   public static readonly Volume CubicParsec = new (
                                                    "cubic parsec"
                                                  , "pc³"
                                                  , CubicLightYear
                                                  , 3.2615637769757 * 3.2615637769757 * 3.2615637769757
                                                  , system: "Astronomical"
                                                   );

   /// <summary>
   /// cubic earth radius defined such that: SI cubic kilometer = R(⊕)³ × (6_371.0)*(6_371.0)*(6_371.0).
   /// </summary>
   public static readonly Volume CubicEarthRadius = new (
                                                         "cubic earth radius"
                                                       , "R(⊕)³"
                                                       , SI.Volumes.CubicKilometer
                                                       , 6_371.0 * 6_371.0 * 6_371.0
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// cubic jovian radius defined such that: SI cubic kilometer = R(J)³ × (69_911.0)*(69_911.0)*(69_911.0).
   /// </summary>
   public static readonly Volume CubicJovianRadius = new (
                                                          "cubic jovian radius"
                                                        , "R(J)³"
                                                        , SI.Volumes.CubicKilometer
                                                        , 69_911.0 * 69_911.0 * 69_911.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// cubic lunar radius defined such that: SI cubic kilometer = R(L)³ × (1_737.4)*(1_737.4)*(1_737.4).
   /// </summary>
   public static readonly Volume CubicLunarRadius = new (
                                                         "cubic lunar radius"
                                                       , "R(L)³"
                                                       , SI.Volumes.CubicKilometer
                                                       , 1_737.4 * 1_737.4 * 1_737.4
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// cubic mars radius defined such that: SI cubic kilometer = R(♂)³ × (3_389.5)*(3_389.5)*(3_389.5).
   /// </summary>
   public static readonly Volume CubicMarsRadius = new (
                                                        "cubic mars radius"
                                                      , "R(♂)³"
                                                      , SI.Volumes.CubicKilometer
                                                      , 3_389.5 * 3_389.5 * 3_389.5
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// cubic solar radius defined such that: SI cubic kilometer = R(☉)³ × (695_700.0)*(695_700.0)*(695_700.0).
   /// </summary>
   public static readonly Volume CubicSolarRadius = new (
                                                         "cubic solar radius"
                                                       , "R(☉)³"
                                                       , SI.Volumes.CubicKilometer
                                                       , 695_700.0 * 695_700.0 * 695_700.0
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// cubic earth diameter defined such that: cubic earth radius = D(⊕)³ × (2.0)*(2.0)*(2.0).
   /// </summary>
   public static readonly Volume CubicEarthDiameter = new (
                                                           "cubic earth diameter"
                                                         , "D(⊕)³"
                                                         , CubicEarthRadius
                                                         , 2.0 * 2.0 * 2.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// cubic dekalight-year defined such that: cubic light-year = daly³ × (10.0)*(10.0)*(10.0).
   /// </summary>
   public static readonly Volume CubicDekalightYear = new (
                                                           "cubic dekalight-year"
                                                         , "daly³"
                                                         , CubicLightYear
                                                         , 10.0 * 10.0 * 10.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// cubic jovian diameter defined such that: cubic jovian radius = D(J)³ × (2.0)*(2.0)*(2.0).
   /// </summary>
   public static readonly Volume CubicJovianDiameter = new (
                                                            "cubic jovian diameter"
                                                          , "D(J)³"
                                                          , CubicJovianRadius
                                                          , 2.0 * 2.0 * 2.0
                                                          , system: "Astronomical"
                                                           );

   /// <summary>
   /// cubic hectolight-year defined such that: cubic dekalight-year = hly³ × (10.0)*(10.0)*(10.0).
   /// </summary>
   public static readonly Volume CubicHectolightYear = new (
                                                            "cubic hectolight-year"
                                                          , "hly³"
                                                          , CubicDekalightYear
                                                          , 10.0 * 10.0 * 10.0
                                                          , system: "Astronomical"
                                                           );

   /// <summary>
   /// cubic lunar diameter defined such that: cubic lunar radius = D(L)³ × (2.0)*(2.0)*(2.0).
   /// </summary>
   public static readonly Volume CubicLunarDiameter = new (
                                                           "cubic lunar diameter"
                                                         , "D(L)³"
                                                         , CubicLunarRadius
                                                         , 2.0 * 2.0 * 2.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// cubic kilolight-year defined such that: cubic hectolight-year = kly³ × (10.0)*(10.0)*(10.0).
   /// </summary>
   public static readonly Volume CubicKilolightYear = new (
                                                           "cubic kilolight-year"
                                                         , "kly³"
                                                         , CubicHectolightYear
                                                         , 10.0 * 10.0 * 10.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// cubic mars diameter defined such that: cubic mars radius = D(♂)³ × (2.0)*(2.0)*(2.0).
   /// </summary>
   public static readonly Volume CubicMarsDiameter = new (
                                                          "cubic mars diameter"
                                                        , "D(♂)³"
                                                        , CubicMarsRadius
                                                        , 2.0 * 2.0 * 2.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// cubic megalight-year defined such that: cubic kilolight-year = Mly³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicMegalightYear = new (
                                                           "cubic megalight-year"
                                                         , "Mly³"
                                                         , CubicKilolightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// cubic solar diameter defined such that: cubic solar radius = D(☉)³ × (2.0)*(2.0)*(2.0).
   /// </summary>
   public static readonly Volume CubicSolarDiameter = new (
                                                           "cubic solar diameter"
                                                         , "D(☉)³"
                                                         , CubicSolarRadius
                                                         , 2.0 * 2.0 * 2.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// cubic gigalight-year defined such that: cubic megalight-year = Gly³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicGigalightYear = new (
                                                           "cubic gigalight-year"
                                                         , "Gly³"
                                                         , CubicMegalightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// cubic earth circumference defined such that: cubic earth diameter = C(⊕)³ × (Math.PI)*(Math.PI)*(Math.PI).
   /// </summary>
   public static readonly Volume CubicEarthCircumference = new (
                                                                "cubic earth circumference"
                                                              , "C(⊕)³"
                                                              , CubicEarthDiameter
                                                              , Math.PI * Math.PI * Math.PI
                                                              , system: "Astronomical"
                                                               );

   /// <summary>
   /// cubic teralight-year defined such that: cubic gigalight-year = Tly³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicTeralightYear = new (
                                                           "cubic teralight-year"
                                                         , "Tly³"
                                                         , CubicGigalightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// cubic jovian circumference defined such that: cubic jovian diameter = C(J)³ × (Math.PI)*(Math.PI)*(Math.PI).
   /// </summary>
   public static readonly Volume CubicJovianCircumference = new (
                                                                 "cubic jovian circumference"
                                                               , "C(J)³"
                                                               , CubicJovianDiameter
                                                               , Math.PI * Math.PI * Math.PI
                                                               , system: "Astronomical"
                                                                );

   /// <summary>
   /// cubic petalight-year defined such that: cubic teralight-year = Ply³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicPetalightYear = new (
                                                           "cubic petalight-year"
                                                         , "Ply³"
                                                         , CubicTeralightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// cubic lunar circumference defined such that: cubic lunar diameter = C(L)³ × (Math.PI)*(Math.PI)*(Math.PI).
   /// </summary>
   public static readonly Volume CubicLunarCircumference = new (
                                                                "cubic lunar circumference"
                                                              , "C(L)³"
                                                              , CubicLunarDiameter
                                                              , Math.PI * Math.PI * Math.PI
                                                              , system: "Astronomical"
                                                               );

   /// <summary>
   /// cubic exalight-year defined such that: cubic petalight-year = Ely³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicExalightYear = new (
                                                          "cubic exalight-year"
                                                        , "Ely³"
                                                        , CubicPetalightYear
                                                        , 1000.0 * 1000.0 * 1000.0
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// cubic mars circumference defined such that: cubic mars diameter = C(♂)³ × (Math.PI)*(Math.PI)*(Math.PI).
   /// </summary>
   public static readonly Volume CubicMarsCircumference = new (
                                                               "cubic mars circumference"
                                                             , "C(♂)³"
                                                             , CubicMarsDiameter
                                                             , Math.PI * Math.PI * Math.PI
                                                             , system: "Astronomical"
                                                              );

   /// <summary>
   /// cubic zettalight-year defined such that: cubic exalight-year = Zly³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicZettalightYear = new (
                                                            "cubic zettalight-year"
                                                          , "Zly³"
                                                          , CubicExalightYear
                                                          , 1000.0 * 1000.0 * 1000.0
                                                          , system: "Astronomical"
                                                           );

   /// <summary>
   /// cubic solar circumference defined such that: cubic solar diameter = C(☉)³ × (Math.PI)*(Math.PI)*(Math.PI).
   /// </summary>
   public static readonly Volume CubicSolarCircumference = new (
                                                                "cubic solar circumference"
                                                              , "C(☉)³"
                                                              , CubicSolarDiameter
                                                              , Math.PI * Math.PI * Math.PI
                                                              , system: "Astronomical"
                                                               );

   /// <summary>
   /// cubic yottalight-year defined such that: cubic zettalight-year = Yly³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicYottalightYear = new (
                                                            "cubic yottalight-year"
                                                          , "Yly³"
                                                          , CubicZettalightYear
                                                          , 1000.0 * 1000.0 * 1000.0
                                                          , system: "Astronomical"
                                                           );

   /// <summary>
   /// cubic ronnalight-year defined such that: cubic yottalight-year = Rly³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicRonnalightYear = new (
                                                            "cubic ronnalight-year"
                                                          , "Rly³"
                                                          , CubicYottalightYear
                                                          , 1000.0 * 1000.0 * 1000.0
                                                          , system: "Astronomical"
                                                           );

   /// <summary>
   /// cubic quettalight-year defined such that: cubic ronnalight-year = Qly³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicQuettalightYear = new (
                                                             "cubic quettalight-year"
                                                           , "Qly³"
                                                           , CubicRonnalightYear
                                                           , 1000.0 * 1000.0 * 1000.0
                                                           , system: "Astronomical"
                                                            );

   /// <summary>
   /// cubic dekaparsec defined such that: cubic parsec = dapc³ × (10.0)*(10.0)*(10.0).
   /// </summary>
   public static readonly Volume CubicDekaparsec = new (
                                                        "cubic dekaparsec"
                                                      , "dapc³"
                                                      , CubicParsec
                                                      , 10.0 * 10.0 * 10.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// cubic hectoparsec defined such that: cubic dekaparsec = hpc³ × (10.0)*(10.0)*(10.0).
   /// </summary>
   public static readonly Volume CubicHectoparsec = new (
                                                         "cubic hectoparsec"
                                                       , "hpc³"
                                                       , CubicDekaparsec
                                                       , 10.0 * 10.0 * 10.0
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// cubic kiloparsec defined such that: cubic hectoparsec = kpc³ × (10.0)*(10.0)*(10.0).
   /// </summary>
   public static readonly Volume CubicKiloparsec = new (
                                                        "cubic kiloparsec"
                                                      , "kpc³"
                                                      , CubicHectoparsec
                                                      , 10.0 * 10.0 * 10.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// cubic megaparsec defined such that: cubic kiloparsec = Mpc³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicMegaparsec = new (
                                                        "cubic megaparsec"
                                                      , "Mpc³"
                                                      , CubicKiloparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// cubic gigaparsec defined such that: cubic megaparsec = Gpc³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicGigaparsec = new (
                                                        "cubic gigaparsec"
                                                      , "Gpc³"
                                                      , CubicMegaparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// cubic teraparsec defined such that: cubic gigaparsec = Tpc³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicTeraparsec = new (
                                                        "cubic teraparsec"
                                                      , "Tpc³"
                                                      , CubicGigaparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// cubic petaparsec defined such that: cubic teraparsec = Ppc³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicPetaparsec = new (
                                                        "cubic petaparsec"
                                                      , "Ppc³"
                                                      , CubicTeraparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// cubic exaparsec defined such that: cubic petaparsec = Epc³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicExaparsec = new (
                                                       "cubic exaparsec"
                                                     , "Epc³"
                                                     , CubicPetaparsec
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// cubic zettaparsec defined such that: cubic exaparsec = Zpc³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicZettaparsec = new (
                                                         "cubic zettaparsec"
                                                       , "Zpc³"
                                                       , CubicExaparsec
                                                       , 1000.0 * 1000.0 * 1000.0
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// cubic yottaparsec defined such that: cubic zettaparsec = Ypc³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicYottaparsec = new (
                                                         "cubic yottaparsec"
                                                       , "Ypc³"
                                                       , CubicZettaparsec
                                                       , 1000.0 * 1000.0 * 1000.0
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// cubic ronnaparsec defined such that: cubic yottaparsec = Rpc³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicRonnaparsec = new (
                                                         "cubic ronnaparsec"
                                                       , "Rpc³"
                                                       , CubicYottaparsec
                                                       , 1000.0 * 1000.0 * 1000.0
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// cubic quettaparsec defined such that: cubic ronnaparsec = Qpc³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicQuettaparsec = new (
                                                          "cubic quettaparsec"
                                                        , "Qpc³"
                                                        , CubicRonnaparsec
                                                        , 1000.0 * 1000.0 * 1000.0
                                                        , system: "Astronomical"
                                                         );
}
