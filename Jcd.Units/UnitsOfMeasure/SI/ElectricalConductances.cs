using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Conductance.
/// </summary>
public class ElectricalConductances : Enumeration<ElectricalConductances,ElectricalConductance>
{
    public static readonly ElectricalConductance Siemens = new ("siemens", "S");
    public static readonly ElectricalConductance Decisiemens = new ("decisiemens", "dS", Siemens, 1.0/10.0,0);
    public static readonly ElectricalConductance Centisiemens = new ("centisiemens", "cS", Decisiemens, 1.0/10.0,0);
    public static readonly ElectricalConductance Millisiemens = new ("millisiemens", "mS", Centisiemens, 1.0/10.0,0);
    public static readonly ElectricalConductance Microsiemens = new ("microsiemens", "μS", Millisiemens, 1.0/1000.0,0);
    public static readonly ElectricalConductance Nanosiemens = new ("nanosiemens", "nS", Microsiemens, 1.0/1000.0,0);
    public static readonly ElectricalConductance Picosiemens = new ("picosiemens", "pS", Nanosiemens, 1.0/1000.0,0);
    public static readonly ElectricalConductance Femtosiemens = new ("femtosiemens", "fS", Picosiemens, 1.0/1000.0,0);
    public static readonly ElectricalConductance Attosiemens = new ("attosiemens", "aS", Femtosiemens, 1.0/1000.0,0);
    public static readonly ElectricalConductance Zeptosiemens = new ("zeptosiemens", "zS", Attosiemens, 1.0/1000.0,0);
    public static readonly ElectricalConductance Yoctosiemens = new ("yoctosiemens", "yS", Zeptosiemens, 1.0/1000.0,0);
    public static readonly ElectricalConductance Rontosiemens = new ("rontosiemens", "rS", Yoctosiemens, 1.0/1000.0,0);
    public static readonly ElectricalConductance Quectosiemens = new ("quectosiemens", "qS", Rontosiemens, 1.0/1000.0,0);
    public static readonly ElectricalConductance Dekasiemens = new ("dekasiemens", "daS", Siemens, 10,0);
    public static readonly ElectricalConductance Hectosiemens = new ("hectosiemens", "hS", Dekasiemens, 10,0);
    public static readonly ElectricalConductance Kilosiemens = new ("kilosiemens", "kS", Hectosiemens, 10,0);
    public static readonly ElectricalConductance Megasiemens = new ("megasiemens", "MS", Kilosiemens, 1000,0);
    public static readonly ElectricalConductance Gigasiemens = new ("gigasiemens", "GS", Megasiemens, 1000,0);
    public static readonly ElectricalConductance Terasiemens = new ("terasiemens", "TS", Gigasiemens, 1000,0);
    public static readonly ElectricalConductance Petasiemens = new ("petasiemens", "PS", Terasiemens, 1000,0);
    public static readonly ElectricalConductance Exasiemens = new ("exasiemens", "ES", Petasiemens, 1000,0);
    public static readonly ElectricalConductance Zettasiemens = new ("zettasiemens", "ZS", Exasiemens, 1000,0);
    public static readonly ElectricalConductance Yottasiemens = new ("yottasiemens", "YS", Zettasiemens, 1000,0);
    public static readonly ElectricalConductance Ronnasiemens = new ("ronnasiemens", "RS", Yottasiemens, 1000,0);
    public static readonly ElectricalConductance Quettasiemens = new ("quettasiemens", "QS", Ronnasiemens, 1000,0);
}