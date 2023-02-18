using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Force.
/// </summary>
public class Forces : Enumeration<Forces,Force>
{
    public static readonly Force Newton = new ("newton", "N");
    public static readonly Force Decinewton = new ("decinewton", "dN", Newton, 1.0/10.0,0);
    public static readonly Force Centinewton = new ("centinewton", "cN", Decinewton, 1.0/10.0,0);
    public static readonly Force Millinewton = new ("millinewton", "mN", Centinewton, 1.0/10.0,0);
    public static readonly Force Micronewton = new ("micronewton", "μN", Millinewton, 1.0/1000.0,0);
    public static readonly Force Nanonewton = new ("nanonewton", "nN", Micronewton, 1.0/1000.0,0);
    public static readonly Force Piconewton = new ("piconewton", "pN", Nanonewton, 1.0/1000.0,0);
    public static readonly Force Femtonewton = new ("femtonewton", "fN", Piconewton, 1.0/1000.0,0);
    public static readonly Force Attonewton = new ("attonewton", "aN", Femtonewton, 1.0/1000.0,0);
    public static readonly Force Zeptonewton = new ("zeptonewton", "zN", Attonewton, 1.0/1000.0,0);
    public static readonly Force Yoctonewton = new ("yoctonewton", "yN", Zeptonewton, 1.0/1000.0,0);
    public static readonly Force Rontonewton = new ("rontonewton", "rN", Yoctonewton, 1.0/1000.0,0);
    public static readonly Force Quectonewton = new ("quectonewton", "qN", Rontonewton, 1.0/1000.0,0);
    public static readonly Force Dekanewton = new ("dekanewton", "daN", Newton, 10,0);
    public static readonly Force Hectonewton = new ("hectonewton", "hN", Dekanewton, 10,0);
    public static readonly Force Kilonewton = new ("kilonewton", "kN", Hectonewton, 10,0);
    public static readonly Force Meganewton = new ("meganewton", "MN", Kilonewton, 1000,0);
    public static readonly Force Giganewton = new ("giganewton", "GN", Meganewton, 1000,0);
    public static readonly Force Teranewton = new ("teranewton", "TN", Giganewton, 1000,0);
    public static readonly Force Petanewton = new ("petanewton", "PN", Teranewton, 1000,0);
    public static readonly Force Exanewton = new ("exanewton", "EN", Petanewton, 1000,0);
    public static readonly Force Zettanewton = new ("zettanewton", "ZN", Exanewton, 1000,0);
    public static readonly Force Yottanewton = new ("yottanewton", "YN", Zettanewton, 1000,0);
    public static readonly Force Ronnanewton = new ("ronnanewton", "RN", Yottanewton, 1000,0);
    public static readonly Force Quettanewton = new ("quettanewton", "QN", Ronnanewton, 1000,0);
}