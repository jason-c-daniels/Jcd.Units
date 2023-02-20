using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global


namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Capacitance.
/// </summary>
public class Capacitances : Enumeration<Capacitances,Capacitance>
{

    /// <summary>
    /// A(n) farad.
    /// </summary>
    public static readonly Capacitance Farad = new ("farad", "F");

    /// <summary>
    /// A(n) decifarad. Defined in terms of a(n) farad.
    /// </summary>
    public static readonly Capacitance Decifarad = new ("decifarad", "dF", Farad, 1.0/10.0,0);

    /// <summary>
    /// A(n) centifarad. Defined in terms of a(n) decifarad.
    /// </summary>
    public static readonly Capacitance Centifarad = new ("centifarad", "cF", Decifarad, 1.0/10.0,0);

    /// <summary>
    /// A(n) millifarad. Defined in terms of a(n) centifarad.
    /// </summary>
    public static readonly Capacitance Millifarad = new ("millifarad", "mF", Centifarad, 1.0/10.0,0);

    /// <summary>
    /// A(n) microfarad. Defined in terms of a(n) millifarad.
    /// </summary>
    public static readonly Capacitance Microfarad = new ("microfarad", "μF", Millifarad, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanofarad. Defined in terms of a(n) microfarad.
    /// </summary>
    public static readonly Capacitance Nanofarad = new ("nanofarad", "nF", Microfarad, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picofarad. Defined in terms of a(n) nanofarad.
    /// </summary>
    public static readonly Capacitance Picofarad = new ("picofarad", "pF", Nanofarad, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtofarad. Defined in terms of a(n) picofarad.
    /// </summary>
    public static readonly Capacitance Femtofarad = new ("femtofarad", "fF", Picofarad, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attofarad. Defined in terms of a(n) femtofarad.
    /// </summary>
    public static readonly Capacitance Attofarad = new ("attofarad", "aF", Femtofarad, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptofarad. Defined in terms of a(n) attofarad.
    /// </summary>
    public static readonly Capacitance Zeptofarad = new ("zeptofarad", "zF", Attofarad, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctofarad. Defined in terms of a(n) zeptofarad.
    /// </summary>
    public static readonly Capacitance Yoctofarad = new ("yoctofarad", "yF", Zeptofarad, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontofarad. Defined in terms of a(n) yoctofarad.
    /// </summary>
    public static readonly Capacitance Rontofarad = new ("rontofarad", "rF", Yoctofarad, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectofarad. Defined in terms of a(n) rontofarad.
    /// </summary>
    public static readonly Capacitance Quectofarad = new ("quectofarad", "qF", Rontofarad, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekafarad. Defined in terms of a(n) farad.
    /// </summary>
    public static readonly Capacitance Dekafarad = new ("dekafarad", "daF", Farad, 10,0);

    /// <summary>
    /// A(n) hectofarad. Defined in terms of a(n) dekafarad.
    /// </summary>
    public static readonly Capacitance Hectofarad = new ("hectofarad", "hF", Dekafarad, 10,0);

    /// <summary>
    /// A(n) kilofarad. Defined in terms of a(n) hectofarad.
    /// </summary>
    public static readonly Capacitance Kilofarad = new ("kilofarad", "kF", Hectofarad, 10,0);

    /// <summary>
    /// A(n) megafarad. Defined in terms of a(n) kilofarad.
    /// </summary>
    public static readonly Capacitance Megafarad = new ("megafarad", "MF", Kilofarad, 1000,0);

    /// <summary>
    /// A(n) gigafarad. Defined in terms of a(n) megafarad.
    /// </summary>
    public static readonly Capacitance Gigafarad = new ("gigafarad", "GF", Megafarad, 1000,0);

    /// <summary>
    /// A(n) terafarad. Defined in terms of a(n) gigafarad.
    /// </summary>
    public static readonly Capacitance Terafarad = new ("terafarad", "TF", Gigafarad, 1000,0);

    /// <summary>
    /// A(n) petafarad. Defined in terms of a(n) terafarad.
    /// </summary>
    public static readonly Capacitance Petafarad = new ("petafarad", "PF", Terafarad, 1000,0);

    /// <summary>
    /// A(n) exafarad. Defined in terms of a(n) petafarad.
    /// </summary>
    public static readonly Capacitance Exafarad = new ("exafarad", "EF", Petafarad, 1000,0);

    /// <summary>
    /// A(n) zettafarad. Defined in terms of a(n) exafarad.
    /// </summary>
    public static readonly Capacitance Zettafarad = new ("zettafarad", "ZF", Exafarad, 1000,0);

    /// <summary>
    /// A(n) yottafarad. Defined in terms of a(n) zettafarad.
    /// </summary>
    public static readonly Capacitance Yottafarad = new ("yottafarad", "YF", Zettafarad, 1000,0);

    /// <summary>
    /// A(n) ronnafarad. Defined in terms of a(n) yottafarad.
    /// </summary>
    public static readonly Capacitance Ronnafarad = new ("ronnafarad", "RF", Yottafarad, 1000,0);

    /// <summary>
    /// A(n) quettafarad. Defined in terms of a(n) ronnafarad.
    /// </summary>
    public static readonly Capacitance Quettafarad = new ("quettafarad", "QF", Ronnafarad, 1000,0);

}