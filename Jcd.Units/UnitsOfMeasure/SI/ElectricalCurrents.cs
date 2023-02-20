using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Current.
/// </summary>
public class ElectricalCurrents : Enumeration<ElectricalCurrents,ElectricalCurrent>
{

    /// <summary>
    /// A(n) ampere.
    /// </summary>
    public static readonly ElectricalCurrent Ampere = new ("ampere", "A");

    /// <summary>
    /// A(n) deciampere. Defined in terms of a(n) ampere.
    /// </summary>
    public static readonly ElectricalCurrent Deciampere = new ("deciampere", "dA", Ampere, 1.0/10.0,0);

    /// <summary>
    /// A(n) centiampere. Defined in terms of a(n) deciampere.
    /// </summary>
    public static readonly ElectricalCurrent Centiampere = new ("centiampere", "cA", Deciampere, 1.0/10.0,0);

    /// <summary>
    /// A(n) milliampere. Defined in terms of a(n) centiampere.
    /// </summary>
    public static readonly ElectricalCurrent Milliampere = new ("milliampere", "mA", Centiampere, 1.0/10.0,0);

    /// <summary>
    /// A(n) microampere. Defined in terms of a(n) milliampere.
    /// </summary>
    public static readonly ElectricalCurrent Microampere = new ("microampere", "μA", Milliampere, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanoampere. Defined in terms of a(n) microampere.
    /// </summary>
    public static readonly ElectricalCurrent Nanoampere = new ("nanoampere", "nA", Microampere, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picoampere. Defined in terms of a(n) nanoampere.
    /// </summary>
    public static readonly ElectricalCurrent Picoampere = new ("picoampere", "pA", Nanoampere, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtoampere. Defined in terms of a(n) picoampere.
    /// </summary>
    public static readonly ElectricalCurrent Femtoampere = new ("femtoampere", "fA", Picoampere, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attoampere. Defined in terms of a(n) femtoampere.
    /// </summary>
    public static readonly ElectricalCurrent Attoampere = new ("attoampere", "aA", Femtoampere, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptoampere. Defined in terms of a(n) attoampere.
    /// </summary>
    public static readonly ElectricalCurrent Zeptoampere = new ("zeptoampere", "zA", Attoampere, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctoampere. Defined in terms of a(n) zeptoampere.
    /// </summary>
    public static readonly ElectricalCurrent Yoctoampere = new ("yoctoampere", "yA", Zeptoampere, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontoampere. Defined in terms of a(n) yoctoampere.
    /// </summary>
    public static readonly ElectricalCurrent Rontoampere = new ("rontoampere", "rA", Yoctoampere, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectoampere. Defined in terms of a(n) rontoampere.
    /// </summary>
    public static readonly ElectricalCurrent Quectoampere = new ("quectoampere", "qA", Rontoampere, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekaampere. Defined in terms of a(n) ampere.
    /// </summary>
    public static readonly ElectricalCurrent Dekaampere = new ("dekaampere", "daA", Ampere, 10,0);

    /// <summary>
    /// A(n) hectoampere. Defined in terms of a(n) dekaampere.
    /// </summary>
    public static readonly ElectricalCurrent Hectoampere = new ("hectoampere", "hA", Dekaampere, 10,0);

    /// <summary>
    /// A(n) kiloampere. Defined in terms of a(n) hectoampere.
    /// </summary>
    public static readonly ElectricalCurrent Kiloampere = new ("kiloampere", "kA", Hectoampere, 10,0);

    /// <summary>
    /// A(n) megaampere. Defined in terms of a(n) kiloampere.
    /// </summary>
    public static readonly ElectricalCurrent Megaampere = new ("megaampere", "MA", Kiloampere, 1000,0);

    /// <summary>
    /// A(n) gigaampere. Defined in terms of a(n) megaampere.
    /// </summary>
    public static readonly ElectricalCurrent Gigaampere = new ("gigaampere", "GA", Megaampere, 1000,0);

    /// <summary>
    /// A(n) teraampere. Defined in terms of a(n) gigaampere.
    /// </summary>
    public static readonly ElectricalCurrent Teraampere = new ("teraampere", "TA", Gigaampere, 1000,0);

    /// <summary>
    /// A(n) petaampere. Defined in terms of a(n) teraampere.
    /// </summary>
    public static readonly ElectricalCurrent Petaampere = new ("petaampere", "PA", Teraampere, 1000,0);

    /// <summary>
    /// A(n) exaampere. Defined in terms of a(n) petaampere.
    /// </summary>
    public static readonly ElectricalCurrent Exaampere = new ("exaampere", "EA", Petaampere, 1000,0);

    /// <summary>
    /// A(n) zettaampere. Defined in terms of a(n) exaampere.
    /// </summary>
    public static readonly ElectricalCurrent Zettaampere = new ("zettaampere", "ZA", Exaampere, 1000,0);

    /// <summary>
    /// A(n) yottaampere. Defined in terms of a(n) zettaampere.
    /// </summary>
    public static readonly ElectricalCurrent Yottaampere = new ("yottaampere", "YA", Zettaampere, 1000,0);

    /// <summary>
    /// A(n) ronnaampere. Defined in terms of a(n) yottaampere.
    /// </summary>
    public static readonly ElectricalCurrent Ronnaampere = new ("ronnaampere", "RA", Yottaampere, 1000,0);

    /// <summary>
    /// A(n) quettaampere. Defined in terms of a(n) ronnaampere.
    /// </summary>
    public static readonly ElectricalCurrent Quettaampere = new ("quettaampere", "QA", Ronnaampere, 1000,0);

}