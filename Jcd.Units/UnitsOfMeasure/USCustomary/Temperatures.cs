using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

/// <summary>
/// United States Customary Units for measuring Temperature.
/// </summary>
public class Temperatures : Enumeration<Temperatures,Temperature>
{

    /// <summary>
    /// A(n) degrees fahrenheit. Defined in terms of a(n) SI degrees celcius.
    /// </summary>
    public static readonly Temperature DegreesFahrenheit = new ("degrees fahrenheit", "°F", SI.Temperatures.DegreesCelcius, 5.0/9.0,-32);

}