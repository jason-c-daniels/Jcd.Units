﻿#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.Imperial;

/// <summary>
/// British Imperial Units for measuring Volume.
/// </summary>
public class Volumes : UnitOfMeasureEnumeration<Volumes, Volume>
{
   /// <summary>
   /// A(n) cubic inch. Defined in terms of a(n) SI cubic centimeter.
   /// </summary>
   public static readonly Volume CubicInch = new (
                                                  "cubic inch"
                                                , "in.³"
                                                , SI.Volumes.CubicCentimeter
                                                , 2.54 * 2.54 * 2.54
                                                , 0
                                                 );

   /// <summary>
   /// A(n) fluid ounce. Defined in terms of a(n) SI milliliter.
   /// </summary>
   public static readonly Volume FluidOunce = new ("fluid ounce", "fl oz", SI.Volumes.Milliliter, 28.4130625, 0);

   /// <summary>
   /// A(n) cubic foot. Defined in terms of a(n) cubic inch.
   /// </summary>
   public static readonly Volume CubicFoot = new ("cubic foot", "ft.³", CubicInch, 12 * 12 * 12, 0);

   /// <summary>
   /// A(n) gill. Defined in terms of a(n) fluid ounce.
   /// </summary>
   public static readonly Volume Gill = new ("gill", "gi", FluidOunce, 5.0, 0);

   /// <summary>
   /// A(n) cubic twip. Defined in terms of a(n) cubic foot.
   /// </summary>
   public static readonly Volume CubicTwip = new (
                                                  "cubic twip"
                                                , "twip³"
                                                , CubicFoot
                                                , 1.0 / 17280.0 * (1.0 / 17280.0) * (1.0 / 17280.0)
                                                , 0
                                                 );

   /// <summary>
   /// A(n) pint. Defined in terms of a(n) fluid ounce.
   /// </summary>
   public static readonly Volume Pint = new ("pint", "pt", FluidOunce, 20.0, 0);

   /// <summary>
   /// A(n) cubic thou. Defined in terms of a(n) cubic foot.
   /// </summary>
   public static readonly Volume CubicThou = new (
                                                  "cubic thou"
                                                , "th³"
                                                , CubicFoot
                                                , 1.0 / 12000.0 * (1.0 / 12000.0) * (1.0 / 12000.0)
                                                , 0
                                                 );

   /// <summary>
   /// A(n) quart. Defined in terms of a(n) pint.
   /// </summary>
   public static readonly Volume Quart = new ("quart", "qt", Pint, 2.0, 0);

   /// <summary>
   /// A(n) cubic barleycorn. Defined in terms of a(n) cubic foot.
   /// </summary>
   public static readonly Volume CubicBarleycorn = new (
                                                        "cubic barleycorn"
                                                      , "barleycorn³"
                                                      , CubicFoot
                                                      , 1.0 / 36.0 * (1.0 / 36.0) * (1.0 / 36.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) gallon. Defined in terms of a(n) quart.
   /// </summary>
   public static readonly Volume Gallon = new ("gallon", "gal", Quart, 4.0, 0);

   /// <summary>
   /// A(n) cubic hand. Defined in terms of a(n) cubic inch.
   /// </summary>
   public static readonly Volume CubicHand = new ("cubic hand", "hh³", CubicInch, 4.0 * 4.0 * 4.0, 0);

   /// <summary>
   /// A(n) bushel. Defined in terms of a(n) gallon.
   /// </summary>
   public static readonly Volume Bushel = new ("bushel", "bushel", Gallon, 8.0, 0);

   /// <summary>
   /// A(n) cubic yard. Defined in terms of a(n) cubic foot.
   /// </summary>
   public static readonly Volume CubicYard = new ("cubic yard", "yd³", CubicFoot, 3.0 * 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) quarter. Defined in terms of a(n) bushel.
   /// </summary>
   public static readonly Volume Quarter = new ("quarter", "quarter", Bushel, 8.0, 0);

   /// <summary>
   /// A(n) cubic chain. Defined in terms of a(n) cubic yard.
   /// </summary>
   public static readonly Volume CubicChain = new ("cubic chain", "ch³", CubicYard, 22.0 * 22.0 * 22.0, 0);

   /// <summary>
   /// A(n) minim. Defined in terms of a(n) pint.
   /// </summary>
   public static readonly Volume Minim = new ("minim", "♏︎ ", Pint, 1.0 / 9600.0, 0);

   /// <summary>
   /// A(n) cubic furlong. Defined in terms of a(n) cubic chain.
   /// </summary>
   public static readonly Volume CubicFurlong = new ("cubic furlong", "fur³", CubicChain, 10.0 * 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) fluid scruple. Defined in terms of a(n) minim.
   /// </summary>
   public static readonly Volume FluidScruple = new ("fluid scruple", "fl ℈", Minim, 20.0, 0);

   /// <summary>
   /// A(n) cubic mile. Defined in terms of a(n) cubic furlong.
   /// </summary>
   public static readonly Volume CubicMile = new ("cubic mile", "mi³", CubicFurlong, 8.0 * 8.0 * 8.0, 0);

   /// <summary>
   /// A(n) fluid drachm. Defined in terms of a(n) fluid scruple.
   /// </summary>
   public static readonly Volume FluidDrachm = new ("fluid drachm", "fl ʒ", FluidScruple, 3.0, 0);

   /// <summary>
   /// A(n) cubic league. Defined in terms of a(n) cubic mile.
   /// </summary>
   public static readonly Volume CubicLeague = new ("cubic league", "lea³", CubicMile, 3.0 * 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) cubic fathom. Defined in terms of a(n) cubic foot.
   /// </summary>
   public static readonly Volume CubicFathom = new ("cubic fathom", "ftm³", CubicFoot, 6.0 * 6.0 * 6.0, 0);

   /// <summary>
   /// A(n) cubic cable. Defined in terms of a(n) cubic fathom.
   /// </summary>
   public static readonly Volume CubicCable = new ("cubic cable", "cable³", CubicFathom, 100.0 * 100.0 * 100.0, 0);

   /// <summary>
   /// A(n) cubic nautical mile. Defined in terms of a(n) cubic cable.
   /// </summary>
   public static readonly Volume CubicNauticalMile = new (
                                                          "cubic nautical mile"
                                                        , "nmi³"
                                                        , CubicCable
                                                        , 10.0 * 10.0 * 10.0
                                                        , 0
                                                         );
}
