using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

public class Temperatures : Enumeration<Temperatures,Temperature>
{
    public static Temperature Celcius = new ("Celcius", "°C",1,0);
    public static Temperature Kelvin = new ("Kelvin", "°K", Celcius,1,-273.15);
}