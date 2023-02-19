using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Inductance.
/// </summary>
public class Inductances : Enumeration<Inductances,Inductance>
{

    /// <summary>
    /// Units of a henry.
    /// </summary>
    public static readonly Inductance Henry = new ("henry", "H");
    /// <summary>
    /// Units of a decihenry. It's defined in terms of a(n) SI henry.
    /// </summary>
    public static readonly Inductance Decihenry = new ("decihenry", "dH", Henry, 1.0/10.0,0);
    /// <summary>
    /// Units of a centihenry. It's defined in terms of a(n) SI decihenry.
    /// </summary>
    public static readonly Inductance Centihenry = new ("centihenry", "cH", Decihenry, 1.0/10.0,0);
    /// <summary>
    /// Units of a millihenry. It's defined in terms of a(n) SI centihenry.
    /// </summary>
    public static readonly Inductance Millihenry = new ("millihenry", "mH", Centihenry, 1.0/10.0,0);
    /// <summary>
    /// Units of a microhenry. It's defined in terms of a(n) SI millihenry.
    /// </summary>
    public static readonly Inductance Microhenry = new ("microhenry", "μH", Millihenry, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanohenry. It's defined in terms of a(n) SI microhenry.
    /// </summary>
    public static readonly Inductance Nanohenry = new ("nanohenry", "nH", Microhenry, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picohenry. It's defined in terms of a(n) SI nanohenry.
    /// </summary>
    public static readonly Inductance Picohenry = new ("picohenry", "pH", Nanohenry, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtohenry. It's defined in terms of a(n) SI picohenry.
    /// </summary>
    public static readonly Inductance Femtohenry = new ("femtohenry", "fH", Picohenry, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attohenry. It's defined in terms of a(n) SI femtohenry.
    /// </summary>
    public static readonly Inductance Attohenry = new ("attohenry", "aH", Femtohenry, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptohenry. It's defined in terms of a(n) SI attohenry.
    /// </summary>
    public static readonly Inductance Zeptohenry = new ("zeptohenry", "zH", Attohenry, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctohenry. It's defined in terms of a(n) SI zeptohenry.
    /// </summary>
    public static readonly Inductance Yoctohenry = new ("yoctohenry", "yH", Zeptohenry, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontohenry. It's defined in terms of a(n) SI yoctohenry.
    /// </summary>
    public static readonly Inductance Rontohenry = new ("rontohenry", "rH", Yoctohenry, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectohenry. It's defined in terms of a(n) SI rontohenry.
    /// </summary>
    public static readonly Inductance Quectohenry = new ("quectohenry", "qH", Rontohenry, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekahenry. It's defined in terms of a(n) SI henry.
    /// </summary>
    public static readonly Inductance Dekahenry = new ("dekahenry", "daH", Henry, 10,0);
    /// <summary>
    /// Units of a hectohenry. It's defined in terms of a(n) SI dekahenry.
    /// </summary>
    public static readonly Inductance Hectohenry = new ("hectohenry", "hH", Dekahenry, 10,0);
    /// <summary>
    /// Units of a kilohenry. It's defined in terms of a(n) SI hectohenry.
    /// </summary>
    public static readonly Inductance Kilohenry = new ("kilohenry", "kH", Hectohenry, 10,0);
    /// <summary>
    /// Units of a megahenry. It's defined in terms of a(n) SI kilohenry.
    /// </summary>
    public static readonly Inductance Megahenry = new ("megahenry", "MH", Kilohenry, 1000,0);
    /// <summary>
    /// Units of a gigahenry. It's defined in terms of a(n) SI megahenry.
    /// </summary>
    public static readonly Inductance Gigahenry = new ("gigahenry", "GH", Megahenry, 1000,0);
    /// <summary>
    /// Units of a terahenry. It's defined in terms of a(n) SI gigahenry.
    /// </summary>
    public static readonly Inductance Terahenry = new ("terahenry", "TH", Gigahenry, 1000,0);
    /// <summary>
    /// Units of a petahenry. It's defined in terms of a(n) SI terahenry.
    /// </summary>
    public static readonly Inductance Petahenry = new ("petahenry", "PH", Terahenry, 1000,0);
    /// <summary>
    /// Units of a exahenry. It's defined in terms of a(n) SI petahenry.
    /// </summary>
    public static readonly Inductance Exahenry = new ("exahenry", "EH", Petahenry, 1000,0);
    /// <summary>
    /// Units of a zettahenry. It's defined in terms of a(n) SI exahenry.
    /// </summary>
    public static readonly Inductance Zettahenry = new ("zettahenry", "ZH", Exahenry, 1000,0);
    /// <summary>
    /// Units of a yottahenry. It's defined in terms of a(n) SI zettahenry.
    /// </summary>
    public static readonly Inductance Yottahenry = new ("yottahenry", "YH", Zettahenry, 1000,0);
    /// <summary>
    /// Units of a ronnahenry. It's defined in terms of a(n) SI yottahenry.
    /// </summary>
    public static readonly Inductance Ronnahenry = new ("ronnahenry", "RH", Yottahenry, 1000,0);
    /// <summary>
    /// Units of a quettahenry. It's defined in terms of a(n) SI ronnahenry.
    /// </summary>
    public static readonly Inductance Quettahenry = new ("quettahenry", "QH", Ronnahenry, 1000,0);

}