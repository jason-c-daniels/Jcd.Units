using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

/// <summary>
/// United States Customary Units for measuring Length.
/// </summary>
public class Lengths : Enumeration<Lengths,Length>
{
    /// <summary>
    /// Units of a inch. It's defined in terms of a(n) SI centimeter.
    /// </summary>
    public static readonly Length Inch = new ("inch", "in", SI.Lengths.Centimeter, 2.54,0);
    /// <summary>
    /// Units of a mil. It's defined in terms of a(n) US Customary inch.
    /// </summary>
    public static readonly Length Mil = new ("mil", "mil", Inch, 1.0/1000.0,0);
    /// <summary>
    /// Units of a point. It's defined in terms of a(n) US Customary inch.
    /// </summary>
    public static readonly Length Point = new ("point", "p", Inch, 1.0/72.0,0);
    /// <summary>
    /// Units of a twip. It's defined in terms of a(n) US Customary point.
    /// </summary>
    public static readonly Length Twip = new ("twip", "twip", Point, 1.0/20.0,0);
    /// <summary>
    /// Units of a pica. It's defined in terms of a(n) US Customary point.
    /// </summary>
    public static readonly Length Pica = new ("pica", "P", Point, 12,0);
    /// <summary>
    /// Units of a foot. It's defined in terms of a(n) US Customary inch.
    /// </summary>
    public static readonly Length Foot = new ("foot", "ft", Inch, 12,0);
    /// <summary>
    /// Units of a yard. It's defined in terms of a(n) US Customary foot.
    /// </summary>
    public static readonly Length Yard = new ("yard", "yd", Foot, 3,0);
    /// <summary>
    /// Units of a mile. It's defined in terms of a(n) US Customary yard.
    /// </summary>
    public static readonly Length Mile = new ("mile", "mi", Yard, 1760,0);
    /// <summary>
    /// Units of a league. It's defined in terms of a(n) US Customary mile.
    /// </summary>
    public static readonly Length League = new ("league", "le", Mile, 3,0);
    /// <summary>
    /// Units of a fathom. It's defined in terms of a(n) US Customary yard.
    /// </summary>
    public static readonly Length Fathom = new ("fathom", "ftm", Yard, 2,0);
    /// <summary>
    /// Units of a cable. It's defined in terms of a(n) US Customary fathom.
    /// </summary>
    public static readonly Length Cable = new ("cable", "cb", Fathom, 120,0);
    /// <summary>
    /// Units of a nautical mile. It's defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length NauticalMile = new ("nautical mile", "nmi", SI.Lengths.Meter, 1852,0);

}