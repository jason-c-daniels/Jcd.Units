using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Current.
/// </summary>
public class ElectricalCurrents : Enumeration<ElectricalCurrents,ElectricalCurrent>
{

    /// <summary>
    /// Units of a ampere.
    /// </summary>
    public static readonly ElectricalCurrent Ampere = new ("ampere", "A");
    /// <summary>
    /// Units of a deciampere. It's defined in terms of a(n) SI ampere.
    /// </summary>
    public static readonly ElectricalCurrent Deciampere = new ("deciampere", "dA", Ampere, 1.0/10.0,0);
    /// <summary>
    /// Units of a centiampere. It's defined in terms of a(n) SI deciampere.
    /// </summary>
    public static readonly ElectricalCurrent Centiampere = new ("centiampere", "cA", Deciampere, 1.0/10.0,0);
    /// <summary>
    /// Units of a milliampere. It's defined in terms of a(n) SI centiampere.
    /// </summary>
    public static readonly ElectricalCurrent Milliampere = new ("milliampere", "mA", Centiampere, 1.0/10.0,0);
    /// <summary>
    /// Units of a microampere. It's defined in terms of a(n) SI milliampere.
    /// </summary>
    public static readonly ElectricalCurrent Microampere = new ("microampere", "μA", Milliampere, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanoampere. It's defined in terms of a(n) SI microampere.
    /// </summary>
    public static readonly ElectricalCurrent Nanoampere = new ("nanoampere", "nA", Microampere, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picoampere. It's defined in terms of a(n) SI nanoampere.
    /// </summary>
    public static readonly ElectricalCurrent Picoampere = new ("picoampere", "pA", Nanoampere, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtoampere. It's defined in terms of a(n) SI picoampere.
    /// </summary>
    public static readonly ElectricalCurrent Femtoampere = new ("femtoampere", "fA", Picoampere, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attoampere. It's defined in terms of a(n) SI femtoampere.
    /// </summary>
    public static readonly ElectricalCurrent Attoampere = new ("attoampere", "aA", Femtoampere, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptoampere. It's defined in terms of a(n) SI attoampere.
    /// </summary>
    public static readonly ElectricalCurrent Zeptoampere = new ("zeptoampere", "zA", Attoampere, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctoampere. It's defined in terms of a(n) SI zeptoampere.
    /// </summary>
    public static readonly ElectricalCurrent Yoctoampere = new ("yoctoampere", "yA", Zeptoampere, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontoampere. It's defined in terms of a(n) SI yoctoampere.
    /// </summary>
    public static readonly ElectricalCurrent Rontoampere = new ("rontoampere", "rA", Yoctoampere, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectoampere. It's defined in terms of a(n) SI rontoampere.
    /// </summary>
    public static readonly ElectricalCurrent Quectoampere = new ("quectoampere", "qA", Rontoampere, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekaampere. It's defined in terms of a(n) SI ampere.
    /// </summary>
    public static readonly ElectricalCurrent Dekaampere = new ("dekaampere", "daA", Ampere, 10,0);
    /// <summary>
    /// Units of a hectoampere. It's defined in terms of a(n) SI dekaampere.
    /// </summary>
    public static readonly ElectricalCurrent Hectoampere = new ("hectoampere", "hA", Dekaampere, 10,0);
    /// <summary>
    /// Units of a kiloampere. It's defined in terms of a(n) SI hectoampere.
    /// </summary>
    public static readonly ElectricalCurrent Kiloampere = new ("kiloampere", "kA", Hectoampere, 10,0);
    /// <summary>
    /// Units of a megaampere. It's defined in terms of a(n) SI kiloampere.
    /// </summary>
    public static readonly ElectricalCurrent Megaampere = new ("megaampere", "MA", Kiloampere, 1000,0);
    /// <summary>
    /// Units of a gigaampere. It's defined in terms of a(n) SI megaampere.
    /// </summary>
    public static readonly ElectricalCurrent Gigaampere = new ("gigaampere", "GA", Megaampere, 1000,0);
    /// <summary>
    /// Units of a teraampere. It's defined in terms of a(n) SI gigaampere.
    /// </summary>
    public static readonly ElectricalCurrent Teraampere = new ("teraampere", "TA", Gigaampere, 1000,0);
    /// <summary>
    /// Units of a petaampere. It's defined in terms of a(n) SI teraampere.
    /// </summary>
    public static readonly ElectricalCurrent Petaampere = new ("petaampere", "PA", Teraampere, 1000,0);
    /// <summary>
    /// Units of a exaampere. It's defined in terms of a(n) SI petaampere.
    /// </summary>
    public static readonly ElectricalCurrent Exaampere = new ("exaampere", "EA", Petaampere, 1000,0);
    /// <summary>
    /// Units of a zettaampere. It's defined in terms of a(n) SI exaampere.
    /// </summary>
    public static readonly ElectricalCurrent Zettaampere = new ("zettaampere", "ZA", Exaampere, 1000,0);
    /// <summary>
    /// Units of a yottaampere. It's defined in terms of a(n) SI zettaampere.
    /// </summary>
    public static readonly ElectricalCurrent Yottaampere = new ("yottaampere", "YA", Zettaampere, 1000,0);
    /// <summary>
    /// Units of a ronnaampere. It's defined in terms of a(n) SI yottaampere.
    /// </summary>
    public static readonly ElectricalCurrent Ronnaampere = new ("ronnaampere", "RA", Yottaampere, 1000,0);
    /// <summary>
    /// Units of a quettaampere. It's defined in terms of a(n) SI ronnaampere.
    /// </summary>
    public static readonly ElectricalCurrent Quettaampere = new ("quettaampere", "QA", Ronnaampere, 1000,0);

}