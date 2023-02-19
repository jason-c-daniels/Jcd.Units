using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Conductance.
/// </summary>
public class ElectricalConductances : Enumeration<ElectricalConductances,ElectricalConductance>
{

    /// <summary>
    /// Units of a siemens.
    /// </summary>
    public static readonly ElectricalConductance Siemens = new ("siemens", "S");
    /// <summary>
    /// Units of a decisiemens. It's defined in terms of a(n) SI siemens.
    /// </summary>
    public static readonly ElectricalConductance Decisiemens = new ("decisiemens", "dS", Siemens, 1.0/10.0,0);
    /// <summary>
    /// Units of a centisiemens. It's defined in terms of a(n) SI decisiemens.
    /// </summary>
    public static readonly ElectricalConductance Centisiemens = new ("centisiemens", "cS", Decisiemens, 1.0/10.0,0);
    /// <summary>
    /// Units of a millisiemens. It's defined in terms of a(n) SI centisiemens.
    /// </summary>
    public static readonly ElectricalConductance Millisiemens = new ("millisiemens", "mS", Centisiemens, 1.0/10.0,0);
    /// <summary>
    /// Units of a microsiemens. It's defined in terms of a(n) SI millisiemens.
    /// </summary>
    public static readonly ElectricalConductance Microsiemens = new ("microsiemens", "μS", Millisiemens, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanosiemens. It's defined in terms of a(n) SI microsiemens.
    /// </summary>
    public static readonly ElectricalConductance Nanosiemens = new ("nanosiemens", "nS", Microsiemens, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picosiemens. It's defined in terms of a(n) SI nanosiemens.
    /// </summary>
    public static readonly ElectricalConductance Picosiemens = new ("picosiemens", "pS", Nanosiemens, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtosiemens. It's defined in terms of a(n) SI picosiemens.
    /// </summary>
    public static readonly ElectricalConductance Femtosiemens = new ("femtosiemens", "fS", Picosiemens, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attosiemens. It's defined in terms of a(n) SI femtosiemens.
    /// </summary>
    public static readonly ElectricalConductance Attosiemens = new ("attosiemens", "aS", Femtosiemens, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptosiemens. It's defined in terms of a(n) SI attosiemens.
    /// </summary>
    public static readonly ElectricalConductance Zeptosiemens = new ("zeptosiemens", "zS", Attosiemens, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctosiemens. It's defined in terms of a(n) SI zeptosiemens.
    /// </summary>
    public static readonly ElectricalConductance Yoctosiemens = new ("yoctosiemens", "yS", Zeptosiemens, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontosiemens. It's defined in terms of a(n) SI yoctosiemens.
    /// </summary>
    public static readonly ElectricalConductance Rontosiemens = new ("rontosiemens", "rS", Yoctosiemens, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectosiemens. It's defined in terms of a(n) SI rontosiemens.
    /// </summary>
    public static readonly ElectricalConductance Quectosiemens = new ("quectosiemens", "qS", Rontosiemens, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekasiemens. It's defined in terms of a(n) SI siemens.
    /// </summary>
    public static readonly ElectricalConductance Dekasiemens = new ("dekasiemens", "daS", Siemens, 10,0);
    /// <summary>
    /// Units of a hectosiemens. It's defined in terms of a(n) SI dekasiemens.
    /// </summary>
    public static readonly ElectricalConductance Hectosiemens = new ("hectosiemens", "hS", Dekasiemens, 10,0);
    /// <summary>
    /// Units of a kilosiemens. It's defined in terms of a(n) SI hectosiemens.
    /// </summary>
    public static readonly ElectricalConductance Kilosiemens = new ("kilosiemens", "kS", Hectosiemens, 10,0);
    /// <summary>
    /// Units of a megasiemens. It's defined in terms of a(n) SI kilosiemens.
    /// </summary>
    public static readonly ElectricalConductance Megasiemens = new ("megasiemens", "MS", Kilosiemens, 1000,0);
    /// <summary>
    /// Units of a gigasiemens. It's defined in terms of a(n) SI megasiemens.
    /// </summary>
    public static readonly ElectricalConductance Gigasiemens = new ("gigasiemens", "GS", Megasiemens, 1000,0);
    /// <summary>
    /// Units of a terasiemens. It's defined in terms of a(n) SI gigasiemens.
    /// </summary>
    public static readonly ElectricalConductance Terasiemens = new ("terasiemens", "TS", Gigasiemens, 1000,0);
    /// <summary>
    /// Units of a petasiemens. It's defined in terms of a(n) SI terasiemens.
    /// </summary>
    public static readonly ElectricalConductance Petasiemens = new ("petasiemens", "PS", Terasiemens, 1000,0);
    /// <summary>
    /// Units of a exasiemens. It's defined in terms of a(n) SI petasiemens.
    /// </summary>
    public static readonly ElectricalConductance Exasiemens = new ("exasiemens", "ES", Petasiemens, 1000,0);
    /// <summary>
    /// Units of a zettasiemens. It's defined in terms of a(n) SI exasiemens.
    /// </summary>
    public static readonly ElectricalConductance Zettasiemens = new ("zettasiemens", "ZS", Exasiemens, 1000,0);
    /// <summary>
    /// Units of a yottasiemens. It's defined in terms of a(n) SI zettasiemens.
    /// </summary>
    public static readonly ElectricalConductance Yottasiemens = new ("yottasiemens", "YS", Zettasiemens, 1000,0);
    /// <summary>
    /// Units of a ronnasiemens. It's defined in terms of a(n) SI yottasiemens.
    /// </summary>
    public static readonly ElectricalConductance Ronnasiemens = new ("ronnasiemens", "RS", Yottasiemens, 1000,0);
    /// <summary>
    /// Units of a quettasiemens. It's defined in terms of a(n) SI ronnasiemens.
    /// </summary>
    public static readonly ElectricalConductance Quettasiemens = new ("quettasiemens", "QS", Ronnasiemens, 1000,0);

}