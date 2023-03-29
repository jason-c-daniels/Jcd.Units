﻿#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.USSurvey;

/// <summary>
/// United States Survey Units for measuring Acceleration.
/// </summary>
public class Accelerations : UnitOfMeasureEnumeration<Accelerations, Acceleration>
{
   /// <summary>
   /// A(n) league per square century. Defined as: ((4828.032)/((10.0)*(10.0))) × SI meter per square decade + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentury = new (
                                                                     "league per square century"
                                                                   , "lea/century²"
                                                                   , SI.Accelerations.MeterPerSquareDecade
                                                                   , 4828.032 / (10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) chain per square sextillion years. Defined as: ((20.1168)/((1000.0)*(1000.0))) × SI meter per square quintillion years + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareSextillionYears = new (
                                                                            "chain per square sextillion years"
                                                                          , "ch/Zyr²"
                                                                          , SI.Accelerations
                                                                              .MeterPerSquareQuintillionYears
                                                                          , 20.1168 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) chain per square year. Defined as: ((20.1168)/((365.2525)*(365.2525))) × SI meter per square day + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareYear = new (
                                                                 "chain per square year"
                                                               , "ch/yr²"
                                                               , SI.Accelerations.MeterPerSquareDay
                                                               , 20.1168 / (365.2525 * 365.2525)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) rod per square billion years. Defined as: ((5.0292)/((1000.0)*(1000.0))) × SI meter per square million years + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareBillionYears = new (
                                                                       "rod per square billion years"
                                                                     , "rd/Gyr²"
                                                                     , SI.Accelerations.MeterPerSquareMillionYears
                                                                     , 5.0292 / (1000.0 * 1000.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) rod per square trillion years. Defined as: ((5.0292)/((1000.0)*(1000.0))) × SI meter per square billion years + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareTrillionYears = new (
                                                                        "rod per square trillion years"
                                                                      , "rd/Tyr²"
                                                                      , SI.Accelerations.MeterPerSquareBillionYears
                                                                      , 5.0292 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square quadrillion years. Defined as: ((4828.032)/((1000.0)*(1000.0))) × SI meter per square trillion years + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuadrillionYears = new (
                                                                              "league per square quadrillion years"
                                                                            , "lea/Pyr²"
                                                                            , SI.Accelerations
                                                                                      .MeterPerSquareTrillionYears
                                                                            , 4828.032 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) furlong per square octillion years. Defined as: ((201.168)/((1000.0)*(1000.0))) × SI meter per square septillion years + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareOctillionYears = new (
                                                                             "furlong per square octillion years"
                                                                           , "fur/Ryr²"
                                                                           , SI.Accelerations
                                                                                     .MeterPerSquareSeptillionYears
                                                                           , 201.168 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) furlong per square billion years. Defined as: ((201.168)/((1000.0)*(1000.0))) × SI meter per square million years + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareBillionYears = new (
                                                                           "furlong per square billion years"
                                                                         , "fur/Gyr²"
                                                                         , SI.Accelerations.MeterPerSquareMillionYears
                                                                         , 201.168 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) chain per square septillion years. Defined as: ((20.1168)/((1000.0)*(1000.0))) × SI meter per square sextillion years + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareSeptillionYears = new (
                                                                            "chain per square septillion years"
                                                                          , "ch/Yyr²"
                                                                          , SI.Accelerations
                                                                              .MeterPerSquareSextillionYears
                                                                          , 20.1168 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) furlong per square week. Defined as: ((201.168)/((7.0)*(7.0))) × SI meter per square day + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareWeek = new (
                                                                   "furlong per square week"
                                                                 , "fur/wk²"
                                                                 , SI.Accelerations.MeterPerSquareDay
                                                                 , 201.168 / (7.0 * 7.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) league per square day. Defined as: ((4828.032)/((24.0)*(24.0))) × SI meter per square hour + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDay = new (
                                                                 "league per square day"
                                                               , "lea/dy²"
                                                               , SI.Accelerations.MeterPerSquareHour
                                                               , 4828.032 / (24.0 * 24.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) chain per square decade. Defined as: ((20.1168)/((10.0)*(10.0))) × SI meter per square year + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecade = new (
                                                                   "chain per square decade"
                                                                 , "ch/decade²"
                                                                 , SI.Accelerations.MeterPerSquareYear
                                                                 , 20.1168 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rod per square quadrillion years. Defined as: ((5.0292)/((1000.0)*(1000.0))) × SI meter per square trillion years + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareQuadrillionYears = new (
                                                                           "rod per square quadrillion years"
                                                                         , "rd/Pyr²"
                                                                         , SI.Accelerations.MeterPerSquareTrillionYears
                                                                         , 5.0292 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) league per square nonillion years. Defined as: ((4828.032)/((1000.0)*(1000.0))) × SI meter per square octillion years + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNonillionYears = new (
                                                                            "league per square nonillion years"
                                                                          , "lea/Qyr²"
                                                                          , SI.Accelerations
                                                                              .MeterPerSquareOctillionYears
                                                                          , 4828.032 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) rod per square quintillion years. Defined as: ((5.0292)/((1000.0)*(1000.0))) × SI meter per square quadrillion years + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareQuintillionYears = new (
                                                                           "rod per square quintillion years"
                                                                         , "rd/Eyr²"
                                                                         , SI.Accelerations
                                                                             .MeterPerSquareQuadrillionYears
                                                                         , 5.0292 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) chain per square tick. Defined as: ((20.1168)/((100.0)*(100.0))) × SI meter per square nanosecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareTick = new (
                                                                 "chain per square tick"
                                                               , "ch/tick²"
                                                               , SI.Accelerations.MeterPerSquareNanosecond
                                                               , 20.1168 / (100.0 * 100.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) league per square millennium. Defined as: ((4828.032)/((10.0)*(10.0))) × SI meter per square century + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillennium = new (
                                                                        "league per square millennium"
                                                                      , "lea/kyr²"
                                                                      , SI.Accelerations.MeterPerSquareCentury
                                                                      , 4828.032 / (10.0 * 10.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square octillion years. Defined as: ((20.1168)/((1000.0)*(1000.0))) × SI meter per square septillion years + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareOctillionYears = new (
                                                                           "chain per square octillion years"
                                                                         , "ch/Ryr²"
                                                                         , SI.Accelerations
                                                                             .MeterPerSquareSeptillionYears
                                                                         , 20.1168 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) chain per square century. Defined as: ((20.1168)/((10.0)*(10.0))) × SI meter per square decade + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareCentury = new (
                                                                    "chain per square century"
                                                                  , "ch/century²"
                                                                  , SI.Accelerations.MeterPerSquareDecade
                                                                  , 20.1168 / (10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rod per square sextillion years. Defined as: ((5.0292)/((1000.0)*(1000.0))) × SI meter per square quintillion years + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareSextillionYears = new (
                                                                          "rod per square sextillion years"
                                                                        , "rd/Zyr²"
                                                                        , SI.Accelerations
                                                                            .MeterPerSquareQuintillionYears
                                                                        , 5.0292 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square nonillion years. Defined as: ((201.168)/((1000.0)*(1000.0))) × SI meter per square octillion years + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareNonillionYears = new (
                                                                             "furlong per square nonillion years"
                                                                           , "fur/Qyr²"
                                                                           , SI.Accelerations
                                                                                     .MeterPerSquareOctillionYears
                                                                           , 201.168 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) furlong per square trillion years. Defined as: ((201.168)/((1000.0)*(1000.0))) × SI meter per square billion years + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareTrillionYears = new (
                                                                            "furlong per square trillion years"
                                                                          , "fur/Tyr²"
                                                                          , SI.Accelerations.MeterPerSquareBillionYears
                                                                          , 201.168 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) furlong per square year. Defined as: ((201.168)/((365.2525)*(365.2525))) × SI meter per square day + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareYear = new (
                                                                   "furlong per square year"
                                                                 , "fur/yr²"
                                                                 , SI.Accelerations.MeterPerSquareDay
                                                                 , 201.168 / (365.2525 * 365.2525)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rod per square septillion years. Defined as: ((5.0292)/((1000.0)*(1000.0))) × SI meter per square sextillion years + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareSeptillionYears = new (
                                                                          "rod per square septillion years"
                                                                        , "rd/Yyr²"
                                                                        , SI.Accelerations.MeterPerSquareSextillionYears
                                                                        , 5.0292 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) league per square quintillion years. Defined as: ((4828.032)/((1000.0)*(1000.0))) × SI meter per square quadrillion years + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuintillionYears = new (
                                                                              "league per square quintillion years"
                                                                            , "lea/Eyr²"
                                                                            , SI.Accelerations
                                                                                      .MeterPerSquareQuadrillionYears
                                                                            , 4828.032 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) chain per square nonillion years. Defined as: ((20.1168)/((1000.0)*(1000.0))) × SI meter per square octillion years + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareNonillionYears = new (
                                                                           "chain per square nonillion years"
                                                                         , "ch/Qyr²"
                                                                         , SI.Accelerations.MeterPerSquareOctillionYears
                                                                         , 20.1168 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) league per square week. Defined as: ((4828.032)/((7.0)*(7.0))) × SI meter per square day + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareWeek = new (
                                                                  "league per square week"
                                                                , "lea/wk²"
                                                                , SI.Accelerations.MeterPerSquareDay
                                                                , 4828.032 / (7.0 * 7.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) chain per square millennium. Defined as: ((20.1168)/((10.0)*(10.0))) × SI meter per square century + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillennium = new (
                                                                       "chain per square millennium"
                                                                     , "ch/kyr²"
                                                                     , SI.Accelerations.MeterPerSquareCentury
                                                                     , 20.1168 / (10.0 * 10.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) rod per square octillion years. Defined as: ((5.0292)/((1000.0)*(1000.0))) × SI meter per square septillion years + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareOctillionYears = new (
                                                                         "rod per square octillion years"
                                                                       , "rd/Ryr²"
                                                                       , SI.Accelerations.MeterPerSquareSeptillionYears
                                                                       , 5.0292 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square decillion years. Defined as: ((4828.032)/((1000.0)*(1000.0))) × SI meter per square nonillion years + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecillionYears = new (
                                                                            "league per square decillion years"
                                                                          , "lea/decillion yr²"
                                                                          , SI.Accelerations
                                                                              .MeterPerSquareNonillionYears
                                                                          , 4828.032 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) rod per square nonillion years. Defined as: ((5.0292)/((1000.0)*(1000.0))) × SI meter per square octillion years + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareNonillionYears = new (
                                                                         "rod per square nonillion years"
                                                                       , "rd/Qyr²"
                                                                       , SI.Accelerations.MeterPerSquareOctillionYears
                                                                       , 5.0292 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square decillion years. Defined as: ((201.168)/((1000.0)*(1000.0))) × SI meter per square nonillion years + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecillionYears = new (
                                                                             "furlong per square decillion years"
                                                                           , "fur/decillion yr²"
                                                                           , SI.Accelerations
                                                                                     .MeterPerSquareNonillionYears
                                                                           , 201.168 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) league per square million years. Defined as: ((4828.032)/((1000.0)*(1000.0))) × SI meter per square millennium + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillionYears = new (
                                                                          "league per square million years"
                                                                        , "lea/Myr²"
                                                                        , SI.Accelerations.MeterPerSquareMillennium
                                                                        , 4828.032 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square quadrillion years. Defined as: ((201.168)/((1000.0)*(1000.0))) × SI meter per square trillion years + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuadrillionYears = new (
                                                                               "furlong per square quadrillion years"
                                                                             , "fur/Pyr²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareTrillionYears
                                                                             , 201.168 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) chain per square decillion years. Defined as: ((20.1168)/((1000.0)*(1000.0))) × SI meter per square nonillion years + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecillionYears = new (
                                                                           "chain per square decillion years"
                                                                         , "ch/decillion yr²"
                                                                         , SI.Accelerations.MeterPerSquareNonillionYears
                                                                         , 20.1168 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) furlong per square decade. Defined as: ((201.168)/((10.0)*(10.0))) × SI meter per square year + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecade = new (
                                                                     "furlong per square decade"
                                                                   , "fur/decade²"
                                                                   , SI.Accelerations.MeterPerSquareYear
                                                                   , 201.168 / (10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) chain per square million years. Defined as: ((20.1168)/((1000.0)*(1000.0))) × SI meter per square millennium + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillionYears = new (
                                                                         "chain per square million years"
                                                                       , "ch/Myr²"
                                                                       , SI.Accelerations.MeterPerSquareMillennium
                                                                       , 20.1168 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) rod per square decillion years. Defined as: ((5.0292)/((1000.0)*(1000.0))) × SI meter per square nonillion years + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareDecillionYears = new (
                                                                         "rod per square decillion years"
                                                                       , "rd/decillion yr²"
                                                                       , SI.Accelerations.MeterPerSquareNonillionYears
                                                                       , 5.0292 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) link per square second. Defined as: ((0.20116)/((1.0)*(1.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareSecond = new (
                                                                  "link per square second"
                                                                , "li/s²"
                                                                , SI.Accelerations.MeterPerSquareSecond
                                                                , 0.20116 / (1.0 * 1.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) link per square decisecond. Defined as: ((0.20116)/((1.0/10.0)*(1.0/10.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareDecisecond = new (
                                                                      "link per square decisecond"
                                                                    , "li/ds²"
                                                                    , SI.Accelerations.MeterPerSquareSecond
                                                                    , 0.20116 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) link per square centisecond. Defined as: ((0.20116)/((1.0/10.0)*(1.0/10.0))) × SI meter per square decisecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareCentisecond = new (
                                                                       "link per square centisecond"
                                                                     , "li/cs²"
                                                                     , SI.Accelerations.MeterPerSquareDecisecond
                                                                     , 0.20116 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) link per square millisecond. Defined as: ((0.20116)/((1.0/10.0)*(1.0/10.0))) × SI meter per square centisecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareMillisecond = new (
                                                                       "link per square millisecond"
                                                                     , "li/ms²"
                                                                     , SI.Accelerations.MeterPerSquareCentisecond
                                                                     , 0.20116 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) link per square microsecond. Defined as: ((0.20116)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square millisecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareMicrosecond = new (
                                                                       "link per square microsecond"
                                                                     , "li/μs²"
                                                                     , SI.Accelerations.MeterPerSquareMillisecond
                                                                     , 0.20116 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) link per square nanosecond. Defined as: ((0.20116)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square microsecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareNanosecond = new (
                                                                      "link per square nanosecond"
                                                                    , "li/ns²"
                                                                    , SI.Accelerations.MeterPerSquareMicrosecond
                                                                    , 0.20116 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) link per square picosecond. Defined as: ((0.20116)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square nanosecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquarePicosecond = new (
                                                                      "link per square picosecond"
                                                                    , "li/ps²"
                                                                    , SI.Accelerations.MeterPerSquareNanosecond
                                                                    , 0.20116 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) link per square femtosecond. Defined as: ((0.20116)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square picosecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareFemtosecond = new (
                                                                       "link per square femtosecond"
                                                                     , "li/fs²"
                                                                     , SI.Accelerations.MeterPerSquarePicosecond
                                                                     , 0.20116 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) link per square attosecond. Defined as: ((0.20116)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square femtosecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareAttosecond = new (
                                                                      "link per square attosecond"
                                                                    , "li/as²"
                                                                    , SI.Accelerations.MeterPerSquareFemtosecond
                                                                    , 0.20116 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) link per square zeptosecond. Defined as: ((0.20116)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square attosecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareZeptosecond = new (
                                                                       "link per square zeptosecond"
                                                                     , "li/zs²"
                                                                     , SI.Accelerations.MeterPerSquareAttosecond
                                                                     , 0.20116 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) link per square yoctosecond. Defined as: ((0.20116)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square zeptosecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareYoctosecond = new (
                                                                       "link per square yoctosecond"
                                                                     , "li/ys²"
                                                                     , SI.Accelerations.MeterPerSquareZeptosecond
                                                                     , 0.20116 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) link per square rontosecond. Defined as: ((0.20116)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square yoctosecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareRontosecond = new (
                                                                       "link per square rontosecond"
                                                                     , "li/rs²"
                                                                     , SI.Accelerations.MeterPerSquareYoctosecond
                                                                     , 0.20116 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) link per square quectosecond. Defined as: ((0.20116)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square rontosecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareQuectosecond = new (
                                                                        "link per square quectosecond"
                                                                      , "li/qs²"
                                                                      , SI.Accelerations.MeterPerSquareRontosecond
                                                                      , 0.20116 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) link per square minute. Defined as: ((0.20116)/((60.0)*(60.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareMinute = new (
                                                                  "link per square minute"
                                                                , "li/min²"
                                                                , SI.Accelerations.MeterPerSquareSecond
                                                                , 0.20116 / (60.0 * 60.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) rod per square second. Defined as: ((5.0292)/((1.0)*(1.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareSecond = new (
                                                                 "rod per square second"
                                                               , "rd/s²"
                                                               , SI.Accelerations.MeterPerSquareSecond
                                                               , 5.0292 / (1.0 * 1.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) rod per square decisecond. Defined as: ((5.0292)/((1.0/10.0)*(1.0/10.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareDecisecond = new (
                                                                     "rod per square decisecond"
                                                                   , "rd/ds²"
                                                                   , SI.Accelerations.MeterPerSquareSecond
                                                                   , 5.0292 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rod per square centisecond. Defined as: ((5.0292)/((1.0/10.0)*(1.0/10.0))) × SI meter per square decisecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareCentisecond = new (
                                                                      "rod per square centisecond"
                                                                    , "rd/cs²"
                                                                    , SI.Accelerations.MeterPerSquareDecisecond
                                                                    , 5.0292 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rod per square millisecond. Defined as: ((5.0292)/((1.0/10.0)*(1.0/10.0))) × SI meter per square centisecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareMillisecond = new (
                                                                      "rod per square millisecond"
                                                                    , "rd/ms²"
                                                                    , SI.Accelerations.MeterPerSquareCentisecond
                                                                    , 5.0292 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rod per square microsecond. Defined as: ((5.0292)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square millisecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareMicrosecond = new (
                                                                      "rod per square microsecond"
                                                                    , "rd/μs²"
                                                                    , SI.Accelerations.MeterPerSquareMillisecond
                                                                    , 5.0292 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rod per square nanosecond. Defined as: ((5.0292)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square microsecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareNanosecond = new (
                                                                     "rod per square nanosecond"
                                                                   , "rd/ns²"
                                                                   , SI.Accelerations.MeterPerSquareMicrosecond
                                                                   , 5.0292 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rod per square picosecond. Defined as: ((5.0292)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square nanosecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquarePicosecond = new (
                                                                     "rod per square picosecond"
                                                                   , "rd/ps²"
                                                                   , SI.Accelerations.MeterPerSquareNanosecond
                                                                   , 5.0292 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rod per square femtosecond. Defined as: ((5.0292)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square picosecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareFemtosecond = new (
                                                                      "rod per square femtosecond"
                                                                    , "rd/fs²"
                                                                    , SI.Accelerations.MeterPerSquarePicosecond
                                                                    , 5.0292 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rod per square attosecond. Defined as: ((5.0292)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square femtosecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareAttosecond = new (
                                                                     "rod per square attosecond"
                                                                   , "rd/as²"
                                                                   , SI.Accelerations.MeterPerSquareFemtosecond
                                                                   , 5.0292 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rod per square zeptosecond. Defined as: ((5.0292)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square attosecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareZeptosecond = new (
                                                                      "rod per square zeptosecond"
                                                                    , "rd/zs²"
                                                                    , SI.Accelerations.MeterPerSquareAttosecond
                                                                    , 5.0292 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rod per square yoctosecond. Defined as: ((5.0292)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square zeptosecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareYoctosecond = new (
                                                                      "rod per square yoctosecond"
                                                                    , "rd/ys²"
                                                                    , SI.Accelerations.MeterPerSquareZeptosecond
                                                                    , 5.0292 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rod per square rontosecond. Defined as: ((5.0292)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square yoctosecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareRontosecond = new (
                                                                      "rod per square rontosecond"
                                                                    , "rd/rs²"
                                                                    , SI.Accelerations.MeterPerSquareYoctosecond
                                                                    , 5.0292 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rod per square quectosecond. Defined as: ((5.0292)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square rontosecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareQuectosecond = new (
                                                                       "rod per square quectosecond"
                                                                     , "rd/qs²"
                                                                     , SI.Accelerations.MeterPerSquareRontosecond
                                                                     , 5.0292 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) link per square hour. Defined as: ((0.20116)/((60.0)*(60.0))) × SI meter per square minute + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareHour = new (
                                                                "link per square hour"
                                                              , "li/hr²"
                                                              , SI.Accelerations.MeterPerSquareMinute
                                                              , 0.20116 / (60.0 * 60.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) chain per square second. Defined as: ((20.1168)/((1.0)*(1.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareSecond = new (
                                                                   "chain per square second"
                                                                 , "ch/s²"
                                                                 , SI.Accelerations.MeterPerSquareSecond
                                                                 , 20.1168 / (1.0 * 1.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) chain per square decisecond. Defined as: ((20.1168)/((1.0/10.0)*(1.0/10.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareDecisecond = new (
                                                                       "chain per square decisecond"
                                                                     , "ch/ds²"
                                                                     , SI.Accelerations.MeterPerSquareSecond
                                                                     , 20.1168 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) chain per square centisecond. Defined as: ((20.1168)/((1.0/10.0)*(1.0/10.0))) × SI meter per square decisecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareCentisecond = new (
                                                                        "chain per square centisecond"
                                                                      , "ch/cs²"
                                                                      , SI.Accelerations.MeterPerSquareDecisecond
                                                                      , 20.1168 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square millisecond. Defined as: ((20.1168)/((1.0/10.0)*(1.0/10.0))) × SI meter per square centisecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareMillisecond = new (
                                                                        "chain per square millisecond"
                                                                      , "ch/ms²"
                                                                      , SI.Accelerations.MeterPerSquareCentisecond
                                                                      , 20.1168 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square microsecond. Defined as: ((20.1168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square millisecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareMicrosecond = new (
                                                                        "chain per square microsecond"
                                                                      , "ch/μs²"
                                                                      , SI.Accelerations.MeterPerSquareMillisecond
                                                                      , 20.1168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square nanosecond. Defined as: ((20.1168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square microsecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareNanosecond = new (
                                                                       "chain per square nanosecond"
                                                                     , "ch/ns²"
                                                                     , SI.Accelerations.MeterPerSquareMicrosecond
                                                                     , 20.1168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) chain per square picosecond. Defined as: ((20.1168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square nanosecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquarePicosecond = new (
                                                                       "chain per square picosecond"
                                                                     , "ch/ps²"
                                                                     , SI.Accelerations.MeterPerSquareNanosecond
                                                                     , 20.1168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) chain per square femtosecond. Defined as: ((20.1168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square picosecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareFemtosecond = new (
                                                                        "chain per square femtosecond"
                                                                      , "ch/fs²"
                                                                      , SI.Accelerations.MeterPerSquarePicosecond
                                                                      , 20.1168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square attosecond. Defined as: ((20.1168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square femtosecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareAttosecond = new (
                                                                       "chain per square attosecond"
                                                                     , "ch/as²"
                                                                     , SI.Accelerations.MeterPerSquareFemtosecond
                                                                     , 20.1168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) chain per square zeptosecond. Defined as: ((20.1168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square attosecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareZeptosecond = new (
                                                                        "chain per square zeptosecond"
                                                                      , "ch/zs²"
                                                                      , SI.Accelerations.MeterPerSquareAttosecond
                                                                      , 20.1168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square yoctosecond. Defined as: ((20.1168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square zeptosecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareYoctosecond = new (
                                                                        "chain per square yoctosecond"
                                                                      , "ch/ys²"
                                                                      , SI.Accelerations.MeterPerSquareZeptosecond
                                                                      , 20.1168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square rontosecond. Defined as: ((20.1168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square yoctosecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareRontosecond = new (
                                                                        "chain per square rontosecond"
                                                                      , "ch/rs²"
                                                                      , SI.Accelerations.MeterPerSquareYoctosecond
                                                                      , 20.1168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) chain per square quectosecond. Defined as: ((20.1168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square rontosecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuectosecond = new (
                                                                         "chain per square quectosecond"
                                                                       , "ch/qs²"
                                                                       , SI.Accelerations.MeterPerSquareRontosecond
                                                                       , 20.1168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) link per square day. Defined as: ((0.20116)/((24.0)*(24.0))) × SI meter per square hour + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareDay = new (
                                                               "link per square day"
                                                             , "li/dy²"
                                                             , SI.Accelerations.MeterPerSquareHour
                                                             , 0.20116 / (24.0 * 24.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per square second. Defined as: ((201.168)/((1.0)*(1.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSecond = new (
                                                                     "furlong per square second"
                                                                   , "fur/s²"
                                                                   , SI.Accelerations.MeterPerSquareSecond
                                                                   , 201.168 / (1.0 * 1.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) furlong per square decisecond. Defined as: ((201.168)/((1.0/10.0)*(1.0/10.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDecisecond = new (
                                                                         "furlong per square decisecond"
                                                                       , "fur/ds²"
                                                                       , SI.Accelerations.MeterPerSquareSecond
                                                                       , 201.168 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square centisecond. Defined as: ((201.168)/((1.0/10.0)*(1.0/10.0))) × SI meter per square decisecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareCentisecond = new (
                                                                          "furlong per square centisecond"
                                                                        , "fur/cs²"
                                                                        , SI.Accelerations.MeterPerSquareDecisecond
                                                                        , 201.168 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square millisecond. Defined as: ((201.168)/((1.0/10.0)*(1.0/10.0))) × SI meter per square centisecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillisecond = new (
                                                                          "furlong per square millisecond"
                                                                        , "fur/ms²"
                                                                        , SI.Accelerations.MeterPerSquareCentisecond
                                                                        , 201.168 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square microsecond. Defined as: ((201.168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square millisecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMicrosecond = new (
                                                                          "furlong per square microsecond"
                                                                        , "fur/μs²"
                                                                        , SI.Accelerations.MeterPerSquareMillisecond
                                                                        , 201.168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square nanosecond. Defined as: ((201.168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square microsecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareNanosecond = new (
                                                                         "furlong per square nanosecond"
                                                                       , "fur/ns²"
                                                                       , SI.Accelerations.MeterPerSquareMicrosecond
                                                                       , 201.168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square picosecond. Defined as: ((201.168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square nanosecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquarePicosecond = new (
                                                                         "furlong per square picosecond"
                                                                       , "fur/ps²"
                                                                       , SI.Accelerations.MeterPerSquareNanosecond
                                                                       , 201.168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square femtosecond. Defined as: ((201.168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square picosecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareFemtosecond = new (
                                                                          "furlong per square femtosecond"
                                                                        , "fur/fs²"
                                                                        , SI.Accelerations.MeterPerSquarePicosecond
                                                                        , 201.168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square attosecond. Defined as: ((201.168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square femtosecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareAttosecond = new (
                                                                         "furlong per square attosecond"
                                                                       , "fur/as²"
                                                                       , SI.Accelerations.MeterPerSquareFemtosecond
                                                                       , 201.168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square zeptosecond. Defined as: ((201.168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square attosecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareZeptosecond = new (
                                                                          "furlong per square zeptosecond"
                                                                        , "fur/zs²"
                                                                        , SI.Accelerations.MeterPerSquareAttosecond
                                                                        , 201.168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square yoctosecond. Defined as: ((201.168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square zeptosecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareYoctosecond = new (
                                                                          "furlong per square yoctosecond"
                                                                        , "fur/ys²"
                                                                        , SI.Accelerations.MeterPerSquareZeptosecond
                                                                        , 201.168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square rontosecond. Defined as: ((201.168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square yoctosecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareRontosecond = new (
                                                                          "furlong per square rontosecond"
                                                                        , "fur/rs²"
                                                                        , SI.Accelerations.MeterPerSquareYoctosecond
                                                                        , 201.168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) furlong per square quectosecond. Defined as: ((201.168)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square rontosecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuectosecond = new (
                                                                           "furlong per square quectosecond"
                                                                         , "fur/qs²"
                                                                         , SI.Accelerations.MeterPerSquareRontosecond
                                                                         , 201.168 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) link per square week. Defined as: ((0.20116)/((7.0)*(7.0))) × SI meter per square day + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareWeek = new (
                                                                "link per square week"
                                                              , "li/wk²"
                                                              , SI.Accelerations.MeterPerSquareDay
                                                              , 0.20116 / (7.0 * 7.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) league per square second. Defined as: ((4828.032)/((1.0)*(1.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSecond = new (
                                                                    "league per square second"
                                                                  , "lea/s²"
                                                                  , SI.Accelerations.MeterPerSquareSecond
                                                                  , 4828.032 / (1.0 * 1.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) league per square decisecond. Defined as: ((4828.032)/((1.0/10.0)*(1.0/10.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecisecond = new (
                                                                        "league per square decisecond"
                                                                      , "lea/ds²"
                                                                      , SI.Accelerations.MeterPerSquareSecond
                                                                      , 4828.032 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square centisecond. Defined as: ((4828.032)/((1.0/10.0)*(1.0/10.0))) × SI meter per square decisecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareCentisecond = new (
                                                                         "league per square centisecond"
                                                                       , "lea/cs²"
                                                                       , SI.Accelerations.MeterPerSquareDecisecond
                                                                       , 4828.032 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square millisecond. Defined as: ((4828.032)/((1.0/10.0)*(1.0/10.0))) × SI meter per square centisecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMillisecond = new (
                                                                         "league per square millisecond"
                                                                       , "lea/ms²"
                                                                       , SI.Accelerations.MeterPerSquareCentisecond
                                                                       , 4828.032 / (1.0 / 10.0 * (1.0 / 10.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square microsecond. Defined as: ((4828.032)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square millisecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMicrosecond = new (
                                                                         "league per square microsecond"
                                                                       , "lea/μs²"
                                                                       , SI.Accelerations.MeterPerSquareMillisecond
                                                                       , 4828.032 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square nanosecond. Defined as: ((4828.032)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square microsecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareNanosecond = new (
                                                                        "league per square nanosecond"
                                                                      , "lea/ns²"
                                                                      , SI.Accelerations.MeterPerSquareMicrosecond
                                                                      , 4828.032 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square picosecond. Defined as: ((4828.032)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square nanosecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePicosecond = new (
                                                                        "league per square picosecond"
                                                                      , "lea/ps²"
                                                                      , SI.Accelerations.MeterPerSquareNanosecond
                                                                      , 4828.032 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square femtosecond. Defined as: ((4828.032)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square picosecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareFemtosecond = new (
                                                                         "league per square femtosecond"
                                                                       , "lea/fs²"
                                                                       , SI.Accelerations.MeterPerSquarePicosecond
                                                                       , 4828.032 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square attosecond. Defined as: ((4828.032)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square femtosecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareAttosecond = new (
                                                                        "league per square attosecond"
                                                                      , "lea/as²"
                                                                      , SI.Accelerations.MeterPerSquareFemtosecond
                                                                      , 4828.032 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) league per square zeptosecond. Defined as: ((4828.032)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square attosecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareZeptosecond = new (
                                                                         "league per square zeptosecond"
                                                                       , "lea/zs²"
                                                                       , SI.Accelerations.MeterPerSquareAttosecond
                                                                       , 4828.032 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square yoctosecond. Defined as: ((4828.032)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square zeptosecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYoctosecond = new (
                                                                         "league per square yoctosecond"
                                                                       , "lea/ys²"
                                                                       , SI.Accelerations.MeterPerSquareZeptosecond
                                                                       , 4828.032 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square rontosecond. Defined as: ((4828.032)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square yoctosecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareRontosecond = new (
                                                                         "league per square rontosecond"
                                                                       , "lea/rs²"
                                                                       , SI.Accelerations.MeterPerSquareYoctosecond
                                                                       , 4828.032 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) league per square quectosecond. Defined as: ((4828.032)/((1.0/1000.0)*(1.0/1000.0))) × SI meter per square rontosecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareQuectosecond = new (
                                                                          "league per square quectosecond"
                                                                        , "lea/qs²"
                                                                        , SI.Accelerations.MeterPerSquareRontosecond
                                                                        , 4828.032 / (1.0 / 1000.0 * (1.0 / 1000.0))
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) link per square year. Defined as: ((0.20116)/((365.2525)*(365.2525))) × SI meter per square day + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareYear = new (
                                                                "link per square year"
                                                              , "li/yr²"
                                                              , SI.Accelerations.MeterPerSquareDay
                                                              , 0.20116 / (365.2525 * 365.2525)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) link per square decade. Defined as: ((0.20116)/((10.0)*(10.0))) × SI meter per square year + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareDecade = new (
                                                                  "link per square decade"
                                                                , "li/decade²"
                                                                , SI.Accelerations.MeterPerSquareYear
                                                                , 0.20116 / (10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) link per square century. Defined as: ((0.20116)/((10.0)*(10.0))) × SI meter per square decade + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareCentury = new (
                                                                   "link per square century"
                                                                 , "li/century²"
                                                                 , SI.Accelerations.MeterPerSquareDecade
                                                                 , 0.20116 / (10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) link per square millennium. Defined as: ((0.20116)/((10.0)*(10.0))) × SI meter per square century + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareMillennium = new (
                                                                      "link per square millennium"
                                                                    , "li/kyr²"
                                                                    , SI.Accelerations.MeterPerSquareCentury
                                                                    , 0.20116 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) link per square million years. Defined as: ((0.20116)/((1000.0)*(1000.0))) × SI meter per square millennium + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareMillionYears = new (
                                                                        "link per square million years"
                                                                      , "li/Myr²"
                                                                      , SI.Accelerations.MeterPerSquareMillennium
                                                                      , 0.20116 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) link per square billion years. Defined as: ((0.20116)/((1000.0)*(1000.0))) × SI meter per square million years + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareBillionYears = new (
                                                                        "link per square billion years"
                                                                      , "li/Gyr²"
                                                                      , SI.Accelerations.MeterPerSquareMillionYears
                                                                      , 0.20116 / (1000.0 * 1000.0)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) link per square trillion years. Defined as: ((0.20116)/((1000.0)*(1000.0))) × SI meter per square billion years + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareTrillionYears = new (
                                                                         "link per square trillion years"
                                                                       , "li/Tyr²"
                                                                       , SI.Accelerations.MeterPerSquareBillionYears
                                                                       , 0.20116 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) link per square quadrillion years. Defined as: ((0.20116)/((1000.0)*(1000.0))) × SI meter per square trillion years + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareQuadrillionYears = new (
                                                                            "link per square quadrillion years"
                                                                          , "li/Pyr²"
                                                                          , SI.Accelerations.MeterPerSquareTrillionYears
                                                                          , 0.20116 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) link per square quintillion years. Defined as: ((0.20116)/((1000.0)*(1000.0))) × SI meter per square quadrillion years + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareQuintillionYears = new (
                                                                            "link per square quintillion years"
                                                                          , "li/Eyr²"
                                                                          , SI.Accelerations
                                                                              .MeterPerSquareQuadrillionYears
                                                                          , 0.20116 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) link per square sextillion years. Defined as: ((0.20116)/((1000.0)*(1000.0))) × SI meter per square quintillion years + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareSextillionYears = new (
                                                                           "link per square sextillion years"
                                                                         , "li/Zyr²"
                                                                         , SI.Accelerations
                                                                             .MeterPerSquareQuintillionYears
                                                                         , 0.20116 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) link per square septillion years. Defined as: ((0.20116)/((1000.0)*(1000.0))) × SI meter per square sextillion years + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareSeptillionYears = new (
                                                                           "link per square septillion years"
                                                                         , "li/Yyr²"
                                                                         , SI.Accelerations
                                                                             .MeterPerSquareSextillionYears
                                                                         , 0.20116 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) link per square octillion years. Defined as: ((0.20116)/((1000.0)*(1000.0))) × SI meter per square septillion years + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareOctillionYears = new (
                                                                          "link per square octillion years"
                                                                        , "li/Ryr²"
                                                                        , SI.Accelerations.MeterPerSquareSeptillionYears
                                                                        , 0.20116 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) link per square nonillion years. Defined as: ((0.20116)/((1000.0)*(1000.0))) × SI meter per square octillion years + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareNonillionYears = new (
                                                                          "link per square nonillion years"
                                                                        , "li/Qyr²"
                                                                        , SI.Accelerations.MeterPerSquareOctillionYears
                                                                        , 0.20116 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) link per square decillion years. Defined as: ((0.20116)/((1000.0)*(1000.0))) × SI meter per square nonillion years + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareDecillionYears = new (
                                                                          "link per square decillion years"
                                                                        , "li/decillion yr²"
                                                                        , SI.Accelerations.MeterPerSquareNonillionYears
                                                                        , 0.20116 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) link per square planck-time. Defined as: ((0.20116)/((5.391247E-38)*(5.391247E-38))) × SI meter per square microsecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquarePlanckTime = new (
                                                                      "link per square planck-time"
                                                                    , "li/tₚ²"
                                                                    , SI.Accelerations.MeterPerSquareMicrosecond
                                                                    , 0.20116 / (5.391247E-38 * 5.391247E-38)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) link per square tick. Defined as: ((0.20116)/((100.0)*(100.0))) × SI meter per square nanosecond + (0).
   /// </summary>
   public static readonly Acceleration LinkPerSquareTick = new (
                                                                "link per square tick"
                                                              , "li/tick²"
                                                              , SI.Accelerations.MeterPerSquareNanosecond
                                                              , 0.20116 / (100.0 * 100.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) rod per square planck-time. Defined as: ((5.0292)/((5.391247E-38)*(5.391247E-38))) × SI meter per square microsecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquarePlanckTime = new (
                                                                     "rod per square planck-time"
                                                                   , "rd/tₚ²"
                                                                   , SI.Accelerations.MeterPerSquareMicrosecond
                                                                   , 5.0292 / (5.391247E-38 * 5.391247E-38)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) league per square sextillion years. Defined as: ((4828.032)/((1000.0)*(1000.0))) × SI meter per square quintillion years + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSextillionYears = new (
                                                                             "league per square sextillion years"
                                                                           , "lea/Zyr²"
                                                                           , SI.Accelerations
                                                                                     .MeterPerSquareQuintillionYears
                                                                           , 4828.032 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) rod per square minute. Defined as: ((5.0292)/((60.0)*(60.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareMinute = new (
                                                                 "rod per square minute"
                                                               , "rd/min²"
                                                               , SI.Accelerations.MeterPerSquareSecond
                                                               , 5.0292 / (60.0 * 60.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) chain per square planck-time. Defined as: ((20.1168)/((5.391247E-38)*(5.391247E-38))) × SI meter per square microsecond + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquarePlanckTime = new (
                                                                       "chain per square planck-time"
                                                                     , "ch/tₚ²"
                                                                     , SI.Accelerations.MeterPerSquareMicrosecond
                                                                     , 20.1168 / (5.391247E-38 * 5.391247E-38)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) furlong per square tick. Defined as: ((201.168)/((100.0)*(100.0))) × SI meter per square nanosecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareTick = new (
                                                                   "furlong per square tick"
                                                                 , "fur/tick²"
                                                                 , SI.Accelerations.MeterPerSquareNanosecond
                                                                 , 201.168 / (100.0 * 100.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) league per square year. Defined as: ((4828.032)/((365.2525)*(365.2525))) × SI meter per square day + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareYear = new (
                                                                  "league per square year"
                                                                , "lea/yr²"
                                                                , SI.Accelerations.MeterPerSquareDay
                                                                , 4828.032 / (365.2525 * 365.2525)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) chain per square billion years. Defined as: ((20.1168)/((1000.0)*(1000.0))) × SI meter per square million years + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareBillionYears = new (
                                                                         "chain per square billion years"
                                                                       , "ch/Gyr²"
                                                                       , SI.Accelerations.MeterPerSquareMillionYears
                                                                       , 20.1168 / (1000.0 * 1000.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) furlong per square planck-time. Defined as: ((201.168)/((5.391247E-38)*(5.391247E-38))) × SI meter per square microsecond + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquarePlanckTime = new (
                                                                         "furlong per square planck-time"
                                                                       , "fur/tₚ²"
                                                                       , SI.Accelerations.MeterPerSquareMicrosecond
                                                                       , 201.168 / (5.391247E-38 * 5.391247E-38)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) rod per square hour. Defined as: ((5.0292)/((60.0)*(60.0))) × SI meter per square minute + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareHour = new (
                                                               "rod per square hour"
                                                             , "rd/hr²"
                                                             , SI.Accelerations.MeterPerSquareMinute
                                                             , 5.0292 / (60.0 * 60.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) chain per square minute. Defined as: ((20.1168)/((60.0)*(60.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareMinute = new (
                                                                   "chain per square minute"
                                                                 , "ch/min²"
                                                                 , SI.Accelerations.MeterPerSquareSecond
                                                                 , 20.1168 / (60.0 * 60.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) furlong per square quintillion years. Defined as: ((201.168)/((1000.0)*(1000.0))) × SI meter per square quadrillion years + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareQuintillionYears = new (
                                                                               "furlong per square quintillion years"
                                                                             , "fur/Eyr²"
                                                                             , SI.Accelerations
                                                                                       .MeterPerSquareQuadrillionYears
                                                                             , 201.168 / (1000.0 * 1000.0)
                                                                             , 0
                                                                              );

   /// <summary>
   /// A(n) league per square planck-time. Defined as: ((4828.032)/((5.391247E-38)*(5.391247E-38))) × SI meter per square microsecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquarePlanckTime = new (
                                                                        "league per square planck-time"
                                                                      , "lea/tₚ²"
                                                                      , SI.Accelerations.MeterPerSquareMicrosecond
                                                                      , 4828.032 / (5.391247E-38 * 5.391247E-38)
                                                                      , 0
                                                                       );

   /// <summary>
   /// A(n) furlong per square century. Defined as: ((201.168)/((10.0)*(10.0))) × SI meter per square decade + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareCentury = new (
                                                                      "furlong per square century"
                                                                    , "fur/century²"
                                                                    , SI.Accelerations.MeterPerSquareDecade
                                                                    , 201.168 / (10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rod per square day. Defined as: ((5.0292)/((24.0)*(24.0))) × SI meter per square hour + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareDay = new (
                                                              "rod per square day"
                                                            , "rd/dy²"
                                                            , SI.Accelerations.MeterPerSquareHour
                                                            , 5.0292 / (24.0 * 24.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) furlong per square minute. Defined as: ((201.168)/((60.0)*(60.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMinute = new (
                                                                     "furlong per square minute"
                                                                   , "fur/min²"
                                                                   , SI.Accelerations.MeterPerSquareSecond
                                                                   , 201.168 / (60.0 * 60.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) league per square billion years. Defined as: ((4828.032)/((1000.0)*(1000.0))) × SI meter per square million years + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareBillionYears = new (
                                                                          "league per square billion years"
                                                                        , "lea/Gyr²"
                                                                        , SI.Accelerations.MeterPerSquareMillionYears
                                                                        , 4828.032 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) chain per square trillion years. Defined as: ((20.1168)/((1000.0)*(1000.0))) × SI meter per square billion years + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareTrillionYears = new (
                                                                          "chain per square trillion years"
                                                                        , "ch/Tyr²"
                                                                        , SI.Accelerations.MeterPerSquareBillionYears
                                                                        , 20.1168 / (1000.0 * 1000.0)
                                                                        , 0
                                                                         );

   /// <summary>
   /// A(n) chain per square hour. Defined as: ((20.1168)/((60.0)*(60.0))) × SI meter per square minute + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareHour = new (
                                                                 "chain per square hour"
                                                               , "ch/hr²"
                                                               , SI.Accelerations.MeterPerSquareMinute
                                                               , 20.1168 / (60.0 * 60.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) rod per square week. Defined as: ((5.0292)/((7.0)*(7.0))) × SI meter per square day + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareWeek = new (
                                                               "rod per square week"
                                                             , "rd/wk²"
                                                             , SI.Accelerations.MeterPerSquareDay
                                                             , 5.0292 / (7.0 * 7.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) league per square minute. Defined as: ((4828.032)/((60.0)*(60.0))) × SI meter per square second + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareMinute = new (
                                                                    "league per square minute"
                                                                  , "lea/min²"
                                                                  , SI.Accelerations.MeterPerSquareSecond
                                                                  , 4828.032 / (60.0 * 60.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) league per square septillion years. Defined as: ((4828.032)/((1000.0)*(1000.0))) × SI meter per square sextillion years + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareSeptillionYears = new (
                                                                             "league per square septillion years"
                                                                           , "lea/Yyr²"
                                                                           , SI.Accelerations
                                                                                     .MeterPerSquareSextillionYears
                                                                           , 4828.032 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) rod per square year. Defined as: ((5.0292)/((365.2525)*(365.2525))) × SI meter per square day + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareYear = new (
                                                               "rod per square year"
                                                             , "rd/yr²"
                                                             , SI.Accelerations.MeterPerSquareDay
                                                             , 5.0292 / (365.2525 * 365.2525)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) furlong per square sextillion years. Defined as: ((201.168)/((1000.0)*(1000.0))) × SI meter per square quintillion years + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSextillionYears = new (
                                                                              "furlong per square sextillion years"
                                                                            , "fur/Zyr²"
                                                                            , SI.Accelerations
                                                                                      .MeterPerSquareQuintillionYears
                                                                            , 201.168 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) league per square decade. Defined as: ((4828.032)/((10.0)*(10.0))) × SI meter per square year + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareDecade = new (
                                                                    "league per square decade"
                                                                  , "lea/decade²"
                                                                  , SI.Accelerations.MeterPerSquareYear
                                                                  , 4828.032 / (10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) furlong per square millennium. Defined as: ((201.168)/((10.0)*(10.0))) × SI meter per square century + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillennium = new (
                                                                         "furlong per square millennium"
                                                                       , "fur/kyr²"
                                                                       , SI.Accelerations.MeterPerSquareCentury
                                                                       , 201.168 / (10.0 * 10.0)
                                                                       , 0
                                                                        );

   /// <summary>
   /// A(n) chain per square quadrillion years. Defined as: ((20.1168)/((1000.0)*(1000.0))) × SI meter per square trillion years + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuadrillionYears = new (
                                                                             "chain per square quadrillion years"
                                                                           , "ch/Pyr²"
                                                                           , SI.Accelerations
                                                                                     .MeterPerSquareTrillionYears
                                                                           , 20.1168 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) chain per square day. Defined as: ((20.1168)/((24.0)*(24.0))) × SI meter per square hour + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareDay = new (
                                                                "chain per square day"
                                                              , "ch/dy²"
                                                              , SI.Accelerations.MeterPerSquareHour
                                                              , 20.1168 / (24.0 * 24.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) furlong per square hour. Defined as: ((201.168)/((60.0)*(60.0))) × SI meter per square minute + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareHour = new (
                                                                   "furlong per square hour"
                                                                 , "fur/hr²"
                                                                 , SI.Accelerations.MeterPerSquareMinute
                                                                 , 201.168 / (60.0 * 60.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rod per square decade. Defined as: ((5.0292)/((10.0)*(10.0))) × SI meter per square year + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareDecade = new (
                                                                 "rod per square decade"
                                                               , "rd/decade²"
                                                               , SI.Accelerations.MeterPerSquareYear
                                                               , 5.0292 / (10.0 * 10.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) rod per square tick. Defined as: ((5.0292)/((100.0)*(100.0))) × SI meter per square nanosecond + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareTick = new (
                                                               "rod per square tick"
                                                             , "rd/tick²"
                                                             , SI.Accelerations.MeterPerSquareNanosecond
                                                             , 5.0292 / (100.0 * 100.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) rod per square century. Defined as: ((5.0292)/((10.0)*(10.0))) × SI meter per square decade + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareCentury = new (
                                                                  "rod per square century"
                                                                , "rd/century²"
                                                                , SI.Accelerations.MeterPerSquareDecade
                                                                , 5.0292 / (10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) league per square trillion years. Defined as: ((4828.032)/((1000.0)*(1000.0))) × SI meter per square billion years + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTrillionYears = new (
                                                                           "league per square trillion years"
                                                                         , "lea/Tyr²"
                                                                         , SI.Accelerations.MeterPerSquareBillionYears
                                                                         , 4828.032 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) chain per square quintillion years. Defined as: ((20.1168)/((1000.0)*(1000.0))) × SI meter per square quadrillion years + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareQuintillionYears = new (
                                                                             "chain per square quintillion years"
                                                                           , "ch/Eyr²"
                                                                           , SI.Accelerations
                                                                                     .MeterPerSquareQuadrillionYears
                                                                           , 20.1168 / (1000.0 * 1000.0)
                                                                           , 0
                                                                            );

   /// <summary>
   /// A(n) league per square tick. Defined as: ((4828.032)/((100.0)*(100.0))) × SI meter per square nanosecond + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareTick = new (
                                                                  "league per square tick"
                                                                , "lea/tick²"
                                                                , SI.Accelerations.MeterPerSquareNanosecond
                                                                , 4828.032 / (100.0 * 100.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) chain per square week. Defined as: ((20.1168)/((7.0)*(7.0))) × SI meter per square day + (0).
   /// </summary>
   public static readonly Acceleration ChainPerSquareWeek = new (
                                                                 "chain per square week"
                                                               , "ch/wk²"
                                                               , SI.Accelerations.MeterPerSquareDay
                                                               , 20.1168 / (7.0 * 7.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) league per square hour. Defined as: ((4828.032)/((60.0)*(60.0))) × SI meter per square minute + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareHour = new (
                                                                  "league per square hour"
                                                                , "lea/hr²"
                                                                , SI.Accelerations.MeterPerSquareMinute
                                                                , 4828.032 / (60.0 * 60.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) rod per square millennium. Defined as: ((5.0292)/((10.0)*(10.0))) × SI meter per square century + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareMillennium = new (
                                                                     "rod per square millennium"
                                                                   , "rd/kyr²"
                                                                   , SI.Accelerations.MeterPerSquareCentury
                                                                   , 5.0292 / (10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) furlong per square septillion years. Defined as: ((201.168)/((1000.0)*(1000.0))) × SI meter per square sextillion years + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareSeptillionYears = new (
                                                                              "furlong per square septillion years"
                                                                            , "fur/Yyr²"
                                                                            , SI.Accelerations
                                                                                      .MeterPerSquareSextillionYears
                                                                            , 201.168 / (1000.0 * 1000.0)
                                                                            , 0
                                                                             );

   /// <summary>
   /// A(n) furlong per square million years. Defined as: ((201.168)/((1000.0)*(1000.0))) × SI meter per square millennium + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareMillionYears = new (
                                                                           "furlong per square million years"
                                                                         , "fur/Myr²"
                                                                         , SI.Accelerations.MeterPerSquareMillennium
                                                                         , 201.168 / (1000.0 * 1000.0)
                                                                         , 0
                                                                          );

   /// <summary>
   /// A(n) league per square octillion years. Defined as: ((4828.032)/((1000.0)*(1000.0))) × SI meter per square septillion years + (0).
   /// </summary>
   public static readonly Acceleration LeaguePerSquareOctillionYears = new (
                                                                            "league per square octillion years"
                                                                          , "lea/Ryr²"
                                                                          , SI.Accelerations
                                                                              .MeterPerSquareSeptillionYears
                                                                          , 4828.032 / (1000.0 * 1000.0)
                                                                          , 0
                                                                           );

   /// <summary>
   /// A(n) furlong per square day. Defined as: ((201.168)/((24.0)*(24.0))) × SI meter per square hour + (0).
   /// </summary>
   public static readonly Acceleration FurlongPerSquareDay = new (
                                                                  "furlong per square day"
                                                                , "fur/dy²"
                                                                , SI.Accelerations.MeterPerSquareHour
                                                                , 201.168 / (24.0 * 24.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) rod per square million years. Defined as: ((5.0292)/((1000.0)*(1000.0))) × SI meter per square millennium + (0).
   /// </summary>
   public static readonly Acceleration RodPerSquareMillionYears = new (
                                                                       "rod per square million years"
                                                                     , "rd/Myr²"
                                                                     , SI.Accelerations.MeterPerSquareMillennium
                                                                     , 5.0292 / (1000.0 * 1000.0)
                                                                     , 0
                                                                      );
}