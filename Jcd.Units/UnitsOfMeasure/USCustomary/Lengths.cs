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
   /// inch, defined as: SI centimeter × 2.54
   /// </summary>
   public static readonly Length Inch = new ("inch", "in", SI.Lengths.Centimeter, 2.54);

   /// <summary>
   /// mil, defined as: inch × 1.0/1000.0
   /// </summary>
   public static readonly Length Mil = new ("mil", "mil", Inch, 1.0 / 1000.0);

   /// <summary>
   /// point, defined as: inch × 1.0/72.0
   /// </summary>
   public static readonly Length Point = new ("point", "p", Inch, 1.0 / 72.0);

   /// <summary>
   /// twip, defined as: point × 1.0/20.0
   /// </summary>
   public static readonly Length Twip = new ("twip", "twip", Point, 1.0 / 20.0);

   /// <summary>
   /// pica, defined as: point × 12.0
   /// </summary>
   public static readonly Length Pica = new ("pica", "P", Point, 12.0);

   /// <summary>
   /// foot, defined as: inch × 12.0
   /// </summary>
   public static readonly Length Foot = new ("foot", "ft", Inch, 12.0);

   /// <summary>
   /// yard, defined as: foot × 3.0
   /// </summary>
   public static readonly Length Yard = new ("yard", "yd", Foot, 3.0);

   /// <summary>
   /// mile, defined as: yard × 1760.0
   /// </summary>
   public static readonly Length Mile = new ("mile", "mi", Yard, 1760.0);

   /// <summary>
   /// league, defined as: mile × 3.0
   /// </summary>
   public static readonly Length League = new ("league", "le", Mile, 3.0);

   /// <summary>
   /// fathom, defined as: yard × 2.0
   /// </summary>
   public static readonly Length Fathom = new ("fathom", "ftm", Yard, 2.0);

   /// <summary>
   /// cable, defined as: fathom × 120.0
   /// </summary>
   public static readonly Length Cable = new ("cable", "cb", Fathom, 120.0);

   /// <summary>
   /// nautical mile, defined as: SI meter × 1852.0
   /// </summary>
   public static readonly Length NauticalMile = new ("nautical mile", "nmi", SI.Lengths.Meter, 1852.0);
}
