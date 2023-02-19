using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Frequency.
/// </summary>
public class Frequencies : Enumeration<Frequencies,Frequency>
{

    /// <summary>
    /// Units of a hertz.
    /// </summary>
    public static readonly Frequency Hertz = new ("hertz", "Hz");
    /// <summary>
    /// Units of a decihertz. It's defined in terms of a(n) SI hertz.
    /// </summary>
    public static readonly Frequency Decihertz = new ("decihertz", "dHz", Hertz, 1.0/10.0,0);
    /// <summary>
    /// Units of a centihertz. It's defined in terms of a(n) SI decihertz.
    /// </summary>
    public static readonly Frequency Centihertz = new ("centihertz", "cHz", Decihertz, 1.0/10.0,0);
    /// <summary>
    /// Units of a millihertz. It's defined in terms of a(n) SI centihertz.
    /// </summary>
    public static readonly Frequency Millihertz = new ("millihertz", "mHz", Centihertz, 1.0/10.0,0);
    /// <summary>
    /// Units of a microhertz. It's defined in terms of a(n) SI millihertz.
    /// </summary>
    public static readonly Frequency Microhertz = new ("microhertz", "μHz", Millihertz, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanohertz. It's defined in terms of a(n) SI microhertz.
    /// </summary>
    public static readonly Frequency Nanohertz = new ("nanohertz", "nHz", Microhertz, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picohertz. It's defined in terms of a(n) SI nanohertz.
    /// </summary>
    public static readonly Frequency Picohertz = new ("picohertz", "pHz", Nanohertz, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtohertz. It's defined in terms of a(n) SI picohertz.
    /// </summary>
    public static readonly Frequency Femtohertz = new ("femtohertz", "fHz", Picohertz, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attohertz. It's defined in terms of a(n) SI femtohertz.
    /// </summary>
    public static readonly Frequency Attohertz = new ("attohertz", "aHz", Femtohertz, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptohertz. It's defined in terms of a(n) SI attohertz.
    /// </summary>
    public static readonly Frequency Zeptohertz = new ("zeptohertz", "zHz", Attohertz, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctohertz. It's defined in terms of a(n) SI zeptohertz.
    /// </summary>
    public static readonly Frequency Yoctohertz = new ("yoctohertz", "yHz", Zeptohertz, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontohertz. It's defined in terms of a(n) SI yoctohertz.
    /// </summary>
    public static readonly Frequency Rontohertz = new ("rontohertz", "rHz", Yoctohertz, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectohertz. It's defined in terms of a(n) SI rontohertz.
    /// </summary>
    public static readonly Frequency Quectohertz = new ("quectohertz", "qHz", Rontohertz, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekahertz. It's defined in terms of a(n) SI hertz.
    /// </summary>
    public static readonly Frequency Dekahertz = new ("dekahertz", "daHz", Hertz, 10,0);
    /// <summary>
    /// Units of a hectohertz. It's defined in terms of a(n) SI dekahertz.
    /// </summary>
    public static readonly Frequency Hectohertz = new ("hectohertz", "hHz", Dekahertz, 10,0);
    /// <summary>
    /// Units of a kilohertz. It's defined in terms of a(n) SI hectohertz.
    /// </summary>
    public static readonly Frequency Kilohertz = new ("kilohertz", "kHz", Hectohertz, 10,0);
    /// <summary>
    /// Units of a megahertz. It's defined in terms of a(n) SI kilohertz.
    /// </summary>
    public static readonly Frequency Megahertz = new ("megahertz", "MHz", Kilohertz, 1000,0);
    /// <summary>
    /// Units of a gigahertz. It's defined in terms of a(n) SI megahertz.
    /// </summary>
    public static readonly Frequency Gigahertz = new ("gigahertz", "GHz", Megahertz, 1000,0);
    /// <summary>
    /// Units of a terahertz. It's defined in terms of a(n) SI gigahertz.
    /// </summary>
    public static readonly Frequency Terahertz = new ("terahertz", "THz", Gigahertz, 1000,0);
    /// <summary>
    /// Units of a petahertz. It's defined in terms of a(n) SI terahertz.
    /// </summary>
    public static readonly Frequency Petahertz = new ("petahertz", "PHz", Terahertz, 1000,0);
    /// <summary>
    /// Units of a exahertz. It's defined in terms of a(n) SI petahertz.
    /// </summary>
    public static readonly Frequency Exahertz = new ("exahertz", "EHz", Petahertz, 1000,0);
    /// <summary>
    /// Units of a zettahertz. It's defined in terms of a(n) SI exahertz.
    /// </summary>
    public static readonly Frequency Zettahertz = new ("zettahertz", "ZHz", Exahertz, 1000,0);
    /// <summary>
    /// Units of a yottahertz. It's defined in terms of a(n) SI zettahertz.
    /// </summary>
    public static readonly Frequency Yottahertz = new ("yottahertz", "YHz", Zettahertz, 1000,0);
    /// <summary>
    /// Units of a ronnahertz. It's defined in terms of a(n) SI yottahertz.
    /// </summary>
    public static readonly Frequency Ronnahertz = new ("ronnahertz", "RHz", Yottahertz, 1000,0);
    /// <summary>
    /// Units of a quettahertz. It's defined in terms of a(n) SI ronnahertz.
    /// </summary>
    public static readonly Frequency Quettahertz = new ("quettahertz", "QHz", Ronnahertz, 1000,0);

}