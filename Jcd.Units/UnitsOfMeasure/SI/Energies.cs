using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

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
}