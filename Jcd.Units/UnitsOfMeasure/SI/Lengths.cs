using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Length.
/// </summary>
public class Lengths : Enumeration<Lengths,Length>
{
    public static readonly Length Meter = new ("meter", "m");
    public static readonly Length Decimeter = new ("decimeter", "dm", Meter, 1.0/10.0,0);
    public static readonly Length Centimeter = new ("centimeter", "cm", Decimeter, 1.0/10.0,0);
    public static readonly Length Millimeter = new ("millimeter", "mm", Centimeter, 1.0/10.0,0);
    public static readonly Length Micrometer = new ("micrometer", "μm", Millimeter, 1.0/1000.0,0);
    public static readonly Length Nanometer = new ("nanometer", "nm", Micrometer, 1.0/1000.0,0);
    public static readonly Length Picometer = new ("picometer", "pm", Nanometer, 1.0/1000.0,0);
    public static readonly Length Femtometer = new ("femtometer", "fm", Picometer, 1.0/1000.0,0);
    public static readonly Length Attometer = new ("attometer", "am", Femtometer, 1.0/1000.0,0);
    public static readonly Length Zeptometer = new ("zeptometer", "zm", Attometer, 1.0/1000.0,0);
    public static readonly Length Yoctometer = new ("yoctometer", "ym", Zeptometer, 1.0/1000.0,0);
    public static readonly Length Rontometer = new ("rontometer", "rm", Yoctometer, 1.0/1000.0,0);
    public static readonly Length Quectometer = new ("quectometer", "qm", Rontometer, 1.0/1000.0,0);
    public static readonly Length Dekameter = new ("dekameter", "dam", Meter, 10,0);
    public static readonly Length Hectometer = new ("hectometer", "hm", Dekameter, 10,0);
    public static readonly Length Kilometer = new ("kilometer", "km", Hectometer, 10,0);
    public static readonly Length Megameter = new ("megameter", "Mm", Kilometer, 1000,0);
    public static readonly Length Gigameter = new ("gigameter", "Gm", Megameter, 1000,0);
    public static readonly Length Terameter = new ("terameter", "Tm", Gigameter, 1000,0);
    public static readonly Length Petameter = new ("petameter", "Pm", Terameter, 1000,0);
    public static readonly Length Exameter = new ("exameter", "Em", Petameter, 1000,0);
    public static readonly Length Zettameter = new ("zettameter", "Zm", Exameter, 1000,0);
    public static readonly Length Yottameter = new ("yottameter", "Ym", Zettameter, 1000,0);
    public static readonly Length Ronnameter = new ("ronnameter", "Rm", Yottameter, 1000,0);
    public static readonly Length Quettameter = new ("quettameter", "Qm", Ronnameter, 1000,0);
}