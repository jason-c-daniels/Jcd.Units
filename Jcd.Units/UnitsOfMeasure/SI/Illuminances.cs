﻿using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Illuminance.
/// </summary>
public class Illuminances : Enumeration<Illuminances,Illuminance>
{


    /// <summary>
    /// A(n) lux.
    /// </summary>
    public static readonly Illuminance Lux = new ("lux", "lx");
    /// <summary>
    /// A(n) decilux. It's defined in terms of a(n) lux.
    /// </summary>
    public static readonly Illuminance Decilux = new ("decilux", "dlx", Lux, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centilux. It's defined in terms of a(n) decilux.
    /// </summary>
    public static readonly Illuminance Centilux = new ("centilux", "clx", Decilux, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) millilux. It's defined in terms of a(n) centilux.
    /// </summary>
    public static readonly Illuminance Millilux = new ("millilux", "mlx", Centilux, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) microlux. It's defined in terms of a(n) millilux.
    /// </summary>
    public static readonly Illuminance Microlux = new ("microlux", "μlx", Millilux, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanolux. It's defined in terms of a(n) microlux.
    /// </summary>
    public static readonly Illuminance Nanolux = new ("nanolux", "nlx", Microlux, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) picolux. It's defined in terms of a(n) nanolux.
    /// </summary>
    public static readonly Illuminance Picolux = new ("picolux", "plx", Nanolux, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtolux. It's defined in terms of a(n) picolux.
    /// </summary>
    public static readonly Illuminance Femtolux = new ("femtolux", "flx", Picolux, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attolux. It's defined in terms of a(n) femtolux.
    /// </summary>
    public static readonly Illuminance Attolux = new ("attolux", "alx", Femtolux, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptolux. It's defined in terms of a(n) attolux.
    /// </summary>
    public static readonly Illuminance Zeptolux = new ("zeptolux", "zlx", Attolux, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctolux. It's defined in terms of a(n) zeptolux.
    /// </summary>
    public static readonly Illuminance Yoctolux = new ("yoctolux", "ylx", Zeptolux, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontolux. It's defined in terms of a(n) yoctolux.
    /// </summary>
    public static readonly Illuminance Rontolux = new ("rontolux", "rlx", Yoctolux, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectolux. It's defined in terms of a(n) rontolux.
    /// </summary>
    public static readonly Illuminance Quectolux = new ("quectolux", "qlx", Rontolux, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekalux. It's defined in terms of a(n) lux.
    /// </summary>
    public static readonly Illuminance Dekalux = new ("dekalux", "dalx", Lux, 10,0);
    
    /// <summary>
    /// A(n) hectolux. It's defined in terms of a(n) dekalux.
    /// </summary>
    public static readonly Illuminance Hectolux = new ("hectolux", "hlx", Dekalux, 10,0);
    
    /// <summary>
    /// A(n) kilolux. It's defined in terms of a(n) hectolux.
    /// </summary>
    public static readonly Illuminance Kilolux = new ("kilolux", "klx", Hectolux, 10,0);
    
    /// <summary>
    /// A(n) megalux. It's defined in terms of a(n) kilolux.
    /// </summary>
    public static readonly Illuminance Megalux = new ("megalux", "Mlx", Kilolux, 1000,0);
    
    /// <summary>
    /// A(n) gigalux. It's defined in terms of a(n) megalux.
    /// </summary>
    public static readonly Illuminance Gigalux = new ("gigalux", "Glx", Megalux, 1000,0);
    
    /// <summary>
    /// A(n) teralux. It's defined in terms of a(n) gigalux.
    /// </summary>
    public static readonly Illuminance Teralux = new ("teralux", "Tlx", Gigalux, 1000,0);
    
    /// <summary>
    /// A(n) petalux. It's defined in terms of a(n) teralux.
    /// </summary>
    public static readonly Illuminance Petalux = new ("petalux", "Plx", Teralux, 1000,0);
    
    /// <summary>
    /// A(n) exalux. It's defined in terms of a(n) petalux.
    /// </summary>
    public static readonly Illuminance Exalux = new ("exalux", "Elx", Petalux, 1000,0);
    
    /// <summary>
    /// A(n) zettalux. It's defined in terms of a(n) exalux.
    /// </summary>
    public static readonly Illuminance Zettalux = new ("zettalux", "Zlx", Exalux, 1000,0);
    
    /// <summary>
    /// A(n) yottalux. It's defined in terms of a(n) zettalux.
    /// </summary>
    public static readonly Illuminance Yottalux = new ("yottalux", "Ylx", Zettalux, 1000,0);
    
    /// <summary>
    /// A(n) ronnalux. It's defined in terms of a(n) yottalux.
    /// </summary>
    public static readonly Illuminance Ronnalux = new ("ronnalux", "Rlx", Yottalux, 1000,0);
    
    /// <summary>
    /// A(n) quettalux. It's defined in terms of a(n) ronnalux.
    /// </summary>
    public static readonly Illuminance Quettalux = new ("quettalux", "Qlx", Ronnalux, 1000,0);

}