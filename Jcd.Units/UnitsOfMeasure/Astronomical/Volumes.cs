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
   /// A(n) cubic light-year. Defined in terms of a(n) SI cubic meter.
   /// </summary>
   public static readonly Volume CubicLightYear = new (
                                                       "cubic light-year"
                                                     , "ly³"
                                                     , SI.Volumes.CubicMeter
                                                     , 9_460_730_472_580_800.0
                                                     * 9_460_730_472_580_800.0
                                                     * 9_460_730_472_580_800.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic light-second. Defined in terms of a(n) SI cubic meter.
   /// </summary>
   public static readonly Volume CubicLightSecond = new (
                                                         "cubic light-second"
                                                       , "ls³"
                                                       , SI.Volumes.CubicMeter
                                                       , 299_792_458.0 * 299_792_458.0 * 299_792_458.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic light-minute. Defined in terms of a(n) cubic light-second.
   /// </summary>
   public static readonly Volume CubicLightMinute = new (
                                                         "cubic light-minute"
                                                       , "lm³"
                                                       , CubicLightSecond
                                                       , 60.0 * 60.0 * 60.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic astronomical unit. Defined in terms of a(n) SI cubic kilometer.
   /// </summary>
   public static readonly Volume CubicAstronomicalUnit = new (
                                                              "cubic astronomical unit"
                                                            , "AU³"
                                                            , SI.Volumes.CubicKilometer
                                                            , 149597870.691 * 149597870.691 * 149597870.691
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) cubic light-hour. Defined in terms of a(n) cubic light-minute.
   /// </summary>
   public static readonly Volume CubicLightHour = new (
                                                       "cubic light-hour"
                                                     , "lh³"
                                                     , CubicLightMinute
                                                     , 60.0 * 60.0 * 60.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic light-day. Defined in terms of a(n) cubic light-hour.
   /// </summary>
   public static readonly Volume CubicLightDay = new ("cubic light-day", "ld³", CubicLightHour, 24.0 * 24.0 * 24.0, 0);

   /// <summary>
   /// A(n) cubic light-week. Defined in terms of a(n) cubic light-day.
   /// </summary>
   public static readonly Volume CubicLightWeek = new ("cubic light-week", "lw³", CubicLightDay, 7.0 * 7.0 * 7.0, 0);

   /// <summary>
   /// A(n) cubic parsec. Defined in terms of a(n) cubic light-year.
   /// </summary>
   public static readonly Volume CubicParsec = new (
                                                    "cubic parsec"
                                                  , "pc³"
                                                  , CubicLightYear
                                                  , 3.2615637769757 * 3.2615637769757 * 3.2615637769757
                                                  , 0
                                                   );

   /// <summary>
   /// A(n) cubic earth radius. Defined in terms of a(n) SI cubic kilometer.
   /// </summary>
   public static readonly Volume CubicEarthRadius = new (
                                                         "cubic earth radius"
                                                       , "R(⊕)³"
                                                       , SI.Volumes.CubicKilometer
                                                       , 6_371.0 * 6_371.0 * 6_371.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic jovian radius. Defined in terms of a(n) SI cubic kilometer.
   /// </summary>
   public static readonly Volume CubicJovianRadius = new (
                                                          "cubic jovian radius"
                                                        , "R(J)³"
                                                        , SI.Volumes.CubicKilometer
                                                        , 69_911.0 * 69_911.0 * 69_911.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) cubic lunar radius. Defined in terms of a(n) SI cubic kilometer.
   /// </summary>
   public static readonly Volume CubicLunarRadius = new (
                                                         "cubic lunar radius"
                                                       , "R(L)³"
                                                       , SI.Volumes.CubicKilometer
                                                       , 1_737.4 * 1_737.4 * 1_737.4
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic mars radius. Defined in terms of a(n) SI cubic kilometer.
   /// </summary>
   public static readonly Volume CubicMarsRadius = new (
                                                        "cubic mars radius"
                                                      , "R(♂)³"
                                                      , SI.Volumes.CubicKilometer
                                                      , 3_389.5 * 3_389.5 * 3_389.5
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic solar radius. Defined in terms of a(n) SI cubic kilometer.
   /// </summary>
   public static readonly Volume CubicSolarRadius = new (
                                                         "cubic solar radius"
                                                       , "R(☉)³"
                                                       , SI.Volumes.CubicKilometer
                                                       , 695_700.0 * 695_700.0 * 695_700.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic earth diameter. Defined in terms of a(n) cubic earth radius.
   /// </summary>
   public static readonly Volume CubicEarthDiameter = new (
                                                           "cubic earth diameter"
                                                         , "D(⊕)³"
                                                         , CubicEarthRadius
                                                         , 2.0 * 2.0 * 2.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) cubic dekalight-year. Defined in terms of a(n) cubic light-year.
   /// </summary>
   public static readonly Volume CubicDekalightYear = new (
                                                           "cubic dekalight-year"
                                                         , "daly³"
                                                         , CubicLightYear
                                                         , 10.0 * 10.0 * 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) cubic jovian diameter. Defined in terms of a(n) cubic jovian radius.
   /// </summary>
   public static readonly Volume CubicJovianDiameter = new (
                                                            "cubic jovian diameter"
                                                          , "D(J)³"
                                                          , CubicJovianRadius
                                                          , 2.0 * 2.0 * 2.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) cubic hectolight-year. Defined in terms of a(n) cubic dekalight-year.
   /// </summary>
   public static readonly Volume CubicHectolightYear = new (
                                                            "cubic hectolight-year"
                                                          , "hly³"
                                                          , CubicDekalightYear
                                                          , 10.0 * 10.0 * 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) cubic lunar diameter. Defined in terms of a(n) cubic lunar radius.
   /// </summary>
   public static readonly Volume CubicLunarDiameter = new (
                                                           "cubic lunar diameter"
                                                         , "D(L)³"
                                                         , CubicLunarRadius
                                                         , 2.0 * 2.0 * 2.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) cubic kilolight-year. Defined in terms of a(n) cubic hectolight-year.
   /// </summary>
   public static readonly Volume CubicKilolightYear = new (
                                                           "cubic kilolight-year"
                                                         , "kly³"
                                                         , CubicHectolightYear
                                                         , 10.0 * 10.0 * 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) cubic mars diameter. Defined in terms of a(n) cubic mars radius.
   /// </summary>
   public static readonly Volume CubicMarsDiameter = new (
                                                          "cubic mars diameter"
                                                        , "D(♂)³"
                                                        , CubicMarsRadius
                                                        , 2.0 * 2.0 * 2.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) cubic megalight-year. Defined in terms of a(n) cubic kilolight-year.
   /// </summary>
   public static readonly Volume CubicMegalightYear = new (
                                                           "cubic megalight-year"
                                                         , "Mly³"
                                                         , CubicKilolightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) cubic solar diameter. Defined in terms of a(n) cubic solar radius.
   /// </summary>
   public static readonly Volume CubicSolarDiameter = new (
                                                           "cubic solar diameter"
                                                         , "D(☉)³"
                                                         , CubicSolarRadius
                                                         , 2.0 * 2.0 * 2.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) cubic gigalight-year. Defined in terms of a(n) cubic megalight-year.
   /// </summary>
   public static readonly Volume CubicGigalightYear = new (
                                                           "cubic gigalight-year"
                                                         , "Gly³"
                                                         , CubicMegalightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) cubic earth circumference. Defined in terms of a(n) cubic earth diameter.
   /// </summary>
   public static readonly Volume CubicEarthCircumference = new (
                                                                "cubic earth circumference"
                                                              , "C(⊕)³"
                                                              , CubicEarthDiameter
                                                              , Math.PI * Math.PI * Math.PI
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) cubic teralight-year. Defined in terms of a(n) cubic gigalight-year.
   /// </summary>
   public static readonly Volume CubicTeralightYear = new (
                                                           "cubic teralight-year"
                                                         , "Tly³"
                                                         , CubicGigalightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) cubic jovian circumference. Defined in terms of a(n) cubic jovian diameter.
   /// </summary>
   public static readonly Volume CubicJovianCircumference = new (
                                                                 "cubic jovian circumference"
                                                               , "C(J)³"
                                                               , CubicJovianDiameter
                                                               , Math.PI * Math.PI * Math.PI
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) cubic petalight-year. Defined in terms of a(n) cubic teralight-year.
   /// </summary>
   public static readonly Volume CubicPetalightYear = new (
                                                           "cubic petalight-year"
                                                         , "Ply³"
                                                         , CubicTeralightYear
                                                         , 1000.0 * 1000.0 * 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) cubic lunar circumference. Defined in terms of a(n) cubic lunar diameter.
   /// </summary>
   public static readonly Volume CubicLunarCircumference = new (
                                                                "cubic lunar circumference"
                                                              , "C(L)³"
                                                              , CubicLunarDiameter
                                                              , Math.PI * Math.PI * Math.PI
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) cubic exalight-year. Defined in terms of a(n) cubic petalight-year.
   /// </summary>
   public static readonly Volume CubicExalightYear = new (
                                                          "cubic exalight-year"
                                                        , "Ely³"
                                                        , CubicPetalightYear
                                                        , 1000.0 * 1000.0 * 1000.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) cubic mars circumference. Defined in terms of a(n) cubic mars diameter.
   /// </summary>
   public static readonly Volume CubicMarsCircumference = new (
                                                               "cubic mars circumference"
                                                             , "C(♂)³"
                                                             , CubicMarsDiameter
                                                             , Math.PI * Math.PI * Math.PI
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) cubic zettalight-year. Defined in terms of a(n) cubic exalight-year.
   /// </summary>
   public static readonly Volume CubicZettalightYear = new (
                                                            "cubic zettalight-year"
                                                          , "Zly³"
                                                          , CubicExalightYear
                                                          , 1000.0 * 1000.0 * 1000.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) cubic solar circumference. Defined in terms of a(n) cubic solar diameter.
   /// </summary>
   public static readonly Volume CubicSolarCircumference = new (
                                                                "cubic solar circumference"
                                                              , "C(☉)³"
                                                              , CubicSolarDiameter
                                                              , Math.PI * Math.PI * Math.PI
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) cubic yottalight-year. Defined in terms of a(n) cubic zettalight-year.
   /// </summary>
   public static readonly Volume CubicYottalightYear = new (
                                                            "cubic yottalight-year"
                                                          , "Yly³"
                                                          , CubicZettalightYear
                                                          , 1000.0 * 1000.0 * 1000.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) cubic ronnalight-year. Defined in terms of a(n) cubic yottalight-year.
   /// </summary>
   public static readonly Volume CubicRonnalightYear = new (
                                                            "cubic ronnalight-year"
                                                          , "Rly³"
                                                          , CubicYottalightYear
                                                          , 1000.0 * 1000.0 * 1000.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) cubic quettalight-year. Defined in terms of a(n) cubic ronnalight-year.
   /// </summary>
   public static readonly Volume CubicQuettalightYear = new (
                                                             "cubic quettalight-year"
                                                           , "Qly³"
                                                           , CubicRonnalightYear
                                                           , 1000.0 * 1000.0 * 1000.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) cubic dekaparsec. Defined in terms of a(n) cubic parsec.
   /// </summary>
   public static readonly Volume CubicDekaparsec = new (
                                                        "cubic dekaparsec"
                                                      , "dapc³"
                                                      , CubicParsec
                                                      , 10.0 * 10.0 * 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic hectoparsec. Defined in terms of a(n) cubic dekaparsec.
   /// </summary>
   public static readonly Volume CubicHectoparsec = new (
                                                         "cubic hectoparsec"
                                                       , "hpc³"
                                                       , CubicDekaparsec
                                                       , 10.0 * 10.0 * 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic kiloparsec. Defined in terms of a(n) cubic hectoparsec.
   /// </summary>
   public static readonly Volume CubicKiloparsec = new (
                                                        "cubic kiloparsec"
                                                      , "kpc³"
                                                      , CubicHectoparsec
                                                      , 10.0 * 10.0 * 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic megaparsec. Defined in terms of a(n) cubic kiloparsec.
   /// </summary>
   public static readonly Volume CubicMegaparsec = new (
                                                        "cubic megaparsec"
                                                      , "Mpc³"
                                                      , CubicKiloparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic gigaparsec. Defined in terms of a(n) cubic megaparsec.
   /// </summary>
   public static readonly Volume CubicGigaparsec = new (
                                                        "cubic gigaparsec"
                                                      , "Gpc³"
                                                      , CubicMegaparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic teraparsec. Defined in terms of a(n) cubic gigaparsec.
   /// </summary>
   public static readonly Volume CubicTeraparsec = new (
                                                        "cubic teraparsec"
                                                      , "Tpc³"
                                                      , CubicGigaparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic petaparsec. Defined in terms of a(n) cubic teraparsec.
   /// </summary>
   public static readonly Volume CubicPetaparsec = new (
                                                        "cubic petaparsec"
                                                      , "Ppc³"
                                                      , CubicTeraparsec
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic exaparsec. Defined in terms of a(n) cubic petaparsec.
   /// </summary>
   public static readonly Volume CubicExaparsec = new (
                                                       "cubic exaparsec"
                                                     , "Epc³"
                                                     , CubicPetaparsec
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic zettaparsec. Defined in terms of a(n) cubic exaparsec.
   /// </summary>
   public static readonly Volume CubicZettaparsec = new (
                                                         "cubic zettaparsec"
                                                       , "Zpc³"
                                                       , CubicExaparsec
                                                       , 1000.0 * 1000.0 * 1000.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic yottaparsec. Defined in terms of a(n) cubic zettaparsec.
   /// </summary>
   public static readonly Volume CubicYottaparsec = new (
                                                         "cubic yottaparsec"
                                                       , "Ypc³"
                                                       , CubicZettaparsec
                                                       , 1000.0 * 1000.0 * 1000.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic ronnaparsec. Defined in terms of a(n) cubic yottaparsec.
   /// </summary>
   public static readonly Volume CubicRonnaparsec = new (
                                                         "cubic ronnaparsec"
                                                       , "Rpc³"
                                                       , CubicYottaparsec
                                                       , 1000.0 * 1000.0 * 1000.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic quettaparsec. Defined in terms of a(n) cubic ronnaparsec.
   /// </summary>
   public static readonly Volume CubicQuettaparsec = new (
                                                          "cubic quettaparsec"
                                                        , "Qpc³"
                                                        , CubicRonnaparsec
                                                        , 1000.0 * 1000.0 * 1000.0
                                                        , 0
                                                         );
}
