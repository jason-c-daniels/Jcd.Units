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
   /// inch, defined as: SI centimeter × 2.54
   /// </summary>
   public static readonly Length Inch = new ("inch", "in", SI.Lengths.Centimeter, 2.54);

   /// <summary>
   /// foot, defined as: inch × 12
   /// </summary>
   public static readonly Length Foot = new ("foot", "ft", Inch, 12);

   /// <summary>
   /// twip, defined as: foot × 1.0/17280.0
   /// </summary>
   public static readonly Length Twip = new ("twip", "twip", Foot, 1.0 / 17280.0);

   /// <summary>
   /// thou, defined as: foot × 1.0/12000.0
   /// </summary>
   public static readonly Length Thou = new ("thou", "th", Foot, 1.0 / 12000.0);

   /// <summary>
   /// barleycorn, defined as: foot × 1.0/36.0
   /// </summary>
   public static readonly Length Barleycorn = new ("barleycorn", "barleycorn", Foot, 1.0 / 36.0);

   /// <summary>
   /// hand, defined as: inch × 4.0
   /// </summary>
   public static readonly Length Hand = new ("hand", "hh", Inch, 4.0);

   /// <summary>
   /// yard, defined as: foot × 3.0
   /// </summary>
   public static readonly Length Yard = new ("yard", "yd", Foot, 3.0);

   /// <summary>
   /// chain, defined as: yard × 22.0
   /// </summary>
   public static readonly Length Chain = new ("chain", "ch", Yard, 22.0);

   /// <summary>
   /// furlong, defined as: chain × 10.0
   /// </summary>
   public static readonly Length Furlong = new ("furlong", "fur", Chain, 10.0);

   /// <summary>
   /// mile, defined as: furlong × 8.0
   /// </summary>
   public static readonly Length Mile = new ("mile", "mi", Furlong, 8.0);

   /// <summary>
   /// league, defined as: mile × 3.0
   /// </summary>
   public static readonly Length League = new ("league", "lea", Mile, 3.0);

   /// <summary>
   /// fathom, defined as: foot × 6.0
   /// </summary>
   public static readonly Length Fathom = new ("fathom", "ftm", Foot, 6.0);

   /// <summary>
   /// cable, defined as: fathom × 100.0
   /// </summary>
   public static readonly Length Cable = new ("cable", "cable", Fathom, 100.0);

   /// <summary>
   /// nautical mile, defined as: cable × 10.0
   /// </summary>
   public static readonly Length NauticalMile = new ("nautical mile", "nmi", Cable, 10.0);
}
