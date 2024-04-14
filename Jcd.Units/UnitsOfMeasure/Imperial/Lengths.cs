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
/// British Imperial Units for measuring Length.
/// </summary>
public class Lengths : UnitOfMeasureEnumeration<Lengths, Length>
{
   /// <summary>
   /// inch defined such that: SI centimeter = in × 2.54.
   /// </summary>
   public static readonly Length Inch = new("inch", "in", SI.Lengths.Centimeter, 2.54, system: "Imperial");
   
   /// <summary>
   /// foot defined such that: inch = ft × 12.
   /// </summary>
   public static readonly Length Foot = new("foot", "ft", Inch, 12, system: "Imperial");
   
   /// <summary>
   /// twip defined such that: foot = twip × 1.0/17280.0.
   /// </summary>
   public static readonly Length Twip = new("twip", "twip", Foot, 1.0 / 17280.0, system: "Imperial");
   
   /// <summary>
   /// thou defined such that: foot = th × 1.0/12000.0.
   /// </summary>
   public static readonly Length Thou = new("thou", "th", Foot, 1.0 / 12000.0, system: "Imperial");
   
   /// <summary>
   /// barleycorn defined such that: foot = barleycorn × 1.0/36.0.
   /// </summary>
   public static readonly Length Barleycorn = new("barleycorn", "barleycorn", Foot, 1.0 / 36.0, system: "Imperial");
   
   /// <summary>
   /// hand defined such that: inch = hh × 4.0.
   /// </summary>
   public static readonly Length Hand = new("hand", "hh", Inch, 4.0, system: "Imperial");
   
   /// <summary>
   /// yard defined such that: foot = yd × 3.0.
   /// </summary>
   public static readonly Length Yard = new("yard", "yd", Foot, 3.0, system: "Imperial");
   
   /// <summary>
   /// chain defined such that: yard = ch × 22.0.
   /// </summary>
   public static readonly Length Chain = new("chain", "ch", Yard, 22.0, system: "Imperial");
   
   /// <summary>
   /// furlong defined such that: chain = fur × 10.0.
   /// </summary>
   public static readonly Length Furlong = new("furlong", "fur", Chain, 10.0, system: "Imperial");
   
   /// <summary>
   /// mile defined such that: furlong = mi × 8.0.
   /// </summary>
   public static readonly Length Mile = new("mile", "mi", Furlong, 8.0, system: "Imperial");
   
   /// <summary>
   /// league defined such that: mile = lea × 3.0.
   /// </summary>
   public static readonly Length League = new("league", "lea", Mile, 3.0, system: "Imperial");
   
   /// <summary>
   /// fathom defined such that: foot = ftm × 6.0.
   /// </summary>
   public static readonly Length Fathom = new("fathom", "ftm", Foot, 6.0, system: "Imperial");
   
   /// <summary>
   /// cable defined such that: fathom = cable × 100.0.
   /// </summary>
   public static readonly Length Cable = new("cable", "cable", Fathom, 100.0, system: "Imperial");
   
   /// <summary>
   /// nautical mile defined such that: cable = nmi × 10.0.
   /// </summary>
   public static readonly Length NauticalMile = new("nautical mile", "nmi", Cable, 10.0, system: "Imperial");
}