using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Frequency.
/// </summary>
public class Frequencies : Enumeration<Frequencies,Frequency>
{

    /// <summary>
    /// A(n) hertz.
    /// </summary>
    public static readonly Frequency Hertz = new ("hertz", "Hz");

    /// <summary>
    /// A(n) decihertz. Defined in terms of a(n) hertz.
    /// </summary>
    public static readonly Frequency Decihertz = new ("decihertz", "dHz", Hertz, 1.0/10.0,0);

    /// <summary>
    /// A(n) centihertz. Defined in terms of a(n) decihertz.
    /// </summary>
    public static readonly Frequency Centihertz = new ("centihertz", "cHz", Decihertz, 1.0/10.0,0);

    /// <summary>
    /// A(n) millihertz. Defined in terms of a(n) centihertz.
    /// </summary>
    public static readonly Frequency Millihertz = new ("millihertz", "mHz", Centihertz, 1.0/10.0,0);

    /// <summary>
    /// A(n) microhertz. Defined in terms of a(n) millihertz.
    /// </summary>
    public static readonly Frequency Microhertz = new ("microhertz", "μHz", Millihertz, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanohertz. Defined in terms of a(n) microhertz.
    /// </summary>
    public static readonly Frequency Nanohertz = new ("nanohertz", "nHz", Microhertz, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picohertz. Defined in terms of a(n) nanohertz.
    /// </summary>
    public static readonly Frequency Picohertz = new ("picohertz", "pHz", Nanohertz, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtohertz. Defined in terms of a(n) picohertz.
    /// </summary>
    public static readonly Frequency Femtohertz = new ("femtohertz", "fHz", Picohertz, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attohertz. Defined in terms of a(n) femtohertz.
    /// </summary>
    public static readonly Frequency Attohertz = new ("attohertz", "aHz", Femtohertz, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptohertz. Defined in terms of a(n) attohertz.
    /// </summary>
    public static readonly Frequency Zeptohertz = new ("zeptohertz", "zHz", Attohertz, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctohertz. Defined in terms of a(n) zeptohertz.
    /// </summary>
    public static readonly Frequency Yoctohertz = new ("yoctohertz", "yHz", Zeptohertz, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontohertz. Defined in terms of a(n) yoctohertz.
    /// </summary>
    public static readonly Frequency Rontohertz = new ("rontohertz", "rHz", Yoctohertz, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectohertz. Defined in terms of a(n) rontohertz.
    /// </summary>
    public static readonly Frequency Quectohertz = new ("quectohertz", "qHz", Rontohertz, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekahertz. Defined in terms of a(n) hertz.
    /// </summary>
    public static readonly Frequency Dekahertz = new ("dekahertz", "daHz", Hertz, 10,0);

    /// <summary>
    /// A(n) hectohertz. Defined in terms of a(n) dekahertz.
    /// </summary>
    public static readonly Frequency Hectohertz = new ("hectohertz", "hHz", Dekahertz, 10,0);

    /// <summary>
    /// A(n) kilohertz. Defined in terms of a(n) hectohertz.
    /// </summary>
    public static readonly Frequency Kilohertz = new ("kilohertz", "kHz", Hectohertz, 10,0);

    /// <summary>
    /// A(n) megahertz. Defined in terms of a(n) kilohertz.
    /// </summary>
    public static readonly Frequency Megahertz = new ("megahertz", "MHz", Kilohertz, 1000,0);

    /// <summary>
    /// A(n) gigahertz. Defined in terms of a(n) megahertz.
    /// </summary>
    public static readonly Frequency Gigahertz = new ("gigahertz", "GHz", Megahertz, 1000,0);

    /// <summary>
    /// A(n) terahertz. Defined in terms of a(n) gigahertz.
    /// </summary>
    public static readonly Frequency Terahertz = new ("terahertz", "THz", Gigahertz, 1000,0);

    /// <summary>
    /// A(n) petahertz. Defined in terms of a(n) terahertz.
    /// </summary>
    public static readonly Frequency Petahertz = new ("petahertz", "PHz", Terahertz, 1000,0);

    /// <summary>
    /// A(n) exahertz. Defined in terms of a(n) petahertz.
    /// </summary>
    public static readonly Frequency Exahertz = new ("exahertz", "EHz", Petahertz, 1000,0);

    /// <summary>
    /// A(n) zettahertz. Defined in terms of a(n) exahertz.
    /// </summary>
    public static readonly Frequency Zettahertz = new ("zettahertz", "ZHz", Exahertz, 1000,0);

    /// <summary>
    /// A(n) yottahertz. Defined in terms of a(n) zettahertz.
    /// </summary>
    public static readonly Frequency Yottahertz = new ("yottahertz", "YHz", Zettahertz, 1000,0);

    /// <summary>
    /// A(n) ronnahertz. Defined in terms of a(n) yottahertz.
    /// </summary>
    public static readonly Frequency Ronnahertz = new ("ronnahertz", "RHz", Yottahertz, 1000,0);

    /// <summary>
    /// A(n) quettahertz. Defined in terms of a(n) ronnahertz.
    /// </summary>
    public static readonly Frequency Quettahertz = new ("quettahertz", "QHz", Ronnahertz, 1000,0);

}