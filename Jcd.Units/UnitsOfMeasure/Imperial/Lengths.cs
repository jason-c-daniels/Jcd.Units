using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.Imperial;

/// <summary>
/// British Imperial Units for measuring Length.
/// </summary>
public class Lengths : Enumeration<Lengths,Length>
{
    public static readonly Length Inch = new ("inch", "in.", SI.Lengths.Centimeter, 2.54,0);
    public static readonly Length Foot = new ("foot", "ft.", Inch, 12,0);
    public static readonly Length Twip = new ("twip", "twip", Foot, 1.0/17280.0,0);
    public static readonly Length Thou = new ("thou", "th", Foot, 1.0/12000.0,0);
    public static readonly Length Barleycorn = new ("barleycorn", "barleycorn", Foot, 1.0/36.0,0);
    public static readonly Length Hand = new ("hand", "hh", Inch, 4,0);
    public static readonly Length Yard = new ("yard", "yd", Foot, 3,0);
    public static readonly Length Chain = new ("chain", "ch", Yard, 22,0);
    public static readonly Length Furlong = new ("furlong", "fur", Chain, 10,0);
    public static readonly Length Mile = new ("mile", "mi", Furlong, 8,0);
    public static readonly Length League = new ("league", "lea", Mile, 3,0);
    public static readonly Length Fathom = new ("fathom", "ftm", Foot, 6,0);
    public static readonly Length Cable = new ("cable", "cable", Fathom, 100,0);
    public static readonly Length NauticalMile = new ("nautical mile", "nmi", Cable, 10,0);
}