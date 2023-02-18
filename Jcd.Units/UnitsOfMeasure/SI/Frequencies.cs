using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Frequency.
/// </summary>
public class Frequencies : Enumeration<Frequencies,Frequency>
{
    public static readonly Frequency Hertz = new ("hertz", "Hz");
    public static readonly Frequency Decihertz = new ("decihertz", "dHz", Hertz, 1.0/10.0,0);
    public static readonly Frequency Centihertz = new ("centihertz", "cHz", Decihertz, 1.0/10.0,0);
    public static readonly Frequency Millihertz = new ("millihertz", "mHz", Centihertz, 1.0/10.0,0);
    public static readonly Frequency Microhertz = new ("microhertz", "μHz", Millihertz, 1.0/1000.0,0);
    public static readonly Frequency Nanohertz = new ("nanohertz", "nHz", Microhertz, 1.0/1000.0,0);
    public static readonly Frequency Picohertz = new ("picohertz", "pHz", Nanohertz, 1.0/1000.0,0);
    public static readonly Frequency Femtohertz = new ("femtohertz", "fHz", Picohertz, 1.0/1000.0,0);
    public static readonly Frequency Attohertz = new ("attohertz", "aHz", Femtohertz, 1.0/1000.0,0);
    public static readonly Frequency Zeptohertz = new ("zeptohertz", "zHz", Attohertz, 1.0/1000.0,0);
    public static readonly Frequency Yoctohertz = new ("yoctohertz", "yHz", Zeptohertz, 1.0/1000.0,0);
    public static readonly Frequency Rontohertz = new ("rontohertz", "rHz", Yoctohertz, 1.0/1000.0,0);
    public static readonly Frequency Quectohertz = new ("quectohertz", "qHz", Rontohertz, 1.0/1000.0,0);
    public static readonly Frequency Dekahertz = new ("dekahertz", "daHz", Hertz, 10,0);
    public static readonly Frequency Hectohertz = new ("hectohertz", "hHz", Dekahertz, 10,0);
    public static readonly Frequency Kilohertz = new ("kilohertz", "kHz", Hectohertz, 10,0);
    public static readonly Frequency Megahertz = new ("megahertz", "MHz", Kilohertz, 1000,0);
    public static readonly Frequency Gigahertz = new ("gigahertz", "GHz", Megahertz, 1000,0);
    public static readonly Frequency Terahertz = new ("terahertz", "THz", Gigahertz, 1000,0);
    public static readonly Frequency Petahertz = new ("petahertz", "PHz", Terahertz, 1000,0);
    public static readonly Frequency Exahertz = new ("exahertz", "EHz", Petahertz, 1000,0);
    public static readonly Frequency Zettahertz = new ("zettahertz", "ZHz", Exahertz, 1000,0);
    public static readonly Frequency Yottahertz = new ("yottahertz", "YHz", Zettahertz, 1000,0);
    public static readonly Frequency Ronnahertz = new ("ronnahertz", "RHz", Yottahertz, 1000,0);
    public static readonly Frequency Quettahertz = new ("quettahertz", "QHz", Ronnahertz, 1000,0);
}