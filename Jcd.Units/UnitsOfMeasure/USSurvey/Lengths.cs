using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global


namespace Jcd.Units.UnitsOfMeasure.USSurvey;

/// <summary>
/// United States Survey Units for measuring Length.
/// </summary>
public class Lengths : Enumeration<Lengths,Length>
{

    /// <summary>
    /// A(n) link. Defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length Link = new ("link", "li", SI.Lengths.Meter, 0.20116,0);

    /// <summary>
    /// A(n) rod. Defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length Rod = new ("rod", "rd", SI.Lengths.Meter, 5.0292,0);

    /// <summary>
    /// A(n) chain. Defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length Chain = new ("chain", "ch", SI.Lengths.Meter, 20.1168,0);

    /// <summary>
    /// A(n) furlong. Defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length Furlong = new ("furlong", "fur", SI.Lengths.Meter, 201.168,0);

    /// <summary>
    /// A(n) league. Defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length League = new ("league", "lea", SI.Lengths.Meter, 4828.032,0);

}