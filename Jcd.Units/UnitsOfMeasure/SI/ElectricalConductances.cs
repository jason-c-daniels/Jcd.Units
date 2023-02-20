using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global


namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Conductance.
/// </summary>
public class ElectricalConductances : Enumeration<ElectricalConductances,ElectricalConductance>
{

    /// <summary>
    /// A(n) siemens.
    /// </summary>
    public static readonly ElectricalConductance Siemens = new ("siemens", "S");

    /// <summary>
    /// A(n) decisiemens. Defined in terms of a(n) siemens.
    /// </summary>
    public static readonly ElectricalConductance Decisiemens = new ("decisiemens", "dS", Siemens, 1.0/10.0,0);

    /// <summary>
    /// A(n) centisiemens. Defined in terms of a(n) decisiemens.
    /// </summary>
    public static readonly ElectricalConductance Centisiemens = new ("centisiemens", "cS", Decisiemens, 1.0/10.0,0);

    /// <summary>
    /// A(n) millisiemens. Defined in terms of a(n) centisiemens.
    /// </summary>
    public static readonly ElectricalConductance Millisiemens = new ("millisiemens", "mS", Centisiemens, 1.0/10.0,0);

    /// <summary>
    /// A(n) microsiemens. Defined in terms of a(n) millisiemens.
    /// </summary>
    public static readonly ElectricalConductance Microsiemens = new ("microsiemens", "μS", Millisiemens, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanosiemens. Defined in terms of a(n) microsiemens.
    /// </summary>
    public static readonly ElectricalConductance Nanosiemens = new ("nanosiemens", "nS", Microsiemens, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picosiemens. Defined in terms of a(n) nanosiemens.
    /// </summary>
    public static readonly ElectricalConductance Picosiemens = new ("picosiemens", "pS", Nanosiemens, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtosiemens. Defined in terms of a(n) picosiemens.
    /// </summary>
    public static readonly ElectricalConductance Femtosiemens = new ("femtosiemens", "fS", Picosiemens, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attosiemens. Defined in terms of a(n) femtosiemens.
    /// </summary>
    public static readonly ElectricalConductance Attosiemens = new ("attosiemens", "aS", Femtosiemens, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptosiemens. Defined in terms of a(n) attosiemens.
    /// </summary>
    public static readonly ElectricalConductance Zeptosiemens = new ("zeptosiemens", "zS", Attosiemens, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctosiemens. Defined in terms of a(n) zeptosiemens.
    /// </summary>
    public static readonly ElectricalConductance Yoctosiemens = new ("yoctosiemens", "yS", Zeptosiemens, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontosiemens. Defined in terms of a(n) yoctosiemens.
    /// </summary>
    public static readonly ElectricalConductance Rontosiemens = new ("rontosiemens", "rS", Yoctosiemens, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectosiemens. Defined in terms of a(n) rontosiemens.
    /// </summary>
    public static readonly ElectricalConductance Quectosiemens = new ("quectosiemens", "qS", Rontosiemens, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekasiemens. Defined in terms of a(n) siemens.
    /// </summary>
    public static readonly ElectricalConductance Dekasiemens = new ("dekasiemens", "daS", Siemens, 10,0);

    /// <summary>
    /// A(n) hectosiemens. Defined in terms of a(n) dekasiemens.
    /// </summary>
    public static readonly ElectricalConductance Hectosiemens = new ("hectosiemens", "hS", Dekasiemens, 10,0);

    /// <summary>
    /// A(n) kilosiemens. Defined in terms of a(n) hectosiemens.
    /// </summary>
    public static readonly ElectricalConductance Kilosiemens = new ("kilosiemens", "kS", Hectosiemens, 10,0);

    /// <summary>
    /// A(n) megasiemens. Defined in terms of a(n) kilosiemens.
    /// </summary>
    public static readonly ElectricalConductance Megasiemens = new ("megasiemens", "MS", Kilosiemens, 1000,0);

    /// <summary>
    /// A(n) gigasiemens. Defined in terms of a(n) megasiemens.
    /// </summary>
    public static readonly ElectricalConductance Gigasiemens = new ("gigasiemens", "GS", Megasiemens, 1000,0);

    /// <summary>
    /// A(n) terasiemens. Defined in terms of a(n) gigasiemens.
    /// </summary>
    public static readonly ElectricalConductance Terasiemens = new ("terasiemens", "TS", Gigasiemens, 1000,0);

    /// <summary>
    /// A(n) petasiemens. Defined in terms of a(n) terasiemens.
    /// </summary>
    public static readonly ElectricalConductance Petasiemens = new ("petasiemens", "PS", Terasiemens, 1000,0);

    /// <summary>
    /// A(n) exasiemens. Defined in terms of a(n) petasiemens.
    /// </summary>
    public static readonly ElectricalConductance Exasiemens = new ("exasiemens", "ES", Petasiemens, 1000,0);

    /// <summary>
    /// A(n) zettasiemens. Defined in terms of a(n) exasiemens.
    /// </summary>
    public static readonly ElectricalConductance Zettasiemens = new ("zettasiemens", "ZS", Exasiemens, 1000,0);

    /// <summary>
    /// A(n) yottasiemens. Defined in terms of a(n) zettasiemens.
    /// </summary>
    public static readonly ElectricalConductance Yottasiemens = new ("yottasiemens", "YS", Zettasiemens, 1000,0);

    /// <summary>
    /// A(n) ronnasiemens. Defined in terms of a(n) yottasiemens.
    /// </summary>
    public static readonly ElectricalConductance Ronnasiemens = new ("ronnasiemens", "RS", Yottasiemens, 1000,0);

    /// <summary>
    /// A(n) quettasiemens. Defined in terms of a(n) ronnasiemens.
    /// </summary>
    public static readonly ElectricalConductance Quettasiemens = new ("quettasiemens", "QS", Ronnasiemens, 1000,0);

}