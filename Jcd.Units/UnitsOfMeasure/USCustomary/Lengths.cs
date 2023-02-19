using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

/// <summary>
/// United States Customary Units for measuring Length.
/// </summary>
public class Lengths : Enumeration<Lengths,Length>
{

    /// <summary>
    /// A(n) inch. It's defined in terms of a(n) SI centimeter.
    /// </summary>
    public static readonly Length Inch = new ("inch", "in", SI.Lengths.Centimeter, 2.54,0);
    
    /// <summary>
    /// A(n) mil. It's defined in terms of a(n) inch.
    /// </summary>
    public static readonly Length Mil = new ("mil", "mil", Inch, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) point. It's defined in terms of a(n) inch.
    /// </summary>
    public static readonly Length Point = new ("point", "p", Inch, 1.0/72.0,0);
    
    /// <summary>
    /// A(n) twip. It's defined in terms of a(n) point.
    /// </summary>
    public static readonly Length Twip = new ("twip", "twip", Point, 1.0/20.0,0);
    
    /// <summary>
    /// A(n) pica. It's defined in terms of a(n) point.
    /// </summary>
    public static readonly Length Pica = new ("pica", "P", Point, 12,0);
    
    /// <summary>
    /// A(n) foot. It's defined in terms of a(n) inch.
    /// </summary>
    public static readonly Length Foot = new ("foot", "ft", Inch, 12,0);
    
    /// <summary>
    /// A(n) yard. It's defined in terms of a(n) foot.
    /// </summary>
    public static readonly Length Yard = new ("yard", "yd", Foot, 3,0);
    
    /// <summary>
    /// A(n) mile. It's defined in terms of a(n) yard.
    /// </summary>
    public static readonly Length Mile = new ("mile", "mi", Yard, 1760,0);
    
    /// <summary>
    /// A(n) league. It's defined in terms of a(n) mile.
    /// </summary>
    public static readonly Length League = new ("league", "le", Mile, 3,0);
    
    /// <summary>
    /// A(n) fathom. It's defined in terms of a(n) yard.
    /// </summary>
    public static readonly Length Fathom = new ("fathom", "ftm", Yard, 2,0);
    
    /// <summary>
    /// A(n) cable. It's defined in terms of a(n) fathom.
    /// </summary>
    public static readonly Length Cable = new ("cable", "cb", Fathom, 120,0);
    
    /// <summary>
    /// A(n) nautical mile. It's defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length NauticalMile = new ("nautical mile", "nmi", SI.Lengths.Meter, 1852,0);

}