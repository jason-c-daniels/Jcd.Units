using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Radiation Equivalent Dose.
/// </summary>
public class RadiationEquivalentDoses : Enumeration<RadiationEquivalentDoses,RadiationEquivalentDose>
{
    public static readonly RadiationEquivalentDose Sievert = new ("sievert", "sv");
    public static readonly RadiationEquivalentDose Decisievert = new ("decisievert", "dsv", Sievert, 1.0/10.0,0);
    public static readonly RadiationEquivalentDose Centisievert = new ("centisievert", "csv", Decisievert, 1.0/10.0,0);
    public static readonly RadiationEquivalentDose Millisievert = new ("millisievert", "msv", Centisievert, 1.0/10.0,0);
    public static readonly RadiationEquivalentDose Microsievert = new ("microsievert", "μsv", Millisievert, 1.0/1000.0,0);
    public static readonly RadiationEquivalentDose Nanosievert = new ("nanosievert", "nsv", Microsievert, 1.0/1000.0,0);
    public static readonly RadiationEquivalentDose Picosievert = new ("picosievert", "psv", Nanosievert, 1.0/1000.0,0);
    public static readonly RadiationEquivalentDose Femtosievert = new ("femtosievert", "fsv", Picosievert, 1.0/1000.0,0);
    public static readonly RadiationEquivalentDose Attosievert = new ("attosievert", "asv", Femtosievert, 1.0/1000.0,0);
    public static readonly RadiationEquivalentDose Zeptosievert = new ("zeptosievert", "zsv", Attosievert, 1.0/1000.0,0);
    public static readonly RadiationEquivalentDose Yoctosievert = new ("yoctosievert", "ysv", Zeptosievert, 1.0/1000.0,0);
    public static readonly RadiationEquivalentDose Rontosievert = new ("rontosievert", "rsv", Yoctosievert, 1.0/1000.0,0);
    public static readonly RadiationEquivalentDose Quectosievert = new ("quectosievert", "qsv", Rontosievert, 1.0/1000.0,0);
    public static readonly RadiationEquivalentDose Dekasievert = new ("dekasievert", "dasv", Sievert, 10,0);
    public static readonly RadiationEquivalentDose Hectosievert = new ("hectosievert", "hsv", Dekasievert, 10,0);
    public static readonly RadiationEquivalentDose Kilosievert = new ("kilosievert", "ksv", Hectosievert, 10,0);
    public static readonly RadiationEquivalentDose Megasievert = new ("megasievert", "Msv", Kilosievert, 1000,0);
    public static readonly RadiationEquivalentDose Gigasievert = new ("gigasievert", "Gsv", Megasievert, 1000,0);
    public static readonly RadiationEquivalentDose Terasievert = new ("terasievert", "Tsv", Gigasievert, 1000,0);
    public static readonly RadiationEquivalentDose Petasievert = new ("petasievert", "Psv", Terasievert, 1000,0);
    public static readonly RadiationEquivalentDose Exasievert = new ("exasievert", "Esv", Petasievert, 1000,0);
    public static readonly RadiationEquivalentDose Zettasievert = new ("zettasievert", "Zsv", Exasievert, 1000,0);
    public static readonly RadiationEquivalentDose Yottasievert = new ("yottasievert", "Ysv", Zettasievert, 1000,0);
    public static readonly RadiationEquivalentDose Ronnasievert = new ("ronnasievert", "Rsv", Yottasievert, 1000,0);
    public static readonly RadiationEquivalentDose Quettasievert = new ("quettasievert", "Qsv", Ronnasievert, 1000,0);
}