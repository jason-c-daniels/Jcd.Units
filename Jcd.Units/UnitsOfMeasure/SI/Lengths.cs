using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

public class Lengths : Enumeration<Lengths,Length>
{
    public static readonly Length Meter = new Length("meter", "m", 1.0, 0);
    public static readonly Length Decimeter = new Length("decimeter", "dm", Meter, 1.0 / 10.0);
    public static readonly Length Centimeter = new Length("centimeter", "cm", Decimeter, 1.0 / 10.0);
    public static readonly Length Millimeter = new Length("millimeter", "mm", Centimeter, 1.0 / 10.0);
    public static readonly Length Micrometer = new Length("micrometer", "μm", Millimeter, 1.0 / 1000.0);
    public static readonly Length Nanometer = new Length("nanometer", "nm", Micrometer, 1.0 / 1000.0);
    public static readonly Length Picometer = new Length("picometer", "pm", Nanometer, 1.0 / 1000.0);
    public static readonly Length Femtometer = new Length("femtometer", "fm", Picometer, 1.0 / 1000.0);
    public static readonly Length Attometer = new Length("attometer", "am", Femtometer, 1.0 / 1000.0);
    public static readonly Length Zeptometer = new Length("zepometer", "zm", Attometer, 1.0 / 1000.0);
    public static readonly Length Yoctometer = new Length("yoctometer", "ym", Zeptometer, 1.0 / 1000.0);
    public static readonly Length Dekameter = new Length("dekameter", "dam", Meter, 10);
    public static readonly Length Hectometer = new Length("hectometer", "hm", Meter, 100);
    public static readonly Length Kilometer = new Length("kilometer", "km", Meter, 1000);
    public static readonly Length Megameter = new Length("megameter", "Mm", Kilometer, 1000);
    public static readonly Length Gigameter = new Length("gigameter", "Gm", Megameter, 1000);
    public static readonly Length Terameter = new Length("terameter", "Tm", Gigameter, 1000);
    public static readonly Length Petameter = new Length("petameter", "Pm", Terameter, 1000);
    public static readonly Length Exameter = new Length("exameter", "Em", Petameter, 1000);
    public static readonly Length Zettameter = new Length("zettameter", "Zm", Exameter, 1000);
    public static readonly Length Yottameter = new Length("yottameter", "Ym", Zettameter, 1000);
}