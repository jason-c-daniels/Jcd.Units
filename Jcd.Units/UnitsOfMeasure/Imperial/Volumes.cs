#region

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
   /// cubic inch, defined as: SI cubic centimeter × (2.54)*(2.54)*(2.54)
   /// </summary>
   public static readonly Volume CubicInch = new (
                                                  "cubic inch"
                                                , "in³"
                                                , SI.Volumes.CubicCentimeter
                                                , 2.54 * 2.54 * 2.54
                                                , system: "Imperial"
                                                 );

   /// <summary>
   /// fluid ounce, defined as: SI milliliter × 28.4130625
   /// </summary>
   public static readonly Volume FluidOunce = new (
                                                   "fluid ounce"
                                                 , "fl oz"
                                                 , SI.Volumes.Milliliter
                                                 , 28.4130625
                                                 , system: "Imperial"
                                                  );

   /// <summary>
   /// cubic foot, defined as: cubic inch × (12)*(12)*(12)
   /// </summary>
   public static readonly Volume CubicFoot = new ("cubic foot", "ft³", CubicInch, 12 * 12 * 12, system: "Imperial");

   /// <summary>
   /// gill, defined as: fluid ounce × 5.0
   /// </summary>
   public static readonly Volume Gill = new ("gill", "gi", FluidOunce, 5.0, system: "Imperial");

   /// <summary>
   /// cubic twip, defined as: cubic foot × (1.0/17280.0)*(1.0/17280.0)*(1.0/17280.0)
   /// </summary>
   public static readonly Volume CubicTwip = new (
                                                  "cubic twip"
                                                , "twip³"
                                                , CubicFoot
                                                , 1.0 / 17280.0 * (1.0 / 17280.0) * (1.0 / 17280.0)
                                                , system: "Imperial"
                                                 );

   /// <summary>
   /// pint, defined as: fluid ounce × 20.0
   /// </summary>
   public static readonly Volume Pint = new ("pint", "pt", FluidOunce, 20.0, system: "Imperial");

   /// <summary>
   /// cubic thou, defined as: cubic foot × (1.0/12000.0)*(1.0/12000.0)*(1.0/12000.0)
   /// </summary>
   public static readonly Volume CubicThou = new (
                                                  "cubic thou"
                                                , "th³"
                                                , CubicFoot
                                                , 1.0 / 12000.0 * (1.0 / 12000.0) * (1.0 / 12000.0)
                                                , system: "Imperial"
                                                 );

   /// <summary>
   /// quart, defined as: pint × 2.0
   /// </summary>
   public static readonly Volume Quart = new ("quart", "qt", Pint, 2.0, system: "Imperial");

   /// <summary>
   /// cubic barleycorn, defined as: cubic foot × (1.0/36.0)*(1.0/36.0)*(1.0/36.0)
   /// </summary>
   public static readonly Volume CubicBarleycorn = new (
                                                        "cubic barleycorn"
                                                      , "barleycorn³"
                                                      , CubicFoot
                                                      , 1.0 / 36.0 * (1.0 / 36.0) * (1.0 / 36.0)
                                                      , system: "Imperial"
                                                       );

   /// <summary>
   /// gallon, defined as: quart × 4.0
   /// </summary>
   public static readonly Volume Gallon = new ("gallon", "gal", Quart, 4.0, system: "Imperial");

   /// <summary>
   /// cubic hand, defined as: cubic inch × (4.0)*(4.0)*(4.0)
   /// </summary>
   public static readonly Volume CubicHand = new ("cubic hand", "hh³", CubicInch, 4.0 * 4.0 * 4.0, system: "Imperial");

   /// <summary>
   /// bushel, defined as: gallon × 8.0
   /// </summary>
   public static readonly Volume Bushel = new ("bushel", "bushel", Gallon, 8.0, system: "Imperial");

   /// <summary>
   /// cubic yard, defined as: cubic foot × (3.0)*(3.0)*(3.0)
   /// </summary>
   public static readonly Volume CubicYard = new ("cubic yard", "yd³", CubicFoot, 3.0 * 3.0 * 3.0, system: "Imperial");

   /// <summary>
   /// quarter, defined as: bushel × 8.0
   /// </summary>
   public static readonly Volume Quarter = new ("quarter", "quarter", Bushel, 8.0, system: "Imperial");

   /// <summary>
   /// cubic chain, defined as: cubic yard × (22.0)*(22.0)*(22.0)
   /// </summary>
   public static readonly Volume CubicChain = new (
                                                   "cubic chain"
                                                 , "ch³"
                                                 , CubicYard
                                                 , 22.0 * 22.0 * 22.0
                                                 , system: "Imperial"
                                                  );

   /// <summary>
   /// minim, defined as: pint × 1.0/9600.0
   /// </summary>
   public static readonly Volume Minim = new ("minim", "♏︎ ", Pint, 1.0 / 9600.0, system: "Imperial");

   /// <summary>
   /// cubic furlong, defined as: cubic chain × (10.0)*(10.0)*(10.0)
   /// </summary>
   public static readonly Volume CubicFurlong = new (
                                                     "cubic furlong"
                                                   , "fur³"
                                                   , CubicChain
                                                   , 10.0 * 10.0 * 10.0
                                                   , system: "Imperial"
                                                    );

   /// <summary>
   /// fluid scruple, defined as: minim × 20.0
   /// </summary>
   public static readonly Volume FluidScruple = new ("fluid scruple", "fl ℈", Minim, 20.0, system: "Imperial");

   /// <summary>
   /// cubic mile, defined as: cubic furlong × (8.0)*(8.0)*(8.0)
   /// </summary>
   public static readonly Volume CubicMile = new (
                                                  "cubic mile"
                                                , "mi³"
                                                , CubicFurlong
                                                , 8.0 * 8.0 * 8.0
                                                , system: "Imperial"
                                                 );

   /// <summary>
   /// fluid drachm, defined as: fluid scruple × 3.0
   /// </summary>
   public static readonly Volume FluidDrachm = new ("fluid drachm", "fl ʒ", FluidScruple, 3.0, system: "Imperial");

   /// <summary>
   /// cubic league, defined as: cubic mile × (3.0)*(3.0)*(3.0)
   /// </summary>
   public static readonly Volume CubicLeague = new (
                                                    "cubic league"
                                                  , "lea³"
                                                  , CubicMile
                                                  , 3.0 * 3.0 * 3.0
                                                  , system: "Imperial"
                                                   );

   /// <summary>
   /// cubic fathom, defined as: cubic foot × (6.0)*(6.0)*(6.0)
   /// </summary>
   public static readonly Volume CubicFathom = new (
                                                    "cubic fathom"
                                                  , "ftm³"
                                                  , CubicFoot
                                                  , 6.0 * 6.0 * 6.0
                                                  , system: "Imperial"
                                                   );

   /// <summary>
   /// cubic cable, defined as: cubic fathom × (100.0)*(100.0)*(100.0)
   /// </summary>
   public static readonly Volume CubicCable = new (
                                                   "cubic cable"
                                                 , "cable³"
                                                 , CubicFathom
                                                 , 100.0 * 100.0 * 100.0
                                                 , system: "Imperial"
                                                  );

   /// <summary>
   /// cubic nautical mile, defined as: cubic cable × (10.0)*(10.0)*(10.0)
   /// </summary>
   public static readonly Volume CubicNauticalMile = new (
                                                          "cubic nautical mile"
                                                        , "nmi³"
                                                        , CubicCable
                                                        , 10.0 * 10.0 * 10.0
                                                        , system: "Imperial"
                                                         );
}
