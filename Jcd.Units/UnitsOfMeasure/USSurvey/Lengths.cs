using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.USSurvey;

/// <summary>
/// United States Survey Units for measuring Length.
/// </summary>
public class Lengths : Enumeration<Lengths,Length>
{
    public static readonly Length Link = new ("link", "li", SI.Lengths.Meter, 0.20116,0);
    public static readonly Length Rod = new ("rod", "rd", SI.Lengths.Meter, 5.0292,0);
    public static readonly Length Chain = new ("chain", "ch", SI.Lengths.Meter, 20.1168,0);
    public static readonly Length Furlong = new ("furlong", "fur", SI.Lengths.Meter, 201.168,0);
    public static readonly Length League = new ("league", "lea", SI.Lengths.Meter, 4828.032,0);
}