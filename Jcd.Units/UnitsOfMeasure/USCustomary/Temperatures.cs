using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

/// <summary>
/// United States Customary Units for measuring Temperature.
/// </summary>
public class Temperatures : Enumeration<Temperatures,Temperature>
{

    /// <summary>
    /// A(n) degrees fahrenheit. It's defined in terms of a(n) SI degrees celcius.
    /// </summary>
    public static readonly Temperature DegreesFahrenheit = new ("degrees fahrenheit", "°F", SI.Temperatures.DegreesCelcius, 5.0/9.0,-32);

}