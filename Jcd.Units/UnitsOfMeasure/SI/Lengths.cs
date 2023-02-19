using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Length.
/// </summary>
public class Lengths : Enumeration<Lengths,Length>
{

    /// <summary>
    /// Units of a meter.
    /// </summary>
    public static readonly Length Meter = new ("meter", "m");
    /// <summary>
    /// Units of a decimeter. It's defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length Decimeter = new ("decimeter", "dm", Meter, 1.0/10.0,0);
    /// <summary>
    /// Units of a centimeter. It's defined in terms of a(n) SI decimeter.
    /// </summary>
    public static readonly Length Centimeter = new ("centimeter", "cm", Decimeter, 1.0/10.0,0);
    /// <summary>
    /// Units of a millimeter. It's defined in terms of a(n) SI centimeter.
    /// </summary>
    public static readonly Length Millimeter = new ("millimeter", "mm", Centimeter, 1.0/10.0,0);
    /// <summary>
    /// Units of a micrometer. It's defined in terms of a(n) SI millimeter.
    /// </summary>
    public static readonly Length Micrometer = new ("micrometer", "μm", Millimeter, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanometer. It's defined in terms of a(n) SI micrometer.
    /// </summary>
    public static readonly Length Nanometer = new ("nanometer", "nm", Micrometer, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picometer. It's defined in terms of a(n) SI nanometer.
    /// </summary>
    public static readonly Length Picometer = new ("picometer", "pm", Nanometer, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtometer. It's defined in terms of a(n) SI picometer.
    /// </summary>
    public static readonly Length Femtometer = new ("femtometer", "fm", Picometer, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attometer. It's defined in terms of a(n) SI femtometer.
    /// </summary>
    public static readonly Length Attometer = new ("attometer", "am", Femtometer, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptometer. It's defined in terms of a(n) SI attometer.
    /// </summary>
    public static readonly Length Zeptometer = new ("zeptometer", "zm", Attometer, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctometer. It's defined in terms of a(n) SI zeptometer.
    /// </summary>
    public static readonly Length Yoctometer = new ("yoctometer", "ym", Zeptometer, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontometer. It's defined in terms of a(n) SI yoctometer.
    /// </summary>
    public static readonly Length Rontometer = new ("rontometer", "rm", Yoctometer, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectometer. It's defined in terms of a(n) SI rontometer.
    /// </summary>
    public static readonly Length Quectometer = new ("quectometer", "qm", Rontometer, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekameter. It's defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length Dekameter = new ("dekameter", "dam", Meter, 10,0);
    /// <summary>
    /// Units of a hectometer. It's defined in terms of a(n) SI dekameter.
    /// </summary>
    public static readonly Length Hectometer = new ("hectometer", "hm", Dekameter, 10,0);
    /// <summary>
    /// Units of a kilometer. It's defined in terms of a(n) SI hectometer.
    /// </summary>
    public static readonly Length Kilometer = new ("kilometer", "km", Hectometer, 10,0);
    /// <summary>
    /// Units of a megameter. It's defined in terms of a(n) SI kilometer.
    /// </summary>
    public static readonly Length Megameter = new ("megameter", "Mm", Kilometer, 1000,0);
    /// <summary>
    /// Units of a gigameter. It's defined in terms of a(n) SI megameter.
    /// </summary>
    public static readonly Length Gigameter = new ("gigameter", "Gm", Megameter, 1000,0);
    /// <summary>
    /// Units of a terameter. It's defined in terms of a(n) SI gigameter.
    /// </summary>
    public static readonly Length Terameter = new ("terameter", "Tm", Gigameter, 1000,0);
    /// <summary>
    /// Units of a petameter. It's defined in terms of a(n) SI terameter.
    /// </summary>
    public static readonly Length Petameter = new ("petameter", "Pm", Terameter, 1000,0);
    /// <summary>
    /// Units of a exameter. It's defined in terms of a(n) SI petameter.
    /// </summary>
    public static readonly Length Exameter = new ("exameter", "Em", Petameter, 1000,0);
    /// <summary>
    /// Units of a zettameter. It's defined in terms of a(n) SI exameter.
    /// </summary>
    public static readonly Length Zettameter = new ("zettameter", "Zm", Exameter, 1000,0);
    /// <summary>
    /// Units of a yottameter. It's defined in terms of a(n) SI zettameter.
    /// </summary>
    public static readonly Length Yottameter = new ("yottameter", "Ym", Zettameter, 1000,0);
    /// <summary>
    /// Units of a ronnameter. It's defined in terms of a(n) SI yottameter.
    /// </summary>
    public static readonly Length Ronnameter = new ("ronnameter", "Rm", Yottameter, 1000,0);
    /// <summary>
    /// Units of a quettameter. It's defined in terms of a(n) SI ronnameter.
    /// </summary>
    public static readonly Length Quettameter = new ("quettameter", "Qm", Ronnameter, 1000,0);

}