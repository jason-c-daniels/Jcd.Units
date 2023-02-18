using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

public class Capacitances : Enumeration<Capacitances,Capacitance>
{
    public static readonly Capacitance Farad = new ("farad", "F");
    public static readonly Capacitance Decifarad = new ("decifarad", "dF", Farad, 1.0/10.0,0);
    public static readonly Capacitance Centifarad = new ("centifarad", "cF", Decifarad, 1.0/10.0,0);
    public static readonly Capacitance Millifarad = new ("millifarad", "mF", Centifarad, 1.0/10.0,0);
    public static readonly Capacitance Microfarad = new ("microfarad", "μF", Millifarad, 1.0/1000.0,0);
    public static readonly Capacitance Nanofarad = new ("nanofarad", "nF", Microfarad, 1.0/1000.0,0);
    public static readonly Capacitance Picofarad = new ("picofarad", "pF", Nanofarad, 1.0/1000.0,0);
    public static readonly Capacitance Femtofarad = new ("femtofarad", "fF", Picofarad, 1.0/1000.0,0);
    public static readonly Capacitance Attofarad = new ("attofarad", "aF", Femtofarad, 1.0/1000.0,0);
    public static readonly Capacitance Zeptofarad = new ("zeptofarad", "zF", Attofarad, 1.0/1000.0,0);
    public static readonly Capacitance Yoctofarad = new ("yoctofarad", "yF", Zeptofarad, 1.0/1000.0,0);
    public static readonly Capacitance Rontofarad = new ("rontofarad", "rF", Yoctofarad, 1.0/1000.0,0);
    public static readonly Capacitance Quectofarad = new ("quectofarad", "qF", Rontofarad, 1.0/1000.0,0);
    public static readonly Capacitance Dekafarad = new ("dekafarad", "daF", Farad, 10,0);
    public static readonly Capacitance Hectofarad = new ("hectofarad", "hF", Dekafarad, 10,0);
    public static readonly Capacitance Kilofarad = new ("kilofarad", "kF", Hectofarad, 10,0);
    public static readonly Capacitance Megafarad = new ("megafarad", "MF", Kilofarad, 1000,0);
    public static readonly Capacitance Gigafarad = new ("gigafarad", "GF", Megafarad, 1000,0);
    public static readonly Capacitance Terafarad = new ("terafarad", "TF", Gigafarad, 1000,0);
    public static readonly Capacitance Petafarad = new ("petafarad", "PF", Terafarad, 1000,0);
    public static readonly Capacitance Exafarad = new ("exafarad", "EF", Petafarad, 1000,0);
    public static readonly Capacitance Zettafarad = new ("zettafarad", "ZF", Exafarad, 1000,0);
    public static readonly Capacitance Yottafarad = new ("yottafarad", "YF", Zettafarad, 1000,0);
    public static readonly Capacitance Ronnafarad = new ("ronnafarad", "RF", Yottafarad, 1000,0);
    public static readonly Capacitance Quettafarad = new ("quettafarad", "QF", Ronnafarad, 1000,0);
}