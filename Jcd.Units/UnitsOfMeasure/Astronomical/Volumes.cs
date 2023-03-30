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
   /// cubic light-year, defined as: SI cubic meter × (9_460_730_472_580_800.0)*(9_460_730_472_580_800.0)*(9_460_730_472_580_800.0)
   /// </summary>
   public static readonly Volume CubicLightYear = new (
                                                       "cubic light-year"
                                                     , "ly³"
                                                     , SI.Volumes.CubicMeter
                                                     , 9_460_730_472_580_800.0
                                                     * 9_460_730_472_580_800.0
                                                     * 9_460_730_472_580_800.0
                                                      );

   /// <summary>
   /// cubic light-second, defined as: SI cubic meter × (299_792_458.0)*(299_792_458.0)*(299_792_458.0)
   /// </summary>
   public static readonly Volume CubicLightSecond = new (
                                                         "cubic light-second"
                                                       , "ls³"
                                                       , SI.Volumes.CubicMeter
                                                       , 299_792_458.0 * 299_792_458.0 * 299_792_458.0
                                                        );

   /// <summary>
   /// cubic light-minute, defined as: cubic light-second × (60.0)*(60.0)*(60.0)
   /// </summary>
   public static readonly Volume CubicLightMinute = new (
                                                         "cubic light-minute"
                                                       , "lm³"
                                                       , CubicLightSecond
                                                       , 60.0 * 60.0 * 60.0
                                                        );

   /// <summary>
   /// cubic astronomical unit, defined as: SI cubic kilometer × (149597870.691)*(149597870.691)*(149597870.691)
   /// </summary>
   public static readonly Volume CubicAstronomicalUnit = new (
                                                              "cubic astronomical unit"
                                                            , "AU³"
                                                            , SI.Volumes.CubicKilometer
                                                            , 149597870.691 * 149597870.691 * 149597870.691
                                                             );

   /// <summary>
   /// cubic light-hour, defined as: cubic light-minute × (60.0)*(60.0)*(60.0)
   /// </summary>
   public static readonly Volume CubicLightHour = new ("cubic light-hour", "lh³", CubicLightMinute, 60.0 * 60.0 * 60.0);

   /// <summary>
   /// cubic light-day, defined as: cubic light-hour × (24.0)*(24.0)*(24.0)
   /// </summary>
   public static readonly Volume CubicLightDay = new ("cubic light-day", "ld³", CubicLightHour, 24.0 * 24.0 * 24.0);

   /// <summary>
   /// cubic light-week, defined as: cubic light-day × (7.0)*(7.0)*(7.0)
   /// </summary>
   public static readonly Volume CubicLightWeek = new ("cubic light-week", "lw³", CubicLightDay, 7.0 * 7.0 * 7.0);

   /// <summary>
   /// cubic parsec, defined as: cubic light-year × (3.2615637769757)*(3.2615637769757)*(3.2615637769757)
   /// </summary>
   public static readonly Volume CubicParsec = new (
                                                    "cubic parsec"
                                                  , "pc³"
                                                  , CubicLightYear
                                                  , 3.2615637769757 * 3.2615637769757 * 3.2615637769757
                                                   );

   /// <summary>
   /// cubic earth radius, defined as: SI cubic kilometer × (6_371.0)*(6_371.0)*(6_371.0)
   /// </summary>
   public static readonly Volume CubicEarthRadius = new (
                                                         "cubic earth radius"
                                                       , "R(⊕)³"
                                                       , SI.Volumes.CubicKilometer
                                                       , 6_371.0 * 6_371.0 * 6_371.0
                                                        );

   /// <summary>
   /// cubic jovian radius, defined as: SI cubic kilometer × (69_911.0)*(69_911.0)*(69_911.0)
   /// </summary>
   public static readonly Volume CubicJovianRadius = new (
                                                          "cubic jovian radius"
                                                        , "R(J)³"
                                                        , SI.Volumes.CubicKilometer
                                                        , 69_911.0 * 69_911.0 * 69_911.0
                                                         );

   /// <summary>
   /// cubic lunar radius, defined as: SI cubic kilometer × (1_737.4)*(1_737.4)*(1_737.4)
   /// </summary>
   public static readonly Volume CubicLunarRadius = new (
                                                         "cubic lunar radius"
                                                       , "R(L)³"
                                                       , SI.Volumes.CubicKilometer
                                                       , 1_737.4 * 1_737.4 * 1_737.4
                                                        );

   /// <summary>
   /// cubic mars radius, defined as: SI cubic kilometer × (3_389.5)*(3_389.5)*(3_389.5)
   /// </summary>
   public static readonly Volume CubicMarsRadius = new (
                                                        "cubic mars radius"
                                                      , "R(♂)³"
                                                      , SI.Volumes.CubicKilometer
                                                      , 3_389.5 * 3_389.5 * 3_389.5
                                                       );

   /// <summary>
   /// cubic solar radius, defined as: SI cubic kilometer × (695_700.0)*(695_700.0)*(695_700.0)
   /// </summary>
   public static readonly Volume CubicSolarRadius = new (
                                                         "cubic solar radius"
                                                       , "R(☉)³"
                                                       , SI.Volumes.CubicKilometer
                                                       , 695_700.0 * 695_700.0 * 695_700.0
                                                        );

   /// <summary>
   /// cubic earth diameter, defined as: cubic earth radius × (2.0)*(2.0)*(2.0)
   /// </summary>
   public static readonly Volume CubicEarthDiameter = new (
                                                           "cubic earth diameter"
                                                         , "D(⊕)³"
                                                         , CubicEarthRadius
                                                         , 2.0 * 2.0 * 2.0
                                                          );

   /// <summary>
   /// cubic dekalight-year, defined as: cubic light-year × (10.0)*(10.0)*(10.0)
   /// </summary>
   public static readonly Volume CubicDekalightYear = new (
                                                           "cubic dekalight-year"
                                                         , "daly³"
                                                         , CubicLightYear
                                                         , 10.0 * 10.0 * 10.0
                                                          );

   /// <summary>
   /// cubic jovian diameter, defined as: cubic jovian radius × (2.0)*(2.0)*(2.0)
   /// </summary>
   public static readonly Volume CubicJovianDiameter = new (
                                                            "cubic jovian diameter"
                                                          , "D(J)³"
                                                          , CubicJovianRadius
                                                          , 2.0 * 2.0 * 2.0
                                                           );

   /// <summary>
   /// cubic hectolight-year, defined as: cubic dekalight-year × (10.0)*(10.0)*(10.0)
   /// </summary>
   public static readonly Volume CubicHectolightYear = new (
                                                            "cubic hectolight-year"
                                                          , "hly³"
                                                          , CubicDekalightYear
                                                          , 10.0 * 10.0 * 10.0
                                                           );

   /// <summary>
   /// cubic lunar diameter, defined as: cubic lunar radius × (2.0)*(2.0)*(2.0)
   /// </summary>
   public static readonly Volume CubicLunarDiameter = new (
                                                           "cubic lunar diameter"
                                                         , "D(L)³"
                                                         , CubicLunarRadius
                                                         , 2.0 * 2.0 * 2.0
                                                          );

   /// <summary>
   /// cubic kilolight-year, defined as: cubic hectolight-year × (10.0)*(10.0)*(10.0)
   /// </summary>
   public static readonly Volume CubicKilolightYear = new (
                                                           "cubic kilolight-year"
                                                         , "kly³"
                                                         , CubicHectolightYear
                                                         , 10.0 * 10.0 * 10.0
                                                          );

   /// <summary>
   /// cubic mars diameter, defined as: cubic mars radius × (2.0)*(2.0)*(2.0)
   /// </summary>
   public static readonly Volume CubicMarsDiameter = new (
                                                          "cubic mars diameter"
                                                        , "D(♂)³"
                                                        , CubicMarsRadius
                                                        , 2.0 * 2.0 * 2.0
                                                         );

   /// <summary>
   /// cubic megalight-year, defined as: cubic kilolight-year × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicMegalightYear = new (
                                                           "cubic megalight-year"
                                                         , "Mly³"
                                                         , CubicKilolightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                          );

   /// <summary>
   /// cubic solar diameter, defined as: cubic solar radius × (2.0)*(2.0)*(2.0)
   /// </summary>
   public static readonly Volume CubicSolarDiameter = new (
                                                           "cubic solar diameter"
                                                         , "D(☉)³"
                                                         , CubicSolarRadius
                                                         , 2.0 * 2.0 * 2.0
                                                          );

   /// <summary>
   /// cubic gigalight-year, defined as: cubic megalight-year × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicGigalightYear = new (
                                                           "cubic gigalight-year"
                                                         , "Gly³"
                                                         , CubicMegalightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                          );

   /// <summary>
   /// cubic earth circumference, defined as: cubic earth diameter × (Math.PI)*(Math.PI)*(Math.PI)
   /// </summary>
   public static readonly Volume CubicEarthCircumference = new (
                                                                "cubic earth circumference"
                                                              , "C(⊕)³"
                                                              , CubicEarthDiameter
                                                              , Math.PI * Math.PI * Math.PI
                                                               );

   /// <summary>
   /// cubic teralight-year, defined as: cubic gigalight-year × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicTeralightYear = new (
                                                           "cubic teralight-year"
                                                         , "Tly³"
                                                         , CubicGigalightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                          );

   /// <summary>
   /// cubic jovian circumference, defined as: cubic jovian diameter × (Math.PI)*(Math.PI)*(Math.PI)
   /// </summary>
   public static readonly Volume CubicJovianCircumference = new (
                                                                 "cubic jovian circumference"
                                                               , "C(J)³"
                                                               , CubicJovianDiameter
                                                               , Math.PI * Math.PI * Math.PI
                                                                );

   /// <summary>
   /// cubic petalight-year, defined as: cubic teralight-year × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicPetalightYear = new (
                                                           "cubic petalight-year"
                                                         , "Ply³"
                                                         , CubicTeralightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                          );

   /// <summary>
   /// cubic lunar circumference, defined as: cubic lunar diameter × (Math.PI)*(Math.PI)*(Math.PI)
   /// </summary>
   public static readonly Volume CubicLunarCircumference = new (
                                                                "cubic lunar circumference"
                                                              , "C(L)³"
                                                              , CubicLunarDiameter
                                                              , Math.PI * Math.PI * Math.PI
                                                               );

   /// <summary>
   /// cubic exalight-year, defined as: cubic petalight-year × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicExalightYear = new (
                                                          "cubic exalight-year"
                                                        , "Ely³"
                                                        , CubicPetalightYear
                                                        , 1000.0 * 1000.0 * 1000.0
                                                         );

   /// <summary>
   /// cubic mars circumference, defined as: cubic mars diameter × (Math.PI)*(Math.PI)*(Math.PI)
   /// </summary>
   public static readonly Volume CubicMarsCircumference = new (
                                                               "cubic mars circumference"
                                                             , "C(♂)³"
                                                             , CubicMarsDiameter
                                                             , Math.PI * Math.PI * Math.PI
                                                              );

   /// <summary>
   /// cubic zettalight-year, defined as: cubic exalight-year × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicZettalightYear = new (
                                                            "cubic zettalight-year"
                                                          , "Zly³"
                                                          , CubicExalightYear
                                                          , 1000.0 * 1000.0 * 1000.0
                                                           );

   /// <summary>
   /// cubic solar circumference, defined as: cubic solar diameter × (Math.PI)*(Math.PI)*(Math.PI)
   /// </summary>
   public static readonly Volume CubicSolarCircumference = new (
                                                                "cubic solar circumference"
                                                              , "C(☉)³"
                                                              , CubicSolarDiameter
                                                              , Math.PI * Math.PI * Math.PI
                                                               );

   /// <summary>
   /// cubic yottalight-year, defined as: cubic zettalight-year × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicYottalightYear = new (
                                                            "cubic yottalight-year"
                                                          , "Yly³"
                                                          , CubicZettalightYear
                                                          , 1000.0 * 1000.0 * 1000.0
                                                           );

   /// <summary>
   /// cubic Planck-length, defined as: SI cubic meter × (1.616255E-35)*(1.616255E-35)*(1.616255E-35)
   /// </summary>
   public static readonly Volume CubicPlanckLength = new (
                                                          "cubic Planck-length"
                                                        , "ℓₚ³"
                                                        , SI.Volumes.CubicMeter
                                                        , 1.616255E-35 * 1.616255E-35 * 1.616255E-35
                                                         );

   /// <summary>
   /// cubic ronnalight-year, defined as: cubic yottalight-year × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicRonnalightYear = new (
                                                            "cubic ronnalight-year"
                                                          , "Rly³"
                                                          , CubicYottalightYear
                                                          , 1000.0 * 1000.0 * 1000.0
                                                           );

   /// <summary>
   /// cubic quettalight-year, defined as: cubic ronnalight-year × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicQuettalightYear = new (
                                                             "cubic quettalight-year"
                                                           , "Qly³"
                                                           , CubicRonnalightYear
                                                           , 1000.0 * 1000.0 * 1000.0
                                                            );

   /// <summary>
   /// cubic dekaparsec, defined as: cubic parsec × (10.0)*(10.0)*(10.0)
   /// </summary>
   public static readonly Volume CubicDekaparsec = new ("cubic dekaparsec", "dapc³", CubicParsec, 10.0 * 10.0 * 10.0);

   /// <summary>
   /// cubic hectoparsec, defined as: cubic dekaparsec × (10.0)*(10.0)*(10.0)
   /// </summary>
   public static readonly Volume CubicHectoparsec = new (
                                                         "cubic hectoparsec"
                                                       , "hpc³"
                                                       , CubicDekaparsec
                                                       , 10.0 * 10.0 * 10.0
                                                        );

   /// <summary>
   /// cubic kiloparsec, defined as: cubic hectoparsec × (10.0)*(10.0)*(10.0)
   /// </summary>
   public static readonly Volume CubicKiloparsec = new (
                                                        "cubic kiloparsec"
                                                      , "kpc³"
                                                      , CubicHectoparsec
                                                      , 10.0 * 10.0 * 10.0
                                                       );

   /// <summary>
   /// cubic megaparsec, defined as: cubic kiloparsec × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicMegaparsec = new (
                                                        "cubic megaparsec"
                                                      , "Mpc³"
                                                      , CubicKiloparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                       );

   /// <summary>
   /// cubic gigaparsec, defined as: cubic megaparsec × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicGigaparsec = new (
                                                        "cubic gigaparsec"
                                                      , "Gpc³"
                                                      , CubicMegaparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                       );

   /// <summary>
   /// cubic teraparsec, defined as: cubic gigaparsec × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicTeraparsec = new (
                                                        "cubic teraparsec"
                                                      , "Tpc³"
                                                      , CubicGigaparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                       );

   /// <summary>
   /// cubic petaparsec, defined as: cubic teraparsec × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicPetaparsec = new (
                                                        "cubic petaparsec"
                                                      , "Ppc³"
                                                      , CubicTeraparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                       );

   /// <summary>
   /// cubic exaparsec, defined as: cubic petaparsec × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicExaparsec = new (
                                                       "cubic exaparsec"
                                                     , "Epc³"
                                                     , CubicPetaparsec
                                                     , 1000.0 * 1000.0 * 1000.0
                                                      );

   /// <summary>
   /// cubic zettaparsec, defined as: cubic exaparsec × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicZettaparsec = new (
                                                         "cubic zettaparsec"
                                                       , "Zpc³"
                                                       , CubicExaparsec
                                                       , 1000.0 * 1000.0 * 1000.0
                                                        );

   /// <summary>
   /// cubic yottaparsec, defined as: cubic zettaparsec × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicYottaparsec = new (
                                                         "cubic yottaparsec"
                                                       , "Ypc³"
                                                       , CubicZettaparsec
                                                       , 1000.0 * 1000.0 * 1000.0
                                                        );

   /// <summary>
   /// cubic ronnaparsec, defined as: cubic yottaparsec × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicRonnaparsec = new (
                                                         "cubic ronnaparsec"
                                                       , "Rpc³"
                                                       , CubicYottaparsec
                                                       , 1000.0 * 1000.0 * 1000.0
                                                        );

   /// <summary>
   /// cubic quettaparsec, defined as: cubic ronnaparsec × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicQuettaparsec = new (
                                                          "cubic quettaparsec"
                                                        , "Qpc³"
                                                        , CubicRonnaparsec
                                                        , 1000.0 * 1000.0 * 1000.0
                                                         );
}
