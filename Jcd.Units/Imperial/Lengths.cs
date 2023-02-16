namespace Jcd.Units.Imperial;

public static class Lengths
{
    public static readonly Length Inch = new ("inch", "in", SI.Lengths.Centimeter,  2.54);
    public static readonly Length Twip = new ("twip", "twip", Inch,  1.0 /1440.0);
    public static readonly Length Thou = new ("thou", "th", Inch,  1.0 /1000.0);
    public static readonly Length Barleycorn = new ("barleycorn", "Bc", Inch, 1.0 /3.0);
    public static readonly Length Hand = new ("hand", "hh", Inch, 4);
    public static readonly Length Foot = new ("foot", "ft", Hand, 3);
    public static readonly Length Yard = new ("yard", "yd", Foot, 3);
    public static readonly Length Chain = new ("chain", "ch", Foot, 22);
    public static readonly Length Furlong = new ("furlong", "fur", Chain, 10);
    public static readonly Length Mile = new ("mile", "mi", Furlong, 8);
    public static readonly Length League = new ("league", "lea", Mile, 3);

    public static readonly Length Fathom = new ("fathom", "ftm", Yard, 2.02667);
    public static readonly Length Cable = new ("cable", "cable", Fathom, 100);
    public static readonly Length NauticalMile = new ("nautical mile", "nmi", Cable, 10);

    public static readonly Length Link = new ("link", "link", Inch, 7.92);
    public static readonly Length Rod = new ("rod", "rod", Link, 25);
}