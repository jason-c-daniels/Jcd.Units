using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Temperature.
/// </summary>
public class Temperatures : Enumeration<Temperatures,Temperature>
{
    public static readonly Temperature DegreesCelcius = new ("degrees celcius", "°C");
    public static readonly Temperature DegreesKelvin = new ("degrees kelvin", "°K", DegreesCelcius, 1,-273.15);
}