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
   /// A(n) inch. Defined as: (2.54) × SI centimeter + (0).
   /// </summary>
   public static readonly Length Inch = new ("inch", "in", SI.Lengths.Centimeter, 2.54, 0);

   /// <summary>
   /// A(n) foot. Defined as: (12) × inch + (0).
   /// </summary>
   public static readonly Length Foot = new ("foot", "ft", Inch, 12, 0);

   /// <summary>
   /// A(n) twip. Defined as: (1.0/17280.0) × foot + (0).
   /// </summary>
   public static readonly Length Twip = new ("twip", "twip", Foot, 1.0 / 17280.0, 0);

   /// <summary>
   /// A(n) thou. Defined as: (1.0/12000.0) × foot + (0).
   /// </summary>
   public static readonly Length Thou = new ("thou", "th", Foot, 1.0 / 12000.0, 0);

   /// <summary>
   /// A(n) barleycorn. Defined as: (1.0/36.0) × foot + (0).
   /// </summary>
   public static readonly Length Barleycorn = new ("barleycorn", "barleycorn", Foot, 1.0 / 36.0, 0);

   /// <summary>
   /// A(n) hand. Defined as: (4.0) × inch + (0).
   /// </summary>
   public static readonly Length Hand = new ("hand", "hh", Inch, 4.0, 0);

   /// <summary>
   /// A(n) yard. Defined as: (3.0) × foot + (0).
   /// </summary>
   public static readonly Length Yard = new ("yard", "yd", Foot, 3.0, 0);

   /// <summary>
   /// A(n) chain. Defined as: (22.0) × yard + (0).
   /// </summary>
   public static readonly Length Chain = new ("chain", "ch", Yard, 22.0, 0);

   /// <summary>
   /// A(n) furlong. Defined as: (10.0) × chain + (0).
   /// </summary>
   public static readonly Length Furlong = new ("furlong", "fur", Chain, 10.0, 0);

   /// <summary>
   /// A(n) mile. Defined as: (8.0) × furlong + (0).
   /// </summary>
   public static readonly Length Mile = new ("mile", "mi", Furlong, 8.0, 0);

   /// <summary>
   /// A(n) league. Defined as: (3.0) × mile + (0).
   /// </summary>
   public static readonly Length League = new ("league", "lea", Mile, 3.0, 0);

   /// <summary>
   /// A(n) fathom. Defined as: (6.0) × foot + (0).
   /// </summary>
   public static readonly Length Fathom = new ("fathom", "ftm", Foot, 6.0, 0);

   /// <summary>
   /// A(n) cable. Defined as: (100.0) × fathom + (0).
   /// </summary>
   public static readonly Length Cable = new ("cable", "cable", Fathom, 100.0, 0);

   /// <summary>
   /// A(n) nautical mile. Defined as: (10.0) × cable + (0).
   /// </summary>
   public static readonly Length NauticalMile = new ("nautical mile", "nmi", Cable, 10.0, 0);
}
