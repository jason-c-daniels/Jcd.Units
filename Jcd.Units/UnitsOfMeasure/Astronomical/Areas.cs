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
   /// A(n) square light-year. Defined in terms of a(n) SI square meter.
   /// </summary>
   public static readonly Area SquareLightYear = new (
                                                      "square light-year"
                                                    , "ly²"
                                                    , SI.Areas.SquareMeter
                                                    , 9_460_730_472_580_800.0 * 9_460_730_472_580_800.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square light-second. Defined in terms of a(n) SI square meter.
   /// </summary>
   public static readonly Area SquareLightSecond = new (
                                                        "square light-second"
                                                      , "ls²"
                                                      , SI.Areas.SquareMeter
                                                      , 299_792_458.0 * 299_792_458.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square light-minute. Defined in terms of a(n) square light-second.
   /// </summary>
   public static readonly Area SquareLightMinute = new (
                                                        "square light-minute"
                                                      , "lm²"
                                                      , SquareLightSecond
                                                      , 60.0 * 60.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square astronomical unit. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareAstronomicalUnit = new (
                                                             "square astronomical unit"
                                                           , "AU²"
                                                           , SI.Areas.SquareKilometer
                                                           , 149597870.691 * 149597870.691
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) square light-hour. Defined in terms of a(n) square light-minute.
   /// </summary>
   public static readonly Area SquareLightHour = new ("square light-hour", "lh²", SquareLightMinute, 60.0 * 60.0, 0);

   /// <summary>
   /// A(n) square light-day. Defined in terms of a(n) square light-hour.
   /// </summary>
   public static readonly Area SquareLightDay = new ("square light-day", "ld²", SquareLightHour, 24.0 * 24.0, 0);

   /// <summary>
   /// A(n) square light-week. Defined in terms of a(n) square light-day.
   /// </summary>
   public static readonly Area SquareLightWeek = new ("square light-week", "lw²", SquareLightDay, 7.0 * 7.0, 0);

   /// <summary>
   /// A(n) square parsec. Defined in terms of a(n) square light-year.
   /// </summary>
   public static readonly Area SquareParsec = new (
                                                   "square parsec"
                                                 , "pc²"
                                                 , SquareLightYear
                                                 , 3.2615637769757 * 3.2615637769757
                                                 , 0
                                                  );

   /// <summary>
   /// A(n) square earth radius. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareEarthRadius = new (
                                                        "square earth radius"
                                                      , "R(⊕)²"
                                                      , SI.Areas.SquareKilometer
                                                      , 6_371.0 * 6_371.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square jovian radius. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareJovianRadius = new (
                                                         "square jovian radius"
                                                       , "R(J)²"
                                                       , SI.Areas.SquareKilometer
                                                       , 69_911.0 * 69_911.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) square lunar radius. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareLunarRadius = new (
                                                        "square lunar radius"
                                                      , "R(L)²"
                                                      , SI.Areas.SquareKilometer
                                                      , 1_737.4 * 1_737.4
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square mars radius. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareMarsRadius = new (
                                                       "square mars radius"
                                                     , "R(♂)²"
                                                     , SI.Areas.SquareKilometer
                                                     , 3_389.5 * 3_389.5
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square solar radius. Defined in terms of a(n) SI square kilometer.
   /// </summary>
   public static readonly Area SquareSolarRadius = new (
                                                        "square solar radius"
                                                      , "R(☉)²"
                                                      , SI.Areas.SquareKilometer
                                                      , 695_700.0 * 695_700.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square earth diameter. Defined in terms of a(n) square earth radius.
   /// </summary>
   public static readonly Area SquareEarthDiameter = new (
                                                          "square earth diameter"
                                                        , "D(⊕)²"
                                                        , SquareEarthRadius
                                                        , 2.0 * 2.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square dekalight-year. Defined in terms of a(n) square light-year.
   /// </summary>
   public static readonly Area SquareDekalightYear = new (
                                                          "square dekalight-year"
                                                        , "daly²"
                                                        , SquareLightYear
                                                        , 10.0 * 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square jovian diameter. Defined in terms of a(n) square jovian radius.
   /// </summary>
   public static readonly Area SquareJovianDiameter = new (
                                                           "square jovian diameter"
                                                         , "D(J)²"
                                                         , SquareJovianRadius
                                                         , 2.0 * 2.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) square hectolight-year. Defined in terms of a(n) square dekalight-year.
   /// </summary>
   public static readonly Area SquareHectolightYear = new (
                                                           "square hectolight-year"
                                                         , "hly²"
                                                         , SquareDekalightYear
                                                         , 10.0 * 10.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) square lunar diameter. Defined in terms of a(n) square lunar radius.
   /// </summary>
   public static readonly Area SquareLunarDiameter = new (
                                                          "square lunar diameter"
                                                        , "D(L)²"
                                                        , SquareLunarRadius
                                                        , 2.0 * 2.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square kilolight-year. Defined in terms of a(n) square hectolight-year.
   /// </summary>
   public static readonly Area SquareKilolightYear = new (
                                                          "square kilolight-year"
                                                        , "kly²"
                                                        , SquareHectolightYear
                                                        , 10.0 * 10.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square mars diameter. Defined in terms of a(n) square mars radius.
   /// </summary>
   public static readonly Area SquareMarsDiameter = new (
                                                         "square mars diameter"
                                                       , "D(♂)²"
                                                       , SquareMarsRadius
                                                       , 2.0 * 2.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) square megalight-year. Defined in terms of a(n) square kilolight-year.
   /// </summary>
   public static readonly Area SquareMegalightYear = new (
                                                          "square megalight-year"
                                                        , "Mly²"
                                                        , SquareKilolightYear
                                                        , 1000.0 * 1000.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square solar diameter. Defined in terms of a(n) square solar radius.
   /// </summary>
   public static readonly Area SquareSolarDiameter = new (
                                                          "square solar diameter"
                                                        , "D(☉)²"
                                                        , SquareSolarRadius
                                                        , 2.0 * 2.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square gigalight-year. Defined in terms of a(n) square megalight-year.
   /// </summary>
   public static readonly Area SquareGigalightYear = new (
                                                          "square gigalight-year"
                                                        , "Gly²"
                                                        , SquareMegalightYear
                                                        , 1000.0 * 1000.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square earth circumference. Defined in terms of a(n) square earth diameter.
   /// </summary>
   public static readonly Area SquareEarthCircumference = new (
                                                               "square earth circumference"
                                                             , "C(⊕)²"
                                                             , SquareEarthDiameter
                                                             , Math.PI * Math.PI
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) square teralight-year. Defined in terms of a(n) square gigalight-year.
   /// </summary>
   public static readonly Area SquareTeralightYear = new (
                                                          "square teralight-year"
                                                        , "Tly²"
                                                        , SquareGigalightYear
                                                        , 1000.0 * 1000.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square jovian circumference. Defined in terms of a(n) square jovian diameter.
   /// </summary>
   public static readonly Area SquareJovianCircumference = new (
                                                                "square jovian circumference"
                                                              , "C(J)²"
                                                              , SquareJovianDiameter
                                                              , Math.PI * Math.PI
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) square petalight-year. Defined in terms of a(n) square teralight-year.
   /// </summary>
   public static readonly Area SquarePetalightYear = new (
                                                          "square petalight-year"
                                                        , "Ply²"
                                                        , SquareTeralightYear
                                                        , 1000.0 * 1000.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) square lunar circumference. Defined in terms of a(n) square lunar diameter.
   /// </summary>
   public static readonly Area SquareLunarCircumference = new (
                                                               "square lunar circumference"
                                                             , "C(L)²"
                                                             , SquareLunarDiameter
                                                             , Math.PI * Math.PI
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) square exalight-year. Defined in terms of a(n) square petalight-year.
   /// </summary>
   public static readonly Area SquareExalightYear = new (
                                                         "square exalight-year"
                                                       , "Ely²"
                                                       , SquarePetalightYear
                                                       , 1000.0 * 1000.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) square mars circumference. Defined in terms of a(n) square mars diameter.
   /// </summary>
   public static readonly Area SquareMarsCircumference = new (
                                                              "square mars circumference"
                                                            , "C(♂)²"
                                                            , SquareMarsDiameter
                                                            , Math.PI * Math.PI
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) square zettalight-year. Defined in terms of a(n) square exalight-year.
   /// </summary>
   public static readonly Area SquareZettalightYear = new (
                                                           "square zettalight-year"
                                                         , "Zly²"
                                                         , SquareExalightYear
                                                         , 1000.0 * 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) square solar circumference. Defined in terms of a(n) square solar diameter.
   /// </summary>
   public static readonly Area SquareSolarCircumference = new (
                                                               "square solar circumference"
                                                             , "C(☉)²"
                                                             , SquareSolarDiameter
                                                             , Math.PI * Math.PI
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) square yottalight-year. Defined in terms of a(n) square zettalight-year.
   /// </summary>
   public static readonly Area SquareYottalightYear = new (
                                                           "square yottalight-year"
                                                         , "Yly²"
                                                         , SquareZettalightYear
                                                         , 1000.0 * 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) square ronnalight-year. Defined in terms of a(n) square yottalight-year.
   /// </summary>
   public static readonly Area SquareRonnalightYear = new (
                                                           "square ronnalight-year"
                                                         , "Rly²"
                                                         , SquareYottalightYear
                                                         , 1000.0 * 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) square quettalight-year. Defined in terms of a(n) square ronnalight-year.
   /// </summary>
   public static readonly Area SquareQuettalightYear =
            new ("square quettalight-year", "Qly²", SquareRonnalightYear, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square dekaparsec. Defined in terms of a(n) square parsec.
   /// </summary>
   public static readonly Area SquareDekaparsec = new ("square dekaparsec", "dapc²", SquareParsec, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square hectoparsec. Defined in terms of a(n) square dekaparsec.
   /// </summary>
   public static readonly Area SquareHectoparsec = new ("square hectoparsec", "hpc²", SquareDekaparsec, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square kiloparsec. Defined in terms of a(n) square hectoparsec.
   /// </summary>
   public static readonly Area SquareKiloparsec = new ("square kiloparsec", "kpc²", SquareHectoparsec, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square megaparsec. Defined in terms of a(n) square kiloparsec.
   /// </summary>
   public static readonly Area SquareMegaparsec = new (
                                                       "square megaparsec"
                                                     , "Mpc²"
                                                     , SquareKiloparsec
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square gigaparsec. Defined in terms of a(n) square megaparsec.
   /// </summary>
   public static readonly Area SquareGigaparsec = new (
                                                       "square gigaparsec"
                                                     , "Gpc²"
                                                     , SquareMegaparsec
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square teraparsec. Defined in terms of a(n) square gigaparsec.
   /// </summary>
   public static readonly Area SquareTeraparsec = new (
                                                       "square teraparsec"
                                                     , "Tpc²"
                                                     , SquareGigaparsec
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square petaparsec. Defined in terms of a(n) square teraparsec.
   /// </summary>
   public static readonly Area SquarePetaparsec = new (
                                                       "square petaparsec"
                                                     , "Ppc²"
                                                     , SquareTeraparsec
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square exaparsec. Defined in terms of a(n) square petaparsec.
   /// </summary>
   public static readonly Area SquareExaparsec = new ("square exaparsec", "Epc²", SquarePetaparsec, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square zettaparsec. Defined in terms of a(n) square exaparsec.
   /// </summary>
   public static readonly Area SquareZettaparsec = new (
                                                        "square zettaparsec"
                                                      , "Zpc²"
                                                      , SquareExaparsec
                                                      , 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square yottaparsec. Defined in terms of a(n) square zettaparsec.
   /// </summary>
   public static readonly Area SquareYottaparsec = new (
                                                        "square yottaparsec"
                                                      , "Ypc²"
                                                      , SquareZettaparsec
                                                      , 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square ronnaparsec. Defined in terms of a(n) square yottaparsec.
   /// </summary>
   public static readonly Area SquareRonnaparsec = new (
                                                        "square ronnaparsec"
                                                      , "Rpc²"
                                                      , SquareYottaparsec
                                                      , 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square quettaparsec. Defined in terms of a(n) square ronnaparsec.
   /// </summary>
   public static readonly Area SquareQuettaparsec = new (
                                                         "square quettaparsec"
                                                       , "Qpc²"
                                                       , SquareRonnaparsec
                                                       , 1000.0 * 1000.0
                                                       , 0
                                                        );
}
