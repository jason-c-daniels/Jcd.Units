namespace Jcd.Units.USSurvey;

public static class Lengths
{
    public static readonly Length Link = new ("link", "li.", USCustomary.Lengths.Inch, 7.92);
    public static readonly Length Foot = new ("foot", "ft.", SI.Lengths.Meter, 1200.0/3937.0);
    public static readonly Length Rod = new ("rod", "rd.", Link, 25.0);
    public static readonly Length Chain = new ("chain", "ch.", Rod, 4.0);
    public static readonly Length Furlong = new ("furlong", "fur.", Chain, 10.0);
    public static readonly Length Mile = new ("survey mile", "mi.", Furlong, 8.0);
    public static readonly Length League = new ("league", "lea.", Mile, 3.0);
    public static readonly Length Fathom = new ("fathom", "ftm.", USCustomary.Lengths.Yard, 2.0);
    public static readonly Length Cable = new ("cable", "cb.", Fathom, 120.0);
    public static readonly Length NauticalMile = new ("nautical mile", "nmi.", SI.Lengths.Meter, 1852.0);
}