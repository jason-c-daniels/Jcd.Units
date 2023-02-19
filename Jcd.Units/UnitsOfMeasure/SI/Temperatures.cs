using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Temperature.
/// </summary>
public class Temperatures : Enumeration<Temperatures,Temperature>
{


    /// <summary>
    /// A(n) degrees celcius.
    /// </summary>
    public static readonly Temperature DegreesCelcius = new ("degrees celcius", "°C");
    /// <summary>
    /// A(n) degrees kelvin. It's defined in terms of a(n) degrees celcius.
    /// </summary>
    public static readonly Temperature DegreesKelvin = new ("degrees kelvin", "°K", DegreesCelcius, 1,-273.15);

}