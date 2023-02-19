using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Resistance.
/// </summary>
public class Resistances : Enumeration<Resistances,Resistance>
{

    /// <summary>
    /// Units of a ohm.
    /// </summary>
    public static readonly Resistance Ohm = new ("ohm", "Ω");
    /// <summary>
    /// Units of a deciohm. It's defined in terms of a(n) SI ohm.
    /// </summary>
    public static readonly Resistance Deciohm = new ("deciohm", "dΩ", Ohm, 1.0/10.0,0);
    /// <summary>
    /// Units of a centiohm. It's defined in terms of a(n) SI deciohm.
    /// </summary>
    public static readonly Resistance Centiohm = new ("centiohm", "cΩ", Deciohm, 1.0/10.0,0);
    /// <summary>
    /// Units of a milliohm. It's defined in terms of a(n) SI centiohm.
    /// </summary>
    public static readonly Resistance Milliohm = new ("milliohm", "mΩ", Centiohm, 1.0/10.0,0);
    /// <summary>
    /// Units of a microohm. It's defined in terms of a(n) SI milliohm.
    /// </summary>
    public static readonly Resistance Microohm = new ("microohm", "μΩ", Milliohm, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanoohm. It's defined in terms of a(n) SI microohm.
    /// </summary>
    public static readonly Resistance Nanoohm = new ("nanoohm", "nΩ", Microohm, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picoohm. It's defined in terms of a(n) SI nanoohm.
    /// </summary>
    public static readonly Resistance Picoohm = new ("picoohm", "pΩ", Nanoohm, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtoohm. It's defined in terms of a(n) SI picoohm.
    /// </summary>
    public static readonly Resistance Femtoohm = new ("femtoohm", "fΩ", Picoohm, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attoohm. It's defined in terms of a(n) SI femtoohm.
    /// </summary>
    public static readonly Resistance Attoohm = new ("attoohm", "aΩ", Femtoohm, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptoohm. It's defined in terms of a(n) SI attoohm.
    /// </summary>
    public static readonly Resistance Zeptoohm = new ("zeptoohm", "zΩ", Attoohm, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctoohm. It's defined in terms of a(n) SI zeptoohm.
    /// </summary>
    public static readonly Resistance Yoctoohm = new ("yoctoohm", "yΩ", Zeptoohm, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontoohm. It's defined in terms of a(n) SI yoctoohm.
    /// </summary>
    public static readonly Resistance Rontoohm = new ("rontoohm", "rΩ", Yoctoohm, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectoohm. It's defined in terms of a(n) SI rontoohm.
    /// </summary>
    public static readonly Resistance Quectoohm = new ("quectoohm", "qΩ", Rontoohm, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekaohm. It's defined in terms of a(n) SI ohm.
    /// </summary>
    public static readonly Resistance Dekaohm = new ("dekaohm", "daΩ", Ohm, 10,0);
    /// <summary>
    /// Units of a hectoohm. It's defined in terms of a(n) SI dekaohm.
    /// </summary>
    public static readonly Resistance Hectoohm = new ("hectoohm", "hΩ", Dekaohm, 10,0);
    /// <summary>
    /// Units of a kiloohm. It's defined in terms of a(n) SI hectoohm.
    /// </summary>
    public static readonly Resistance Kiloohm = new ("kiloohm", "kΩ", Hectoohm, 10,0);
    /// <summary>
    /// Units of a megaohm. It's defined in terms of a(n) SI kiloohm.
    /// </summary>
    public static readonly Resistance Megaohm = new ("megaohm", "MΩ", Kiloohm, 1000,0);
    /// <summary>
    /// Units of a gigaohm. It's defined in terms of a(n) SI megaohm.
    /// </summary>
    public static readonly Resistance Gigaohm = new ("gigaohm", "GΩ", Megaohm, 1000,0);
    /// <summary>
    /// Units of a teraohm. It's defined in terms of a(n) SI gigaohm.
    /// </summary>
    public static readonly Resistance Teraohm = new ("teraohm", "TΩ", Gigaohm, 1000,0);
    /// <summary>
    /// Units of a petaohm. It's defined in terms of a(n) SI teraohm.
    /// </summary>
    public static readonly Resistance Petaohm = new ("petaohm", "PΩ", Teraohm, 1000,0);
    /// <summary>
    /// Units of a exaohm. It's defined in terms of a(n) SI petaohm.
    /// </summary>
    public static readonly Resistance Exaohm = new ("exaohm", "EΩ", Petaohm, 1000,0);
    /// <summary>
    /// Units of a zettaohm. It's defined in terms of a(n) SI exaohm.
    /// </summary>
    public static readonly Resistance Zettaohm = new ("zettaohm", "ZΩ", Exaohm, 1000,0);
    /// <summary>
    /// Units of a yottaohm. It's defined in terms of a(n) SI zettaohm.
    /// </summary>
    public static readonly Resistance Yottaohm = new ("yottaohm", "YΩ", Zettaohm, 1000,0);
    /// <summary>
    /// Units of a ronnaohm. It's defined in terms of a(n) SI yottaohm.
    /// </summary>
    public static readonly Resistance Ronnaohm = new ("ronnaohm", "RΩ", Yottaohm, 1000,0);
    /// <summary>
    /// Units of a quettaohm. It's defined in terms of a(n) SI ronnaohm.
    /// </summary>
    public static readonly Resistance Quettaohm = new ("quettaohm", "QΩ", Ronnaohm, 1000,0);

}