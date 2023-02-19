using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.Imperial;

/// <summary>
/// British Imperial Units for measuring Length.
/// </summary>
public class Lengths : Enumeration<Lengths,Length>
{

    /// <summary>
    /// A(n) inch. It's defined in terms of a(n) SI centimeter.
    /// </summary>
    public static readonly Length Inch = new ("inch", "in.", SI.Lengths.Centimeter, 2.54,0);
    
    /// <summary>
    /// A(n) foot. It's defined in terms of a(n) inch.
    /// </summary>
    public static readonly Length Foot = new ("foot", "ft.", Inch, 12,0);
    
    /// <summary>
    /// A(n) twip. It's defined in terms of a(n) foot.
    /// </summary>
    public static readonly Length Twip = new ("twip", "twip", Foot, 1.0/17280.0,0);
    
    /// <summary>
    /// A(n) thou. It's defined in terms of a(n) foot.
    /// </summary>
    public static readonly Length Thou = new ("thou", "th", Foot, 1.0/12000.0,0);
    
    /// <summary>
    /// A(n) barleycorn. It's defined in terms of a(n) foot.
    /// </summary>
    public static readonly Length Barleycorn = new ("barleycorn", "barleycorn", Foot, 1.0/36.0,0);
    
    /// <summary>
    /// A(n) hand. It's defined in terms of a(n) inch.
    /// </summary>
    public static readonly Length Hand = new ("hand", "hh", Inch, 4,0);
    
    /// <summary>
    /// A(n) yard. It's defined in terms of a(n) foot.
    /// </summary>
    public static readonly Length Yard = new ("yard", "yd", Foot, 3,0);
    
    /// <summary>
    /// A(n) chain. It's defined in terms of a(n) yard.
    /// </summary>
    public static readonly Length Chain = new ("chain", "ch", Yard, 22,0);
    
    /// <summary>
    /// A(n) furlong. It's defined in terms of a(n) chain.
    /// </summary>
    public static readonly Length Furlong = new ("furlong", "fur", Chain, 10,0);
    
    /// <summary>
    /// A(n) mile. It's defined in terms of a(n) furlong.
    /// </summary>
    public static readonly Length Mile = new ("mile", "mi", Furlong, 8,0);
    
    /// <summary>
    /// A(n) league. It's defined in terms of a(n) mile.
    /// </summary>
    public static readonly Length League = new ("league", "lea", Mile, 3,0);
    
    /// <summary>
    /// A(n) fathom. It's defined in terms of a(n) foot.
    /// </summary>
    public static readonly Length Fathom = new ("fathom", "ftm", Foot, 6,0);
    
    /// <summary>
    /// A(n) cable. It's defined in terms of a(n) fathom.
    /// </summary>
    public static readonly Length Cable = new ("cable", "cable", Fathom, 100,0);
    
    /// <summary>
    /// A(n) nautical mile. It's defined in terms of a(n) cable.
    /// </summary>
    public static readonly Length NauticalMile = new ("nautical mile", "nmi", Cable, 10,0);

}