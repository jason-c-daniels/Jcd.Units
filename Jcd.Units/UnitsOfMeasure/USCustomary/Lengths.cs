#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

/// <summary>
/// United States Customary Units for measuring Length.
/// </summary>
public class Lengths : UnitOfMeasureEnumeration<Lengths, Length>
{
   /// <summary>
   /// inch defined such that: SI centimeter = in × 2.54.
   /// </summary>
   public static readonly Length Inch = new("inch", "in", SI.Lengths.Centimeter, 2.54, system: "US Customary");

   /// <summary>
   /// mil defined such that: inch = mil × 1.0/1000.0.
   /// </summary>
   public static readonly Length Mil = new("mil", "mil", Inch, 1.0 / 1000.0, system: "US Customary");

   /// <summary>
   /// point defined such that: inch = p × 1.0/72.0.
   /// </summary>
   public static readonly Length Point = new("point", "p", Inch, 1.0 / 72.0, system: "US Customary");

   /// <summary>
   /// twip defined such that: point = twip × 1.0/20.0.
   /// </summary>
   public static readonly Length Twip = new("twip", "twip", Point, 1.0 / 20.0, system: "US Customary");

   /// <summary>
   /// pica defined such that: point = P × 12.0.
   /// </summary>
   public static readonly Length Pica = new("pica", "P", Point, 12.0, system: "US Customary");

   /// <summary>
   /// foot defined such that: inch = ft × 12.0.
   /// </summary>
   public static readonly Length Foot = new("foot", "ft", Inch, 12.0, system: "US Customary");

   /// <summary>
   /// yard defined such that: foot = yd × 3.0.
   /// </summary>
   public static readonly Length Yard = new("yard", "yd", Foot, 3.0, system: "US Customary");

   /// <summary>
   /// mile defined such that: yard = mi × 1760.0.
   /// </summary>
   public static readonly Length Mile = new("mile", "mi", Yard, 1760.0, system: "US Customary");

   /// <summary>
   /// league defined such that: mile = le × 3.0.
   /// </summary>
   public static readonly Length League = new("league", "le", Mile, 3.0, system: "US Customary");

   /// <summary>
   /// fathom defined such that: yard = ftm × 2.0.
   /// </summary>
   public static readonly Length Fathom = new("fathom", "ftm", Yard, 2.0, system: "US Customary");

   /// <summary>
   /// cable defined such that: fathom = cb × 120.0.
   /// </summary>
   public static readonly Length Cable = new("cable", "cb", Fathom, 120.0, system: "US Customary");

   /// <summary>
   /// nautical mile defined such that: SI meter = nmi × 1852.0.
   /// </summary>
   public static readonly Length NauticalMile = new("nautical mile", "nmi", SI.Lengths.Meter, 1852.0, system: "US Customary");
}