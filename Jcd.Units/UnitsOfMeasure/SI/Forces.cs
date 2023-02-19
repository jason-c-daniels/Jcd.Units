﻿using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Force.
/// </summary>
public class Forces : Enumeration<Forces,Force>
{


    /// <summary>
    /// A(n) newton.
    /// </summary>
    public static readonly Force Newton = new ("newton", "N");
    /// <summary>
    /// A(n) decinewton. It's defined in terms of a(n) newton.
    /// </summary>
    public static readonly Force Decinewton = new ("decinewton", "dN", Newton, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centinewton. It's defined in terms of a(n) decinewton.
    /// </summary>
    public static readonly Force Centinewton = new ("centinewton", "cN", Decinewton, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) millinewton. It's defined in terms of a(n) centinewton.
    /// </summary>
    public static readonly Force Millinewton = new ("millinewton", "mN", Centinewton, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) micronewton. It's defined in terms of a(n) millinewton.
    /// </summary>
    public static readonly Force Micronewton = new ("micronewton", "μN", Millinewton, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanonewton. It's defined in terms of a(n) micronewton.
    /// </summary>
    public static readonly Force Nanonewton = new ("nanonewton", "nN", Micronewton, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) piconewton. It's defined in terms of a(n) nanonewton.
    /// </summary>
    public static readonly Force Piconewton = new ("piconewton", "pN", Nanonewton, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtonewton. It's defined in terms of a(n) piconewton.
    /// </summary>
    public static readonly Force Femtonewton = new ("femtonewton", "fN", Piconewton, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attonewton. It's defined in terms of a(n) femtonewton.
    /// </summary>
    public static readonly Force Attonewton = new ("attonewton", "aN", Femtonewton, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptonewton. It's defined in terms of a(n) attonewton.
    /// </summary>
    public static readonly Force Zeptonewton = new ("zeptonewton", "zN", Attonewton, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctonewton. It's defined in terms of a(n) zeptonewton.
    /// </summary>
    public static readonly Force Yoctonewton = new ("yoctonewton", "yN", Zeptonewton, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontonewton. It's defined in terms of a(n) yoctonewton.
    /// </summary>
    public static readonly Force Rontonewton = new ("rontonewton", "rN", Yoctonewton, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectonewton. It's defined in terms of a(n) rontonewton.
    /// </summary>
    public static readonly Force Quectonewton = new ("quectonewton", "qN", Rontonewton, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekanewton. It's defined in terms of a(n) newton.
    /// </summary>
    public static readonly Force Dekanewton = new ("dekanewton", "daN", Newton, 10,0);
    
    /// <summary>
    /// A(n) hectonewton. It's defined in terms of a(n) dekanewton.
    /// </summary>
    public static readonly Force Hectonewton = new ("hectonewton", "hN", Dekanewton, 10,0);
    
    /// <summary>
    /// A(n) kilonewton. It's defined in terms of a(n) hectonewton.
    /// </summary>
    public static readonly Force Kilonewton = new ("kilonewton", "kN", Hectonewton, 10,0);
    
    /// <summary>
    /// A(n) meganewton. It's defined in terms of a(n) kilonewton.
    /// </summary>
    public static readonly Force Meganewton = new ("meganewton", "MN", Kilonewton, 1000,0);
    
    /// <summary>
    /// A(n) giganewton. It's defined in terms of a(n) meganewton.
    /// </summary>
    public static readonly Force Giganewton = new ("giganewton", "GN", Meganewton, 1000,0);
    
    /// <summary>
    /// A(n) teranewton. It's defined in terms of a(n) giganewton.
    /// </summary>
    public static readonly Force Teranewton = new ("teranewton", "TN", Giganewton, 1000,0);
    
    /// <summary>
    /// A(n) petanewton. It's defined in terms of a(n) teranewton.
    /// </summary>
    public static readonly Force Petanewton = new ("petanewton", "PN", Teranewton, 1000,0);
    
    /// <summary>
    /// A(n) exanewton. It's defined in terms of a(n) petanewton.
    /// </summary>
    public static readonly Force Exanewton = new ("exanewton", "EN", Petanewton, 1000,0);
    
    /// <summary>
    /// A(n) zettanewton. It's defined in terms of a(n) exanewton.
    /// </summary>
    public static readonly Force Zettanewton = new ("zettanewton", "ZN", Exanewton, 1000,0);
    
    /// <summary>
    /// A(n) yottanewton. It's defined in terms of a(n) zettanewton.
    /// </summary>
    public static readonly Force Yottanewton = new ("yottanewton", "YN", Zettanewton, 1000,0);
    
    /// <summary>
    /// A(n) ronnanewton. It's defined in terms of a(n) yottanewton.
    /// </summary>
    public static readonly Force Ronnanewton = new ("ronnanewton", "RN", Yottanewton, 1000,0);
    
    /// <summary>
    /// A(n) quettanewton. It's defined in terms of a(n) ronnanewton.
    /// </summary>
    public static readonly Force Quettanewton = new ("quettanewton", "QN", Ronnanewton, 1000,0);

}