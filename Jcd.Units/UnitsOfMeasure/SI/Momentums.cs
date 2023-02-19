using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Momentum.
/// </summary>
public class Momentums : Enumeration<Momentums,Momentum>
{

    /// <summary>
    /// Units of a newton-second.
    /// </summary>
    public static readonly Momentum NewtonSecond = new ("newton-second", "N⋅s");
    /// <summary>
    /// Units of a decinewton-second. It's defined in terms of a(n) SI newton-second.
    /// </summary>
    public static readonly Momentum DecinewtonSecond = new ("decinewton-second", "dN⋅s", NewtonSecond, 1.0/10.0,0);
    /// <summary>
    /// Units of a centinewton-second. It's defined in terms of a(n) SI decinewton-second.
    /// </summary>
    public static readonly Momentum CentinewtonSecond = new ("centinewton-second", "cN⋅s", DecinewtonSecond, 1.0/10.0,0);
    /// <summary>
    /// Units of a millinewton-second. It's defined in terms of a(n) SI centinewton-second.
    /// </summary>
    public static readonly Momentum MillinewtonSecond = new ("millinewton-second", "mN⋅s", CentinewtonSecond, 1.0/10.0,0);
    /// <summary>
    /// Units of a micronewton-second. It's defined in terms of a(n) SI millinewton-second.
    /// </summary>
    public static readonly Momentum MicronewtonSecond = new ("micronewton-second", "μN⋅s", MillinewtonSecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanonewton-second. It's defined in terms of a(n) SI micronewton-second.
    /// </summary>
    public static readonly Momentum NanonewtonSecond = new ("nanonewton-second", "nN⋅s", MicronewtonSecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a piconewton-second. It's defined in terms of a(n) SI nanonewton-second.
    /// </summary>
    public static readonly Momentum PiconewtonSecond = new ("piconewton-second", "pN⋅s", NanonewtonSecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtonewton-second. It's defined in terms of a(n) SI piconewton-second.
    /// </summary>
    public static readonly Momentum FemtonewtonSecond = new ("femtonewton-second", "fN⋅s", PiconewtonSecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attonewton-second. It's defined in terms of a(n) SI femtonewton-second.
    /// </summary>
    public static readonly Momentum AttonewtonSecond = new ("attonewton-second", "aN⋅s", FemtonewtonSecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptonewton-second. It's defined in terms of a(n) SI attonewton-second.
    /// </summary>
    public static readonly Momentum ZeptonewtonSecond = new ("zeptonewton-second", "zN⋅s", AttonewtonSecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctonewton-second. It's defined in terms of a(n) SI zeptonewton-second.
    /// </summary>
    public static readonly Momentum YoctonewtonSecond = new ("yoctonewton-second", "yN⋅s", ZeptonewtonSecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontonewton-second. It's defined in terms of a(n) SI yoctonewton-second.
    /// </summary>
    public static readonly Momentum RontonewtonSecond = new ("rontonewton-second", "rN⋅s", YoctonewtonSecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectonewton-second. It's defined in terms of a(n) SI rontonewton-second.
    /// </summary>
    public static readonly Momentum QuectonewtonSecond = new ("quectonewton-second", "qN⋅s", RontonewtonSecond, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekanewton-second. It's defined in terms of a(n) SI newton-second.
    /// </summary>
    public static readonly Momentum DekanewtonSecond = new ("dekanewton-second", "daN⋅s", NewtonSecond, 10,0);
    /// <summary>
    /// Units of a hectonewton-second. It's defined in terms of a(n) SI dekanewton-second.
    /// </summary>
    public static readonly Momentum HectonewtonSecond = new ("hectonewton-second", "hN⋅s", DekanewtonSecond, 10,0);
    /// <summary>
    /// Units of a kilonewton-second. It's defined in terms of a(n) SI hectonewton-second.
    /// </summary>
    public static readonly Momentum KilonewtonSecond = new ("kilonewton-second", "kN⋅s", HectonewtonSecond, 10,0);
    /// <summary>
    /// Units of a meganewton-second. It's defined in terms of a(n) SI kilonewton-second.
    /// </summary>
    public static readonly Momentum MeganewtonSecond = new ("meganewton-second", "MN⋅s", KilonewtonSecond, 1000,0);
    /// <summary>
    /// Units of a giganewton-second. It's defined in terms of a(n) SI meganewton-second.
    /// </summary>
    public static readonly Momentum GiganewtonSecond = new ("giganewton-second", "GN⋅s", MeganewtonSecond, 1000,0);
    /// <summary>
    /// Units of a teranewton-second. It's defined in terms of a(n) SI giganewton-second.
    /// </summary>
    public static readonly Momentum TeranewtonSecond = new ("teranewton-second", "TN⋅s", GiganewtonSecond, 1000,0);
    /// <summary>
    /// Units of a petanewton-second. It's defined in terms of a(n) SI teranewton-second.
    /// </summary>
    public static readonly Momentum PetanewtonSecond = new ("petanewton-second", "PN⋅s", TeranewtonSecond, 1000,0);
    /// <summary>
    /// Units of a exanewton-second. It's defined in terms of a(n) SI petanewton-second.
    /// </summary>
    public static readonly Momentum ExanewtonSecond = new ("exanewton-second", "EN⋅s", PetanewtonSecond, 1000,0);
    /// <summary>
    /// Units of a zettanewton-second. It's defined in terms of a(n) SI exanewton-second.
    /// </summary>
    public static readonly Momentum ZettanewtonSecond = new ("zettanewton-second", "ZN⋅s", ExanewtonSecond, 1000,0);
    /// <summary>
    /// Units of a yottanewton-second. It's defined in terms of a(n) SI zettanewton-second.
    /// </summary>
    public static readonly Momentum YottanewtonSecond = new ("yottanewton-second", "YN⋅s", ZettanewtonSecond, 1000,0);
    /// <summary>
    /// Units of a ronnanewton-second. It's defined in terms of a(n) SI yottanewton-second.
    /// </summary>
    public static readonly Momentum RonnanewtonSecond = new ("ronnanewton-second", "RN⋅s", YottanewtonSecond, 1000,0);
    /// <summary>
    /// Units of a quettanewton-second. It's defined in terms of a(n) SI ronnanewton-second.
    /// </summary>
    public static readonly Momentum QuettanewtonSecond = new ("quettanewton-second", "QN⋅s", RonnanewtonSecond, 1000,0);

}