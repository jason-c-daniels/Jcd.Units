using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global


namespace Jcd.Units.UnitsOfMeasure;

/// <summary>
/// Uncategorized Units for measuring Temperature.
/// </summary>
public class Temperatures : Enumeration<Temperatures,Temperature>
{

    /// <summary>
    /// A(n) degrees rankine. Defined in terms of a(n) SI degrees celcius.
    /// </summary>
    public static readonly Temperature DegreesRankine = new ("degrees rankine", "°R", SI.Temperatures.DegreesCelcius, 5.0/9.0,-491.67);

    /// <summary>
    /// A(n) degrees delisle. Defined in terms of a(n) SI degrees celcius.
    /// </summary>
    public static readonly Temperature DegreesDelisle = new ("degrees delisle", "°De", SI.Temperatures.DegreesCelcius, 3.0/2.0,-150);

    /// <summary>
    /// A(n) degrees newton. Defined in terms of a(n) SI degrees celcius.
    /// </summary>
    public static readonly Temperature DegreesNewton = new ("degrees newton", "°N", SI.Temperatures.DegreesCelcius, 100.0/33.0,0);

    /// <summary>
    /// A(n) degrees réaumur. Defined in terms of a(n) SI degrees celcius.
    /// </summary>
    public static readonly Temperature DegreesRéaumur = new ("degrees réaumur", "°Ré", SI.Temperatures.DegreesCelcius, 5.0/4.0,0);

    /// <summary>
    /// A(n) degrees rømer. Defined in terms of a(n) SI degrees celcius.
    /// </summary>
    public static readonly Temperature DegreesRømer = new ("degrees rømer", "°Rø", SI.Temperatures.DegreesCelcius, 1000.0/525.0,-7.5);

}