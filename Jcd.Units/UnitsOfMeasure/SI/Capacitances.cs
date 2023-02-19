using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Capacitance.
/// </summary>
public class Capacitances : Enumeration<Capacitances,Capacitance>
{

    /// <summary>
    /// Units of a farad.
    /// </summary>
    public static readonly Capacitance Farad = new ("farad", "F");
    /// <summary>
    /// Units of a decifarad. It's defined in terms of a(n) SI farad.
    /// </summary>
    public static readonly Capacitance Decifarad = new ("decifarad", "dF", Farad, 1.0/10.0,0);
    /// <summary>
    /// Units of a centifarad. It's defined in terms of a(n) SI decifarad.
    /// </summary>
    public static readonly Capacitance Centifarad = new ("centifarad", "cF", Decifarad, 1.0/10.0,0);
    /// <summary>
    /// Units of a millifarad. It's defined in terms of a(n) SI centifarad.
    /// </summary>
    public static readonly Capacitance Millifarad = new ("millifarad", "mF", Centifarad, 1.0/10.0,0);
    /// <summary>
    /// Units of a microfarad. It's defined in terms of a(n) SI millifarad.
    /// </summary>
    public static readonly Capacitance Microfarad = new ("microfarad", "μF", Millifarad, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanofarad. It's defined in terms of a(n) SI microfarad.
    /// </summary>
    public static readonly Capacitance Nanofarad = new ("nanofarad", "nF", Microfarad, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picofarad. It's defined in terms of a(n) SI nanofarad.
    /// </summary>
    public static readonly Capacitance Picofarad = new ("picofarad", "pF", Nanofarad, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtofarad. It's defined in terms of a(n) SI picofarad.
    /// </summary>
    public static readonly Capacitance Femtofarad = new ("femtofarad", "fF", Picofarad, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attofarad. It's defined in terms of a(n) SI femtofarad.
    /// </summary>
    public static readonly Capacitance Attofarad = new ("attofarad", "aF", Femtofarad, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptofarad. It's defined in terms of a(n) SI attofarad.
    /// </summary>
    public static readonly Capacitance Zeptofarad = new ("zeptofarad", "zF", Attofarad, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctofarad. It's defined in terms of a(n) SI zeptofarad.
    /// </summary>
    public static readonly Capacitance Yoctofarad = new ("yoctofarad", "yF", Zeptofarad, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontofarad. It's defined in terms of a(n) SI yoctofarad.
    /// </summary>
    public static readonly Capacitance Rontofarad = new ("rontofarad", "rF", Yoctofarad, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectofarad. It's defined in terms of a(n) SI rontofarad.
    /// </summary>
    public static readonly Capacitance Quectofarad = new ("quectofarad", "qF", Rontofarad, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekafarad. It's defined in terms of a(n) SI farad.
    /// </summary>
    public static readonly Capacitance Dekafarad = new ("dekafarad", "daF", Farad, 10,0);
    /// <summary>
    /// Units of a hectofarad. It's defined in terms of a(n) SI dekafarad.
    /// </summary>
    public static readonly Capacitance Hectofarad = new ("hectofarad", "hF", Dekafarad, 10,0);
    /// <summary>
    /// Units of a kilofarad. It's defined in terms of a(n) SI hectofarad.
    /// </summary>
    public static readonly Capacitance Kilofarad = new ("kilofarad", "kF", Hectofarad, 10,0);
    /// <summary>
    /// Units of a megafarad. It's defined in terms of a(n) SI kilofarad.
    /// </summary>
    public static readonly Capacitance Megafarad = new ("megafarad", "MF", Kilofarad, 1000,0);
    /// <summary>
    /// Units of a gigafarad. It's defined in terms of a(n) SI megafarad.
    /// </summary>
    public static readonly Capacitance Gigafarad = new ("gigafarad", "GF", Megafarad, 1000,0);
    /// <summary>
    /// Units of a terafarad. It's defined in terms of a(n) SI gigafarad.
    /// </summary>
    public static readonly Capacitance Terafarad = new ("terafarad", "TF", Gigafarad, 1000,0);
    /// <summary>
    /// Units of a petafarad. It's defined in terms of a(n) SI terafarad.
    /// </summary>
    public static readonly Capacitance Petafarad = new ("petafarad", "PF", Terafarad, 1000,0);
    /// <summary>
    /// Units of a exafarad. It's defined in terms of a(n) SI petafarad.
    /// </summary>
    public static readonly Capacitance Exafarad = new ("exafarad", "EF", Petafarad, 1000,0);
    /// <summary>
    /// Units of a zettafarad. It's defined in terms of a(n) SI exafarad.
    /// </summary>
    public static readonly Capacitance Zettafarad = new ("zettafarad", "ZF", Exafarad, 1000,0);
    /// <summary>
    /// Units of a yottafarad. It's defined in terms of a(n) SI zettafarad.
    /// </summary>
    public static readonly Capacitance Yottafarad = new ("yottafarad", "YF", Zettafarad, 1000,0);
    /// <summary>
    /// Units of a ronnafarad. It's defined in terms of a(n) SI yottafarad.
    /// </summary>
    public static readonly Capacitance Ronnafarad = new ("ronnafarad", "RF", Yottafarad, 1000,0);
    /// <summary>
    /// Units of a quettafarad. It's defined in terms of a(n) SI ronnafarad.
    /// </summary>
    public static readonly Capacitance Quettafarad = new ("quettafarad", "QF", Ronnafarad, 1000,0);

}