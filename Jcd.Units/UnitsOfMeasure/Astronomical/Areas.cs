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
   /// A(n) square light-year. Defined in terms of a(n) SI square meter.
   /// </summary>
   public static readonly Area SquareLightYear = new (
                                                      "square light-year"
                                                    , "ly^2"
                                                    , SI.Areas.SquareMeter
                                                    , 9_460_730_472_580_800.0 * 9_460_730_472_580_800.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square light-second. Defined in terms of a(n) SI square meter.
   /// </summary>
   public static readonly Area SquareLightSecond = new (
                                                        "square light-second"
                                                      , "ls^2"
                                                      , SI.Areas.SquareMeter
                                                      , 299_792_458.0 * 299_792_458.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square light-minute. Defined in terms of a(n) square light-second.
   /// </summary>
   public static readonly Area SquareLightMinute = new (
                                                        "square light-minute"
                                                      , "lm^2"
                                                      , SquareLightSecond
                                                      , 60.0 * 60.0
                                                      , 0
                                                       );

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
   /// A(n) square light-hour. Defined in terms of a(n) square light-minute.
   /// </summary>
   public static readonly Area SquareLightHour = new ("square light-hour", "lh^2", SquareLightMinute, 60.0 * 60.0, 0);

   /// <summary>
   /// A(n) square light-day. Defined in terms of a(n) square light-hour.
   /// </summary>
   public static readonly Area SquareLightDay = new ("square light-day", "ld^2", SquareLightHour, 24.0 * 24.0, 0);

   /// <summary>
   /// A(n) square light-week. Defined in terms of a(n) square light-day.
   /// </summary>
   public static readonly Area SquareLightWeek = new ("square light-week", "lw^2", SquareLightDay, 7.0 * 7.0, 0);

   /// <summary>
   /// A(n) square parsec. Defined in terms of a(n) square light-year.
   /// </summary>
   public static readonly Area SquareParsec = new (
                                                   "square parsec"
                                                 , "pc^2"
                                                 , SquareLightYear
                                                 , 3.2615637769757 * 3.2615637769757
                                                 , 0
                                                  );

   /// <summary>
   /// A(n) square earth radius. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareEarthRadius = new (
                                                        "square earth radius"
                                                      , "R(⊕)^2"
                                                      , SI.Areas.SquareKilometer
                                                      , 6_371.0 * 6_371.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square jovian radius. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareJovianRadius = new (
                                                         "square jovian radius"
                                                       , "R(J)^2"
                                                       , SI.Areas.SquareKilometer
                                                       , 69_911.0 * 69_911.0
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
   /// A(n) square solar radius. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareSolarRadius = new (
                                                        "square solar radius"
                                                      , "R(☉)^2"
                                                      , SI.Areas.SquareKilometer
                                                      , 695_700.0 * 695_700.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square earth diameter. Defined in terms of a(n) square earth radius.
   /// </summary>
   public static readonly Area SquareEarthDiameter = new (
                                                          "square earth diameter"
                                                        , "D(⊕)^2"
                                                        , SquareEarthRadius
                                                        , 2.0 * 2.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square dekalight-year. Defined in terms of a(n) square light-year.
   /// </summary>
   public static readonly Area SquareDekalightYear = new (
                                                          "square dekalight-year"
                                                        , "daly^2"
                                                        , SquareLightYear
                                                        , 10.0 * 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square jovian diameter. Defined in terms of a(n) square jovian radius.
   /// </summary>
   public static readonly Area SquareJovianDiameter = new (
                                                           "square jovian diameter"
                                                         , "D(J)^2"
                                                         , SquareJovianRadius
                                                         , 2.0 * 2.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) square hectolight-year. Defined in terms of a(n) square dekalight-year.
   /// </summary>
   public static readonly Area SquareHectolightYear = new (
                                                           "square hectolight-year"
                                                         , "hly^2"
                                                         , SquareDekalightYear
                                                         , 10.0 * 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) square lunar diameter. Defined in terms of a(n) square lunar radius.
   /// </summary>
   public static readonly Area SquareLunarDiameter = new (
                                                          "square lunar diameter"
                                                        , "D(L)^2"
                                                        , SquareLunarRadius
                                                        , 2.0 * 2.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square kilolight-year. Defined in terms of a(n) square hectolight-year.
   /// </summary>
   public static readonly Area SquareKilolightYear = new (
                                                          "square kilolight-year"
                                                        , "kly^2"
                                                        , SquareHectolightYear
                                                        , 10.0 * 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square mars diameter. Defined in terms of a(n) square mars radius.
   /// </summary>
   public static readonly Area SquareMarsDiameter = new (
                                                         "square mars diameter"
                                                       , "D(♂)^2"
                                                       , SquareMarsRadius
                                                       , 2.0 * 2.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) square megalight-year. Defined in terms of a(n) square kilolight-year.
   /// </summary>
   public static readonly Area SquareMegalightYear = new (
                                                          "square megalight-year"
                                                        , "Mly^2"
                                                        , SquareKilolightYear
                                                        , 1000.0 * 1000.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square solar diameter. Defined in terms of a(n) square solar radius.
   /// </summary>
   public static readonly Area SquareSolarDiameter = new (
                                                          "square solar diameter"
                                                        , "D(☉)^2"
                                                        , SquareSolarRadius
                                                        , 2.0 * 2.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square gigalight-year. Defined in terms of a(n) square megalight-year.
   /// </summary>
   public static readonly Area SquareGigalightYear = new (
                                                          "square gigalight-year"
                                                        , "Gly^2"
                                                        , SquareMegalightYear
                                                        , 1000.0 * 1000.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square earth circumference. Defined in terms of a(n) square earth diameter.
   /// </summary>
   public static readonly Area SquareEarthCircumference = new (
                                                               "square earth circumference"
                                                             , "C(⊕)^2"
                                                             , SquareEarthDiameter
                                                             , Math.PI * Math.PI
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) square teralight-year. Defined in terms of a(n) square gigalight-year.
   /// </summary>
   public static readonly Area SquareTeralightYear = new (
                                                          "square teralight-year"
                                                        , "Tly^2"
                                                        , SquareGigalightYear
                                                        , 1000.0 * 1000.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square jovian circumference. Defined in terms of a(n) square jovian diameter.
   /// </summary>
   public static readonly Area SquareJovianCircumference = new (
                                                                "square jovian circumference"
                                                              , "C(J)^2"
                                                              , SquareJovianDiameter
                                                              , Math.PI * Math.PI
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) square petalight-year. Defined in terms of a(n) square teralight-year.
   /// </summary>
   public static readonly Area SquarePetalightYear = new (
                                                          "square petalight-year"
                                                        , "Ply^2"
                                                        , SquareTeralightYear
                                                        , 1000.0 * 1000.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square lunar circumference. Defined in terms of a(n) square lunar diameter.
   /// </summary>
   public static readonly Area SquareLunarCircumference = new (
                                                               "square lunar circumference"
                                                             , "C(L)^2"
                                                             , SquareLunarDiameter
                                                             , Math.PI * Math.PI
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) square exalight-year. Defined in terms of a(n) square petalight-year.
   /// </summary>
   public static readonly Area SquareExalightYear = new (
                                                         "square exalight-year"
                                                       , "Ely^2"
                                                       , SquarePetalightYear
                                                       , 1000.0 * 1000.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) square mars circumference. Defined in terms of a(n) square mars diameter.
   /// </summary>
   public static readonly Area SquareMarsCircumference = new (
                                                              "square mars circumference"
                                                            , "C(♂)^2"
                                                            , SquareMarsDiameter
                                                            , Math.PI * Math.PI
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) square zettalight-year. Defined in terms of a(n) square exalight-year.
   /// </summary>
   public static readonly Area SquareZettalightYear = new (
                                                           "square zettalight-year"
                                                         , "Zly^2"
                                                         , SquareExalightYear
                                                         , 1000.0 * 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) square solar circumference. Defined in terms of a(n) square solar diameter.
   /// </summary>
   public static readonly Area SquareSolarCircumference = new (
                                                               "square solar circumference"
                                                             , "C(☉)^2"
                                                             , SquareSolarDiameter
                                                             , Math.PI * Math.PI
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) square yottalight-year. Defined in terms of a(n) square zettalight-year.
   /// </summary>
   public static readonly Area SquareYottalightYear = new (
                                                           "square yottalight-year"
                                                         , "Yly^2"
                                                         , SquareZettalightYear
                                                         , 1000.0 * 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) square ronnalight-year. Defined in terms of a(n) square yottalight-year.
   /// </summary>
   public static readonly Area SquareRonnalightYear = new (
                                                           "square ronnalight-year"
                                                         , "Rly^2"
                                                         , SquareYottalightYear
                                                         , 1000.0 * 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) square quettalight-year. Defined in terms of a(n) square ronnalight-year.
   /// </summary>
   public static readonly Area SquareQuettalightYear =
            new ("square quettalight-year", "Qly^2", SquareRonnalightYear, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square dekaparsec. Defined in terms of a(n) square parsec.
   /// </summary>
   public static readonly Area SquareDekaparsec = new ("square dekaparsec", "dapc^2", SquareParsec, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square hectoparsec. Defined in terms of a(n) square dekaparsec.
   /// </summary>
   public static readonly Area SquareHectoparsec = new (
                                                        "square hectoparsec"
                                                      , "hpc^2"
                                                      , SquareDekaparsec
                                                      , 10.0 * 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square kiloparsec. Defined in terms of a(n) square hectoparsec.
   /// </summary>
   public static readonly Area SquareKiloparsec = new ("square kiloparsec", "kpc^2", SquareHectoparsec, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square megaparsec. Defined in terms of a(n) square kiloparsec.
   /// </summary>
   public static readonly Area SquareMegaparsec = new (
                                                       "square megaparsec"
                                                     , "Mpc^2"
                                                     , SquareKiloparsec
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square gigaparsec. Defined in terms of a(n) square megaparsec.
   /// </summary>
   public static readonly Area SquareGigaparsec = new (
                                                       "square gigaparsec"
                                                     , "Gpc^2"
                                                     , SquareMegaparsec
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square teraparsec. Defined in terms of a(n) square gigaparsec.
   /// </summary>
   public static readonly Area SquareTeraparsec = new (
                                                       "square teraparsec"
                                                     , "Tpc^2"
                                                     , SquareGigaparsec
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square petaparsec. Defined in terms of a(n) square teraparsec.
   /// </summary>
   public static readonly Area SquarePetaparsec = new (
                                                       "square petaparsec"
                                                     , "Ppc^2"
                                                     , SquareTeraparsec
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square exaparsec. Defined in terms of a(n) square petaparsec.
   /// </summary>
   public static readonly Area SquareExaparsec = new (
                                                      "square exaparsec"
                                                    , "Epc^2"
                                                    , SquarePetaparsec
                                                    , 1000.0 * 1000.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square zettaparsec. Defined in terms of a(n) square exaparsec.
   /// </summary>
   public static readonly Area SquareZettaparsec = new (
                                                        "square zettaparsec"
                                                      , "Zpc^2"
                                                      , SquareExaparsec
                                                      , 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square yottaparsec. Defined in terms of a(n) square zettaparsec.
   /// </summary>
   public static readonly Area SquareYottaparsec = new (
                                                        "square yottaparsec"
                                                      , "Ypc^2"
                                                      , SquareZettaparsec
                                                      , 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square ronnaparsec. Defined in terms of a(n) square yottaparsec.
   /// </summary>
   public static readonly Area SquareRonnaparsec = new (
                                                        "square ronnaparsec"
                                                      , "Rpc^2"
                                                      , SquareYottaparsec
                                                      , 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square quettaparsec. Defined in terms of a(n) square ronnaparsec.
   /// </summary>
   public static readonly Area SquareQuettaparsec = new (
                                                         "square quettaparsec"
                                                       , "Qpc^2"
                                                       , SquareRonnaparsec
                                                       , 1000.0 * 1000.0
                                                       , 0
                                                        );
}
