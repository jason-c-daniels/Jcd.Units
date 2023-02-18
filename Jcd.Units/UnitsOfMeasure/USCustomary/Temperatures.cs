using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

public class Temperatures : Enumeration<Temperatures,Temperature>
{
    public static readonly Temperature DegreesFahrenheit = new ("degrees fahrenheit", "°F", SI.Temperatures.DegreesCelcius, 5.0/9.0,-32);
}