using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Inductance.
/// </summary>
public class Inductances : Enumeration<Inductances,Inductance>
{
    public static readonly Inductance Henry = new ("henry", "H");
    public static readonly Inductance Decihenry = new ("decihenry", "dH", Henry, 1.0/10.0,0);
    public static readonly Inductance Centihenry = new ("centihenry", "cH", Decihenry, 1.0/10.0,0);
    public static readonly Inductance Millihenry = new ("millihenry", "mH", Centihenry, 1.0/10.0,0);
    public static readonly Inductance Microhenry = new ("microhenry", "μH", Millihenry, 1.0/1000.0,0);
    public static readonly Inductance Nanohenry = new ("nanohenry", "nH", Microhenry, 1.0/1000.0,0);
    public static readonly Inductance Picohenry = new ("picohenry", "pH", Nanohenry, 1.0/1000.0,0);
    public static readonly Inductance Femtohenry = new ("femtohenry", "fH", Picohenry, 1.0/1000.0,0);
    public static readonly Inductance Attohenry = new ("attohenry", "aH", Femtohenry, 1.0/1000.0,0);
    public static readonly Inductance Zeptohenry = new ("zeptohenry", "zH", Attohenry, 1.0/1000.0,0);
    public static readonly Inductance Yoctohenry = new ("yoctohenry", "yH", Zeptohenry, 1.0/1000.0,0);
    public static readonly Inductance Rontohenry = new ("rontohenry", "rH", Yoctohenry, 1.0/1000.0,0);
    public static readonly Inductance Quectohenry = new ("quectohenry", "qH", Rontohenry, 1.0/1000.0,0);
    public static readonly Inductance Dekahenry = new ("dekahenry", "daH", Henry, 10,0);
    public static readonly Inductance Hectohenry = new ("hectohenry", "hH", Dekahenry, 10,0);
    public static readonly Inductance Kilohenry = new ("kilohenry", "kH", Hectohenry, 10,0);
    public static readonly Inductance Megahenry = new ("megahenry", "MH", Kilohenry, 1000,0);
    public static readonly Inductance Gigahenry = new ("gigahenry", "GH", Megahenry, 1000,0);
    public static readonly Inductance Terahenry = new ("terahenry", "TH", Gigahenry, 1000,0);
    public static readonly Inductance Petahenry = new ("petahenry", "PH", Terahenry, 1000,0);
    public static readonly Inductance Exahenry = new ("exahenry", "EH", Petahenry, 1000,0);
    public static readonly Inductance Zettahenry = new ("zettahenry", "ZH", Exahenry, 1000,0);
    public static readonly Inductance Yottahenry = new ("yottahenry", "YH", Zettahenry, 1000,0);
    public static readonly Inductance Ronnahenry = new ("ronnahenry", "RH", Yottahenry, 1000,0);
    public static readonly Inductance Quettahenry = new ("quettahenry", "QH", Ronnahenry, 1000,0);
}