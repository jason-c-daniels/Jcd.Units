using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure;

public class Temperatures : Enumeration<Temperatures,Temperature>
{
    public static Temperature Fahrenheit = new ("Fahrenheit", "°F",SI.Temperatures.Celcius,5.0/9.0,-32.0);
    public static Temperature Rankine = new ("Rankine", "°R",SI.Temperatures.Celcius,5.0/9.0, -491.67);
    public static Temperature Delisle = new ("Delisle", "°De",SI.Temperatures.Celcius,1.5,100.0);
    public static Temperature Newton = new ("Newton", "°N",SI.Temperatures.Celcius,33.0/100.0);
    public static Temperature Réaumur = new ("Réaumur", "°Ré",SI.Temperatures.Celcius,4.0/5.0);
    public static Temperature Rømer = new ("Rømer", "°Rø",SI.Temperatures.Celcius,0.52500,-7.5);
}