using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Current.
/// </summary>
public class ElectricalCurrents : Enumeration<ElectricalCurrents,ElectricalCurrent>
{
    public static readonly ElectricalCurrent Ampere = new ("ampere", "A");
    public static readonly ElectricalCurrent Deciampere = new ("deciampere", "dA", Ampere, 1.0/10.0,0);
    public static readonly ElectricalCurrent Centiampere = new ("centiampere", "cA", Deciampere, 1.0/10.0,0);
    public static readonly ElectricalCurrent Milliampere = new ("milliampere", "mA", Centiampere, 1.0/10.0,0);
    public static readonly ElectricalCurrent Microampere = new ("microampere", "μA", Milliampere, 1.0/1000.0,0);
    public static readonly ElectricalCurrent Nanoampere = new ("nanoampere", "nA", Microampere, 1.0/1000.0,0);
    public static readonly ElectricalCurrent Picoampere = new ("picoampere", "pA", Nanoampere, 1.0/1000.0,0);
    public static readonly ElectricalCurrent Femtoampere = new ("femtoampere", "fA", Picoampere, 1.0/1000.0,0);
    public static readonly ElectricalCurrent Attoampere = new ("attoampere", "aA", Femtoampere, 1.0/1000.0,0);
    public static readonly ElectricalCurrent Zeptoampere = new ("zeptoampere", "zA", Attoampere, 1.0/1000.0,0);
    public static readonly ElectricalCurrent Yoctoampere = new ("yoctoampere", "yA", Zeptoampere, 1.0/1000.0,0);
    public static readonly ElectricalCurrent Rontoampere = new ("rontoampere", "rA", Yoctoampere, 1.0/1000.0,0);
    public static readonly ElectricalCurrent Quectoampere = new ("quectoampere", "qA", Rontoampere, 1.0/1000.0,0);
    public static readonly ElectricalCurrent Dekaampere = new ("dekaampere", "daA", Ampere, 10,0);
    public static readonly ElectricalCurrent Hectoampere = new ("hectoampere", "hA", Dekaampere, 10,0);
    public static readonly ElectricalCurrent Kiloampere = new ("kiloampere", "kA", Hectoampere, 10,0);
    public static readonly ElectricalCurrent Megaampere = new ("megaampere", "MA", Kiloampere, 1000,0);
    public static readonly ElectricalCurrent Gigaampere = new ("gigaampere", "GA", Megaampere, 1000,0);
    public static readonly ElectricalCurrent Teraampere = new ("teraampere", "TA", Gigaampere, 1000,0);
    public static readonly ElectricalCurrent Petaampere = new ("petaampere", "PA", Teraampere, 1000,0);
    public static readonly ElectricalCurrent Exaampere = new ("exaampere", "EA", Petaampere, 1000,0);
    public static readonly ElectricalCurrent Zettaampere = new ("zettaampere", "ZA", Exaampere, 1000,0);
    public static readonly ElectricalCurrent Yottaampere = new ("yottaampere", "YA", Zettaampere, 1000,0);
    public static readonly ElectricalCurrent Ronnaampere = new ("ronnaampere", "RA", Yottaampere, 1000,0);
    public static readonly ElectricalCurrent Quettaampere = new ("quettaampere", "QA", Ronnaampere, 1000,0);
}