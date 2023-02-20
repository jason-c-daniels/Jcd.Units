using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global


namespace Jcd.Units.UnitsOfMeasure.USCustomary;

/// <summary>
/// United States Customary Units for measuring Length.
/// </summary>
public class Lengths : Enumeration<Lengths,Length>
{

    /// <summary>
    /// A(n) inch. Defined in terms of a(n) SI centimeter.
    /// </summary>
    public static readonly Length Inch = new ("inch", "in", SI.Lengths.Centimeter, 2.54,0);

    /// <summary>
    /// A(n) mil. Defined in terms of a(n) inch.
    /// </summary>
    public static readonly Length Mil = new ("mil", "mil", Inch, 1.0/1000.0,0);

    /// <summary>
    /// A(n) point. Defined in terms of a(n) inch.
    /// </summary>
    public static readonly Length Point = new ("point", "p", Inch, 1.0/72.0,0);

    /// <summary>
    /// A(n) twip. Defined in terms of a(n) point.
    /// </summary>
    public static readonly Length Twip = new ("twip", "twip", Point, 1.0/20.0,0);

    /// <summary>
    /// A(n) pica. Defined in terms of a(n) point.
    /// </summary>
    public static readonly Length Pica = new ("pica", "P", Point, 12,0);

    /// <summary>
    /// A(n) foot. Defined in terms of a(n) inch.
    /// </summary>
    public static readonly Length Foot = new ("foot", "ft", Inch, 12,0);

    /// <summary>
    /// A(n) yard. Defined in terms of a(n) foot.
    /// </summary>
    public static readonly Length Yard = new ("yard", "yd", Foot, 3,0);

    /// <summary>
    /// A(n) mile. Defined in terms of a(n) yard.
    /// </summary>
    public static readonly Length Mile = new ("mile", "mi", Yard, 1760,0);

    /// <summary>
    /// A(n) league. Defined in terms of a(n) mile.
    /// </summary>
    public static readonly Length League = new ("league", "le", Mile, 3,0);

    /// <summary>
    /// A(n) fathom. Defined in terms of a(n) yard.
    /// </summary>
    public static readonly Length Fathom = new ("fathom", "ftm", Yard, 2,0);

    /// <summary>
    /// A(n) cable. Defined in terms of a(n) fathom.
    /// </summary>
    public static readonly Length Cable = new ("cable", "cb", Fathom, 120,0);

    /// <summary>
    /// A(n) nautical mile. Defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length NauticalMile = new ("nautical mile", "nmi", SI.Lengths.Meter, 1852,0);

}