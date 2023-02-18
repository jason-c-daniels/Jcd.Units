using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure;

public class Temperatures : Enumeration<Temperatures,Temperature>
{
    public static readonly Temperature Rankine = new ("rankine", "°R", SI.Temperatures.Celcius, 5.0/9.0,-491.67);
    public static readonly Temperature Delisle = new ("delisle", "°De", SI.Temperatures.Celcius, 1.5,100);
    public static readonly Temperature Newton = new ("newton", "°N", SI.Temperatures.Celcius, 33.0/100.0,0);
    public static readonly Temperature Réaumur = new ("réaumur", "°Ré", SI.Temperatures.Celcius, 4.0/5.0,0);
    public static readonly Temperature Rømer = new ("rømer", "°Rø", SI.Temperatures.Celcius, 0.525,-7.5);
}