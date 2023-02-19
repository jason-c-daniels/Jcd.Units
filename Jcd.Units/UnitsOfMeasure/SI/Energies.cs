using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Energy.
/// </summary>
public class Energies : Enumeration<Energies,Energy>
{


    /// <summary>
    /// A(n) joule.
    /// </summary>
    public static readonly Energy Joule = new ("joule", "J");
    /// <summary>
    /// A(n) decijoule. Defined in terms of a(n) joule.
    /// </summary>
    public static readonly Energy Decijoule = new ("decijoule", "dJ", Joule, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centijoule. Defined in terms of a(n) decijoule.
    /// </summary>
    public static readonly Energy Centijoule = new ("centijoule", "cJ", Decijoule, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) millijoule. Defined in terms of a(n) centijoule.
    /// </summary>
    public static readonly Energy Millijoule = new ("millijoule", "mJ", Centijoule, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) microjoule. Defined in terms of a(n) millijoule.
    /// </summary>
    public static readonly Energy Microjoule = new ("microjoule", "μJ", Millijoule, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanojoule. Defined in terms of a(n) microjoule.
    /// </summary>
    public static readonly Energy Nanojoule = new ("nanojoule", "nJ", Microjoule, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) picojoule. Defined in terms of a(n) nanojoule.
    /// </summary>
    public static readonly Energy Picojoule = new ("picojoule", "pJ", Nanojoule, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtojoule. Defined in terms of a(n) picojoule.
    /// </summary>
    public static readonly Energy Femtojoule = new ("femtojoule", "fJ", Picojoule, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attojoule. Defined in terms of a(n) femtojoule.
    /// </summary>
    public static readonly Energy Attojoule = new ("attojoule", "aJ", Femtojoule, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptojoule. Defined in terms of a(n) attojoule.
    /// </summary>
    public static readonly Energy Zeptojoule = new ("zeptojoule", "zJ", Attojoule, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctojoule. Defined in terms of a(n) zeptojoule.
    /// </summary>
    public static readonly Energy Yoctojoule = new ("yoctojoule", "yJ", Zeptojoule, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontojoule. Defined in terms of a(n) yoctojoule.
    /// </summary>
    public static readonly Energy Rontojoule = new ("rontojoule", "rJ", Yoctojoule, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectojoule. Defined in terms of a(n) rontojoule.
    /// </summary>
    public static readonly Energy Quectojoule = new ("quectojoule", "qJ", Rontojoule, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekajoule. Defined in terms of a(n) joule.
    /// </summary>
    public static readonly Energy Dekajoule = new ("dekajoule", "daJ", Joule, 10,0);
    
    /// <summary>
    /// A(n) hectojoule. Defined in terms of a(n) dekajoule.
    /// </summary>
    public static readonly Energy Hectojoule = new ("hectojoule", "hJ", Dekajoule, 10,0);
    
    /// <summary>
    /// A(n) kilojoule. Defined in terms of a(n) hectojoule.
    /// </summary>
    public static readonly Energy Kilojoule = new ("kilojoule", "kJ", Hectojoule, 10,0);
    
    /// <summary>
    /// A(n) megajoule. Defined in terms of a(n) kilojoule.
    /// </summary>
    public static readonly Energy Megajoule = new ("megajoule", "MJ", Kilojoule, 1000,0);
    
    /// <summary>
    /// A(n) gigajoule. Defined in terms of a(n) megajoule.
    /// </summary>
    public static readonly Energy Gigajoule = new ("gigajoule", "GJ", Megajoule, 1000,0);
    
    /// <summary>
    /// A(n) terajoule. Defined in terms of a(n) gigajoule.
    /// </summary>
    public static readonly Energy Terajoule = new ("terajoule", "TJ", Gigajoule, 1000,0);
    
    /// <summary>
    /// A(n) petajoule. Defined in terms of a(n) terajoule.
    /// </summary>
    public static readonly Energy Petajoule = new ("petajoule", "PJ", Terajoule, 1000,0);
    
    /// <summary>
    /// A(n) exajoule. Defined in terms of a(n) petajoule.
    /// </summary>
    public static readonly Energy Exajoule = new ("exajoule", "EJ", Petajoule, 1000,0);
    
    /// <summary>
    /// A(n) zettajoule. Defined in terms of a(n) exajoule.
    /// </summary>
    public static readonly Energy Zettajoule = new ("zettajoule", "ZJ", Exajoule, 1000,0);
    
    /// <summary>
    /// A(n) yottajoule. Defined in terms of a(n) zettajoule.
    /// </summary>
    public static readonly Energy Yottajoule = new ("yottajoule", "YJ", Zettajoule, 1000,0);
    
    /// <summary>
    /// A(n) ronnajoule. Defined in terms of a(n) yottajoule.
    /// </summary>
    public static readonly Energy Ronnajoule = new ("ronnajoule", "RJ", Yottajoule, 1000,0);
    
    /// <summary>
    /// A(n) quettajoule. Defined in terms of a(n) ronnajoule.
    /// </summary>
    public static readonly Energy Quettajoule = new ("quettajoule", "QJ", Ronnajoule, 1000,0);
    
    /// <summary>
    /// A(n) calorie. Defined in terms of a(n) joule.
    /// </summary>
    public static readonly Energy Calorie = new ("calorie", "c", Joule, 4.184,0);
    
    /// <summary>
    /// A(n) decicalorie. Defined in terms of a(n) calorie.
    /// </summary>
    public static readonly Energy Decicalorie = new ("decicalorie", "dc", Calorie, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centicalorie. Defined in terms of a(n) decicalorie.
    /// </summary>
    public static readonly Energy Centicalorie = new ("centicalorie", "cc", Decicalorie, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) millicalorie. Defined in terms of a(n) centicalorie.
    /// </summary>
    public static readonly Energy Millicalorie = new ("millicalorie", "mc", Centicalorie, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) microcalorie. Defined in terms of a(n) millicalorie.
    /// </summary>
    public static readonly Energy Microcalorie = new ("microcalorie", "μc", Millicalorie, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanocalorie. Defined in terms of a(n) microcalorie.
    /// </summary>
    public static readonly Energy Nanocalorie = new ("nanocalorie", "nc", Microcalorie, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) picocalorie. Defined in terms of a(n) nanocalorie.
    /// </summary>
    public static readonly Energy Picocalorie = new ("picocalorie", "pc", Nanocalorie, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtocalorie. Defined in terms of a(n) picocalorie.
    /// </summary>
    public static readonly Energy Femtocalorie = new ("femtocalorie", "fc", Picocalorie, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attocalorie. Defined in terms of a(n) femtocalorie.
    /// </summary>
    public static readonly Energy Attocalorie = new ("attocalorie", "ac", Femtocalorie, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptocalorie. Defined in terms of a(n) attocalorie.
    /// </summary>
    public static readonly Energy Zeptocalorie = new ("zeptocalorie", "zc", Attocalorie, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctocalorie. Defined in terms of a(n) zeptocalorie.
    /// </summary>
    public static readonly Energy Yoctocalorie = new ("yoctocalorie", "yc", Zeptocalorie, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontocalorie. Defined in terms of a(n) yoctocalorie.
    /// </summary>
    public static readonly Energy Rontocalorie = new ("rontocalorie", "rc", Yoctocalorie, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectocalorie. Defined in terms of a(n) rontocalorie.
    /// </summary>
    public static readonly Energy Quectocalorie = new ("quectocalorie", "qc", Rontocalorie, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekacalorie. Defined in terms of a(n) calorie.
    /// </summary>
    public static readonly Energy Dekacalorie = new ("dekacalorie", "dac", Calorie, 10,0);
    
    /// <summary>
    /// A(n) hectocalorie. Defined in terms of a(n) dekacalorie.
    /// </summary>
    public static readonly Energy Hectocalorie = new ("hectocalorie", "hc", Dekacalorie, 10,0);
    
    /// <summary>
    /// A(n) kilocalorie. Defined in terms of a(n) hectocalorie.
    /// </summary>
    public static readonly Energy Kilocalorie = new ("kilocalorie", "kc", Hectocalorie, 10,0);
    
    /// <summary>
    /// A(n) megacalorie. Defined in terms of a(n) kilocalorie.
    /// </summary>
    public static readonly Energy Megacalorie = new ("megacalorie", "Mc", Kilocalorie, 1000,0);
    
    /// <summary>
    /// A(n) gigacalorie. Defined in terms of a(n) megacalorie.
    /// </summary>
    public static readonly Energy Gigacalorie = new ("gigacalorie", "Gc", Megacalorie, 1000,0);
    
    /// <summary>
    /// A(n) teracalorie. Defined in terms of a(n) gigacalorie.
    /// </summary>
    public static readonly Energy Teracalorie = new ("teracalorie", "Tc", Gigacalorie, 1000,0);
    
    /// <summary>
    /// A(n) petacalorie. Defined in terms of a(n) teracalorie.
    /// </summary>
    public static readonly Energy Petacalorie = new ("petacalorie", "Pc", Teracalorie, 1000,0);
    
    /// <summary>
    /// A(n) exacalorie. Defined in terms of a(n) petacalorie.
    /// </summary>
    public static readonly Energy Exacalorie = new ("exacalorie", "Ec", Petacalorie, 1000,0);
    
    /// <summary>
    /// A(n) zettacalorie. Defined in terms of a(n) exacalorie.
    /// </summary>
    public static readonly Energy Zettacalorie = new ("zettacalorie", "Zc", Exacalorie, 1000,0);
    
    /// <summary>
    /// A(n) yottacalorie. Defined in terms of a(n) zettacalorie.
    /// </summary>
    public static readonly Energy Yottacalorie = new ("yottacalorie", "Yc", Zettacalorie, 1000,0);
    
    /// <summary>
    /// A(n) ronnacalorie. Defined in terms of a(n) yottacalorie.
    /// </summary>
    public static readonly Energy Ronnacalorie = new ("ronnacalorie", "Rc", Yottacalorie, 1000,0);
    
    /// <summary>
    /// A(n) quettacalorie. Defined in terms of a(n) ronnacalorie.
    /// </summary>
    public static readonly Energy Quettacalorie = new ("quettacalorie", "Qc", Ronnacalorie, 1000,0);
    
    /// <summary>
    /// A(n) Calorie (Food). Defined in terms of a(n) calorie.
    /// </summary>
    public static readonly Energy CalorieFood = new ("Calorie (Food)", "C", Calorie, 1000,0);

}