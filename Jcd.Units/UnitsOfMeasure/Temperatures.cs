using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure;

/// <summary>
/// Uncategorized Units for measuring Temperature.
/// </summary>
public class Temperatures : Enumeration<Temperatures,Temperature>
{
    public static readonly Temperature DegreesRankine = new ("degrees rankine", "°R", SI.Temperatures.DegreesCelcius, 5.0/9.0,-491.67);
    public static readonly Temperature DegreesDelisle = new ("degrees delisle", "°De", SI.Temperatures.DegreesCelcius, 1.0/1.5,100);
    public static readonly Temperature DegreesNewton = new ("degrees newton", "°N", SI.Temperatures.DegreesCelcius, 100.0/33.0,0);
    public static readonly Temperature DegreesRéaumur = new ("degrees réaumur", "°Ré", SI.Temperatures.DegreesCelcius, 5.0/4.0,0);
    public static readonly Temperature DegreesRømer = new ("degrees rømer", "°Rø", SI.Temperatures.DegreesCelcius, 1000.0/525.0,-7.5);
}