﻿using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Resistance.
/// </summary>
public class Resistances : Enumeration<Resistances,Resistance>
{

    /// <summary>
    /// A(n) ohm.
    /// </summary>
    public static readonly Resistance Ohm = new ("ohm", "Ω");

    /// <summary>
    /// A(n) deciohm. Defined in terms of a(n) ohm.
    /// </summary>
    public static readonly Resistance Deciohm = new ("deciohm", "dΩ", Ohm, 1.0/10.0,0);

    /// <summary>
    /// A(n) centiohm. Defined in terms of a(n) deciohm.
    /// </summary>
    public static readonly Resistance Centiohm = new ("centiohm", "cΩ", Deciohm, 1.0/10.0,0);

    /// <summary>
    /// A(n) milliohm. Defined in terms of a(n) centiohm.
    /// </summary>
    public static readonly Resistance Milliohm = new ("milliohm", "mΩ", Centiohm, 1.0/10.0,0);

    /// <summary>
    /// A(n) microohm. Defined in terms of a(n) milliohm.
    /// </summary>
    public static readonly Resistance Microohm = new ("microohm", "μΩ", Milliohm, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanoohm. Defined in terms of a(n) microohm.
    /// </summary>
    public static readonly Resistance Nanoohm = new ("nanoohm", "nΩ", Microohm, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picoohm. Defined in terms of a(n) nanoohm.
    /// </summary>
    public static readonly Resistance Picoohm = new ("picoohm", "pΩ", Nanoohm, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtoohm. Defined in terms of a(n) picoohm.
    /// </summary>
    public static readonly Resistance Femtoohm = new ("femtoohm", "fΩ", Picoohm, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attoohm. Defined in terms of a(n) femtoohm.
    /// </summary>
    public static readonly Resistance Attoohm = new ("attoohm", "aΩ", Femtoohm, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptoohm. Defined in terms of a(n) attoohm.
    /// </summary>
    public static readonly Resistance Zeptoohm = new ("zeptoohm", "zΩ", Attoohm, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctoohm. Defined in terms of a(n) zeptoohm.
    /// </summary>
    public static readonly Resistance Yoctoohm = new ("yoctoohm", "yΩ", Zeptoohm, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontoohm. Defined in terms of a(n) yoctoohm.
    /// </summary>
    public static readonly Resistance Rontoohm = new ("rontoohm", "rΩ", Yoctoohm, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectoohm. Defined in terms of a(n) rontoohm.
    /// </summary>
    public static readonly Resistance Quectoohm = new ("quectoohm", "qΩ", Rontoohm, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekaohm. Defined in terms of a(n) ohm.
    /// </summary>
    public static readonly Resistance Dekaohm = new ("dekaohm", "daΩ", Ohm, 10,0);

    /// <summary>
    /// A(n) hectoohm. Defined in terms of a(n) dekaohm.
    /// </summary>
    public static readonly Resistance Hectoohm = new ("hectoohm", "hΩ", Dekaohm, 10,0);

    /// <summary>
    /// A(n) kiloohm. Defined in terms of a(n) hectoohm.
    /// </summary>
    public static readonly Resistance Kiloohm = new ("kiloohm", "kΩ", Hectoohm, 10,0);

    /// <summary>
    /// A(n) megaohm. Defined in terms of a(n) kiloohm.
    /// </summary>
    public static readonly Resistance Megaohm = new ("megaohm", "MΩ", Kiloohm, 1000,0);

    /// <summary>
    /// A(n) gigaohm. Defined in terms of a(n) megaohm.
    /// </summary>
    public static readonly Resistance Gigaohm = new ("gigaohm", "GΩ", Megaohm, 1000,0);

    /// <summary>
    /// A(n) teraohm. Defined in terms of a(n) gigaohm.
    /// </summary>
    public static readonly Resistance Teraohm = new ("teraohm", "TΩ", Gigaohm, 1000,0);

    /// <summary>
    /// A(n) petaohm. Defined in terms of a(n) teraohm.
    /// </summary>
    public static readonly Resistance Petaohm = new ("petaohm", "PΩ", Teraohm, 1000,0);

    /// <summary>
    /// A(n) exaohm. Defined in terms of a(n) petaohm.
    /// </summary>
    public static readonly Resistance Exaohm = new ("exaohm", "EΩ", Petaohm, 1000,0);

    /// <summary>
    /// A(n) zettaohm. Defined in terms of a(n) exaohm.
    /// </summary>
    public static readonly Resistance Zettaohm = new ("zettaohm", "ZΩ", Exaohm, 1000,0);

    /// <summary>
    /// A(n) yottaohm. Defined in terms of a(n) zettaohm.
    /// </summary>
    public static readonly Resistance Yottaohm = new ("yottaohm", "YΩ", Zettaohm, 1000,0);

    /// <summary>
    /// A(n) ronnaohm. Defined in terms of a(n) yottaohm.
    /// </summary>
    public static readonly Resistance Ronnaohm = new ("ronnaohm", "RΩ", Yottaohm, 1000,0);

    /// <summary>
    /// A(n) quettaohm. Defined in terms of a(n) ronnaohm.
    /// </summary>
    public static readonly Resistance Quettaohm = new ("quettaohm", "QΩ", Ronnaohm, 1000,0);

}