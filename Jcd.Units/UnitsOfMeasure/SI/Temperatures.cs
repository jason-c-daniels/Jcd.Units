using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

public class Temperatures : Enumeration<Temperatures,Temperature>
{
    public static readonly Temperature Celcius = new ("celcius", "°C");
    public static readonly Temperature Kelvin = new ("kelvin", "°K", Celcius, 1,-273.15);
}