namespace Jcd.Units;

public partial record Length
{
    public static class USCustomary
    {
        public static readonly Length Inch = Imperial.Inch;
        public static readonly Length Point = new Length("point", "p.", Inch, 1.0 / 72.0);
        public static readonly Length Pica = new Length("pica", "P.", Point, 1.0 / 12.0);
        public static readonly Length Foot = new Length("foot", "ft.", Inch, 12.0);
        public static readonly Length Yard = new Length("yard", "yd.", Foot, 3.0);
        public static readonly Length Mile = new Length("mile", "mi.", Yard, 1760.0);
    }
    public static class USSurvey
    {
        public static readonly Length Link = new Length("link", "li.", USCustomary.Inch, 7.92);
        public static readonly Length Foot = new Length("foot", "ft.", SI.Meter, 1200.0/3937.0);
        public static readonly Length Rod = new Length("rod", "rd.", Link, 25.0);
        public static readonly Length Chain = new Length("chain", "ch.", Rod, 4.0);
        public static readonly Length Furlong = new Length("furlong", "fur.", Chain, 10.0);
        public static readonly Length Mile = new Length("survey mile", "mi.", Furlong, 8.0);
        public static readonly Length League = new Length("league", "lea.", Mile, 3.0);
        public static readonly Length Fathom = new Length("fathom", "ftm.", USCustomary.Yard, 2.0);
        public static readonly Length Cable = new Length("cable", "cb.", Fathom, 120.0);
        public static readonly Length NauticalMile = new Length("nautical mile", "nmi.", SI.Meter, 1852.0);
    }
}