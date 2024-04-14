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
   /// cubic inch defined such that: SI cubic centimeter = in³ × (2.54)*(2.54)*(2.54).
   /// </summary>
   public static readonly Volume CubicInch = new("cubic inch", "in³", SI.Volumes.CubicCentimeter, 2.54 * 2.54 * 2.54, system: "Imperial");
   
   /// <summary>
   /// fluid ounce defined such that: SI milliliter = fl oz × 28.4130625.
   /// </summary>
   public static readonly Volume FluidOunce = new("fluid ounce", "fl oz", SI.Volumes.Milliliter, 28.4130625, system: "Imperial");
   
   /// <summary>
   /// cubic foot defined such that: cubic inch = ft³ × (12)*(12)*(12).
   /// </summary>
   public static readonly Volume CubicFoot = new("cubic foot", "ft³", CubicInch, 12 * 12 * 12, system: "Imperial");
   
   /// <summary>
   /// gill defined such that: fluid ounce = gi × 5.0.
   /// </summary>
   public static readonly Volume Gill = new("gill", "gi", FluidOunce, 5.0, system: "Imperial");
   
   /// <summary>
   /// cubic twip defined such that: cubic foot = twip³ × (1.0/17280.0)*(1.0/17280.0)*(1.0/17280.0).
   /// </summary>
   public static readonly Volume CubicTwip = new("cubic twip", "twip³", CubicFoot, 1.0 / 17280.0 * (1.0 / 17280.0) * (1.0 / 17280.0), system: "Imperial");
   
   /// <summary>
   /// pint defined such that: fluid ounce = pt × 20.0.
   /// </summary>
   public static readonly Volume Pint = new("pint", "pt", FluidOunce, 20.0, system: "Imperial");
   
   /// <summary>
   /// cubic thou defined such that: cubic foot = th³ × (1.0/12000.0)*(1.0/12000.0)*(1.0/12000.0).
   /// </summary>
   public static readonly Volume CubicThou = new("cubic thou", "th³", CubicFoot, 1.0 / 12000.0 * (1.0 / 12000.0) * (1.0 / 12000.0), system: "Imperial");
   
   /// <summary>
   /// quart defined such that: pint = qt × 2.0.
   /// </summary>
   public static readonly Volume Quart = new("quart", "qt", Pint, 2.0, system: "Imperial");
   
   /// <summary>
   /// cubic barleycorn defined such that: cubic foot = barleycorn³ × (1.0/36.0)*(1.0/36.0)*(1.0/36.0).
   /// </summary>
   public static readonly Volume CubicBarleycorn = new("cubic barleycorn", "barleycorn³", CubicFoot, 1.0 / 36.0 * (1.0 / 36.0) * (1.0 / 36.0), system: "Imperial");
   
   /// <summary>
   /// gallon defined such that: quart = gal × 4.0.
   /// </summary>
   public static readonly Volume Gallon = new("gallon", "gal", Quart, 4.0, system: "Imperial");
   
   /// <summary>
   /// cubic hand defined such that: cubic inch = hh³ × (4.0)*(4.0)*(4.0).
   /// </summary>
   public static readonly Volume CubicHand = new("cubic hand", "hh³", CubicInch, 4.0 * 4.0 * 4.0, system: "Imperial");
   
   /// <summary>
   /// bushel defined such that: gallon = bushel × 8.0.
   /// </summary>
   public static readonly Volume Bushel = new("bushel", "bushel", Gallon, 8.0, system: "Imperial");
   
   /// <summary>
   /// cubic yard defined such that: cubic foot = yd³ × (3.0)*(3.0)*(3.0).
   /// </summary>
   public static readonly Volume CubicYard = new("cubic yard", "yd³", CubicFoot, 3.0 * 3.0 * 3.0, system: "Imperial");
   
   /// <summary>
   /// quarter defined such that: bushel = quarter × 8.0.
   /// </summary>
   public static readonly Volume Quarter = new("quarter", "quarter", Bushel, 8.0, system: "Imperial");
   
   /// <summary>
   /// cubic chain defined such that: cubic yard = ch³ × (22.0)*(22.0)*(22.0).
   /// </summary>
   public static readonly Volume CubicChain = new("cubic chain", "ch³", CubicYard, 22.0 * 22.0 * 22.0, system: "Imperial");
   
   /// <summary>
   /// minim defined such that: pint = ♏︎  × 1.0/9600.0.
   /// </summary>
   public static readonly Volume Minim = new("minim", "♏︎ ", Pint, 1.0 / 9600.0, system: "Imperial");
   
   /// <summary>
   /// cubic furlong defined such that: cubic chain = fur³ × (10.0)*(10.0)*(10.0).
   /// </summary>
   public static readonly Volume CubicFurlong = new("cubic furlong", "fur³", CubicChain, 10.0 * 10.0 * 10.0, system: "Imperial");
   
   /// <summary>
   /// fluid scruple defined such that: minim = fl ℈ × 20.0.
   /// </summary>
   public static readonly Volume FluidScruple = new("fluid scruple", "fl ℈", Minim, 20.0, system: "Imperial");
   
   /// <summary>
   /// cubic mile defined such that: cubic furlong = mi³ × (8.0)*(8.0)*(8.0).
   /// </summary>
   public static readonly Volume CubicMile = new("cubic mile", "mi³", CubicFurlong, 8.0 * 8.0 * 8.0, system: "Imperial");
   
   /// <summary>
   /// fluid drachm defined such that: fluid scruple = fl ʒ × 3.0.
   /// </summary>
   public static readonly Volume FluidDrachm = new("fluid drachm", "fl ʒ", FluidScruple, 3.0, system: "Imperial");
   
   /// <summary>
   /// cubic league defined such that: cubic mile = lea³ × (3.0)*(3.0)*(3.0).
   /// </summary>
   public static readonly Volume CubicLeague = new("cubic league", "lea³", CubicMile, 3.0 * 3.0 * 3.0, system: "Imperial");
   
   /// <summary>
   /// cubic fathom defined such that: cubic foot = ftm³ × (6.0)*(6.0)*(6.0).
   /// </summary>
   public static readonly Volume CubicFathom = new("cubic fathom", "ftm³", CubicFoot, 6.0 * 6.0 * 6.0, system: "Imperial");
   
   /// <summary>
   /// cubic cable defined such that: cubic fathom = cable³ × (100.0)*(100.0)*(100.0).
   /// </summary>
   public static readonly Volume CubicCable = new("cubic cable", "cable³", CubicFathom, 100.0 * 100.0 * 100.0, system: "Imperial");
   
   /// <summary>
   /// cubic nautical mile defined such that: cubic cable = nmi³ × (10.0)*(10.0)*(10.0).
   /// </summary>
   public static readonly Volume CubicNauticalMile = new("cubic nautical mile", "nmi³", CubicCable, 10.0 * 10.0 * 10.0, system: "Imperial");
}