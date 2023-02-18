using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Resistance.
/// </summary>
public class Resistances : Enumeration<Resistances,Resistance>
{
    public static readonly Resistance Ohm = new ("ohm", "Ω");
    public static readonly Resistance Deciohm = new ("deciohm", "dΩ", Ohm, 1.0/10.0,0);
    public static readonly Resistance Centiohm = new ("centiohm", "cΩ", Deciohm, 1.0/10.0,0);
    public static readonly Resistance Milliohm = new ("milliohm", "mΩ", Centiohm, 1.0/10.0,0);
    public static readonly Resistance Microohm = new ("microohm", "μΩ", Milliohm, 1.0/1000.0,0);
    public static readonly Resistance Nanoohm = new ("nanoohm", "nΩ", Microohm, 1.0/1000.0,0);
    public static readonly Resistance Picoohm = new ("picoohm", "pΩ", Nanoohm, 1.0/1000.0,0);
    public static readonly Resistance Femtoohm = new ("femtoohm", "fΩ", Picoohm, 1.0/1000.0,0);
    public static readonly Resistance Attoohm = new ("attoohm", "aΩ", Femtoohm, 1.0/1000.0,0);
    public static readonly Resistance Zeptoohm = new ("zeptoohm", "zΩ", Attoohm, 1.0/1000.0,0);
    public static readonly Resistance Yoctoohm = new ("yoctoohm", "yΩ", Zeptoohm, 1.0/1000.0,0);
    public static readonly Resistance Rontoohm = new ("rontoohm", "rΩ", Yoctoohm, 1.0/1000.0,0);
    public static readonly Resistance Quectoohm = new ("quectoohm", "qΩ", Rontoohm, 1.0/1000.0,0);
    public static readonly Resistance Dekaohm = new ("dekaohm", "daΩ", Ohm, 10,0);
    public static readonly Resistance Hectoohm = new ("hectoohm", "hΩ", Dekaohm, 10,0);
    public static readonly Resistance Kiloohm = new ("kiloohm", "kΩ", Hectoohm, 10,0);
    public static readonly Resistance Megaohm = new ("megaohm", "MΩ", Kiloohm, 1000,0);
    public static readonly Resistance Gigaohm = new ("gigaohm", "GΩ", Megaohm, 1000,0);
    public static readonly Resistance Teraohm = new ("teraohm", "TΩ", Gigaohm, 1000,0);
    public static readonly Resistance Petaohm = new ("petaohm", "PΩ", Teraohm, 1000,0);
    public static readonly Resistance Exaohm = new ("exaohm", "EΩ", Petaohm, 1000,0);
    public static readonly Resistance Zettaohm = new ("zettaohm", "ZΩ", Exaohm, 1000,0);
    public static readonly Resistance Yottaohm = new ("yottaohm", "YΩ", Zettaohm, 1000,0);
    public static readonly Resistance Ronnaohm = new ("ronnaohm", "RΩ", Yottaohm, 1000,0);
    public static readonly Resistance Quettaohm = new ("quettaohm", "QΩ", Ronnaohm, 1000,0);
}