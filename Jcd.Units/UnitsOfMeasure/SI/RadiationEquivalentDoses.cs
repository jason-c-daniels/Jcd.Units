using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Radiation Equivalent Dose.
/// </summary>
public class RadiationEquivalentDoses : Enumeration<RadiationEquivalentDoses,RadiationEquivalentDose>
{

    /// <summary>
    /// Units of a sievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Sievert = new ("sievert", "sv");
    /// <summary>
    /// Units of a decisievert. It's defined in terms of a(n) SI sievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Decisievert = new ("decisievert", "dsv", Sievert, 1.0/10.0,0);
    /// <summary>
    /// Units of a centisievert. It's defined in terms of a(n) SI decisievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Centisievert = new ("centisievert", "csv", Decisievert, 1.0/10.0,0);
    /// <summary>
    /// Units of a millisievert. It's defined in terms of a(n) SI centisievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Millisievert = new ("millisievert", "msv", Centisievert, 1.0/10.0,0);
    /// <summary>
    /// Units of a microsievert. It's defined in terms of a(n) SI millisievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Microsievert = new ("microsievert", "μsv", Millisievert, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanosievert. It's defined in terms of a(n) SI microsievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Nanosievert = new ("nanosievert", "nsv", Microsievert, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picosievert. It's defined in terms of a(n) SI nanosievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Picosievert = new ("picosievert", "psv", Nanosievert, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtosievert. It's defined in terms of a(n) SI picosievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Femtosievert = new ("femtosievert", "fsv", Picosievert, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attosievert. It's defined in terms of a(n) SI femtosievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Attosievert = new ("attosievert", "asv", Femtosievert, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptosievert. It's defined in terms of a(n) SI attosievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Zeptosievert = new ("zeptosievert", "zsv", Attosievert, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctosievert. It's defined in terms of a(n) SI zeptosievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Yoctosievert = new ("yoctosievert", "ysv", Zeptosievert, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontosievert. It's defined in terms of a(n) SI yoctosievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Rontosievert = new ("rontosievert", "rsv", Yoctosievert, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectosievert. It's defined in terms of a(n) SI rontosievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Quectosievert = new ("quectosievert", "qsv", Rontosievert, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekasievert. It's defined in terms of a(n) SI sievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Dekasievert = new ("dekasievert", "dasv", Sievert, 10,0);
    /// <summary>
    /// Units of a hectosievert. It's defined in terms of a(n) SI dekasievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Hectosievert = new ("hectosievert", "hsv", Dekasievert, 10,0);
    /// <summary>
    /// Units of a kilosievert. It's defined in terms of a(n) SI hectosievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Kilosievert = new ("kilosievert", "ksv", Hectosievert, 10,0);
    /// <summary>
    /// Units of a megasievert. It's defined in terms of a(n) SI kilosievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Megasievert = new ("megasievert", "Msv", Kilosievert, 1000,0);
    /// <summary>
    /// Units of a gigasievert. It's defined in terms of a(n) SI megasievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Gigasievert = new ("gigasievert", "Gsv", Megasievert, 1000,0);
    /// <summary>
    /// Units of a terasievert. It's defined in terms of a(n) SI gigasievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Terasievert = new ("terasievert", "Tsv", Gigasievert, 1000,0);
    /// <summary>
    /// Units of a petasievert. It's defined in terms of a(n) SI terasievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Petasievert = new ("petasievert", "Psv", Terasievert, 1000,0);
    /// <summary>
    /// Units of a exasievert. It's defined in terms of a(n) SI petasievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Exasievert = new ("exasievert", "Esv", Petasievert, 1000,0);
    /// <summary>
    /// Units of a zettasievert. It's defined in terms of a(n) SI exasievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Zettasievert = new ("zettasievert", "Zsv", Exasievert, 1000,0);
    /// <summary>
    /// Units of a yottasievert. It's defined in terms of a(n) SI zettasievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Yottasievert = new ("yottasievert", "Ysv", Zettasievert, 1000,0);
    /// <summary>
    /// Units of a ronnasievert. It's defined in terms of a(n) SI yottasievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Ronnasievert = new ("ronnasievert", "Rsv", Yottasievert, 1000,0);
    /// <summary>
    /// Units of a quettasievert. It's defined in terms of a(n) SI ronnasievert.
    /// </summary>
    public static readonly RadiationEquivalentDose Quettasievert = new ("quettasievert", "Qsv", Ronnasievert, 1000,0);

}