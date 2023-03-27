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
   /// A(n) cubic inch. Defined as: ((2.54)*(2.54)*(2.54)) × SI cubic centimeter + (0).
   /// </summary>
   public static readonly Volume CubicInch = new (
                                                  "cubic inch"
                                                , "in.³"
                                                , SI.Volumes.CubicCentimeter
                                                , 2.54 * 2.54 * 2.54
                                                , 0
                                                 );

   /// <summary>
   /// A(n) fluid ounce. Defined as: (28.4130625) × SI milliliter + (0).
   /// </summary>
   public static readonly Volume FluidOunce = new ("fluid ounce", "fl oz", SI.Volumes.Milliliter, 28.4130625, 0);

   /// <summary>
   /// A(n) cubic foot. Defined as: ((12)*(12)*(12)) × cubic inch + (0).
   /// </summary>
   public static readonly Volume CubicFoot = new ("cubic foot", "ft.³", CubicInch, 12 * 12 * 12, 0);

   /// <summary>
   /// A(n) gill. Defined as: (5.0) × fluid ounce + (0).
   /// </summary>
   public static readonly Volume Gill = new ("gill", "gi", FluidOunce, 5.0, 0);

   /// <summary>
   /// A(n) cubic twip. Defined as: ((1.0/17280.0)*(1.0/17280.0)*(1.0/17280.0)) × cubic foot + (0).
   /// </summary>
   public static readonly Volume CubicTwip = new (
                                                  "cubic twip"
                                                , "twip³"
                                                , CubicFoot
                                                , 1.0 / 17280.0 * (1.0 / 17280.0) * (1.0 / 17280.0)
                                                , 0
                                                 );

   /// <summary>
   /// A(n) pint. Defined as: (20.0) × fluid ounce + (0).
   /// </summary>
   public static readonly Volume Pint = new ("pint", "pt", FluidOunce, 20.0, 0);

   /// <summary>
   /// A(n) cubic thou. Defined as: ((1.0/12000.0)*(1.0/12000.0)*(1.0/12000.0)) × cubic foot + (0).
   /// </summary>
   public static readonly Volume CubicThou = new (
                                                  "cubic thou"
                                                , "th³"
                                                , CubicFoot
                                                , 1.0 / 12000.0 * (1.0 / 12000.0) * (1.0 / 12000.0)
                                                , 0
                                                 );

   /// <summary>
   /// A(n) quart. Defined as: (2.0) × pint + (0).
   /// </summary>
   public static readonly Volume Quart = new ("quart", "qt", Pint, 2.0, 0);

   /// <summary>
   /// A(n) cubic barleycorn. Defined as: ((1.0/36.0)*(1.0/36.0)*(1.0/36.0)) × cubic foot + (0).
   /// </summary>
   public static readonly Volume CubicBarleycorn = new (
                                                        "cubic barleycorn"
                                                      , "barleycorn³"
                                                      , CubicFoot
                                                      , 1.0 / 36.0 * (1.0 / 36.0) * (1.0 / 36.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) gallon. Defined as: (4.0) × quart + (0).
   /// </summary>
   public static readonly Volume Gallon = new ("gallon", "gal", Quart, 4.0, 0);

   /// <summary>
   /// A(n) cubic hand. Defined as: ((4.0)*(4.0)*(4.0)) × cubic inch + (0).
   /// </summary>
   public static readonly Volume CubicHand = new ("cubic hand", "hh³", CubicInch, 4.0 * 4.0 * 4.0, 0);

   /// <summary>
   /// A(n) bushel. Defined as: (8.0) × gallon + (0).
   /// </summary>
   public static readonly Volume Bushel = new ("bushel", "bushel", Gallon, 8.0, 0);

   /// <summary>
   /// A(n) cubic yard. Defined as: ((3.0)*(3.0)*(3.0)) × cubic foot + (0).
   /// </summary>
   public static readonly Volume CubicYard = new ("cubic yard", "yd³", CubicFoot, 3.0 * 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) quarter. Defined as: (8.0) × bushel + (0).
   /// </summary>
   public static readonly Volume Quarter = new ("quarter", "quarter", Bushel, 8.0, 0);

   /// <summary>
   /// A(n) cubic chain. Defined as: ((22.0)*(22.0)*(22.0)) × cubic yard + (0).
   /// </summary>
   public static readonly Volume CubicChain = new ("cubic chain", "ch³", CubicYard, 22.0 * 22.0 * 22.0, 0);

   /// <summary>
   /// A(n) minim. Defined as: (1.0/9600.0) × pint + (0).
   /// </summary>
   public static readonly Volume Minim = new ("minim", "♏︎ ", Pint, 1.0 / 9600.0, 0);

   /// <summary>
   /// A(n) cubic furlong. Defined as: ((10.0)*(10.0)*(10.0)) × cubic chain + (0).
   /// </summary>
   public static readonly Volume CubicFurlong = new ("cubic furlong", "fur³", CubicChain, 10.0 * 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) fluid scruple. Defined as: (20.0) × minim + (0).
   /// </summary>
   public static readonly Volume FluidScruple = new ("fluid scruple", "fl ℈", Minim, 20.0, 0);

   /// <summary>
   /// A(n) cubic mile. Defined as: ((8.0)*(8.0)*(8.0)) × cubic furlong + (0).
   /// </summary>
   public static readonly Volume CubicMile = new ("cubic mile", "mi³", CubicFurlong, 8.0 * 8.0 * 8.0, 0);

   /// <summary>
   /// A(n) fluid drachm. Defined as: (3.0) × fluid scruple + (0).
   /// </summary>
   public static readonly Volume FluidDrachm = new ("fluid drachm", "fl ʒ", FluidScruple, 3.0, 0);

   /// <summary>
   /// A(n) cubic league. Defined as: ((3.0)*(3.0)*(3.0)) × cubic mile + (0).
   /// </summary>
   public static readonly Volume CubicLeague = new ("cubic league", "lea³", CubicMile, 3.0 * 3.0 * 3.0, 0);

   /// <summary>
   /// A(n) cubic fathom. Defined as: ((6.0)*(6.0)*(6.0)) × cubic foot + (0).
   /// </summary>
   public static readonly Volume CubicFathom = new ("cubic fathom", "ftm³", CubicFoot, 6.0 * 6.0 * 6.0, 0);

   /// <summary>
   /// A(n) cubic cable. Defined as: ((100.0)*(100.0)*(100.0)) × cubic fathom + (0).
   /// </summary>
   public static readonly Volume CubicCable = new ("cubic cable", "cable³", CubicFathom, 100.0 * 100.0 * 100.0, 0);

   /// <summary>
   /// A(n) cubic nautical mile. Defined as: ((10.0)*(10.0)*(10.0)) × cubic cable + (0).
   /// </summary>
   public static readonly Volume CubicNauticalMile = new (
                                                          "cubic nautical mile"
                                                        , "nmi³"
                                                        , CubicCable
                                                        , 10.0 * 10.0 * 10.0
                                                        , 0
                                                         );
}
