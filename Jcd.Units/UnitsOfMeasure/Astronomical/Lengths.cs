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
/// Astronomical Units for measuring Length.
/// </summary>
public class Lengths : UnitOfMeasureEnumeration<Lengths, Length>
{
   /// <summary>
   /// light-year defined such that: SI meter = ly × 9_460_730_472_580_800.0.
   /// </summary>
   public static readonly Length LightYear = new (
                                                  "light-year"
                                                , "ly"
                                                , SI.Lengths.Meter
                                                , 9_460_730_472_580_800.0
                                                , system: "Astronomical"
                                                 );

   /// <summary>
   /// dekalight-year defined such that: light-year = daly × 10.0.
   /// </summary>
   public static readonly Length DekalightYear = new (
                                                      "dekalight-year"
                                                    , "daly"
                                                    , LightYear
                                                    , 10.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// hectolight-year defined such that: dekalight-year = hly × 10.0.
   /// </summary>
   public static readonly Length HectolightYear = new (
                                                       "hectolight-year"
                                                     , "hly"
                                                     , DekalightYear
                                                     , 10.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// kilolight-year defined such that: hectolight-year = kly × 10.0.
   /// </summary>
   public static readonly Length KilolightYear = new (
                                                      "kilolight-year"
                                                    , "kly"
                                                    , HectolightYear
                                                    , 10.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// megalight-year defined such that: kilolight-year = Mly × 1000.0.
   /// </summary>
   public static readonly Length MegalightYear = new (
                                                      "megalight-year"
                                                    , "Mly"
                                                    , KilolightYear
                                                    , 1000.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// gigalight-year defined such that: megalight-year = Gly × 1000.0.
   /// </summary>
   public static readonly Length GigalightYear = new (
                                                      "gigalight-year"
                                                    , "Gly"
                                                    , MegalightYear
                                                    , 1000.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// teralight-year defined such that: gigalight-year = Tly × 1000.0.
   /// </summary>
   public static readonly Length TeralightYear = new (
                                                      "teralight-year"
                                                    , "Tly"
                                                    , GigalightYear
                                                    , 1000.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// petalight-year defined such that: teralight-year = Ply × 1000.0.
   /// </summary>
   public static readonly Length PetalightYear = new (
                                                      "petalight-year"
                                                    , "Ply"
                                                    , TeralightYear
                                                    , 1000.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// exalight-year defined such that: petalight-year = Ely × 1000.0.
   /// </summary>
   public static readonly Length ExalightYear = new (
                                                     "exalight-year"
                                                   , "Ely"
                                                   , PetalightYear
                                                   , 1000.0
                                                   , system: "Astronomical"
                                                    );

   /// <summary>
   /// zettalight-year defined such that: exalight-year = Zly × 1000.0.
   /// </summary>
   public static readonly Length ZettalightYear = new (
                                                       "zettalight-year"
                                                     , "Zly"
                                                     , ExalightYear
                                                     , 1000.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// yottalight-year defined such that: zettalight-year = Yly × 1000.0.
   /// </summary>
   public static readonly Length YottalightYear = new (
                                                       "yottalight-year"
                                                     , "Yly"
                                                     , ZettalightYear
                                                     , 1000.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// ronnalight-year defined such that: yottalight-year = Rly × 1000.0.
   /// </summary>
   public static readonly Length RonnalightYear = new (
                                                       "ronnalight-year"
                                                     , "Rly"
                                                     , YottalightYear
                                                     , 1000.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// quettalight-year defined such that: ronnalight-year = Qly × 1000.0.
   /// </summary>
   public static readonly Length QuettalightYear = new (
                                                        "quettalight-year"
                                                      , "Qly"
                                                      , RonnalightYear
                                                      , 1000.0
                                                      , system: "Astronomical"
                                                       );

   /// <summary>
   /// light-second defined such that: SI meter = ls × 299_792_458.0.
   /// </summary>
   public static readonly Length LightSecond = new (
                                                    "light-second"
                                                  , "ls"
                                                  , SI.Lengths.Meter
                                                  , 299_792_458.0
                                                  , system: "Astronomical"
                                                   );

   /// <summary>
   /// light-minute defined such that: light-second = lm × 60.0.
   /// </summary>
   public static readonly Length LightMinute = new ("light-minute", "lm", LightSecond, 60.0, system: "Astronomical");

   /// <summary>
   /// astronomical unit defined such that: SI kilometer = AU × 149597870.691.
   /// </summary>
   public static readonly Length AstronomicalUnit = new (
                                                         "astronomical unit"
                                                       , "AU"
                                                       , SI.Lengths.Kilometer
                                                       , 149597870.691
                                                       , system: "Astronomical"
                                                        );

   /// <summary>
   /// light-hour defined such that: light-minute = lh × 60.0.
   /// </summary>
   public static readonly Length LightHour = new ("light-hour", "lh", LightMinute, 60.0, system: "Astronomical");

   /// <summary>
   /// light-day defined such that: light-hour = ld × 24.0.
   /// </summary>
   public static readonly Length LightDay = new ("light-day", "ld", LightHour, 24.0, system: "Astronomical");

   /// <summary>
   /// light-week defined such that: light-day = lw × 7.0.
   /// </summary>
   public static readonly Length LightWeek = new ("light-week", "lw", LightDay, 7.0, system: "Astronomical");

   /// <summary>
   /// parsec defined such that: light-year = pc × 3.2615637769757.
   /// </summary>
   public static readonly Length Parsec = new ("parsec", "pc", LightYear, 3.2615637769757, system: "Astronomical");

   /// <summary>
   /// dekaparsec defined such that: parsec = dapc × 10.0.
   /// </summary>
   public static readonly Length Dekaparsec = new ("dekaparsec", "dapc", Parsec, 10.0, system: "Astronomical");

   /// <summary>
   /// hectoparsec defined such that: dekaparsec = hpc × 10.0.
   /// </summary>
   public static readonly Length Hectoparsec = new ("hectoparsec", "hpc", Dekaparsec, 10.0, system: "Astronomical");

   /// <summary>
   /// kiloparsec defined such that: hectoparsec = kpc × 10.0.
   /// </summary>
   public static readonly Length Kiloparsec = new ("kiloparsec", "kpc", Hectoparsec, 10.0, system: "Astronomical");

   /// <summary>
   /// megaparsec defined such that: kiloparsec = Mpc × 1000.0.
   /// </summary>
   public static readonly Length Megaparsec = new ("megaparsec", "Mpc", Kiloparsec, 1000.0, system: "Astronomical");

   /// <summary>
   /// gigaparsec defined such that: megaparsec = Gpc × 1000.0.
   /// </summary>
   public static readonly Length Gigaparsec = new ("gigaparsec", "Gpc", Megaparsec, 1000.0, system: "Astronomical");

   /// <summary>
   /// teraparsec defined such that: gigaparsec = Tpc × 1000.0.
   /// </summary>
   public static readonly Length Teraparsec = new ("teraparsec", "Tpc", Gigaparsec, 1000.0, system: "Astronomical");

   /// <summary>
   /// petaparsec defined such that: teraparsec = Ppc × 1000.0.
   /// </summary>
   public static readonly Length Petaparsec = new ("petaparsec", "Ppc", Teraparsec, 1000.0, system: "Astronomical");

   /// <summary>
   /// exaparsec defined such that: petaparsec = Epc × 1000.0.
   /// </summary>
   public static readonly Length Exaparsec = new ("exaparsec", "Epc", Petaparsec, 1000.0, system: "Astronomical");

   /// <summary>
   /// zettaparsec defined such that: exaparsec = Zpc × 1000.0.
   /// </summary>
   public static readonly Length Zettaparsec = new ("zettaparsec", "Zpc", Exaparsec, 1000.0, system: "Astronomical");

   /// <summary>
   /// yottaparsec defined such that: zettaparsec = Ypc × 1000.0.
   /// </summary>
   public static readonly Length Yottaparsec = new ("yottaparsec", "Ypc", Zettaparsec, 1000.0, system: "Astronomical");

   /// <summary>
   /// ronnaparsec defined such that: yottaparsec = Rpc × 1000.0.
   /// </summary>
   public static readonly Length Ronnaparsec = new ("ronnaparsec", "Rpc", Yottaparsec, 1000.0, system: "Astronomical");

   /// <summary>
   /// quettaparsec defined such that: ronnaparsec = Qpc × 1000.0.
   /// </summary>
   public static readonly Length Quettaparsec = new (
                                                     "quettaparsec"
                                                   , "Qpc"
                                                   , Ronnaparsec
                                                   , 1000.0
                                                   , system: "Astronomical"
                                                    );

   /// <summary>
   /// earth radius defined such that: SI kilometer = R(⊕) × 6_371.0.
   /// </summary>
   public static readonly Length EarthRadius = new (
                                                    "earth radius"
                                                  , "R(⊕)"
                                                  , SI.Lengths.Kilometer
                                                  , 6_371.0
                                                  , system: "Astronomical"
                                                   );

   /// <summary>
   /// jovian radius defined such that: SI kilometer = R(J) × 69_911.0.
   /// </summary>
   public static readonly Length JovianRadius = new (
                                                     "jovian radius"
                                                   , "R(J)"
                                                   , SI.Lengths.Kilometer
                                                   , 69_911.0
                                                   , system: "Astronomical"
                                                    );

   /// <summary>
   /// lunar radius defined such that: SI kilometer = R(L) × 1_737.4.
   /// </summary>
   public static readonly Length LunarRadius = new (
                                                    "lunar radius"
                                                  , "R(L)"
                                                  , SI.Lengths.Kilometer
                                                  , 1_737.4
                                                  , system: "Astronomical"
                                                   );

   /// <summary>
   /// mars radius defined such that: SI kilometer = R(♂) × 3_389.5.
   /// </summary>
   public static readonly Length MarsRadius = new (
                                                   "mars radius"
                                                 , "R(♂)"
                                                 , SI.Lengths.Kilometer
                                                 , 3_389.5
                                                 , system: "Astronomical"
                                                  );

   /// <summary>
   /// solar radius defined such that: SI kilometer = R(☉) × 695_700.0.
   /// </summary>
   public static readonly Length SolarRadius = new (
                                                    "solar radius"
                                                  , "R(☉)"
                                                  , SI.Lengths.Kilometer
                                                  , 695_700.0
                                                  , system: "Astronomical"
                                                   );

   /// <summary>
   /// earth diameter defined such that: earth radius = D(⊕) × 2.0.
   /// </summary>
   public static readonly Length EarthDiameter = new (
                                                      "earth diameter"
                                                    , "D(⊕)"
                                                    , EarthRadius
                                                    , 2.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// jovian diameter defined such that: jovian radius = D(J) × 2.0.
   /// </summary>
   public static readonly Length JovianDiameter = new (
                                                       "jovian diameter"
                                                     , "D(J)"
                                                     , JovianRadius
                                                     , 2.0
                                                     , system: "Astronomical"
                                                      );

   /// <summary>
   /// lunar diameter defined such that: lunar radius = D(L) × 2.0.
   /// </summary>
   public static readonly Length LunarDiameter = new (
                                                      "lunar diameter"
                                                    , "D(L)"
                                                    , LunarRadius
                                                    , 2.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// mars diameter defined such that: mars radius = D(♂) × 2.0.
   /// </summary>
   public static readonly Length MarsDiameter = new ("mars diameter", "D(♂)", MarsRadius, 2.0, system: "Astronomical");

   /// <summary>
   /// solar diameter defined such that: solar radius = D(☉) × 2.0.
   /// </summary>
   public static readonly Length SolarDiameter = new (
                                                      "solar diameter"
                                                    , "D(☉)"
                                                    , SolarRadius
                                                    , 2.0
                                                    , system: "Astronomical"
                                                     );

   /// <summary>
   /// earth circumference defined such that: earth diameter = C(⊕) × Math.PI.
   /// </summary>
   public static readonly Length EarthCircumference = new (
                                                           "earth circumference"
                                                         , "C(⊕)"
                                                         , EarthDiameter
                                                         , Math.PI
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// jovian circumference defined such that: jovian diameter = C(J) × Math.PI.
   /// </summary>
   public static readonly Length JovianCircumference = new (
                                                            "jovian circumference"
                                                          , "C(J)"
                                                          , JovianDiameter
                                                          , Math.PI
                                                          , system: "Astronomical"
                                                           );

   /// <summary>
   /// lunar circumference defined such that: lunar diameter = C(L) × Math.PI.
   /// </summary>
   public static readonly Length LunarCircumference = new (
                                                           "lunar circumference"
                                                         , "C(L)"
                                                         , LunarDiameter
                                                         , Math.PI
                                                         , system: "Astronomical"
                                                          );

   /// <summary>
   /// mars circumference defined such that: mars diameter = C(♂) × Math.PI.
   /// </summary>
   public static readonly Length MarsCircumference = new (
                                                          "mars circumference"
                                                        , "C(♂)"
                                                        , MarsDiameter
                                                        , Math.PI
                                                        , system: "Astronomical"
                                                         );

   /// <summary>
   /// solar circumference defined such that: solar diameter = C(☉) × Math.PI.
   /// </summary>
   public static readonly Length SolarCircumference = new (
                                                           "solar circumference"
                                                         , "C(☉)"
                                                         , SolarDiameter
                                                         , Math.PI
                                                         , system: "Astronomical"
                                                          );
}
