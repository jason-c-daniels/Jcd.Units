using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Temperature.
/// </summary>
public class Temperatures : Enumeration<Temperatures,Temperature>
{

    /// <summary>
    /// Units of a degrees celcius.
    /// </summary>
    public static readonly Temperature DegreesCelcius = new ("degrees celcius", "°C");
    /// <summary>
    /// Units of a degrees kelvin. It's defined in terms of a(n) SI degrees celcius.
    /// </summary>
    public static readonly Temperature DegreesKelvin = new ("degrees kelvin", "°K", DegreesCelcius, 1,-273.15);

}