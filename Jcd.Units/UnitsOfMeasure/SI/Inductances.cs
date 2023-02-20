using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global


namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Inductance.
/// </summary>
public class Inductances : Enumeration<Inductances,Inductance>
{

    /// <summary>
    /// A(n) henry.
    /// </summary>
    public static readonly Inductance Henry = new ("henry", "H");

    /// <summary>
    /// A(n) decihenry. Defined in terms of a(n) henry.
    /// </summary>
    public static readonly Inductance Decihenry = new ("decihenry", "dH", Henry, 1.0/10.0,0);

    /// <summary>
    /// A(n) centihenry. Defined in terms of a(n) decihenry.
    /// </summary>
    public static readonly Inductance Centihenry = new ("centihenry", "cH", Decihenry, 1.0/10.0,0);

    /// <summary>
    /// A(n) millihenry. Defined in terms of a(n) centihenry.
    /// </summary>
    public static readonly Inductance Millihenry = new ("millihenry", "mH", Centihenry, 1.0/10.0,0);

    /// <summary>
    /// A(n) microhenry. Defined in terms of a(n) millihenry.
    /// </summary>
    public static readonly Inductance Microhenry = new ("microhenry", "μH", Millihenry, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanohenry. Defined in terms of a(n) microhenry.
    /// </summary>
    public static readonly Inductance Nanohenry = new ("nanohenry", "nH", Microhenry, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picohenry. Defined in terms of a(n) nanohenry.
    /// </summary>
    public static readonly Inductance Picohenry = new ("picohenry", "pH", Nanohenry, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtohenry. Defined in terms of a(n) picohenry.
    /// </summary>
    public static readonly Inductance Femtohenry = new ("femtohenry", "fH", Picohenry, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attohenry. Defined in terms of a(n) femtohenry.
    /// </summary>
    public static readonly Inductance Attohenry = new ("attohenry", "aH", Femtohenry, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptohenry. Defined in terms of a(n) attohenry.
    /// </summary>
    public static readonly Inductance Zeptohenry = new ("zeptohenry", "zH", Attohenry, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctohenry. Defined in terms of a(n) zeptohenry.
    /// </summary>
    public static readonly Inductance Yoctohenry = new ("yoctohenry", "yH", Zeptohenry, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontohenry. Defined in terms of a(n) yoctohenry.
    /// </summary>
    public static readonly Inductance Rontohenry = new ("rontohenry", "rH", Yoctohenry, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectohenry. Defined in terms of a(n) rontohenry.
    /// </summary>
    public static readonly Inductance Quectohenry = new ("quectohenry", "qH", Rontohenry, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekahenry. Defined in terms of a(n) henry.
    /// </summary>
    public static readonly Inductance Dekahenry = new ("dekahenry", "daH", Henry, 10,0);

    /// <summary>
    /// A(n) hectohenry. Defined in terms of a(n) dekahenry.
    /// </summary>
    public static readonly Inductance Hectohenry = new ("hectohenry", "hH", Dekahenry, 10,0);

    /// <summary>
    /// A(n) kilohenry. Defined in terms of a(n) hectohenry.
    /// </summary>
    public static readonly Inductance Kilohenry = new ("kilohenry", "kH", Hectohenry, 10,0);

    /// <summary>
    /// A(n) megahenry. Defined in terms of a(n) kilohenry.
    /// </summary>
    public static readonly Inductance Megahenry = new ("megahenry", "MH", Kilohenry, 1000,0);

    /// <summary>
    /// A(n) gigahenry. Defined in terms of a(n) megahenry.
    /// </summary>
    public static readonly Inductance Gigahenry = new ("gigahenry", "GH", Megahenry, 1000,0);

    /// <summary>
    /// A(n) terahenry. Defined in terms of a(n) gigahenry.
    /// </summary>
    public static readonly Inductance Terahenry = new ("terahenry", "TH", Gigahenry, 1000,0);

    /// <summary>
    /// A(n) petahenry. Defined in terms of a(n) terahenry.
    /// </summary>
    public static readonly Inductance Petahenry = new ("petahenry", "PH", Terahenry, 1000,0);

    /// <summary>
    /// A(n) exahenry. Defined in terms of a(n) petahenry.
    /// </summary>
    public static readonly Inductance Exahenry = new ("exahenry", "EH", Petahenry, 1000,0);

    /// <summary>
    /// A(n) zettahenry. Defined in terms of a(n) exahenry.
    /// </summary>
    public static readonly Inductance Zettahenry = new ("zettahenry", "ZH", Exahenry, 1000,0);

    /// <summary>
    /// A(n) yottahenry. Defined in terms of a(n) zettahenry.
    /// </summary>
    public static readonly Inductance Yottahenry = new ("yottahenry", "YH", Zettahenry, 1000,0);

    /// <summary>
    /// A(n) ronnahenry. Defined in terms of a(n) yottahenry.
    /// </summary>
    public static readonly Inductance Ronnahenry = new ("ronnahenry", "RH", Yottahenry, 1000,0);

    /// <summary>
    /// A(n) quettahenry. Defined in terms of a(n) ronnahenry.
    /// </summary>
    public static readonly Inductance Quettahenry = new ("quettahenry", "QH", Ronnahenry, 1000,0);

}