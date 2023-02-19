using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Energy.
/// </summary>
public class Energies : Enumeration<Energies,Energy>
{

    /// <summary>
    /// Units of a joule.
    /// </summary>
    public static readonly Energy Joule = new ("joule", "J");
    /// <summary>
    /// Units of a decijoule. It's defined in terms of a(n) SI joule.
    /// </summary>
    public static readonly Energy Decijoule = new ("decijoule", "dJ", Joule, 1.0/10.0,0);
    /// <summary>
    /// Units of a centijoule. It's defined in terms of a(n) SI decijoule.
    /// </summary>
    public static readonly Energy Centijoule = new ("centijoule", "cJ", Decijoule, 1.0/10.0,0);
    /// <summary>
    /// Units of a millijoule. It's defined in terms of a(n) SI centijoule.
    /// </summary>
    public static readonly Energy Millijoule = new ("millijoule", "mJ", Centijoule, 1.0/10.0,0);
    /// <summary>
    /// Units of a microjoule. It's defined in terms of a(n) SI millijoule.
    /// </summary>
    public static readonly Energy Microjoule = new ("microjoule", "μJ", Millijoule, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanojoule. It's defined in terms of a(n) SI microjoule.
    /// </summary>
    public static readonly Energy Nanojoule = new ("nanojoule", "nJ", Microjoule, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picojoule. It's defined in terms of a(n) SI nanojoule.
    /// </summary>
    public static readonly Energy Picojoule = new ("picojoule", "pJ", Nanojoule, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtojoule. It's defined in terms of a(n) SI picojoule.
    /// </summary>
    public static readonly Energy Femtojoule = new ("femtojoule", "fJ", Picojoule, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attojoule. It's defined in terms of a(n) SI femtojoule.
    /// </summary>
    public static readonly Energy Attojoule = new ("attojoule", "aJ", Femtojoule, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptojoule. It's defined in terms of a(n) SI attojoule.
    /// </summary>
    public static readonly Energy Zeptojoule = new ("zeptojoule", "zJ", Attojoule, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctojoule. It's defined in terms of a(n) SI zeptojoule.
    /// </summary>
    public static readonly Energy Yoctojoule = new ("yoctojoule", "yJ", Zeptojoule, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontojoule. It's defined in terms of a(n) SI yoctojoule.
    /// </summary>
    public static readonly Energy Rontojoule = new ("rontojoule", "rJ", Yoctojoule, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectojoule. It's defined in terms of a(n) SI rontojoule.
    /// </summary>
    public static readonly Energy Quectojoule = new ("quectojoule", "qJ", Rontojoule, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekajoule. It's defined in terms of a(n) SI joule.
    /// </summary>
    public static readonly Energy Dekajoule = new ("dekajoule", "daJ", Joule, 10,0);
    /// <summary>
    /// Units of a hectojoule. It's defined in terms of a(n) SI dekajoule.
    /// </summary>
    public static readonly Energy Hectojoule = new ("hectojoule", "hJ", Dekajoule, 10,0);
    /// <summary>
    /// Units of a kilojoule. It's defined in terms of a(n) SI hectojoule.
    /// </summary>
    public static readonly Energy Kilojoule = new ("kilojoule", "kJ", Hectojoule, 10,0);
    /// <summary>
    /// Units of a megajoule. It's defined in terms of a(n) SI kilojoule.
    /// </summary>
    public static readonly Energy Megajoule = new ("megajoule", "MJ", Kilojoule, 1000,0);
    /// <summary>
    /// Units of a gigajoule. It's defined in terms of a(n) SI megajoule.
    /// </summary>
    public static readonly Energy Gigajoule = new ("gigajoule", "GJ", Megajoule, 1000,0);
    /// <summary>
    /// Units of a terajoule. It's defined in terms of a(n) SI gigajoule.
    /// </summary>
    public static readonly Energy Terajoule = new ("terajoule", "TJ", Gigajoule, 1000,0);
    /// <summary>
    /// Units of a petajoule. It's defined in terms of a(n) SI terajoule.
    /// </summary>
    public static readonly Energy Petajoule = new ("petajoule", "PJ", Terajoule, 1000,0);
    /// <summary>
    /// Units of a exajoule. It's defined in terms of a(n) SI petajoule.
    /// </summary>
    public static readonly Energy Exajoule = new ("exajoule", "EJ", Petajoule, 1000,0);
    /// <summary>
    /// Units of a zettajoule. It's defined in terms of a(n) SI exajoule.
    /// </summary>
    public static readonly Energy Zettajoule = new ("zettajoule", "ZJ", Exajoule, 1000,0);
    /// <summary>
    /// Units of a yottajoule. It's defined in terms of a(n) SI zettajoule.
    /// </summary>
    public static readonly Energy Yottajoule = new ("yottajoule", "YJ", Zettajoule, 1000,0);
    /// <summary>
    /// Units of a ronnajoule. It's defined in terms of a(n) SI yottajoule.
    /// </summary>
    public static readonly Energy Ronnajoule = new ("ronnajoule", "RJ", Yottajoule, 1000,0);
    /// <summary>
    /// Units of a quettajoule. It's defined in terms of a(n) SI ronnajoule.
    /// </summary>
    public static readonly Energy Quettajoule = new ("quettajoule", "QJ", Ronnajoule, 1000,0);
    /// <summary>
    /// Units of a calorie. It's defined in terms of a(n) SI joule.
    /// </summary>
    public static readonly Energy Calorie = new ("calorie", "c", Joule, 4.184,0);
    /// <summary>
    /// Units of a decicalorie. It's defined in terms of a(n) SI calorie.
    /// </summary>
    public static readonly Energy Decicalorie = new ("decicalorie", "dc", Calorie, 1.0/10.0,0);
    /// <summary>
    /// Units of a centicalorie. It's defined in terms of a(n) SI decicalorie.
    /// </summary>
    public static readonly Energy Centicalorie = new ("centicalorie", "cc", Decicalorie, 1.0/10.0,0);
    /// <summary>
    /// Units of a millicalorie. It's defined in terms of a(n) SI centicalorie.
    /// </summary>
    public static readonly Energy Millicalorie = new ("millicalorie", "mc", Centicalorie, 1.0/10.0,0);
    /// <summary>
    /// Units of a microcalorie. It's defined in terms of a(n) SI millicalorie.
    /// </summary>
    public static readonly Energy Microcalorie = new ("microcalorie", "μc", Millicalorie, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanocalorie. It's defined in terms of a(n) SI microcalorie.
    /// </summary>
    public static readonly Energy Nanocalorie = new ("nanocalorie", "nc", Microcalorie, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picocalorie. It's defined in terms of a(n) SI nanocalorie.
    /// </summary>
    public static readonly Energy Picocalorie = new ("picocalorie", "pc", Nanocalorie, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtocalorie. It's defined in terms of a(n) SI picocalorie.
    /// </summary>
    public static readonly Energy Femtocalorie = new ("femtocalorie", "fc", Picocalorie, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attocalorie. It's defined in terms of a(n) SI femtocalorie.
    /// </summary>
    public static readonly Energy Attocalorie = new ("attocalorie", "ac", Femtocalorie, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptocalorie. It's defined in terms of a(n) SI attocalorie.
    /// </summary>
    public static readonly Energy Zeptocalorie = new ("zeptocalorie", "zc", Attocalorie, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctocalorie. It's defined in terms of a(n) SI zeptocalorie.
    /// </summary>
    public static readonly Energy Yoctocalorie = new ("yoctocalorie", "yc", Zeptocalorie, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontocalorie. It's defined in terms of a(n) SI yoctocalorie.
    /// </summary>
    public static readonly Energy Rontocalorie = new ("rontocalorie", "rc", Yoctocalorie, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectocalorie. It's defined in terms of a(n) SI rontocalorie.
    /// </summary>
    public static readonly Energy Quectocalorie = new ("quectocalorie", "qc", Rontocalorie, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekacalorie. It's defined in terms of a(n) SI calorie.
    /// </summary>
    public static readonly Energy Dekacalorie = new ("dekacalorie", "dac", Calorie, 10,0);
    /// <summary>
    /// Units of a hectocalorie. It's defined in terms of a(n) SI dekacalorie.
    /// </summary>
    public static readonly Energy Hectocalorie = new ("hectocalorie", "hc", Dekacalorie, 10,0);
    /// <summary>
    /// Units of a kilocalorie. It's defined in terms of a(n) SI hectocalorie.
    /// </summary>
    public static readonly Energy Kilocalorie = new ("kilocalorie", "kc", Hectocalorie, 10,0);
    /// <summary>
    /// Units of a megacalorie. It's defined in terms of a(n) SI kilocalorie.
    /// </summary>
    public static readonly Energy Megacalorie = new ("megacalorie", "Mc", Kilocalorie, 1000,0);
    /// <summary>
    /// Units of a gigacalorie. It's defined in terms of a(n) SI megacalorie.
    /// </summary>
    public static readonly Energy Gigacalorie = new ("gigacalorie", "Gc", Megacalorie, 1000,0);
    /// <summary>
    /// Units of a teracalorie. It's defined in terms of a(n) SI gigacalorie.
    /// </summary>
    public static readonly Energy Teracalorie = new ("teracalorie", "Tc", Gigacalorie, 1000,0);
    /// <summary>
    /// Units of a petacalorie. It's defined in terms of a(n) SI teracalorie.
    /// </summary>
    public static readonly Energy Petacalorie = new ("petacalorie", "Pc", Teracalorie, 1000,0);
    /// <summary>
    /// Units of a exacalorie. It's defined in terms of a(n) SI petacalorie.
    /// </summary>
    public static readonly Energy Exacalorie = new ("exacalorie", "Ec", Petacalorie, 1000,0);
    /// <summary>
    /// Units of a zettacalorie. It's defined in terms of a(n) SI exacalorie.
    /// </summary>
    public static readonly Energy Zettacalorie = new ("zettacalorie", "Zc", Exacalorie, 1000,0);
    /// <summary>
    /// Units of a yottacalorie. It's defined in terms of a(n) SI zettacalorie.
    /// </summary>
    public static readonly Energy Yottacalorie = new ("yottacalorie", "Yc", Zettacalorie, 1000,0);
    /// <summary>
    /// Units of a ronnacalorie. It's defined in terms of a(n) SI yottacalorie.
    /// </summary>
    public static readonly Energy Ronnacalorie = new ("ronnacalorie", "Rc", Yottacalorie, 1000,0);
    /// <summary>
    /// Units of a quettacalorie. It's defined in terms of a(n) SI ronnacalorie.
    /// </summary>
    public static readonly Energy Quettacalorie = new ("quettacalorie", "Qc", Ronnacalorie, 1000,0);
    /// <summary>
    /// Units of a Calorie (Food). It's defined in terms of a(n) SI calorie.
    /// </summary>
    public static readonly Energy CalorieFood = new ("Calorie (Food)", "C", Calorie, 1000,0);

}