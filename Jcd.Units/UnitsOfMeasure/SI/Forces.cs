using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Force.
/// </summary>
public class Forces : Enumeration<Forces,Force>
{

    /// <summary>
    /// Units of a newton.
    /// </summary>
    public static readonly Force Newton = new ("newton", "N");
    /// <summary>
    /// Units of a decinewton. It's defined in terms of a(n) SI newton.
    /// </summary>
    public static readonly Force Decinewton = new ("decinewton", "dN", Newton, 1.0/10.0,0);
    /// <summary>
    /// Units of a centinewton. It's defined in terms of a(n) SI decinewton.
    /// </summary>
    public static readonly Force Centinewton = new ("centinewton", "cN", Decinewton, 1.0/10.0,0);
    /// <summary>
    /// Units of a millinewton. It's defined in terms of a(n) SI centinewton.
    /// </summary>
    public static readonly Force Millinewton = new ("millinewton", "mN", Centinewton, 1.0/10.0,0);
    /// <summary>
    /// Units of a micronewton. It's defined in terms of a(n) SI millinewton.
    /// </summary>
    public static readonly Force Micronewton = new ("micronewton", "μN", Millinewton, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanonewton. It's defined in terms of a(n) SI micronewton.
    /// </summary>
    public static readonly Force Nanonewton = new ("nanonewton", "nN", Micronewton, 1.0/1000.0,0);
    /// <summary>
    /// Units of a piconewton. It's defined in terms of a(n) SI nanonewton.
    /// </summary>
    public static readonly Force Piconewton = new ("piconewton", "pN", Nanonewton, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtonewton. It's defined in terms of a(n) SI piconewton.
    /// </summary>
    public static readonly Force Femtonewton = new ("femtonewton", "fN", Piconewton, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attonewton. It's defined in terms of a(n) SI femtonewton.
    /// </summary>
    public static readonly Force Attonewton = new ("attonewton", "aN", Femtonewton, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptonewton. It's defined in terms of a(n) SI attonewton.
    /// </summary>
    public static readonly Force Zeptonewton = new ("zeptonewton", "zN", Attonewton, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctonewton. It's defined in terms of a(n) SI zeptonewton.
    /// </summary>
    public static readonly Force Yoctonewton = new ("yoctonewton", "yN", Zeptonewton, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontonewton. It's defined in terms of a(n) SI yoctonewton.
    /// </summary>
    public static readonly Force Rontonewton = new ("rontonewton", "rN", Yoctonewton, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectonewton. It's defined in terms of a(n) SI rontonewton.
    /// </summary>
    public static readonly Force Quectonewton = new ("quectonewton", "qN", Rontonewton, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekanewton. It's defined in terms of a(n) SI newton.
    /// </summary>
    public static readonly Force Dekanewton = new ("dekanewton", "daN", Newton, 10,0);
    /// <summary>
    /// Units of a hectonewton. It's defined in terms of a(n) SI dekanewton.
    /// </summary>
    public static readonly Force Hectonewton = new ("hectonewton", "hN", Dekanewton, 10,0);
    /// <summary>
    /// Units of a kilonewton. It's defined in terms of a(n) SI hectonewton.
    /// </summary>
    public static readonly Force Kilonewton = new ("kilonewton", "kN", Hectonewton, 10,0);
    /// <summary>
    /// Units of a meganewton. It's defined in terms of a(n) SI kilonewton.
    /// </summary>
    public static readonly Force Meganewton = new ("meganewton", "MN", Kilonewton, 1000,0);
    /// <summary>
    /// Units of a giganewton. It's defined in terms of a(n) SI meganewton.
    /// </summary>
    public static readonly Force Giganewton = new ("giganewton", "GN", Meganewton, 1000,0);
    /// <summary>
    /// Units of a teranewton. It's defined in terms of a(n) SI giganewton.
    /// </summary>
    public static readonly Force Teranewton = new ("teranewton", "TN", Giganewton, 1000,0);
    /// <summary>
    /// Units of a petanewton. It's defined in terms of a(n) SI teranewton.
    /// </summary>
    public static readonly Force Petanewton = new ("petanewton", "PN", Teranewton, 1000,0);
    /// <summary>
    /// Units of a exanewton. It's defined in terms of a(n) SI petanewton.
    /// </summary>
    public static readonly Force Exanewton = new ("exanewton", "EN", Petanewton, 1000,0);
    /// <summary>
    /// Units of a zettanewton. It's defined in terms of a(n) SI exanewton.
    /// </summary>
    public static readonly Force Zettanewton = new ("zettanewton", "ZN", Exanewton, 1000,0);
    /// <summary>
    /// Units of a yottanewton. It's defined in terms of a(n) SI zettanewton.
    /// </summary>
    public static readonly Force Yottanewton = new ("yottanewton", "YN", Zettanewton, 1000,0);
    /// <summary>
    /// Units of a ronnanewton. It's defined in terms of a(n) SI yottanewton.
    /// </summary>
    public static readonly Force Ronnanewton = new ("ronnanewton", "RN", Yottanewton, 1000,0);
    /// <summary>
    /// Units of a quettanewton. It's defined in terms of a(n) SI ronnanewton.
    /// </summary>
    public static readonly Force Quettanewton = new ("quettanewton", "QN", Ronnanewton, 1000,0);

}