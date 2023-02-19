using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Momentum.
/// </summary>
public class Momentums : Enumeration<Momentums,Momentum>
{


    /// <summary>
    /// A(n) newton-second.
    /// </summary>
    public static readonly Momentum NewtonSecond = new ("newton-second", "N⋅s");
    /// <summary>
    /// A(n) decinewton-second. It's defined in terms of a(n) newton-second.
    /// </summary>
    public static readonly Momentum DecinewtonSecond = new ("decinewton-second", "dN⋅s", NewtonSecond, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centinewton-second. It's defined in terms of a(n) decinewton-second.
    /// </summary>
    public static readonly Momentum CentinewtonSecond = new ("centinewton-second", "cN⋅s", DecinewtonSecond, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) millinewton-second. It's defined in terms of a(n) centinewton-second.
    /// </summary>
    public static readonly Momentum MillinewtonSecond = new ("millinewton-second", "mN⋅s", CentinewtonSecond, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) micronewton-second. It's defined in terms of a(n) millinewton-second.
    /// </summary>
    public static readonly Momentum MicronewtonSecond = new ("micronewton-second", "μN⋅s", MillinewtonSecond, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanonewton-second. It's defined in terms of a(n) micronewton-second.
    /// </summary>
    public static readonly Momentum NanonewtonSecond = new ("nanonewton-second", "nN⋅s", MicronewtonSecond, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) piconewton-second. It's defined in terms of a(n) nanonewton-second.
    /// </summary>
    public static readonly Momentum PiconewtonSecond = new ("piconewton-second", "pN⋅s", NanonewtonSecond, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtonewton-second. It's defined in terms of a(n) piconewton-second.
    /// </summary>
    public static readonly Momentum FemtonewtonSecond = new ("femtonewton-second", "fN⋅s", PiconewtonSecond, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attonewton-second. It's defined in terms of a(n) femtonewton-second.
    /// </summary>
    public static readonly Momentum AttonewtonSecond = new ("attonewton-second", "aN⋅s", FemtonewtonSecond, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptonewton-second. It's defined in terms of a(n) attonewton-second.
    /// </summary>
    public static readonly Momentum ZeptonewtonSecond = new ("zeptonewton-second", "zN⋅s", AttonewtonSecond, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctonewton-second. It's defined in terms of a(n) zeptonewton-second.
    /// </summary>
    public static readonly Momentum YoctonewtonSecond = new ("yoctonewton-second", "yN⋅s", ZeptonewtonSecond, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontonewton-second. It's defined in terms of a(n) yoctonewton-second.
    /// </summary>
    public static readonly Momentum RontonewtonSecond = new ("rontonewton-second", "rN⋅s", YoctonewtonSecond, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectonewton-second. It's defined in terms of a(n) rontonewton-second.
    /// </summary>
    public static readonly Momentum QuectonewtonSecond = new ("quectonewton-second", "qN⋅s", RontonewtonSecond, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekanewton-second. It's defined in terms of a(n) newton-second.
    /// </summary>
    public static readonly Momentum DekanewtonSecond = new ("dekanewton-second", "daN⋅s", NewtonSecond, 10,0);
    
    /// <summary>
    /// A(n) hectonewton-second. It's defined in terms of a(n) dekanewton-second.
    /// </summary>
    public static readonly Momentum HectonewtonSecond = new ("hectonewton-second", "hN⋅s", DekanewtonSecond, 10,0);
    
    /// <summary>
    /// A(n) kilonewton-second. It's defined in terms of a(n) hectonewton-second.
    /// </summary>
    public static readonly Momentum KilonewtonSecond = new ("kilonewton-second", "kN⋅s", HectonewtonSecond, 10,0);
    
    /// <summary>
    /// A(n) meganewton-second. It's defined in terms of a(n) kilonewton-second.
    /// </summary>
    public static readonly Momentum MeganewtonSecond = new ("meganewton-second", "MN⋅s", KilonewtonSecond, 1000,0);
    
    /// <summary>
    /// A(n) giganewton-second. It's defined in terms of a(n) meganewton-second.
    /// </summary>
    public static readonly Momentum GiganewtonSecond = new ("giganewton-second", "GN⋅s", MeganewtonSecond, 1000,0);
    
    /// <summary>
    /// A(n) teranewton-second. It's defined in terms of a(n) giganewton-second.
    /// </summary>
    public static readonly Momentum TeranewtonSecond = new ("teranewton-second", "TN⋅s", GiganewtonSecond, 1000,0);
    
    /// <summary>
    /// A(n) petanewton-second. It's defined in terms of a(n) teranewton-second.
    /// </summary>
    public static readonly Momentum PetanewtonSecond = new ("petanewton-second", "PN⋅s", TeranewtonSecond, 1000,0);
    
    /// <summary>
    /// A(n) exanewton-second. It's defined in terms of a(n) petanewton-second.
    /// </summary>
    public static readonly Momentum ExanewtonSecond = new ("exanewton-second", "EN⋅s", PetanewtonSecond, 1000,0);
    
    /// <summary>
    /// A(n) zettanewton-second. It's defined in terms of a(n) exanewton-second.
    /// </summary>
    public static readonly Momentum ZettanewtonSecond = new ("zettanewton-second", "ZN⋅s", ExanewtonSecond, 1000,0);
    
    /// <summary>
    /// A(n) yottanewton-second. It's defined in terms of a(n) zettanewton-second.
    /// </summary>
    public static readonly Momentum YottanewtonSecond = new ("yottanewton-second", "YN⋅s", ZettanewtonSecond, 1000,0);
    
    /// <summary>
    /// A(n) ronnanewton-second. It's defined in terms of a(n) yottanewton-second.
    /// </summary>
    public static readonly Momentum RonnanewtonSecond = new ("ronnanewton-second", "RN⋅s", YottanewtonSecond, 1000,0);
    
    /// <summary>
    /// A(n) quettanewton-second. It's defined in terms of a(n) ronnanewton-second.
    /// </summary>
    public static readonly Momentum QuettanewtonSecond = new ("quettanewton-second", "QN⋅s", RonnanewtonSecond, 1000,0);

}