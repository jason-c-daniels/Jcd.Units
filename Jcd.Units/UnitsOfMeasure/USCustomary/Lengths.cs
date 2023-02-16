using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.USCustomary;
public class Lengths : Enumeration<Lengths,Length>
{
    public static readonly Length Inch = Imperial.Lengths.Inch;
    public static readonly Length Point = new Length("point", "p.", Inch, 1.0 / 72.0);
    public static readonly Length Pica = new Length("pica", "P.", Point, 1.0 / 12.0);
    public static readonly Length Foot = new Length("foot", "ft.", Inch, 12.0);
    public static readonly Length Yard = new Length("yard", "yd.", Foot, 3.0);
    public static readonly Length Mile = new Length("mile", "mi.", Yard, 1760.0);
}
