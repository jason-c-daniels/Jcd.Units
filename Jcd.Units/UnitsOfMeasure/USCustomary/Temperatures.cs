using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

public class Temperatures : Enumeration<Temperatures,Temperature>
{
    public static readonly Temperature Fahrenheit = new ("fahrenheit", "°F", SI.Temperatures.Celcius, 5.0/9.0,32);
}