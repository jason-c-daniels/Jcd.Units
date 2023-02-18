using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Energy.
/// </summary>
public class Energies : Enumeration<Energies,Energy>
{
    public static readonly Energy Joule = new ("joule", "J");
    public static readonly Energy Decijoule = new ("decijoule", "dJ", Joule, 1.0/10.0,0);
    public static readonly Energy Centijoule = new ("centijoule", "cJ", Decijoule, 1.0/10.0,0);
    public static readonly Energy Millijoule = new ("millijoule", "mJ", Centijoule, 1.0/10.0,0);
    public static readonly Energy Microjoule = new ("microjoule", "μJ", Millijoule, 1.0/1000.0,0);
    public static readonly Energy Nanojoule = new ("nanojoule", "nJ", Microjoule, 1.0/1000.0,0);
    public static readonly Energy Picojoule = new ("picojoule", "pJ", Nanojoule, 1.0/1000.0,0);
    public static readonly Energy Femtojoule = new ("femtojoule", "fJ", Picojoule, 1.0/1000.0,0);
    public static readonly Energy Attojoule = new ("attojoule", "aJ", Femtojoule, 1.0/1000.0,0);
    public static readonly Energy Zeptojoule = new ("zeptojoule", "zJ", Attojoule, 1.0/1000.0,0);
    public static readonly Energy Yoctojoule = new ("yoctojoule", "yJ", Zeptojoule, 1.0/1000.0,0);
    public static readonly Energy Rontojoule = new ("rontojoule", "rJ", Yoctojoule, 1.0/1000.0,0);
    public static readonly Energy Quectojoule = new ("quectojoule", "qJ", Rontojoule, 1.0/1000.0,0);
    public static readonly Energy Dekajoule = new ("dekajoule", "daJ", Joule, 10,0);
    public static readonly Energy Hectojoule = new ("hectojoule", "hJ", Dekajoule, 10,0);
    public static readonly Energy Kilojoule = new ("kilojoule", "kJ", Hectojoule, 10,0);
    public static readonly Energy Megajoule = new ("megajoule", "MJ", Kilojoule, 1000,0);
    public static readonly Energy Gigajoule = new ("gigajoule", "GJ", Megajoule, 1000,0);
    public static readonly Energy Terajoule = new ("terajoule", "TJ", Gigajoule, 1000,0);
    public static readonly Energy Petajoule = new ("petajoule", "PJ", Terajoule, 1000,0);
    public static readonly Energy Exajoule = new ("exajoule", "EJ", Petajoule, 1000,0);
    public static readonly Energy Zettajoule = new ("zettajoule", "ZJ", Exajoule, 1000,0);
    public static readonly Energy Yottajoule = new ("yottajoule", "YJ", Zettajoule, 1000,0);
    public static readonly Energy Ronnajoule = new ("ronnajoule", "RJ", Yottajoule, 1000,0);
    public static readonly Energy Quettajoule = new ("quettajoule", "QJ", Ronnajoule, 1000,0);
    public static readonly Energy Calorie = new ("calorie", "c", Joule, 4.184,0);
    public static readonly Energy Decicalorie = new ("decicalorie", "dc", Calorie, 1.0/10.0,0);
    public static readonly Energy Centicalorie = new ("centicalorie", "cc", Decicalorie, 1.0/10.0,0);
    public static readonly Energy Millicalorie = new ("millicalorie", "mc", Centicalorie, 1.0/10.0,0);
    public static readonly Energy Microcalorie = new ("microcalorie", "μc", Millicalorie, 1.0/1000.0,0);
    public static readonly Energy Nanocalorie = new ("nanocalorie", "nc", Microcalorie, 1.0/1000.0,0);
    public static readonly Energy Picocalorie = new ("picocalorie", "pc", Nanocalorie, 1.0/1000.0,0);
    public static readonly Energy Femtocalorie = new ("femtocalorie", "fc", Picocalorie, 1.0/1000.0,0);
    public static readonly Energy Attocalorie = new ("attocalorie", "ac", Femtocalorie, 1.0/1000.0,0);
    public static readonly Energy Zeptocalorie = new ("zeptocalorie", "zc", Attocalorie, 1.0/1000.0,0);
    public static readonly Energy Yoctocalorie = new ("yoctocalorie", "yc", Zeptocalorie, 1.0/1000.0,0);
    public static readonly Energy Rontocalorie = new ("rontocalorie", "rc", Yoctocalorie, 1.0/1000.0,0);
    public static readonly Energy Quectocalorie = new ("quectocalorie", "qc", Rontocalorie, 1.0/1000.0,0);
    public static readonly Energy Dekacalorie = new ("dekacalorie", "dac", Calorie, 10,0);
    public static readonly Energy Hectocalorie = new ("hectocalorie", "hc", Dekacalorie, 10,0);
    public static readonly Energy Kilocalorie = new ("kilocalorie", "kc", Hectocalorie, 10,0);
    public static readonly Energy Megacalorie = new ("megacalorie", "Mc", Kilocalorie, 1000,0);
    public static readonly Energy Gigacalorie = new ("gigacalorie", "Gc", Megacalorie, 1000,0);
    public static readonly Energy Teracalorie = new ("teracalorie", "Tc", Gigacalorie, 1000,0);
    public static readonly Energy Petacalorie = new ("petacalorie", "Pc", Teracalorie, 1000,0);
    public static readonly Energy Exacalorie = new ("exacalorie", "Ec", Petacalorie, 1000,0);
    public static readonly Energy Zettacalorie = new ("zettacalorie", "Zc", Exacalorie, 1000,0);
    public static readonly Energy Yottacalorie = new ("yottacalorie", "Yc", Zettacalorie, 1000,0);
    public static readonly Energy Ronnacalorie = new ("ronnacalorie", "Rc", Yottacalorie, 1000,0);
    public static readonly Energy Quettacalorie = new ("quettacalorie", "Qc", Ronnacalorie, 1000,0);
    public static readonly Energy CalorieFood = new ("Calorie (Food)", "C", Calorie, 1000,0);
}